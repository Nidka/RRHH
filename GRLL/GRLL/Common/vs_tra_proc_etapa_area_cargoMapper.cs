using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_proc_etapa_area_cargoMapper : GenericMapper<vs_tra_proc_etapa_area_cargo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_proc_etapa_area_cargoMapper()
	{
	}

	public static GenericMapper<vs_tra_proc_etapa_area_cargo, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_proc_etapa_area_cargo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_proc_etapa_area_cargo, dcGRLLDataContext>.InstanceBase();
	}
}
