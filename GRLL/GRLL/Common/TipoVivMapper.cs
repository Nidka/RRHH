using System.Diagnostics;

namespace GRLL.Common;

public class TipoVivMapper : GenericMapper<TipoViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoVivMapper()
	{
	}

	public static GenericMapper<TipoViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoViv, dcGRLLDataContext>.InstanceBase();
	}
}
