using System;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>Valida la entrada del formulario y registra un periodo por el contrato atómico.</summary>
public sealed class RegistrarPeriodoTeletrabajo
{
    private readonly ITeletrabajoRepository _repository;

    public RegistrarPeriodoTeletrabajo(ITeletrabajoRepository repository) => _repository = repository;

    /// <summary>Devuelve el identificador asignado al periodo persistido.</summary>
    public int Ejecutar(int empleado, DateTime desde, DateTime hasta,
        ModalidadTeletrabajo modalidad, int diasRemotos, string autorizacion) =>
        _repository.Registrar(new PeriodoTeletrabajo(empleado, RangoFechas.Crear(desde, hasta),
            modalidad, diasRemotos, autorizacion));
}
