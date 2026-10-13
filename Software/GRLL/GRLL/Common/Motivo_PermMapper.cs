using System.Diagnostics;

namespace GRLL.Common;

public class Motivo_PermMapper : GenericMapper<Motivo_Perm, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Motivo_PermMapper()
	{
	}

	public static GenericMapper<Motivo_Perm, dcGRLLDataContext> Instance()
	{
		GenericMapper<Motivo_Perm, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Motivo_Perm, dcGRLLDataContext>.InstanceBase();
	}
}
