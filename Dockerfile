# Imagen del host web de RRHH (ASP.NET Core 8). Se compila desde la raíz del repositorio:
#   docker build -t rrhh-web .
# Solo se copian los proyectos que la web compila: el WinForms y las DLL licenciadas no entran en la imagen.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS compilacion
WORKDIR /src
COPY Software/Directory.Build.props Software/Directory.Build.targets Software/
COPY Software/lib/resource-runtime Software/lib/resource-runtime
# Primero solo los .csproj: la restauración de paquetes queda en caché mientras no cambien las dependencias.
COPY Software/RRHH.Domain/RRHH.Domain.csproj Software/RRHH.Domain/
COPY Software/RRHH.Application/RRHH.Application.csproj Software/RRHH.Application/
COPY Software/RRHH.Web/RRHH.Web.csproj Software/RRHH.Web/
RUN dotnet restore Software/RRHH.Web/RRHH.Web.csproj
COPY Software/RRHH.Domain Software/RRHH.Domain
COPY Software/RRHH.Application Software/RRHH.Application
COPY Software/RRHH.PostgreSql Software/RRHH.PostgreSql
COPY Software/RRHH.Web Software/RRHH.Web
RUN dotnet publish Software/RRHH.Web/RRHH.Web.csproj -c Release -o /app --no-restore --no-self-contained \
    && rm -rf /app/*.pdb

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS ejecucion
WORKDIR /app
COPY --from=compilacion /app .
ENV ASPNETCORE_ENVIRONMENT=Production \
    RRHH_WEB_TRUST_PROXY=false \
    DOTNET_gcServer=0
# Usuario sin privilegios (incluido en las imágenes de .NET 8).
USER app
EXPOSE 8080
# La plataforma define PORT (Render); sin ella se usa 8080.
CMD ["sh", "-c", "ASPNETCORE_URLS=http://+:${PORT:-8080} exec dotnet RRHH.Web.dll"]
HEALTHCHECK --interval=30s --timeout=5s --start-period=20s --retries=3 \
    CMD ["bash", "-c", "exec 3<>/dev/tcp/127.0.0.1/${PORT:-8080} && printf 'GET /salud HTTP/1.0\\r\\n\\r\\n' >&3 && head -n1 <&3 | grep -q ' 200 '"]
