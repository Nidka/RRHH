using System.Diagnostics;

namespace GRLL.Common;

public class TransferenciaBcoMapper : GenericMapper<TransferenciaBco, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TransferenciaBcoMapper()
	{
	}

	public static GenericMapper<TransferenciaBco, dcGRLLDataContext> Instance()
	{
		GenericMapper<TransferenciaBco, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TransferenciaBco, dcGRLLDataContext>.InstanceBase();
	}
}
