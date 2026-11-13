using System;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

/// <summary>RF-01: evita rangos inválidos, datos truncados y confusión entre empleados/edición.</summary>
public class AsignacionHorarioTests
{
    [Fact]
    public void UnDiaNormalizaHorasYConservaTextoHastaCincuentaCaracteres()
    {
        var a = Crear(1, 0, 10, 10, new string('x', 50));
        Assert.Equal(1, a.Rango.Dias);
        Assert.Equal(new DateTime(2026, 11, 10), a.Rango.Desde);
        Assert.Equal(50, a.Documento.Length);
    }

    [Theory]
    [InlineData(0, 0, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 0, 0)]
    public void RechazaIdentificadoresInvalidos(int empleado, int numero, int horario) =>
        Assert.Throws<ReglaNegocioException>(() => new AsignacionHorario(empleado, numero,
            RangoFechas.Crear(new DateTime(2026,11,10), new DateTime(2026,11,12)), horario, null, null));

    [Theory]
    [InlineData(10, 12, true)]
    [InlineData(9, 13, true)]
    [InlineData(11, 11, true)]
    [InlineData(8, 10, true)]
    [InlineData(12, 14, true)]
    [InlineData(8, 9, false)]
    [InlineData(13, 14, false)]
    public void DetectaTodosLosCrucesInclusivos(int desde, int hasta, bool esperado) =>
        Assert.Equal(esperado, Crear(1, 0, desde, hasta).EnConflictoCon(Crear(1, 5, 10, 12)));

    [Fact]
    public void OtroEmpleadoYLaPropiaEdicionNoBloquean()
    {
        Assert.False(Crear(2, 0, 10, 12).EnConflictoCon(Crear(1, 1, 10, 12)));
        Assert.False(Crear(1, 7, 9, 13).EnConflictoCon(Crear(1, 7, 10, 12)));
        Assert.True(Crear(1, 8, 9, 13).EnConflictoCon(Crear(1, 7, 10, 12)));
    }

    [Fact]
    public void NoTruncaDocumentoNiSisgedo()
    {
        Assert.Throws<ReglaNegocioException>(() => Crear(1, 0, 10, 12, new string('x', 51)));
        Assert.Throws<ReglaNegocioException>(() => new AsignacionHorario(1, 0,
            RangoFechas.Crear(DateTime.Today, DateTime.Today), 1, null, new string('x', 51)));
    }

    private static AsignacionHorario Crear(int empleado, int numero, int desde, int hasta, string documento = null) =>
        new AsignacionHorario(empleado, numero, RangoFechas.Crear(new DateTime(2026, 11, desde, 18, 0, 0),
            new DateTime(2026, 11, hasta, 19, 0, 0)), 1, documento, null);
}
