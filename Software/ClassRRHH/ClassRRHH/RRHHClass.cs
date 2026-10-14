using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RRHH.PostgreSql;

namespace ClassRRHH;

public class RRHHClass
{
	public SqlConnection ObjCnn;

	public SqlDataAdapter objDA;

	private readonly PostgreSqlExecutor _database;

	private int mCodigoEmpleado;

	private int mAnio;

	public int CodigoEmpleado
	{
		get
		{
			return mCodigoEmpleado;
		}
		set
		{
			mCodigoEmpleado = value;
		}
	}

	public int Anio
	{
		get
		{
			return mAnio;
		}
		set
		{
			mAnio = value;
		}
	}

	public RRHHClass()
		: this(new PostgreSqlExecutor())
	{
	}

	public RRHHClass(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
		// Se conserva temporalmente para los controles Ubigeo heredados de GRLL.
		// Las operaciones de RRHH de esta clase usan PostgreSQL.
		ObjCnn = clsConexion.Conexion;
		objDA = new SqlDataAdapter();
		mAnio = 2011;
	}

	public object llena_DocID()
	{
		return _database.Query(
			"SELECT \"TipoDocID\", \"Descripcion\" FROM public.\"TipoDocID\" ORDER BY \"Descripcion\";");
	}

	public object llena_Area()
	{
		return _database.Query(
			"SELECT \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +
			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";",
			new PostgreSqlParameterValue("year", mAnio));
	}

	public object llena_Nacionalidad()
	{
		return _database.Query(
			"SELECT \"IdNacionalidad\", \"Descripcion\" FROM public.\"Nacionalidad\" ORDER BY \"Descripcion\";");
	}

	public object llena_Discapacidad()
	{
		return _database.Query(
			"SELECT \"IdDiscapacidad\", \"Descrip_Discapacidad\" FROM public.\"Discapacidad\" " +
			"ORDER BY \"Descrip_Discapacidad\";");
	}

	public object llena_estCivil()
	{
		return _database.Query(
			"SELECT \"IdEstadoCivil\", \"DescripEstCivil\" FROM public.\"EstadoCivil\" " +
			"ORDER BY \"DescripEstCivil\";");
	}

	public int SgtIdPermiso(int idempleado)
	{
		return _database.ScalarInt(
			"SELECT COALESCE(MAX(\"NPermiso\"), 0) + 1 FROM public.\"Permiso\" WHERE \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", idempleado));
	}

	public int SgtIdHorarioTemporal(int idempleado)
	{
		return _database.ScalarInt(
			"SELECT COALESCE(MAX(\"N\"), 0) + 1 FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", idempleado));
	}

	public bool importarBio(string FechaInicial, string FechaFinal)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("spRRHH_ImportarAsistenciaBio", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.VarChar).Value = FechaInicial;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.VarChar).Value = FechaFinal;
		objDA.SelectCommand.CommandTimeout = 0;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return true;
	}

	public int ExisteMarcacion(int idempleado, string fecha)
	{
		return _database.ScalarInt(
			"SELECT COUNT(*) FROM public.\"Marcacion\" WHERE \"Fecha\" = @fecha AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha), DbType.DateTime),
			new PostgreSqlParameterValue("empleadoId", idempleado));
	}

	public int ExisteAsistencia(int idempleado, string fecha)
	{
		return _database.ScalarInt(
			"SELECT COUNT(*) FROM public.\"Asistencia\" WHERE \"Fecha\" = @fecha AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha), DbType.DateTime),
			new PostgreSqlParameterValue("empleadoId", idempleado));
	}

	public bool ElimnarPermiso(int idempleado, int NPermiso)
	{
		_database.Execute(
			"DELETE FROM public.\"Permiso\" WHERE \"IdEmpleado\" = @empleadoId AND \"NPermiso\" = @numero;",
			new PostgreSqlParameterValue("empleadoId", idempleado),
			new PostgreSqlParameterValue("numero", NPermiso));
		return true;
	}

	public bool eliminarHorarioTemporal(int idempleado, int NPermiso)
	{
		_database.Execute(
			"DELETE FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\" = @empleadoId AND \"N\" = @numero;",
			new PostgreSqlParameterValue("empleadoId", idempleado),
			new PostgreSqlParameterValue("numero", NPermiso));
		return true;
	}

	public DataTable llenar_Empleado_Area(int idEmpleado)
	{
		return _database.Query("""
SELECT ea."Year", ea."idAreaOrganiz", eo."AreaOrganizacional"
FROM public."Empleado_Area" AS ea
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE ea."IdEmpleado" = @empleadoId
ORDER BY ea."Year" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", idEmpleado));
	}

	public void Actualizar_Area_Empleado(int idEmpleado, int Anio, int idAreaOrganiz)
	{
		_database.Execute(
			"UPDATE public.\"Empleado_Area\" SET \"idAreaOrganiz\" = @areaId " +
			"WHERE \"Year\" = @year AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("areaId", idAreaOrganiz),
			new PostgreSqlParameterValue("year", Anio),
			new PostgreSqlParameterValue("empleadoId", idEmpleado));
	}

	public DataTable llenar_Areas_by_año(int Anio)
	{
		return _database.Query(
			"SELECT \"Year\", \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +
			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";",
			new PostgreSqlParameterValue("year", Anio));
	}

	public DataTable buscar_empleado(int? codigo, string numdoc, string apellido, int? idTipoTrabajador, int activo, int idRol = 0)
	{
		const string sql = """
SELECT
    e."IdTipoTrabajador",
    e."IdEmpleado" AS "Codigo",
    p."NumDocID" AS "DNI",
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    eo."AreaOrganizacional",
    c."Cargo" AS "cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = @estado
  AND (@apellido = '' OR btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) ILIKE @apellido || '%')
  AND (@numeroDocumento = '' OR btrim(p."NumDocID") = btrim(@numeroDocumento))
  AND (@empleadoId IS NULL OR e."IdEmpleado" = @empleadoId)
  AND (@year IS NULL OR ea."Year" = @year)
  AND (
      (@rol = 3 AND e."IdTipoTrabajador" = 2)
      OR (@rol = 4 AND e."IdTipoTrabajador" IN (1, 3, 4, 5))
      OR (@rol NOT IN (3, 4) AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador))
  )
