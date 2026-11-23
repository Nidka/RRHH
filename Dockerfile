FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY Software/Directory.Build.props Software/Directory.Build.targets Software/
COPY Software/lib/resource-runtime/ Software/lib/resource-runtime/
COPY Software/RRHH.Domain/ Software/RRHH.Domain/
COPY Software/RRHH.Application/ Software/RRHH.Application/
COPY Software/RRHH.PostgreSql/ Software/RRHH.PostgreSql/
COPY Software/RRHH.Web/ Software/RRHH.Web/
RUN dotnet publish Software/RRHH.Web/RRHH.Web.csproj -c Release -o /app --self-contained false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8080
COPY --from=build /app/ ./
USER app
EXPOSE 8080
ENTRYPOINT ["dotnet", "RRHH.Web.dll"]
