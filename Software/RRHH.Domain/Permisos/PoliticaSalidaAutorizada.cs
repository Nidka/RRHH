using System;
using System.Collections.Generic;
using System.Globalization;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Permisos;

/// <summary>Regla académica de salida del día; el host proporciona fecha y marcaciones bajo transacción.</summary>
public static class PoliticaSalidaAutorizada
{
    /// <summary>Exige una fecha de hoy y presencia sin salida previa; no modifica la marcación ni el reloj físico.</summary>
    public static void Validar(DateTime hoy,DateTime desde,DateTime hasta,IReadOnlyList<string> salidas)
    {
        if(desde.Date!=hoy.Date || hasta.Date!=hoy.Date)
            throw new ReglaNegocioException("La salida autorizada debe corresponder únicamente al día de hoy.");
        if(salidas==null || salidas.Count==0)
            throw new ReglaNegocioException("El empleado no tiene marcación presencial de hoy.");
        foreach(string hora in salidas)
        {
            if(string.IsNullOrWhiteSpace(hora))continue;
            if(!TimeSpan.TryParse(hora,CultureInfo.InvariantCulture,out var salida) || salida<TimeSpan.Zero || salida>=TimeSpan.FromDays(1))
                throw new ReglaNegocioException("La marcación contiene una hora de salida inválida. Solicite revisión.");
            if(salida>TimeSpan.Zero)throw new ReglaNegocioException("El empleado ya tiene una salida registrada hoy.");
        }
    }
}
