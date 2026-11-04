# Política de versionado

## Esquema
Versionado semántico (SemVer 2.0.0): `MAJOR.MINOR.PATCH`.
Las etiquetas Git llevan prefijo `v`: `v1.0.0`, `v1.1.0`.

## Por qué SemVer
- El número indica al equipo y al área de RRHH si actualizar es seguro.
- Coincide con la clasificación de las solicitudes de cambio (corrección, mejora, cambio mayor).
- Es el estándar de la industria.

## Versión inicial
`1.0.0`, sobre `main` en `fd12b80` (18/10/2026): aplicación recuperada, compila con 0 errores,
65 pruebas aprobadas y opera contra PostgreSQL. Incluye TEC-003 (PR #1) y TEC-004 (PR #2).

## Cuándo sube cada número
| Número | Sube cuando… | Ejemplo en RRHH |
|--------|--------------|-----------------|
| MAJOR | El cambio rompe compatibilidad: deja de soportar SQL Server, cambia el esquema de BD sin migración compatible o reemplaza pantallas completas. | Retiro de TableAdapters de SQL Server → 2.0.0 |
| MINOR | Se agrega o mejora una función sin romper lo existente. | Validación de horarios (SC-001) → 1.1.0 |
| PATCH | Se corrige un error o se refactoriza sin cambiar el comportamiento. | Integridad de IDs de BD (SC-002) → 1.0.1 |

Al subir un número, los de su derecha vuelven a 0. Los cambios solo de documentación no cambian la versión.
Versiones de prueba: `1.1.0-beta.1`.

## Quién decide la versión
El autor propone el tipo de cambio en el PR (label `semver:*`); el revisor lo confirma.
La coordinación crea la etiqueta y el Release.
