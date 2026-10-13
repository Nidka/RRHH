using System.Diagnostics;

namespace GRLL.Common;

public class MetaMapper : GenericMapper<Meta, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public MetaMapper()
	{
	}

	public static GenericMapper<Meta, dcGRLLDataContext> Instance()
	{
		GenericMapper<Meta, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Meta, dcGRLLDataContext>.InstanceBase();
	}
}
