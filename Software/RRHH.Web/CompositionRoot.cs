using System.Threading.RateLimiting;
using Microsoft.AspNetCore.Authentication.Cookies;
using RRHH.Application.Permisos;
using RRHH.Application.Seguridad;
using RRHH.Application.Teletrabajo;
using RRHH.PostgreSql;
using RRHH.PostgreSql.Asistencia;
using RRHH.PostgreSql.Permisos;
using RRHH.PostgreSql.Seguridad;
using RRHH.PostgreSql.Teletrabajo;

/// <summary>Conecta el host web con los casos de uso y repositorios de T3.</summary>
internal static class CompositionRoot
{
    internal const string PoliticaAusencias = "ConsultarAusencias";
    internal const string RolRrhh = "rrhh:rol";

    public static void Configurar(WebApplicationBuilder builder)
    {
        var roles = (builder.Configuration["RRHH_WEB_ROLES"] ?? "")
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(int.Parse).ToHashSet();
        builder.Services.AddSingleton(new RolesOperador(roles));
        builder.Services.AddSingleton(_ => new PostgreSqlExecutor(
            new PostgreSqlConnectionFactory(builder.Configuration["RRHH_WEB_POSTGRES"]
                ?? throw new InvalidOperationException("Configure RRHH_WEB_POSTGRES para este host."))));
        builder.Services.AddScoped(sp => new ObtenerAccesoUsuario(
            new PostgreSqlAccesoUsuarioRepository(sp.GetRequiredService<PostgreSqlExecutor>())));
        builder.Services.AddScoped<PostgreSqlTeletrabajoRepository>();
        builder.Services.AddScoped<PostgreSqlFeriadoRepository>();
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
        var rolesAusencias = (builder.Configuration["RRHH_WEB_ROLES_AUSENCIAS"] ?? "")
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        builder.Services.AddAuthorization(options => options.AddPolicy(PoliticaAusencias, policy =>
            policy.RequireAssertion(context =>
                context.User.HasClaim(claim => claim.Type == RolRrhh && rolesAusencias.Contains(claim.Value)))));
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
}

/// <summary>Roles RRHH habilitados explícitamente para el piloto. Una lista vacía deniega el acceso.</summary>
internal sealed record RolesOperador(HashSet<int> Ids)
{
    public bool Contiene(int id) => Ids.Contains(id);
}
