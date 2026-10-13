using System.Diagnostics;

namespace GRLL.Common;

public class MotivoBajaMapper : GenericMapper<MotivoBaja, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public MotivoBajaMapper()
	{
	}

	public static GenericMapper<MotivoBaja, dcGRLLDataContext> Instance()
	{
		GenericMapper<MotivoBaja, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<MotivoBaja, dcGRLLDataContext>.InstanceBase();
	}
}