ORDER BY "NombresCompletos";
""";

		return _database.Query(
			sql,
			new PostgreSqlParameterValue("estado", activo == 0 ? "0" : "1"),
			new PostgreSqlParameterValue("apellido", apellido ?? string.Empty),
			new PostgreSqlParameterValue("numeroDocumento", numdoc ?? string.Empty),
			new PostgreSqlParameterValue("empleadoId", codigo, DbType.Int32),
			new PostgreSqlParameterValue("year", mAnio),
			new PostgreSqlParameterValue("rol", idRol),
			new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32));
	}

	public DataTable BuscarEmpleado_Codigo(int codigo)
	{
		const string sql = """
SELECT
    p."Nombres", p."Apellido_Paterno", p."Apellido_Materno", e."Sexo",
    p."TipoDocID", p."NumDocID", e."IdNacionalidad", p."FechaNacimiento",
    p."Telefono", p."NumCelular", p."FonoCentroLab", p."Fax",
    e."IdEstadoCivil", e."IdDiscapacidad", p."IdUbigeo", p."Direccion",
    p."UbigeoDireccion", e."ExpSocial", e."Foto", e."IdPersona",
    e."Year", e."idAreaOrganiz", p."FechaRegistro", p."Email",
    e."IdTipoSangre", e."GradoInstruccion", e."NumLibretaMilitar",
    e."Brevete", e."NumRUC", e."idHorario", e."IdTipoTrabajador"
FROM public."Persona" AS p
INNER JOIN public."Empleado" AS e ON e."IdPersona" = p."IdPersona"
WHERE e."IdEmpleado" = @empleadoId;
""";

		return _database.Query(
			sql,
			new PostgreSqlParameterValue("empleadoId", codigo));
	}

	public bool ActualizaAsistencia(int idEmpleado, DateTime fecha, string hor_sal, bool flag_sal)
	{
		_database.Execute(
			"UPDATE public.\"Asistencia\" SET \"Hor_Sal\" = @horaSalida, \"Flag_Sal\" = @salidaManual " +
			"WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\" = @fecha;",
			new PostgreSqlParameterValue("horaSalida", hor_sal),
			new PostgreSqlParameterValue("salidaManual", flag_sal),
			new PostgreSqlParameterValue("empleadoId", idEmpleado),
			new PostgreSqlParameterValue("fecha", fecha, DbType.DateTime));
		return true;
	}

	public int ExistePermiso(int idEmpleado, string FechaInicio, string FechaFin)
	{
		return _database.ScalarInt("""
SELECT COUNT(*)
FROM public."Permiso"
WHERE "IdEmpleado" = @empleadoId
  AND (@fechaInicio::date BETWEEN "FechaInicio"::date AND "FechaFin"::date
       OR @fechaFin::date BETWEEN "FechaInicio"::date AND "FechaFin"::date);
""",
			new PostgreSqlParameterValue("empleadoId", idEmpleado),
			new PostgreSqlParameterValue("fechaInicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fechaFin", ParseCompactDate(FechaFin), DbType.Date));
	}

	public void ingresa_Empleado_Area(int year, int idorganiz, int idEmpleado)
	{
		_database.Execute(
			"INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +
			"VALUES (@year, @areaId, @empleadoId);",
			new PostgreSqlParameterValue("year", year),
			new PostgreSqlParameterValue("areaId", idorganiz),
			new PostgreSqlParameterValue("empleadoId", idEmpleado));
	}

	public int Ingresa_Empleado(int year, int idorganiz, int TipoDocIdent, string NumDoc, string Apellido_Paterno, string Apellido_Materno, string Nombres, string ubigeoNac, DateTime fechaNac, string Direccion, string Fono, string FonoLab, string FonoCel, string FonoOtro, string Mail, string UbigeoDireccion, int idNacionalidad, string sexo, int idEstCivil, int idDiscapacidad, string expSocial, DateTime FechaIngreso, int tiposangre, string brevete, string libmilitar, string gradoinstruccion, string numRuc, int idtipoTrabajador, byte[] Foto)
	{
		return _database.InTransaction(transaction =>
		{
			// El esquema migrado no trae secuencias. El bloqueo evita IDs repetidos
			// mientras se reemplaza el procedimiento cifrado spRRHH_GrabarEmpleado.
			transaction.Execute("SELECT pg_advisory_xact_lock(721104);");
			int personaId = transaction.ScalarInt(
				"SELECT COALESCE(MAX(\"IdPersona\"), 0) + 1 FROM public.\"Persona\";");
			int empleadoId = transaction.ScalarInt(
				"SELECT COALESCE(MAX(\"IdEmpleado\"), 0) + 1 FROM public.\"Empleado\";");

			transaction.Execute("""
