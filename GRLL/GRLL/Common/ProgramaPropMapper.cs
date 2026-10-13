using System.Diagnostics;

namespace GRLL.Common;

public class ProgramaPropMapper : GenericMapper<ProgramaProp, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ProgramaPropMapper()
	{
	}

	public static GenericMapper<ProgramaProp, dcGRLLDataContext> Instance()
	{
		GenericMapper<ProgramaProp, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ProgramaProp, dcGRLLDataContext>.InstanceBase();
	}
}
