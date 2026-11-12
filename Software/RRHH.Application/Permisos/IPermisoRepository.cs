using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Contrato de consulta sobre los permisos registrados en <c>public."Permiso"</c>.
/// Por ahora solo expone lo que necesita la regla de solapamiento (RF-03).
/// </summary>
public interface IPermisoRepository
{
	/// <summary>
	/// Indica si el empleado ya tiene un permiso que comparta al menos un día con
	/// <paramref name="rango"/>. Reemplaza a <c>RRHHClass.ExistePermiso</c>.
	/// </summary>
	/// <param name="idEmpleado">Empleado cuyos permisos se revisan; los de otros empleados no cuentan.</param>
	/// <param name="rango">Días que se quieren ocupar, ambos extremos incluidos.</param>
	/// <param name="excluirNPermiso">
	/// Número del permiso que se está editando para no compararlo consigo mismo; 0 cuando es un alta.
	/// </param>
	bool ExisteSolapamiento(int idEmpleado, RangoFechas rango, int excluirNPermiso);
}
