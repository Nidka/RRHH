using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Asistencia;

/// <summary>Asignación temporal identificada por empleado y número, con vigencia inclusiva.</summary>
/// <remarks>La exclusión de solapamientos es una hipótesis de RF-01; no modifica el horario principal.</remarks>
public sealed class AsignacionHorario
{
    public int IdEmpleado { get; }
    public int Numero { get; }
    public RangoFechas Rango { get; }
    public int IdHorario { get; }
    public string Documento { get; }
    public string Sisgedo { get; }

    /// <summary>Valida claves y referencias de hasta 50 caracteres; cero identifica un alta.</summary>
    /// <exception cref="ReglaNegocioException">Identificadores o longitudes inválidos.</exception>
    public AsignacionHorario(int empleado, int numero, RangoFechas rango, int horario, string documento, string sisgedo)
    {
        if (empleado <= 0 || numero < 0 || horario <= 0)
            throw new ReglaNegocioException("Seleccione un empleado y un horario válidos.");
        Rango = rango ?? throw new ArgumentNullException(nameof(rango));
        IdEmpleado = empleado;
        Numero = numero;
        IdHorario = horario;
        Documento = Normalizar(documento);
        Sisgedo = Normalizar(sisgedo);
    }

    /// <summary>Comprueba días comunes del mismo empleado, excluyendo la propia edición.</summary>
    public bool EnConflictoCon(AsignacionHorario otra) => otra != null &&
        IdEmpleado == otra.IdEmpleado && (Numero == 0 || Numero != otra.Numero) && Rango.Solapa(otra.Rango);

    private static string Normalizar(string texto)
    {
        texto = texto?.Trim() ?? string.Empty;
        if (texto.Length > 50) throw new ReglaNegocioException("Documento y Sisgedo admiten hasta 50 caracteres.");
        return texto;
    }
}
