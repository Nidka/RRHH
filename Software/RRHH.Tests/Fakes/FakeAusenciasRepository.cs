using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.Tests.Fakes;

/// <summary>Repositorio en memoria de ausencias (RF-18) que cumple el contrato de <see cref="IAusenciasRepository"/>.</summary>
internal sealed class FakeAusenciasRepository : IAusenciasRepository
{
	public List<AusenciaRegistrada> Registros { get; } = new List<AusenciaRegistrada>();

	public List<MotivoAusenciaDto> Motivos { get; } = new List<MotivoAusenciaDto>();

	/// <summary>Si es <c>true</c> devuelve todo sin filtrar, para comprobar que el caso de uso no confía en el repositorio.</summary>
	public bool DevolverSinFiltrar { get; set; }

	public bool Fallar { get; set; }

	public int Consultas { get; private set; }

	public int? UltimoMotivo { get; private set; }

	public FakeAusenciasRepository Agregar(int idEmpleado, string empleado, int idMotivo, string motivo, DateTime inicio, DateTime fin)
	{
		Registros.Add(new AusenciaRegistrada
		{
			IdEmpleado = idEmpleado, Empleado = empleado, IdMotivo = idMotivo, Motivo = motivo, Inicio = inicio, Fin = fin
		});
		return this;
	}

	public IReadOnlyList<AusenciaRegistrada> ListarSolapadas(RangoFechas rango, int? idMotivo)
	{
		Consultas++;
		UltimoMotivo = idMotivo;
		if (Fallar)
		{
			throw new InvalidOperationException("Conexión interrumpida");
		}

		if (DevolverSinFiltrar)
		{
			return Registros.ToList();
		}

		return Registros
			.Where(a => a.Fin.Date >= a.Inicio.Date
				&& RangoFechas.Crear(a.Inicio, a.Fin).Solapa(rango)
				&& (!idMotivo.HasValue || a.IdMotivo == idMotivo.Value))
			.ToList();
	}

	public IReadOnlyList<MotivoAusenciaDto> ListarMotivos()
	{
		if (Fallar)
		{
			throw new InvalidOperationException("Conexión interrumpida");
		}

		return Motivos.ToList();
	}
}
