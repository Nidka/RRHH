using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Permisos;
using Xunit;

namespace RRHH.Tests.Permisos;

[CollectionDefinition("Motivos PostgreSQL local", DisableParallelization = true)]
public sealed class MotivosPostgreSqlCollection { }

/// <summary>
/// Integración opt-in contra una BD desechable local. Nunca lee .env/Neon.
/// RRHH_TEST_POSTGRES_CONNECTION debe apuntar a localhost y rrhh_tec004_tests.
/// </summary>
[Collection("Motivos PostgreSQL local")]
public class MotivoPermisoPostgreSqlTests
{
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlMotivoPermisoRepository _repo;

    public MotivoPermisoPostgreSqlTests()
    {
        string connection = Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION");
        var config = new NpgsqlConnectionStringBuilder(connection);
        if ((config.Host != "127.0.0.1" && config.Host != "localhost") || config.Database != "rrhh_tec004_tests")
            throw new InvalidOperationException("Estas pruebas solo admiten la BD local desechable rrhh_tec004_tests.");
        _db = new PostgreSqlExecutor(new PostgreSqlConnectionFactory(connection));
        _repo = new PostgreSqlMotivoPermisoRepository(_db);
        _db.Execute("""
DROP TABLE IF EXISTS public."Permiso_Aud", public."Permiso", public."Motivo_Perm", public."TipoPermiso" CASCADE;
DROP SEQUENCE IF EXISTS public.tec004_sequence;
CREATE TABLE public."TipoPermiso" ("idTipoPermiso" integer NOT NULL, "DescripTipoPermiso" varchar(50));
CREATE TABLE public."Motivo_Perm" (
 "idMotivo" integer NOT NULL, "Descrip_Motivo" varchar(50), "Salario" boolean,
 "idTipoPermiso" integer, "Abrev" varchar(3), "TipoModalidad" varchar(1), "Activo" boolean);
CREATE TABLE public."Permiso" ("idMotivo" integer);
CREATE TABLE public."Permiso_Aud" ("idMotivo_Ant" integer, "idMotivo_Act" integer);
INSERT INTO public."TipoPermiso" VALUES (1, 'Tipo ficticio'), (2, 'Otro tipo ficticio');
""");
    }

    [PostgreSqlLocalFact]
    public void TablaVaciaInsertaYConsultaConCamposNulos()
    {
        int id = _repo.Insertar(Nuevo("Nuevo", "P"));
        Assert.Equal(1, id);
        MotivoPermiso motivo = _repo.Obtener(id);
        Assert.Equal("Nuevo", motivo.Descripcion);
        Assert.Null(motivo.Salario);
        Assert.Equal("P", motivo.Modalidad);
        Assert.True(motivo.Activo);
    }

    [PostgreSqlLocalFact]
    public void FiltroNoOcultaInactivosYRespetaTipoModalidad()
    {
        _db.Execute("""
INSERT INTO public."Motivo_Perm" VALUES
(1, 'P inactivo', null, 1, null, 'P', false),
(2, 'C activo', true, 1, 'C', 'C', true),
(3, 'Sin modalidad', null, 1, null, null, null),
(4, 'Otro tipo', false, 2, null, 'P', true);
""");
        Assert.Single(_repo.Listar(1, "P"));
        Assert.Single(_repo.Listar(1, "C"));
        Assert.Equal(3, _repo.Listar(1, null).Count);
        Assert.False(_repo.Listar(1, "P")[0].Activo);
        Assert.Equal("Tipo ficticio", _repo.Listar(1, "P")[0].DescripcionTipo);
    }

    [PostgreSqlLocalFact]
    public void ActualizarConservaEstadoModalidadYTipoInclusoSiEstadoCambio()
    {
        int id = _repo.Insertar(Nuevo("Anterior", "C"));
        MotivoPermiso cargado = _repo.Obtener(id);
        _db.Execute("UPDATE public.\"Motivo_Perm\" SET \"Activo\"=false WHERE \"idMotivo\"=@id;",
            new PostgreSqlParameterValue("id", id));
        Assert.True(_repo.Actualizar(cargado.Editar("Editado", "E", null)));
        MotivoPermiso despues = _repo.Obtener(id);
        Assert.False(despues.Activo);
        Assert.Equal("C", despues.Modalidad);
        Assert.Equal(1, despues.TipoPermisoId);
        Assert.Equal("Editado", despues.Descripcion);
    }

    [PostgreSqlLocalFact]
    public void CambioConcurrenteDeModalidadNoSeSobrescribe()
    {
        int id = _repo.Insertar(Nuevo("Anterior", "P"));
        MotivoPermiso cargado = _repo.Obtener(id);
        _db.Execute("UPDATE public.\"Motivo_Perm\" SET \"TipoModalidad\"='C' WHERE \"idMotivo\"=@id;",
            new PostgreSqlParameterValue("id", id));
        Assert.False(_repo.Actualizar(cargado.Editar("No debe guardarse", null, null)));
        Assert.Equal("Anterior", _repo.Obtener(id).Descripcion);
    }

