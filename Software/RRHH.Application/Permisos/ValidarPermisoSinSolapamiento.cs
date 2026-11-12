using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Regla RF-03: una persona no puede tener dos permisos que ocupen el mismo día.
/// Se usa al registrar y al editar un permiso, antes de escribirlo.
/// </summary>
/// <remarks>
/// HIPÓTESIS (ver <c>specs/CR-003-permisos-solapados.md</c>): se compara por día calendario completo
/// (los permisos por horas también ocupan el día) y todo permiso registrado cuenta, porque
/// <c>public."Permiso"</c> no tiene columna de anulación. Esta clase solo valida: no escribe, de modo
/// que no puede por sí sola evitar que dos solicitudes simultáneas pasen la comprobación a la vez.
/// </remarks>
public sealed class ValidarPermisoSinSolapamiento
{
	public const string MensajeSolapamiento =
		"El empleado ya tiene un permiso en esas fechas. No se puede registrar otro permiso el mismo día.";

	private readonly IPermisoRepository _repository;

	public ValidarPermisoSinSolapamiento(IPermisoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <summary>
	/// Reemplaza el guard <c>RRHHClass.ExistePermiso(...) &gt;= 1</c> de <c>FrmPermiso</c>.
	/// </summary>
	/// <param name="idEmpleado">Empleado al que pertenece el permiso.</param>
	/// <param name="desde">Primer día del permiso; se ignora la hora.</param>
	/// <param name="hasta">Último día del permiso; se ignora la hora.</param>
	/// <param name="excluirNPermiso">Número del permiso en edición, o 0 para un alta.</param>
	/// <returns>
	/// Error con mensaje para el usuario si el rango es inválido o se solapa con otro permiso del empleado;
	/// éxito en caso contrario.
	/// </returns>
	public ResultadoOperacion Ejecutar(int idEmpleado, DateTime desde, DateTime hasta, int excluirNPermiso = 0)
	{
		RangoFechas rango;
		try
		{
			rango = RangoFechas.Crear(desde, hasta);
		}
		catch (ReglaNegocioException ex)
		{
			return ResultadoOperacion.Error(ex.Message);
		}

		return _repository.ExisteSolapamiento(idEmpleado, rango, excluirNPermiso)
			? ResultadoOperacion.Error(MensajeSolapamiento)
			: ResultadoOperacion.Ok();
	}
}
