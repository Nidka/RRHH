using System.Diagnostics;

namespace GRLL.Common;

public class EstudiosRealizadoMapper : GenericMapper<EstudiosRealizado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EstudiosRealizadoMapper()
	{
	}

	public static GenericMapper<EstudiosRealizado, dcGRLLDataContext> Instance()
	{
		GenericMapper<EstudiosRealizado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EstudiosRealizado, dcGRLLDataContext>.InstanceBase();
	}
}
