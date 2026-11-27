using System;
using System.Linq;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Personal;

/// <summary>
/// CR-020: datos básicos con los que se registra o edita un empleado desde la web.
/// Valida y normaliza al crearse; una instancia siempre es válida e inmutable.
/// </summary>
/// <remarks>
/// Las longitudes vienen del esquema (<c>Persona."Nombres" varchar(100)</c>, apellidos <c>varchar(30)</c>,
/// <c>NumDocID varchar(12)</c>). HIPÓTESIS (ver <c>specs/CR-020-registro-empleados-web.md</c>): la fecha de ingreso
/// se admite desde 1950 hasta un año después de hoy, para permitir ingresos programados.
/// </remarks>
public sealed class DatosEmpleado
{
    public const int MaximoNombres = 100;
    public const int MaximoApellido = 30;
    public const int MaximoDocumento = 12;

    private static readonly DateTime IngresoMinimo = new DateTime(1950, 1, 1);

    private DatosEmpleado(int tipoDocumento, string numeroDocumento, string apellidoPaterno, string apellidoMaterno,
        string nombres, int area, DateTime fechaIngreso, bool activo)
    {
        TipoDocumento = tipoDocumento;
        NumeroDocumento = numeroDocumento;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        Nombres = nombres;
        Area = area;
        FechaIngreso = fechaIngreso;
        Activo = activo;
    }

    public int TipoDocumento { get; }

    /// <summary>Número de documento sin espacios y en mayúsculas.</summary>
    public string NumeroDocumento { get; }

    public string ApellidoPaterno { get; }

    /// <summary>Apellido materno, o <c>null</c> si no se indicó.</summary>
    public string ApellidoMaterno { get; }

    public string Nombres { get; }

    public int Area { get; }

    /// <summary>Fecha de ingreso sin hora.</summary>
    public DateTime FechaIngreso { get; }

    public bool Activo { get; }

    /// <summary>Valida y normaliza los datos.</summary>
    /// <param name="hoy">Fecha actual; se recibe para que la regla del ingreso sea comprobable.</param>
    /// <exception cref="ReglaNegocioException">Algún dato no cumple las reglas; el mensaje es para el usuario.</exception>
    public static DatosEmpleado Crear(int tipoDocumento, string numeroDocumento, string apellidoPaterno,
        string apellidoMaterno, string nombres, int area, DateTime fechaIngreso, bool activo, DateTime hoy)
    {
        if (tipoDocumento <= 0) throw new ReglaNegocioException("Seleccione el tipo de documento.");
        string documento = (numeroDocumento ?? string.Empty).Trim().ToUpperInvariant();
        if (documento.Length == 0) throw new ReglaNegocioException("Ingrese el número de documento.");
        if (documento.Length > MaximoDocumento)
            throw new ReglaNegocioException($"El documento admite hasta {MaximoDocumento} caracteres.");
        if (!documento.All(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || c == '-'))
            throw new ReglaNegocioException("El documento solo admite letras, números y guion.");

        string paterno = Requerido(apellidoPaterno, "Ingrese el apellido paterno.",
            $"El apellido paterno admite hasta {MaximoApellido} caracteres.", MaximoApellido);
        string materno = (apellidoMaterno ?? string.Empty).Trim();
        if (materno.Length > MaximoApellido)
            throw new ReglaNegocioException($"El apellido materno admite hasta {MaximoApellido} caracteres.");
        string nombre = Requerido(nombres, "Ingrese los nombres.",
            $"Los nombres admiten hasta {MaximoNombres} caracteres.", MaximoNombres);

        if (area <= 0) throw new ReglaNegocioException("Seleccione el área.");
        DateTime ingreso = fechaIngreso.Date;
        if (ingreso < IngresoMinimo || ingreso > hoy.Date.AddYears(1))
            throw new ReglaNegocioException("La fecha de ingreso debe estar entre 1950 y un año después de hoy.");

        return new DatosEmpleado(tipoDocumento, documento, paterno, materno.Length == 0 ? null : materno, nombre, area, ingreso, activo);
    }

    private static string Requerido(string valor, string mensajeVacio, string mensajeLargo, int maximo)
    {
        string limpio = (valor ?? string.Empty).Trim();
        if (limpio.Length == 0) throw new ReglaNegocioException(mensajeVacio);
        if (limpio.Length > maximo) throw new ReglaNegocioException(mensajeLargo);
        return limpio;
    }
}
