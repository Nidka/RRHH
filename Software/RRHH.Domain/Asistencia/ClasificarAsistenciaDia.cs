namespace RRHH.Domain.Asistencia;

/// <summary>Resultado excluyente de un día del piloto.</summary>
public sealed class ClasificacionAsistenciaDia
{
    public string Categoria { get; }
    public bool Inconsistencia { get; }
    private ClasificacionAsistenciaDia(string categoria,bool inconsistencia){Categoria=categoria;Inconsistencia=inconsistencia;}
    /// <summary>Aplica prioridad ausencia, presencial, remoto; no laborables no computan.</summary>
    /// <remarks>Inconsistencia significa dos fuentes distintas en un día laborable, sin sumar dos categorías.</remarks>
    public static ClasificacionAsistenciaDia Resolver(bool laborable,bool ausencia,bool presencial,bool remoto)
    {
        int fuentes=(ausencia ? 1 : 0)+(presencial ? 1 : 0)+(remoto ? 1 : 0);
        string categoria=!laborable ? "No laborable" : ausencia ? "Ausencia" : presencial ? "Presencial" : remoto ? "Remoto" : "Sin registro";
        return new ClasificacionAsistenciaDia(categoria,laborable && fuentes>1);
    }
}
