using System.Diagnostics;

namespace GRLL.Common;

public class EstructOrganizMapper : GenericMapper<EstructOrganiz, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EstructOrganizMapper()
	{
	}

	public static GenericMapper<EstructOrganiz, dcGRLLDataContext> Instance()
	{
		GenericMapper<EstructOrganiz, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EstructOrganiz, dcGRLLDataContext>.InstanceBase();
	}
}
