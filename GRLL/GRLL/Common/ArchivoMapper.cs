using System.Diagnostics;

namespace GRLL.Common;

public class ArchivoMapper : GenericMapper<Archivo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ArchivoMapper()
	{
	}

	public static GenericMapper<Archivo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Archivo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Archivo, dcGRLLDataContext>.InstanceBase();
	}
}
