using System;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class FeriadoTests
{
	[Fact]
	public void Crear_TruncaHoraDeLaFechaYNormalizaMotivo()
	{
		var fechaConHora = new DateTime(2026, 7, 28, 15, 42, 19);

		Feriado feriado = Feriado.Crear(0, fechaConHora, "  FIESTAS PATRIAS  ");

		Assert.True(feriado.EsNuevo);
		Assert.Equal(new DateTime(2026, 7, 28), feriado.Fecha);
		Assert.Equal(TimeSpan.Zero, feriado.Fecha.TimeOfDay);
		Assert.Equal("FIESTAS PATRIAS", feriado.Motivo);
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("   ")]
	public void Validar_SinMotivo_DevuelveError(string motivo)
	{
		string error = Feriado.Validar(new DateTime(2026, 7, 28), motivo);

		Assert.Equal("Debe ingresar motivo.", error);
	}

	[Fact]
	public void Validar_FechaPorDefecto_DevuelveError()
	{
		string error = Feriado.Validar(default, "AÑO NUEVO");

		Assert.Equal("Debe seleccionar una fecha válida.", error);
	}

	[Fact]
	public void Validar_RespetaLongitudMaximaDelEsquema()
	{
		var fecha = new DateTime(2026, 12, 25);

		Assert.Null(Feriado.Validar(fecha, new string('A', 200)));
		Assert.Equal(
			"Motivo: no puede superar 200 caracteres.",
			Feriado.Validar(fecha, new string('A', 201)));
	}

	[Fact]
	public void Crear_ConMotivoInvalido_LanzaReglaNegocioException()
	{
		var ex = Assert.Throws<ReglaNegocioException>(() =>
			Feriado.Crear(0, new DateTime(2026, 5, 1), new string('X', 201)));

		Assert.Equal("Motivo: no puede superar 200 caracteres.", ex.Message);
	}

	[Fact]
	public void Reconstituir_PermiteRegistrosHistoricosSinMotivoOConHora()
	{
		var fechaHistorica = new DateTime(2023, 5, 1, 10, 27, 27);

		Feriado reconstituido = Feriado.Reconstituir(219, fechaHistorica, null);

		Assert.Equal(219, reconstituido.Id);
		Assert.Equal(fechaHistorica, reconstituido.Fecha);
		Assert.Equal(string.Empty, reconstituido.Motivo);
	}
}

