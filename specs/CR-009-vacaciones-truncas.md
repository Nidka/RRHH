# CR-009: vacaciones truncas del piloto al cese

- Depende de RF-08/RF-10. Responsable: Jorge Enrique Cano Asto; revisión ajena pendiente.
- Mantenimiento perfectivo. Regla pura en RegimenVacacionesPiloto, caso de
  uso con IIngresoVacacionesRepository y adaptadores MVP/web existentes.
- Fuente inspeccionada: Empleado dispone de FechaResolCese, que no se presume
  equivalente al último día efectivo de servicio. El operador proporciona
  explícitamente la fecha de cese para la simulación; no se modifica Empleado.

## Regla académica y aceptación

Cese incluido como día de servicio. Desde el último aniversario al cese
inclusive: días anuales/12 por mes completo y días anuales/360 por día
restante; redondeo a dos decimales alejándose de cero. Mes completo usa
AddMonths; aniversarios conservan la convención RF-07 para 29 de febrero.
No es cálculo legal ni liquidación económica.

Ejemplo del grupo: ingreso 01/03/2024, cese 12/11/2026, régimen 30:
8 meses + 12 días = 21,00. Un cese anterior al ingreso se rechaza.
Régimen configurable; cálculo sin escritura y con acceso RRHH explícito.

Pruebas: ejemplo, cambio de régimen, límites de aniversario y HTTP con roles.
Reversión: retirar caso de uso/adaptadores; no hay datos nuevos que eliminar.
Solo local. IA material en código/pruebas/documentación; revisión y QA visual pendientes.

Ejecutado: 371/371 pruebas net48 sin omisiones; ejemplo, régimen de 15 días,
primer día y cierre del primer periodo. HTTP comprueba 21,00 y acceso 401/403,
y rechaza cese previo al ingreso. Build web 0 errores/0 advertencias y WinForms
completo x86 0 errores/26 advertencias heredadas.
