using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Globalization;
using System.Linq;
using System.Reflection;
using RRHH.PostgreSql;

namespace GRLL.Common;

/// <summary>
/// Adaptador PostgreSQL para los mappers generados por el sistema original.
/// Mantiene la API que consumen los formularios decompilados, pero evita crear
/// dcGRLLDataContext y, por tanto, elimina su dependencia operativa de SQL Server.
/// </summary>
public class PostgreSqlLegacyMapper<TEntity> where TEntity : class, new()
{
	private readonly PostgreSqlExecutor _database = new PostgreSqlExecutor();

	private static readonly PropertyInfo[] Columns = typeof(TEntity)
		.GetProperties(BindingFlags.Instance | BindingFlags.Public)
		.Where(property => property.CanRead && property.CanWrite &&
			property.GetCustomAttributes(typeof(ColumnAttribute), true).Length > 0)
		.ToArray();

	private static readonly PropertyInfo[] PrimaryKeys = Columns
		.Where(property => ((ColumnAttribute)property
			.GetCustomAttributes(typeof(ColumnAttribute), true)[0]).IsPrimaryKey)
		.ToArray();

	private static readonly string TableName = ResolveTableName();

	[DataObjectMethod(DataObjectMethodType.Select)]
	public List<TEntity> SelectAll()
	{
		return Map(_database.Query($"SELECT * FROM {QuoteTable(TableName)};"));
	}

	[DataObjectMethod(DataObjectMethodType.Select)]
	public List<TEntity> SelectBy(Func<TEntity, bool> predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException(nameof(predicate));
		}

