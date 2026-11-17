# ADR 0002 Host web para teletrabajo

Estado: propuesto para revisión.

El requisito final pide acceso desde web o móvil. Se añade un host ASP.NET Core con interfaz adaptable para reutilizar las reglas de T3 en el navegador. El navegador presenta y envía eventos HTTP. El host coordina los casos de uso y concentra la composición. Domain y Application mantienen dependencias hacia adentro. Las fuentes específicas de PostgreSQL se compilan para el host con Npgsql 8, conservando el proyecto de escritorio y sus dependencias.

Se eligió la web para este corte. La instalación móvil queda pendiente de una decisión y validación propias. Las operaciones requieren conexión y las respuestas de la API se sirven sin caché. No se incorpora el host a la solución WinForms.
