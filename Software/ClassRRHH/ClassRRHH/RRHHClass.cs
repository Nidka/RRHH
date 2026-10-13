using System;
using System.Data;
using System.Data.SqlClient;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassRRHH;

public class RRHHClass
{
	public SqlConnection ObjCnn;

	public SqlDataAdapter objDA;

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
	{
		ObjCnn = clsConexion.Conexion;
		objDA = new SqlDataAdapter();
		mAnio = 2011;
	}

	public object llena_DocID()
	{
		ObjCnn.Open();
		DataTable dt_des_DI = new DataTable();
		objDA.SelectCommand = new SqlCommand("Select TipoDocID,Descripcion from  TipoDocID", ObjCnn);
		objDA.Fill(dt_des_DI);
		ObjCnn.Close();
		return dt_des_DI;
	}

	public object llena_Area()
	{
		ObjCnn.Open();
		DataTable dt_des_Area = new DataTable();
		objDA.SelectCommand = new SqlCommand("select idAreaOrganiz,AreaOrganizacional from dbo.EstructOrganiz where Year=" + Conversions.ToString(mAnio) + "Order by 2", ObjCnn);
		objDA.Fill(dt_des_Area);
		ObjCnn.Close();
		return dt_des_Area;
	}

	public object llena_Nacionalidad()
	{
		ObjCnn.Open();
		DataTable dt_des_Nac = new DataTable();
		objDA.SelectCommand = new SqlCommand("select IdNacionalidad, Descripcion from nacionalidad", ObjCnn);
		objDA.Fill(dt_des_Nac);
		ObjCnn.Close();
		return dt_des_Nac;
	}

	public object llena_Discapacidad()
	{
		ObjCnn.Open();
		DataTable dt_des_Discapacidad = new DataTable();
		objDA.SelectCommand = new SqlCommand("Select IdDiscapacidad,Descrip_Discapacidad from  Discapacidad", ObjCnn);
		objDA.Fill(dt_des_Discapacidad);
		ObjCnn.Close();
		return dt_des_Discapacidad;
	}

	public object llena_estCivil()
	{
		ObjCnn.Open();
		DataTable dt_llena_civil = new DataTable();
		objDA.SelectCommand = new SqlCommand("select IdEstadoCivil,DescripEstCivil from EstadoCivil", ObjCnn);
		objDA.Fill(dt_llena_civil);
		ObjCnn.Close();
		return dt_llena_civil;
	}

