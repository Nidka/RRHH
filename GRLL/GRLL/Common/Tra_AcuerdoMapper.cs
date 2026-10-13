using System.Diagnostics;

namespace GRLL.Common;

public class Tra_AcuerdoMapper : GenericMapper<Tra_Acuerdo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Tra_AcuerdoMapper()
	{
	}

	public static GenericMapper<Tra_Acuerdo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Tra_Acuerdo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Tra_Acuerdo, dcGRLLDataContext>.InstanceBase();
	}
}
