using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

public sealed class MotivoPermisoDto
{
    public int Id { get; set; }
    public int? TipoPermisoId { get; set; }
    public string Descripcion { get; set; }
    public string DescripcionTipo { get; set; }
    public string Abreviatura { get; set; }
    public bool? Salario { get; set; }
    public string Modalidad { get; set; }
    public bool? Activo { get; set; }

    public static MotivoPermisoDto Desde(MotivoPermiso motivo) => new MotivoPermisoDto
    {
        Id = motivo.Id, TipoPermisoId = motivo.TipoPermisoId,
        Descripcion = motivo.Descripcion, Abreviatura = motivo.Abreviatura,
        Salario = motivo.Salario, Modalidad = motivo.Modalidad, Activo = motivo.Activo
    };
}
