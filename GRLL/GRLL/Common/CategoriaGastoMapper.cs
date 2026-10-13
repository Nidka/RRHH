using System.Diagnostics;

namespace GRLL.Common;

public class CategoriaGastoMapper : GenericMapper<CategoriaGasto, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CategoriaGastoMapper()
	{
	}

	public static GenericMapper<CategoriaGasto, dcGRLLDataContext> Instance()
	{
		GenericMapper<CategoriaGasto, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CategoriaGasto, dcGRLLDataContext>.InstanceBase();
	}
}
