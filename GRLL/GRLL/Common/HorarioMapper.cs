using System.Diagnostics;

namespace GRLL.Common;

public class HorarioMapper : GenericMapper<Horario, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public HorarioMapper()
	{
	}

	public static GenericMapper<Horario, dcGRLLDataContext> Instance()
	{
		GenericMapper<Horario, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Horario, dcGRLLDataContext>.InstanceBase();
	}
}
