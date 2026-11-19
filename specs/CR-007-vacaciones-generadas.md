# CR-007 vacaciones generadas del piloto

RF-07. Base d12f4a4 y cambios RF-17 en revisión. Responsable de implementación de esta continuación Jorge Enrique Cano Asto con asistencia de Codex. Revisión humana del grupo pendiente. Mantenimiento perfectivo. Capacidad nueva propuesta por el grupo para datos ficticios.

## Regla y caracterización

La tabla Empleado contiene FechaIngreso. Los motivos de vacaciones existentes no acreditan un cálculo de devengo. El piloto genera un periodo de 30 días calendario por aniversario cumplido desde el ingreso. La cantidad anual es parametrizable mediante RRHH_VACACIONES_DIAS_ANUALES y su valor predeterminado es 30. No se devenga mensualmente en RF-07. El ejemplo ingreso 01/03/2024 y corte 12/11/2026 produce 60 días.

Para ingreso el 29 de febrero se adopta el 28 de febrero como aniversario de un año no bisiesto, usando DateTime.AddYears. Es una convención técnica del piloto pendiente de revisión. Un corte anterior al ingreso devuelve un error. Fechas de ingreso ausentes o contradictorias entre filas del mismo empleado se rechazan, sin elegir una arbitrariamente.

## Diseño y aceptación

RegimenVacacionesPiloto en Domain contiene el cálculo puro. ReportarVacacionesGeneradas en Application utiliza IIngresoVacacionesRepository. PostgreSqlIngresoVacacionesRepository lee únicamente IdEmpleado y FechaIngreso. El presenter y la vista WinForms son pasivos. El host web adapta el mismo caso de uso. Se aplican Repository, MVP y composición en CompositionRoot. Domain y Application no conocen los controles ni PostgreSQL.

Probar cero, uno y dos aniversarios, día anterior al aniversario, 29 de febrero, parámetro anual distinto, fecha invertida, empleado ausente y fechas ambiguas. La UI muestra ingreso, corte, aniversarios y días generados. No hay cambio de esquema ni escrituras. RF-08 y RF-09 se implementan por separado y no se computan todavía saldos o truncas.

## Acceso y reversión

En web se requiere el rol explícito RRHH_WEB_ROLES_VACACIONES además del acceso al host. En escritorio se requiere RRHH_VACACIONES_ROLES, con IDs separados por comas. Listas vacías deniegan la consulta. La reversión retira el reporte y sus entradas sin modificar datos. El despliegue de BD compartida no forma parte de este cambio.

## Verificación realizada

El 19/11/2026 pasaron 354 pruebas net48 con PostgreSQL 18 ficticio. Las siete regresiones nuevas prueban aniversario completo, días anteriores al aniversario, régimen parametrizado, corte anterior al ingreso y la convención del 29 de febrero. La prueba HTTP obtuvo 60 días y dos años cumplidos para el ejemplo del grupo, rechazó ingreso nulo y corte anterior al ingreso y denegó el rol sin acceso.

La web compiló con cero errores y cero advertencias. El build.cmd completo de Windows generó RecursosHumanos.exe x86 con cero errores y 26 advertencias del aplicativo tras corregir una referencia de namespace en CompositionRoot. El recorrido visual de las nuevas pantallas RF-07 queda pendiente de registrar.
