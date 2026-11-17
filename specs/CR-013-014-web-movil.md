# CR-013 y CR-014 en web y móvil

Base: T3 consolidada en `bb5add4`. Rama: `RamaW+M`. Revisión humana pendiente.

## Necesidad y alcance

El operador de escritorio usa WinForms para registrar periodos de teletrabajo y consultar sus días. El piloto adapta esa capacidad al navegador de escritorio y al teléfono mediante una PWA instalable. Usa usuarios RRHH con rol habilitado explícitamente. Incluye sesión, registro, listado y reporte. La confirmación del rol de operador, el patrón parcial y el calendario corresponde al equipo. No abarca RF-16, vacaciones, anulación ni un binario nativo de tienda.

## Diseño

Mantenimiento adaptativo. Se conserva el contrato de fechas inclusivas, patrón semanal, días laborables y alta transaccional. No se refactorizan pantallas WinForms ni se sustituyen procedimientos. El nuevo host compone `ObtenerAccesoUsuario`, `RegistrarPeriodoTeletrabajo`, `ListarPeriodosTeletrabajo` y `ReportarDiasTeletrabajo` con los repositorios existentes. SRP separa sesión HTTP, vista, lógica y datos. DIP mantiene los contratos en Application. El ADR 0002 recoge la adaptación de la presentación.

## Criterios de aceptación

- Un rol habilitado inicia sesión y un usuario sin sesión no accede a los datos.
- Un periodo válido se guarda y aparece en el listado. Uno superpuesto del mismo empleado se rechaza.
- El reporte recorta el rango, excluye feriados y respeta el patrón parcial.
- En móvil se puede usar el mismo flujo y acceder al modo instalado donde el navegador lo admita. La caché contiene solo recursos estáticos.

## Pruebas y reversión

Verificar compilación del host, sesión, token contra solicitudes cruzadas, alta/listado e informe con PostgreSQL ficticio. Registrar un recorrido separado en teléfono. El host requiere la migración existente de Teletrabajo y el esquema de contraseña. Se revierte retirando el host sin modificar los periodos guardados.

El entorno de QA ejecuta las pruebas de escritorio en una base desechable separada de la demo. La [evidencia de escritorio y navegador](../Software/RRHH.Web/qa/RESULTADOS.md) registra el caso parcial, el feriado y el rechazo de solapamiento. Móvil se conserva como alcance de la rama y queda fuera de la verificación del 17/11.
