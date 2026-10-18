using System;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Asistencia;
using RRHH.Tests.Permisos;
using Xunit;

namespace RRHH.Tests.Asistencia;

[CollectionDefinition("Horarios PostgreSQL local", DisableParallelization = true)]
public sealed class HorariosPostgreSqlCollection { }

/// <summary>Integración opt-in destructiva solo en la BD desechable local usada por TEC-004; nunca lee .env.</summary>
[Collection("Horarios PostgreSQL local")]
public class HorarioPostgreSqlTests
{
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlHorarioRepository _repo;

    public HorarioPostgreSqlTests()
    {
        string connection = Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION");
        var config = new NpgsqlConnectionStringBuilder(connection);
        if ((config.Host != "127.0.0.1" && config.Host != "localhost") || config.Database != "rrhh_tec004_tests")
            throw new InvalidOperationException("Solo se admite la BD local desechable rrhh_tec004_tests.");
        _db = new PostgreSqlExecutor(new PostgreSqlConnectionFactory(connection));
        _repo = new PostgreSqlHorarioRepository(_db);
        _db.Execute("""
DROP TABLE IF EXISTS public."ExtraHorario", public."Empleado", public."HorarioTemporal", public."Asistencia", public."Marcacion", public."Horario" CASCADE;
DROP SEQUENCE IF EXISTS public.tec001_sequence;
CREATE TABLE public."Horario" (
 "idHorario" integer NOT NULL, "Ingreso1" varchar(8), "Salida1" varchar(8),
 "Ingreso2" varchar(8), "Salida2" varchar(8), "Descrip_Horario" varchar(20), "Estado" boolean, "SgtDia" boolean);
CREATE TABLE public."Empleado" ("idHorario" integer);
CREATE TABLE public."HorarioTemporal" ("HorarioAsignado" integer);
CREATE TABLE public."Asistencia" ("idHorario" integer);
CREATE TABLE public."Marcacion" ("idHorario" integer);
""");
    }

