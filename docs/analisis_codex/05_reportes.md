# 5. REPORTES

[Volver al índice](../analisis_codex.md). No se encontraron .rpt/.rdlc/.repx/.xsd en el inventario de fuentes. Hay 12 clases XtraReport y DataSets tipados recuperados como C#. No atribuir Crystal Reports/ReportViewer por el hecho de existir reportes. [Software/RecursosHumanos/RecursosHumanos.csproj:45](../../Software/RecursosHumanos/RecursosHumanos.csproj#L45).

| Reporte | Archivo / declaración |
|---|---|
| Rep_CuadroPersonal | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L15) |
| Rep_Profesion | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L15) |
| Report_Cargos | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:17](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L17) |
| Report_Cumple | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L16) |
| Report_Emple_Ingreso | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L16) |
| Report_FichaSocial_L | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L16) |
| Report_Ficha_Escalaf | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:18](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L18) |
| Report_Oficinas | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L15) |
| Report_Porcentaje | [Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:13](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L13) |
| XtraRepPermiso | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L16) |
| XtraReportFaltas | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L16) |
| XtraReportFaltas_Area | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:15](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L15) |

## Rep_CuadroPersonal

[Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L15)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Report_CuadroPer" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:791](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L791) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:792](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L792) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Report_CuadroPer.Codigo", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:574](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L574) |
| new XRBinding("Text", null, "spRRHH_Report_CuadroPer.DNI", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:586](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L586) |
| new XRBinding("Text", null, "spRRHH_Report_CuadroPer.NombresCompletos", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:598](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L598) |
| new XRBinding("Text", null, "spRRHH_Report_CuadroPer.Descripcion", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:609](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L609) |
| new XRBinding("Text", null, "spRRHH_Report_CuadroPer.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:699](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L699) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell4.Text = "XrTableCell4" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:580](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L580) |
| XrTableCell5.Text = "XrTableCell5" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:592](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L592) |
| XrTableCell6.Text = "XrTableCell6" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:604](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L604) |
| XrLabel3.Text = "XrLabel3" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:622](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L622) |
| XrTableCell1.Text = "Código" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:649](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L649) |
| XrTableCell2.Text = "Dni" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:658](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L658) |
| XrTableCell3.Text = "Nombres Completos" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:667](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L667) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:712](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L712) |
| XrLabel4.Text = "Por:" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:762](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L762) |
| XrLabel2.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:788](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L788) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_CuadroPersonal.cs#L15).

**Formulario invocante y parámetros efectivos:** FrmReportCuadro.FrmReportCuadro_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs:1760](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs#L1760)

```csharp
private void FrmReportCuadro_Load(object sender, EventArgs e)
	{
		MdiParent = MyProject.Forms.MainMDI;
		WindowState = FormWindowState.Maximized;
		Rep_CuadroPersonal rep_CuadroPersonal = new Rep_CuadroPersonal();
		rep_CuadroPersonal.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Cuadro_Pers(CodPre));
		PrintControl1.PrintingSystem = rep_CuadroPersonal.PrintingSystem;
		rep_CuadroPersonal.CreateDocument();
	}
```

## Rep_Profesion

[Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L15)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Rep_profesion" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:784](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L784) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:785](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L785) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Rep_profesion.Apellido_Paterno", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:575](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L575) |
| new XRBinding("Text", null, "spRRHH_Rep_profesion.Apellido_Materno", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:586](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L586) |
| new XRBinding("Text", null, "spRRHH_Rep_profesion.nombres", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:597](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L597) |
| new XRBinding("Text", null, "spRRHH_Rep_profesion.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:608](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L608) |
| new XRBinding("Text", null, "spRRHH_Rep_profesion.Profesion", "") | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:770](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L770) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell5.Text = "XrTableCell5" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:581](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L581) |
| XrTableCell6.Text = "XrTableCell6" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:592](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L592) |
| XrTableCell7.Text = "XrTableCell7" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:603](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L603) |
| XrTableCell8.Text = "XrTableCell8" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:614](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L614) |
| XrLabel3.Text = "Reporte de Trabajadores por Profesion" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:635](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L635) |
| XrLabel5.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:668](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L668) |
| XrLabel4.Text = "por:" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:681](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L681) |
| XrLabel2.Text = "Profesion:" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:716](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L716) |
| XrTableCell1.Text = "Apellido Paterno" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:744](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L744) |
| XrTableCell2.Text = "Apellido Materno" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:751](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L751) |
| XrTableCell4.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:758](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L758) |
| XrTableCell3.Text = "Area Organizacional" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:765](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L765) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:782](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L782) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Rep_Profesion.cs#L15).

**Formulario invocante y parámetros efectivos:** FrmReporteProfesion.Button1_Click · [Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:2035](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L2035)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		dataTable2.TableName = "spRRHH_Rep_profesion";
		checked
		{
			int num = CheckedListBoxControl1.ItemCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (CheckedListBoxControl1.GetItemChecked(num2))
				{
					dataTable = objRRHHClass.spRRHH_Rep_profesion(CheckedListBoxControl1.GetItemValue(num2).ToString());
					dataTable2.Merge(dataTable, preserveChanges: true);
				}
				num2++;
			}
			DataSet dataSet = new DataSet();
			dataTable2.DefaultView.Sort = "Profesion";
			dataSet.Tables.Add(dataTable2);
			Rep_Profesion rep_Profesion = new Rep_Profesion();
			rep_Profesion.DataSource = dataSet;
			PrintControl1.PrintingSystem = rep_Profesion.PrintingSystem;
			rep_Profesion.CreateDocument();
		}
	}
```

## Report_Cargos

[Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:17](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L17)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Rep_cargos" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:826](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L826) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:827](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L827) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Rep_cargos.Apellido_Paterno", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:610](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L610) |
| new XRBinding("Text", null, "spRRHH_Rep_cargos.Apellido_Materno", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:621](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L621) |
| new XRBinding("Text", null, "spRRHH_Rep_cargos.nombres", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:632](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L632) |
| new XRBinding("Text", null, "spRRHH_Rep_cargos.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:643](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L643) |
| new XRBinding("Text", null, "spRRHH_Rep_cargos.cargo", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:667](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L667) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell5.Text = "Apellido Paterno" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:616](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L616) |
| XrTableCell6.Text = "Apellido Materno" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:627](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L627) |
| XrTableCell7.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:638](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L638) |
| XrTableCell8.Text = "Area Organizacional" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:649](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L649) |
| XrLabel2.Text = "Cargo:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:663](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L663) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:680](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L680) |
| XrLabel3.Text = "Reporte de Trabajadores por Cargo" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:700](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L700) |
| XrLabel5.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:733](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L733) |
| XrLabel4.Text = "por:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:746](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L746) |
| XrTableCell1.Text = "Apellido Paterno" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:784](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L784) |
| XrTableCell2.Text = "Apellido Materno" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:791](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L791) |
| XrTableCell4.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:798](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L798) |
| XrTableCell3.Text = "Area Organizacional" | [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:805](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L805) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs:17](../../Software/RecursosHumanos/RecursosHumanos/Report_Cargos.cs#L17).

**Formulario invocante y parámetros efectivos:** FrmReport_Cargos.Button1_Click · [Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1962](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1962)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		dataTable2.TableName = "spRRHH_Rep_cargos";
		checked
		{
			int num = CheckedListBoxControl1.ItemCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (CheckedListBoxControl1.GetItemChecked(num2))
				{
					dataTable = objRRHHClass.generar_rep_cargos(Conversions.ToInteger(CheckedListBoxControl1.GetItemValue(num2).ToString()));
					dataTable2.Merge(dataTable);
				}
				num2++;
			}
			Report_Cargos report_Cargos = new Report_Cargos();
			report_Cargos.DataSource = dataTable2;
			PrintControl1.PrintingSystem = report_Cargos.PrintingSystem;
			report_Cargos.CreateDocument();
		}
	}
```

## Report_Cumple

[Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L16)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Report_Cumple" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:814](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L814) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:815](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L815) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Report_Cumple.Dia", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:603](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L603) |
| new XRBinding("Text", null, "spRRHH_Report_Cumple.edadEmpleado", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:618](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L618) |
| new XRBinding("Text", null, "spRRHH_Report_Cumple.NombresCompletos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:633](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L633) |
| new XRBinding("Text", null, "spRRHH_Report_Cumple.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:648](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L648) |
| new XRBinding("Text", null, "spRRHH_Report_Cumple.MESletras", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:747](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L747) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell1.Text = "XrTableCell1" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:615](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L615) |
| XrTableCell8.Text = "XrTableCell8" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:630](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L630) |
| XrTableCell2.Text = "XrTableCell2" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:645](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L645) |
| XrTableCell6.Text = "XrTableCell6" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:660](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L660) |
| XrTableCell3.Text = "Fecha" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:695](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L695) |
| XrTableCell7.Text = "Edad" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:706](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L706) |
| XrTableCell4.Text = "Apellidos y Nombres" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:717](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L717) |
| XrTableCell5.Text = "Oficina" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:728](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L728) |
| XrLabel2.Text = "Mes:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:741](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L741) |
| XrLabel3.Text = "XrLabel3" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:759](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L759) |
| XrLabel1.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:772](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L772) |
| XrLabel4.Text = "Por:" | [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:797](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L797) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Cumple.cs#L16).

**Formulario invocante y parámetros efectivos:** FrmReportCumple.FrmReportCumple_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1779](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1779)

```csharp
private void FrmReportCumple_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		MdiParent = MyProject.Forms.MainMDI;
		Report_Cumple report_Cumple = new Report_Cumple();
		if (!mostedad)
		{
			report_Cumple.XrTableCell3.Visible = false;
			report_Cumple.XrTableCell7.Text = "Fecha";
			report_Cumple.XrTableCell8.Visible = false;
			XRTableCell xrTableCell = report_Cumple.XrTableCell1;
			Rectangle bounds = new Rectangle(61, 0, 61, 25);
			xrTableCell.Bounds = bounds;
		}
		report_Cumple.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Cumples(mes));
		PrintControl1.PrintingSystem = report_Cumple.PrintingSystem;
		report_Cumple.CreateDocument();
	}
```

## Report_Emple_Ingreso

[Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L16)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Report_FechaIngreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:993](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L993) |
| DataSource = DataSet1 | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:994](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L994) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.años", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:708](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L708) |
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.meses", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:719](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L719) |
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.dias", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:730](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L730) |
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.FechadeIngreso", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:741](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L741) |
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.NombresCompletos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:757](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L757) |
| new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:944](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L944) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell4.Text = "Años" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:714](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L714) |
| XrTableCell5.Text = "Meses" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:725](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L725) |
| XrTableCell6.Text = "Dias" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:736](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L736) |
| XrLabel3.Text = "XrLabel3" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:753](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L753) |
| XrLabel2.Text = "XrLabel2" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:769](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L769) |
| XrLabel8.Text = "Por:" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:807](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L807) |
| XrLabel7.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:833](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L833) |
| XrTableCell1.Text = "Años" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:873](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L873) |
| XrTableCell2.Text = "Meses" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:880](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L880) |
| XrTableCell3.Text = "Dias" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:887](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L887) |
| XrLabel9.Text = "Tiempo de Servicio" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:901](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L901) |
| XrLabel6.Text = "Nombres Completos del Trabajador" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:914](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L914) |
| XrLabel5.Text = "Fecha de Ingreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:927](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L927) |
| XrLabel4.Text = "Oficina:" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:940](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L940) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:957](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L957) |
| XrLabel10.Text = "Reporte por Fechas deIngreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:990](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L990) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_Emple_Ingreso.cs#L16).

