using System.Diagnostics;

namespace GRLL.Common;

public class VS_ABA_LISTARBIEN_ALMACENMapper : GenericMapper<VS_ABA_LISTARBIEN_ALMACEN, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_ABA_LISTARBIEN_ALMACENMapper()
	{
	}

	public static GenericMapper<VS_ABA_LISTARBIEN_ALMACEN, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_ABA_LISTARBIEN_ALMACEN, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_ABA_LISTARBIEN_ALMACEN, dcGRLLDataContext>.InstanceBase();
	}
}
