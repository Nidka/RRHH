using System.Diagnostics;

namespace GRLL.Common;

public class TRATramiteMapper : GenericMapper<TRATramite, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRATramiteMapper()
	{
	}

	public static GenericMapper<TRATramite, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRATramite, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRATramite, dcGRLLDataContext>.InstanceBase();
	}
}