**Formulario invocante y parámetros efectivos:** FrmReport_Empleado_Ingre.FrmReport_Empleado_Ingre_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1769](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1769)

```csharp
private void FrmReport_Empleado_Ingre_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		MdiParent = MyProject.Forms.MainMDI;
		Report_Emple_Ingreso report_Emple_Ingreso = new Report_Emple_Ingreso();
		report_Emple_Ingreso.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Report_Emple_ficha(fi, ft, tipo));
		PrintControl1.PrintingSystem = report_Emple_Ingreso.PrintingSystem;
		report_Emple_Ingreso.CreateDocument();
	}
```

## Report_FichaSocial_L

[Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L16)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DetailReport.DataMember = "spRRHH_Ficha_ExpLab" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9294](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9294) |
| DetailReport.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9295](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9295) |
| DetailReport1.DataMember = "spRRHH_Ficha_Det_Familiar" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9654](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9654) |
| DetailReport1.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9655](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9655) |
| DetailReport2.DataMember = "spRRHH_Ficha_Ingreso_Egreso" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10794](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10794) |
| DetailReport2.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10795](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10795) |
| DetailReport3.DataMember = "spRRHH_Ficha_Vivienda" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11471](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11471) |
| DetailReport3.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11472](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11472) |
| DetailReport4.DataMember = "spRRHH_Ficha_Estudio_Realizado" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12136](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12136) |
| DetailReport4.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12137](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12137) |
| DetailReport6.DataMember = "spRRHH_Ficha_Det_Familiar_Salud" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12712](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12712) |
| DetailReport6.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12713](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12713) |
| DataMember = "spRRHH_Report_CuadroPer" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13181](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13181) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13182](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13182) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Image", null, "spRRHH_Ficha_DatosPersonales.foto", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8446](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8446) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Paterno", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8567](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8567) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Materno", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8584](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8584) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nombres", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8601](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8601) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.edadEmpleado", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8638](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8638) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.sexo", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8668](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8668) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoDoc", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8684](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8684) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8702](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8702) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaNacimiento", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8739](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8739) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DescripTS", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8771](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8771) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Telefono", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8884](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8884) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FonoCentroLab", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8899](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8899) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumCelular", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8914](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8914) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Fax", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8930](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8930) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.EstadoCivil", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8967](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8967) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdistrito", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9065](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9065) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desprovincia", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9080](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9080) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdepartamento", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9096](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9096) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.direccion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9210](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9210) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DistCasa", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9227](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9227) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ProvCasa", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9244](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9244) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.depCasa", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9261](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9261) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9331](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9331) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.CondicionLab", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9364](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9364) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.profesion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9397](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9397) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.cargo", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9430](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9430) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.LeyRegimen", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9463](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9463) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.DescripAFP", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9491](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9491) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaAFP", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9524](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9524) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NroAFP", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9552](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9552) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaIngreEstado", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9593](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9593) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.Fechaingreso", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9626](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9626) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.NombresFamilia", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9676](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9676) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.edadFamiliar", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9691](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9691) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamSexo", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9706](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9706) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripTipoFam", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9721](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9721) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamGradoInstruc", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9736](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9736) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripEstCivil", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9751](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9751) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.ViveCasa", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9778](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9778) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.LaboraInstitucion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9801](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9801) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Descripvivecon", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9957](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9957) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.JefeHogar", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10002](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10002) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.CargaFam", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10026](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10026) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Numhijos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10079](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10079) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ObsFam", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10139](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10139) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.com1", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10237](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10237) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.com2", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10283](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10283) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.afec1", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10333](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10333) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.afec2", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10379](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10379) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.decis1", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10429](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10429) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.decis2", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10475](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10475) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc1", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10521](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10521) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc2", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10571](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10571) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc3", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10617](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10617) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoFamDescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10684](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10684) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.relacParejaDescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10716](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10716) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.RelacPHDescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10748](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10748) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.RelacHermanoDescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10780](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10780) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.Alimentacion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10848](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10848) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.transporte", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10874](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10874) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.vivienda", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10904](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10904) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.energiaelec", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10930](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10930) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.educacion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10960](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10960) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.agua", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10986](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10986) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.salud", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11016](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11016) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.bajapolicia", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11042](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11042) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.vestido", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11072](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11072) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.telefono", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11098](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11098) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.recreacion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11128](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11128) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.seguropriv", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11154](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11154) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.prestamos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11184](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11184) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.OtrosEgresos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11210](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11210) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.TotalEgreso", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11243](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11243) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.NumPersonaAportan", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11258](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11258) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.IngresoMiembros", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11284](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11284) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.Remuneracion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11379](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11379) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.OtrosIngresos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11410](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11410) |
| new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.TotalIngreso", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11443](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11443) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.observacion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11512](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11512) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripUbicacion", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11554](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11554) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripAlumbrado", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11587](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11587) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.descripAgua", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11620](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11620) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripExcretas", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11653](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11653) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.telefono", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11698](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11698) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.internet", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11740](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11740) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.cable", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11782](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11782) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.otros", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11824](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11824) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumDormitorio", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11881](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11881) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumCompart", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11909](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11909) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumServHig", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11941](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11941) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumPerDorm", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11969](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11969) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripTenencia", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12009](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12009) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripTipo", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12042](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12042) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripMaterial", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12075](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12075) |
| new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripConserva", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12108](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12108) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripTipoEst", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12158](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12158) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.CentroEstudios", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12173](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12173) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.AñoInicio", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12188](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12188) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.Añotermino", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12203](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12203) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudio", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12218](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12218) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.respues1", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12376](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12376) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.respues2", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12413](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12413) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc3", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12450](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12450) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.PrincipProblemas", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12487](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12487) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.PropMejoraInstitu", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12524](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12524) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.hobby", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12561](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12561) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ActRecreaInstitu", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12598](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12598) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12628](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12628) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.numdocid", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12735](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12735) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.DescripTipoFam", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12749](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12749) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.enfermedad", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12763](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12763) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedad", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12777](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12777) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.numautogensalud", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12801](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12801) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.descripts", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12815](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12815) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.enfercronica", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12962](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12962) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.enfercronicadescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12986](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12986) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.famdiscapacidad", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13030](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13030) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.famdiscapdescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13054](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13054) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.alergico", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13098](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13098) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.alergicodescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13122](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13122) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.AcudeEnfermDescrip", "") | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13154](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13154) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrLabel3.Text = "FICHA SOCIAL" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8442](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8442) |
| XrLabel4.Text = "I. DATOS PERSONALES" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8469](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8469) |
| XrTableCell4.Text = "Apellido Paterno" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8513](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8513) |
| XrTableCell5.Text = "Apellido Materno" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8528](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8528) |
| XrTableCell6.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8543](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8543) |
| XrTableCell8.Text = "Nombres y Apellidos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8563](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8563) |
| XrTableCell9.Text = "XrTableCell9" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8580](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8580) |
| XrTableCell10.Text = "XrTableCell10" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8597](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8597) |
| XrTableCell11.Text = "XrTableCell11" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8614](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8614) |
| XrTableCell15.Text = "Edad:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8634](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8634) |
| XrTableCell16.Text = "XrTableCell16" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8651](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8651) |
| XrTableCell17.Text = "Sexo:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8664](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8664) |
| XrTableCell18.Text = "XrTableCell18" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8681](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8681) |
| XrTableCell24.Text = "XrTableCell24" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8698](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8698) |
| XrTableCell23.Text = "XrTableCell23" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8715](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8715) |
| XrTableCell14.Text = "Fecha de Nac.:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8735](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8735) |
| XrTableCell19.Text = "XrTableCell19" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8752](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8752) |
| XrTableCell55.Text = "Grupo Sanguíneo:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8767](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8767) |
| XrTableCell56.Text = "XrTableCell56" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8784](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8784) |
| XrTableCell26.Text = "Domicilio" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8816](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8816) |
| XrTableCell27.Text = "Centro Laboral" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8831](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8831) |
| XrTableCell33.Text = "Celular" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8846](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8846) |
| XrTableCell28.Text = "Otro" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8861](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8861) |
| XrTableCell29.Text = "Teléfonos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8881](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8881) |
| XrTableCell30.Text = "XrTableCell30" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8896](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8896) |
| XrTableCell31.Text = "XrTableCell31" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8911](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8911) |
| XrTableCell34.Text = "XrTableCell34" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8926](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8926) |
| XrTableCell32.Text = "XrTableCell32" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8943](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8943) |
| XrTableCell35.Text = "Estado Civil:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8963](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8963) |
| XrTableCell36.Text = "XrTableCell36" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:8980](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L8980) |
| XrTableCell41.Text = "Distrito" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9012](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9012) |
| XrTableCell42.Text = "Provincia" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9027](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9027) |
| XrTableCell43.Text = "Departamento" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9042](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9042) |
| XrTableCell98.Text = "Lugar de Nacimiento:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9062](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9062) |
| XrTableCell99.Text = "XrTableCell99" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9077](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9077) |
| XrTableCell100.Text = "XrTableCell100" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9092](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9092) |
| XrTableCell101.Text = "XrTableCell101" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9109](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9109) |
| XrTableCell2.Text = "Calle,Jirón, Av." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9141](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9141) |
| XrTableCell3.Text = "Distrito" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9156](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9156) |
| XrTableCell12.Text = "Provincia" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9171](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9171) |
| XrTableCell13.Text = "Departamento" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9186](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9186) |
| XrTableCell45.Text = "Dirección:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9206](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9206) |
| XrTableCell46.Text = "XrTableCell46" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9223](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9223) |
| XrTableCell47.Text = "XrTableCell47" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9240](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9240) |
| XrTableCell48.Text = "XrTableCell48" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9257](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9257) |
| XrTableCell49.Text = "XrTableCell49" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9274](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9274) |
| XrTableCell52.Text = "Lugar de Trabajo:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9328](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9328) |
| XrTableCell102.Text = "XrTableCell102" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9343](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9343) |
| XrTableCell109.Text = "Condición Laboral:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9361](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9361) |
| XrTableCell110.Text = "XrTableCell110" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9376](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9376) |
| XrTableCell105.Text = "Profesión u ocupación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9394](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9394) |
| XrTableCell106.Text = "XrTableCell106" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9409](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9409) |
| XrTableCell103.Text = "Cargo que desempeña o labor que realiza:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9427](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9427) |
| XrTableCell104.Text = "XrTableCell104" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9442](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9442) |
| XrTableCell113.Text = "Reg. Pensión:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9460](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9460) |
| XrTableCell114.Text = "XrTableCell114" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9475](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9475) |
| XrTableCell115.Text = "AFP:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9488](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9488) |
| XrTableCell116.Text = "XrTableCell116" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9503](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9503) |
| XrTableCell117.Text = "Fecha Inscrip. AFP:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9521](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9521) |
| XrTableCell118.Text = "XrTableCell118" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9536](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9536) |
| XrTableCell119.Text = "Num CUSPP:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9549](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9549) |
| XrTableCell120.Text = "XrTableCell120" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9564](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9564) |
| XrTableCell83.Text = "Fecha de Ingreso al Estado:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9590](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9590) |
| XrTableCell71.Text = "XrTableCell71" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9605](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9605) |
| XrTableCell80.Text = "Fecha de Ingreso a la Institución:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9623](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9623) |
| XrTableCell84.Text = "XrTableCell84" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9638](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9638) |
| XrLabel5.Text = "III. ASPECTO LABORAL DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9651](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9651) |
| XrTableCell137.Text = "XrTableCell137" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9688](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9688) |
| XrTableCell138.Text = "XrTableCell138" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9703](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9703) |
| XrTableCell143.Text = "XrTableCell143" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9718](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9718) |
| XrTableCell144.Text = "XrTableCell144" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9733](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9733) |
| XrTableCell145.Text = "XrTableCell145" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9748](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9748) |
| XrTableCell146.Text = "XrTableCell146" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9763](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9763) |
| XrTableCell163.Text = "Nombres y Apellidos" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9838](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9838) |
| XrTableCell164.Text = "Edad" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9849](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9849) |
| XrTableCell165.Text = "Sexo" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9860](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9860) |
| XrTableCell166.Text = "Parentesco" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9871](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9871) |
| XrTableCell167.Text = "Grado de Inst." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9882](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9882) |
| XrTableCell168.Text = "E.Civil" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9893](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9893) |
| XrTableCell169.Text = "Vive en Casa" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9904](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9904) |
| XrTableCell133.Text = "Lab. Instit." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9915](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9915) |
| XrLabel7.Text = "4.1 Composición Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9928](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9928) |
| XrTableCell111.Text = "¿Con quién vives actualmente?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9954](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9954) |
| XrTableCell112.Text = "XrTableCell112" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9969](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9969) |
| XrTableCell74.Text = "¿Eres Jefe de Hogar?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:9987](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L9987) |
| XrTableCell95.Text = "Carga Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10023](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10023) |
| XrTableCell96.Text = "XrTableCell96" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10038](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10038) |
| XrTableCell129.Text = "Hijos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10076](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10076) |
| XrTableCell130.Text = "XrTableCell130" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10091](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10091) |
| XrLabel6.Text = "IV. ASPECTO SOCIO-FAMILIAR DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10104](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10104) |
| XrTableCell258.Text = "Observación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10135](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10135) |
| XrTableCell57.Text = "Resp." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10199](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10199) |
| XrTableCell226.Text = "COMUNICACIÓN" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10219](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10219) |
| XrTableCell227.Text = "Es verbal, Fluida y Abierta en todas las Situaciones" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10233](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10233) |
| XrTableCell121.Text = "Solo cuando hay dificultades" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10279](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10279) |
| XrTableCell89.Text = "AFECTIVIDAD" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10315](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10315) |
| XrTableCell90.Text = "Se brindan abrazos, besos, palabras cariñosas" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10329](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10329) |
| XrTableCell85.Text = "Se aceptan y toleran entre sí" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10375](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10375) |
| XrTableCell76.Text = "TOMA DE DECISIONES" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10411](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10411) |
| XrTableCell77.Text = "Ante un problema todos participan en la Solución" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10425](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10425) |
| XrTableCell70.Text = "Ante un problema solo los padres buscan la Solución" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10471](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10471) |
| XrTableCell58.Text = "Participan en Clubs, Juntas Vecinales y Otros." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10517](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10517) |
| XrTableCell60.Text = "SOCIALIZACIÓN" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10553](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10553) |
| XrTableCell61.Text = "Realizan sus Propias actividades familiares" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10567](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10567) |
| XrTableCell64.Text = "Buena relaciones con amigos y vecinos." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10613](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10613) |
| XrLabel14.Text = "4.2 Dinámica Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10642](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10642) |
| XrLabel8.Text = "4.3 Funcionamiento Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10655](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10655) |
| XrTableCell20.Text = "Tipo de Familia:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10681](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10681) |
| XrTableCell53.Text = "Relación de Pareja:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10713](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10713) |
| XrTableCell44.Text = "Relación Padres - Hijos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10745](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10745) |
| XrTableCell37.Text = "Relación entre Hermanos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10777](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10777) |
| XrTableCell127.Text = "Egresos" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10828](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10828) |
| XrTableCell229.Text = "Alimentación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10845](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10845) |
| XrTableCell230.Text = "XrTableCell147" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10860](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10860) |
| XrTableCell154.Text = "Transporte:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10871](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10871) |
| XrTableCell233.Text = "Vivienda:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10901](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10901) |
| XrTableCell234.Text = "XrTableCell151" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10916](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10916) |
| XrTableCell155.Text = "Energía Eléctrica:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10927](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10927) |
| XrTableCell237.Text = "Educación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10957](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10957) |
| XrTableCell238.Text = "XrTableCell155" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10972](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10972) |
| XrTableCell156.Text = "Agua:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:10983](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L10983) |
| XrTableCell241.Text = "Salud:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11013](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11013) |
| XrTableCell242.Text = "XrTableCell159" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11028](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11028) |
| XrTableCell157.Text = "Baja Policía:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11039](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11039) |
| XrTableCell245.Text = "Vestido:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11069](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11069) |
| XrTableCell246.Text = "XrTableCell170" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11084](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11084) |
| XrTableCell158.Text = "Teléfono:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11095](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11095) |
| XrTableCell249.Text = "Recreación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11125](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11125) |
| XrTableCell250.Text = "XrTableCell174" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11140](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11140) |
| XrTableCell159.Text = "Seguro Privado:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11151](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11151) |
| XrTableCell253.Text = "Tarjetas de Crédito:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11181](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11181) |
| XrTableCell254.Text = "XrTableCell178" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11196](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11196) |
| XrTableCell160.Text = "Otros gastos personales:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11207](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11207) |
| XrTableCell150.Text = "XrTableCell150" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11222](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11222) |
| XrTableCell261.Text = "Total de Egresos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11240](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11240) |
| XrTableCell262.Text = "XrTableCell186" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11255](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11255) |
| XrLabel13.Text = "XrLabel13" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11270](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11270) |
| XrLabel12.Text = "Nº de personas que aportan económicamente en la manutención de la familia:  Nº" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11281](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11281) |
| XrLabel11.Text = "XrLabel11" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11296](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11296) |
| XrLabel10.Text = "Monto de ingresos generados por otros miembros de la familia:  S/." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11307](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11307) |
| XrLabel9.Text = "5.2 Ingresos de la familia" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11320](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11320) |
| XrLabel2.Text = "5.1  Ingresos y egresos del trabjador:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11333](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11333) |
| XrTableCell126.Text = "Ingresos" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11359](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11359) |
| XrTableCell140.Text = "Remuneración:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11376](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11376) |
| XrTableCell141.Text = "XrTableCell141" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11391](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11391) |
| XrTableCell179.Text = "Otros Ingresos" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11407](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11407) |
| XrTableCell180.Text = "XrTableCell180" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11422](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11422) |
| XrTableCell183.Text = "Total de Ingresos:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11440](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11440) |
| XrTableCell184.Text = "XrTableCell184" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11455](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11455) |
| XrLabel1.Text = "VII. ASPECTO ECONÓMICO" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11468](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11468) |
| XrTableCell240.Text = "Observaciones:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11508](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11508) |
| XrTableCell257.Text = "XrTableCell257" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11525](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11525) |
| XrTableCell195.Text = "Ubicacion:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11551](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11551) |
| XrTableCell196.Text = "XrTableCell196" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11566](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11566) |
| XrTableCell197.Text = "Alumbrado:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11584](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11584) |
| XrTableCell198.Text = "XrTableCell198" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11599](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11599) |
| XrTableCell199.Text = "Abastecimiento de Agua:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11617](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11617) |
| XrTableCell200.Text = "XrTableCell200" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11632](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11632) |
| XrTableCell201.Text = "Eliminacion de Excretas:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11650](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11650) |
| XrTableCell202.Text = "XrTableCell202" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11665](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11665) |
| XrTableCell243.Text = "Teléfono:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11683](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11683) |
| XrCheckBoxFono.Text = "Si" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11707](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11707) |
| XrTableCell251.Text = "Internet:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11725](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11725) |
| XrCheckBoxInter.Text = "Si" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11749](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11749) |
| XrTableCell247.Text = "Cable:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11767](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11767) |
| XrCheckBoxCable.Text = "Si" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11791](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11791) |
| XrTableCell255.Text = "Otros:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11809](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11809) |
| XrCheckBoxOtros.Text = "Si" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11833](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11833) |
| XrTableCell212.Text = "Distribución" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11859](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11859) |
| XrTableCell210.Text = "Dormitorios N°:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11878](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11878) |
| XrTableCell211.Text = "XrTableCell211" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11893](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11893) |
| XrTableCell206.Text = "Compartimientos Nº" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11906](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11906) |
| XrTableCell213.Text = "Servicios Higienicos N°" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11938](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11938) |
| XrTableCell214.Text = "XrTableCell214" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11953](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11953) |
| XrTableCell207.Text = "Personas por Dorm. Nº" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:11966](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L11966) |
| XrTableCell187.Text = "Tenencia:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12006](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12006) |
| XrTableCell188.Text = "XrTableCell188" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12021](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12021) |
| XrTableCell189.Text = "Tipo:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12039](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12039) |
| XrTableCell190.Text = "XrTableCell190" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12054](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12054) |
| XrTableCell191.Text = "Material:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12072](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12072) |
| XrTableCell192.Text = "XrTableCell192" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12087](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12087) |
| XrTableCell193.Text = "Condiciones de Conservación:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12105](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12105) |
| XrTableCell194.Text = "XrTableCell194" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12120](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12120) |
| XrLabel15.Text = "V. ASPECTO DE VIVIENDA" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12133](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12133) |
| XrTableCell220.Text = "Tipo de Estudio" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12170](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12170) |
| XrTableCell221.Text = "Centro de Estudios" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12185](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12185) |
| XrTableCell222.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12200](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12200) |
| XrTableCell223.Text = "Fecha de Termino" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12215](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12215) |
| XrTableCell224.Text = "Estado" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12230](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12230) |
| XrTableCell215.Text = "Tipo de Estudio" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12259](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12259) |
| XrTableCell216.Text = "Centro de Estudios" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12270](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12270) |
| XrTableCell217.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12281](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12281) |
| XrTableCell218.Text = "Fecha de Termino" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12292](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12292) |
| XrTableCell219.Text = "Estado" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12303](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12303) |
| XrLabel18.Text = "2.1  Estudios Realizados:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12316](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12316) |
| XrLabel17.Text = "II. ASPECTO EDUCATIVO" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12329](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12329) |
| XrTableCell88.Text = "¿Se lleva bien con sus compañeros de Trabajo?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12368](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12368) |
| XrTableCell93.Text = "¿Cómo se siente en su ámbito laboral?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12405](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12405) |
| XrTableCell75.Text = "En general, ¿Cómo se siente tratado por su superior inmediato?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12442](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12442) |
| XrTableCell124.Text = "¿Cuáles son los principales problemas conocidos por UD. que existen en la Institución?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12479](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12479) |
| XrTableCell92.Text = "¿Qué propone usted para mejorar esas situaciones problemáticas en su institución?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12516](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12516) |
| XrTableCell87.Text = "¿Cuál es su Hobby?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12553](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12553) |
| XrTableCell73.Text = "¿Qué actividades recreativas le gustaría realizar en el Centro de Trabajo?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12590](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12590) |
| XrLabel16.Text = "VIII. ASPECTO SOCIO / RECREATIVO" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12622](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12622) |
| XrLabel24.Text = "XrLabel24" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12640](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12640) |
| XrLabel23.Text = "DNI:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12651](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12651) |
| XrLabel22.Text = "Fecha:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12674](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12674) |
| XrLabel21.Text = "Firma de la Trabajadora Social" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12699](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12699) |
| XrLabel20.Text = "Firma del Trabajador" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12710](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12710) |
| XrTableCell177.Text = "DNI" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12855](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12855) |
| XrTableCell203.Text = "Parentesco" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12866](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12866) |
| XrTableCell185.Text = "Enfermedad" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12877](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12877) |
| XrTableCell181.Text = "Tiempo" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12888](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12888) |
| XrTableCell182.Text = "Seguro" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12899](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12899) |
| XrTableCell186.Text = "N° Autogen." | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12910](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12910) |
| XrTableCell204.Text = "Tipo Sangre" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12921](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12921) |
| XrTableCell128.Text = "Enfermedad Crónica o Discapacidad:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12947](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12947) |
| XrTableCell152.Text = "Mencione:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:12983](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L12983) |
| XrTableCell161.Text = "Miembros de su Familia con Discapacidad:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13015](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13015) |
| XrTableCell170.Text = "Mencione:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13051](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13051) |
| XrTableCell172.Text = "Es Alérgico a algún medicamento?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13083](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13083) |
| XrTableCell174.Text = "Mencione:" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13119](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13119) |
| XrTableCell176.Text = "Donde Acude en Caso de Enfermedad?" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13151](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13151) |
| XrLabel19.Text = "VI. ASPECTO SALUD" | [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:13178](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L13178) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs:16](../../Software/RecursosHumanos/RecursosHumanos/Report_FichaSocial_L.cs#L16).

**Formulario invocante y parámetros efectivos:** FrmReportFicha.FrmReportFicha_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1766](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1766)

