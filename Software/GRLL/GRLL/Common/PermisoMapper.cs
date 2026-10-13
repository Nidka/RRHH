using System.Diagnostics;

namespace GRLL.Common;

public class PermisoMapper : GenericMapper<Permiso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PermisoMapper()
	{
	}

	public static GenericMapper<Permiso, dcGRLLDataContext> Instance()
	{
		GenericMapper<Permiso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Permiso, dcGRLLDataContext>.InstanceBase();
	}
}
