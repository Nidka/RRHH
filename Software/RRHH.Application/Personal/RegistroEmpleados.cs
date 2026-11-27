using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
using RRHH.Domain.Personal;

namespace RRHH.Application.Personal;

/// <summary>Una opción de catálogo para las listas del formulario (tipo de documento o área).</summary>
public sealed class OpcionCatalogoDto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
}

/// <summary>Listas que necesita el formulario de registro y el año en que se registran las altas.</summary>
public sealed class DatosRegistroEmpleadoDto
{
    public int Anio { get; set; }
    public IReadOnlyList<OpcionCatalogoDto> TiposDocumento { get; set; }
    public IReadOnlyList<OpcionCatalogoDto> Areas { get; set; }
}

/// <summary>Datos básicos de un empleado tal como los envía o muestra el formulario web (CR-020).</summary>
public sealed class EmpleadoEdicionDto
{
    /// <summary>Código del empleado; 0 en un alta. Se completa al registrar.</summary>
    public int Id { get; set; }
    public int TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Nombres { get; set; }
    public int Area { get; set; }
    public DateTime FechaIngreso { get; set; }
    public bool Activo { get; set; } = true;

    /// <summary>Año de la fila de <c>Empleado</c> que se muestra y edita (la más reciente). Solo lectura para el cliente.</summary>
    public int Anio { get; set; }
}

/// <summary>Resultado de escribir un empleado en el repositorio.</summary>
public enum ResultadoEscrituraEmpleado
{
    Guardado,
    DocumentoDuplicado,
    NoExiste
}

/// <summary>
/// Persistencia del registro de empleados (CR-020). Una implementación debe comprobar el documento duplicado y asignar
/// los códigos dentro de la misma transacción, serializada con el registro del escritorio.
/// </summary>
public interface IEmpleadoRegistroRepository
{
    IReadOnlyList<OpcionCatalogoDto> TiposDocumento();

    /// <summary>Áreas de <c>EstructOrganiz</c> del año indicado.</summary>
    IReadOnlyList<OpcionCatalogoDto> Areas(int anio);

    /// <summary>Datos del empleado según su fila más reciente, o <c>null</c> si no existe.</summary>
    EmpleadoEdicionDto Obtener(int idEmpleado);

    /// <summary>Inserta persona, empleado del año y su área.</summary>
    /// <returns>El código asignado, o 0 si el tipo y número de documento ya pertenecen a otra persona.</returns>
    int Insertar(DatosEmpleado datos, int anio);

    /// <summary>Actualiza la persona y solo la fila más reciente del empleado, con su área.</summary>
    ResultadoEscrituraEmpleado Actualizar(int idEmpleado, DatosEmpleado datos);
}

/// <summary>Devuelve las listas del formulario de registro para el año actual.</summary>
public sealed class ObtenerDatosRegistroEmpleado
{
    private readonly IEmpleadoRegistroRepository _repository;
    private readonly Func<DateTime> _hoy;

    public ObtenerDatosRegistroEmpleado(IEmpleadoRegistroRepository repository, Func<DateTime> hoy = null)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _hoy = hoy ?? (() => DateTime.Today);
    }

    public DatosRegistroEmpleadoDto Ejecutar()
    {
        int anio = _hoy().Year;
        return new DatosRegistroEmpleadoDto
        {
            Anio = anio,
            TiposDocumento = _repository.TiposDocumento(),
            Areas = _repository.Areas(anio)
        };
    }
}

/// <summary>Carga los datos de un empleado para editarlos.</summary>
public sealed class ObtenerEmpleado
{
    public const string MensajeNoExiste = "El empleado no existe.";

    private readonly IEmpleadoRegistroRepository _repository;

    public ObtenerEmpleado(IEmpleadoRegistroRepository repository) =>
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    /// <exception cref="ReglaNegocioException">El código no es válido o el empleado no existe.</exception>
    public EmpleadoEdicionDto Ejecutar(int idEmpleado)
    {
        if (idEmpleado <= 0) throw new ReglaNegocioException("Indique un código de empleado válido.");
        return _repository.Obtener(idEmpleado) ?? throw new ReglaNegocioException(MensajeNoExiste);
    }
}

