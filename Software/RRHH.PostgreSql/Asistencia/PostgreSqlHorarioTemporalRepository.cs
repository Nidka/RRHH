using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Reemplaza HorarioTemporalMapper y SgtIdHorarioTemporal con operaciones específicas PostgreSQL.</summary>
public sealed class PostgreSqlHorarioTemporalRepository : IHorarioTemporalRepository
{
    private readonly PostgreSqlExecutor _db;
    public PostgreSqlHorarioTemporalRepository(PostgreSqlExecutor db) =>
        _db = db ?? throw new ArgumentNullException(nameof(db));

    /// <inheritdoc/>
    public AsignacionHorarioDto Obtener(int empleado, int numero)
    {
        var tabla = _db.Query("""
SELECT "idEmpleado", "N", "FechaInicio", "FechaFin", "HorarioAsignado", "NroDocumento", "Sisgedo", "FechaRegistro"
FROM public."HorarioTemporal" WHERE "idEmpleado"=@empleado AND "N"=@numero;
""", Entero("empleado", empleado), Entero("numero", numero));
        if (tabla.Rows.Count > 1) throw Ambiguo();
        if (tabla.Rows.Count == 0) return null;
        var f = tabla.Rows[0];
        if (f.IsNull("FechaInicio") || f.IsNull("FechaFin") || f.IsNull("HorarioAsignado"))
            throw new ReglaNegocioException("La asignación contiene fechas u horario nulos. Solicite revisar los datos.");
        return new AsignacionHorarioDto
        {
            IdEmpleado=empleado, Numero=numero, Desde=(DateTime)f["FechaInicio"], Hasta=(DateTime)f["FechaFin"],
            IdHorario=(int)f["HorarioAsignado"], Documento=Convert.ToString(f["NroDocumento"]),
            Sisgedo=Convert.ToString(f["Sisgedo"]), FechaRegistro=f.IsNull("FechaRegistro") ? (DateTime?)null : (DateTime)f["FechaRegistro"]
        };
    }

    /// <summary>Reemplaza BuscarEmpleado_Codigo para el encabezado; no requiere área/cargo y no escribe.</summary>
    public EmpleadoHorarioDto ObtenerEmpleado(int empleado)
    {
        var tabla = _db.Query("""
SELECT p."IdPersona" AS "PersonaId", p."Nombres", p."Apellido_Paterno", p."Apellido_Materno", p."NumDocID", e."Foto"
FROM public."Empleado" e LEFT JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
WHERE e."IdEmpleado"=@empleado;
""", Entero("empleado", empleado));
        if (tabla.Rows.Count > 1) throw Ambiguo();
        if (tabla.Rows.Count == 0) return null;
        var f=tabla.Rows[0];
        if (f.IsNull("PersonaId")) return null;
        return new EmpleadoHorarioDto { Nombres=Convert.ToString(f["Nombres"]),
            ApellidoPaterno=Convert.ToString(f["Apellido_Paterno"]), ApellidoMaterno=Convert.ToString(f["Apellido_Materno"]),
            Documento=Convert.ToString(f["NumDocID"]), Foto=Foto(f["Foto"]) };
    }

