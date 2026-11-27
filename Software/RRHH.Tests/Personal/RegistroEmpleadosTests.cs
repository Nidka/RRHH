using System;
using System.Collections.Generic;
using RRHH.Application.Personal;
using RRHH.Domain.Comun;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>CR-020: casos de uso de alta, edición y consulta de empleados con un repositorio en memoria.</summary>
public sealed class RegistroEmpleadosTests
{
    private static readonly DateTime Hoy = new DateTime(2026, 11, 27);
    private readonly FakeEmpleadoRegistroRepository _repo = new();

    public RegistroEmpleadosTests()
    {
        _repo.AreasPorAnio[2026] = new List<OpcionCatalogoDto> { new() { Id = 10, Descripcion = "Recursos Humanos" } };
        _repo.AreasPorAnio[2025] = new List<OpcionCatalogoDto> { new() { Id = 20, Descripcion = "Sistemas" } };
    }

    private static EmpleadoEdicionDto Entrada(string documento = "40000001", int area = 10) => new()
    {
        TipoDocumento = 1, NumeroDocumento = documento, ApellidoPaterno = "Paredes", ApellidoMaterno = "Quispe",
        Nombres = "Lucía", Area = area, FechaIngreso = new DateTime(2024, 3, 1)
    };

    private RegistrarEmpleado Registrar() => new(_repo, () => Hoy);

    [Fact]
    public void RegistraEnElAnioActualActivoYDevuelveElCodigo()
    {
        var dto = Entrada();
        var resultado = Registrar().Ejecutar(dto);

        Assert.True(resultado.Exitoso, resultado.Mensaje);
        Assert.Equal(1, dto.Id);
        Assert.Equal(2026, dto.Anio);
        Assert.True(_repo.Empleados[1].Activo);
        Assert.Equal(2026, _repo.Empleados[1].Anio);
    }

    [Fact]
    public void RechazaUnDocumentoYaRegistradoAunqueCambienEspaciosYMayusculas()
    {
        Assert.True(Registrar().Ejecutar(Entrada("ce-123")).Exitoso);

        var resultado = Registrar().Ejecutar(Entrada(" CE-123 "));

        Assert.False(resultado.Exitoso);
        Assert.Equal(RegistrarEmpleado.MensajeDocumentoDuplicado, resultado.Mensaje);
        Assert.Single(_repo.Empleados);
    }

    [Fact]
    public void RechazaAreaOTipoInexistentesSinEscribir()
    {
        var sinArea = Registrar().Ejecutar(Entrada(area: 20));
        var dto = Entrada(); dto.TipoDocumento = 9;
        var sinTipo = Registrar().Ejecutar(dto);

        Assert.Equal("El área no existe en la estructura orgánica de 2026.", sinArea.Mensaje);
        Assert.Equal("El tipo de documento no existe.", sinTipo.Mensaje);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void UnDatoInvalidoSeInformaComoErrorSinEscribir()
    {
        var dto = Entrada(); dto.Nombres = " ";

        var resultado = Registrar().Ejecutar(dto);

        Assert.Equal("Ingrese los nombres.", resultado.Mensaje);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void EditaConElAreaDelAnioDelEmpleadoYPermiteRegistrarElCese()
    {
        _repo.Empleados[7] = new EmpleadoEdicionDto { Id = 7, Anio = 2025, TipoDocumento = 1, NumeroDocumento = "50000007",
            ApellidoPaterno = "Salinas", Nombres = "Raúl", Area = 20, FechaIngreso = new DateTime(2006, 5, 2), Activo = true };
        var dto = Entrada("50000007", area: 20); dto.Activo = false;

        var resultado = new ActualizarEmpleado(_repo, () => Hoy).Ejecutar(7, dto);

        Assert.True(resultado.Exitoso, resultado.Mensaje);
        Assert.False(_repo.Empleados[7].Activo);
        Assert.Equal(2025, _repo.Empleados[7].Anio);
        Assert.Equal("Paredes", _repo.Empleados[7].ApellidoPaterno);
    }

    [Fact]
    public void AlEditarNoPuedeTomarElDocumentoDeOtraPersona()
    {
        Registrar().Ejecutar(Entrada("40000001"));
        Registrar().Ejecutar(Entrada("40000002"));

        var resultado = new ActualizarEmpleado(_repo, () => Hoy).Ejecutar(2, Entrada("40000001"));

        Assert.Equal(RegistrarEmpleado.MensajeDocumentoDuplicado, resultado.Mensaje);
        Assert.Equal("40000002", _repo.Empleados[2].NumeroDocumento);
    }

    [Fact]
    public void EditarOConsultarUnEmpleadoInexistenteSeRechaza()
    {
        Assert.Equal(ObtenerEmpleado.MensajeNoExiste, new ActualizarEmpleado(_repo, () => Hoy).Ejecutar(99, Entrada()).Mensaje);
        Assert.Equal(ObtenerEmpleado.MensajeNoExiste,
            Assert.Throws<ReglaNegocioException>(() => new ObtenerEmpleado(_repo).Ejecutar(99)).Message);
    }

    [Fact]
    public void LasListasDelFormularioSonDelAnioActual()
    {
        var datos = new ObtenerDatosRegistroEmpleado(_repo, () => Hoy).Ejecutar();

        Assert.Equal(2026, datos.Anio);
        Assert.Equal("Recursos Humanos", Assert.Single(datos.Areas).Descripcion);
        Assert.Equal("DNI", Assert.Single(datos.TiposDocumento).Descripcion);
    }
}
