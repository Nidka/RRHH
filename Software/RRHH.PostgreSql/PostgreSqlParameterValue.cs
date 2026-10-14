using System.Data;

namespace RRHH.PostgreSql;

public sealed class PostgreSqlParameterValue
{
	public string Name { get; }
	public object Value { get; }
	public DbType? Type { get; }

	public PostgreSqlParameterValue(string name, object value, DbType? type = null)
	{
		Name = name;
		Value = value;
		Type = type;
	}
}
