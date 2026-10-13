using System.Diagnostics;

namespace GRLL.Common;

public class RolMapper : GenericMapper<Rol, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RolMapper()
	{
	}

	public static GenericMapper<Rol, dcGRLLDataContext> Instance()
	{
		GenericMapper<Rol, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Rol, dcGRLLDataContext>.InstanceBase();
	}
}