```csharp
private void FrmReportFicha_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		MdiParent = MyProject.Forms.MainMDI;
		if (RRHH.Bienestar)
		{
			Report_FichaSocial_L report_FichaSocial_L = new Report_FichaSocial_L();
			report_FichaSocial_L.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Ficha_Prueba(Codempleado));
			PrintControl1.PrintingSystem = report_FichaSocial_L.PrintingSystem;
			report_FichaSocial_L.CreateDocument();
		}
		else
		{
			Report_Ficha_Escalaf report_Ficha_Escalaf = new Report_Ficha_Escalaf();
			report_Ficha_Escalaf.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Ficha_Prueba(Codempleado));
			PrintControl1.PrintingSystem = report_Ficha_Escalaf.PrintingSystem;
			report_Ficha_Escalaf.CreateDocument();
		}
	}
```

## Report_Ficha_Escalaf

[Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:18](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L18)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DetailReport.DataMember = "spRRHH_Ficha_ExpLab" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6621](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6621) |
| DetailReport.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6622](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6622) |
| DetailReport1.DataMember = "spRRHH_Ficha_Det_Familiar" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7319](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7319) |
| DetailReport1.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7320](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7320) |
| DetailReport2.DataMember = "spRRHH_Ficha_Estudio_Realizado" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7753](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7753) |
| DetailReport2.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7754](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7754) |
| DetailReport3.DataMember = "spRRHH_Ficha_Estudio_Titulo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7932](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7932) |
| DetailReport3.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7933](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7933) |
| DetailReport4.DataMember = "spRRHH_Ficha_Estudio_Capacitacion" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8080](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8080) |
| DetailReport4.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8081](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8081) |
| DetailReport5.DataMember = "spRRHH_busca_Disciplina" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8252](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8252) |
| DetailReport5.DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8253](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8253) |
| DataMember = "spRRHH_Ficha_DatosPersonales" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8388](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8388) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8389](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8389) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.idempleado") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5759](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5759) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaRegistro", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5785](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5785) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Paterno") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5897](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5897) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Materno") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5909](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5909) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nombres") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5921](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5921) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.edadEmpleado") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5949](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5949) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.sexo") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5970](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5970) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoDoc") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5982](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5982) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5995](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5995) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumLibretaMilitar") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6023](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6023) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumRUC") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6044](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6044) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.brevete") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6072](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6072) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DescripTS") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6093](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6093) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nacionalidad") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6121](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6121) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaNacimiento", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6142](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6142) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Telefono") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6217](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6217) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FonoCentroLab") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6229](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6229) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumCelular") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6241](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6241) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Fax") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6253](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6253) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.EstadoCivil") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6281](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6281) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Discapacidad") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6302](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6302) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.gradoInstruccion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6330](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6330) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdistrito") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6396](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6396) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desprovincia") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6407](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6407) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdepartamento") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6419](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6419) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.direccion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6497](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6497) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DistCasa") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6509](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6509) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ProvCasa") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6521](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6521) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.depCasa") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6533](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6533) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.foto") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6544](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6544) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.DescriptipoInstitucion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6658](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6658) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.NomInstitucion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6669](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6669) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.CargoExp") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6680](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6680) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.UnidadOrgaExp") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6691](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6691) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.FechaIngresoExp", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6702](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6702) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.FEchaEgresoExp", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6713](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6713) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.AreaOrganizacional") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6771](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6771) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.CondicionLab") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6797](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6797) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.profesion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6823](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6823) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.cargo") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6849](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6849) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumAutogenSalud") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6875](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6875) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.LeyRegimen") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6901](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6901) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.DescripAFP") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6920](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6920) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaAFP", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6946](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6946) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NroAFP") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6965](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6965) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResoIngreEsta") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7018](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7018) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaIngreEstado", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7037](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7037) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResoIngreInstitu") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7063](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7063) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResol20530") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7124](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7124) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResol20530", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7143](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7143) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResolCese") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7169](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7169) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResolCese", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7188](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7188) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResolPenMen") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7215](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7215) |
| new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResolPenMen", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7234](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7234) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.NombresFamilia") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7355](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7355) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.edadFamiliar") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7366](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7366) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamSexo") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7377](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7377) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripTipoFam") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7388](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7388) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamGradoInstruc") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7399](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7399) |
| new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripEstCivil") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7410](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7410) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.ViveCasa") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7430](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7430) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.LaboraInstitucion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7453](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7453) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Descripvivecon") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7590](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7590) |
| new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.JefeHogar") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7625](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7625) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.CargaFam") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7647](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7647) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Numhijos") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7685](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7685) |
| new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ObsFam") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7743](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7743) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripTipoEst") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7790](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7790) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.CentroEstudios") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7801](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7801) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.AñoInicio", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7812](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7812) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.Añotermino", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7823](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7823) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudio") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7834](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7834) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.NumColegiatura") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7969](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7969) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.DenominacionGrado") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7980](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7980) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.Institucion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7991](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7991) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.Fecha", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8002](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8002) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.NombreCurso") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8117](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8117) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.FechaInicio", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8128](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8128) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.FechaFin", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8139](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8139) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.NumHoras") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8150](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8150) |
| new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadora") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8161](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8161) |
| new XRBinding("Text", null, "spRRHH_busca_Disciplina.TipoCompDescrip") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8272](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8272) |
| new XRBinding("Text", null, "spRRHH_busca_Disciplina.Fecha", "{0:MM/dd/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8279](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8279) |
| new XRBinding("Text", null, "spRRHH_busca_Disciplina.NumResol") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8286](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8286) |
| new XRBinding("Text", null, "spRRHH_busca_Disciplina.Titulo") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8293](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8293) |
| new XRBinding("Text", null, "spRRHH_busca_Disciplina.Descripcion") | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8300](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8300) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell122.Text = "Cod. Sistema:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5754](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5754) |
| XrTableCell127.Text = "XrTableCell127" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5765](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5765) |
| XrTableCell123.Text = "Fecha de Inscrip.:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5780](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5780) |
| XrTableCell126.Text = "XrTableCell126" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5791](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5791) |
| XrLabel8.Text = "I. IDENTIFICACION" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5805](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5805) |
| XrLabel4.Text = "II. DATOS PERSONALES DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5818](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5818) |
| XrTableCell4.Text = "Apellido Paterno" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5857](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5857) |
| XrTableCell5.Text = "Apellido Materno" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5866](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5866) |
| XrTableCell6.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5875](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5875) |
| XrTableCell8.Text = "Nombres y Apellidos:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5891](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5891) |
| XrTableCell9.Text = "XrTableCell9" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5903](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5903) |
| XrTableCell10.Text = "XrTableCell10" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5915](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5915) |
| XrTableCell11.Text = "XrTableCell11" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5927](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5927) |
| XrTableCell15.Text = "Edad:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5943](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5943) |
| XrTableCell16.Text = "XrTableCell16" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5955](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5955) |
| XrTableCell17.Text = "Sexo:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5964](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5964) |
| XrTableCell18.Text = "XrTableCell18" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5976](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5976) |
| XrTableCell24.Text = "XrTableCell24" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:5989](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L5989) |
| XrTableCell23.Text = "XrTableCell23" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6001](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6001) |
| XrTableCell14.Text = "Nº Libreta Militar:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6017](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6017) |
| XrTableCell44.Text = "XrTableCell44" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6029](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6029) |
| XrTableCell50.Text = "Nº RUC:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6038](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6038) |
| XrTableCell51.Text = "XrTableCell51" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6050](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6050) |
| XrTableCell53.Text = "Nº de Brevete:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6066](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6066) |
| XrTableCell54.Text = "XrTableCell54" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6078](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6078) |
| XrTableCell55.Text = "Grupo Sanguíneo:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6087](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6087) |
| XrTableCell56.Text = "XrTableCell56" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6099](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6099) |
| XrTableCell19.Text = "Nacionalidad:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6115](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6115) |
| XrTableCell20.Text = "XrTableCell20" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6127](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6127) |
| XrTableCell21.Text = "Fecha de Nac.:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6136](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6136) |
| XrTableCell22.Text = "XrTableCell22" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6148](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6148) |
| XrTableCell26.Text = "Domicilio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6170](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6170) |
| XrTableCell27.Text = "Centro Laboral" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6178](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6178) |
| XrTableCell33.Text = "Celular" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6186](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6186) |
| XrTableCell28.Text = "Otro" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6195](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6195) |
| XrTableCell29.Text = "Teléfonos:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6211](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6211) |
| XrTableCell30.Text = "XrTableCell30" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6223](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6223) |
| XrTableCell31.Text = "XrTableCell31" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6235](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6235) |
| XrTableCell34.Text = "XrTableCell34" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6247](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6247) |
| XrTableCell32.Text = "XrTableCell32" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6259](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6259) |
| XrTableCell35.Text = "Estado Civil:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6275](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6275) |
| XrTableCell36.Text = "XrTableCell36" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6287](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6287) |
| XrTableCell37.Text = "Discapacidad:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6296](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6296) |
| XrTableCell38.Text = "XrTableCell38" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6308](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6308) |
| XrTableCell39.Text = "Grado de Instrucción:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6324](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6324) |
| XrTableCell97.Text = "XrTableCell97" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6336](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6336) |
| XrTableCell41.Text = "Distrito" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6358](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6358) |
| XrTableCell42.Text = "Provincia" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6366](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6366) |
| XrTableCell43.Text = "Departamento" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6375](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6375) |
| XrTableCell98.Text = "Lugar de Nacimiento:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6391](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6391) |
| XrTableCell99.Text = "XrTableCell99" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6402](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6402) |
| XrTableCell100.Text = "XrTableCell100" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6413](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6413) |
| XrTableCell101.Text = "XrTableCell101" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6425](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6425) |
| XrTableCell2.Text = "Calle,Jirón, Av." | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6448](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6448) |
| XrTableCell3.Text = "Distrito" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6457](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6457) |
| XrTableCell12.Text = "Provincia" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6466](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6466) |
| XrTableCell13.Text = "Departamento" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6475](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6475) |
| XrTableCell45.Text = "Dirección:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6491](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6491) |
| XrTableCell46.Text = "XrTableCell46" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6503](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6503) |
| XrTableCell47.Text = "XrTableCell47" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6515](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6515) |
| XrTableCell48.Text = "XrTableCell48" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6527](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6527) |
| XrTableCell49.Text = "XrTableCell49" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6539](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6539) |
| XrLabel2.Text = "XrLabel2" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6556](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6556) |
| XrLabel1.Text = "Ficha Escalafonaria" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6569](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6569) |
| XrLabel9.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6605](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6605) |
| XrTableCell63.Text = "Tipo de Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6664](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6664) |
| XrTableCell64.Text = "Nombre de la Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6675](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6675) |
| XrTableCell65.Text = "Cargo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6686](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6686) |
| XrTableCell66.Text = "Unidad Organica" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6697](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6697) |
| XrTableCell67.Text = "Fecha Ingreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6708](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6708) |
| XrTableCell68.Text = "Fecha Egreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6719](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6719) |
| XrLabel5.Text = "III. ASPECTO LABORAL DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6740](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6740) |
| XrTableCell52.Text = "Lugar de Trabajo:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6766](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6766) |
| XrTableCell102.Text = "XrTableCell102" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6777](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6777) |
| XrTableCell109.Text = "Condición Laboral:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6792](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6792) |
| XrTableCell110.Text = "XrTableCell110" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6803](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6803) |
| XrTableCell105.Text = "Profesión u ocupación:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6818](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6818) |
| XrTableCell106.Text = "XrTableCell106" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6829](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6829) |
| XrTableCell103.Text = "Cargo que desempeña o labor que realiza:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6844](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6844) |
| XrTableCell104.Text = "XrTableCell104" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6855](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6855) |
| XrTableCell72.Text = "Nº Autogenerado de Salud:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6870](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6870) |
| XrTableCell73.Text = "XrTableCell73" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6881](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6881) |
| XrTableCell113.Text = "Reg. Pensión:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6896](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6896) |
| XrTableCell114.Text = "XrTableCell114" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6907](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6907) |
| XrTableCell115.Text = "AFP:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6915](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6915) |
| XrTableCell116.Text = "XrTableCell116" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6926](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6926) |
| XrTableCell117.Text = "Fecha Inscrip. AFP:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6941](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6941) |
| XrTableCell118.Text = "XrTableCell118" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6952](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6952) |
| XrTableCell119.Text = "Num CUSPP:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6960](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6960) |
| XrTableCell120.Text = "XrTableCell120" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6971](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6971) |
| XrTableCell69.Text = "PARA EL PERSONAL ACTIVO" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:6998](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L6998) |
| XrTableCell81.Text = "Nº Resolución de Ingreso al Estado:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7013](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7013) |
| XrTableCell82.Text = "XrTableCell82" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7024](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7024) |
| XrTableCell83.Text = "Fecha de Ingreso al Estado:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7032](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7032) |
| XrTableCell71.Text = "XrTableCell71" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7043](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7043) |
| XrTableCell78.Text = "Nº Resolución de Ingreso a la Institución:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7058](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7058) |
| XrTableCell79.Text = "XrTableCell79" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7069](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7069) |
| XrTableCell70.Text = "PARA EL PERSONAL PENSIONISTA" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7103](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7103) |
| XrTableCell75.Text = "Nº Resolución de Incorporación a la 20530:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7119](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7119) |
| XrTableCell76.Text = "XrTableCell76" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7130](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7130) |
| XrTableCell77.Text = "Fecha de Incorporación a la 20530:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7138](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7138) |
| XrTableCell85.Text = "XrTableCell85" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7149](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7149) |
| XrTableCell86.Text = "Nº Resolución de Cese" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7164](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7164) |
| XrTableCell87.Text = "XrTableCell87" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7175](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7175) |
| XrTableCell88.Text = "Fecha de Cese:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7183](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7183) |
| XrTableCell89.Text = "XrTableCell89" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7194](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7194) |
| XrTableCell90.Text = "Nº Resolución de Pensionista Mensual - Cesantía" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7210](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7210) |
| XrTableCell91.Text = "XrTableCell91" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7221](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7221) |
| XrTableCell92.Text = "Fecha de Pensión Mensual - Cesantía:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7229](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7229) |
| XrTableCell93.Text = "XrTableCell93" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7240](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7240) |
| XrLabel14.Text = "Experiencia Laboral:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7254](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7254) |
| XrTableCell57.Text = "Tipo de Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7280](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7280) |
| XrTableCell58.Text = "Nombre de la Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7287](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7287) |
| XrTableCell59.Text = "Cargo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7294](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7294) |
| XrTableCell60.Text = "Unidad Organica" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7301](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7301) |
| XrTableCell61.Text = "Fecha Ingreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7308](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7308) |
| XrTableCell62.Text = "Fecha Egreso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7315](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7315) |
| XrTableCell137.Text = "XrTableCell137" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7361](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7361) |
| XrTableCell138.Text = "XrTableCell138" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7372](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7372) |
| XrTableCell143.Text = "XrTableCell143" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7383](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7383) |
| XrTableCell144.Text = "XrTableCell144" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7394](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7394) |
| XrTableCell145.Text = "XrTableCell145" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7405](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7405) |
| XrTableCell146.Text = "XrTableCell146" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7416](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7416) |
| XrTableCell131.Text = "XrTableCell131" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7425](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7425) |
| XrTableCell132.Text = "XrTableCell132" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7448](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7448) |
| XrTableCell163.Text = "Nombres y Apellidos" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7496](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7496) |
| XrTableCell164.Text = "Edad" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7503](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7503) |
| XrTableCell165.Text = "Sexo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7510](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7510) |
| XrTableCell166.Text = "Parentesco" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7517](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7517) |
| XrTableCell167.Text = "Grado de Inst." | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7524](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7524) |
| XrTableCell168.Text = "E.Civil" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7531](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7531) |
| XrTableCell169.Text = "Vive en Casa" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7538](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7538) |
| XrTableCell133.Text = "Lab. Instit." | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7545](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7545) |
| XrLabel7.Text = "4.5 Composición Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7559](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7559) |
| XrTableCell111.Text = "¿Con quién vives actualmente?" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7585](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7585) |
| XrTableCell112.Text = "XrTableCell112" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7596](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7596) |
| XrTableCell74.Text = "¿Eres Jefe de Hogar?" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7611](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7611) |
| XrTableCell94.Text = "XrTableCell94" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7620](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7620) |
| XrTableCell95.Text = "Carga Familiar:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7642](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7642) |
| XrTableCell96.Text = "XrTableCell96" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7653](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7653) |
| XrTableCell129.Text = "Hijos:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7680](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7680) |
| XrTableCell130.Text = "XrTableCell130" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7691](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7691) |
| XrLabel6.Text = "IV. ASPECTO SOCIO-FAMILIAR DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7705](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7705) |
| XrTableCell134.Text = "Observaciones:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7738](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7738) |
| XrTableCell135.Text = "XrTableCell135" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7749](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7749) |
| XrTableCell220.Text = "Tipo de Estudio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7796](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7796) |
| XrTableCell221.Text = "Centro de Estudios" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7807](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7807) |
| XrTableCell222.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7818](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7818) |
| XrTableCell223.Text = "Fecha de Termino" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7829](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7829) |
| XrTableCell224.Text = "Estado" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7840](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7840) |
| XrTableCell215.Text = "Tipo de Estudio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7874](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7874) |
| XrTableCell216.Text = "Centro de Estudios" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7881](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7881) |
| XrTableCell217.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7888](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7888) |
| XrTableCell218.Text = "Fecha de Termino" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7895](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7895) |
| XrTableCell219.Text = "Estado" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7902](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7902) |
| XrLabel18.Text = "5.1  Estudios Realizados:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7916](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7916) |
| XrLabel17.Text = "V. ASPECTO DE EDUCACION DEL TRABAJADOR" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7929](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7929) |
| XrTableCell229.Text = "Num. Colegiatura" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7975](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7975) |
| XrTableCell230.Text = "Denominación del Grado y/o Título" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7986](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7986) |
| XrTableCell231.Text = "Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:7997](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L7997) |
| XrTableCell232.Text = "Fecha" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8008](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8008) |
| XrTableCell226.Text = "Num. Colegiatura" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8042](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8042) |
| XrTableCell227.Text = "Denominación del Grado y/o Título" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8049](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8049) |
| XrTableCell228.Text = "Institución" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8056](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8056) |
| XrTableCell225.Text = "Fecha" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8063](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8063) |
| XrLabel19.Text = "5.2  Grados y Titulos:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8077](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8077) |
| XrTableCell238.Text = "Nombre del Curso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8123](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8123) |
| XrTableCell239.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8134](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8134) |
| XrTableCell240.Text = "Fecha de Fin" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8145](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8145) |
| XrTableCell241.Text = "Nº de Horas" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8156](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8156) |
| XrTableCell242.Text = "Inst. Organizadora" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8167](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8167) |
| XrTableCell233.Text = "Nombre del Curso" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8201](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8201) |
| XrTableCell234.Text = "Fecha de Inicio" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8208](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8208) |
| XrTableCell235.Text = "Fecha de Fin" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8215](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8215) |
| XrTableCell236.Text = "Nº de Horas" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8222](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8222) |
| XrTableCell237.Text = "Inst. Organizadora" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8229](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8229) |
| XrLabel20.Text = "5.3  Capacitaciones:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8243](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8243) |
| XrTableCell136.Text = "XrTableCell136" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8275](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8275) |
| XrTableCell139.Text = "XrTableCell139" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8282](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8282) |
| XrTableCell142.Text = "XrTableCell142" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8289](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8289) |
| XrTableCell140.Text = "XrTableCell140" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8296](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8296) |
| XrTableCell141.Text = "XrTableCell141" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8303](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8303) |
| XrTableCell84.Text = "Tipo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8332](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8332) |
| XrTableCell121.Text = "Fecha" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8339](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8339) |
| XrTableCell124.Text = "Nro. Documento" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8346](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8346) |
| XrTableCell125.Text = "Titulo" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8353](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8353) |
| XrTableCell128.Text = "Descripcion" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8360](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8360) |
| XrLabel3.Text = "5.4  Aspecto Disciplinario:" | [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:8374](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L8374) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs:18](../../Software/RecursosHumanos/RecursosHumanos/Report_Ficha_Escalaf.cs#L18).

**Formulario invocante y parámetros efectivos:** FrmReportFicha.FrmReportFicha_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1773](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1773)

