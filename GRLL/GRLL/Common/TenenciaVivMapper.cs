using System.Diagnostics;

namespace GRLL.Common;

public class TenenciaVivMapper : GenericMapper<TenenciaViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TenenciaVivMapper()
	{
	}

	public static GenericMapper<TenenciaViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<TenenciaViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TenenciaViv, dcGRLLDataContext>.InstanceBase();
	}
}
