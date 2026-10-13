# Dependencias heredadas

Esta carpeta recibe localmente las DLL propietarias o heredadas necesarias para
compilar y ejecutar RRHH. Las DLL están excluidas de Git para no publicar
componentes licenciados de DevExpress ni binarios internos.

Desde la raíz del repositorio, un desarrollador que tenga la distribución
original debe ejecutar:

```powershell
.\scripts\setup-dependencies.cmd "C:\ruta\a\la\distribucion-original"
```

El script valida y copia `GRLL.dll`, los ensamblados DevExpress 11.2, el interop
de Microsoft Office y las bibliotecas requeridas para consultar el proyecto
recuperado de GRLL.
