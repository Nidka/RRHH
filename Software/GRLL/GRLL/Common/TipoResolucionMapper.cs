using System.Diagnostics;

namespace GRLL.Common;

public class TipoResolucionMapper : GenericMapper<TipoResolucion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoResolucionMapper()
	{
	}

	public static GenericMapper<TipoResolucion, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoResolucion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoResolucion, dcGRLLDataContext>.InstanceBase();
	}
}
