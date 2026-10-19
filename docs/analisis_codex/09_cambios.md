# 9. CAMBIOS YA HECHOS

[Volver al índice](../analisis_codex.md). El historial local describe cambios entre commits del repositorio. Sin un hash/copia comparada del ejecutable original no se puede asegurar que cada diferencia sea respecto del original ni quién realizó su recuperación inicial. [README.md:1](../../README.md#L1).

| Commit(s) | Cambio documentado | Alcance / límite | Fuente actual con línea |
|---|---|---|---|
| b664942 / 136929b / 7418591 / e725cd6 | Incorporación/organización de fuentes recuperadas, exportación de esquema y acceso PostgreSQL inicial. | Base recuperada ya adaptada; e725cd6 no es certificado de fuente original intacto. | [README.md:1](../../README.md#L1); [Software/docs/ARQUITECTURA.md:27](../../Software/docs/ARQUITECTURA.md#L27) |
| 0a4b6a8 | Arquitectura MVP por capas y catálogos simples. | Existen definiciones, casos, presenters y repositorios; no equivale a migración total. | [Software/docs/adr/0001-mvp-sobre-capas.md:1](../../Software/docs/adr/0001-mvp-sobre-capas.md#L1); [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:54](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L54) |
| eeeb817 | Conexión .env/DB_*, autenticación, puentes PostgreSQL y portado de operaciones. | La ruta actual ya no se describe sólo como SQL Server; conserva Access y APIs heredadas. | [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:17](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L17); [Software/RecursosHumanos/RecursosHumanos/Module1.cs:11](../../Software/RecursosHumanos/RecursosHumanos/Module1.cs#L11) |
| cc74aa0 / f39f4b1 / dacb87f / 6f7feb8 | TEC-003: casos, persistencia, presenter/vista y pruebas de feriados; integración PR #1. | Catálogo migrado; no demuestra cómputo RF-17. | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:15](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L15); [Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs:10](../../Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs#L10) |
| 01db40b / fe1a00a / 06ca7f6 | TEC-004: motivos por capas, protección de escritura/referencias, contratos XML; integración PR #2. | Carga separada del guardado; alta/baja ya tienen implementación, con QA/política pendientes. | [Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs:7](../../Software/RRHH.Presentation/Permisos/MotivoPermisoEditorPresenter.cs#L7); [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:112](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L112) |
| 138dbce | TEC-001: listado/editor de horarios por MVP, dominio/casos/repositorio, cuatro referencias de borrado y conexión desde las dos entradas MainMDI. | No creó HorarioTemporal ni su consulta heredada. Los cambios técnicos deben distinguirse de las funciones ya existentes. | [Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs:96](../../Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs#L96); [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:91](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L91); [Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977) |
| f713383 / fd12b80 y otros docs | Organización T2, specs, reparto, evidencia y simplificación del encargo de diagramas. | Cambios de documentación, no implementación de los 18 RF. | [docs/t2/PLAN_EQUIPO.md:15](../../docs/t2/PLAN_EQUIPO.md#L15); [CONTRIBUTING.md:1](../../CONTRIBUTING.md#L1) |

## Historial local completo disponible

| Commit | Fecha con zona | Autor registrado | Asunto |
|---|---|---|---|
| b6649423327d8caadf97eca5df08add4c88a7153 | 2026-10-13T18:04:32-05:00 | Nidka | first commit |
| 136929b23a0d87060bc01318cb4136c9e1561e02 | 2026-10-13T18:07:29-05:00 | Nidka | Add safe PostgreSQL schema export workflow |
| 7418591bfa4d4b99f08afadbb25ef17fb77b76f8 | 2026-10-13T18:30:05-05:00 | Nidka | Organize source and add PostgreSQL startup access |
| e725cd65e4598a14beaeb1aa1c0e05541f9c0c8d | 2026-10-13T19:16:53-05:00 | Nidka | Actualización del proyecto RRHH |
| 0a4b6a864d04fa33da464f58fa379ec19ae74b36 | 2026-10-15T15:50:57-05:00 | Piero | Adoptar arquitectura MVP por capas y migrar los catálogos simples |
| eeeb81716ded9f1ce2a0ef122dfa1e3bd9a29c5e | 2026-10-15T20:30:06-05:00 | Nidka | Migracion de conexion a postgres |
| f713383bbba3a545c1e48f4276aae4b2a2772cde | 2026-10-17T22:26:05-05:00 | helcorp | docs(T2): organizar equipo, specs y prompts de refactorización |
| 1bdb274474480de866a88f3a553568101fa7973e | 2026-10-18T00:07:55-05:00 | Piero | docs(TEC-003): caracterizar feriados y completar plan |
| cc74aa00aadfd44b1d396fc409c4f45390480406 | 2026-10-18T00:07:55-05:00 | Piero | refactor(TEC-003): extraer casos de uso y persistencia de feriados |
| f39f4b128f8ea6c3a136b1530ca5f75ef4db19a4 | 2026-10-18T00:07:55-05:00 | Piero | refactor(TEC-003): conectar vista y presenter de feriados |
| dacb87f890c6128246db6772d19c9ad1c1645740 | 2026-10-18T00:07:55-05:00 | Piero | test(TEC-003): cubrir duplicados y documentar QA |
| b24bcf8a7f44870413dbcc8ac484e94ca0c1811a | 2026-10-18T00:09:23-05:00 | Piero | docs(TEC-003): actualizar estado de CR-TEC-003 y trazabilidad de commits |
| 6f7feb869ddb7022b18871d6b2be31d3f53adf13 | 2026-10-18T00:18:23-05:00 | Francisco Kadin Valera Lizarraga | Merge pull request #1 from Nidka/refactor/tec-003-feriados |
| 01db40b46edd0cef7dcedc4a1537d3716e7034eb | 2026-10-17T23:23:29-05:00 | Evelyn Victoria Rodriguez Cardozo | refactor(TEC-004): separar motivos de permiso por capas y proteger escrituras |
| 0b8509ab7f6b247737b80d78f792429888ec8e9e | 2026-10-17T23:24:07-05:00 | Evelyn Victoria Rodriguez Cardozo | docs(TEC-004): registrar diagramas, pruebas y guía de sustentación |
| fe1a00ad1d13cbfab7d1283c8b68ab118fe8e86f | 2026-10-18T00:44:29-05:00 | Evelyn Victoria Rodriguez Cardozo | docs(TEC-004): documentar contratos y acordar comentarios XML |
| 9a00a4ae0fa584634339d29945b4b1aa7b82d860 | 2026-10-18T00:44:58-05:00 | Evelyn Victoria Rodriguez Cardozo | merge(TEC-004): incorporar feriados desde main conservando motivos |
| 8efc50feeec64e9e55f0f0bff9850c48e2fa2620 | 2026-10-18T00:46:27-05:00 | Evelyn Victoria Rodriguez Cardozo | docs(TEC-004): registrar validación combinada y preparar revisión |
| a9c9f4d2b8a9b1c4224bac08bc4ef31196e1c99d | 2026-10-18T00:47:41-05:00 | Evelyn Victoria Rodriguez Cardozo | docs(TEC-004): vincular PR #2 y revisión pendiente de Frank |
| 06ca7f6d8e0561d5265bfa3107c3ce4e8c9634ee | 2026-10-18T00:58:04-05:00 | Frank Piero Mantilla Arqueros | Merge pull request #2 from Nidka/refactor/tec-004-motivos-permiso |
| fd12b80039f169787c69462699ade77e25689948 | 2026-10-18T14:24:16-05:00 | Evelyn Victoria Rodriguez Cardozo | docs(T2-04): simplificar entrega de diagramas y actualizar reparto |
| 138dbce6951d8472cfcbf1a8434d97d33c51234a | 2026-10-18T14:37:10-05:00 | Evelyn Victoria Rodriguez Cardozo | refactor(TEC-001): migrar horarios a MVP y repositorio PostgreSQL |

Fuente: consulta git log del repositorio local, corte 138dbce6951d8472cfcbf1a8434d97d33c51234a. Es metadato Git, por lo que su identificador verificable es el commit, no una línea de código. Los archivos y líneas de cada cambio funcional figuran en la tabla anterior. No se atribuyen aprobaciones que el log no registra.

## Cambios de las refactorizaciones localizados por diff


### 0a4b6a8

```text
0a4b6a8 Adoptar arquitectura MVP por capas y migrar los catálogos simples
 .gitignore                                         |   4 +
 CLAUDE.md                                          |  47 +++
 CONTRIBUTING.md                                    |  12 +
 README.md                                          |   9 +
 .../Catalogos/EliminarItemCatalogo.cs              |  27 ++
 .../Catalogos/GuardarItemCatalogo.cs               |  54 ++++
 .../Catalogos/ICatalogoRepository.cs               |  20 ++
 .../RRHH.Application/Catalogos/ItemCatalogoDto.cs  |  17 +
 .../RRHH.Application/Catalogos/ListarCatalogo.cs   |  27 ++
 .../Comun/RegistroEnUsoException.cs                |  15 +
 .../RRHH.Application/Comun/ResultadoOperacion.cs   |  20 ++
 Software/RRHH.Application/RRHH.Application.csproj  |  11 +
 .../RRHH.Application/Seguridad/AccesoUsuario.cs    |  34 ++
 .../Seguridad/IAccesoUsuarioRepository.cs          |  11 +
 .../Seguridad/ObtenerAccesoUsuario.cs              |  32 ++
 .../RRHH.Domain/Catalogos/DefinicionCatalogo.cs    |  78 +++++
 .../RRHH.Domain/Catalogos/DefinicionesCatalogo.cs  |  36 +++
 Software/RRHH.Domain/Catalogos/ItemCatalogo.cs     |  58 ++++
 Software/RRHH.Domain/Catalogos/TipoCatalogo.cs     |  16 +
 .../RRHH.Domain/Comun/ReglaNegocioException.cs     |  15 +
 Software/RRHH.Domain/RRHH.Domain.csproj            |   8 +
 .../RRHH.PostgreSql/Catalogos/MapeoCatalogo.cs     |  37 +++
 .../RRHH.PostgreSql/Catalogos/MapeosCatalogo.cs    |  50 +++
 .../Catalogos/PostgreSqlCatalogoRepository.cs      | 146 +++++++++
 .../Catalogos/ReferenciaCatalogo.cs                |  21 ++
 Software/RRHH.PostgreSql/IdentificadorSql.cs       |  30 ++
 .../RRHH.PostgreSql/PostgreSqlConnectionFactory.cs |  22 +-
 Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj    |   4 +-
 .../Seguridad/PostgreSqlAccesoUsuarioRepository.cs |  64 ++++
 .../Catalogos/CatalogoFilaEventArgs.cs             |  24 ++
 .../Catalogos/CatalogoPresenter.cs                 | 118 +++++++
 .../RRHH.Presentation/Catalogos/ICatalogoView.cs   |  38 +++
 .../RRHH.Presentation/RRHH.Presentation.csproj     |  13 +
 .../Arquitectura/DependenciasEntreCapasTests.cs    |  84 +++++
 .../RRHH.Tests/Catalogos/CatalogoPresenterTests.cs | 172 ++++++++++
 .../Catalogos/DefinicionCatalogoTests.cs           |  81 +++++
 .../RRHH.Tests/Catalogos/MapeosCatalogoTests.cs    | 143 +++++++++
 .../RRHH.Tests/Fakes/FakeCatalogoRepository.cs     |  63 ++++
 Software/RRHH.Tests/Fakes/FakeCatalogoView.cs      |  66 ++++
 Software/RRHH.Tests/RRHH.Tests.csproj              |  22 ++
 .../Seguridad/ObtenerAccesoUsuarioTests.cs         |  56 ++++
 Software/RRHH.sln                                  |  56 ++++
 Software/RecursosHumanos/RecursosHumanos.csproj    |   1 +
 .../RecursosHumanos/CompositionRoot.cs             |  55 ++++
 .../Data/PostgreSqlUserRepository.cs               |  64 ----
 .../RecursosHumanos/Data/UserAccess.cs             |  16 -
 .../RecursosHumanos/RecursosHumanos/FrmLogin.cs    |  20 +-
 .../RecursosHumanos/FrmMantCargos.cs               | 171 ++--------
 .../RecursosHumanos/FrmMantEstCivil.cs             | 171 ++--------
 .../RecursosHumanos/FrmMantGrupoSanguineo.cs       | 171 ++--------
 .../RecursosHumanos/FrmMantNacionalidades.cs       | 173 ++--------
 .../RecursosHumanos/FrmMantRegimen.cs              | 177 ++--------
 .../RecursosHumanos/FrmMantTipoDocIdent.cs         | 168 ++--------
 .../RecursosHumanos/FrmMantTipoEstudio.cs          | 170 ++--------
 .../RecursosHumanos/FrmMantTipoInst.cs             | 170 ++--------
 .../RecursosHumanos/FrmMantTipoPerm.cs             | 175 ++--------
 .../RecursosHumanos/FrmMantTipoTrab.cs             | 175 ++--------
 .../RecursosHumanos/IFormularioCatalogo.cs         |  10 +
 .../RecursosHumanos/RecursosHumanos/MainMDI.cs     |  23 +-
 .../RecursosHumanos/RecursosHumanos/Module1.cs     |   7 +-
 .../RecursosHumanos/My/MyApplication.cs            |   1 -
 .../{Data => }/PostgreSqlDiagnostic.cs             |  16 +-
 .../RecursosHumanos/VistaCatalogoGrid.cs           | 206 ++++++++++++
 Software/RecursosHumanos/app.config                |   7 +-
 Software/docs/ARQUITECTURA.md                      | 357 +++++++++++++++++++++
 Software/docs/PLAN_REFACTORIZACION.md              | 123 +++++++
 Software/docs/adr/0001-mvp-sobre-capas.md          |  43 +++
 .../AsistenciaImport/AsistenciaAccess.vb           |  69 ++++
 .../AsistenciaAccess_Original_Legacy.vb            | 215 +++++++++++++
 .../AsistenciaImport/AsistenciaImport.vbproj       |  72 +++++
 .../FrmImportarAsistencia.Designer.vb              | 226 +++++++++++++
 .../AsistenciaImport/FrmImportarAsistencia.vb      | 160 +++++++++
 .../AsistenciaImport/IAsistenciaService.vb         |   9 +
 .../referencia/AsistenciaImport/ISedeImportador.vb |  40 +++
 .../AsistenciaImport/ImportadorConsejo.vb          |  35 ++
 .../AsistenciaImport/ImportadorFueraSede.vb        |  35 ++
 .../AsistenciaImport/ImportadorProind.vb           |  35 ++
 .../AsistenciaImport/ImportadorSedeBase.vb         | 150 +++++++++
 .../AsistenciaImport/ImportadorSedePrincipal.vb    |  36 +++
 .../Launcher/AsistenciaImportLauncher.vbproj       |  36 +++
 .../AsistenciaImport/Launcher/Program.vb           |  12 +
 .../referencia/AsistenciaImport/Launcher/README.md |  20 ++
 .../AsistenciaImport/README_REFACTOR_OCP.md        |  87 +++++
 .../AsistenciaImport/SedeImportadorFactory.vb      |  51 +++
 Software/referencia/AsistenciaImport/TipoSede.vb   |  20 ++
 Software/referencia/README.md                      |  42 +++
 86 files changed, 4222 insertions(+), 1659 deletions(-)

```

### eeeb817

```text
eeeb817 Migracion de conexion a postgres
 .env.example                                       |   9 +
 .../20261015_01_complete_module_tables.sql         |  61 ++
 BD/password-auth.sql                               |  16 +
 BD/schema.sql                                      |  49 +-
 README.md                                          | 214 +++----
 Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs   | 625 ++++++++------------
 Software/ClassRRHH/ClassRRHH/RRHHClass.cs          | 634 +++++++++++++++------
 .../Seguridad/IAccesoUsuarioRepository.cs          |   9 +-
 .../Seguridad/ObtenerAccesoUsuario.cs              |  13 +-
 .../Seguridad/Pbkdf2PasswordHasher.cs              | 103 ++++
 Software/RRHH.PostgreSql/EnvironmentFile.cs        |  97 ++++
 .../RRHH.PostgreSql/PostgreSqlConnectionFactory.cs |  81 ++-
 .../Seguridad/PostgreSqlAccesoUsuarioRepository.cs |  56 +-
 Software/RRHH.PostgreSql/packages.lock.json        |   9 +
 .../Seguridad/ObtenerAccesoUsuarioTests.cs         |  22 +-
 .../Seguridad/Pbkdf2PasswordHasherTests.cs         |  24 +
 Software/RecursosHumanos/RecursosHumanos.csproj    |   1 +
 .../RecursosHumanos/CompositionRoot.cs             |   6 +
 .../RecursosHumanos/FrmConsultaAsistencias.cs      |   5 +-
 .../RecursosHumanos/FrmFichaSocial.cs              |  13 +-
 .../RecursosHumanos/FrmHorasTrabajadas.cs          |   2 +-
 .../RecursosHumanos/RecursosHumanos/FrmLogin.cs    |  40 +-
 .../RecursosHumanos/FrmMantDocFile.cs              |  32 +-
 .../RecursosHumanos/FrmMantEmpleado_Basico.cs      |   2 -
 .../RecursosHumanos/FrmMotivoPermiso.cs            |  24 +-
 .../RecursosHumanos/FrmRegistroAsegurado.cs        |   1 -
 .../RecursosHumanos/RecursosHumanos/Module1.cs     |   3 +-
 .../RecursosHumanos/PostgreSqlDiagnostic.cs        |  96 +++-
 .../RecursosHumanos/PostgreSqlLegacyContext.cs     | 182 ++++++
 .../RecursosHumanos/PostgreSqlLegacyMapper.cs      | 402 +++++++++++++
 .../RecursosHumanos/PostgreSqlUbigeoControl.cs     | 197 +++++++
 Software/RecursosHumanos/packages.lock.json        |  16 +
 Software/docs/PLAN_REFACTORIZACION.md              | 193 +++----
 Software/docs/POSTGRESQL_MIGRATION.md              | 129 +++--
 Software/scripts/build.ps1                         |   2 +-
 Software/scripts/check-postgresql.ps1              |  32 +-
 Software/scripts/set-user-password.cmd             |   4 +
 Software/scripts/set-user-password.ps1             |  59 ++
 38 files changed, 2540 insertions(+), 923 deletions(-)

```

### 01db40b

```text
01db40b refactor(TEC-004): separar motivos de permiso por capas y proteger escrituras
 .../Permisos/EliminarMotivoPermiso.cs              |  37 ++++
 .../Permisos/GuardarMotivoPermiso.cs               |  52 +++++
 .../Permisos/IMotivoPermisoRepository.cs           |  15 ++
 .../Permisos/ListarMotivosPermiso.cs               |  25 +++
 .../RRHH.Application/Permisos/MotivoPermisoDto.cs  |  22 ++
 .../Permisos/ObtenerMotivoPermiso.cs               |  24 +++
 .../RRHH.Domain/Permisos/AccesoMotivosPermiso.cs   |  32 +++
 Software/RRHH.Domain/Permisos/MotivoPermiso.cs     |  59 ++++++
 .../Permisos/PostgreSqlMotivoPermisoRepository.cs  | 162 +++++++++++++++
 .../Permisos/IMotivoPermisoEditorView.cs           |  19 ++
 .../Permisos/IMotivosPermisoView.cs                |  24 +++
 .../Permisos/MotivoPermisoEditorPresenter.cs       |  64 ++++++
 .../Permisos/MotivosPermisoPresenter.cs            |  97 +++++++++
 .../Fakes/FakeMotivoPermisoRepository.cs           |  56 +++++
 .../Permisos/GestionMotivosPermisoTests.cs         | 106 ++++++++++
 .../Permisos/MotivoPermisoPostgreSqlTests.cs       | 213 +++++++++++++++++++
 Software/RRHH.Tests/Permisos/MotivoPermisoTests.cs |  51 +++++
 .../RRHH.Tests/Permisos/MotivosPresenterTests.cs   | 177 ++++++++++++++++
 Software/RRHH.Tests/RRHH.Tests.csproj              |   1 +
 .../RecursosHumanos/CompositionRoot.cs             |  30 +++
 .../RecursosHumanos/FrmMantMotivo.cs               |  75 +++----
 .../RecursosHumanos/FrmMotivoPermiso.cs            | 227 +++++++--------------
 .../RecursosHumanos/RecursosHumanos/MainMDI.cs     |   4 +-
 23 files changed, 1369 insertions(+), 203 deletions(-)

```

### cc74aa0

```text
cc74aa0 refactor(TEC-003): extraer casos de uso y persistencia de feriados
 Software/ClassRRHH/ClassRRHH/RRHHClass.cs          |   7 --
 .../RRHH.Application/Asistencia/EliminarFeriado.cs |  28 ++++++
 Software/RRHH.Application/Asistencia/FeriadoDto.cs |  15 +++
 .../Asistencia/IFeriadoRepository.cs               |  23 +++++
 .../RRHH.Application/Asistencia/ListarFeriados.cs  |  30 ++++++
 .../Asistencia/RegistrarFeriado.cs                 |  49 +++++++++
 .../Asistencia/RegistrarFeriadoDto.cs              |  15 +++
 Software/RRHH.Domain/Asistencia/Feriado.cs         |  74 ++++++++++++++
 .../Asistencia/PostgreSqlFeriadoRepository.cs      | 109 +++++++++++++++++++++
 .../RecursosHumanos/PostgreSqlLegacyMapper.cs      |   1 -
 10 files changed, 343 insertions(+), 8 deletions(-)

```

### f39f4b1

```text
f39f4b1 refactor(TEC-003): conectar vista y presenter de feriados
 .../Asistencia/FeriadoPresenter.cs                 | 112 +++++++++++++++++++++
 .../RRHH.Presentation/Asistencia/IFeriadoView.cs   |  33 ++++++
 .../RecursosHumanos/CompositionRoot.cs             |  16 +++
 .../RecursosHumanos/RecursosHumanos/FrmFeriado.cs  |  99 ++++++++++--------
 .../RecursosHumanos/RecursosHumanos/MainMDI.cs     |   4 +-
 5 files changed, 219 insertions(+), 45 deletions(-)

```

### 138dbce

```text
138dbce refactor(TEC-001): migrar horarios a MVP y repositorio PostgreSQL
 .../RRHH.Application/Asistencia/EliminarHorario.cs |  24 +++
 .../RRHH.Application/Asistencia/GuardarHorario.cs  |  31 ++++
 Software/RRHH.Application/Asistencia/HorarioDto.cs |  13 ++
 .../Asistencia/IHorarioRepository.cs               |  19 +++
 .../RRHH.Application/Asistencia/ListarHorarios.cs  |  12 ++
 .../RRHH.Application/Asistencia/ObtenerHorario.cs  |  17 ++
 Software/RRHH.Domain/Asistencia/Horario.cs         |  55 +++++++
 .../Asistencia/PostgreSqlHorarioRepository.cs      | 142 ++++++++++++++++
 .../Asistencia/HorarioEditorPresenter.cs           |  58 +++++++
 .../Asistencia/HorariosPresenter.cs                |  69 ++++++++
 .../Asistencia/IHorarioEditorView.cs               |  24 +++
 .../RRHH.Presentation/Asistencia/IHorariosView.cs  |  22 +++
 .../Asistencia/HorarioPostgreSqlTests.cs           | 178 +++++++++++++++++++++
 Software/RRHH.Tests/Asistencia/HorarioTests.cs     |  54 +++++++
 .../Asistencia/HorariosPresenterTests.cs           | 167 +++++++++++++++++++
 Software/RRHH.Tests/Fakes/FakeHorarioRepository.cs |  49 ++++++
 .../RecursosHumanos/CompositionRoot.cs             |  21 +++
 .../RecursosHumanos/RecursosHumanos/FrmHorarios.cs | 112 +++++++------
 .../RecursosHumanos/FrmMantHorarios.cs             | 104 ++++++------
 .../RecursosHumanos/RecursosHumanos/MainMDI.cs     |   4 +-
 docs/t2/AVANCE_CODIGO_Y_SUSTENTACION.md            |  21 ++-
 docs/t2/PLAN_EQUIPO.md                             |  15 +-
 docs/t2/PROMPTS_POR_INTEGRANTE.md                  |  16 +-
 docs/t2/README.md                                  |   6 +-
 docs/t2/evidencias/TEC-001/validacion-local.txt    |  56 +++++++
 specs/README.md                                    |   2 +-
 specs/TEC-001-horarios.md                          |  77 +++++++--
 27 files changed, 1220 insertions(+), 148 deletions(-)

```

## Trabajo realizado en esta solicitud

Sólo lectura de fuentes, proyectos, configuración no secreta, esquema y Git; extracción estructural local e informe Markdown. Se crearon docs/analisis_codex.md y sus capítulos/anexos. No se modificó código, Word, matrices CSV, configuración de ejecución, BD ni historia Git; no se hicieron commits/push. Los cambios documentales anteriores que ya estaban en el árbol se conservaron. Evidencia del corte de código: [manifiesto SHA-256](01_arbol.md).

La existencia de 167 resultados aprobados en el registro previo no significa que se ejecutaran de nuevo aquí. En esta solicitud no se compiló ni ejecutó WinForms ni se hicieron nuevas pruebas de BD. [docs/t2/evidencias/TEC-001/validacion-local.txt:30](../../docs/t2/evidencias/TEC-001/validacion-local.txt#L30).
