using System.Diagnostics;

namespace GRLL.Common;

public class TRANumeracionMapper : GenericMapper<TRANumeracion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRANumeracionMapper()
	{
	}

	public static GenericMapper<TRANumeracion, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRANumeracion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRANumeracion, dcGRLLDataContext>.InstanceBase();
	}
}
