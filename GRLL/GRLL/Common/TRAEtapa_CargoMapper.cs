using System.Diagnostics;

namespace GRLL.Common;

public class TRAEtapa_CargoMapper : GenericMapper<TRAEtapa_Cargo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAEtapa_CargoMapper()
	{
	}

	public static GenericMapper<TRAEtapa_Cargo, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAEtapa_Cargo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAEtapa_Cargo, dcGRLLDataContext>.InstanceBase();
	}
}
