using System.Diagnostics;

namespace GRLL.Common;

public class ViviendaMapper : GenericMapper<Vivienda, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ViviendaMapper()
	{
	}

	public static GenericMapper<Vivienda, dcGRLLDataContext> Instance()
	{
		GenericMapper<Vivienda, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Vivienda, dcGRLLDataContext>.InstanceBase();
	}
}
