using System.Diagnostics;

namespace GRLL.Common;

public class VS_TRA_ACUERDO_ARTICULOMapper : GenericMapper<VS_TRA_ACUERDO_ARTICULO, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_TRA_ACUERDO_ARTICULOMapper()
	{
	}

	public static GenericMapper<VS_TRA_ACUERDO_ARTICULO, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_TRA_ACUERDO_ARTICULO, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_TRA_ACUERDO_ARTICULO, dcGRLLDataContext>.InstanceBase();
	}
}
