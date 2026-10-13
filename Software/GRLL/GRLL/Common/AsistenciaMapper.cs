using System.Diagnostics;

namespace GRLL.Common;

public class AsistenciaMapper : GenericMapper<Asistencia, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AsistenciaMapper()
	{
	}

	public static GenericMapper<Asistencia, dcGRLLDataContext> Instance()
	{
		GenericMapper<Asistencia, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Asistencia, dcGRLLDataContext>.InstanceBase();
	}
}
