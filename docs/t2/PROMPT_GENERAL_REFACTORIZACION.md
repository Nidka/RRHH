# Prompt general para refactorizar en RRHH

Este es el procedimiento común del equipo. Se combina con el rol y la spec
de cada integrante; no cambia el reparto de módulos. La arquitectura tiene
su fuente en `Software/docs/ARQUITECTURA.md` y ADR 0001.

Completar ID, responsable, revisor y alcance al iniciar. El bloque siguiente
se puede copiar a la IA del IDE o pedirle que lo lea desde este archivo.

```text
Trabaja en el proyecto RRHH aplicando este procedimiento a mi tarea.

ID de tarea / solicitud de cambio: <TEC-NNN / CR-TEC-NNN o CR-NNN>
Responsable: <integrante>
Revisor humano: <otro integrante>
Spec: <ruta de la especificación existente>
Rama de trabajo: <rama asignada>
Alcance autorizado: <pantallas, caso de uso o parte del esquema>

1. CONTEXTO Y LÍNEA BASE
Lee AGENTS.md, CONTRIBUTING.md, Software/docs/ARQUITECTURA.md, ADR 0001,
Software/docs/PLAN_REFACTORIZACION.md, docs/t2/PLAN_EQUIPO.md,
docs/t2/PRIMERA_PRUEBA.md y mi spec. Comprueba git status, rama, commit,
dependencias y versión de esquema. Conserva cambios ajenos y autoría real.
No reinicies trabajo ya realizado ni extiendas mi tarea a otros módulos.
Si falta información, registra la limitación y avanza lo independiente.

2. INGENIERÍA INVERSA Y DIAGNÓSTICO
Antes de editar identifica pantallas, entradas, acciones, reglas, salidas,
mensajes, métodos, llamadas y tablas. Reconstruye el flujo actual y registra
fuentes/versión y evidencia. Distingue original recibido, reconstrucción,
observación en ejecución, inferencia del código y propuesta futura.
Los mappers de compatibilidad actuales pueden usar PostgreSQL: inspecciona
el tipo y proveedor real antes de diagnosticar una dependencia SQL Server.
Cada problema debe indicar evidencia, impacto y recomendación concreta.

3. CLASIFICACIÓN DEL TRABAJO
Declara el tipo de mantenimiento principal y, si procede, secundarios:
- Preventivo: reducir riesgos futuros y mejorar estructura/mantenibilidad.
- Correctivo: corregir un defecto observado y documentado.
- Adaptativo: responder a un cambio de plataforma, entorno o integración.
- Perfectivo: mejorar capacidades, rendimiento o usabilidad solicitados.
Justifica la clasificación con el cambio concreto; no marques las cuatro
categorías por defecto. Refactorización es una técnica que reorganiza la
estructura conservando el comportamiento observable previsto.
Si también corriges un defecto o agregas una capacidad, separa su alcance,
aceptación, pruebas y explicación del refactor, preferiblemente en commits
coherentes distintos. No llames refactorización pura a cualquier cambio.

4. RESPETO DE ARQUITECTURA Y PATRONES
Mantén MVP con vista pasiva sobre las capas actuales:
- RecursosHumanos: formularios/controles y composición, sin reglas ni SQL.
- RRHH.Presentation: presenters y contratos View, sin WinForms/DevExpress.
- RRHH.Application: casos de uso, DTO y contratos de repositorio.
- RRHH.Domain: reglas y entidades puras, sin UI ni acceso a datos.
- RRHH.PostgreSql: repositorios, consultas y transacciones PostgreSQL.
Respeta las dependencias permitidas por ARQUITECTURA.md. CompositionRoot
crea y conecta dependencias; formularios/presenters no crean repositorios.
Usa el patrón MVP y contratos Repository en los flujos que se migran;
reutiliza la composición/fábricas existentes donde correspondan. Documenta
su propósito y las clases participantes. La inyección por constructor es
la técnica de provisión de dependencias; no la confundas con todos los
patrones ni con todos los principios SOLID.
Considera Strategy, Adapter u otro patrón solo ante variación/integración
real demostrada; justifica el problema y la simplicidad de la solución.
No añadas patrones para aumentar la cantidad. No reemplaces la arquitectura
vigente: una alternativa necesita su ADR y evaluación de impacto.

5. PRINCIPIOS CON EVIDENCIA EN CÓDIGO
Evalúa y documenta los que realmente correspondan:
- SRP: separar responsabilidades y motivos de cambio.
- DRY: extraer reglas/operaciones duplicadas sin unificar cosas distintas.
- OCP: aislar una variación real para extenderla conservando lógica estable;
  explicar qué se extiende, qué registro cambia y qué código se conserva.
- DIP: casos de uso dependen de contratos, no del proveedor de datos.
- IoC: dependencias suministradas desde composición, no creadas por el consumidor.
- ISP: contratos centrados en lo que necesita cada cliente, si hay un problema real.
- LSP: preservar contratos al sustituir implementaciones/subtipos, si existen.
Los temas expresos hasta T2 incluyen SRP/DRY, OCP e IoC. ISP/LSP no son una
cuota de implementación; no inventes jerarquías para poder mencionarlos.
Para cada principio reclamado señala archivo/método, antes/después,
beneficio concreto y prueba. Para patrones indica las clases participantes.
No clasifiques DRY o SOLID como patrones de diseño.

6. PLAN POR CAMBIO Y CONTROL
Completa la spec antes de implementar: alcance y límites, archivos/capas,
reglas confirmadas, aceptación, riesgos/dependencias, pasos, pruebas y reversión.
Registra la solicitud, su estado y el responsable de decisión/revisión según
PLAN_EQUIPO.md. No inventes aprobación del alcance ni revisión humana.
Trabaja en la rama asignada y conserva trazabilidad:
evidencia → diagnóstico → RF si aplica → CR → spec → commits → PR → pruebas.
Coordina esquema/migraciones con Kadin y cambios compartidos de MainMDI y
CompositionRoot; no reordenes esos archivos completos ni pises otros paquetes.

7. IMPLEMENTACIÓN
Realiza el cambio autorizado con pasos pequeños y coherentes. Conserva
nombres/recursos Frm*. No amplíes proyectos congelados salvo retirada de
código ya reemplazado. No agregues mappers de compatibilidad, SqlClient,
RRHHClass o DataContext a código nuevo. Completa el caso de uso migrado.
SQL con parámetros, fechas tipadas, entidades/DTO y transacciones donde
corresponda. Maneja nulos, errores, cancelación, selección inválida y
concurrencia según los riesgos reales. No inventes reglas de negocio.
Aplica la sección Documentación del código de AGENTS.md: comentarios XML
/// en español para tipos nuevos, contratos y operaciones relevantes.
Explica propósito, nulos, resultados, errores, escrituras y límites cuando
corresponda; actualiza los comentarios con el cambio y evita repetir lo obvio.
No accedas a secretos de .env para mostrarlos en el chat o documentación;
usa la configuración local sin volcarla. No escribas datos en un servidor
sin destino/alcance autorizados ni ejecutes limpieza destructiva implícita.

8. PRUEBAS Y ACEPTACIÓN
Caracteriza el comportamiento válido anterior y verifica su conservación.
Una corrección requiere reproducir el defecto y comprobar su solución.
Prueba reglas/casos/presenters, errores y límites relevantes, sin pruebas
que se limiten a repetir la implementación. Para código ejecuta en Windows:
Software\scripts\build.cmd
dotnet test Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
Si cambia SQL, ejecuta además Software\scripts\check-postgresql.cmd -Modules.
Comprueba el recorrido UI y escrituras en QA con datos ficticios; para
esquema, precondiciones, compatibilidad, concurrencia y restauración aplicables.
Documenta entorno, casos, esperado/obtenido y evidencia. Si no puedes
ejecutar algo, indica la limitación y el siguiente responsable/paso; no lo
declares aprobado. No cierres el cambio solo porque compile.

9. DIAGRAMAS Y EVIDENCIAS T2
Genera los diagramas de mi rol según PROMPTS_POR_INTEGRANTE.md. Para mi
refactor incluye flujo actual/propuesto y responsabilidades/dependencias
que ayuden a explicarlo; evita duplicar diagramas globales de otro autor.
Los diagramas globales T2-04 los coordina Evelyn y los encarga a Kadin por
texto: flujos en Bizagi y módulos como componentes en Modelio. Consulta
PLAN_EQUIPO.md para su alcance y entrega. Mermaid sirve para anexos técnicos del refactor;
no sustituye los entregables en las herramientas indicadas por el docente.
Incluye fuente, commit, autor, alcance y leyenda observado/inferido/propuesto.
Revisa coherencia y sintaxis; declara si no pudiste renderizarlo. No presentes
dibujos propuestos como funcionamiento observado.
Guarda diagramas en docs/t2/diagramas/<ID>/, análisis en docs/t2/aportes/<ID>/
y evidencias reales en docs/t2/evidencias/<ID>/. No inventes capturas.
Relaciona problemas y decisiones con el informe y RF, sin cerrar un RF
completo por una mejora parcial. La entrega global conserva los 18 RF,
18 CR funcionales, plan, al menos cuatro propuestas y los 16 apartados.

10. REVISIÓN, ENTREGA Y EXPOSICIÓN
Prepara commits con mi ID y la identidad Git existente; no atribuyas trabajo
a otros. Registra asistencia de IA y qué verificó la persona responsable.
Prepara PR con alcance, spec, antes/después, clasificación, principios,
patrones, pruebas, diagramas, riesgo y reversión. Publica la rama/abre PR
cuando esté autorizado por el usuario; no integres a main sin autorización
y revisión ajena. El autor responde al feedback y el revisor verifica lo corregido.
El feedback debe indicar archivo/caso, problema, impacto, sugerencia y comprobación;
distingue bloqueos de sugerencias y no fabriques observaciones ni aprobaciones.
Entrega también una explicación breve para la exposición de 20 minutos:
problema → código anterior → cambio → principio/patrón → mantenimiento → prueba.
Finaliza con lo implementado, verificado, pendiente y bloqueado, con enlaces reales.
```

