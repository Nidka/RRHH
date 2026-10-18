using System;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

public sealed class ObtenerMotivoPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;

    public ObtenerMotivoPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

    public MotivoPermisoDto Ejecutar(int id)
    {
        _acceso.ExigirAcceso();
        MotivoPermiso motivo = _repository.Obtener(id);
        _acceso.ExigirAcceso(motivo);
        return MotivoPermisoDto.Desde(motivo);
    }
}
