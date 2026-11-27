using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Personal;
using RRHH.Domain.Personal;

namespace RRHH.PostgreSql.Personal;

/// <summary>
/// CR-020: alta y edición de empleados para la web sobre <c>Persona</c>, <c>Empleado</c> y <c>Empleado_Area</c>.
/// </summary>
/// <remarks>
/// Conserva la numeración de <c>RRHHClass.Ingresa_Empleado</c> (<c>MAX + 1</c>, porque el esquema no tiene secuencias)
/// y su bloqueo <c>pg_advisory_xact_lock(721104)</c>, de modo que el escritorio y la web no asignan el mismo código.
/// El mismo bloqueo serializa la comprobación del documento duplicado con la escritura.
/// Las fechas viajan como <c>DbType.Date</c>: con Npgsql 8 (web) <c>DbType.DateTime</c> se envía como timestamptz y falla.
/// </remarks>
public sealed class PostgreSqlEmpleadoRegistroRepository : IEmpleadoRegistroRepository
{
    /// <summary>Clave del bloqueo que usa también <c>RRHHClass.Ingresa_Empleado</c>.</summary>
    public const long BloqueoRegistroEmpleados = 721104;

    private readonly PostgreSqlExecutor _db;

    public PostgreSqlEmpleadoRegistroRepository(PostgreSqlExecutor db) =>
        _db = db ?? throw new ArgumentNullException(nameof(db));

    /// <inheritdoc/>
    public IReadOnlyList<OpcionCatalogoDto> TiposDocumento() => Opciones(_db.Query("""
SELECT "TipoDocID" AS id, btrim("Descripcion") AS descripcion
FROM public."TipoDocID" WHERE "Descripcion" IS NOT NULL AND btrim("Descripcion") <> ''
ORDER BY "TipoDocID";
"""));

    /// <inheritdoc/>
    public IReadOnlyList<OpcionCatalogoDto> Areas(int anio) => Opciones(_db.Query("""
SELECT "idAreaOrganiz" AS id, MIN(btrim("AreaOrganizacional")) AS descripcion
FROM public."EstructOrganiz" WHERE "Year" = @anio
GROUP BY "idAreaOrganiz" ORDER BY 2, 1;
""", new PostgreSqlParameterValue("anio", anio, DbType.Int32)));

    /// <inheritdoc/>
    public EmpleadoEdicionDto Obtener(int idEmpleado)
    {
        DataTable tabla = _db.Query("""
SELECT e."IdEmpleado", e."Year", e."idAreaOrganiz", e."FechaIngreso", e."Estado",
       p."TipoDocID", p."NumDocID", p."Apellido_Paterno", p."Apellido_Materno", p."Nombres"
FROM public."Empleado" e
LEFT JOIN public."Persona" p ON p."IdPersona" = e."IdPersona"
WHERE e."IdEmpleado" = @empleado
ORDER BY e."Year" DESC LIMIT 1;
""", new PostgreSqlParameterValue("empleado", idEmpleado, DbType.Int32));
        if (tabla.Rows.Count == 0) return null;
        DataRow fila = tabla.Rows[0];
        return new EmpleadoEdicionDto
        {
            Id = Convert.ToInt32(fila["IdEmpleado"]),
            Anio = Convert.ToInt32(fila["Year"]),
            Area = Convert.ToInt32(fila["idAreaOrganiz"]),
            FechaIngreso = fila.IsNull("FechaIngreso") ? default : Convert.ToDateTime(fila["FechaIngreso"]).Date,
            Activo = !fila.IsNull("Estado") && Convert.ToString(fila["Estado"]).Trim() == "1",
            TipoDocumento = fila.IsNull("TipoDocID") ? 0 : Convert.ToInt32(fila["TipoDocID"]),
            NumeroDocumento = Texto(fila, "NumDocID"),
            ApellidoPaterno = Texto(fila, "Apellido_Paterno"),
            ApellidoMaterno = Texto(fila, "Apellido_Materno"),
            Nombres = Texto(fila, "Nombres")
        };
    }

    /// <inheritdoc/>
    public int Insertar(DatosEmpleado datos, int anio)
    {
        if (datos == null) throw new ArgumentNullException(nameof(datos));
        return _db.InTransaction(tx =>
        {
            Bloquear(tx);
            if (DocumentoOcupado(tx, datos, personaPropia: null)) return 0;
            int persona = tx.ScalarInt("SELECT COALESCE(MAX(\"IdPersona\"), 0) + 1 FROM public.\"Persona\";");
            int empleado = tx.ScalarInt("SELECT COALESCE(MAX(\"IdEmpleado\"), 0) + 1 FROM public.\"Empleado\";");
            tx.Execute("""
INSERT INTO public."Persona" ("IdPersona", "Nombres", "Apellido_Paterno", "Apellido_Materno", "TipoDocID", "NumDocID",
                              "TipoPersona", "FechaRegistro")
VALUES (@persona, @nombres, @paterno, @materno, @tipo, @documento, 'N', @ingreso);
""", ParametrosPersona(datos, persona));
            tx.Execute("""
INSERT INTO public."Empleado" ("IdEmpleado", "Year", "idAreaOrganiz", "IdPersona", "FechaIngreso", "Estado")
VALUES (@empleado, @anio, @area, @persona, @ingreso, '1');
INSERT INTO public."Empleado_Area" ("Year", "idAreaOrganiz", "IdEmpleado") VALUES (@anio, @area, @empleado);
""",
                new PostgreSqlParameterValue("empleado", empleado, DbType.Int32),
                new PostgreSqlParameterValue("anio", anio, DbType.Int32),
                new PostgreSqlParameterValue("area", datos.Area, DbType.Int32),
                new PostgreSqlParameterValue("persona", persona, DbType.Int32),
                new PostgreSqlParameterValue("ingreso", datos.FechaIngreso, DbType.Date));
            return empleado;
        });
    }