```csharp
private void FrmReportFicha_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		MdiParent = MyProject.Forms.MainMDI;
		if (RRHH.Bienestar)
		{
			Report_FichaSocial_L report_FichaSocial_L = new Report_FichaSocial_L();
			report_FichaSocial_L.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Ficha_Prueba(Codempleado));
			PrintControl1.PrintingSystem = report_FichaSocial_L.PrintingSystem;
			report_FichaSocial_L.CreateDocument();
		}
		else
		{
			Report_Ficha_Escalaf report_Ficha_Escalaf = new Report_Ficha_Escalaf();
			report_Ficha_Escalaf.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Ficha_Prueba(Codempleado));
			PrintControl1.PrintingSystem = report_Ficha_Escalaf.PrintingSystem;
			report_Ficha_Escalaf.CreateDocument();
		}
	}
```

## Report_Oficinas

[Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L15)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "sprrhh_prueba1" | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:353](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L353) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:354](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L354) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "sprrhh_prueba1.NombresCompletos", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:282](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L282) |
| new XRBinding("Text", null, "sprrhh_prueba1.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:336](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L336) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrLabel2.Text = "XrLabel2" | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:294](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L294) |
| XrLabel4.Text = "Nombres Completos del Trabajador" | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:320](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L320) |
| XrLabel3.Text = "Oficina:" | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:333](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L333) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:350](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L350) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs:15](../../Software/RecursosHumanos/RecursosHumanos/Report_Oficinas.cs#L15).

**Formulario invocante y parámetros efectivos:** FrmReport_Selec_Oficina.Form1_Load · [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1775](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1775)

```csharp
private void Form1_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		MdiParent = MyProject.Forms.MainMDI;
		Report_Oficinas report_Oficinas = new Report_Oficinas();
		if (opcion == 1)
		{
			report_Oficinas.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Report_oficina_Dep(Var));
		}
		else
		{
			report_Oficinas.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Report_oficina(Conversions.ToInteger(Var)));
		}
		PrintControl1.PrintingSystem = report_Oficinas.PrintingSystem;
		report_Oficinas.CreateDocument();
	}
```

## Report_Porcentaje

[Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:13](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L13)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|

No se localizaron XRBinding/ExpressionBinding en esta clase; revisar etiquetas/celdas y configuración por el llamador. [Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:13](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L13)

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:13](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L13).

