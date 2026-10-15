using RRHH.Application.Catalogos;
using RRHH.Domain.Catalogos;
using RRHH.Presentation.Catalogos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Catalogos;

public class CatalogoPresenterTests
{
	private readonly FakeCatalogoRepository _repository = new FakeCatalogoRepository();
	private readonly FakeCatalogoView _view = new FakeCatalogoView();

	private void Iniciar(TipoCatalogo tipo)
	{
		DefinicionCatalogo definicion = DefinicionesCatalogo.Definicion(tipo);
		_ = new CatalogoPresenter(
			_view,
			definicion,
			new ListarCatalogo(_repository),
			new GuardarItemCatalogo(definicion, _repository),
			new EliminarItemCatalogo(_repository));
	}

	private void IniciarEstadoCivil()
	{
		_repository.Registros.Add(ItemCatalogo.Reconstituir(1, "Soltero", "S"));
		_repository.Registros.Add(ItemCatalogo.Reconstituir(2, "Casado", "C"));
		Iniciar(TipoCatalogo.EstadoCivil);
	}

	[Fact]
	public void AlIniciar_ConfiguraLasColumnasSegunLaDefinicion()
	{
		Iniciar(TipoCatalogo.TipoTrabajador);

		Assert.True(_view.ColumnasConfiguradas);
		Assert.Equal("Descripción", _view.EtiquetaDescripcion);
		Assert.Equal("Observaciones", _view.EtiquetaExtra);
	}

	[Fact]
	public void AlIniciar_CatalogoSinExtra_OcultaLaColumnaExtra()
	{
		Iniciar(TipoCatalogo.TipoDocumentoIdentidad);

		Assert.Null(_view.EtiquetaExtra);
	}

	[Fact]
	public void Buscar_MuestraLosRegistrosQueCoincidenConElFiltro()
	{
		IniciarEstadoCivil();
		_view.Filtro = "sol";

		_view.Buscar();

		ItemCatalogoDto unico = Assert.Single(_view.Mostrados);
		Assert.Equal("Soltero", unico.Descripcion);
		Assert.Equal("S", unico.Extra);
	}

	[Fact]
	public void Validar_FilaSinDescripcion_DevuelveError()
	{
		IniciarEstadoCivil();

		CatalogoFilaEventArgs args = _view.Validar(new ItemCatalogoDto());

		Assert.Equal("Debe ingresar descripción.", args.Error);
	}

	[Fact]
	public void Guardar_FilaNueva_AsignaCodigoEInforma()
	{
		IniciarEstadoCivil();
		var fila = new ItemCatalogoDto { Descripcion = " Viudo ", Extra = "V" };

		CatalogoFilaEventArgs args = _view.Guardar(fila);

		Assert.False(args.Cancelar);
		Assert.Equal(3, fila.Id);
		Assert.Equal("Viudo", fila.Descripcion);
		Assert.StartsWith("Se insertó", Assert.Single(_view.Informaciones));
		Assert.Equal(3, _repository.Registros.Count);
	}

	[Fact]
	public void Guardar_FilaExistente_Actualiza()
	{
		IniciarEstadoCivil();

		_view.Guardar(new ItemCatalogoDto { Id = 2, Descripcion = "Casada", Extra = "C" });

		Assert.Equal("Casada", _repository.Registros[1].Descripcion);
		Assert.StartsWith("Se actualizó", Assert.Single(_view.Informaciones));
	}

	[Fact]
	public void Guardar_FilaInvalida_MuestraErrorYNoGuarda()
	{
		IniciarEstadoCivil();

		CatalogoFilaEventArgs args = _view.Guardar(new ItemCatalogoDto { Descripcion = "" });

		Assert.True(args.Cancelar);
		Assert.Single(_view.Errores);
		Assert.Equal(2, _repository.Registros.Count);
	}

	[Fact]
	public void Guardar_RegistroEliminadoPorOtroUsuario_MuestraErrorYCancela()
	{
		IniciarEstadoCivil();
		_repository.Registros.RemoveAll(r => r.Id == 2);

		CatalogoFilaEventArgs args = _view.Guardar(new ItemCatalogoDto { Id = 2, Descripcion = "Casada", Extra = "C" });

		Assert.True(args.Cancelar);
		Assert.StartsWith("El registro ya no existe", Assert.Single(_view.Errores));
		Assert.Empty(_view.Informaciones);
	}

	[Fact]
	public void Guardar_ErrorDeBaseDeDatos_MuestraErrorYCancela()
	{
		IniciarEstadoCivil();
		_repository.FallarAlGuardar = true;

		CatalogoFilaEventArgs args = _view.Guardar(new ItemCatalogoDto { Descripcion = "Viudo" });

		Assert.True(args.Cancelar);
		Assert.Equal("No se pudo guardar el registro: Conexión perdida", Assert.Single(_view.Errores));
	}

	[Fact]
	public void Eliminar_SinConfirmacion_NoElimina()
	{
		IniciarEstadoCivil();
		_view.RespuestaConfirmacion = false;

		CatalogoFilaEventArgs args = _view.Eliminar(new ItemCatalogoDto { Id = 1, Descripcion = "Soltero", Extra = "S" });

		Assert.True(args.Cancelar);
		Assert.Contains("Abreviatura=S", Assert.Single(_view.Confirmaciones));
		Assert.Equal(2, _repository.Registros.Count);
	}

	[Fact]
	public void Eliminar_Confirmado_Elimina()
	{
		IniciarEstadoCivil();

		CatalogoFilaEventArgs args = _view.Eliminar(new ItemCatalogoDto { Id = 1, Descripcion = "Soltero" });

		Assert.False(args.Cancelar);
		Assert.DoesNotContain(_repository.Registros, e => e.Id == 1);
	}

	[Fact]
	public void Eliminar_RegistroEnUso_MuestraErrorYCancela()
	{
		IniciarEstadoCivil();
		_repository.IdsEnUso.Add(1);

		CatalogoFilaEventArgs args = _view.Eliminar(new ItemCatalogoDto { Id = 1, Descripcion = "Soltero" });

		Assert.True(args.Cancelar);
		Assert.Equal("Se hace referencia a este registro en otra tabla.", Assert.Single(_view.Errores));
		Assert.Equal(2, _repository.Registros.Count);
	}
}
