using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using ClassRRHH.My;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using Seguridad;

namespace ClassRRHH;

public class AsistenciaAccess
{
	public string BD;

	public string BDProind;

	public string BDConsejo;

	private OleDbConnection oCnAccess;

	private OleDbConnection oCnAccessAlt;

	private SqlConnection ObjCnn;

	public AsistenciaAccess()
	{
		BD = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Aplicacion.ToString(), "E");
		BDProind = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Key.ToString(), "E");
		BDConsejo = global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.App.ToString(), "E");
		oCnAccess = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BD + "\\Marcacion.mdb;Jet OLEDB:Database Password=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Serie.ToString(), "E") + ";");
		oCnAccessAlt = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Version.ToString(), "E") + "\\Marcacion.mdb;Jet OLEDB:Database Password=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.SEDE.ToString(), "E") + ";");
		ObjCnn = clsConexion.Conexion;
	}

	public bool Grabar_Asis_Norm(int Pers_DNI, string Fec_Asi, string Hor_Ent, string Hor_Sal, string Alm_Ent, string Alm_Sal)
	{
		oCnAccess.Open();
		OleDbCommand oCmdPer = new OleDbCommand("SELECT pers_cod from empleado where pers_dni='" + Conversions.ToString(Pers_DNI) + "'", oCnAccess);
		oCmdPer.CommandType = CommandType.Text;
		OleDbDataAdapter oDa = new OleDbDataAdapter();
		oDa.SelectCommand = oCmdPer;
		DataTable oDt = new DataTable();
		oDa.Fill(oDt);
		if (ExistAsistencia(Conversions.ToInteger(oDt.Rows[0]["pers_cod"].ToString()), Fec_Asi))
		{
			return false;
		}
		OleDbCommand oCmd = new OleDbCommand("INSERT into Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal,Alm_Ent,Alm_Sal) VALUES(" + oDt.Rows[0]["pers_cod"].ToString() + ",'" + Fec_Asi + "','" + Hor_Ent + "', '" + Hor_Sal + "','" + Alm_Ent + "','" + Alm_Sal + "')", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		oCmd.ExecuteNonQuery();
		oCnAccess.Close();
		if (MySettingsProperty.Settings.Aplicacion.ToString().Length >= 3)
		{
			oCnAccessAlt.Open();
			OleDbCommand oCmdAlt = new OleDbCommand("INSERT into Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal,Alm_Ent,Alm_Sal) VALUES(" + oDt.Rows[0]["pers_cod"].ToString() + ",'" + Fec_Asi + "','" + Hor_Ent + "', '" + Hor_Sal + "','" + Alm_Ent + "','" + Alm_Sal + "')", oCnAccessAlt);
			oCmdAlt.CommandType = CommandType.Text;
			oCmdAlt.ExecuteNonQuery();
			oCnAccessAlt.Close();
		}
		return true;
	}

	public bool ExistAsistencia(int Pers_Cod, string Fecha)
	{
		DataTable dt = new DataTable();
		OleDbCommand oCmd = new OleDbCommand("Select Pers_Cod, Hor_Ent, Hor_Sal FROM Asis_Norm WHERE Pers_Cod = " + Conversions.ToString(Pers_Cod) + " AND Fec_Asi = '" + Fecha + "';", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDa = new OleDbDataAdapter();
		oDa.SelectCommand = oCmd;
		oDa.Fill(dt);
		if (dt.Rows.Count >= 1)
		{
			return true;
		}
		return false;
	}

	public bool Grabar_Marcaciones(string fecha, string dni, string estado, int proceso, string Lugar)
	{
		oCnAccess.Open();
		OleDbCommand oCmd = new OleDbCommand("Insert into Marcacion (Fecha, Valor, Estado, Proceso, Lugar) VALUES ('" + fecha + "' , '" + dni + "' , '" + estado + "' ," + Conversions.ToString(proceso) + ", '" + Lugar + "');", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		oCmd.ExecuteNonQuery();
		oCnAccess.Close();
		if (MySettingsProperty.Settings.Aplicacion.ToString().Length >= 3)
		{
			oCnAccessAlt.Open();
			OleDbCommand oCmdAlt = new OleDbCommand("Insert into Marcacion (Fecha, Valor, Estado, Proceso, Lugar) VALUES ('" + fecha + "' , '" + dni + "' , '" + estado + "' ," + Conversions.ToString(proceso) + ", '" + Lugar + "');", oCnAccessAlt);
			oCmdAlt.CommandType = CommandType.Text;
			oCmdAlt.ExecuteNonQuery();
			oCnAccessAlt.Close();
		}
		return true;
	}

	public bool Actualizar_Empleado_Horario(int idhorario, string dni)
	{
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		OleDbCommand oCmd = new OleDbCommand("Update Empleado set idHorario=" + Conversions.ToString(idhorario) + " where pers_estado=true and pers_DNI='" + dni.Trim() + "'; ", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		oCmd.ExecuteNonQuery();
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (MySettingsProperty.Settings.Aplicacion.ToString().Length >= 3)
		{
			oCnAccessAlt.Open();
			OleDbCommand oCmdAlt = new OleDbCommand("Update Empleado set idHorario=" + Conversions.ToString(idhorario) + " where pers_estado=true and pers_DNI='" + dni.Trim() + "'; ", oCnAccessAlt);
			oCmdAlt.CommandType = CommandType.Text;
			oCmdAlt.ExecuteNonQuery();
			oCnAccessAlt.Close();
		}
		return true;
	}

	public object Grabar_suspencion(string Dni, string Fecha)
	{
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		DataTable dt = new DataTable();
		OleDbCommand oCmd = new OleDbCommand("Select pers_cod from Empleado where pers_estado=true and pers_dni='" + Dni.Trim() + "';", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDa = new OleDbDataAdapter();
		oDa.SelectCommand = oCmd;
		oDa.Fill(dt);
		OleDbCommand oCmd2 = new OleDbCommand("Select Count(Pers_Cod) FROM Asis_Norm WHERE Pers_Cod = " + dt.Rows[0]["pers_cod"].ToString() + " AND Fec_Asi = '" + Fecha + "';", oCnAccess);
		oCmd2.CommandType = CommandType.Text;
		int cant = Conversions.ToInteger(oCmd2.ExecuteScalar());
		checked
		{
			if (cant == 1)
			{
				oCmd2.CommandText = "Update Asis_Norm set Suspendido=true where Pers_Cod = " + dt.Rows[0]["pers_cod"].ToString() + " AND Fec_Asi = '" + Fecha + "';";
				short i = (short)oCmd2.ExecuteNonQuery();
				if (i <= 0)
				{
					return false;
				}
			}
			else
			{
				oCmd2.CommandText = "INSERT into Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal,Alm_Ent,Alm_Sal, suspendido) VALUES(" + dt.Rows[0]["pers_cod"].ToString() + ",'" + Fecha + "','00:00:00', '00:00:00','00:00:00','00:00:00',true);";
				short i2 = (short)oCmd2.ExecuteNonQuery();
				if (i2 <= 0)
				{
					return false;
				}
			}
			return true;
		}
	}

	public bool Grabar_SalidaAutorizada(string Dni, int NPermiso, string FechaInicio, string FechaFin, bool dia, bool Retorno, string Lugar)
	{
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		DataTable dt = new DataTable();
		OleDbCommand oCmd = new OleDbCommand("Select pers_cod from Empleado where pers_estado=true and pers_dni='" + Dni.Trim() + "';", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDa = new OleDbDataAdapter();
		oDa.SelectCommand = oCmd;
		oDa.Fill(dt);
		oCmd.CommandText = "Insert into Permiso (idEmpleado, NPermiso, FechaInicio, FechaFin, dia,Retorno,Lugar) VALUES (" + dt.Rows[0]["pers_cod"].ToString() + " , " + Conversions.ToString(NPermiso) + " , '" + FechaInicio + "' , '" + FechaFin + "' , " + Conversions.ToString(dia) + " , " + Conversions.ToString(Retorno) + " , '" + Lugar + "');";
		short i = checked((short)oCmd.ExecuteNonQuery());
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (i <= 0)
		{
			return false;
		}
		if (MySettingsProperty.Settings.Aplicacion.ToString().Length >= 3)
		{
			if (oCnAccessAlt.State == ConnectionState.Closed)
			{
				oCnAccessAlt.Open();
			}
			OleDbCommand oCmdAlt = new OleDbCommand("Insert into Permiso (idEmpleado, NPermiso, FechaInicio, FechaFin, dia,Retorno,Lugar) VALUES (" + dt.Rows[0]["pers_cod"].ToString() + " , " + Conversions.ToString(NPermiso) + " , '" + FechaInicio + "' , '" + FechaFin + "' , " + Conversions.ToString(dia) + " , " + Conversions.ToString(Retorno) + " , '" + Lugar + "');", oCnAccessAlt);
			oCmdAlt.CommandType = CommandType.Text;
			oCmdAlt.ExecuteNonQuery();
			if (oCnAccessAlt.State == ConnectionState.Open)
			{
				oCnAccessAlt.Close();
			}
		}
		return true;
	}

	public bool Access2Sql(string FechaInicial, string FechaFinal, int forzar)
	{
		oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BD + ";Jet OLEDB:Database Password=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Serie.ToString(), "E") + ";";
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		OleDbCommand oCmd = new OleDbCommand("select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' ,  '''&a.estado& ''' , " + Conversions.ToString(forzar) + "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" + FechaInicial + "' and a.fec_asi <= '" + FechaFinal + "'", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDA = new OleDbDataAdapter();
		oDA.SelectCommand = oCmd;
		DataTable oDtAsistencia = new DataTable();
		oDA.Fill(oDtAsistencia);
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		bool Access2Sql;
		try
		{
			foreach (DataRow Item in oDtAsistencia.Rows)
			{
				SqlCommand oCmdS = new SqlCommand(Item.ItemArray[0].ToString(), ObjCnn);
				oCmdS.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Access2Sql = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		oCmd.Connection = oCnAccess;
		oCmd.CommandText = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " + Conversions.ToString(forzar) + "' from marcacion where Fecha >= '" + FechaInicial + " 00:00:00' and Fecha < '" + FechaFinal + " 23:59:59' order by Fecha";
		oCmd.CommandType = CommandType.Text;
		oDA.SelectCommand = oCmd;
		DataTable oDtMarcacion = new DataTable();
		oDA.Fill(oDtMarcacion);
		try
		{
			foreach (DataRow Item2 in oDtMarcacion.Rows)
			{
				SqlCommand oCmdS2 = new SqlCommand(Item2.ItemArray[0].ToString(), ObjCnn);
				oCmdS2.ExecuteNonQuery();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Access2Sql = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		Access2Sql = true;
		goto IL_0312;
		IL_0312:
		return Access2Sql;
	}

	public bool Access2SqlSEDE(string FechaInicial, string FechaFinal, int forzar)
	{
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		OleDbCommand oCmd = new OleDbCommand("select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''', '''&a.idhorario& ''' , '''&a.estado& ''' , " + Conversions.ToString(forzar) + "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" + FechaInicial + "' and a.fec_asi <= '" + FechaFinal + "'", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDA = new OleDbDataAdapter();
		oDA.SelectCommand = oCmd;
		DataTable oDtAsistencia = new DataTable();
		oDA.Fill(oDtAsistencia);
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		bool Access2SqlSEDE;
		try
		{
			foreach (DataRow Item in oDtAsistencia.Rows)
			{
				SqlCommand oCmdS = new SqlCommand(Item.ItemArray[0].ToString(), ObjCnn);
				oCmdS.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Access2SqlSEDE = false;
			ProjectData.ClearProjectError();
			goto IL_02af;
		}
		oCmd.Connection = oCnAccess;
		oCmd.CommandText = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " + Conversions.ToString(forzar) + "' from marcacion where Fecha >= '" + FechaInicial + " 00:00:00' and Fecha < '" + FechaFinal + " 23:59:59' order by Fecha";
		oCmd.CommandType = CommandType.Text;
		oDA.SelectCommand = oCmd;
		DataTable oDtMarcacion = new DataTable();
		oDA.Fill(oDtMarcacion);
		try
		{
			foreach (DataRow Item2 in oDtMarcacion.Rows)
			{
				SqlCommand oCmdS2 = new SqlCommand(Item2.ItemArray[0].ToString(), ObjCnn);
				oCmdS2.ExecuteNonQuery();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Access2SqlSEDE = false;
			ProjectData.ClearProjectError();
			goto IL_02af;
		}
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		Access2SqlSEDE = true;
		goto IL_02af;
		IL_02af:
		return Access2SqlSEDE;
	}

	public bool Access2SqlPROIND(string FechaInicial, string FechaFinal, int forzar)
	{
		oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDProind + "\\Marcacion.mdb;Jet OLEDB:Database Password=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Serie.ToString(), "E") + ";";
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		OleDbCommand oCmd = new OleDbCommand("select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' , '''&a.estado& ''' , " + Conversions.ToString(forzar) + "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" + FechaInicial + "' and a.fec_asi <= '" + FechaFinal + "'", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDA = new OleDbDataAdapter();
		oDA.SelectCommand = oCmd;
		DataTable oDtAsistencia = new DataTable();
		oDA.Fill(oDtAsistencia);
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		bool Access2SqlPROIND;
		try
		{
			foreach (DataRow Item in oDtAsistencia.Rows)
			{
				SqlCommand oCmdS = new SqlCommand(Item.ItemArray[0].ToString(), ObjCnn);
				oCmdS.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Access2SqlPROIND = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		oCmd.Connection = oCnAccess;
		oCmd.CommandText = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " + Conversions.ToString(forzar) + "' from marcacion where Fecha >= '" + FechaInicial + " 00:00:00' and Fecha < '" + FechaFinal + " 23:59:59' order by Fecha";
		oCmd.CommandType = CommandType.Text;
		oDA.SelectCommand = oCmd;
		DataTable oDtMarcacion = new DataTable();
		oDA.Fill(oDtMarcacion);
		try
		{
			foreach (DataRow Item2 in oDtMarcacion.Rows)
			{
				SqlCommand oCmdS2 = new SqlCommand(Item2.ItemArray[0].ToString(), ObjCnn);
				oCmdS2.ExecuteNonQuery();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Access2SqlPROIND = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		Access2SqlPROIND = true;
		goto IL_0312;
		IL_0312:
		return Access2SqlPROIND;
	}

	public bool Access2SqlCONSEJO(string FechaInicial, string FechaFinal, int forzar)
	{
		oCnAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + BDConsejo + "\\Marcacion.mdb;Jet OLEDB:Database Password=" + global::Seguridad.Seguridad.DecryptString(MySettingsProperty.Settings.Serie.ToString(), "E") + ";";
		if (oCnAccess.State == ConnectionState.Closed)
		{
			oCnAccess.Open();
		}
		OleDbCommand oCmd = new OleDbCommand("select 'Exec SpRRHH_Asistencia_Import '&''''&e.pers_DNI&''', '''&a.fec_asi&''', '''&a.hor_ent&''', '''&a.hor_sal&''', '''&a.alm_ent&''', '''&a.alm_sal&''','''&a.idhorario& ''' , '''&a.estado& ''' , " + Conversions.ToString(forzar) + "' from empleado e inner join asis_norm a on e.pers_cod=a.pers_cod where a.fec_asi >= '" + FechaInicial + "' and a.fec_asi <= '" + FechaFinal + "'", oCnAccess);
		oCmd.CommandType = CommandType.Text;
		OleDbDataAdapter oDA = new OleDbDataAdapter();
		oDA.SelectCommand = oCmd;
		DataTable oDtAsistencia = new DataTable();
		oDA.Fill(oDtAsistencia);
		if (ObjCnn.State == ConnectionState.Closed)
		{
			ObjCnn.Open();
		}
		bool Access2SqlCONSEJO;
		try
		{
			foreach (DataRow Item in oDtAsistencia.Rows)
			{
				SqlCommand oCmdS = new SqlCommand(Item.ItemArray[0].ToString(), ObjCnn);
				oCmdS.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Access2SqlCONSEJO = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		oCmd.Connection = oCnAccess;
		oCmd.CommandText = "select 'Exec SpRRHH_Marcacion_Import '''&Valor&''', '''&Fecha&''', '''&Estado&''', '''&Lugar&''' , " + Conversions.ToString(forzar) + "' from marcacion where Fecha >= '" + FechaInicial + " 00:00:00' and Fecha < '" + FechaFinal + " 23:59:59' order by Fecha";
		oCmd.CommandType = CommandType.Text;
		oDA.SelectCommand = oCmd;
		DataTable oDtMarcacion = new DataTable();
		oDA.Fill(oDtMarcacion);
		try
		{
			foreach (DataRow Item2 in oDtMarcacion.Rows)
			{
				SqlCommand oCmdS2 = new SqlCommand(Item2.ItemArray[0].ToString(), ObjCnn);
				oCmdS2.ExecuteNonQuery();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Access2SqlCONSEJO = false;
			ProjectData.ClearProjectError();
			goto IL_0312;
		}
		if (oCnAccess.State == ConnectionState.Open)
		{
			oCnAccess.Close();
		}
		if (ObjCnn.State == ConnectionState.Open)
		{
			ObjCnn.Close();
		}
		Access2SqlCONSEJO = true;
		goto IL_0312;
		IL_0312:
		return Access2SqlCONSEJO;
	}
}
