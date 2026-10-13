using System.Diagnostics;

namespace GRLL.Common;

public class Proveedor_BienMapper : GenericMapper<Proveedor_Bien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Proveedor_BienMapper()
	{
	}

	public static GenericMapper<Proveedor_Bien, dcGRLLDataContext> Instance()
	{
		GenericMapper<Proveedor_Bien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Proveedor_Bien, dcGRLLDataContext>.InstanceBase();
	}
}
