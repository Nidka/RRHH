using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHH.Application.Navegacion;

/// <summary>
/// Permiso que habilita una pantalla. Cada interfaz lo traduce a su propio mecanismo:
/// políticas de autorización en la web y variables de rol o menús heredados en escritorio.
/// </summary>
public enum PermisoModulo
{
    /// <summary>Operador de teletrabajo (RF-13, RF-14, RF-16).</summary>
    Teletrabajo,
    /// <summary>Empleado que consulta solo sus propios datos (RF-12).</summary>
    Autoconsulta,
    /// <summary>Reporte de ausencias por periodo (RF-18).</summary>
    Ausencias,
    /// <summary>Asignación e histórico de turnos (RF-01, RF-02).</summary>
    Horarios,
    /// <summary>Catálogo de motivos de permiso (RF-04, RF-05).</summary>
    Motivos,
    /// <summary>Asistencia, feriados y consolidado presencial (RF-15, RF-17).</summary>
    Asistencia,
    /// <summary>Vacaciones generadas, saldo, truncas y reporte (RF-07 a RF-09, RF-11).</summary>
    Vacaciones,
    /// <summary>Registro de permisos y licencias (RF-03, RF-06, RF-10).</summary>
    Permisos,
    /// <summary>Registro y edición de empleados (CR-020).</summary>
    Personal
}

/// <summary>Pantalla funcional del sistema y los requerimientos que atiende.</summary>
public sealed class PantallaModulo
{
    /// <param name="clave">Identificador estable en minúsculas y guiones; la web lo usa como nombre de archivo.</param>
    /// <param name="titulo">Texto visible en menús y encabezados.</param>
    /// <param name="permiso">Permiso que debe tener el usuario para verla.</param>
    /// <param name="requerimientos">Requerimientos del área usuaria que se atienden en esta pantalla.</param>
    public PantallaModulo(string clave, string titulo, PermisoModulo permiso, params string[] requerimientos)
    {
        Clave = clave;
        Titulo = titulo;
        Permiso = permiso;
        Requerimientos = requerimientos;
    }

    public string Clave { get; }
    public string Titulo { get; }
    public PermisoModulo Permiso { get; }
    public IReadOnlyList<string> Requerimientos { get; }
}

/// <summary>Agrupación de pantallas según la clasificación de requerimientos del área usuaria.</summary>
public sealed class ModuloSistema
{
    public ModuloSistema(string clave, string titulo, IReadOnlyList<PantallaModulo> pantallas)
    {
        Clave = clave;
        Titulo = titulo;
        Pantallas = pantallas;
    }

    public string Clave { get; }
    public string Titulo { get; }
    public IReadOnlyList<PantallaModulo> Pantallas { get; }
}

/// <summary>
/// Fuente única de la navegación del sistema (CR-019). Escritorio y web arman sus menús desde aquí,
/// así que agregar una pantalla consiste en sumar una entrada, sin modificar los menús.
/// </summary>
/// <remarks>
/// El orden de los módulos sigue la clasificación A-E del enunciado, más la autoconsulta del empleado.
/// La lista solo describe la navegación: la autorización real la siguen aplicando los endpoints y los
/// <c>CompositionRoot</c>, de modo que ocultar una pantalla nunca es la única protección.
/// </remarks>
public static class CatalogoModulos
{
    /// <summary>Todos los módulos con todas sus pantallas, en el orden en que se muestran.</summary>
    public static IReadOnlyList<ModuloSistema> Todos { get; } = new[]
    {
        new ModuloSistema("turnos", "Gestión de turnos", new[]
        {
            new PantallaModulo("asignar-turno", "Asignar turno por periodo", PermisoModulo.Horarios, "RF-01"),
            new PantallaModulo("historico-turnos", "Histórico de turnos", PermisoModulo.Horarios, "RF-02")
        }),
        new ModuloSistema("permisos", "Permisos y licencias", new[]
        {
            new PantallaModulo("registro-permisos", "Registro de permisos y licencias", PermisoModulo.Permisos, "RF-03", "RF-06", "RF-10"),
            new PantallaModulo("motivos-permiso", "Motivos de permiso", PermisoModulo.Motivos, "RF-04", "RF-05")
        }),
        new ModuloSistema("vacaciones", "Vacaciones", new[]
        {
            new PantallaModulo("vacaciones-generadas", "Vacaciones generadas", PermisoModulo.Vacaciones, "RF-07"),
            new PantallaModulo("saldo-vacaciones", "Vacaciones pendientes de goce", PermisoModulo.Vacaciones, "RF-08"),
            new PantallaModulo("vacaciones-truncas", "Vacaciones truncas", PermisoModulo.Vacaciones, "RF-09"),
            new PantallaModulo("reporte-vacaciones", "Reporte de vacaciones", PermisoModulo.Vacaciones, "RF-11")
        }),
        new ModuloSistema("teletrabajo", "Teletrabajo y presencialidad", new[]
        {
            new PantallaModulo("periodos-teletrabajo", "Periodos de teletrabajo", PermisoModulo.Teletrabajo, "RF-13"),
            new PantallaModulo("dias-teletrabajo", "Días de teletrabajo", PermisoModulo.Teletrabajo, "RF-14"),
            new PantallaModulo("presencialidad", "Presencialidad y teletrabajo por persona", PermisoModulo.Asistencia, "RF-15"),
            new PantallaModulo("teletrabajo-total-parcial", "Teletrabajo total o parcial", PermisoModulo.Teletrabajo, "RF-16")
        }),
        new ModuloSistema("reportes", "Reportes generales", new[]
        {
            new PantallaModulo("asistencia-feriados", "Asistencia con feriados", PermisoModulo.Asistencia, "RF-17"),
            new PantallaModulo("ausencias-periodo", "Ausencias por periodo", PermisoModulo.Ausencias, "RF-18")
        }),
        // CR-020: fuera de la clasificación A-E del enunciado; permite usar la web sin el escritorio.
        new ModuloSistema("personal", "Personal", new[]
        {
            new PantallaModulo("registro-empleados", "Registro de empleados", PermisoModulo.Personal)
        }),
        new ModuloSistema("mi-cuenta", "Mi cuenta", new[]
        {
            new PantallaModulo("mis-vacaciones", "Mis vacaciones", PermisoModulo.Autoconsulta, "RF-12")
        })
    };

    /// <summary>
    /// Devuelve los módulos con las pantallas que el usuario puede ver, en el mismo orden.
    /// Un módulo sin pantallas permitidas no se incluye.
    /// </summary>
    /// <param name="tienePermiso">Indica si el usuario actual tiene el permiso dado.</param>
    /// <exception cref="ArgumentNullException">Si <paramref name="tienePermiso"/> es nulo.</exception>
    public static IReadOnlyList<ModuloSistema> Visibles(Func<PermisoModulo, bool> tienePermiso)
    {
        if (tienePermiso == null) throw new ArgumentNullException(nameof(tienePermiso));
        return Todos
            .Select(m => new ModuloSistema(m.Clave, m.Titulo, m.Pantallas.Where(p => tienePermiso(p.Permiso)).ToList()))
            .Where(m => m.Pantallas.Count > 0)
            .ToList();
    }
}
