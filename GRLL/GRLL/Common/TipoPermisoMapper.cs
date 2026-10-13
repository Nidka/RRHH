using System.Diagnostics;

namespace GRLL.Common;

public class TipoPermisoMapper : GenericMapper<TipoPermiso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoPermisoMapper()
	{
	}

	public static GenericMapper<TipoPermiso, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoPermiso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoPermiso, dcGRLLDataContext>.InstanceBase();
	}
}