/// <summary>
/// CR-020: registra un empleado nuevo (persona, empleado del año actual y su área), activo.
/// Reemplaza para la web el alta de <c>FrmMantEmpleado_Basico</c> / <c>RRHHClass.Ingresa_Empleado</c>.
/// </summary>
public sealed class RegistrarEmpleado
{
    public const string MensajeDocumentoDuplicado = "Ya existe un empleado con ese documento.";

    private readonly IEmpleadoRegistroRepository _repository;
    private readonly Func<DateTime> _hoy;

    public RegistrarEmpleado(IEmpleadoRegistroRepository repository, Func<DateTime> hoy = null)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _hoy = hoy ?? (() => DateTime.Today);
    }

    /// <returns>Éxito con <see cref="EmpleadoEdicionDto.Id"/> completado, o error con el mensaje para el usuario.</returns>
    public ResultadoOperacion Ejecutar(EmpleadoEdicionDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        DateTime hoy = _hoy();
        int anio = hoy.Year;
        DatosEmpleado datos;
        try
        {
            datos = DatosEmpleado.Crear(dto.TipoDocumento, dto.NumeroDocumento, dto.ApellidoPaterno, dto.ApellidoMaterno,
                dto.Nombres, dto.Area, dto.FechaIngreso, activo: true, hoy);
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Error(ex.Message);
        }

        string error = ValidacionCatalogos.Validar(_repository, datos, anio);
        if (error != null) return ResultadoOperacion.Error(error);

        int id = _repository.Insertar(datos, anio);
        if (id <= 0) return ResultadoOperacion.Error(MensajeDocumentoDuplicado);
        dto.Id = id;
        dto.Anio = anio;
        dto.Activo = true;
        return ResultadoOperacion.Ok();
    }
}

/// <summary>
/// CR-020: edita los datos básicos y el estado de un empleado. A diferencia de <c>RRHHClass.Actualiza_Empleado</c>,
/// conserva las filas de años anteriores y permite registrar el cese.
/// </summary>
public sealed class ActualizarEmpleado
{
    private readonly IEmpleadoRegistroRepository _repository;
    private readonly Func<DateTime> _hoy;

    public ActualizarEmpleado(IEmpleadoRegistroRepository repository, Func<DateTime> hoy = null)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _hoy = hoy ?? (() => DateTime.Today);
    }

    public ResultadoOperacion Ejecutar(int idEmpleado, EmpleadoEdicionDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        EmpleadoEdicionDto actual = idEmpleado > 0 ? _repository.Obtener(idEmpleado) : null;
        if (actual == null) return ResultadoOperacion.Error(ObtenerEmpleado.MensajeNoExiste);

        DatosEmpleado datos;
        try
        {
            datos = DatosEmpleado.Crear(dto.TipoDocumento, dto.NumeroDocumento, dto.ApellidoPaterno, dto.ApellidoMaterno,
                dto.Nombres, dto.Area, dto.FechaIngreso, dto.Activo, _hoy());
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Error(ex.Message);
        }

        string error = ValidacionCatalogos.Validar(_repository, datos, actual.Anio);
        if (error != null) return ResultadoOperacion.Error(error);

        switch (_repository.Actualizar(idEmpleado, datos))
        {
            case ResultadoEscrituraEmpleado.DocumentoDuplicado:
                return ResultadoOperacion.Error(RegistrarEmpleado.MensajeDocumentoDuplicado);
            case ResultadoEscrituraEmpleado.NoExiste:
                return ResultadoOperacion.Error(ObtenerEmpleado.MensajeNoExiste);
            default:
                dto.Id = idEmpleado;
                dto.Anio = actual.Anio;
                return ResultadoOperacion.Ok();
        }
    }
}

internal static class ValidacionCatalogos
{
    /// <summary>Comprueba que el tipo de documento y el área existan; devuelve el mensaje de error o null.</summary>
    internal static string Validar(IEmpleadoRegistroRepository repository, DatosEmpleado datos, int anio)
    {
        if (!repository.TiposDocumento().Any(t => t.Id == datos.TipoDocumento))
            return "El tipo de documento no existe.";
        if (!repository.Areas(anio).Any(a => a.Id == datos.Area))
            return $"El área no existe en la estructura orgánica de {anio}.";
        return null;
    }
}
