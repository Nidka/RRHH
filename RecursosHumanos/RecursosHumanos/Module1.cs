using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[StandardModule]
internal sealed class Module1
{
	public static dcGRLLDataContext DcGrll = new dcGRLLDataContext(clsConexion.Conexion);
}
