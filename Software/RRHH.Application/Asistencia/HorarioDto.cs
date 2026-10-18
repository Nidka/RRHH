namespace RRHH.Application.Asistencia;

/// <summary>Datos del mantenimiento; las horas históricas se leen sin validarlas para permitir su corrección.</summary>
public sealed class HorarioDto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public string Ingreso1 { get; set; }
    public string Salida1 { get; set; }
    public string Ingreso2 { get; set; }
    public string Salida2 { get; set; }
    public bool? Estado { get; set; }
}
