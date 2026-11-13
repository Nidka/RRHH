using System;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Asistencia;
using RRHH.Tests.Permisos;
using Xunit;

namespace RRHH.Tests.Asistencia;

/// <summary>SQL real sobre fixture local ficticio. Comparte colección para no competir por tablas.</summary>
[Collection("Horarios PostgreSQL local")]
public class HorarioTemporalPostgreSqlTests
{
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlHorarioTemporalRepository _repo;
    public HorarioTemporalPostgreSqlTests()
    {
        string connection = Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION");
        var config = new NpgsqlConnectionStringBuilder(connection);
        if ((config.Host != "127.0.0.1" && config.Host != "localhost") || config.Database != "rrhh_tec004_tests")
            throw new InvalidOperationException("Solo se admite la BD local ficticia rrhh_tec004_tests.");
        _db = new PostgreSqlExecutor(new PostgreSqlConnectionFactory(connection));
        _repo = new PostgreSqlHorarioTemporalRepository(_db);
        _db.Execute("""
DROP TABLE IF EXISTS public."HorarioTemporal", public."Empleado", public."Persona", public."Horario" CASCADE;
CREATE TABLE public."Persona" ("IdPersona" integer, "Nombres" text, "Apellido_Paterno" text, "Apellido_Materno" text, "NumDocID" text);
CREATE TABLE public."Empleado" ("IdEmpleado" integer, "IdPersona" integer, "Foto" text);
CREATE TABLE public."Horario" ("idHorario" integer, "Descrip_Horario" text, "Ingreso1" text, "Salida2" text);
CREATE TABLE public."HorarioTemporal" ("idEmpleado" integer NOT NULL, "N" integer NOT NULL,
 "FechaInicio" timestamp, "FechaFin" timestamp, "HorarioAsignado" integer,
 "NroDocumento" varchar(50), "Sisgedo" varchar(50), "FechaRegistro" timestamp);
INSERT INTO public."Persona" VALUES (1,'Persona','Ficticia','Uno','FICTICIO');
INSERT INTO public."Empleado" VALUES (1,1,NULL), (2,1,NULL);
INSERT INTO public."Horario" VALUES (1,'Horario ficticio','08:00:00','17:00:00');
""");
    }

    [PostgreSqlLocalFact]
    public void AltaReasignaSinBorrarHistoriaYEdicionConservaFechaRegistro()
    {
        Assert.Equal(1, _repo.Guardar(Nueva(1,0,10,12,"O'Hara")));
        Assert.Equal(2, _repo.Guardar(Nueva(1,0,13,14)));
        var fecha = _repo.Obtener(1,1).FechaRegistro;
        _repo.Guardar(Nueva(1,1,9,12));
        Assert.Equal(fecha, _repo.Obtener(1,1).FechaRegistro);
        Assert.Equal(2, _db.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\";"));
    }

    [PostgreSqlLocalFact]
    public void ContencionEdicionYReferenciaInvalidaNoDejanEscrituras()
    {
        _repo.Guardar(Nueva(1,0,10,12));
        _repo.Guardar(Nueva(1,0,20,22));
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(Nueva(1,0,9,13)));
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(Nueva(1,2,12,22)));
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(Nueva(999,0,15,16)));
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(new AsignacionHorario(1,0,
            RangoFechas.Crear(new DateTime(2026,11,15),new DateTime(2026,11,16)),999,null,null)));
        Assert.Equal(new DateTime(2026,11,20), _repo.Obtener(1,2).Desde);
        Assert.Equal(2, _db.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\";"));
        Assert.Equal(1, _repo.Guardar(Nueva(2,0,10,12)));
    }

    [PostgreSqlLocalFact]
    public async Task DosAltasSuperpuestasSoloConfirmanUna()
    {
        async Task<bool> Alta() => await Task.Run(() =>
        {
            try { _repo.Guardar(Nueva(1,0,10,12)); return true; }
            catch (ReglaNegocioException) { return false; }
        });
        var resultados = await Task.WhenAll(Alta(), Alta());
        Assert.Single(resultados, x => x);
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\";"));
    }

    [PostgreSqlLocalFact]
    public void DuplicadosYFechasInconsistentesExigenRevisionSinModificarDatos()
    {
        _repo.Guardar(Nueva(1,0,10,12));
        _db.Execute("INSERT INTO public.\"HorarioTemporal\" SELECT * FROM public.\"HorarioTemporal\";");
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(Nueva(1,1,10,11)));
        Assert.Throws<ReglaNegocioException>(() => _repo.Obtener(1,1));
        _db.Execute("TRUNCATE public.\"HorarioTemporal\"; INSERT INTO public.\"HorarioTemporal\" (\"idEmpleado\",\"N\") VALUES (1,1);");
        Assert.Throws<ReglaNegocioException>(() => _repo.Guardar(Nueva(1,0,10,11)));
        Assert.Equal(1,_db.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\";"));
    }

    [PostgreSqlLocalFact]
    public async Task OrdenDeBloqueosCompatibleConBajaDeHorarioEvitaInterbloqueo()
    {
        using (var conexion=new NpgsqlConnection(Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION")))
        {
            conexion.Open();
            using (var tx=conexion.BeginTransaction())
            {
                using(var cmd=new NpgsqlCommand("LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;",conexion,tx)) cmd.ExecuteNonQuery();
                var alta=Task.Run(()=>_repo.Guardar(Nueva(1,0,10,12)));
                try
                {
                    Assert.True(System.Threading.SpinWait.SpinUntil(()=>_db.ScalarInt(
                        "SELECT COUNT(*) FROM pg_locks WHERE relation='public.\"Horario\"'::regclass AND NOT granted;")>0,5000));
                    // Una baja bloquea Horario antes que Empleado. El alta que espera Horario no debe retener Empleado.
                    using(var cmd=new NpgsqlCommand("LOCK TABLE public.\"Empleado\" IN SHARE ROW EXCLUSIVE MODE NOWAIT;",conexion,tx)) cmd.ExecuteNonQuery();
                }
                finally { tx.Rollback(); }
                Assert.Equal(1,await alta);
            }
        }
    }

    private static AsignacionHorario Nueva(int empleado,int numero,int desde,int hasta,string doc=null) =>
        new AsignacionHorario(empleado,numero,RangoFechas.Crear(new DateTime(2026,11,desde),
            new DateTime(2026,11,hasta)),1,doc,null);
}
