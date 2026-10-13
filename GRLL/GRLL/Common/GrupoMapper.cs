using System.Diagnostics;

namespace GRLL.Common;

public class GrupoMapper : GenericMapper<Grupo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public GrupoMapper()
	{
	}

	public static GenericMapper<Grupo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Grupo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Grupo, dcGRLLDataContext>.InstanceBase();
	}
}
