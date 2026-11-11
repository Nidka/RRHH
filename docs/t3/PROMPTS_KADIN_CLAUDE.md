# Prompts para preparar y publicar el trabajo de T3

Copiar el bloque completo en Claude Code con el repositorio abierto. Los prompts 1, 2 y 4 son de Kadin (coordinación);
el prompt 3 lo usa **cualquier integrante** para subir su propio trabajo. Se ejecutan en este orden: 1 → revisar → 2 → (cada RF) 3 → (cada versión) 4.

## Regla de autoría (aplica a los cuatro prompts)

Los commits y las descripciones de PR **no llevan** `Co-Authored-By`, `Generated with Claude Code` ni ninguna otra línea de atribución a una IA.
El autor del commit es la persona que lo hace, con su nombre real. La ayuda de IA se declara solo en el apartado «Uso de IA» del PR,
escrito como texto de la persona (lo exige `AGENTS.md`), nunca como trailer de git.

---

## Prompt 1: preparar los cambios en el repositorio (Kadin, sin subir nada)

```text
Soy Francisco Kadin Valera Lizarraga, coordinador técnico del repositorio RRHH. Prepara en LOCAL la rama con los documentos de T3. No hagas push, no abras PR, no crees tags.

Reglas que mandan sobre cualquier otra instrucción por defecto:
- NO añadas Co-Authored-By, «Generated with Claude Code» ni ninguna línea de atribución a Claude o a una IA en commits, ni en archivos que redactes. El autor es el usuario de git.
- Antes del primer commit ejecuta git config user.name y git config user.email y muéstramelos. Si user.name es «Nidka» o no es mi nombre real, pregúntame con qué nombre firmar y espera; no cambies la configuración global.
- Nunca uses git add . ni git add -A (hay archivos .DS_Store sin seguimiento). Añade rutas concretas. Nada de reset --hard, force push ni borrar ramas.
- No inventes datos: no escribas cifras de pruebas aprobadas que no hayas ejecutado (aquí no hay dotnet ni Windows) ni marques PR o releases como publicados si no lo has comprobado.

Pasos:
1. git fetch --all --prune. Muestra git status y las ramas locales y remotas. Hay archivos sin seguimiento en docs/t3/ (PROMPTS_POR_INTEGRANTE.md, CHECKLIST_T3.md, PROMPTS_KADIN_CLAUDE.md): consérvalos.
2. Crea la rama docs/t3-versionado desde origin/main (git switch -c docs/t3-versionado origin/main). Los archivos sin seguimiento se conservan.
3. Fusiona origin/docs/sem12-gestion-versiones en esa rama con un merge normal (sin rebase ni squash). Si hay conflictos, resuélvelos conservando el trabajo ajeno y descríbeme cada resolución.
4. Lee docs/t3/PROMPTS_POR_INTEGRANTE.md (secciones 1 y 2) y aplica lo siguiente:
   a. CONTRIBUTING.md: añadir el prefijo de rama fix/ y el formato de commit tipo(ALCANCE): descripción con el pie Refs:, tal como lo define la sección 2; añadir la regla de no usar Co-Authored-By de IA.
   b. AGENTS.md: añadir, en «IA y trabajo colaborativo», una viñeta: los commits y PR no llevan trailers de coautoría ni líneas de atribución a una IA; el uso de IA se declara en el PR. No modificar nada más de ese archivo.
   c. docs/versionado/REGISTRO_VERSIONES.md: alinear la tabla y la matriz con el plan de versiones de la sección 2 (v1.0.1, v1.1.0, v1.1.1, v1.2.0, v1.2.1, v1.3.0, v1.4.0). Estados «Planificada»; nada como publicada salvo v1.0.0.
   d. CHANGELOG.md: corregir las inconsistencias que puedas verificar en el repositorio (TEC-001 figura «en revisión» aunque su commit 138dbce está en main; la afirmación «65 pruebas» → sustitúyela por un dato verificable, por ejemplo el número de métodos [Fact]/[Theory] declarados, indicándolo así, o quítala).
   e. README.md: dejar enlazados docs/t3/CHECKLIST_T3.md y docs/t3/PROMPTS_POR_INTEGRANTE.md en la sección de equipo.
   f. Crear las carpetas vacías con un .gitkeep: docs/t3/casos_prueba/, docs/t3/evidencias/, docs/t3/refactorizaciones/, docs/t3/informe/.
5. Comprueba los enlaces locales de los Markdown que tocaste y que los IDs RF/CR/REF citados existan. Cambios solo de documentación: no hace falta compilar.
6. Haz commits pequeños con el formato tipo(ALCANCE): descripción (por ejemplo docs(T3): agregar checklist y prompts por integrante; docs(SEM12): definir rama fix/ y formato de commit), sin pie de coautoría. Un merge de la rama sem12 cuenta como su propio commit.
7. Termina mostrándome: git log --oneline --graph main..HEAD, git diff --stat origin/main, los conflictos resueltos y cualquier cosa que no pudiste verificar. Detente ahí y espera mi confirmación.
```

