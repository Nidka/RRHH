# TEC-002: integridad e IDs para los módulos asignados

- Estado: Despliegue informado; conexión verificada por psql. Integridad/IDs y QA de aplicación pendientes.
- Responsable: Francisco Kadin Valera Lizarraga.
- Revisor: Jorge Enrique Cano Asto.
- Rama: `infra/tec-002-integridad-bd`.
- Base actual: `eeeb817` (16/10/2026); el diagnóstico inicial se preparó con `0a4b6a8`. Caracterizar la versión nueva según [primera prueba](../docs/t2/PRIMERA_PRUEBA.md) y actualizar el diagnóstico antes de programar.
- Trazabilidad: paquete técnico del [plan de equipo](../docs/t2/PLAN_EQUIPO.md); enlazar issue/PR y RF/CR aplicables al iniciar.

## Actualización operativa del 16/10/2026

La BD ya fue desplegada por Kadin según informó Evelyn. Conexión y metadatos se comprobaron por psql; la prueba WinForms sigue pendiente. `eeeb817` añade `.env`, contraseña de usuario RRHH y puentes PostgreSqlLegacyMapper/PostgreSqlLegacyContext. Los nombres XxxMapper del diagnóstico inicial ya no prueban uso de SQL Server: revisar su resolución y proveedor actual. El objetivo del paquete es refactorizar hacia responsabilidades/casos de uso específicos sobre la ruta nueva, conservando su comportamiento caracterizado.

## Problema y evidencia inicial (base anterior; revalidar)

`BD/schema.sql` declara Horario, RRHH_Feriado y Motivo_Perm sin PK, secuencias ni FK. Los formularios calculan IDs con MAX+1. El despliegue ya fue informado; este diagnóstico de integridad debe contrastarse con la instancia actual. No asumir que la instancia real tiene exactamente ese estado.

Es lectura estática del código recuperado. El responsable registra el comportamiento real y distingue original/reconstrucción antes de atribuir un defecto al producto recibido.

## Alcance

Preparar QA y migraciones compatibles de las tres tablas, comenzando por perfilado y PK/identidad; reconstruir FK solo tras comprobar las claves de tablas relacionadas y sus datos. No reconstruir toda CMI ni limpiar/eliminar filas reales automáticamente. No modificar el repositorio genérico de catálogos, que no usa estas tablas, sin otra tarea.

## Procedimiento común y justificación del diseño

Aplicar [prompt general de refactorización](../docs/t2/PROMPT_GENERAL_REFACTORIZACION.md).
Antes de implementar, completar aquí o en los apartados de diseño/principios:

- Mantenimiento principal y secundarios, con justificación del cambio real.
- Comportamiento que se conserva; defectos/capacidades nuevos y su aceptación separada.
- Patrones aplicados: propósito y clases participantes, conforme a la arquitectura vigente.
- Principios sustentados: archivo/método antes/después, beneficio y prueba.

Para horarios/feriados/motivos, el cambio estructural pendiente es principalmente
preventivo; la adaptación PostgreSQL ya incorporada no se atribuye como
nuevo trabajo del paquete. Para BD, distinguir migración/integridad del refactor
de código. No introducir patrones ni jerarquías solo para mencionarlos.

## Diseño y archivos previstos

- `BD/migrations/`: migraciones numeradas con orden de aplicación, transacciones y precondiciones explícitas.
- `BD/README.md` y runbook de despliegue sin secretos: destino acordado, versiones, respaldo/restauración y comando de comprobación.
- `BD/schema.sql`: actualizar solo al exportar el esquema QA real saneado, coordinando con los demás.
- Tablas: Horario.idHorario, RRHH_Feriado.idFeriado y Motivo_Perm.idMotivo. Conservar identificadores y columnas existentes.
- Contrato en esta spec: estrategia elegida (p. ej. identidad BY DEFAULT compatible con ID explícito), orden y salida RETURNING; lo completará Kadin antes de que se integren repositorios nuevos.

Nombres nuevos propuestos: adaptarlos a las convenciones existentes sin duplicar servicios. Todo archivo nuevo debe cumplir [arquitectura](../Software/docs/ARQUITECTURA.md). No cambiar proyectos congelados salvo retirada del código ya reemplazado.

## Plan de trabajo

1. Registrar versión/destino y perfilar IDs duplicados, nulos, máximos y referencias huérfanas. Entregar informe sin datos personales.
2. Publicar contrato de IDs y dependencias para Jorge/Frank/Evelyn. Crear copia QA ficticia; las migraciones no requieren tocar producción.
3. Incorporar PK/identidad/secuencias, alineadas por encima del máximo conservando IDs; abortar ante anomalías en lugar de borrarlas. Si una tabla ya tiene esas estructuras, verificar y registrar el estado.
4. Inventariar referencias (incluyendo HorarioTemporal y permisos/motivos). Agregar solo FK con claves destino y datos válidos; registrar las diferidas.
5. Desplegar cuando se disponga de destino autorizado; verificar altas, concurrencia y rechazo de referencias inválidas donde exista FK. Comprobar restauración.
6. Registrar versión de migración y actualizar esquema exportado; revisar con autores de repositorios que INSERT/RETURNING y secuencias coincidan.

## Aceptación y pruebas

- Copia QA conserva IDs/filas previas y genera IDs nuevos sin colisión, incluso con inserts concurrentes.
- Cada migración tiene precondiciones y resultado esperado; la repetición se maneja explícitamente por versión o detección segura.
- Duplicados/huérfanos detienen el paso correspondiente y producen diagnóstico, sin limpieza destructiva implícita.
- FK no implementada no se declara verificada; tablas consumidoras y riesgos pendientes figuran en el informe.
- Runbook y comprobaciones reproducibles, sin claves en Git; restauración ensayada y evidencia real antes de declarar despliegue completado.

