using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Personal;
using RRHH.Domain.Personal;

namespace RRHH.Tests.Fakes;

/// <summary>Repositorio en memoria para los casos de uso de CR-020.</summary>
internal sealed class FakeEmpleadoRegistroRepository : IEmpleadoRegistroRepository
{
    public List<OpcionCatalogoDto> Tipos { get; } = new() { new OpcionCatalogoDto { Id = 1, Descripcion = "DNI" } };

    /// <summary>Áreas por año.</summary>
    public Dictionary<int, List<OpcionCatalogoDto>> AreasPorAnio { get; } = new();

    public Dictionary<int, EmpleadoEdicionDto> Empleados { get; } = new();

    public int Escrituras { get; private set; }

    public IReadOnlyList<OpcionCatalogoDto> TiposDocumento() => Tipos;

    public IReadOnlyList<OpcionCatalogoDto> Areas(int anio) =>
        AreasPorAnio.TryGetValue(anio, out var areas) ? areas : new List<OpcionCatalogoDto>();

    public EmpleadoEdicionDto Obtener(int idEmpleado) => Empleados.TryGetValue(idEmpleado, out var e) ? e : null;

    public int Insertar(DatosEmpleado datos, int anio)
    {
        if (Ocupado(datos, null)) return 0;
        Escrituras++;
        int id = Empleados.Count == 0 ? 1 : Empleados.Keys.Max() + 1;
        Empleados[id] = Copia(id, anio, datos);
        return id;
    }

    public ResultadoEscrituraEmpleado Actualizar(int idEmpleado, DatosEmpleado datos)
    {
        if (!Empleados.TryGetValue(idEmpleado, out var actual)) return ResultadoEscrituraEmpleado.NoExiste;
        if (Ocupado(datos, idEmpleado)) return ResultadoEscrituraEmpleado.DocumentoDuplicado;
        Escrituras++;
        Empleados[idEmpleado] = Copia(idEmpleado, actual.Anio, datos);
        return ResultadoEscrituraEmpleado.Guardado;
    }

    private bool Ocupado(DatosEmpleado datos, int? propio) => Empleados.Values.Any(e => e.Id != propio
        && e.TipoDocumento == datos.TipoDocumento && e.NumeroDocumento == datos.NumeroDocumento);

    private static EmpleadoEdicionDto Copia(int id, int anio, DatosEmpleado d) => new()
    {
        Id = id, Anio = anio, TipoDocumento = d.TipoDocumento, NumeroDocumento = d.NumeroDocumento,
        ApellidoPaterno = d.ApellidoPaterno, ApellidoMaterno = d.ApellidoMaterno, Nombres = d.Nombres,
        Area = d.Area, FechaIngreso = d.FechaIngreso, Activo = d.Activo
    };
}
