using System;
using RRHH.Domain.Permisos;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Permisos;

public sealed class SalidaAutorizadaTests
{
    [Theory]
    [InlineData(18,18)]
    [InlineData(20,20)]
    [InlineData(19,20)]
    public void RechazaFechasFueraDeHoy(int desde,int hasta)=>Assert.Throws<ReglaNegocioException>(()=>
        PoliticaSalidaAutorizada.Validar(new DateTime(2026,11,19),new DateTime(2026,11,desde),new DateTime(2026,11,hasta),new[]{"00:00:00"}));
    [Fact]
    public void MarcacionesSinSalidaPermitenRegistrar()=>PoliticaSalidaAutorizada.Validar(
        new DateTime(2026,11,19),new DateTime(2026,11,19),new DateTime(2026,11,19),new[]{"00:00:00",null,""});
    [Fact]
    public void DosFilasNoOcultanUnaSalida()=>Assert.Throws<ReglaNegocioException>(()=>PoliticaSalidaAutorizada.Validar(
        new DateTime(2026,11,19),new DateTime(2026,11,19),new DateTime(2026,11,19),new[]{"00:00:00","17:00:00"}));
    [Fact]
    public void SinMarcacionNoAcreditaPresencia()=>Assert.Throws<ReglaNegocioException>(()=>PoliticaSalidaAutorizada.Validar(
        new DateTime(2026,11,19),new DateTime(2026,11,19),new DateTime(2026,11,19),Array.Empty<string>()));
}
