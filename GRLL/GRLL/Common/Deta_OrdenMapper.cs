using System.Diagnostics;

namespace GRLL.Common;

public class Deta_OrdenMapper : GenericMapper<Deta_Orden, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_OrdenMapper()
	{
	}

	public static GenericMapper<Deta_Orden, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Orden, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Orden, dcGRLLDataContext>.InstanceBase();
	}
}
