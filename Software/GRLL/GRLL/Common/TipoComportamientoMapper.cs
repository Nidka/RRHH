using System.Diagnostics;

namespace GRLL.Common;

public class TipoComportamientoMapper : GenericMapper<TipoComportamiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoComportamientoMapper()
	{
	}

	public static GenericMapper<TipoComportamiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoComportamiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoComportamiento, dcGRLLDataContext>.InstanceBase();
	}
}
