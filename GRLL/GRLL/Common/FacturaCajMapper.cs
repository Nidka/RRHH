using System.Diagnostics;

namespace GRLL.Common;

public class FacturaCajMapper : GenericMapper<FacturaCaj, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public FacturaCajMapper()
	{
	}

	public static GenericMapper<FacturaCaj, dcGRLLDataContext> Instance()
	{
		GenericMapper<FacturaCaj, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<FacturaCaj, dcGRLLDataContext>.InstanceBase();
	}
}
