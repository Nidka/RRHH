using System;
using System.Collections.Generic;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

/// <summary>Vista pasiva del reporte de ausencias por periodo (RF-18).</summary>
public interface IRepAusenciasView
{
    /// <summary>Primer día del periodo capturado.</summary>
    DateTime Desde { get; }

    /// <summary>Último día del periodo capturado, incluido.</summary>
    DateTime Hasta { get; }

    /// <summary>Motivo elegido en el filtro; null o 0 cuando se eligió «todos».</summary>
    int? MotivoSeleccionado { get; }

    event EventHandler CargarSolicitado;
    event EventHandler ConsultarSolicitado;

    /// <summary>Carga el filtro de motivos; la vista agrega por su cuenta la opción «todos».</summary>
    void MostrarMotivos(IReadOnlyList<MotivoAusenciaDto> motivos);

    void MostrarAusencias(IReadOnlyList<AusenciaPorPeriodoDto> ausencias);

    /// <summary>Texto de resumen del resultado, por ejemplo «3 personas ausentes (4 permisos)».</summary>
    void MostrarResumen(string resumen);

    void HabilitarConsulta(bool habilitada);

    void MostrarError(string mensaje);
}
