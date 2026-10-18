using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;

namespace RRHH.PostgreSql.Permisos;

/// <summary>
/// Reemplaza spRRHH_getMotivo_perm y Motivo_PermMapper del mantenimiento.
/// SQL de consulta equivalente al puente PostgreSqlLegacyContext de eeeb817.
/// </summary>
public sealed class PostgreSqlMotivoPermisoRepository : IMotivoPermisoRepository
{
    private readonly PostgreSqlExecutor _database;
    public PostgreSqlMotivoPermisoRepository(PostgreSqlExecutor database) =>
        _database = database ?? throw new ArgumentNullException(nameof(database));

    public IReadOnlyList<MotivoPermisoDto> Listar(int tipoPermisoId, string modalidad)
    {
        DataTable table = _database.Query("""
SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",
       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"
FROM public."Motivo_Perm" AS m
LEFT JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
WHERE m."idTipoPermiso" = @tipo
  AND (@modalidad IS NULL OR m."TipoModalidad" = @modalidad)
ORDER BY m."Descrip_Motivo", m."idMotivo";
""", Param("tipo", tipoPermisoId, DbType.Int32), Param("modalidad", modalidad, DbType.String));
        return table.Rows.Cast<DataRow>().Select(row =>
        {
            MotivoPermisoDto dto = MotivoPermisoDto.Desde(Mapear(row));
            dto.DescripcionTipo = row["DescripTipoPermiso"] as string;
            return dto;
        }).ToList();
    }

    public MotivoPermiso Obtener(int id)
    {
        DataTable table = _database.Query("""
SELECT "idMotivo", "Descrip_Motivo", "Salario", "idTipoPermiso", "Abrev", "TipoModalidad", "Activo"
FROM public."Motivo_Perm" WHERE "idMotivo" = @id;
""", Param("id", id, DbType.Int32));
        if (table.Rows.Count > 1) throw CodigoDuplicado();
        return table.Rows.Count == 0 ? null : Mapear(table.Rows[0]);
    }