    [PostgreSqlLocalFact]
    public void IdentidadNuevaDeTEC002SeUtilizaSinIDExplicito()
    {
        _db.Execute("ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);");
        Assert.Equal(100, _repo.Insertar(Nuevo("Identidad", "P")));
    }

    [PostgreSqlLocalFact]
    public void SecuenciaDefaultDeTEC002SeUtiliza()
    {
        _db.Execute("CREATE SEQUENCE public.tec004_sequence START 200; ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" SET DEFAULT nextval('public.tec004_sequence');");
        Assert.Equal(200, _repo.Insertar(Nuevo("Secuencia", "P")));
    }

    [PostgreSqlLocalFact]
    public void SecuenciaDesalineadaSinPKRevierteLaFilaDuplicada()
    {
        _db.Execute("""
INSERT INTO public."Motivo_Perm" ("idMotivo", "idTipoPermiso", "Descrip_Motivo") VALUES (1, 1, 'Anterior');
CREATE SEQUENCE public.tec004_sequence START 1;
ALTER TABLE public."Motivo_Perm" ALTER COLUMN "idMotivo" SET DEFAULT nextval('public.tec004_sequence');
""");
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(Nuevo("No guardar", "P")));
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\";"));
        Assert.Equal("Anterior", _repo.Obtener(1).Descripcion);
    }

    [PostgreSqlLocalFact]
    public void TipoDuplicadoComoEnDespliegueRechazaAltaSinEscribir()
    {
        _db.Execute("INSERT INTO public.\"TipoPermiso\" VALUES (1, 'Tipo repetido');");
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(Nuevo("No guardar", "P")));
        Assert.Empty(_repo.Listar(1, null));
    }

    [PostgreSqlLocalFact]
    public async Task AltasConcurrentesSinSecuenciaNoRepitenCodigo()
    {
        Task<int>[] tareas = Enumerable.Range(0, 8).Select(i => Task.Run(() =>
            _repo.Insertar(Nuevo("Motivo " + i, "P")))).ToArray();
        int[] ids = await Task.WhenAll(tareas);
        Assert.Equal(8, ids.Distinct().Count());
        Assert.Equal(8, _repo.Listar(1, "P").Count);
    }

    [PostgreSqlLocalFact]
    public void BorradoCompruebaPermisoYAmbosLadosDeAuditoria()
    {
        int id = _repo.Insertar(Nuevo("Referenciado", "P"));
        var parametro = new PostgreSqlParameterValue("id", id);
        foreach (string referencia in new[]
        {
            "INSERT INTO public.\"Permiso\" VALUES (@id);",
            "INSERT INTO public.\"Permiso_Aud\" VALUES (@id, null);",
            "INSERT INTO public.\"Permiso_Aud\" VALUES (null, @id);"
        })
        {
            _db.Execute("DELETE FROM public.\"Permiso\"; DELETE FROM public.\"Permiso_Aud\";");
            _db.Execute(referencia, parametro);
            Assert.Throws<RegistroEnUsoException>(() => _repo.Eliminar(id, "P"));
            Assert.NotNull(_repo.Obtener(id));
        }
    }

    [PostgreSqlLocalFact]
    public void BorradoFueraDeModalidadNoEliminaYOtroSinReferenciasSi()
    {
        int id = _repo.Insertar(Nuevo("Motivo", "P"));
        Assert.False(_repo.Eliminar(id, "C"));
        Assert.NotNull(_repo.Obtener(id));
        Assert.True(_repo.Eliminar(id, "P"));
        Assert.Null(_repo.Obtener(id));
    }

    [PostgreSqlLocalFact]
    public void DuplicadosDeIDSeDiagnosticanSinModificarFilas()
    {
        _db.Execute("INSERT INTO public.\"Motivo_Perm\" (\"idMotivo\",\"idTipoPermiso\") VALUES (8,1),(8,1);");
        Assert.Throws<ReglaNegocioException>(() => _repo.Obtener(8));
        Assert.Throws<ReglaNegocioException>(() => _repo.Eliminar(8, null));
        Assert.Equal(2, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\";"));
    }

    [PostgreSqlLocalFact]
    public void TipoInexistenteRevierteSinInsertar()
    {
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(MotivoPermiso.Nuevo(99, "Inválido", null, null, "P")));
        Assert.Empty(_repo.Listar(1, null));
    }

    [PostgreSqlLocalFact]
    public void DescripcionConSQLSeGuardaComoDato()
    {
        const string texto = "'; DROP TABLE Motivo_Perm; --";
        int id = _repo.Insertar(Nuevo(texto, "P"));
        Assert.Equal(texto, _repo.Obtener(id).Descripcion);
        Assert.Single(_repo.Listar(1, "P"));
    }

    [PostgreSqlLocalFact]
    public void MarcaAnualDeRF06UsaDefaultEnAltaYSeConservaAlEditar()
    {
        _db.Execute("ALTER TABLE public.\"Motivo_Perm\" ADD COLUMN \"UnaVezPorAnio\" boolean NOT NULL DEFAULT false;");
        int id=_repo.Insertar(Nuevo("Motivo ficticio anual","P"));
        Assert.False((bool)_db.Scalar("SELECT \"UnaVezPorAnio\" FROM public.\"Motivo_Perm\" WHERE \"idMotivo\"=@id;", new PostgreSqlParameterValue("id",id,System.Data.DbType.Int32)));
        _db.Execute("UPDATE public.\"Motivo_Perm\" SET \"UnaVezPorAnio\"=true;");
        Assert.True(_repo.Actualizar(_repo.Obtener(id).Editar("Descripción corregida","MC",true)));
        Assert.True(new RRHH.PostgreSql.Permisos.PostgreSqlPermisoRepository(_db).MotivoSeOtorgaUnaVezPorAnio(id));
        Assert.Equal("Descripción corregida",_repo.Obtener(id).Descripcion);
        Assert.True(_repo.Eliminar(id,"P"));
    }

    [PostgreSqlLocalFact]
    public void RF06SinMigracionDevuelveDiagnosticoSinEscribir()
    {
        var repo = new PostgreSqlPermisoRepository(_db);
        var validacion = new RRHH.Application.Permisos.ValidarLicenciaUnaVezPorAnio(repo)
            .Ejecutar(101, 900, new DateTime(2026, 3, 10));
        Assert.False(validacion.Exitoso);
        Assert.Contains("20261111_01_licencia_una_vez_anio.sql", validacion.Mensaje);
        Assert.Equal(0, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
        Assert.Equal(0, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\";"));
    }

    private void PrepararLicenciasAnuales(bool conGrupo)
    {
        _db.Execute("""
ALTER TABLE public."Motivo_Perm" ADD COLUMN "UnaVezPorAnio" boolean NOT NULL DEFAULT false;
ALTER TABLE public."Permiso" ADD COLUMN "IdEmpleado" integer;
ALTER TABLE public."Permiso" ADD COLUMN "NPermiso" integer;
ALTER TABLE public."Permiso" ADD COLUMN "FechaInicio" timestamp;
INSERT INTO public."Motivo_Perm" ("idMotivo", "Descrip_Motivo", "idTipoPermiso", "UnaVezPorAnio")
VALUES (900, 'Licencia piloto', 1, true), (901, 'Licencia alternativa piloto', 1, true),
       (902, 'Otra licencia piloto', 1, true);
INSERT INTO public."Permiso" ("idMotivo", "IdEmpleado", "NPermiso", "FechaInicio")
VALUES (900, 101, 1, '2026-03-10');
""");
        if (conGrupo)
            _db.Execute("""
ALTER TABLE public."Motivo_Perm" ADD COLUMN "GrupoReglaAnual" varchar(64);
UPDATE public."Motivo_Perm" SET "GrupoReglaAnual" = 'PILOTO-FAMILIAR' WHERE "idMotivo" IN (900,901);
UPDATE public."Motivo_Perm" SET "GrupoReglaAnual" = 'PILOTO-OTRA' WHERE "idMotivo" = 902;
""");
    }

    [PostgreSqlLocalFact]
    public void RF06GrupoImpideCambiarDeMotivoEnElMismoAnio()
    {
        PrepararLicenciasAnuales(true);
        var caso = new RRHH.Application.Permisos.ValidarLicenciaUnaVezPorAnio(new PostgreSqlPermisoRepository(_db));
        Assert.False(caso.Ejecutar(101, 901, new DateTime(2026, 9, 1)).Exitoso);
        Assert.True(caso.Ejecutar(101, 901, new DateTime(2027, 9, 1)).Exitoso);
        Assert.True(caso.Ejecutar(102, 901, new DateTime(2026, 9, 1)).Exitoso);
        Assert.True(caso.Ejecutar(101, 902, new DateTime(2026, 9, 1)).Exitoso);
        Assert.True(caso.Ejecutar(101, 900, new DateTime(2026, 9, 1), 1).Exitoso);
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
    }

    [PostgreSqlLocalFact]
    public void RF06SinColumnaGrupoConservaLaReglaIndividual()
    {
        PrepararLicenciasAnuales(false);
        var caso = new RRHH.Application.Permisos.ValidarLicenciaUnaVezPorAnio(new PostgreSqlPermisoRepository(_db));
        Assert.False(caso.Ejecutar(101, 900, new DateTime(2026, 9, 1)).Exitoso);
        Assert.True(caso.Ejecutar(101, 901, new DateTime(2026, 9, 1)).Exitoso);
    }

    [PostgreSqlLocalFact]
    public void RF06MotivoDuplicadoSeRechazaSinElegirUnaFila()
    {
        PrepararLicenciasAnuales(true);
        _db.Execute("INSERT INTO public.\"Motivo_Perm\" SELECT * FROM public.\"Motivo_Perm\" WHERE \"idMotivo\"=901;");
        var caso = new RRHH.Application.Permisos.ValidarLicenciaUnaVezPorAnio(new PostgreSqlPermisoRepository(_db));
        var resultado = caso.Ejecutar(101, 901, new DateTime(2026, 9, 1));
        Assert.False(resultado.Exitoso);
        Assert.Contains("duplicado", resultado.Mensaje);
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
    }

    [PostgreSqlLocalFact]
    public void DescripcionRepetidaMantieneElComportamientoActualConIdsDistintos()
    {
        int primero=_repo.Insertar(Nuevo("Motivo ficticio repetido","P"));
        int segundo=_repo.Insertar(Nuevo("Motivo ficticio repetido","P"));
        Assert.NotEqual(primero,segundo);
        Assert.Equal(2,_repo.Listar(1,"P").Count);
        // No se inventa una regla de unicidad por descripción: requiere acuerdo de negocio.
    }

    private static MotivoPermiso Nuevo(string descripcion, string modalidad) =>
        MotivoPermiso.Nuevo(1, descripcion, null, null, modalidad);

    [PostgreSqlLocalFact]
    public void RF03YRF06SoloEstadosOcupantesBloquean()
    {
        PrepararLicenciasAnuales(true);
        _db.Execute("""
ALTER TABLE public."Permiso" ADD COLUMN "FechaFin" timestamp;
ALTER TABLE public."Permiso" ADD COLUMN "EstadoSolicitud" varchar(10);
UPDATE public."Permiso" SET "FechaFin"='2026-03-12';
""");
        var repo = new PostgreSqlPermisoRepository(_db);
        var rango = RangoFechas.Crear(new DateTime(2026, 3, 9), new DateTime(2026, 3, 13));
        foreach (string estado in new[] { "Solicitado", "Aprobado", "Rechazado", "Anulado", "Otro" })
        {
            _db.Execute("UPDATE public.\"Permiso\" SET \"EstadoSolicitud\"=@estado;",
                new PostgreSqlParameterValue("estado", estado));
            bool ocupa = estado != "Rechazado" && estado != "Anulado";
            Assert.Equal(ocupa, repo.ExisteSolapamiento(101, rango, 0));
            Assert.Equal(ocupa, repo.ExistePermisoDelMotivoEnAnio(101, 901, 2026, 0));
            Assert.False(repo.ExisteSolapamiento(101, rango, 1));
        }
        _db.Execute("ALTER TABLE public.\"Permiso\" DROP COLUMN \"EstadoSolicitud\";");
        Assert.True(repo.ExisteSolapamiento(101, rango, 0));
        Assert.True(repo.ExistePermisoDelMotivoEnAnio(101, 901, 2026, 0));
    }

    [PostgreSqlLocalFact]
    public void MigracionEstadosEsIdempotenteYCompatibleConAutorizadoHeredado()
    {
        PrepararLicenciasAnuales(true);
        _db.Execute("ALTER TABLE public.\"Permiso\" ADD COLUMN \"Autorizado\" boolean;");
        string migracion = LeerMigracion("20261119_02_estados_permiso.sql");
        _db.Execute(migracion);
        Assert.Equal("Solicitado", EstadoActual());
        _db.Execute("UPDATE public.\"Permiso\" SET \"Autorizado\"=true;");
        Assert.Equal("Aprobado", EstadoActual());
        _db.Execute("UPDATE public.\"Permiso\" SET \"EstadoSolicitud\"='Anulado';");
        Assert.Equal(0, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\" WHERE \"Autorizado\";"));
        _db.Execute(migracion);
        Assert.Equal("Anulado", EstadoActual());
        var error = Assert.Throws<PostgresException>(() => _db.Execute(
            "UPDATE public.\"Permiso\" SET \"EstadoSolicitud\"='Invalido';"));
        Assert.Equal("23514", error.SqlState);
        Assert.Equal("Anulado", EstadoActual());
        Assert.Throws<PostgresException>(() => _db.Execute(LeerMigracion("20261119_02_estados_permiso.rollback.sql")));
        Assert.Equal("Anulado", EstadoActual());
        _db.Execute("UPDATE public.\"Permiso\" SET \"EstadoSolicitud\"='Solicitado';");
        _db.Execute(LeerMigracion("20261119_02_estados_permiso.rollback.sql"));
        Assert.Equal(0, _db.ScalarInt("SELECT COUNT(*) FROM information_schema.columns WHERE table_schema='public' AND table_name='Permiso' AND column_name='EstadoSolicitud';"));
    }

    private string EstadoActual() => (string)_db.Scalar("SELECT \"EstadoSolicitud\" FROM public.\"Permiso\";");

    private GuardarPermiso PrepararGuardado()
    {
        PrepararLicenciasAnuales(true);
        _db.Execute("""
DELETE FROM public."Permiso";
DROP TABLE IF EXISTS public."Empleado" CASCADE;
CREATE TABLE public."Empleado" ("IdEmpleado" integer);
DROP TABLE IF EXISTS public."RRHH_Feriado" CASCADE;
CREATE TABLE public."RRHH_Feriado" ("Fecha" timestamp);
INSERT INTO public."Empleado" VALUES (101),(102);
UPDATE public."Motivo_Perm" SET "Activo"=true;
ALTER TABLE public."Permiso" ADD COLUMN "FechaFin" timestamp;
ALTER TABLE public."Permiso" ADD COLUMN "Autorizado" boolean;
ALTER TABLE public."Permiso" ADD COLUMN "Lugar" varchar(20);
ALTER TABLE public."Permiso" ADD COLUMN "Referencia" varchar(100);
ALTER TABLE public."Permiso" ADD COLUMN "Autorizacion" varchar(50);
ALTER TABLE public."Permiso" ADD COLUMN "Obs" varchar(200);
ALTER TABLE public."Permiso" ADD COLUMN "Dia" boolean;
ALTER TABLE public."Permiso" ADD COLUMN "Retorno" boolean;
ALTER TABLE public."Permiso" ADD COLUMN "Hora_Sal" varchar(8);
ALTER TABLE public."Permiso" ADD COLUMN "Hora_Ret" varchar(8);
ALTER TABLE public."Permiso" ADD COLUMN "AutorizacionRRHH" varchar(50);
""");
        _db.Execute(LeerMigracion("20261119_02_estados_permiso.sql"));
        _db.Execute(LeerMigracion("20261119_03_vacaciones_piloto.sql"));
        return new GuardarPermiso(new PostgreSqlPermisoEscrituraRepository(_db));
    }

    private static PermisoGuardarDto Solicitud(int motivo = 900, int dia = 10) => new PermisoGuardarDto
    {
        IdEmpleado=101, IdMotivo=motivo, Desde=new DateTime(2026, 3, dia), Hasta=new DateTime(2026, 3, dia)
    };

    [PostgreSqlLocalFact]
    public void GuardadoPermisoConservaMarcacionesYLiberaCupoAlAnular()
    {
        var guardar = PrepararGuardado();
        var primera = Solicitud();
        Assert.True(guardar.Ejecutar(primera).Exitoso);
        Assert.Equal(1, primera.Numero);
        Assert.Equal("Solicitado", EstadoActual());
        var segunda = Solicitud(901, 20);
        Assert.False(guardar.Ejecutar(segunda).Exitoso);
        Assert.Equal(0, segunda.Numero);
        _db.Execute("UPDATE public.\"Permiso\" SET \"Hora_Sal\"='12:00:00', \"AutorizacionRRHH\"='Conservar';");
        primera.Estado="Anulado";
        Assert.True(guardar.Ejecutar(primera).Exitoso);
        Assert.Equal("12:00:00", _db.Scalar("SELECT \"Hora_Sal\" FROM public.\"Permiso\";"));
        Assert.Equal("Conservar", _db.Scalar("SELECT \"AutorizacionRRHH\" FROM public.\"Permiso\";"));
        Assert.True(guardar.Ejecutar(segunda).Exitoso);
        Assert.Equal(2, segunda.Numero);
        primera.Estado="Aprobado";
        Assert.False(guardar.Ejecutar(primera).Exitoso);
        Assert.Equal("Anulado", _db.Scalar("SELECT \"EstadoSolicitud\" FROM public.\"Permiso\" WHERE \"NPermiso\"=1;"));
        segunda.Observacion=new string('x',201);
        Assert.False(guardar.Ejecutar(segunda).Exitoso);
        Assert.Equal(2, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
    }

    [PostgreSqlLocalFact]
    public async Task GuardadoConcurrenteSerializaSolapamientoYCupoCompartido()
    {
        var guardar = PrepararGuardado();
        foreach (bool porFechas in new[] { true, false })
        {
            _db.Execute("DELETE FROM public.\"Permiso\";");
            // Motivos diferentes: las fechas coincidentes ejercitan RF-03; las
            // fechas distintas ejercitan RF-06 mediante el grupo compartido.
            var primera=Solicitud(900,10);
            var segunda=Solicitud(901,porFechas ? 10 : 20);
            var resultados=await Task.WhenAll(
                Task.Run(() => guardar.Ejecutar(primera)), Task.Run(() => guardar.Ejecutar(segunda)));
            Assert.Single(resultados, r => r.Exitoso);
            Assert.Single(resultados, r => !r.Exitoso);
            Assert.Equal(1,_db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
            Assert.Equal(1, primera.Numero + segunda.Numero);
        }
    }

    private static string LeerMigracion(string nombre)
    {
        var carpeta = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        while (carpeta != null)
        {
            string archivo = Path.Combine(carpeta.FullName, "BD", "migrations", nombre);
            if (File.Exists(archivo)) return File.ReadAllText(archivo);
            carpeta = carpeta.Parent;
        }
        throw new FileNotFoundException("Ejecutar las pruebas dentro del checkout que contiene BD/migrations.", nombre);
    }

    private RRHH.Application.Asistencia.ConsultarSaldoVacaciones PrepararSaldo()
    {
        PrepararGuardado();
        _db.Execute(LeerMigracion("20261119_03_vacaciones_piloto.sql"));
        _db.Execute(LeerMigracion("20261119_03_vacaciones_piloto.sql"));
        _db.Execute("""
ALTER TABLE public."Empleado" ADD COLUMN "FechaIngreso" timestamp;
UPDATE public."Empleado" SET "FechaIngreso"='2024-03-01';
UPDATE public."Motivo_Perm" SET "EsVacacionesPiloto"=true,"UnaVezPorAnio"=false,"GrupoReglaAnual"=NULL WHERE "idMotivo"=900;
INSERT INTO public."Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud","MediaJornadaVacaciones") VALUES
(101,1,900,'2026-05-01','2026-05-12','Aprobado',false),
(101,2,900,'2026-05-13','2026-05-13','Aprobado',true),
(101,3,900,'2026-06-01','2026-06-10','Solicitado',false),
(101,4,900,'2026-07-01','2026-07-10','Rechazado',false),
(101,5,900,'2026-08-01','2026-08-10','Anulado',false);
""");
        return new RRHH.Application.Asistencia.ConsultarSaldoVacaciones(
            new RRHH.PostgreSql.Asistencia.PostgreSqlSaldoVacacionesRepository(_db),new RRHH.Domain.Asistencia.RegimenVacacionesPiloto());
    }

    [PostgreSqlLocalFact]
    public void RF08SaldoConciliadoArrastraYAnulacionDevuelveDias()
    {
        var caso=PrepararSaldo();
        var saldo=caso.Ejecutar(101,new DateTime(2026,11,12));
        Assert.Equal(60m,saldo.Generadas);
        Assert.Equal(12.5m,saldo.Usadas);
        Assert.Equal(47.5m,saldo.Pendientes);
        Assert.Equal(2,saldo.Consumos.Count);
        _db.Execute("UPDATE public.\"Permiso\" SET \"EstadoSolicitud\"='Anulado' WHERE \"NPermiso\"=1;");
        Assert.Equal(59.5m,caso.Ejecutar(101,new DateTime(2026,11,12)).Pendientes);
        Assert.Equal(0m,caso.Ejecutar(101,new DateTime(2026,4,30)).Usadas);
    }

    [PostgreSqlLocalFact]
    public void RF08RechazaCatalogoAmbiguoEIngresoIncompleto()
    {
        var caso=PrepararSaldo();
        _db.Execute("UPDATE public.\"Empleado\" SET \"FechaIngreso\"=NULL WHERE \"IdEmpleado\"=101;");
        Assert.Throws<ReglaNegocioException>(() => caso.Ejecutar(101,new DateTime(2026,11,12)));
        _db.Execute("UPDATE public.\"Empleado\" SET \"FechaIngreso\"='2024-03-01'; INSERT INTO public.\"Motivo_Perm\" SELECT * FROM public.\"Motivo_Perm\" WHERE \"idMotivo\"=900;");
        Assert.Throws<ReglaNegocioException>(() => caso.Ejecutar(101,new DateTime(2026,11,12)));
    }

    [PostgreSqlLocalFact]
    public void RF10MediaJornadaRespetaCalendarioSaldoYAnulacion()
    {
        var saldo=PrepararSaldo();
        var guardar=new GuardarPermiso(new PostgreSqlPermisoEscrituraRepository(_db));
        var media=Solicitud();media.Desde=media.Hasta=new DateTime(2026,3,4);media.Estado="Aprobado";media.MediaJornadaVacaciones=true;
        Assert.True(guardar.Ejecutar(media).Exitoso);
        Assert.Equal(13m,saldo.Ejecutar(101,new DateTime(2026,11,12)).Usadas);
        var sabado=Solicitud();sabado.Desde=sabado.Hasta=new DateTime(2026,3,7);sabado.Estado="Aprobado";sabado.MediaJornadaVacaciones=true;
        Assert.False(guardar.Ejecutar(sabado).Exitoso);
        _db.Execute("INSERT INTO public.\"RRHH_Feriado\" VALUES ('2026-03-05');");
        sabado.Desde=sabado.Hasta=new DateTime(2026,3,5);
        Assert.False(guardar.Ejecutar(sabado).Exitoso);
        var excesiva=Solicitud();excesiva.Desde=new DateTime(2026,5,20);excesiva.Hasta=new DateTime(2026,7,20);excesiva.Estado="Aprobado";
        Assert.False(guardar.Ejecutar(excesiva).Exitoso);
        Assert.Equal(0,excesiva.Numero);
        // Un cambio posterior del calendario no puede impedir devolver el saldo.
        _db.Execute("INSERT INTO public.\"RRHH_Feriado\" VALUES ('2026-03-04');");
        media.Estado="Anulado";
        Assert.True(guardar.Ejecutar(media).Exitoso);
        Assert.Equal(12.5m,saldo.Ejecutar(101,new DateTime(2026,11,12)).Usadas);
    }

    [PostgreSqlLocalFact]
    public async Task RF10AprobacionesConcurrentesNoGastanDosVecesElSaldo()
    {
        var saldo=PrepararSaldo();
        _db.Execute("""
DELETE FROM public."Permiso";
INSERT INTO public."Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud","MediaJornadaVacaciones") VALUES
(101,1,900,'2026-03-01','2026-04-28','Aprobado',false),(101,2,900,'2026-04-29','2026-04-29','Aprobado',true);
""");
        Assert.Equal(59.5m,saldo.Ejecutar(101,new DateTime(2026,11,12)).Usadas);
        var a=Solicitud();a.Desde=a.Hasta=new DateTime(2026,5,4);a.Estado="Aprobado";a.MediaJornadaVacaciones=true;
        var b=Solicitud();b.Desde=b.Hasta=new DateTime(2026,5,5);b.Estado="Aprobado";b.MediaJornadaVacaciones=true;
        var guardar=new GuardarPermiso(new PostgreSqlPermisoEscrituraRepository(_db));
        var resultados=await Task.WhenAll(Task.Run(()=>guardar.Ejecutar(a)),Task.Run(()=>guardar.Ejecutar(b)));
        Assert.Single(resultados,r=>r.Exitoso);
        Assert.Equal(60m,saldo.Ejecutar(101,new DateTime(2026,11,12)).Usadas);
        Assert.Equal(3,_db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
    }

    [PostgreSqlLocalFact]
    public void RF11ReporteConciliaFiltrosYExponeDatosIncompletos()
    {
        PrepararSaldo();
        _db.Execute("""
ALTER TABLE public."Empleado" ADD COLUMN "Year" integer DEFAULT 2026;
ALTER TABLE public."Empleado" ADD COLUMN "idAreaOrganiz" integer;
UPDATE public."Empleado" SET "idAreaOrganiz"=CASE WHEN "IdEmpleado"=101 THEN 1 ELSE 2 END;
UPDATE public."Empleado" SET "FechaIngreso"=NULL WHERE "IdEmpleado"=102;
""");
        var caso=new RRHH.Application.Asistencia.ReportarSaldoVacaciones(new RRHH.PostgreSql.Asistencia.PostgreSqlReporteVacacionesRepository(_db),new RRHH.Domain.Asistencia.RegimenVacacionesPiloto());
        var filas=caso.Ejecutar(2026,new DateTime(2026,11,12));
        Assert.Equal(2,filas.Count);Assert.Equal(47.5m,filas[0].Pendientes);Assert.Equal(21m,filas[0].TruncasAlCorte);
        Assert.NotNull(filas[1].Error);Assert.Null(filas[1].Pendientes);
        Assert.Single(caso.Ejecutar(2026,new DateTime(2026,11,12),1,101));
        Assert.Single(caso.Ejecutar(2026,new DateTime(2026,11,12),2,null));
        Assert.Empty(caso.Ejecutar(2025,new DateTime(2025,11,12)));
        Assert.Throws<ReglaNegocioException>(()=>caso.Ejecutar(2025,new DateTime(2026,11,12)));
    }

    [PostgreSqlLocalFact]
    public void RF12IdentidadSoloConsultaSuEmpleadoYRechazaVinculosAmbiguos()
    {
        var saldos=PrepararSaldo();
        _db.Execute("""
DROP TABLE IF EXISTS public."Usuario" CASCADE;
CREATE TABLE public."Usuario" ("IdUsuario" integer,"IdEmpleado" integer,"Estado" boolean);
INSERT INTO public."Usuario" VALUES (4,101,true),(5,102,true),(6,NULL,true),(7,101,false);
""");
        var caso=new RRHH.Application.Asistencia.ConsultarMisVacaciones(new RRHH.PostgreSql.Seguridad.PostgreSqlUsuarioEmpleadoRepository(_db),saldos);
        Assert.Equal(101,caso.Ejecutar(4,new DateTime(2026,11,12)).Empleado);
        Assert.Equal(102,caso.Ejecutar(5,new DateTime(2026,11,12)).Empleado);
        Assert.Equal(0m,caso.Ejecutar(5,new DateTime(2026,11,12)).Usadas);
        Assert.Throws<ReglaNegocioException>(()=>caso.Ejecutar(6,new DateTime(2026,11,12)));
        Assert.Throws<ReglaNegocioException>(()=>caso.Ejecutar(7,new DateTime(2026,11,12)));
        _db.Execute("INSERT INTO public.\"Usuario\" VALUES (4,101,true);");
        Assert.Throws<ReglaNegocioException>(()=>caso.Ejecutar(4,new DateTime(2026,11,12)));
    }

    [PostgreSqlLocalFact]
    public void RF15TresFuentesSinDobleConteoRespetaFeriadosYPatron()
    {
        PrepararGuardado();
        _db.Execute("""
DROP TABLE IF EXISTS public."Asistencia",public."Teletrabajo" CASCADE;
CREATE TABLE public."Asistencia" ("IdEmpleado" integer,"Fecha" timestamp);
CREATE TABLE public."Teletrabajo" ("IdEmpleado" integer,"FechaInicio" date,"FechaFin" date,"Estado" boolean,"Modalidad" text,"DiasRemotos" integer);
INSERT INTO public."Asistencia" VALUES (101,'2026-11-18'),(101,'2026-11-18 16:00');
INSERT INTO public."Teletrabajo" VALUES (101,'2026-11-16','2026-11-20',true,'T',31);
INSERT INTO public."Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud") VALUES
(101,1,900,'2026-11-18','2026-11-18','Aprobado'),(101,2,900,'2026-11-19','2026-11-19','Rechazado');
""");
        var caso=new RRHH.Application.Asistencia.ConsolidarAsistencia(new RRHH.PostgreSql.Asistencia.PostgreSqlAsistenciaConsolidadaRepository(_db));
        var resultado=caso.Ejecutar(101,new DateTime(2026,11,16),new DateTime(2026,11,23));
        Assert.Equal(6,resultado.Laborables);Assert.Equal(1,resultado.Ausencias);Assert.Equal(0,resultado.Presenciales);
        Assert.Equal(4,resultado.Remotos);Assert.Equal(1,resultado.SinRegistro);Assert.Equal(1,resultado.Inconsistencias);
        var miercoles=resultado.Dias.Single(d=>d.Fecha==new DateTime(2026,11,18));
        Assert.True(miercoles.Ausencia && miercoles.Presencial && miercoles.Remoto && miercoles.Inconsistencia);
        Assert.Equal("Ausencia",miercoles.Categoria);
        _db.Execute("INSERT INTO public.\"RRHH_Feriado\" VALUES ('2026-11-17');");
        Assert.Equal(3,caso.Ejecutar(101,new DateTime(2026,11,16),new DateTime(2026,11,23)).Remotos);
        _db.Execute("UPDATE public.\"Teletrabajo\" SET \"Modalidad\"='P',\"DiasRemotos\"=1;");
        Assert.Equal(1,caso.Ejecutar(101,new DateTime(2026,11,16),new DateTime(2026,11,23)).Remotos);
    }

    [PostgreSqlLocalFact]
    public void RF03SalidaSeValidaDentroDelGuardadoYPermiteAnularHistorial()
    {
        PrepararGuardado();
        _db.Execute("""
UPDATE public."Motivo_Perm" SET "idTipoPermiso"=2,"UnaVezPorAnio"=false,"GrupoReglaAnual"=NULL WHERE "idMotivo"=900;
DROP TABLE IF EXISTS public."Asistencia" CASCADE;
CREATE TABLE public."Asistencia" ("IdEmpleado" integer,"Fecha" timestamp,"Hor_Sal" varchar(8));
""");
        var caso=new GuardarPermiso(new PostgreSqlPermisoEscrituraRepository(_db,true,30m,()=>new DateTime(2026,11,19)));
        var dto=Solicitud();dto.Desde=dto.Hasta=new DateTime(2026,11,19);
        Assert.False(caso.Ejecutar(dto).Exitoso);Assert.Equal(0,dto.Numero);
        _db.Execute("INSERT INTO public.\"Asistencia\" VALUES (101,'2026-11-19','00:00:00');");
        Assert.True(caso.Ejecutar(dto).Exitoso);
        dto.Estado="Anulado";Assert.True(caso.Ejecutar(dto).Exitoso);
        _db.Execute("INSERT INTO public.\"Asistencia\" VALUES (101,'2026-11-19','17:00:00');");
        dto.Numero=0;dto.Estado="Solicitado";
        var resultado=caso.Ejecutar(dto);Assert.False(resultado.Exitoso);Assert.Contains("salida registrada",resultado.Mensaje);
        Assert.Equal(1,_db.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\";"));
    }
}

public sealed class PostgreSqlLocalFactAttribute : FactAttribute
{
    public PostgreSqlLocalFactAttribute()
    {
        if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION")))
            Skip = "Requiere BD local desechable rrhh_tec004_tests; ver protocolo TEC-004.";
    }
}
