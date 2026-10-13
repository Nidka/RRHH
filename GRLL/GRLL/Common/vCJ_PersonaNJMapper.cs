using System.Diagnostics;

namespace GRLL.Common;

public class vCJ_PersonaNJMapper : GenericMapper<vCJ_PersonaNJ, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vCJ_PersonaNJMapper()
	{
	}

	public static GenericMapper<vCJ_PersonaNJ, dcGRLLDataContext> Instance()
	{
		GenericMapper<vCJ_PersonaNJ, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vCJ_PersonaNJ, dcGRLLDataContext>.InstanceBase();
	}
}
