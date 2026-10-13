using System.Diagnostics;

namespace GRLL.Common;

public class TRAProcedimiento_RequisitoMapper : GenericMapper<TRAProcedimiento_Requisito, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAProcedimiento_RequisitoMapper()
	{
	}

	public static GenericMapper<TRAProcedimiento_Requisito, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAProcedimiento_Requisito, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAProcedimiento_Requisito, dcGRLLDataContext>.InstanceBase();
	}
}
