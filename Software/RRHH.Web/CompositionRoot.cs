using System.Threading.RateLimiting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using RRHH.Application.Asistencia;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;
using RRHH.Application.Seguridad;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Catalogos;
using RRHH.Domain.Permisos;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Asistencia;
using RRHH.PostgreSql.Catalogos;
using RRHH.PostgreSql.Permisos;
using RRHH.PostgreSql.Seguridad;
using RRHH.PostgreSql.Teletrabajo;

/// <summary>Conecta el host web con los casos de uso y repositorios de T3.</summary>
internal static class CompositionRoot
{
    internal const string PoliticaAusencias = "ConsultarAusencias";
    internal const string PoliticaHorarios = "GestionarHorarios";
    internal const string PoliticaMotivos = "GestionarMotivos";
    internal const string PoliticaAsistencia = "ConsultarAsistencia";
    internal const string PoliticaVacaciones = "ConsultarVacaciones";
    internal const string PoliticaPermisos = "GestionarPermisos";
    internal const string RolRrhh = "rrhh:rol";

    public static void Configurar(WebApplicationBuilder builder)
    {
        var roles = (builder.Configuration["RRHH_WEB_ROLES"] ?? "")
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(int.Parse).ToHashSet();
        builder.Services.AddSingleton(new RolesOperador(roles));
        var autoservicio=(builder.Configuration["RRHH_WEB_ROLES_AUTOCONSULTA"] ?? "")
            .Split(',',StringSplitOptions.RemoveEmptyEntries|StringSplitOptions.TrimEntries).Select(int.Parse).ToHashSet();
        if(roles.Overlaps(autoservicio)) throw new InvalidOperationException("Los roles de operador y autoconsulta deben ser distintos.");
        builder.Services.AddSingleton(new RolesAutoservicio(autoservicio));
        builder.Services.AddScoped<IUsuarioEmpleadoRepository,PostgreSqlUsuarioEmpleadoRepository>();
        builder.Services.AddSingleton(_ => new PostgreSqlExecutor(
            new PostgreSqlConnectionFactory(builder.Configuration["RRHH_WEB_POSTGRES"]
                ?? throw new InvalidOperationException("Configure RRHH_WEB_POSTGRES para este host."))));
        builder.Services.AddScoped(sp => new ObtenerAccesoUsuario(
            new PostgreSqlAccesoUsuarioRepository(sp.GetRequiredService<PostgreSqlExecutor>())));
        builder.Services.AddScoped<PostgreSqlTeletrabajoRepository>();
        builder.Services.AddScoped<PostgreSqlFeriadoRepository>();
        builder.Services.AddScoped(sp=>new ConsolidarAsistencia(new PostgreSqlAsistenciaConsolidadaRepository(sp.GetRequiredService<PostgreSqlExecutor>())));
        var diasVacaciones = decimal.Parse(builder.Configuration["RRHH_VACACIONES_DIAS_ANUALES"] ?? "30",
            System.Globalization.CultureInfo.InvariantCulture);
        builder.Services.AddScoped(sp => new ReportarVacacionesGeneradas(
            new PostgreSqlIngresoVacacionesRepository(sp.GetRequiredService<PostgreSqlExecutor>()),
            new RRHH.Domain.Asistencia.RegimenVacacionesPiloto(diasVacaciones)));
        builder.Services.AddScoped(sp => new ConsultarSaldoVacaciones(
            new PostgreSqlSaldoVacacionesRepository(sp.GetRequiredService<PostgreSqlExecutor>()),
            new RRHH.Domain.Asistencia.RegimenVacacionesPiloto(diasVacaciones)));
        builder.Services.AddScoped<ConsultarMisVacaciones>();
        builder.Services.AddScoped(sp => new ConsultarVacacionesTruncas(
            new PostgreSqlIngresoVacacionesRepository(sp.GetRequiredService<PostgreSqlExecutor>()),
            new RRHH.Domain.Asistencia.RegimenVacacionesPiloto(diasVacaciones)));
        builder.Services.AddScoped(sp=>new ReportarSaldoVacaciones(new PostgreSqlReporteVacacionesRepository(
            sp.GetRequiredService<PostgreSqlExecutor>()),new RRHH.Domain.Asistencia.RegimenVacacionesPiloto(diasVacaciones)));
        builder.Services.AddScoped(sp => new ReportarAsistenciaConFeriados(
            new PostgreSqlFechasAsistenciaRepository(sp.GetRequiredService<PostgreSqlExecutor>()),
            sp.GetRequiredService<PostgreSqlFeriadoRepository>()));
        builder.Services.AddScoped(sp => new RegistrarPeriodoTeletrabajo(sp.GetRequiredService<PostgreSqlTeletrabajoRepository>()));
        builder.Services.AddScoped(sp => new ListarPeriodosTeletrabajo(sp.GetRequiredService<PostgreSqlTeletrabajoRepository>()));
        builder.Services.AddScoped(sp =>
        {
            var db = sp.GetRequiredService<PostgreSqlExecutor>();
            return new ReportarDiasTeletrabajo(new PostgreSqlReporteTeletrabajoRepository(db),
                sp.GetRequiredService<PostgreSqlFeriadoRepository>());
        });
        builder.Services.AddScoped(sp => new ReportarTeletrabajoTotalOParcial(
            sp.GetRequiredService<ReportarDiasTeletrabajo>(), sp.GetRequiredService<PostgreSqlFeriadoRepository>()));
        builder.Services.AddScoped(sp => new ReportarAusenciasPorPeriodo(
            new PostgreSqlAusenciasRepository(sp.GetRequiredService<PostgreSqlExecutor>())));
        builder.Services.AddScoped<PostgreSqlHorarioTemporalRepository>();
        builder.Services.AddScoped(sp => new AsignarHorarioPorPeriodo(sp.GetRequiredService<PostgreSqlHorarioTemporalRepository>()));
        builder.Services.AddScoped(sp => new ConsultarHistoricoHorarios(sp.GetRequiredService<PostgreSqlHorarioTemporalRepository>()));
        builder.Services.AddScoped(sp => new ListarHorarios(
            new PostgreSqlHorarioRepository(sp.GetRequiredService<PostgreSqlExecutor>())));
        builder.Services.AddScoped<IMotivoPermisoRepository, PostgreSqlMotivoPermisoRepository>();
        builder.Services.AddScoped(sp => new PostgreSqlPermisoEscrituraRepository(
            sp.GetRequiredService<PostgreSqlExecutor>(), permitirSalidasAutorizadas: false,diasAnuales:diasVacaciones));
        builder.Services.AddScoped(sp => new GuardarPermiso(sp.GetRequiredService<PostgreSqlPermisoEscrituraRepository>()));
        builder.Services.AddScoped(sp => new ConsultarPermiso(sp.GetRequiredService<PostgreSqlPermisoEscrituraRepository>()));
        builder.Services.AddScoped(sp => new ListarCatalogo(new PostgreSqlCatalogoRepository(
            sp.GetRequiredService<PostgreSqlExecutor>(), MapeosCatalogo.Para(TipoCatalogo.TipoPermiso))));

        var seguridad = builder.Environment.IsDevelopment() ? CookieSecurePolicy.SameAsRequest : CookieSecurePolicy.Always;
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
        {
            options.Cookie.Name = "rrhh.web.sesion";
            options.Cookie.HttpOnly = true;
            options.Cookie.SameSite = SameSiteMode.Strict;
            options.Cookie.SecurePolicy = seguridad;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            options.SlidingExpiration = false;
            options.Events.OnRedirectToLogin = ctx => { ctx.Response.StatusCode = 401; return Task.CompletedTask; };
            options.Events.OnRedirectToAccessDenied = ctx => { ctx.Response.StatusCode = 403; return Task.CompletedTask; };
        });
        builder.Services.AddAuthorization(options =>
        {
            AgregarPoliticaPorRol(options, PoliticaAusencias, builder.Configuration["RRHH_WEB_ROLES_AUSENCIAS"]);
            AgregarPoliticaPorRol(options, PoliticaHorarios, builder.Configuration["RRHH_WEB_ROLES_HORARIOS"]);
            AgregarPoliticaPorRol(options, PoliticaAsistencia, builder.Configuration["RRHH_WEB_ROLES_ASISTENCIA"]);
            AgregarPoliticaPorRol(options, PoliticaVacaciones, builder.Configuration["RRHH_WEB_ROLES_VACACIONES"]);
            AgregarPoliticaPorRol(options, PoliticaPermisos, builder.Configuration["RRHH_WEB_ROLES_PERMISOS"]);
            var rolesMotivos = (builder.Configuration["RRHH_WEB_ROLES_MOTIVOS"] ?? "")
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            options.AddPolicy(PoliticaMotivos, policy => policy.RequireAssertion(context =>
                context.User.HasClaim(claim => claim.Type == RolRrhh && rolesMotivos.Contains(claim.Value)
                    && int.TryParse(claim.Value, out var id) && new AccesoMotivosPermiso(id).Permitido)));
        });
        builder.Services.AddAntiforgery(options =>
        {
            options.HeaderName = "X-RRHH-CSRF";
            options.Cookie.SecurePolicy = seguridad;
        });
        builder.Services.AddRateLimiter(options =>
        {
            options.RejectionStatusCode = 429;
            options.AddPolicy("login", ctx => RateLimitPartition.GetFixedWindowLimiter(
                ctx.Connection.RemoteIpAddress?.ToString() ?? "local", _ => new FixedWindowRateLimiterOptions
                {
                    PermitLimit = 10, Window = TimeSpan.FromMinutes(1), QueueLimit = 0
                }));
        });
    }

    private static void AgregarPoliticaPorRol(AuthorizationOptions opciones, string politica, string configuracion)
    {
        var roles = (configuracion ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        opciones.AddPolicy(politica, policy => policy.RequireAssertion(context =>
            context.User.HasClaim(claim => claim.Type == RolRrhh && roles.Contains(claim.Value))));
    }
}

/// <summary>Roles RRHH habilitados explícitamente para el piloto. Una lista vacía deniega el acceso.</summary>
internal sealed record RolesOperador(HashSet<int> Ids)
{
    public bool Contiene(int id) => Ids.Contains(id);
}
/// <summary>Roles exclusivos de empleado; no heredan permisos del operador.</summary>
internal sealed record RolesAutoservicio(HashSet<int> Ids)
{
    public bool Contiene(int id)=>Ids.Contains(id);
}
