# Prompts por integrante para trabajar en su IDE

Copiar **un bloque completo**, el del integrante correspondiente, en la IA de su IDE con el repositorio abierto. Cada bloque incluye las reglas comunes y su rol. No hace falta copiar esta conversación. Las IAs se coordinan mediante archivos versionados, specs, commits, PR y revisión humana; no asumir memoria compartida entre sesiones.

**Base del equipo:** `origin/docs/t2-organizacion-specs` mientras estos planes no estén integrados en main. Después de `git fetch origin`, crear cada rama de tarea desde esa base compartida. Si ya existe una rama con cambios, conservarla y coordinar la incorporación de los documentos. Integrar primero el PR de organización antes de los PR de implementación. No indicar que los archivos están en main hasta integrarlos realmente.

Cada persona es responsable de comprender, validar y explicar el trabajo asistido por IA. Los prompts no acreditan avance ni aprobación del docente. Actualización 18/10/2026: Evelyn coordina los diagramas globales T2-04 y encarga su elaboración a Kadin mediante instrucciones por texto. Él entrega los editables y exportaciones; Evelyn coordina revisión e incorporación al informe y repositorio. Alcance en [PLAN_EQUIPO.md](PLAN_EQUIPO.md#responsables-y-revisión-cruzada).

**Situación de BD:** desplegada según Evelyn; conexión/esquema comprobados por psql. Antes de cambiar código, todos siguen [PRIMERA_PRUEBA.md](PRIMERA_PRUEBA.md) en Windows y registran sus resultados. El login RRHH requiere credenciales de aplicación diferentes de las de conexión.

## Procedimiento común para todos los roles

Usar [PROMPT_GENERAL_REFACTORIZACION.md](PROMPT_GENERAL_REFACTORIZACION.md)
como instrucción general junto con el bloque personal. El procedimiento
incluye arquitectura, MVP/Repository, principios justificables, tipo de
mantenimiento y separación entre refactor y corrección, además de diagramas,
pruebas y control de cambios. Las instrucciones personales delimitan quién
hace qué; no reemplazan las reglas comunes.

## Cobertura de diagramas

| Integrante | Diagramas a producir y sustentar |
|---|---|
| Jorge | Arquitectura actual/objetivo y propuestas de diagnóstico; el paquete horarios continúa con Evelyn |
| Kadin | Elabora mapa global, componentes en Modelio y cinco flujos en Bizagi por encargo de Evelyn; conserva además el análisis de datos de su paquete |
| Frank | Feriados antes/después; aporta exploración de asistencia/reportes a Evelyn |
| Evelyn | Motivos y horarios antes/después; coordina mapa, módulos y los cinco flujos globales que elabora Kadin |

Para cada diagrama incluir alcance, fuente/versión, autor, fecha, leyenda observado/inferido/propuesto y vínculos a evidencia. Acompañar los flujos con entradas/procesos/salidas y reglas. El flujo de BD apoya a los módulos consumidores; no reemplaza los cinco flujos funcionales requeridos. Un diagrama hipotético no cumple por sí solo la evidencia funcional observada.

## Continuación de TEC-001, asumida por Evelyn

Desde el 18/10/2026 Evelyn asume este paquete inicialmente asignado a
Jorge/Kike. El bloque siguiente refleja esa continuación; no reasigna sus
tareas de diagnóstico/arquitectura ni atribuye a Jorge los cambios de Evelyn.

```text
Soy Evelyn Victoria Rodriguez Cardozo. Asumo la continuación de TEC-001, solicitud CR-TEC-001, inicialmente asignada a Jorge/Kike.
Mi rama: refactor/tec-001-horarios-evelyn.
Mi spec: specs/TEC-001-horarios.md.
Mi revisor humano: Evelyn Victoria Rodriguez Cardozo.

Lee y aplica docs/t2/PROMPT_GENERAL_REFACTORIZACION.md como procedimiento común obligatorio, junto con mi spec. Antes de editar declara mantenimiento principal/secundario, técnica de refactor, patrones (MVP/Repository y los realmente necesarios), principios con archivos/métodos y comportamiento que se conserva. Separa correcciones o capacidades nuevas con aceptación propia. Respeta arquitectura, dependencias y composición; no agregues patrones por cantidad. Sigue también sus requisitos de pruebas, diagramas, control de cambios y revisión.

Trabajamos en el proyecto académico RRHH para T2 de Evolución y Configuración de Software. Necesito que ejecutes mi parte: ingeniería inversa, diagnóstico, cambio de código, pruebas y documentación trazable. No te limites a explicar teoría ni a documentar el cambio de otro integrante.

Primero revisa git status y la rama actual. Lee AGENTS.md, CONTRIBUTING.md, Software/docs/ARQUITECTURA.md, Software/docs/adr/0001-mvp-sobre-capas.md, Software/docs/PLAN_REFACTORIZACION.md, docs/t2/PLAN_EQUIPO.md, docs/t2/ENTREGA_Y_EVIDENCIAS.md y mi spec indicada abajo. Si faltan archivos del reparto, indícalo y pide sincronizar la rama que los contiene; mientras tanto inspecciona el código sin cambiar la arquitectura ni inventar instrucciones ausentes. No borres cambios ajenos.

La base actual es eeeb817, con despliegue informado por Kadin y soporte .env. Lee docs/t2/PRIMERA_PRUEBA.md y empieza probando la aplicación antes de editar; los diagnósticos originales de las specs se basaban en 0a4b6a8 y deben revalidarse. Los mappers tienen ahora un puente PostgreSQL local: no deduzcas SQL Server solo por su nombre. Nunca leas, muestres o pegues secretos de .env en la conversación o evidencias; basta comprobar claves/presencia si hace falta. Mientras el PR de organización no esté integrado, crea mi rama desde origin/docs/t2-organizacion-specs, que contiene las reglas y specs. Si ya están integradas, parte de main actualizado. Usa mi rama indicada o continúa esa misma rama si ya existe. No crees ramas duplicadas ni cambies la identidad Git a la de otro integrante.

Antes de editar registra comportamiento, entradas/procesos/salidas, reglas, métodos, llamadas y tablas; distingue ejecutable original, reconstrucción e hipótesis del código. Completa la spec con evidencia y limitaciones. Mantén MVP de vista pasiva: reglas en Domain, casos/contratos en Application, presenters/contratos View en Presentation y repositorios parametrizados en PostgreSql. CompositionRoot ensambla; no agregar mappers/SqlClient/RRHHClass, ni renombrar Frm* o .resx. Respeta los proyectos congelados.

Implementa mi paquete con pruebas significativas y cambios enfocados, siguiendo la spec. Si faltan datos o un contrato indispensable, registra el bloqueo y continúa trabajo independiente; no inventes reglas. Para ejecutar cambios en BD necesitas destino y alcance autorizados. No subas secretos ni datos personales. No implementes los otros paquetes o los 18 RF completos.

Guarda mis entregables de análisis en docs/t2/aportes/TEC-001/ y mis diagramas Mermaid en docs/t2/diagramas/TEC-001/. Crea evidencia real en docs/t2/evidencias/TEC-001/ con IDs que incluyan el paquete, fecha, autor, versión, pasos y resultado. Si no puedes ejecutar WinForms, deja un protocolo de captura/prueba pendiente para mí: no fabriques capturas ni resultados. Un diagrama deducido del código se etiqueta como tal; un flujo nuevo propuesto no se presenta como observado.

Trabaja hacia commits coherentes con mi ID de tarea usando la identidad Git ya configurada; registra la asistencia de IA. Prepara el PR con solicitud CR-TEC, RF si aplica, antes/después, principio, tipo de mantenimiento, pruebas y riesgos/reversión. No publiques ni integres a main sin instrucción expresa y revisión ajena. Para código verifica build y suite en Windows y QA con datos ficticios, o informa claramente qué no se ejecutó y por qué.

Al terminar entrega: archivos cambiados; diagnóstico; diagramas y evidencia disponibles; pruebas ejecutadas/pendientes; commits creados o sugeridos si no fue posible crearlos; feedback técnico fundamentado y una explicación breve para mi exposición. Distingue implementado, verificado, propuesto y bloqueado. No atribuyas a otro integrante autoría o aprobación que no conste.

Mi alcance particular:

Mi paquete de código es listado y mantenimiento de horarios: FrmHorarios.cs y FrmMantHorarios.cs, con sus casos de uso, repositorio, presenters, composición y pruebas. Completa ambas vistas; no refactorices solo el editor dejando el listado acoplado al mapper genérico. No implementar aún turnos por periodos/histórico (RF-01/02), ni sincronización de equipos sin contrato.

Mis diagramas: arquitectura actual/objetivo diferenciadas y flujo de consulta/alta/edición/borrado de horarios antes/después. No duplico los globales T2-04, que coordina Evelyn y elabora Kadin. Cada elemento tiene fuente o marca de hipótesis. Mi análisis alimenta ingeniería inversa técnica y propuestas de refactorización; explica SRP, DRY e inyección donde realmente se apliquen.

Coordina con Kadin el contrato de IDs de Horario. No cambies sus migraciones. Limita mis ediciones de MainMDI/CompositionRoot a conectar horarios y documenta ese punto compartido. La revisión humana de esta continuación está pendiente de asignar a otra persona. Evelyn solicitó integrar directamente esta tarea en main; no inventes aprobación ajena ni resultados de QA Windows.
```

## Prompt de Kadin

```text
Soy Francisco Kadin Valera Lizarraga. Mi rol es responsable de TEC-002, solicitud CR-TEC-002.
Mi rama: infra/tec-002-integridad-bd.
Mi spec: specs/TEC-002-integridad-bd.md.
Mi revisor humano: Jorge Enrique Cano Asto.

Lee y aplica docs/t2/PROMPT_GENERAL_REFACTORIZACION.md como procedimiento común obligatorio, junto con mi spec. Antes de editar declara mantenimiento principal/secundario, técnica de refactor, patrones (MVP/Repository y los realmente necesarios), principios con archivos/métodos y comportamiento que se conserva. Separa correcciones o capacidades nuevas con aceptación propia. Respeta arquitectura, dependencias y composición; no agregues patrones por cantidad. Sigue también sus requisitos de pruebas, diagramas, control de cambios y revisión.

Trabajamos en el proyecto académico RRHH para T2 de Evolución y Configuración de Software. Necesito que ejecutes mi parte: ingeniería inversa, diagnóstico, cambio de código, pruebas y documentación trazable. No te limites a explicar teoría ni a documentar el cambio de otro integrante.

Primero revisa git status y la rama actual. Lee AGENTS.md, CONTRIBUTING.md, Software/docs/ARQUITECTURA.md, Software/docs/adr/0001-mvp-sobre-capas.md, Software/docs/PLAN_REFACTORIZACION.md, docs/t2/PLAN_EQUIPO.md, docs/t2/ENTREGA_Y_EVIDENCIAS.md y mi spec indicada abajo. Si faltan archivos del reparto, indícalo y pide sincronizar la rama que los contiene; mientras tanto inspecciona el código sin cambiar la arquitectura ni inventar instrucciones ausentes. No borres cambios ajenos.

La base actual es eeeb817, con despliegue informado por Kadin y soporte .env. Lee docs/t2/PRIMERA_PRUEBA.md y empieza probando la aplicación antes de editar; los diagnósticos originales de las specs se basaban en 0a4b6a8 y deben revalidarse. Los mappers tienen ahora un puente PostgreSQL local: no deduzcas SQL Server solo por su nombre. Nunca leas, muestres o pegues secretos de .env en la conversación o evidencias; basta comprobar claves/presencia si hace falta. Mientras el PR de organización no esté integrado, crea mi rama desde origin/docs/t2-organizacion-specs, que contiene las reglas y specs. Si ya están integradas, parte de main actualizado. Usa mi rama indicada o continúa esa misma rama si ya existe. No crees ramas duplicadas ni cambies la identidad Git a la de otro integrante.

Antes de editar registra comportamiento, entradas/procesos/salidas, reglas, métodos, llamadas y tablas; distingue ejecutable original, reconstrucción e hipótesis del código. Completa la spec con evidencia y limitaciones. Mantén MVP de vista pasiva: reglas en Domain, casos/contratos en Application, presenters/contratos View en Presentation y repositorios parametrizados en PostgreSql. CompositionRoot ensambla; no agregar mappers/SqlClient/RRHHClass, ni renombrar Frm* o .resx. Respeta los proyectos congelados.

Implementa mi paquete con pruebas significativas y cambios enfocados, siguiendo la spec. Si faltan datos o un contrato indispensable, registra el bloqueo y continúa trabajo independiente; no inventes reglas. Para ejecutar cambios en BD necesitas destino y alcance autorizados. No subas secretos ni datos personales. No implementes los otros paquetes o los 18 RF completos.

Guarda mis entregables de análisis en docs/t2/aportes/TEC-002/ y mis diagramas Mermaid en docs/t2/diagramas/TEC-002/. Crea evidencia real en docs/t2/evidencias/TEC-002/ con IDs que incluyan el paquete, fecha, autor, versión, pasos y resultado. Si no puedes ejecutar WinForms, deja un protocolo de captura/prueba pendiente para mí: no fabriques capturas ni resultados. Un diagrama deducido del código se etiqueta como tal; un flujo nuevo propuesto no se presenta como observado.

Trabaja hacia commits coherentes con mi ID de tarea usando la identidad Git ya configurada; registra la asistencia de IA. Prepara el PR con solicitud CR-TEC, RF si aplica, antes/después, principio, tipo de mantenimiento, pruebas y riesgos/reversión. No publiques ni integres a main sin instrucción expresa y revisión ajena. Para código verifica build y suite en Windows y QA con datos ficticios, o informa claramente qué no se ejecutó y por qué.

Al terminar entrega: archivos cambiados; diagnóstico; diagramas y evidencia disponibles; pruebas ejecutadas/pendientes; commits creados o sugeridos si no fue posible crearlos; feedback técnico fundamentado y una explicación breve para mi exposición. Distingue implementado, verificado, propuesto y bloqueado. No atribuyas a otro integrante autoría o aprobación que no conste.

Mi alcance particular:

Mi paquete es diagnóstico, integridad/IDs y despliegue QA de BD, delimitado a Horario, RRHH_Feriado y Motivo_Perm y las dependencias verificadas. El despliegue ya fue informado como completado; comprueba su estado, documenta su evidencia y continúa integridad/IDs sin redesplegar por rutina. Primero publica el contrato de tablas/columnas/IDs y compatibilidad que necesitan los otros tres; no esperes a desplegar para documentarlo. Prepara migraciones numeradas con precondiciones, secuencias/identidad por encima de IDs existentes, PK/FK aplicables y restauración. No elimines duplicados ni datos reales automáticamente, ni reconstruyas toda la base.

Mis diagramas técnicos: entidad-relación del alcance y dependencias relevantes, distinguiendo FK realmente declaradas de relaciones inferidas; despliegue según entorno confirmado o propuesta etiquetada. Entrego diccionario de datos acotado, perfilado saneado, plan/migraciones, pruebas de concurrencia/integridad y runbook reproducible. Si faltan claves, difiero la FK y documento el riesgo. Además, Evelyn me encarga T2-04 por texto: mapa global, componentes en Modelio y cinco flujos en Bizagi. Le entrego editables/exportaciones para revisión e incorporación, sin ampliar la implementación de BD a esos módulos.

Coordina IDs con Jorge/Frank/Evelyn. No edites sus pantallas ni declares un despliegue por crear scripts. Mi revisor es Jorge; prepara las comprobaciones y restauración para que revise el resultado real.
```

## Prompt de Frank

```text
Soy Frank Piero Mantilla Arqueros. Mi rol es responsable de TEC-003, solicitud CR-TEC-003.
Mi rama: refactor/tec-003-feriados.
Mi spec: specs/TEC-003-feriados.md.
Mi revisor humano: Francisco Kadin Valera Lizarraga.

Lee y aplica docs/t2/PROMPT_GENERAL_REFACTORIZACION.md como procedimiento común obligatorio, junto con mi spec. Antes de editar declara mantenimiento principal/secundario, técnica de refactor, patrones (MVP/Repository y los realmente necesarios), principios con archivos/métodos y comportamiento que se conserva. Separa correcciones o capacidades nuevas con aceptación propia. Respeta arquitectura, dependencias y composición; no agregues patrones por cantidad. Sigue también sus requisitos de pruebas, diagramas, control de cambios y revisión.

Trabajamos en el proyecto académico RRHH para T2 de Evolución y Configuración de Software. Necesito que ejecutes mi parte: ingeniería inversa, diagnóstico, cambio de código, pruebas y documentación trazable. No te limites a explicar teoría ni a documentar el cambio de otro integrante.

Primero revisa git status y la rama actual. Lee AGENTS.md, CONTRIBUTING.md, Software/docs/ARQUITECTURA.md, Software/docs/adr/0001-mvp-sobre-capas.md, Software/docs/PLAN_REFACTORIZACION.md, docs/t2/PLAN_EQUIPO.md, docs/t2/ENTREGA_Y_EVIDENCIAS.md y mi spec indicada abajo. Si faltan archivos del reparto, indícalo y pide sincronizar la rama que los contiene; mientras tanto inspecciona el código sin cambiar la arquitectura ni inventar instrucciones ausentes. No borres cambios ajenos.

La base actual es eeeb817, con despliegue informado por Kadin y soporte .env. Lee docs/t2/PRIMERA_PRUEBA.md y empieza probando la aplicación antes de editar; los diagnósticos originales de las specs se basaban en 0a4b6a8 y deben revalidarse. Los mappers tienen ahora un puente PostgreSQL local: no deduzcas SQL Server solo por su nombre. Nunca leas, muestres o pegues secretos de .env en la conversación o evidencias; basta comprobar claves/presencia si hace falta. Mientras el PR de organización no esté integrado, crea mi rama desde origin/docs/t2-organizacion-specs, que contiene las reglas y specs. Si ya están integradas, parte de main actualizado. Usa mi rama indicada o continúa esa misma rama si ya existe. No crees ramas duplicadas ni cambies la identidad Git a la de otro integrante.

Antes de editar registra comportamiento, entradas/procesos/salidas, reglas, métodos, llamadas y tablas; distingue ejecutable original, reconstrucción e hipótesis del código. Completa la spec con evidencia y limitaciones. Mantén MVP de vista pasiva: reglas en Domain, casos/contratos en Application, presenters/contratos View en Presentation y repositorios parametrizados en PostgreSql. CompositionRoot ensambla; no agregar mappers/SqlClient/RRHHClass, ni renombrar Frm* o .resx. Respeta los proyectos congelados.

Implementa mi paquete con pruebas significativas y cambios enfocados, siguiendo la spec. Si faltan datos o un contrato indispensable, registra el bloqueo y continúa trabajo independiente; no inventes reglas. Para ejecutar cambios en BD necesitas destino y alcance autorizados. No subas secretos ni datos personales. No implementes los otros paquetes o los 18 RF completos.

Guarda mis entregables de análisis en docs/t2/aportes/TEC-003/ y mis diagramas Mermaid en docs/t2/diagramas/TEC-003/. Crea evidencia real en docs/t2/evidencias/TEC-003/ con IDs que incluyan el paquete, fecha, autor, versión, pasos y resultado. Si no puedes ejecutar WinForms, deja un protocolo de captura/prueba pendiente para mí: no fabriques capturas ni resultados. Un diagrama deducido del código se etiqueta como tal; un flujo nuevo propuesto no se presenta como observado.

Trabaja hacia commits coherentes con mi ID de tarea usando la identidad Git ya configurada; registra la asistencia de IA. Prepara el PR con solicitud CR-TEC, RF si aplica, antes/después, principio, tipo de mantenimiento, pruebas y riesgos/reversión. No publiques ni integres a main sin instrucción expresa y revisión ajena. Para código verifica build y suite en Windows y QA con datos ficticios, o informa claramente qué no se ejecutó y por qué.

Al terminar entrega: archivos cambiados; diagnóstico; diagramas y evidencia disponibles; pruebas ejecutadas/pendientes; commits creados o sugeridos si no fue posible crearlos; feedback técnico fundamentado y una explicación breve para mi exposición. Distingue implementado, verificado, propuesto y bloqueado. No atribuyas a otro integrante autoría o aprobación que no conste.

Mi alcance particular:

Mi paquete de código es FrmFeriado.cs: listado, alta, duplicación de día y borrado, con dominio, casos, repositorio, presenter, composición y pruebas. Sustituye el acoplamiento a RRHHClass/mappers de compatibilidad por un flujo con casos de uso/repositorio específico; coordina con Kadin IDs, representación de fecha y garantía concurrente. No marques RF-17 completo: el cálculo del reporte general queda fuera de este cambio.

Mis diagramas: flujo de feriados antes/después. Mantengo la exploración funcional y aporto fuentes, entradas/procesos/salidas y evidencia de asistencia/reportes a Evelyn, quien coordina los diagramas globales T2-04. Esto no autoriza migrar esos módulos ni fabricar recorridos no comprobados.

Entrega capturas reales disponibles y protocolo de exploración para las pendientes; diagnóstico y prueba de regresión. Limita mis ediciones de MainMDI/CompositionRoot a feriados. Mi revisor es Kadin: debe comprobar persistencia e integridad, no solo leer el código.
```

## Prompt de Evelyn

```text
Soy Evelyn Victoria Rodriguez Cardozo. Mi rol es responsable de TEC-004, solicitud CR-TEC-004.
Mi rama: refactor/tec-004-motivos-permiso.
Mi spec: specs/TEC-004-motivos-permiso.md.
Mi revisor humano: Frank Piero Mantilla Arqueros.

Lee y aplica docs/t2/PROMPT_GENERAL_REFACTORIZACION.md como procedimiento común obligatorio, junto con mi spec. Antes de editar declara mantenimiento principal/secundario, técnica de refactor, patrones (MVP/Repository y los realmente necesarios), principios con archivos/métodos y comportamiento que se conserva. Separa correcciones o capacidades nuevas con aceptación propia. Respeta arquitectura, dependencias y composición; no agregues patrones por cantidad. Sigue también sus requisitos de pruebas, diagramas, control de cambios y revisión.

Trabajamos en el proyecto académico RRHH para T2 de Evolución y Configuración de Software. Necesito que ejecutes mi parte: ingeniería inversa, diagnóstico, cambio de código, pruebas y documentación trazable. No te limites a explicar teoría ni a documentar el cambio de otro integrante.

Primero revisa git status y la rama actual. Lee AGENTS.md, CONTRIBUTING.md, Software/docs/ARQUITECTURA.md, Software/docs/adr/0001-mvp-sobre-capas.md, Software/docs/PLAN_REFACTORIZACION.md, docs/t2/PLAN_EQUIPO.md, docs/t2/ENTREGA_Y_EVIDENCIAS.md y mi spec indicada abajo. Si faltan archivos del reparto, indícalo y pide sincronizar la rama que los contiene; mientras tanto inspecciona el código sin cambiar la arquitectura ni inventar instrucciones ausentes. No borres cambios ajenos.

La base actual es eeeb817, con despliegue informado por Kadin y soporte .env. Lee docs/t2/PRIMERA_PRUEBA.md y empieza probando la aplicación antes de editar; los diagnósticos originales de las specs se basaban en 0a4b6a8 y deben revalidarse. Los mappers tienen ahora un puente PostgreSQL local: no deduzcas SQL Server solo por su nombre. Nunca leas, muestres o pegues secretos de .env en la conversación o evidencias; basta comprobar claves/presencia si hace falta. Mientras el PR de organización no esté integrado, crea mi rama desde origin/docs/t2-organizacion-specs, que contiene las reglas y specs. Si ya están integradas, parte de main actualizado. Usa mi rama indicada o continúa esa misma rama si ya existe. No crees ramas duplicadas ni cambies la identidad Git a la de otro integrante.

Antes de editar registra comportamiento, entradas/procesos/salidas, reglas, métodos, llamadas y tablas; distingue ejecutable original, reconstrucción e hipótesis del código. Completa la spec con evidencia y limitaciones. Mantén MVP de vista pasiva: reglas en Domain, casos/contratos en Application, presenters/contratos View en Presentation y repositorios parametrizados en PostgreSql. CompositionRoot ensambla; no agregar mappers/SqlClient/RRHHClass, ni renombrar Frm* o .resx. Respeta los proyectos congelados.

Implementa mi paquete con pruebas significativas y cambios enfocados, siguiendo la spec. Si faltan datos o un contrato indispensable, registra el bloqueo y continúa trabajo independiente; no inventes reglas. Para ejecutar cambios en BD necesitas destino y alcance autorizados. No subas secretos ni datos personales. No implementes los otros paquetes o los 18 RF completos.

Guarda mis entregables de análisis en docs/t2/aportes/TEC-004/ y mis diagramas Mermaid en docs/t2/diagramas/TEC-004/. Crea evidencia real en docs/t2/evidencias/TEC-004/ con IDs que incluyan el paquete, fecha, autor, versión, pasos y resultado. Si no puedes ejecutar WinForms, deja un protocolo de captura/prueba pendiente para mí: no fabriques capturas ni resultados. Un diagrama deducido del código se etiqueta como tal; un flujo nuevo propuesto no se presenta como observado.

Trabaja hacia commits coherentes con mi ID de tarea usando la identidad Git ya configurada; registra la asistencia de IA. Prepara el PR con solicitud CR-TEC, RF si aplica, antes/después, principio, tipo de mantenimiento, pruebas y riesgos/reversión. No publiques ni integres a main sin instrucción expresa y revisión ajena. Para código verifica build y suite en Windows y QA con datos ficticios, o informa claramente qué no se ejecutó y por qué.

Al terminar entrega: archivos cambiados; diagnóstico; diagramas y evidencia disponibles; pruebas ejecutadas/pendientes; commits creados o sugeridos si no fue posible crearlos; feedback técnico fundamentado y una explicación breve para mi exposición. Distingue implementado, verificado, propuesto y bloqueado. No atribuyas a otro integrante autoría o aprobación que no conste.

Mi alcance particular:

Mi paquete de código es FrmMotivoPermiso.cs y FrmMantMotivo.cs: listado por tipo/modalidad, alta/edición y borrado seguro por capas. Quita escrituras al abrir el editor y centraliza recargas. Caracteriza los roles y el contrato de spRRHH_getMotivo_perm, ahora implementado en PostgreSqlLegacyContext, antes de sustituirlo; no inventes su filtro ni supongas equivalencia con el SQL Server original sin evidencia. Coordina IDs/referencias con Kadin y conserva campos no editados. No migres el registro de permisos ni licencias completas en este paquete.

Mis diagramas: flujo de motivos antes/después. Coordino los globales T2-04 y encargo a Kadin por texto el mapa, módulos y flujos de asistencia, permisos, licencias, vacaciones y reportes. Reviso los editables/exportaciones que me entregue e incorporo el material aceptado al informe y repositorio; alcance en PLAN_EQUIPO.md. Estos flujos son análisis, no implementación. Si no hay un recorrido accesible de vacaciones/licencias, registro búsqueda, limitación y preguntas pendientes; las propuestas futuras van separadas y etiquetadas.

Además reviso las matrices de 18 RF y 18 CR, las cuatro CR-TEC, el plan y la cobertura de los 16 apartados del informe. Integra los aportes reales de los otros tres con enlaces; marca lo que todavía no entregaron sin inventarlo ni apropiarte de sus cambios. Conserva las responsabilidades del equipo. Limita MainMDI/CompositionRoot a motivos. Mi revisor es Frank. Prepara material para explicar mi cambio y la trazabilidad, además de integrar el informe.
```

## Prompt de continuidad para cualquiera de los cuatro

Usarlo en la misma rama, sustituyendo el ID. Evita reiniciar la tarea o repetir trabajo terminado.

```text
Continúa mi paquete TEC-NNN. Aplica docs/t2/PROMPT_GENERAL_REFACTORIZACION.md y relee AGENTS.md, la spec, el plan de equipo, git status y el diff actual. Comprueba qué ya está hecho, conserva cambios ajenos y retoma el siguiente paso pendiente. Actualiza evidencia, decisiones y bloqueos reales. No reinicies el diseño ni declares verificaciones no ejecutadas. Al terminar indica qué avanzó, qué falta y qué necesita mi revisor.
```

## Prompt para revisión cruzada

La sesión del revisor debe tener acceso al diff/PR real. Sustituir ID y enlace/ramas; no ejecutar con datos de ejemplo como si fueran una revisión real.

```text
Soy el revisor humano asignado al paquete TEC-NNN. Ayúdame a revisar el PR <enlace o diff entre ramas>, sin aprobarlo ni integrarlo por mí. Lee las reglas, docs/t2/PROMPT_GENERAL_REFACTORIZACION.md, spec y aceptación; comprueba la clasificación de mantenimiento, patrones/principios y arquitectura. Revisa código, pruebas, línea base, diagramas/evidencias y compatibilidad con BD. Comprueba cobertura T2 y si se afirma algo sin evidencia. Devuelve hallazgos por prioridad: archivo/método o caso, problema, impacto, sugerencia y cómo verificar. Separa correcciones necesarias de sugerencias; si no hay hallazgos, explica qué revisaste y qué no pudiste ejecutar. No fabriques observaciones ni autoría y no modifiques el trabajo del autor salvo que yo lo pida.
```
