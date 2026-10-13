using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_AcudeEnfermMapper : GenericMapper<RRHH_AcudeEnferm, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_AcudeEnfermMapper()
	{
	}

	public static GenericMapper<RRHH_AcudeEnferm, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_AcudeEnferm, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_AcudeEnferm, dcGRLLDataContext>.InstanceBase();
	}
}
