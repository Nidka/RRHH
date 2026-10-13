using System.Diagnostics;

namespace GRLL.Common;

public class PersonaMapper : GenericMapper<Persona, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PersonaMapper()
	{
	}

	public static GenericMapper<Persona, dcGRLLDataContext> Instance()
	{
		GenericMapper<Persona, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Persona, dcGRLLDataContext>.InstanceBase();
	}
}
