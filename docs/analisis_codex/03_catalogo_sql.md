# Anexo 3A. Catálogo de SQL y comandos

[Volver a acceso a datos](03_acceso_datos.md). Se conservan expresiones y plantillas completas de C#, incluidas pruebas y fuentes auxiliares, indicando su ámbito. No se afirma que todos los comandos se ejecuten ni que interpolación implique vulnerabilidad. Las variables se mantienen como expresiones; no se inventa SQL resuelto en ejecución.

Extracción estructural: 218 expresiones/literales no contenidos en otro extracto, a partir de los 1135 C# parseados sin errores sintácticos. Los comandos construidos exclusivamente a partir de variables se enumeran además en el índice de llamadas inferior.


## Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs

<a id="sql-0001"></a>

### SQL-0001 · AsistenciaAccess.ExistAsistencia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:53](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L53)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccessScalarInt(oCnAccess,
			"SELECT Count(*) FROM Asis_Norm WHERE Pers_Cod = ? AND Fec_Asi = ?",
			new OleDbParameter("persCod", OleDbType.Integer) { Value = Pers_Cod },
			new OleDbParameter("fecha", OleDbType.VarWChar) { Value = Fecha })
```

<a id="sql-0002"></a>

### SQL-0002 · AsistenciaAccess.Grabar_suspencion · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:94](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L94)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"UPDATE Asis_Norm SET Suspendido = true WHERE Pers_Cod = ? AND Fec_Asi = ?"
```

<a id="sql-0003"></a>

### SQL-0003 · AsistenciaAccess.Grabar_suspencion · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:95](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L95)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"INSERT INTO Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal, Suspendido) VALUES (?, ?, '00:00:00', '00:00:00', '00:00:00', '00:00:00', true)"
```

<a id="sql-0004"></a>

### SQL-0004 · AsistenciaAccess.ImportToPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:139](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L139)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ReadAccessTable(accessConnectionString, @"
SELECT e.pers_DNI AS DNI, a.fec_asi, a.hor_ent, a.hor_sal,
       a.alm_ent, a.alm_sal, a.idhorario, a.estado
FROM empleado e INNER JOIN asis_norm a ON e.pers_cod = a.pers_cod
WHERE a.fec_asi >= ? AND a.fec_asi < ?", start, endExclusive)
```

<a id="sql-0005"></a>

### SQL-0005 · AsistenciaAccess.ImportToPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:144](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L144)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ReadAccessTable(accessConnectionString, @"
SELECT Valor AS DNI, Fecha, Estado, Lugar
FROM marcacion
WHERE Fecha >= ? AND Fecha < ?
ORDER BY Fecha", start, endExclusive)
```

<a id="sql-0006"></a>

### SQL-0006 · AsistenciaAccess.ImportAttendanceRows · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:172](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L172)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
transaction.Execute(@"DELETE FROM public.""Asistencia"" WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date;",
					Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.Date))
```

<a id="sql-0007"></a>

### SQL-0007 · AsistenciaAccess.ImportAttendanceRows · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:176](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L176)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
transaction.Execute(@"
INSERT INTO public.""Asistencia""
    (""Fecha"", ""IdEmpleado"", ""Hor_Ent"", ""Hor_Sal"", ""Alm_Ent"", ""Alm_Sal"", ""Estado"", ""idHorario"", ""Usuario"", ""PC"")
SELECT @date, @employee, @arrival, @departure, @lunchArrival, @lunchDeparture, @state, @schedule, 'IMPORTACION', @pc
WHERE NOT EXISTS (
    SELECT 1 FROM public.""Asistencia""
    WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date
);",
				Param("date", date, DbType.DateTime), Param("employee", employeeId, DbType.Int32),
				Param("arrival", TimeText(row["hor_ent"]), DbType.String), Param("departure", TimeText(row["hor_sal"]), DbType.String),
				Param("lunchArrival", TimeText(row["alm_ent"]), DbType.String), Param("lunchDeparture", TimeText(row["alm_sal"]), DbType.String),
				Param("state", BooleanValue(row["estado"]), DbType.Boolean), Param("schedule", NullableInt(row["idhorario"]), DbType.Int32),
				Param("pc", Environment.MachineName, DbType.String))
```

<a id="sql-0008"></a>

### SQL-0008 · AsistenciaAccess.ImportMarkRows · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:200](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L200)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
transaction.Execute(@"DELETE FROM public.""Marcacion"" WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date;",
					Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.DateTime))
```

<a id="sql-0009"></a>

### SQL-0009 · AsistenciaAccess.ImportMarkRows · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:204](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L204)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
transaction.Execute(@"
INSERT INTO public.""Marcacion"" (""Fecha"", ""Estado"", ""IdEmpleado"", ""Lugar"")
SELECT @date, @state, @employee, @place
WHERE NOT EXISTS (
    SELECT 1 FROM public.""Marcacion""
    WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date
);",
				Param("date", date, DbType.DateTime), Param("state", DbValue(row["Estado"]), DbType.String),
				Param("employee", employeeId, DbType.Int32), Param("place", DbValue(row["Lugar"]), DbType.String))
```

<a id="sql-0010"></a>

### SQL-0010 · AsistenciaAccess.LoadEmployeesByDocument · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:230](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L230)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query(@"
SELECT e.""IdEmpleado"", p.""NumDocID""
FROM public.""Empleado"" e
JOIN public.""Persona"" p ON p.""IdPersona"" = e.""IdPersona""
WHERE p.""NumDocID"" IS NOT NULL;")
```

<a id="sql-0011"></a>

### SQL-0011 · AsistenciaAccess.InsertAccessAttendance · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:246](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L246)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccess(connection, "INSERT INTO Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal) VALUES (?, ?, ?, ?, ?, ?)",
			new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("date", OleDbType.VarWChar) { Value = date },
			new OleDbParameter("arrival", OleDbType.VarWChar) { Value = arrival }, new OleDbParameter("departure", OleDbType.VarWChar) { Value = departure },
			new OleDbParameter("lunchArrival", OleDbType.VarWChar) { Value = lunchArrival }, new OleDbParameter("lunchDeparture", OleDbType.VarWChar) { Value = lunchDeparture })
```

<a id="sql-0012"></a>

### SQL-0012 · AsistenciaAccess.InsertAccessMark · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:254](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L254)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccess(connection, "INSERT INTO Marcacion (Fecha, Valor, Estado, Proceso, Lugar) VALUES (?, ?, ?, ?, ?)",
			new OleDbParameter("date", OleDbType.VarWChar) { Value = date }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document },
			new OleDbParameter("state", OleDbType.VarWChar) { Value = state }, new OleDbParameter("process", OleDbType.Integer) { Value = process },
			new OleDbParameter("place", OleDbType.VarWChar) { Value = place })
```

<a id="sql-0013"></a>

### SQL-0013 · AsistenciaAccess.UpdateAccessSchedule · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:262](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L262)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccess(connection, "UPDATE Empleado SET idHorario = ? WHERE pers_estado = true AND pers_DNI = ?",
			new OleDbParameter("schedule", OleDbType.Integer) { Value = scheduleId }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document.Trim() })
```

<a id="sql-0014"></a>

### SQL-0014 · AsistenciaAccess.InsertAccessPermission · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:268](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L268)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccess(connection, "INSERT INTO Permiso (idEmpleado, NPermiso, FechaInicio, FechaFin, dia, Retorno, Lugar) VALUES (?, ?, ?, ?, ?, ?, ?)",
			new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("permission", OleDbType.Integer) { Value = permissionNumber },
			new OleDbParameter("start", OleDbType.VarWChar) { Value = start }, new OleDbParameter("end", OleDbType.VarWChar) { Value = end },
			new OleDbParameter("fullDay", OleDbType.Boolean) { Value = fullDay }, new OleDbParameter("returns", OleDbType.Boolean) { Value = returns },
			new OleDbParameter("place", OleDbType.VarWChar) { Value = place })
```

<a id="sql-0015"></a>

### SQL-0015 · AsistenciaAccess.GetAccessPersonCode · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:276](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L276)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
ExecuteAccessScalarInt(connection, "SELECT pers_cod FROM Empleado WHERE pers_estado = true AND pers_dni = ?",
			new OleDbParameter("document", OleDbType.VarWChar) { Value = document.Trim() })
```

## Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs

<a id="sql-0016"></a>

### SQL-0016 · FamiliaresClass.llena_parentezco · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:22](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L22)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"IdTipoFam\", \"DescripTipoFam\" " +
			"FROM public.\"TipoFamiliar\" ORDER BY \"DescripTipoFam\";")
```

<a id="sql-0017"></a>

### SQL-0017 · FamiliaresClass.Busca_DNI · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:29](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L29)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT * FROM public.\"Persona\" " +
			"WHERE btrim(\"NumDocID\") = btrim(@numDoc) AND \"TipoDocID\" = @tipoDoc;",
			new PostgreSqlParameterValue("numDoc", numDoc),
			new PostgreSqlParameterValue("tipoDoc", tipodoc))
```

<a id="sql-0018"></a>

### SQL-0018 · FamiliaresClass.Busca_Codigo · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:38](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L38)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT p.*, f.* FROM public.\"Persona\" AS p " +
			"INNER JOIN public.\"Familiar\" AS f ON f.\"IdPersona\" = p.\"IdPersona\" " +
			"WHERE p.\"IdPersona\" = @personaId;",
			new PostgreSqlParameterValue("personaId", Codper))
```

## Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs

<a id="sql-0019"></a>

### SQL-0019 · FichaSocialClass.llenarFamiliares · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs:22](../../Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs#L22)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"""
SELECT
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    p."FechaNacimiento" AS "fechaNacimiento",
    f."FamSexo" AS "famSexo",
    tf."DescripTipoFam",
    f."FamGradoInstruc" AS "famgradoInstruc",
    ec."DescripEstCivil" AS "descripestcivil",
    f."ViveCasa" AS "vivecasa",
    p."IdPersona" AS "Idpersona",
    f."LaboraInstitucion" AS "laborainstitucion"
FROM public."Familiar" AS f
INNER JOIN public."Persona" AS p ON p."IdPersona" = f."IdPersona"
LEFT JOIN public."TipoFamiliar" AS tf ON tf."IdTipoFam" = f."IdTipoFam"
LEFT JOIN public."EstadoCivil" AS ec ON ec."IdEstadoCivil" = f."IdEstadoCivil"
WHERE f."IdEmpleado" = @empleadoId
ORDER BY "NombresCompletos";
"""
```

## Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs

<a id="sql-0020"></a>

### SQL-0020 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs:161](../../Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs#L161)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
elems.Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)
```

<a id="sql-0021"></a>

### SQL-0021 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs:163](../../Software/ClassRRHH/ClassRRHH/My/InternalXmlHelper.cs#L163)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject)
```

## Software/ClassRRHH/ClassRRHH/RRHHClass.cs

<a id="sql-0022"></a>

### SQL-0022 · RRHHClass.llena_DocID · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:57](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L57)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_database.Query(
			"SELECT \"TipoDocID\", \"Descripcion\" FROM public.\"TipoDocID\" ORDER BY \"Descripcion\";")
```

<a id="sql-0023"></a>

### SQL-0023 · RRHHClass.llena_Area · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:63](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L63)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +
			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";",
			new PostgreSqlParameterValue("year", mAnio))
```

<a id="sql-0024"></a>

### SQL-0024 · RRHHClass.llena_Nacionalidad · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:71](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L71)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_database.Query(
			"SELECT \"IdNacionalidad\", \"Descripcion\" FROM public.\"Nacionalidad\" ORDER BY \"Descripcion\";")
```

<a id="sql-0025"></a>

### SQL-0025 · RRHHClass.llena_Discapacidad · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:77](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L77)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"IdDiscapacidad\", \"Descrip_Discapacidad\" FROM public.\"Discapacidad\" " +
			"ORDER BY \"Descrip_Discapacidad\";")
```

<a id="sql-0026"></a>

### SQL-0026 · RRHHClass.llena_estCivil · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:84](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L84)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"IdEstadoCivil\", \"DescripEstCivil\" FROM public.\"EstadoCivil\" " +
			"ORDER BY \"DescripEstCivil\";")
```

<a id="sql-0027"></a>

### SQL-0027 · RRHHClass.SgtIdPermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:91](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L91)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.ScalarInt(
			"SELECT COALESCE(MAX(\"NPermiso\"), 0) + 1 FROM public.\"Permiso\" WHERE \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", idempleado))
```

<a id="sql-0028"></a>

### SQL-0028 · RRHHClass.SgtIdHorarioTemporal · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:98](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L98)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.ScalarInt(
			"SELECT COALESCE(MAX(\"N\"), 0) + 1 FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", idempleado))
```

<a id="sql-0029"></a>

### SQL-0029 · RRHHClass.importarBio · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:105](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L105)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute("""
INSERT INTO public."Asistencia"
    ("Fecha","IdEmpleado","Hor_Ent","Hor_Sal","Flag_Ent","Flag_Sal","Estado","idHorario","Usuario","PC")
SELECT m."Fecha"::date, m."IdEmpleado",
       to_char(MIN(m."Fecha"),'HH24:MI:SS'), to_char(MAX(m."Fecha"),'HH24:MI:SS'),
       TRUE, COUNT(*) > 1, TRUE, MAX(m."idHorario"), 'MIGRACION_BIO', 'POSTGRESQL'
FROM public."Marcacion" m
WHERE m."Fecha"::date BETWEEN @inicio AND @fin
GROUP BY m."Fecha"::date,m."IdEmpleado"
ON CONFLICT ("Fecha","IdEmpleado") DO UPDATE SET
  "Hor_Ent"=EXCLUDED."Hor_Ent", "Hor_Sal"=EXCLUDED."Hor_Sal",
  "Flag_Ent"=EXCLUDED."Flag_Ent", "Flag_Sal"=EXCLUDED."Flag_Sal",
  "Estado"=EXCLUDED."Estado", "idHorario"=EXCLUDED."idHorario";
""", new PostgreSqlParameterValue("inicio", ParseDate(FechaInicial).Date, DbType.Date),
			new PostgreSqlParameterValue("fin", ParseDate(FechaFinal).Date, DbType.Date))
```

<a id="sql-0030"></a>

### SQL-0030 · RRHHClass.ExisteMarcacion · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:125](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L125)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.ScalarInt(
			"SELECT COUNT(*) FROM public.\"Marcacion\" WHERE \"Fecha\" = @fecha AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha), DbType.DateTime),
			new PostgreSqlParameterValue("empleadoId", idempleado))
```

<a id="sql-0031"></a>

### SQL-0031 · RRHHClass.ExisteAsistencia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:133](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L133)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.ScalarInt(
			"SELECT COUNT(*) FROM public.\"Asistencia\" WHERE \"Fecha\" = @fecha AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha), DbType.DateTime),
			new PostgreSqlParameterValue("empleadoId", idempleado))
```

<a id="sql-0032"></a>

### SQL-0032 · RRHHClass.ElimnarPermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:141](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L141)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
			"DELETE FROM public.\"Permiso\" WHERE \"IdEmpleado\" = @empleadoId AND \"NPermiso\" = @numero;",
			new PostgreSqlParameterValue("empleadoId", idempleado),
			new PostgreSqlParameterValue("numero", NPermiso))
```

<a id="sql-0033"></a>

### SQL-0033 · RRHHClass.eliminarHorarioTemporal · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:150](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L150)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
			"DELETE FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\" = @empleadoId AND \"N\" = @numero;",
			new PostgreSqlParameterValue("empleadoId", idempleado),
			new PostgreSqlParameterValue("numero", NPermiso))
```

<a id="sql-0034"></a>

### SQL-0034 · RRHHClass.llenar_Empleado_Area · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:159](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L159)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT ea."Year", ea."idAreaOrganiz", eo."AreaOrganizacional"
FROM public."Empleado_Area" AS ea
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE ea."IdEmpleado" = @empleadoId
ORDER BY ea."Year" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", idEmpleado))
```

<a id="sql-0035"></a>

### SQL-0035 · RRHHClass.Actualizar_Area_Empleado · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:172](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L172)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			"UPDATE public.\"Empleado_Area\" SET \"idAreaOrganiz\" = @areaId " +
			"WHERE \"Year\" = @year AND \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("areaId", idAreaOrganiz),
			new PostgreSqlParameterValue("year", Anio),
			new PostgreSqlParameterValue("empleadoId", idEmpleado))
```

<a id="sql-0036"></a>

### SQL-0036 · RRHHClass.llenar_Areas_by_año · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:182](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L182)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"Year\", \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +
			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";",
			new PostgreSqlParameterValue("year", Anio))
```

<a id="sql-0037"></a>

### SQL-0037 · RRHHClass.buscar_empleado · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:190](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L190)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"""
SELECT
    e."IdTipoTrabajador",
    e."IdEmpleado" AS "Codigo",
    p."NumDocID" AS "DNI",
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    eo."AreaOrganizacional",
    c."Cargo" AS "cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = @estado
  AND (@apellido = '' OR btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) ILIKE @apellido || '%')
  AND (@numeroDocumento = '' OR btrim(p."NumDocID") = btrim(@numeroDocumento))
  AND (@empleadoId IS NULL OR e."IdEmpleado" = @empleadoId)
  AND (@year IS NULL OR ea."Year" = @year)
  AND (
      (@rol = 3 AND e."IdTipoTrabajador" = 2)
      OR (@rol = 4 AND e."IdTipoTrabajador" IN (1, 3, 4, 5))
      OR (@rol NOT IN (3, 4) AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador))
  )
ORDER BY "NombresCompletos";
"""
```

<a id="sql-0038"></a>

### SQL-0038 · RRHHClass.BuscarEmpleado_Codigo · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:230](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L230)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"""
SELECT
    p."Nombres", p."Apellido_Paterno", p."Apellido_Materno", e."Sexo",
    p."TipoDocID", p."NumDocID", e."IdNacionalidad", p."FechaNacimiento",
    p."Telefono", p."NumCelular", p."FonoCentroLab", p."Fax",
    e."IdEstadoCivil", e."IdDiscapacidad", p."IdUbigeo", p."Direccion",
    p."UbigeoDireccion", e."ExpSocial", e."Foto", e."IdPersona",
    e."Year", e."idAreaOrganiz", p."FechaRegistro", p."Email",
    e."IdTipoSangre", e."GradoInstruccion", e."NumLibretaMilitar",
    e."Brevete", e."NumRUC", e."idHorario", e."IdTipoTrabajador"
FROM public."Persona" AS p
INNER JOIN public."Empleado" AS e ON e."IdPersona" = p."IdPersona"
WHERE e."IdEmpleado" = @empleadoId;
"""
```

<a id="sql-0039"></a>

### SQL-0039 · RRHHClass.ActualizaAsistencia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:252](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L252)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			"UPDATE public.\"Asistencia\" SET \"Hor_Sal\" = @horaSalida, \"Flag_Sal\" = @salidaManual " +
			"WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\" = @fecha;",
			new PostgreSqlParameterValue("horaSalida", hor_sal),
			new PostgreSqlParameterValue("salidaManual", flag_sal),
			new PostgreSqlParameterValue("empleadoId", idEmpleado),
			new PostgreSqlParameterValue("fecha", fecha, DbType.DateTime))
```

<a id="sql-0040"></a>

### SQL-0040 · RRHHClass.ExistePermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:264](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L264)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.ScalarInt("""
SELECT COUNT(*)
FROM public."Permiso"
WHERE "IdEmpleado" = @empleadoId
  AND (@fechaInicio::date BETWEEN "FechaInicio"::date AND "FechaFin"::date
       OR @fechaFin::date BETWEEN "FechaInicio"::date AND "FechaFin"::date);
""",
			new PostgreSqlParameterValue("empleadoId", idEmpleado),
			new PostgreSqlParameterValue("fechaInicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fechaFin", ParseCompactDate(FechaFin), DbType.Date))
```

<a id="sql-0041"></a>

### SQL-0041 · RRHHClass.ingresa_Empleado_Area · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:278](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L278)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			"INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +
			"VALUES (@year, @areaId, @empleadoId);",
			new PostgreSqlParameterValue("year", year),
			new PostgreSqlParameterValue("areaId", idorganiz),
			new PostgreSqlParameterValue("empleadoId", idEmpleado))
```

<a id="sql-0042"></a>

### SQL-0042 · RRHHClass.Ingresa_Empleado · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:288](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L288)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.InTransaction(transaction =>
		{
			// El esquema migrado no trae secuencias. El bloqueo evita IDs repetidos
			// mientras se reemplaza el procedimiento cifrado spRRHH_GrabarEmpleado.
			transaction.Execute("SELECT pg_advisory_xact_lock(721104);");
			int personaId = transaction.ScalarInt(
				"SELECT COALESCE(MAX(\"IdPersona\"), 0) + 1 FROM public.\"Persona\";");
			int empleadoId = transaction.ScalarInt(
				"SELECT COALESCE(MAX(\"IdEmpleado\"), 0) + 1 FROM public.\"Empleado\";");

			transaction.Execute("""
INSERT INTO public."Persona"
    ("IdPersona", "Nombres", "Apellido_Paterno", "Apellido_Materno", "TipoDocID", "NumDocID",
     "Direccion", "Telefono", "Fax", "Email", "IdUbigeo", "UbigeoDireccion", "TipoPersona",
     "FechaNacimiento", "FechaRegistro", "NumCelular", "FonoCentroLab")
VALUES
    (@personaId, @nombres, @apellidoPaterno, @apellidoMaterno, @tipoDoc, @numeroDoc,
     @direccion, @telefono, @fax, @email, @ubigeoNacimiento, @ubigeoDireccion, 'N',
     @fechaNacimiento, @fechaRegistro, @celular, @telefonoLaboral);
""",
				new PostgreSqlParameterValue("personaId", personaId),
				Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno),
				Text("apellidoMaterno", Apellido_Materno),
				new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc),
				Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro),
				Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac),
				Text("ubigeoDireccion", UbigeoDireccion),
				new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime),
				new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime),
				Text("celular", FonoCel), Text("telefonoLaboral", FonoLab));

			transaction.Execute("""
INSERT INTO public."Empleado"
    ("IdEmpleado", "Year", "idAreaOrganiz", "IdPersona", "ExpSocial", "FechaIngreso",
     "Brevete", "IdEstadoCivil", "Sexo", "IdTipoSangre", "Foto", "IdTipoTrabajador",
     "Estado", "IdDiscapacidad", "IdNacionalidad", "NumLibretaMilitar", "GradoInstruccion", "NumRUC")
VALUES
    (@empleadoId, @year, @areaId, @personaId, @expSocial, @fechaIngreso,
     @brevete, @estadoCivil, @sexo, @tipoSangre, @foto, @tipoTrabajador,
     '1', @discapacidad, @nacionalidad, @libretaMilitar, @gradoInstruccion, @ruc);
""",
				new PostgreSqlParameterValue("empleadoId", empleadoId),
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz),
				new PostgreSqlParameterValue("personaId", personaId),
				Text("expSocial", expSocial),
				new PostgreSqlParameterValue("fechaIngreso", FechaIngreso, DbType.DateTime),
				Text("brevete", brevete), new PostgreSqlParameterValue("estadoCivil", idEstCivil),
				Text("sexo", sexo), new PostgreSqlParameterValue("tipoSangre", tiposangre),
				Text("foto", EncodePhoto(Foto)),
				NullableInt("tipoTrabajador", idtipoTrabajador),
				new PostgreSqlParameterValue("discapacidad", idDiscapacidad),
				NullableInt("nacionalidad", idNacionalidad), Text("libretaMilitar", libmilitar),
				Text("gradoInstruccion", gradoinstruccion), Text("ruc", numRuc));

			transaction.Execute(
				"INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +
				"VALUES (@year, @areaId, @empleadoId);",
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz),
				new PostgreSqlParameterValue("empleadoId", empleadoId));

			return empleadoId;
		})
```

<a id="sql-0043"></a>

### SQL-0043 · RRHHClass.Actualiza_Empleado · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:356](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L356)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(transaction =>
		{
			transaction.Execute("""
