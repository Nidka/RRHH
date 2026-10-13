using System.Diagnostics;

namespace GRLL.Common;

public class IngresoMapper : GenericMapper<Ingreso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public IngresoMapper()
	{
	}

	public static GenericMapper<Ingreso, dcGRLLDataContext> Instance()
	{
		GenericMapper<Ingreso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Ingreso, dcGRLLDataContext>.InstanceBase();
	}
}
