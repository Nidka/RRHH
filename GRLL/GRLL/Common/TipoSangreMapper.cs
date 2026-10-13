using System.Diagnostics;

namespace GRLL.Common;

public class TipoSangreMapper : GenericMapper<TipoSangre, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoSangreMapper()
	{
	}

	public static GenericMapper<TipoSangre, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoSangre, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoSangre, dcGRLLDataContext>.InstanceBase();
	}
}
