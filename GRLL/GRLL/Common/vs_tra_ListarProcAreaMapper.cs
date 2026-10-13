using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_ListarProcAreaMapper : GenericMapper<vs_tra_ListarProcArea, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_ListarProcAreaMapper()
	{
	}

	public static GenericMapper<vs_tra_ListarProcArea, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_ListarProcArea, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_ListarProcArea, dcGRLLDataContext>.InstanceBase();
	}
}
