using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_TempFechaMapper : GenericMapper<RRHH_TempFecha, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_TempFechaMapper()
	{
	}

	public static GenericMapper<RRHH_TempFecha, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_TempFecha, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_TempFecha, dcGRLLDataContext>.InstanceBase();
	}
}
