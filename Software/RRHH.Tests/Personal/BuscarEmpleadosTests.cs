using System;
using System.Collections.Generic;
using RRHH.Application.Personal;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>CR-019: reglas del caso de uso de búsqueda, sin base de datos.</summary>
public sealed class BuscarEmpleadosTests
{
    private readonly RepositorioFalso _repositorio = new RepositorioFalso();

    private BuscarEmpleados Caso => new BuscarEmpleados(_repositorio);

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("g")]
    [InlineData(" g ")]
    public void UnTextoDeMenosDeDosCaracteresNoConsultaLaBase(string texto)
    {
        Assert.Empty(Caso.Ejecutar(texto));
        Assert.Equal(0, _repositorio.Llamadas);
    }

    [Fact]
    public void RecortaEspaciosYLimitaLaCantidadDeResultados()
    {
        Caso.Ejecutar("  gar  ");

        Assert.Equal("gar", _repositorio.Texto);
        Assert.Equal(BuscarEmpleados.MaximoResultados, _repositorio.Limite);
    }

    [Fact]
    public void UnTextoMuyLargoSeAcortaAntesDeConsultar()
    {
        Caso.Ejecutar(new string('a', 500));

        Assert.Equal(BuscarEmpleados.MaximoCaracteres, _repositorio.Texto.Length);
    }

    [Fact]
    public void DevuelveLoQueEncuentraElRepositorio()
    {
        _repositorio.Resultado = new[] { new EmpleadoResumenDto(101, "García Pérez, Ana", "12345678", true) };

        var encontrado = Assert.Single(Caso.Ejecutar("garcía"));
        Assert.Equal(101, encontrado.IdEmpleado);
    }

    [Fact]
    public void ExigeUnRepositorio()
    {
        Assert.Throws<ArgumentNullException>(() => new BuscarEmpleados(null));
    }

    private sealed class RepositorioFalso : IEmpleadoBusquedaRepository
    {
        public int Llamadas { get; private set; }
        public string Texto { get; private set; }
        public int Limite { get; private set; }
        public IReadOnlyList<EmpleadoResumenDto> Resultado { get; set; } = Array.Empty<EmpleadoResumenDto>();

        public IReadOnlyList<EmpleadoResumenDto> Buscar(string texto, int limite)
        {
            Llamadas++;
            Texto = texto;
            Limite = limite;
            return Resultado;
        }

        public IReadOnlyList<EmpleadoResumenDto> ObtenerPorCodigos(IReadOnlyCollection<int> codigos) =>
            throw new NotSupportedException();
    }
}
