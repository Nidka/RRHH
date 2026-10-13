using System.Diagnostics;

namespace GRLL.Common;

public class TipoDocMapper : GenericMapper<TipoDoc, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoDocMapper()
	{
	}

	public static GenericMapper<TipoDoc, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoDoc, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoDoc, dcGRLLDataContext>.InstanceBase();
	}
}
