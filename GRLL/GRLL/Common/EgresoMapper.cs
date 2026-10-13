using System.Diagnostics;

namespace GRLL.Common;

public class EgresoMapper : GenericMapper<Egreso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EgresoMapper()
	{
	}

	public static GenericMapper<Egreso, dcGRLLDataContext> Instance()
	{
		GenericMapper<Egreso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Egreso, dcGRLLDataContext>.InstanceBase();
	}
}
