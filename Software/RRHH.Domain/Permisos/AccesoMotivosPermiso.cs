using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Permisos;

/// <summary>Política caracterizada en FrmMotivoPermiso: 10=P, 14=C, 13=todas.</summary>
public sealed class AccesoMotivosPermiso
{
    public bool Permitido { get; }
    public string Modalidad { get; }

    public AccesoMotivosPermiso(int rol)
    {
        Permitido = rol == 10 || rol == 14 || rol == 13;
        Modalidad = rol == 10 ? "P" : rol == 14 ? "C" : null;
    }

    /// <summary>Comprueba que el rol puede usar el mantenimiento.</summary>
    /// <exception cref="ReglaNegocioException">El rol no es 10, 14 ni 13.</exception>
    public void ExigirAcceso()
    {
        if (!Permitido)
            throw new ReglaNegocioException("Su rol no tiene acceso al mantenimiento de motivos.");
    }

    /// <summary>Comprueba acceso, existencia del motivo y pertenencia a la modalidad autorizada.</summary>
    /// <exception cref="ReglaNegocioException">Rol sin acceso, motivo null o modalidad ajena.</exception>
    public void ExigirAcceso(MotivoPermiso motivo)
    {
        ExigirAcceso();
        if (motivo == null)
            throw new ReglaNegocioException("El motivo ya no existe. Actualice el listado.");
        if (Modalidad != null && !string.Equals(Modalidad, motivo.Modalidad, StringComparison.Ordinal))
            throw new ReglaNegocioException("El motivo no pertenece a su modalidad.");
    }
}
