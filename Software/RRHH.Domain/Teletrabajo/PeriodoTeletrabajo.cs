using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Teletrabajo;

/// <summary>Modalidades reconocidas de un periodo de teletrabajo.</summary>
public enum ModalidadTeletrabajo { Total, Parcial }

/// <summary>Periodo inclusivo con un patrón de días remotos de lunes a viernes.</summary>
public sealed class PeriodoTeletrabajo
{
    /// <summary>Máscara que incluye los cinco días de la semana laboral propuesta.</summary>
    public const int SemanaCompleta = 31;

    public int IdEmpleado { get; }
    public RangoFechas Rango { get; }
    public ModalidadTeletrabajo Modalidad { get; }
    public int DiasRemotos { get; }
    public string Autorizacion { get; }

    /// <summary>Crea un periodo y valida el código, modalidad, patrón y referencia opcional.</summary>
    /// <exception cref="ReglaNegocioException">Los datos no cumplen el contrato del periodo.</exception>
    public PeriodoTeletrabajo(int empleado, RangoFechas rango, ModalidadTeletrabajo modalidad,
        int diasRemotos, string autorizacion)
    {
        if (empleado <= 0) throw new ReglaNegocioException("Indique un código de empleado positivo.");
        Rango = rango ?? throw new ArgumentNullException(nameof(rango));
        if (modalidad != ModalidadTeletrabajo.Total && modalidad != ModalidadTeletrabajo.Parcial)
            throw new ReglaNegocioException("Seleccione una modalidad válida.");
        if (modalidad == ModalidadTeletrabajo.Total ? diasRemotos != SemanaCompleta :
            diasRemotos < 1 || diasRemotos >= SemanaCompleta)
            throw new ReglaNegocioException("La modalidad parcial requiere entre uno y cuatro días remotos.");
        autorizacion = autorizacion?.Trim();
        if (autorizacion?.Length > 200)
            throw new ReglaNegocioException("La referencia de autorización admite hasta 200 caracteres.");
        IdEmpleado = empleado;
        Modalidad = modalidad;
        DiasRemotos = diasRemotos;
        Autorizacion = string.IsNullOrEmpty(autorizacion) ? null : autorizacion;
    }

    /// <summary>Determina si el periodo comparte al menos un día con otro del mismo empleado.</summary>
    public bool Solapa(PeriodoTeletrabajo otro) =>
        IdEmpleado == otro.IdEmpleado && Rango.Solapa(otro.Rango);
}
