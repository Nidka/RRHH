using System;
using RRHH.Application.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// Regla RF-06: ciertas licencias (por ejemplo la identificada como 30012) solo se otorgan una vez por año
/// a cada persona. Qué motivos están sujetos a la regla se configura en el catálogo de motivos
/// (<c>Motivo_Perm."UnaVezPorAnio"</c>); este código no conoce ningún número de licencia.
/// </summary>
/// <remarks>
/// HIPÓTESIS (ver <c>specs/CR-006-licencia-anual.md</c>): el año se toma de la fecha de inicio del permiso,
/// la regla se aplica como bloqueo (no como advertencia), un permiso en edición no cuenta contra sí mismo y
/// un permiso que cruza de año solo ocupa el año en que empieza. Esta clase solo valida: no escribe, por lo que
/// no evita que dos solicitudes simultáneas pasen la comprobación a la vez.
/// </remarks>
public sealed class ValidarLicenciaUnaVezPorAnio
{
	private readonly IPermisoRepository _repository;

	public ValidarLicenciaUnaVezPorAnio(IPermisoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <summary>Mensaje para el usuario cuando la licencia ya fue otorgada en el año.</summary>
	public static string MensajeLicenciaYaOtorgada(int anio)
	{
		return $"El empleado ya tiene una licencia de este tipo en {anio}. Esta licencia solo se otorga una vez por año.";
	}

	/// <param name="idEmpleado">Empleado al que pertenece el permiso.</param>
	/// <param name="idMotivo">Motivo elegido; 0 o negativo si todavía no se eligió uno (no se restringe).</param>
	/// <param name="fechaInicio">Primer día del permiso; su año es el que se revisa.</param>
	/// <param name="excluirNPermiso">Número del permiso en edición, o 0 para un alta.</param>
	/// <returns>
	/// Error con mensaje para el usuario si el motivo es de una vez por año y el empleado ya tiene otro permiso de
	/// ese motivo que empieza en el mismo año; éxito en caso contrario.
	/// </returns>
	public ResultadoOperacion Ejecutar(int idEmpleado, int idMotivo, DateTime fechaInicio, int excluirNPermiso = 0)
	{
		if (idMotivo <= 0 || !_repository.MotivoSeOtorgaUnaVezPorAnio(idMotivo))
		{
			return ResultadoOperacion.Ok();
		}

		int anio = fechaInicio.Year;
		return _repository.ExistePermisoDelMotivoEnAnio(idEmpleado, idMotivo, anio, excluirNPermiso)
			? ResultadoOperacion.Error(MensajeLicenciaYaOtorgada(anio))
			: ResultadoOperacion.Ok();
	}
}