	public int SgtIdPermiso(int idempleado)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_SgtID_Permiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		int id = Conversions.ToInteger(objDA.SelectCommand.ExecuteScalar());
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return id;
	}

	public int SgtIdHorarioTemporal(int idempleado)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_SgtID_HorarioTemporal", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		int id = Conversions.ToInteger(objDA.SelectCommand.ExecuteScalar());
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return id;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Verficar_Existe_Marcacion", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		objDA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = fecha;
		int id = Conversions.ToInteger(objDA.SelectCommand.ExecuteScalar());
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return id;
	}

	public int ExisteAsistencia(int idempleado, string fecha)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Verficar_Existe_Asistencia", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		objDA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = fecha;
		int id = Conversions.ToInteger(objDA.SelectCommand.ExecuteScalar());
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return id;
	}

	public bool ElimnarPermiso(int idempleado, int NPermiso)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Elimnar_Permiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		objDA.SelectCommand.Parameters.Add("@NPermiso", SqlDbType.Int).Value = NPermiso;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return true;
	}

	public bool eliminarHorarioTemporal(int idempleado, int NPermiso)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Elimnar_HorarioTemporal", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idempleado;
		objDA.SelectCommand.Parameters.Add("@NPermiso", SqlDbType.Int).Value = NPermiso;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return true;
	}

	public DataTable llenar_Empleado_Area(int idEmpleado)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable oDt_Empleado_Area = new DataTable();
		objDA.SelectCommand = new SqlCommand("sp_GetAll_EmpleadoArea_by_idEmpleado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = idEmpleado;
		objDA.Fill(oDt_Empleado_Area);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return oDt_Empleado_Area;
	}

	public void Actualizar_Area_Empleado(int idEmpleado, int Anio, int idAreaOrganiz)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Actualiza_Empleado_Area", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = idEmpleado;
		objDA.SelectCommand.Parameters.Add("@idAreaOrganiz", SqlDbType.Int).Value = idAreaOrganiz;
		objDA.SelectCommand.Parameters.Add("@Anio", SqlDbType.Int).Value = Anio;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
	}

	public DataTable llenar_Areas_by_año(int Anio)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable oDt_Areas = new DataTable();
		objDA.SelectCommand = new SqlCommand("sp_GetAll_Area_By_Anio", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@Anio", SqlDbType.Int).Value = Anio;
		objDA.Fill(oDt_Areas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return oDt_Areas;
	}

	public DataTable buscar_empleado(int? codigo, string numdoc, string apellido, int? idTipoTrabajador, int activo, int idRol = 0)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_bus_emple = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_busca_empleado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = codigo;
		objDA.SelectCommand.Parameters.Add("@NumdocId", SqlDbType.VarChar, 12).Value = numdoc;
		objDA.SelectCommand.Parameters.Add("@Apellido_Paterno", SqlDbType.VarChar, 30).Value = apellido;
		objDA.SelectCommand.Parameters.Add("@IdTipoTrabajador", SqlDbType.VarChar, 30).Value = idTipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@Anio", SqlDbType.VarChar, 30).Value = mAnio;
		objDA.SelectCommand.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol;
		objDA.SelectCommand.Parameters.Add("@activo", SqlDbType.Bit).Value = activo;
		objDA.Fill(dt_bus_emple);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_bus_emple;
	}

	public DataTable BuscarEmpleado_Codigo(int codigo)
	{
		ObjCnn.Open();
		DataTable dt_bus_emple_cod = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_BuscarEmpleado_Codigo", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
		objDA.Fill(dt_bus_emple_cod);
		ObjCnn.Close();
		return dt_bus_emple_cod;
	}

	public bool ActualizaAsistencia(int idEmpleado, DateTime fecha, string hor_sal, bool flag_sal)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Actualiza_Asistencia", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = idEmpleado;
		objDA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
		objDA.SelectCommand.Parameters.Add("@Hor_Sal", SqlDbType.Char, 8).Value = hor_sal;
		objDA.SelectCommand.Parameters.Add("@Flag_Sal", SqlDbType.Bit).Value = flag_sal;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return true;
	}

	public int ExistePermiso(int idEmpleado, string FechaInicio, string FechaFin)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_ExistePermiso_Permiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.Char).Value = FechaInicio;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.Char).Value = FechaFin;
		int Result = Conversions.ToInteger(objDA.SelectCommand.ExecuteScalar());
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return Result;
	}

	public void ingresa_Empleado_Area(int year, int idorganiz, int idEmpleado)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		objDA.SelectCommand = new SqlCommand("sp_Insert_Empleado_Area", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@Year", SqlDbType.Int).Value = year;
		objDA.SelectCommand.Parameters.Add("@idAreaOrganiz", SqlDbType.Int).Value = idorganiz;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = idEmpleado;
		objDA.SelectCommand.ExecuteNonQuery();
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
	}

	public int Ingresa_Empleado(int year, int idorganiz, int TipoDocIdent, string NumDoc, string Apellido_Paterno, string Apellido_Materno, string Nombres, string ubigeoNac, DateTime fechaNac, string Direccion, string Fono, string FonoLab, string FonoCel, string FonoOtro, string Mail, string UbigeoDireccion, int idNacionalidad, string sexo, int idEstCivil, int idDiscapacidad, string expSocial, DateTime FechaIngreso, int tiposangre, string brevete, string libmilitar, string gradoinstruccion, string numRuc, int idtipoTrabajador, byte[] Foto)
	{
		ObjCnn.Open();
		objDA.SelectCommand = new SqlCommand("spRRHH_GrabarEmpleado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		SqlParameter paramid = new SqlParameter("@codEmpleNuevo", SqlDbType.Int, 32);
		paramid.Direction = ParameterDirection.Output;
		objDA.SelectCommand.Parameters.Add(paramid);
		objDA.SelectCommand.Parameters.Add("@year", SqlDbType.Int).Value = year;
		objDA.SelectCommand.Parameters.Add("@idorganiz", SqlDbType.Int).Value = idorganiz;
		objDA.SelectCommand.Parameters.Add("@TipoDocIdent", SqlDbType.Int).Value = TipoDocIdent;
		objDA.SelectCommand.Parameters.Add("@NumDoc", SqlDbType.Char, 12).Value = NumDoc;
		objDA.SelectCommand.Parameters.Add("@Apellido_Paterno", SqlDbType.VarChar, 30).Value = Apellido_Paterno;
		objDA.SelectCommand.Parameters.Add("@Apellido_Materno", SqlDbType.VarChar, 30).Value = Apellido_Materno;
		objDA.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 100).Value = Nombres;
		objDA.SelectCommand.Parameters.Add("@ubigeoNac", SqlDbType.Char, 6).Value = ubigeoNac;
		objDA.SelectCommand.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = fechaNac;
		objDA.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = Direccion;
		objDA.SelectCommand.Parameters.Add("@Fono", SqlDbType.VarChar, 15).Value = Fono;
		objDA.SelectCommand.Parameters.Add("@FonoLab", SqlDbType.VarChar, 15).Value = FonoLab;
		objDA.SelectCommand.Parameters.Add("@FonoCel", SqlDbType.VarChar, 15).Value = FonoCel;
		objDA.SelectCommand.Parameters.Add("@FonoOtro", SqlDbType.VarChar, 15).Value = FonoOtro;
		objDA.SelectCommand.Parameters.Add("@Mail", SqlDbType.VarChar, 50).Value = Mail;
		objDA.SelectCommand.Parameters.Add("@UbigeoDireccion", SqlDbType.Char, 6).Value = UbigeoDireccion;
		objDA.SelectCommand.Parameters.Add("@idNacionalidad", SqlDbType.Int).Value = idNacionalidad;
		objDA.SelectCommand.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = sexo;
		objDA.SelectCommand.Parameters.Add("@idEstCivil", SqlDbType.Int).Value = idEstCivil;
		objDA.SelectCommand.Parameters.Add("@idDiscapacidad", SqlDbType.Int).Value = idDiscapacidad;
		objDA.SelectCommand.Parameters.Add("@expSocial", SqlDbType.VarChar, 20).Value = expSocial;
		objDA.SelectCommand.Parameters.Add("@FechaIngreso", SqlDbType.SmallDateTime).Value = FechaIngreso;
		objDA.SelectCommand.Parameters.Add("@idtiposangre", SqlDbType.Int).Value = tiposangre;
		objDA.SelectCommand.Parameters.Add("@brevete", SqlDbType.VarChar, 12).Value = brevete;
		objDA.SelectCommand.Parameters.Add("@libmilitar", SqlDbType.VarChar, 10).Value = libmilitar;
		objDA.SelectCommand.Parameters.Add("@gradoinstrucc", SqlDbType.VarChar, 80).Value = gradoinstruccion;
		objDA.SelectCommand.Parameters.Add("@numruc", SqlDbType.VarChar, 12).Value = numRuc;
		objDA.SelectCommand.Parameters.Add("@idtipoTrabajador", SqlDbType.Int).Value = idtipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
		objDA.SelectCommand.ExecuteNonQuery();
		ObjCnn.Close();
		return Conversions.ToInteger(paramid.Value);
	}

	public void Actualiza_Empleado(int codpersona, int codempleado, int year, int idorganiz, int TipoDocIdent, string NumDoc, string Apellido_Paterno, string Apellido_Materno, string Nombres, string ubigeoNac, DateTime fechaNac, string Direccion, string Fono, string FonoLab, string FonoCel, string FonoOtro, string Mail, string UbigeoDireccion, int idNacionalidad, string sexo, int idEstCivil, int idDiscapacidad, string expSocial, DateTime FechaIngreso, int tiposangre, string brevete, string libmilitar, string gradoinstruccion, string numRuc, int idtipoTrabajador, byte[] Foto)
	{
		ObjCnn.Open();
		objDA.SelectCommand = new SqlCommand("spRRHH_ActualizaEmpleado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@CodPer", SqlDbType.Int).Value = codpersona;
		objDA.SelectCommand.Parameters.Add("@codEmple", SqlDbType.Int).Value = codempleado;
		objDA.SelectCommand.Parameters.Add("@year", SqlDbType.Int).Value = year;
		objDA.SelectCommand.Parameters.Add("@idorganiz", SqlDbType.Int).Value = idorganiz;
		objDA.SelectCommand.Parameters.Add("@TipoDocIdent", SqlDbType.Int).Value = TipoDocIdent;
		objDA.SelectCommand.Parameters.Add("@NumDoc", SqlDbType.Char, 12).Value = NumDoc;
		objDA.SelectCommand.Parameters.Add("@Apellido_Paterno", SqlDbType.VarChar, 30).Value = Apellido_Paterno;
		objDA.SelectCommand.Parameters.Add("@Apellido_Materno", SqlDbType.VarChar, 30).Value = Apellido_Materno;
		objDA.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 100).Value = Nombres;
		objDA.SelectCommand.Parameters.Add("@ubigeoNac", SqlDbType.Char, 6).Value = ubigeoNac;
		objDA.SelectCommand.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = fechaNac;
		objDA.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = Direccion;
		objDA.SelectCommand.Parameters.Add("@Fono", SqlDbType.VarChar, 15).Value = Fono;
		objDA.SelectCommand.Parameters.Add("@FonoLab", SqlDbType.VarChar, 15).Value = FonoLab;
		objDA.SelectCommand.Parameters.Add("@FonoCel", SqlDbType.VarChar, 15).Value = FonoCel;
		objDA.SelectCommand.Parameters.Add("@FonoOtro", SqlDbType.VarChar, 15).Value = FonoOtro;
		objDA.SelectCommand.Parameters.Add("@Mail", SqlDbType.VarChar, 50).Value = Mail;
		objDA.SelectCommand.Parameters.Add("@UbigeoDireccion", SqlDbType.Char, 6).Value = UbigeoDireccion;
		objDA.SelectCommand.Parameters.Add("@idNacionalidad", SqlDbType.Int).Value = idNacionalidad;
		objDA.SelectCommand.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = sexo;
		objDA.SelectCommand.Parameters.Add("@idEstCivil", SqlDbType.Int).Value = idEstCivil;
		objDA.SelectCommand.Parameters.Add("@idDiscapacidad", SqlDbType.Int).Value = idDiscapacidad;
		objDA.SelectCommand.Parameters.Add("@expSocial", SqlDbType.VarChar, 20).Value = expSocial;
		objDA.SelectCommand.Parameters.Add("@FechaIngreso", SqlDbType.SmallDateTime).Value = FechaIngreso;
		objDA.SelectCommand.Parameters.Add("@idtiposangre", SqlDbType.Int).Value = tiposangre;
		objDA.SelectCommand.Parameters.Add("@brevete", SqlDbType.VarChar, 12).Value = brevete;
		objDA.SelectCommand.Parameters.Add("@libmilitar", SqlDbType.VarChar, 10).Value = libmilitar;
		objDA.SelectCommand.Parameters.Add("@gradoinstrucc", SqlDbType.VarChar, 80).Value = gradoinstruccion;
		objDA.SelectCommand.Parameters.Add("@numruc", SqlDbType.VarChar, 12).Value = numRuc;
		objDA.SelectCommand.Parameters.Add("@idtipoTrabajador", SqlDbType.Int).Value = idtipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
		objDA.SelectCommand.ExecuteNonQuery();
		ObjCnn.Close();
	}

	public void Actualiza_Empleado(int codempleado)
	{
		ObjCnn.Open();
		objDA.SelectCommand = new SqlCommand("spRRHH_EliminarEmpleado", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@codEmple", SqlDbType.Int).Value = codempleado;
		objDA.SelectCommand.ExecuteNonQuery();
		ObjCnn.Close();
	}

	public object llena_tree()
	{
		ObjCnn.Open();
		DataTable dt_Vista_Tree = new DataTable();
		objDA.SelectCommand = new SqlCommand("select IdAreaOrganiz As Padre, AreaOrganizacional,IdDependeDe as Hijo from dbo.EstructOrganiz where Year=" + Conversions.ToString(mAnio), ObjCnn);
		objDA.Fill(dt_Vista_Tree);
		ObjCnn.Close();
		return dt_Vista_Tree;
	}

	public DataTable buscar_empleado_tree(int area, int tipotrab)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_bus_emple_tree = new DataTable();
		objDA.SelectCommand = new SqlCommand("sp_RRHH_Busca_Empleado_tree", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idAreaOrganiz", SqlDbType.Int).Value = area;
		objDA.SelectCommand.Parameters.Add("@year", SqlDbType.Int).Value = mAnio;
		objDA.SelectCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = true;
		objDA.SelectCommand.Parameters.Add("@tipotrabajador", SqlDbType.Int).Value = tipotrab;
		objDA.Fill(dt_bus_emple_tree);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_bus_emple_tree;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_cargos = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Rep_cargos", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idCargo", SqlDbType.Int).Value = idCargo;
		objDA.Fill(dt_Generar_cargos);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_cargos;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_des_DI = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_llenarPermiso", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = codempleado;
		objDA.SelectCommand.Parameters.Add("@idTipoPermiso", SqlDbType.Int).Value = permiso;
		objDA.SelectCommand.Parameters.Add("@idmotivo", SqlDbType.Int).Value = motivo;
		objDA.Fill(dt_des_DI);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_des_DI;
	}

	public object llena_HorariosTemporales(int codempleado)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_des_DI = new DataTable();
		objDA.SelectCommand = new SqlCommand("[spRRHH_llenarHorarioTemporal]", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = codempleado;
		objDA.Fill(dt_des_DI);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_des_DI;
	}

	public object Generar_Rep_Faltas(string fecha, int? idTipoTrabajador, int? idAreaOrganiz, int? Año)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Faltas", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@fecha", SqlDbType.VarChar).Value = fecha;
		objDA.SelectCommand.Parameters.Add("@idTipoTrabajador", SqlDbType.Int).Value = idTipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@idAreaOrganiz", SqlDbType.Int).Value = idAreaOrganiz;
		objDA.SelectCommand.Parameters.Add("@Anio", SqlDbType.Int).Value = Año;
		dt_Generar_Faltas.TableName = "spRRHH_Faltas";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public object ObtenerAsistenciasxDia(string fecha)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_GetAsistencias", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@dia", SqlDbType.Char).Value = fecha;
		dt_Generar_Faltas.TableName = "spRRHH_GetAsistencias";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public object ObtenerEmpleados()
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("select idempleado,NombresC from vs_GetEmpleado where Estado=1", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.Text;
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Feriado = new DataTable();
		objDA.SelectCommand = new SqlCommand("select * from RRHH_Feriado where convert(char(10),Fecha,103)='" + fecha + "'", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.Text;
		objDA.Fill(dt_Feriado);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Feriado;
	}

	public DataTable spRRHH_RepPermisos(string fechaI, string fechaF, int? tipopermiso, int? motivo, int? idTipoTrabajador)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_RepPermisos", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.NVarChar).Value = fechaI;
		objDA.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.NVarChar).Value = fechaF;
		objDA.SelectCommand.Parameters.Add("@idTipoPermiso", SqlDbType.Int).Value = tipopermiso;
		objDA.SelectCommand.Parameters.Add("@idmotivo", SqlDbType.Int).Value = motivo;
		objDA.SelectCommand.Parameters.Add("@idtipoEmpleado", SqlDbType.Int).Value = idTipoTrabajador;
		dt_Generar_Faltas.TableName = "spRRHH_RepPermisos";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("select P.IdPersona,Apellido_Paterno, P.Apellido_Materno, P.Nombres from dbo.Persona P Where P.Apellido_Paterno like '" + ApellidoPaterno + "%' and TipoPersona = 'N'", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.Text;
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
	}

	public object ListarProfesiones()
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Listar_Profesiones = new DataTable();
		objDA.SelectCommand = new SqlCommand("sp_RRHH_ListarProfesiones", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.Fill(dt_Listar_Profesiones);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Listar_Profesiones;
	}

	public DataTable spRRHH_Rep_profesion(string profesion)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_cargos = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_Rep_profesion", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@profesion", SqlDbType.NVarChar).Value = profesion;
		objDA.Fill(dt_Generar_cargos);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_cargos;
	}

	public DataTable spRRHH_ListarTrabajadores(int idTipoTrabajador)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_cargos = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_ListarTrabajadores", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdTipoTrabajador", SqlDbType.Int).Value = idTipoTrabajador;
		objDA.Fill(dt_Generar_cargos);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_cargos;
	}

	public DataTable spRRHH_ListarTrabajadoresRep(int idTipoTrabajador)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_cargos = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_ListarTrabajadoresRep", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdTipoTrabajador", SqlDbType.Int).Value = idTipoTrabajador;
		objDA.Fill(dt_Generar_cargos);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_cargos;
	}

	public DataTable spRRHH_AgregarReporte(int idTipoTrabajador, int opcion)
	{
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_cargos = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_AgregarReporte", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idTipoTrabajador;
		objDA.SelectCommand.Parameters.Add("@opt", SqlDbType.Int).Value = opcion;
		objDA.Fill(dt_Generar_cargos);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_cargos;
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
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		DataTable dt_Generar_Faltas = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_ListarMotivos_byTipo", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@TipoModalidad", SqlDbType.NVarChar).Value = fechaI;
		dt_Generar_Faltas.TableName = "spRRHH_ListarMotivos_byTipo";
		objDA.Fill(dt_Generar_Faltas);
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		return dt_Generar_Faltas;
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
		ObjCnn.Open();
		DataTable dt_bus_emple_cod = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_GetAsistenciaDia", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = codigo;
		objDA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = fecha;
		objDA.Fill(dt_bus_emple_cod);
		ObjCnn.Close();
		return dt_bus_emple_cod;
	}
}