UPDATE public."Persona" SET
    "Nombres" = @nombres, "Apellido_Paterno" = @apellidoPaterno,
    "Apellido_Materno" = @apellidoMaterno, "TipoDocID" = @tipoDoc,
    "NumDocID" = @numeroDoc, "Direccion" = @direccion, "Telefono" = @telefono,
    "Fax" = @fax, "Email" = @email, "IdUbigeo" = @ubigeoNacimiento,
    "UbigeoDireccion" = @ubigeoDireccion, "TipoPersona" = 'N',
    "FechaNacimiento" = @fechaNacimiento, "FechaRegistro" = @fechaRegistro,
    "NumCelular" = @celular, "FonoCentroLab" = @telefonoLaboral
WHERE "IdPersona" = @personaId;
""",
				Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno),
				Text("apellidoMaterno", Apellido_Materno),
				new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc),
				Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro),
				Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac),
				Text("ubigeoDireccion", UbigeoDireccion),
				new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime),
				new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime),
				Text("celular", FonoCel), Text("telefonoLaboral", FonoLab),
				new PostgreSqlParameterValue("personaId", codpersona));

			transaction.Execute("""
UPDATE public."Empleado" SET
    "Year" = @year, "idAreaOrganiz" = @areaId, "ExpSocial" = @expSocial,
    "IdEstadoCivil" = @estadoCivil, "Sexo" = @sexo, "Foto" = @foto,
    "IdDiscapacidad" = @discapacidad, "IdNacionalidad" = @nacionalidad,
    "Estado" = '1', "IdTipoSangre" = @tipoSangre, "Brevete" = @brevete,
    "NumLibretaMilitar" = @libretaMilitar, "GradoInstruccion" = @gradoInstruccion,
    "NumRUC" = @ruc, "IdTipoTrabajador" = @tipoTrabajador
WHERE "IdEmpleado" = @empleadoId;
""",
				new PostgreSqlParameterValue("year", year),
				new PostgreSqlParameterValue("areaId", idorganiz), Text("expSocial", expSocial),
				new PostgreSqlParameterValue("estadoCivil", idEstCivil), Text("sexo", sexo),
				Text("foto", EncodePhoto(Foto)),
				new PostgreSqlParameterValue("discapacidad", idDiscapacidad),
				NullableInt("nacionalidad", idNacionalidad),
				new PostgreSqlParameterValue("tipoSangre", tiposangre), Text("brevete", brevete),
				Text("libretaMilitar", libmilitar), Text("gradoInstruccion", gradoinstruccion),
				Text("ruc", numRuc), NullableInt("tipoTrabajador", idtipoTrabajador),
				new PostgreSqlParameterValue("empleadoId", codempleado));

			return true;
		})
```

<a id="sql-0044"></a>

### SQL-0044 · RRHHClass.Actualiza_Empleado · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:409](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L409)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
			"UPDATE public.\"Empleado\" SET \"Estado\" = '0' WHERE \"IdEmpleado\" = @empleadoId;",
			new PostgreSqlParameterValue("empleadoId", codempleado))
```

<a id="sql-0045"></a>

### SQL-0045 · RRHHClass.llena_tree · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:416](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L416)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT \"idAreaOrganiz\" AS \"Padre\", \"AreaOrganizacional\", \"idDependeDe\" AS \"Hijo\" " +
			"FROM public.\"EstructOrganiz\" WHERE \"Year\" = @year;",
			new PostgreSqlParameterValue("year", mAnio))
```

<a id="sql-0046"></a>

### SQL-0046 · RRHHClass.buscar_empleado_tree · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:424](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L424)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT
    e."IdTipoTrabajador",
    e."IdEmpleado" AS "Codigo",
    p."NumDocID" AS "DNI",
    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",
    c."Cargo" AS "Cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE ea."idAreaOrganiz" = @areaId
  AND ea."Year" = @year
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND (@tipoTrabajador = 0 OR e."IdTipoTrabajador" = @tipoTrabajador)
ORDER BY "NombresCompletos";
""",
			new PostgreSqlParameterValue("areaId", area),
			new PostgreSqlParameterValue("year", mAnio),
			new PostgreSqlParameterValue("tipoTrabajador", tipotrab))
```

<a id="sql-0047"></a>

### SQL-0047 · RRHHClass.Generar_Cuadro_Pers · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:589](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L589)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado" AS "Codigo", p."NumDocID" AS "DNI",
       btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       eo."AreaOrganizacional", c."Cargo" AS "cargo", tt."Descripcion",
       e."Estado", e."IdTipoTrabajador"
FROM public."Empleado" e
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"
LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "NombresCompletos";
""", new PostgreSqlParameterValue("year", mAnio), new PostgreSqlParameterValue("tipo", tipo))
```

<a id="sql-0048"></a>

### SQL-0048 · RRHHClass.Generar_Cumples · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:609](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L609)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       EXTRACT(DAY FROM p."FechaNacimiento")::integer AS "Dia",
       EXTRACT(MONTH FROM p."FechaNacimiento")::integer AS "mes",
       trim(to_char(p."FechaNacimiento", 'TMMonth')) AS "MESletras",
       EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",
       eo."AreaOrganizacional", e."Estado"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE EXTRACT(MONTH FROM p."FechaNacimiento")=@mes
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "Dia", "NombresCompletos";
""", new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("mes", mes))
```

<a id="sql-0049"></a>

### SQL-0049 · RRHHClass.llena_tree_reporte · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:628](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L628)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT "AreaOrganizacional", COALESCE(NULLIF("Sigla",''),"Abrev") AS "siglafull",
       "idAreaOrganiz" AS "Padre", "idDependeDe" AS "Hijo"
FROM public."EstructOrganiz" WHERE "Year"=@year ORDER BY "AreaOrganizacional";
""", new PostgreSqlParameterValue("year", mAnio))
```

<a id="sql-0050"></a>

### SQL-0050 · RRHHClass.Generar_Report_Emple_ficha · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:649](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L649)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",
       e."FechaIngreso" AS "FechadeIngreso", eo."AreaOrganizacional",
       EXTRACT(YEAR FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "años",
       EXTRACT(MONTH FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "meses",
       EXTRACT(DAY FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "dias"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE e."FechaIngreso"::date BETWEEN @inicio AND @fin AND (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
ORDER BY e."FechaIngreso", "NombresCompletos";
""", new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(Fechatermino), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo))
```

<a id="sql-0051"></a>

### SQL-0051 · RRHHClass.generar_rep_cargos · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:669](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L669)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",
       eo."AreaOrganizacional", c."Cargo" AS "cargo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = e."idAreaOrganiz" AND eo."Year" = e."Year"
INNER JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
WHERE e."IdCargo" = @cargoId
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND e."IdTipoTrabajador" = 1;
""",
			new PostgreSqlParameterValue("cargoId", idCargo))
```

<a id="sql-0052"></a>

### SQL-0052 · RRHHClass.llena_Asistencias · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:686](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L686)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT a.*, p."NumDocID", p."Apellido_Paterno", p."Apellido_Materno", p."Nombres"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin ORDER BY a."Fecha",p."Apellido_Paterno";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaFin), DbType.Date))
```

<a id="sql-0053"></a>

### SQL-0053 · RRHHClass.llena_Permisos · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:697](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L697)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT tp."DescripTipoPermiso", m."Descrip_Motivo", p."NPermiso",
       p."FechaInicio", p."FechaFin", p."Hora_Sal", p."Hora_Ret", p."Dia",
       p."Retorno", p."Lugar", p."Referencia", p."Autorizacion", p."IdEmpleado"
FROM public."Permiso" AS p
INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"
INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
WHERE p."IdEmpleado" = @empleadoId
  AND (@tipoPermiso IS NULL OR tp."idTipoPermiso" = @tipoPermiso)
  AND (@motivo IS NULL OR m."idMotivo" = @motivo)
ORDER BY p."FechaInicio" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", codempleado),
			new PostgreSqlParameterValue("tipoPermiso", permiso, DbType.Int32),
			new PostgreSqlParameterValue("motivo", motivo, DbType.Int32))
```

<a id="sql-0054"></a>

### SQL-0054 · RRHHClass.llena_HorariosTemporales · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:716](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L716)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT ht."N", ht."FechaInicio", ht."FechaFin", h."Descrip_Horario",
       h."Ingreso1", h."Salida2", ht."NroDocumento", ht."Sisgedo"
FROM public."HorarioTemporal" AS ht
INNER JOIN public."Horario" AS h ON h."idHorario" = ht."HorarioAsignado"
WHERE ht."idEmpleado" = @empleadoId
ORDER BY ht."FechaInicio" DESC;
""",
			new PostgreSqlParameterValue("empleadoId", codempleado))
```

<a id="sql-0055"></a>

### SQL-0055 · RRHHClass.Generar_Rep_Faltas · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:729](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L729)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC",
       p."NumDocID", p."IdPersona", e."IdEmpleado", ea."Year", ea."idAreaOrganiz",
       e."IdTipoTrabajador", e."Estado", eo."AreaOrganizacional", tt."Descripcion",
       NULL::timestamp AS "Fecha"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
LEFT JOIN public."TipoTrabajador" AS tt ON tt."IdTipoTrabajador" = e."IdTipoTrabajador"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)
  AND (@areaId IS NULL OR ea."idAreaOrganiz" = @areaId)
  AND (@year IS NULL OR ea."Year" = @year)
  AND NOT EXISTS (
      SELECT 1 FROM public."Asistencia" AS a
      WHERE a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha
  )
ORDER BY "NombresC";
""",
			new PostgreSqlParameterValue("fecha", ParseDate(fecha).Date, DbType.Date),
			new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32),
			new PostgreSqlParameterValue("areaId", idAreaOrganiz, DbType.Int32),
			new PostgreSqlParameterValue("year", Año, DbType.Int32))
```

<a id="sql-0056"></a>

### SQL-0056 · RRHHClass.ObtenerAsistenciasxDia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:760](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L760)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT a."Fecha", e."IdEmpleado",
       CASE WHEN a."IdEmpleado" IS NULL THEN 'F' ELSE 'A' END AS "Estado"
FROM public."Empleado" AS e
LEFT JOIN public."Asistencia" AS a
    ON a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
ORDER BY e."IdEmpleado";
""",
			new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date))
```

<a id="sql-0057"></a>

### SQL-0057 · RRHHClass.ObtenerEmpleados · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:776](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L776)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_database.Query("""
SELECT e."IdEmpleado" AS "idempleado",
       btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
ORDER BY "NombresC";
""")
```

<a id="sql-0058"></a>

### SQL-0058 · RRHHClass.LlenarPlanillaAsistencia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:803](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L803)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado", btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
       a."Fecha"::date AS "Dia", a."Hor_Ent", a."Hor_Sal"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)
  AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))
  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY "NombresC",a."Fecha";
""", new PostgreSqlParameterValue("inicio", dates.Min(), DbType.Date),
			new PostgreSqlParameterValue("fin", dates.Max(), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("locales", locales))
```

<a id="sql-0059"></a>

### SQL-0059 · RRHHClass.spRRHH_RepPermisos · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:837](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L837)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT
    btrim(concat_ws(' ', pe."Apellido_Paterno", pe."Apellido_Materno", pe."Nombres")) AS "Nombres",
    c."Cargo", eo."AreaOrganizacional", m."Descrip_Motivo",
    p."FechaInicio", p."FechaFin", COALESCE(p."Hora_Sal", '--') AS "Hora_Sal",
    COALESCE(p."Hora_Ret", '--') AS "Hora_ret", COALESCE(p."Lugar", 'No Especifica') AS "Lugar",
    COALESCE(p."Obs", '--') AS "Observaciones"
FROM public."Permiso" AS p
INNER JOIN public."Empleado" AS e ON e."IdEmpleado" = p."IdEmpleado"
INNER JOIN public."Persona" AS pe ON pe."IdPersona" = e."IdPersona"
INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"
INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"
INNER JOIN public."Empleado_Area" AS ea
    ON ea."IdEmpleado" = e."IdEmpleado" AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE p."FechaInicio"::date BETWEEN @fechaInicio AND @fechaFin
  AND (@tipoPermiso IS NULL OR m."idTipoPermiso" = @tipoPermiso)
  AND (@motivo IS NULL OR p."idMotivo" = @motivo)
  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)
ORDER BY p."FechaInicio";
""",
			new PostgreSqlParameterValue("fechaInicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fechaFin", ParseCompactDate(fechaF), DbType.Date),
			new PostgreSqlParameterValue("tipoPermiso", tipopermiso, DbType.Int32),
			new PostgreSqlParameterValue("motivo", motivo, DbType.Int32),
			new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32))
```

<a id="sql-0060"></a>

### SQL-0060 · RRHHClass.spRRHH_ObtenerHorasExtras · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:871](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L871)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado",p."NumDocID",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 a."Fecha",a."Hor_Ent",a."Hor_Sal",h."Salida1",
 ROUND(GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-h."Salida1"::time))/3600)::numeric,2) AS "HorasExtras"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}' AND h."Salida1" ~ '^\d{1,2}:\d{2}'
ORDER BY a."Fecha","NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date),
			new PostgreSqlParameterValue("tipo", tipo, DbType.Int32))
```

<a id="sql-0061"></a>

### SQL-0061 · RRHHClass.BuscarPersonas · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:891](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L891)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT "IdPersona", "Apellido_Paterno", "Apellido_Materno", "Nombres"
FROM public."Persona"
WHERE "Apellido_Paterno" ILIKE @apellido || '%' AND "TipoPersona" = 'N'
ORDER BY "Apellido_Paterno", "Apellido_Materno", "Nombres";
""",
			Text("apellido", ApellidoPaterno ?? string.Empty))
```

<a id="sql-0062"></a>

### SQL-0062 · RRHHClass.ListarProfesiones · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:902](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L902)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			"SELECT DISTINCT \"Profesion\" FROM public.\"Empleado\" " +
			"WHERE NULLIF(btrim(\"Profesion\"), '') IS NOT NULL ORDER BY \"Profesion\";")
```

<a id="sql-0063"></a>

### SQL-0063 · RRHHClass.spRRHH_Rep_profesion · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:909](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L909)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",
       eo."AreaOrganizacional", e."Profesion"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"
INNER JOIN public."EstructOrganiz" AS eo
    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"
WHERE e."Profesion" = @profesion
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
  AND e."IdTipoTrabajador" = 1;
""",
			Text("profesion", profesion))
```

<a id="sql-0064"></a>

### SQL-0064 · RRHHClass.spRRHH_AgregarReporte · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:939](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L939)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute("""
INSERT INTO public."AuxRRHH_ReporteAsistencia" ("idEmpleado")
SELECT @empleadoId
WHERE NOT EXISTS (
    SELECT 1 FROM public."AuxRRHH_ReporteAsistencia" WHERE "idEmpleado" = @empleadoId
);
""",
				new PostgreSqlParameterValue("empleadoId", idTipoTrabajador))
```

<a id="sql-0065"></a>

### SQL-0065 · RRHHClass.spRRHH_AgregarReporte · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:950](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L950)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
				"DELETE FROM public.\"AuxRRHH_ReporteAsistencia\" WHERE \"idEmpleado\" = @empleadoId;",
				new PostgreSqlParameterValue("empleadoId", idTipoTrabajador))
```

<a id="sql-0066"></a>

### SQL-0066 · RRHHClass.spRRHH_RepAsisdiarria · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:961](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L961)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT a.*,p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 eo."AreaOrganizacional",l."NombreLocal"
FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"
JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Local" l ON l."idLocal"=e."idLocal"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin
 AND (@dni IS NULL OR p."NumDocID" ILIKE '%'||@dni||'%')
 AND (@area IS NULL OR ea."idAreaOrganiz"=@area) AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))
ORDER BY a."Fecha","NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date),
			Text("dni", string.IsNullOrWhiteSpace(DNI) ? null : DNI.Trim()),
			new PostgreSqlParameterValue("area", area, DbType.Int32),
			new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
			new PostgreSqlParameterValue("year", int.TryParse(year, out int parsedYear) ? parsedYear : DateTime.Today.Year),
			new PostgreSqlParameterValue("locales", locales))
```

<a id="sql-0067"></a>

### SQL-0067 · RRHHClass.spRRHH_ListarMotivos_byTipo · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:988](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L988)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT "Abrev", "Descrip_Motivo"
FROM public."Motivo_Perm"
WHERE COALESCE("Activo", FALSE) AND "TipoModalidad" = @modalidad AND "Abrev" <> '1'
ORDER BY "Abrev";
""",
			Text("modalidad", fechaI))
```

<a id="sql-0068"></a>

### SQL-0068 · RRHHClass.spRRHH_EstadisticaPermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1004](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1004)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 e."IdEmpleado",p."NumDocID",
 COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "MinutosTarde",
 eo."AreaOrganizacional",ea."idAreaOrganiz"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo) AND (@area=0 OR ea."idAreaOrganiz"=@area)
 AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",eo."AreaOrganizacional",ea."idAreaOrganiz"
ORDER BY "NombresC";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("area", area))
```

<a id="sql-0069"></a>

### SQL-0069 · RRHHClass.spRRHH_EstadisticaPermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1024](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1024)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT pe."IdEmpleado",pe."idMotivo",COUNT(*)::integer AS "Cantidad",m."Descrip_Motivo"
FROM public."Permiso" pe JOIN public."Motivo_Perm" m ON m."idMotivo"=pe."idMotivo"
WHERE pe."FechaInicio"::date <= @fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date >= @inicio
 AND (cardinality(@motivos::integer[])=0 OR pe."idMotivo"=ANY(@motivos::integer[]))
GROUP BY pe."IdEmpleado",pe."idMotivo",m."Descrip_Motivo";
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("motivos", motivos))
```

<a id="sql-0070"></a>

### SQL-0070 · RRHHClass.spRRHH_ResumenEstadisticaPermiso · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1065](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1065)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT m."idMotivo",m."Descrip_Motivo",COUNT(pe."NPermiso")::integer AS "Cantidad",
 ROUND(CASE WHEN totals.total=0 THEN 0 ELSE COUNT(pe."NPermiso")*100.0/totals.total END,2) AS "Porcentaje"
FROM public."Motivo_Perm" m
LEFT JOIN public."Permiso" pe ON pe."idMotivo"=m."idMotivo"
 AND pe."FechaInicio"::date<=@fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date>=@inicio
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=pe."IdEmpleado" AND ea."Year"=@year
CROSS JOIN (SELECT COUNT(*)::numeric AS total FROM public."Permiso" p2
 JOIN public."Empleado_Area" ea2 ON ea2."IdEmpleado"=p2."IdEmpleado" AND ea2."Year"=@year
 WHERE p2."FechaInicio"::date<=@fin AND COALESCE(p2."FechaFin",p2."FechaInicio")::date>=@inicio
 AND (@area=0 OR ea2."idAreaOrganiz"=@area)) totals
WHERE m."idMotivo"=@motivo AND (@area=0 OR ea."idAreaOrganiz"=@area OR pe."IdEmpleado" IS NULL)
GROUP BY m."idMotivo",m."Descrip_Motivo",totals.total;
""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date),
			new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date),
			new PostgreSqlParameterValue("year", DateTime.Today.Year),
			new PostgreSqlParameterValue("motivo", idMotivo), new PostgreSqlParameterValue("area", idArea))
```

<a id="sql-0071"></a>

### SQL-0071 · RRHHClass.spRRHH_GetAsistenciaDia · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1088](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1088)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query(
			"SELECT * FROM public.\"Asistencia\" WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\"::date = @fecha;",
			new PostgreSqlParameterValue("empleadoId", codigo),
			new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date))
```

<a id="sql-0072"></a>

### SQL-0072 · RRHHClass.ListarTrabajadoresReporte · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1097](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1097)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"""
SELECT e."IdEmpleado",
       btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno")) || ', ' || btrim(p."Nombres") AS "NombresCompletos"
FROM public."Persona" AS p
INNER JOIN public."Empleado" AS e ON e."IdPersona" = p."IdPersona"
INNER JOIN public."Empleado_Area" AS ea
    ON ea."IdEmpleado" = e."IdEmpleado" AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer
WHERE e."IdEmpleado" {0} (SELECT "idEmpleado" FROM public."AuxRRHH_ReporteAsistencia")
  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'
  AND e."IdTipoTrabajador" = @tipoTrabajador
ORDER BY p."Apellido_Paterno";
"""
```

<a id="sql-0073"></a>

### SQL-0073 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1119](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1119)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado" AS "idempleado",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",
 p."NumDocID" AS "NumDocId",p."Direccion" AS "direccion",p."Telefono",p."Fax",p."Email",
 p."FechaNacimiento",p."FechaRegistro",p."NumCelular",p."FonoCentroLab",
 e."Sexo" AS "sexo",e."ExpSocial",e."Brevete" AS "brevete",e."JefeHogar",e."CargaFam",
 e."NumHijos" AS "Numhijos",e."ObsFam",e."NumLibretaMilitar",e."GradoInstruccion" AS "gradoInstruccion",
 e."NumRUC",e."Foto" AS "foto",td."Descripcion" AS "TipoDoc",ec."DescripEstCivil" AS "EstadoCivil",
 ts."DescripTS" AS "DescripTS",n."Descripcion" AS "Nacionalidad",
 vc."DescripViveCon" AS "Descripvivecon",d."Descrip_Discapacidad" AS "Discapacidad",
 EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",
 s."EnferCronica" AS "enfercronica",s."EnferCronicaDescrip" AS "enfercronicadescrip",
 s."FamDiscapacidad" AS "famdiscapacidad",s."FamDiscapDescrip" AS "famdiscapdescrip",
 s."Alergico" AS "alergico",s."AlergicoDescrip" AS "alergicodescrip"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."TipoDocID" td ON td."TipoDocID"=p."TipoDocID"
LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=e."IdEstadoCivil"
LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=e."IdTipoSangre"
LEFT JOIN public."Nacionalidad" n ON n."IdNacionalidad"=e."IdNacionalidad"
LEFT JOIN public."ViveCon" vc ON vc."IdViveCon"=e."IdViveCon"
LEFT JOIN public."Discapacidad" d ON d."IdDiscapacidad"=e."IdDiscapacidad"
LEFT JOIN public."RRHH_Salud" s ON s."IdEmpleado"=e."IdEmpleado"
WHERE e."IdEmpleado"=@empleado;
""", employee)
```

<a id="sql-0074"></a>

### SQL-0074 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1143](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1143)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."FechaIngreso" AS "Fechaingreso",e."FechaAFP",e."NroAFP",e."Profesion" AS "profesion",
 e."NumResolCese",e."FechaResolCese",e."NumResol20530",e."FechaResol20530",
 a."DescripAFP",c."Cargo" AS "cargo",eo."AreaOrganizacional",tt."Descripcion" AS "CondicionLab"
FROM public."Empleado" e LEFT JOIN public."AFP" a ON a."IdAFP"=e."IdAFP"
LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"
LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"
LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE e."IdEmpleado"=@empleado;
""", employee, new PostgreSqlParameterValue("year", DateTime.Today.Year))
```

<a id="sql-0075"></a>

### SQL-0075 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1155](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1155)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT ex."NomInstitucion",ex."Cargo" AS "CargoExp",ex."FechaIngreso" AS "FechaIngresoExp",
 ex."FechaEgreso" AS "FEchaEgresoExp",ex."UnidadOrganica" AS "UnidadOrgaExp",
 ti."DescripTipoInstitucion" AS "DescriptipoInstitucion"
FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"
WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;
""", employee)
```

<a id="sql-0076"></a>

### SQL-0076 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1171](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1171)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query("""
SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"
FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"
WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;
""", employee), "spRRHH_busca_Disciplina")
```

<a id="sql-0077"></a>

### SQL-0077 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1177](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1177)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query("""
SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresFamilia",
 f."FamSexo",f."FamGradoInstruc",f."ViveCasa",f."LaboraInstitucion",tf."DescripTipoFam",ec."DescripEstCivil",
 EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadFamiliar"
FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"
LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"
LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=f."IdEstadoCivil"
WHERE f."IdEmpleado"=@empleado ORDER BY tf."DescripTipoFam",p."Apellido_Paterno";
""", employee), "spRRHH_Ficha_Det_Familiar")
```

<a id="sql-0078"></a>

### SQL-0078 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1186](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1186)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query("""
SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio",er."AñoTermino",ee."DescripEstadoEstudio"
FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"
LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"
WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio";
""", employee), "spRRHH_Ficha_Estudio_Realizado")
```

<a id="sql-0079"></a>

### SQL-0079 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1192](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1192)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query(
			"SELECT * FROM public.\"TitulosEmpleado\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"Fecha\";", employee),
			"spRRHH_Ficha_Estudio_Titulo")
```

<a id="sql-0080"></a>

### SQL-0080 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1195](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1195)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query(
			"SELECT * FROM public.\"Capacitacion\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"FechaInicio\";", employee),
			"spRRHH_Ficha_Estudio_Capacitacion")
```

<a id="sql-0081"></a>

### SQL-0081 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1199](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1199)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query("""
SELECT v."NumDormitorio",v."NumServHig",v."NumCompart",v."NumPerDorm",v."Observacion" AS "observacion",
 v."Telefono" AS "telefono",v."Cable" AS "cable",v."Internet" AS "internet",v."Otros" AS "otros",
 te."DescripTenencia",tv."DescripTipo" AS "DescripTipo",mv."DescripMaterial",cv."DescripConserva",
 uv."DescripUbicacion",av."DescripAlumbrado",wv."DescripAgua" AS "descripAgua",ev."DescripExcretas"
FROM public."Vivienda" v LEFT JOIN public."TenenciaViv" te ON te."IdTenencia"=v."IdTenencia"
LEFT JOIN public."TipoViv" tv ON tv."IdTipo"=v."IdTipo"
LEFT JOIN public."MaterialViv" mv ON mv."IdMaterial"=v."IdMaterial"
LEFT JOIN public."ConservacionViv" cv ON cv."IdConservacion"=v."IdConservacion"
LEFT JOIN public."UbicacionViv" uv ON uv."IdUbicacion"=v."IdUbicacion"
LEFT JOIN public."AlumbradoViv" av ON av."IdAlumbrado"=v."IdAlumbrado"
LEFT JOIN public."AguaViv" wv ON wv."IdAgua"=v."IdAgua"
LEFT JOIN public."ExcretasViv" ev ON ev."IdExcretas"=v."IdExcretas"
WHERE v."IdEmpleado"=@empleado;
""", employee), "spRRHH_Ficha_Vivienda")
```

<a id="sql-0082"></a>

### SQL-0082 · RRHHClass.GenerarFichaPostgreSql · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1215](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1215)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
AddReportTable(result, _database.Query("""
SELECT tf."DescripTipoFam",ts."DescripTS" AS "descripts",f."Enfermedad" AS "enfermedad",
 f."TiempoEnfermedad" AS "tiempoenfermedad",f."NumAutogenSalud" AS "numautogensalud",p."NumDocID" AS "numdocid"
FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"
LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"
LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=f."IdTipoSangre"
WHERE f."IdEmpleado"=@empleado;
""", employee), "spRRHH_Ficha_Det_Familiar_Salud")
```

<a id="sql-0083"></a>

### SQL-0083 · RRHHClass.ObtenerIngresosEgresos · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1228](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1228)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Convert.ToBoolean(_database.Scalar(
			"SELECT to_regclass('public.\"Ingreso\"') IS NOT NULL AND to_regclass('public.\"Egreso\"') IS NOT NULL;"))
```

<a id="sql-0084"></a>

### SQL-0084 · RRHHClass.ObtenerIngresosEgresos · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1234](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1234)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT i."Remuneracion",i."Honorarios" AS "honorarios",i."AlqPredio",i."AlqBienes",i."CapitalesColocados",
 i."Dietas",i."Negocios",i."Otros" AS "OtrosIngresos",i."IngresoMiembros",i."NumPersonaAportan",
 e."Alimentacion",e."Vivienda" AS "vivienda",e."Educacion" AS "educacion",e."Salud" AS "salud",
 e."Vestido" AS "vestido",e."Recreacion" AS "recreacion",e."Prestamos" AS "prestamos",
 e."Otros" AS "OtrosEgresos",e."Transporte" AS "transporte",e."EnergiaElec" AS "energiaelec",
 e."Agua" AS "agua",e."BajaPolicia" AS "bajapolicia",e."Telefono" AS "telefono",
 e."SeguroPriv" AS "seguropriv",e."TarjCredito" AS "tarjcredito"
FROM public."Ingreso" i FULL JOIN public."Egreso" e ON e."IdEmpleado"=i."IdEmpleado"
WHERE COALESCE(i."IdEmpleado",e."IdEmpleado")=@empleado;
""", new PostgreSqlParameterValue("empleado", empleadoId))
```

<a id="sql-0085"></a>

### SQL-0085 · RRHHClass.ReporteOficina · Plantilla/literal SQL

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1255](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1255)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"""
SELECT e."IdEmpleado" AS "idempleado",p."IdPersona" AS "idpersona",
       p."Apellido_Paterno" AS "Apellido_paterno",p."Apellido_Materno" AS "apellido_materno",
       p."Nombres" AS "nombres",eo."AreaOrganizacional"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year
JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"
WHERE {0} AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY p."Apellido_Paterno",p."Apellido_Materno",p."Nombres";
"""
```

<a id="sql-0086"></a>

### SQL-0086 · RRHHClass.ParseCsvIntegers · Llamada/expresión C#

[Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1286](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1286)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
value.Split(',')
			.Select(item => item.Trim())
			.Where(item => int.TryParse(item, out _))
			.Select(int.Parse)
			.Distinct()
			.ToArray()
```

## Software/ClsCtrls/ClsCtrls/Clases.cs

<a id="sql-0087"></a>

### SQL-0087 · clsDbArray.LeerDatos · Llamada/expresión C#

[Software/ClsCtrls/ClsCtrls/Clases.cs:1082](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1082)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
text = "SELECT * FROM " + _Tabla + text
```

## Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs

<a id="sql-0088"></a>

### SQL-0088 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs:155](../../Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs#L155)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
source.Select(new RemoveNamespaceAttributesClosure(ns).ProcessXElement)
```

<a id="sql-0089"></a>

### SQL-0089 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs:157](../../Software/ClsCtrls/ClsCtrls/My/InternalXmlHelper.cs#L157)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(ns).ProcessObject)
```

## Software/GRLL/GRLL/Common/ClsExcel.cs

<a id="sql-0090"></a>

### SQL-0090 · ClsExcel.ExportaExcel · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ClsExcel.cs:48](../../Software/GRLL/GRLL/Common/ClsExcel.cs#L48)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/GRLL/GRLL/Common/GenericMapper.cs

<a id="sql-0091"></a>

### SQL-0091 · GenericMapper.get · Llamada/expresión C#

[Software/GRLL/GRLL/Common/GenericMapper.cs:61](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L61)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
RuntimeHelpers.GetObjectValue((from a in EntityType.GetCustomAttributes(inherit: false)
				where a.GetType() == typeof(TableAttribute)
				select (a)).FirstOrDefault())
```

<a id="sql-0092"></a>

### SQL-0092 · GenericMapper.GetColumns · Llamada/expresión C#

[Software/GRLL/GRLL/Common/GenericMapper.cs:102](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L102)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
(from p in EntityType.GetProperties()
			where (from att in p.GetCustomAttributes(inherit: true)
				where att.GetType() == typeof(ColumnAttribute)
				select (att)).Count() > 0
			select (p)).ToArray()
```

<a id="sql-0093"></a>

### SQL-0093 · GenericMapper.GetEntity · Llamada/expresión C#

[Software/GRLL/GRLL/Common/GenericMapper.cs:229](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L229)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
string.Format("Select * From (0) where (1)=(2)", new object[3]
		{
			TableName,
			GetPrimaryKey().Name,
			id
		})
```

<a id="sql-0094"></a>

### SQL-0094 · GenericMapper.DameEntidad · Plantilla/literal SQL

[Software/GRLL/GRLL/Common/GenericMapper.cs:391](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L391)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
"SELECT "
```

## Software/GRLL/GRLL/Common/frmBaseMant.cs

<a id="sql-0095"></a>

### SQL-0095 · frmBaseMant.BTN_EXCEL_Click · Llamada/expresión C#

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2595](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2595)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/GRLL/GRLL/Common/ucTView1T.cs

<a id="sql-0096"></a>

### SQL-0096 · ucTView1T.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTView1T.cs:598](../../Software/GRLL/GRLL/Common/ucTView1T.cs#L598)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
sSql = "SELECT * FROM " + cTabla + " WHERE "
```

<a id="sql-0097"></a>

### SQL-0097 · ucTView1T.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTView1T.cs:672](../../Software/GRLL/GRLL/Common/ucTView1T.cs#L672)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
sSql = "SELECT * FROM " + cTabla + " WHERE "
```

## Software/GRLL/GRLL/Common/ucTViewNT.cs

<a id="sql-0098"></a>

### SQL-0098 · ucTViewNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewNT.cs:1296](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1296)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = '" + nIdValorWhere[0].ToString() + "'"
```

<a id="sql-0099"></a>

### SQL-0099 · ucTViewNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewNT.cs:1300](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1300)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = " + nIdValorWhere[0].ToString()
```

<a id="sql-0100"></a>

### SQL-0100 · ucTViewNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewNT.cs:1305](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1305)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0]
```

<a id="sql-0101"></a>

### SQL-0101 · ucTViewNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewNT.cs:1321](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1321)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = '"), oNodo.Tag), "'"))
```

<a id="sql-0102"></a>

### SQL-0102 · ucTViewNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewNT.cs:1325](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1325)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = "), oNodo.Tag))
```

## Software/GRLL/GRLL/Common/ucTViewV1T.cs

<a id="sql-0103"></a>

### SQL-0103 · ucTViewV1T.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewV1T.cs:612](../../Software/GRLL/GRLL/Common/ucTViewV1T.cs#L612)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
sSql = "SELECT * FROM " + cTabla + " WHERE "
```

<a id="sql-0104"></a>

### SQL-0104 · ucTViewV1T.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewV1T.cs:686](../../Software/GRLL/GRLL/Common/ucTViewV1T.cs#L686)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
sSql = "SELECT * FROM " + cTabla + " WHERE "
```

## Software/GRLL/GRLL/Common/ucTViewVNT.cs

<a id="sql-0105"></a>

### SQL-0105 · ucTViewVNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewVNT.cs:1305](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1305)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = '" + nIdValorWhere[0].ToString() + "'"
```

<a id="sql-0106"></a>

### SQL-0106 · ucTViewVNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewVNT.cs:1309](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1309)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = " + nIdValorWhere[0].ToString()
```

<a id="sql-0107"></a>

### SQL-0107 · ucTViewVNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewVNT.cs:1314](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1314)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = "SELECT * FROM " + cTabla[0]
```

<a id="sql-0108"></a>

### SQL-0108 · ucTViewVNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewVNT.cs:1330](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1330)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = '"), oNodo.Tag), "'"))
```

<a id="sql-0109"></a>

### SQL-0109 · ucTViewVNT.GetHijos · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucTViewVNT.cs:1334](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1334)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = "), oNodo.Tag))
```

## Software/GRLL/GRLL/Common/ucUbigeoCmb.cs

<a id="sql-0110"></a>

### SQL-0110 · ucUbigeoCmb.GetDpto · Plantilla/literal SQL

[Software/GRLL/GRLL/Common/ucUbigeoCmb.cs:538](../../Software/GRLL/GRLL/Common/ucUbigeoCmb.cs#L538)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
"select IdUbigeo, Departamento, Provincia, Distrito, Descripcion from Ubigeo"
```

## Software/GRLL/GRLL/Common/ucUbigeoCombito.cs

<a id="sql-0111"></a>

### SQL-0111 · ucUbigeoCombito.GetDpto · Plantilla/literal SQL

[Software/GRLL/GRLL/Common/ucUbigeoCombito.cs:602](../../Software/GRLL/GRLL/Common/ucUbigeoCombito.cs#L602)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
"select IdUbigeo, Departamento, Provincia, Distrito, Descripcion from Ubigeo"
```

## Software/GRLL/GRLL/Common/ucUbigeoLinq.cs

<a id="sql-0112"></a>

### SQL-0112 · ucUbigeoLinq.GetDpto · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucUbigeoLinq.cs:682](../../Software/GRLL/GRLL/Common/ucUbigeoLinq.cs#L682)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
		{
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
		}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable()
```

<a id="sql-0113"></a>

### SQL-0113 · ucUbigeoLinq.CMB_Dpto_SelectedIndexChanged · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucUbigeoLinq.cs:808](../../Software/GRLL/GRLL/Common/ucUbigeoLinq.cs#L808)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
			{
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
				Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
			}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable()
```

<a id="sql-0114"></a>

### SQL-0114 · ucUbigeoLinq.CMB_Prov_SelectedIndexChanged · Llamada/expresión C#

[Software/GRLL/GRLL/Common/ucUbigeoLinq.cs:852](../../Software/GRLL/GRLL/Common/ucUbigeoLinq.cs#L852)

Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
source2.Select(Expression.Lambda<Func<ClsTUbigeo, VB_0024AnonymousType_0<string, string, string, string, string>>>(Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), new Expression[5]
		{
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			Expression.Field(parameterExpression3, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))
		}, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(VB_0024AnonymousType_0<string, string, string, string, string>).TypeHandle)), new ParameterExpression[1] { parameterExpression3 })).ToDataTable()
```

## Software/RRHH.Application/Asistencia/ListarFeriados.cs

<a id="sql-0115"></a>

### SQL-0115 · ListarFeriados.Ejecutar · Llamada/expresión C#

[Software/RRHH.Application/Asistencia/ListarFeriados.cs:21](../../Software/RRHH.Application/Asistencia/ListarFeriados.cs#L21)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_repository.Listar()
			.Select(feriado => new FeriadoDto
			{
				Id = feriado.Id,
				Fecha = feriado.Fecha,
				Motivo = feriado.Motivo
			})
			.ToList()
```

## Software/RRHH.Application/Catalogos/ListarCatalogo.cs

<a id="sql-0116"></a>

### SQL-0116 · ListarCatalogo.Ejecutar · Llamada/expresión C#

[Software/RRHH.Application/Catalogos/ListarCatalogo.cs:18](../../Software/RRHH.Application/Catalogos/ListarCatalogo.cs#L18)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_repository.Listar(filtro?.Trim() ?? string.Empty)
			.Select(item => new ItemCatalogoDto
			{
				Id = item.Id,
				Descripcion = item.Descripcion,
				Extra = item.Extra
			})
			.ToList()
```

## Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs

<a id="sql-0117"></a>

### SQL-0117 · PostgreSqlFeriadoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:36](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L36)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			$"SELECT {IdSql} AS id, {FechaSql} AS fecha, COALESCE({MotivoSql}, '') AS motivo " +
			$"FROM {TablaCalificada} " +
			$"ORDER BY {IdSql};")
```

<a id="sql-0118"></a>

### SQL-0118 · PostgreSqlFeriadoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:41](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L41)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
table.Rows.Cast<DataRow>()
			.Select(row => Feriado.Reconstituir(
				Convert.ToInt32(row["id"]),
				Convert.ToDateTime(row["fecha"]),
				Convert.ToString(row["motivo"])))
			.ToList()
```

<a id="sql-0119"></a>

### SQL-0119 · PostgreSqlFeriadoRepository.ExisteFecha · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:51](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L51)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.ScalarInt(
			$"SELECT 1 FROM {TablaCalificada} WHERE {FechaSql}::date = @fecha LIMIT 1;",
			new PostgreSqlParameterValue("fecha", fecha.Date, DbType.Date))
```

<a id="sql-0120"></a>

### SQL-0120 · PostgreSqlFeriadoRepository.InsertarSiNoExisteFecha · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:73](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L73)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.InTransaction(tx =>
			{
				tx.Execute($"LOCK TABLE {TablaCalificada} IN SHARE ROW EXCLUSIVE MODE;");

				int existe = tx.ScalarInt(
					$"SELECT 1 FROM {TablaCalificada} WHERE {FechaSql}::date = @fecha LIMIT 1;",
					parametroFecha);
				if (existe == 1)
				{
					return 0;
				}

				return tx.ScalarInt(
					$"INSERT INTO {TablaCalificada} ({IdSql}, {FechaSql}, {MotivoSql}) " +
					$"SELECT COALESCE(MAX({IdSql}), 0) + 1, @fecha, @motivo FROM {TablaCalificada} " +
					$"RETURNING {IdSql};",
					parametroFecha,
					parametroMotivo);
			})
```

<a id="sql-0121"></a>

### SQL-0121 · PostgreSqlFeriadoRepository.Eliminar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:105](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L105)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			$"DELETE FROM {TablaCalificada} WHERE {IdSql} = @id;",
			new PostgreSqlParameterValue("id", id, DbType.Int32))
```

## Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs

<a id="sql-0122"></a>

### SQL-0122 · PostgreSqlHorarioRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:23](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L23)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
        "SELECT " + Columnas + " FROM public.\"Horario\" ORDER BY \"idHorario\";")
        .Rows.Cast<DataRow>().Select(Mapear).ToList()
```

<a id="sql-0123"></a>

### SQL-0123 · PostgreSqlHorarioRepository.Obtener · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:30](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L30)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query("SELECT " + Columnas + " FROM public.\"Horario\" WHERE \"idHorario\" = @id;", Id(id))
```

<a id="sql-0124"></a>

### SQL-0124 · PostgreSqlHorarioRepository.Insertar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:42](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L42)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;");
                bool tieneDefault = tx.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns
WHERE table_schema='public' AND table_name='Horario' AND column_name='idHorario'
  AND (is_identity='YES' OR column_default IS NOT NULL);
""") > 0;
                string sql = tieneDefault ? """
INSERT INTO public."Horario" ("Descrip_Horario", "Ingreso1", "Salida1", "Ingreso2", "Salida2", "Estado")
VALUES (@descripcion, @ingreso1, @salida1, @ingreso2, @salida2, @estado)
RETURNING "idHorario";
""" : """
INSERT INTO public."Horario" ("idHorario", "Descrip_Horario", "Ingreso1", "Salida1", "Ingreso2", "Salida2", "Estado")
SELECT COALESCE(MAX("idHorario"), 0)+1, @descripcion, @ingreso1, @salida1, @ingreso2, @salida2, @estado
FROM public."Horario"
RETURNING "idHorario";
""";
                int id = tx.ScalarInt(sql, Parametros(horario));
                if (id <= 0) throw new ReglaNegocioException("La BD no generó un código positivo de horario. Solicite revisar los IDs.");
                if (Contar(tx, id) != 1) throw CodigoDuplicado();
                return id;
            })
```

<a id="sql-0125"></a>

### SQL-0125 · PostgreSqlHorarioRepository.Actualizar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:76](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L76)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;");
            if (Contar(tx, horario.Id) > 1) throw CodigoDuplicado();
            return tx.Execute("""
UPDATE public."Horario"
SET "Descrip_Horario"=@descripcion, "Ingreso1"=@ingreso1, "Salida1"=@salida1,
    "Ingreso2"=@ingreso2, "Salida2"=@salida2, "Estado"=@estado
WHERE "idHorario"=@id;
""", Parametros(horario).Concat(new[] { Id(horario.Id) }).ToArray()) == 1;
        })
```

<a id="sql-0126"></a>

### SQL-0126 · PostgreSqlHorarioRepository.Eliminar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:95](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L95)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Horario\", public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\" IN SHARE ROW EXCLUSIVE MODE;");
                int cantidad = Contar(tx, id);
                if (cantidad > 1) throw CodigoDuplicado();
                if (cantidad == 0) return false;
                if (tx.ScalarInt("""
SELECT CASE WHEN EXISTS (SELECT 1 FROM public."Empleado" WHERE "idHorario"=@id)
 OR EXISTS (SELECT 1 FROM public."HorarioTemporal" WHERE "HorarioAsignado"=@id)
 OR EXISTS (SELECT 1 FROM public."Asistencia" WHERE "idHorario"=@id)
 OR EXISTS (SELECT 1 FROM public."Marcacion" WHERE "idHorario"=@id)
THEN 1 ELSE 0 END;
""", Id(id)) == 1)
                    throw new RegistroEnUsoException("No se puede eliminar: el horario está referenciado por personal, horarios temporales, asistencia o marcaciones.", null);
                return tx.Execute("DELETE FROM public.\"Horario\" WHERE \"idHorario\"=@id;", Id(id)) == 1;
            })
```

<a id="sql-0127"></a>

### SQL-0127 · PostgreSqlHorarioRepository.Contar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:119](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L119)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
tx.ScalarInt("SELECT COUNT(*) FROM public.\"Horario\" WHERE \"idHorario\"=@id;", Id(id))
```

## Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs

<a id="sql-0128"></a>

### SQL-0128 · PostgreSqlCatalogoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:44](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L44)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			$"SELECT {_id} AS id, COALESCE({_descripcion}, '') AS descripcion, {columnaExtra} AS extra " +
			$"FROM {_tabla} " +
			$"WHERE COALESCE({_descripcion}, '') ILIKE @patron ESCAPE '\\' " +
			$"ORDER BY {_id};",
			new PostgreSqlParameterValue("patron", "%" + EscaparLike(filtro) + "%"))
```

<a id="sql-0129"></a>

### SQL-0129 · PostgreSqlCatalogoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:51](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L51)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
table.Rows.Cast<DataRow>()
			.Select(row => ItemCatalogo.Reconstituir(
				Convert.ToInt32(row["id"]),
				(string)row["descripcion"],
				row["extra"] as string))
			.ToList()
```

<a id="sql-0130"></a>

### SQL-0130 · PostgreSqlCatalogoRepository.Insertar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:73](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L73)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.InTransaction(tx =>
		{
			tx.Execute($"LOCK TABLE {_tabla} IN SHARE ROW EXCLUSIVE MODE;");
			return tx.ScalarInt(
				$"INSERT INTO {_tabla} ({columnas}) " +
				$"SELECT COALESCE(MAX({_id}), 0) + 1, {valores} FROM {_tabla} " +
				$"RETURNING {_id};",
				Parametros(item));
		})
```

<a id="sql-0131"></a>

### SQL-0131 · PostgreSqlCatalogoRepository.Actualizar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:97](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L97)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute($"UPDATE {_tabla} SET {asignaciones} WHERE {_id} = @id;", parametros.ToArray())
```

<a id="sql-0132"></a>

### SQL-0132 · PostgreSqlCatalogoRepository.Eliminar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:110](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L110)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.InTransaction(tx =>
			{
				ReferenciaCatalogo enUso = _mapeo.Referencias.FirstOrDefault(r => tx.ScalarInt(
					$"SELECT 1 FROM {IdentificadorSql.Tabla(r.Tabla)} " +
					$"WHERE {IdentificadorSql.Comillas(r.Columna)} = @id LIMIT 1;",
					parametroId) == 1);
				if (enUso != null)
				{
					throw new RegistroEnUsoException(
						$"El registro {id} de {_mapeo.Tabla} está referenciado en {enUso}.", null);
				}

				return tx.Execute($"DELETE FROM {_tabla} WHERE {_id} = @id;", parametroId);
			})
```

## Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs

<a id="sql-0133"></a>

### SQL-0133 · PostgreSqlMotivoPermisoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:25](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L25)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",
       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"
FROM public."Motivo_Perm" AS m
LEFT JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"
WHERE m."idTipoPermiso" = @tipo
  AND (@modalidad IS NULL OR m."TipoModalidad" = @modalidad)
ORDER BY m."Descrip_Motivo", m."idMotivo";
""", Param("tipo", tipoPermisoId, DbType.Int32), Param("modalidad", modalidad, DbType.String))
```

<a id="sql-0134"></a>

### SQL-0134 · PostgreSqlMotivoPermisoRepository.Listar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:34](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L34)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
table.Rows.Cast<DataRow>().Select(row =>
        {
            MotivoPermisoDto dto = MotivoPermisoDto.Desde(Mapear(row));
            dto.DescripcionTipo = row["DescripTipoPermiso"] as string;
            return dto;
        }).ToList()
```