    /// <summary>
    /// Usa identidad/default si existe (TEC-002). El respaldo MAX+1 queda
    /// protegido por bloqueo de tabla, compatible con escritores del puente.
    /// No crea ni modifica secuencias en la BD compartida.
    /// </summary>
    public int Insertar(MotivoPermiso motivo)
    {
        if (motivo == null) throw new ArgumentNullException(nameof(motivo));
        return _database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Motivo_Perm\", public.\"TipoPermiso\" IN SHARE ROW EXCLUSIVE MODE;");
            int tipos = tx.ScalarInt("SELECT COUNT(*) FROM public.\"TipoPermiso\" WHERE \"idTipoPermiso\" = @tipo;",
                Param("tipo", motivo.TipoPermisoId, DbType.Int32));
            if (tipos != 1) throw new ReglaNegocioException("El tipo de permiso no existe o tiene códigos duplicados.");
            int usaDefault = tx.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns
WHERE table_schema = 'public' AND table_name = 'Motivo_Perm' AND column_name = 'idMotivo'
  AND (is_identity = 'YES' OR column_default IS NOT NULL);
""");
            string sql = usaDefault > 0 ? """
INSERT INTO public."Motivo_Perm" ("Descrip_Motivo", "Abrev", "Salario", "idTipoPermiso", "TipoModalidad", "Activo")
VALUES (@descripcion, @abreviatura, @salario, @tipo, @modalidad, @activo)
RETURNING "idMotivo";
""" : """
INSERT INTO public."Motivo_Perm" ("idMotivo", "Descrip_Motivo", "Abrev", "Salario", "idTipoPermiso", "TipoModalidad", "Activo")
SELECT COALESCE(MAX("idMotivo"), 0) + 1, @descripcion, @abreviatura, @salario, @tipo, @modalidad, @activo
FROM public."Motivo_Perm"
RETURNING "idMotivo";
""";
            int id = tx.ScalarInt(sql, Parametros(motivo));
            // Una secuencia desalineada en un esquema sin PK también puede
            // repetir un ID. Revertir la fila en lugar de guardar ambigüedad.
            if (Contar(tx, id) != 1) throw CodigoDuplicado();
            return id;
        });
    }

    /// <summary>Solo actualiza los campos editables; conserva Activo, modalidad y tipo.</summary>
    public bool Actualizar(MotivoPermiso motivo)
    {
        if (motivo == null) throw new ArgumentNullException(nameof(motivo));
        return _database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Motivo_Perm\" IN SHARE ROW EXCLUSIVE MODE;");
            if (Contar(tx, motivo.Id) > 1) throw CodigoDuplicado();
            return tx.Execute("""
UPDATE public."Motivo_Perm"
SET "Descrip_Motivo" = @descripcion, "Abrev" = @abreviatura, "Salario" = @salario
WHERE "idMotivo" = @id AND "idTipoPermiso" IS NOT DISTINCT FROM @tipo
  AND "TipoModalidad" IS NOT DISTINCT FROM @modalidad;
""", Parametros(motivo).Concat(new[] { Param("id", motivo.Id, DbType.Int32) }).ToArray()) == 1;
        });
    }

    /// <summary>
    /// Conserva referencias de Permiso y Permiso_Aud. Sin FK, el bloqueo de
    /// escrituras relacionadas protege comprobación y DELETE; sustituir por
    /// integridad declarativa cuando TEC-002 la restaure. No impide que un
    /// escritor legado cree una referencia huérfana después del commit.
    /// </summary>
    public bool Eliminar(int id, string modalidad)
    {
        try
        {
            return _database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Motivo_Perm\", public.\"Permiso\", public.\"Permiso_Aud\" IN SHARE ROW EXCLUSIVE MODE;");
                if (Contar(tx, id) > 1) throw CodigoDuplicado();
                var idParam = Param("id", id, DbType.Int32);
                var modalidadParam = Param("modalidad", modalidad, DbType.String);
                if (tx.ScalarInt("""
SELECT COUNT(*) FROM public."Motivo_Perm"
WHERE "idMotivo" = @id AND (@modalidad IS NULL OR "TipoModalidad" = @modalidad);
""", idParam, modalidadParam) == 0) return false;
                if (tx.ScalarInt("""
SELECT CASE WHEN EXISTS (SELECT 1 FROM public."Permiso" WHERE "idMotivo" = @id)
 OR EXISTS (SELECT 1 FROM public."Permiso_Aud" WHERE "idMotivo_Ant" = @id OR "idMotivo_Act" = @id)
THEN 1 ELSE 0 END;
""", idParam) == 1)
                    throw new RegistroEnUsoException("El motivo está referenciado en permisos o auditoría.", null);
                return tx.Execute("""
DELETE FROM public."Motivo_Perm"
WHERE "idMotivo" = @id AND (@modalidad IS NULL OR "TipoModalidad" = @modalidad);
""", idParam, modalidadParam) == 1;
            });
        }
        catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.ForeignKeyViolation)
        {
            throw new RegistroEnUsoException("El motivo está referenciado en otra tabla.", ex);
        }
    }

    private static int Contar(PostgreSqlTransactionContext tx, int id) => tx.ScalarInt(
        "SELECT COUNT(*) FROM public.\"Motivo_Perm\" WHERE \"idMotivo\" = @id;", Param("id", id, DbType.Int32));

    private static ReglaNegocioException CodigoDuplicado() =>
        new ReglaNegocioException("Hay códigos de motivo duplicados. Solicite revisar la integridad de la BD.");

    private static MotivoPermiso Mapear(DataRow row) => MotivoPermiso.Reconstituir(
        Convert.ToInt32(row["idMotivo"]), row["idTipoPermiso"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["idTipoPermiso"]),
        row["Descrip_Motivo"] as string, row["Abrev"] as string, row["Salario"] as bool?,
        row["TipoModalidad"] as string, row["Activo"] as bool?);

    private static PostgreSqlParameterValue Param(string name, object value, DbType type) => new PostgreSqlParameterValue(name, value, type);
    private static PostgreSqlParameterValue[] Parametros(MotivoPermiso motivo) => new[]
    {
        Param("tipo", motivo.TipoPermisoId, DbType.Int32), Param("descripcion", motivo.Descripcion, DbType.String),
        Param("abreviatura", motivo.Abreviatura, DbType.String), Param("salario", motivo.Salario, DbType.Boolean),
        Param("modalidad", motivo.Modalidad, DbType.String), Param("activo", motivo.Activo, DbType.Boolean)
    };
}
