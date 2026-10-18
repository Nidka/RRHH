using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

/// <summary>Coordina alta o edición de motivos según el alcance del rol y las reglas del dominio.</summary>
public sealed class GuardarMotivoPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;

    public GuardarMotivoPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

    /// <summary>Guarda únicamente campos editables; en altas toma la modalidad de la política de acceso.</summary>
    /// <param name="dto">ID cero para alta; ID existente para edición. En éxito recibe ID y textos normalizados.</param>
    /// <returns>Éxito o error de validación/acceso/conflicto; los errores de infraestructura se propagan.</returns>
    /// <exception cref="ArgumentNullException">El DTO es null.</exception>
    public ResultadoOperacion Ejecutar(MotivoPermisoDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        try
        {
            _acceso.ExigirAcceso();
            if (dto.Id < 0) return ResultadoOperacion.Error("El código del motivo no es válido.");
            MotivoPermiso motivo;
            if (dto.Id == 0)
            {
                motivo = MotivoPermiso.Nuevo(dto.TipoPermisoId ?? 0, dto.Descripcion,
                    dto.Abreviatura, dto.Salario, _acceso.Modalidad);
                dto.Id = _repository.Insertar(motivo);
            }
            else
            {
                MotivoPermiso anterior = _repository.Obtener(dto.Id);
                _acceso.ExigirAcceso(anterior);
                if (anterior.TipoPermisoId != dto.TipoPermisoId)
                    return ResultadoOperacion.Error("El tipo del motivo cambió. Actualice el listado.");
                motivo = anterior.Editar(dto.Descripcion, dto.Abreviatura, dto.Salario);
                if (!_repository.Actualizar(motivo))
                    return ResultadoOperacion.Error("El motivo cambió o fue eliminado. Actualice el listado.");
            }
            dto.Descripcion = motivo.Descripcion;
            dto.Abreviatura = motivo.Abreviatura;
            return ResultadoOperacion.Ok();
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Error(ex.Message);
        }
    }
}
