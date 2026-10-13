using System.Diagnostics;

namespace GRLL.Common;

public class PapeletDepositCajMapper : GenericMapper<PapeletDepositCaj, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PapeletDepositCajMapper()
	{
	}

	public static GenericMapper<PapeletDepositCaj, dcGRLLDataContext> Instance()
	{
		GenericMapper<PapeletDepositCaj, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<PapeletDepositCaj, dcGRLLDataContext>.InstanceBase();
	}
}
