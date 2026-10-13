# Trabajo en equipo

1. Crear una rama desde `main`: `git switch -c feature/nombre-corto`.
2. Mantener cada cambio pequeño y enfocado.
3. Ejecutar `scripts\build.cmd` antes de publicar la rama.
4. No subir contraseñas, archivos `.bak`, dumps con datos ni DLL licenciadas.
5. Integrar mediante pull request y revisión de otra persona.

Los cambios de acceso a datos deben indicar qué consulta o procedimiento SQL
Server reemplazan y adjuntar una prueba contra PostgreSQL QA con datos
ficticios o anonimizados.
