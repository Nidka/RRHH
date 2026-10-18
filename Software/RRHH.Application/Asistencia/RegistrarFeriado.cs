using System;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Valida y registra un día feriado nuevo garantizando unicidad por día calendario.
/// </summary>
public sealed class RegistrarFeriado
{
	public const string MensajeFechaDuplicada = "Ya a Agregado esa Fecha";

	private readonly IFeriadoRepository _repository;

	public RegistrarFeriado(IFeriadoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	public ResultadoOperacion Ejecutar(RegistrarFeriadoDto dto)
	{
		if (dto == null)
		{
			throw new ArgumentNullException(nameof(dto));
		}

		Feriado feriado;
		try
		{
			feriado = Feriado.Crear(0, dto.Fecha, dto.Motivo);
		}
		catch (ReglaNegocioException ex)
		{
			return ResultadoOperacion.Error(ex.Message);
		}

		if (!_repository.InsertarSiNoExisteFecha(feriado, out int idAsignado))
		{
			return ResultadoOperacion.Error(MensajeFechaDuplicada);
		}

		dto.Id = idAsignado;
		dto.Fecha = feriado.Fecha;
		dto.Motivo = feriado.Motivo;
		return ResultadoOperacion.Ok();
	}
}
