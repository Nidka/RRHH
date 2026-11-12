#!/usr/bin/env python3
"""Ejecuta fuentes reales de las capas y tests en net8; no sustituye Windows/net48.

No carga .env ni selecciona una BD. Las pruebas SQL existentes solo se habilitan
con RRHH_TEST_POSTGRES_CONNECTION y validan host/nombre de BD local desechable.
"""
import argparse
from pathlib import Path
import subprocess
import tempfile
import xml.etree.ElementTree as ET

parser = argparse.ArgumentParser(description=__doc__)
parser.add_argument('--source', help='Origen NuGet opcional, por ejemplo la caché local de paquetes')
args = parser.parse_args()
repo = Path(__file__).resolve().parents[3]
proyectos = ['Domain', 'Application', 'Presentation', 'PostgreSql', 'Tests']
with tempfile.TemporaryDirectory(prefix='rrhh-evelyn-net8-') as temporal:
    raiz = Path(temporal)
    for capa in proyectos:
        nombre = 'RRHH.' + capa
        origen = repo / 'Software' / nombre
        original = ET.parse(origen / (nombre + '.csproj')).getroot()
        proyecto = ET.Element('Project', Sdk='Microsoft.NET.Sdk')
        propiedades = ET.SubElement(proyecto, 'PropertyGroup')
        for clave, valor in {'TargetFramework': 'net8.0', 'LangVersion': '12.0',
                             'AssemblyName': nombre, 'EnableDefaultCompileItems': 'false',
                             'NuGetAudit': 'false'}.items():
            ET.SubElement(propiedades, clave).text = valor
        elementos = ET.SubElement(proyecto, 'ItemGroup')
        ET.SubElement(elementos, 'Compile', Include=str(origen / '**/*.cs'),
                      Exclude=str(origen / 'obj/**') + ';' + str(origen / 'bin/**'))
        for paquete in original.findall('.//PackageReference'):
            ET.SubElement(elementos, 'PackageReference', **paquete.attrib)
        for referencia in original.findall('.//ProjectReference'):
            otro = Path(referencia.attrib['Include'].replace('\\', '/')).stem
            ET.SubElement(elementos, 'ProjectReference', Include=f'../{otro}/{otro}.csproj')
        destino = raiz / nombre
        destino.mkdir()
        ET.ElementTree(proyecto).write(destino / (nombre + '.csproj'), encoding='unicode')
    # MapeosCatalogoTests busca schema.sql subiendo desde el ensamblado temporal.
    (raiz / 'BD').symlink_to(repo / 'BD', target_is_directory=True)
    tests = str(raiz / 'RRHH.Tests/RRHH.Tests.csproj')
    restaurar = ['dotnet', 'restore', tests, '--disable-parallel']
    if args.source:
        restaurar += ['--source', args.source]
    subprocess.run(restaurar, check=True, cwd=repo)
    subprocess.run(['dotnet', 'test', tests, '--no-restore', '-m:1',
                    '--logger', 'console;verbosity=minimal'], check=True, cwd=repo)
