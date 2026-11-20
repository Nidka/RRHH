using System;

namespace RRHH.Application.Asistencia;

/// <summary>Resuelve el vínculo único y activo de una identidad autenticada.</summary>
public interface IUsuarioEmpleadoRepository
{
    /// <summary>Devuelve empleado positivo o lanza regla de negocio si la identidad/vínculo es ambiguo o está deshabilitado.</summary>
    int ObtenerEmpleado(int idUsuario);
}
/// <summary>RF-12: consulta propia; no acepta identificadores de empleado enviados por el cliente.</summary>
public sealed class ConsultarMisVacaciones
{
    private readonly IUsuarioEmpleadoRepository _vinculos;
    private readonly ConsultarSaldoVacaciones _saldos;
    public ConsultarMisVacaciones(IUsuarioEmpleadoRepository vinculos,ConsultarSaldoVacaciones saldos)
    {
        _vinculos=vinculos ?? throw new ArgumentNullException(nameof(vinculos));
        _saldos=saldos ?? throw new ArgumentNullException(nameof(saldos));
    }
    /// <summary>Resuelve de nuevo el vínculo de la identidad autenticada antes de leer su saldo.</summary>
    public SaldoVacacionesDto Ejecutar(int idUsuario,DateTime corte)=>_saldos.Ejecutar(_vinculos.ObtenerEmpleado(idUsuario),corte);
}
