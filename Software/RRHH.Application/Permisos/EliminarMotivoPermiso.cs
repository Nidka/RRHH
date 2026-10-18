using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

public sealed class EliminarMotivoPermiso
{
    private readonly IMotivoPermisoRepository _repository;
    private readonly AccesoMotivosPermiso _acceso;

    public EliminarMotivoPermiso(IMotivoPermisoRepository repository, AccesoMotivosPermiso acceso)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _acceso = acceso ?? throw new ArgumentNullException(nameof(acceso));
    }

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
