using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_FuncFamMapper : GenericMapper<RRHH_FuncFam, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_FuncFamMapper()
	{
	}

	public static GenericMapper<RRHH_FuncFam, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_FuncFam, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_FuncFam, dcGRLLDataContext>.InstanceBase();
	}
}
