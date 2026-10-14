using System.Data;
using RRHH.PostgreSql;

namespace ClassRRHH;

public class FamiliaresClass
{
	private readonly PostgreSqlExecutor _database;

	public FamiliaresClass()
		: this(new PostgreSqlExecutor())
	{
	}

	public FamiliaresClass(PostgreSqlExecutor database)
	{
		_database = database;
	}

	public object llena_parentezco()
	{
		return _database.Query(
			"SELECT \"IdTipoFam\", \"DescripTipoFam\" " +
			"FROM public.\"TipoFamiliar\" ORDER BY \"DescripTipoFam\";");
	}

	public object Busca_DNI(string numDoc, int tipodoc)
	{
		return _database.Query(
			"SELECT * FROM public.\"Persona\" " +
			"WHERE btrim(\"NumDocID\") = btrim(@numDoc) AND \"TipoDocID\" = @tipoDoc;",
			new PostgreSqlParameterValue("numDoc", numDoc),
			new PostgreSqlParameterValue("tipoDoc", tipodoc));
	}

	public object Busca_Codigo(int Codper)
	{
		return _database.Query(
			"SELECT p.*, f.* FROM public.\"Persona\" AS p " +
			"INNER JOIN public.\"Familiar\" AS f ON f.\"IdPersona\" = p.\"IdPersona\" " +
			"WHERE p.\"IdPersona\" = @personaId;",
			new PostgreSqlParameterValue("personaId", Codper));
	}
}
