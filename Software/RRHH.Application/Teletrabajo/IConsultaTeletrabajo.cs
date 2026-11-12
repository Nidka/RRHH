using System.Collections.Generic;
using RRHH.Domain.Comun;

namespace RRHH.Application.Teletrabajo;

/// <summary>Lectura de periodos activos para informes de teletrabajo.</summary>
public interface IConsultaTeletrabajo
{
    /// <summary>Obtiene los periodos que cruzan el rango. Un empleado nulo incluye a todos.</summary>
    IReadOnlyList<PeriodoTeletrabajoDto> Consultar(int? empleado, RangoFechas rango);
}