## Clasificación actual de nuestros paquetes

Evaluación inicial, pendiente de contrastar con el cambio que finalmente se implemente:

| Paquete | Mantenimiento principal previsto | Técnica o cambio | Qué se clasifica aparte |
|---|---|---|---|
| TEC-001, horarios | Preventivo | Extraer reglas/casos/presenters/repositorio y reducir acoplamiento conservando comportamiento | Defectos reproducidos: correctivo. La conexión PostgreSQL ya existe; no contar otra migración de motor por rutina |
| TEC-003, feriados | Preventivo | Separar flujo y persistencia del formulario y del puente genérico | Duplicados/concurrencia solo se presentan como corrección si se demuestra el defecto; nuevas reglas requieren decisión |
| TEC-004, motivos | Preventivo | Extraer responsabilidades y centralizar recargas repetidas | Eliminar una escritura involuntaria al abrir es correctivo si se reproduce; documentar ese cambio de comportamiento |
| TEC-002, integridad de BD | Preventivo en la etapa pendiente de integridad/IDs | Perfilado, migraciones y garantías de datos; no es por sí solo un refactor de código | Despliegue/adaptación de entorno: adaptativo, ya informado. Una limpieza/corrección de datos tiene alcance separado |

La ampliación de capacidades solicitadas puede ser perfectiva; no es el
objetivo principal de los tres refactors actuales. La categoría se asigna
al cambio concreto y se justifica, no a toda la aplicación de una sola vez.

## Cuándo considerar el paquete listo para revisión

- La spec contiene clasificación, diseño y aceptación verificable.
- Hay código dentro del alcance y arquitectura, no solo un nuevo diagrama.
- Principios y patrones están vinculados a archivos y métodos reales.
- Pruebas/QA y limitaciones están registradas, con evidencia antes/después.
- Diagramas, CR, documentación y propuesta de PR corresponden al mismo cambio.
- El material permite defender el avance dentro de los 20 minutos del equipo.

Estas son reglas de ejecución del equipo para atender la pauta. Los patrones
opcionales y el número de commits no se convierten en requisitos adicionales
del docente.
