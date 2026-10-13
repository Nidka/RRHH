using System.Diagnostics;

namespace GRLL.Common;

public class Tra_Articulo_AcuerdoMapper : GenericMapper<Tra_Articulo_Acuerdo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Tra_Articulo_AcuerdoMapper()
	{
	}

	public static GenericMapper<Tra_Articulo_Acuerdo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Tra_Articulo_Acuerdo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Tra_Articulo_Acuerdo, dcGRLLDataContext>.InstanceBase();
	}
}
