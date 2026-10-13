using System.Diagnostics;

namespace GRLL.Common;

public class vCJ_PersonaJuridicaMapper : GenericMapper<vCJ_PersonaJuridica, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vCJ_PersonaJuridicaMapper()
	{
	}

	public static GenericMapper<vCJ_PersonaJuridica, dcGRLLDataContext> Instance()
	{
		GenericMapper<vCJ_PersonaJuridica, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vCJ_PersonaJuridica, dcGRLLDataContext>.InstanceBase();
	}
}
