using System.Data;
using System.Data.SqlClient;
using GRLL.Common;

namespace ClassRRHH;

public class FichaSocialClass
{
	public SqlConnection ObjCnn;

	public SqlDataAdapter objDA;

	public FichaSocialClass()
	{
		ObjCnn = clsConexion.Conexion;
		objDA = new SqlDataAdapter();
	}

	public object llenarFamiliares(int CodEmple)
	{
		ObjCnn.Open();
		DataTable dt_llena_Familiares = new DataTable();
		objDA.SelectCommand = new SqlCommand("spRRHH_BuscarFamiliares", ObjCnn);
		objDA.SelectCommand.CommandType = CommandType.StoredProcedure;
		objDA.SelectCommand.Parameters.Add("@idempleado", SqlDbType.Int).Value = CodEmple;
		objDA.Fill(dt_llena_Familiares);
		ObjCnn.Close();
		return dt_llena_Familiares;
	}
}
