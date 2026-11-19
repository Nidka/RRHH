# CR-008: saldo conciliado de vacaciones del piloto

- RF-08; línea base `a91c2c1`; responsable de esta continuación: Jorge Enrique Cano Asto.
- Revisión ajena pendiente. Solo QA local; sin despliegue compartido.

## Diagnóstico y diseño previo

RF-07 solo calcula aniversarios. Falta descontar consumos aprobados, mantener
arrastre y liberar saldo al anular. Mantenimiento perfectivo: nuevo caso de
consulta; extracción de cálculo reutilizable, conservando RF-07.

Se usa Permiso como fuente única, sin libro paralelo que pueda desincronizarse.
Una marca explícita EsVacacionesPiloto en Motivo_Perm identifica vacaciones;
no se infiere por descripción ni se activan códigos reales. Estado Aprobado
descuenta; sin columna histórica de estado se interpreta Autorizado=true.
Consumo completo por días calendario inclusivos; media jornada individual
equivale a 0,5. La aprobación reserva el permiso completo desde su inicio.
Las consultas al corte incluyen consumos cuyo inicio ya ocurrió; la validación
de nuevas aprobaciones deberá considerar también reservas futuras.

Application depende de IVacacionesSaldoRepository (DIP); PostgreSQL devuelve
ingreso y consumos en una consulta consistente. RegimenVacacionesPiloto
mantiene cálculo puro. MVP para la nueva pantalla; CompositionRoot compone.
No es refactorización pura: agrega capacidad funcional.

## Aceptación

- Ingreso 01/03/2024, corte 12/11/2026: 60 generadas; 12,5 aprobadas usadas;
  pendientes 47,5; solicitado/rechazado/anulado no consume.
- Anular devuelve saldo sin actualización de un contador auxiliar.
- Datos de ingreso contradictorios o consumos corruptos producen diagnóstico.
- Corte previo al ingreso se rechaza; arrastre entre aniversarios.
- No se oculta un saldo histórico negativo; se muestra para revisión.

## Verificación y reversión

Ejecutado: 364/364 pruebas net48, ninguna omitida, PostgreSQL 18 local ficticio;
smoke HTTP con 60 generadas, 12,5 usadas y 47,5 pendientes, más 401/403.
WinForms completo x86: 0 errores y 26 advertencias heredadas; web net8:
0 errores y 0 advertencias. Recorrido visual de la pantalla nueva pendiente.
La migración es transaccional e idempotente; agrega marcas sin activar motivos.
El rollback se bloquea si hay medias jornadas para no perder su significado.
Revisión del grupo y configuración de motivos reales pendientes.

IA: asistencia material en código, documentación y pruebas; sin revisión humana simulada.
