using System.Diagnostics;

namespace GRLL.Common;

public class TipoAlertaMapper : GenericMapper<TipoAlerta, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoAlertaMapper()
	{
	}

	public static GenericMapper<TipoAlerta, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoAlerta, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoAlerta, dcGRLLDataContext>.InstanceBase();
	}
}
