using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

/// <summary>Solicita el borrado dentro de la modalidad autorizada y traduce rechazos de negocio al usuario.</summary>
public sealed class EliminarMotivoPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;

    public EliminarMotivoPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

    /// <summary>Elimina el motivo seleccionado si el repositorio confirma acceso e inexistencia de referencias.</summary>
    /// <returns>Éxito o rechazo por selección, acceso, registro inexistente o historial asociado.</returns>
    /// <remarks>Los fallos de infraestructura se propagan al presenter; no se implementa baja lógica.</remarks>
    public ResultadoOperacion Ejecutar(int id)
    {
        try
        {
            _acceso.ExigirAcceso();
            if (id <= 0) return ResultadoOperacion.Error("Seleccione un motivo válido.");
            return _repository.Eliminar(id, _acceso.Modalidad) ? ResultadoOperacion.Ok() :
                ResultadoOperacion.Error("El motivo ya no existe o no pertenece a su modalidad.");
        }
        catch (RegistroEnUsoException)
        {
            return ResultadoOperacion.Error("No se puede eliminar: el motivo tiene permisos o historial asociado.");
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Error(ex.Message);
        }
    }
}
