using System.Diagnostics;

namespace GRLL.Common;

public class ModalidadAplicacionMapper : GenericMapper<ModalidadAplicacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ModalidadAplicacionMapper()
	{
	}

	public static GenericMapper<ModalidadAplicacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<ModalidadAplicacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ModalidadAplicacion, dcGRLLDataContext>.InstanceBase();
	}
}
