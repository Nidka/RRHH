using System;
using System.Globalization;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Asistencia;

/// <summary>Horario válido con cuatro horas del día; no impone un orden que excluya jornadas nocturnas.</summary>
public sealed class Horario
{
    private Horario(int id, string descripcion, TimeSpan ingreso1, TimeSpan salida1,
        TimeSpan ingreso2, TimeSpan salida2, bool? estado)
    {
        Id = id;
        Descripcion = descripcion;
        Ingreso1 = ingreso1;
        Salida1 = salida1;
        Ingreso2 = ingreso2;
        Salida2 = salida2;
        Estado = estado;
    }

    /// <summary>Cero para alta; positivo para edición.</summary>
    public int Id { get; }
    public string Descripcion { get; }
    public TimeSpan Ingreso1 { get; }
    public TimeSpan Salida1 { get; }
    public TimeSpan Ingreso2 { get; }
    public TimeSpan Salida2 { get; }
    public bool? Estado { get; }

    /// <summary>Valida y normaliza una edición; admite descripción vacía como el formulario anterior.</summary>
    /// <remarks>No calcula ni modifica SgtDia. Las horas aceptan H:mm, HH:mm y sus variantes con segundos.</remarks>
    /// <exception cref="ReglaNegocioException">Código negativo, descripción mayor de 20 o una hora inválida.</exception>
    public static Horario Crear(int id, string descripcion, string ingreso1, string salida1,
        string ingreso2, string salida2, bool? estado)
    {
        if (id < 0) throw new ReglaNegocioException("El código de horario no es válido.");
        string texto = (descripcion ?? string.Empty).Trim();
        if (texto.Length > 20) throw new ReglaNegocioException("La descripción no puede superar 20 caracteres.");
        return new Horario(id, texto, LeerHora(ingreso1), LeerHora(salida1),
            LeerHora(ingreso2), LeerHora(salida2), estado);
    }

    /// <summary>Formato invariable compatible con las columnas varchar(8) heredadas.</summary>
    public static string FormatearHora(TimeSpan hora) => hora.ToString(@"hh\:mm\:ss", CultureInfo.InvariantCulture);

    private static TimeSpan LeerHora(string texto)
    {
        var formatos = new[] { @"h\:mm", @"hh\:mm", @"h\:mm\:ss", @"hh\:mm\:ss" };
        if (!TimeSpan.TryParseExact((texto ?? string.Empty).Trim(), formatos, CultureInfo.InvariantCulture,
            TimeSpanStyles.None, out TimeSpan hora) || hora < TimeSpan.Zero || hora >= TimeSpan.FromDays(1))
            throw new ReglaNegocioException("Debe ingresar cuatro horas válidas entre 00:00:00 y 23:59:59.");
        return hora;
    }
}