<a id="sql-0135"></a>

### SQL-0135 · PostgreSqlMotivoPermisoRepository.Obtener · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:44](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L44)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT "idMotivo", "Descrip_Motivo", "Salario", "idTipoPermiso", "Abrev", "TipoModalidad", "Activo"
FROM public."Motivo_Perm" WHERE "idMotivo" = @id;
""", Param("id", id, DbType.Int32))
```

<a id="sql-0136"></a>

### SQL-0136 · PostgreSqlMotivoPermisoRepository.Insertar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:60](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L60)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Motivo_Perm\", public.\"TipoPermiso\" IN SHARE ROW EXCLUSIVE MODE;");
            int tipos = tx.ScalarInt("SELECT COUNT(*) FROM public.\"TipoPermiso\" WHERE \"idTipoPermiso\" = @tipo;",
                Param("tipo", motivo.TipoPermisoId, DbType.Int32));
            if (tipos != 1) throw new ReglaNegocioException("El tipo de permiso no existe o tiene códigos duplicados.");
            int usaDefault = tx.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns
WHERE table_schema = 'public' AND table_name = 'Motivo_Perm' AND column_name = 'idMotivo'
  AND (is_identity = 'YES' OR column_default IS NOT NULL);
""");
            string sql = usaDefault > 0 ? """
INSERT INTO public."Motivo_Perm" ("Descrip_Motivo", "Abrev", "Salario", "idTipoPermiso", "TipoModalidad", "Activo")
VALUES (@descripcion, @abreviatura, @salario, @tipo, @modalidad, @activo)
RETURNING "idMotivo";
""" : """
INSERT INTO public."Motivo_Perm" ("idMotivo", "Descrip_Motivo", "Abrev", "Salario", "idTipoPermiso", "TipoModalidad", "Activo")
SELECT COALESCE(MAX("idMotivo"), 0) + 1, @descripcion, @abreviatura, @salario, @tipo, @modalidad, @activo
FROM public."Motivo_Perm"
RETURNING "idMotivo";
""";
            int id = tx.ScalarInt(sql, Parametros(motivo));
            // Una secuencia desalineada en un esquema sin PK también puede
            // repetir un ID. Revertir la fila en lugar de guardar ambigüedad.
            if (Contar(tx, id) != 1) throw CodigoDuplicado();
            return id;
        })
```

<a id="sql-0137"></a>

### SQL-0137 · PostgreSqlMotivoPermisoRepository.Actualizar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:93](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L93)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Motivo_Perm\" IN SHARE ROW EXCLUSIVE MODE;");
            if (Contar(tx, motivo.Id) > 1) throw CodigoDuplicado();
            return tx.Execute("""
UPDATE public."Motivo_Perm"
SET "Descrip_Motivo" = @descripcion, "Abrev" = @abreviatura, "Salario" = @salario
WHERE "idMotivo" = @id AND "idTipoPermiso" IS NOT DISTINCT FROM @tipo
  AND "TipoModalidad" IS NOT DISTINCT FROM @modalidad;
""", Parametros(motivo).Concat(new[] { Param("id", motivo.Id, DbType.Int32) }).ToArray()) == 1;
        })
```

<a id="sql-0138"></a>

### SQL-0138 · PostgreSqlMotivoPermisoRepository.Eliminar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:116](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L116)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.InTransaction(tx =>
            {
                tx.Execute("LOCK TABLE public.\"Motivo_Perm\", public.\"Permiso\", public.\"Permiso_Aud\" IN SHARE ROW EXCLUSIVE MODE;");
                if (Contar(tx, id) > 1) throw CodigoDuplicado();
                var idParam = Param("id", id, DbType.Int32);
                var modalidadParam = Param("modalidad", modalidad, DbType.String);
                if (tx.ScalarInt("""
SELECT COUNT(*) FROM public."Motivo_Perm"
WHERE "idMotivo" = @id AND (@modalidad IS NULL OR "TipoModalidad" = @modalidad);
""", idParam, modalidadParam) == 0) return false;
                if (tx.ScalarInt("""
SELECT CASE WHEN EXISTS (SELECT 1 FROM public."Permiso" WHERE "idMotivo" = @id)
 OR EXISTS (SELECT 1 FROM public."Permiso_Aud" WHERE "idMotivo_Ant" = @id OR "idMotivo_Act" = @id)
THEN 1 ELSE 0 END;
""", idParam) == 1)
                    throw new RegistroEnUsoException("El motivo está referenciado en permisos o auditoría.", null);
                return tx.Execute("""
DELETE FROM public."Motivo_Perm"
WHERE "idMotivo" = @id AND (@modalidad IS NULL OR "TipoModalidad" = @modalidad);
""", idParam, modalidadParam) == 1;
            })
```

<a id="sql-0139"></a>

### SQL-0139 · PostgreSqlMotivoPermisoRepository.Contar · Llamada/expresión C#

[Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:144](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L144)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
tx.ScalarInt(
        "SELECT COUNT(*) FROM public.\"Motivo_Perm\" WHERE \"idMotivo\" = @id;", Param("id", id, DbType.Int32))
```

## Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs

<a id="sql-0140"></a>

### SQL-0140 · PostgreSqlConnectionFactory.VerifySchema · Llamada/expresión C#

[Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:41](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L41)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
new NpgsqlCommand(
			"SELECT to_regclass('public.\"Usuario\"') IS NOT NULL " +
			"AND to_regclass('public.\"Empleado\"') IS NOT NULL " +
			"AND to_regclass('public.\"Persona\"') IS NOT NULL " +
			"AND EXISTS (SELECT 1 FROM information_schema.columns " +
			"WHERE table_schema = 'public' AND table_name = 'Usuario' " +
			"AND column_name = 'PasswordHash');",
			connection)
```

## Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs

<a id="sql-0141"></a>

### SQL-0141 · PostgreSqlAccesoUsuarioRepository. · Plantilla/literal SQL

[Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:13](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L13)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
@"
SELECT DISTINCT
    u.""IdUsuario"" AS id_usuario,
    btrim(u.""Login"") AS login,
    u.""IdEmpleado"" AS id_empleado,
    e.""idAreaOrganiz"" AS id_area,
    ur.""IdRol"" AS id_rol,
    btrim(concat_ws(' ', p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"")) AS nombre_empleado,
    u.""PasswordHash"" AS password_hash,
    u.""PasswordSalt"" AS password_salt,
    u.""PasswordIterations"" AS password_iterations
FROM public.""Usuario"" AS u
INNER JOIN public.""Usuario_Rol"" AS ur ON ur.""IdUsuario"" = u.""IdUsuario""
INNER JOIN public.""Rol"" AS r ON r.""IdRol"" = ur.""IdRol""
LEFT JOIN public.""Empleado"" AS e ON e.""IdEmpleado"" = u.""IdEmpleado""
LEFT JOIN public.""Persona"" AS p ON p.""IdPersona"" = e.""IdPersona""
WHERE lower(btrim(u.""Login"")) = lower(btrim(@login))
  AND COALESCE(u.""Estado"", FALSE)
  AND r.""IdSistema"" = @codigoSistema
ORDER BY ur.""IdRol""
LIMIT 1;"
```

<a id="sql-0142"></a>

### SQL-0142 · PostgreSqlAccesoUsuarioRepository. · Plantilla/literal SQL

[Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:35](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L35)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
@"
WITH matching_users AS (
    SELECT ""IdUsuario""
    FROM public.""Usuario""
    WHERE lower(btrim(""Login"")) = lower(btrim(@login))
), unique_user AS (
    SELECT min(""IdUsuario"") AS id_usuario
    FROM matching_users
    HAVING count(DISTINCT ""IdUsuario"") = 1
)
UPDATE public.""Usuario"" AS u
SET ""PasswordHash"" = @passwordHash,
    ""PasswordSalt"" = @passwordSalt,
    ""PasswordIterations"" = @passwordIterations,
    ""PasswordChangedAt"" = CURRENT_TIMESTAMP
FROM unique_user
WHERE u.""IdUsuario"" = unique_user.id_usuario;"
```

## Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs

<a id="sql-0143"></a>

### SQL-0143 · DependenciasEntreCapasTests.AssertNoReferencia · Llamada/expresión C#

[Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs:63](../../Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs#L63)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
ensamblado.GetReferencedAssemblies()
			.Select(referencia => referencia.Name)
			.Where(nombre => prefijos.Any(prefijo => EmpiezaCon(nombre, prefijo)))
			.OrderBy(nombre => nombre, StringComparer.Ordinal)
			.ToArray()
```

## Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs

<a id="sql-0144"></a>

### SQL-0144 · HorarioPostgreSqlTests.HorarioPostgreSqlTests · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:33](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L33)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("""
DROP TABLE IF EXISTS public."ExtraHorario", public."Empleado", public."HorarioTemporal", public."Asistencia", public."Marcacion", public."Horario" CASCADE;
DROP SEQUENCE IF EXISTS public.tec001_sequence;
CREATE TABLE public."Horario" (
 "idHorario" integer NOT NULL, "Ingreso1" varchar(8), "Salida1" varchar(8),
 "Ingreso2" varchar(8), "Salida2" varchar(8), "Descrip_Horario" varchar(20), "Estado" boolean, "SgtDia" boolean);
CREATE TABLE public."Empleado" ("idHorario" integer);
CREATE TABLE public."HorarioTemporal" ("HorarioAsignado" integer);
CREATE TABLE public."Asistencia" ("idHorario" integer);
CREATE TABLE public."Marcacion" ("idHorario" integer);
""")
```

<a id="sql-0145"></a>

### SQL-0145 · HorarioPostgreSqlTests.TablaVaciaGeneraIdYHorasCanonicasConEstadoNulo · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:53](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L53)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Assert.Null(_db.Scalar("SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;"))
```

<a id="sql-0146"></a>

### SQL-0146 · HorarioPostgreSqlTests.IdentidadAlwaysNoRecibeIdExplicito · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:60](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L60)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);")
```

<a id="sql-0147"></a>

### SQL-0147 · HorarioPostgreSqlTests.SecuenciaDefaultSeRespeta · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:67](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L67)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("CREATE SEQUENCE public.tec001_sequence START 200; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');")
```

<a id="sql-0148"></a>

### SQL-0148 · HorarioPostgreSqlTests.DefaultCeroRevierteElAltaParaNoConfundirlaConRegistroNuevo · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:74](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L74)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT 0;")
```

<a id="sql-0149"></a>

### SQL-0149 · HorarioPostgreSqlTests.SecuenciaDesalineadaSinPKRevierteInsercion · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:83](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L83)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');")
```

<a id="sql-0150"></a>

### SQL-0150 · HorarioPostgreSqlTests.SecuenciaDesalineadaConPKInformaConflicto · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:92](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L92)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');")
```

<a id="sql-0151"></a>

### SQL-0151 · HorarioPostgreSqlTests.ActualizarConservaSgtDiaYEstadoNullable · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:101](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L101)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("UPDATE public.\"Horario\" SET \"SgtDia\"=true WHERE \"idHorario\"=1;")
```

<a id="sql-0152"></a>

### SQL-0152 · HorarioPostgreSqlTests.ActualizarConservaSgtDiaYEstadoNullable · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:103](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L103)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Assert.True((bool)_db.Scalar("SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;"))
```

<a id="sql-0153"></a>

### SQL-0153 · HorarioPostgreSqlTests.DatosHistoricosInvalidosSePuedenLeerParaCorregir · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:111](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L111)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("INSERT INTO public.\"Horario\" (\"idHorario\", \"Ingreso1\") VALUES (1, '29:00');")
```

<a id="sql-0154"></a>

### SQL-0154 · HorarioPostgreSqlTests.CadaReferenciaImpideElBorrado · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:124](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L124)

Prueba automatizada; no flujo productivo. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_db.Execute("INSERT INTO public." + referencia + " VALUES (1);")
```

<a id="sql-0155"></a>

### SQL-0155 · HorarioPostgreSqlTests.FKAdicionalSeTraduceARegistroEnUso · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:137](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L137)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE TABLE public.\"ExtraHorario\" (id integer REFERENCES public.\"Horario\" (\"idHorario\")); INSERT INTO public.\"ExtraHorario\" VALUES (1);")
```

<a id="sql-0156"></a>

### SQL-0156 · HorarioPostgreSqlTests.AltasConcurrentesNoDuplicanIdsSinSecuencia · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:145](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L145)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Task.WhenAll(Enumerable.Range(0, 8).Select(_ => Task.Run(() => _repo.Insertar(Nuevo()))))
```

<a id="sql-0157"></a>

### SQL-0157 · HorarioPostgreSqlTests.CodigosDuplicadosNoSeActualizanNiEliminan · Llamada/expresión C#

[Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:153](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L153)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("INSERT INTO public.\"Horario\" (\"idHorario\") VALUES (1),(1);")
```

## Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs

<a id="sql-0158"></a>

### SQL-0158 · RegistrarFeriadoTests.LeerColumnasTabla · Plantilla/literal SQL

[Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs:148](../../Software/RRHH.Tests/Asistencia/RegistrarFeriadoTests.cs#L148)

Prueba automatizada; no flujo productivo. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
$"CREATE TABLE public.\"{nombreTabla}\" ("
```

## Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs

<a id="sql-0159"></a>

### SQL-0159 · MapeosCatalogoTests. · Llamada/expresión C#

[Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs:23](../../Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs#L23)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Enum.GetValues(typeof(TipoCatalogo)).Cast<TipoCatalogo>().Select(t => new object[] { t })
```

<a id="sql-0160"></a>

### SQL-0160 · MapeosCatalogoTests.NoFaltaNingunaReferencia · Llamada/expresión C#

[Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs:74](../../Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs#L74)

Prueba automatizada; no flujo productivo. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
Esquema.Value
			.Where(tabla => tabla.Key != mapeo.Tabla)
			.SelectMany(tabla => tabla.Value
				.Where(columna => string.Equals(columna.Key, mapeo.ColumnaId, StringComparison.OrdinalIgnoreCase)
					&& columna.Value.StartsWith("integer"))
				.Select(columna => tabla.Key + "." + columna.Key))
			.OrderBy(nombre => nombre, StringComparer.Ordinal)
```

<a id="sql-0161"></a>

### SQL-0161 · MapeosCatalogoTests.NoFaltaNingunaReferencia · Llamada/expresión C#

[Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs:82](../../Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs#L82)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Assert.Equal(esperadas, mapeo.Referencias.Select(r => r.ToString()).OrderBy(nombre => nombre, StringComparer.Ordinal))
```

<a id="sql-0162"></a>

### SQL-0162 · MapeosCatalogoTests.LeerEsquema · Llamada/expresión C#

[Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs:101](../../Software/RRHH.Tests/Catalogos/MapeosCatalogoTests.cs#L101)

Prueba automatizada; no flujo productivo. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
Regex.Match(linea, @"^CREATE TABLE public\.""([^""]+)"" \($")
```

## Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs

<a id="sql-0163"></a>

### SQL-0163 · FakeMotivoPermisoRepository.Listar · Llamada/expresión C#

[Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs:25](../../Software/RRHH.Tests/Fakes/FakeMotivoPermisoRepository.cs#L25)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Registros.Where(m => m.TipoPermisoId == tipo && (modalidad == null || m.Modalidad == modalidad))
            .Select(MotivoPermisoDto.Desde).ToList()
```

## Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs

<a id="sql-0164"></a>

### SQL-0164 · MotivoPermisoPostgreSqlTests.MotivoPermisoPostgreSqlTests · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:35](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L35)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("""
DROP TABLE IF EXISTS public."Permiso_Aud", public."Permiso", public."Motivo_Perm", public."TipoPermiso" CASCADE;
DROP SEQUENCE IF EXISTS public.tec004_sequence;
CREATE TABLE public."TipoPermiso" ("idTipoPermiso" integer NOT NULL, "DescripTipoPermiso" varchar(50));
CREATE TABLE public."Motivo_Perm" (
 "idMotivo" integer NOT NULL, "Descrip_Motivo" varchar(50), "Salario" boolean,
 "idTipoPermiso" integer, "Abrev" varchar(3), "TipoModalidad" varchar(1), "Activo" boolean);
CREATE TABLE public."Permiso" ("idMotivo" integer);
CREATE TABLE public."Permiso_Aud" ("idMotivo_Ant" integer, "idMotivo_Act" integer);
INSERT INTO public."TipoPermiso" VALUES (1, 'Tipo ficticio'), (2, 'Otro tipo ficticio');
""")
```

<a id="sql-0165"></a>

### SQL-0165 · MotivoPermisoPostgreSqlTests.FiltroNoOcultaInactivosYRespetaTipoModalidad · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:63](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L63)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("""
INSERT INTO public."Motivo_Perm" VALUES
(1, 'P inactivo', null, 1, null, 'P', false),
(2, 'C activo', true, 1, 'C', 'C', true),
(3, 'Sin modalidad', null, 1, null, null, null),
(4, 'Otro tipo', false, 2, null, 'P', true);
""")
```

<a id="sql-0166"></a>

### SQL-0166 · MotivoPermisoPostgreSqlTests.ActualizarConservaEstadoModalidadYTipoInclusoSiEstadoCambio · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:82](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L82)

Prueba automatizada; no flujo productivo. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_db.Execute("UPDATE public.\"Motivo_Perm\" SET \"Activo\"=false WHERE \"idMotivo\"=@id;",
            new PostgreSqlParameterValue("id", id))
```

<a id="sql-0167"></a>

### SQL-0167 · MotivoPermisoPostgreSqlTests.CambioConcurrenteDeModalidadNoSeSobrescribe · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:97](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L97)

Prueba automatizada; no flujo productivo. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_db.Execute("UPDATE public.\"Motivo_Perm\" SET \"TipoModalidad\"='C' WHERE \"idMotivo\"=@id;",
            new PostgreSqlParameterValue("id", id))
```

<a id="sql-0168"></a>

### SQL-0168 · MotivoPermisoPostgreSqlTests.IdentidadNuevaDeTEC002SeUtilizaSinIDExplicito · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:106](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L106)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);")
```

<a id="sql-0169"></a>

### SQL-0169 · MotivoPermisoPostgreSqlTests.SecuenciaDefaultDeTEC002SeUtiliza · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:113](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L113)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("CREATE SEQUENCE public.tec004_sequence START 200; ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" SET DEFAULT nextval('public.tec004_sequence');")
```

<a id="sql-0170"></a>

### SQL-0170 · MotivoPermisoPostgreSqlTests.SecuenciaDesalineadaSinPKRevierteLaFilaDuplicada · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:120](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L120)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("""
INSERT INTO public."Motivo_Perm" ("idMotivo", "idTipoPermiso", "Descrip_Motivo") VALUES (1, 1, 'Anterior');
CREATE SEQUENCE public.tec004_sequence START 1;
ALTER TABLE public."Motivo_Perm" ALTER COLUMN "idMotivo" SET DEFAULT nextval('public.tec004_sequence');
""")
```

<a id="sql-0171"></a>

### SQL-0171 · MotivoPermisoPostgreSqlTests.SecuenciaDesalineadaSinPKRevierteLaFilaDuplicada · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:126](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L126)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Assert.Equal(1, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\";"))
```

<a id="sql-0172"></a>

### SQL-0172 · MotivoPermisoPostgreSqlTests.TipoDuplicadoComoEnDespliegueRechazaAltaSinEscribir · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:133](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L133)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("INSERT INTO public.\"TipoPermiso\" VALUES (1, 'Tipo repetido');")
```

<a id="sql-0173"></a>

### SQL-0173 · MotivoPermisoPostgreSqlTests.AltasConcurrentesSinSecuenciaNoRepitenCodigo · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:141](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L141)

Prueba automatizada; no flujo productivo. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
Enumerable.Range(0, 8).Select(i => Task.Run(() =>
            _repo.Insertar(Nuevo("Motivo " + i, "P")))).ToArray()
```

<a id="sql-0174"></a>

### SQL-0174 · MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria · Plantilla/literal SQL

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:155](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L155)

Prueba automatizada; no flujo productivo. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"INSERT INTO public.\"Permiso\" VALUES (@id);"
```

<a id="sql-0175"></a>

### SQL-0175 · MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria · Plantilla/literal SQL

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:156](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L156)

Prueba automatizada; no flujo productivo. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"INSERT INTO public.\"Permiso_Aud\" VALUES (@id, null);"
```

<a id="sql-0176"></a>

### SQL-0176 · MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria · Plantilla/literal SQL

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:157](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L157)

Prueba automatizada; no flujo productivo. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
"INSERT INTO public.\"Permiso_Aud\" VALUES (null, @id);"
```

<a id="sql-0177"></a>

### SQL-0177 · MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:160](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L160)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("DELETE FROM public.\"Permiso\"; DELETE FROM public.\"Permiso_Aud\";")
```

<a id="sql-0178"></a>

### SQL-0178 · MotivoPermisoPostgreSqlTests.DuplicadosDeIDSeDiagnosticanSinModificarFilas · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:180](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L180)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
_db.Execute("INSERT INTO public.\"Motivo_Perm\" (\"idMotivo\",\"idTipoPermiso\") VALUES (8,1),(8,1);")
```

<a id="sql-0179"></a>

### SQL-0179 · MotivoPermisoPostgreSqlTests.DuplicadosDeIDSeDiagnosticanSinModificarFilas · Llamada/expresión C#

[Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:183](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L183)

Prueba automatizada; no flujo productivo. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
Assert.Equal(2, _db.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\";"))
```

## Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs

<a id="sql-0180"></a>

### SQL-0180 · FrmConsultaAsistDiaria.Button2_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:992](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L992)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs

<a id="sql-0181"></a>

### SQL-0181 · FrmConsultaAsistencias.Button1_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1020](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1020)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs

<a id="sql-0182"></a>

### SQL-0182 · FrmConsultaFaltas.BtnExportar_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:807](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L807)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs

<a id="sql-0183"></a>

### SQL-0183 · FrmConsultaHorarioEsp.Button2_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1120](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1120)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs

<a id="sql-0184"></a>

### SQL-0184 · FrmConsultaPermisos.Button2_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1514](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1514)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs

<a id="sql-0185"></a>

### SQL-0185 · FrmHorasTrabajadas.BtnExportarExcel_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:743](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L743)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs

<a id="sql-0186"></a>

### SQL-0186 · FrmRepAsistenciaDia.Button2_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:917](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L917)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs

<a id="sql-0187"></a>

### SQL-0187 · FrmRepPermisos.Button2_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:871](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L871)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs

<a id="sql-0188"></a>

### SQL-0188 · FrmSobreTiempo.BtnExportarExcel_Click · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:621](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L621)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true)
```

## Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs

<a id="sql-0189"></a>

### SQL-0189 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs:161](../../Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs#L161)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
source.Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)
```

<a id="sql-0190"></a>

### SQL-0190 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs:163](../../Software/RecursosHumanos/RecursosHumanos/My/InternalXmlHelper.cs#L163)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject)
```

## Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs

<a id="sql-0191"></a>

### SQL-0191 · PostgreSqlDiagnostic.TryRun · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:73](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L73)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
EmpleadoMapper.Instance().SelectAll().Select(item => item.IdEmpleado).First()
```

<a id="sql-0192"></a>

### SQL-0192 · PostgreSqlDiagnostic.TryRun · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:77](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L77)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
new PostgreSqlExecutor().ScalarInt("SELECT COUNT(*) FROM public.\"Ubigeo\";")
```

## Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs

<a id="sql-0193"></a>

### SQL-0193 · PostgreSqlLegacyContext.sp_Update_Empleado_idHorario_By_idEmpleado · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:25](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L25)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
		"UPDATE public.\"Empleado\" SET \"idHorario\"=@valor WHERE \"IdEmpleado\"=@empleado;",
		new PostgreSqlParameterValue("valor", horario), new PostgreSqlParameterValue("empleado", empleado))
```

<a id="sql-0194"></a>

### SQL-0194 · PostgreSqlLegacyContext.sp_Update_Empleado_idLocal_By_idEmpleado · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:29](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L29)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Execute(
		"UPDATE public.\"Empleado\" SET \"idLocal\"=@valor WHERE \"IdEmpleado\"=@empleado;",
		new PostgreSqlParameterValue("valor", local), new PostgreSqlParameterValue("empleado", empleado))
```

<a id="sql-0195"></a>

### SQL-0195 · PostgreSqlLegacyContext.spRRHH_getMotivo_perm · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:33](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L33)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",
       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"
FROM public."Motivo_Perm" m
LEFT JOIN public."TipoPermiso" tp ON tp."idTipoPermiso"=m."idTipoPermiso"
WHERE (@tipo IS NULL OR m."idTipoPermiso"=@tipo)
  AND (@modalidad IS NULL OR m."TipoModalidad"=@modalidad)
ORDER BY m."Descrip_Motivo";
""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
		new PostgreSqlParameterValue("modalidad", modalidad?.ToString(), DbType.String))
```

<a id="sql-0196"></a>

### SQL-0196 · PostgreSqlLegacyContext.spRRHH_GetMinTarde · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:47](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L47)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado",
       COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
         THEN GREATEST(0, EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "Tarde",
       COUNT(*) FILTER (WHERE a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'
         AND a."Hor_Ent"::time>h."Ingreso1"::time)::integer AS "DiasTarde"
FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"
LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo
GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";
""", Date("inicio", inicio), Date("fin", fin),
		new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32))