INSERT INTO public."Persona"
    ("IdPersona", "Nombres", "Apellido_Paterno", "Apellido_Materno", "TipoDocID", "NumDocID",
     "Direccion", "Telefono", "Fax", "Email", "IdUbigeo", "UbigeoDireccion", "TipoPersona",
     "FechaNacimiento", "FechaRegistro", "NumCelular", "FonoCentroLab")
VALUES
    (@personaId, @nombres, @apellidoPaterno, @apellidoMaterno, @tipoDoc, @numeroDoc,
     @direccion, @telefono, @fax, @email, @ubigeoNacimiento, @ubigeoDireccion, 'N',
     @fechaNacimiento, @fechaRegistro, @celular, @telefonoLaboral);
""",
				new PostgreSqlParameterValue("personaId", personaId),
				Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno),
				Text("apellidoMaterno", Apellido_Materno),
				new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc),
				Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro),
				Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac),
				Text("ubigeoDireccion", UbigeoDireccion),
				new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime),
				new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime),
				Text("celular", FonoCel), Text("telefonoLaboral", FonoLab));

			transaction.Execute("""
INSERT INTO public."Empleado"
    ("IdEmpleado", "Year", "idAreaOrganiz", "IdPersona", "ExpSocial", "FechaIngreso",
     "Brevete", "IdEstadoCivil", "Sexo", "IdTipoSangre", "Foto", "IdTipoTrabajador",
     "Estado", "IdDiscapacidad", "IdNacionalidad", "NumLibretaMilitar", "GradoInstruccion", "NumRUC")
VALUES
    (@empleadoId, @year, @areaId, @personaId, @expSocial, @fechaIngreso,
     @brevete, @estadoCivil, @sexo, @tipoSangre, @foto, @tipoTrabajador,
     '1', @discapacidad, @nacionalidad, @libretaMilitar, @gradoInstruccion, @ruc);
""",
				new PostgreSqlParameterValue("empleadoId", empleadoId),
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz),
				new PostgreSqlParameterValue("personaId", personaId),
				Text("expSocial", expSocial),
				new PostgreSqlParameterValue("fechaIngreso", FechaIngreso, DbType.DateTime),
				Text("brevete", brevete), new PostgreSqlParameterValue("estadoCivil", idEstCivil),
				Text("sexo", sexo), new PostgreSqlParameterValue("tipoSangre", tiposangre),
				Text("foto", EncodePhoto(Foto)),
				NullableInt("tipoTrabajador", idtipoTrabajador),
				new PostgreSqlParameterValue("discapacidad", idDiscapacidad),
				NullableInt("nacionalidad", idNacionalidad), Text("libretaMilitar", libmilitar),
				Text("gradoInstruccion", gradoinstruccion), Text("ruc", numRuc));

			transaction.Execute(
				"INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +
				"VALUES (@year, @areaId, @empleadoId);",
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz),
				new PostgreSqlParameterValue("empleadoId", empleadoId));

			return empleadoId;
		});
	}

	public void Actualiza_Empleado(int codpersona, int codempleado, int year, int idorganiz, int TipoDocIdent, string NumDoc, string Apellido_Paterno, string Apellido_Materno, string Nombres, string ubigeoNac, DateTime fechaNac, string Direccion, string Fono, string FonoLab, string FonoCel, string FonoOtro, string Mail, string UbigeoDireccion, int idNacionalidad, string sexo, int idEstCivil, int idDiscapacidad, string expSocial, DateTime FechaIngreso, int tiposangre, string brevete, string libmilitar, string gradoinstruccion, string numRuc, int idtipoTrabajador, byte[] Foto)
	{
		_database.InTransaction(transaction =>
		{
			transaction.Execute("""
UPDATE public."Persona" SET
    "Nombres" = @nombres, "Apellido_Paterno" = @apellidoPaterno,
    "Apellido_Materno" = @apellidoMaterno, "TipoDocID" = @tipoDoc,
    "NumDocID" = @numeroDoc, "Direccion" = @direccion, "Telefono" = @telefono,
    "Fax" = @fax, "Email" = @email, "IdUbigeo" = @ubigeoNacimiento,
    "UbigeoDireccion" = @ubigeoDireccion, "TipoPersona" = 'N',
    "FechaNacimiento" = @fechaNacimiento, "FechaRegistro" = @fechaRegistro,
    "NumCelular" = @celular, "FonoCentroLab" = @telefonoLaboral
