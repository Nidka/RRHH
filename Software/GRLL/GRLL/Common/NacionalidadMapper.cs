using System.Diagnostics;

namespace GRLL.Common;

public class NacionalidadMapper : GenericMapper<Nacionalidad, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public NacionalidadMapper()
	{
	}

	public static GenericMapper<Nacionalidad, dcGRLLDataContext> Instance()
	{
		GenericMapper<Nacionalidad, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Nacionalidad, dcGRLLDataContext>.InstanceBase();
	}
}
