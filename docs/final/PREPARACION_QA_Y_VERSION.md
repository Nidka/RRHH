# Preparación de QA y versión de RRHH

1. Confirmar con Kadin la instancia de QA, el nombre de la base y el perfil local de conexión. Usar una copia autorizada con respaldo y ensayar su restauración.
2. Ejecutar el diagnóstico de TEC-002 en solo lectura. Clasificar duplicados exactos y filas con datos diferentes. Resolver estos últimos con Kadin antes de aplicar restricciones. Ver [consulta](../../BD/diagnostics/tec002_profile.sql).
3. Inventariar migraciones aplicadas y contrastarlas con el [directorio versionado](../../BD/migrations/). Ensayar en la copia el orden de las pendientes y sus reversiones. Verificar grupos de licencias anuales, motivos de vacaciones y roles de operador y de autoservicio.
4. Repetir los escenarios de la [matriz RF](MATRIZ_ACEPTACION_RF.md) y registrar resultados, commit y entorno. Para el reloj, usar una estación y un dispositivo de QA acordados. Comprobar la marcación y la salida autorizada, además del rechazo de una segunda salida, y conservar evidencia ficticia.
5. Preparar v1.6.0-beta.1 como candidata de escritorio y web. Compilar desde el commit elegido y adjuntar artefactos, requisitos de instalación, evidencia y limitaciones. Reservar v1.6.0 para la aceptación del alcance acordado por el equipo.

El corte 7b90c45 tiene regresión local ejecutada. La selección del destino y las pruebas compartidas siguen pendientes.