Registrar casos, entorno, comando, esperado/obtenido y evidencia. Cuando aplique: `Software\scripts\build.cmd` y `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` en Windows; QA con datos ficticios. No declarar éxito de lo que no se ejecutó.

## Principios, mantenimiento y exposición

Preventivo por integridad/concurrencia; adaptativo en despliegue/configuración. No confundir desplegar con refactorizar una pantalla.

Entregar diff antes/después y una demostración breve del resultado del paquete. Explicar beneficio concreto para modificar/probar el módulo y un límite pendiente. La autoría se acredita con los commits reales del responsable; revisión del integrante asignado.

## Reversión y coordinación

Conservar referencia del commit anterior. Separar scripts de datos de vistas/casos de uso. Antes de migrar, comprobar compatibilidad de aplicación y esquema previo/nuevo; no revertir un cambio de datos solo revirtiendo C#. Kadin coordina copia/restauración y aplicación de migraciones; cada autor prepara su plan específico de reversión antes del PR final. No ejecutar contra un servidor sin destino/alcance autorizados.

## Ingeniería inversa y control de este cambio

- Solicitud técnica: **CR-TEC-002**, registrada en el [plan de equipo](../docs/t2/PLAN_EQUIPO.md).
- Línea base de ejecución: pendiente de registrar por el responsable (ejecutable original/reconstruido, entorno y versión de BD). El hash de código revisado no sustituye la versión del original.
- Antes de editar: registrar entradas, proceso, salidas, reglas y un flujo; inventariar métodos, llamadas y tablas; enlazar capturas/pruebas y limitaciones.
- Diagnóstico: completar evidencia → problema → impacto → recomendación. Distinguir observación de hipótesis y defecto del original de regresión de reconstrucción.
- Al implementar: enlazar commits, PR y revisiones reales; actualizar estado de CR-TEC-002 y RF asociados sin declarar completo un RF parcial.
- Al cerrar: entregar comparación antes/después, principio y mantenimiento justificados, resultados de pruebas y versión integrada para el informe/exposición.
- Feedback: el revisor señala archivo/caso, impacto, cambio sugerido y comprobación; el autor enlaza su respuesta/corrección y el revisor verifica lo afectado.

## Seguimiento

- Caracterización: realizada el 18/10/2026 en lectura sobre `06ca7f6`; evidencia
  saneada en `../docs/t2/evidencias/TEC-002/DIAGNOSTICO_2026-10-18.md`.
- Decisiones y supuestos: contrato `IDENTITY BY DEFAULT`, PK/FK sin cascada y
  fecha de feriado única por día; compartido en
  `../docs/t2/aportes/TEC-002/CONTRATO_IDS.md` para Jorge, Frank y Evelyn.
- Código/pruebas/QA: migración, reversión, perfilador y pruebas SQL locales
  aprobadas. Instancia compartida bloqueada por duplicación exacta al 100 %;
  saneamiento autorizado, QA WinForms Windows y restauración remota pendientes.
- PR, commits y evidencias: pendientes.
- IA: plan, scripts, documentos y ejecución local preparados con asistencia de
  IA; requieren revisión humana de Kadin/Jorge antes del PR o despliegue.

## Resultado del perfilado del 18/10/2026

La instancia configurada es PostgreSQL 18.6 en Neon y la conexión técnica usa
un rol propietario; no se confirmó que sea una QA ficticia. Por ello se usó
solo `BEGIN READ ONLY`. Horario tiene 140 filas/70 IDs; RRHH_Feriado 442/221;
Motivo_Perm 280/140; TipoPermiso 6/3. Cada ID aparece dos veces y las dos copias
son idénticas, sin variantes de contenido. No se detectaron huérfanos en las
ocho referencias inventariadas. No hay PK/FK/identidades en esas tablas.

Existe una cuenta técnicamente elegible para RRHH, pero no se confirmó por
canal humano su login, contraseña ni que represente un empleado ficticio. No se
modificaron credenciales. La prueba de aplicación permanece pendiente.

## Contrato y compatibilidad

La migración `20261018_02_integrity_ids.sql` conserva IDs, crea PK e identidad
`BY DEFAULT`, alinea secuencias por encima del máximo, añade las ocho FK
verificadas y hace única la fecha calendario de feriado. Aborta de forma
transaccional ante duplicados, nulos, huérfanos, defaults desconocidos o una PK
incompatible. No corrige ni elimina datos.

`BY DEFAULT` permite restaurar IDs explícitos y permite que el código integrado
de feriados siga funcionando durante la transición. Los repositorios nuevos
deben omitir el ID y usar `RETURNING`; después de una carga explícita se vuelve
a ejecutar la migración para alinear secuencias.

## Verificación ejecutada y pendientes

En PostgreSQL local 14.23 con datos ficticios se aprobaron: migración limpia,
4 PK, 4 identidades, 8 FK, fecha única, secuencias, repetición idempotente,
rechazo de FK/fecha inválidas, dos inserts concurrentes con IDs distintos,
aborto ante duplicado/huérfano y reversión conservando filas.

Pendientes reales: aprobación y saneamiento de una copia restaurada, ensayo de
backup/restore del destino autorizado, aplicación programada, exportación de
`schema.sql`, build/tests/WinForms en Windows y revisión de Jorge. No se declara
completado el despliegue de integridad mientras esos puntos sigan abiertos.
