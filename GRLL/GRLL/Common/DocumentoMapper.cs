using System.Diagnostics;

namespace GRLL.Common;

public class DocumentoMapper : GenericMapper<Documento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public DocumentoMapper()
	{
	}

	public static GenericMapper<Documento, dcGRLLDataContext> Instance()
	{
		GenericMapper<Documento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Documento, dcGRLLDataContext>.InstanceBase();
	}
}
