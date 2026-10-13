using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_proveedorMapper : GenericMapper<vs_ABA_Proveedor, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_proveedorMapper()
	{
	}

	public static GenericMapper<vs_ABA_Proveedor, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_Proveedor, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_Proveedor, dcGRLLDataContext>.InstanceBase();
	}
}
