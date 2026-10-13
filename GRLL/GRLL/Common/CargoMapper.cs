using System.Diagnostics;

namespace GRLL.Common;

public class CargoMapper : GenericMapper<Cargo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CargoMapper()
	{
	}

	public static GenericMapper<Cargo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Cargo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Cargo, dcGRLLDataContext>.InstanceBase();
	}
}
