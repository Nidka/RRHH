using System.Diagnostics;

namespace GRLL.Common;

public class TRATipoSilencioMapper : GenericMapper<TRATipoSilencio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRATipoSilencioMapper()
	{
	}

	public static GenericMapper<TRATipoSilencio, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRATipoSilencio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRATipoSilencio, dcGRLLDataContext>.InstanceBase();
	}
}
