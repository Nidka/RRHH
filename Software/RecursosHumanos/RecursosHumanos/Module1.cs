using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[StandardModule]
internal sealed class Module1
{
	// Contexto SQL Server heredado. Se conserva temporalmente para que los
	// módulos aún no migrados sigan compilando; no se usa en el nuevo login.
	// Las dependencias nuevas se crean en CompositionRoot.
	public static readonly PostgreSqlLegacyContext DcGrll = new PostgreSqlLegacyContext();
}
