using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using RRHH.Application.Asistencia;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.PostgreSql.Asistencia;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class RegistrarFeriadoTests
{
	private readonly FakeFeriadoRepository _repository = new FakeFeriadoRepository();

	[Fact]
	public void Ejecutar_FechaLibre_InsertaYNormalizaDatos()
	{
		var casoUso = new RegistrarFeriado(_repository);
		var dto = new RegistrarFeriadoDto
		{
			Fecha = new DateTime(2026, 7, 28, 18, 30, 0),
			Motivo = "  FIESTAS PATRIAS  "
		};

		ResultadoOperacion resultado = casoUso.Ejecutar(dto);

		Assert.True(resultado.Exitoso);
		Assert.Equal(1, dto.Id);
		Assert.Equal(new DateTime(2026, 7, 28), dto.Fecha);
		Assert.Equal("FIESTAS PATRIAS", dto.Motivo);
		Assert.Single(_repository.Registros);
	}

	[Fact]
	public void Ejecutar_MismoDiaConDistintaHora_RechazaDuplicado()
	{
		_repository.Registros.Add(
			Feriado.Reconstituir(271, new DateTime(2026, 1, 1, 11, 39, 43), "AÑO NUEVO"));
		var casoUso = new RegistrarFeriado(_repository);

		ResultadoOperacion resultado = casoUso.Ejecutar(new RegistrarFeriadoDto
		{
			Fecha = new DateTime(2026, 1, 1, 0, 0, 0),
			Motivo = "AÑO NUEVO DUPLICADO"
		});

		Assert.False(resultado.Exitoso);
		Assert.Equal("Ya a Agregado esa Fecha", resultado.Mensaje);
		Assert.Single(_repository.Registros);
	}

	[Theory]
	[InlineData("es-PE")]
	[InlineData("en-US")]
	public void Ejecutar_DeteccionDeDuplicadoNoDependeDelFormatoRegional(string culturaNombre)
	{
		CultureInfo culturaOriginal = Thread.CurrentThread.CurrentCulture;
		try
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(culturaNombre);
			_repository.Registros.Add(
				Feriado.Reconstituir(10, new DateTime(2026, 8, 6), "BATALLA DE JUNIN"));
			var casoUso = new RegistrarFeriado(_repository);

			ResultadoOperacion resultado = casoUso.Ejecutar(new RegistrarFeriadoDto
			{
				Fecha = new DateTime(2026, 8, 6, 9, 15, 0),
				Motivo = "OTRO REGISTRO"
			});

			Assert.False(resultado.Exitoso);
			Assert.Equal("Ya a Agregado esa Fecha", resultado.Mensaje);
		}
		finally
		{
			Thread.CurrentThread.CurrentCulture = culturaOriginal;
		}
	}

	[Fact]
	public async Task Ejecutar_DosAltasSimultaneasDelMismoDia_SoloPermiteUnRegistro()
	{
		var casoUso = new RegistrarFeriado(_repository);
		var barrera = new ManualResetEventSlim(false);

		Task<ResultadoOperacion> tarea1 = Task.Run(() =>
		{
			barrera.Wait();
			return casoUso.Ejecutar(new RegistrarFeriadoDto
			{
				Fecha = new DateTime(2026, 10, 8, 8, 0, 0),
				Motivo = "COMBATE DE ANGAMOS 1"
			});
		});

		Task<ResultadoOperacion> tarea2 = Task.Run(() =>
		{
			barrera.Wait();
			return casoUso.Ejecutar(new RegistrarFeriadoDto
			{
				Fecha = new DateTime(2026, 10, 8, 16, 0, 0),
				Motivo = "COMBATE DE ANGAMOS 2"
			});
		});

		barrera.Set();
		ResultadoOperacion[] resultados = await Task.WhenAll(tarea1, tarea2);

		Assert.Equal(1, resultados.Count(r => r.Exitoso));
		Assert.Equal(1, resultados.Count(r => !r.Exitoso && r.Mensaje == "Ya a Agregado esa Fecha"));
		Assert.Single(_repository.Registros);
	}

	[Fact]
	public void ElMapeoDeFeriadoCoincideConElEsquema()
	{
		Dictionary<string, string> columnas = LeerColumnasTabla(PostgreSqlFeriadoRepository.Tabla);

		Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaId));
		Assert.StartsWith("integer", columnas[PostgreSqlFeriadoRepository.ColumnaId]);

		Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaFecha));
		Assert.StartsWith("timestamp", columnas[PostgreSqlFeriadoRepository.ColumnaFecha]);

		Assert.True(columnas.ContainsKey(PostgreSqlFeriadoRepository.ColumnaMotivo));
		Assert.Equal(
			$"character varying({Feriado.LongitudMaximaMotivo})",
			columnas[PostgreSqlFeriadoRepository.ColumnaMotivo]);
	}

	private static Dictionary<string, string> LeerColumnasTabla(string nombreTabla)
	{
		string ruta = BuscarEsquema();
		var columnas = new Dictionary<string, string>();
		bool enTabla = false;

		foreach (string linea in File.ReadLines(ruta))
		{
			if (!enTabla)
			{
				if (linea == $"CREATE TABLE public.\"{nombreTabla}\" (")
				{
					enTabla = true;
				}
				continue;
			}

			if (linea.StartsWith(");"))
			{
				break;
			}

			Match match = Regex.Match(linea, @"^\s+""([^""]+)"" (.+?),?$");
			if (match.Success)
			{
				columnas[match.Groups[1].Value] = match.Groups[2].Value;
			}
		}

		Assert.NotEmpty(columnas);
		return columnas;
	}

	private static string BuscarEsquema()
	{
		for (DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory); dir != null; dir = dir.Parent)
		{
			string candidato = Path.Combine(dir.FullName, "BD", "schema.sql");
			if (File.Exists(candidato))
			{
				return candidato;
			}
		}

		throw new FileNotFoundException("No se encontró BD/schema.sql subiendo desde la carpeta de las pruebas.");
	}
}

