using System.Diagnostics;

namespace GRLL.Common;

public class TipoTrabajadorMapper : GenericMapper<TipoTrabajador, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoTrabajadorMapper()
	{
	}

	public static GenericMapper<TipoTrabajador, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoTrabajador, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoTrabajador, dcGRLLDataContext>.InstanceBase();
	}
}
