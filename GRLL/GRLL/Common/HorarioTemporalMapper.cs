using System.Diagnostics;

namespace GRLL.Common;

public class HorarioTemporalMapper : GenericMapper<HorarioTemporal, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public HorarioTemporalMapper()
	{
	}

	public static GenericMapper<HorarioTemporal, dcGRLLDataContext> Instance()
	{
		GenericMapper<HorarioTemporal, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<HorarioTemporal, dcGRLLDataContext>.InstanceBase();
	}
}