---

## Prompt 2: publicar la rama en GitHub (Kadin, después de revisar el resultado del prompt 1)

```text
Soy Francisco Kadin Valera Lizarraga. Ya revisé la rama docs/t3-versionado. Publícala y prepara el PR hacia main.

Reglas:
- NO añadas Co-Authored-By, «Generated with Claude Code» ni líneas de atribución a Claude o a una IA, ni en commits ni en la descripción del PR.
- Sin force push. Sin merge del PR: lo integra otra persona tras revisarlo (propón como revisora a Evelyn Victoria Rodriguez Cardozo).
- Pídeme confirmación explícita justo antes del git push.

Pasos:
1. Comprueba que estás en docs/t3-versionado, que git status no tiene cambios sin commitear que no sean .DS_Store y que git remote -v apunta a git@github.com:Nidka/RRHH.git.
2. Muéstrame git log --oneline origin/main..HEAD y espera mi «sí». Luego: git push -u origin docs/t3-versionado.
3. Crea el PR hacia main con gh pr create si gh está instalado y autenticado. Si no lo está, no lo instales: dame la URL https://github.com/Nidka/RRHH/compare/main...docs/t3-versionado?expand=1 y el título y cuerpo listos para pegar.
   Título: docs(T3): agregar plan de T3, checklist y política de versiones
   Cuerpo, con estos apartados:
   - Tarea y spec: T3, base de versionado (SEM12). Sin RF de código.
   - Qué cambia: lista breve de archivos (documentos de T3, CHANGELOG, política y registro de versiones, CONTRIBUTING, AGENTS, README).
   - Verificación: «Solo documentación. Enlaces e IDs comprobados; no se compiló ni se ejecutaron pruebas».
   - Riesgos y reversión: revertir el merge; no cambia código ni BD.
   - Uso de IA: redáctalo como texto de Kadin («Se usó un asistente de IA para redactar y ordenar los documentos; fueron revisados por mí»), sin trailer ni firma.
   - Línea para el CHANGELOG: «Agregado: plan de T3, checklist y reglas de versionado».
   - Label sugerida: semver:none.
4. Si las labels semver:* no existen en GitHub, dime que las cree yo desde Settings > Labels (no las crees tú con la API sin mi permiso).
5. Resume: rama publicada, URL del PR o de la comparación, y qué falta para integrarlo (revisión). Detente.
```

---

## Prompt 3: subir el trabajo de un RF (cualquier integrante: Evelyn, Jorge, Frank, Kadin)

Reemplazar los valores entre corchetes antes de pegar.

