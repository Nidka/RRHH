using System.Data;
using System.Data.SqlClient;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassRRHH;

public class FamiliaresClass
{
	public SqlConnection ObjCnn;

	public SqlDataAdapter objDA;

	public FamiliaresClass()
	{
		ObjCnn = clsConexion.Conexion;
		objDA = new SqlDataAdapter();
	}

	public object llena_parentezco()
	{
		ObjCnn.Open();
		DataTable dt_llena_Parentesco = new DataTable();
		objDA.SelectCommand = new SqlCommand("select IdTipoFam, DescripTipoFam from tipofamiliar", ObjCnn);
		objDA.Fill(dt_llena_Parentesco);
		ObjCnn.Close();
		return dt_llena_Parentesco;
	}

	public object Busca_DNI(string numDoc, int tipodoc)
	{
		ObjCnn.Open();
		DataTable dt_bus_persona = new DataTable();
		objDA.SelectCommand = new SqlCommand("select * from persona where NumDocId='" + numDoc + "'and TipoDocID=" + Conversions.ToString(tipodoc), ObjCnn);
		objDA.Fill(dt_bus_persona);
		ObjCnn.Close();
		return dt_bus_persona;
	}

	public object Busca_Codigo(int Codper)
	{
		ObjCnn.Open();
		DataTable dt_bus_persona = new DataTable();
		objDA.SelectCommand = new SqlCommand("select * from persona inner join familiar on familiar.idpersona=persona.idpersona where persona.IdPersona=" + Conversions.ToString(Codper), ObjCnn);
		objDA.Fill(dt_bus_persona);
		ObjCnn.Close();
		return dt_bus_persona;
	}
}
