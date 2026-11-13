using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Presentation.Teletrabajo;

/// <summary>Vista pasiva del reporte de teletrabajo total o parcial (RF-16).</summary>
public interface IClasificacionTeletrabajoView
{
    DateTime Desde { get; }
    DateTime Hasta { get; }

    /// <summary>Clasificación elegida en el filtro; <c>null</c> cuando se eligió «todas».</summary>
    ModalidadTeletrabajo? Filtro { get; }

    event EventHandler ConsultarSolicitado;
    void MostrarFilas(IReadOnlyList<ClasificacionTeletrabajoDto> filas);
    void MostrarResumen(string resumen);
    void MostrarError(string mensaje);
}

/// <summary>Coordina la consulta de RF-16: ejecuta el caso de uso y comunica filas, resumen y errores a la vista.</summary>
public sealed class ClasificacionTeletrabajoPresenter
{
    public const string ResumenSinPersonal = "Nadie teletrabaja en el periodo consultado.";

    private readonly IClasificacionTeletrabajoView _vista;
    private readonly ReportarTeletrabajoTotalOParcial _reporte;

    public ClasificacionTeletrabajoPresenter(IClasificacionTeletrabajoView vista, ReportarTeletrabajoTotalOParcial reporte)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        _reporte = reporte ?? throw new ArgumentNullException(nameof(reporte));
        _vista.ConsultarSolicitado += (_, _) => Consultar();
    }

    private void Consultar()
    {
        try
        {
            IReadOnlyList<ClasificacionTeletrabajoDto> filas = _reporte.Ejecutar(_vista.Desde, _vista.Hasta, _vista.Filtro);
            _vista.MostrarFilas(filas);
            _vista.MostrarResumen(Resumir(filas));
        }
        catch (ReglaNegocioException ex)
        {
            _vista.MostrarError(ex.Message);
        }
        catch (Exception)
        {
            _vista.MostrarError("No se pudo consultar el reporte. Compruebe la conexión y el esquema.");
        }
    }

    private static string Resumir(IReadOnlyList<ClasificacionTeletrabajoDto> filas)
    {
        if (filas.Count == 0)
        {
            return ResumenSinPersonal;
        }

        int total = filas.Count(f => f.Clasificacion == ModalidadTeletrabajo.Total);
        int parcial = filas.Count - total;
        return filas.Count + (filas.Count == 1 ? " persona" : " personas") + " en teletrabajo: " + total + " total y " + parcial + " parcial";
    }
}
