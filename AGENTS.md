# Instrucciones para trabajar en RRHH

Estas reglas aplican al repositorio completo, para integrantes y asistentes de IA.

## Leer antes de cambiar

1. `CONTRIBUTING.md`: ramas, revisiones y verificaciones.
2. `Software/docs/ARQUITECTURA.md` y `Software/docs/adr/0001-mvp-sobre-capas.md`: arquitectura vigente.
3. `Software/docs/PLAN_REFACTORIZACION.md`: orden técnico de migración.
4. `docs/t2/README.md` y `docs/t2/PLAN_EQUIPO.md`: reparto vigente de implementación (horarios/BD/feriados/motivos), orden y tareas académicas.
5. La especificación de la tarea en `specs/`; usar `specs/PLANTILLA.md` cuando corresponda crearla.
6. `docs/t2/PRIMERA_PRUEBA.md`: conexión y caracterización sobre `eeeb817`, antes de continuar los paquetes.
7. `docs/t2/PROMPT_GENERAL_REFACTORIZACION.md`: procedimiento común obligatorio del equipo para ejecutar cada refactor; se combina con la spec y el rol.

La arquitectura tiene una sola fuente: `Software/docs/ARQUITECTURA.md`. Si se propone cambiarla, documentar el motivo y las consecuencias en un ADR; no introducir una arquitectura alternativa de forma implícita. `CLAUDE.md` remite a estas mismas fuentes.

## Alcance y evidencia

- La T2 exige diagnóstico, ingeniería inversa y planificación. No implementar los 18 RF por el hecho de aparecer en el backlog.
- Sustentar también el avance de código existente: antes/después, principio, tipo de mantenimiento, beneficio y prueba real. Usar `docs/t2/AVANCE_CODIGO_Y_SUSTENTACION.md`; no reducir la entrega a conocimiento teórico o a producir documentos. Distinguir las tareas técnicas propuestas de las ya ejecutadas.
- Diferenciar ejecutable original, código recuperado, cambios del equipo y propuesta futura. Indicar versión/commit y origen de la evidencia.
- No inventar capturas, resultados de pruebas, reglas de negocio, despliegues, aprobación humana ni contribuciones de integrantes.
- Una hipótesis derivada del código se registra como hipótesis hasta contrastarla. Una prueba escrita no equivale a una prueba ejecutada.
- Revisar `git status` antes de editar. Conservar cambios ajenos y documentos locales. No usar reset, borrado o force push para resolver divergencias sin autorización expresa.

## Código y refactorización

- Antes de editar, completar en la spec el mantenimiento principal, técnica de refactorización, patrones y principios con archivos/métodos concretos. Separar comportamiento conservado de correcciones o capacidades nuevas. Seguir el prompt general enlazado; no forzar patrones ni afirmar SOLID sin evidencia.

- MVP de vista pasiva: contratos y presenters en `RRHH.Presentation`; casos de uso/contratos de repositorio en `RRHH.Application`; reglas puras en `RRHH.Domain`; repositorios en `RRHH.PostgreSql`.
- Domain, Application y Presentation no dependen de WinForms, DevExpress, Npgsql, System.Data ni GRLL. Crear dependencias en `CompositionRoot`.
- No agregar nuevos usos de mappers heredados, `dcGRLLDataContext`, `RRHHClass`, SqlClient, TableAdapters o estado estático en `Module1`.
- Los proyectos heredados están congelados según la arquitectura: solo retirar código migrado. No mover ni renombrar `Frm*` o `.resx`.
- SQL parametrizado; fechas tipadas; transacciones para operaciones relacionadas; entidades/DTO tipados. Indicar qué consulta/procedimiento se reemplaza.
- Migrar un caso de uso completo. No validar en PostgreSQL y escribir en SQL Server dentro del mismo flujo migrado.
- Antes de una refactorización funcional, registrar comportamiento actual, alcance, archivos/capas, riesgos, pasos, regresión y reversión en su spec. Reutilizar lo existente.
- `Software/referencia/` es material de consulta, fuera de la solución principal. No presentarlo como una funcionalidad integrada.

## IA y trabajo colaborativo

- Respetar los paquetes TEC-001…004 y sus specs: cada integrante implementa y hace sus commits; no sustituir el reparto de código por solo redacción o exposición de cambios anteriores.
- Trabajar en una rama por tarea, vinculada a un ID T2, TEC o CR. Para código, mantener una spec concreta; para documentación basta el entregable y su aceptación en el plan.
- La IA ayuda a analizar, redactar y programar; el integrante responsable comprueba el resultado y puede explicarlo. Registrar en el PR la ayuda material recibida y cómo se verificó.
- No asignar commits a otra persona ni simular revisiones. No integrar a `main`, publicar ni invitar colaboradores salvo instrucción expresa. Preparar cambios locales revisables dentro del alcance autorizado.
- Una revisión la realiza otro integrante. El autor corrige observaciones; el revisor comprueba aceptación y evidencia antes de aprobar.
- Para cada paquete TEC registrar también su CR-TEC, línea base, ingeniería inversa funcional/técnica y diagnóstico antes de implementar, según `docs/t2/PLAN_EQUIPO.md`. El feedback debe identificar archivo/caso, impacto, sugerencia y comprobación; no inventar revisiones ni defectos.

## Verificaciones y secretos

- Código: en Windows ejecutar `Software\scripts\build.cmd` y `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj`; cambios de datos/pantallas migradas requieren QA con datos ficticios. Seguir además la definición de terminado de arquitectura.
- Documentación: comprobar enlaces locales, IDs RF/CR, responsables, estados y cobertura de entregables; no requiere recompilar si no cambia código/configuración de ejecución.
- Si una verificación no puede ejecutarse, dejar motivo y responsable pendiente. No afirmar que pasó.
- Credenciales mediante `RRHH_POSTGRES_CONNECTION`, variables DB_* o `.env` local ignorado, según el cargador actual; secretos externos en CI/servidores. No versionar `.env`, dumps personales, claves, DLL licenciadas ni capturas con datos reales.
- Desde `eeeb817` hay puente PostgreSQL local para mappers/procedimientos. No inferir el proveedor por el nombre del mapper ni volver a portar una consulta sin revisar su implementación actual. El objetivo nuevo sigue siendo retirar ese acoplamiento hacia repositorios/casos específicos.
- El despliegue de BD lo coordina Francisco Kadin Valera Lizarraga. No ejecutar cambios contra su servidor sin un destino y alcance autorizados.