    /// <inheritdoc/>
    public ResultadoEscrituraEmpleado Actualizar(int idEmpleado, DatosEmpleado datos)
    {
        if (datos == null) throw new ArgumentNullException(nameof(datos));
        return _db.InTransaction(tx =>
        {
            Bloquear(tx);
            DataTable actual = tx.Query("""
SELECT "Year", "idAreaOrganiz", "IdPersona" FROM public."Empleado"
WHERE "IdEmpleado" = @empleado ORDER BY "Year" DESC LIMIT 1 FOR UPDATE;
""", new PostgreSqlParameterValue("empleado", idEmpleado, DbType.Int32));
            if (actual.Rows.Count == 0 || actual.Rows[0].IsNull("IdPersona")) return ResultadoEscrituraEmpleado.NoExiste;
            int anio = Convert.ToInt32(actual.Rows[0]["Year"]);
            int areaAnterior = Convert.ToInt32(actual.Rows[0]["idAreaOrganiz"]);
            int persona = Convert.ToInt32(actual.Rows[0]["IdPersona"]);
            if (DocumentoOcupado(tx, datos, persona)) return ResultadoEscrituraEmpleado.DocumentoDuplicado;

            tx.Execute("""
UPDATE public."Persona" SET "Nombres" = @nombres, "Apellido_Paterno" = @paterno, "Apellido_Materno" = @materno,
       "TipoDocID" = @tipo, "NumDocID" = @documento
WHERE "IdPersona" = @persona;
""", ParametrosPersona(datos, persona));
            var parametros = new[]
            {
                new PostgreSqlParameterValue("empleado", idEmpleado, DbType.Int32),
                new PostgreSqlParameterValue("anio", anio, DbType.Int32),
                new PostgreSqlParameterValue("area", datos.Area, DbType.Int32),
                new PostgreSqlParameterValue("areaAnterior", areaAnterior, DbType.Int32),
                new PostgreSqlParameterValue("ingreso", datos.FechaIngreso, DbType.Date),
                new PostgreSqlParameterValue("estado", datos.Activo ? "1" : "0", DbType.String)
            };
            tx.Execute("""
UPDATE public."Empleado" SET "idAreaOrganiz" = @area, "FechaIngreso" = @ingreso, "Estado" = @estado
WHERE "IdEmpleado" = @empleado AND "Year" = @anio;
""", parametros);
            if (areaAnterior != datos.Area)
            {
                tx.Execute("""
DELETE FROM public."Empleado_Area" WHERE "IdEmpleado" = @empleado AND "Year" = @anio AND "idAreaOrganiz" = @areaAnterior;
INSERT INTO public."Empleado_Area" ("Year", "idAreaOrganiz", "IdEmpleado")
SELECT @anio, @area, @empleado
WHERE NOT EXISTS (SELECT 1 FROM public."Empleado_Area"
                  WHERE "IdEmpleado" = @empleado AND "Year" = @anio AND "idAreaOrganiz" = @area);
""", parametros);
            }
            return ResultadoEscrituraEmpleado.Guardado;
        });
    }

    private static void Bloquear(PostgreSqlTransactionContext tx) =>
        tx.Execute("SELECT pg_advisory_xact_lock(@clave);",
            new PostgreSqlParameterValue("clave", BloqueoRegistroEmpleados, DbType.Int64));

    /// <summary>El mismo tipo y número (sin espacios ni mayúsculas) en otra persona.</summary>
    private static bool DocumentoOcupado(PostgreSqlTransactionContext tx, DatosEmpleado datos, int? personaPropia) =>
        tx.ScalarInt("""
SELECT 1 FROM public."Persona"
WHERE "TipoDocID" = @tipo AND upper(btrim("NumDocID")) = @documento
  AND (@persona::integer IS NULL OR "IdPersona" <> @persona)
LIMIT 1;
""",
            new PostgreSqlParameterValue("tipo", datos.TipoDocumento, DbType.Int32),
            new PostgreSqlParameterValue("documento", datos.NumeroDocumento, DbType.String),
            new PostgreSqlParameterValue("persona", personaPropia, DbType.Int32)) == 1;

    private static PostgreSqlParameterValue[] ParametrosPersona(DatosEmpleado datos, int persona) => new[]
    {
        new PostgreSqlParameterValue("persona", persona, DbType.Int32),
        new PostgreSqlParameterValue("nombres", datos.Nombres, DbType.String),
        new PostgreSqlParameterValue("paterno", datos.ApellidoPaterno, DbType.String),
        new PostgreSqlParameterValue("materno", datos.ApellidoMaterno, DbType.String),
        new PostgreSqlParameterValue("tipo", datos.TipoDocumento, DbType.Int32),
        new PostgreSqlParameterValue("documento", datos.NumeroDocumento, DbType.String),
        new PostgreSqlParameterValue("ingreso", datos.FechaIngreso, DbType.Date)
    };

    private static IReadOnlyList<OpcionCatalogoDto> Opciones(DataTable tabla) => tabla.Rows.Cast<DataRow>()
        .Select(f => new OpcionCatalogoDto { Id = Convert.ToInt32(f["id"]), Descripcion = Convert.ToString(f["descripcion"]) })
        .ToList();

    private static string Texto(DataRow fila, string columna) =>
        fila.IsNull(columna) ? null : Convert.ToString(fila[columna]).Trim();
}
