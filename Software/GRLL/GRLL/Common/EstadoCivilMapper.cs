using System.Diagnostics;

namespace GRLL.Common;

public class EstadoCivilMapper : GenericMapper<EstadoCivil, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EstadoCivilMapper()
	{
	}

	public static GenericMapper<EstadoCivil, dcGRLLDataContext> Instance()
	{
		GenericMapper<EstadoCivil, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EstadoCivil, dcGRLLDataContext>.InstanceBase();
	}
}