    [PostgreSqlLocalFact]
    public void TablaVaciaGeneraIdYHorasCanonicasConEstadoNulo()
    {
        int id = _repo.Insertar(Nuevo());
        Assert.Equal(1, id);
        Assert.Equal("07:00:00", _repo.Obtener(id).Ingreso1);
        Assert.Null(_repo.Obtener(id).Estado);
        Assert.Null(_db.Scalar("SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;"));
        Assert.Single(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void IdentidadAlwaysNoRecibeIdExplicito()
    {
        _db.Execute("ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);");
        Assert.Equal(100, _repo.Insertar(Nuevo()));
    }

    [PostgreSqlLocalFact]
    public void SecuenciaDefaultSeRespeta()
    {
        _db.Execute("CREATE SEQUENCE public.tec001_sequence START 200; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');");
        Assert.Equal(200, _repo.Insertar(Nuevo()));
    }

    [PostgreSqlLocalFact]
    public void DefaultCeroRevierteElAltaParaNoConfundirlaConRegistroNuevo()
    {
        _db.Execute("ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT 0;");
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(Nuevo()));
        Assert.Empty(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void SecuenciaDesalineadaSinPKRevierteInsercion()
    {
        _repo.Insertar(Nuevo());
        _db.Execute("CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');");
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(Nuevo()));
        Assert.Single(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void SecuenciaDesalineadaConPKInformaConflicto()
    {
        _repo.Insertar(Nuevo());
        _db.Execute("ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');");
        Assert.Throws<ReglaNegocioException>(() => _repo.Insertar(Nuevo()));
        Assert.Single(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void ActualizarConservaSgtDiaYEstadoNullable()
    {
        int id = _repo.Insertar(Nuevo());
        _db.Execute("UPDATE public.\"Horario\" SET \"SgtDia\"=true WHERE \"idHorario\"=1;");
        Assert.True(_repo.Actualizar(Horario.Crear(id, "Editado", "22:00", "00:00", "00:30", "06:00", false)));
        Assert.True((bool)_db.Scalar("SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;"));
        Assert.False(_repo.Obtener(id).Estado);
        Assert.Equal("22:00:00", _repo.Obtener(id).Ingreso1);
    }

    [PostgreSqlLocalFact]
    public void DatosHistoricosInvalidosSePuedenLeerParaCorregir()
    {
        _db.Execute("INSERT INTO public.\"Horario\" (\"idHorario\", \"Ingreso1\") VALUES (1, '29:00');");
        Assert.Equal("29:00", _repo.Obtener(1).Ingreso1);
        Assert.Null(_repo.Obtener(1).Salida1);
        Assert.Single(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void CadaReferenciaImpideElBorrado()
    {
        int id = _repo.Insertar(Nuevo());
        foreach (string referencia in new[] { "\"Empleado\" (\"idHorario\")", "\"HorarioTemporal\" (\"HorarioAsignado\")", "\"Asistencia\" (\"idHorario\")", "\"Marcacion\" (\"idHorario\")" })
        {
            // Solo identificadores constantes de la fixture, nunca datos de usuario.
            _db.Execute("INSERT INTO public." + referencia + " VALUES (1);");
            Assert.Throws<RegistroEnUsoException>(() => _repo.Eliminar(id));
            Assert.NotNull(_repo.Obtener(id));
            _db.Execute("TRUNCATE public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\";");
        }
        Assert.True(_repo.Eliminar(id));
        Assert.Empty(_repo.Listar());
    }

    [PostgreSqlLocalFact]
    public void FKAdicionalSeTraduceARegistroEnUso()
    {
        int id = _repo.Insertar(Nuevo());
        _db.Execute("ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE TABLE public.\"ExtraHorario\" (id integer REFERENCES public.\"Horario\" (\"idHorario\")); INSERT INTO public.\"ExtraHorario\" VALUES (1);");
        Assert.Throws<RegistroEnUsoException>(() => _repo.Eliminar(id));
        Assert.NotNull(_repo.Obtener(id));
    }

    [PostgreSqlLocalFact]
    public async Task AltasConcurrentesNoDuplicanIdsSinSecuencia()
    {
        int[] ids = await Task.WhenAll(Enumerable.Range(0, 8).Select(_ => Task.Run(() => _repo.Insertar(Nuevo()))));
        Assert.Equal(8, ids.Distinct().Count());
        Assert.Equal(8, _repo.Listar().Count);
    }

    [PostgreSqlLocalFact]
    public void CodigosDuplicadosNoSeActualizanNiEliminan()
    {
        _db.Execute("INSERT INTO public.\"Horario\" (\"idHorario\") VALUES (1),(1);");
        Assert.Throws<ReglaNegocioException>(() => _repo.Obtener(1));
        Assert.Throws<ReglaNegocioException>(() => _repo.Actualizar(Horario.Crear(1, "Nuevo", "07:00", "12:00", "13:00", "17:00", true)));
        Assert.Throws<ReglaNegocioException>(() => _repo.Eliminar(1));
        Assert.Equal(2, _repo.Listar().Count);
        Assert.All(_repo.Listar(), h => Assert.Null(h.Descripcion));
    }

    [PostgreSqlLocalFact]
    public void TextoConComillaSeGuardaComoDato()
    {
        const string texto = "Turno ' ; --";
        int id = _repo.Insertar(Horario.Crear(0, texto, "07:00", "12:00", "13:00", "17:00", true));
        Assert.Equal(texto, _repo.Obtener(id).Descripcion);
    }

    [PostgreSqlLocalFact]
    public void RegistroInexistenteNoSimulaExito()
    {
        Assert.Null(_repo.Obtener(99));
        Assert.False(_repo.Actualizar(Horario.Crear(99, "Nuevo", "07:00", "12:00", "13:00", "17:00", true)));
        Assert.False(_repo.Eliminar(99));
    }

    private static Horario Nuevo() => Horario.Crear(0, "Turno ficticio", "7:00", "12:00", "13:00", "17:00", null);
}