		return SelectAll().Where(predicate).ToList();
	}

	public TEntity SelectOneBy(Func<TEntity, bool> predicate)
	{
		return SelectBy(predicate).FirstOrDefault();
	}

	public TEntity SelectOneBy(TEntity entity)
	{
		return entity;
	}

	public TEntity GetEntity(int id)
	{
		if (PrimaryKeys.Length != 1)
		{
			throw new InvalidOperationException(
				$"{TableName} no tiene una clave primaria simple para GetEntity(int).");
		}

		PropertyInfo key = PrimaryKeys[0];
		DataTable result = _database.Query(
			$"SELECT * FROM {QuoteTable(TableName)} WHERE {QuoteIdentifier(ColumnName(key))} = @id LIMIT 1;",
			new PostgreSqlParameterValue("id", id));
		return Map(result).FirstOrDefault();
	}

	[DataObjectMethod(DataObjectMethodType.Insert)]
	public void Insert(TEntity entity)
	{
		Insert(entity, true);
	}

	public void Insert(TEntity entity, bool submitChanges)
	{
		if (entity == null)
		{
			throw new ArgumentNullException(nameof(entity));
		}

		string names = string.Join(", ", Columns.Select(property => QuoteIdentifier(ColumnName(property))));
		string values = string.Join(", ", Columns.Select((property, index) => "@p" + index));
		_database.Execute(
			$"INSERT INTO {QuoteTable(TableName)} ({names}) VALUES ({values});",
			Parameters(entity, Columns));
	}

	public void InsertAll(List<TEntity> entities)
	{
		if (entities == null)
		{
			throw new ArgumentNullException(nameof(entities));
		}

		foreach (TEntity entity in entities)
		{
			Insert(entity);
		}
	}

	[DataObjectMethod(DataObjectMethodType.Update)]
	public void Update(TEntity entity)
	{
		Update(entity, true);
	}

	public void Update(TEntity entity, bool submitChanges)
	{
		if (entity == null)
		{
			throw new ArgumentNullException(nameof(entity));
		}

		EnsurePrimaryKey();
		List<PropertyInfo> updateColumns = Columns.Except(PrimaryKeys).ToList();
		string assignments = string.Join(", ", updateColumns.Select(
			(property, index) => $"{QuoteIdentifier(ColumnName(property))} = @p{index}"));
		string where = BuildKeyWhere(updateColumns.Count);
		PropertyInfo[] parameters = updateColumns.Concat(PrimaryKeys).ToArray();
		int affected = _database.Execute(
			$"UPDATE {QuoteTable(TableName)} SET {assignments} WHERE {where};",
			Parameters(entity, parameters));
		if (affected == 0)
		{
			throw new InvalidOperationException("No se encontro el registro que se desea actualizar.");
		}
	}

	public void UpdateBy(TEntity values, Func<TEntity, bool> predicate)
	{
		List<TEntity> entities = SelectBy(predicate);
		foreach (TEntity entity in entities)
		{
			MergeSpecifiedValues(entity, values);
			Update(entity);
		}
	}

	[DataObjectMethod(DataObjectMethodType.Delete)]
	public void Delete(TEntity entity)
	{
		Delete(entity, true);
	}

	public void Delete(TEntity entity, bool submitChanges)
	{
		if (entity == null)
		{
			throw new ArgumentNullException(nameof(entity));
		}

		EnsurePrimaryKey();
		int affected = _database.Execute(
			$"DELETE FROM {QuoteTable(TableName)} WHERE {BuildKeyWhere(0)};",
			Parameters(entity, PrimaryKeys));
		if (affected == 0)
		{
			throw new InvalidOperationException("No se encontro el registro que se desea eliminar.");
		}
	}

	public void DeleteBy(Func<TEntity, bool> predicate)
	{
		foreach (TEntity entity in SelectBy(predicate))
		{
			Delete(entity);
		}
	}

	// Se conserva por compatibilidad. Cada operacion se confirma inmediatamente.
	public void SubmitChanges()
	{
	}

	private static List<TEntity> Map(DataTable table)
	{
		List<TEntity> result = new List<TEntity>(table.Rows.Count);
		Dictionary<string, DataColumn> dataColumns = table.Columns
			.Cast<DataColumn>()
			.ToDictionary(column => column.ColumnName, StringComparer.OrdinalIgnoreCase);

		foreach (DataRow row in table.Rows)
		{
			TEntity entity = new TEntity();
			foreach (PropertyInfo property in Columns)
			{
				if (!dataColumns.TryGetValue(ColumnName(property), out DataColumn column) ||
					row[column] == DBNull.Value)
				{
					continue;
				}

				property.SetValue(entity, ConvertValue(row[column], property.PropertyType), null);
			}
			result.Add(entity);
		}

		return result;
	}

	private static object ConvertValue(object value, Type destinationType)
	{
		Type actualType = Nullable.GetUnderlyingType(destinationType) ?? destinationType;
		if (actualType == typeof(Binary) && value is byte[] bytes)
		{
			return new Binary(bytes);
		}
		if (actualType == typeof(char))
		{
			string text = Convert.ToString(value, CultureInfo.InvariantCulture);
			return string.IsNullOrEmpty(text) ? '\0' : text[0];
		}
		if (actualType == typeof(Guid))
		{
			if (value is Guid guid)
			{
				return guid;
			}
			return Guid.TryParse(Convert.ToString(value, CultureInfo.InvariantCulture), out Guid parsed)
				? (object)parsed
				: null;
		}
		if (actualType.IsEnum)
		{
			return Enum.ToObject(actualType, value);
		}
		if (actualType.IsInstanceOfType(value))
		{
			return value;
		}
		return Convert.ChangeType(value, actualType, CultureInfo.InvariantCulture);
	}

	private static PostgreSqlParameterValue[] Parameters(TEntity entity, IList<PropertyInfo> properties)
	{
		PostgreSqlParameterValue[] result = new PostgreSqlParameterValue[properties.Count];
		for (int index = 0; index < properties.Count; index++)
		{
			object value = properties[index].GetValue(entity, null);
			if (value is Binary binary)
			{
				value = binary.ToArray();
			}
			else if (value is char character)
			{
				value = character.ToString();
			}
			result[index] = new PostgreSqlParameterValue("p" + index, value);
		}
		return result;
	}

	private static void MergeSpecifiedValues(TEntity destination, TEntity source)
	{
		foreach (PropertyInfo property in Columns.Except(PrimaryKeys))
		{
			object value = property.GetValue(source, null);
			if (value == null)
			{
				continue;
			}
			if (value is int intValue && intValue == -1)
			{
				continue;
			}
			if (value is DateTime dateValue && dateValue == default(DateTime))
			{
				continue;
			}
			if (value is string text && text.Trim() == "<NULL>")
			{
				property.SetValue(destination, null, null);
				continue;
			}
			property.SetValue(destination, value, null);
		}
	}

	private static string BuildKeyWhere(int parameterOffset)
	{
		return string.Join(" AND ", PrimaryKeys.Select((property, index) =>
			$"{QuoteIdentifier(ColumnName(property))} = @p{parameterOffset + index}"));
	}

	private static void EnsurePrimaryKey()
	{
		if (PrimaryKeys.Length == 0)
		{
			throw new InvalidOperationException($"{TableName} no tiene clave primaria mapeada.");
		}
	}

	private static string ResolveTableName()
	{
		TableAttribute attribute = (TableAttribute)typeof(TEntity)
			.GetCustomAttributes(typeof(TableAttribute), false)
			.FirstOrDefault();
		string name = attribute?.Name ?? typeof(TEntity).Name;
		int separator = name.LastIndexOf('.');
		if (separator >= 0)
		{
			name = name.Substring(separator + 1);
		}
		return name.Trim('[', ']');
	}

	private static string ColumnName(PropertyInfo property)
	{
		ColumnAttribute attribute = (ColumnAttribute)property
			.GetCustomAttributes(typeof(ColumnAttribute), true)[0];
		return string.IsNullOrWhiteSpace(attribute.Name) ? property.Name : attribute.Name;
	}

	private static string QuoteTable(string identifier)
	{
		return "public." + QuoteIdentifier(identifier);
	}

	private static string QuoteIdentifier(string identifier)
	{
		if (string.IsNullOrWhiteSpace(identifier) || identifier.IndexOf('"') >= 0)
		{
			throw new InvalidOperationException("Identificador PostgreSQL no valido.");
		}
		return "\"" + identifier + "\"";
	}
}