**Invocación:** sin constructor localizado fuera de su definición en los C#; no se certifica una ruta operativa. [Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs:13](../../Software/RecursosHumanos/RecursosHumanos/Report_Porcentaje.cs#L13)

## XtraRepPermiso

[Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L16)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_RepPermisos" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:961](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L961) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:962](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L962) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_RepPermisos.Nombres", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:674](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L674) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.Descrip_Motivo", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:689](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L689) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.FechaInicio", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:704](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L704) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.FEchaFin", "{0:dd/MM/yyyy}") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:719](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L719) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.Hora_Sal", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:734](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L734) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.Hora_ret", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:749](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L749) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.Lugar", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:764](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L764) |
| new XRBinding("Text", null, "spRRHH_RepPermisos.Observaciones", "") | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:779](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L779) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell1.Text = "XrTableCell1" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:686](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L686) |
| XrTableCell5.Text = "XrTableCell5" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:701](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L701) |
| XrTableCell2.Text = "XrTableCell2" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:716](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L716) |
| XrTableCell6.Text = "XrTableCell6" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:731](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L731) |
| XrTableCell3.Text = "XrTableCell3" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:746](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L746) |
| XrTableCell4.Text = "XrTableCell4" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:761](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L761) |
| XrTableCell7.Text = "XrTableCell7" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:776](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L776) |
| XrTableCell8.Text = "XrTableCell8" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:791](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L791) |
| XrLabel2.Text = "Reporte  de Permisos" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:814](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L814) |
| XrTableCell9.Text = "Nombres" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:841](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L841) |
| XrTableCell13.Text = "Permiso" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:852](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L852) |
| XrTableCell10.Text = "Fecha Inicio" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:863](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L863) |
| XrTableCell15.Text = "Fecha Termino" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:874](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L874) |
| XrTableCell14.Text = "Hora Sal." | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:885](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L885) |
| XrTableCell16.Text = "Hora Ret." | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:896](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L896) |
| XrTableCell11.Text = "Lugar" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:907](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L907) |
| XrTableCell12.Text = "Obs." | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:918](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L918) |
| XrLabel1.Text = "Impreso el:" | [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:946](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L946) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraRepPermiso.cs#L16).

