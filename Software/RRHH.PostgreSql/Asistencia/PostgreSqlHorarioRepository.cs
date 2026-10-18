using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using RRHH.Application.Asistencia;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Reemplaza HorarioMapper y la comprobación EmpleadoMapper del mantenimiento por SQL parametrizado.</summary>
public sealed class PostgreSqlHorarioRepository : IHorarioRepository
{
    private readonly PostgreSqlExecutor _database;
    private const string Columnas = "\"idHorario\", \"Descrip_Horario\", \"Ingreso1\", \"Salida1\", \"Ingreso2\", \"Salida2\", \"Estado\"";

    public PostgreSqlHorarioRepository(PostgreSqlExecutor database) =>
        _database = database ?? throw new ArgumentNullException(nameof(database));

    /// <inheritdoc/>
    public IReadOnlyList<HorarioDto> Listar() => _database.Query(
        "SELECT " + Columnas + " FROM public.\"Horario\" ORDER BY \"idHorario\";")
        .Rows.Cast<DataRow>().Select(Mapear).ToList();

    /// <inheritdoc/>
    public HorarioDto Obtener(int id)
    {
        DataTable table = _database.Query("SELECT " + Columnas + " FROM public.\"Horario\" WHERE \"idHorario\" = @id;", Id(id));
        if (table.Rows.Count > 1) throw CodigoDuplicado();
        return table.Rows.Count == 0 ? null : Mapear(table.Rows[0]);
    }

    /// <summary>Utiliza identidad/default de TEC-002 si existe; si falta, MAX+1 protegido por bloqueo de tabla.</summary>
    /// <remarks>No crea secuencias ni migra el esquema. La garantía se limita a escritores que respeten la estrategia de IDs.</remarks>
    public int Insertar(Horario horario)
    {
        if (horario == null) throw new ArgumentNullException(nameof(horario));
        try
        {
            return _database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;");
                bool tieneDefault = tx.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns
WHERE table_schema='public' AND table_name='Horario' AND column_name='idHorario'
  AND (is_identity='YES' OR column_default IS NOT NULL);
""") > 0;
                string sql = tieneDefault ? """
INSERT INTO public."Horario" ("Descrip_Horario", "Ingreso1", "Salida1", "Ingreso2", "Salida2", "Estado")
VALUES (@descripcion, @ingreso1, @salida1, @ingreso2, @salida2, @estado)
RETURNING "idHorario";
""" : """
INSERT INTO public."Horario" ("idHorario", "Descrip_Horario", "Ingreso1", "Salida1", "Ingreso2", "Salida2", "Estado")
SELECT COALESCE(MAX("idHorario"), 0)+1, @descripcion, @ingreso1, @salida1, @ingreso2, @salida2, @estado
FROM public."Horario"
RETURNING "idHorario";
""";
                int id = tx.ScalarInt(sql, Parametros(horario));
                if (id <= 0) throw new ReglaNegocioException("La BD no generó un código positivo de horario. Solicite revisar los IDs.");
                if (Contar(tx, id) != 1) throw CodigoDuplicado();
                return id;
            });
        }
        catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.UniqueViolation)
        {
            throw new ReglaNegocioException("El código de horario ya existe. Solicite revisar la secuencia de IDs.");
        }
    }

    /// <summary>Actualiza solo campos del editor y conserva SgtDia incluso si fue modificado por otro proceso.</summary>
    public bool Actualizar(Horario horario)
    {
        if (horario == null) throw new ArgumentNullException(nameof(horario));
        return _database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;");
            if (Contar(tx, horario.Id) > 1) throw CodigoDuplicado();
            return tx.Execute("""
UPDATE public."Horario"
SET "Descrip_Horario"=@descripcion, "Ingreso1"=@ingreso1, "Salida1"=@salida1,
    "Ingreso2"=@ingreso2, "Salida2"=@salida2, "Estado"=@estado
WHERE "idHorario"=@id;
""", Parametros(horario).Concat(new[] { Id(horario.Id) }).ToArray()) == 1;
        });
    }

    /// <summary>Impide eliminar horarios referenciados por empleados, horarios temporales, asistencia o marcaciones.</summary>
    /// <remarks>Los bloqueos protegen comprobación y borrado. Sin FK, un escritor externo puede crear huérfanos después del commit; TEC-002 mantiene la integridad declarativa.</remarks>
    public bool Eliminar(int id)
    {
        try
        {
            return _database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Horario\", public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\" IN SHARE ROW EXCLUSIVE MODE;");
                int cantidad = Contar(tx, id);
                if (cantidad > 1) throw CodigoDuplicado();
                if (cantidad == 0) return false;
                if (tx.ScalarInt("""
SELECT CASE WHEN EXISTS (SELECT 1 FROM public."Empleado" WHERE "idHorario"=@id)
 OR EXISTS (SELECT 1 FROM public."HorarioTemporal" WHERE "HorarioAsignado"=@id)
 OR EXISTS (SELECT 1 FROM public."Asistencia" WHERE "idHorario"=@id)
 OR EXISTS (SELECT 1 FROM public."Marcacion" WHERE "idHorario"=@id)
THEN 1 ELSE 0 END;
""", Id(id)) == 1)
                    throw new RegistroEnUsoException("No se puede eliminar: el horario está referenciado por personal, horarios temporales, asistencia o marcaciones.", null);
                return tx.Execute("DELETE FROM public.\"Horario\" WHERE \"idHorario\"=@id;", Id(id)) == 1;
            });
        }
        catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.ForeignKeyViolation)
        {
            throw new RegistroEnUsoException("No se puede eliminar: el horario está referenciado en otra tabla.", ex);
        }
    }

    private static int Contar(PostgreSqlTransactionContext tx, int id) =>
        tx.ScalarInt("SELECT COUNT(*) FROM public.\"Horario\" WHERE \"idHorario\"=@id;", Id(id));

    private static ReglaNegocioException CodigoDuplicado() =>
        new ReglaNegocioException("Hay códigos de horario duplicados. Solicite revisar la integridad de la BD.");

    private static HorarioDto Mapear(DataRow row) => new HorarioDto
    {
        Id = Convert.ToInt32(row["idHorario"]), Descripcion = row["Descrip_Horario"] as string,
        Ingreso1 = row["Ingreso1"] as string, Salida1 = row["Salida1"] as string,
        Ingreso2 = row["Ingreso2"] as string, Salida2 = row["Salida2"] as string,
        Estado = row["Estado"] as bool?
    };

    private static PostgreSqlParameterValue Id(int id) => new PostgreSqlParameterValue("id", id, DbType.Int32);
    private static PostgreSqlParameterValue[] Parametros(Horario horario) => new[]
    {
        new PostgreSqlParameterValue("descripcion", horario.Descripcion, DbType.String),
        new PostgreSqlParameterValue("ingreso1", Horario.FormatearHora(horario.Ingreso1), DbType.String),
        new PostgreSqlParameterValue("salida1", Horario.FormatearHora(horario.Salida1), DbType.String),
        new PostgreSqlParameterValue("ingreso2", Horario.FormatearHora(horario.Ingreso2), DbType.String),
        new PostgreSqlParameterValue("salida2", Horario.FormatearHora(horario.Salida2), DbType.String),
        new PostgreSqlParameterValue("estado", horario.Estado, DbType.Boolean)
    };
}
