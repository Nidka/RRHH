using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using ClassRRHH.My;
using RRHH.PostgreSql;

namespace ClassRRHH;

/// <summary>
/// Sincroniza el archivo Access del reloj biométrico con PostgreSQL.
/// Access continúa siendo la fuente local del reloj; SQL Server ya no participa.
/// </summary>
public class AsistenciaAccess
{
	public string BD;
	public string BDProind;
	public string BDConsejo;

	private readonly OleDbConnection oCnAccess;
	private readonly OleDbConnection oCnAccessAlt;
	private readonly PostgreSqlExecutor _database;

	public AsistenciaAccess()
	{
		BD = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Aplicacion.ToString(), "E");
		BDProind = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Key.ToString(), "E");
		BDConsejo = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.App.ToString(), "E");
		oCnAccess = new OleDbConnection(BuildAccessConnectionString(BD, appendFileName: true));
		oCnAccessAlt = new OleDbConnection(BuildAlternativeConnectionString());
		_database = new PostgreSqlExecutor();
	}

	public bool Grabar_Asis_Norm(int Pers_DNI, string Fec_Asi, string Hor_Ent, string Hor_Sal, string Alm_Ent, string Alm_Sal)
	{
		try
		{
			int personCode = GetAccessPersonCode(oCnAccess, Pers_DNI.ToString(CultureInfo.InvariantCulture));
			if (ExistAsistencia(personCode, Fec_Asi)) return false;
			InsertAccessAttendance(oCnAccess, personCode, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal);
			if (HasAlternativeDatabase()) InsertAccessAttendance(oCnAccessAlt, personCode, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool ExistAsistencia(int Pers_Cod, string Fecha)
	{
		return ExecuteAccessScalarInt(oCnAccess,
			"SELECT Count(*) FROM Asis_Norm WHERE Pers_Cod = ? AND Fec_Asi = ?",
			new OleDbParameter("persCod", OleDbType.Integer) { Value = Pers_Cod },
			new OleDbParameter("fecha", OleDbType.VarWChar) { Value = Fecha }) > 0;
	}

	public bool Grabar_Marcaciones(string fecha, string dni, string estado, int proceso, string Lugar)
	{
		try
		{
			InsertAccessMark(oCnAccess, fecha, dni, estado, proceso, Lugar);
			if (HasAlternativeDatabase()) InsertAccessMark(oCnAccessAlt, fecha, dni, estado, proceso, Lugar);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool Actualizar_Empleado_Horario(int idhorario, string dni)
	{
		try
		{
			UpdateAccessSchedule(oCnAccess, idhorario, dni);
			if (HasAlternativeDatabase()) UpdateAccessSchedule(oCnAccessAlt, idhorario, dni);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public object Grabar_suspencion(string Dni, string Fecha)
	{
		try
		{
			int personCode = GetAccessPersonCode(oCnAccess, Dni);
			bool exists = ExistAsistencia(personCode, Fecha);
			string sql = exists
				? "UPDATE Asis_Norm SET Suspendido = true WHERE Pers_Cod = ? AND Fec_Asi = ?"
				: "INSERT INTO Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal, Suspendido) VALUES (?, ?, '00:00:00', '00:00:00', '00:00:00', '00:00:00', true)";
			return ExecuteAccess(oCnAccess, sql,
				new OleDbParameter("persCod", OleDbType.Integer) { Value = personCode },
				new OleDbParameter("fecha", OleDbType.VarWChar) { Value = Fecha }) > 0;
		}
		catch
		{
			return false;
		}
	}

	public bool Grabar_SalidaAutorizada(string Dni, int NPermiso, string FechaInicio, string FechaFin, bool dia, bool Retorno, string Lugar)
	{
		try
		{
			int personCode = GetAccessPersonCode(oCnAccess, Dni);
			InsertAccessPermission(oCnAccess, personCode, NPermiso, FechaInicio, FechaFin, dia, Retorno, Lugar);
			if (HasAlternativeDatabase()) InsertAccessPermission(oCnAccessAlt, personCode, NPermiso, FechaInicio, FechaFin, dia, Retorno, Lugar);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool Access2Sql(string FechaInicial, string FechaFinal, int forzar) =>
		ImportToPostgreSql(BuildAccessConnectionString(BD, appendFileName: false), FechaInicial, FechaFinal, forzar);

	public bool Access2SqlSEDE(string FechaInicial, string FechaFinal, int forzar) =>
		ImportToPostgreSql(BuildAccessConnectionString(BD, appendFileName: true), FechaInicial, FechaFinal, forzar);

	public bool Access2SqlPROIND(string FechaInicial, string FechaFinal, int forzar) =>
		ImportToPostgreSql(BuildAccessConnectionString(BDProind, appendFileName: true), FechaInicial, FechaFinal, forzar);

	public bool Access2SqlCONSEJO(string FechaInicial, string FechaFinal, int forzar) =>
		ImportToPostgreSql(BuildAccessConnectionString(BDConsejo, appendFileName: true), FechaInicial, FechaFinal, forzar);

	private bool ImportToPostgreSql(string accessConnectionString, string fechaInicial, string fechaFinal, int forzar)
	{
		try
		{
			DateTime start = DateTime.ParseExact(fechaInicial, "yyyyMMdd", CultureInfo.InvariantCulture).Date;
			DateTime endExclusive = DateTime.ParseExact(fechaFinal, "yyyyMMdd", CultureInfo.InvariantCulture).Date.AddDays(1);
			DataTable attendance = ReadAccessTable(accessConnectionString, @"
SELECT e.pers_DNI AS DNI, a.fec_asi, a.hor_ent, a.hor_sal,
       a.alm_ent, a.alm_sal, a.idhorario, a.estado
FROM empleado e INNER JOIN asis_norm a ON e.pers_cod = a.pers_cod
WHERE a.fec_asi >= ? AND a.fec_asi < ?", start, endExclusive);
			DataTable marks = ReadAccessTable(accessConnectionString, @"
SELECT Valor AS DNI, Fecha, Estado, Lugar
FROM marcacion
WHERE Fecha >= ? AND Fecha < ?
ORDER BY Fecha", start, endExclusive);
			Dictionary<string, int> employees = LoadEmployeesByDocument();
			_database.InTransaction(transaction =>
			{
				ImportAttendanceRows(transaction, attendance, employees, forzar != 0);
				ImportMarkRows(transaction, marks, employees, forzar != 0);
				return true;
			});
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static void ImportAttendanceRows(PostgreSqlTransactionContext transaction, DataTable rows, Dictionary<string, int> employees, bool force)
	{
		foreach (DataRow row in rows.Rows)
		{
			if (!employees.TryGetValue(Convert.ToString(row["DNI"]).Trim(), out int employeeId)) continue;
			DateTime date = Convert.ToDateTime(row["fec_asi"], CultureInfo.InvariantCulture).Date;
			if (force)
			{
				transaction.Execute(@"DELETE FROM public.""Asistencia"" WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date;",
					Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.Date));
			}

			transaction.Execute(@"
INSERT INTO public.""Asistencia""
    (""Fecha"", ""IdEmpleado"", ""Hor_Ent"", ""Hor_Sal"", ""Alm_Ent"", ""Alm_Sal"", ""Estado"", ""idHorario"", ""Usuario"", ""PC"")
SELECT @date, @employee, @arrival, @departure, @lunchArrival, @lunchDeparture, @state, @schedule, 'IMPORTACION', @pc
WHERE NOT EXISTS (
    SELECT 1 FROM public.""Asistencia""
    WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date
);",
				Param("date", date, DbType.DateTime), Param("employee", employeeId, DbType.Int32),
				Param("arrival", TimeText(row["hor_ent"]), DbType.String), Param("departure", TimeText(row["hor_sal"]), DbType.String),
				Param("lunchArrival", TimeText(row["alm_ent"]), DbType.String), Param("lunchDeparture", TimeText(row["alm_sal"]), DbType.String),
				Param("state", BooleanValue(row["estado"]), DbType.Boolean), Param("schedule", NullableInt(row["idhorario"]), DbType.Int32),
				Param("pc", Environment.MachineName, DbType.String));
		}
	}

	private static void ImportMarkRows(PostgreSqlTransactionContext transaction, DataTable rows, Dictionary<string, int> employees, bool force)
	{
		foreach (DataRow row in rows.Rows)
		{
			if (!employees.TryGetValue(Convert.ToString(row["DNI"]).Trim(), out int employeeId)) continue;
			DateTime date = Convert.ToDateTime(row["Fecha"], CultureInfo.InvariantCulture);
			if (force)
			{
				transaction.Execute(@"DELETE FROM public.""Marcacion"" WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date;",
					Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.DateTime));
			}

			transaction.Execute(@"
INSERT INTO public.""Marcacion"" (""Fecha"", ""Estado"", ""IdEmpleado"", ""Lugar"")
SELECT @date, @state, @employee, @place
WHERE NOT EXISTS (
    SELECT 1 FROM public.""Marcacion""
    WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date
);",
				Param("date", date, DbType.DateTime), Param("state", DbValue(row["Estado"]), DbType.String),
				Param("employee", employeeId, DbType.Int32), Param("place", DbValue(row["Lugar"]), DbType.String));
		}
	}

	private static DataTable ReadAccessTable(string connectionString, string sql, DateTime start, DateTime endExclusive)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand command = new OleDbCommand(sql, connection);
		command.Parameters.Add("start", OleDbType.Date).Value = start;
		command.Parameters.Add("end", OleDbType.Date).Value = endExclusive;
		using OleDbDataAdapter adapter = new OleDbDataAdapter(command);
		DataTable table = new DataTable();
		adapter.Fill(table);
		return table;
	}

	private Dictionary<string, int> LoadEmployeesByDocument()
	{
		DataTable table = _database.Query(@"
SELECT e.""IdEmpleado"", p.""NumDocID""
FROM public.""Empleado"" e
JOIN public.""Persona"" p ON p.""IdPersona"" = e.""IdPersona""
WHERE p.""NumDocID"" IS NOT NULL;");
		Dictionary<string, int> result = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		foreach (DataRow row in table.Rows)
		{
			string document = Convert.ToString(row["NumDocID"]).Trim();
			if (document.Length > 0 && !result.ContainsKey(document)) result.Add(document, Convert.ToInt32(row["IdEmpleado"], CultureInfo.InvariantCulture));
		}
		return result;
	}

	private static void InsertAccessAttendance(OleDbConnection connection, int personCode, string date, string arrival, string departure, string lunchArrival, string lunchDeparture)
	{
		ExecuteAccess(connection, "INSERT INTO Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal) VALUES (?, ?, ?, ?, ?, ?)",
			new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("date", OleDbType.VarWChar) { Value = date },
			new OleDbParameter("arrival", OleDbType.VarWChar) { Value = arrival }, new OleDbParameter("departure", OleDbType.VarWChar) { Value = departure },
			new OleDbParameter("lunchArrival", OleDbType.VarWChar) { Value = lunchArrival }, new OleDbParameter("lunchDeparture", OleDbType.VarWChar) { Value = lunchDeparture });
	}

	private static void InsertAccessMark(OleDbConnection connection, string date, string document, string state, int process, string place)
	{
		ExecuteAccess(connection, "INSERT INTO Marcacion (Fecha, Valor, Estado, Proceso, Lugar) VALUES (?, ?, ?, ?, ?)",
			new OleDbParameter("date", OleDbType.VarWChar) { Value = date }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document },
			new OleDbParameter("state", OleDbType.VarWChar) { Value = state }, new OleDbParameter("process", OleDbType.Integer) { Value = process },
			new OleDbParameter("place", OleDbType.VarWChar) { Value = place });
	}

	private static void UpdateAccessSchedule(OleDbConnection connection, int scheduleId, string document)
	{
		ExecuteAccess(connection, "UPDATE Empleado SET idHorario = ? WHERE pers_estado = true AND pers_DNI = ?",
			new OleDbParameter("schedule", OleDbType.Integer) { Value = scheduleId }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document.Trim() });
	}

	private static void InsertAccessPermission(OleDbConnection connection, int personCode, int permissionNumber, string start, string end, bool fullDay, bool returns, string place)
	{
		ExecuteAccess(connection, "INSERT INTO Permiso (idEmpleado, NPermiso, FechaInicio, FechaFin, dia, Retorno, Lugar) VALUES (?, ?, ?, ?, ?, ?, ?)",
			new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("permission", OleDbType.Integer) { Value = permissionNumber },
			new OleDbParameter("start", OleDbType.VarWChar) { Value = start }, new OleDbParameter("end", OleDbType.VarWChar) { Value = end },
			new OleDbParameter("fullDay", OleDbType.Boolean) { Value = fullDay }, new OleDbParameter("returns", OleDbType.Boolean) { Value = returns },
			new OleDbParameter("place", OleDbType.VarWChar) { Value = place });
	}

	private static int GetAccessPersonCode(OleDbConnection connection, string document) =>
		ExecuteAccessScalarInt(connection, "SELECT pers_cod FROM Empleado WHERE pers_estado = true AND pers_dni = ?",
			new OleDbParameter("document", OleDbType.VarWChar) { Value = document.Trim() });

	private static int ExecuteAccess(OleDbConnection connection, string sql, params OleDbParameter[] parameters)
	{
		bool close = connection.State == ConnectionState.Closed;
		if (close) connection.Open();
		try
		{
			using OleDbCommand command = new OleDbCommand(sql, connection);
			command.Parameters.AddRange(parameters);
			return command.ExecuteNonQuery();
		}
		finally
		{
			if (close) connection.Close();
		}
	}

	private static int ExecuteAccessScalarInt(OleDbConnection connection, string sql, params OleDbParameter[] parameters)
	{
		bool close = connection.State == ConnectionState.Closed;
		if (close) connection.Open();
		try
		{
			using OleDbCommand command = new OleDbCommand(sql, connection);
			command.Parameters.AddRange(parameters);
			object value = command.ExecuteScalar();
			return value == null || value == DBNull.Value ? 0 : Convert.ToInt32(value, CultureInfo.InvariantCulture);
		}
		finally
		{
			if (close) connection.Close();
		}
	}

	private bool HasAlternativeDatabase() => MySettingsProperty.Settings.Aplicacion.ToString().Length >= 3;

	private string BuildAlternativeConnectionString()
	{
		string path = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Version.ToString(), "E");
		string password = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.SEDE.ToString(), "E");
		return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Path.Combine(path, "Marcacion.mdb") + ";Jet OLEDB:Database Password=" + password + ";";
	}

	private static string BuildAccessConnectionString(string path, bool appendFileName)
	{
		string dataSource = appendFileName ? System.IO.Path.Combine(path, "Marcacion.mdb") : path;
		string password = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Serie.ToString(), "E");
		return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + ";Jet OLEDB:Database Password=" + password + ";";
	}

	private static PostgreSqlParameterValue Param(string name, object value, DbType type) => new PostgreSqlParameterValue(name, value ?? DBNull.Value, type);
	private static object DbValue(object value) => value == null || value == DBNull.Value ? null : Convert.ToString(value).Trim();
	private static object NullableInt(object value) => value == null || value == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(value)) ? null : (object)Convert.ToInt32(value, CultureInfo.InvariantCulture);

	private static bool BooleanValue(object value)
	{
		if (value == null || value == DBNull.Value) return false;
		if (value is bool boolean) return boolean;
		string text = Convert.ToString(value).Trim();
		return text == "1" || text.Equals("true", StringComparison.OrdinalIgnoreCase) || text.Equals("si", StringComparison.OrdinalIgnoreCase);
	}

	private static object TimeText(object value)
	{
		if (value == null || value == DBNull.Value) return null;
		if (value is DateTime dateTime) return dateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
		if (value is TimeSpan timeSpan) return timeSpan.ToString(@"hh\:mm\:ss", CultureInfo.InvariantCulture);
		string text = Convert.ToString(value).Trim();
		return text.Length > 8 ? text.Substring(0, 8) : text;
	}
}