WHERE "IdPersona" = @personaId;
""",
				Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno),
				Text("apellidoMaterno", Apellido_Materno),
				new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc),
				Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro),
				Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac),
				Text("ubigeoDireccion", UbigeoDireccion),
				new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime),
				new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime),
				Text("celular", FonoCel), Text("telefonoLaboral", FonoLab),
				new PostgreSqlParameterValue("personaId", codpersona));

			transaction.Execute("""
UPDATE public."Empleado" SET
    "Year" = @year, "idAreaOrganiz" = @areaId, "ExpSocial" = @expSocial,
    "IdEstadoCivil" = @estadoCivil, "Sexo" = @sexo, "Foto" = @foto,
    "IdDiscapacidad" = @discapacidad, "IdNacionalidad" = @nacionalidad,
    "Estado" = '1', "IdTipoSangre" = @tipoSangre, "Brevete" = @brevete,
    "NumLibretaMilitar" = @libretaMilitar, "GradoInstruccion" = @gradoInstruccion,
    "NumRUC" = @ruc, "IdTipoTrabajador" = @tipoTrabajador
WHERE "IdEmpleado" = @empleadoId;
""",
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz), Text("expSocial", expSocial),
				new PostgreSqlParameterValue("estadoCivil", idEstCivil), Text("sexo", sexo),
				Text("foto", EncodePhoto(Foto)),
				new PostgreSqlParameterValue("discapacidad", idDiscapacidad),
				NullableInt("nacionalidad", idNacionalidad),
				new PostgreSqlParameterValue("tipoSangre", tiposangre), Text("brevete", brevete),
				Text("libretaMilitar", libmilitar), Text("gradoInstruccion", gradoinstruccion),
				Text("ruc", numRuc), NullableInt("tipoTrabajador", idtipoTrabajador),
				new PostgreSqlParameterValue("empleadoId", codempleado));

			return true;
		});
	}

	public void Actualiza_Empleado(int codempleado)
	{
		// La aplicación histórica conserva empleados relacionados con nómina,
		// por eso la eliminación se implementa como baja lógica.
		_database.Execute(
			"UPDATE public.\"Empleado\" SET \"Estado\" = '0' WHERE \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", codempleado));
	}

	public object llena_tree()
	{
		return _database.Query(
			"SELECT \"idAreaOrganiz\" AS \"Padre\", \"AreaOrganizacional\", \"idDependeDe\" AS \"Hijo\" " +
			"FROM public.\"EstructOrganiz\" WHERE \"Year\" = @year;",
			new PostgreSqlParameterValue("year", mAnio));
	}

	public DataTable buscar_empleado_tree(int area, int tipotrab)
	{
		return _database.Query("""
