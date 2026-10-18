using System;
using System.Collections.Generic;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

/// <summary>Consulta motivos aplicando la modalidad del rol sin ocultar registros inactivos.</summary>
public sealed class ListarMotivosPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;
    public bool Permitido => _acceso.Permitido;

    public ListarMotivosPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

    /// <summary>Exige acceso y consulta el tipo seleccionado.</summary>
    /// <returns>Lista vacía y sin consultar persistencia cuando no se seleccionó un tipo válido.</returns>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">El rol no tiene acceso al mantenimiento.</exception>
    public IReadOnlyList<MotivoPermisoDto> Ejecutar(int tipoPermisoId)
    {
        _acceso.ExigirAcceso();
        return tipoPermisoId <= 0 ? Array.Empty<MotivoPermisoDto>() :
            _repository.Listar(tipoPermisoId, _acceso.Modalidad);
    }
}
