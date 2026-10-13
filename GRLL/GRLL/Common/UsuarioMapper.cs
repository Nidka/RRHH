using System.Diagnostics;

namespace GRLL.Common;

public class UsuarioMapper : GenericMapper<Usuario, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public UsuarioMapper()
	{
	}

	public static GenericMapper<Usuario, dcGRLLDataContext> Instance()
	{
		GenericMapper<Usuario, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Usuario, dcGRLLDataContext>.InstanceBase();
	}
}