    /// <inheritdoc/>
    /// <remarks>Bloqueos de tablas serializan esta ruta; no sustituyen FK/PK para escritores ajenos.
    /// Reemplaza MAX+1 separado y Update genérico de FrmHorarioEsp. Conserva FechaRegistro al editar.</remarks>
    public int Guardar(AsignacionHorario a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        return _db.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Horario\", public.\"Empleado\" IN SHARE MODE;");
            tx.Execute("LOCK TABLE public.\"HorarioTemporal\" IN SHARE ROW EXCLUSIVE MODE;");
            if (tx.ScalarInt("SELECT COUNT(*) FROM public.\"Empleado\" WHERE \"IdEmpleado\"=@empleado;", Entero("empleado",a.IdEmpleado)) != 1 ||
                tx.ScalarInt("SELECT COUNT(*) FROM public.\"Horario\" WHERE \"idHorario\"=@horario;",Entero("horario",a.IdHorario)) != 1)
                throw new ReglaNegocioException("El empleado o el horario no existe o tiene código duplicado.");
            var claves=new[] { Entero("empleado",a.IdEmpleado),Entero("numero",a.Numero) };
            if (a.Numero != 0 && tx.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\"=@empleado AND \"N\"=@numero;",claves) != 1)
                throw new ReglaNegocioException("La asignación no existe o su clave está duplicada. Actualice el listado.");
            if (tx.ScalarInt("""
SELECT COUNT(*) FROM public."HorarioTemporal" WHERE "idEmpleado"=@empleado AND (@numero=0 OR "N"<>@numero)
 AND ("FechaInicio" IS NULL OR "FechaFin" IS NULL OR "FechaInicio"::date > "FechaFin"::date);
""", claves)>0) throw new ReglaNegocioException("Hay periodos con fechas inconsistentes. Solicite revisar los datos.");
            var parametros=claves.Concat(new[] {
                new PostgreSqlParameterValue("desde",a.Rango.Desde,DbType.Date),
                new PostgreSqlParameterValue("hasta",a.Rango.Hasta,DbType.Date),
                Entero("horario",a.IdHorario), new PostgreSqlParameterValue("documento",a.Documento,DbType.String),
                new PostgreSqlParameterValue("sisgedo",a.Sisgedo,DbType.String) }).ToArray();
            if (tx.ScalarInt("""
SELECT COUNT(*) FROM public."HorarioTemporal"
WHERE "idEmpleado"=@empleado AND (@numero=0 OR "N"<>@numero)
 AND "FechaInicio"::date<=@hasta AND "FechaFin"::date>=@desde;
""",parametros)>0) throw new ReglaNegocioException("El empleado ya tiene un horario asignado en esas fechas.");
            if (a.Numero==0)
                return tx.ScalarInt("""
INSERT INTO public."HorarioTemporal" ("idEmpleado","N","FechaInicio","FechaFin","HorarioAsignado","NroDocumento","Sisgedo","FechaRegistro")
SELECT @empleado,COALESCE(MAX("N"),0)+1,@desde,@hasta,@horario,@documento,@sisgedo,LOCALTIMESTAMP
FROM public."HorarioTemporal" WHERE "idEmpleado"=@empleado RETURNING "N";
""",parametros);
            tx.Execute("""
UPDATE public."HorarioTemporal" SET "FechaInicio"=@desde,"FechaFin"=@hasta,"HorarioAsignado"=@horario,
 "NroDocumento"=@documento,"Sisgedo"=@sisgedo WHERE "idEmpleado"=@empleado AND "N"=@numero;
""",parametros);
            return a.Numero;
        });
    }

    /// <summary>Reemplaza llena_HorariosTemporales, conservando filas sin catálogo y parametrizando el periodo.</summary>
    public IReadOnlyList<HistoricoHorarioDto> Listar(int empleado, RangoFechas rango) => _db.Query("""
SELECT ht.*, COALESCE(h."Descrip_Horario",'Horario no disponible') AS "Descrip_Horario",h."Ingreso1",h."Salida2"
FROM public."HorarioTemporal" ht LEFT JOIN public."Horario" h ON h."idHorario"=ht."HorarioAsignado"
WHERE ht."idEmpleado"=@empleado AND (@desde::date IS NULL OR
 (ht."FechaInicio"::date<=@hasta AND ht."FechaFin"::date>=@desde AND ht."FechaInicio"::date<=ht."FechaFin"::date))
ORDER BY ht."FechaInicio" DESC NULLS LAST,ht."N" DESC;
""",Entero("empleado",empleado),new PostgreSqlParameterValue("desde",rango?.Desde,DbType.Date),
        new PostgreSqlParameterValue("hasta",rango?.Hasta,DbType.Date)).Rows.Cast<DataRow>().Select(f=>new HistoricoHorarioDto
        {
            IdEmpleado=(int)f["idEmpleado"],N=(int)f["N"],FechaInicio=Fecha(f,"FechaInicio"),FechaFin=Fecha(f,"FechaFin"),
            HorarioAsignado=f.IsNull("HorarioAsignado") ? (int?)null : (int)f["HorarioAsignado"],
            Descrip_Horario=Convert.ToString(f["Descrip_Horario"]),Ingreso1=Convert.ToString(f["Ingreso1"]),
            Salida2=Convert.ToString(f["Salida2"]),NroDocumento=Convert.ToString(f["NroDocumento"]),
            Sisgedo=Convert.ToString(f["Sisgedo"]),FechaRegistro=Fecha(f,"FechaRegistro")
        }).ToList();

    /// <summary>Reemplaza eliminarHorarioTemporal; no se llama al agregar/reasignar periodos.</summary>
    public bool Eliminar(int empleado,int numero) => _db.InTransaction(tx=>
    {
        tx.Execute("LOCK TABLE public.\"HorarioTemporal\" IN SHARE ROW EXCLUSIVE MODE;");
        var claves=new[] { Entero("empleado",empleado),Entero("numero",numero) };
        int cantidad=tx.ScalarInt("SELECT COUNT(*) FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\"=@empleado AND \"N\"=@numero;",claves);
        if(cantidad>1) throw Ambiguo();
        if(cantidad==0) return false;
        return tx.Execute("DELETE FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\"=@empleado AND \"N\"=@numero;",claves)==1;
    });

    private static DateTime? Fecha(DataRow fila,string columna) => fila.IsNull(columna) ? (DateTime?)null : (DateTime)fila[columna];

    private static PostgreSqlParameterValue Entero(string nombre,int valor) => new PostgreSqlParameterValue(nombre,valor,DbType.Int32);
    private static ReglaNegocioException Ambiguo() => new ReglaNegocioException("Hay claves duplicadas. Solicite revisar los datos.");
    private static byte[] Foto(object valor)
    {
        if (valor is byte[] bytes) return bytes;
        if (valor == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(valor))) return null;
        // La reconstrucción guarda fotos como base64 en Empleado.Foto (text). Una foto dañada no impide asignar.
        try { return Convert.FromBase64String(Convert.ToString(valor)); }
        catch (FormatException) { return null; }
    }
}