SELECT
    e."IdTipoTrabajador",
    e."IdEmpleado" AS "Codigo",
    p."NumDocID" AS "DNI",
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    c."Cargo" AS "Cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE ea."idAreaOrganiz" = @areaId
  AND ea."Year" = @year
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND (@tipoTrabajador = 0 OR e."IdTipoTrabajador" = @tipoTrabajador)
ORDER BY "NombresCompletos";
""",
			new PostgreSqlParameterValue("areaId", area),
			new PostgreSqlParameterValue("year", mAnio),
			new PostgreSqlParameterValue("tipoTrabajador", tipotrab));
	}

	public object Generar_Ficha(int codEmple)
	{
		ObjCnn.Open();
		DataSet dt_Generar_Ficha = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_fichaSocial", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@codEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_Generar_Ficha, "FichaSocial");
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_ExpLab", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@codEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_Generar_Ficha, "FichaSocialExp");
		ObjCnn.Close();
		return dt_Generar_Ficha;
	}

	public object Generar_Ficha_Prueba(int codEmple)
	{
		ObjCnn.Open();
		DataSet ds_Generar_Ficha = new DataSet();
		ds_Generar_Ficha.Clear();
		DataTable dt_DatosLaborales = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_ExpLab_Datos", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_DatosLaborales);
		if (dt_DatosLaborales.Rows.Count >= 1)
		{
			dt_DatosLaborales.TableName = "spRRHH_Ficha_ExpLab_Datos";
			ds_Generar_Ficha.Tables.Add(dt_DatosLaborales);
		}
		DataTable dt_DatosDisciplinario = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_busca_Disciplina", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_DatosDisciplinario);
		if (dt_DatosDisciplinario.Rows.Count >= 1)
		{
			dt_DatosDisciplinario.TableName = "spRRHH_busca_Disciplina";
			ds_Generar_Ficha.Tables.Add(dt_DatosDisciplinario);
		}
		DataTable dt_ExpLaborales = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_ExpLab", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_ExpLaborales);
		if (dt_ExpLaborales.Rows.Count >= 1)
		{
			dt_ExpLaborales.TableName = "spRRHH_Ficha_ExpLab";
			ds_Generar_Ficha.Tables.Add(dt_ExpLaborales);
		}
		DataTable dt_DetFam = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Det_Familiar", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_DetFam);
		if (dt_DetFam.Rows.Count >= 1)
		{
			dt_DetFam.TableName = "spRRHH_Ficha_Det_Familiar";
			ds_Generar_Ficha.Tables.Add(dt_DetFam);
		}
		DataTable dt_EstRealizado = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Estudio_Realizado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_EstRealizado);
		if (dt_EstRealizado.Rows.Count >= 1)
		{
			dt_EstRealizado.TableName = "spRRHH_Ficha_Estudio_Realizado";
			ds_Generar_Ficha.Tables.Add(dt_EstRealizado);
		}
		DataTable dt_EstTitulo = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Estudio_Titulo", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_EstTitulo);
		if (dt_EstTitulo.Rows.Count >= 1)
		{
			dt_EstTitulo.TableName = "spRRHH_Ficha_Estudio_Titulo";
			ds_Generar_Ficha.Tables.Add(dt_EstTitulo);
		}
		DataTable dt_EstCapacitacion = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Estudio_Capacitacion", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_EstCapacitacion);
		if (dt_EstCapacitacion.Rows.Count >= 1)
		{
			dt_EstCapacitacion.TableName = "spRRHH_Ficha_Estudio_Capacitacion";
			ds_Generar_Ficha.Tables.Add(dt_EstCapacitacion);
		}
		DataTable dt_IngresoEgreso = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Ingreso_Egreso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_IngresoEgreso);
		if (dt_IngresoEgreso.Rows.Count >= 1)
		{
			dt_IngresoEgreso.TableName = "spRRHH_Ficha_Ingreso_Egreso";
			ds_Generar_Ficha.Tables.Add(dt_IngresoEgreso);
		}
		DataTable dt_vivienda = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Vivienda", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(dt_vivienda);
		if (dt_vivienda.Rows.Count >= 1)
		{
			dt_vivienda.TableName = "spRRHH_Ficha_Vivienda";
			ds_Generar_Ficha.Tables.Add(dt_vivienda);
		}
		DataTable spRRHH_Ficha_DatosPersonales = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_DatosPersonales", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(spRRHH_Ficha_DatosPersonales);
		if (spRRHH_Ficha_DatosPersonales.Rows.Count >= 1)
		{
			spRRHH_Ficha_DatosPersonales.TableName = "spRRHH_Ficha_DatosPersonales";
			ds_Generar_Ficha.Tables.Add(spRRHH_Ficha_DatosPersonales);
		}
		DataTable spRRHH_Ficha_Det_Familiar_Salud = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Ficha_Det_Familiar_Salud", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodEmple", SqlDbType.Int).Value = codEmple;
		objDA.Fill(spRRHH_Ficha_Det_Familiar_Salud);
		if (spRRHH_Ficha_DatosPersonales.Rows.Count >= 1)
		{
			spRRHH_Ficha_Det_Familiar_Salud.TableName = "spRRHH_Ficha_Det_Familiar_Salud";
			ds_Generar_Ficha.Tables.Add(spRRHH_Ficha_Det_Familiar_Salud);
		}
		ObjCnn.Close();
		return ds_Generar_Ficha;
	}

	public object Generar_Cuadro_Pers(int tipo)
	{
		ObjCnn.Open();
		DataSet dt_Generar_Cuadro = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_Report_CuadroPer", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@Tipo", SqlDbType.Int).Value = tipo;
		objDA.Fill(dt_Generar_Cuadro, "Cuadro");
		ObjCnn.Close();
		return dt_Generar_Cuadro;
	}

	public object Generar_Cumples(int mes)
	{
		ObjCnn.Open();
		DataSet dt_Generar_Cumple = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_Report_Cumple", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
		objDA.Fill(dt_Generar_Cumple, "spRRHH_Report_Cumple");
		ObjCnn.Close();
		return dt_Generar_Cumple;
	}

	public object llena_tree_reporte()
	{
		ObjCnn.Open();
		DataTable dt_Vista_Tree = new DataTable();
		objDA.SelectCommand = new SqlCommand("Select AreaOrganizacional,siglafull,IdAreaOrganiz As Padre,IdDependeDe as Hijo from vEstructOrganiz where Year=" + Conversions.ToString(mAnio), ObjCnn);
		objDA.Fill(dt_Vista_Tree);
		ObjCnn.Close();
		return dt_Vista_Tree;
	}

	public object Generar_Report_oficina(int CodOficina)
	{
		ObjCnn.Open();
		DataSet ds_Generar_Oficina = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_Report_Oficina_Unico", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idarea", SqlDbType.Int).Value = CodOficina;
		objDA.Fill(ds_Generar_Oficina, "spRRHH_Report_Oficina_Unico");
		ObjCnn.Close();
		return ds_Generar_Oficina;
	}

	public object Generar_Report_oficina_Dep(string Sigla)
	{
		ObjCnn.Open();
		DataSet ds_Generar_Dep = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_Report_Oficina", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@sigla", SqlDbType.VarChar).Value = Sigla;
		objDA.Fill(ds_Generar_Dep, "spRRHH_Report_Oficina");
		ObjCnn.Close();
		return ds_Generar_Dep;
	}

	public object Generar_Report_Emple_ficha(string FechaInicio, string Fechatermino, int tipo)
	{
		ObjCnn.Open();
		DataSet ds_Generar_Dep = new DataSet();
		objDA.SelectCommand = new SqlCommand("spRRHH_Report_FechaIngreso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaIni", SqlDbType.Char, 8).Value = FechaInicio;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.Char, 8).Value = Fechatermino;
		objDA.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
		objDA.Fill(ds_Generar_Dep, "spRRHH_Report_FechaIngreso");
		int x = ds_Generar_Dep.Tables[0].Rows.Count;
		ObjCnn.Close();
		return ds_Generar_Dep;
	}

	public DataTable generar_rep_cargos(int idCargo)
	{
		return _database.Query("""
SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",
       eo."AreaOrganizacional", c."Cargo" AS "cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = e."idAreaOrganiz" AND eo."Year" = e."Year"
INNER JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE e."IdCargo" = @cargoId
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND e."IdTipoTrabajador" = 1;
""",
			new PostgreSqlParameterValue("cargoId", idCargo));
	}

	public object llena_Asistencias(string fechaInicio, string fechaFin)
	{
		ObjCnn.Open();
		DataTable dt_des_DI = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_GetRepAsistencias", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.VarChar).Value = fechaInicio;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.VarChar).Value = fechaFin;
		objDA.Fill(dt_des_DI);
		ObjCnn.Close();
		return dt_des_DI;
	}

	public object llena_Permisos(int codempleado, int? permiso, int? motivo)
	{
		return _database.Query("""
SELECT tp."DescripTipoPermiso", m."Descrip_Motivo", p."NPermiso",
       p."FechaInicio", p."FechaFin", p."Hora_Sal", p."Hora_Ret", p."Dia",
       p."Retorno", p."Lugar", p."Referencia", p."Autorizacion", p."IdEmpleado"
FROM public."Permiso" AS p
INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"
INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
WHERE p."IdEmpleado" = @empleadoId
  AND (@tipoPermiso IS NULL OR tp."idTipoPermiso" = @tipoPermiso)
  AND (@motivo IS NULL OR m."idMotivo" = @motivo)
ORDER BY p."FechaInicio" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", codempleado),
			new PostgreSqlParameterValue("tipoPermiso", permiso, DbType.Int32),
			new PostgreSqlParameterValue("motivo", motivo, DbType.Int32));
	}

	public object llena_HorariosTemporales(int codempleado)
	{
		return _database.Query("""
SELECT ht."N", ht."FechaInicio", ht."FechaFin", h."Descrip_Horario",
       h."Ingreso1", h."Salida2", ht."NroDocumento", ht."Sisgedo"
FROM public."HorarioTemporal" AS ht
INNER JOIN public."Horario" AS h ON h."idHorario" = ht."HorarioAsignado"
WHERE ht."idEmpleado" = @empleadoId
ORDER BY ht."FechaInicio" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", codempleado));
	}

	public object Generar_Rep_Faltas(string fecha, int? idTipoTrabajador, int? idAreaOrganiz, int? Año)
	{
		DataTable result = _database.Query("""
SELECT btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC",
       p."NumDocID", p."IdPersona", e."IdEmpleado", ea."Year", ea."idAreaOrganiz",
       e."IdTipoTrabajador", e."Estado", eo."AreaOrganizacional", tt."Descripcion",
       NULL::timestamp AS "Fecha"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
LEFT JOIN public."TipoTrabajador" AS tt ON tt."IdTipoTrabajador" = e."IdTipoTrabajador"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)
  AND (@areaId IS NULL OR ea."idAreaOrganiz" = @areaId)
  AND (@year IS NULL OR ea."Year" = @year)
  AND NOT EXISTS (
      SELECT 1 FROM public."Asistencia" AS a
      WHERE a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha
  )
ORDER BY "NombresC";
""",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha).Date, DbType.Date),
			new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32),
			new PostgreSqlParameterValue("areaId", idAreaOrganiz, DbType.Int32),
			new PostgreSqlParameterValue("year", Año, DbType.Int32));
		result.TableName = "spRRHH_Faltas";
		return result;
	}

	public object ObtenerAsistenciasxDia(string fecha)
	{
		DataTable result = _database.Query("""
SELECT a."Fecha", e."IdEmpleado",
       CASE WHEN a."IdEmpleado" IS NULL THEN 'F' ELSE 'A' END AS "Estado"
FROM public."Empleado" AS e
LEFT JOIN public."Asistencia" AS a
    ON a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
ORDER BY e."IdEmpleado";
""",
			new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date));
		result.TableName = "spRRHH_GetAsistencias";
		return result;
	}

	public object ObtenerEmpleados()
	{
		return _database.Query("""
SELECT e."IdEmpleado" AS "idempleado",
       btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
ORDER BY "NombresC";
""");
	}

	public object LlenarPlanillaAsistencia(string fechas, string idTipoTrabajador, string idLocales)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_RepPlanillaAsistencias", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@Fechas", SqlDbType.NVarChar).Value = fechas;
		objDA.SelectCommand.Parameters.Add("@idTipoTrabajador", SqlDbType.Char).Value = idTipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@idLocales", SqlDbType.NVarChar).Value = idLocales;
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public DataTable GetFeriado(string fecha)
	{
		return _database.Query(
			"SELECT * FROM public.\"RRHH_Feriado\" WHERE \"Fecha\"::date = @fecha;",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha).Date, DbType.Date));
	}

	public DataTable spRRHH_RepPermisos(string fechaI, string fechaF, int? tipopermiso, int? motivo, int? idTipoTrabajador)
	{
		DataTable result = _database.Query("""
SELECT
    btrim(concat_ws(' ', pe."Apellido_Paterno", pe."Apellido_Materno", pe."Nombres")) AS "Nombres",
    c."Cargo", eo."AreaOrganizacional", m."Descrip_Motivo",
    p."FechaInicio", p."FechaFin", COALESCE(p."Hora_Sal", '--') AS "Hora_Sal",
    COALESCE(p."Hora_Ret", '--') AS "Hora_ret", COALESCE(p."Lugar", 'No Especifica') AS "Lugar",
    COALESCE(p."Obs", '--') AS "Observaciones"
FROM public."Permiso" AS p
INNER JOIN public."Empleado" AS e ON e."IdEmpleado" = p."IdEmpleado"
INNER JOIN public."Persona" AS pe ON pe."IdPersona" = e."IdPersona"
INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"
INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
INNER JOIN public."Empleado_Area" AS ea
    ON ea."IdEmpleado" = e."IdEmpleado" AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE p."FechaInicio"::date BETWEEN @fechaInicio AND @fechaFin
  AND (@tipoPermiso IS NULL OR m."idTipoPermiso" = @tipoPermiso)
  AND (@motivo IS NULL OR p."idMotivo" = @motivo)
  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)
