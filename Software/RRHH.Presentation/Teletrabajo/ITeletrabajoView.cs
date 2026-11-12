using System;
using System.Collections.Generic;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Presentation.Teletrabajo;

/// <summary>Captura datos de teletrabajo y presenta la consulta sin acceder a persistencia.</summary>
public interface ITeletrabajoView
{
    int IdEmpleado { get; }
    DateTime Desde { get; }
    DateTime Hasta { get; }
    ModalidadTeletrabajo Modalidad { get; }
    int DiasRemotos { get; }
    string Autorizacion { get; }
    event EventHandler RegistrarSolicitado;
    event EventHandler ListarSolicitado;
    void MostrarPeriodos(IReadOnlyList<PeriodoTeletrabajoDto> periodos);
    void MostrarRegistro(int id);
    void MostrarError(string mensaje);
}
