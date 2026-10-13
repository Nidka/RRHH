using System.Diagnostics;

namespace GRLL.Common;

public class TRATipoDocMapper : GenericMapper<TRATipoDoc, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRATipoDocMapper()
	{
	}

	public static GenericMapper<TRATipoDoc, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRATipoDoc, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRATipoDoc, dcGRLLDataContext>.InstanceBase();
	}
}