ORDER BY p."FechaInicio";
""",
			new PostgreSqlParameterValue("fechaInicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fechaFin", ParseCompactDate(fechaF), DbType.Date),
			new PostgreSqlParameterValue("tipoPermiso", tipopermiso, DbType.Int32),
			new PostgreSqlParameterValue("motivo", motivo, DbType.Int32),
			new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32));
		result.TableName = "spRRHH_RepPermisos";
		return result;
	}

	public object spRRHH_ObtenerHorasExtras(string fechaI, string fechaF, int? tipo)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_ObtenerHorasExtras", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaI", SqlDbType.NVarChar).Value = fechaI;
		objDA.SelectCommand.Parameters.Add("@FechaF", SqlDbType.NVarChar).Value = fechaF;
		objDA.SelectCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
		dt_Generar_Faltas.TableName = "spRRHH_ObtenerHorasExtras";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public object BuscarPersonas(string ApellidoPaterno)
	{
		return _database.Query("""
SELECT "IdPersona", "Apellido_Paterno", "Apellido_Materno", "Nombres"
FROM public."Persona"
WHERE "Apellido_Paterno" ILIKE @apellido || '%' AND "TipoPersona" = 'N'
ORDER BY "Apellido_Paterno", "Apellido_Materno", "Nombres";
""",
			Text("apellido", ApellidoPaterno ?? string.Empty));
	}

	public object ListarProfesiones()
	{
		return _database.Query(
			"SELECT DISTINCT \"Profesion\" FROM public.\"Empleado\" " +
			"WHERE NULLIF(btrim(\"Profesion\"), '') IS NOT NULL ORDER BY \"Profesion\";");
	}

	public DataTable spRRHH_Rep_profesion(string profesion)
	{
		return _database.Query("""
SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",
       eo."AreaOrganizacional", e."Profesion"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE e."Profesion" = @profesion
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
  AND e."IdTipoTrabajador" = 1;
""",
			Text("profesion", profesion));
	}

	public DataTable spRRHH_ListarTrabajadores(int idTipoTrabajador)
	{
		return ListarTrabajadoresReporte(idTipoTrabajador, false);
	}

	public DataTable spRRHH_ListarTrabajadoresRep(int idTipoTrabajador)
	{
		return ListarTrabajadoresReporte(idTipoTrabajador, true);
	}

	public DataTable spRRHH_AgregarReporte(int idTipoTrabajador, int opcion)
	{
		if (opcion == 1)
		{
			_database.Execute("""
INSERT INTO public."AuxRRHH_ReporteAsistencia" ("idEmpleado")
SELECT @empleadoId
WHERE NOT EXISTS (
    SELECT 1 FROM public."AuxRRHH_ReporteAsistencia" WHERE "idEmpleado" = @empleadoId
);
""",
				new PostgreSqlParameterValue("empleadoId", idTipoTrabajador));
		}
		else if (opcion == 2)
		{
			_database.Execute(
				"DELETE FROM public.\"AuxRRHH_ReporteAsistencia\" WHERE \"idEmpleado\" = @empleadoId;",
				new PostgreSqlParameterValue("empleadoId", idTipoTrabajador));
		}

		return new DataTable("spRRHH_AgregarReporte");
	}

	public DataTable spRRHH_RepAsisdiarria(string fechaI, string fechaF, string DNI, int? area, int? tipo, string year, string idLocales, int opt = 0)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spGetAsistenciasDetalle", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaIni", SqlDbType.NVarChar).Value = fechaI;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.NVarChar).Value = fechaF;
		objDA.SelectCommand.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = DNI;
		objDA.SelectCommand.Parameters.Add("@opt", SqlDbType.Int).Value = opt;
		objDA.SelectCommand.Parameters.Add("@TipoEmpleado", SqlDbType.Int).Value = tipo;
		objDA.SelectCommand.Parameters.Add("@idLocales", SqlDbType.NVarChar).Value = idLocales;
		objDA.SelectCommand.Parameters.Add("@Area", SqlDbType.Int).Value = area;
		dt_Generar_Faltas.TableName = "spGetAsistenciasDetalle";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public DataTable spRRHH_ListarMotivos_byTipo(string fechaI)
	{
		DataTable result = _database.Query("""
