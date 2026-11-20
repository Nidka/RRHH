# CR-015: consolidación diaria de asistencia

- RF-15; responsable de continuación: Jorge Enrique Cano Asto; revisión ajena pendiente.
- Mantenimiento perfectivo. Se conservan RF-14/RF-17; reporte nuevo no escribe datos.

## Diseño previo y regla del piloto

Por cada día laborable: ausencia aprobada > presencial > remoto > sin registro.
Una fila Asistencia con fecha acredita presencialidad en este piloto; no se
infiere jornada completa a partir de horas. Un permiso aprobado cuenta como
ausencia a nivel de día, incluso si es parcial; no es cálculo de horas trabajadas.
Teletrabajo debe estar vigente/activo y corresponder al patrón semanal.
Dos o más fuentes distintas generan inconsistencia, sin doble conteo;
marcaciones repetidas de la misma fuente no duplican el día. No laborables
quedan en detalle y no suman a las categorías laborables. Sin registro se
muestra como falta de evidencia y no suma presencialidad ni remoto.

Regla pura en Domain, caso de uso con IAsistenciaConsolidadaRepository,
SQL parametrizado en una instantánea REPEATABLE READ READ ONLY y generate_series
limitado a 367 días. MVP nuevo en escritorio; política de asistencia en web.
Calendario lunes-viernes menos RRHH_Feriado, coherente con el piloto existente.

Aceptación: miércoles con tres fuentes → ausencia 1, presencial 0, remoto 0
e inconsistencia; día sin fuentes → sin registro; feriados no computan;
fuentes duplicadas no duplican; permiso rechazado no genera ausencia.

Pruebas puras, SQL ficticio, HTTP y builds. Reversión retira UI/caso sin datos
nuevos que eliminar. Solo local; ayuda material de IA declarada. Revisión y
recorrido visual pendientes, sin aceptación humana inventada.

Ejecutado: 381/381 pruebas net48 sin omisiones; prioridades puras, SQL de
tres fuentes y marcaciones duplicadas, feriado y patrón parcial. HTTP confirma
ausencia 1, presencial 0, remoto 4, sin registro 1 e inconsistencia 1 en seis
días laborables; 401/403 y límite de rango. Build web 0 errores/0 advertencias,
WinForms completo x86 0 errores/26 advertencias heredadas. Acceso escritorio
mediante RRHH_ASISTENCIA_ROLES explícito; sin roles habilitados por defecto.