```text
Soy [NOMBRE COMPLETO]. Mi trabajo de [RF-NN y descripción] está en la rama [rama]. Prepáralo para subirlo y abre el PR hacia main.

Reglas:
- NO añadas Co-Authored-By, «Generated with Claude Code» ni líneas de atribución a Claude o a una IA, ni en commits ni en el PR. Los commits son míos.
- Primero ejecuta git config user.name y git config user.email y muéstramelos. Si no coinciden con mi nombre real, detente y pregúntame.
- Nunca git add . ni git add -A. Añade rutas concretas. Sin force push, sin reset --hard, sin push directo a main.
- No afirmes que build o pruebas pasaron si no los ejecutaste en esta sesión (requieren Windows). Si no pude ejecutarlos, dilo en el PR como «pendiente» con mi nombre.
- Lee docs/t3/PROMPTS_POR_INTEGRANTE.md secciones 1 y 2 y aplícalas.

Pasos:
1. git fetch origin; git status; git diff --stat. Si mi rama no parte del main actual, dime cuántos commits la separan y propón fusionar origin/main en mi rama (merge, no rebase si ya la subí). Resuelve conflictos conservando lo ajeno y descríbemelos.
2. Revisa que mi trabajo cumple la «definición de terminado» de la sección 1: ficha del RF en la spec, casos CP-[NN]-nn en docs/t3/casos_prueba/[mi-nombre].csv, pruebas xUnit, evidencias reales en docs/t3/evidencias/RF-[NN]/, y mis filas de docs/t2/CONTROL_CAMBIOS.csv actualizadas (solo las mías). Dime qué falta. No inventes evidencias ni resultados.
3. Si en Windows puedo, ejecuta Software\scripts\build.cmd y dotnet test Software\RRHH.Tests\RRHH.Tests.csproj y pega el resultado real. Si no, anótalo.
4. Agrupa los cambios en commits pequeños con el formato tipo(ALCANCE): descripción más el pie Refs: RF-[NN], CR-0[NN], CP-[NN]-nn. Tipos: feat (MINOR), fix y refactor (PATCH), docs, test y chore (sin cambio de versión). Muéstrame la lista de commits y espera mi «sí».
5. Con mi «sí»: git push -u origin [rama].
6. Crea el PR hacia main con gh pr create si gh está disponible y autenticado; si no, dame la URL https://github.com/Nidka/RRHH/compare/main...[rama]?expand=1 y el texto para pegar.
   Título: igual que el commit principal.
   Cuerpo: RF y CR; spec; casos de prueba; verificaciones reales (qué se ejecutó y qué quedó pendiente); evidencia; riesgos y reversión; «Uso de IA» como texto mío, sin firma de IA; línea exacta para el CHANGELOG (por ejemplo «Agregado: registro de periodos de teletrabajo (RF-13)»); label semver:[minor|patch|none] que propongo.
   Revisor: [revisor, según la tabla de la sección 0].
7. No integres el PR. Resúmeme rama, commits, URL o texto del PR y lo pendiente.
```

---

## Prompt 4: publicar una versión (Kadin, una vez por cada versión del plan)

Reemplazar `X.Y.Z` y la lista de PR antes de pegar.

```text
Soy Francisco Kadin Valera Lizarraga. Quiero publicar la versión vX.Y.Z del sistema RRHH, que según docs/t3/PROMPTS_POR_INTEGRANTE.md (sección 2) incluye: [lista de RF y PR].

Reglas:
- NO añadas Co-Authored-By, «Generated with Claude Code» ni líneas de atribución a una IA en commits, tags, Release ni PR.
- Cada acción hacia afuera (push de rama, push de tag, crear Release) requiere mi confirmación explícita justo antes. Sin force push; nunca muevas ni borres un tag ya publicado.
- Si algo del contenido de la versión no está integrado en main, detente y dímelo.

Pasos:
1. git fetch --all --tags --prune. Comprueba con git log y git branch -r --merged origin/main que los commits de los RF indicados están en origin/main y que el tag vX.Y.Z no existe aún.
2. Revisa CHANGELOG.md: las entradas de «[Sin publicar]» deben corresponder solo a esta versión. Si mezcla cambios de otra, dímelo antes de editar.
3. Crea release/X.Y.Z desde origin/main. Mueve las entradas de «[Sin publicar]» a «[X.Y.Z] - AAAA-MM-DD» (fecha de hoy), actualiza los enlaces de comparación al final y la fila de docs/versionado/REGISTRO_VERSIONES.md a «Publicada». Commit: chore(release): preparar vX.Y.Z (sin pie de coautoría).
4. Con mi «sí»: push de release/X.Y.Z y PR hacia main (gh pr create o URL de comparación y texto para pegar). Label semver:none. No lo integres; espera a que otra persona lo apruebe y lo integre.
5. Cuando yo te diga que el PR está integrado: git fetch, git switch main, git pull --ff-only origin main, y con mi «sí»:
   git tag -a vX.Y.Z -m "RRHH X.Y.Z"   (sobre el commit del merge)
   git push origin vX.Y.Z
6. Crea el Release en GitHub (gh release create vX.Y.Z --notes-file <notas> si hay gh; si no, dame el texto de las notas tomado del CHANGELOG y los pasos de la web: Releases > Draft a new release > elegir el tag vX.Y.Z). Para versiones de QA usa vX.Y.Z-rc.N marcado como pre-release.
7. Resúmeme tag, commit al que apunta, URL del Release y lo que falta. Detente.
```
