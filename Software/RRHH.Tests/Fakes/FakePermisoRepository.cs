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
	}

	public List<PermisoFalso> Registros { get; } = new List<PermisoFalso>();

	public int Consultas { get; private set; }

	public FakePermisoRepository Agregar(int idEmpleado, int nPermiso, DateTime desde, DateTime hasta)
	{
		Registros.Add(new PermisoFalso { IdEmpleado = idEmpleado, NPermiso = nPermiso, Desde = desde, Hasta = hasta });
		return this;
	}

	public bool ExisteSolapamiento(int idEmpleado, RangoFechas rango, int excluirNPermiso)
	{
		Consultas++;
		return Registros.Any(p => p.IdEmpleado == idEmpleado
			&& p.NPermiso != excluirNPermiso
			&& RangoFechas.Crear(p.Desde, p.Hasta).Solapa(rango));
	}
}