**Formulario invocante y parámetros efectivos:** FrmRepPermisoDispl.FrmRepPermisoDispl_Load · [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1767](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1767)

```csharp
private void FrmRepPermisoDispl_Load(object sender, EventArgs e)
	{
		XtraRepPermiso xtraRepPermiso = new XtraRepPermiso();
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			xtraRepPermiso.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, 1);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			xtraRepPermiso.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, 2);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			xtraRepPermiso.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, idTipoTrabajador);
		}
		PrintControl1.PrintingSystem = xtraRepPermiso.PrintingSystem;
		xtraRepPermiso.CreateDocument();
	}
```

## XtraReportFaltas

[Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L16)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Faltas" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:641](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L641) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:642](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L642) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Faltas.NombresC", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:485](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L485) |
| new XRBinding("Text", null, "spRRHH_Faltas.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:500](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L500) |
| new XRBinding("Text", null, "spRRHH_Faltas.Fecha", "{0:dddd, dd MMMM yyyy}") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:518](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L518) |
| new XRBinding("Text", null, "spRRHH_Faltas.Descripcion", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:624](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L624) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrTableCell1.Text = "XrTableCell1" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:497](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L497) |
| XrTableCell2.Text = "XrTableCell2" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:512](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L512) |
| XrLabel4.Text = "XrLabel4" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:530](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L530) |
| XrLabel3.Text = "Día:" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:543](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L543) |
| XrLabel2.Text = "Reporte de Faltas" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:556](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L556) |
| XrLabel5.Text = "Condición Laboral:" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:584](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L584) |
| XrTableCell3.Text = "Nombres Completos" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:610](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L610) |
| XrTableCell4.Text = "Area Organizacional" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:621](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L621) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:638](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L638) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L16).

**Invocación:** sin constructor localizado fuera de su definición en los C#; no se certifica una ruta operativa. [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs:16](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas.cs#L16)

## XtraReportFaltas_Area

[Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:15](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L15)

**Datos y origen configurados por el diseñador:**

| Asignación | Evidencia |
|---|---|
| DataMember = "spRRHH_Faltas" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:448](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L448) |
| DataSource = DataSet11 | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:449](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L449) |

**Campos enlazados (lo que imprime):**

| Enlace de campo / formato | Evidencia |
|---|---|
| new XRBinding("Text", null, "spRRHH_Faltas.NombresC", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:335](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L335) |
| new XRBinding("Text", null, "spRRHH_Faltas.Descripcion", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:404](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L404) |
| new XRBinding("Text", null, "spRRHH_Faltas.AreaOrganizacional", "") | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:429](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L429) |

**Encabezados/textos del diseño:**

| Control / texto | Evidencia |
|---|---|
| XrLabel3.Text = "XrLabel3" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:348](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L348) |
| XrLabel6.Text = "XrLabel6" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:366](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L366) |
| XrLabel5.Text = "Fecha:" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:379](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L379) |
| XrLabel4.Text = "Reporte de Faltas" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:392](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L392) |
| XrLabel2.Text = "XrLabel2" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:418](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L418) |
| XrLabel1.Text = "XrLabel1" | [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:443](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L443) |

