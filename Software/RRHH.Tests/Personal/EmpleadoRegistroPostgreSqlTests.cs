using System;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RRHH.Application.Personal;
using RRHH.Domain.Personal;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Personal;
using RRHH.Tests.Permisos;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>
/// CR-020: alta y edición de empleados contra la BD local desechable rrhh_tec004_tests.
/// Comparte colección con las pruebas que recrean Empleado y Persona. Datos ficticios.
/// </summary>
[Collection("Motivos PostgreSQL local")]
public sealed class EmpleadoRegistroPostgreSqlTests
{
    private static readonly DateTime Hoy = new DateTime(2026, 11, 27);
    private readonly string _conexion;
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlEmpleadoRegistroRepository _repo;

    public EmpleadoRegistroPostgreSqlTests()
    {
        _conexion = Environment.GetEnvironmentVariable("RRHH_TEST_POSTGRES_CONNECTION");
        var config = new NpgsqlConnectionStringBuilder(_conexion);
        if ((config.Host != "127.0.0.1" && config.Host != "localhost") || config.Database != "rrhh_tec004_tests")
            throw new InvalidOperationException("Estas pruebas solo admiten la BD local desechable rrhh_tec004_tests.");
        _db = new PostgreSqlExecutor(new PostgreSqlConnectionFactory(_conexion));
        _repo = new PostgreSqlEmpleadoRegistroRepository(_db);
        _db.Execute("""
DROP TABLE IF EXISTS public."Empleado", public."Persona", public."Empleado_Area", public."TipoDocID", public."EstructOrganiz" CASCADE;
CREATE TABLE public."TipoDocID" ("TipoDocID" integer NOT NULL, "Descripcion" varchar(40));
CREATE TABLE public."EstructOrganiz" ("Year" integer NOT NULL, "idAreaOrganiz" integer NOT NULL,
 "AreaOrganizacional" varchar(200) NOT NULL, "Abrev" varchar(10) NOT NULL, "Sigla" varchar(6) NOT NULL);
CREATE TABLE public."Persona" ("IdPersona" integer NOT NULL, "Nombres" varchar(100), "Apellido_Paterno" varchar(30),
 "Apellido_Materno" varchar(30), "TipoDocID" integer, "NumDocID" varchar(12), "TipoPersona" varchar(1),
 "FechaRegistro" timestamp);
CREATE TABLE public."Empleado" ("IdEmpleado" integer NOT NULL, "Year" integer NOT NULL, "idAreaOrganiz" integer NOT NULL,
 "IdPersona" integer, "FechaIngreso" timestamp, "Estado" varchar(1));
CREATE TABLE public."Empleado_Area" ("Year" integer NOT NULL, "idAreaOrganiz" integer NOT NULL, "IdEmpleado" integer NOT NULL);
INSERT INTO public."TipoDocID" VALUES (1, 'DNI'), (2, 'Carné de extranjería'), (3, NULL);
INSERT INTO public."EstructOrganiz" VALUES (2025, 20, 'Sistemas', 'SIS', 'SIS'),
 (2026, 10, 'Recursos Humanos', 'RRHH', 'RRHH'), (2026, 20, 'Sistemas', 'SIS', 'SIS');
INSERT INTO public."Persona" VALUES (40, 'Raúl', 'Salinas', 'Poma', 1, '50000007', 'N', '2006-05-02');
INSERT INTO public."Empleado" VALUES (107, 2025, 20, 40, '2006-05-02', '1'), (107, 2026, 20, 40, '2006-05-02', '1');
INSERT INTO public."Empleado_Area" VALUES (2025, 20, 107), (2026, 20, 107);
""");
    }

    private static DatosEmpleado Datos(string documento, int area = 10, bool activo = true, string paterno = "Paredes") =>
        DatosEmpleado.Crear(1, documento, paterno, "Quispe", "Lucía", area, new DateTime(2024, 3, 1), activo, Hoy);

    [PostgreSqlLocalFact]
    public void InsertaPersonaEmpleadoYAreaConElSiguienteCodigo()
    {
        int id = _repo.Insertar(Datos("40000001"), 2026);

        Assert.Equal(108, id);
        Assert.Equal(1, _db.ScalarInt("""
SELECT COUNT(*) FROM public."Persona" p JOIN public."Empleado" e ON e."IdPersona" = p."IdPersona"
JOIN public."Empleado_Area" a ON a."IdEmpleado" = e."IdEmpleado" AND a."Year" = e."Year"
WHERE e."IdEmpleado" = 108 AND p."IdPersona" = 41 AND e."Year" = 2026 AND e."Estado" = '1'
  AND p."TipoPersona" = 'N' AND p."FechaRegistro" = '2024-03-01' AND a."idAreaOrganiz" = 10;
"""));
        var ficha = _repo.Obtener(108);
        Assert.Equal("40000001", ficha.NumeroDocumento);
        Assert.True(ficha.Activo);
    }

