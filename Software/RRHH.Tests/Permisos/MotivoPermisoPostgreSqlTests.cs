using System;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RRHH.Application.Comun;
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

    private static MotivoPermiso Nuevo(string descripcion, string modalidad) =>
        MotivoPermiso.Nuevo(1, descripcion, null, null, modalidad);
}

public sealed class PostgreSqlLocalFactAttribute : FactAttribute
{
    public PostgreSqlLocalFactAttribute()
    {
        if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION")))
            Skip = "Requiere BD local desechable rrhh_tec004_tests; ver protocolo TEC-004.";
    }
}
