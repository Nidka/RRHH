using System.Diagnostics;

namespace GRLL.Common;

public class VS_ABA_LISTARPROVEEDORMapper : GenericMapper<VS_ABA_LISTARPROVEEDOR, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_ABA_LISTARPROVEEDORMapper()
	{
	}

	public static GenericMapper<VS_ABA_LISTARPROVEEDOR, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_ABA_LISTARPROVEEDOR, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_ABA_LISTARPROVEEDOR, dcGRLLDataContext>.InstanceBase();
	}
}