SELECT "Abrev", "Descrip_Motivo"
FROM public."Motivo_Perm"
WHERE COALESCE("Activo", FALSE) AND "TipoModalidad" = @modalidad AND "Abrev" <> '1'
ORDER BY "Abrev";
""",
			Text("modalidad", fechaI));
		result.TableName = "spRRHH_ListarMotivos_byTipo";
		return result;
	}

	public DataTable spRRHH_EstadisticaPermiso(string IdTipoTrabajador, string FechaInicio, string FechaFin, string idMotivos, string Motivos, string MotivosNull, string idAreas)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_EstadisticaPermiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdTipoTrabajador", SqlDbType.Int).Value = IdTipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.NVarChar).Value = FechaInicio;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.NVarChar).Value = FechaFin;
		objDA.SelectCommand.Parameters.Add("@idMotivos", SqlDbType.NVarChar).Value = idMotivos;
		objDA.SelectCommand.Parameters.Add("@Motivos", SqlDbType.NVarChar).Value = Motivos;
		objDA.SelectCommand.Parameters.Add("@MotivosNull", SqlDbType.NVarChar).Value = MotivosNull;
		objDA.SelectCommand.Parameters.Add("@idAreas", SqlDbType.NVarChar).Value = idAreas;
		dt_Generar_Faltas.TableName = "spRRHH_EstadisticaPermiso";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public DataTable spRRHH_ResumenEstadisticaPermiso(string FechaInicio, string FechaFin, int idMotivo, int idArea)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_ResumenEstadisticaPermiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idAreaOrganiz", SqlDbType.Int).Value = idArea;
		objDA.SelectCommand.Parameters.Add("@idMotivo", SqlDbType.NVarChar).Value = idMotivo;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.NVarChar).Value = FechaInicio;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.NVarChar).Value = FechaFin;
		dt_Generar_Faltas.TableName = "spRRHH_ResumenEstadisticaPermiso";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public DataTable spRRHH_GetAsistenciaDia(int codigo, string fecha)
	{
		return _database.Query(
			"SELECT * FROM public.\"Asistencia\" WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\"::date = @fecha;",
			new PostgreSqlParameterValue("empleadoId", codigo),
			new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date));
	}

	private DataTable ListarTrabajadoresReporte(int tipoTrabajador, bool incluidos)
	{
		string membership = incluidos ? "IN" : "NOT IN";
		string sql = """
SELECT e."IdEmpleado",
       btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno")) || ', ' || btrim(p."Nombres") AS "NombresCompletos"
FROM public."Persona" AS p
INNER JOIN public."Empleado" AS e ON e."IdPersona" = p."IdPersona"
INNER JOIN public."Empleado_Area" AS ea
    ON ea."IdEmpleado" = e."IdEmpleado" AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
WHERE e."IdEmpleado" {0} (SELECT "idEmpleado" FROM public."AuxRRHH_ReporteAsistencia")
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND e."IdTipoTrabajador" = @tipoTrabajador
ORDER BY p."Apellido_Paterno";
""";

		return _database.Query(
			string.Format(CultureInfo.InvariantCulture, sql, membership),
			new PostgreSqlParameterValue("tipoTrabajador", tipoTrabajador));
	}

	private static PostgreSqlParameterValue Text(string name, string value)
	{
		return new PostgreSqlParameterValue(name, value, DbType.String);
	}

	private static PostgreSqlParameterValue NullableInt(string name, int value)
	{
		return new PostgreSqlParameterValue(
			name,
			value == 0 ? null : (object)value,
			DbType.Int32);
	}

	private static string EncodePhoto(byte[] photo)
	{
		return photo == null || photo.Length == 0 ? null : Convert.ToBase64String(photo);
	}

	private static DateTime ParseCompactDate(string value)
	{
		if (DateTime.TryParseExact(
			value,
			new[] { "yyyyMMdd", "ddMMyyyy", "yyyy-MM-dd", "dd/MM/yyyy" },
			CultureInfo.InvariantCulture,
			DateTimeStyles.None,
			out DateTime parsed))
		{
			return parsed.Date;
		}

		throw new FormatException($"La fecha '{value}' no tiene un formato reconocido.");
	}

	private static DateTime ParseDate(string value)
	{
		if (DateTime.TryParse(value, CultureInfo.GetCultureInfo("es-PE"), DateTimeStyles.None, out DateTime parsed) ||
			DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsed))
		{
			return parsed;
		}

		return ParseCompactDate(value);
	}
}
