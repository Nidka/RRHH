using System.Diagnostics;

namespace GRLL.Common;

public class TRATramite_RequisitoMapper : GenericMapper<TRATramite_Requisito, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRATramite_RequisitoMapper()
	{
	}

	public static GenericMapper<TRATramite_Requisito, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRATramite_Requisito, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRATramite_Requisito, dcGRLLDataContext>.InstanceBase();
	}
}
