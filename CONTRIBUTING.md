# Trabajo en equipo

Para cualquier refactorización utilizar el [prompt general](docs/t2/PROMPT_GENERAL_REFACTORIZACION.md)
junto con la spec y el rol. Debe quedar documentado el mantenimiento,
comportamiento conservado, arquitectura, patrones/principios, pruebas,
diagramas y trazabilidad del cambio. Los prompts individuales remiten al
mismo procedimiento.

Mantener comentarios XML `///` en el código nuevo o modificado según
[documentación del código](AGENTS.md#documentación-del-código). Documentar
responsabilidades, contratos y restricciones relevantes y revisarlos en el PR.

Antes de refactorizar, seguir [primera prueba](docs/t2/PRIMERA_PRUEBA.md)
contra la base `eeeb817` o posterior y registrar el comportamiento del módulo.
La BD ya fue desplegada según el equipo; las escrituras requieren confirmar
datos ficticios/QA. `.env` es local y no se agrega al PR. Las credenciales de
conexión no sustituyen al usuario/contraseña del login RRHH.

1. Crear una rama desde `main`: `git switch -c feature/nombre-corto`.
2. Mantener cada cambio pequeño y enfocado.
3. Ejecutar `Software\scripts\build.cmd` antes de publicar la rama.
4. No subir contraseñas, archivos `.bak`, dumps con datos ni DLL licenciadas.
5. Integrar mediante pull request y revisión de otra persona.

Los cambios de acceso a datos deben indicar qué consulta o procedimiento SQL
Server reemplazan y adjuntar una prueba contra PostgreSQL QA con datos
ficticios o anonimizados.

## Tareas, ramas y revisión

El [plan T2](docs/t2/PLAN_EQUIPO.md) contiene responsables, revisores,
dependencias y aceptación. El autor abre una tarea con su ID y crea una rama
desde `main` actualizado. Ejemplo desde la raíz del repositorio:

```powershell
git switch main
git pull --ff-only origin main
git switch -c refactor/tec-003-feriados
```

Si hay cambios locales, conservarlos y resolver su ubicación antes de cambiar
de rama. Cada PR aborda una tarea revisable; usar prefijos `docs/`, `feature/`,
`refactor/`, `test/` o `infra/` e incluir el ID T2, CR o TEC. Para cambios de
código preparar la [spec](specs/README.md) antes de implementar.

1. Leer arquitectura, tarea y spec. Coordinar ediciones de esquema,
   `CompositionRoot` y archivos compartidos con los demás responsables.
2. Hacer cambios enfocados y verificarlos. Para código ejecutar build y
   `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` en Windows; para datos,
   adjuntar QA. Para cambios solo documentales, comprobar enlaces, IDs,
   responsables y cobertura; no requieren compilar.
3. Revisar `git diff` y agregar archivos concretos con `git add <ruta>`.
   Crear un commit descriptivo con ID de tarea y subir la rama.
4. Abrir PR hacia `main` con tarea, spec, resultado, verificaciones, evidencia,
   riesgos/reversión y uso material de IA. No marcar pruebas no ejecutadas
   como aprobadas.
5. Pedir revisión al integrante asignado, diferente del autor. El revisor
   comprueba aceptación, arquitectura, datos y evidencias; el autor atiende
   observaciones. Si cambia el PR después de aprobarse, revisar lo nuevo.
6. Integrar tras revisión favorable y verificaciones aplicables. Actualizar
   estados/enlaces de tarea y CR con el PR y commit resultante. Una propuesta
   de T2 puede quedar analizada sin implementarse; no cerrarla como código
   terminado.

Flujo acordado: tarea → rama → cambios/verificación → PR → revisión ajena →
integración a `main`. No hacer push directo ni force push a `main`. Si hay
divergencia o conflictos, resolver en la rama de trabajo conservando cambios
ajenos y repetir las comprobaciones afectadas.

## Configuración pendiente en GitHub

Un administrador debe comprobar repositorio privado, acceso de los cuatro
integrantes y del docente, PR obligatorio, al menos una aprobación ajena y
conversaciones resueltas; bloquear force push y borrado de `main` cuando las
opciones de la cuenta lo permitan. Exigir checks solo cuando exista un flujo
CI que realmente los ejecute. Estas son reglas propuestas para configurar:
este cambio de documentación no activa protecciones ni crea workflows,
issues, invitaciones o PR remotos.

La participación se acredita con trabajo, commits y revisiones reales. Si se
usa IA, el autor registra la ayuda y las comprobaciones humanas; no genera
historial a nombre de otro integrante.

## Arquitectura

Todo cambio debe cumplir [`Software/docs/ARQUITECTURA.md`](Software/docs/ARQUITECTURA.md).
En particular:

- Las pantallas nuevas o migradas usan MVP: el formulario implementa
  `IXxxView` y la lógica va en `XxxPresenter`.
- No se agrega código nuevo que use `dcGRLLDataContext`, `XxxMapper.Instance()`,
  `RRHHClass`, `SqlConnection` ni TableAdapters.
- Cada pantalla migrada cumple la definición de terminado (sección 9) antes
  de abrir el pull request.

## Ramas y versiones

Política completa en [docs/versionado/POLITICA_VERSIONADO.md](docs/versionado/POLITICA_VERSIONADO.md).

| Rama | Para qué sirve | Quién trabaja | Cómo se integra |
|------|----------------|---------------|-----------------|
| `main` | Versión estable. Siempre compila y pasa pruebas. | Nadie directamente | Solo PR aprobados |
| `feature/<id>-<desc>` | Nueva función | Responsable del paquete | PR a `main`, sube MINOR |
| `fix/<id>-<desc>` | Corregir un comportamiento incorrecto | Responsable del paquete | PR a `main`, sube PATCH |
| `refactor/<id>-<desc>` | Reestructurar sin cambiar comportamiento | Responsable del paquete | PR a `main`, sube PATCH |
| `docs/`, `test/`, `infra/` | Documentación, pruebas, scripts | Integrante asignado | PR a `main` (no cambia versión) |
| `release/x.y.z` | Congelar una versión: CHANGELOG, número, pruebas finales | Coordinación | PR a `main`, luego tag `vx.y.z` y Release |
| `hotfix/<desc>` | Corrección urgente de la versión entregada | Responsable del error | PR prioritario a `main`, sube PATCH |

### Mensajes de commit

Formato `tipo(ALCANCE): descripción` en imperativo, más un pie `Refs:` en los commits de código:

```
fix(RF-03): detectar permisos que contienen a otro existente

Refs: RF-03, CR-003, CP-03-01
```

| Tipo | Efecto en la versión |
|------|----------------------|
| `feat` | MINOR |
| `fix`, `refactor`, `perf` | PATCH |
| `docs`, `test`, `chore`, `build` | Ninguno |

- `ALCANCE` es `RF-NN`, `TEC-NNN`, `REF-NNN` o `BASE` (infraestructura compartida). Varios: `RF-13,RF-14`.
- Un cambio incompatible se escribe `feat(RF-NN)!: …` con el pie `BREAKING CHANGE: motivo` y sube MAJOR.
- El número de versión se asigna al publicar el release, no en cada commit.
- Los commits y los PR **no llevan** `Co-Authored-By` ni líneas de atribución a una IA. El uso de IA se declara en el PR.
- Cada PR lleva una label `semver:major|minor|patch|none`: la propone el autor y la confirma el revisor.
- La guía de la semana de T3 está en [docs/t3/PROMPTS_POR_INTEGRANTE.md](docs/t3/PROMPTS_POR_INTEGRANTE.md).

### Publicar una versión

1. Crear `release/x.y.z` desde `main`.
2. Pasar lo de «[Sin publicar]» del CHANGELOG a la nueva versión con fecha.
3. PR a `main`, revisión y merge.
4. `git tag -a vx.y.z -m "RRHH x.y.z"` y `git push origin vx.y.z`.
5. Crear el Release en GitHub con las notas del CHANGELOG.
