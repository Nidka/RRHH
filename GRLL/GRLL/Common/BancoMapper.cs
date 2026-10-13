using System.Diagnostics;

namespace GRLL.Common;

public class BancoMapper : GenericMapper<Banco, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public BancoMapper()
	{
	}

	public static GenericMapper<Banco, dcGRLLDataContext> Instance()
	{
		GenericMapper<Banco, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Banco, dcGRLLDataContext>.InstanceBase();
	}
}
