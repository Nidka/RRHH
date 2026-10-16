using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using ClassRRHH;
using GRLL.Common;
using RRHH.PostgreSql;

namespace RecursosHumanos;

/// <summary>Reemplazo PostgreSQL de los procedimientos LINQ usados por RRHH.</summary>
internal sealed class PostgreSqlLegacyContext
{
	private readonly PostgreSqlExecutor _database = new PostgreSqlExecutor();

	public PostgreSqlSingleResult<sp_Listar_Empleado_HorarioResult> sp_Listar_Empleado_Horario(int? tipo, string filtro) =>
		Result<sp_Listar_Empleado_HorarioResult>(ListarEmpleados("e.\"idHorario\" AS \"idHorario\"", tipo, filtro));

	public PostgreSqlSingleResult<sp_Listar_Empleado_LocalResult> sp_Listar_Empleado_Local(int? tipo, string filtro) =>
		Result<sp_Listar_Empleado_LocalResult>(ListarEmpleados("e.\"idLocal\" AS \"idLocal\"", tipo, filtro));

	public int sp_Update_Empleado_idHorario_By_idEmpleado(int empleado, int horario) => _database.Execute(
		"UPDATE public.\"Empleado\" SET \"idHorario\"=@valor WHERE \"IdEmpleado\"=@empleado;",
		new PostgreSqlParameterValue("valor", horario), new PostgreSqlParameterValue("empleado", empleado));

	public int sp_Update_Empleado_idLocal_By_idEmpleado(int empleado, int local) => _database.Execute(
		"UPDATE public.\"Empleado\" SET \"idLocal\"=@valor WHERE \"IdEmpleado\"=@empleado;",
		new PostgreSqlParameterValue("valor", local), new PostgreSqlParameterValue("empleado", empleado));

	public DataTable spRRHH_getMotivo_perm(int? tipo, char? modalidad) => _database.Query("""
SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",
       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"
FROM public."Motivo_Perm" m
LEFT JOIN public."TipoPermiso" tp ON tp."idTipoPermiso"=m."idTipoPermiso"
WHERE (@tipo IS NULL OR m."idTipoPermiso"=@tipo)
  AND (@modalidad IS NULL OR m."TipoModalidad"=@modalidad)
ORDER BY m."Descrip_Motivo";
""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
		new PostgreSqlParameterValue("modalidad", modalidad?.ToString(), DbType.String));

	public DataTable spRRHH_Faltas(string fecha, int? tipo, int? area, int? year) =>
		(DataTable)new RRHHClass(_database).Generar_Rep_Faltas(fecha, tipo, area, year);

	public DataTable spRRHH_GetMinTarde(string inicio, string fin, char tipo) => _database.Query("""
SELECT e."IdEmpleado",
       COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
         THEN GREATEST(0, EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "Tarde",
       COUNT(*) FILTER (WHERE a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
         AND a."Hor_Ent"::time>h."Ingreso1"::time)::integer AS "DiasTarde"
FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo
GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";
""", Date("inicio", inicio), Date("fin", fin),
		new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32));

	public DataTable spRRHH_GetDiasAsistidos(string inicio, string fin, char tipo) => _database.Query("""
SELECT e."IdEmpleado", COUNT(DISTINCT a."Fecha"::date)::integer AS "Dias_Asistidos"
FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo
GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";
""", Date("inicio", inicio), Date("fin", fin),
		new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32));

	public DataTable spRRHH_GetRecordAsistenciasSemanales(string inicio, string fin, int? tipo) => _database.Query("""
SELECT e."IdEmpleado", p."NumDocID",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 COUNT(DISTINCT a."Fecha"::date)::integer AS "DiasAsistidos",
 MIN(a."Fecha"::date) AS "FechaInicio", MAX(a."Fecha"::date) AS "FechaFin",
 ROUND(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}'
  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-a."Hor_Ent"::time))/3600) ELSE 0 END)::numeric,2) AS "HorasTrabajadas"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo) AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres"
ORDER BY "NombresC";
""", Date("inicio", inicio), Date("fin", fin), new PostgreSqlParameterValue("tipo", tipo, DbType.Int32));

	public int spRRHH_GetReporteAsistencia(string inicio, string fin, int? year, int? tipo) => 0;

	public IEnumerable<spRRHH_ListarResolucionResult> spRRHH_ListarResolucion(int empleado) =>
		Map<spRRHH_ListarResolucionResult>(_database.Query("""
SELECT tr."DescripTipoResolucion",r."FechaResolucion",r."NumeroResolucion",r."idResolucion"
FROM public."Resolucion" r LEFT JOIN public."TipoResolucion" tr ON tr."idTipoResolucion"=r."idTipoResolucion"
WHERE r."idEmpleado"=@empleado ORDER BY r."FechaResolucion" DESC;
""", Employee(empleado)));

	public IEnumerable<spRRHH_ListarRotacionesResult> spRRHH_ListarRotaciones(int empleado) =>
		Map<spRRHH_ListarRotacionesResult>(_database.Query("""
