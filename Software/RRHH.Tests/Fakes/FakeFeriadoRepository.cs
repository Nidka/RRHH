using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;

namespace RRHH.Tests.Fakes;

internal sealed class FakeFeriadoRepository : IFeriadoRepository
{
	private readonly object _sync = new object();

	public List<Feriado> Registros { get; } = new List<Feriado>();

	public bool FallarAlConsultar { get; set; }

	public bool FallarAlGuardar { get; set; }

	public bool FallarAlEliminar { get; set; }

	public IReadOnlyList<Feriado> Listar()
	{
		if (FallarAlConsultar)
		{
			throw new InvalidOperationException("Conexión perdida");
		}

		lock (_sync)
		{
			return Registros.OrderBy(r => r.Id).ToList();
		}
	}

	public bool ExisteFecha(DateTime fecha)
	{
		lock (_sync)
		{
			DateTime dia = fecha.Date;
			return Registros.Any(r => r.Fecha.Date == dia);
		}
	}

	public bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado)
	{
		if (FallarAlGuardar)
		{
			throw new InvalidOperationException("Conexión perdida");
		}

		lock (_sync)
		{
			DateTime dia = feriado.Fecha.Date;
			if (Registros.Any(r => r.Fecha.Date == dia))
			{
				idAsignado = 0;
				return false;
			}

			idAsignado = Registros.Count == 0 ? 1 : Registros.Max(r => r.Id) + 1;
			Registros.Add(Feriado.Reconstituir(idAsignado, feriado.Fecha, feriado.Motivo));
			return true;
		}
	}

	public bool Eliminar(int id)
	{
		if (FallarAlEliminar)
		{
			throw new InvalidOperationException("Conexión perdida");
		}

		lock (_sync)
		{
			return Registros.RemoveAll(r => r.Id == id) > 0;
		}
	}
}

