using System.Diagnostics;

namespace GRLL.Common;

public class vCJ_PersonaNaturalMapper : GenericMapper<vCJ_PersonaNatural, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vCJ_PersonaNaturalMapper()
	{
	}

	public static GenericMapper<vCJ_PersonaNatural, dcGRLLDataContext> Instance()
	{
		GenericMapper<vCJ_PersonaNatural, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vCJ_PersonaNatural, dcGRLLDataContext>.InstanceBase();
	}
}
