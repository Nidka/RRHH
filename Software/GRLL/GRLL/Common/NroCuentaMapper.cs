using System.Diagnostics;

namespace GRLL.Common;

public class NroCuentaMapper : GenericMapper<NroCuenta, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public NroCuentaMapper()
	{
	}

	public static GenericMapper<NroCuenta, dcGRLLDataContext> Instance()
	{
		GenericMapper<NroCuenta, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<NroCuenta, dcGRLLDataContext>.InstanceBase();
	}
}
