[CmdletBinding()]
param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $DistributionPath
)

$ErrorActionPreference = 'Stop'
$source = (Resolve-Path -LiteralPath $DistributionPath).Path
$root = Split-Path -Parent $PSScriptRoot
$destination = Join-Path $root 'lib\legacy'

$required = @(
    'GRLL.dll',
    'Interop.Microsoft.Office.Core.dll',
    'DevExpress.Data.v11.2.dll',
    'DevExpress.Printing.v11.2.Core.dll',
    'DevExpress.Utils.v11.2.dll',
    'DevExpress.XtraBars.v11.2.dll',
    'DevExpress.XtraEditors.v11.2.dll',
    'DevExpress.XtraGrid.v11.2.dll',
    'DevExpress.XtraPrinting.v11.2.dll',
    'DevExpress.XtraReports.v11.2.dll',
    'DevExpress.XtraTreeList.v11.2.dll'
)

$missing = @($required | Where-Object {
    -not (Test-Path -LiteralPath (Join-Path $source $_) -PathType Leaf)
})

if ($missing.Count -gt 0) {
    throw "Faltan dependencias en '$source': $($missing -join ', ')"
}

New-Item -ItemType Directory -Path $destination -Force | Out-Null

$files = @(
    Get-ChildItem -LiteralPath $source -File | Where-Object {
        $_.Name -like 'DevExpress.*.v11.2*.dll' -or
        $_.Name -in @(
            'GRLL.dll',
            'ClsCtrls.dll',
            'TabStrip.dll',
            'Custom Featured MessageBox.dll',
            'GRLL.Common.Rutinas.dll',
            'Interop.Microsoft.Office.Core.dll'
        )
    }
)

foreach ($file in $files) {
    Copy-Item -LiteralPath $file.FullName -Destination (Join-Path $destination $file.Name) -Force
}

Write-Host "Dependencias preparadas en: $destination"
Write-Host "Archivos copiados: $($files.Count)"
