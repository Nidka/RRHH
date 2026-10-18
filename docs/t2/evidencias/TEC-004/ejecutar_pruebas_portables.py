"""Verifica fuentes de las capas en .NET 8, sin cambiar el target net48 de producción.
Requiere SDK 8 en PATH. Para integración, RRHH_TEST_POSTGRES_CONNECTION debe
apuntar a una BD local desechable llamada rrhh_tec004_tests; nunca usa .env.
La interfaz WinForms/DevExpress y su ejecución net48 requieren Windows aparte.
"""
from pathlib import Path
import json
import os
import shutil
import subprocess
import tempfile
import xml.etree.ElementTree as ET
from xml.sax.saxutils import escape

repo = Path(__file__).resolve().parents[4]
dotnet = shutil.which("dotnet") or "/opt/homebrew/opt/dotnet@8/bin/dotnet"
paquetes = {
    "RRHH.Domain": ([], []),
    "RRHH.Application": (["RRHH.Domain"], []),
    "RRHH.Presentation": (["RRHH.Application"], []),
    "RRHH.PostgreSql": (["RRHH.Application"], [("Npgsql", "4.1.14"), ("System.Memory", "4.5.5")]),
    "RRHH.Tests": (["RRHH.Domain", "RRHH.Application", "RRHH.Presentation", "RRHH.PostgreSql"],
        [("Microsoft.NET.Test.Sdk", "17.11.1"), ("xunit", "2.9.2"), ("xunit.runner.visualstudio", "2.8.2"), ("Npgsql", "4.1.14")]),
}
with tempfile.TemporaryDirectory(prefix="rrhh-tec004-portable-") as work:
    root = Path(work)
    (root / "BD").mkdir()
    shutil.copyfile(repo / "BD/schema.sql", root / "BD/schema.sql")
    for nombre, (referencias, dependencias) in paquetes.items():
        proyecto = root / nombre
        proyecto.mkdir()
        fuente = (repo / "Software" / nombre).as_posix()
        items = [f'<Compile Include="{escape(fuente)}/**/*.cs" Exclude="{escape(fuente)}/obj/**;{escape(fuente)}/bin/**" />']
        items += [f'<ProjectReference Include="../{r}/{r}.csproj" />' for r in referencias]
        items += [f'<PackageReference Include="{n}" Version="{v}" />' for n, v in dependencias]
        texto = f"""<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup>
<TargetFramework>net8.0</TargetFramework><LangVersion>12.0</LangVersion>
<AssemblyName>{nombre}</AssemblyName><EnableDefaultCompileItems>false</EnableDefaultCompileItems>
<IsTestProject>{str(nombre == 'RRHH.Tests').lower()}</IsTestProject>
</PropertyGroup><ItemGroup>{''.join(items)}</ItemGroup></Project>"""
        (proyecto / (nombre + ".csproj")).write_text(texto)
    resultado = subprocess.run([dotnet, "test", str(root / "RRHH.Tests/RRHH.Tests.csproj"),
        "--logger", "trx;LogFileName=resultado.trx", "--results-directory", str(root / "resultados")],
        cwd=repo, capture_output=True, text=True)
    salida = resultado.stdout + resultado.stderr
    (Path(__file__).parent / "resultado-portable.txt").write_text(salida)
    trx = root / "resultados/resultado.trx"
    if trx.exists():
        tree = ET.parse(trx)
        contadores = tree.find(".//{http://microsoft.com/schemas/VisualStudio/TeamTest/2010}Counters")
        resumen = {"entorno": ".NET 8 portable; no valida ejecución WinForms/net48",
            "fuentes": "capas y suite reales enlazadas, ensamblados separados",
            "integracion_solicitada": bool(os.environ.get("RRHH_TEST_POSTGRES_CONNECTION")),
            "contadores": dict(contadores.attrib) if contadores is not None else {}}
        (Path(__file__).parent / "resumen-portable.json").write_text(json.dumps(resumen, indent=2, ensure_ascii=False) + "\n")
        print(json.dumps(resumen, indent=2, ensure_ascii=False))
    print(salida[-6000:])
    raise SystemExit(resultado.returncode)
