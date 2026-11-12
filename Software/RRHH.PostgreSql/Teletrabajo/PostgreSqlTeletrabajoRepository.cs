using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

namespace RRHH.PostgreSql.Teletrabajo;

/// <summary>Implementa las consultas nuevas de teletrabajo sobre el esquema acordado para RF-13.</summary>
public sealed class PostgreSqlTeletrabajoRepository : ITeletrabajoRepository
{
    private readonly PostgreSqlExecutor _database;
    private const string Columnas = """
"Id", "IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion"
""";

    public PostgreSqlTeletrabajoRepository(PostgreSqlExecutor database) => _database = database;

    /// <inheritdoc/>
    /// <remarks>El bloqueo serializa altas que usan este repositorio. Una escritura ajena puede omitir la validación.</remarks>
    public int Registrar(PeriodoTeletrabajo periodo) => _database.InTransaction(tx =>
    {
        var empleado = new PostgreSqlParameterValue("empleado", periodo.IdEmpleado, DbType.Int32);
        var desde = new PostgreSqlParameterValue("desde", periodo.Rango.Desde, DbType.Date);
        var hasta = new PostgreSqlParameterValue("hasta", periodo.Rango.Hasta, DbType.Date);

        tx.Execute("""LOCK TABLE public."Empleado" IN SHARE MODE;""");
        if (tx.ScalarInt("""SELECT COUNT(*) FROM public."Empleado" WHERE "IdEmpleado" = @empleado;""", empleado) != 1)
            throw new ReglaNegocioException("El empleado no existe o su código está duplicado.");

        tx.Execute("""LOCK TABLE public."Teletrabajo" IN SHARE ROW EXCLUSIVE MODE;""");
        // Predicado inclusivo equivalente a RangoFechas.Solapa, ejecutado bajo el mismo bloqueo del alta.
        if (tx.ScalarInt("""
SELECT COUNT(*) FROM public."Teletrabajo"
WHERE "IdEmpleado" = @empleado AND "Estado" AND "FechaInicio" <= @hasta AND "FechaFin" >= @desde;
""", empleado, desde, hasta) > 0)
            throw new ReglaNegocioException("El empleado ya tiene un periodo de teletrabajo que se solapa.");

        return tx.ScalarInt("""
INSERT INTO public."Teletrabajo"
    ("IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion")
VALUES (@empleado, @desde, @hasta, @modalidad, @dias, @autorizacion)
RETURNING "Id";
""", empleado, desde, hasta,
            new PostgreSqlParameterValue("modalidad", periodo.Modalidad == ModalidadTeletrabajo.Total ? "T" : "P", DbType.String),
            new PostgreSqlParameterValue("dias", periodo.DiasRemotos, DbType.Int32),
            new PostgreSqlParameterValue("autorizacion", periodo.Autorizacion, DbType.String));
    });

    /// <inheritdoc/>
    public IReadOnlyList<PeriodoTeletrabajoDto> Listar(int empleado) =>
        _database.Query("SELECT " + Columnas + """
 FROM public."Teletrabajo" WHERE "IdEmpleado" = @empleado AND "Estado"
 ORDER BY "FechaInicio", "Id";
""", new PostgreSqlParameterValue("empleado", empleado, DbType.Int32))
        .Rows.Cast<DataRow>().Select(Mapear).ToList();

    private static PeriodoTeletrabajoDto Mapear(DataRow row) => new PeriodoTeletrabajoDto
    {
        Id = (int)row["Id"],
        IdEmpleado = (int)row["IdEmpleado"],
        Desde = (DateTime)row["FechaInicio"],
        Hasta = (DateTime)row["FechaFin"],
        Modalidad = ((string)row["Modalidad"]).Trim() switch
        {
            "T" => ModalidadTeletrabajo.Total,
            "P" => ModalidadTeletrabajo.Parcial,
            _ => throw new ReglaNegocioException("La base contiene una modalidad de teletrabajo inválida.")
        },
        DiasRemotos = (int)row["DiasRemotos"],
        Autorizacion = row.IsNull("Autorizacion") ? null : (string)row["Autorizacion"]
    };
}
