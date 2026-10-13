using System.Diagnostics;

namespace GRLL.Common;

public class ComportamientoMapper : GenericMapper<Comportamiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ComportamientoMapper()
	{
	}

	public static GenericMapper<Comportamiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<Comportamiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Comportamiento, dcGRLLDataContext>.InstanceBase();
	}
}
