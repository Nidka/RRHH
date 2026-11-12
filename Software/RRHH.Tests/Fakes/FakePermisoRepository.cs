using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.Tests.Fakes;

internal sealed class FakePermisoRepository : IPermisoRepository
{
	public sealed class PermisoFalso
	{
		public int IdEmpleado { get; set; }

		public int NPermiso { get; set; }

		public DateTime Desde { get; set; }

		public DateTime Hasta { get; set; }

		public int IdMotivo { get; set; }
	}

	public List<PermisoFalso> Registros { get; } = new List<PermisoFalso>();

	/// <summary>Motivos marcados como de una vez por año en el catálogo falso.</summary>
	public HashSet<int> MotivosUnaVezPorAnio { get; } = new HashSet<int>();

	public int Consultas { get; private set; }

	public FakePermisoRepository Agregar(int idEmpleado, int nPermiso, DateTime desde, DateTime hasta, int idMotivo = 0)
	{
		Registros.Add(new PermisoFalso { IdEmpleado = idEmpleado, NPermiso = nPermiso, Desde = desde, Hasta = hasta, IdMotivo = idMotivo });
		return this;
	}

	public bool ExisteSolapamiento(int idEmpleado, RangoFechas rango, int excluirNPermiso)
	{
		Consultas++;
		return Registros.Any(p => p.IdEmpleado == idEmpleado
			&& p.NPermiso != excluirNPermiso
			&& RangoFechas.Crear(p.Desde, p.Hasta).Solapa(rango));
	}

	public bool MotivoSeOtorgaUnaVezPorAnio(int idMotivo)
	{
		Consultas++;
		return MotivosUnaVezPorAnio.Contains(idMotivo);
	}

	public bool ExistePermisoDelMotivoEnAnio(int idEmpleado, int idMotivo, int anio, int excluirNPermiso)
	{
		Consultas++;
		return Registros.Any(p => p.IdEmpleado == idEmpleado
			&& p.IdMotivo == idMotivo
			&& p.NPermiso != excluirNPermiso
			&& p.Desde.Year == anio);
	}
}
