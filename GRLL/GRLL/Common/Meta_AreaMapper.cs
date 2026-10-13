using System.Diagnostics;

namespace GRLL.Common;

public class Meta_AreaMapper : GenericMapper<Meta_Area, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Meta_AreaMapper()
	{
	}

	public static GenericMapper<Meta_Area, dcGRLLDataContext> Instance()
	{
		GenericMapper<Meta_Area, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Meta_Area, dcGRLLDataContext>.InstanceBase();
	}
}
