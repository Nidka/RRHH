using System;
using System.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RRHH.PostgreSql;

namespace ClassRRHH;

public class RRHHClass
{
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
		_database.Execute("""
INSERT INTO public."Asistencia"
    ("Fecha","IdEmpleado","Hor_Ent","Hor_Sal","Flag_Ent","Flag_Sal","Estado","idHorario","Usuario","PC")
SELECT m."Fecha"::date, m."IdEmpleado",
       to_char(MIN(m."Fecha"),'HH24:MI:SS'), to_char(MAX(m."Fecha"),'HH24:MI:SS'),
       TRUE, COUNT(*) > 1, TRUE, MAX(m."idHorario"), 'MIGRACION_BIO', 'POSTGRESQL'
FROM public."Marcacion" m
WHERE m."Fecha"::date BETWEEN @inicio AND @fin
GROUP BY m."Fecha"::date,m."IdEmpleado"
ON CONFLICT ("Fecha","IdEmpleado") DO UPDATE SET
  "Hor_Ent"=EXCLUDED."Hor_Ent", "Hor_Sal"=EXCLUDED."Hor_Sal",
  "Flag_Ent"=EXCLUDED."Flag_Ent", "Flag_Sal"=EXCLUDED."Flag_Sal",
  "Estado"=EXCLUDED."Estado", "idHorario"=EXCLUDED."idHorario";
""", new PostgreSqlParameterValue("inicio", ParseDate(FechaInicial).Date, DbType.Date),
			new PostgreSqlParameterValue("fin", ParseDate(FechaFinal).Date, DbType.Date));
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
		return GenerarFichaPostgreSql(codEmple, false);
#if false
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
#endif
	}

	public object Generar_Ficha_Prueba(int codEmple)
	{
		return GenerarFichaPostgreSql(codEmple, true);
#if false
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
#endif
	}

	public object Generar_Cuadro_Pers(int tipo)
	{
		DataTable table = _database.Query("""
SELECT e."IdEmpleado" AS "Codigo", p."NumDocID" AS "DNI",
       btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       eo."AreaOrganizacional", c."Cargo" AS "cargo", tt."Descripcion",
       e."Estado", e."IdTipoTrabajador"
FROM public."Empleado" e
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"
LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "NombresCompletos";
""", new PostgreSqlParameterValue("year", mAnio), new PostgreSqlParameterValue("tipo", tipo));
		return DataSetWith(table, "Cuadro");
	}

	public object Generar_Cumples(int mes)
	{
		DataTable table = _database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       EXTRACT(DAY FROM p."FechaNacimiento")::integer AS "Dia",
       EXTRACT(MONTH FROM p."FechaNacimiento")::integer AS "mes",
       trim(to_char(p."FechaNacimiento", 'TMMonth')) AS "MESletras",
       EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",
       eo."AreaOrganizacional", e."Estado"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE EXTRACT(MONTH FROM p."FechaNacimiento")=@mes
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "Dia", "NombresCompletos";
""", new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("mes", mes));
		return DataSetWith(table, "spRRHH_Report_Cumple");
	}

	public object llena_tree_reporte()
	{
		return _database.Query("""
SELECT "AreaOrganizacional", COALESCE(NULLIF("Sigla",''),"Abrev") AS "siglafull",
       "idAreaOrganiz" AS "Padre", "idDependeDe" AS "Hijo"
FROM public."EstructOrganiz" WHERE "Year"=@year ORDER BY "AreaOrganizacional";
""", new PostgreSqlParameterValue("year", mAnio));
	}

	public object Generar_Report_oficina(int CodOficina)
	{
		DataTable table = ReporteOficina("ea.\"idAreaOrganiz\"=@area", new PostgreSqlParameterValue("area", CodOficina));
		return DataSetWith(table, "spRRHH_Report_Oficina_Unico");
	}

	public object Generar_Report_oficina_Dep(string Sigla)
	{
		DataTable table = ReporteOficina("(eo.\"Sigla\"=@sigla OR eo.\"Abrev\"=@sigla)", Text("sigla", Sigla));
		return DataSetWith(table, "spRRHH_Report_Oficina");
	}

	public object Generar_Report_Emple_ficha(string FechaInicio, string Fechatermino, int tipo)
	{
		DataTable table = _database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       e."FechaIngreso" AS "FechadeIngreso", eo."AreaOrganizacional",
       EXTRACT(YEAR FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "años",
       EXTRACT(MONTH FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "meses",
       EXTRACT(DAY FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "dias"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE e."FechaIngreso"::date BETWEEN @inicio AND @fin AND (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
ORDER BY e."FechaIngreso", "NombresCompletos";
""", new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(Fechatermino), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo));
		return DataSetWith(table, "spRRHH_Report_FechaIngreso");
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
		return _database.Query("""
SELECT a.*, p."NumDocID", p."Apellido_Paterno", p."Apellido_Materno", p."Nombres"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin ORDER BY a."Fecha",p."Apellido_Paterno";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaFin), DbType.Date));
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
		List<DateTime> dates = ParseDateList(fechas);
		DataTable result = new DataTable("spRRHH_RepPlanillaAsistencias");
		result.Columns.Add("IdEmpleado", typeof(int));
		result.Columns.Add("NombresC", typeof(string));
		foreach (DateTime date in dates)
		{
			result.Columns.Add(date.ToString(), typeof(string));
		}
		if (dates.Count == 0)
		{
			return result;
		}

		int tipo = int.TryParse(idTipoTrabajador, out int parsedType) ? parsedType : 0;
		int[] locales = ParseCsvIntegers(idLocales);
		DataTable source = _database.Query("""
SELECT e."IdEmpleado", btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
       a."Fecha"::date AS "Dia", a."Hor_Ent", a."Hor_Sal"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
  AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "NombresC",a."Fecha";
""", new PostgreSqlParameterValue("inicio", dates.Min(), DbType.Date),
			new PostgreSqlParameterValue("fin", dates.Max(), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("locales", locales));

		foreach (IGrouping<int, DataRow> employee in source.Rows.Cast<DataRow>().GroupBy(row => Convert.ToInt32(row["IdEmpleado"])))
		{
			DataRow target = result.NewRow();
			target["IdEmpleado"] = employee.Key;
			target["NombresC"] = employee.First()["NombresC"];
			foreach (DataRow attendance in employee.Where(row => row["Dia"] != DBNull.Value))
			{
				DateTime date = Convert.ToDateTime(attendance["Dia"]).Date;
				string column = date.ToString();
				if (result.Columns.Contains(column))
				{
					target[column] = FormatAttendance(attendance["Hor_Ent"], attendance["Hor_Sal"]);
				}
			}
			result.Rows.Add(target);
		}
		return result;
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
		DataTable result = _database.Query("""
SELECT e."IdEmpleado",p."NumDocID",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 a."Fecha",a."Hor_Ent",a."Hor_Sal",h."Salida1",
 ROUND(GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-h."Salida1"::time))/3600)::numeric,2) AS "HorasExtras"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}' AND h."Salida1" ~ '^\d{1,2}:\d{2}'
