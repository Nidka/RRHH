using System.Diagnostics;

namespace GRLL.Common;

public class Rol_AccesoMapper : GenericMapper<Rol_Acceso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Rol_AccesoMapper()
	{
	}

	public static GenericMapper<Rol_Acceso, dcGRLLDataContext> Instance()
	{
		GenericMapper<Rol_Acceso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Rol_Acceso, dcGRLLDataContext>.InstanceBase();
	}
}
