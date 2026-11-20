using System;
using RRHH.Application.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Consulta orientativa de no solapamiento (RF-03) y licencia anual (RF-06).
/// No escribe ni sustituye a GuardarPermiso, que comprueba las reglas dentro de la transacción de guardado.
/// </summary>
public sealed class ValidarPermiso
{
	private readonly ValidarPermisoSinSolapamiento _sinSolapamiento;
	private readonly ValidarLicenciaUnaVezPorAnio _unaVezPorAnio;

	public ValidarPermiso(ValidarPermisoSinSolapamiento sinSolapamiento, ValidarLicenciaUnaVezPorAnio unaVezPorAnio)
	{
		_sinSolapamiento = sinSolapamiento ?? throw new ArgumentNullException(nameof(sinSolapamiento));
		_unaVezPorAnio = unaVezPorAnio ?? throw new ArgumentNullException(nameof(unaVezPorAnio));
	}

	/// <summary>
	/// Aplica las reglas en orden y devuelve el primer error: rango y solapamiento (RF-03), luego licencia anual (RF-06).
	/// </summary>
	/// <param name="idEmpleado">Empleado al que pertenece el permiso.</param>
	/// <param name="idMotivo">Motivo elegido; 0 si no hay uno seleccionado.</param>
	/// <param name="desde">Primer día del permiso; se ignora la hora.</param>
	/// <param name="hasta">Último día del permiso; se ignora la hora.</param>
	/// <param name="excluirNPermiso">Número del permiso en edición, o 0 para un alta.</param>
	public ResultadoOperacion Ejecutar(int idEmpleado, int idMotivo, DateTime desde, DateTime hasta, int excluirNPermiso = 0)
	{
		ResultadoOperacion solapamiento = _sinSolapamiento.Ejecutar(idEmpleado, desde, hasta, excluirNPermiso);
		if (!solapamiento.Exitoso)
		{
			return solapamiento;
		}

		return _unaVezPorAnio.Ejecutar(idEmpleado, idMotivo, desde, excluirNPermiso);
	}
}
