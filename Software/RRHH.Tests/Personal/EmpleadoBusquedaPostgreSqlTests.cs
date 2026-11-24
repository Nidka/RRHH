using System;
using System.Linq;
using Npgsql;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Personal;
using RRHH.Tests.Permisos;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>
/// CR-019: búsqueda de empleados contra la BD local desechable rrhh_tec004_tests.
/// Comparte colección con las demás pruebas que recrean Empleado y Persona. Datos ficticios.
/// </summary>
[Collection("Motivos PostgreSQL local")]
public sealed class EmpleadoBusquedaPostgreSqlTests
{
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlEmpleadoBusquedaRepository _repo;

    public EmpleadoBusquedaPostgreSqlTests()
    {
        string connection = Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION");
        var config = new NpgsqlConnectionStringBuilder(connection);
        if ((config.Host != "127.0.0.1" && config.Host != "localhost") || config.Database != "rrhh_tec004_tests")
            throw new InvalidOperationException("Estas pruebas solo admiten la BD local desechable rrhh_tec004_tests.");
        _db = new PostgreSqlExecutor(new PostgreSqlConnectionFactory(connection));
        _repo = new PostgreSqlEmpleadoBusquedaRepository(_db);
        _db.Execute("""
DROP TABLE IF EXISTS public."Empleado", public."Persona" CASCADE;
CREATE TABLE public."Persona" ("IdPersona" integer NOT NULL, "Nombres" varchar(100),
 "Apellido_Paterno" varchar(30), "Apellido_Materno" varchar(30), "NumDocID" varchar(12));
CREATE TABLE public."Empleado" ("IdEmpleado" integer NOT NULL, "Year" integer NOT NULL,
 "IdPersona" integer, "Estado" varchar(1));
INSERT INTO public."Persona" VALUES
 (1, 'Ana', 'García', 'Pérez', '40000001'),
 (2, 'Luis', 'Garcés', 'Rojas', '40000002'),
 (3, 'Rosa', 'Quispe', NULL, '50000003'),
 (4, 'Carla', 'Mendoza', 'Díaz', ' 40000004 ');
INSERT INTO public."Empleado" VALUES
 (101, 2025, 1, '1'), (101, 2026, 1, '1'),
 (102, 2025, 2, '1'), (102, 2026, 2, '0'),
 (103, 2026, 3, '1'),
 (104, 2026, 4, NULL);
""");
    }

    [PostgreSqlLocalFact]
    public void EncuentraPorParteDelApellidoSinDistinguirMayusculas()
    {
        var encontrados = _repo.Buscar("GAR", 20);

        Assert.Equal(new[] { 101, 102 }, encontrados.Select(e => e.IdEmpleado).OrderBy(id => id));
    }

    [PostgreSqlLocalFact]
    public void EncuentraPorNombreSeguidoDelApellido()
    {
        Assert.Equal(103, Assert.Single(_repo.Buscar("rosa quis", 20)).IdEmpleado);
    }

    [PostgreSqlLocalFact]
    public void EncuentraPorElInicioDelDocumento()
    {
        Assert.Equal(new[] { 101, 102, 104 }, _repo.Buscar("4000000", 20).Select(e => e.IdEmpleado).OrderBy(id => id));
    }

    [PostgreSqlLocalFact]
    public void MuestraApellidosNombresYDocumentoSinEspaciosSobrantes()
    {
        var ana = Assert.Single(_repo.Buscar("ana", 20));
        var carla = Assert.Single(_repo.Buscar("carla", 20));

        Assert.Equal("García Pérez, Ana", ana.NombreCompleto);
        Assert.Equal("40000004", carla.Documento);
    }

    [PostgreSqlLocalFact]
    public void DevuelveUnaFilaPorEmpleadoConElEstadoDelAnioMasReciente()
    {
        var encontrados = _repo.Buscar("gar", 20);

        Assert.True(encontrados.Single(e => e.IdEmpleado == 101).Activo);
        Assert.False(encontrados.Single(e => e.IdEmpleado == 102).Activo);
    }

    [PostgreSqlLocalFact]
    public void IncluyeCesadosDespuesDeLosActivos()
    {
        var encontrados = _repo.Buscar("4000000", 20);

        Assert.Equal(new[] { true, false, false }, encontrados.Select(e => e.Activo));
        Assert.False(encontrados.Single(e => e.IdEmpleado == 104).Activo);
    }

    [PostgreSqlLocalFact]
    public void LosComodinesSeBuscanComoTextoLiteral()
    {
        Assert.Empty(_repo.Buscar("%%", 20));
        Assert.Empty(_repo.Buscar("__", 20));
    }

    [PostgreSqlLocalFact]
    public void UnIntentoDeInyeccionSqlNoAlteraLaConsulta()
    {
        Assert.Empty(_repo.Buscar("' OR 1=1 --", 20));
        Assert.Equal(6, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Empleado\";"));
    }

    [PostgreSqlLocalFact]
    public void ObtienePorCodigoConElAnioMasRecienteYOmiteLosInexistentes()
    {
        var encontrados = _repo.ObtenerPorCodigos(new[] { 101, 102, 999 });

        Assert.Equal(new[] { 101, 102 }, encontrados.Select(e => e.IdEmpleado).OrderBy(id => id));
        Assert.Equal("García Pérez, Ana", encontrados.Single(e => e.IdEmpleado == 101).NombreCompleto);
        Assert.False(encontrados.Single(e => e.IdEmpleado == 102).Activo);
    }

    [PostgreSqlLocalFact]
    public void RespetaElLimiteDeResultados()
    {
        _db.Execute("""
INSERT INTO public."Persona" SELECT 100 + n, 'Ficticio', 'Gargantúa', NULL, '6' || n FROM generate_series(1, 25) n;
INSERT INTO public."Empleado" SELECT 500 + n, 2026, 100 + n, '1' FROM generate_series(1, 25) n;
""");

        Assert.Equal(20, _repo.Buscar("garg", 20).Count);
    }
}