```

<a id="sql-0197"></a>

### SQL-0197 · PostgreSqlLegacyContext.spRRHH_GetDiasAsistidos · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:60](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L60)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado", COUNT(DISTINCT a."Fecha"::date)::integer AS "Dias_Asistidos"
FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"
WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo
GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";
""", Date("inicio", inicio), Date("fin", fin),
		new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32))
```

<a id="sql-0198"></a>

### SQL-0198 · PostgreSqlLegacyContext.spRRHH_GetRecordAsistenciasSemanales · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:68](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L68)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_database.Query("""
SELECT e."IdEmpleado", p."NumDocID",
 btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",
 COUNT(DISTINCT a."Fecha"::date)::integer AS "DiasAsistidos",
 MIN(a."Fecha"::date) AS "FechaInicio", MAX(a."Fecha"::date) AS "FechaFin",
 ROUND(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}'
  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-a."Hor_Ent"::time))/3600) ELSE 0 END)::numeric,2) AS "HorasTrabajadas"
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin
WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo) AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres"
ORDER BY "NombresC";
""", Date("inicio", inicio), Date("fin", fin), new PostgreSqlParameterValue("tipo", tipo, DbType.Int32))
```

<a id="sql-0199"></a>

### SQL-0199 · PostgreSqlLegacyContext.spRRHH_ListarResolucion · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:85](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L85)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_ListarResolucionResult>(_database.Query("""
SELECT tr."DescripTipoResolucion",r."FechaResolucion",r."NumeroResolucion",r."idResolucion"
FROM public."Resolucion" r LEFT JOIN public."TipoResolucion" tr ON tr."idTipoResolucion"=r."idTipoResolucion"
WHERE r."idEmpleado"=@empleado ORDER BY r."FechaResolucion" DESC;
""", Employee(empleado)))
```

<a id="sql-0200"></a>

### SQL-0200 · PostgreSqlLegacyContext.spRRHH_ListarRotaciones · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:92](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L92)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_ListarRotacionesResult>(_database.Query("""
SELECT r."idRotacion",r."FechaMemo",r."NroMemo",eo."AreaOrganizacional"
FROM public."Rotacion" r LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=r."Year" AND eo."idAreaOrganiz"=r."idAreaOrganiz"
WHERE r."idEmpleado"=@empleado ORDER BY r."FechaMemo" DESC;
""", Employee(empleado)))
```

<a id="sql-0201"></a>

### SQL-0201 · PostgreSqlLegacyContext.spRRHH_buscarEstudios · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:99](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L99)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_buscarEstudiosResult>(_database.Query("""
SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio" AS "Añoinicio",er."AñoTermino" AS "Añotermino",
 ee."DescripEstadoEstudio",er."IdEmpleado",er."IdTipoEstudios"
FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"
LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"
WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio" DESC;
""", Employee(empleado)))
```

<a id="sql-0202"></a>

### SQL-0202 · PostgreSqlLegacyContext.spRRHH_BuscarExpLab · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:108](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L108)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_BuscarExpLabResult>(_database.Query("""
SELECT ti."DescripTipoInstitucion",ex."NomInstitucion",ex."Cargo",ex."FechaIngreso",ex."FechaEgreso",
 ex."UnidadOrganica" AS "unidadOrganica",ex."IdEmpleado" AS "idEmpleado",ex."IdExpLab" AS "idExpLab"
FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"
WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;
""", Employee(empleado)))
```

<a id="sql-0203"></a>

### SQL-0203 · PostgreSqlLegacyContext.spRRHH_busca_Disciplina · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:116](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L116)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_busca_DisciplinaResult>(_database.Query("""
SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"
FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"
WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;
""", Employee(empleado)))
```

<a id="sql-0204"></a>

### SQL-0204 · PostgreSqlLegacyContext.spRRHH_GetPeriodoLaboralByEmpleado · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:123](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L123)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_GetPeriodoLaboralByEmpleadoResult>(_database.Query(
			"SELECT * FROM public.\"PeriodoLaboral\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"NroPeriodo\";", Employee(empleado)))
```

<a id="sql-0205"></a>

### SQL-0205 · PostgreSqlLegacyContext.spRRHH_busca_archivos · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:127](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L127)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
Map<spRRHH_busca_archivosResult>(_database.Query("""
SELECT d."DescripDocumento",a."IdEmpleado" AS "idEmpleado",a."idDocumento",a."FechaIngreDoc",a."FechaVenDoc",a."NumRef",a."Obs"
FROM public."Archivo" a LEFT JOIN public."Documento" d ON d."idDocumento"=a."idDocumento"
WHERE a."IdEmpleado"=@empleado ORDER BY d."DescripDocumento";
""", Employee(empleado)))
```

<a id="sql-0206"></a>

### SQL-0206 · PostgreSqlLegacyContext.ListarEmpleados · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:133](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L133)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query($"""
SELECT e."IdEmpleado" AS "idEmpleado",p."NumDocID",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",{asignacion}
FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"
WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)
 AND (@filtro IS NULL OR btrim(concat_ws(' ',p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) ILIKE '%'||@filtro||'%')
 AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'
ORDER BY p."Apellido_Paterno",p."Apellido_Materno",p."Nombres";
""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32),
		new PostgreSqlParameterValue("filtro", string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim(), DbType.String))
```

## Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs

<a id="sql-0207"></a>

### SQL-0207 · PostgreSqlLegacyMapper.SelectAll · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:39](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L39)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
Map(_database.Query($"SELECT * FROM {QuoteTable(TableName)};"))
```

<a id="sql-0208"></a>

### SQL-0208 · PostgreSqlLegacyMapper.GetEntity · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:72](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L72)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Query(
			$"SELECT * FROM {QuoteTable(TableName)} WHERE {QuoteIdentifier(ColumnName(key))} = @id LIMIT 1;",
			new PostgreSqlParameterValue("id", id))
```

<a id="sql-0209"></a>

### SQL-0209 · PostgreSqlLegacyMapper.Insert · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:91](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L91)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
string.Join(", ", Columns.Select(property => QuoteIdentifier(ColumnName(property))))
```

<a id="sql-0210"></a>

### SQL-0210 · PostgreSqlLegacyMapper.Insert · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:92](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L92)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
string.Join(", ", Columns.Select((property, index) => "@p" + index))
```

<a id="sql-0211"></a>

### SQL-0211 · PostgreSqlLegacyMapper.Insert · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:93](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L93)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			$"INSERT INTO {QuoteTable(TableName)} ({names}) VALUES ({values});",
			Parameters(entity, Columns))
```

<a id="sql-0212"></a>

### SQL-0212 · PostgreSqlLegacyMapper.Update · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:126](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L126)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
string.Join(", ", updateColumns.Select(
			(property, index) => $"{QuoteIdentifier(ColumnName(property))} = @p{index}"))
```

<a id="sql-0213"></a>

### SQL-0213 · PostgreSqlLegacyMapper.Update · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:130](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L130)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			$"UPDATE {QuoteTable(TableName)} SET {assignments} WHERE {where};",
			Parameters(entity, parameters))
```

<a id="sql-0214"></a>

### SQL-0214 · PostgreSqlLegacyMapper.Delete · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:163](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L163)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
_database.Execute(
			$"DELETE FROM {QuoteTable(TableName)} WHERE {BuildKeyWhere(0)};",
			Parameters(entity, PrimaryKeys))
```

<a id="sql-0215"></a>

### SQL-0215 · PostgreSqlLegacyMapper.BuildKeyWhere · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:291](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L291)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. SQL construido/interpolado o concatenado: revisar origen de cada identificador/fragmento. No prueba inyección por sí mismo; puede usar parámetros y lista permitida.

```csharp
string.Join(" AND ", PrimaryKeys.Select((property, index) =>
			$"{QuoteIdentifier(ColumnName(property))} = @p{parameterOffset + index}"))