    [PostgreSqlLocalFact]
    public void NoInsertaUnDocumentoQueYaTieneOtraPersona()
    {
        _db.Execute("UPDATE public.\"Persona\" SET \"NumDocID\" = ' ce-9 ' WHERE \"IdPersona\" = 40;");

        Assert.Equal(0, _repo.Insertar(DatosEmpleado.Crear(1, "CE-9", "Paredes", null, "Lucía", 10,
            new DateTime(2024, 3, 1), true, Hoy), 2026));
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Persona\";"));
        Assert.NotEqual(0, _repo.Insertar(DatosEmpleado.Crear(2, "CE-9", "Paredes", null, "Lucía", 10,
            new DateTime(2024, 3, 1), true, Hoy), 2026));
    }

    [PostgreSqlLocalFact]
    public void EditaSoloLaFilaMasRecienteYRegistraElCese()
    {
        var resultado = _repo.Actualizar(107, Datos("50000007", area: 10, activo: false, paterno: "Salinas"));

        Assert.Equal(ResultadoEscrituraEmpleado.Guardado, resultado);
        Assert.Equal("10|0", Convert.ToString(_db.Scalar(
            "SELECT \"idAreaOrganiz\" || '|' || \"Estado\" FROM public.\"Empleado\" WHERE \"IdEmpleado\" = 107 AND \"Year\" = 2026;")));
        Assert.Equal("20|1", Convert.ToString(_db.Scalar(
            "SELECT \"idAreaOrganiz\" || '|' || \"Estado\" FROM public.\"Empleado\" WHERE \"IdEmpleado\" = 107 AND \"Year\" = 2025;")));
        Assert.Equal(new[] { "2025:20", "2026:10" }, _db.Query(
            "SELECT \"Year\" || ':' || \"idAreaOrganiz\" AS f FROM public.\"Empleado_Area\" WHERE \"IdEmpleado\" = 107 ORDER BY 1;")
            .Rows.Cast<System.Data.DataRow>().Select(f => (string)f["f"]));
        Assert.Equal("Lucía", _repo.Obtener(107).Nombres);
        Assert.False(_repo.Obtener(107).Activo);
    }

    [PostgreSqlLocalFact]
    public void AlEditarDetectaDocumentoAjenoYEmpleadoInexistente()
    {
        int nuevo = _repo.Insertar(Datos("40000001"), 2026);

        Assert.Equal(ResultadoEscrituraEmpleado.DocumentoDuplicado, _repo.Actualizar(nuevo, Datos("50000007")));
        Assert.Equal(ResultadoEscrituraEmpleado.Guardado, _repo.Actualizar(nuevo, Datos("40000001", paterno: "Rojas")));
        Assert.Equal(ResultadoEscrituraEmpleado.NoExiste, _repo.Actualizar(999, Datos("40000099")));
    }

    [PostgreSqlLocalFact]
    public void ListaTiposConDescripcionYAreasDelAnio()
    {
        Assert.Equal(new[] { "DNI", "Carné de extranjería" }, _repo.TiposDocumento().Select(t => t.Descripcion));
        Assert.Equal(new[] { 10, 20 }, _repo.Areas(2026).Select(a => a.Id));
        Assert.Equal(20, Assert.Single(_repo.Areas(2025)).Id);
    }

    [PostgreSqlLocalFact]
    public async Task AltasSimultaneasNoRepitenCodigosNiDocumentos()
    {
        var tareas = Enumerable.Range(1, 8).Select(i => Task.Run(() =>
            new PostgreSqlEmpleadoRegistroRepository(new PostgreSqlExecutor(new PostgreSqlConnectionFactory(_conexion)))
                .Insertar(Datos(i % 2 == 0 ? "60000000" : "6000000" + i), 2026))).ToArray();
        int[] ids = await Task.WhenAll(tareas);

        int[] creados = ids.Where(id => id > 0).ToArray();
        Assert.Equal(creados.Length, creados.Distinct().Count());
        Assert.Equal(5, creados.Length);
        Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Persona\" WHERE \"NumDocID\" = '60000000';"));
    }
}
