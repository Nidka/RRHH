using System;
using System.Threading;
using System.Windows.Forms;
using RRHH.Application.Catalogos;
using RRHH.Application.Seguridad;
using RRHH.Domain.Catalogos;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Catalogos;
using RRHH.PostgreSql.Seguridad;
using RRHH.Presentation.Catalogos;

namespace RecursosHumanos;

/// <summary>
/// Único lugar donde se crean las dependencias de las pantallas migradas a
/// MVP. Los formularios y presenters no crean repositorios por su cuenta.
/// </summary>
internal static class CompositionRoot
{
	// Diferida y sin guardar el error: si falta RRHH_POSTGRES_CONNECTION, el
	// usuario ve el mensaje real (no una TypeInitializationException) y puede
	// reintentar después de corregirla.
	private static readonly Lazy<PostgreSqlConnectionFactory> Conexiones =
		new Lazy<PostgreSqlConnectionFactory>(() => new PostgreSqlConnectionFactory(), LazyThreadSafetyMode.PublicationOnly);

	private static readonly Lazy<PostgreSqlExecutor> Database =
		new Lazy<PostgreSqlExecutor>(() => new PostgreSqlExecutor(Conexiones.Value), LazyThreadSafetyMode.PublicationOnly);

	/// <summary>Comprueba la conexión y que la base tenga el esquema RRHH.</summary>
	public static void VerificarBaseDeDatos()
	{
		Conexiones.Value.VerifySchema();
	}

	public static ObtenerAccesoUsuario CrearObtenerAccesoUsuario()
	{
		return new ObtenerAccesoUsuario(new PostgreSqlAccesoUsuarioRepository(Database.Value));
	}

	public static bool EstablecerContrasenaUsuario(string login, string password)
	{
		return new PostgreSqlAccesoUsuarioRepository(Database.Value)
			.EstablecerContrasena(login, password);
	}

	/// <summary>Crea un formulario FrmMant* de catálogo con su presenter conectado.</summary>
	public static TForm CrearCatalogo<TForm>(TipoCatalogo tipo)
		where TForm : Form, IFormularioCatalogo, new()
	{
		TForm form = new TForm();
		DefinicionCatalogo definicion = DefinicionesCatalogo.Definicion(tipo);
		ICatalogoRepository repository = new PostgreSqlCatalogoRepository(Database.Value, MapeosCatalogo.Para(tipo));
		_ = new CatalogoPresenter(
			form.Vista,
			definicion,
			new ListarCatalogo(repository),
			new GuardarItemCatalogo(definicion, repository),
			new EliminarItemCatalogo(repository));
		return form;
	}
}