```

## Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs

<a id="sql-0216"></a>

### SQL-0216 · ucUbigeoCmb.GetDpto · Llamada/expresión C#

[Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs:62](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs#L62)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Contiene marcadores @/?; comprobar enlace de parámetros y orden OleDb en la llamada.

```csharp
_ubigeos = _database.Query(@"
SELECT ""IdUbigeo"", ""Departamento"", ""Provincia"", ""Distrito"", ""Descripcion""
FROM public.""Ubigeo""
ORDER BY ""Descripcion"";")
```

## Software/Seguridad/Seguridad/My/InternalXmlHelper.cs

<a id="sql-0217"></a>

### SQL-0217 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/Seguridad/Seguridad/My/InternalXmlHelper.cs:161](../../Software/Seguridad/Seguridad/My/InternalXmlHelper.cs#L161)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
elems.Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)
```

<a id="sql-0218"></a>

### SQL-0218 · InternalXmlHelper.RemoveNamespaceAttributes · Llamada/expresión C#

[Software/Seguridad/Seguridad/My/InternalXmlHelper.cs:163](../../Software/Seguridad/Seguridad/My/InternalXmlHelper.cs#L163)

Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas. Sin marcador visible en este extracto; puede ser SQL constante, DDL o usar parámetros suministrados por otro método.

```csharp
obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject)
```

## Comandos SQL suministrados por variables y APIs de ejecución

| Clase / método | API | Argumentos (expresión completa) | Ámbito | Evidencia |
|---|---|---|---|---|
| AsistenciaAccess.Grabar_suspencion | ExecuteAccess | oCnAccess, sql, new OleDbParameter("persCod", OleDbType.Integer) { Value = personCode }, new OleDbParameter("fecha", OleDbType.VarWChar) { Value = Fecha } | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:96](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L96) |
| AsistenciaAccess.ImportToPostgreSql | ReadAccessTable | accessConnectionString, @"<br>SELECT e.pers_DNI AS DNI, a.fec_asi, a.hor_ent, a.hor_sal,<br>       a.alm_ent, a.alm_sal, a.idhorario, a.estado<br>FROM empleado e INNER JOIN asis_norm a ON e.pers_cod = a.pers_cod<br>WHERE a.fec_asi &gt;= ? AND a.fec_asi &lt; ?", start, endExclusive | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:139](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L139) |
| AsistenciaAccess.ImportToPostgreSql | ReadAccessTable | accessConnectionString, @"<br>SELECT Valor AS DNI, Fecha, Estado, Lugar<br>FROM marcacion<br>WHERE Fecha &gt;= ? AND Fecha &lt; ?<br>ORDER BY Fecha", start, endExclusive | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:144](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L144) |
| AsistenciaAccess.ImportAttendanceRows | transaction.Execute | @"DELETE FROM public.""Asistencia"" WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date;", Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.Date) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:172](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L172) |
| AsistenciaAccess.ImportAttendanceRows | transaction.Execute | @"<br>INSERT INTO public.""Asistencia""<br>    (""Fecha"", ""IdEmpleado"", ""Hor_Ent"", ""Hor_Sal"", ""Alm_Ent"", ""Alm_Sal"", ""Estado"", ""idHorario"", ""Usuario"", ""PC"")<br>SELECT @date, @employee, @arrival, @departure, @lunchArrival, @lunchDeparture, @state, @schedule, 'IMPORTACION', @pc<br>WHERE NOT EXISTS (<br>    SELECT 1 FROM public.""Asistencia""<br>    WHERE ""IdEmpleado"" = @employee AND ""Fecha""::date = @date<br>);", Param("date", date, DbType.DateTime), Param("employee", employeeId, DbType.Int32), Param("arrival", TimeText(row["hor_ent"]), DbType.String), Param("departure", TimeText(row["hor_sal"]), DbType.String), Param("lunchArrival", TimeText(row["alm_ent"]), DbType.String), Param("lunchDeparture", TimeText(row["alm_sal"]), DbType.String), Param("state", BooleanValue(row["estado"]), DbType.Boolean), Param("schedule", NullableInt(row["idhorario"]), DbType.Int32), Param("pc", Environment.MachineName, DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:176](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L176) |
| AsistenciaAccess.ImportMarkRows | transaction.Execute | @"DELETE FROM public.""Marcacion"" WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date;", Param("employee", employeeId, DbType.Int32), Param("date", date, DbType.DateTime) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:200](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L200) |
| AsistenciaAccess.ImportMarkRows | transaction.Execute | @"<br>INSERT INTO public.""Marcacion"" (""Fecha"", ""Estado"", ""IdEmpleado"", ""Lugar"")<br>SELECT @date, @state, @employee, @place<br>WHERE NOT EXISTS (<br>    SELECT 1 FROM public.""Marcacion""<br>    WHERE ""IdEmpleado"" = @employee AND ""Fecha"" = @date<br>);", Param("date", date, DbType.DateTime), Param("state", DbValue(row["Estado"]), DbType.String), Param("employee", employeeId, DbType.Int32), Param("place", DbValue(row["Lugar"]), DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:204](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L204) |
| AsistenciaAccess.ReadAccessTable | OleDbCommand | sql, connection | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:219](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L219) |
| AsistenciaAccess.LoadEmployeesByDocument | _database.Query | @"<br>SELECT e.""IdEmpleado"", p.""NumDocID""<br>FROM public.""Empleado"" e<br>JOIN public.""Persona"" p ON p.""IdPersona"" = e.""IdPersona""<br>WHERE p.""NumDocID"" IS NOT NULL;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:230](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L230) |
| AsistenciaAccess.InsertAccessAttendance | ExecuteAccess | connection, "INSERT INTO Asis_Norm (Pers_Cod, Fec_Asi, Hor_Ent, Hor_Sal, Alm_Ent, Alm_Sal) VALUES (?, ?, ?, ?, ?, ?)", new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("date", OleDbType.VarWChar) { Value = date }, new OleDbParameter("arrival", OleDbType.VarWChar) { Value = arrival }, new OleDbParameter("departure", OleDbType.VarWChar) { Value = departure }, new OleDbParameter("lunchArrival", OleDbType.VarWChar) { Value = lunchArrival }, new OleDbParameter("lunchDeparture", OleDbType.VarWChar) { Value = lunchDeparture } | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:246](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L246) |
| AsistenciaAccess.InsertAccessMark | ExecuteAccess | connection, "INSERT INTO Marcacion (Fecha, Valor, Estado, Proceso, Lugar) VALUES (?, ?, ?, ?, ?)", new OleDbParameter("date", OleDbType.VarWChar) { Value = date }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document }, new OleDbParameter("state", OleDbType.VarWChar) { Value = state }, new OleDbParameter("process", OleDbType.Integer) { Value = process }, new OleDbParameter("place", OleDbType.VarWChar) { Value = place } | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:254](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L254) |
| AsistenciaAccess.UpdateAccessSchedule | ExecuteAccess | connection, "UPDATE Empleado SET idHorario = ? WHERE pers_estado = true AND pers_DNI = ?", new OleDbParameter("schedule", OleDbType.Integer) { Value = scheduleId }, new OleDbParameter("document", OleDbType.VarWChar) { Value = document.Trim() } | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:262](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L262) |
| AsistenciaAccess.InsertAccessPermission | ExecuteAccess | connection, "INSERT INTO Permiso (idEmpleado, NPermiso, FechaInicio, FechaFin, dia, Retorno, Lugar) VALUES (?, ?, ?, ?, ?, ?, ?)", new OleDbParameter("person", OleDbType.Integer) { Value = personCode }, new OleDbParameter("permission", OleDbType.Integer) { Value = permissionNumber }, new OleDbParameter("start", OleDbType.VarWChar) { Value = start }, new OleDbParameter("end", OleDbType.VarWChar) { Value = end }, new OleDbParameter("fullDay", OleDbType.Boolean) { Value = fullDay }, new OleDbParameter("returns", OleDbType.Boolean) { Value = returns }, new OleDbParameter("place", OleDbType.VarWChar) { Value = place } | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:268](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L268) |
| AsistenciaAccess.ExecuteAccess | OleDbCommand | sql, connection | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:285](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L285) |
| AsistenciaAccess.ExecuteAccess | command.ExecuteNonQuery |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:287](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L287) |
| AsistenciaAccess.ExecuteAccessScalarInt | OleDbCommand | sql, connection | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:301](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L301) |
| AsistenciaAccess.ExecuteAccessScalarInt | command.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs:303](../../Software/ClassRRHH/ClassRRHH/AsistenciaAccess.cs#L303) |
| FamiliaresClass.llena_parentezco | _database.Query | "SELECT \"IdTipoFam\", \"DescripTipoFam\" " +<br>			"FROM public.\"TipoFamiliar\" ORDER BY \"DescripTipoFam\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:22](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L22) |
| FamiliaresClass.Busca_DNI | _database.Query | "SELECT * FROM public.\"Persona\" " +<br>			"WHERE btrim(\"NumDocID\") = btrim(@numDoc) AND \"TipoDocID\" = @tipoDoc;", new PostgreSqlParameterValue("numDoc", numDoc), new PostgreSqlParameterValue("tipoDoc", tipodoc) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:29](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L29) |
| FamiliaresClass.Busca_Codigo | _database.Query | "SELECT p.*, f.* FROM public.\"Persona\" AS p " +<br>			"INNER JOIN public.\"Familiar\" AS f ON f.\"IdPersona\" = p.\"IdPersona\" " +<br>			"WHERE p.\"IdPersona\" = @personaId;", new PostgreSqlParameterValue("personaId", Codper) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs:38](../../Software/ClassRRHH/ClassRRHH/FamiliaresClass.cs#L38) |
| FichaSocialClass.llenarFamiliares | _database.Query | sql, new PostgreSqlParameterValue("empleadoId", CodEmple) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs:41](../../Software/ClassRRHH/ClassRRHH/FichaSocialClass.cs#L41) |
| RRHHClass.llena_DocID | _database.Query | "SELECT \"TipoDocID\", \"Descripcion\" FROM public.\"TipoDocID\" ORDER BY \"Descripcion\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:57](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L57) |
| RRHHClass.llena_Area | _database.Query | "SELECT \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +<br>			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";", new PostgreSqlParameterValue("year", mAnio) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:63](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L63) |
| RRHHClass.llena_Nacionalidad | _database.Query | "SELECT \"IdNacionalidad\", \"Descripcion\" FROM public.\"Nacionalidad\" ORDER BY \"Descripcion\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:71](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L71) |
| RRHHClass.llena_Discapacidad | _database.Query | "SELECT \"IdDiscapacidad\", \"Descrip_Discapacidad\" FROM public.\"Discapacidad\" " +<br>			"ORDER BY \"Descrip_Discapacidad\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:77](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L77) |
| RRHHClass.llena_estCivil | _database.Query | "SELECT \"IdEstadoCivil\", \"DescripEstCivil\" FROM public.\"EstadoCivil\" " +<br>			"ORDER BY \"DescripEstCivil\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:84](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L84) |
| RRHHClass.importarBio | _database.Execute | """<br>INSERT INTO public."Asistencia"<br>    ("Fecha","IdEmpleado","Hor_Ent","Hor_Sal","Flag_Ent","Flag_Sal","Estado","idHorario","Usuario","PC")<br>SELECT m."Fecha"::date, m."IdEmpleado",<br>       to_char(MIN(m."Fecha"),'HH24:MI:SS'), to_char(MAX(m."Fecha"),'HH24:MI:SS'),<br>       TRUE, COUNT(*) &gt; 1, TRUE, MAX(m."idHorario"), 'MIGRACION_BIO', 'POSTGRESQL'<br>FROM public."Marcacion" m<br>WHERE m."Fecha"::date BETWEEN @inicio AND @fin<br>GROUP BY m."Fecha"::date,m."IdEmpleado"<br>ON CONFLICT ("Fecha","IdEmpleado") DO UPDATE SET<br>  "Hor_Ent"=EXCLUDED."Hor_Ent", "Hor_Sal"=EXCLUDED."Hor_Sal",<br>  "Flag_Ent"=EXCLUDED."Flag_Ent", "Flag_Sal"=EXCLUDED."Flag_Sal",<br>  "Estado"=EXCLUDED."Estado", "idHorario"=EXCLUDED."idHorario";<br>""", new PostgreSqlParameterValue("inicio", ParseDate(FechaInicial).Date, DbType.Date), new PostgreSqlParameterValue("fin", ParseDate(FechaFinal).Date, DbType.Date) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:105](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L105) |
| RRHHClass.ElimnarPermiso | _database.Execute | "DELETE FROM public.\"Permiso\" WHERE \"IdEmpleado\" = @empleadoId AND \"NPermiso\" = @numero;", new PostgreSqlParameterValue("empleadoId", idempleado), new PostgreSqlParameterValue("numero", NPermiso) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:141](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L141) |
| RRHHClass.eliminarHorarioTemporal | _database.Execute | "DELETE FROM public.\"HorarioTemporal\" WHERE \"idEmpleado\" = @empleadoId AND \"N\" = @numero;", new PostgreSqlParameterValue("empleadoId", idempleado), new PostgreSqlParameterValue("numero", NPermiso) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:150](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L150) |
| RRHHClass.llenar_Empleado_Area | _database.Query | """<br>SELECT ea."Year", ea."idAreaOrganiz", eo."AreaOrganizacional"<br>FROM public."Empleado_Area" AS ea<br>INNER JOIN public."EstructOrganiz" AS eo<br>    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"<br>WHERE ea."IdEmpleado" = @empleadoId<br>ORDER BY ea."Year" DESC;<br>""", new PostgreSqlParameterValue("empleadoId", idEmpleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:159](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L159) |
| RRHHClass.Actualizar_Area_Empleado | _database.Execute | "UPDATE public.\"Empleado_Area\" SET \"idAreaOrganiz\" = @areaId " +<br>			"WHERE \"Year\" = @year AND \"IdEmpleado\" = @empleadoId;", new PostgreSqlParameterValue("areaId", idAreaOrganiz), new PostgreSqlParameterValue("year", Anio), new PostgreSqlParameterValue("empleadoId", idEmpleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:172](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L172) |
| RRHHClass.llenar_Areas_by_año | _database.Query | "SELECT \"Year\", \"idAreaOrganiz\", \"AreaOrganizacional\" FROM public.\"EstructOrganiz\" " +<br>			"WHERE \"Year\" = @year ORDER BY \"AreaOrganizacional\";", new PostgreSqlParameterValue("year", Anio) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:182](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L182) |
| RRHHClass.buscar_empleado | _database.Query | sql, new PostgreSqlParameterValue("estado", activo == 0 ? "0" : "1"), new PostgreSqlParameterValue("apellido", apellido ?? string.Empty), new PostgreSqlParameterValue("numeroDocumento", numdoc ?? string.Empty), new PostgreSqlParameterValue("empleadoId", codigo, DbType.Int32), new PostgreSqlParameterValue("year", mAnio), new PostgreSqlParameterValue("rol", idRol), new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:217](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L217) |
| RRHHClass.BuscarEmpleado_Codigo | _database.Query | sql, new PostgreSqlParameterValue("empleadoId", codigo) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:245](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L245) |
| RRHHClass.ActualizaAsistencia | _database.Execute | "UPDATE public.\"Asistencia\" SET \"Hor_Sal\" = @horaSalida, \"Flag_Sal\" = @salidaManual " +<br>			"WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\" = @fecha;", new PostgreSqlParameterValue("horaSalida", hor_sal), new PostgreSqlParameterValue("salidaManual", flag_sal), new PostgreSqlParameterValue("empleadoId", idEmpleado), new PostgreSqlParameterValue("fecha", fecha, DbType.DateTime) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:252](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L252) |
| RRHHClass.ingresa_Empleado_Area | _database.Execute | "INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +<br>			"VALUES (@year, @areaId, @empleadoId);", new PostgreSqlParameterValue("year", year), new PostgreSqlParameterValue("areaId", idorganiz), new PostgreSqlParameterValue("empleadoId", idEmpleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:278](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L278) |
| RRHHClass.Ingresa_Empleado | transaction.Execute | "SELECT pg_advisory_xact_lock(721104);" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:292](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L292) |
| RRHHClass.Ingresa_Empleado | transaction.Execute | """<br>INSERT INTO public."Persona"<br>    ("IdPersona", "Nombres", "Apellido_Paterno", "Apellido_Materno", "TipoDocID", "NumDocID",<br>     "Direccion", "Telefono", "Fax", "Email", "IdUbigeo", "UbigeoDireccion", "TipoPersona",<br>     "FechaNacimiento", "FechaRegistro", "NumCelular", "FonoCentroLab")<br>VALUES<br>    (@personaId, @nombres, @apellidoPaterno, @apellidoMaterno, @tipoDoc, @numeroDoc,<br>     @direccion, @telefono, @fax, @email, @ubigeoNacimiento, @ubigeoDireccion, 'N',<br>     @fechaNacimiento, @fechaRegistro, @celular, @telefonoLaboral);<br>""", new PostgreSqlParameterValue("personaId", personaId), Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno), Text("apellidoMaterno", Apellido_Materno), new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc), Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro), Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac), Text("ubigeoDireccion", UbigeoDireccion), new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime), new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime), Text("celular", FonoCel), Text("telefonoLaboral", FonoLab) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:298](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L298) |
| RRHHClass.Ingresa_Empleado | transaction.Execute | """<br>INSERT INTO public."Empleado"<br>    ("IdEmpleado", "Year", "idAreaOrganiz", "IdPersona", "ExpSocial", "FechaIngreso",<br>     "Brevete", "IdEstadoCivil", "Sexo", "IdTipoSangre", "Foto", "IdTipoTrabajador",<br>     "Estado", "IdDiscapacidad", "IdNacionalidad", "NumLibretaMilitar", "GradoInstruccion", "NumRUC")<br>VALUES<br>    (@empleadoId, @year, @areaId, @personaId, @expSocial, @fechaIngreso,<br>     @brevete, @estadoCivil, @sexo, @tipoSangre, @foto, @tipoTrabajador,<br>     '1', @discapacidad, @nacionalidad, @libretaMilitar, @gradoInstruccion, @ruc);<br>""", new PostgreSqlParameterValue("empleadoId", empleadoId), new PostgreSqlParameterValue("year", year), new PostgreSqlParameterValue("areaId", idorganiz), new PostgreSqlParameterValue("personaId", personaId), Text("expSocial", expSocial), new PostgreSqlParameterValue("fechaIngreso", FechaIngreso, DbType.DateTime), Text("brevete", brevete), new PostgreSqlParameterValue("estadoCivil", idEstCivil), Text("sexo", sexo), new PostgreSqlParameterValue("tipoSangre", tiposangre), Text("foto", EncodePhoto(Foto)), NullableInt("tipoTrabajador", idtipoTrabajador), new PostgreSqlParameterValue("discapacidad", idDiscapacidad), NullableInt("nacionalidad", idNacionalidad), Text("libretaMilitar", libmilitar), Text("gradoInstruccion", gradoinstruccion), Text("ruc", numRuc) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:319](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L319) |
| RRHHClass.Ingresa_Empleado | transaction.Execute | "INSERT INTO public.\"Empleado_Area\" (\"Year\", \"idAreaOrganiz\", \"IdEmpleado\") " +<br>				"VALUES (@year, @areaId, @empleadoId);", new PostgreSqlParameterValue("year", year), new PostgreSqlParameterValue("areaId", idorganiz), new PostgreSqlParameterValue("empleadoId", empleadoId) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:343](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L343) |
| RRHHClass.Actualiza_Empleado | transaction.Execute | """<br>UPDATE public."Persona" SET<br>    "Nombres" = @nombres, "Apellido_Paterno" = @apellidoPaterno,<br>    "Apellido_Materno" = @apellidoMaterno, "TipoDocID" = @tipoDoc,<br>    "NumDocID" = @numeroDoc, "Direccion" = @direccion, "Telefono" = @telefono,<br>    "Fax" = @fax, "Email" = @email, "IdUbigeo" = @ubigeoNacimiento,<br>    "UbigeoDireccion" = @ubigeoDireccion, "TipoPersona" = 'N',<br>    "FechaNacimiento" = @fechaNacimiento, "FechaRegistro" = @fechaRegistro,<br>    "NumCelular" = @celular, "FonoCentroLab" = @telefonoLaboral<br>WHERE "IdPersona" = @personaId;<br>""", Text("nombres", Nombres), Text("apellidoPaterno", Apellido_Paterno), Text("apellidoMaterno", Apellido_Materno), new PostgreSqlParameterValue("tipoDoc", TipoDocIdent), Text("numeroDoc", NumDoc), Text("direccion", Direccion), Text("telefono", Fono), Text("fax", FonoOtro), Text("email", Mail), Text("ubigeoNacimiento", ubigeoNac), Text("ubigeoDireccion", UbigeoDireccion), new PostgreSqlParameterValue("fechaNacimiento", fechaNac, DbType.DateTime), new PostgreSqlParameterValue("fechaRegistro", FechaIngreso, DbType.DateTime), Text("celular", FonoCel), Text("telefonoLaboral", FonoLab), new PostgreSqlParameterValue("personaId", codpersona) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:358](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L358) |
| RRHHClass.Actualiza_Empleado | transaction.Execute | """<br>UPDATE public."Empleado" SET<br>    "Year" = @year, "idAreaOrganiz" = @areaId, "ExpSocial" = @expSocial,<br>    "IdEstadoCivil" = @estadoCivil, "Sexo" = @sexo, "Foto" = @foto,<br>    "IdDiscapacidad" = @discapacidad, "IdNacionalidad" = @nacionalidad,<br>    "Estado" = '1', "IdTipoSangre" = @tipoSangre, "Brevete" = @brevete,<br>    "NumLibretaMilitar" = @libretaMilitar, "GradoInstruccion" = @gradoInstruccion,<br>    "NumRUC" = @ruc, "IdTipoTrabajador" = @tipoTrabajador<br>WHERE "IdEmpleado" = @empleadoId;<br>""", new PostgreSqlParameterValue("year", year), new PostgreSqlParameterValue("areaId", idorganiz), Text("expSocial", expSocial), new PostgreSqlParameterValue("estadoCivil", idEstCivil), Text("sexo", sexo), Text("foto", EncodePhoto(Foto)), new PostgreSqlParameterValue("discapacidad", idDiscapacidad), NullableInt("nacionalidad", idNacionalidad), new PostgreSqlParameterValue("tipoSangre", tiposangre), Text("brevete", brevete), Text("libretaMilitar", libmilitar), Text("gradoInstruccion", gradoinstruccion), Text("ruc", numRuc), NullableInt("tipoTrabajador", idtipoTrabajador), new PostgreSqlParameterValue("empleadoId", codempleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:380](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L380) |
| RRHHClass.Actualiza_Empleado | _database.Execute | "UPDATE public.\"Empleado\" SET \"Estado\" = '0' WHERE \"IdEmpleado\" = @empleadoId;", new PostgreSqlParameterValue("empleadoId", codempleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:409](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L409) |
| RRHHClass.llena_tree | _database.Query | "SELECT \"idAreaOrganiz\" AS \"Padre\", \"AreaOrganizacional\", \"idDependeDe\" AS \"Hijo\" " +<br>			"FROM public.\"EstructOrganiz\" WHERE \"Year\" = @year;", new PostgreSqlParameterValue("year", mAnio) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:416](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L416) |
| RRHHClass.buscar_empleado_tree | _database.Query | """<br>SELECT<br>    e."IdTipoTrabajador",<br>    e."IdEmpleado" AS "Codigo",<br>    p."NumDocID" AS "DNI",<br>    btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresCompletos",<br>    c."Cargo" AS "Cargo"<br>FROM public."Empleado" AS e<br>INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"<br>INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"<br>LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"<br>WHERE ea."idAreaOrganiz" = @areaId<br>  AND ea."Year" = @year<br>  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>  AND (@tipoTrabajador = 0 OR e."IdTipoTrabajador" = @tipoTrabajador)<br>ORDER BY "NombresCompletos";<br>""", new PostgreSqlParameterValue("areaId", area), new PostgreSqlParameterValue("year", mAnio), new PostgreSqlParameterValue("tipoTrabajador", tipotrab) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:424](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L424) |
| RRHHClass.Generar_Ficha | SqlCommand | "spRRHH_fichaSocial", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:452](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L452) |
| RRHHClass.Generar_Ficha | SqlCommand | "spRRHH_Ficha_ExpLab", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:456](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L456) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_ExpLab_Datos", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:473](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L473) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_busca_Disciplina", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:483](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L483) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_ExpLab", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:493](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L493) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Det_Familiar", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:503](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L503) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Estudio_Realizado", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:513](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L513) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Estudio_Titulo", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:523](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L523) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Estudio_Capacitacion", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:533](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L533) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Ingreso_Egreso", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:543](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L543) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Vivienda", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:553](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L553) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_DatosPersonales", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:563](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L563) |
| RRHHClass.Generar_Ficha_Prueba | SqlCommand | "spRRHH_Ficha_Det_Familiar_Salud", ObjCnn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:573](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L573) |
| RRHHClass.Generar_Cuadro_Pers | _database.Query | """<br>SELECT e."IdEmpleado" AS "Codigo", p."NumDocID" AS "DNI",<br>       btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",<br>       eo."AreaOrganizacional", c."Cargo" AS "cargo", tt."Descripcion",<br>       e."Estado", e."IdTipoTrabajador"<br>FROM public."Empleado" e<br>JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"<br>LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"<br>WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)<br>  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>ORDER BY "NombresCompletos";<br>""", new PostgreSqlParameterValue("year", mAnio), new PostgreSqlParameterValue("tipo", tipo) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:589](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L589) |
| RRHHClass.Generar_Cumples | _database.Query | """<br>SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",<br>       EXTRACT(DAY FROM p."FechaNacimiento")::integer AS "Dia",<br>       EXTRACT(MONTH FROM p."FechaNacimiento")::integer AS "mes",<br>       trim(to_char(p."FechaNacimiento", 'TMMonth')) AS "MESletras",<br>       EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",<br>       eo."AreaOrganizacional", e."Estado"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>WHERE EXTRACT(MONTH FROM p."FechaNacimiento")=@mes<br>  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>ORDER BY "Dia", "NombresCompletos";<br>""", new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("mes", mes) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:609](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L609) |
| RRHHClass.llena_tree_reporte | _database.Query | """<br>SELECT "AreaOrganizacional", COALESCE(NULLIF("Sigla",''),"Abrev") AS "siglafull",<br>       "idAreaOrganiz" AS "Padre", "idDependeDe" AS "Hijo"<br>FROM public."EstructOrganiz" WHERE "Year"=@year ORDER BY "AreaOrganizacional";<br>""", new PostgreSqlParameterValue("year", mAnio) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:628](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L628) |
| RRHHClass.Generar_Report_Emple_ficha | _database.Query | """<br>SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresCompletos",<br>       e."FechaIngreso" AS "FechadeIngreso", eo."AreaOrganizacional",<br>       EXTRACT(YEAR FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "años",<br>       EXTRACT(MONTH FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "meses",<br>       EXTRACT(DAY FROM age(CURRENT_DATE,e."FechaIngreso"))::integer AS "dias"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>WHERE e."FechaIngreso"::date BETWEEN @inicio AND @fin AND (@tipo=0 OR e."IdTipoTrabajador"=@tipo)<br>ORDER BY e."FechaIngreso", "NombresCompletos";<br>""", new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(Fechatermino), DbType.Date), new PostgreSqlParameterValue("tipo", tipo) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:649](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L649) |
| RRHHClass.generar_rep_cargos | _database.Query | """<br>SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",<br>       eo."AreaOrganizacional", c."Cargo" AS "cargo"<br>FROM public."Empleado" AS e<br>INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"<br>INNER JOIN public."EstructOrganiz" AS eo<br>    ON eo."idAreaOrganiz" = e."idAreaOrganiz" AND eo."Year" = e."Year"<br>INNER JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"<br>WHERE e."IdCargo" = @cargoId<br>  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>  AND e."IdTipoTrabajador" = 1;<br>""", new PostgreSqlParameterValue("cargoId", idCargo) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:669](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L669) |
| RRHHClass.llena_Asistencias | _database.Query | """<br>SELECT a.*, p."NumDocID", p."Apellido_Paterno", p."Apellido_Materno", p."Nombres"<br>FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"<br>JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>WHERE a."Fecha"::date BETWEEN @inicio AND @fin ORDER BY a."Fecha",p."Apellido_Paterno";<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaInicio), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(fechaFin), DbType.Date) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:686](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L686) |
| RRHHClass.llena_Permisos | _database.Query | """<br>SELECT tp."DescripTipoPermiso", m."Descrip_Motivo", p."NPermiso",<br>       p."FechaInicio", p."FechaFin", p."Hora_Sal", p."Hora_Ret", p."Dia",<br>       p."Retorno", p."Lugar", p."Referencia", p."Autorizacion", p."IdEmpleado"<br>FROM public."Permiso" AS p<br>INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"<br>INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"<br>WHERE p."IdEmpleado" = @empleadoId<br>  AND (@tipoPermiso IS NULL OR tp."idTipoPermiso" = @tipoPermiso)<br>  AND (@motivo IS NULL OR m."idMotivo" = @motivo)<br>ORDER BY p."FechaInicio" DESC;<br>""", new PostgreSqlParameterValue("empleadoId", codempleado), new PostgreSqlParameterValue("tipoPermiso", permiso, DbType.Int32), new PostgreSqlParameterValue("motivo", motivo, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:697](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L697) |
| RRHHClass.llena_HorariosTemporales | _database.Query | """<br>SELECT ht."N", ht."FechaInicio", ht."FechaFin", h."Descrip_Horario",<br>       h."Ingreso1", h."Salida2", ht."NroDocumento", ht."Sisgedo"<br>FROM public."HorarioTemporal" AS ht<br>INNER JOIN public."Horario" AS h ON h."idHorario" = ht."HorarioAsignado"<br>WHERE ht."idEmpleado" = @empleadoId<br>ORDER BY ht."FechaInicio" DESC;<br>""", new PostgreSqlParameterValue("empleadoId", codempleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:716](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L716) |
| RRHHClass.Generar_Rep_Faltas | _database.Query | """<br>SELECT btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC",<br>       p."NumDocID", p."IdPersona", e."IdEmpleado", ea."Year", ea."idAreaOrganiz",<br>       e."IdTipoTrabajador", e."Estado", eo."AreaOrganizacional", tt."Descripcion",<br>       NULL::timestamp AS "Fecha"<br>FROM public."Empleado" AS e<br>INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"<br>INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"<br>INNER JOIN public."EstructOrganiz" AS eo<br>    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"<br>LEFT JOIN public."TipoTrabajador" AS tt ON tt."IdTipoTrabajador" = e."IdTipoTrabajador"<br>WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)<br>  AND (@areaId IS NULL OR ea."idAreaOrganiz" = @areaId)<br>  AND (@year IS NULL OR ea."Year" = @year)<br>  AND NOT EXISTS (<br>      SELECT 1 FROM public."Asistencia" AS a<br>      WHERE a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha<br>  )<br>ORDER BY "NombresC";<br>""", new PostgreSqlParameterValue("fecha", ParseDate(fecha).Date, DbType.Date), new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32), new PostgreSqlParameterValue("areaId", idAreaOrganiz, DbType.Int32), new PostgreSqlParameterValue("year", Año, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:729](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L729) |
| RRHHClass.ObtenerAsistenciasxDia | _database.Query | """<br>SELECT a."Fecha", e."IdEmpleado",<br>       CASE WHEN a."IdEmpleado" IS NULL THEN 'F' ELSE 'A' END AS "Estado"<br>FROM public."Empleado" AS e<br>LEFT JOIN public."Asistencia" AS a<br>    ON a."IdEmpleado" = e."IdEmpleado" AND a."Fecha"::date = @fecha<br>WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>ORDER BY e."IdEmpleado";<br>""", new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:760](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L760) |
| RRHHClass.ObtenerEmpleados | _database.Query | """<br>SELECT e."IdEmpleado" AS "idempleado",<br>       btrim(concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres")) AS "NombresC"<br>FROM public."Empleado" AS e<br>INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"<br>WHERE COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>ORDER BY "NombresC";<br>""" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:776](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L776) |
| RRHHClass.LlenarPlanillaAsistencia | _database.Query | """<br>SELECT e."IdEmpleado", btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",<br>       a."Fecha"::date AS "Dia", a."Hor_Ent", a."Hor_Sal"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin<br>WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo)<br>  AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))<br>  AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>ORDER BY "NombresC",a."Fecha";<br>""", new PostgreSqlParameterValue("inicio", dates.Min(), DbType.Date), new PostgreSqlParameterValue("fin", dates.Max(), DbType.Date), new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("locales", locales) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:803](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L803) |
| RRHHClass.spRRHH_RepPermisos | _database.Query | """<br>SELECT<br>    btrim(concat_ws(' ', pe."Apellido_Paterno", pe."Apellido_Materno", pe."Nombres")) AS "Nombres",<br>    c."Cargo", eo."AreaOrganizacional", m."Descrip_Motivo",<br>    p."FechaInicio", p."FechaFin", COALESCE(p."Hora_Sal", '--') AS "Hora_Sal",<br>    COALESCE(p."Hora_Ret", '--') AS "Hora_ret", COALESCE(p."Lugar", 'No Especifica') AS "Lugar",<br>    COALESCE(p."Obs", '--') AS "Observaciones"<br>FROM public."Permiso" AS p<br>INNER JOIN public."Empleado" AS e ON e."IdEmpleado" = p."IdEmpleado"<br>INNER JOIN public."Persona" AS pe ON pe."IdPersona" = e."IdPersona"<br>INNER JOIN public."Motivo_Perm" AS m ON m."idMotivo" = p."idMotivo"<br>INNER JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"<br>LEFT JOIN public."Cargo" AS c ON c."IdCargo" = e."IdCargo"<br>INNER JOIN public."Empleado_Area" AS ea<br>    ON ea."IdEmpleado" = e."IdEmpleado" AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer<br>INNER JOIN public."EstructOrganiz" AS eo<br>    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"<br>WHERE p."FechaInicio"::date BETWEEN @fechaInicio AND @fechaFin<br>  AND (@tipoPermiso IS NULL OR m."idTipoPermiso" = @tipoPermiso)<br>  AND (@motivo IS NULL OR p."idMotivo" = @motivo)<br>  AND (@tipoTrabajador IS NULL OR e."IdTipoTrabajador" = @tipoTrabajador)<br>ORDER BY p."FechaInicio";<br>""", new PostgreSqlParameterValue("fechaInicio", ParseCompactDate(fechaI), DbType.Date), new PostgreSqlParameterValue("fechaFin", ParseCompactDate(fechaF), DbType.Date), new PostgreSqlParameterValue("tipoPermiso", tipopermiso, DbType.Int32), new PostgreSqlParameterValue("motivo", motivo, DbType.Int32), new PostgreSqlParameterValue("tipoTrabajador", idTipoTrabajador, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:837](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L837) |
| RRHHClass.spRRHH_ObtenerHorasExtras | _database.Query | """<br>SELECT e."IdEmpleado",p."NumDocID",<br> btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",<br> a."Fecha",a."Hor_Ent",a."Hor_Sal",h."Salida1",<br> ROUND(GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-h."Salida1"::time))/3600)::numeric,2) AS "HorasExtras"<br>FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"<br>JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")<br>WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)<br> AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}' AND h."Salida1" ~ '^\d{1,2}:\d{2}'<br>ORDER BY a."Fecha","NombresC";<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date), new PostgreSqlParameterValue("tipo", tipo, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:871](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L871) |
| RRHHClass.BuscarPersonas | _database.Query | """<br>SELECT "IdPersona", "Apellido_Paterno", "Apellido_Materno", "Nombres"<br>FROM public."Persona"<br>WHERE "Apellido_Paterno" ILIKE @apellido \|\| '%' AND "TipoPersona" = 'N'<br>ORDER BY "Apellido_Paterno", "Apellido_Materno", "Nombres";<br>""", Text("apellido", ApellidoPaterno ?? string.Empty) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:891](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L891) |
| RRHHClass.ListarProfesiones | _database.Query | "SELECT DISTINCT \"Profesion\" FROM public.\"Empleado\" " +<br>			"WHERE NULLIF(btrim(\"Profesion\"), '') IS NOT NULL ORDER BY \"Profesion\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:902](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L902) |
| RRHHClass.spRRHH_Rep_profesion | _database.Query | """<br>SELECT p."Apellido_Paterno", p."Apellido_Materno", p."Nombres",<br>       eo."AreaOrganizacional", e."Profesion"<br>FROM public."Empleado" AS e<br>INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"<br>INNER JOIN public."Empleado_Area" AS ea ON ea."IdEmpleado" = e."IdEmpleado"<br>INNER JOIN public."EstructOrganiz" AS eo<br>    ON eo."idAreaOrganiz" = ea."idAreaOrganiz" AND eo."Year" = ea."Year"<br>WHERE e."Profesion" = @profesion<br>  AND COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1'<br>  AND ea."Year" = EXTRACT(YEAR FROM CURRENT_DATE)::integer<br>  AND e."IdTipoTrabajador" = 1;<br>""", Text("profesion", profesion) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:909](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L909) |
| RRHHClass.spRRHH_AgregarReporte | _database.Execute | """<br>INSERT INTO public."AuxRRHH_ReporteAsistencia" ("idEmpleado")<br>SELECT @empleadoId<br>WHERE NOT EXISTS (<br>    SELECT 1 FROM public."AuxRRHH_ReporteAsistencia" WHERE "idEmpleado" = @empleadoId<br>);<br>""", new PostgreSqlParameterValue("empleadoId", idTipoTrabajador) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:939](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L939) |
| RRHHClass.spRRHH_AgregarReporte | _database.Execute | "DELETE FROM public.\"AuxRRHH_ReporteAsistencia\" WHERE \"idEmpleado\" = @empleadoId;", new PostgreSqlParameterValue("empleadoId", idTipoTrabajador) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:950](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L950) |
| RRHHClass.spRRHH_RepAsisdiarria | _database.Query | """<br>SELECT a.*,p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",<br> btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",<br> eo."AreaOrganizacional",l."NombreLocal"<br>FROM public."Asistencia" a JOIN public."Empleado" e ON e."IdEmpleado"=a."IdEmpleado"<br>JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>LEFT JOIN public."Local" l ON l."idLocal"=e."idLocal"<br>WHERE a."Fecha"::date BETWEEN @inicio AND @fin<br> AND (@dni IS NULL OR p."NumDocID" ILIKE '%'\|\|@dni\|\|'%')<br> AND (@area IS NULL OR ea."idAreaOrganiz"=@area) AND (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)<br> AND (cardinality(@locales::integer[])=0 OR e."idLocal"=ANY(@locales::integer[]))<br>ORDER BY a."Fecha","NombresC";<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(fechaI), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(fechaF), DbType.Date), Text("dni", string.IsNullOrWhiteSpace(DNI) ? null : DNI.Trim()), new PostgreSqlParameterValue("area", area, DbType.Int32), new PostgreSqlParameterValue("tipo", tipo, DbType.Int32), new PostgreSqlParameterValue("year", int.TryParse(year, out int parsedYear) ? parsedYear : DateTime.Today.Year), new PostgreSqlParameterValue("locales", locales) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:961](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L961) |
| RRHHClass.spRRHH_ListarMotivos_byTipo | _database.Query | """<br>SELECT "Abrev", "Descrip_Motivo"<br>FROM public."Motivo_Perm"<br>WHERE COALESCE("Activo", FALSE) AND "TipoModalidad" = @modalidad AND "Abrev" &lt;&gt; '1'<br>ORDER BY "Abrev";<br>""", Text("modalidad", fechaI) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:988](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L988) |
| RRHHClass.spRRHH_EstadisticaPermiso | _database.Query | """<br>SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",<br> e."IdEmpleado",p."NumDocID",<br> COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'<br>  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "MinutosTarde",<br> eo."AreaOrganizacional",ea."idAreaOrganiz"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin<br>LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")<br>WHERE (@tipo=0 OR e."IdTipoTrabajador"=@tipo) AND (@area=0 OR ea."idAreaOrganiz"=@area)<br> AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres",eo."AreaOrganizacional",ea."idAreaOrganiz"<br>ORDER BY "NombresC";<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date), new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("tipo", tipo), new PostgreSqlParameterValue("area", area) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1004](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1004) |
| RRHHClass.spRRHH_EstadisticaPermiso | _database.Query | """<br>SELECT pe."IdEmpleado",pe."idMotivo",COUNT(*)::integer AS "Cantidad",m."Descrip_Motivo"<br>FROM public."Permiso" pe JOIN public."Motivo_Perm" m ON m."idMotivo"=pe."idMotivo"<br>WHERE pe."FechaInicio"::date &lt;= @fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date &gt;= @inicio<br> AND (cardinality(@motivos::integer[])=0 OR pe."idMotivo"=ANY(@motivos::integer[]))<br>GROUP BY pe."IdEmpleado",pe."idMotivo",m."Descrip_Motivo";<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date), new PostgreSqlParameterValue("motivos", motivos) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1024](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1024) |
| RRHHClass.spRRHH_ResumenEstadisticaPermiso | _database.Query | """<br>SELECT m."idMotivo",m."Descrip_Motivo",COUNT(pe."NPermiso")::integer AS "Cantidad",<br> ROUND(CASE WHEN totals.total=0 THEN 0 ELSE COUNT(pe."NPermiso")*100.0/totals.total END,2) AS "Porcentaje"<br>FROM public."Motivo_Perm" m<br>LEFT JOIN public."Permiso" pe ON pe."idMotivo"=m."idMotivo"<br> AND pe."FechaInicio"::date&lt;=@fin AND COALESCE(pe."FechaFin",pe."FechaInicio")::date&gt;=@inicio<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=pe."IdEmpleado" AND ea."Year"=@year<br>CROSS JOIN (SELECT COUNT(*)::numeric AS total FROM public."Permiso" p2<br> JOIN public."Empleado_Area" ea2 ON ea2."IdEmpleado"=p2."IdEmpleado" AND ea2."Year"=@year<br> WHERE p2."FechaInicio"::date&lt;=@fin AND COALESCE(p2."FechaFin",p2."FechaInicio")::date&gt;=@inicio<br> AND (@area=0 OR ea2."idAreaOrganiz"=@area)) totals<br>WHERE m."idMotivo"=@motivo AND (@area=0 OR ea."idAreaOrganiz"=@area OR pe."IdEmpleado" IS NULL)<br>GROUP BY m."idMotivo",m."Descrip_Motivo",totals.total;<br>""", new PostgreSqlParameterValue("inicio", ParseCompactDate(FechaInicio), DbType.Date), new PostgreSqlParameterValue("fin", ParseCompactDate(FechaFin), DbType.Date), new PostgreSqlParameterValue("year", DateTime.Today.Year), new PostgreSqlParameterValue("motivo", idMotivo), new PostgreSqlParameterValue("area", idArea) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1065](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1065) |
| RRHHClass.spRRHH_GetAsistenciaDia | _database.Query | "SELECT * FROM public.\"Asistencia\" WHERE \"IdEmpleado\" = @empleadoId AND \"Fecha\"::date = @fecha;", new PostgreSqlParameterValue("empleadoId", codigo), new PostgreSqlParameterValue("fecha", ParseCompactDate(fecha), DbType.Date) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1088](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1088) |
| RRHHClass.ListarTrabajadoresReporte | _database.Query | string.Format(CultureInfo.InvariantCulture, sql, membership), new PostgreSqlParameterValue("tipoTrabajador", tipoTrabajador) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1110](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1110) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT e."IdEmpleado" AS "idempleado",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",<br> p."NumDocID" AS "NumDocId",p."Direccion" AS "direccion",p."Telefono",p."Fax",p."Email",<br> p."FechaNacimiento",p."FechaRegistro",p."NumCelular",p."FonoCentroLab",<br> e."Sexo" AS "sexo",e."ExpSocial",e."Brevete" AS "brevete",e."JefeHogar",e."CargaFam",<br> e."NumHijos" AS "Numhijos",e."ObsFam",e."NumLibretaMilitar",e."GradoInstruccion" AS "gradoInstruccion",<br> e."NumRUC",e."Foto" AS "foto",td."Descripcion" AS "TipoDoc",ec."DescripEstCivil" AS "EstadoCivil",<br> ts."DescripTS" AS "DescripTS",n."Descripcion" AS "Nacionalidad",<br> vc."DescripViveCon" AS "Descripvivecon",d."Descrip_Discapacidad" AS "Discapacidad",<br> EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadEmpleado",<br> s."EnferCronica" AS "enfercronica",s."EnferCronicaDescrip" AS "enfercronicadescrip",<br> s."FamDiscapacidad" AS "famdiscapacidad",s."FamDiscapDescrip" AS "famdiscapdescrip",<br> s."Alergico" AS "alergico",s."AlergicoDescrip" AS "alergicodescrip"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."TipoDocID" td ON td."TipoDocID"=p."TipoDocID"<br>LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=e."IdEstadoCivil"<br>LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=e."IdTipoSangre"<br>LEFT JOIN public."Nacionalidad" n ON n."IdNacionalidad"=e."IdNacionalidad"<br>LEFT JOIN public."ViveCon" vc ON vc."IdViveCon"=e."IdViveCon"<br>LEFT JOIN public."Discapacidad" d ON d."IdDiscapacidad"=e."IdDiscapacidad"<br>LEFT JOIN public."RRHH_Salud" s ON s."IdEmpleado"=e."IdEmpleado"<br>WHERE e."IdEmpleado"=@empleado;<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1119](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1119) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT e."FechaIngreso" AS "Fechaingreso",e."FechaAFP",e."NroAFP",e."Profesion" AS "profesion",<br> e."NumResolCese",e."FechaResolCese",e."NumResol20530",e."FechaResol20530",<br> a."DescripAFP",c."Cargo" AS "cargo",eo."AreaOrganizacional",tt."Descripcion" AS "CondicionLab"<br>FROM public."Empleado" e LEFT JOIN public."AFP" a ON a."IdAFP"=e."IdAFP"<br>LEFT JOIN public."Cargo" c ON c."IdCargo"=e."IdCargo"<br>LEFT JOIN public."TipoTrabajador" tt ON tt."IdTipoTrabajador"=e."IdTipoTrabajador"<br>LEFT JOIN public."Empleado_Area" ea ON ea."IdEmpleado"=e."IdEmpleado" AND ea."Year"=@year<br>LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=ea."Year" AND eo."idAreaOrganiz"=ea."idAreaOrganiz"<br>WHERE e."IdEmpleado"=@empleado;<br>""", employee, new PostgreSqlParameterValue("year", DateTime.Today.Year) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1143](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1143) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT ex."NomInstitucion",ex."Cargo" AS "CargoExp",ex."FechaIngreso" AS "FechaIngresoExp",<br> ex."FechaEgreso" AS "FEchaEgresoExp",ex."UnidadOrganica" AS "UnidadOrgaExp",<br> ti."DescripTipoInstitucion" AS "DescriptipoInstitucion"<br>FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"<br>WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1155](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1155) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"<br>FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"<br>WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1171](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1171) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresFamilia",<br> f."FamSexo",f."FamGradoInstruc",f."ViveCasa",f."LaboraInstitucion",tf."DescripTipoFam",ec."DescripEstCivil",<br> EXTRACT(YEAR FROM age(CURRENT_DATE,p."FechaNacimiento"))::integer AS "edadFamiliar"<br>FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"<br>LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"<br>LEFT JOIN public."EstadoCivil" ec ON ec."IdEstadoCivil"=f."IdEstadoCivil"<br>WHERE f."IdEmpleado"=@empleado ORDER BY tf."DescripTipoFam",p."Apellido_Paterno";<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1177](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1177) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio",er."AñoTermino",ee."DescripEstadoEstudio"<br>FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"<br>LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"<br>WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio";<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1186](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1186) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | "SELECT * FROM public.\"TitulosEmpleado\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"Fecha\";", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1192](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1192) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | "SELECT * FROM public.\"Capacitacion\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"FechaInicio\";", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1195](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1195) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT v."NumDormitorio",v."NumServHig",v."NumCompart",v."NumPerDorm",v."Observacion" AS "observacion",<br> v."Telefono" AS "telefono",v."Cable" AS "cable",v."Internet" AS "internet",v."Otros" AS "otros",<br> te."DescripTenencia",tv."DescripTipo" AS "DescripTipo",mv."DescripMaterial",cv."DescripConserva",<br> uv."DescripUbicacion",av."DescripAlumbrado",wv."DescripAgua" AS "descripAgua",ev."DescripExcretas"<br>FROM public."Vivienda" v LEFT JOIN public."TenenciaViv" te ON te."IdTenencia"=v."IdTenencia"<br>LEFT JOIN public."TipoViv" tv ON tv."IdTipo"=v."IdTipo"<br>LEFT JOIN public."MaterialViv" mv ON mv."IdMaterial"=v."IdMaterial"<br>LEFT JOIN public."ConservacionViv" cv ON cv."IdConservacion"=v."IdConservacion"<br>LEFT JOIN public."UbicacionViv" uv ON uv."IdUbicacion"=v."IdUbicacion"<br>LEFT JOIN public."AlumbradoViv" av ON av."IdAlumbrado"=v."IdAlumbrado"<br>LEFT JOIN public."AguaViv" wv ON wv."IdAgua"=v."IdAgua"<br>LEFT JOIN public."ExcretasViv" ev ON ev."IdExcretas"=v."IdExcretas"<br>WHERE v."IdEmpleado"=@empleado;<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1199](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1199) |
| RRHHClass.GenerarFichaPostgreSql | _database.Query | """<br>SELECT tf."DescripTipoFam",ts."DescripTS" AS "descripts",f."Enfermedad" AS "enfermedad",<br> f."TiempoEnfermedad" AS "tiempoenfermedad",f."NumAutogenSalud" AS "numautogensalud",p."NumDocID" AS "numdocid"<br>FROM public."Familiar" f JOIN public."Persona" p ON p."IdPersona"=f."IdPersona"<br>LEFT JOIN public."TipoFamiliar" tf ON tf."IdTipoFam"=f."IdTipoFam"<br>LEFT JOIN public."TipoSangre" ts ON ts."IdTipoSangre"=f."IdTipoSangre"<br>WHERE f."IdEmpleado"=@empleado;<br>""", employee | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1215](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1215) |
| RRHHClass.ObtenerIngresosEgresos | _database.Scalar | "SELECT to_regclass('public.\"Ingreso\"') IS NOT NULL AND to_regclass('public.\"Egreso\"') IS NOT NULL;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1228](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1228) |
| RRHHClass.ObtenerIngresosEgresos | _database.Query | """<br>SELECT i."Remuneracion",i."Honorarios" AS "honorarios",i."AlqPredio",i."AlqBienes",i."CapitalesColocados",<br> i."Dietas",i."Negocios",i."Otros" AS "OtrosIngresos",i."IngresoMiembros",i."NumPersonaAportan",<br> e."Alimentacion",e."Vivienda" AS "vivienda",e."Educacion" AS "educacion",e."Salud" AS "salud",<br> e."Vestido" AS "vestido",e."Recreacion" AS "recreacion",e."Prestamos" AS "prestamos",<br> e."Otros" AS "OtrosEgresos",e."Transporte" AS "transporte",e."EnergiaElec" AS "energiaelec",<br> e."Agua" AS "agua",e."BajaPolicia" AS "bajapolicia",e."Telefono" AS "telefono",<br> e."SeguroPriv" AS "seguropriv",e."TarjCredito" AS "tarjcredito"<br>FROM public."Ingreso" i FULL JOIN public."Egreso" e ON e."IdEmpleado"=i."IdEmpleado"<br>WHERE COALESCE(i."IdEmpleado",e."IdEmpleado")=@empleado;<br>""", new PostgreSqlParameterValue("empleado", empleadoId) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1234](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1234) |
| RRHHClass.ReporteOficina | _database.Query | string.Format(CultureInfo.InvariantCulture, sql, condition), all.ToArray() | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClassRRHH/ClassRRHH/RRHHClass.cs:1269](../../Software/ClassRRHH/ClassRRHH/RRHHClass.cs#L1269) |
| clsRs.clsRs | SqlCommand |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:1803](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1803) |
| clsRs.ExecSelect | SqlCommand | ReplaceTokens(cSqlSelect, cSqlParameters), oSysCn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:1939](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1939) |
| clsRs.ExecSelect | sqlCommand.ExecuteReader |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:1940](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1940) |
| clsRs.ExecInsert | SqlCommand | ReplaceTokens(cSqlInsert, cSqlParameters), oSysCn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:1972](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1972) |
| clsRs.ExecInsert | sqlCommand.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:1973](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L1973) |
| clsRs.ExecUpdate | SqlCommand | ReplaceTokens(cSqlUpdate, cSqlParameters), oSysCn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:2005](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L2005) |
| clsRs.ExecUpdate | sqlCommand.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:2006](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L2006) |
| clsRs.ExecDelete | SqlCommand | ReplaceTokens(cSqlDelete, cSqlParameters), oSysCn | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:2038](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L2038) |
| clsRs.ExecDelete | sqlCommand.ExecuteNonQuery |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/ClsCtrls/ClsCtrls/Clases.cs:2039](../../Software/ClsCtrls/ClsCtrls/Clases.cs#L2039) |
| GenericMapper.GetEntity | DataContext.ExecuteQuery&lt;TEntity&gt; | query, new object[0] | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/GenericMapper.cs:235](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L235) |
| GenericMapper.DameEntidad | DataContext.ExecuteQuery&lt;TEntity&gt; | query, new object[0] | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/GenericMapper.cs:424](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L424) |
| ucTView1T.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTView1T.cs:574](../../Software/GRLL/GRLL/Common/ucTView1T.cs#L574) |
| ucTView1T.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTView1T.cs:648](../../Software/GRLL/GRLL/Common/ucTView1T.cs#L648) |
| ucTViewNT.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTViewNT.cs:1260](../../Software/GRLL/GRLL/Common/ucTViewNT.cs#L1260) |
| ucTViewV1T.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTViewV1T.cs:588](../../Software/GRLL/GRLL/Common/ucTViewV1T.cs#L588) |
| ucTViewV1T.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTViewV1T.cs:662](../../Software/GRLL/GRLL/Common/ucTViewV1T.cs#L662) |
| ucTViewVNT.GetHijos | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucTViewVNT.cs:1269](../../Software/GRLL/GRLL/Common/ucTViewVNT.cs#L1269) |
| ucUbigeoCmb.GetDpto | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucUbigeoCmb.cs:534](../../Software/GRLL/GRLL/Common/ucUbigeoCmb.cs#L534) |
| ucUbigeoCombito.GetDpto | SqlCommand |  | Fuente recuperada GRLL; la app referencia DLL binaria, no este proyecto | [Software/GRLL/GRLL/Common/ucUbigeoCombito.cs:598](../../Software/GRLL/GRLL/Common/ucUbigeoCombito.cs#L598) |
| PostgreSqlFeriadoRepository.Listar | _database.Query | $"SELECT {IdSql} AS id, {FechaSql} AS fecha, COALESCE({MotivoSql}, '') AS motivo " +<br>			$"FROM {TablaCalificada} " +<br>			$"ORDER BY {IdSql};" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:36](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L36) |
| PostgreSqlFeriadoRepository.InsertarSiNoExisteFecha | tx.Execute | $"LOCK TABLE {TablaCalificada} IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:75](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L75) |
| PostgreSqlFeriadoRepository.Eliminar | _database.Execute | $"DELETE FROM {TablaCalificada} WHERE {IdSql} = @id;", new PostgreSqlParameterValue("id", id, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs:105](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs#L105) |
| PostgreSqlHorarioRepository.Listar | _database.Query | "SELECT " + Columnas + " FROM public.\"Horario\" ORDER BY \"idHorario\";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:23](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L23) |
| PostgreSqlHorarioRepository.Obtener | _database.Query | "SELECT " + Columnas + " FROM public.\"Horario\" WHERE \"idHorario\" = @id;", Id(id) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:30](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L30) |
| PostgreSqlHorarioRepository.Insertar | tx.Execute | "LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:44](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L44) |
| PostgreSqlHorarioRepository.Actualizar | tx.Execute | "LOCK TABLE public.\"Horario\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:78](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L78) |
| PostgreSqlHorarioRepository.Actualizar | tx.Execute | """<br>UPDATE public."Horario"<br>SET "Descrip_Horario"=@descripcion, "Ingreso1"=@ingreso1, "Salida1"=@salida1,<br>    "Ingreso2"=@ingreso2, "Salida2"=@salida2, "Estado"=@estado<br>WHERE "idHorario"=@id;<br>""", Parametros(horario).Concat(new[] { Id(horario.Id) }).ToArray() | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:80](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L80) |
| PostgreSqlHorarioRepository.Eliminar | tx.Execute | "LOCK TABLE public.\"Horario\", public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:97](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L97) |
| PostgreSqlHorarioRepository.Eliminar | tx.Execute | "DELETE FROM public.\"Horario\" WHERE \"idHorario\"=@id;", Id(id) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs:109](../../Software/RRHH.PostgreSql/Asistencia/PostgreSqlHorarioRepository.cs#L109) |
| PostgreSqlCatalogoRepository.Listar | _database.Query | $"SELECT {_id} AS id, COALESCE({_descripcion}, '') AS descripcion, {columnaExtra} AS extra " +<br>			$"FROM {_tabla} " +<br>			$"WHERE COALESCE({_descripcion}, '') ILIKE @patron ESCAPE '\\' " +<br>			$"ORDER BY {_id};", new PostgreSqlParameterValue("patron", "%" + EscaparLike(filtro) + "%") | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:44](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L44) |
| PostgreSqlCatalogoRepository.Insertar | tx.Execute | $"LOCK TABLE {_tabla} IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:75](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L75) |
| PostgreSqlCatalogoRepository.Actualizar | _database.Execute | $"UPDATE {_tabla} SET {asignaciones} WHERE {_id} = @id;", parametros.ToArray() | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:97](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L97) |
| PostgreSqlCatalogoRepository.Eliminar | tx.Execute | $"DELETE FROM {_tabla} WHERE {_id} = @id;", parametroId | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs:122](../../Software/RRHH.PostgreSql/Catalogos/PostgreSqlCatalogoRepository.cs#L122) |
| PostgreSqlMotivoPermisoRepository.Listar | _database.Query | """<br>SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",<br>       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"<br>FROM public."Motivo_Perm" AS m<br>LEFT JOIN public."TipoPermiso" AS tp ON tp."idTipoPermiso" = m."idTipoPermiso"<br>WHERE m."idTipoPermiso" = @tipo<br>  AND (@modalidad IS NULL OR m."TipoModalidad" = @modalidad)<br>ORDER BY m."Descrip_Motivo", m."idMotivo";<br>""", Param("tipo", tipoPermisoId, DbType.Int32), Param("modalidad", modalidad, DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:25](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L25) |
| PostgreSqlMotivoPermisoRepository.Obtener | _database.Query | """<br>SELECT "idMotivo", "Descrip_Motivo", "Salario", "idTipoPermiso", "Abrev", "TipoModalidad", "Activo"<br>FROM public."Motivo_Perm" WHERE "idMotivo" = @id;<br>""", Param("id", id, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:44](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L44) |
| PostgreSqlMotivoPermisoRepository.Insertar | tx.Execute | "LOCK TABLE public.\"Motivo_Perm\", public.\"TipoPermiso\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:62](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L62) |
| PostgreSqlMotivoPermisoRepository.Actualizar | tx.Execute | "LOCK TABLE public.\"Motivo_Perm\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:95](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L95) |
| PostgreSqlMotivoPermisoRepository.Actualizar | tx.Execute | """<br>UPDATE public."Motivo_Perm"<br>SET "Descrip_Motivo" = @descripcion, "Abrev" = @abreviatura, "Salario" = @salario<br>WHERE "idMotivo" = @id AND "idTipoPermiso" IS NOT DISTINCT FROM @tipo<br>  AND "TipoModalidad" IS NOT DISTINCT FROM @modalidad;<br>""", Parametros(motivo).Concat(new[] { Param("id", motivo.Id, DbType.Int32) }).ToArray() | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:97](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L97) |
| PostgreSqlMotivoPermisoRepository.Eliminar | tx.Execute | "LOCK TABLE public.\"Motivo_Perm\", public.\"Permiso\", public.\"Permiso_Aud\" IN SHARE ROW EXCLUSIVE MODE;" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:118](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L118) |
| PostgreSqlMotivoPermisoRepository.Eliminar | tx.Execute | """<br>DELETE FROM public."Motivo_Perm"<br>WHERE "idMotivo" = @id AND (@modalidad IS NULL OR "TipoModalidad" = @modalidad);<br>""", idParam, modalidadParam | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs:132](../../Software/RRHH.PostgreSql/Permisos/PostgreSqlMotivoPermisoRepository.cs#L132) |
| PostgreSqlConnectionFactory.VerifySchema | NpgsqlCommand | "SELECT to_regclass('public.\"Usuario\"') IS NOT NULL " +<br>			"AND to_regclass('public.\"Empleado\"') IS NOT NULL " +<br>			"AND to_regclass('public.\"Persona\"') IS NOT NULL " +<br>			"AND EXISTS (SELECT 1 FROM information_schema.columns " +<br>			"WHERE table_schema = 'public' AND table_name = 'Usuario' " +<br>			"AND column_name = 'PasswordHash');", connection | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:41](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L41) |
| PostgreSqlConnectionFactory.VerifySchema | command.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs:50](../../Software/RRHH.PostgreSql/PostgreSqlConnectionFactory.cs#L50) |
| PostgreSqlExecutor.Execute | command.ExecuteNonQuery |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:39](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L39) |
| PostgreSqlExecutor.Scalar | command.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:46](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L46) |
| PostgreSqlExecutor.CreateCommand | NpgsqlCommand | sql, connection, transaction | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:84](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L84) |
| PostgreSqlTransactionContext.Execute | command.ExecuteNonQuery |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:115](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L115) |
| PostgreSqlTransactionContext.Scalar | command.ExecuteScalar |  | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/PostgreSqlExecutor.cs:122](../../Software/RRHH.PostgreSql/PostgreSqlExecutor.cs#L122) |
| PostgreSqlAccesoUsuarioRepository.Autenticar | _database.Query | Sql, new PostgreSqlParameterValue("login", login.Trim(), DbType.String), new PostgreSqlParameterValue("codigoSistema", codigoSistema, DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:71](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L71) |
| PostgreSqlAccesoUsuarioRepository.EstablecerContrasena | _database.Execute | UpdatePasswordSql, new PostgreSqlParameterValue("login", login.Trim(), DbType.String), new PostgreSqlParameterValue("passwordHash", hash.Hash, DbType.String), new PostgreSqlParameterValue("passwordSalt", hash.Salt, DbType.String), new PostgreSqlParameterValue("passwordIterations", hash.Iterations, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs:108](../../Software/RRHH.PostgreSql/Seguridad/PostgreSqlAccesoUsuarioRepository.cs#L108) |
| HorarioPostgreSqlTests.HorarioPostgreSqlTests | _db.Execute | """<br>DROP TABLE IF EXISTS public."ExtraHorario", public."Empleado", public."HorarioTemporal", public."Asistencia", public."Marcacion", public."Horario" CASCADE;<br>DROP SEQUENCE IF EXISTS public.tec001_sequence;<br>CREATE TABLE public."Horario" (<br> "idHorario" integer NOT NULL, "Ingreso1" varchar(8), "Salida1" varchar(8),<br> "Ingreso2" varchar(8), "Salida2" varchar(8), "Descrip_Horario" varchar(20), "Estado" boolean, "SgtDia" boolean);<br>CREATE TABLE public."Empleado" ("idHorario" integer);<br>CREATE TABLE public."HorarioTemporal" ("HorarioAsignado" integer);<br>CREATE TABLE public."Asistencia" ("idHorario" integer);<br>CREATE TABLE public."Marcacion" ("idHorario" integer);<br>""" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:33](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L33) |
| HorarioPostgreSqlTests.TablaVaciaGeneraIdYHorasCanonicasConEstadoNulo | _db.Scalar | "SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:53](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L53) |
| HorarioPostgreSqlTests.IdentidadAlwaysNoRecibeIdExplicito | _db.Execute | "ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:60](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L60) |
| HorarioPostgreSqlTests.SecuenciaDefaultSeRespeta | _db.Execute | "CREATE SEQUENCE public.tec001_sequence START 200; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:67](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L67) |
| HorarioPostgreSqlTests.DefaultCeroRevierteElAltaParaNoConfundirlaConRegistroNuevo | _db.Execute | "ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT 0;" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:74](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L74) |
| HorarioPostgreSqlTests.SecuenciaDesalineadaSinPKRevierteInsercion | _db.Execute | "CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:83](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L83) |
| HorarioPostgreSqlTests.SecuenciaDesalineadaConPKInformaConflicto | _db.Execute | "ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE SEQUENCE public.tec001_sequence START 1; ALTER TABLE public.\"Horario\" ALTER COLUMN \"idHorario\" SET DEFAULT nextval('public.tec001_sequence');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:92](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L92) |
| HorarioPostgreSqlTests.ActualizarConservaSgtDiaYEstadoNullable | _db.Execute | "UPDATE public.\"Horario\" SET \"SgtDia\"=true WHERE \"idHorario\"=1;" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:101](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L101) |
| HorarioPostgreSqlTests.ActualizarConservaSgtDiaYEstadoNullable | _db.Scalar | "SELECT \"SgtDia\" FROM public.\"Horario\" WHERE \"idHorario\"=1;" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:103](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L103) |
| HorarioPostgreSqlTests.DatosHistoricosInvalidosSePuedenLeerParaCorregir | _db.Execute | "INSERT INTO public.\"Horario\" (\"idHorario\", \"Ingreso1\") VALUES (1, '29:00');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:111](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L111) |
| HorarioPostgreSqlTests.CadaReferenciaImpideElBorrado | _db.Execute | "INSERT INTO public." + referencia + " VALUES (1);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:124](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L124) |
| HorarioPostgreSqlTests.CadaReferenciaImpideElBorrado | _db.Execute | "TRUNCATE public.\"Empleado\", public.\"HorarioTemporal\", public.\"Asistencia\", public.\"Marcacion\";" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:127](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L127) |
| HorarioPostgreSqlTests.FKAdicionalSeTraduceARegistroEnUso | _db.Execute | "ALTER TABLE public.\"Horario\" ADD PRIMARY KEY (\"idHorario\"); CREATE TABLE public.\"ExtraHorario\" (id integer REFERENCES public.\"Horario\" (\"idHorario\")); INSERT INTO public.\"ExtraHorario\" VALUES (1);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:137](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L137) |
| HorarioPostgreSqlTests.CodigosDuplicadosNoSeActualizanNiEliminan | _db.Execute | "INSERT INTO public.\"Horario\" (\"idHorario\") VALUES (1),(1);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs:153](../../Software/RRHH.Tests/Asistencia/HorarioPostgreSqlTests.cs#L153) |
| MotivoPermisoPostgreSqlTests.MotivoPermisoPostgreSqlTests | _db.Execute | """<br>DROP TABLE IF EXISTS public."Permiso_Aud", public."Permiso", public."Motivo_Perm", public."TipoPermiso" CASCADE;<br>DROP SEQUENCE IF EXISTS public.tec004_sequence;<br>CREATE TABLE public."TipoPermiso" ("idTipoPermiso" integer NOT NULL, "DescripTipoPermiso" varchar(50));<br>CREATE TABLE public."Motivo_Perm" (<br> "idMotivo" integer NOT NULL, "Descrip_Motivo" varchar(50), "Salario" boolean,<br> "idTipoPermiso" integer, "Abrev" varchar(3), "TipoModalidad" varchar(1), "Activo" boolean);<br>CREATE TABLE public."Permiso" ("idMotivo" integer);<br>CREATE TABLE public."Permiso_Aud" ("idMotivo_Ant" integer, "idMotivo_Act" integer);<br>INSERT INTO public."TipoPermiso" VALUES (1, 'Tipo ficticio'), (2, 'Otro tipo ficticio');<br>""" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:35](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L35) |
| MotivoPermisoPostgreSqlTests.FiltroNoOcultaInactivosYRespetaTipoModalidad | _db.Execute | """<br>INSERT INTO public."Motivo_Perm" VALUES<br>(1, 'P inactivo', null, 1, null, 'P', false),<br>(2, 'C activo', true, 1, 'C', 'C', true),<br>(3, 'Sin modalidad', null, 1, null, null, null),<br>(4, 'Otro tipo', false, 2, null, 'P', true);<br>""" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:63](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L63) |
| MotivoPermisoPostgreSqlTests.ActualizarConservaEstadoModalidadYTipoInclusoSiEstadoCambio | _db.Execute | "UPDATE public.\"Motivo_Perm\" SET \"Activo\"=false WHERE \"idMotivo\"=@id;", new PostgreSqlParameterValue("id", id) | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:82](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L82) |
| MotivoPermisoPostgreSqlTests.CambioConcurrenteDeModalidadNoSeSobrescribe | _db.Execute | "UPDATE public.\"Motivo_Perm\" SET \"TipoModalidad\"='C' WHERE \"idMotivo\"=@id;", new PostgreSqlParameterValue("id", id) | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:97](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L97) |
| MotivoPermisoPostgreSqlTests.IdentidadNuevaDeTEC002SeUtilizaSinIDExplicito | _db.Execute | "ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" ADD GENERATED ALWAYS AS IDENTITY (START WITH 100);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:106](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L106) |
| MotivoPermisoPostgreSqlTests.SecuenciaDefaultDeTEC002SeUtiliza | _db.Execute | "CREATE SEQUENCE public.tec004_sequence START 200; ALTER TABLE public.\"Motivo_Perm\" ALTER COLUMN \"idMotivo\" SET DEFAULT nextval('public.tec004_sequence');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:113](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L113) |
| MotivoPermisoPostgreSqlTests.SecuenciaDesalineadaSinPKRevierteLaFilaDuplicada | _db.Execute | """<br>INSERT INTO public."Motivo_Perm" ("idMotivo", "idTipoPermiso", "Descrip_Motivo") VALUES (1, 1, 'Anterior');<br>CREATE SEQUENCE public.tec004_sequence START 1;<br>ALTER TABLE public."Motivo_Perm" ALTER COLUMN "idMotivo" SET DEFAULT nextval('public.tec004_sequence');<br>""" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:120](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L120) |
| MotivoPermisoPostgreSqlTests.TipoDuplicadoComoEnDespliegueRechazaAltaSinEscribir | _db.Execute | "INSERT INTO public.\"TipoPermiso\" VALUES (1, 'Tipo repetido');" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:133](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L133) |
| MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria | _db.Execute | "DELETE FROM public.\"Permiso\"; DELETE FROM public.\"Permiso_Aud\";" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:160](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L160) |
| MotivoPermisoPostgreSqlTests.BorradoCompruebaPermisoYAmbosLadosDeAuditoria | _db.Execute | referencia, parametro | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:161](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L161) |
| MotivoPermisoPostgreSqlTests.DuplicadosDeIDSeDiagnosticanSinModificarFilas | _db.Execute | "INSERT INTO public.\"Motivo_Perm\" (\"idMotivo\",\"idTipoPermiso\") VALUES (8,1),(8,1);" | Prueba automatizada; no flujo productivo | [Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs:180](../../Software/RRHH.Tests/Permisos/MotivoPermisoPostgreSqlTests.cs#L180) |
| spRRHH_FaltasTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_FaltasTableAdapter.cs:244](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_FaltasTableAdapter.cs#L244) |
| spRRHH_Ficha_DatosPersonalesTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_DatosPersonalesTableAdapter.cs:293](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_DatosPersonalesTableAdapter.cs#L293) |
| spRRHH_Ficha_Det_FamiliarTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_FamiliarTableAdapter.cs:241](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_FamiliarTableAdapter.cs#L241) |
| spRRHH_Ficha_Det_Familiar_SaludTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs:239](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Det_Familiar_SaludTableAdapter.cs#L239) |
| spRRHH_Ficha_Estudio_CapacitacionTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs:237](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_CapacitacionTableAdapter.cs#L237) |
| spRRHH_Ficha_Estudio_RealizadoTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs:235](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_RealizadoTableAdapter.cs#L235) |
| spRRHH_Ficha_Estudio_TituloTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_TituloTableAdapter.cs:238](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Estudio_TituloTableAdapter.cs#L238) |
| spRRHH_Ficha_ExpLabTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLabTableAdapter.cs:239](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLabTableAdapter.cs#L239) |
| spRRHH_Ficha_ExpLab_DatosTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLab_DatosTableAdapter.cs:249](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ExpLab_DatosTableAdapter.cs#L249) |
| spRRHH_Ficha_Ingreso_EgresoTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs:260](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_Ingreso_EgresoTableAdapter.cs#L260) |
| spRRHH_Ficha_ViviendaTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ViviendaTableAdapter.cs:250](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Ficha_ViviendaTableAdapter.cs#L250) |
| spRRHH_RepAsisdiarriaTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs:237](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs#L237) |
| spRRHH_RepPermisosTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs:238](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs#L238) |
| spRRHH_Rep_cargosTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs:235](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs#L235) |
| spRRHH_Rep_profesionTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs:238](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs#L238) |
| spRRHH_Report_CuadroPerTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs:241](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs#L241) |
| spRRHH_Report_CumpleTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs:240](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs#L240) |
| spRRHH_Report_FechaIngresoTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs:236](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs#L236) |
| spRRHH_Report_OficinaTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs:236](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs#L236) |
| spRRHH_busca_DisciplinaTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_busca_DisciplinaTableAdapter.cs:237](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_busca_DisciplinaTableAdapter.cs#L237) |
| QueriesTableAdapter.InitCommandCollection | SqlCommand |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs:92](../../Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs#L92) |
| QueriesTableAdapter.spRRHH_EstadisticaPermiso | sqlCommand.ExecuteScalar |  | TableAdapter SQL Server recuperado; verificar invocación por pantalla | [Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs:176](../../Software/RecursosHumanos/RecursosHumanos/DataSet_PorcentajeTableAdapters/QueriesTableAdapter.cs#L176) |
| PostgreSqlDiagnostic.TryRun | new PostgreSqlExecutor().Execute | File.ReadAllText(migrationPath) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:45](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L45) |
| PostgreSqlLegacyContext.sp_Update_Empleado_idHorario_By_idEmpleado | _database.Execute | "UPDATE public.\"Empleado\" SET \"idHorario\"=@valor WHERE \"IdEmpleado\"=@empleado;", new PostgreSqlParameterValue("valor", horario), new PostgreSqlParameterValue("empleado", empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:25](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L25) |
| PostgreSqlLegacyContext.sp_Update_Empleado_idLocal_By_idEmpleado | _database.Execute | "UPDATE public.\"Empleado\" SET \"idLocal\"=@valor WHERE \"IdEmpleado\"=@empleado;", new PostgreSqlParameterValue("valor", local), new PostgreSqlParameterValue("empleado", empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:29](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L29) |
| PostgreSqlLegacyContext.spRRHH_getMotivo_perm | _database.Query | """<br>SELECT m."idMotivo", m."Descrip_Motivo", m."Salario", m."idTipoPermiso",<br>       tp."DescripTipoPermiso", m."Abrev", m."TipoModalidad", m."Activo"<br>FROM public."Motivo_Perm" m<br>LEFT JOIN public."TipoPermiso" tp ON tp."idTipoPermiso"=m."idTipoPermiso"<br>WHERE (@tipo IS NULL OR m."idTipoPermiso"=@tipo)<br>  AND (@modalidad IS NULL OR m."TipoModalidad"=@modalidad)<br>ORDER BY m."Descrip_Motivo";<br>""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32), new PostgreSqlParameterValue("modalidad", modalidad?.ToString(), DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:33](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L33) |
| PostgreSqlLegacyContext.spRRHH_GetMinTarde | _database.Query | """<br>SELECT e."IdEmpleado",<br>       COALESCE(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'<br>         THEN GREATEST(0, EXTRACT(EPOCH FROM (a."Hor_Ent"::time-h."Ingreso1"::time))/60) ELSE 0 END),0)::integer AS "Tarde",<br>       COUNT(*) FILTER (WHERE a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND h."Ingreso1" ~ '^\d{1,2}:\d{2}'<br>         AND a."Hor_Ent"::time&gt;h."Ingreso1"::time)::integer AS "DiasTarde"<br>FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"<br>LEFT JOIN public."Horario" h ON h."idHorario"=COALESCE(a."idHorario",e."idHorario")<br>WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo<br>GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";<br>""", Date("inicio", inicio), Date("fin", fin), new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:47](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L47) |
| PostgreSqlLegacyContext.spRRHH_GetDiasAsistidos | _database.Query | """<br>SELECT e."IdEmpleado", COUNT(DISTINCT a."Fecha"::date)::integer AS "Dias_Asistidos"<br>FROM public."Empleado" e JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado"<br>WHERE a."Fecha"::date BETWEEN @inicio AND @fin AND e."IdTipoTrabajador"=@tipo<br>GROUP BY e."IdEmpleado" ORDER BY e."IdEmpleado";<br>""", Date("inicio", inicio), Date("fin", fin), new PostgreSqlParameterValue("tipo", int.Parse(tipo.ToString()), DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:60](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L60) |
| PostgreSqlLegacyContext.spRRHH_GetRecordAsistenciasSemanales | _database.Query | """<br>SELECT e."IdEmpleado", p."NumDocID",<br> btrim(concat_ws(' ',p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) AS "NombresC",<br> COUNT(DISTINCT a."Fecha"::date)::integer AS "DiasAsistidos",<br> MIN(a."Fecha"::date) AS "FechaInicio", MAX(a."Fecha"::date) AS "FechaFin",<br> ROUND(SUM(CASE WHEN a."Hor_Ent" ~ '^\d{1,2}:\d{2}' AND a."Hor_Sal" ~ '^\d{1,2}:\d{2}'<br>  THEN GREATEST(0,EXTRACT(EPOCH FROM (a."Hor_Sal"::time-a."Hor_Ent"::time))/3600) ELSE 0 END)::numeric,2) AS "HorasTrabajadas"<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>LEFT JOIN public."Asistencia" a ON a."IdEmpleado"=e."IdEmpleado" AND a."Fecha"::date BETWEEN @inicio AND @fin<br>WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo) AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>GROUP BY e."IdEmpleado",p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres"<br>ORDER BY "NombresC";<br>""", Date("inicio", inicio), Date("fin", fin), new PostgreSqlParameterValue("tipo", tipo, DbType.Int32) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:68](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L68) |
| PostgreSqlLegacyContext.spRRHH_ListarResolucion | _database.Query | """<br>SELECT tr."DescripTipoResolucion",r."FechaResolucion",r."NumeroResolucion",r."idResolucion"<br>FROM public."Resolucion" r LEFT JOIN public."TipoResolucion" tr ON tr."idTipoResolucion"=r."idTipoResolucion"<br>WHERE r."idEmpleado"=@empleado ORDER BY r."FechaResolucion" DESC;<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:85](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L85) |
| PostgreSqlLegacyContext.spRRHH_ListarRotaciones | _database.Query | """<br>SELECT r."idRotacion",r."FechaMemo",r."NroMemo",eo."AreaOrganizacional"<br>FROM public."Rotacion" r LEFT JOIN public."EstructOrganiz" eo ON eo."Year"=r."Year" AND eo."idAreaOrganiz"=r."idAreaOrganiz"<br>WHERE r."idEmpleado"=@empleado ORDER BY r."FechaMemo" DESC;<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:92](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L92) |
| PostgreSqlLegacyContext.spRRHH_buscarEstudios | _database.Query | """<br>SELECT te."DescripTipoEst",er."CentroEstudios",er."AñoInicio" AS "Añoinicio",er."AñoTermino" AS "Añotermino",<br> ee."DescripEstadoEstudio",er."IdEmpleado",er."IdTipoEstudios"<br>FROM public."EstudiosRealizado" er LEFT JOIN public."TipoEstudio" te ON te."IdTipoEstudios"=er."IdTipoEstudios"<br>LEFT JOIN public."EstadoEstudio" ee ON ee."IdEstadoEstudio"=er."IdEstadoEstudio"<br>WHERE er."IdEmpleado"=@empleado ORDER BY er."AñoInicio" DESC;<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:99](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L99) |
| PostgreSqlLegacyContext.spRRHH_BuscarExpLab | _database.Query | """<br>SELECT ti."DescripTipoInstitucion",ex."NomInstitucion",ex."Cargo",ex."FechaIngreso",ex."FechaEgreso",<br> ex."UnidadOrganica" AS "unidadOrganica",ex."IdEmpleado" AS "idEmpleado",ex."IdExpLab" AS "idExpLab"<br>FROM public."ExpLaboral" ex LEFT JOIN public."TipoInstitucion" ti ON ti."IdTipoInstitucion"=ex."IdTipoInstitucion"<br>WHERE ex."IdEmpleado"=@empleado ORDER BY ex."FechaIngreso" DESC;<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:108](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L108) |
| PostgreSqlLegacyContext.spRRHH_busca_Disciplina | _database.Query | """<br>SELECT c."idComportamiento",c."Fecha",c."IdEmpleado" AS "idEmpleado",c."NumResol",c."Titulo",c."Descripcion",tc."TipoCompDescrip"<br>FROM public."Comportamiento" c LEFT JOIN public."TipoComportamiento" tc ON tc."idTipoComportamiento"=c."idTipoComportamiento"<br>WHERE c."IdEmpleado"=@empleado ORDER BY c."Fecha" DESC;<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:116](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L116) |
| PostgreSqlLegacyContext.spRRHH_GetPeriodoLaboralByEmpleado | _database.Query | "SELECT * FROM public.\"PeriodoLaboral\" WHERE \"IdEmpleado\"=@empleado ORDER BY \"NroPeriodo\";", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:123](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L123) |
| PostgreSqlLegacyContext.spRRHH_busca_archivos | _database.Query | """<br>SELECT d."DescripDocumento",a."IdEmpleado" AS "idEmpleado",a."idDocumento",a."FechaIngreDoc",a."FechaVenDoc",a."NumRef",a."Obs"<br>FROM public."Archivo" a LEFT JOIN public."Documento" d ON d."idDocumento"=a."idDocumento"<br>WHERE a."IdEmpleado"=@empleado ORDER BY d."DescripDocumento";<br>""", Employee(empleado) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:127](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L127) |
| PostgreSqlLegacyContext.ListarEmpleados | _database.Query | $"""<br>SELECT e."IdEmpleado" AS "idEmpleado",p."NumDocID",p."Nombres",p."Apellido_Paterno",p."Apellido_Materno",{asignacion}<br>FROM public."Empleado" e JOIN public."Persona" p ON p."IdPersona"=e."IdPersona"<br>WHERE (@tipo IS NULL OR e."IdTipoTrabajador"=@tipo)<br> AND (@filtro IS NULL OR btrim(concat_ws(' ',p."NumDocID",p."Apellido_Paterno",p."Apellido_Materno",p."Nombres")) ILIKE '%'\|\|@filtro\|\|'%')<br> AND COALESCE(NULLIF(btrim(e."Estado"),''),'0')='1'<br>ORDER BY p."Apellido_Paterno",p."Apellido_Materno",p."Nombres";<br>""", new PostgreSqlParameterValue("tipo", tipo, DbType.Int32), new PostgreSqlParameterValue("filtro", string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim(), DbType.String) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:133](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L133) |
| PostgreSqlLegacyMapper.SelectAll | _database.Query | $"SELECT * FROM {QuoteTable(TableName)};" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:39](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L39) |
| PostgreSqlLegacyMapper.GetEntity | _database.Query | $"SELECT * FROM {QuoteTable(TableName)} WHERE {QuoteIdentifier(ColumnName(key))} = @id LIMIT 1;", new PostgreSqlParameterValue("id", id) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:72](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L72) |
| PostgreSqlLegacyMapper.Insert | _database.Execute | $"INSERT INTO {QuoteTable(TableName)} ({names}) VALUES ({values});", Parameters(entity, Columns) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:93](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L93) |
| PostgreSqlLegacyMapper.Update | _database.Execute | $"UPDATE {QuoteTable(TableName)} SET {assignments} WHERE {where};", Parameters(entity, parameters) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:130](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L130) |
| PostgreSqlLegacyMapper.Delete | _database.Execute | $"DELETE FROM {QuoteTable(TableName)} WHERE {BuildKeyWhere(0)};", Parameters(entity, PrimaryKeys) | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs:163](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyMapper.cs#L163) |
| ucUbigeoCmb.GetDpto | _database.Query | @"<br>SELECT ""IdUbigeo"", ""Departamento"", ""Provincia"", ""Distrito"", ""Descripcion""<br>FROM public.""Ubigeo""<br>ORDER BY ""Descripcion"";" | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs:62](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlUbigeoControl.cs#L62) |
| TreeListOperationCollapseExpandToLevel.Execute | base.Execute | node | Fuente de proyecto actual; la alcanzabilidad depende de sus llamadas | [Software/RecursosHumanos/RecursosHumanos/TreeListOperationCollapseExpandToLevel.cs:25](../../Software/RecursosHumanos/RecursosHumanos/TreeListOperationCollapseExpandToLevel.cs#L25) |

## Expresiones LINQ de sintaxis de consulta


[Software/GRLL/GRLL/Common/GenericMapper.cs:61](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L61)
```csharp
from a in EntityType.GetCustomAttributes(inherit: false)
				where a.GetType() == typeof(TableAttribute)
				select (a)
```

[Software/GRLL/GRLL/Common/GenericMapper.cs:102](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L102)
```csharp
from p in EntityType.GetProperties()
			where (from att in p.GetCustomAttributes(inherit: true)
				where att.GetType() == typeof(ColumnAttribute)
				select (att)).Count() > 0
			select (p)
```

[Software/GRLL/GRLL/Common/GenericMapper.cs:103](../../Software/GRLL/GRLL/Common/GenericMapper.cs#L103)
```csharp
from att in p.GetCustomAttributes(inherit: true)
				where att.GetType() == typeof(ColumnAttribute)
				select (att)
```
