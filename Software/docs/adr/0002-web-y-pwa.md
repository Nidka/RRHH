# ADR 0002 Host web y móvil para teletrabajo

Estado: propuesto para revisión.

El requisito final pide acceso desde web o móvil. Se añade un host ASP.NET Core con interfaz adaptable y PWA para reutilizar las reglas de T3 en ambas superficies. El navegador presenta y envía eventos HTTP. El host coordina los casos de uso y concentra la composición. Domain y Application mantienen dependencias hacia adentro. Las fuentes específicas de PostgreSQL se compilan para el host con Npgsql 8, conservando el proyecto de escritorio y sus dependencias.

Se evaluó un cliente móvil nativo. La PWA permite una sola interfaz y evita dos procesos de distribución para el piloto. La instalación depende del navegador y HTTPS. Las operaciones requieren conexión y la aplicación no guarda datos de empleados en su caché. No se incorpora el host a la solución WinForms.
