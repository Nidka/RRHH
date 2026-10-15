# ADR 0001: MVP sobre una arquitectura en capas

- **Estado:** aceptada
- **Fecha:** 2026-10-13

## Contexto

RRHH es una aplicación WinForms (.NET Framework 4.8, DevExpress 11.2)
recuperada por ingeniería inversa. Los formularios concentran interfaz, reglas
de negocio y acceso a datos. El acceso a datos usa cuatro mecanismos distintos:
LINQ-to-SQL mediante `GenericMapper`, `RRHHClass`, TableAdapters y
`SqlConnection` directo. Además, el sistema está migrando de SQL Server a
PostgreSQL.

Se necesita una arquitectura que permita migrar pantalla por pantalla, probar
la lógica sin abrir formularios y aislar la base de datos.

## Decisión

Usar **MVP con vista pasiva** en la presentación, sobre **capas** con
dependencias hacia adentro: Dominio, Aplicación, Infraestructura (PostgreSQL) y
Presentación. La migración se hace por caso de uso, reemplazando gradualmente
el código heredado. El detalle está en [../ARQUITECTURA.md](../ARQUITECTURA.md).

## Alternativas descartadas

| Alternativa | Motivo del descarte |
|---|---|
| MVC | En WinForms el formulario recibe los eventos del usuario, así que actúa de vista y de controlador a la vez. Un controlador separado resulta artificial y la vista sigue conociendo el modelo. |
| MVVM | Depende de un enlace de datos (*data binding*) completo. El de WinForms en .NET Framework 4.8, y más aún con DevExpress 11.2, es limitado. |
| Reescritura completa (web o WPF) | Alto riesgo: no hay especificación funcional fuera del propio código recuperado y faltan los 303 procedimientos de la base original. |
| Mantener la estructura actual | Impide terminar la migración a PostgreSQL. LINQ-to-SQL solo genera SQL de SQL Server. |

## Consecuencias

- Cada pantalla migrada suma tres archivos (vista, interfaz y presenter) más un
  caso de uso y un repositorio. Es más código, pero se puede probar.
- Durante la migración convivirán pantallas nuevas y heredadas. Los proyectos
  heredados quedan congelados y solo se modifican para retirar código.
- La lógica de negocio queda cubierta por pruebas sin depender de la interfaz ni
  de la base de datos.
- Si en el futuro se cambia la interfaz (por ejemplo, a web), `RRHH.Domain`,
  `RRHH.Application` y `RRHH.PostgreSql` se reutilizan sin cambios.
