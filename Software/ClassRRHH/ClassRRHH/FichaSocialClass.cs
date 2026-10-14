using System.Data;
using RRHH.PostgreSql;

namespace ClassRRHH;

public class FichaSocialClass
{
	private readonly PostgreSqlExecutor _database;

	public FichaSocialClass()
		: this(new PostgreSqlExecutor())
	{
	}

	public FichaSocialClass(PostgreSqlExecutor database)
	{
		_database = database;
	}

	public object llenarFamiliares(int CodEmple)
	{
		const string sql = """
SELECT
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    p."FechaNacimiento" AS "fechaNacimiento",
    f."FamSexo" AS "famSexo",
    tf."DescripTipoFam",
    f."FamGradoInstruc" AS "famgradoInstruc",
    ec."DescripEstCivil" AS "descripestcivil",
    f."ViveCasa" AS "vivecasa",
    p."IdPersona" AS "Idpersona",
    f."LaboraInstitucion" AS "laborainstitucion"
FROM public."Familiar" AS f
INNER JOIN public."Persona" AS p ON p."IdPersona" = f."IdPersona"
LEFT JOIN public."TipoFamiliar" AS tf ON tf."IdTipoFam" = f."IdTipoFam"
LEFT JOIN public."EstadoCivil" AS ec ON ec."IdEstadoCivil" = f."IdEstadoCivil"
WHERE f."IdEmpleado" = @empleadoId
ORDER BY "NombresCompletos";
""";

		return _database.Query(
			sql,
			new PostgreSqlParameterValue("empleadoId", CodEmple));
	}
}
