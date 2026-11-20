using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Contrato de consulta sobre los permisos registrados en <c>public."Permiso"</c>.
/// Expone las consultas de solapamiento (RF-03) y restricción anual por motivo o grupo (RF-06).
/// </summary>
public interface IPermisoRepository
{
	/// <summary>
	/// Indica si el empleado ya tiene un permiso que comparta al menos un día con
	/// <paramref name="rango"/>. Rechazados y anulados no bloquean; en esquemas históricos
    /// sin estado explícito todos cuentan. Reemplaza a <c>RRHHClass.ExistePermiso</c>.
	/// </summary>
	/// <param name="idEmpleado">Empleado cuyos permisos se revisan; los de otros empleados no cuentan.</param>
	/// <param name="rango">Días que se quieren ocupar, ambos extremos incluidos.</param>
	/// <param name="excluirNPermiso">
	/// Número del permiso que se está editando para no compararlo consigo mismo; 0 cuando es un alta.
	/// </param>
	bool ExisteSolapamiento(int idEmpleado, RangoFechas rango, int excluirNPermiso);

	/// <summary>
	/// Indica si el motivo está marcado en el catálogo (<c>public."Motivo_Perm"."UnaVezPorAnio"</c>) como
	/// licencia que solo se otorga una vez por año a cada persona (RF-06). Un motivo inexistente o sin la marca
	/// devuelve <c>false</c>.
	/// </summary>
	bool MotivoSeOtorgaUnaVezPorAnio(int idMotivo);

	/// <summary>
	/// Indica si el empleado tiene un permiso del mismo motivo o grupo de restricción anual que empieza en <paramref name="anio"/>.
    /// Se excluyen los estados explícitos Rechazado y Anulado; un estado desconocido ocupa el cupo.
	/// </summary>
	/// <param name="idEmpleado">Empleado cuyos permisos se revisan; los de otros empleados no cuentan.</param>
	/// <param name="idMotivo">Motivo (<c>public."Permiso"."idMotivo"</c>) que se busca.</param>
	/// <param name="anio">Año calendario de la fecha de inicio del permiso.</param>
	/// <param name="excluirNPermiso">Número del permiso en edición, o 0 para un alta.</param>
	bool ExistePermisoDelMotivoEnAnio(int idEmpleado, int idMotivo, int anio, int excluirNPermiso);
}