// Los nombres coinciden con los mappers del DLL original. Al estar compilados
// dentro de la aplicacion, estos adaptadores tienen prioridad y redirigen todos
// los formularios de RRHH a PostgreSQL.
public sealed class AFPMapper : PostgreSqlLegacyMapper<AFP> { public static AFPMapper Instance() => new AFPMapper(); }
public sealed class AguaVivMapper : PostgreSqlLegacyMapper<AguaViv> { public static AguaVivMapper Instance() => new AguaVivMapper(); }
public sealed class AlumbradoVivMapper : PostgreSqlLegacyMapper<AlumbradoViv> { public static AlumbradoVivMapper Instance() => new AlumbradoVivMapper(); }
public sealed class ArchivoMapper : PostgreSqlLegacyMapper<Archivo> { public static ArchivoMapper Instance() => new ArchivoMapper(); }
public sealed class AsistenciaMapper : PostgreSqlLegacyMapper<Asistencia> { public static AsistenciaMapper Instance() => new AsistenciaMapper(); }
public sealed class CapacitacionMapper : PostgreSqlLegacyMapper<Capacitacion> { public static CapacitacionMapper Instance() => new CapacitacionMapper(); }
public sealed class CargoMapper : PostgreSqlLegacyMapper<Cargo> { public static CargoMapper Instance() => new CargoMapper(); }
public sealed class ComportamientoMapper : PostgreSqlLegacyMapper<Comportamiento> { public static ComportamientoMapper Instance() => new ComportamientoMapper(); }
public sealed class ConservacionVivMapper : PostgreSqlLegacyMapper<ConservacionViv> { public static ConservacionVivMapper Instance() => new ConservacionVivMapper(); }
public sealed class DocumentoMapper : PostgreSqlLegacyMapper<Documento> { public static DocumentoMapper Instance() => new DocumentoMapper(); }
public sealed class EgresoMapper : PostgreSqlLegacyMapper<Egreso> { public static EgresoMapper Instance() => new EgresoMapper(); }
public sealed class EmpleadoMapper : PostgreSqlLegacyMapper<Empleado> { public static EmpleadoMapper Instance() => new EmpleadoMapper(); }
public sealed class EstadoEstudioMapper : PostgreSqlLegacyMapper<EstadoEstudio> { public static EstadoEstudioMapper Instance() => new EstadoEstudioMapper(); }
public sealed class EstructOrganizMapper : PostgreSqlLegacyMapper<EstructOrganiz> { public static EstructOrganizMapper Instance() => new EstructOrganizMapper(); }
public sealed class EstudiosRealizadoMapper : PostgreSqlLegacyMapper<EstudiosRealizado> { public static EstudiosRealizadoMapper Instance() => new EstudiosRealizadoMapper(); }
public sealed class ExcretasVivMapper : PostgreSqlLegacyMapper<ExcretasViv> { public static ExcretasVivMapper Instance() => new ExcretasVivMapper(); }
public sealed class ExpLaboralMapper : PostgreSqlLegacyMapper<ExpLaboral> { public static ExpLaboralMapper Instance() => new ExpLaboralMapper(); }
public sealed class FamiliarMapper : PostgreSqlLegacyMapper<Familiar> { public static FamiliarMapper Instance() => new FamiliarMapper(); }
public sealed class HorarioMapper : PostgreSqlLegacyMapper<Horario> { public static HorarioMapper Instance() => new HorarioMapper(); }
public sealed class HorarioTemporalMapper : PostgreSqlLegacyMapper<HorarioTemporal> { public static HorarioTemporalMapper Instance() => new HorarioTemporalMapper(); }
public sealed class IngresoMapper : PostgreSqlLegacyMapper<Ingreso> { public static IngresoMapper Instance() => new IngresoMapper(); }
public sealed class LocalMapper : PostgreSqlLegacyMapper<Local> { public static LocalMapper Instance() => new LocalMapper(); }
public sealed class MarcacionMapper : PostgreSqlLegacyMapper<Marcacion> { public static MarcacionMapper Instance() => new MarcacionMapper(); }
public sealed class MaterialVivMapper : PostgreSqlLegacyMapper<MaterialViv> { public static MaterialVivMapper Instance() => new MaterialVivMapper(); }
public sealed class Motivo_PermMapper : PostgreSqlLegacyMapper<Motivo_Perm> { public static Motivo_PermMapper Instance() => new Motivo_PermMapper(); }
public sealed class MotivoBajaMapper : PostgreSqlLegacyMapper<MotivoBaja> { public static MotivoBajaMapper Instance() => new MotivoBajaMapper(); }
public sealed class PeriodoLaboralMapper : PostgreSqlLegacyMapper<PeriodoLaboral> { public static PeriodoLaboralMapper Instance() => new PeriodoLaboralMapper(); }
public sealed class PermisoMapper : PostgreSqlLegacyMapper<Permiso> { public static PermisoMapper Instance() => new PermisoMapper(); }
public sealed class PersonaMapper : PostgreSqlLegacyMapper<Persona> { public static PersonaMapper Instance() => new PersonaMapper(); }
public sealed class RegimenPensionMapper : PostgreSqlLegacyMapper<RegimenPension> { public static RegimenPensionMapper Instance() => new RegimenPensionMapper(); }
public sealed class ResolucionMapper : PostgreSqlLegacyMapper<Resolucion> { public static ResolucionMapper Instance() => new ResolucionMapper(); }
public sealed class RotacionMapper : PostgreSqlLegacyMapper<Rotacion> { public static RotacionMapper Instance() => new RotacionMapper(); }
public sealed class RRHH_AcudeEnfermMapper : PostgreSqlLegacyMapper<RRHH_AcudeEnferm> { public static RRHH_AcudeEnfermMapper Instance() => new RRHH_AcudeEnfermMapper(); }
public sealed class RRHH_AseguradoMapper : PostgreSqlLegacyMapper<RRHH_Asegurado> { public static RRHH_AseguradoMapper Instance() => new RRHH_AseguradoMapper(); }
public sealed class RRHH_AspSocioMapper : PostgreSqlLegacyMapper<RRHH_AspSocio> { public static RRHH_AspSocioMapper Instance() => new RRHH_AspSocioMapper(); }
public sealed class RRHH_DinamicaFamiliarMapper : PostgreSqlLegacyMapper<RRHH_DinamicaFamiliar> { public static RRHH_DinamicaFamiliarMapper Instance() => new RRHH_DinamicaFamiliarMapper(); }
public sealed class RRHH_FeriadoMapper : PostgreSqlLegacyMapper<RRHH_Feriado> { public static RRHH_FeriadoMapper Instance() => new RRHH_FeriadoMapper(); }
public sealed class RRHH_FuncFamMapper : PostgreSqlLegacyMapper<RRHH_FuncFam> { public static RRHH_FuncFamMapper Instance() => new RRHH_FuncFamMapper(); }
public sealed class RRHH_Preg1Mapper : PostgreSqlLegacyMapper<RRHH_Preg1> { public static RRHH_Preg1Mapper Instance() => new RRHH_Preg1Mapper(); }
public sealed class RRHH_Preg2Mapper : PostgreSqlLegacyMapper<RRHH_Preg2> { public static RRHH_Preg2Mapper Instance() => new RRHH_Preg2Mapper(); }
public sealed class RRHH_Preg3Mapper : PostgreSqlLegacyMapper<RRHH_Preg3> { public static RRHH_Preg3Mapper Instance() => new RRHH_Preg3Mapper(); }
public sealed class RRHH_RelacHermanoMapper : PostgreSqlLegacyMapper<RRHH_RelacHermano> { public static RRHH_RelacHermanoMapper Instance() => new RRHH_RelacHermanoMapper(); }
public sealed class RRHH_RelacParejaMapper : PostgreSqlLegacyMapper<RRHH_RelacPareja> { public static RRHH_RelacParejaMapper Instance() => new RRHH_RelacParejaMapper(); }
public sealed class RRHH_RelacPHMapper : PostgreSqlLegacyMapper<RRHH_RelacPH> { public static RRHH_RelacPHMapper Instance() => new RRHH_RelacPHMapper(); }
public sealed class RRHH_SaludMapper : PostgreSqlLegacyMapper<RRHH_Salud> { public static RRHH_SaludMapper Instance() => new RRHH_SaludMapper(); }
public sealed class RRHH_TempFechaMapper : PostgreSqlLegacyMapper<RRHH_TempFecha> { public static RRHH_TempFechaMapper Instance() => new RRHH_TempFechaMapper(); }
public sealed class RRHH_TipoFamiliaMapper : PostgreSqlLegacyMapper<RRHH_TipoFamilia> { public static RRHH_TipoFamiliaMapper Instance() => new RRHH_TipoFamiliaMapper(); }
public sealed class TenenciaVivMapper : PostgreSqlLegacyMapper<TenenciaViv> { public static TenenciaVivMapper Instance() => new TenenciaVivMapper(); }
public sealed class TipoComportamientoMapper : PostgreSqlLegacyMapper<TipoComportamiento> { public static TipoComportamientoMapper Instance() => new TipoComportamientoMapper(); }
public sealed class TipoDocIDMapper : PostgreSqlLegacyMapper<TipoDocID> { public static TipoDocIDMapper Instance() => new TipoDocIDMapper(); }
public sealed class TipoEstudioMapper : PostgreSqlLegacyMapper<TipoEstudio> { public static TipoEstudioMapper Instance() => new TipoEstudioMapper(); }
public sealed class TipoInstitucionMapper : PostgreSqlLegacyMapper<TipoInstitucion> { public static TipoInstitucionMapper Instance() => new TipoInstitucionMapper(); }
public sealed class TipoPermisoMapper : PostgreSqlLegacyMapper<TipoPermiso> { public static TipoPermisoMapper Instance() => new TipoPermisoMapper(); }
public sealed class TipoResolucionMapper : PostgreSqlLegacyMapper<TipoResolucion> { public static TipoResolucionMapper Instance() => new TipoResolucionMapper(); }
public sealed class TipoSangreMapper : PostgreSqlLegacyMapper<TipoSangre> { public static TipoSangreMapper Instance() => new TipoSangreMapper(); }
public sealed class TipoTrabajadorMapper : PostgreSqlLegacyMapper<TipoTrabajador> { public static TipoTrabajadorMapper Instance() => new TipoTrabajadorMapper(); }
public sealed class TipoVivMapper : PostgreSqlLegacyMapper<TipoViv> { public static TipoVivMapper Instance() => new TipoVivMapper(); }
public sealed class TitulosEmpleadoMapper : PostgreSqlLegacyMapper<TitulosEmpleado> { public static TitulosEmpleadoMapper Instance() => new TitulosEmpleadoMapper(); }
public sealed class UbicacionVivMapper : PostgreSqlLegacyMapper<UbicacionViv> { public static UbicacionVivMapper Instance() => new UbicacionVivMapper(); }
public sealed class ViveConMapper : PostgreSqlLegacyMapper<ViveCon> { public static ViveConMapper Instance() => new ViveConMapper(); }
public sealed class ViviendaMapper : PostgreSqlLegacyMapper<Vivienda> { public static ViviendaMapper Instance() => new ViviendaMapper(); }