ORDER BY a."Fecha","NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo, DbType.Int32));
		result.TableName = "spRRHH_ObtenerHorasExtras";
		return result;
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
		int[] locales = ParseCsvIntegers(idLocales);
		DataTable result = _database.Query("""
SELECT a.*,p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 eo."AreaOrganizacional",l."NombreLocal"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Local" l ON l."idLocal"=e."idLocal"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin
 AND (@dni IS NULL OR p."NumDocID" ILIKE '%'||@dni||'%')
 AND (@area IS NULL OR ea."idAreaOrganiz"=@area) AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))
ORDER BY a."Fecha","NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date),
			Text("dni", string.IsNullOrWhiteSpace(DNI) ? null : DNI.Trim()),
			new PostgreSqlParameterValue("area", area, DbType.Int32),
			new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
			new PostgreSqlParameterValue("year", int.TryParse(year, out int parsedYear) ? parsedYear : DateTime.Today.Year),
			new PostgreSqlParameterValue("locales", locales));
		result.TableName = "spGetAsistenciasDetalle";
		return result;
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
		int tipo = int.TryParse(IdTipoTrabajador, out int parsedType) ? parsedType : 0;
		int area = int.TryParse(idAreas, out int parsedArea) ? parsedArea : 0;
		int[] motivos = ParseCsvIntegers(idMotivos);
		DataTable result = _database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 e."IdEmpleado",p."NumDocID",
 COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "MinutosTarde",
 eo."AreaOrganizacional",ea."idAreaOrganiz"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo) AND (@area=0 OR ea."idAreaOrganiz"=@area)
 AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",eo."AreaOrganizacional",ea."idAreaOrganiz"
ORDER BY "NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("area", area));

		DataTable permissionCounts = _database.Query("""
SELECT pe."IdEmpleado",pe."idMotivo",COUNT(*)::integer AS "Cantidad",m."Descrip_Motivo"
FROM public."Permiso" pe JOIN public."Motivo_Perm" m ON m."idMotivo"=pe."idMotivo"
WHERE pe."FechaInicio"::date <= @fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date >= @inicio
 AND (cardinality(@motivos::integer[])=0 OR pe."idMotivo"=ANY(@motivos::integer[]))
GROUP BY pe."IdEmpleado",pe."idMotivo",m."Descrip_Motivo";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("motivos", motivos));

		Dictionary<int, string> names = permissionCounts.Rows.Cast<DataRow>()
			.GroupBy(row => Convert.ToInt32(row["idMotivo"]))
			.ToDictionary(group => group.Key, group => Convert.ToString(group.First()["Descrip_Motivo"]));
		foreach (int id in motivos)
		{
			string name = names.TryGetValue(id, out string description) ? description : "Motivo_" + id;
			name = UniqueColumnName(result, name);
			result.Columns.Add(name, typeof(int));
			foreach (DataRow row in result.Rows) row[name] = 0;
			names[id] = name;
		}
		foreach (DataRow count in permissionCounts.Rows)
		{
			int id = Convert.ToInt32(count["idMotivo"]);
			if (!names.TryGetValue(id, out string name))
			{
				name = UniqueColumnName(result, Convert.ToString(count["Descrip_Motivo"]));
				result.Columns.Add(name, typeof(int));
				foreach (DataRow row in result.Rows) row[name] = 0;
				names[id] = name;
			}
			DataRow target = result.Rows.Cast<DataRow>().FirstOrDefault(row =>
				Convert.ToInt32(row["IdEmpleado"]) == Convert.ToInt32(count["IdEmpleado"]));
			if (target != null) target[name] = count["Cantidad"];
		}
		result.TableName = "spRRHH_EstadisticaPermiso";
		return result;
	}

	public DataTable spRRHH_ResumenEstadisticaPermiso(string FechaInicio, string FechaFin, int idMotivo, int idArea)
	{
		DataTable result = _database.Query("""
SELECT m."idMotivo",m."Descrip_Motivo",COUNT(pe."NPermiso")::integer AS "Cantidad",
 ROUND(CASE WHEN totals.total=0 THEN 0 ELSE COUNT(pe."NPermiso")*100.0/totals.total END,2) AS "Porcentaje"
FROM public."Motivo_Perm" m
LEFT JOIN public."Permiso" pe ON pe."idMotivo"=m."idMotivo"
 AND pe."FechaInicio"::date<=@fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date>=@inicio
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=pe."IdEmpleado" AND ea."Year"=@year
CROSS JOIN (SELECT COUNT(*)::numeric AS total FROM public."Permiso" p2
 JOIN public."Empleado_Area" ea2 ON ea2."IdEmpleado"=p2."IdEmpleado" AND ea2."Year"=@year
 WHERE p2."FechaInicio"::date<=@fin AND COALESCE(p2."FechaFin",p2."FechaInicio")::date>=@inicio
 AND (@area=0 OR ea2."idAreaOrganiz"=@area)) totals
WHERE m."idMotivo"=@motivo AND (@area=0 OR ea."idAreaOrganiz"=@area OR pe."IdEmpleado" IS NULL)
GROUP BY m."idMotivo",m."Descrip_Motivo",totals.total;
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("motivo", idMotivo), new PostgreSqlParameterValue("area", idArea));
		result.TableName = "spRRHH_ResumenEstadisticaPermiso";
		return result;
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

	private DataSet GenerarFichaPostgreSql(int empleadoId, bool completa)
	{
		PostgreSqlParameterValue employee = new PostgreSqlParameterValue("empleado", empleadoId);
		DataSet result = new DataSet();
		DataTable personal = _database.Query("""
SELECT e."IdEmpleado" AS "idempleado",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",
 p."NumDocID" AS "NumDocId",p."Direccion" AS "direccion",p."Telefono",p."Fax",p."Email",
 p."FechaNacimiento",p."FechaRegistro",p."NumCelular",p."FonoCentroLab",
 e."Sexo" AS "sexo",e."ExpSocial",e."Brevete" AS "brevete",e."JefeHogar",e."CargaFam",
 e."NumHijos" AS "Numhijos",e."ObsFam",e."NumLibretaMilitar",e."GradoInstruccion" AS "gradoInstruccion",
 e."NumRUC",e."Foto" AS "foto",td."Descripcion" AS "TipoDoc",ec."DescripEstCivil" AS "EstadoCivil",
 ts."DescripTS" AS "DescripTS",n."Descripcion" AS "Nacionalidad",
 vc."DescripViveCon" AS "Descripvivecon",d."Descrip_Discapacidad" AS "Discapacidad",
 EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",
 s."EnferCronica" AS "enfercronica",s."EnferCronicaDescrip" AS "enfercronicadescrip",
 s."FamDiscapacidad" AS "famdiscapacidad",s."FamDiscapDescrip" AS "famdiscapdescrip",
 s."Alergico" AS "alergico",s."AlergicoDescrip" AS "alergicodescrip"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."TipoDocID" td ON td."TipoDocID"=p."TipoDocID"
LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=e."IdEstadoCivil"
LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=e."IdTipoSangre"
LEFT JOIN public."Nacionalidad" n ON n."IdNacionalidad"=e."IdNacionalidad"
LEFT JOIN public."ViveCon" vc ON vc."IdViveCon"=e."IdViveCon"
LEFT JOIN public."Discapacidad" d ON d."IdDiscapacidad"=e."IdDiscapacidad"
LEFT JOIN public."RRHH_Salud" s ON s."IdEmpleado"=e."IdEmpleado"
WHERE e."IdEmpleado"=@empleado;
""", employee);

		DataTable work = _database.Query("""
SELECT e."FechaIngreso" AS "Fechaingreso",e."FechaAFP",e."NroAFP",e."Profesion" AS "profesion",
 e."NumResolCese",e."FechaResolCese",e."NumResol20530",e."FechaResol20530",
 a."DescripAFP",c."Cargo" AS "cargo",eo."AreaOrganizacional",tt."Descripcion" AS "CondicionLab"
FROM public."Empleado" e LEFT JOIN public."AFP" a ON a."IdAFP"=e."IdAFP"
LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"
LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE e."IdEmpleado"=@empleado;
""", employee, new PostgreSqlParameterValue("year", DateTime.Today.Year));

		DataTable experience = _database.Query("""
SELECT ex."NomInstitucion",ex."Cargo" AS "CargoExp",ex."FechaIngreso" AS "FechaIngresoExp",
 ex."FechaEgreso" AS "FEchaEgresoExp",ex."UnidadOrganica" AS "UnidadOrgaExp",
 ti."DescripTipoInstitucion" AS "DescriptipoInstitucion"
FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"
WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;
""", employee);

		if (!completa)
		{
			AddReportTable(result, personal, "FichaSocial");
			AddReportTable(result, experience, "FichaSocialExp");
			return result;
		}

		AddReportTable(result, work, "spRRHH_Ficha_ExpLab_Datos");
		AddReportTable(result, _database.Query("""
SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"
FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"
WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;
""", employee), "spRRHH_busca_Disciplina");
		AddReportTable(result, experience, "spRRHH_Ficha_ExpLab");
		AddReportTable(result, _database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresFamilia",
 f."FamSexo",f."FamGradoInstruc",f."ViveCasa",f."LaboraInstitucion",tf."DescripTipoFam",ec."DescripEstCivil",
 EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadFamiliar"
FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"
LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"
LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=f."IdEstadoCivil"
WHERE f."IdEmpleado"=@empleado ORDER BY tf."DescripTipoFam",p."Apellido_Paterno";
""", employee), "spRRHH_Ficha_Det_Familiar");
		AddReportTable(result, _database.Query("""
SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio",er."AñoTermino",ee."DescripEstadoEstudio"
FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"
LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"
WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio";
""", employee), "spRRHH_Ficha_Estudio_Realizado");
		AddReportTable(result, _database.Query(
			"SELECT * FROM public.\"TitulosEmpleado\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"Fecha\";", employee),
			"spRRHH_Ficha_Estudio_Titulo");
		AddReportTable(result, _database.Query(
			"SELECT * FROM public.\"Capacitacion\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"FechaInicio\";", employee),
			"spRRHH_Ficha_Estudio_Capacitacion");
		AddReportTable(result, ObtenerIngresosEgresos(empleadoId), "spRRHH_Ficha_Ingreso_Egreso");
		AddReportTable(result, _database.Query("""
SELECT v."NumDormitorio",v."NumServHig",v."NumCompart",v."NumPerDorm",v."Observacion" AS "observacion",
 v."Telefono" AS "telefono",v."Cable" AS "cable",v."Internet" AS "internet",v."Otros" AS "otros",
 te."DescripTenencia",tv."DescripTipo" AS "DescripTipo",mv."DescripMaterial",cv."DescripConserva",
 uv."DescripUbicacion",av."DescripAlumbrado",wv."DescripAgua" AS "descripAgua",ev."DescripExcretas"
FROM public."Vivienda" v LEFT JOIN public."TenenciaViv" te ON te."IdTenencia"=v."IdTenencia"
LEFT JOIN public."TipoViv" tv ON tv."IdTipo"=v."IdTipo"
LEFT JOIN public."MaterialViv" mv ON mv."IdMaterial"=v."IdMaterial"
LEFT JOIN public."ConservacionViv" cv ON cv."IdConservacion"=v."IdConservacion"
LEFT JOIN public."UbicacionViv" uv ON uv."IdUbicacion"=v."IdUbicacion"
LEFT JOIN public."AlumbradoViv" av ON av."IdAlumbrado"=v."IdAlumbrado"
LEFT JOIN public."AguaViv" wv ON wv."IdAgua"=v."IdAgua"
LEFT JOIN public."ExcretasViv" ev ON ev."IdExcretas"=v."IdExcretas"
WHERE v."IdEmpleado"=@empleado;
""", employee), "spRRHH_Ficha_Vivienda");
		AddReportTable(result, personal, "spRRHH_Ficha_DatosPersonales");
		AddReportTable(result, _database.Query("""
SELECT tf."DescripTipoFam",ts."DescripTS" AS "descripts",f."Enfermedad" AS "enfermedad",
 f."TiempoEnfermedad" AS "tiempoenfermedad",f."NumAutogenSalud" AS "numautogensalud",p."NumDocID" AS "numdocid"
FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"
LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"
LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=f."IdTipoSangre"
WHERE f."IdEmpleado"=@empleado;
""", employee), "spRRHH_Ficha_Det_Familiar_Salud");
		return result;
	}

	private DataTable ObtenerIngresosEgresos(int empleadoId)
	{
		bool available = Convert.ToBoolean(_database.Scalar(
			"SELECT to_regclass('public.\"Ingreso\"') IS NOT NULL AND to_regclass('public.\"Egreso\"') IS NOT NULL;"));
		if (!available)
		{
			return new DataTable();
		}
		return _database.Query("""
SELECT i."Remuneracion",i."Honorarios" AS "honorarios",i."AlqPredio",i."AlqBienes",i."CapitalesColocados",
 i."Dietas",i."Negocios",i."Otros" AS "OtrosIngresos",i."IngresoMiembros",i."NumPersonaAportan",
 e."Alimentacion",e."Vivienda" AS "vivienda",e."Educacion" AS "educacion",e."Salud" AS "salud",
 e."Vestido" AS "vestido",e."Recreacion" AS "recreacion",e."Prestamos" AS "prestamos",
 e."Otros" AS "OtrosEgresos",e."Transporte" AS "transporte",e."EnergiaElec" AS "energiaelec",
 e."Agua" AS "agua",e."BajaPolicia" AS "bajapolicia",e."Telefono" AS "telefono",
 e."SeguroPriv" AS "seguropriv",e."TarjCredito" AS "tarjcredito"
FROM public."Ingreso" i FULL JOIN public."Egreso" e ON e."IdEmpleado"=i."IdEmpleado"
WHERE COALESCE(i."IdEmpleado",e."IdEmpleado")=@empleado;
""", new PostgreSqlParameterValue("empleado", empleadoId));
	}

	private static void AddReportTable(DataSet dataSet, DataTable table, string name)
	{
		table.TableName = name;
		dataSet.Tables.Add(table);
	}

	private DataTable ReporteOficina(string condition, params PostgreSqlParameterValue[] parameters)
	{
		string sql = """
SELECT e."IdEmpleado" AS "idempleado",p."IdPersona" AS "idpersona",
       p."Apellido_Paterno" AS "Apellido_paterno",p."Apellido_Materno" AS "apellido_materno",
       p."Nombres" AS "nombres",eo."AreaOrganizacional"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE {0} AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY p."Apellido_Paterno",p."Apellido_Materno",p."Nombres";
""";
		List<PostgreSqlParameterValue> all = new List<PostgreSqlParameterValue>(parameters ?? Array.Empty<PostgreSqlParameterValue>())
		{
			new PostgreSqlParameterValue("year", mAnio)
		};
		return _database.Query(string.Format(CultureInfo.InvariantCulture, sql, condition), all.ToArray());
	}

	private static DataSet DataSetWith(DataTable table, string name)
	{
		table.TableName = name;
		DataSet dataSet = new DataSet();
		dataSet.Tables.Add(table);
		return dataSet;
	}

	private static int[] ParseCsvIntegers(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return Array.Empty<int>();
		}
		return value.Split(',')
			.Select(item => item.Trim())
			.Where(item => int.TryParse(item, out _))
			.Select(int.Parse)
			.Distinct()
			.ToArray();
	}

	private static List<DateTime> ParseDateList(string value)
	{
		List<DateTime> result = new List<DateTime>();
		foreach (string segment in (value ?? string.Empty).Split(']'))
		{
			string text = segment.Trim(' ', ',', '[');
			if (string.IsNullOrWhiteSpace(text))
			{
				continue;
			}
			if (DateTime.TryParse(text, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime date) ||
				DateTime.TryParse(text, CultureInfo.GetCultureInfo("es-PE"), DateTimeStyles.None, out date) ||
				DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
			{
				result.Add(date.Date);
			}
		}
		return result.Distinct().OrderBy(date => date).ToList();
	}

	private static string FormatAttendance(object entrance, object exit)
	{
		string entranceText = entrance == DBNull.Value ? string.Empty : Convert.ToString(entrance).Trim();
		string exitText = exit == DBNull.Value ? string.Empty : Convert.ToString(exit).Trim();
		if (entranceText.Length == 0 && exitText.Length == 0)
		{
			return string.Empty;
		}
		if (exitText.Length == 0 || exitText == entranceText)
		{
			return entranceText;
		}
		return entranceText + " - " + exitText;
	}

	private static string UniqueColumnName(DataTable table, string preferredName)
	{
		string baseName = string.IsNullOrWhiteSpace(preferredName) ? "Motivo" : preferredName.Trim();
		string name = baseName;
		int suffix = 2;
		while (table.Columns.Contains(name))
		{
			name = baseName + "_" + suffix++;
		}
		return name;
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
