# 1. ORIGEN Y ENTORNO

[Volver al índice](../analisis_codex.md). Corte local: 138dbce; 18/10/2026, America/Lima. Análisis estático de fuentes; no se ejecutó la aplicación ni se accedió a la BD.

## Procedencia y señales de recuperación

El entorno del ejecutable original descrito en la pauta es Windows Forms con SQL Server 2008 R2. Esa procedencia está registrada en el análisis académico previo; en esta solicitud no se comprobó una instancia original ni la versión de su motor. La reconstrucción actual usa rutas PostgreSQL que se distinguen a continuación. [docs/t2/ANALISIS_Y_PREPARACION_T2.md:16](../../docs/t2/ANALISIS_Y_PREPARACION_T2.md#L16).

La evidencia sostiene **código recuperado y después modificado**, no fuente original intacto: README lo identifica como recuperado y la arquitectura describe un origen VB.NET de 2013. Esto es una declaración del repositorio, no una comprobación del binario original. [README.md:1](../../README.md#L1); [Software/docs/ARQUITECTURA.md:27](../../Software/docs/ARQUITECTURA.md#L27).

Se conservan MyApplication/MyProject de Visual Basic, GeneratedCode(MyTemplate), StandardModule, DesignerGenerated, __ENCList, AccessedThroughProperty, Conversions, Operators y cierres con nombres codificados _Closure_0024__. Son compatibles con recuperación de VB a C#; los atributos de diseñador/generador por sí solos también aparecen en código legítimamente generado. [Software/RecursosHumanos/RecursosHumanos/My/MyApplication.cs:12](../../Software/RecursosHumanos/RecursosHumanos/My/MyApplication.cs#L12); [Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:36](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L36); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:25](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L25); [Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:29](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L29).

No se halló una identificación verificable de **ILSpy o dnSpy**, versión o comando utilizado. Tampoco se encontró el patrón literal <>c__DisplayClass en las fuentes analizadas. No corresponde atribuir una herramienta concreta. La exclusión de InternalXmlHelper porque contiene propiedades VB no representables en C# es otra señal explícita de adaptación. [Software/Directory.Build.props:31](../../Software/Directory.Build.props#L31).

La falta de comentarios no prueba descompilación. Hay comentarios XML actuales, pruebas y decisiones de arquitectura; conviven con grandes bloques de diseñador recuperado. [Software/RRHH.Domain/Asistencia/Horario.cs:7](../../Software/RRHH.Domain/Asistencia/Horario.cs#L7); [Software/docs/adr/0001-mvp-sobre-capas.md:9](../../Software/docs/adr/0001-mvp-sobre-capas.md#L9).

## Plataforma y proyectos

La solución actual registra VisualStudioVersion 17.0.31903.59 (familia Visual Studio 2022), formato 12 y MinimumVisualStudioVersion 10.0.40219.1. Eso describe el archivo reconstruido, no prueba qué IDE compiló el ejecutable original. [Software/RRHH.sln:4](../../Software/RRHH.sln#L4).

| Proyecto | SDK/tipo | Framework | Salida | Plataforma | Lenguaje | Evidencia |
|---|---|---|---|---|---|---|
| Software/ClassRRHH/ClassRRHH.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | x86 | 12.0 | [Software/ClassRRHH/ClassRRHH.csproj:1](../../Software/ClassRRHH/ClassRRHH.csproj#L1) |
| Software/ClsCtrls/ClsCtrls.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | Library por defecto | Predeterminado | 12.0 | [Software/ClsCtrls/ClsCtrls.csproj:1](../../Software/ClsCtrls/ClsCtrls.csproj#L1) |
| Software/CustomFeaturedMessageBox/Custom Featured MessageBox.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | Library por defecto | Predeterminado | 12.0 | [Software/CustomFeaturedMessageBox/Custom Featured MessageBox.csproj:1](../../Software/CustomFeaturedMessageBox/Custom%20Featured%20MessageBox.csproj#L1) |
| Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | Library por defecto | Predeterminado | 12.0 | [Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj:1](../../Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj#L1) |
| Software/GRLL/GRLL.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | Library por defecto | Predeterminado | 12.0 | [Software/GRLL/GRLL.csproj:1](../../Software/GRLL/GRLL.csproj#L1) |
| Software/RRHH.Application/RRHH.Application.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | Predeterminado | 12.0 | [Software/RRHH.Application/RRHH.Application.csproj:1](../../Software/RRHH.Application/RRHH.Application.csproj#L1) |
| Software/RRHH.Domain/RRHH.Domain.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | Predeterminado | 12.0 | [Software/RRHH.Domain/RRHH.Domain.csproj:1](../../Software/RRHH.Domain/RRHH.Domain.csproj#L1) |
| Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | x86 | 12.0 | [Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj:1](../../Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj#L1) |
| Software/RRHH.Presentation/RRHH.Presentation.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | Predeterminado | 12.0 | [Software/RRHH.Presentation/RRHH.Presentation.csproj:1](../../Software/RRHH.Presentation/RRHH.Presentation.csproj#L1) |
| Software/RRHH.Tests/RRHH.Tests.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | x86 | 12.0 | [Software/RRHH.Tests/RRHH.Tests.csproj:1](../../Software/RRHH.Tests/RRHH.Tests.csproj#L1) |
| Software/RecursosHumanos/RecursosHumanos.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | WinExe | x86 | 12.0 | [Software/RecursosHumanos/RecursosHumanos.csproj:1](../../Software/RecursosHumanos/RecursosHumanos.csproj#L1) |
| Software/Seguridad/Seguridad.csproj | Microsoft.NET.Sdk | net48 | Library por defecto | Predeterminado | 12.0 | [Software/Seguridad/Seguridad.csproj:1](../../Software/Seguridad/Seguridad.csproj#L1) |
| Software/TabStrip/TabStrip.csproj | Microsoft.NET.Sdk.WindowsDesktop | net48 | Library por defecto | Predeterminado | 12.0 | [Software/TabStrip/TabStrip.csproj:1](../../Software/TabStrip/TabStrip.csproj#L1) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | Proyecto MSBuild clásico | v4.0 | Library | Predeterminado | Predeterminado | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:1](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L1) |
| Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj | Proyecto MSBuild clásico | v4.0 | WinExe | x86 | Predeterminado | [Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj:1](../../Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj#L1) |

Los 13 csproj físicos no equivalen a 13 proyectos compilados por RRHH.sln: la solución lista 12 proyectos C# y una carpeta lógica; GRLL.csproj se conserva como fuente auxiliar y la aplicación referencia GRLL.dll. Los dos vbproj de referencia tampoco están integrados en esa solución. [Software/RRHH.sln:6](../../Software/RRHH.sln#L6); [Software/RecursosHumanos/RecursosHumanos.csproj:27](../../Software/RecursosHumanos/RecursosHumanos.csproj#L27).

## Referencias y paquetes completos

La UI usa DevExpress 11.2 (Grid, Editors, Printing, Reports, Bars, TreeList, Data), bibliotecas GRLL, Microsoft.VisualBasic y automatización Office. Los paquetes directos incluyen Npgsql 4.1.14, System.Memory 4.5.5 y los de pruebas xUnit/Test SDK. No se hallaron referencias Crystal Reports/ReportViewer en estos proyectos; los reportes localizados son XtraReport. [Software/RecursosHumanos/RecursosHumanos.csproj:45](../../Software/RecursosHumanos/RecursosHumanos.csproj#L45); [Software/RRHH.Tests/RRHH.Tests.csproj:12](../../Software/RRHH.Tests/RRHH.Tests.csproj#L12).

| Proyecto | Referencia declarada | Evidencia |
|---|---|---|
| Software/ClassRRHH/ClassRRHH.csproj | &lt;Reference Include="Microsoft.VisualBasic" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:17](../../Software/ClassRRHH/ClassRRHH.csproj#L17) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;Reference Include="System.Xml.Linq" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:18](../../Software/ClassRRHH/ClassRRHH.csproj#L18) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:19](../../Software/ClassRRHH/ClassRRHH.csproj#L19) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:20](../../Software/ClassRRHH/ClassRRHH.csproj#L20) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;Reference Include="GRLL"&gt; | [Software/ClassRRHH/ClassRRHH.csproj:21](../../Software/ClassRRHH/ClassRRHH.csproj#L21) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;ProjectReference Include="..\RRHH.PostgreSql\RRHH.PostgreSql.csproj" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:26](../../Software/ClassRRHH/ClassRRHH.csproj#L26) |
| Software/ClassRRHH/ClassRRHH.csproj | &lt;ProjectReference Include="..\Seguridad\Seguridad.csproj" /&gt; | [Software/ClassRRHH/ClassRRHH.csproj:27](../../Software/ClassRRHH/ClassRRHH.csproj#L27) |
| Software/ClsCtrls/ClsCtrls.csproj | &lt;Reference Include="Microsoft.VisualBasic" /&gt; | [Software/ClsCtrls/ClsCtrls.csproj:17](../../Software/ClsCtrls/ClsCtrls.csproj#L17) |
| Software/ClsCtrls/ClsCtrls.csproj | &lt;Reference Include="System.Xml.Linq" /&gt; | [Software/ClsCtrls/ClsCtrls.csproj:18](../../Software/ClsCtrls/ClsCtrls.csproj#L18) |
| Software/ClsCtrls/ClsCtrls.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/ClsCtrls/ClsCtrls.csproj:19](../../Software/ClsCtrls/ClsCtrls.csproj#L19) |
| Software/ClsCtrls/ClsCtrls.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/ClsCtrls/ClsCtrls.csproj:20](../../Software/ClsCtrls/ClsCtrls.csproj#L20) |
| Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj:15](../../Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj#L15) |
| Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj:16](../../Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj#L16) |
| Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj | &lt;Reference Include="GRLL"&gt; | [Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj:17](../../Software/GRLL.Common.Rutinas/GRLL.Common.Rutinas.csproj#L17) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="Microsoft.VisualBasic" /&gt; | [Software/GRLL/GRLL.csproj:18](../../Software/GRLL/GRLL.csproj#L18) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/GRLL/GRLL.csproj:19](../../Software/GRLL/GRLL.csproj#L19) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="ClsCtrls"&gt; | [Software/GRLL/GRLL.csproj:20](../../Software/GRLL/GRLL.csproj#L20) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="System.Data.Linq" /&gt; | [Software/GRLL/GRLL.csproj:23](../../Software/GRLL/GRLL.csproj#L23) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="System.Xml.Linq" /&gt; | [Software/GRLL/GRLL.csproj:24](../../Software/GRLL/GRLL.csproj#L24) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="TabStrip"&gt; | [Software/GRLL/GRLL.csproj:25](../../Software/GRLL/GRLL.csproj#L25) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/GRLL/GRLL.csproj:28](../../Software/GRLL/GRLL.csproj#L28) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="Custom Featured MessageBox"&gt; | [Software/GRLL/GRLL.csproj:29](../../Software/GRLL/GRLL.csproj#L29) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="GRLL.Common.Rutinas"&gt; | [Software/GRLL/GRLL.csproj:32](../../Software/GRLL/GRLL.csproj#L32) |
| Software/GRLL/GRLL.csproj | &lt;Reference Include="System.Web" /&gt; | [Software/GRLL/GRLL.csproj:35](../../Software/GRLL/GRLL.csproj#L35) |
| Software/RRHH.Application/RRHH.Application.csproj | &lt;ProjectReference Include="..\RRHH.Domain\RRHH.Domain.csproj" /&gt; | [Software/RRHH.Application/RRHH.Application.csproj:9](../../Software/RRHH.Application/RRHH.Application.csproj#L9) |
| Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj:11](../../Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj#L11) |
| Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj | &lt;PackageReference Include="Npgsql" Version="4.1.14" /&gt; | [Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj:14](../../Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj#L14) |
| Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj | &lt;PackageReference Include="System.Memory" Version="4.5.5" /&gt; | [Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj:15](../../Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj#L15) |
| Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj | &lt;ProjectReference Include="..\RRHH.Application\RRHH.Application.csproj" /&gt; | [Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj:18](../../Software/RRHH.PostgreSql/RRHH.PostgreSql.csproj#L18) |
| Software/RRHH.Presentation/RRHH.Presentation.csproj | &lt;ProjectReference Include="..\RRHH.Application\RRHH.Application.csproj" /&gt; | [Software/RRHH.Presentation/RRHH.Presentation.csproj:11](../../Software/RRHH.Presentation/RRHH.Presentation.csproj#L11) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:12](../../Software/RRHH.Tests/RRHH.Tests.csproj#L12) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;PackageReference Include="xunit" Version="2.9.2" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:13](../../Software/RRHH.Tests/RRHH.Tests.csproj#L13) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;PackageReference Include="xunit.runner.visualstudio" Version="2.8.2" PrivateAssets="all" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:14](../../Software/RRHH.Tests/RRHH.Tests.csproj#L14) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;PackageReference Include="Npgsql" Version="4.1.14" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:15](../../Software/RRHH.Tests/RRHH.Tests.csproj#L15) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;ProjectReference Include="..\RRHH.Domain\RRHH.Domain.csproj" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:18](../../Software/RRHH.Tests/RRHH.Tests.csproj#L18) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;ProjectReference Include="..\RRHH.Application\RRHH.Application.csproj" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:19](../../Software/RRHH.Tests/RRHH.Tests.csproj#L19) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;ProjectReference Include="..\RRHH.Presentation\RRHH.Presentation.csproj" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:20](../../Software/RRHH.Tests/RRHH.Tests.csproj#L20) |
| Software/RRHH.Tests/RRHH.Tests.csproj | &lt;ProjectReference Include="..\RRHH.PostgreSql\RRHH.PostgreSql.csproj" /&gt; | [Software/RRHH.Tests/RRHH.Tests.csproj:21](../../Software/RRHH.Tests/RRHH.Tests.csproj#L21) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="Microsoft.VisualBasic" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:25](../../Software/RecursosHumanos/RecursosHumanos.csproj#L25) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Xml.Linq" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:26](../../Software/RecursosHumanos/RecursosHumanos.csproj#L26) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="GRLL"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:27](../../Software/RecursosHumanos/RecursosHumanos.csproj#L27) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraGrid.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:30](../../Software/RecursosHumanos/RecursosHumanos.csproj#L30) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraEditors.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:33](../../Software/RecursosHumanos/RecursosHumanos.csproj#L33) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.Utils.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:36](../../Software/RecursosHumanos/RecursosHumanos.csproj#L36) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraPrinting.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:39](../../Software/RecursosHumanos/RecursosHumanos.csproj#L39) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraBars.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:42](../../Software/RecursosHumanos/RecursosHumanos.csproj#L42) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraReports.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:45](../../Software/RecursosHumanos/RecursosHumanos.csproj#L45) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Data" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:48](../../Software/RecursosHumanos/RecursosHumanos.csproj#L48) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Configuration" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:49](../../Software/RecursosHumanos/RecursosHumanos.csproj#L49) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Xml" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:50](../../Software/RecursosHumanos/RecursosHumanos.csproj#L50) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Data.DataSetExtensions" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:51](../../Software/RecursosHumanos/RecursosHumanos.csproj#L51) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.XtraTreeList.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:52](../../Software/RecursosHumanos/RecursosHumanos.csproj#L52) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:55](../../Software/RecursosHumanos/RecursosHumanos.csproj#L55) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.Data.v11.2"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:56](../../Software/RecursosHumanos/RecursosHumanos.csproj#L56) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="System.Data.Linq" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:59](../../Software/RecursosHumanos/RecursosHumanos.csproj#L59) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="DevExpress.Printing.v11.2.Core"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:60](../../Software/RecursosHumanos/RecursosHumanos.csproj#L60) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;Reference Include="Interop.Microsoft.Office.Core"&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:63](../../Software/RecursosHumanos/RecursosHumanos.csproj#L63) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;ProjectReference Include="..\ClassRRHH\ClassRRHH.csproj" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:68](../../Software/RecursosHumanos/RecursosHumanos.csproj#L68) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;ProjectReference Include="..\GRLL.Common.Rutinas\GRLL.Common.Rutinas.csproj" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:69](../../Software/RecursosHumanos/RecursosHumanos.csproj#L69) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;ProjectReference Include="..\RRHH.PostgreSql\RRHH.PostgreSql.csproj" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:70](../../Software/RecursosHumanos/RecursosHumanos.csproj#L70) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;ProjectReference Include="..\RRHH.Presentation\RRHH.Presentation.csproj" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:71](../../Software/RecursosHumanos/RecursosHumanos.csproj#L71) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;PackageReference Include="Npgsql" Version="4.1.14" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:75](../../Software/RecursosHumanos/RecursosHumanos.csproj#L75) |
| Software/RecursosHumanos/RecursosHumanos.csproj | &lt;PackageReference Include="System.Memory" Version="4.5.5" /&gt; | [Software/RecursosHumanos/RecursosHumanos.csproj:76](../../Software/RecursosHumanos/RecursosHumanos.csproj#L76) |
| Software/Seguridad/Seguridad.csproj | &lt;Reference Include="Microsoft.VisualBasic" /&gt; | [Software/Seguridad/Seguridad.csproj:16](../../Software/Seguridad/Seguridad.csproj#L16) |
| Software/Seguridad/Seguridad.csproj | &lt;Reference Include="System.Xml.Linq" /&gt; | [Software/Seguridad/Seguridad.csproj:17](../../Software/Seguridad/Seguridad.csproj#L17) |
| Software/Seguridad/Seguridad.csproj | &lt;Reference Include="System.Core" /&gt; | [Software/Seguridad/Seguridad.csproj:18](../../Software/Seguridad/Seguridad.csproj#L18) |
| Software/TabStrip/TabStrip.csproj | &lt;Reference Include="System.Design" /&gt; | [Software/TabStrip/TabStrip.csproj:20](../../Software/TabStrip/TabStrip.csproj#L20) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:35](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L35) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.configuration" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:36](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L36) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.Data" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:37](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L37) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.Drawing" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:38](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L38) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.Windows.Forms" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:39](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L39) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.Xml" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:40](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L40) |
| Software/referencia/AsistenciaImport/AsistenciaImport.vbproj | &lt;Reference Include="System.Core" /&gt; | [Software/referencia/AsistenciaImport/AsistenciaImport.vbproj:41](../../Software/referencia/AsistenciaImport/AsistenciaImport.vbproj#L41) |
| Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj | &lt;Reference Include="System" /&gt; | [Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj:20](../../Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj#L20) |
| Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj | &lt;Reference Include="System.Windows.Forms" /&gt; | [Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj:21](../../Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj#L21) |
| Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj | &lt;ProjectReference Include="..\AsistenciaImport.vbproj"&gt; | [Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj:24](../../Software/referencia/AsistenciaImport/Launcher/AsistenciaImportLauncher.vbproj#L24) |

Referencias compartidas agregadas por Directory.Build.props: System.Resources.Extensions, Memory, Buffers, Numerics.Vectors y Unsafe mediante copias locales. [Software/Directory.Build.props:8](../../Software/Directory.Build.props#L8).


### Versiones resueltas: Software/RRHH.PostgreSql/packages.lock.json

| Framework | Paquete | Tipo | Solicitado | Resuelto | Evidencia |
|---|---|---|---|---|---|
| .NETFramework,Version=v4.8 | Npgsql | Direct | [4.1.14, ) | 4.1.14 | [Software/RRHH.PostgreSql/packages.lock.json:5](../../Software/RRHH.PostgreSql/packages.lock.json#L5) |
| .NETFramework,Version=v4.8 | System.Memory | Direct | [4.5.5, ) | 4.5.5 | [Software/RRHH.PostgreSql/packages.lock.json:12](../../Software/RRHH.PostgreSql/packages.lock.json#L12) |
| .NETFramework,Version=v4.8 | Microsoft.Bcl.AsyncInterfaces | Transitive |  | 1.1.0 | [Software/RRHH.PostgreSql/packages.lock.json:11](../../Software/RRHH.PostgreSql/packages.lock.json#L11) |
| .NETFramework,Version=v4.8 | System.Buffers | Transitive |  | 4.5.1 | [Software/RRHH.PostgreSql/packages.lock.json:25](../../Software/RRHH.PostgreSql/packages.lock.json#L25) |
| .NETFramework,Version=v4.8 | System.Numerics.Vectors | Transitive |  | 4.5.0 | [Software/RRHH.PostgreSql/packages.lock.json:26](../../Software/RRHH.PostgreSql/packages.lock.json#L26) |
| .NETFramework,Version=v4.8 | System.Runtime.CompilerServices.Unsafe | Transitive |  | 4.6.0 | [Software/RRHH.PostgreSql/packages.lock.json:13](../../Software/RRHH.PostgreSql/packages.lock.json#L13) |
| .NETFramework,Version=v4.8 | System.Text.Encodings.Web | Transitive |  | 4.6.0 | [Software/RRHH.PostgreSql/packages.lock.json:53](../../Software/RRHH.PostgreSql/packages.lock.json#L53) |
| .NETFramework,Version=v4.8 | System.Text.Json | Transitive |  | 4.6.0 | [Software/RRHH.PostgreSql/packages.lock.json:14](../../Software/RRHH.PostgreSql/packages.lock.json#L14) |
| .NETFramework,Version=v4.8 | System.Threading.Tasks.Extensions | Transitive |  | 4.5.3 | [Software/RRHH.PostgreSql/packages.lock.json:15](../../Software/RRHH.PostgreSql/packages.lock.json#L15) |
| .NETFramework,Version=v4.8 | System.ValueTuple | Transitive |  | 4.5.0 | [Software/RRHH.PostgreSql/packages.lock.json:16](../../Software/RRHH.PostgreSql/packages.lock.json#L16) |
| .NETFramework,Version=v4.8 | rrhh.application | Project |  |  | [Software/RRHH.PostgreSql/packages.lock.json:89](../../Software/RRHH.PostgreSql/packages.lock.json#L89) |
| .NETFramework,Version=v4.8 | rrhh.domain | Project |  |  | [Software/RRHH.PostgreSql/packages.lock.json:95](../../Software/RRHH.PostgreSql/packages.lock.json#L95) |

### Versiones resueltas: Software/RecursosHumanos/packages.lock.json

| Framework | Paquete | Tipo | Solicitado | Resuelto | Evidencia |
|---|---|---|---|---|---|
| .NETFramework,Version=v4.8 | Npgsql | Direct | [4.1.14, ) | 4.1.14 | [Software/RecursosHumanos/packages.lock.json:5](../../Software/RecursosHumanos/packages.lock.json#L5) |
| .NETFramework,Version=v4.8 | System.Memory | Direct | [4.5.5, ) | 4.5.5 | [Software/RecursosHumanos/packages.lock.json:12](../../Software/RecursosHumanos/packages.lock.json#L12) |
| .NETFramework,Version=v4.8 | Microsoft.Bcl.AsyncInterfaces | Transitive |  | 1.1.0 | [Software/RecursosHumanos/packages.lock.json:11](../../Software/RecursosHumanos/packages.lock.json#L11) |
| .NETFramework,Version=v4.8 | System.Buffers | Transitive |  | 4.5.1 | [Software/RecursosHumanos/packages.lock.json:25](../../Software/RecursosHumanos/packages.lock.json#L25) |
| .NETFramework,Version=v4.8 | System.Numerics.Vectors | Transitive |  | 4.5.0 | [Software/RecursosHumanos/packages.lock.json:26](../../Software/RecursosHumanos/packages.lock.json#L26) |
| .NETFramework,Version=v4.8 | System.Runtime.CompilerServices.Unsafe | Transitive |  | 4.6.0 | [Software/RecursosHumanos/packages.lock.json:13](../../Software/RecursosHumanos/packages.lock.json#L13) |
| .NETFramework,Version=v4.8 | System.Text.Encodings.Web | Transitive |  | 4.6.0 | [Software/RecursosHumanos/packages.lock.json:53](../../Software/RecursosHumanos/packages.lock.json#L53) |
| .NETFramework,Version=v4.8 | System.Text.Json | Transitive |  | 4.6.0 | [Software/RecursosHumanos/packages.lock.json:14](../../Software/RecursosHumanos/packages.lock.json#L14) |
| .NETFramework,Version=v4.8 | System.Threading.Tasks.Extensions | Transitive |  | 4.5.3 | [Software/RecursosHumanos/packages.lock.json:15](../../Software/RecursosHumanos/packages.lock.json#L15) |
| .NETFramework,Version=v4.8 | System.ValueTuple | Transitive |  | 4.5.0 | [Software/RecursosHumanos/packages.lock.json:16](../../Software/RecursosHumanos/packages.lock.json#L16) |
| .NETFramework,Version=v4.8 | classrrhh | Project |  |  | [Software/RecursosHumanos/packages.lock.json:89](../../Software/RecursosHumanos/packages.lock.json#L89) |
| .NETFramework,Version=v4.8 | grll.common.rutinas | Project |  |  | [Software/RecursosHumanos/packages.lock.json:96](../../Software/RecursosHumanos/packages.lock.json#L96) |
| .NETFramework,Version=v4.8 | rrhh.application | Project |  |  | [Software/RecursosHumanos/packages.lock.json:99](../../Software/RecursosHumanos/packages.lock.json#L99) |
| .NETFramework,Version=v4.8 | rrhh.domain | Project |  |  | [Software/RecursosHumanos/packages.lock.json:105](../../Software/RecursosHumanos/packages.lock.json#L105) |
| .NETFramework,Version=v4.8 | rrhh.postgresql | Project |  |  | [Software/RecursosHumanos/packages.lock.json:108](../../Software/RecursosHumanos/packages.lock.json#L108) |
| .NETFramework,Version=v4.8 | rrhh.presentation | Project |  |  | [Software/RecursosHumanos/packages.lock.json:116](../../Software/RecursosHumanos/packages.lock.json#L116) |
| .NETFramework,Version=v4.8 | seguridad | Project |  |  | [Software/RecursosHumanos/packages.lock.json:122](../../Software/RecursosHumanos/packages.lock.json#L122) |

### DLL físicas y disponibilidad

| Archivo físico | SHA-256 del archivo local |
|---|---|
| Software/RRHH.Application/bin/Debug/net48/RRHH.Application.dll | c7e42ad62633f899ebd59561d5f1317165a4eba2a15a5eee3958fbc40afaaa8a |
| Software/RRHH.Application/bin/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.Application/bin/Debug/net48/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/RRHH.Application/bin/Debug/net48/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/RRHH.Application/bin/Debug/net48/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/RRHH.Application/bin/Debug/net48/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/RRHH.Application/bin/Debug/net48/System.Runtime.CompilerServices.Unsafe.dll | 66409f670315afe8610f17a4d3a1ee52d72b6a46c544cec97544e8385f90ad74 |
| Software/RRHH.Application/obj/Debug/net48/RRHH.Application.dll | c7e42ad62633f899ebd59561d5f1317165a4eba2a15a5eee3958fbc40afaaa8a |
| Software/RRHH.Domain/bin/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.Domain/bin/Debug/net48/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/RRHH.Domain/bin/Debug/net48/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/RRHH.Domain/bin/Debug/net48/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/RRHH.Domain/bin/Debug/net48/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/RRHH.Domain/bin/Debug/net48/System.Runtime.CompilerServices.Unsafe.dll | 66409f670315afe8610f17a4d3a1ee52d72b6a46c544cec97544e8385f90ad74 |
| Software/RRHH.Domain/obj/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.PostgreSql/bin/Debug/net48/Microsoft.Bcl.AsyncInterfaces.dll | ed5bc605f7f9fcc382183abef06c354dad946abb42a07631712077b2157d6bc9 |
| Software/RRHH.PostgreSql/bin/Debug/net48/Npgsql.dll | f10b5245ebf0c907270baca687972576be5b18c7aa11d52125324a2d0bd6beb9 |
| Software/RRHH.PostgreSql/bin/Debug/net48/RRHH.Application.dll | c7e42ad62633f899ebd59561d5f1317165a4eba2a15a5eee3958fbc40afaaa8a |
| Software/RRHH.PostgreSql/bin/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.PostgreSql/bin/Debug/net48/RRHH.PostgreSql.dll | 616c877779d58c91d2205021570de07bc7c818330f0067cfd17f940693f3b5a1 |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Runtime.CompilerServices.Unsafe.dll | 70868cd40021b6df1195ba764a6672d8e19ab58b86a263992986361f316a51ce |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Text.Encodings.Web.dll | c4aba259ca86656fc73044e9266fec9dc5c6c5db9350d15b0b48dbd8039b06fd |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Text.Json.dll | 4c9cdb617f7da0aec3266f8205f7eaa112be516e6bb5ca46ace3dc20daa67c8d |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.Threading.Tasks.Extensions.dll | 1f54718bbab6e7a649e460f5097ed444f33452b1451841f67e2e194641d5fccd |
| Software/RRHH.PostgreSql/bin/Debug/net48/System.ValueTuple.dll | e905d102585b22c6df04f219af5cbdbfa7bc165979e9788b62df6dcc165e10f4 |
| Software/RRHH.PostgreSql/obj/Debug/net48/RRHH.PostgreSql.dll | 616c877779d58c91d2205021570de07bc7c818330f0067cfd17f940693f3b5a1 |
| Software/RRHH.Presentation/bin/Debug/net48/RRHH.Application.dll | c7e42ad62633f899ebd59561d5f1317165a4eba2a15a5eee3958fbc40afaaa8a |
| Software/RRHH.Presentation/bin/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.Presentation/bin/Debug/net48/RRHH.Presentation.dll | 3f4bc114a1460a1c87cfeb2396b2f9822a362c32543667954352e181fb45843f |
| Software/RRHH.Presentation/bin/Debug/net48/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/RRHH.Presentation/bin/Debug/net48/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/RRHH.Presentation/bin/Debug/net48/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/RRHH.Presentation/bin/Debug/net48/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/RRHH.Presentation/bin/Debug/net48/System.Runtime.CompilerServices.Unsafe.dll | 66409f670315afe8610f17a4d3a1ee52d72b6a46c544cec97544e8385f90ad74 |
| Software/RRHH.Presentation/obj/Debug/net48/RRHH.Presentation.dll | 3f4bc114a1460a1c87cfeb2396b2f9822a362c32543667954352e181fb45843f |
| Software/RRHH.Tests/bin/Debug/net48/Microsoft.Bcl.AsyncInterfaces.dll | ed5bc605f7f9fcc382183abef06c354dad946abb42a07631712077b2157d6bc9 |
| Software/RRHH.Tests/bin/Debug/net48/Microsoft.TestPlatform.CoreUtilities.dll | 27545c78b4ec67273e261ebcd2e062c0ec15b879914d00799eac50a7554cf5af |
| Software/RRHH.Tests/bin/Debug/net48/Microsoft.TestPlatform.PlatformAbstractions.dll | a5caf4430f775373d12d519e01bce749dca722d448a0700423656a5feff7fa3b |
| Software/RRHH.Tests/bin/Debug/net48/Microsoft.VisualStudio.CodeCoverage.Shim.dll | d7b48a42e619e9059b69987d46291ee822c46125b3aa7d2239d63616aa7179fd |
| Software/RRHH.Tests/bin/Debug/net48/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll | 55e78704714b3f522d5bd5edba0c0031023348accbcba37fc1803c1f34a443bc |
| Software/RRHH.Tests/bin/Debug/net48/Npgsql.dll | f10b5245ebf0c907270baca687972576be5b18c7aa11d52125324a2d0bd6beb9 |
| Software/RRHH.Tests/bin/Debug/net48/RRHH.Application.dll | c7e42ad62633f899ebd59561d5f1317165a4eba2a15a5eee3958fbc40afaaa8a |
| Software/RRHH.Tests/bin/Debug/net48/RRHH.Domain.dll | c2656b478bcbe207ce5751c9f53caff035d76b7ec28c5d314479de89161d0eb4 |
| Software/RRHH.Tests/bin/Debug/net48/RRHH.PostgreSql.dll | 616c877779d58c91d2205021570de07bc7c818330f0067cfd17f940693f3b5a1 |
| Software/RRHH.Tests/bin/Debug/net48/RRHH.Presentation.dll | 3f4bc114a1460a1c87cfeb2396b2f9822a362c32543667954352e181fb45843f |
| Software/RRHH.Tests/bin/Debug/net48/RRHH.Tests.dll | a8d8bfab41df3800caa7ee05e84ffcf315569916fa38318bcaaf7d17ad5f922c |
| Software/RRHH.Tests/bin/Debug/net48/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/RRHH.Tests/bin/Debug/net48/System.Collections.Immutable.dll | 2f05a2c489c2d30a6cca346d4ce184323d70eb4f5afa6bed34d5800274444e57 |
| Software/RRHH.Tests/bin/Debug/net48/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/RRHH.Tests/bin/Debug/net48/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/RRHH.Tests/bin/Debug/net48/System.Reflection.Metadata.dll | 2e180767f1415cb5bbed14450e1d4003cf56a9da6aeaf91ce969a4b9d2a54314 |
| Software/RRHH.Tests/bin/Debug/net48/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/RRHH.Tests/bin/Debug/net48/System.Runtime.CompilerServices.Unsafe.dll | 70868cd40021b6df1195ba764a6672d8e19ab58b86a263992986361f316a51ce |
| Software/RRHH.Tests/bin/Debug/net48/System.Text.Encodings.Web.dll | c4aba259ca86656fc73044e9266fec9dc5c6c5db9350d15b0b48dbd8039b06fd |
| Software/RRHH.Tests/bin/Debug/net48/System.Text.Json.dll | 4c9cdb617f7da0aec3266f8205f7eaa112be516e6bb5ca46ace3dc20daa67c8d |
| Software/RRHH.Tests/bin/Debug/net48/System.Threading.Tasks.Extensions.dll | 1f54718bbab6e7a649e460f5097ed444f33452b1451841f67e2e194641d5fccd |
| Software/RRHH.Tests/bin/Debug/net48/System.ValueTuple.dll | e905d102585b22c6df04f219af5cbdbfa7bc165979e9788b62df6dcc165e10f4 |
| Software/RRHH.Tests/bin/Debug/net48/xunit.abstractions.dll | 7c07e3bce3e1794cffc033302fcf13a003fd320b16e1c09e9d9a221f495566a4 |
| Software/RRHH.Tests/bin/Debug/net48/xunit.assert.dll | e941a88f646598ff637fa5426ed45ecf1a40060fbb798b32ddedd79041ffd099 |
| Software/RRHH.Tests/bin/Debug/net48/xunit.core.dll | 0ed5297c796b0225aab35564319ebb6600738e14e868fddb21c317e35b99513b |
| Software/RRHH.Tests/bin/Debug/net48/xunit.execution.desktop.dll | ee5b22df0da1a1f65801b791139acd488e4ea3e3fdf24cecaea977f986413a64 |
| Software/RRHH.Tests/bin/Debug/net48/xunit.runner.reporters.net452.dll | d57d12d60650292d9d0adf51cdc8f811d9ad119beb1a7fc766b0f5173c8d884b |
| Software/RRHH.Tests/bin/Debug/net48/xunit.runner.utility.net452.dll | fb2535b40ba0c3bb4a1c364dbff923ce9f2c724f0cd768bffa0f0ac6980377c0 |
| Software/RRHH.Tests/bin/Debug/net48/xunit.runner.visualstudio.testadapter.dll | 6075715f19c3e64d997aa9e6a221d6fb55cea61b64e344689887193df7d4265b |
| Software/RRHH.Tests/bin/Debug/net48/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll | 6f498a2f6b7aee0460d108c035960dce4ed41dd03943a6eb93b05b0394575377 |
| Software/RRHH.Tests/bin/Debug/net48/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 6a7547eda4037dd5b43f4dead112591f1ce3458bf4aeeeb6c1c6c962e2b7d55c |
| Software/RRHH.Tests/bin/Debug/net48/de/Microsoft.TestPlatform.CoreUtilities.resources.dll | 56f531ffa52e1cbae05d12e8ab7ebfafc6216702adc75a7471d307cd5f82c89c |
| Software/RRHH.Tests/bin/Debug/net48/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | afa406ebd2d6b767a2b40df941b7729c94867517da40ec76c38c2aa3a4096bb2 |
| Software/RRHH.Tests/bin/Debug/net48/es/Microsoft.TestPlatform.CoreUtilities.resources.dll | 1198add89b8c56b31adc4f97017d80f095f0d668aed1a3169f56022def799cd7 |
| Software/RRHH.Tests/bin/Debug/net48/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 7dd5c960bbd0dd0b51ff18e8724e319c5cca4ce4fe30ecaec9c4958d0a64d5c0 |
| Software/RRHH.Tests/bin/Debug/net48/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll | d1b6d8186e1d652737d065238337978ed0b1bdc86dc673c9f5d5057b105efb7c |
| Software/RRHH.Tests/bin/Debug/net48/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | b3ed1caaa8aff0ab4a9680867f43393cfcc3f3dc28d27a215f97d4b1b390ed46 |
| Software/RRHH.Tests/bin/Debug/net48/it/Microsoft.TestPlatform.CoreUtilities.resources.dll | 67fc9af90a5281a22bb766e414e58eff2da9d9e82e7662016c787e74fafa3cbf |
| Software/RRHH.Tests/bin/Debug/net48/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 85f5146e429cbdb11301f088e454155c017eae62ee8addbc2e490275bafbf5b3 |
| Software/RRHH.Tests/bin/Debug/net48/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll | c20addbf93c1a8a6e4aad9b09091d1caa05e4c8a951454d3889d8b7e0d1a489f |
| Software/RRHH.Tests/bin/Debug/net48/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | b1445357e2c71f4c797dcbdbbdd7d4db1480cfc274aad242a72a103193c6c00d |
| Software/RRHH.Tests/bin/Debug/net48/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll | 49efc95dce9326a797c9a7558c5127af460ef5d97e4de9b06b18b53da8386f6d |
| Software/RRHH.Tests/bin/Debug/net48/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 35e05b1d888b9e0d58d59e8d9fcf9b44b3c7dc3f5784083a29efdeefa906b51b |
| Software/RRHH.Tests/bin/Debug/net48/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll | cd8ff45e6bf7ff60d0bfe470d928cf535e16e3cf95658a18e24e107c56b3f7b7 |
| Software/RRHH.Tests/bin/Debug/net48/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 7b3d678cdd48248338b6fb810184ae47753b8450763c69b48d045cb145bdcdf0 |
| Software/RRHH.Tests/bin/Debug/net48/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll | 8e3d56566beb58ed75564144e1e204e8a11af752cf28c6cb57d0194170c22ea4 |
| Software/RRHH.Tests/bin/Debug/net48/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | c6c0047ecd377ba4eb83da40cfd04bb019dd6c0f68d2034e4a59faf5fa3e89d3 |
| Software/RRHH.Tests/bin/Debug/net48/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll | ff982981f0708bad76fc4d9d9b3b751487e84b88f7c2f12d32b340bd7687a642 |
| Software/RRHH.Tests/bin/Debug/net48/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 74b1352b9479339c2723a6dcd53169d50d4e2316c1684b559aaf10a71e44962b |
| Software/RRHH.Tests/bin/Debug/net48/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll | d6c5e872ac87cd1bc675e9eaabad70f1561506626d95f4a839abb5ea3460713f |
| Software/RRHH.Tests/bin/Debug/net48/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | d1d33fcb48a9d6cddf7485b3268d3b1126b5b079d443206044d995b9fc8126e6 |
| Software/RRHH.Tests/bin/Debug/net48/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll | ae542d7872dcea1ee2ac8638f90ac9373208363ff8106f4ae7dcf4d83c71116e |
| Software/RRHH.Tests/bin/Debug/net48/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | c9f810c770f7cc39a2a015b83dff21b9d5ce4cb303b72b1a23d6b06c092b8507 |
| Software/RRHH.Tests/bin/Debug/net48/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll | ca127d368e4f8a024884511775d86ea12c489b43e2b0346da1f18646191d9d81 |
| Software/RRHH.Tests/bin/Debug/net48/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll | 24894d1c7b2ae6287a416d919c7608068bf88dafb07b06d44ff53094fbfdcf42 |
| Software/RRHH.Tests/obj/Debug/net48/RRHH.Tests.dll | a8d8bfab41df3800caa7ee05e84ffcf315569916fa38318bcaaf7d17ad5f922c |
| Software/lib/resource-runtime/System.Buffers.dll | accccfbe45d9f08ffeed9916e37b33e98c65be012cfff6e7fa7b67210ce1fefb |
| Software/lib/resource-runtime/System.Memory.dll | bf3fb84664f4097f1a8a9bc71a51dcf8cf1a905d4080a4d290da1730866e856f |
| Software/lib/resource-runtime/System.Numerics.Vectors.dll | 1d3ef8698281e7cf7371d1554afef5872b39f96c26da772210a33da041ba1183 |
| Software/lib/resource-runtime/System.Resources.Extensions.dll | b69c9547c7bf0d6e357993d41228b6cef033f4f2e0ecba9f07325c7e980139ae |
| Software/lib/resource-runtime/System.Runtime.CompilerServices.Unsafe.dll | 66409f670315afe8610f17a4d3a1ee52d72b6a46c544cec97544e8385f90ad74 |

La ubicación esperada de DLL heredadas está declarada en HintPath; presencia de DLL de una compilación previa no garantiza que pueda reproducirse el ejecutable actual. Recursos licenciados y recursos Microsoft tienen rutas separadas. [Software/RecursosHumanos/RecursosHumanos.csproj:28](../../Software/RecursosHumanos/RecursosHumanos.csproj#L28); [Software/Directory.Build.props:10](../../Software/Directory.Build.props#L10).

## Configuraciones y conexiones

**SQL Server histórico:** app.config conserva CMIConnectionString con `Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30`, proveedor System.Data.SqlClient. Usa autenticación integrada; esa cadena no contiene contraseña. Settings incluye BaseDatos=CMI, Servidor=localhost, Usuario vacío, AutenticacionIntegrada=True, TiempoConexion=30, AnioActual=2013 y RutaLogo=D:\Sistema_GRLL\Logo_GRLL.jpg. No demuestra una conexión activa a SQL Server. [Software/RecursosHumanos/app.config:15](../../Software/RecursosHumanos/app.config#L15).

**Ruta actual PostgreSQL:** ConnectionFactory carga .env mediante EnvironmentFile, prioriza RRHH_POSTGRES_CONNECTION y, si falta, construye la cadena desde DB_HOST, DB_PORT, DB_NAME, DB_USER, DB_PASSWORD y DB_SSLMODE. Password=[OCULTA]; no se leyó el .env privado ni se publican host/usuario reales obtenidos de él. El nombre CMI del mensaje de login puede estar desactualizado respecto de DB_NAME. [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:17](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L17); [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:71](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L71); [Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:151](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L151).

**Opciones de conexión:** puerto por defecto 5432, SSL Require por defecto, Pooling, KeepAlive=30, Timeout=15, CommandTimeout=60 y TrustServerCertificate cuando SSL no es Disable. DB_CHANNEL_BINDING no se aplica en Npgsql 4.1 según comentario del propio código. No se verificó el transporte de una conexión real. [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:68](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L68).

**Reloj/Access:** AsistenciaAccess obtiene rutas a partir de Settings cifrados y crea conexiones OleDb para la BD biométrica principal y alternativa; no confundir esta BD con la PostgreSQL RRHH. Los valores cifrados se omiten. [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:25](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L25).

**Diagnóstico:** app.config sí define DefaultSource, DefaultSwitch y FileLogTraceListener. Esto impide afirmar “no existen logs”; falta demostrar que los flujos críticos registren eventos en ese listener. [Software/RecursosHumanos/app.config:18](../../Software/RecursosHumanos/app.config#L18).

### Valores Settings recuperados

| Archivo | Clave | Valor saneado | Evidencia |
|---|---|---|---|
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | Serie |  | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:21](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L21) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | SEDE |  | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:34](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L34) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | Aplicacion | (vacío) | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:51](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L51) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | Version |  | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:65](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L65) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | Key | (vacío) | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:80](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L80) |
| Software/ClassRRHH/ClassRRHH/My/MySettings.cs | App | (vacío) | [Software/ClassRRHH/ClassRRHH/My/MySettings.cs:95](../../Software/ClassRRHH/ClassRRHH/My/MySettings.cs#L95) |
| Software/GRLL/GRLL/Common/My/MySettings.cs | CMIConnectionString | Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30 | [Software/GRLL/GRLL/Common/My/MySettings.cs:22](../../Software/GRLL/GRLL/Common/My/MySettings.cs#L22) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | Usuario |  | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:55](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L55) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | BaseDatos | CMI | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:62](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L62) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | Servidor | localhost | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:66](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L66) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | AutenticacionIntegrada | False | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:70](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L70) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | TiempoConexion | 30 | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:76](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L76) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | AnioActual | 2013 | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:82](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L82) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | RutaLogo | D:\\Sistema_GRLL\\Logo_GRLL.jpg | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:97](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L97) |
| Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs | CMIConnectionString | Data Source=localhost;Initial Catalog=CMI;Integrated Security=True;Connect Timeout=30 | [Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs:111](../../Software/RecursosHumanos/RecursosHumanos/My/MySettings.cs#L111) |

### Árbol completo

[Árbol y manifiesto de fuentes](01_arbol.md): inventario físico completo y SHA-256 de cada C# analizado. Los archivos de referencia, pruebas, bin/obj y fuentes auxiliares se distinguen de proyectos integrados.
