using System.Diagnostics;

namespace GRLL.Common;

public class Almacen_BienMapper : GenericMapper<Almacen_Bien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Almacen_BienMapper()
	{
	}

	public static GenericMapper<Almacen_Bien, dcGRLLDataContext> Instance()
	{
		GenericMapper<Almacen_Bien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Almacen_Bien, dcGRLLDataContext>.InstanceBase();
	}
}
