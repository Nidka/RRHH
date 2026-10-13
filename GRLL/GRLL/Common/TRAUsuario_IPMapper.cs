using System.Diagnostics;

namespace GRLL.Common;

public class TRAUsuario_IPMapper : GenericMapper<TRAUsuario_IP, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAUsuario_IPMapper()
	{
	}

	public static GenericMapper<TRAUsuario_IP, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAUsuario_IP, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAUsuario_IP, dcGRLLDataContext>.InstanceBase();
	}
}
