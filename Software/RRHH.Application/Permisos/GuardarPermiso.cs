using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>Datos editables del permiso; no incluye marcaciones ni autorización administrativa heredada.</summary>
public sealed class PermisoGuardarDto
{
    public int IdEmpleado { get; set; }
    /// <summary>Cero para alta; tras el éxito contiene el número persistido para este empleado.</summary>
    public int Numero { get; set; }
    public int IdMotivo { get; set; }
    public DateTime Desde { get; set; }
    public DateTime Hasta { get; set; }
    /// <summary>Null conserva el estado al editar; en altas se utiliza Solicitado.</summary>
    public string Estado { get; set; }
    public string Lugar { get; set; }
    public string Referencia { get; set; }
    public string Autorizacion { get; set; }
    public string Observacion { get; set; }
    public bool? Dia { get; set; }
    public bool? Retorno { get; set; }
    /// <summary>Null conserva el valor al editar; true consume 0,5 días para motivos de vacaciones del piloto.</summary>
    public bool? MediaJornadaVacaciones { get; set; }
}

/// <summary>Persiste el permiso validando fechas y cupo anual dentro de la misma transacción.</summary>
public interface IPermisoEscrituraRepository
{
    /// <summary>Guarda campos editables y devuelve el número solo después del commit.</summary>
    /// <remarks>Debe serializar validación, asignación de número y escritura entre sus escritores.</remarks>
    /// <exception cref="ReglaNegocioException">Conflicto, referencia inválida o esquema pendiente.</exception>
    int Guardar(PermisoGuardarDto permiso);
}

/// <summary>Valida la entrada del permiso antes del guardado transaccional RF-03/RF-06.</summary>
/// <remarks>El host debe autorizar al operador; este caso de uso no autentica usuarios.</remarks>
public sealed class GuardarPermiso
{
    private readonly IPermisoEscrituraRepository _repository;
    public GuardarPermiso(IPermisoEscrituraRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    /// <summary>Valida y guarda; conserva el número del DTO si la operación falla.</summary>
    /// <returns>Error de negocio o éxito con el número definitivo en el DTO.</returns>
    public ResultadoOperacion Ejecutar(PermisoGuardarDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        try
        {
            if (dto.IdEmpleado <= 0 || dto.IdMotivo <= 0 || dto.Numero < 0)
                throw new ReglaNegocioException("Empleado, motivo o número de permiso inválido.");
            if (dto.Dia == true && dto.Retorno == true)
                throw new ReglaNegocioException("Día completo y con retorno no pueden seleccionarse simultáneamente.");
            RangoFechas.Crear(dto.Desde, dto.Hasta);
            if (dto.Desde.Year < 1900 || dto.Hasta.Year > 9998)
                throw new ReglaNegocioException("Las fechas deben estar entre 1900 y 9998.");
            if (dto.Estado != null && dto.Estado != "Solicitado" && dto.Estado != "Aprobado"
                && dto.Estado != "Rechazado" && dto.Estado != "Anulado")
                throw new ReglaNegocioException("Seleccione un estado válido del permiso.");
            ExigirLongitud(dto.Lugar, 20, "Lugar");
            ExigirLongitud(dto.Referencia, 100, "Referencia");
            ExigirLongitud(dto.Autorizacion, 50, "Autorización");
            ExigirLongitud(dto.Observacion, 200, "Observación");
            dto.Numero = _repository.Guardar(dto);
            return ResultadoOperacion.Ok();
        }
        catch (ReglaNegocioException ex)
        {
            return ResultadoOperacion.Error(ex.Message);
        }
    }

    private static void ExigirLongitud(string valor, int maximo, string campo)
    {
        if (valor != null && valor.Length > maximo)
            throw new ReglaNegocioException(campo + " admite hasta " + maximo + " caracteres.");
    }
}
