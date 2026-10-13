using System.Diagnostics;

namespace GRLL.Common;

public class TipoEstudioMapper : GenericMapper<TipoEstudio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoEstudioMapper()
	{
	}

	public static GenericMapper<TipoEstudio, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoEstudio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoEstudio, dcGRLLDataContext>.InstanceBase();
	}
}
