using System.Diagnostics;

namespace GRLL.Common;

public class UbigeoMapper : GenericMapper<Ubigeo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public UbigeoMapper()
	{
	}

	public static GenericMapper<Ubigeo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Ubigeo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Ubigeo, dcGRLLDataContext>.InstanceBase();
	}
}
