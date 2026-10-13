using System.Diagnostics;

namespace GRLL.Common;

public class Usuario_RolMapper : GenericMapper<Usuario_Rol, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Usuario_RolMapper()
	{
	}

	public static GenericMapper<Usuario_Rol, dcGRLLDataContext> Instance()
	{
		GenericMapper<Usuario_Rol, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Usuario_Rol, dcGRLLDataContext>.InstanceBase();
	}
}
