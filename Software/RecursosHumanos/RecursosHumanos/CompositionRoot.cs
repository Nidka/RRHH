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

using RRHH.Application.Teletrabajo;
using RRHH.PostgreSql.Teletrabajo;
using RRHH.Presentation.Teletrabajo;

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

    /// <summary>Conecta la consulta tipada de días remotos al calendario laboral.</summary>
    public static FrmReporteTeletrabajo CrearReporteTeletrabajo()
    {
        var repositorio = new PostgreSqlReporteTeletrabajoRepository(Database.Value);
        var feriados = new PostgreSqlFeriadoRepository(Database.Value);
        var vista = new FrmReporteTeletrabajo();
        _ = new ReporteTeletrabajoPresenter(vista, new ReportarDiasTeletrabajo(repositorio, feriados));
        return vista;
    }

    /// <summary>
    /// RF-16: conecta el reporte de personal en teletrabajo total o parcial; reutiliza el conteo de días remotos de RF-14
    /// y el calendario laboral.
    /// </summary>
    public static FrmClasificacionTeletrabajo CrearClasificacionTeletrabajo()
    {
        var repositorio = new PostgreSqlReporteTeletrabajoRepository(Database.Value);
        var feriados = new PostgreSqlFeriadoRepository(Database.Value);
        var vista = new FrmClasificacionTeletrabajo();
        _ = new ClasificacionTeletrabajoPresenter(vista,
            new ReportarTeletrabajoTotalOParcial(new ReportarDiasTeletrabajo(repositorio, feriados), feriados));
        return vista;
    }

    /// <summary>Conecta la vista pasiva de teletrabajo a sus casos de uso.</summary>
    public static FrmTeletrabajo CrearTeletrabajo()
    {
        var repositorio = new PostgreSqlTeletrabajoRepository(Database.Value);
        var vista = new FrmTeletrabajo();
        _ = new TeletrabajoPresenter(vista, new RegistrarPeriodoTeletrabajo(repositorio),
            new ListarPeriodosTeletrabajo(repositorio));
        return vista;
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
	/// Crea la validación de permisos que usa FrmPermiso al guardar: RF-03 (sin permisos solapados, en lugar de
	/// <c>RRHHClass.ExistePermiso</c>) y RF-06 (licencia de una vez por año), desde un único punto.
	/// </summary>
	public static ValidarPermiso CrearValidarPermiso()
	{
		IPermisoRepository repository = new PostgreSqlPermisoRepository(Database.Value);
		return new ValidarPermiso(
			new ValidarPermisoSinSolapamiento(repository),
			new ValidarLicenciaUnaVezPorAnio(repository));
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
	/// Crea el reporte RF-18 de ausencias por periodo con su presenter conectado. Reemplaza el criterio de
	/// <c>RRHHClass.spRRHH_RepPermisos</c> (solo fecha de inicio) por el solapamiento de fechas inclusivas.
	/// </summary>
	public static FrmRepAusencias CrearRepAusencias()
	{
		FrmRepAusencias form = new FrmRepAusencias();
		_ = new RepAusenciasPresenter(
			form,
			new ReportarAusenciasPorPeriodo(new PostgreSqlAusenciasRepository(Database.Value)));
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

    /// <summary>Compone RF-01 con repositorios PostgreSQL específicos y catálogo TEC-001.</summary>
    public static FrmHorarioEsp CrearAsignacionHorario(int empleado, int numero = 0)
    {
        var repo = new PostgreSqlHorarioTemporalRepository(Database.Value);
        var vista = new FrmHorarioEsp { idEmpleado=empleado, Npermiso=numero };
        _ = new AsignacionHorarioPresenter(vista,new ObtenerDatosAsignacion(repo),
            new ListarHorarios(new PostgreSqlHorarioRepository(Database.Value)),new AsignarHorarioPorPeriodo(repo));
        return vista;
    }

    /// <summary>Compone RF-02 sobre las asignaciones conservadas por RF-01, sin escrituras al consultar.</summary>
    public static FrmConsultaHorarioEsp CrearHistoricoHorarios(int empleado)
    {
        var repo=new PostgreSqlHorarioTemporalRepository(Database.Value);
        var vista=new FrmConsultaHorarioEsp { idEmpleado=empleado };
        _=new HistoricoHorariosPresenter(vista,new ObtenerDatosAsignacion(repo),
            new ConsultarHistoricoHorarios(repo),new EliminarAsignacionHorario(repo));
        return vista;
    }
}
