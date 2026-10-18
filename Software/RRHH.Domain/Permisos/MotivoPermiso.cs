using RRHH.Domain.Comun;

namespace RRHH.Domain.Permisos;

/// <summary>Motivo independiente de WinForms, mappers y proveedor de persistencia.</summary>
public sealed class MotivoPermiso
{
    public int Id { get; }
    public int? TipoPermisoId { get; }
    public string Descripcion { get; }
    public string Abreviatura { get; }
    public bool? Salario { get; }
    public string Modalidad { get; }
    public bool? Activo { get; }

    private MotivoPermiso(int id, int? tipo, string descripcion, string abreviatura,
        bool? salario, string modalidad, bool? activo)
    {
        Id = id;
        TipoPermisoId = tipo;
        Descripcion = descripcion;
        Abreviatura = abreviatura;
        Salario = salario;
        Modalidad = modalidad;
        Activo = activo;
    }

    public static MotivoPermiso Nuevo(int tipo, string descripcion, string abreviatura,
        bool? salario, string modalidad)
    {
        Validar(tipo, descripcion, abreviatura);
        return new MotivoPermiso(0, tipo, descripcion.Trim(), abreviatura?.Trim(), salario, modalidad, true);
    }

    /// <summary>Conserva tipo, modalidad y estado que el editor no permite modificar.</summary>
    public MotivoPermiso Editar(string descripcion, string abreviatura, bool? salario)
    {
        Validar(TipoPermisoId, descripcion, abreviatura);
        return new MotivoPermiso(Id, TipoPermisoId, descripcion.Trim(), abreviatura?.Trim(),
            salario, Modalidad, Activo);
    }

    private static void Validar(int? tipo, string descripcion, string abreviatura)
    {
        if (!tipo.HasValue || tipo.Value <= 0)
            throw new ReglaNegocioException("Seleccione un tipo de permiso válido.");
        if (string.IsNullOrWhiteSpace(descripcion))
            throw new ReglaNegocioException("Ingrese la descripción del motivo.");
        if (descripcion.Trim().Length > 50)
            throw new ReglaNegocioException("La descripción no puede superar 50 caracteres.");
        if (abreviatura?.Trim().Length > 3)
            throw new ReglaNegocioException("La abreviatura no puede superar 3 caracteres.");
    }

    /// <summary>Lee datos heredados sin ocultar filas que requieran corrección.</summary>
    public static MotivoPermiso Reconstituir(int id, int? tipo, string descripcion,
        string abreviatura, bool? salario, string modalidad, bool? activo) =>
        new MotivoPermiso(id, tipo, descripcion, abreviatura, salario, modalidad, activo);
}
