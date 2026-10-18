using System;
using System.Globalization;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class HorarioTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("24:00:00")]
    [InlineData("29:30:00")]
    [InlineData("12:60:00")]
    [InlineData("-01:00:00")]
    [InlineData("07:30:00.5")]
    public void RechazaHorasInvalidas(string hora) => Assert.Throws<ReglaNegocioException>(() =>
        Horario.Crear(0, "Turno", hora, "12:00", "13:00", "17:00", true));

    [Theory]
    [InlineData("es-PE")]
    [InlineData("en-US")]
    [InlineData("fr-FR")]
    public void NormalizaSinDependerDeLaCultura(string cultura)
    {
        CultureInfo anterior = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(cultura);
            Horario horario = Horario.Crear(0, " Turno ", "7:30", "12:00:01", "13:00", "23:59:59", null);
            Assert.Equal("07:30:00", Horario.FormatearHora(horario.Ingreso1));
            Assert.Equal("Turno", horario.Descripcion);
            Assert.Null(horario.Estado);
        }
        finally { CultureInfo.CurrentCulture = anterior; }
    }

    [Fact]
    public void ConservaJornadaNocturnaSinInventarOrdenDeHoras()
    {
        Horario horario = Horario.Crear(1, "Noche", "22:00", "00:00", "00:30", "06:00", false);
        Assert.True(horario.Ingreso1 > horario.Salida2);
        Assert.False(horario.Estado);
    }

    [Fact]
    public void AdmiteDescripcionVaciaPeroRespetaLongitudDelEsquema()
    {
        Assert.Equal(string.Empty, Horario.Crear(0, null, "00:00", "00:00", "00:00", "00:00", true).Descripcion);
        Assert.Throws<ReglaNegocioException>(() => Horario.Crear(0, new string('x', 21), "00:00", "00:00", "00:00", "00:00", true));
    }
}
