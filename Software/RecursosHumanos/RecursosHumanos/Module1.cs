using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.Data;

namespace RecursosHumanos;

[StandardModule]
internal sealed class Module1
{
	public static readonly PostgreSqlConnectionFactory PostgreSql = new PostgreSqlConnectionFactory();

	public static readonly PostgreSqlUserRepository Users = new PostgreSqlUserRepository(PostgreSql);

	// Contexto SQL Server heredado. Se conserva temporalmente para que los
	// módulos aún no migrados sigan compilando; no se usa en el nuevo login.
	public static dcGRLLDataContext DcGrll = new dcGRLLDataContext(clsConexion.Conexion);
}
