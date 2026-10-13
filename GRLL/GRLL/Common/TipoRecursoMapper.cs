using System.Diagnostics;

namespace GRLL.Common;

public class TipoRecursoMapper : GenericMapper<TipoRecurso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoRecursoMapper()
	{
	}

	public static GenericMapper<TipoRecurso, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoRecurso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoRecurso, dcGRLLDataContext>.InstanceBase();
	}
}
