param(
 [ValidatePattern('^QA[A-Za-z0-9]{1,10}$')][string]$Documento='QA001',
 [datetime]$Fecha=(Get-Date).Date,
 [ValidatePattern('^([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$')][string]$Entrada='08:00:00',
 [ValidatePattern('^$|^([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$')][string]$Salida='',
 [string]$Carpeta=$PSScriptRoot
)
$ErrorActionPreference='Stop'
if([IntPtr]::Size -ne 4){throw 'Ejecuta este script con Windows PowerShell de 32 bits.'}
if($Salida -and [TimeSpan]::Parse($Salida) -le [TimeSpan]::Parse($Entrada)){throw 'La salida debe ser posterior a la entrada.'}
$Carpeta=(Resolve-Path -LiteralPath $Carpeta).Path
$file=Join-Path $Carpeta 'Marcacion.mdb'
if(Test-Path -LiteralPath $file){throw 'Marcacion.mdb ya existe. Selecciona otra carpeta para conservar el archivo anterior.'}
$cs="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=$file;Jet OLEDB:Engine Type=5;"
$cat=New-Object -ComObject ADOX.Catalog
try{$cat.Create($cs).Close()}finally{[void][Runtime.InteropServices.Marshal]::FinalReleaseComObject($cat)}
$conn=New-Object System.Data.OleDb.OleDbConnection($cs)
$conn.Open()
try{
$date=$Fecha.ToString('MM/dd/yyyy',[Globalization.CultureInfo]::InvariantCulture)
$exitTime=if($Salida){$Salida}else{'00:00:00'}
$statements=@(
 'CREATE TABLE empleado (pers_cod INTEGER, pers_DNI TEXT(12))',
 'CREATE TABLE asis_norm (pers_cod INTEGER, fec_asi DATETIME, hor_ent TEXT(8), hor_sal TEXT(8), alm_ent TEXT(8), alm_sal TEXT(8), idhorario INTEGER, estado YESNO)',
 'CREATE TABLE marcacion (Valor TEXT(12), Fecha DATETIME, Estado TEXT(2), Lugar TEXT(10))',
 "INSERT INTO empleado VALUES (1,'$Documento')",
 "INSERT INTO asis_norm (pers_cod,fec_asi,hor_ent,hor_sal,estado) VALUES (1,#$date#,'$Entrada','$exitTime',True)",
 "INSERT INTO marcacion VALUES ('$Documento',#$date $Entrada#,'E','QA')"
)
if($Salida){$statements += "INSERT INTO marcacion VALUES ('$Documento',#$date $Salida#,'S','QA')"}
foreach($sql in $statements){
 $cmd=$conn.CreateCommand()
 try{$cmd.CommandText=$sql;[void]$cmd.ExecuteNonQuery()}finally{$cmd.Dispose()}
}
$cmd=$conn.CreateCommand()
try{$cmd.CommandText='SELECT COUNT(*) FROM marcacion';$actual=[int]$cmd.ExecuteScalar()}finally{$cmd.Dispose()}
$expected=if($Salida){2}else{1}
if($actual -ne $expected){throw 'El número de marcaciones generado no coincide.'}
Write-Output "Generado: $file ($actual marcaciones; documento $Documento)"
}finally{$conn.Dispose()}
