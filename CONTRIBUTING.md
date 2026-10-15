# Trabajo en equipo

1. Crear una rama desde `main`: `git switch -c feature/nombre-corto`.
2. Mantener cada cambio pequeño y enfocado.
3. Ejecutar `Software\scripts\build.cmd` antes de publicar la rama.
4. No subir contraseñas, archivos `.bak`, dumps con datos ni DLL licenciadas.
5. Integrar mediante pull request y revisión de otra persona.

Los cambios de acceso a datos deben indicar qué consulta o procedimiento SQL
Server reemplazan y adjuntar una prueba contra PostgreSQL QA con datos
ficticios o anonimizados.

## Arquitectura

Todo cambio debe cumplir [`Software/docs/ARQUITECTURA.md`](Software/docs/ARQUITECTURA.md).
En particular:

- Las pantallas nuevas o migradas usan MVP: el formulario implementa
  `IXxxView` y la lógica va en `XxxPresenter`.
- No se agrega código nuevo que use `dcGRLLDataContext`, `XxxMapper.Instance()`,
  `RRHHClass`, `SqlConnection` ni TableAdapters.
- Cada pantalla migrada cumple la definición de terminado (sección 9) antes
  de abrir el pull request.