SELECT r."idRotacion",r."FechaMemo",r."NroMemo",eo."AreaOrganizacional"
FROM public."Rotacion" r LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=r."Year" AND eo."idAreaOrganiz"=r."idAreaOrganiz"
WHERE r."idEmpleado"=@empleado ORDER BY r."FechaMemo" DESC;
""", Employee(empleado)));

	public IEnumerable<spRRHH_buscarEstudiosResult> spRRHH_buscarEstudios(int empleado) =>
		Map<spRRHH_buscarEstudiosResult>(_database.Query("""
SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio" AS "Añoinicio",er."AñoTermino" AS "Añotermino",
 ee."DescripEstadoEstudio",er."IdEmpleado",er."IdTipoEstudios"
FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"
LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"
WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio" DESC;
""", Employee(empleado)));

	public IEnumerable<spRRHH_BuscarExpLabResult> spRRHH_BuscarExpLab(int empleado) =>
		Map<spRRHH_BuscarExpLabResult>(_database.Query("""
SELECT ti."DescripTipoInstitucion",ex."NomInstitucion",ex."Cargo",ex."FechaIngreso",ex."FechaEgreso",
 ex."UnidadOrganica" AS "unidadOrganica",ex."IdEmpleado" AS "idEmpleado",ex."IdExpLab" AS "idExpLab"
FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"
WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;
""", Employee(empleado)));

	public IEnumerable<spRRHH_busca_DisciplinaResult> spRRHH_busca_Disciplina(int empleado) =>
		Map<spRRHH_busca_DisciplinaResult>(_database.Query("""
SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"
FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"
WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;
""", Employee(empleado)));

	public IEnumerable<spRRHH_GetPeriodoLaboralByEmpleadoResult> spRRHH_GetPeriodoLaboralByEmpleado(int empleado) =>
		Map<spRRHH_GetPeriodoLaboralByEmpleadoResult>(_database.Query(
			"SELECT * FROM public.\"PeriodoLaboral\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"NroPeriodo\";", Employee(empleado)));

	public IEnumerable<spRRHH_busca_archivosResult> spRRHH_busca_archivos(int empleado) =>
		Map<spRRHH_busca_archivosResult>(_database.Query("""
SELECT d."DescripDocumento",a."IdEmpleado" AS "idEmpleado",a."idDocumento",a."FechaIngreDoc",a."FechaVenDoc",a."NumRef",a."Obs"
FROM public."Archivo" a LEFT JOIN public."Documento" d ON d."idDocumento"=a."idDocumento"
WHERE a."IdEmpleado"=@empleado ORDER BY d."DescripDocumento";
""", Employee(empleado)));

	private DataTable ListarEmpleados(string asignacion, int? tipo, string filtro) => _database.Query($"""
SELECT e."IdEmpleado" AS "idEmpleado",p."NumDocID",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",{asignacion}
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND (@filtro IS NULL OR btrim(concat_ws(' ',p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) ILIKE '%'||@filtro||'%')
 AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY p."Apellido_Paterno",p."Apellido_Materno",p."Nombres";
""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
		new PostgreSqlParameterValue("filtro", string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim(), DbType.String));

	private static PostgreSqlSingleResult<T> Result<T>(DataTable table) where T : new() => new PostgreSqlSingleResult<T>(Map<T>(table));

	private static List<T> Map<T>(DataTable table) where T : new()
	{
		var columns = table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, StringComparer.OrdinalIgnoreCase);
		var result = new List<T>(table.Rows.Count);
		foreach (DataRow row in table.Rows)
		{
			T item = new T();
			foreach (PropertyInfo property in typeof(T).GetProperties().Where(p => p.CanWrite))
			{
				if (!columns.TryGetValue(property.Name, out DataColumn column) || row[column] == DBNull.Value) continue;
				Type target = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
				object value = target.IsInstanceOfType(row[column]) ? row[column] : Convert.ChangeType(row[column], target, CultureInfo.InvariantCulture);
				property.SetValue(item, value, null);
			}
			result.Add(item);
		}
		return result;
	}

	private static PostgreSqlParameterValue Employee(int value) => new PostgreSqlParameterValue("empleado", value, DbType.Int32);

	private static PostgreSqlParameterValue Date(string name, string input)
	{
		if (!DateTime.TryParseExact(input, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime value)
			&& !DateTime.TryParse(input, out value)) throw new ArgumentException("Fecha no valida.", name);
		return new PostgreSqlParameterValue(name, value.Date, DbType.Date);
	}
}

internal sealed class PostgreSqlSingleResult<T> : System.Data.Linq.ISingleResult<T>
{
	private readonly IEnumerable<T> _items;
	public PostgreSqlSingleResult(IEnumerable<T> items) => _items = items ?? Enumerable.Empty<T>();
	public object ReturnValue => null;
	public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	public void Dispose() { }
}