**Parámetros XtraReport:** No se hallaron creaciones explícitas Parameter en la clase; los filtros pueden pasarse a la consulta del formulario. [Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs:15](../../Software/RecursosHumanos/RecursosHumanos/XtraReportFaltas_Area.cs#L15).

**Formulario invocante y parámetros efectivos:** FrmRepFaltas.FrmRepPermiso_Load · [Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1789](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1789)

```csharp
private void FrmRepPermiso_Load(object sender, EventArgs e)
	{
		XtraReportFaltas_Area xtraReportFaltas_Area = new XtraReportFaltas_Area();
		xtraReportFaltas_Area.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.Generar_Rep_Faltas(fecha, tipotrabajador, area, año));
		xtraReportFaltas_Area.XrLabel6.Text = fecha;
		PrintControl1.PrintingSystem = xtraReportFaltas_Area.PrintingSystem;
		xtraReportFaltas_Area.CreateDocument();
	}
```

## Reportes de grilla y exportaciones sin clase XtraReport

No todo reporte tiene archivo de diseño separado. Estas llamadas/exportaciones y asignaciones muestran salidas XLS, PrintControl o generación de grilla; los filtros y condiciones están en los cuerpos de eventos del capítulo 2.

| Formulario/método | Llamada y parámetros | Evidencia |
|---|---|---|
| spRRHH_Report_CuadroPerDataTable.Clone | spRRHH_Report_CuadroPerDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2580](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2580) |
| spRRHH_Report_CuadroPerDataTable.CreateInstance | new spRRHH_Report_CuadroPerDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2588](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2588) |
| spRRHH_Report_CuadroPerDataTable.NewRowFromBuilder | new spRRHH_Report_CuadroPerRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2647](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2647) |
| spRRHH_Report_CuadroPerDataTable.OnRowChanged | spRRHH_Report_CuadroPerRowChanged?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2664](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2664) |
| spRRHH_Report_CuadroPerDataTable.OnRowChanged | new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2664](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2664) |
| spRRHH_Report_CuadroPerDataTable.OnRowChanging | spRRHH_Report_CuadroPerRowChanging?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2675](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2675) |
| spRRHH_Report_CuadroPerDataTable.OnRowChanging | new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2675](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2675) |
| spRRHH_Report_CuadroPerDataTable.OnRowDeleted | spRRHH_Report_CuadroPerRowDeleted?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2686](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2686) |
| spRRHH_Report_CuadroPerDataTable.OnRowDeleted | new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2686](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2686) |
| spRRHH_Report_CuadroPerDataTable.OnRowDeleting | spRRHH_Report_CuadroPerRowDeleting?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2697](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2697) |
| spRRHH_Report_CuadroPerDataTable.OnRowDeleting | new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2697](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2697) |
| spRRHH_Report_OficinaDataTable.Clone | spRRHH_Report_OficinaDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2958](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2958) |
| spRRHH_Report_OficinaDataTable.CreateInstance | new spRRHH_Report_OficinaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:2966](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L2966) |
| spRRHH_Report_OficinaDataTable.NewRowFromBuilder | new spRRHH_Report_OficinaRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3017](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3017) |
| spRRHH_Report_OficinaDataTable.OnRowChanged | spRRHH_Report_OficinaRowChanged?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3034](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3034) |
| spRRHH_Report_OficinaDataTable.OnRowChanged | new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3034](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3034) |
| spRRHH_Report_OficinaDataTable.OnRowChanging | spRRHH_Report_OficinaRowChanging?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3045](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3045) |
| spRRHH_Report_OficinaDataTable.OnRowChanging | new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3045](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3045) |
| spRRHH_Report_OficinaDataTable.OnRowDeleted | spRRHH_Report_OficinaRowDeleted?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3056](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3056) |
| spRRHH_Report_OficinaDataTable.OnRowDeleted | new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3056](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3056) |
| spRRHH_Report_OficinaDataTable.OnRowDeleting | spRRHH_Report_OficinaRowDeleting?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3067](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3067) |
| spRRHH_Report_OficinaDataTable.OnRowDeleting | new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3067](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3067) |
| spRRHH_Report_CumpleDataTable.Clone | spRRHH_Report_CumpleDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3324](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3324) |
| spRRHH_Report_CumpleDataTable.CreateInstance | new spRRHH_Report_CumpleDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3332](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3332) |
| spRRHH_Report_CumpleDataTable.NewRowFromBuilder | new spRRHH_Report_CumpleRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3389](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3389) |
| spRRHH_Report_CumpleDataTable.OnRowChanged | spRRHH_Report_CumpleRowChanged?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3406](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3406) |
| spRRHH_Report_CumpleDataTable.OnRowChanged | new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3406](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3406) |
| spRRHH_Report_CumpleDataTable.OnRowChanging | spRRHH_Report_CumpleRowChanging?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3417](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3417) |
| spRRHH_Report_CumpleDataTable.OnRowChanging | new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3417](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3417) |
| spRRHH_Report_CumpleDataTable.OnRowDeleted | spRRHH_Report_CumpleRowDeleted?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3428](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3428) |
| spRRHH_Report_CumpleDataTable.OnRowDeleted | new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3428](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3428) |
| spRRHH_Report_CumpleDataTable.OnRowDeleting | spRRHH_Report_CumpleRowDeleting?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3439](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3439) |
| spRRHH_Report_CumpleDataTable.OnRowDeleting | new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3439](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3439) |
| spRRHH_Rep_cargosDataTable.Clone | spRRHH_Rep_cargosDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3687](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3687) |
| spRRHH_Rep_cargosDataTable.CreateInstance | new spRRHH_Rep_cargosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3695](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3695) |
| spRRHH_Rep_cargosDataTable.NewRowFromBuilder | new spRRHH_Rep_cargosRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3743](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3743) |
| spRRHH_Rep_cargosDataTable.OnRowChanged | spRRHH_Rep_cargosRowChanged?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3760](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3760) |
| spRRHH_Rep_cargosDataTable.OnRowChanged | new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3760](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3760) |
| spRRHH_Rep_cargosDataTable.OnRowChanging | spRRHH_Rep_cargosRowChanging?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3771](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3771) |
| spRRHH_Rep_cargosDataTable.OnRowChanging | new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3771](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3771) |
| spRRHH_Rep_cargosDataTable.OnRowDeleted | spRRHH_Rep_cargosRowDeleted?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3782](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3782) |
| spRRHH_Rep_cargosDataTable.OnRowDeleted | new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3782](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3782) |
| spRRHH_Rep_cargosDataTable.OnRowDeleting | spRRHH_Rep_cargosRowDeleting?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3793](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3793) |
| spRRHH_Rep_cargosDataTable.OnRowDeleting | new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:3793](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L3793) |
| spRRHH_RepPermisosDataTable.Clone | spRRHH_RepPermisosDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6831](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6831) |
| spRRHH_RepPermisosDataTable.CreateInstance | new spRRHH_RepPermisosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6839](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6839) |
| spRRHH_RepPermisosDataTable.NewRowFromBuilder | new spRRHH_RepPermisosRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6900](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6900) |
| spRRHH_RepPermisosDataTable.OnRowChanged | spRRHH_RepPermisosRowChanged?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6917](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6917) |
| spRRHH_RepPermisosDataTable.OnRowChanged | new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6917](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6917) |
| spRRHH_RepPermisosDataTable.OnRowChanging | spRRHH_RepPermisosRowChanging?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6928](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6928) |
| spRRHH_RepPermisosDataTable.OnRowChanging | new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6928](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6928) |
| spRRHH_RepPermisosDataTable.OnRowDeleted | spRRHH_RepPermisosRowDeleted?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6939](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6939) |
| spRRHH_RepPermisosDataTable.OnRowDeleted | new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6939](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6939) |
| spRRHH_RepPermisosDataTable.OnRowDeleting | spRRHH_RepPermisosRowDeleting?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6950](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6950) |
| spRRHH_RepPermisosDataTable.OnRowDeleting | new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:6950](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L6950) |
| spRRHH_RepAsisdiarriaDataTable.Clone | spRRHH_RepAsisdiarriaDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7189](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7189) |
| spRRHH_RepAsisdiarriaDataTable.CreateInstance | new spRRHH_RepAsisdiarriaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7197](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7197) |
| spRRHH_RepAsisdiarriaDataTable.NewRowFromBuilder | new spRRHH_RepAsisdiarriaRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7243](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7243) |
| spRRHH_RepAsisdiarriaDataTable.OnRowChanged | spRRHH_RepAsisdiarriaRowChanged?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7260](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7260) |
| spRRHH_RepAsisdiarriaDataTable.OnRowChanged | new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7260](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7260) |
| spRRHH_RepAsisdiarriaDataTable.OnRowChanging | spRRHH_RepAsisdiarriaRowChanging?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7271](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7271) |
| spRRHH_RepAsisdiarriaDataTable.OnRowChanging | new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7271](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7271) |
| spRRHH_RepAsisdiarriaDataTable.OnRowDeleted | spRRHH_RepAsisdiarriaRowDeleted?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7282](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7282) |
| spRRHH_RepAsisdiarriaDataTable.OnRowDeleted | new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7282](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7282) |
| spRRHH_RepAsisdiarriaDataTable.OnRowDeleting | spRRHH_RepAsisdiarriaRowDeleting?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7293](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7293) |
| spRRHH_RepAsisdiarriaDataTable.OnRowDeleting | new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7293](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7293) |
| spRRHH_Report_FechaIngresoDataTable.Clone | spRRHH_Report_FechaIngresoDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7547](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7547) |
| spRRHH_Report_FechaIngresoDataTable.CreateInstance | new spRRHH_Report_FechaIngresoDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7555](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7555) |
| spRRHH_Report_FechaIngresoDataTable.NewRowFromBuilder | new spRRHH_Report_FechaIngresoRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7608](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7608) |
| spRRHH_Report_FechaIngresoDataTable.OnRowChanged | spRRHH_Report_FechaIngresoRowChanged?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7625](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7625) |
| spRRHH_Report_FechaIngresoDataTable.OnRowChanged | new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7625](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7625) |
| spRRHH_Report_FechaIngresoDataTable.OnRowChanging | spRRHH_Report_FechaIngresoRowChanging?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7636](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7636) |
| spRRHH_Report_FechaIngresoDataTable.OnRowChanging | new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7636](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7636) |
| spRRHH_Report_FechaIngresoDataTable.OnRowDeleted | spRRHH_Report_FechaIngresoRowDeleted?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7647](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7647) |
| spRRHH_Report_FechaIngresoDataTable.OnRowDeleted | new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7647](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7647) |
| spRRHH_Report_FechaIngresoDataTable.OnRowDeleting | spRRHH_Report_FechaIngresoRowDeleting?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7658](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7658) |
| spRRHH_Report_FechaIngresoDataTable.OnRowDeleting | new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7658](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7658) |
| spRRHH_Rep_profesionDataTable.Clone | spRRHH_Rep_profesionDataTable.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7903](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7903) |
| spRRHH_Rep_profesionDataTable.CreateInstance | new spRRHH_Rep_profesionDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7911](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7911) |
| spRRHH_Rep_profesionDataTable.NewRowFromBuilder | new spRRHH_Rep_profesionRow(builder) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7958](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7958) |
| spRRHH_Rep_profesionDataTable.OnRowChanged | spRRHH_Rep_profesionRowChanged?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7975](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7975) |
| spRRHH_Rep_profesionDataTable.OnRowChanged | new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7975](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7975) |
| spRRHH_Rep_profesionDataTable.OnRowChanging | spRRHH_Rep_profesionRowChanging?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7986](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7986) |
| spRRHH_Rep_profesionDataTable.OnRowChanging | new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7986](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7986) |
| spRRHH_Rep_profesionDataTable.OnRowDeleted | spRRHH_Rep_profesionRowDeleted?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7997](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7997) |
| spRRHH_Rep_profesionDataTable.OnRowDeleted | new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:7997](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L7997) |
| spRRHH_Rep_profesionDataTable.OnRowDeleting | spRRHH_Rep_profesionRowDeleting?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action)) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:8008](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L8008) |
| spRRHH_Rep_profesionDataTable.OnRowDeleting | new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:8008](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L8008) |
| DataSet1.DataSet1 | new spRRHH_Report_CuadroPerDataTable(dataSet.Tables["spRRHH_Report_CuadroPer"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17763](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17763) |
| DataSet1.DataSet1 | new spRRHH_Report_OficinaDataTable(dataSet.Tables["spRRHH_Report_Oficina"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17767](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17767) |
| DataSet1.DataSet1 | new spRRHH_Report_CumpleDataTable(dataSet.Tables["spRRHH_Report_Cumple"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17771](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17771) |
| DataSet1.DataSet1 | new spRRHH_Rep_cargosDataTable(dataSet.Tables["spRRHH_Rep_cargos"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17775](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17775) |
| DataSet1.DataSet1 | new spRRHH_RepPermisosDataTable(dataSet.Tables["spRRHH_RepPermisos"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17799](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17799) |
| DataSet1.DataSet1 | new spRRHH_RepAsisdiarriaDataTable(dataSet.Tables["spRRHH_RepAsisdiarria"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17803](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17803) |
| DataSet1.DataSet1 | new spRRHH_Report_FechaIngresoDataTable(dataSet.Tables["spRRHH_Report_FechaIngreso"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17807](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17807) |
| DataSet1.DataSet1 | new spRRHH_Rep_profesionDataTable(dataSet.Tables["spRRHH_Rep_profesion"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17811](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17811) |
| DataSet1.ReadXmlSerializable | new spRRHH_Report_CuadroPerDataTable(dataSet.Tables["spRRHH_Report_CuadroPer"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17904](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17904) |
| DataSet1.ReadXmlSerializable | new spRRHH_Report_OficinaDataTable(dataSet.Tables["spRRHH_Report_Oficina"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17908](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17908) |
| DataSet1.ReadXmlSerializable | new spRRHH_Report_CumpleDataTable(dataSet.Tables["spRRHH_Report_Cumple"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17912](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17912) |
| DataSet1.ReadXmlSerializable | new spRRHH_Rep_cargosDataTable(dataSet.Tables["spRRHH_Rep_cargos"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17916](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17916) |
| DataSet1.ReadXmlSerializable | new spRRHH_RepPermisosDataTable(dataSet.Tables["spRRHH_RepPermisos"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17940](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17940) |
| DataSet1.ReadXmlSerializable | new spRRHH_RepAsisdiarriaDataTable(dataSet.Tables["spRRHH_RepAsisdiarria"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17944](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17944) |
| DataSet1.ReadXmlSerializable | new spRRHH_Report_FechaIngresoDataTable(dataSet.Tables["spRRHH_Report_FechaIngreso"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17948](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17948) |
| DataSet1.ReadXmlSerializable | new spRRHH_Rep_profesionDataTable(dataSet.Tables["spRRHH_Rep_profesion"]) | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:17952](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L17952) |
| DataSet1.InitVars | tablespRRHH_Report_CuadroPer.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18028](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18028) |
| DataSet1.InitVars | tablespRRHH_Report_Oficina.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18033](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18033) |
| DataSet1.InitVars | tablespRRHH_Report_Cumple.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18038](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18038) |
| DataSet1.InitVars | tablespRRHH_Rep_cargos.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18043](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18043) |
| DataSet1.InitVars | tablespRRHH_RepPermisos.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18073](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18073) |
| DataSet1.InitVars | tablespRRHH_RepAsisdiarria.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18078](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18078) |
| DataSet1.InitVars | tablespRRHH_Report_FechaIngreso.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18083](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18083) |
| DataSet1.InitVars | tablespRRHH_Rep_profesion.InitVars() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18088](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18088) |
| DataSet1.InitClass | new spRRHH_Report_CuadroPerDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18118](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18118) |
| DataSet1.InitClass | new spRRHH_Report_OficinaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18120](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18120) |
| DataSet1.InitClass | new spRRHH_Report_CumpleDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18122](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18122) |
| DataSet1.InitClass | new spRRHH_Rep_cargosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18124](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18124) |
| DataSet1.InitClass | new spRRHH_RepPermisosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18136](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18136) |
| DataSet1.InitClass | new spRRHH_RepAsisdiarriaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18138](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18138) |
| DataSet1.InitClass | new spRRHH_Report_FechaIngresoDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18140](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18140) |
| DataSet1.InitClass | new spRRHH_Rep_profesionDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1.cs:18142](../../Software/RecursosHumanos/RecursosHumanos/DataSet1.cs#L18142) |
| spRRHH_RepAsisdiarriaTableAdapter.GetData | new DataSet1.spRRHH_RepAsisdiarriaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs:299](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepAsisdiarriaTableAdapter.cs#L299) |
| spRRHH_RepPermisosTableAdapter.GetData | new DataSet1.spRRHH_RepPermisosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs:334](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_RepPermisosTableAdapter.cs#L334) |
| spRRHH_Rep_cargosTableAdapter.GetData | new DataSet1.spRRHH_Rep_cargosDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs:280](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_cargosTableAdapter.cs#L280) |
| spRRHH_Rep_profesionTableAdapter.GetData | new DataSet1.spRRHH_Rep_profesionDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs:283](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Rep_profesionTableAdapter.cs#L283) |
| spRRHH_Report_CuadroPerTableAdapter.GetData | new DataSet1.spRRHH_Report_CuadroPerDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs:286](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CuadroPerTableAdapter.cs#L286) |
| spRRHH_Report_CumpleTableAdapter.GetData | new DataSet1.spRRHH_Report_CumpleDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs:285](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_CumpleTableAdapter.cs#L285) |
| spRRHH_Report_FechaIngresoTableAdapter.GetData | new DataSet1.spRRHH_Report_FechaIngresoDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs:315](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_FechaIngresoTableAdapter.cs#L315) |
| spRRHH_Report_OficinaTableAdapter.GetData | new DataSet1.spRRHH_Report_OficinaDataTable() | [Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs:281](../../Software/RecursosHumanos/RecursosHumanos/DataSet1TableAdapters/spRRHH_Report_OficinaTableAdapter.cs#L281) |
| FrmConsultaAsistDiaria.BtnConsultar_Click | obj.spRRHH_RepAsisdiarria(fechaI, fechaF, null, area, tipo, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:953](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L953) |
| FrmConsultaAsistDiaria.BtnConsultar_Click | obj.spRRHH_RepAsisdiarria(fechaI, fechaF, UcTxtDNI.Text.Trim(), num, num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:962](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L962) |
| FrmConsultaAsistDiaria.Button2_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:978](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L978) |
| FrmConsultaAsistencias.BtnGenerar_Click | this.obj.LlenarPlanillaAsistencia(text.Substring(0, text.Length - 3), Conversions.ToString(UcCBPartidaPresupuestal.SelectedValue), text2) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:790](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L790) |
| FrmConsultaAsistencias.Button1_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1001](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1001) |
| FrmConsultaFaltas.BtnExportar_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:793](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L793) |
| FrmConsultaHorarioEsp.Button2_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1106](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1106) |
| FrmConsultaPermisos.Button2_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1500](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1500) |
| FrmHorasTrabajadas.BtnGenerar_Click | dcGrll.spRRHH_GetRecordAsistenciasSemanales(fI, obj, (selectedValue != null) ? ((int?)selectedValue) : num) | [Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:710](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L710) |
| FrmHorasTrabajadas.BtnExportarExcel_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:724](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L724) |
| FrmRepAsistenciaDia.BtnConsultar_Click | rRHHClass.spRRHH_RepAsisdiarria(obj, obj2, null, num, (selectedValue != null) ? ((int?)selectedValue) : num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), Conversions.ToString(0), 1) | [Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:889](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L889) |
| FrmRepAsistenciaDia.Button2_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:903](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L903) |
| FrmRepFaltas.FrmRepPermiso_Load | objRRHHClass.Generar_Rep_Faltas(fecha, tipotrabajador, area, año) | [Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1790](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1790) |
| FrmRepFaltas.FrmRepPermiso_Load | xtraReportFaltas_Area.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1793](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1793) |
| FrmRepPermisoDispl.FrmRepPermisoDispl_Load | objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, 1) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1770](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1770) |
| FrmRepPermisoDispl.FrmRepPermisoDispl_Load | objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, 2) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1774](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1774) |
| FrmRepPermisoDispl.FrmRepPermisoDispl_Load | objRRHHClass.spRRHH_RepPermisos(fechaI, FEchaFin, TipoPermiso, motivo, idTipoTrabajador) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1779](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1779) |
| FrmRepPermisoDispl.FrmRepPermisoDispl_Load | xtraRepPermiso.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1782](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1782) |
| FrmRepPermisos.Button1_Click | objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 1) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:785](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L785) |
| FrmRepPermisos.Button1_Click | objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 2) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:789](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L789) |
| FrmRepPermisos.Button1_Click | objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, num) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:793](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L793) |
| FrmRepPermisos.Button2_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:857](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L857) |
| FrmReportCuadro.FrmReportCuadro_Load | rep_CuadroPersonal.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs:1763](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs#L1763) |
| FrmReportCumple.FrmReportCumple_Load | report_Cumple.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1791](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1791) |
| FrmReportFicha.FrmReportFicha_Load | report_FichaSocial_L.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1769](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1769) |
| FrmReportFicha.FrmReportFicha_Load | report_Ficha_Escalaf.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1776](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1776) |
| FrmReport_Cargos.Button1_Click | report_Cargos.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1965](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1965) |
| FrmReport_Empleado_Ingre.FrmReport_Empleado_Ingre_Load | objRRHHClass.Generar_Report_Emple_ficha(fi, ft, tipo) | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1770](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1770) |
| FrmReport_Empleado_Ingre.FrmReport_Empleado_Ingre_Load | report_Emple_Ingreso.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1772](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1772) |
| FrmReport_Selec_Oficina.Form1_Load | objRRHHClass.Generar_Report_oficina_Dep(Var) | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1778](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1778) |
| FrmReport_Selec_Oficina.Form1_Load | objRRHHClass.Generar_Report_oficina(Conversions.ToInteger(Var)) | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1782](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1782) |
| FrmReport_Selec_Oficina.Form1_Load | report_Oficinas.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1785](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1785) |
| FrmReporteProfesion.Button1_Click | objRRHHClass.spRRHH_Rep_profesion(CheckedListBoxControl1.GetItemValue(num2).ToString()) | [Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:2027](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L2027) |
| FrmReporteProfesion.Button1_Click | rep_Profesion.CreateDocument() | [Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:2038](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L2038) |
| FrmSobreTiempo.BtnExportarExcel_Click | GridControl1.ExportToXls(text2, xlsExportOptions) | [Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:602](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L602) |
| PostgreSqlDiagnostic.TryRun | context.spRRHH_GetRecordAsistenciasSemanales("20240101", "20240107", null) | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:80](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L80) |
| PostgreSqlDiagnostic.TryRun | rrhh.spRRHH_RepAsisdiarria("20240101", "20240107", null, null, null, "2024", null) | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs:81](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlDiagnostic.cs#L81) |
| PostgreSqlLegacyContext.spRRHH_Faltas | new RRHHClass(_database).Generar_Rep_Faltas(fecha, tipo, area, year) | [Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs:45](../../Software/RecursosHumanos/RecursosHumanos/PostgreSqlLegacyContext.cs#L45) |
