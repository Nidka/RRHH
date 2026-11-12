using System;
using System.Threading;
using System.Windows.Forms;
using RRHH.Application.Asistencia;
using RRHH.Application.Catalogos;
using RRHH.Application.Seguridad;
using RRHH.Domain.Catalogos;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Asistencia;
using RRHH.PostgreSql.Catalogos;
using RRHH.PostgreSql.Seguridad;
using RRHH.Presentation.Asistencia;
using RRHH.Presentation.Catalogos;
using RRHH.Application.Permisos;
using RRHH.Domain.Permisos;
using RRHH.PostgreSql.Permisos;
using RRHH.Presentation.Permisos;

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
    /// <summary>Compone consulta y editor de motivos; evita crear dependencias desde las vistas.</summary>
    public static FrmMotivoPermiso CrearMotivosPermiso()
    {
        int.TryParse(RRHH.IdROl, out int rol);
        var acceso = new AccesoMotivosPermiso(rol);
        var repository = new PostgreSqlMotivoPermisoRepository(Database.Value);
        var tipos = new PostgreSqlCatalogoRepository(Database.Value, MapeosCatalogo.Para(TipoCatalogo.TipoPermiso));
        var form = new FrmMotivoPermiso();
        form.ConfigurarEditor((tipo, id) =>
        {
            using (var editor = CrearEditorMotivoPermiso(repository, acceso, tipo, id))
                return editor.ShowDialog(form) == DialogResult.OK;
        });
        _ = new MotivosPermisoPresenter(form, new ListarCatalogo(tipos),
            new ListarMotivosPermiso(repository, acceso), new EliminarMotivoPermiso(repository, acceso));
        return form;
    }

    private static FrmMantMotivo CrearEditorMotivoPermiso(IMotivoPermisoRepository repository,
        AccesoMotivosPermiso acceso, int tipo, int? id)
    {
        var form = new FrmMantMotivo { idTipo = tipo, idMotivo = id ?? 0 };
        _ = new MotivoPermisoEditorPresenter(form, new ObtenerMotivoPermiso(repository, acceso),
            new GuardarMotivoPermiso(repository, acceso));
        return form;
    }

    /// <summary>Compone listado y editor modal de horarios sobre un repositorio específico.</summary>
    public static FrmHorarios CrearHorarios()
    {
        var repository = new PostgreSqlHorarioRepository(Database.Value);
        var form = new FrmHorarios();
        form.ConfigurarEditor(id =>
        {
            using (var editor = CrearEditorHorario(repository, id))
                return editor.ShowDialog(form) == DialogResult.OK;
        });
        _ = new HorariosPresenter(form, new ListarHorarios(repository), new EliminarHorario(repository));
        return form;
    }

    private static FrmMantHorarios CrearEditorHorario(IHorarioRepository repository, int? id)
    {
        var form = new FrmMantHorarios { CodHorario = id ?? 0 };
        _ = new HorarioEditorPresenter(form, new ObtenerHorario(repository), new GuardarHorario(repository));
        return form;
    }

	/// <summary>
	/// Crea la validación RF-03 (sin permisos solapados) que usa FrmPermiso en lugar de
	/// <c>RRHHClass.ExistePermiso</c>.
	/// </summary>
	public static ValidarPermisoSinSolapamiento CrearValidarPermiso()
	{
		return new ValidarPermisoSinSolapamiento(new PostgreSqlPermisoRepository(Database.Value));
	}

	/// <summary>Crea el formulario de gestión de feriados con su presenter conectado.</summary>
	public static FrmFeriado CrearFeriado()
	{
		FrmFeriado form = new FrmFeriado();
		IFeriadoRepository repository = new PostgreSqlFeriadoRepository(Database.Value);
		_ = new FeriadoPresenter(
			form,
			new ListarFeriados(repository),
			new RegistrarFeriado(repository),
			new EliminarFeriado(repository));
		return form;
	}

	/// <summary>
	/// Crea el cálculo RF-17 de días no laborables (fines de semana y feriados) que usa el reporte
	/// general de asistencias en lugar de contar solo sábados y domingos.
	/// </summary>
	public static CalcularDiasNoLaborables CrearCalcularDiasNoLaborables()
	{
		return new CalcularDiasNoLaborables(new PostgreSqlFeriadoRepository(Database.Value));
	}
}
