using System.Diagnostics;

namespace GRLL.Common;

public class EstadoEstudioMapper : GenericMapper<EstadoEstudio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EstadoEstudioMapper()
	{
	}

	public static GenericMapper<EstadoEstudio, dcGRLLDataContext> Instance()
	{
		GenericMapper<EstadoEstudio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EstadoEstudio, dcGRLLDataContext>.InstanceBase();
	}
}
