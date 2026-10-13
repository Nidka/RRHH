using System.Diagnostics;

namespace GRLL.Common;

public class TipoInstitucionMapper : GenericMapper<TipoInstitucion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoInstitucionMapper()
	{
	}

	public static GenericMapper<TipoInstitucion, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoInstitucion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoInstitucion, dcGRLLDataContext>.InstanceBase();
	}
}
