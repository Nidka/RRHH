# Simulador de reloj para RRHH

Genera un Marcacion.mdb de Jet con documentos ficticios que empiezan por QA.
Requiere Windows PowerShell 5.1 x86 y Microsoft Jet OLE DB 4.0.

Abre PowerShell en esta carpeta y ejecuta:

    New-Item -ItemType Directory -Path .\mi-ensayo
    & "$env:WINDIR\SysWOW64\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -File .\Exportar-Marcacion.ps1 -Carpeta .\mi-ensayo -Documento QA001 -Entrada 08:00:00

Agrega -Salida 17:00:00 para generar dos marcaciones. La fecha por defecto
es la del equipo. Puedes indicar otra con -Fecha. El generador conserva
los archivos existentes y verifica la cantidad de marcaciones creadas.

En WinForms abre Importación > Importación Asistencias - OTROS. Selecciona
el MDB, usa el rango que incluye su fecha y genera sin forzar. Usa la
base local rrhh_integridad_qa. QA001 corresponde al empleado ficticio
900001 en esa copia. El script genera el archivo y no se conecta a la BD.

Pruebas de generación: entrada sola dio 1 marcación; entrada y salida
dieron 2. La integración de RRHH se comprobó previamente con un MDB
ficticio del mismo formato. Este simulador sustituye el reloj para la demo.
