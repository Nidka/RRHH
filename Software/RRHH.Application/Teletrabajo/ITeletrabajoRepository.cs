using System.Collections.Generic;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>Contrato de lectura y alta de periodos activos de teletrabajo.</summary>
public interface ITeletrabajoRepository
{
    /// <summary>Comprueba empleado y solapamiento e inserta atómicamente. Devuelve el ID generado.</summary>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">Empleado ausente o ambiguo, o periodo solapado.</exception>
    int Registrar(PeriodoTeletrabajo periodo);

    /// <summary>Lista periodos activos por código de empleado.</summary>
    IReadOnlyList<PeriodoTeletrabajoDto> Listar(int empleado);
}
