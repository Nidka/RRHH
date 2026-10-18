using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Asistencia;

/// <summary>
/// Día feriado no laborable registrado en <c>public."RRHH_Feriado"</c>.
/// </summary>
public sealed class Feriado
{
	public const int LongitudMaximaMotivo = 200;

	private Feriado(int id, DateTime fecha, string motivo)
	{
		Id = id;
		Fecha = fecha;
		Motivo = motivo;
	}

	/// <summary>0 mientras el registro no se haya guardado.</summary>
	public int Id { get; }

	/// <summary>Fecha del feriado normalizada al día calendario en altas nuevas.</summary>
	public DateTime Fecha { get; }

	public string Motivo { get; }

	public bool EsNuevo => Id == 0;

	public static string Validar(DateTime fecha, string motivo)
	{
		if (fecha == default)
		{
			return "Debe seleccionar una fecha válida.";
		}

		if (string.IsNullOrWhiteSpace(motivo))
		{
			return "Debe ingresar motivo.";
		}

		string limpio = motivo.Trim();
		if (limpio.Length > LongitudMaximaMotivo)
		{
			return $"Motivo: no puede superar {LongitudMaximaMotivo} caracteres.";
		}

		return null;
	}

	/// <summary>
	/// Crea un feriado válido con fecha truncada al día calendario (<see cref="DateTime.Date"/>)
	/// y motivo sin espacios sobrantes, o lanza <see cref="ReglaNegocioException"/>.
	/// </summary>
	public static Feriado Crear(int id, DateTime fecha, string motivo)
	{
		string error = Validar(fecha, motivo);
		if (error != null)
		{
			throw new ReglaNegocioException(error);
		}

		return new Feriado(id, fecha.Date, motivo.Trim());
	}

	/// <summary>
	/// Reconstruye un feriado ya persistido sin volver a validarlo.
	/// Solo para repositorios: existen registros históricos con motivo vacío o con hora en la fecha.
	/// </summary>
	public static Feriado Reconstituir(int id, DateTime fecha, string motivo)
	{
		return new Feriado(id, fecha, motivo ?? string.Empty);
	}
}
