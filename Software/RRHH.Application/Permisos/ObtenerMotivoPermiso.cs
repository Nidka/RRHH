using System;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

/// <summary>Carga un motivo existente para el editor, comprobando el alcance del rol.</summary>
public sealed class ObtenerMotivoPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;

    public ObtenerMotivoPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

    /// <summary>Recupera los datos del motivo sin ejecutar escrituras.</summary>
    /// <returns>DTO del motivo autorizado, con los valores heredados y su nulabilidad.</returns>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">Acceso denegado, motivo inexistente o ID ambiguo.</exception>
    public MotivoPermisoDto Ejecutar(int id)
    {
        _acceso.ExigirAcceso();
        MotivoPermiso motivo = _repository.Obtener(id);
        _acceso.ExigirAcceso(motivo);
        return MotivoPermisoDto.Desde(motivo);
    }
}
