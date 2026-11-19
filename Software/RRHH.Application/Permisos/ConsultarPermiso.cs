using System;
using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>Consulta un permiso identificado por empleado y número para editar sus datos.</summary>
public interface IPermisoConsultaRepository
{
    /// <summary>Devuelve datos editables o null si no existe; rechaza identificadores duplicados.</summary>
    PermisoGuardarDto Obtener(int empleado, int numero);
}

/// <summary>Carga un permiso existente sin exponer detalles del proveedor de datos.</summary>
/// <remarks>La autorización del operador corresponde al host de presentación.</remarks>
public sealed class ConsultarPermiso
{
    private readonly IPermisoConsultaRepository _repository;
    public ConsultarPermiso(IPermisoConsultaRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    /// <summary>Obtiene un permiso o comunica que debe corregirse el identificador.</summary>
    /// <exception cref="ReglaNegocioException">ID inválido, registro inexistente o ambiguo.</exception>
    public PermisoGuardarDto Ejecutar(int empleado, int numero)
    {
        if (empleado <= 0 || numero <= 0) throw new ReglaNegocioException("Indique empleado y número de permiso válidos.");
        return _repository.Obtener(empleado, numero) ?? throw new ReglaNegocioException("No se encontró el permiso.");
    }
}
