using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Personal;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>CR-019: los reportes muestran nombres en lugar de códigos internos.</summary>
public sealed class ObtenerNombresEmpleadosTests
{
    private readonly RepositorioFalso _repositorio = new RepositorioFalso();

    private ObtenerNombresEmpleados Caso => new ObtenerNombresEmpleados(_repositorio);

    [Fact]
    public void SinCodigosValidosNoConsultaLaBase()
    {
        Assert.Empty(Caso.Ejecutar(new[] { 0, -5 }));
        Assert.Empty(Caso.Ejecutar(null));
        Assert.Equal(0, _repositorio.Llamadas);
    }

    [Fact]
    public void QuitaRepetidosYCodigosInvalidosAntesDeConsultar()
    {
        Caso.Ejecutar(new[] { 102, 101, 102, 0, -1, 101 });

        Assert.Equal(new[] { 101, 102 }, _repositorio.Codigos.OrderBy(c => c));
    }

    [Fact]
    public void RechazaMasCodigosDeLosPermitidos()
    {
        var demasiados = Enumerable.Range(1, ObtenerNombresEmpleados.MaximoCodigos + 1).ToArray();

        Assert.Throws<ReglaNegocioException>(() => Caso.Ejecutar(demasiados));
        Assert.Equal(0, _repositorio.Llamadas);
    }

    [Fact]
    public void ExigeUnRepositorio()
    {
        Assert.Throws<ArgumentNullException>(() => new ObtenerNombresEmpleados(null));
    }

    private sealed class RepositorioFalso : IEmpleadoBusquedaRepository
    {
        public int Llamadas { get; private set; }
        public IReadOnlyCollection<int> Codigos { get; private set; }

        public IReadOnlyList<EmpleadoResumenDto> Buscar(string texto, int limite) => throw new NotSupportedException();

        public IReadOnlyList<EmpleadoResumenDto> ObtenerPorCodigos(IReadOnlyCollection<int> codigos)
        {
            Llamadas++;
            Codigos = codigos;
            return codigos.Select(c => new EmpleadoResumenDto(c, $"Empleado {c}", null, true)).ToList();
        }
    }
}
