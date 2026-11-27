using System;
using RRHH.Domain.Comun;
using RRHH.Domain.Personal;
using Xunit;

namespace RRHH.Tests.Personal;

/// <summary>CR-020: reglas y normalización de los datos básicos de un empleado. Datos ficticios.</summary>
public sealed class DatosEmpleadoTests
{
    private static readonly DateTime Hoy = new DateTime(2026, 11, 27);

    private static DatosEmpleado Crear(int tipo = 1, string documento = "40000001", string paterno = "Paredes",
        string materno = "Quispe", string nombres = "Lucía", int area = 1, DateTime? ingreso = null, bool activo = true) =>
        DatosEmpleado.Crear(tipo, documento, paterno, materno, nombres, area, ingreso ?? new DateTime(2024, 3, 1), activo, Hoy);

    [Fact]
    public void NormalizaDocumentoNombresYFecha()
    {
        var datos = DatosEmpleado.Crear(2, "  ce-12ab ", " Paredes ", "  ", " Lucía  ", 3, new DateTime(2024, 3, 1, 15, 30, 0), false, Hoy);

        Assert.Equal("CE-12AB", datos.NumeroDocumento);
        Assert.Equal("Paredes", datos.ApellidoPaterno);
        Assert.Null(datos.ApellidoMaterno);
        Assert.Equal("Lucía", datos.Nombres);
        Assert.Equal(new DateTime(2024, 3, 1), datos.FechaIngreso);
        Assert.False(datos.Activo);
    }

    [Theory]
    [InlineData(0, "40000001", "Paredes", "Lucía", 1, "Seleccione el tipo de documento.")]
    [InlineData(1, " ", "Paredes", "Lucía", 1, "Ingrese el número de documento.")]
    [InlineData(1, "1234567890123", "Paredes", "Lucía", 1, "El documento admite hasta 12 caracteres.")]
    [InlineData(1, "4000 0001", "Paredes", "Lucía", 1, "El documento solo admite letras, números y guion.")]
    [InlineData(1, "40000001", "", "Lucía", 1, "Ingrese el apellido paterno.")]
    [InlineData(1, "40000001", "Paredes", "  ", 1, "Ingrese los nombres.")]
    [InlineData(1, "40000001", "Paredes", "Lucía", 0, "Seleccione el área.")]
    public void RechazaDatosObligatoriosOInvalidos(int tipo, string documento, string paterno, string nombres, int area, string mensaje)
    {
        var error = Assert.Throws<ReglaNegocioException>(() => Crear(tipo, documento, paterno, "Quispe", nombres, area));
        Assert.Equal(mensaje, error.Message);
    }

    [Fact]
    public void RespetaLasLongitudesDelEsquema()
    {
        Assert.Equal("El apellido paterno admite hasta 30 caracteres.",
            Assert.Throws<ReglaNegocioException>(() => Crear(paterno: new string('a', 31))).Message);
        Assert.Equal("El apellido materno admite hasta 30 caracteres.",
            Assert.Throws<ReglaNegocioException>(() => Crear(materno: new string('a', 31))).Message);
        Assert.Equal("Los nombres admiten hasta 100 caracteres.",
            Assert.Throws<ReglaNegocioException>(() => Crear(nombres: new string('a', 101))).Message);
        Assert.Equal(30, Crear(paterno: new string('a', 30)).ApellidoPaterno.Length);
    }

    [Theory]
    [InlineData(1949, 12, 31, false)]
    [InlineData(1950, 1, 1, true)]
    [InlineData(2027, 11, 27, true)]
    [InlineData(2027, 11, 28, false)]
    public void AdmiteIngresosDesde1950HastaUnAnioDespuesDeHoy(int anio, int mes, int dia, bool valido)
    {
        var fecha = new DateTime(anio, mes, dia);
        if (valido) Assert.Equal(fecha, Crear(ingreso: fecha).FechaIngreso);
        else Assert.Throws<ReglaNegocioException>(() => Crear(ingreso: fecha));
    }
}
