# Reglas del proyecto RRHH

Aplicación WinForms (.NET Framework 4.8, C# 12, DevExpress 11.2) recuperada
por ingeniería inversa y en migración de SQL Server a PostgreSQL.

- Arquitectura (obligatoria): `Software/docs/ARQUITECTURA.md`
- Estado de la migración: `Software/docs/POSTGRESQL_MIGRATION.md`
- Compilar: `Software\scripts\build.cmd`
- Pruebas (no requieren las DLL heredadas): `dotnet test Software\RRHH.Tests`

## Reglas de arquitectura

1. Presentación con **MVP de vista pasiva**: el formulario implementa
   `IXxxView`, y la lógica va en `XxxPresenter`. Ambos (interfaz y presenter)
   viven en `RRHH.Presentation`, que no referencia WinForms ni DevExpress.
   Ejemplo de referencia: catálogos simples (`CatalogoPresenter`,
   `VistaCatalogoGrid`, `CompositionRoot.CrearCatalogo`). Plan de trabajo:
   `Software/docs/PLAN_REFACTORIZACION.md`.
2. Las dependencias van hacia adentro:
   `RecursosHumanos` → `RRHH.Presentation` → `RRHH.Application` → `RRHH.Domain`, y
   `RRHH.PostgreSql` → `RRHH.Application`.
   `RRHH.Domain`, `RRHH.Application` y `RRHH.Presentation` no referencian
   Npgsql, `System.Data`, WinForms, DevExpress ni GRLL.
3. El acceso a datos va solo por repositorios PostgreSQL con SQL
   parametrizado. Nunca concatenar valores en SQL ni pasar fechas como texto.
4. No agregar código nuevo que use `dcGRLLDataContext`, `XxxMapper.Instance()`,
   `RRHHClass`, `SqlConnection`/`SqlCommand`, TableAdapters ni `Module1.DcGrll`.
5. Los proyectos heredados (`GRLL`, `ClassRRHH`, `ClsCtrls`, `Seguridad`,
   `GRLL.Common.Rutinas`) están congelados: solo se modifican para retirar
   código ya migrado.
6. Las dependencias se crean en `RecursosHumanos/RecursosHumanos/CompositionRoot.cs`,
   no dentro de formularios ni presenters.
7. No renombrar ni mover formularios `Frm*` ni sus `.resx`.
8. Al portar un `spRRHH_*` o una consulta LINQ-to-SQL, indicar en el
   comentario XML qué reemplaza.

## Seguridad

- Nunca escribir contraseñas ni cadenas de conexión en código, `app.config` o
  Git. La conexión viene de `RRHH_POSTGRES_CONNECTION`.
- No subir dumps con datos (`BD/CMI.sql`, `BD/dumps/`, `BD/private/`), `.bak` ni DLL
  licenciadas (`Software/lib/legacy`).

## Herramientas

- `graphify update Software` regenera el grafo de dependencias en
  `Software/graphify-out/`, que está fuera de Git.
