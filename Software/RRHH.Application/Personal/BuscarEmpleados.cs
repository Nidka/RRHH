using System;
using System.Collections.Generic;

namespace RRHH.Application.Personal;

/// <summary>Empleado encontrado por la búsqueda, con lo mínimo para reconocerlo y elegirlo.</summary>
public sealed class EmpleadoResumenDto
{
    /// <param name="idEmpleado">Identificador interno que usan los casos de uso.</param>
    /// <param name="nombreCompleto">«Apellidos, Nombres».</param>
    /// <param name="documento">Documento de identidad, sin espacios sobrantes; puede ser nulo.</param>
    /// <param name="activo">Falso si el empleado está cesado o inactivo.</param>
    public EmpleadoResumenDto(int idEmpleado, string nombreCompleto, string documento, bool activo)
    {
        IdEmpleado = idEmpleado;
        NombreCompleto = nombreCompleto;
        Documento = documento;
        Activo = activo;
    }

    public int IdEmpleado { get; }
    public string NombreCompleto { get; }
    public string Documento { get; }
    public bool Activo { get; }
}

/// <summary>Consulta de solo lectura de empleados por texto libre.</summary>
public interface IEmpleadoBusquedaRepository
{
    /// <summary>
    /// Busca por parte de los apellidos o nombres, o por el inicio del documento, y devuelve una fila
    /// por empleado tomada de su periodo (<c>Year</c>) más reciente: primero activos y luego cesados.
    /// </summary>
    /// <param name="texto">Texto ya validado; los comodines de LIKE se tratan como texto literal.</param>
    /// <param name="limite">Cantidad máxima de filas.</param>
    IReadOnlyList<EmpleadoResumenDto> Buscar(string texto, int limite);
}

/// <summary>
/// CR-019: permite elegir al empleado por nombre o documento en lugar de su número interno.
/// Incluye cesados (marcados como tales) porque RF-09 calcula vacaciones truncas al cese.
/// </summary>
public sealed class BuscarEmpleados
{
    /// <summary>Por debajo de este largo no se consulta la base, para no listar media planilla.</summary>
    public const int MinimoCaracteres = 2;
    /// <summary>Largo máximo del texto que se envía a la base.</summary>
    public const int MaximoCaracteres = 60;
    /// <summary>Cantidad máxima de resultados devueltos.</summary>
    public const int MaximoResultados = 20;

    private readonly IEmpleadoBusquedaRepository _repositorio;

    public BuscarEmpleados(IEmpleadoBusquedaRepository repositorio) =>
        _repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));

    /// <summary>Devuelve hasta <see cref="MaximoResultados"/> coincidencias; lista vacía si el texto es demasiado corto.</summary>
    public IReadOnlyList<EmpleadoResumenDto> Ejecutar(string texto)
    {
        string limpio = (texto ?? string.Empty).Trim();
        if (limpio.Length < MinimoCaracteres) return Array.Empty<EmpleadoResumenDto>();
        if (limpio.Length > MaximoCaracteres) limpio = limpio.Substring(0, MaximoCaracteres);
        return _repositorio.Buscar(limpio, MaximoResultados);
    }
}
