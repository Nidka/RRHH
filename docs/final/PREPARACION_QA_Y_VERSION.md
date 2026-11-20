# Preparación de QA y versión de RRHH

1. Confirmar con Kadin la instancia de QA, el nombre de la base y el perfil local de conexión. Usar una copia autorizada con respaldo y ensayar su restauración.
2. Ejecutar el diagnóstico de TEC-002 en solo lectura. Clasificar duplicados exactos y filas con datos diferentes. Resolver estos últimos con Kadin antes de aplicar restricciones. Ver [consulta](../../BD/diagnostics/tec002_profile.sql).
3. Inventariar migraciones aplicadas y contrastarlas con el [directorio versionado](../../BD/migrations/). Ensayar en la copia el orden de las pendientes y sus reversiones. Verificar grupos de licencias anuales, motivos de vacaciones y roles de operador y de autoservicio.
4. Repetir los escenarios de la [matriz RF](MATRIZ_ACEPTACION_RF.md) y registrar resultados, commit y entorno. Para el reloj, usar una estación y un dispositivo de QA acordados. Comprobar la marcación y la salida autorizada, además del rechazo de una segunda salida, y conservar evidencia ficticia.
5. Preparar v1.6.0-beta.1 como candidata de escritorio y web. Compilar desde el commit elegido y adjuntar artefactos, requisitos de instalación, evidencia y limitaciones. Reservar v1.6.0 para la aceptación del alcance acordado por el equipo.

El corte 7b90c45 tiene regresión local ejecutada. La selección del destino y las pruebas compartidas siguen pendientes.

## Resultado de la validación local

En PostgreSQL 18.3 se creó cmi_qa y se verificó restaurar su respaldo. El
ensayo del esquema confirmó que TEC-002 debe preceder a la migración de
grupo anual de RF-06. La suite de integridad verificó copias exactas y
rechazo de filas ambiguas con datos ficticios. La clasificación de los
duplicados de la base compartida requiere un respaldo anonimizado.

La web verificó el aislamiento de dos cuentas y la restricción anual con
dos motivos del mismo grupo. WinForms consultó 47,5 días pendientes para
el empleado ficticio 101 en la misma base.

## Alcance de la prueba del reloj

La [guía de migración](../../Software/docs/POSTGRESQL_MIGRATION.md)
describe la importación de Marcacion.mdb. La regresión de RF-03 comprueba
las reglas de salida con marcaciones ficticias ya disponibles en PostgreSQL.
Para validar la integración importada, hace falta un archivo de prueba y
el proveedor de Access de la arquitectura del cliente. Para acreditar el
dispositivo físico, el archivo debe provenir de una marcación de QA con
fecha y empleado ficticios conocidos. Después de importar se debe comprobar
la fecha y el empleado en PostgreSQL y ejecutar la validación de salidas.
