# Plan de refactorizacion

La aplicacion recuperada ya dispone de una ruta operativa PostgreSQL. El plan
siguiente separa ese resultado funcional de la modernizacion estructural que
el equipo puede continuar sin bloquear el uso del sistema.

## Estado

| Area | Estado operativo | Refactor estructural |
|---|---|---|
| Login y autorizacion | Hecho y probado | Agregar bloqueo, auditoria y MFA/SSO |
| Catalogos | PostgreSQL funcional | Migrar todos a presenters/repositorios |
| Empleados y ubigeo | PostgreSQL funcional | Dividir formulario principal |
| Permisos | PostgreSQL funcional | Optimizar consultas especializadas |
| Asistencia | PostgreSQL funcional | Caracterizar escrituras y rendimiento |
| Legajo y documentos | PostgreSQL funcional | Repositorios por agregado |
| Ficha social | PostgreSQL funcional | Separar sus subvistas |
| Reportes | Datos PostgreSQL | Retirar TableAdapters de diseno |
| Integridad del esquema | Parcial | Sanear duplicados y agregar restricciones |

## Base implementada

- `RRHH.PostgreSql` centraliza configuracion, conexiones, SQL parametrizado y
  transacciones.
- `PostgreSqlLegacyMapper` permite que los formularios decompilados trabajen
  con PostgreSQL sin el `GenericMapper` SQL Server.
- `PostgreSqlLegacyContext` reemplaza los procedimientos del
  `dcGRLLDataContext` usados por los modulos activos.
- `RRHHClass` implementa en PostgreSQL consultas, escrituras y conjuntos de
  datos para reportes.
- `PostgreSqlUbigeoControl` reemplaza el selector que abria SQL Server.
- `AsistenciaAccess` usa Access solo como entrada de los relojes y PostgreSQL
  como destino.

## Siguientes iteraciones

### 1. Integridad y rendimiento

- Medir duplicados por clave natural en QA.
- Agregar indices para busquedas de empleados, permisos y asistencia.
- Incorporar claves primarias/foraneas mediante migraciones idempotentes.
- Reemplazar consultas genericas costosas por consultas dedicadas.

### 2. Casos de uso por modulo

- Extraer repositorios y servicios para empleados, permisos y asistencia.
- Mantener los formularios como vistas pasivas.
- Agregar pruebas de escritura y concurrencia antes de retirar cada mapper de
  compatibilidad.

### 3. Formularios grandes

- Dividir `FrmMantEmpleado_Basico` en datos personales, vinculo laboral y
  ubicacion.
- Dividir `FrmFichaSocial` en vivienda, salud, familia y aspectos
  socioeconomicos.
- Eliminar codigo decompilado no alcanzable despues de tener cobertura.

### 4. Reportes

- Mantener los nombres de tablas y columnas esperados por los `.repx`.
- Retirar los `TableAdapter` SQL Server que solo permanecen en el disenador.
- Crear pruebas de humo que llamen `CreateDocument()` con datos anonimizados.

### 5. Plataforma

- Evaluar una version soportada de DevExpress.
- Reescribir los controles restantes de `GRLL.dll` y retirar el binario
  heredado cuando ya no tenga consumidores.
- Separar la importacion Access como adaptador opcional por sede.

## Criterio por cambio

Cada pull request debe:

1. compilar `Software/RRHH.sln` en x86;
2. aprobar `RRHH.Tests`;
3. ejecutar `scripts/check-postgresql.cmd -Modules` cuando cambie SQL;
4. no versionar `.env`, dumps, binarios ni datos personales;
5. incluir una migracion idempotente cuando cambie el esquema.
