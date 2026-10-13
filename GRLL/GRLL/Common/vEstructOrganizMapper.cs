using System.Diagnostics;

namespace GRLL.Common;

public class vEstructOrganizMapper : GenericMapper<vEstructOrganiz, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vEstructOrganizMapper()
	{
	}

	public static GenericMapper<vEstructOrganiz, dcGRLLDataContext> Instance()
	{
		GenericMapper<vEstructOrganiz, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vEstructOrganiz, dcGRLLDataContext>.InstanceBase();
	}
}
