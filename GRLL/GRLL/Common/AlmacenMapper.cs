using System.Diagnostics;

namespace GRLL.Common;

public class AlmacenMapper : GenericMapper<Almacen, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AlmacenMapper()
	{
	}

	public static GenericMapper<Almacen, dcGRLLDataContext> Instance()
	{
		GenericMapper<Almacen, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Almacen, dcGRLLDataContext>.InstanceBase();
	}
}
