# Anexo 2A. Cuerpos de eventos y métodos de formularios

[Volver a formularios](02_formularios.md). Extractos de fuente con ubicación inicial/final; se excluyen InitializeComponent, Dispose, accesores mecánicos y administración de referencias débiles. El diseñador, campos y suscripciones están en las fichas. Los cuerpos se incluyen íntegros para que la descripción de un botón no sustituya su condición real.

<a id="f-001"></a>

## AcercaDe


### AcercaDe · líneas 184–190

[Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs:184](../../Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs#L184)

```csharp
[DebuggerNonUserCode]
	public AcercaDe()
	{
		base.Load += AcercaDe_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### AcercaDe_Load · líneas 440–450

[Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs:440](../../Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs#L440)

```csharp
[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void AcercaDe_Load(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(MyProject.Application.Info.Title, "", TextCompare: false) == 0) ? Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : MyProject.Application.Info.Title);
		Text = $"Acerca {arg}";
		LabelProductName.Text = "Sistema de Recursos Humanos";
		LabelVersion.Text = $"Version {MyProject.Application.Info.Version.ToString()}";
		LabelCopyright.Text = MyProject.Application.Info.Copyright;
		LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
		TextBoxDescription.Text = "Desarrollado por: Sub Gerencia de Tecnologías de la Información ";
	}
```

### OKButton_Click · líneas 452–455

[Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs:452](../../Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs#L452)

```csharp
private void OKButton_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### TableLayoutPanel_Paint · líneas 457–459

[Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs:457](../../Software/RecursosHumanos/RecursosHumanos/AcercaDe.cs#L457)

```csharp
private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
	{
	}
```

<a id="f-002"></a>

## FrmAsignarHorario


### FrmAsignarHorario · líneas 373–379

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:373](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L373)

```csharp
[DebuggerNonUserCode]
	public FrmAsignarHorario()
	{
		base.Load += FrmAsignarHorario_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmAsignarHorario_Load · líneas 672–696

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:672](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L672)

```csharp
private void FrmAsignarHorario_Load(object sender, EventArgs e)
	{
		List<Horario> dataSource = HorarioMapper.Instance().SelectAll();
		RepositoryItemLookUpEdit1.ValueMember = "idHorario";
		RepositoryItemLookUpEdit1.DisplayMember = "Descrip_Horario";
		RepositoryItemLookUpEdit1.DataSource = dataSource;
		RepositoryItemLookUpEdit1.BestFitMode = BestFitMode.BestFitResizePopup;
		GridColumn4.ColumnEdit.NullText = "SIN HORARIO ASIGNADO";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Horario(1, null);
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Horario(2, null);
			GridControl1.DataSource = dataSource3;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource4 = Module1.DcGrll.sp_Listar_Empleado_Horario(idTipoTrabajador, null);
			GridControl1.DataSource = dataSource4;
		}
	}
```

### LookUpEditEditValueChanging · líneas 698–701

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:698](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L698)

```csharp
public void LookUpEditEditValueChanging(object sender, ChangingEventArgs e)
	{
		Module1.DcGrll.sp_Update_Empleado_idHorario_By_idEmpleado(Conversions.ToInteger(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idEmpleado")), Conversions.ToInteger(e.NewValue));
	}
```

### BtnBuscar_Click · líneas 703–721

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:703](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L703)

```csharp
private void BtnBuscar_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource = Module1.DcGrll.sp_Listar_Empleado_Horario(1, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Horario(2, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Horario(idTipoTrabajador, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource3;
		}
	}
```

### UcTextBox1_EnterPress · líneas 723–741

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:723](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L723)

```csharp
private void UcTextBox1_EnterPress()
	{
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource = Module1.DcGrll.sp_Listar_Empleado_Horario(1, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Horario(2, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_HorarioResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Horario(idTipoTrabajador, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource3;
		}
	}
```

### CheckEquipoMarcacion_CheckedChanged · líneas 743–745

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:743](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L743)

```csharp
private void CheckEquipoMarcacion_CheckedChanged(object sender, EventArgs e)
	{
	}
```

### GridControl1_Click · líneas 747–749

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs:747](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario.cs#L747)

```csharp
private void GridControl1_Click(object sender, EventArgs e)
	{
	}
```

<a id="f-003"></a>

## FrmAsignarHorario_Lector


### FrmAsignarHorario_Lector · líneas 317–323

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs:317](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs#L317)

```csharp
[DebuggerNonUserCode]
	public FrmAsignarHorario_Lector()
	{
		base.Load += FrmAsignarHorario_Lector_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmAsignarHorario_Lector_Load · líneas 595–597

[Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs:595](../../Software/RecursosHumanos/RecursosHumanos/FrmAsignarHorario_Lector.cs#L595)

```csharp
private void FrmAsignarHorario_Lector_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-004"></a>

## FrmAsistenciaManual


### FrmAsistenciaManual · líneas 416–423

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:416](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L416)

```csharp
public FrmAsistenciaManual()
	{
		base.Load += FrmAsistenciaManual_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmAsistenciaManual_Load · líneas 887–916

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:887](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L887)

```csharp
private void FrmAsistenciaManual_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null) == null)
				{
					MessageBox.Show("Primero debe asignar un Horario al trabajador", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				idHorario = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null));
			}
		}
		DEFecha.DateTime = DateAndTime.Today;
	}
```

### CheckIngreso_CheckedChanged · líneas 918–929

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:918](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L918)

```csharp
private void CheckIngreso_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			DEHoraIngreso.Enabled = true;
			DEHoraIngreso.Focus();
		}
		else
		{
			DEHoraIngreso.Enabled = false;
		}
	}
```

### CheckSalida_CheckedChanged · líneas 931–942

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:931](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L931)

```csharp
private void CheckSalida_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			DEHoraSalida.Enabled = true;
			DEHoraSalida.Focus();
		}
		else
		{
			DEHoraSalida.Enabled = false;
		}
	}
```

### BtnGrabar_Click · líneas 944–1030

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:944](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L944)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		if ((CheckIngreso.CheckState == CheckState.Unchecked) & (CheckSalida.CheckState == CheckState.Unchecked))
		{
			MessageBox.Show("Debe Ingresar una hora de Entrada o Salida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		Horario horario = HorarioMapper.Instance().SelectBy([SpecialName] (Horario v) => v.idHorario == idHorario).Single();
		if (CheckIngreso.CheckState == CheckState.Checked && DateTime.Compare(Conversions.ToDate(DEHoraIngreso.Text), Conversions.ToDate(horario.Ingreso1).AddMinutes(15.0)) > 0)
		{
			MessageBox.Show("La hora de ingreso no puede ser mayor, a la del horario asignado", "Error!");
			return;
		}
		Asistencia asistencia = new Asistencia();
		asistencia.IdEmpleado = idEmpleado;
		asistencia.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Ent = DEHoraIngreso.Text.ToString();
			asistencia.Flag_Ent = true;
			DEFecha.Properties.EditMask = "dd/MM/yyyy";
			Marcacion marcacion = new Marcacion();
			marcacion.IdEmpleado = idEmpleado;
			string value = DEFecha.Text + " " + DEHoraIngreso.Text.ToString();
			marcacion.Fecha = Convert.ToDateTime(value);
			marcacion.Estado = "1M";
			if (dataTable.Rows.Count == 0)
			{
				MarcacionMapper.Instance().Insert(marcacion);
			}
			DEFecha.Properties.EditMask = "D";
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Ent = dataTable.Rows[0]["Hor_Ent"].ToString();
			}
			else
			{
				asistencia.Hor_Ent = "00:00:00";
			}
			asistencia.Flag_Ent = false;
		}
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Sal = DEHoraSalida.Text.ToString();
			asistencia.Flag_Sal = true;
			DEFecha.Properties.EditMask = "dd/MM/yyyy";
			Marcacion marcacion2 = new Marcacion();
			marcacion2.IdEmpleado = idEmpleado;
			string value2 = DEFecha.Text + " " + DEHoraSalida.Text.ToString();
			marcacion2.Fecha = Convert.ToDateTime(value2);
			marcacion2.Estado = "4M";
			if (dataTable.Rows.Count == 0)
			{
				MarcacionMapper.Instance().Insert(marcacion2);
			}
			DEFecha.Properties.EditMask = "D";
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Sal = dataTable.Rows[0]["Hor_Sal"].ToString();
			}
			else
			{
				asistencia.Hor_Sal = "00:00:00";
			}
			asistencia.Flag_Sal = false;
		}
		asistencia.Alm_Ent = "00:00:00";
		asistencia.Alm_Sal = "00:00:00";
		asistencia.idHorario = idHorario;
		if (dataTable.Rows.Count == 0)
		{
			AsistenciaMapper.Instance().Insert(asistencia);
		}
		else
		{
			AsistenciaMapper.Instance().Update(asistencia);
		}
		MessageBox.Show("Se Grabo Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
	}
```

### DEFecha_EditValueChanged · líneas 1032–1049

[Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs:1032](../../Software/RecursosHumanos/RecursosHumanos/FrmAsistenciaManual.cs#L1032)

```csharp
private void DEFecha_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(DEFecha.DateTime.ToShortDateString(), "01/01/0001", TextCompare: false) != 0)
		{
			string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
			DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
			if (dataTable.Rows.Count == 1)
			{
				DEHoraIngreso.Text = dataTable.Rows[0]["Hor_Ent"].ToString();
				DEHoraSalida.Text = dataTable.Rows[0]["Hor_Sal"].ToString();
			}
			else
			{
				DEHoraIngreso.Text = "";
				DEHoraSalida.Text = "";
			}
		}
	}
```

<a id="f-005"></a>

## FrmBuscarDerechohabiente


### FrmBuscarDerechohabiente · líneas 245–251

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs:245](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs#L245)

```csharp
public FrmBuscarDerechohabiente()
	{
		base.Load += FrmBuscarDerechohabiente_Load;
		__ENCAddToList(this);
		oPersona = new Persona();
		InitializeComponent();
	}
```

### FrmBuscarDerechohabiente_Load · líneas 480–482

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs:480](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs#L480)

```csharp
private void FrmBuscarDerechohabiente_Load(object sender, EventArgs e)
	{
	}
```

### btnBuscar_Click · líneas 484–488

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs:484](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs#L484)

```csharp
private void btnBuscar_Click(object sender, EventArgs e)
	{
		RRHHClass rRHHClass = new RRHHClass();
		GCBusqeda.DataSource = RuntimeHelpers.GetObjectValue(rRHHClass.BuscarPersonas(UcTxtApellido.Text.Trim()));
	}
```

### GVBusqeda_DoubleClick · líneas 490–494

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs:490](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarDerechohabiente.cs#L490)

```csharp
private void GVBusqeda_DoubleClick(object sender, EventArgs e)
	{
		oPersona.IdPersona = Conversions.ToInteger(GVBusqeda.GetRowCellValue(GVBusqeda.FocusedRowHandle, "IdPersona"));
		DialogResult = DialogResult.OK;
	}
```

<a id="f-006"></a>

## FrmBuscarPersona


### FrmBuscarPersona · líneas 748–754

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:748](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L748)

```csharp
public FrmBuscarPersona()
	{
		base.Load += FrmBuscarPersona_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### llenarGrid · líneas 1361–1391

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1361](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1361)

```csharp
private void llenarGrid()
	{
		int? codigo = ((UcTxtCodigo.Text.Trim().Length != 0) ? ((int?)int.Parse(UcTxtCodigo.Text)) : ((int?)null));
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, 1, (int)CbxActivo.CheckState);
			return;
		}
		if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, 2, (int)CbxActivo.CheckState);
			return;
		}
		int? num = default(int?);
		if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, num, (int)CbxActivo.CheckState);
			return;
		}
		if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
		{
			dgvEmpleado.DataSource = objClassRRHH.buscar_empleado(codigo, UcTxtDni.Text, UcTxtApellido.Text, num, (int)CbxActivo.CheckState, Conversions.ToInteger(RRHH.IdROl));
			return;
		}
		GridControl gridControl = dgvEmpleado;
		RRHHClass rRHHClass = objClassRRHH;
		string numdoc = UcTxtDni.Text;
		string apellido = UcTxtApellido.Text;
		object obj = Interaction.IIf(RRHH.Partida == 0, null, RRHH.Partida);
		gridControl.DataSource = rRHHClass.buscar_empleado(codigo, numdoc, apellido, (obj != null) ? ((int?)obj) : num, (int)CbxActivo.CheckState);
	}
```

### Button1_Click · líneas 1393–1408

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1393](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1393)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			llenarGrid();
			GridView1.BestFitColumns();
			DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
```

### btn_nuevo_Click · líneas 1410–1430

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1410](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1410)

```csharp
private void btn_nuevo_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			try
			{
				llenarGrid();
				GridView1.BestFitColumns();
				DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
```

### btn_editar_Click · líneas 1432–1490

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1432](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1432)

```csharp
private void btn_editar_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
		if (objClassRRHH.CodigoEmpleado == 0)
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else
		{
			if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		if (frmMantEmpleado_Basico.DialogResult != DialogResult.OK)
		{
			return;
		}
		try
		{
			llenarGrid();
			GridView1.BestFitColumns();
			DataNavigator1.DataSource = RuntimeHelpers.GetObjectValue(dgvEmpleado.DataSource);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}
```

### btn_eliminar_Click · líneas 1492–1500

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1492](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1492)

```csharp
private void btn_eliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (MessageBox.Show("Esta seguro de eliminar al Empleado: " + GridView1.GetRowCellValue(focusedRowHandle, "Codigo").ToString(), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			objClassRRHH.Actualiza_Empleado(Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo")));
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
```

### btn_FichaSocial_Click · líneas 1502–1547

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1502](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1502)

```csharp
private void btn_FichaSocial_Click(object sender, EventArgs e)
	{
		FrmFichaSocial frmFichaSocial = new FrmFichaSocial();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (!RRHH.Bienestar)
		{
			if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
			{
				if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
				{
					MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
			{
				if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
				{
					MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
			else if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
				frmFichaSocial.ShowDialog();
			}
		}
		else
		{
			frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmFichaSocial.ShowDialog();
		}
	}
```

### BtnImprimir_Click · líneas 1549–1563

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1549](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1549)

```csharp
private void BtnImprimir_Click(object sender, EventArgs e)
	{
		FrmReportFicha frmReportFicha = new FrmReportFicha();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Primero debe Seleccionar un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int codempleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmReportFicha.Codempleado = codempleado;
		frmReportFicha.WindowState = FormWindowState.Maximized;
		frmReportFicha.MdiParent = MyProject.Forms.MainMDI;
		frmReportFicha.Show();
	}
```

### dgvEmpleado_DoubleClick · líneas 1565–1604

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1565](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1565)

```csharp
private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
		if (objClassRRHH.CodigoEmpleado == 0)
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		else if ((Conversions.ToDouble(RRHH.IdROl) == 10.0) | (Conversions.ToDouble(RRHH.IdROl) == 14.0) | (Conversions.ToDouble(RRHH.IdROl) == 5.0))
		{
			MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
	}
```

### BtnArchivo_Click · líneas 1606–1633

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1606](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1606)

```csharp
private void BtnArchivo_Click(object sender, EventArgs e)
	{
		FrmListaArchivos frmListaArchivos = new FrmListaArchivos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), 2, TextCompare: false))
			{
				MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmListaArchivos.ShowDialog();
		}
		else if (Operators.ConditionalCompareObjectNotEqual(GridView1.GetRowCellValue(focusedRowHandle, "IdTipoTrabajador"), RRHH.Partida, TextCompare: false))
		{
			MessageBox.Show("Usted No Tiene Permiso para Acceder a esta Información", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmListaArchivos.ShowDialog();
		}
	}
```

### UcTxtApellido_KeyPress · líneas 1635–1641

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1635](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1635)

```csharp
private void UcTxtApellido_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
```

### FrmBuscarPersona_Load · líneas 1643–1710

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1643](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1643)

```csharp
private void FrmBuscarPersona_Load(object sender, EventArgs e)
	{
		checked
		{
			if (RRHH.Bienestar)
			{
				btn_FichaSocial.Text = "Ficha Social";
				BtnArchivo.Visible = false;
				btn_nuevo.Visible = false;
				btn_editar.Visible = false;
				btn_eliminar.Visible = false;
				BtnArchivo.Enabled = false;
				btn_nuevo.Enabled = false;
				btn_editar.Enabled = false;
				btn_eliminar.Enabled = false;
				Button button = btn_FichaSocial;
				Point location = new Point(15, Height - 113);
				button.Location = location;
				BtnAsistenciaManual.Visible = false;
				BtnPermiso.Visible = false;
				BtnSuspender.Visible = false;
				btnMarcacionAutorizada.Visible = false;
			}
			if (RRHH.Asistencias)
			{
				BtnArchivo.Enabled = false;
				BtnArchivo.Visible = false;
				btn_nuevo.Enabled = false;
				btn_nuevo.Visible = false;
				btn_editar.Enabled = false;
				btn_editar.Visible = false;
				btn_eliminar.Enabled = false;
				btn_eliminar.Visible = false;
				btn_FichaSocial.Enabled = false;
				btn_FichaSocial.Visible = false;
				BtnImprimir.Enabled = false;
				BtnImprimir.Visible = false;
				BtnAsistenciaManual.Enabled = true;
				Button btnPermiso = BtnPermiso;
				Point location = new Point(15, Height - 113);
				btnPermiso.Location = location;
				Button btnAsistenciaManual = BtnAsistenciaManual;
				location = new Point(78, Height - 113);
				btnAsistenciaManual.Location = location;
				Button button2 = btnMarcacionAutorizada;
				location = new Point(178, Height - 113);
				button2.Location = location;
				BtnSuspender.Visible = true;
				Button btnSuspender = BtnSuspender;
				location = new Point(298, Height - 113);
				btnSuspender.Location = location;
			}
			else if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
			{
				BtnSuspender.Visible = false;
				BtnAsistenciaManual.Enabled = false;
				BtnPermiso.Enabled = false;
				btnMarcacionAutorizada.Enabled = false;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 15.0)
			{
				BtnPermiso.Visible = false;
				BtnAsistenciaManual.Visible = false;
				btnMarcacionAutorizada.Visible = false;
				BtnSuspender.Visible = false;
			}
		}
	}
```

### Button1_Click_1 · líneas 1712–1723

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1712](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1712)

```csharp
private void Button1_Click_1(object sender, EventArgs e)
	{
		FrmConsultaPermisos frmConsultaPermisos = new FrmConsultaPermisos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmConsultaPermisos.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmConsultaPermisos.ShowDialog();
	}
```

### UcTxtApellido_TextChanged · líneas 1725–1727

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1725](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1725)

```csharp
private void UcTxtApellido_TextChanged(object sender, EventArgs e)
	{
	}
```

### BtnAsistenciaManual_Click · líneas 1729–1740

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1729](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1729)

```csharp
private void BtnAsistenciaManual_Click(object sender, EventArgs e)
	{
		FrmAsistenciaManual frmAsistenciaManual = new FrmAsistenciaManual();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmAsistenciaManual.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmAsistenciaManual.Show();
	}
```

### btnMarcacionAutorizada_Click · líneas 1742–1753

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1742](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1742)

```csharp
private void btnMarcacionAutorizada_Click(object sender, EventArgs e)
	{
		FrmMarcacionesAutorizadas frmMarcacionesAutorizadas = new FrmMarcacionesAutorizadas();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmMarcacionesAutorizadas.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMarcacionesAutorizadas.Show();
	}
```

### dgvEmpleado_Click · líneas 1755–1757

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1755](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1755)

```csharp
private void dgvEmpleado_Click(object sender, EventArgs e)
	{
	}
```

### BtnSuspender_Click · líneas 1759–1770

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1759](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1759)

```csharp
private void BtnSuspender_Click(object sender, EventArgs e)
	{
		FrmSuspenderAsistencia frmSuspenderAsistencia = new FrmSuspenderAsistencia();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmSuspenderAsistencia.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmSuspenderAsistencia.Show();
	}
```

### btnAsegurado_Click · líneas 1772–1774

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1772](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1772)

```csharp
private void btnAsegurado_Click(object sender, EventArgs e)
	{
	}
```

### PanelSup_Paint · líneas 1776–1778

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1776](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1776)

```csharp
private void PanelSup_Paint(object sender, PaintEventArgs e)
	{
	}
```

### btnHorarios_Click · líneas 1780–1791

[Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs:1780](../../Software/RecursosHumanos/RecursosHumanos/FrmBuscarPersona.cs#L1780)

```csharp
private void btnHorarios_Click(object sender, EventArgs e)
	{
		FrmConsultaHorarioEsp frmConsultaHorarioEsp = new FrmConsultaHorarioEsp();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmConsultaHorarioEsp.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmConsultaHorarioEsp.Show();
	}
```

<a id="f-007"></a>

## FrmCapacitaciones


### FrmCapacitaciones · líneas 232–238

[Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs:232](../../Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs#L232)

```csharp
public FrmCapacitaciones()
	{
		base.Load += FrmCapacitaciones_Load;
		__ENCAddToList(this);
		capacitacion = new Capacitacion();
		InitializeComponent();
	}
```

### FrmCapacitaciones_Load · líneas 521–523

[Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs:521](../../Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs#L521)

```csharp
private void FrmCapacitaciones_Load(object sender, EventArgs e)
	{
	}
```

### btnGrabar_Click · líneas 525–566

[Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs:525](../../Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs#L525)

```csharp
private void btnGrabar_Click(object sender, EventArgs e)
	{
		int idCapacitacion;
		if (CapacitacionMapper.Instance().SelectAll().Count == 0)
		{
			idCapacitacion = 1;
		}
		else
		{
			idCapacitacion = CapacitacionMapper.Instance().SelectAll().Max([SpecialName] (Capacitacion v) => v.IdCapacitacion);
			idCapacitacion = checked(idCapacitacion + 1);
		}
		capacitacion.FechaFin = UcDTTermino.Value;
		capacitacion.FechaInicio = UcDTInicio.Value;
		capacitacion.IdEmpleado = codemple;
		capacitacion.IdCapacitacion = idCapacitacion;
		if (UcTxtCurso.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre del Curso y/o Capacitación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtCurso.Focus();
			return;
		}
		capacitacion.NombreCurso = UcTxtCurso.Text;
		if (UcTxtInstOrganiz.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre de la Institucion Organizadora", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtInstOrganiz.Focus();
			return;
		}
		capacitacion.InstitucionOrganizadora = UcTxtInstOrganiz.Text;
		if (UcTxtHoras.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Número total de horas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			UcTxtHoras.Focus();
		}
		else
		{
			capacitacion.NumHoras = UcTxtHoras.Text;
			CapacitacionMapper.Instance().Insert(capacitacion);
			DialogResult = DialogResult.OK;
		}
	}
```

### BtnCerrar_Click · líneas 568–571

[Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs:568](../../Software/RecursosHumanos/RecursosHumanos/FrmCapacitaciones.cs#L568)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-008"></a>

## FrmConsultaAsistDiaria


### FrmConsultaAsistDiaria · líneas 493–499

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:493](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L493)

```csharp
public FrmConsultaAsistDiaria()
	{
		base.Load += FrmConsultaAsistDiaria_Load;
		__ENCAddToList(this);
		obj = new RRHHClass();
		InitializeComponent();
	}
```

### BtnConsultar_Click · líneas 903–965

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:903](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L903)

```csharp
private void BtnConsultar_Click(object sender, EventArgs e)
	{
		int? area;
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCBArea.SelectedValue, 0, TextCompare: false))
		{
			area = null;
		}
		else
		{
			object selectedValue = UcCBArea.SelectedValue;
			area = ((selectedValue != null) ? ((int?)selectedValue) : num);
		}
		int? tipo;
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			tipo = null;
		}
		else
		{
			object selectedValue2 = UcCBPartidaPresupuestal.SelectedValue;
			tipo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridView1.Columns.Clear();
		string text = "";
		checked
		{
			int num2 = ChckListLocal.ItemCount - 1;
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num3) == CheckState.Checked)
				{
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num3), ",")));
				}
				num3++;
			}
			if (RadioGroup1.SelectedIndex == 0)
			{
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
					GridControl1.DataSource = obj.spRRHH_RepAsisdiarria(fechaI, fechaF, null, area, tipo, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text);
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				GridControl1.DataSource = obj.spRRHH_RepAsisdiarria(fechaI, fechaF, UcTxtDNI.Text.Trim(), num, num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), text);
			}
		}
	}
```

### Button2_Click · líneas 967–1052

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:967](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L967)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Export_Asitencias_diaria_" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Export_Asitencias_diaria";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		GridColumnCollection columns = GridView1.Columns;
		array6[1] = columns.Count;
		array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
		object[] array7 = array3;
		object[] arguments2 = array7;
		array2 = new bool[2] { false, true };
		object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
			{
				num,
				columns.Count,
				RuntimeHelpers.GetObjectValue(array7[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Asistencia" }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
		array7 = new object[2] { "A3", null };
		object[] array8 = array7;
		obj2 = objectValue3;
		object instance4 = obj2;
		object[] array9 = new object[2];
		object[] array10 = array9;
		num = 3;
		array10[0] = num;
		object[] array11 = array9;
		columns = GridView1.Columns;
		array11[1] = columns.Count;
		array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
		array = array7;
		object[] arguments3 = array;
		array2 = new bool[2] { false, true };
		object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
			{
				num,
				columns.Count,
				RuntimeHelpers.GetObjectValue(array[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + UcFechas1.Rango.Desde.ToLongDateString() + " Al: " + UcFechas1.Rango.Hasta.ToLongDateString() }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
	}
```

### FrmConsultaAsistDiaria_Load · líneas 1054–1082

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:1054](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L1054)

```csharp
private void FrmConsultaAsistDiaria_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)obj.llena_Area();
		DataRow dataRow = dataTable.NewRow();
		dataRow["idAreaOrganiz"] = 0;
		dataRow["AreaOrganizacional"] = "--TODOS--";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBArea.DataSource = dataTable;
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--TODOS--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		List<Local> list2 = LocalMapper.Instance().SelectAll();
		list2.Insert(0, new Local
		{
			idLocal = 0,
			NombreLocal = "TODOS"
		});
		ChckListLocal.ValueMember = "idLocal";
		ChckListLocal.DisplayMember = "NombreLocal";
		ChckListLocal.DataSource = list2;
	}
```

### RadioGroup1_SelectedIndexChanged · líneas 1084–1104

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:1084](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L1084)

```csharp
private void RadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (RadioGroup1.SelectedIndex == 0)
		{
			Label2.Visible = true;
			UcCBArea.Visible = true;
			Label3.Visible = true;
			UcCBPartidaPresupuestal.Visible = true;
			Label4.Visible = false;
			UcTxtDNI.Visible = false;
		}
		else
		{
			Label2.Visible = false;
			UcCBArea.Visible = false;
			Label3.Visible = false;
			UcCBPartidaPresupuestal.Visible = false;
			Label4.Visible = true;
			UcTxtDNI.Visible = true;
		}
	}
```

### ChckListLocal_SelectedIndexChanged · líneas 1106–1108

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:1106](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L1106)

```csharp
private void ChckListLocal_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
```

### ChckListLocal_ItemCheck · líneas 1110–1157

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs:1110](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistDiaria.cs#L1110)

```csharp
private void ChckListLocal_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListLocal.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListLocal.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListLocal.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListLocal.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListLocal.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListLocal.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}
```

<a id="f-009"></a>

## FrmConsultaAsistencias


### FrmConsultaAsistencias · líneas 384–391

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:384](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L384)

```csharp
public FrmConsultaAsistencias()
	{
		base.FormClosing += FrmConsultaAsistencias_FormClosing;
		base.Load += FrmConsultaAsistencias_Load;
		__ENCAddToList(this);
		obj = new RRHHClass();
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 725–940

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:725](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L725)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Tipo de Trabajador", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		WindowState = FormWindowState.Maximized;
		GridView1.Columns.Clear();
		fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		string text = "[";
		int num = 0;
		TimeSpan timeSpan = UcFechas1.Rango.Hasta - UcFechas1.Rango.Desde;
		double totalDays = timeSpan.TotalDays;
		double num2 = 0.0;
		checked
		{
			while (true)
			{
				double num3 = num2;
				double num4 = totalDays;
				if (!(num3 <= num4))
				{
					break;
				}
				text = text + Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num2)) + "] , [";
				if ((UcFechas1.Rango.Desde.AddDays(num2).DayOfWeek == DayOfWeek.Saturday) | (UcFechas1.Rango.Desde.AddDays(num2).DayOfWeek == DayOfWeek.Sunday))
				{
					num++;
				}
				num2 += 1.0;
			}
			string text2 = "";
			int num5 = ChckListLocal.ItemCount - 1;
			int num6 = 1;
			while (true)
			{
				int num7 = num6;
				int num8 = num5;
				if (num7 > num8)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num6) == CheckState.Checked)
				{
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num6), ",")));
				}
				num6++;
			}
			if (text2.Length > 0)
			{
				text2 = text2.Substring(0, text2.Length - 1);
				PostgreSqlLegacyContext dcGrll = Module1.DcGrll;
				string fI = fi;
				string obj = ff;
				int? anio = 2011;
				object selectedValue = UcCBPartidaPresupuestal.SelectedValue;
				int? num9 = default(int?);
				dcGrll.spRRHH_GetReporteAsistencia(fI, obj, anio, (selectedValue != null) ? ((int?)selectedValue) : num9);
				GridControl1.DataSource = RuntimeHelpers.GetObjectValue(this.obj.LlenarPlanillaAsistencia(text.Substring(0, text.Length - 3), Conversions.ToString(UcCBPartidaPresupuestal.SelectedValue), text2));
				double totalDays2 = timeSpan.TotalDays;
				double num10 = 0.0;
				while (true)
				{
					double num11 = num10;
					double num4 = totalDays2;
					if (!(num11 <= num4))
					{
						break;
					}
					int num12 = GridView1.Columns.Count - 1;
					int num13 = 0;
					while (true)
					{
						int num14 = num13;
						int num8 = num12;
						if (num14 > num8)
						{
							break;
						}
						GridView1.Columns[Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num10))].Caption = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(UcFechas1.Rango.Desde.AddDays(num10).Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.AddDays(num10).Day, UcFechas1.Rango.Desde.AddDays(num10).Day.ToString()), "/"), Interaction.IIf(UcFechas1.Rango.Desde.AddDays(num10).Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.AddDays(num10).Month, UcFechas1.Rango.Desde.AddDays(num10).Month.ToString())));
						GridView1.Columns[Conversions.ToString(UcFechas1.Rango.Desde.AddDays(num10))].BestFit();
						num13++;
					}
					num10 += 1.0;
				}
				GridView1.Columns["IdEmpleado"].Visible = false;
				GridView1.Columns["MinTardeT"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["MinTardeT"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["MinTardeT"].Caption = "Minutos Tarde";
				GridView1.Columns["DiasTardeT"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["DiasTardeT"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["DiasTardeT"].Caption = "Total Dias Tarde";
				GridView1.Columns["DiasAsistidos"].UnboundType = UnboundColumnType.String;
				GridView1.Columns["DiasAsistidos"].VisibleIndex = GridView1.Columns.Count;
				GridView1.Columns["DiasAsistidos"].Caption = "Total Dias Asistidos";
				GridView1.Columns["NombresC"].Width = 220;
				GridView1.Columns["NombresC"].Caption = "Nombres Completos";
				GridControl2.DataSource = Module1.DcGrll.spRRHH_GetMinTarde(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
				int num15 = GridView2.RowCount - 1;
				int num16 = 0;
				while (true)
				{
					int num17 = num16;
					int num8 = num15;
					if (num17 > num8)
					{
						break;
					}
					int num18 = GridView1.RowCount - 1;
					int num19 = 0;
					while (true)
					{
						int num20 = num19;
						num8 = num18;
						if (num20 > num8)
						{
							break;
						}
						if (Operators.ConditionalCompareObjectEqual(GridView2.GetRowCellValue(num16, "IdEmpleado"), GridView1.GetRowCellValue(num19, "IdEmpleado"), TextCompare: false))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(GridView2.GetRowCellValue(num16, "Tarde"));
							object objectValue2 = RuntimeHelpers.GetObjectValue(GridView2.GetRowCellValue(num16, "DiasTarde"));
							GridView1.SetRowCellValue(num19, "MinTardeT", RuntimeHelpers.GetObjectValue(objectValue));
							GridView1.SetRowCellValue(num19, "DiasTardeT", RuntimeHelpers.GetObjectValue(objectValue2));
							break;
						}
						num19++;
					}
					num16++;
				}
				if (Operators.ConditionalCompareObjectEqual(RadioGroupTipo.EditValue, "A", TextCompare: false))
				{
					GridControl3.DataSource = Module1.DcGrll.spRRHH_GetDiasAsistidos(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
					int num21 = GridView3.RowCount - 1;
					int num22 = 0;
					while (true)
					{
						int num23 = num22;
						int num8 = num21;
						if (num23 > num8)
						{
							break;
						}
						int num24 = GridView1.RowCount - 1;
						int num25 = 0;
						while (true)
						{
							int num26 = num25;
							num8 = num24;
							if (num26 > num8)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(GridView3.GetRowCellValue(num22, "IdEmpleado"), GridView1.GetRowCellValue(num25, "IdEmpleado"), TextCompare: false))
							{
								object obj2 = Operators.AddObject(num, GridView3.GetRowCellValue(num22, "Dias_Asistidos"));
								GridView1.SetRowCellValue(num25, "DiasAsistidos", RuntimeHelpers.GetObjectValue(obj2));
								break;
							}
							num25++;
						}
						num22++;
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(RadioGroupTipo.EditValue, "P", TextCompare: false))
				{
					GridControl3.DataSource = Module1.DcGrll.spRRHH_GetDiasAsistidos(fi, ff, Conversions.ToChar(UcCBPartidaPresupuestal.SelectedValue.ToString()));
					int num27 = GridView3.RowCount - 1;
					int num28 = 0;
					while (true)
					{
						int num29 = num28;
						int num8 = num27;
						if (num29 > num8)
						{
							break;
						}
						int num30 = GridView1.RowCount - 1;
						int num31 = 0;
						while (true)
						{
							int num32 = num31;
							num8 = num30;
							if (num32 > num8)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(GridView3.GetRowCellValue(num28, "IdEmpleado"), GridView1.GetRowCellValue(num31, "IdEmpleado"), TextCompare: false))
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num28, "Dias_Asistidos"));
								GridView1.SetRowCellValue(num31, "DiasAsistidos", RuntimeHelpers.GetObjectValue(objectValue3));
								break;
							}
							num31++;
						}
						num28++;
					}
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Tipo de Reporte para Continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
```

### FrmConsultaAsistencias_FormClosing · líneas 942–952

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:942](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L942)

```csharp
private void FrmConsultaAsistencias_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (objLibroExcel != null)
		{
			EiminaReferencias(ref objHojaExcel);
			EiminaReferencias(ref objLibroExcel);
			EiminaReferencias(ref m_Excel);
		}
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}
```

### FrmConsultaAsistencias_Load · líneas 954–988

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:954](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L954)

```csharp
private void FrmConsultaAsistencias_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		List<Local> list2 = LocalMapper.Instance().SelectAll();
		list2.Insert(0, new Local
		{
			idLocal = 0,
			NombreLocal = "TODOS"
		});
		ChckListLocal.ValueMember = "idLocal";
		ChckListLocal.DisplayMember = "NombreLocal";
		ChckListLocal.DataSource = list2;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}
```

### Button1_Click · líneas 990–1207

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:990](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L990)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Asistencias" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Asistencias_" + fi + "_" + ff;
		GridControl1.ExportToXls(text2, xlsExportOptions);
		if (!MyProject.Computer.FileSystem.FileExists(text2))
		{
			Interaction.MsgBox(text2 + " No Existe");
			return;
		}
		m_Excel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(m_Excel, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		objLibroExcel = RuntimeHelpers.GetObjectValue(obj);
		objHojaExcel = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objLibroExcel, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.RutaLogo))
		{
			object instance2 = NewLateBinding.LateGet(objHojaExcel, null, "Shapes", new object[0], null, null, null);
			array = new object[7];
			object[] array3 = array;
			MySettings settings = MySettingsProperty.Settings;
			array3[0] = settings.RutaLogo;
			array[1] = MsoTriState.msoFalse;
			array[2] = MsoTriState.msoCTrue;
			array[3] = 5;
			array[4] = 5;
			array[5] = 50;
			array[6] = 50;
			object[] array4 = array;
			object[] arguments2 = array4;
			array2 = new bool[7] { true, false, false, false, false, false, false };
			NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "RowHeight", new object[1] { 48 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "Orientation", new object[1] { 90 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		checked
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance3 = objHojaExcel;
			object[] array4 = new object[2] { "A2", null };
			object[] array5 = array4;
			object obj2 = objHojaExcel;
			object instance4 = obj2;
			array = new object[2];
			object[] array6 = array;
			int num = 2;
			array6[0] = num;
			object[] array7 = array;
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(instance3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Asistencias" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance6 = objHojaExcel;
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objHojaExcel;
			object instance7 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance7, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance8 = NewLateBinding.LateGet(instance6, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance8, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "PrintTitleRows", new object[1] { "$1:$6" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				1
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Leyenda:" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				2
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Abrev" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				3
			}, null, null, null), null, "FormulaR1C1", new object[1] { "Descripción" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				1
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				2
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				GridView1.RowCount + 7,
				3
			}, null, null, null), null, "Font", new object[0], null, null, null), null, "Bold", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			DataTable dataTable = new DataTable();
			dataTable = this.obj.spRRHH_ListarMotivos_byTipo("P");
			int num3 = dataTable.Rows.Count - 1;
			int num4 = 0;
			while (true)
			{
				int num5 = num4;
				int num6 = num3;
				if (num5 > num6)
				{
					break;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "FormulaR1C1", new object[1] { dataTable.Rows[num4]["Abrev"].ToString() }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 8 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Name", new object[1] { "Tahoma" }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					2
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Italic", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "FormulaR1C1", new object[1] { dataTable.Rows[num4][1].ToString() }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 8 }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Name", new object[1] { "Tahoma" }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
				{
					GridView1.RowCount + 8 + num4,
					3
				}, null, null, null), null, "Font", new object[0], null, null, null), null, "Italic", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
				num4++;
			}
			NewLateBinding.LateSet(m_Excel, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

### EiminaReferencias · líneas 1209–1224

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1209](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1209)

```csharp
private void EiminaReferencias(ref object Referencias)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(Referencias));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Referencias = null;
		}
	}
```

### ChckListLocal_ItemCheck · líneas 1226–1273

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1226](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1226)

```csharp
private void ChckListLocal_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListLocal.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListLocal.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListLocal.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListLocal.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListLocal.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListLocal.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}
```

### ChckListLocal_SelectedIndexChanged · líneas 1275–1277

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs:1275](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaAsistencias.cs#L1275)

```csharp
private void ChckListLocal_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
```

<a id="f-010"></a>

## FrmConsultaFaltas


### FrmConsultaFaltas · líneas 384–390

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:384](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L384)

```csharp
public FrmConsultaFaltas()
	{
		base.Load += FrmConsultaFaltas_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmConsultaFaltas_Load · líneas 731–750

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:731](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L731)

```csharp
private void FrmConsultaFaltas_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)objClassRRHH.llena_Area();
		DataRow dataRow = dataTable.NewRow();
		dataRow["idAreaOrganiz"] = 0;
		dataRow["AreaOrganizacional"] = "--TODOS--";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBArea.DataSource = dataTable;
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--TODOS--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
	}
```

### BtnConsultar_Click · líneas 752–780

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:752](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L752)

```csharp
private void BtnConsultar_Click(object sender, EventArgs e)
	{
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCBArea.SelectedValue, 0, TextCompare: false))
		{
			area = null;
		}
		else
		{
			object selectedValue = UcCBArea.SelectedValue;
			area = ((selectedValue != null) ? ((int?)selectedValue) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			tipo = null;
		}
		else
		{
			object selectedValue2 = UcCBPartidaPresupuestal.SelectedValue;
			tipo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(UcDateTime1.Value.Day.ToString().Length == 1, "0" + UcDateTime1.Value.Day, UcDateTime1.Value.Day.ToString()), "/"), Interaction.IIf(UcDateTime1.Value.Month.ToString().Length == 1, "0" + UcDateTime1.Value.Month, UcDateTime1.Value.Month.ToString())), "/"), UcDateTime1.Value.Year.ToString()));
		GridControl1.DataSource = Module1.DcGrll.spRRHH_Faltas(fecha, tipo, area, 2008);
		if (area.HasValue)
		{
			GridView1.Columns["AreaOrganizacional"].Visible = false;
		}
		Lbl_Faltas.Text = Conversions.ToString(GridView1.RowCount);
	}
```

### BtnExportar_Click · líneas 782–894

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs:782](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaFaltas.cs#L782)

```csharp
private void BtnExportar_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Faltas" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Faltas";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object instance2 = NewLateBinding.LateGet(objectValue3, null, "Shapes", new object[0], null, null, null);
		array = new object[7];
		object[] array3 = array;
		MySettings settings = MySettingsProperty.Settings;
		array3[0] = settings.RutaLogo;
		array[1] = MsoTriState.msoFalse;
		array[2] = MsoTriState.msoCTrue;
		array[3] = 5;
		array[4] = 5;
		array[5] = 50;
		array[6] = 50;
		object[] array4 = array;
		object[] arguments2 = array4;
		array2 = new bool[7] { true, false, false, false, false, false, false };
		NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
		if (array2[0])
		{
			settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		array4 = new object[2] { "A2", null };
		object[] array5 = array4;
		object obj2 = objectValue3;
		object instance3 = obj2;
		array = new object[2];
		object[] array6 = array;
		int num = 2;
		array6[0] = num;
		object[] array7 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance3, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance4 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance4, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Faltas" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objectValue3;
			object instance5 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance5, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance6 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance6, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + UcDateTime1.Value.ToLongDateString() }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"[CLAVE DE PROTECCIÓN OCULTA]", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

<a id="f-011"></a>

## FrmConsultaHorarioEsp


### FrmConsultaHorarioEsp · líneas 567–574

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:567](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L567)

```csharp
public FrmConsultaHorarioEsp()
	{
		base.Load += FrmConsultaHorarioEsp_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmConsultaHorarioEsp_Load · líneas 1014–1037

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1014](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1014)

```csharp
private void FrmConsultaHorarioEsp_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			}
		}
		GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
	}
```

### cmdCerrar_Click · líneas 1039–1042

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1039](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1039)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### Button1_Click · líneas 1044–1054

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1044](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1044)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		FrmHorarioEsp frmHorarioEsp = new FrmHorarioEsp();
		frmHorarioEsp.idEmpleado = idEmpleado;
		frmHorarioEsp.Npermiso = 0;
		frmHorarioEsp.ShowDialog();
		if (frmHorarioEsp.DialogResult == DialogResult.OK)
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
		}
	}
```

### BtnModificar_Click · líneas 1056–1072

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1056](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1056)

```csharp
private void BtnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "N"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		FrmHorarioEsp frmHorarioEsp = new FrmHorarioEsp();
		frmHorarioEsp.idEmpleado = idEmpleado;
		frmHorarioEsp.Npermiso = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "N"));
		frmHorarioEsp.ShowDialog();
		if (frmHorarioEsp.DialogResult == DialogResult.OK)
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_HorariosTemporales(idEmpleado));
		}
	}
```

### BtnEliminar_Click · líneas 1074–1093

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1074](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1074)

```csharp
private void BtnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "N"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Desea eliminar el permiso de la fecha: ", GridView1.GetRowCellValue(focusedRowHandle, "FechaInicio")), " al "), GridView1.GetRowCellValue(focusedRowHandle, "FechaFin"))), "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		{
			if (objClassRRHH.eliminarHorarioTemporal(idEmpleado, Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "N"))))
			{
				MessageBox.Show("Se eliminó exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				FrmConsultaHorarioEsp_Load(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else
			{
				MessageBox.Show("Se generó un error durante la operacion, por favor intételo nuevamente mas tarde", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}
```

### Button2_Click · líneas 1095–1188

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs:1095](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaHorarioEsp.cs#L1095)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_HorariosTemporales" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_HorariosTemporales_";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array6[1] = num2;
			array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
			object[] array7 = array3;
			object[] arguments2 = array7;
			array2 = new bool[2] { false, true };
			object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array7[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Horarios Temporales" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array7 = new object[2] { "A3", null };
			object[] array8 = array7;
			obj2 = objectValue3;
			object instance4 = obj2;
			object[] array9 = new object[2];
			object[] array10 = array9;
			num = 3;
			array10[0] = num;
			object[] array11 = array9;
			num2 = GridView1.Columns.Count - 1;
			array11[1] = num2;
			array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
			array = array7;
			object[] arguments3 = array;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "De: " + UcTxtApePater.Text + " " + UcTxtApeMater.Text + " " + UcTxtNombres.Text }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"[CLAVE DE PROTECCIÓN OCULTA]", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

<a id="f-012"></a>

## FrmConsultaPermisos


### FrmConsultaPermisos · líneas 760–767

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:760](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L760)

```csharp
public FrmConsultaPermisos()
	{
		base.Load += FrmConsultaPermisos_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmConsultaPermisos_Load · líneas 1371–1404

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1371](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1371)

```csharp
private void FrmConsultaPermisos_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			}
		}
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "--TODOS--"
		});
		UcCmbTipoPermiso.DisplayMember = "DescripTipoPermiso";
		UcCmbTipoPermiso.ValueMember = "idTipoPermiso";
		UcCmbTipoPermiso.DataSource = list;
		int? num = default(int?);
		GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Permisos(idEmpleado, num, num));
	}
```

### UcCmbTipoPermiso_SelectedIndexChanged · líneas 1406–1456

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1406](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1406)

```csharp
private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		ucComboBox ucCmbMotivo = UcCmbMotivo;
		ucCmbMotivo.DisplayMember = "Descrip_Motivo";
		ucCmbMotivo.ValueMember = "idMotivo";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "P", TextCompare: false) == 0)));
			list.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "C", TextCompare: false) == 0)));
			list2.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Operators.ConditionalCompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false));
			list3.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list3;
		}
		ucCmbMotivo = null;
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 0, TextCompare: false))
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Permisos(idEmpleado, num, num));
			UcCmbMotivo.SelectedIndex = 0;
			UcCmbMotivo.Enabled = false;
			return;
		}
		UcCmbMotivo.Enabled = true;
		GridControl gridControl = GridControl1;
		RRHHClass rRHHClass = objClassRRHH;
		int codempleado = idEmpleado;
		object selectedValue = UcCmbTipoPermiso.SelectedValue;
		gridControl.DataSource = RuntimeHelpers.GetObjectValue(rRHHClass.llena_Permisos(codempleado, (selectedValue != null) ? ((int?)selectedValue) : num, num));
	}
```

### Button1_Click · líneas 1458–1470

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1458](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1458)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		FrmPermiso frmPermiso = new FrmPermiso();
		frmPermiso.idEmpleado = idEmpleado;
		frmPermiso.Npermiso = 0;
		frmPermiso.ShowDialog();
		if (frmPermiso.DialogResult == DialogResult.OK)
		{
			int? num = default(int?);
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Permisos(idEmpleado, num, num));
			UcCmbTipoPermiso.SelectedValue = 0;
		}
	}
```

### UcCmbMotivo_SelectedIndexChanged · líneas 1472–1487

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1472](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1472)

```csharp
private void UcCmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
	{
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Permisos(idEmpleado, num, num));
			return;
		}
		GridControl gridControl = GridControl1;
		RRHHClass rRHHClass = objClassRRHH;
		int codempleado = idEmpleado;
		object selectedValue = UcCmbTipoPermiso.SelectedValue;
		int? permiso = ((selectedValue != null) ? ((int?)selectedValue) : num);
		object selectedValue2 = UcCmbMotivo.SelectedValue;
		gridControl.DataSource = RuntimeHelpers.GetObjectValue(rRHHClass.llena_Permisos(codempleado, permiso, (selectedValue2 != null) ? ((int?)selectedValue2) : num));
	}
```

### Button2_Click · líneas 1489–1582

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1489](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1489)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Permisos" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Permisos_";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array6[1] = num2;
			array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
			object[] array7 = array3;
			object[] arguments2 = array7;
			array2 = new bool[2] { false, true };
			object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array7[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Permisos" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array7 = new object[2] { "A3", null };
			object[] array8 = array7;
			obj2 = objectValue3;
			object instance4 = obj2;
			object[] array9 = new object[2];
			object[] array10 = array9;
			num = 3;
			array10[0] = num;
			object[] array11 = array9;
			num2 = GridView1.Columns.Count - 1;
			array11[1] = num2;
			array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
			array = array7;
			object[] arguments3 = array;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "De: " + UcTxtApePater.Text + " " + UcTxtApeMater.Text + " " + UcTxtNombres.Text }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"[CLAVE DE PROTECCIÓN OCULTA]", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

### BtnModificar_Click · líneas 1584–1602

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1584](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1584)

```csharp
private void BtnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "NPermiso"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		FrmPermiso frmPermiso = new FrmPermiso();
		frmPermiso.idEmpleado = idEmpleado;
		frmPermiso.Npermiso = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "NPermiso"));
		frmPermiso.ShowDialog();
		if (frmPermiso.DialogResult == DialogResult.OK)
		{
			int? num = default(int?);
			GridControl1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Permisos(idEmpleado, num, num));
			UcCmbTipoPermiso.SelectedValue = 0;
		}
	}
```

### BtnEliminar_Click · líneas 1604–1623

[Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs:1604](../../Software/RecursosHumanos/RecursosHumanos/FrmConsultaPermisos.cs#L1604)

```csharp
private void BtnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "NPermiso"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Desea eliminar el permiso de la fecha: ", GridView1.GetRowCellValue(focusedRowHandle, "FechaInicio")), " al "), GridView1.GetRowCellValue(focusedRowHandle, "FechaFin"))), "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		{
			if (objClassRRHH.ElimnarPermiso(idEmpleado, Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "NPermiso"))))
			{
				MessageBox.Show("Se eliminó exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				FrmConsultaPermisos_Load(RuntimeHelpers.GetObjectValue(sender), e);
			}
			else
			{
				MessageBox.Show("Se generó un error durante la operacion, por favor intételo nuevamente mas tarde", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}
```

<a id="f-013"></a>

## FrmDisciplina


### FrmDisciplina · líneas 232–238

[Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs:232](../../Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs#L232)

```csharp
[DebuggerNonUserCode]
	public FrmDisciplina()
	{
		base.Load += FrmDisciplina_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### btnGrabar_Click · líneas 523–576

[Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs:523](../../Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs#L523)

```csharp
private void btnGrabar_Click(object sender, EventArgs e)
	{
		Comportamiento comportamiento = new Comportamiento();
		if (UcTxtNumDocumento.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar una Resolución Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.NumResol = UcTxtNumDocumento.Text.Trim();
		if (UcTxtTitulo.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar un Título Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.Titulo = UcTxtTitulo.Text.Trim();
		if (UcTxtDescrip.TextLength < 0)
		{
			MessageBox.Show("Debe Ingresar una Descripción Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			return;
		}
		comportamiento.Descripcion = UcTxtDescrip.Text.Trim();
		comportamiento.Fecha = UcDTFecha.Value;
		comportamiento.IdEmpleado = CodEmple;
		if (CodDisci == 0)
		{
			int idComportamiento;
			if (ComportamientoMapper.Instance().SelectAll().Count == 0)
			{
				idComportamiento = 1;
			}
			else
			{
				idComportamiento = ComportamientoMapper.Instance().SelectAll().Max([SpecialName] (Comportamiento v) => v.idComportamiento);
				idComportamiento = checked(idComportamiento + 1);
			}
			comportamiento.idComportamiento = idComportamiento;
		}
		else
		{
			comportamiento.idComportamiento = CodDisci;
		}
		object selectedValue = UcCBTipoCompor.SelectedValue;
		int? num = default(int?);
		comportamiento.idTipoComportamiento = ((selectedValue != null) ? ((int?)selectedValue) : num);
		if (CodDisci == 0)
		{
			ComportamientoMapper.Instance().Insert(comportamiento);
		}
		else
		{
			ComportamientoMapper.Instance().Update(comportamiento);
		}
		DialogResult = DialogResult.OK;
	}
```

### FrmDisciplina_Load · líneas 578–593

[Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs:578](../../Software/RecursosHumanos/RecursosHumanos/FrmDisciplina.cs#L578)

```csharp
private void FrmDisciplina_Load(object sender, EventArgs e)
	{
		UcCBTipoCompor.DisplayMember = "TipoCompDescrip";
		UcCBTipoCompor.ValueMember = "idTipoComportamiento";
		UcCBTipoCompor.DataSource = TipoComportamientoMapper.Instance().SelectAll();
		if (CodDisci != 0)
		{
			Comportamiento comportamiento = ComportamientoMapper.Instance().SelectOneBy([SpecialName] (Comportamiento v) => v.idComportamiento == CodDisci);
			UcCBTipoCompor.SelectedValue = comportamiento.idTipoComportamiento;
			UcCBTipoCompor.Enabled = false;
			UcTxtNumDocumento.Text = comportamiento.NumResol;
			UcDTFecha.Value = (DateTime)comportamiento.Fecha;
			UcTxtTitulo.Text = comportamiento.Titulo;
			UcTxtDescrip.Text = comportamiento.Descripcion;
		}
	}
```

<a id="f-014"></a>

## FrmDocumentos


### FrmDocumentos · líneas 260–267

[Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs:260](../../Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs#L260)

```csharp
public FrmDocumentos()
	{
		base.Load += FrmDocumentos_Load;
		__ENCAddToList(this);
		CodDocumento = 0;
		Archivo = new Archivo();
		InitializeComponent();
	}
```

### FrmDocumentos_Load · líneas 559–574

[Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs:559](../../Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs#L559)

```csharp
private void FrmDocumentos_Load(object sender, EventArgs e)
	{
		UcCmbDocumento.ValueMember = "idDocumento";
		UcCmbDocumento.DisplayMember = "DescripDocumento";
		UcCmbDocumento.DataSource = DocumentoMapper.Instance().SelectAll();
		if (CodDocumento != 0)
		{
			Archivo archivo = ArchivoMapper.Instance().SelectOneBy([SpecialName] (Archivo v) => (v.IdEmpleado == CodEmple) & (v.idDocumento == CodDocumento));
			UcCmbDocumento.SelectedValue = archivo.idDocumento;
			UcCmbDocumento.Enabled = false;
			UcDTIngreso.Value = (DateTime)archivo.FechaIngreDoc;
			UcDTVence.Value = (DateTime)archivo.FechaVenDoc;
			UcTxtReferencia.Text = archivo.NumRef;
			UcTxtObs.Text = archivo.Obs;
		}
	}
```

### BtnGrabar_Click · líneas 576–607

[Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs:576](../../Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs#L576)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		Archivo.idDocumento = Conversions.ToInteger(UcCmbDocumento.SelectedValue);
		Archivo.IdEmpleado = CodEmple;
		Archivo.FechaIngreDoc = UcDTIngreso.Value;
		Archivo.FechaVenDoc = UcDTVence.Value;
		if (UcTxtReferencia.TextLength == 0)
		{
			Archivo.NumRef = ((CodDocumento == 0) ? null : RRHH.nulo);
		}
		else
		{
			Archivo.NumRef = UcTxtReferencia.Text;
		}
		if (UcTxtObs.TextLength == 0)
		{
			Archivo.Obs = ((CodDocumento == 0) ? null : RRHH.nulo);
		}
		else
		{
			Archivo.Obs = UcTxtObs.Text;
		}
		if (CodDocumento == 0)
		{
			ArchivoMapper.Instance().Insert(Archivo);
		}
		else
		{
			ArchivoMapper.Instance().Update(Archivo);
		}
		DialogResult = DialogResult.OK;
	}
```

### BtnCerrar_Click · líneas 609–612

[Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs:609](../../Software/RecursosHumanos/RecursosHumanos/FrmDocumentos.cs#L609)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-015"></a>

## FrmEstudiosRealizados


### FrmEstudiosRealizados · líneas 281–287

[Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:281](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L281)

```csharp
public FrmEstudiosRealizados()
	{
		base.Load += FrmEstudiosRealizados_Load;
		__ENCAddToList(this);
		estudiorealizado = new EstudiosRealizado();
		InitializeComponent();
	}
```

### FrmEstudiosRealizados_Load · líneas 595–615

[Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:595](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L595)

```csharp
private void FrmEstudiosRealizados_Load(object sender, EventArgs e)
	{
		UcCBTipoEstudio.ValueMember = "IdTipoEstudios";
		UcCBTipoEstudio.DisplayMember = "DescripTipoEst";
		UcCBTipoEstudio.DataSource = TipoEstudioMapper.Instance().SelectAll();
		UcCBEstadoEstudio.ValueMember = "IdEstadoEstudio";
		UcCBEstadoEstudio.DisplayMember = "DescripEstadoEstudio";
		UcCBEstadoEstudio.DataSource = EstadoEstudioMapper.Instance().SelectAll();
		if (codEstudio != 0)
		{
			EstudiosRealizado estudiosRealizado = EstudiosRealizadoMapper.Instance().SelectOneBy([SpecialName] (EstudiosRealizado v) => (v.IdEmpleado == CodEmple) & (v.IdTipoEstudios == codEstudio));
			UcCBTipoEstudio.SelectedValue = estudiosRealizado.IdTipoEstudios;
			UcCBTipoEstudio.Enabled = false;
			UcTxtCentro.Text = estudiosRealizado.CentroEstudios;
			UcDTInicio.Value = (DateTime)estudiosRealizado.AñoInicio;
			UcDTFin.Value = (DateTime)estudiosRealizado.AñoTermino;
			UcCBEstadoEstudio.SelectedValue = estudiosRealizado.IdEstadoEstudio;
			UcTxt_Especialidad.Text = estudiosRealizado.Especialidad;
			Nrocorre = estudiosRealizado.Correlativo;
		}
	}
```

### Button1_Click · líneas 617–646

[Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:617](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L617)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		estudiorealizado.AñoInicio = UcDTInicio.Value;
		estudiorealizado.AñoTermino = UcDTFin.Value;
		EstudiosRealizado estudiosRealizado = estudiorealizado;
		object selectedValue = UcCBEstadoEstudio.SelectedValue;
		int? num = default(int?);
		estudiosRealizado.IdEstadoEstudio = ((selectedValue != null) ? ((int?)selectedValue) : num);
		estudiorealizado.IdEmpleado = CodEmple;
		estudiorealizado.IdTipoEstudios = Conversions.ToInteger(UcCBTipoEstudio.SelectedValue);
		if (UcTxtCentro.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar un Centro de Estudios", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		estudiorealizado.CentroEstudios = UcTxtCentro.Text;
		estudiorealizado.Especialidad = UcTxt_Especialidad.Text.Trim();
		estudiorealizado.Correlativo = Nrocorre;
		if ((codEstudio == 0) & (Nrocorre == 0))
		{
			int correlativo = ((EstudiosRealizadoMapper.Instance().SelectBy([SpecialName] (EstudiosRealizado x) => x.IdEmpleado == CodEmple).Count == 0) ? 1 : checked(((IEnumerable<EstudiosRealizado>)EstudiosRealizadoMapper.Instance().SelectBy([SpecialName] (EstudiosRealizado x) => x.IdEmpleado == CodEmple)).Max<EstudiosRealizado, int>((Func<EstudiosRealizado, int>)([SpecialName] (EstudiosRealizado b) => b.Correlativo)) + 1));
			estudiorealizado.Correlativo = correlativo;
			EstudiosRealizadoMapper.Instance().Insert(estudiorealizado);
		}
		else
		{
			EstudiosRealizadoMapper.Instance().Update(estudiorealizado);
		}
		DialogResult = DialogResult.OK;
	}
```

### BtnCerrar_Click · líneas 648–651

[Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:648](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L648)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### UcCBTipoEstudio_SelectedIndexChanged · líneas 653–705

[Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs:653](../../Software/RecursosHumanos/RecursosHumanos/FrmEstudiosRealizados.cs#L653)

```csharp
private void UcCBTipoEstudio_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreaterEqual(UcCBTipoEstudio.SelectedValue, 3, TextCompare: false))
		{
			Size size = new Size(339, 298);
			Size = size;
			Label6.Visible = true;
			UcTxt_Especialidad.Visible = true;
			ucDateTime ucDTInicio = UcDTInicio;
			Point location = new Point(107, 119);
			ucDTInicio.Location = location;
			Label label = Label2;
			location = new Point(18, 123);
			label.Location = location;
			ucDateTime ucDTFin = UcDTFin;
			location = new Point(107, 145);
			ucDTFin.Location = location;
			Label label2 = Label3;
			location = new Point(5, 149);
			label2.Location = location;
			ucComboBox ucCBEstadoEstudio = UcCBEstadoEstudio;
			location = new Point(107, 171);
			ucCBEstadoEstudio.Location = location;
			Label label3 = Label4;
			location = new Point(58, 174);
			label3.Location = location;
		}
		else
		{
			Size size = new Size(339, 279);
			Size = size;
			Label6.Visible = false;
			UcTxt_Especialidad.Visible = false;
			ucDateTime ucDTInicio2 = UcDTInicio;
			Point location = new Point(107, 93);
			ucDTInicio2.Location = location;
			Label label4 = Label2;
			location = new Point(18, 96);
			label4.Location = location;
			ucDateTime ucDTFin2 = UcDTFin;
			location = new Point(107, 119);
			ucDTFin2.Location = location;
			Label label5 = Label3;
			location = new Point(5, 123);
			label5.Location = location;
			ucComboBox ucCBEstadoEstudio2 = UcCBEstadoEstudio;
			location = new Point(107, 145);
			ucCBEstadoEstudio2.Location = location;
			Label label6 = Label4;
			location = new Point(58, 149);
			label6.Location = location;
		}
	}
```

<a id="f-016"></a>

## FrmExpLaboral


### FrmExpLaboral · líneas 582–591

[Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs:582](../../Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs#L582)

```csharp
public FrmExpLaboral()
	{
		base.Load += FrmExpLaboral_Load;
		__ENCAddToList(this);
		ExpLaboral = new ExpLaboral();
		InitializeComponent();
		Button button = cmdCerrar;
		Point location = new Point(255, 224);
		button.Location = location;
	}
```

### FrmExpLaboral_Load · líneas 593–609

[Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs:593](../../Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs#L593)

```csharp
private void FrmExpLaboral_Load(object sender, EventArgs e)
	{
		UcCBTipoInstitucion.ValueMember = "IdTipoInstitucion";
		UcCBTipoInstitucion.DisplayMember = "DescripTipoInstitucion";
		UcCBTipoInstitucion.DataSource = TipoInstitucionMapper.Instance().SelectAll();
		if (codExpLab != 0)
		{
			ExpLaboral expLaboral = ExpLaboralMapper.Instance().SelectOneBy([SpecialName] (ExpLaboral V) => (V.IdEmpleado == codemple) & (V.IdExpLab == codExpLab));
			UcCBTipoInstitucion.SelectedValue = expLaboral.IdTipoInstitucion;
			UcDTIngreso.Value = (DateTime)expLaboral.FechaIngreso;
			UcDTEgreso.Value = (DateTime)expLaboral.FechaEgreso;
			UcTxtCargo.Text = expLaboral.Cargo;
			UcTxtUnidadOrganica.Text = expLaboral.UnidadOrganica;
			UcTxtInstitucion.Text = expLaboral.NomInstitucion;
			UcCBTipoInstitucion.Enabled = false;
		}
	}
```

### BtnGrabar_Click · líneas 611–757

[Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs:611](../../Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs#L611)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		List<ExpLaboral> list = ExpLaboralMapper.Instance().SelectBy([SpecialName] (ExpLaboral v) => v.IdEmpleado == codemple);
		if (list.Count > 0)
		{
			foreach (ExpLaboral item in list)
			{
				DateTime value = UcDTIngreso.Value;
				DateTime? fechaIngreso = item.FechaIngreso;
				bool? obj;
				bool? flag;
				if (!fechaIngreso.HasValue)
				{
					obj = null;
				}
				else
				{
					flag = DateTime.Compare(value, fechaIngreso.GetValueOrDefault()) >= 0;
					obj = flag;
				}
				bool? flag2 = obj;
				DateTime value2 = UcDTIngreso.Value;
				DateTime? fechaEgreso = item.FechaEgreso;
				bool? obj2;
				bool? flag3;
				if (!fechaEgreso.HasValue)
				{
					obj2 = null;
				}
				else
				{
					flag3 = DateTime.Compare(value2, fechaEgreso.GetValueOrDefault()) <= 0;
					obj2 = flag3;
				}
				bool? flag4 = obj2;
				bool? obj3;
				bool? flag6;
				if (flag2 ?? true)
				{
					if (!flag4.HasValue)
					{
						obj3 = null;
					}
					else if (flag4 != true)
					{
						bool? flag5 = false;
						obj3 = flag5;
					}
					else
					{
						obj3 = flag2;
					}
				}
				else
				{
					flag6 = false;
					obj3 = flag6;
				}
				bool? flag7 = obj3;
				if (flag7 == true && MessageBox.Show("El usuario en la fecha: " + Conversions.ToString(UcDTIngreso.Value.Date) + " a estado laborando en:" + item.NomInstitucion + " Desea continuar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
				{
					return;
				}
				value2 = UcDTEgreso.Value;
				fechaEgreso = item.FechaIngreso;
				bool? obj4;
				if (!fechaEgreso.HasValue)
				{
					obj4 = null;
				}
				else
				{
					flag2 = DateTime.Compare(value2, fechaEgreso.GetValueOrDefault()) >= 0;
					obj4 = flag2;
				}
				flag = obj4;
				value = UcDTEgreso.Value;
				fechaIngreso = item.FechaEgreso;
				bool? obj5;
				if (!fechaIngreso.HasValue)
				{
					obj5 = null;
				}
				else
				{
					flag7 = DateTime.Compare(value, fechaIngreso.GetValueOrDefault()) <= 0;
					obj5 = flag7;
				}
				flag6 = obj5;
				bool? obj6;
				if (flag ?? true)
				{
					if (!flag6.HasValue)
					{
						obj6 = null;
					}
					else if (flag6 != true)
					{
						bool? flag5 = false;
						obj6 = flag5;
					}
					else
					{
						obj6 = flag;
					}
				}
				else
				{
					flag4 = false;
					obj6 = flag4;
				}
				flag3 = obj6;
				if (flag3 == true && MessageBox.Show("El usuario en la fecha: " + Conversions.ToString(UcDTIngreso.Value.Date) + " a estado laborando en:" + item.NomInstitucion + " Desea continuar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
				{
					return;
				}
			}
		}
		ExpLaboral.FechaIngreso = UcDTIngreso.Value;
		ExpLaboral.FechaEgreso = UcDTEgreso.Value;
		ExpLaboral expLaboral = ExpLaboral;
		object selectedValue = UcCBTipoInstitucion.SelectedValue;
		int? num = default(int?);
		expLaboral.IdTipoInstitucion = ((selectedValue != null) ? ((int?)selectedValue) : num);
		ExpLaboral.Cargo = UcTxtCargo.Text;
		ExpLaboral.UnidadOrganica = UcTxtUnidadOrganica.Text;
		if (UcTxtInstitucion.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un nombre para la institucion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		ExpLaboral.NomInstitucion = UcTxtInstitucion.Text;
		ExpLaboral.IdEmpleado = codemple;
		if (codExpLab == 0)
		{
			int count = ExpLaboralMapper.Instance().SelectBy([SpecialName] (ExpLaboral v) => v.IdEmpleado == codemple).Count;
			int idExpLab = ((count == 0) ? 1 : checked(count + 1));
			ExpLaboral.IdExpLab = idExpLab;
			ExpLaboralMapper.Instance().Insert(ExpLaboral);
		}
		else
		{
			ExpLaboral.IdExpLab = codExpLab;
			ExpLaboralMapper.Instance().Update(ExpLaboral);
		}
		DialogResult = DialogResult.OK;
	}
```

### BtnCerrar_Click · líneas 759–762

[Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs:759](../../Software/RecursosHumanos/RecursosHumanos/FrmExpLaboral.cs#L759)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-017"></a>

## FrmFamiliar


### FrmFamiliar · líneas 854–862

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:854](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L854)

```csharp
public FrmFamiliar()
	{
		base.Load += FrmFamiliar_Load;
		__ENCAddToList(this);
		objFamiliaresClass = new FamiliaresClass();
		objClassRRHH = new RRHHClass();
		opt = 0;
		InitializeComponent();
	}
```

### FrmFamiliar_Load · líneas 1707–1805

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1707](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1707)

```csharp
private void FrmFamiliar_Load(object sender, EventArgs e)
	{
		if (RRHH.Bienestar)
		{
			Size size = new Size(470, 563);
			Size = size;
			GroupControl1.Visible = true;
			Label19.Visible = true;
			UcTxtLugTrabajo.Visible = true;
		}
		else
		{
			GroupControl1.Visible = false;
			Size size = new Size(470, 457);
			Size = size;
			Label19.Visible = false;
			UcTxtLugTrabajo.Visible = false;
		}
		UcCmbTipoSangre.ValueMember = "IdTipoSangre";
		UcCmbTipoSangre.DisplayMember = "DescripTS";
		UcCmbTipoSangre.DataSource = TipoSangreMapper.Instance().SelectAll();
		UcCBDiscapacidad.ValueMember = "IdDiscapacidad";
		UcCBDiscapacidad.DisplayMember = "Descrip_Discapacidad";
		UcCBDiscapacidad.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Discapacidad());
		UcCBTDI.ValueMember = "TipoDocID";
		UcCBTDI.DisplayMember = "Descripcion";
		UcCBTDI.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_DocID());
		UcCBParentesco.ValueMember = "IdTipoFam";
		UcCBParentesco.DisplayMember = "DescripTipoFam";
		UcCBParentesco.DataSource = RuntimeHelpers.GetObjectValue(objFamiliaresClass.llena_parentezco());
		UcCBEstadoCivil.ValueMember = "IdEstadoCivil";
		UcCBEstadoCivil.DisplayMember = "DescripEstCivil";
		UcCBEstadoCivil.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_estCivil());
		if (codper == 0)
		{
			return;
		}
		DataTable dataTable = (DataTable)objFamiliaresClass.Busca_Codigo(codper);
		foreach (object row in dataTable.Rows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(row);
			string left = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FamSexo" }, null, null, null).ToString();
			if (Operators.CompareString(left, null, TextCompare: false) == 0)
			{
				UcCBSexo.SelectedIndex = -1;
			}
			else if (Operators.CompareString(left, "M", TextCompare: false) == 0)
			{
				UcCBSexo.SelectedIndex = 0;
			}
			else
			{
				UcCBSexo.SelectedIndex = 1;
			}
			UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
			UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
			UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
			UcDateTime1.Value = Conversions.ToDate(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString());
			UcCBParentesco.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdTipoFam" }, null, null, null).ToString();
			UcCBEstadoCivil.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdEstadoCivil" }, null, null, null).ToString();
			UcCBTDI.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "TipoDocID" }, null, null, null).ToString();
			UcTxtDomicilio.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "Direccion" }, null, null, null).ToString();
			UcTxtFono.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "Telefono" }, null, null, null).ToString();
			UcTxtAutogenSalud.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "NumAutogenSalud" }, null, null, null).ToString();
			UcCmbTipoSangre.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "IdTipoSangre" }, null, null, null));
			UcTxtOcupacion.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "FamOcupacion" }, null, null, null).ToString();
			UcTxtLugTrabajo.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "FamLugTrab" }, null, null, null).ToString();
			UcTxtEnfermedad.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "Enfermedad" }, null, null, null).ToString();
			UcTxtTiempo.Text = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "TiempoEnfermedad" }, null, null, null).ToString();
			if ((NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "idDiscapacidad" }, null, null, null) != null && NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "idDiscapacidad" }, null, null, null) != DBNull.Value) ? true : false)
			{
				UcCBDiscapacidad.SelectedValue = NewLateBinding.LateGet(objectValue, null, "item", new object[1] { "idDiscapacidad" }, null, null, null).ToString();
			}
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "ViveCasa" }, null, null, null).ToString().Length > 0)
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "ViveCasa" }, null, null, null).ToString()))
				{
					RadioGroup1.SelectedIndex = 0;
				}
				else
				{
					RadioGroup1.SelectedIndex = 1;
				}
			}
			UcTxtGradoInstruc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FamGradoInstruc" }, null, null, null).ToString();
			if ((NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "LaboraInstitucion" }, null, null, null) != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "LaboraInstitucion" }, null, null, null)))) ? true : false)
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "LaboraInstitucion" }, null, null, null).ToString()))
				{
					RadioGroup2.SelectedIndex = 0;
				}
				else
				{
					RadioGroup2.SelectedIndex = 1;
				}
			}
		}
	}
```

### buscarxDNI · líneas 1807–1832

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1807](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1807)

```csharp
public void buscarxDNI()
	{
		DataTable dataTable = (DataTable)objFamiliaresClass.Busca_DNI(UcTxtNDoc.Text, Conversions.ToInteger(UcCBTDI.SelectedValue));
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString().Length <= 0)
				{
					UcDateTime1.Value = DateAndTime.Today;
				}
				else
				{
					UcDateTime1.Value = Conversions.ToDate(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString());
				}
				codper = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdPersona" }, null, null, null));
				opt = 1;
			}
			return;
		}
		codper = 0;
	}
```

### UcTxtNDoc_LostFocus · líneas 1834–1841

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1834](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1834)

```csharp
private void UcTxtNDoc_LostFocus(object sender, EventArgs e)
	{
		if (codper == 0)
		{
			buscarxDNI();
			focus = 1;
		}
	}
```

### GrabarFamiliar · líneas 1843–1908

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1843](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1843)

```csharp
public void GrabarFamiliar()
	{
		Persona persona = new Persona();
		persona.Apellido_Materno = UcTxtApeMater.Text.Trim();
		persona.Apellido_Paterno = UcTxtApePater.Text.Trim();
		persona.Nombres = UcTxtNombres.Text.Trim();
		object selectedValue = UcCBTDI.SelectedValue;
		int? num = default(int?);
		persona.TipoDocID = ((selectedValue != null) ? ((int?)selectedValue) : num);
		persona.Direccion = UcTxtDomicilio.Text.Trim();
		persona.Telefono = UcTxtFono.Text.Trim();
		if (UcTxtNDoc.TextLength > 0)
		{
			persona.NumDocID = UcTxtNDoc.Text.Trim();
		}
		persona.FechaNacimiento = UcDateTime1.Value;
		persona.TipoPersona = 'N';
		Familiar familiar = new Familiar();
		familiar.IdTipoFam = Conversions.ToInteger(UcCBParentesco.SelectedValue);
		object selectedValue2 = UcCBEstadoCivil.SelectedValue;
		familiar.IdEstadoCivil = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		familiar.FamSexo = Conversions.ToChar(UcCBSexo.Text);
		familiar.FamGradoInstruc = UcTxtGradoInstruc.Text.Trim();
		familiar.NumAutogenSalud = UcTxtAutogenSalud.Text.Trim();
		object selectedValue3 = UcCBDiscapacidad.SelectedValue;
		familiar.IdDiscapacidad = ((selectedValue3 != null) ? ((int?)selectedValue3) : num);
		familiar.IdEmpleado = CodEmple;
		bool? flag = default(bool?);
		if (RadioGroup1.EditValue != null)
		{
			object editValue = RadioGroup1.EditValue;
			familiar.ViveCasa = ((editValue != null) ? ((bool?)editValue) : flag);
		}
		if (RadioGroup2.EditValue != null)
		{
			object editValue2 = RadioGroup2.EditValue;
			familiar.LaboraInstitucion = ((editValue2 != null) ? ((bool?)editValue2) : flag);
		}
		object selectedValue4 = UcCmbTipoSangre.SelectedValue;
		familiar.IdTipoSangre = ((selectedValue4 != null) ? ((int?)selectedValue4) : num);
		familiar.FamOcupacion = UcTxtOcupacion.Text.Trim();
		familiar.FamLugTrab = UcTxtLugTrabajo.Text.Trim();
		familiar.Enfermedad = UcTxtEnfermedad.Text.Trim();
		familiar.TiempoEnfermedad = UcTxtTiempo.Text.Trim();
		if (codper == 0)
		{
			Persona persona2 = PersonaMapper.Instance().SelectAll().Last();
			int idPersona = checked(persona2.IdPersona + 1);
			persona.IdPersona = idPersona;
			persona.FechaRegistro = DateAndTime.Today;
			persona.Familiar.Add(familiar);
			PersonaMapper.Instance().Insert(persona);
			return;
		}
		persona.IdPersona = codper;
		familiar.IdPersona = codper;
		if (opt == 0)
		{
			PersonaMapper.Instance().Update(persona);
			FamiliarMapper.Instance().Update(familiar);
		}
		else if (opt == 1)
		{
			FamiliarMapper.Instance().Insert(familiar);
		}
	}
```

### btnGrabar_Click · líneas 1910–1914

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1910](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1910)

```csharp
private void btnGrabar_Click(object sender, EventArgs e)
	{
		GrabarFamiliar();
		DialogResult = DialogResult.OK;
	}
```

### UcTxtNDoc_TextChanged · líneas 1916–1923

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1916](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1916)

```csharp
private void UcTxtNDoc_TextChanged(object sender, EventArgs e)
	{
		if (focus > 0)
		{
			this.Limpiar_Controles(UcTxtNDoc.Name);
			buscarxDNI();
		}
	}
```

### BtnCerrar_Click · líneas 1925–1928

[Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs:1925](../../Software/RecursosHumanos/RecursosHumanos/FrmFamiliar.cs#L1925)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-018"></a>

## FrmFeriado


### FrmFeriado · líneas 271–276

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:271](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L271)

```csharp
public FrmFeriado()
	{
		base.Load += FrmFeriado_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### MostrarFeriados · líneas 562–574

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:562](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L562)

```csharp
public void MostrarFeriados(IList<FeriadoDto> feriados)
	{
		GridControlFeriado.DataSource = feriados;
		if (GridView1.Columns.Count == 0)
		{
			GridView1.PopulateColumns();
		}
		GridColumn columnaId = GridView1.Columns.ColumnByFieldName(nameof(FeriadoDto.Id));
		if (columnaId != null)
		{
			columnaId.Visible = false;
		}
	}
```

### ReiniciarCaptura · líneas 576–580

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:576](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L576)

```csharp
public void ReiniciarCaptura(DateTime fechaPorDefecto)
	{
		UcTxtMotivo.Text = string.Empty;
		UcDateTime1.Value = fechaPorDefecto;
	}
```

### ConfirmarEliminacion · líneas 582–589

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:582](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L582)

```csharp
public bool ConfirmarEliminacion(DateTime fecha)
	{
		return MessageBox.Show(
			"Desea eliminar el Feriado con Fecha: " + Strings.FormatDateTime(fecha, DateFormat.ShortDate),
			"Alerta",
			MessageBoxButtons.OKCancel,
			MessageBoxIcon.Exclamation) == DialogResult.OK;
	}
```

### MostrarAlerta · líneas 591–594

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:591](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L591)

```csharp
public void MostrarAlerta(string mensaje)
	{
		MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}
```

### MostrarMensaje · líneas 596–599

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:596](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L596)

```csharp
public void MostrarMensaje(string mensaje)
	{
		MessageBox.Show(mensaje);
	}
```

### BtnAgregar_Click · líneas 601–604

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:601](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L601)

```csharp
private void BtnAgregar_Click(object sender, EventArgs e)
	{
		AgregarSolicitado?.Invoke(this, EventArgs.Empty);
	}
```

### FrmFeriado_Load · líneas 606–609

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:606](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L606)

```csharp
private void FrmFeriado_Load(object sender, EventArgs e)
	{
		CargarSolicitado?.Invoke(this, EventArgs.Empty);
	}
```

### btnEliminar_Click · líneas 611–614

[Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs:611](../../Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs#L611)

```csharp
private void btnEliminar_Click(object sender, EventArgs e)
	{
		EliminarSolicitado?.Invoke(this, EventArgs.Empty);
	}
```

<a id="f-019"></a>

## FrmFichaSocial


### FrmFichaSocial · líneas 6798–6811

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:6798](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L6798)

```csharp
public FrmFichaSocial()
	{
		base.Load += FrmFichaSocial_Load;
		__ENCAddToList(this);
		objFichaSocialClass = new FichaSocialClass();
		egreso = new Egreso();
		ingreso = new Ingreso();
		vivienda = new Vivienda();
		RRHH_dinamicafamiliar = new RRHH_DinamicaFamiliar();
		RRHH_FuncFam = new RRHH_FuncFam();
		rrhh_aspSocio = new RRHH_AspSocio();
		rrhh_salud = new RRHH_Salud();
		InitializeComponent();
	}
```

### FrmFichaSocial_Load · líneas 11850–12089

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:11850](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L11850)

```csharp
private void FrmFichaSocial_Load(object sender, EventArgs e)
	{
		if (!RRHH.Bienestar)
		{
			XtraTabPage3.PageVisible = false;
			XtraTabPage4.PageVisible = false;
			XtraTabPage5.PageVisible = false;
			XtraTabPage7.PageVisible = false;
			XtraTabPage8.PageVisible = false;
			XtraTabPage9.PageVisible = false;
			XtraTabPage10.PageVisible = false;
			XtraTabPage12.PageVisible = false;
			XtraTabPage13.PageVisible = false;
		}
		else
		{
			XtraTabPage1.PageVisible = false;
			XtraTabPage11.PageVisible = false;
			XtraTabPage8.PageVisible = false;
			XtraTabPage9.PageVisible = false;
			XtraTabPage10.PageVisible = false;
		}
		UcCBTipoPersonal.SelectedIndex = 0;
		UcCBViveCon.ValueMember = "IdViveCon";
		UcCBViveCon.DisplayMember = "DescripViveCon";
		List<ViveCon> list = ViveConMapper.Instance().SelectAll();
		list.Insert(0, new ViveCon
		{
			IdViveCon = 0,
			DescripViveCon = "NO ESPECIFICA"
		});
		UcCBViveCon.DataSource = list;
		UcCBTipoTrab.ValueMember = "IdTipoTrabajador";
		UcCBTipoTrab.DisplayMember = "Descripcion";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource;
			UcCBTipoTrab.SelectedValue = 1;
			UcCBTipoTrab.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<TipoTrabajador> dataSource2 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource2;
			UcCBTipoTrab.SelectedValue = 2;
			UcCBTipoTrab.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<TipoTrabajador> dataSource3 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource3;
			UcCBTipoTrab.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			List<TipoTrabajador> dataSource4 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => (C.IdTipoTrabajador == 1) | (C.IdTipoTrabajador == 3) | (C.IdTipoTrabajador == 4) | (C.IdTipoTrabajador == 5));
			UcCBTipoTrab.DataSource = dataSource4;
			UcCBTipoTrab.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			List<TipoTrabajador> dataSource5 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => C.IdTipoTrabajador == 2);
			UcCBTipoTrab.DataSource = dataSource5;
			UcCBTipoTrab.SelectedValue = RRHH.Partida;
		}
		UcCBTenencia.ValueMember = "IdTenencia";
		UcCBTenencia.DisplayMember = "DescripTenencia";
		List<TenenciaViv> list2 = TenenciaVivMapper.Instance().SelectAll();
		list2.Insert(0, new TenenciaViv
		{
			IdTenencia = 0,
			DescripTenencia = "NO ESPECIFICA"
		});
		UcCBTenencia.DataSource = list2;
		UcCBTipo.ValueMember = "IdTipo";
		UcCBTipo.DisplayMember = "DescripTipo";
		List<TipoViv> list3 = TipoVivMapper.Instance().SelectAll();
		list3.Insert(0, new TipoViv
		{
			IdTipo = 0,
			DescripTipo = "NO ESPECIFICA"
		});
		UcCBTipo.DataSource = list3;
		UcCBMaterial.ValueMember = "IdMaterial";
		UcCBMaterial.DisplayMember = "DescripMaterial";
		List<MaterialViv> list4 = MaterialVivMapper.Instance().SelectAll();
		list4.Insert(0, new MaterialViv
		{
			IdMaterial = 0,
			DescripMaterial = "NO ESPECIFICA"
		});
		UcCBMaterial.DataSource = list4;
		UcCBConservacion.ValueMember = "IdConservacion";
		UcCBConservacion.DisplayMember = "DescripConserva";
		List<ConservacionViv> list5 = ConservacionVivMapper.Instance().SelectAll();
		list5.Insert(0, new ConservacionViv
		{
			IdConservacion = 0,
			DescripConserva = "NO ESPECIFICA"
		});
		UcCBConservacion.DataSource = list5;
		UcCBUbicacion.ValueMember = "IdUbicacion";
		UcCBUbicacion.DisplayMember = "DescripUbicacion";
		List<UbicacionViv> list6 = UbicacionVivMapper.Instance().SelectAll();
		list6.Insert(0, new UbicacionViv
		{
			IdUbicacion = 0,
			DescripUbicacion = "NO ESPECIFICA"
		});
		UcCBUbicacion.DataSource = list6;
		UcCBAlumbrado.ValueMember = "IdAlumbrado";
		UcCBAlumbrado.DisplayMember = "DescripAlumbrado";
		List<AlumbradoViv> list7 = AlumbradoVivMapper.Instance().SelectAll();
		list7.Insert(0, new AlumbradoViv
		{
			IdAlumbrado = 0,
			DescripAlumbrado = "NO ESPECIFICA"
		});
		UcCBAlumbrado.DataSource = list7;
		UcCBAgua.ValueMember = "IdAgua";
		UcCBAgua.DisplayMember = "DescripAgua";
		List<AguaViv> list8 = AguaVivMapper.Instance().SelectAll();
		list8.Insert(0, new AguaViv
		{
			IdAgua = 0,
			DescripAgua = "NO ESPECIFICA"
		});
		UcCBAgua.DataSource = list8;
		UcCBExcretas.ValueMember = "IdExcretas";
		UcCBExcretas.DisplayMember = "DescripExcretas";
		List<ExcretasViv> list9 = ExcretasVivMapper.Instance().SelectAll();
		list9.Insert(0, new ExcretasViv
		{
			IdExcretas = 0,
			DescripExcretas = "NO ESPECIFICA"
		});
		UcCBExcretas.DataSource = list9;
		UcCmboRec1.ValueMember = "idPregunta1";
		UcCmboRec1.DisplayMember = "Respues1";
		List<RRHH_Preg1> list10 = RRHH_Preg1Mapper.Instance().SelectAll();
		list10.Insert(0, new RRHH_Preg1
		{
			idPregunta1 = 0,
			Respues1 = "(SELECCIONAR)"
		});
		UcCmboRec1.DataSource = list10;
		UcCmboRec2.ValueMember = "idPregunta2";
		UcCmboRec2.DisplayMember = "Respues2";
		List<RRHH_Preg2> list11 = RRHH_Preg2Mapper.Instance().SelectAll();
		list11.Insert(0, new RRHH_Preg2
		{
			idPregunta2 = 0,
			Respues2 = "(SELECCIONAR)"
		});
		UcCmboRec2.DataSource = list11;
		UcCmboRec3.ValueMember = "idPregunta3";
		UcCmboRec3.DisplayMember = "Respues3";
		List<RRHH_Preg3> list12 = RRHH_Preg3Mapper.Instance().SelectAll();
		list12.Insert(0, new RRHH_Preg3
		{
			idPregunta3 = 0,
			Respues3 = "(SELECCIONAR)"
		});
		UcCmboRec3.DataSource = list12;
		UcCmbAcudeEnf.ValueMember = "idAcudeEnferm";
		UcCmbAcudeEnf.DisplayMember = "AcudeEnfermDescrip";
		List<RRHH_AcudeEnferm> list13 = RRHH_AcudeEnfermMapper.Instance().SelectAll();
		list13.Insert(0, new RRHH_AcudeEnferm
		{
			idAcudeEnferm = 0,
			AcudeEnfermDescrip = "(SELECCIONAR)"
		});
		UcCmbAcudeEnf.DataSource = list13;
		UcCmbTipoFam.ValueMember = "idTipoFam";
		UcCmbTipoFam.DisplayMember = "TipoFamDescrip";
		List<RRHH_TipoFamilia> list14 = RRHH_TipoFamiliaMapper.Instance().SelectAll();
		list14.Insert(0, new RRHH_TipoFamilia
		{
			idTipoFam = 0,
			TipoFamDescrip = "(SELECCIONAR)"
		});
		UcCmbTipoFam.DataSource = list14;
		UcCmbRelPareja.ValueMember = "idRelacPareja";
		UcCmbRelPareja.DisplayMember = "RelacParejaDescrip";
		List<RRHH_RelacPareja> list15 = RRHH_RelacParejaMapper.Instance().SelectAll();
		list15.Insert(0, new RRHH_RelacPareja
		{
			idRelacPareja = 0,
			RelacParejaDescrip = "(SELECCIONAR)"
		});
		UcCmbRelPareja.DataSource = list15;
		UcCmbRelPH.ValueMember = "idRelacPH";
		UcCmbRelPH.DisplayMember = "RelacPHDescrip";
		List<RRHH_RelacPH> list16 = RRHH_RelacPHMapper.Instance().SelectAll();
		list16.Insert(0, new RRHH_RelacPH
		{
			idRelacPH = 0,
			RelacPHDescrip = "(SELECCIONAR)"
		});
		UcCmbRelPH.DataSource = list16;
		UcCmbRelHerm.ValueMember = "idRelacHermano";
		UcCmbRelHerm.DisplayMember = "RelacHermanoDescrip";
		List<RRHH_RelacHermano> list17 = RRHH_RelacHermanoMapper.Instance().SelectAll();
		list17.Insert(0, new RRHH_RelacHermano
		{
			idRelacHermano = 0,
			RelacHermanoDescrip = "(SELECCIONAR)"
		});
		UcCmbRelHerm.DataSource = list17;
		UcCmbResp1.SelectedIndex = 0;
		UcCmbResp2.SelectedIndex = 0;
		UcCmbResp3.SelectedIndex = 0;
		UcCmbResp4.SelectedIndex = 0;
		UcCmbResp5.SelectedIndex = 0;
		UcCmbResp6.SelectedIndex = 0;
		UcCmbResp7.SelectedIndex = 0;
		UcCmbResp8.SelectedIndex = 0;
		UcCmbResp9.SelectedIndex = 0;
		UcCBAfp.ValueMember = "IdAFP";
		UcCBAfp.DisplayMember = "DescripAFP";
		UcCBAfp.DataSource = AFPMapper.Instance().SelectAll();
		UcCBCargo.ValueMember = "IdCargo";
		UcCBCargo.DisplayMember = "Cargo";
		UcCBCargo.DataSource = CargoMapper.Instance().SelectAll();
		UcCBRegimen.ValueMember = "IdRegimenPen";
		UcCBRegimen.DisplayMember = "LeyRegimen";
		UcCBRegimen.DataSource = RegimenPensionMapper.Instance().SelectAll();
		llena_dgvFamilia();
		llena_dgvEstudios();
		llena_dgvTitulos();
		llena_dgvCapacitaciones();
		llena_dgvExpLab();
		llena_DgvDisciplina();
		llena_dgvPerLab();
		llenda_datos_empleado();
		llena_dgvAsegurados();
		llena_dvgRotaciones();
		llena_dvgResoluciones();
	}
```

### btnAgregar_Click · líneas 12091–12100

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12091](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12091)

```csharp
private void btnAgregar_Click(object sender, EventArgs e)
	{
		FrmFamiliar frmFamiliar = new FrmFamiliar();
		frmFamiliar.CodEmple = CodEmple;
		frmFamiliar.ShowDialog();
		if (frmFamiliar.DialogResult == DialogResult.OK)
		{
			llena_dgvFamilia();
		}
	}
```

### llenda_datos_empleado · líneas 12102–12735

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12102](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12102)

```csharp
public void llenda_datos_empleado()
	{
		_Closure_0024__5 CS_0024_003C_003E8__locals4 = new _Closure_0024__5();
		empleado = EmpleadoMapper.Instance().SelectBy(qEmpleado => qEmpleado.IdEmpleado == CodEmple).First();
		CS_0024_003C_003E8__locals4._0024VB_0024Local_codper = (int)empleado.IdPersona;
		persona = PersonaMapper.Instance().SelectBy(qPersona =>
			qPersona.IdPersona == CS_0024_003C_003E8__locals4._0024VB_0024Local_codper).First();
		UcTxtNDoc.Text = persona.NumDocID.SinNulo();
		UcTxtApePater.Text = persona.Apellido_Paterno.SinNulo();
		UcTxtApeMater.Text = persona.Apellido_Materno.SinNulo();
		UcTxtNombres.Text = persona.Nombres.SinNulo();
		UcTxtSexo.Text = Conversions.ToString((char)empleado.Sexo.SinNulo());
		CS_0024_003C_003E8__locals4._0024VB_0024Local_docid = (int)persona.TipoDocID;
		TipoDocID tipoDocID = TipoDocIDMapper.Instance().SelectBy([SpecialName] (TipoDocID d) => d.TipoDocID == CS_0024_003C_003E8__locals4._0024VB_0024Local_docid).First();
		UcTxtTipoDocID.Text = tipoDocID.Descripcion;
		if ((object)empleado.Foto != null)
		{
			byte[] array = empleado.Foto.ToArray();
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(array, 0, checked(array.GetUpperBound(0) + 1));
			UcFoto.Image = Image.FromStream(memoryStream);
			memoryStream.Close();
		}
		RadioGroup1.EditValue = empleado.JefeHogar;
		UcTxtCargaFam.Text = empleado.CargaFam;
		UcTxtNumHijos.Text = empleado.NumHijos;
		if (!empleado.IdViveCon.HasValue)
		{
			UcCBViveCon.SelectedValue = 0;
		}
		else
		{
			UcCBViveCon.SelectedValue = empleado.IdViveCon;
		}
		UcTxtObsFam.Text = empleado.ObsFam;
		UcTxtProfesion.Text = empleado.Profesion;
		if (empleado.IdTipoTrabajador.HasValue)
		{
			UcCBTipoTrab.SelectedValue = empleado.IdTipoTrabajador;
		}
		if (empleado.FechaIngreso.HasValue)
		{
		}
		if (empleado.IdRegimenPen.HasValue)
		{
			UcCBRegimen.SelectedValue = empleado.IdRegimenPen;
		}
		if (empleado.IdCargo.HasValue)
		{
			UcCBCargo.SelectedValue = empleado.IdCargo;
		}
		if (empleado.IdAFP.HasValue)
		{
			UcCBAfp.SelectedValue = empleado.IdAFP;
		}
		UcTxtNroAfp.Text = empleado.NroAFP;
		if (empleado.FechaAFP.HasValue)
		{
			UcDTInscripAFP.Value = (DateTime)empleado.FechaAFP;
		}
		UcTxtResolCese.Text = empleado.NumResolCese;
		if (empleado.FechaResolCese.HasValue)
		{
			UcDTCese.Value = (DateTime)empleado.FechaResolCese;
		}
		UcTxtResol20530.Text = empleado.NumResol20530;
		if (empleado.FechaResol20530.HasValue)
		{
			UcDT20530.Value = (DateTime)empleado.FechaResol20530;
		}
		if (empleado.FechaResolIngreEsta.HasValue)
		{
			UcDTFechaResolIngreEstado.Value = (DateTime)empleado.FechaResolIngreEsta;
		}
		if (empleado.FechaResoIngreInstitu.HasValue)
		{
		}
		UcTxtResolPensionista.Text = empleado.NumResolPenMen;
		if (empleado.FechaResolPenMen.HasValue)
		{
			UcDTPension.Value = (DateTime)empleado.FechaResolPenMen;
		}
		UcTxtResoIngreEst.Text = empleado.NumResoIngreEsta;
		if (empleado.FechaIngreEstado.HasValue)
		{
			UcDTIngreEsta.Value = (DateTime)empleado.FechaIngreEstado;
		}
		UcTxtAutogenSalud.Text = empleado.NumAutogenSalud;
		UcTxtObsFam.Text = empleado.ObsFam;
		UcTxtAspPsico.Text = empleado.AspecPsico;
		UcTxtAspSocial.Text = empleado.AspecSocial;
		UcTxtDiagSocial.Text = empleado.DiagnosSocial;
		if (ViviendaMapper.Instance().SelectBy([SpecialName] (Vivienda v) =>
		{
			int codEmple = CodEmple;
			int? idEmpleado = v.IdEmpleado;
			bool? obj;
			if (!idEmpleado.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idEmpleado.GetValueOrDefault() == codEmple;
				obj = flag;
			}
			return (bool)obj;
		}).Count == 1)
		{
			vivienda = ViviendaMapper.Instance().SelectBy([SpecialName] (Vivienda v) =>
			{
				int codEmple2 = CodEmple;
				int? idEmpleado2 = v.IdEmpleado;
				bool? obj2;
				if (!idEmpleado2.HasValue)
				{
					obj2 = null;
				}
				else
				{
					bool? flag2 = idEmpleado2.GetValueOrDefault() == codEmple2;
					obj2 = flag2;
				}
				return (bool)obj2;
			}).First();
			if (!vivienda.IdTenencia.HasValue)
			{
				UcCBTenencia.SelectedValue = 0;
			}
			else
			{
				UcCBTenencia.SelectedValue = vivienda.IdTenencia;
			}
			if (!vivienda.IdMaterial.HasValue)
			{
				UcCBMaterial.SelectedValue = 0;
			}
			else
			{
				UcCBMaterial.SelectedValue = vivienda.IdMaterial;
			}
			if (!vivienda.IdTipo.HasValue)
			{
				UcCBTipo.SelectedValue = 0;
			}
			else
			{
				UcCBTipo.SelectedValue = vivienda.IdTipo;
			}
			if (!vivienda.IdUbicacion.HasValue)
			{
				UcCBUbicacion.SelectedValue = 0;
			}
			else
			{
				UcCBUbicacion.SelectedValue = vivienda.IdUbicacion;
			}
			if (!vivienda.IdConservacion.HasValue)
			{
				UcCBConservacion.SelectedValue = 0;
			}
			else
			{
				UcCBConservacion.SelectedValue = vivienda.IdConservacion;
			}
			if (!vivienda.IdAlumbrado.HasValue)
			{
				UcCBAlumbrado.SelectedValue = 0;
			}
			else
			{
				UcCBAlumbrado.SelectedValue = vivienda.IdAlumbrado;
			}
			if (!vivienda.IdAgua.HasValue)
			{
				UcCBAgua.SelectedValue = 0;
			}
			else
			{
				UcCBAgua.SelectedValue = vivienda.IdAgua;
			}
			if (!vivienda.IdExcretas.HasValue)
			{
				UcCBExcretas.SelectedValue = 0;
			}
			else
			{
				UcCBExcretas.SelectedValue = vivienda.IdExcretas;
			}
			UcTxtOtroAlumbrado.Text = vivienda.OtroAlumbrado;
			UcTxtOtroAgua.Text = vivienda.OtroAgua;
			UcTxtOtroExcreta.Text = vivienda.OtroExcreta;
			ChckFono.EditValue = vivienda.Telefono;
			ChckInter.EditValue = vivienda.Internet;
			ChckCable.EditValue = vivienda.Cable;
			ChckOtros.EditValue = vivienda.Otros;
			UcTxtNumCompart.Text = vivienda.NumCompart;
			UcTxtPerxDorm.Text = vivienda.NumPerDorm;
			UcTxtNumDormito.Text = vivienda.NumDormitorio;
			UcTxtServHig.Text = vivienda.NumServHig;
			UcTxtObsVivienda.Text = vivienda.Observacion;
		}
		if (IngresoMapper.Instance().SelectBy([SpecialName] (Ingreso v) =>
		{
			int codEmple3 = CodEmple;
			int? idEmpleado3 = v.IdEmpleado;
			bool? obj3;
			if (!idEmpleado3.HasValue)
			{
				obj3 = null;
			}
			else
			{
				bool? flag3 = idEmpleado3.GetValueOrDefault() == codEmple3;
				obj3 = flag3;
			}
			return (bool)obj3;
		}).Count == 1)
		{
			ingreso = IngresoMapper.Instance().SelectBy([SpecialName] (Ingreso v) =>
			{
				int codEmple4 = CodEmple;
				int? idEmpleado4 = v.IdEmpleado;
				bool? obj4;
				if (!idEmpleado4.HasValue)
				{
					obj4 = null;
				}
				else
				{
					bool? flag4 = idEmpleado4.GetValueOrDefault() == codEmple4;
					obj4 = flag4;
				}
				return (bool)obj4;
			}).First();
			if (ingreso.Remuneracion.HasValue)
			{
				UcTxtIngreRemune.Text = Conversions.ToString((decimal)ingreso.Remuneracion);
			}
			if (ingreso.Honorarios.HasValue)
			{
				UcTxtIngreAdic.Text = Conversions.ToString((decimal)ingreso.Honorarios);
			}
			if (ingreso.AlqPredio.HasValue)
			{
				UcTxtIngreMiembros.Text = Conversions.ToString((decimal)ingreso.AlqPredio);
			}
			if (ingreso.AlqBienes.HasValue)
			{
				UcTxtIngreBienes.Text = Conversions.ToString((decimal)ingreso.AlqBienes);
			}
			if (ingreso.IngresoMiembros.HasValue)
			{
				UcTxtIngreMiembroszz.Text = Conversions.ToString((decimal)ingreso.IngresoMiembros);
			}
			if (ingreso.NumPersonaAportan != null)
			{
				UcTxtNumPers.Text = ingreso.NumPersonaAportan;
			}
		}
		if (EgresoMapper.Instance().SelectBy([SpecialName] (Egreso v) =>
		{
			int codEmple5 = CodEmple;
			int? idEmpleado5 = v.IdEmpleado;
			bool? obj5;
			if (!idEmpleado5.HasValue)
			{
				obj5 = null;
			}
			else
			{
				bool? flag5 = idEmpleado5.GetValueOrDefault() == codEmple5;
				obj5 = flag5;
			}
			return (bool)obj5;
		}).Count == 1)
		{
			egreso = EgresoMapper.Instance().SelectBy([SpecialName] (Egreso v) =>
			{
				int codEmple6 = CodEmple;
				int? idEmpleado6 = v.IdEmpleado;
				bool? obj6;
				if (!idEmpleado6.HasValue)
				{
					obj6 = null;
				}
				else
				{
					bool? flag6 = idEmpleado6.GetValueOrDefault() == codEmple6;
					obj6 = flag6;
				}
				return (bool)obj6;
			}).First();
			if (egreso.Vivienda.HasValue)
			{
				UcTxtEgreVivienda.Text = Conversions.ToString((decimal)egreso.Vivienda);
			}
			if (egreso.Alimentacion.HasValue)
			{
				UcTxtEgreAliment.Text = Conversions.ToString((decimal)egreso.Alimentacion);
			}
			if (egreso.Vestido.HasValue)
			{
				UcTxtEgreVestido.Text = Conversions.ToString((decimal)egreso.Vestido);
			}
			if (egreso.Agua.HasValue)
			{
				UcTxtEgreAgua.Text = Conversions.ToString((decimal)egreso.Agua);
			}
			if (egreso.Telefono.HasValue)
			{
				UcTxtEgreFono.Text = Conversions.ToString((decimal)egreso.Telefono);
			}
			if (egreso.SeguroPriv.HasValue)
			{
				UcTxtEgreSegPriv.Text = Conversions.ToString((decimal)egreso.SeguroPriv);
			}
			if (egreso.Salud.HasValue)
			{
				UcTxtEgreSalud.Text = Conversions.ToString((decimal)egreso.Salud);
			}
			if (egreso.Educacion.HasValue)
			{
				UcTxtEgreEducac.Text = Conversions.ToString((decimal)egreso.Educacion);
			}
			if (egreso.Transporte.HasValue)
			{
				UcTxtTransporte.Text = Conversions.ToString((decimal)egreso.Transporte);
			}
			if (egreso.EnergiaElec.HasValue)
			{
				UcTxtEnergElec.Text = Conversions.ToString((decimal)egreso.EnergiaElec);
			}
			if (egreso.BajaPolicia.HasValue)
			{
				UcTxtEgreBajaPol.Text = Conversions.ToString((decimal)egreso.BajaPolicia);
			}
			if (egreso.Recreacion.HasValue)
			{
				UcTxtEgreRecrea.Text = Conversions.ToString((decimal)egreso.Recreacion);
			}
			if (egreso.Prestamos.HasValue)
			{
				UcTxtEgreDeuda.Text = Conversions.ToString((decimal)egreso.Prestamos);
			}
			if (egreso.Otros.HasValue)
			{
				UcTxtEgreOtro.Text = Conversions.ToString((decimal)egreso.Otros);
			}
		}
		if (RRHH_DinamicaFamiliarMapper.Instance().SelectBy([SpecialName] (RRHH_DinamicaFamiliar v) =>
		{
			int codEmple7 = CodEmple;
			int? idEmpleado7 = v.IdEmpleado;
			bool? obj7;
			if (!idEmpleado7.HasValue)
			{
				obj7 = null;
			}
			else
			{
				bool? flag7 = idEmpleado7.GetValueOrDefault() == codEmple7;
				obj7 = flag7;
			}
			return (bool)obj7;
		}).Count == 1)
		{
			RRHH_dinamicafamiliar = RRHH_DinamicaFamiliarMapper.Instance().SelectBy([SpecialName] (RRHH_DinamicaFamiliar v) =>
			{
				int codEmple8 = CodEmple;
				int? idEmpleado8 = v.IdEmpleado;
				bool? obj8;
				if (!idEmpleado8.HasValue)
				{
					obj8 = null;
				}
				else
				{
					bool? flag8 = idEmpleado8.GetValueOrDefault() == codEmple8;
					obj8 = flag8;
				}
				return (bool)obj8;
			}).First();
			if (!RRHH_dinamicafamiliar.idTipoFam.HasValue)
			{
				UcCmbTipoFam.SelectedValue = 0;
			}
			else
			{
				UcCmbTipoFam.SelectedValue = RRHH_dinamicafamiliar.idTipoFam;
			}
			if (!RRHH_dinamicafamiliar.idRelaPareja.HasValue)
			{
				UcCmbRelPareja.SelectedValue = 0;
			}
			else
			{
				UcCmbRelPareja.SelectedValue = RRHH_dinamicafamiliar.idRelaPareja;
			}
			if (!RRHH_dinamicafamiliar.idRelaPH.HasValue)
			{
				UcCmbRelPH.SelectedValue = 0;
			}
			else
			{
				UcCmbRelPH.SelectedValue = RRHH_dinamicafamiliar.idRelaPH;
			}
			if (!RRHH_dinamicafamiliar.idRelacHermano.HasValue)
			{
				UcCmbRelHerm.SelectedValue = 0;
			}
			else
			{
				UcCmbRelHerm.SelectedValue = RRHH_dinamicafamiliar.idRelacHermano;
			}
		}
		if (RRHH_FuncFamMapper.Instance().SelectBy([SpecialName] (RRHH_FuncFam v) =>
		{
			int codEmple9 = CodEmple;
			int? idEmpleado9 = v.IdEmpleado;
			bool? obj9;
			if (!idEmpleado9.HasValue)
			{
				obj9 = null;
			}
			else
			{
				bool? flag9 = idEmpleado9.GetValueOrDefault() == codEmple9;
				obj9 = flag9;
			}
			return (bool)obj9;
		}).Count == 1)
		{
			RRHH_FuncFam = RRHH_FuncFamMapper.Instance().SelectBy([SpecialName] (RRHH_FuncFam v) =>
			{
				int codEmple10 = CodEmple;
				int? idEmpleado10 = v.IdEmpleado;
				bool? obj10;
				if (!idEmpleado10.HasValue)
				{
					obj10 = null;
				}
				else
				{
					bool? flag10 = idEmpleado10.GetValueOrDefault() == codEmple10;
					obj10 = flag10;
				}
				return (bool)obj10;
			}).First();
			if (RRHH_FuncFam.Com1 == null)
			{
				UcCmbResp1.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp1.Text = RRHH_FuncFam.Com1;
			}
			if (RRHH_FuncFam.Com2 == null)
			{
				UcCmbResp2.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp2.Text = RRHH_FuncFam.Com2;
			}
			if (RRHH_FuncFam.Afec1 == null)
			{
				UcCmbResp3.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp3.Text = RRHH_FuncFam.Afec1;
			}
			if (RRHH_FuncFam.Afec2 == null)
			{
				UcCmbResp4.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp4.Text = RRHH_FuncFam.Afec2;
			}
			if (RRHH_FuncFam.Soc1 == null)
			{
				UcCmbResp5.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp5.Text = RRHH_FuncFam.Soc1;
			}
			if (RRHH_FuncFam.Soc2 == null)
			{
				UcCmbResp6.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp6.Text = RRHH_FuncFam.Soc2;
			}
			if (RRHH_FuncFam.Soc3 == null)
			{
				UcCmbResp7.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp7.Text = RRHH_FuncFam.Soc3;
			}
			if (RRHH_FuncFam.Decis1 == null)
			{
				UcCmbResp8.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp8.Text = RRHH_FuncFam.Decis1;
			}
			if (RRHH_FuncFam.Decis2 == null)
			{
				UcCmbResp9.SelectedIndex = 0;
			}
			else
			{
				UcCmbResp9.Text = RRHH_FuncFam.Decis2;
			}
		}
		if (RRHH_SaludMapper.Instance().SelectBy([SpecialName] (RRHH_Salud v) =>
		{
			int codEmple11 = CodEmple;
			int? idEmpleado11 = v.IdEmpleado;
			bool? obj11;
			if (!idEmpleado11.HasValue)
			{
				obj11 = null;
			}
			else
			{
				bool? flag11 = idEmpleado11.GetValueOrDefault() == codEmple11;
				obj11 = flag11;
			}
			return (bool)obj11;
		}).Count == 1)
		{
			rrhh_salud = RRHH_SaludMapper.Instance().SelectBy([SpecialName] (RRHH_Salud v) =>
			{
				int codEmple12 = CodEmple;
				int? idEmpleado12 = v.IdEmpleado;
				bool? obj12;
				if (!idEmpleado12.HasValue)
				{
					obj12 = null;
				}
				else
				{
					bool? flag12 = idEmpleado12.GetValueOrDefault() == codEmple12;
					obj12 = flag12;
				}
				return (bool)obj12;
			}).First();
			RadioGroup2.EditValue = rrhh_salud.EnferCronica;
			UcTxtEnfCronica.Text = rrhh_salud.EnferCronicaDescrip;
			RadioGroup3.EditValue = rrhh_salud.FamDiscapacidad;
			UcTxtFamDiscap.Text = rrhh_salud.FamDiscapDescrip;
			if (!rrhh_salud.idAcudeEnferm.HasValue)
			{
				UcCmbAcudeEnf.SelectedValue = 0;
			}
			else
			{
				UcCmbAcudeEnf.SelectedValue = rrhh_salud.idAcudeEnferm;
			}
			RadioGroup4.EditValue = rrhh_salud.Alergico;
			UcTxtAlergico.Text = rrhh_salud.AlergicoDescrip;
		}
		if (RRHH_AspSocioMapper.Instance().SelectBy([SpecialName] (RRHH_AspSocio v) =>
		{
			int codEmple13 = CodEmple;
			int? idEmpleado13 = v.IdEmpleado;
			bool? obj13;
			if (!idEmpleado13.HasValue)
			{
				obj13 = null;
			}
			else
			{
				bool? flag13 = idEmpleado13.GetValueOrDefault() == codEmple13;
				obj13 = flag13;
			}
			return (bool)obj13;
		}).Count != 1)
		{
			return;
		}
		rrhh_aspSocio = RRHH_AspSocioMapper.Instance().SelectBy([SpecialName] (RRHH_AspSocio v) =>
		{
			int codEmple14 = CodEmple;
			int? idEmpleado14 = v.IdEmpleado;
			bool? obj14;
			if (!idEmpleado14.HasValue)
			{
				obj14 = null;
			}
			else
			{
				bool? flag14 = idEmpleado14.GetValueOrDefault() == codEmple14;
				obj14 = flag14;
			}
			return (bool)obj14;
		}).First();
		if (!rrhh_aspSocio.idPregunta1.HasValue)
		{
			UcCmboRec1.SelectedValue = 0;
		}
		else
		{
			UcCmboRec1.SelectedValue = rrhh_aspSocio.idPregunta1;
		}
		if (!rrhh_aspSocio.idPregunta2.HasValue)
		{
			UcCmboRec2.SelectedValue = 0;
		}
		else
		{
			UcCmboRec2.SelectedValue = rrhh_aspSocio.idPregunta2;
		}
		if (!rrhh_aspSocio.idPregunta3.HasValue)
		{
			UcCmboRec3.SelectedValue = 0;
		}
		else
		{
			UcCmboRec3.SelectedValue = rrhh_aspSocio.idPregunta3;
		}
		UcTxtRec4.Text = rrhh_aspSocio.PrincipProblemas;
		UcTxtRec5.Text = rrhh_aspSocio.PropMejoraInstitu;
		UcTxtRec6.Text = rrhh_aspSocio.hobby;
		UcTxtRec7.Text = rrhh_aspSocio.ActRecreaInstitu;
	}
```

### btnModificar_Click · líneas 12737–12754

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12737](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12737)

```csharp
private void btnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewFam.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Familiar");
			return;
		}
		int codper = Conversions.ToInteger(GridViewFam.GetRowCellValue(focusedRowHandle, "Idpersona"));
		FrmFamiliar frmFamiliar = new FrmFamiliar();
		frmFamiliar.CodEmple = CodEmple;
		frmFamiliar.codper = codper;
		frmFamiliar.ShowDialog();
		if (frmFamiliar.DialogResult == DialogResult.OK)
		{
			llena_dgvFamilia();
		}
	}
```

### llena_dvgResoluciones · líneas 12756–12760

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12756](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12756)

```csharp
public void llena_dvgResoluciones()
	{
		List<spRRHH_ListarResolucionResult> dataSource = Module1.DcGrll.spRRHH_ListarResolucion(CodEmple).ToList();
		Grid_Resoluciones.DataSource = dataSource;
	}
```

### llena_dvgRotaciones · líneas 12762–12766

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12762](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12762)

```csharp
public void llena_dvgRotaciones()
	{
		List<spRRHH_ListarRotacionesResult> dataSource = Module1.DcGrll.spRRHH_ListarRotaciones(CodEmple).ToList();
		Grid_Rotaciones.DataSource = dataSource;
	}
```

### llena_dgvAsegurados · líneas 12768–12771

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12768](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12768)

```csharp
public void llena_dgvAsegurados()
	{
		GCAsegurado.DataSource = RRHH_AseguradoMapper.Instance().SelectBy([SpecialName] (RRHH_Asegurado P) => P.idEmpleado == CodEmple);
	}
```

### llena_dgvFamilia · líneas 12773–12776

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12773](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12773)

```csharp
public void llena_dgvFamilia()
	{
		dgvFamiliares.DataSource = RuntimeHelpers.GetObjectValue(objFichaSocialClass.llenarFamiliares(CodEmple));
	}
```

### llena_dgvEstudios · líneas 12778–12782

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12778](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12778)

```csharp
public void llena_dgvEstudios()
	{
		List<spRRHH_buscarEstudiosResult> dataSource = Module1.DcGrll.spRRHH_buscarEstudios(CodEmple).ToList();
		DGVEstudios.DataSource = dataSource;
	}
```

### llena_dgvTitulos · líneas 12784–12803

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12784](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12784)

```csharp
public void llena_dgvTitulos()
	{
		List<TitulosEmpleado> dataSource = TitulosEmpleadoMapper.Instance().SelectBy([SpecialName] (TitulosEmpleado v) =>
		{
			int codEmple = CodEmple;
			int? idEmpleado = v.IdEmpleado;
			bool? obj;
			if (!idEmpleado.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idEmpleado.GetValueOrDefault() == codEmple;
				obj = flag;
			}
			return (bool)obj;
		});
		DGVTitulos.DataSource = dataSource;
	}
```

### llena_dgvCapacitaciones · líneas 12805–12824

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12805](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12805)

```csharp
public void llena_dgvCapacitaciones()
	{
		List<Capacitacion> dataSource = CapacitacionMapper.Instance().SelectBy([SpecialName] (Capacitacion v) =>
		{
			int codEmple = CodEmple;
			int? idEmpleado = v.IdEmpleado;
			bool? obj;
			if (!idEmpleado.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idEmpleado.GetValueOrDefault() == codEmple;
				obj = flag;
			}
			return (bool)obj;
		});
		DGVCapacitacion.DataSource = dataSource;
	}
```

### llena_dgvExpLab · líneas 12826–12830

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12826](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12826)

```csharp
public void llena_dgvExpLab()
	{
		List<spRRHH_BuscarExpLabResult> dataSource = Module1.DcGrll.spRRHH_BuscarExpLab(CodEmple).ToList();
		DGVExpLab.DataSource = dataSource;
	}
```

### llena_DgvDisciplina · líneas 12832–12836

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12832](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12832)

```csharp
public void llena_DgvDisciplina()
	{
		List<spRRHH_busca_DisciplinaResult> dataSource = Module1.DcGrll.spRRHH_busca_Disciplina(CodEmple).ToList();
		DGV_Disciplina.DataSource = dataSource;
	}
```

### btnEliminar_Click · líneas 12838–12854

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12838](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12838)

```csharp
private void btnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewFam.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Familiar");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar a: ", GridViewFam.GetRowCellValue(focusedRowHandle, "NombresCompletos"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idPersona = Conversions.ToInteger(GridViewFam.GetRowCellValue(focusedRowHandle, "Idpersona"));
			Familiar familiar = new Familiar();
			familiar.IdPersona = idPersona;
			familiar.IdEmpleado = CodEmple;
			FamiliarMapper.Instance().Delete(familiar);
			llena_dgvFamilia();
		}
	}
```

### UcCBAgua_SelectedIndexChanged · líneas 12856–12868

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12856](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12856)

```csharp
private void UcCBAgua_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBAgua.SelectedValue, 5, TextCompare: false))
		{
			GroupControl7.Height = 76;
			UcTxtOtroAgua.Visible = true;
		}
		else
		{
			GroupControl7.Height = 49;
			UcTxtOtroAgua.Visible = false;
		}
	}
```

### UcCBExcretas_SelectedIndexChanged · líneas 12870–12882

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12870](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12870)

```csharp
private void UcCBExcretas_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBExcretas.SelectedValue, 5, TextCompare: false))
		{
			GroupControl8.Height = 76;
			UcTxtOtroExcreta.Visible = true;
		}
		else
		{
			GroupControl8.Height = 49;
			UcTxtOtroExcreta.Visible = false;
		}
	}
```

### UcCBAlumbrado_SelectedIndexChanged · líneas 12884–12896

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12884](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12884)

```csharp
private void UcCBAlumbrado_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBAlumbrado.SelectedValue, 5, TextCompare: false))
		{
			GroupControl6.Height = 76;
			UcTxtOtroAlumbrado.Visible = true;
		}
		else
		{
			GroupControl6.Height = 49;
			UcTxtOtroAlumbrado.Visible = false;
		}
	}
```

### btnGuardar_Click · líneas 12898–13862

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:12898](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L12898)

```csharp
private void btnGuardar_Click(object sender, EventArgs e)
	{
		empleado.IdEmpleado = CodEmple;
		Empleado obj = empleado;
		object selectedValue = UcCBTipoTrab.SelectedValue;
		int? num = default(int?);
		obj.IdTipoTrabajador = ((selectedValue != null) ? ((int?)selectedValue) : num);
		if (UcTxtProfesion.TextLength == 0)
		{
			empleado.Profesion = RRHH.nulo;
		}
		else
		{
			empleado.Profesion = UcTxtProfesion.Text;
		}
		Empleado obj2 = empleado;
		object selectedValue2 = UcCBCargo.SelectedValue;
		obj2.IdCargo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		if (Operators.ConditionalCompareObjectEqual(UcCBViveCon.SelectedValue, 0, TextCompare: false))
		{
			empleado.IdViveCon = RRHH.numnulo;
		}
		else
		{
			Empleado obj3 = empleado;
			object selectedValue3 = UcCBViveCon.SelectedValue;
			obj3.IdViveCon = ((selectedValue3 != null) ? ((int?)selectedValue3) : num);
		}
		Empleado obj4 = empleado;
		object editValue = RadioGroup1.EditValue;
		bool? flag = default(bool?);
		obj4.JefeHogar = ((editValue != null) ? ((bool?)editValue) : flag);
		if (UcTxtCargaFam.TextLength == 0)
		{
			empleado.CargaFam = RRHH.nulo;
		}
		else
		{
			empleado.CargaFam = UcTxtCargaFam.Text;
		}
		if (UcTxtNumHijos.TextLength == 0)
		{
			empleado.NumHijos = RRHH.nulo;
		}
		else
		{
			empleado.NumHijos = UcTxtNumHijos.Text;
		}
		if (UcTxtObsFam.TextLength == 0)
		{
			empleado.ObsFam = RRHH.nulo;
		}
		else
		{
			empleado.ObsFam = UcTxtObsFam.Text;
		}
		if (UcTxtAspPsico.TextLength == 0)
		{
			empleado.AspecPsico = RRHH.nulo;
		}
		else
		{
			empleado.AspecPsico = UcTxtAspPsico.Text;
		}
		if (UcTxtAspSocial.TextLength == 0)
		{
			empleado.AspecSocial = RRHH.nulo;
		}
		else
		{
			empleado.AspecSocial = UcTxtAspSocial.Text;
		}
		if (UcTxtDiagSocial.TextLength == 0)
		{
			empleado.DiagnosSocial = RRHH.nulo;
		}
		else
		{
			empleado.DiagnosSocial = UcTxtDiagSocial.Text;
		}
		Empleado obj5 = empleado;
		object selectedValue4 = UcCBCargo.SelectedValue;
		obj5.IdCargo = ((selectedValue4 != null) ? ((int?)selectedValue4) : num);
		DateTime? dateTime = default(DateTime?);
		if (UcCBTipoPersonal.SelectedIndex == 0)
		{
			empleado.NumResolCese = null;
			empleado.FechaResolCese = dateTime;
			empleado.NumResol20530 = null;
			empleado.FechaResol20530 = dateTime;
			empleado.NumResolPenMen = null;
			empleado.FechaResolPenMen = dateTime;
		}
		else
		{
			empleado.NumResolCese = UcTxtResolCese.Text;
			empleado.FechaResolCese = UcDTCese.Value;
			empleado.NumResol20530 = UcTxtResol20530.Text;
			empleado.FechaResol20530 = UcDT20530.Value;
			empleado.NumResolPenMen = UcTxtResolPensionista.Text;
			empleado.FechaResolPenMen = UcDTPension.Value;
		}
		empleado.NumResoIngreEsta = UcTxtResoIngreEst.Text;
		empleado.FechaResolIngreEsta = UcDTFechaResolIngreEstado.Value;
		empleado.FechaIngreEstado = UcDTIngreEsta.Value;
		Empleado obj6 = empleado;
		object selectedValue5 = UcCBRegimen.SelectedValue;
		obj6.IdRegimenPen = ((selectedValue5 != null) ? ((int?)selectedValue5) : num);
		empleado.NumAutogenSalud = UcTxtAutogenSalud.Text;
		if (Operators.ConditionalCompareObjectEqual(UcCBRegimen.SelectedValue, 3, TextCompare: false))
		{
			Empleado obj7 = empleado;
			object selectedValue6 = UcCBAfp.SelectedValue;
			obj7.IdAFP = ((selectedValue6 != null) ? ((int?)selectedValue6) : num);
			empleado.NroAFP = UcTxtNroAfp.Text;
			empleado.FechaAFP = UcDTInscripAFP.Value;
		}
		else
		{
			empleado.IdAFP = num;
			empleado.NroAFP = null;
			empleado.FechaAFP = dateTime;
		}
		EmpleadoMapper.Instance().Update(empleado);
		this.egreso.IdEmpleado = CodEmple;
		this.egreso.Vivienda = UcTxtEgreVivienda.Text.ToDecimal();
		this.egreso.Alimentacion = UcTxtEgreAliment.Text.ToDecimal();
		this.egreso.Vestido = UcTxtEgreVestido.Text.ToDecimal();
		this.egreso.Agua = UcTxtEgreAgua.Text.ToDecimal();
		this.egreso.Telefono = UcTxtEgreFono.Text.ToDecimal();
		this.egreso.SeguroPriv = UcTxtEgreSegPriv.Text.ToDecimal();
		this.egreso.Salud = UcTxtEgreSalud.Text.ToDecimal();
		this.egreso.Educacion = UcTxtEgreEducac.Text.ToDecimal();
		this.egreso.Transporte = UcTxtTransporte.Text.ToDecimal();
		this.egreso.EnergiaElec = UcTxtEnergElec.Text.ToDecimal();
		this.egreso.BajaPolicia = UcTxtEgreBajaPol.Text.ToDecimal();
		this.egreso.Recreacion = UcTxtEgreRecrea.Text.ToDecimal();
		this.egreso.Prestamos = UcTxtEgreDeuda.Text.ToDecimal();
		this.egreso.Otros = UcTxtEgreOtro.Text.ToDecimal();
		this.ingreso.IdEmpleado = CodEmple;
		this.ingreso.Remuneracion = UcTxtIngreRemune.Text.ToDecimal();
		this.ingreso.Otros = UcTxtIngreAdic.Text.ToDecimal();
		this.ingreso.IngresoMiembros = UcTxtIngreMiembros.Text.ToDecimal();
		this.ingreso.AlqBienes = UcTxtIngreBienes.Text.ToDecimal();
		this.ingreso.NumPersonaAportan = UcTxtNumPers.Text;
		bool flag3 = ViviendaMapper.Instance().SelectBy([SpecialName] (Vivienda v) =>
		{
			int codEmple = CodEmple;
			int? idEmpleado = v.IdEmpleado;
			bool? obj8;
			if (!idEmpleado.HasValue)
			{
				obj8 = null;
			}
			else
			{
				bool? flag2 = idEmpleado.GetValueOrDefault() == codEmple;
				obj8 = flag2;
			}
			return (bool)obj8;
		}).Count == 1;
		this.vivienda.IdEmpleado = CodEmple;
		if (Operators.ConditionalCompareObjectEqual(UcCBTenencia.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdTenencia = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdTenencia = num;
			}
		}
		else
		{
			Vivienda obj9 = this.vivienda;
			object selectedValue7 = UcCBTenencia.SelectedValue;
			obj9.IdTenencia = ((selectedValue7 != null) ? ((int?)selectedValue7) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBTipo.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdTipo = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdTipo = num;
			}
		}
		else
		{
			Vivienda obj10 = this.vivienda;
			object selectedValue8 = UcCBTipo.SelectedValue;
			obj10.IdTipo = ((selectedValue8 != null) ? ((int?)selectedValue8) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBMaterial.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdMaterial = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdMaterial = num;
			}
		}
		else
		{
			Vivienda obj11 = this.vivienda;
			object selectedValue9 = UcCBMaterial.SelectedValue;
			obj11.IdMaterial = ((selectedValue9 != null) ? ((int?)selectedValue9) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBConservacion.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdConservacion = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdConservacion = num;
			}
		}
		else
		{
			Vivienda obj12 = this.vivienda;
			object selectedValue10 = UcCBConservacion.SelectedValue;
			obj12.IdConservacion = ((selectedValue10 != null) ? ((int?)selectedValue10) : num);
		}
		if (UcTxtNumDormito.TextLength == 0)
		{
			this.vivienda.NumDormitorio = (flag3 ? RRHH.nulo : null);
		}
		else
		{
			this.vivienda.NumDormitorio = UcTxtNumDormito.Text;
		}
		if (UcTxtServHig.TextLength == 0)
		{
			this.vivienda.NumServHig = (flag3 ? RRHH.nulo : null);
		}
		else
		{
			this.vivienda.NumServHig = UcTxtServHig.Text;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBUbicacion.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdUbicacion = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdUbicacion = num;
			}
		}
		else
		{
			Vivienda obj13 = this.vivienda;
			object selectedValue11 = UcCBUbicacion.SelectedValue;
			obj13.IdUbicacion = ((selectedValue11 != null) ? ((int?)selectedValue11) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBAlumbrado.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdAlumbrado = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdAlumbrado = num;
			}
		}
		else
		{
			Vivienda obj14 = this.vivienda;
			object selectedValue12 = UcCBAlumbrado.SelectedValue;
			obj14.IdAlumbrado = ((selectedValue12 != null) ? ((int?)selectedValue12) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBAlumbrado.SelectedValue, 5, TextCompare: false))
		{
			this.vivienda.OtroAlumbrado = UcTxtOtroAlumbrado.Text;
		}
		else
		{
			this.vivienda.OtroAlumbrado = (flag3 ? RRHH.nulo : null);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBAgua.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdAgua = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdAgua = num;
			}
		}
		else
		{
			Vivienda obj15 = this.vivienda;
			object selectedValue13 = UcCBAgua.SelectedValue;
			obj15.IdAgua = ((selectedValue13 != null) ? ((int?)selectedValue13) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBAgua.SelectedValue, 5, TextCompare: false))
		{
			this.vivienda.OtroAgua = UcTxtOtroAgua.Text;
		}
		else
		{
			this.vivienda.OtroAgua = (flag3 ? RRHH.nulo : null);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBExcretas.SelectedValue, 0, TextCompare: false))
		{
			if (flag3)
			{
				this.vivienda.IdExcretas = RRHH.numnulo;
			}
			else
			{
				this.vivienda.IdExcretas = num;
			}
		}
		else
		{
			Vivienda obj16 = this.vivienda;
			object selectedValue14 = UcCBExcretas.SelectedValue;
			obj16.IdExcretas = ((selectedValue14 != null) ? ((int?)selectedValue14) : num);
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBExcretas.SelectedValue, 5, TextCompare: false))
		{
			this.vivienda.OtroExcreta = UcTxtOtroExcreta.Text;
		}
		else
		{
			this.vivienda.OtroExcreta = (flag3 ? RRHH.nulo : null);
		}
		if (UcTxtNumCompart.TextLength == 0)
		{
			this.vivienda.NumCompart = (flag3 ? RRHH.nulo : null);
		}
		else
		{
			this.vivienda.NumCompart = UcTxtNumCompart.Text.Trim();
		}
		if (UcTxtPerxDorm.TextLength == 0)
		{
			this.vivienda.NumPerDorm = (flag3 ? RRHH.nulo : null);
		}
		else
		{
			this.vivienda.NumPerDorm = UcTxtPerxDorm.Text.Trim();
		}
		if (UcTxtObsVivienda.TextLength == 0)
		{
			this.vivienda.Observacion = (flag3 ? RRHH.nulo : null);
		}
		else
		{
			this.vivienda.Observacion = UcTxtObsVivienda.Text.Trim();
		}
		Vivienda obj17 = this.vivienda;
		object editValue2 = ChckFono.EditValue;
		obj17.Telefono = ((editValue2 != null) ? ((bool?)editValue2) : flag);
		Vivienda obj18 = this.vivienda;
		object editValue3 = ChckInter.EditValue;
		obj18.Internet = ((editValue3 != null) ? ((bool?)editValue3) : flag);
		Vivienda obj19 = this.vivienda;
		object editValue4 = ChckCable.EditValue;
		obj19.Cable = ((editValue4 != null) ? ((bool?)editValue4) : flag);
		Vivienda obj20 = this.vivienda;
		object editValue5 = ChckOtros.EditValue;
		obj20.Otros = ((editValue5 != null) ? ((bool?)editValue5) : flag);
		checked
		{
			if (flag3)
			{
				this.vivienda.IdVivienda = this.vivienda.IdVivienda;
				ViviendaMapper.Instance().Update(this.vivienda);
			}
			else
			{
				List<Vivienda> list = ViviendaMapper.Instance().SelectAll();
				int idVivienda;
				if (list.Count == 0)
				{
					idVivienda = 1;
				}
				else
				{
					Vivienda vivienda = ViviendaMapper.Instance().SelectAll().Last();
					idVivienda = vivienda.IdVivienda + 1;
				}
				this.vivienda.IdVivienda = idVivienda;
				ViviendaMapper.Instance().Insert(this.vivienda);
			}
			if (IngresoMapper.Instance().SelectBy([SpecialName] (Ingreso v) =>
			{
				int codEmple2 = CodEmple;
				int? idEmpleado2 = v.IdEmpleado;
				bool? obj21;
				if (!idEmpleado2.HasValue)
				{
					obj21 = null;
				}
				else
				{
					bool? flag4 = idEmpleado2.GetValueOrDefault() == codEmple2;
					obj21 = flag4;
				}
				return (bool)obj21;
			}).Count == 1)
			{
				this.ingreso.IdIngreso = this.ingreso.IdIngreso;
				IngresoMapper.Instance().Update(this.ingreso);
			}
			else
			{
				int idIngreso;
				if (IngresoMapper.Instance().SelectAll().Count == 0)
				{
					idIngreso = 1;
				}
				else
				{
					Ingreso ingreso = IngresoMapper.Instance().SelectAll().Last();
					idIngreso = ingreso.IdIngreso + 1;
				}
				this.ingreso.IdIngreso = idIngreso;
				IngresoMapper.Instance().Insert(this.ingreso);
			}
			if (EgresoMapper.Instance().SelectBy([SpecialName] (Egreso v) =>
			{
				int codEmple3 = CodEmple;
				int? idEmpleado3 = v.IdEmpleado;
				bool? obj22;
				if (!idEmpleado3.HasValue)
				{
					obj22 = null;
				}
				else
				{
					bool? flag5 = idEmpleado3.GetValueOrDefault() == codEmple3;
					obj22 = flag5;
				}
				return (bool)obj22;
			}).Count == 1)
			{
				this.egreso.IdEgreso = this.egreso.IdEgreso;
				EgresoMapper.Instance().Update(this.egreso);
			}
			else
			{
				int idEgreso;
				if (EgresoMapper.Instance().SelectAll().Count == 0)
				{
					idEgreso = 1;
				}
				else
				{
					Egreso egreso = EgresoMapper.Instance().SelectAll().Last();
					idEgreso = egreso.IdEgreso + 1;
				}
				this.egreso.IdEgreso = idEgreso;
				EgresoMapper.Instance().Insert(this.egreso);
			}
			bool flag7 = RRHH_DinamicaFamiliarMapper.Instance().SelectBy([SpecialName] (RRHH_DinamicaFamiliar v) =>
			{
				int codEmple4 = CodEmple;
				int? idEmpleado4 = v.IdEmpleado;
				bool? obj23;
				if (!idEmpleado4.HasValue)
				{
					obj23 = null;
				}
				else
				{
					bool? flag6 = idEmpleado4.GetValueOrDefault() == codEmple4;
					obj23 = flag6;
				}
				return (bool)obj23;
			}).Count == 1;
			RRHH_dinamicafamiliar.IdEmpleado = CodEmple;
			if (Operators.ConditionalCompareObjectEqual(UcCmbRelHerm.SelectedValue, 0, TextCompare: false))
			{
				if (flag7)
				{
					RRHH_dinamicafamiliar.idRelacHermano = RRHH.numnulo;
				}
				else
				{
					RRHH_dinamicafamiliar.idRelacHermano = num;
				}
			}
			else
			{
				RRHH_DinamicaFamiliar rRHH_dinamicafamiliar = RRHH_dinamicafamiliar;
				object selectedValue15 = UcCmbRelHerm.SelectedValue;
				rRHH_dinamicafamiliar.idRelacHermano = ((selectedValue15 != null) ? ((int?)selectedValue15) : num);
			}
			if (Operators.ConditionalCompareObjectEqual(UcCmbRelPareja.SelectedValue, 0, TextCompare: false))
			{
				if (flag7)
				{
					RRHH_dinamicafamiliar.idRelaPareja = RRHH.numnulo;
				}
				else
				{
					RRHH_dinamicafamiliar.idRelaPareja = num;
				}
			}
			else
			{
				RRHH_DinamicaFamiliar rRHH_dinamicafamiliar2 = RRHH_dinamicafamiliar;
				object selectedValue16 = UcCmbRelPareja.SelectedValue;
				rRHH_dinamicafamiliar2.idRelaPareja = ((selectedValue16 != null) ? ((int?)selectedValue16) : num);
			}
			if (Operators.ConditionalCompareObjectEqual(UcCmbRelPH.SelectedValue, 0, TextCompare: false))
			{
				if (flag7)
				{
					RRHH_dinamicafamiliar.idRelaPH = RRHH.numnulo;
				}
				else
				{
					RRHH_dinamicafamiliar.idRelaPH = num;
				}
			}
			else
			{
				RRHH_DinamicaFamiliar rRHH_dinamicafamiliar3 = RRHH_dinamicafamiliar;
				object selectedValue17 = UcCmbRelPH.SelectedValue;
				rRHH_dinamicafamiliar3.idRelaPH = ((selectedValue17 != null) ? ((int?)selectedValue17) : num);
			}
			if (Operators.ConditionalCompareObjectEqual(UcCmbTipoFam.SelectedValue, 0, TextCompare: false))
			{
				if (flag7)
				{
					RRHH_dinamicafamiliar.idTipoFam = RRHH.numnulo;
				}
				else
				{
					RRHH_dinamicafamiliar.idTipoFam = num;
				}
			}
			else
			{
				RRHH_DinamicaFamiliar rRHH_dinamicafamiliar4 = RRHH_dinamicafamiliar;
				object selectedValue18 = UcCmbTipoFam.SelectedValue;
				rRHH_dinamicafamiliar4.idTipoFam = ((selectedValue18 != null) ? ((int?)selectedValue18) : num);
			}
			if (RRHH_DinamicaFamiliarMapper.Instance().SelectBy([SpecialName] (RRHH_DinamicaFamiliar v) =>
			{
				int codEmple5 = CodEmple;
				int? idEmpleado5 = v.IdEmpleado;
				bool? obj24;
				if (!idEmpleado5.HasValue)
				{
					obj24 = null;
				}
				else
				{
					bool? flag8 = idEmpleado5.GetValueOrDefault() == codEmple5;
					obj24 = flag8;
				}
				return (bool)obj24;
			}).Count == 1)
			{
				RRHH_dinamicafamiliar.idDinamica = RRHH_dinamicafamiliar.idDinamica;
				RRHH_DinamicaFamiliarMapper.Instance().Update(RRHH_dinamicafamiliar);
			}
			else
			{
				int idDinamica;
				if (RRHH_DinamicaFamiliarMapper.Instance().SelectAll().Count == 0)
				{
					idDinamica = 1;
				}
				else
				{
					RRHH_DinamicaFamiliar rRHH_DinamicaFamiliar = RRHH_DinamicaFamiliarMapper.Instance().SelectAll().Last();
					idDinamica = rRHH_DinamicaFamiliar.idDinamica + 1;
				}
				RRHH_dinamicafamiliar.idDinamica = idDinamica;
				RRHH_DinamicaFamiliarMapper.Instance().Insert(RRHH_dinamicafamiliar);
			}
			bool flag10 = RRHH_FuncFamMapper.Instance().SelectBy([SpecialName] (RRHH_FuncFam v) =>
			{
				int codEmple6 = CodEmple;
				int? idEmpleado6 = v.IdEmpleado;
				bool? obj25;
				if (!idEmpleado6.HasValue)
				{
					obj25 = null;
				}
				else
				{
					bool? flag9 = idEmpleado6.GetValueOrDefault() == codEmple6;
					obj25 = flag9;
				}
				return (bool)obj25;
			}).Count == 1;
			RRHH_FuncFam.IdEmpleado = CodEmple;
			if (UcCmbResp1.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Com1 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Com1 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Com1 = UcCmbResp1.Text;
			}
			if (UcCmbResp2.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Com2 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Com2 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Com2 = UcCmbResp2.Text;
			}
			if (UcCmbResp3.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Afec1 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Afec1 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Afec1 = UcCmbResp3.Text;
			}
			if (UcCmbResp4.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Afec2 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Afec2 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Afec2 = UcCmbResp4.Text;
			}
			if (UcCmbResp8.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Decis1 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Decis1 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Decis1 = UcCmbResp8.Text;
			}
			if (UcCmbResp9.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Decis2 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Decis2 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Decis2 = UcCmbResp9.Text;
			}
			if (UcCmbResp5.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Soc1 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Soc1 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Soc1 = UcCmbResp5.Text;
			}
			if (UcCmbResp6.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Soc2 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Soc2 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Soc2 = UcCmbResp6.Text;
			}
			if (UcCmbResp7.SelectedIndex == 0)
			{
				if (flag10)
				{
					RRHH_FuncFam.Soc3 = RRHH.nulo;
				}
				else
				{
					RRHH_FuncFam.Soc3 = null;
				}
			}
			else
			{
				RRHH_FuncFam.Soc3 = UcCmbResp7.Text;
			}
			if (RRHH_FuncFamMapper.Instance().SelectBy([SpecialName] (RRHH_FuncFam v) =>
			{
				int codEmple7 = CodEmple;
				int? idEmpleado7 = v.IdEmpleado;
				bool? obj26;
				if (!idEmpleado7.HasValue)
				{
					obj26 = null;
				}
				else
				{
					bool? flag11 = idEmpleado7.GetValueOrDefault() == codEmple7;
					obj26 = flag11;
				}
				return (bool)obj26;
			}).Count == 1)
			{
				RRHH_FuncFam.idFuncFamiliar = RRHH_FuncFam.idFuncFamiliar;
				RRHH_FuncFamMapper.Instance().Update(RRHH_FuncFam);
			}
			else
			{
				int idFuncFamiliar;
				if (RRHH_FuncFamMapper.Instance().SelectAll().Count == 0)
				{
					idFuncFamiliar = 1;
				}
				else
				{
					RRHH_FuncFam rRHH_FuncFam = RRHH_FuncFamMapper.Instance().SelectAll().Last();
					idFuncFamiliar = rRHH_FuncFam.idFuncFamiliar + 1;
				}
				RRHH_FuncFam.idFuncFamiliar = idFuncFamiliar;
				RRHH_FuncFamMapper.Instance().Insert(RRHH_FuncFam);
			}
			bool flag13 = RRHH_AspSocioMapper.Instance().SelectBy([SpecialName] (RRHH_AspSocio v) =>
			{
				int codEmple8 = CodEmple;
				int? idEmpleado8 = v.IdEmpleado;
				bool? obj27;
				if (!idEmpleado8.HasValue)
				{
					obj27 = null;
				}
				else
				{
					bool? flag12 = idEmpleado8.GetValueOrDefault() == codEmple8;
					obj27 = flag12;
				}
				return (bool)obj27;
			}).Count == 1;
			rrhh_aspSocio.IdEmpleado = CodEmple;
			if (Operators.ConditionalCompareObjectEqual(UcCmboRec1.SelectedValue, 0, TextCompare: false))
			{
				if (flag13)
				{
					rrhh_aspSocio.idPregunta1 = RRHH.numnulo;
				}
				else
				{
					rrhh_aspSocio.idPregunta1 = num;
				}
			}
			else
			{
				RRHH_AspSocio rRHH_AspSocio = rrhh_aspSocio;
				object selectedValue19 = UcCmboRec1.SelectedValue;
				rRHH_AspSocio.idPregunta1 = ((selectedValue19 != null) ? ((int?)selectedValue19) : num);
			}
			if (Operators.ConditionalCompareObjectEqual(UcCmboRec2.SelectedValue, 0, TextCompare: false))
			{
				if (flag13)
				{
					rrhh_aspSocio.idPregunta2 = RRHH.numnulo;
				}
				else
				{
					rrhh_aspSocio.idPregunta2 = num;
				}
			}
			else
			{
				RRHH_AspSocio rRHH_AspSocio2 = rrhh_aspSocio;
				object selectedValue20 = UcCmboRec2.SelectedValue;
				rRHH_AspSocio2.idPregunta2 = ((selectedValue20 != null) ? ((int?)selectedValue20) : num);
			}
			if (Operators.ConditionalCompareObjectEqual(UcCmboRec3.SelectedValue, 0, TextCompare: false))
			{
				if (flag13)
				{
					rrhh_aspSocio.idPregunta3 = RRHH.numnulo;
				}
				else
				{
					rrhh_aspSocio.idPregunta3 = num;
				}
			}
			else
			{
				RRHH_AspSocio rRHH_AspSocio3 = rrhh_aspSocio;
				object selectedValue21 = UcCmboRec3.SelectedValue;
				rRHH_AspSocio3.idPregunta3 = ((selectedValue21 != null) ? ((int?)selectedValue21) : num);
			}
			rrhh_aspSocio.PrincipProblemas = UcTxtRec4.Text.Trim();
			rrhh_aspSocio.PropMejoraInstitu = UcTxtRec5.Text.Trim();
			rrhh_aspSocio.hobby = UcTxtRec6.Text.Trim();
			rrhh_aspSocio.ActRecreaInstitu = UcTxtRec7.Text.Trim();
			if (RRHH_AspSocioMapper.Instance().SelectBy([SpecialName] (RRHH_AspSocio v) =>
			{
				int codEmple9 = CodEmple;
				int? idEmpleado9 = v.IdEmpleado;
				bool? obj28;
				if (!idEmpleado9.HasValue)
				{
					obj28 = null;
				}
				else
				{
					bool? flag14 = idEmpleado9.GetValueOrDefault() == codEmple9;
					obj28 = flag14;
				}
				return (bool)obj28;
			}).Count == 1)
			{
				rrhh_aspSocio.idAspSocio = rrhh_aspSocio.idAspSocio;
				RRHH_AspSocioMapper.Instance().Update(rrhh_aspSocio);
			}
			else
			{
				int idAspSocio;
				if (RRHH_AspSocioMapper.Instance().SelectAll().Count == 0)
				{
					idAspSocio = 1;
				}
				else
				{
					RRHH_AspSocio rRHH_AspSocio4 = RRHH_AspSocioMapper.Instance().SelectAll().Last();
					idAspSocio = rRHH_AspSocio4.idAspSocio + 1;
				}
				rrhh_aspSocio.idAspSocio = idAspSocio;
				RRHH_AspSocioMapper.Instance().Insert(rrhh_aspSocio);
			}
			bool flag16 = RRHH_SaludMapper.Instance().SelectBy([SpecialName] (RRHH_Salud v) =>
			{
				int codEmple10 = CodEmple;
				int? idEmpleado10 = v.IdEmpleado;
				bool? obj29;
				if (!idEmpleado10.HasValue)
				{
					obj29 = null;
				}
				else
				{
					bool? flag15 = idEmpleado10.GetValueOrDefault() == codEmple10;
					obj29 = flag15;
				}
				return (bool)obj29;
			}).Count == 1;
			rrhh_salud.IdEmpleado = CodEmple;
			RRHH_Salud rRHH_Salud = rrhh_salud;
			object editValue6 = RadioGroup2.EditValue;
			rRHH_Salud.EnferCronica = ((editValue6 != null) ? ((bool?)editValue6) : flag);
			rrhh_salud.EnferCronicaDescrip = UcTxtEnfCronica.Text.Trim();
			RRHH_Salud rRHH_Salud2 = rrhh_salud;
			object editValue7 = RadioGroup3.EditValue;
			rRHH_Salud2.FamDiscapacidad = ((editValue7 != null) ? ((bool?)editValue7) : flag);
			rrhh_salud.FamDiscapDescrip = UcTxtFamDiscap.Text.Trim();
			RRHH_Salud rRHH_Salud3 = rrhh_salud;
			object editValue8 = RadioGroup4.EditValue;
			rRHH_Salud3.Alergico = ((editValue8 != null) ? ((bool?)editValue8) : flag);
			rrhh_salud.AlergicoDescrip = UcTxtAlergico.Text.Trim();
			if (Operators.ConditionalCompareObjectEqual(UcCmbAcudeEnf.SelectedValue, 0, TextCompare: false))
			{
				if (flag16)
				{
					rrhh_salud.idAcudeEnferm = RRHH.numnulo;
				}
				else
				{
					rrhh_salud.idAcudeEnferm = num;
				}
			}
			else
			{
				RRHH_Salud rRHH_Salud4 = rrhh_salud;
				object selectedValue22 = UcCmbAcudeEnf.SelectedValue;
				rRHH_Salud4.idAcudeEnferm = ((selectedValue22 != null) ? ((int?)selectedValue22) : num);
			}
			if (RRHH_SaludMapper.Instance().SelectBy([SpecialName] (RRHH_Salud v) =>
			{
				int codEmple11 = CodEmple;
				int? idEmpleado11 = v.IdEmpleado;
				bool? obj30;
				if (!idEmpleado11.HasValue)
				{
					obj30 = null;
				}
				else
				{
					bool? flag17 = idEmpleado11.GetValueOrDefault() == codEmple11;
					obj30 = flag17;
				}
				return (bool)obj30;
			}).Count == 1)
			{
				rrhh_salud.idSalud = rrhh_salud.idSalud;
				RRHH_SaludMapper.Instance().Update(rrhh_salud);
			}
			else
			{
				int idSalud;
				if (RRHH_SaludMapper.Instance().SelectAll().Count == 0)
				{
					idSalud = 1;
				}
				else
				{
					RRHH_Salud rRHH_Salud5 = RRHH_SaludMapper.Instance().SelectAll().Last();
					idSalud = rRHH_Salud5.idSalud + 1;
				}
				rrhh_salud.idSalud = idSalud;
				RRHH_SaludMapper.Instance().Insert(rrhh_salud);
			}
			DialogResult = DialogResult.OK;
		}
	}
```

### UcCBRegimen_SelectedIndexChanged · líneas 13864–13884

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13864](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13864)

```csharp
private void UcCBRegimen_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(UcCBRegimen.SelectedValue, 3, TextCompare: false))
		{
			Label44.Visible = false;
			UcCBAfp.Visible = false;
			Label45.Visible = false;
			UcTxtNroAfp.Visible = false;
			Label48.Visible = false;
			UcDTInscripAFP.Visible = false;
		}
		else
		{
			Label44.Visible = true;
			UcCBAfp.Visible = true;
			Label45.Visible = true;
			UcTxtNroAfp.Visible = true;
			Label48.Visible = true;
			UcDTInscripAFP.Visible = true;
		}
	}
```

### Button3_Click · líneas 13886–13895

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13886](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13886)

```csharp
private void Button3_Click(object sender, EventArgs e)
	{
		FrmEstudiosRealizados frmEstudiosRealizados = new FrmEstudiosRealizados();
		frmEstudiosRealizados.CodEmple = CodEmple;
		frmEstudiosRealizados.ShowDialog();
		if (frmEstudiosRealizados.DialogResult == DialogResult.OK)
		{
			llena_dgvEstudios();
		}
	}
```

### BtnModEst_Click · líneas 13897–13914

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13897](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13897)

```csharp
private void BtnModEst_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewEstudios.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar Registro");
			return;
		}
		int codEstudio = Conversions.ToInteger(GridViewEstudios.GetRowCellValue(focusedRowHandle, "IdTipoEstudios"));
		FrmEstudiosRealizados frmEstudiosRealizados = new FrmEstudiosRealizados();
		frmEstudiosRealizados.CodEmple = CodEmple;
		frmEstudiosRealizados.codEstudio = codEstudio;
		frmEstudiosRealizados.ShowDialog();
		if (frmEstudiosRealizados.DialogResult == DialogResult.OK)
		{
			llena_dgvEstudios();
		}
	}
```

### BtnEliminarEst_Click · líneas 13916–13932

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13916](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13916)

```csharp
private void BtnEliminarEst_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewEstudios.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Registro");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar los Estudios: ", GridViewEstudios.GetRowCellValue(focusedRowHandle, "DescripTipoEst"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idTipoEstudios = Conversions.ToInteger(GridViewEstudios.GetRowCellValue(focusedRowHandle, "IdTipoEstudios"));
			EstudiosRealizado estudiosRealizado = new EstudiosRealizado();
			estudiosRealizado.IdTipoEstudios = idTipoEstudios;
			estudiosRealizado.IdEmpleado = CodEmple;
			EstudiosRealizadoMapper.Instance().Delete(estudiosRealizado);
			llena_dgvEstudios();
		}
	}
```

### Button2_Click · líneas 13934–13943

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13934](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13934)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		FrmTitulos frmTitulos = new FrmTitulos();
		frmTitulos.CodEmple = CodEmple;
		frmTitulos.ShowDialog();
		if (frmTitulos.DialogResult == DialogResult.OK)
		{
			llena_dgvTitulos();
		}
	}
```

### BtnEliminarGrados_Click · líneas 13945–13961

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13945](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13945)

```csharp
private void BtnEliminarGrados_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewTitulos.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Documento");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea Eliminar el Titulo: ", GridViewTitulos.GetRowCellValue(focusedRowHandle, "NumColegiatura"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int num = Conversions.ToInteger(GridViewTitulos.GetRowCellValue(focusedRowHandle, "NumColegiatura"));
			TitulosEmpleado titulosEmpleado = new TitulosEmpleado();
			titulosEmpleado.NumColegiatura = Conversions.ToString(num);
			titulosEmpleado.IdEmpleado = CodEmple;
			TitulosEmpleadoMapper.Instance().Delete(titulosEmpleado);
			llena_dgvTitulos();
		}
	}
```

### Button1_Click · líneas 13963–13972

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13963](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13963)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		FrmCapacitaciones frmCapacitaciones = new FrmCapacitaciones();
		frmCapacitaciones.codemple = CodEmple;
		frmCapacitaciones.ShowDialog();
		if (frmCapacitaciones.DialogResult == DialogResult.OK)
		{
			llena_dgvCapacitaciones();
		}
	}
```

### BtnEliminarCap_Click · líneas 13974–13986

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13974](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13974)

```csharp
private void BtnEliminarCap_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewCapacitacion.FocusedRowHandle;
		if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea Eliminar la Capacitación: ", GridViewCapacitacion.GetRowCellValue(focusedRowHandle, "NombreCurso"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idCapacitacion = Conversions.ToInteger(GridViewCapacitacion.GetRowCellValue(focusedRowHandle, "IdCapacitacion"));
			Capacitacion capacitacion = new Capacitacion();
			capacitacion.IdCapacitacion = idCapacitacion;
			capacitacion.IdEmpleado = CodEmple;
			CapacitacionMapper.Instance().Delete(capacitacion);
			llena_dgvCapacitaciones();
		}
	}
```

### GridViewTitulos_RowUpdated · líneas 13988–13996

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13988](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13988)

```csharp
private void GridViewTitulos_RowUpdated(object sender, RowObjectEventArgs e)
	{
		TitulosEmpleado titulosEmpleado = (TitulosEmpleado)e.Row;
		if (titulosEmpleado.DenominacionGrado != null)
		{
			TitulosEmpleadoMapper.Instance().Update(titulosEmpleado);
			MessageBox.Show("Se actualizó el registro :" + ObtenerMensaje(titulosEmpleado), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
```

### ObtenerMensaje · líneas 13998–14007

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:13998](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L13998)

```csharp
private string ObtenerMensaje(TitulosEmpleado obj, bool EsEliminar = true)
	{
		string text = "\r\nColegiatura=" + obj.NumColegiatura + "\r\n";
		text = text + "Grado y/o Titulo=" + obj.DenominacionGrado + "\r\n";
		if (!EsEliminar)
		{
			text += " correctamente";
		}
		return text;
	}
```

### GridViewCapacitacion_RowUpdated · líneas 14009–14017

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14009](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14009)

```csharp
private void GridViewCapacitacion_RowUpdated(object sender, RowObjectEventArgs e)
	{
		Capacitacion capacitacion = (Capacitacion)e.Row;
		if (capacitacion.NombreCurso != null)
		{
			CapacitacionMapper.Instance().Update(capacitacion);
			MessageBox.Show("Se actualizó el registro :" + ObtenerMensajeCap(capacitacion), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
```

### ObtenerMensajeCap · líneas 14019–14028

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14019](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14019)

```csharp
private string ObtenerMensajeCap(Capacitacion obj, bool EsEliminar = true)
	{
		string text = "\r\nCapacitacion=" + obj.NombreCurso + "\r\n";
		text = text + "Organizado por=" + obj.InstitucionOrganizadora + "\r\n";
		if (!EsEliminar)
		{
			text += " correctamente";
		}
		return text;
	}
```

### BtnAgregarExp_Click · líneas 14030–14039

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14030](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14030)

```csharp
private void BtnAgregarExp_Click(object sender, EventArgs e)
	{
		FrmExpLaboral frmExpLaboral = new FrmExpLaboral();
		frmExpLaboral.codemple = CodEmple;
		frmExpLaboral.ShowDialog();
		if (frmExpLaboral.DialogResult == DialogResult.OK)
		{
			llena_dgvExpLab();
		}
	}
```

### BtnModExpLab_Click · líneas 14041–14058

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14041](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14041)

```csharp
private void BtnModExpLab_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewExpLab.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar una Exp. Lab.");
			return;
		}
		int codExpLab = Conversions.ToInteger(GridViewExpLab.GetRowCellValue(focusedRowHandle, "idExpLab"));
		FrmExpLaboral frmExpLaboral = new FrmExpLaboral();
		frmExpLaboral.codemple = CodEmple;
		frmExpLaboral.codExpLab = codExpLab;
		frmExpLaboral.ShowDialog();
		if (frmExpLaboral.DialogResult == DialogResult.OK)
		{
			llena_dgvExpLab();
		}
	}
```

### BtnElimExpLab_Click · líneas 14060–14076

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14060](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14060)

```csharp
private void BtnElimExpLab_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewExpLab.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar una Exp. Lab.");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Registro: ", GridViewExpLab.GetRowCellValue(focusedRowHandle, "NomInstitucion"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idExpLab = Conversions.ToInteger(GridViewExpLab.GetRowCellValue(focusedRowHandle, "idExpLab"));
			ExpLaboral expLaboral = new ExpLaboral();
			expLaboral.IdExpLab = idExpLab;
			expLaboral.IdEmpleado = CodEmple;
			ExpLaboralMapper.Instance().Delete(expLaboral);
			llena_dgvExpLab();
		}
	}
```

### UcCBTipoPersonal_SelectedIndexChanged · líneas 14078–14104

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14078](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14078)

```csharp
private void UcCBTipoPersonal_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UcCBTipoPersonal.SelectedIndex == 0)
		{
			GroupControl18.Visible = true;
			GroupControl16.Visible = false;
			GroupControl groupControl = GroupControl15;
			Point location = new Point(3, 297);
			groupControl.Location = location;
			GroupControl33.Visible = true;
			GroupControl groupControl2 = GroupControl33;
			location = new Point(3, 470);
			groupControl2.Location = location;
		}
		else if (UcCBTipoPersonal.SelectedIndex == 1)
		{
			GroupControl18.Visible = false;
			GroupControl16.Visible = true;
			GroupControl groupControl3 = GroupControl16;
			Point location = new Point(3, 36);
			groupControl3.Location = location;
			GroupControl groupControl4 = GroupControl15;
			location = new Point(3, 195);
			groupControl4.Location = location;
			GroupControl33.Visible = false;
		}
	}
```

### BtnCerrar_Click · líneas 14106–14109

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14106](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14106)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### BtnAgregarDisci_Click · líneas 14111–14120

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14111](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14111)

```csharp
private void BtnAgregarDisci_Click(object sender, EventArgs e)
	{
		FrmDisciplina frmDisciplina = new FrmDisciplina();
		frmDisciplina.CodEmple = CodEmple;
		frmDisciplina.ShowDialog();
		if (frmDisciplina.DialogResult == DialogResult.OK)
		{
			llena_DgvDisciplina();
		}
	}
```

### BtnModDisci_Click · líneas 14122–14139

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14122](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14122)

```csharp
private void BtnModDisci_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewDisciplina.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Documento");
			return;
		}
		int codDisci = Conversions.ToInteger(GridViewDisciplina.GetRowCellValue(focusedRowHandle, "idComportamiento"));
		FrmDisciplina frmDisciplina = new FrmDisciplina();
		frmDisciplina.CodEmple = CodEmple;
		frmDisciplina.CodDisci = codDisci;
		frmDisciplina.ShowDialog();
		if (frmDisciplina.DialogResult == DialogResult.OK)
		{
			llena_DgvDisciplina();
		}
	}
```

### BtnEliminarDisci_Click · líneas 14141–14157

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14141](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14141)

```csharp
private void BtnEliminarDisci_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewDisciplina.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Documento");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Documento: ", GridViewDisciplina.GetRowCellValue(focusedRowHandle, "NumResol"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idComportamiento = Conversions.ToInteger(GridViewDisciplina.GetRowCellValue(focusedRowHandle, "idComportamiento"));
			Comportamiento comportamiento = new Comportamiento();
			comportamiento.idComportamiento = idComportamiento;
			comportamiento.IdEmpleado = CodEmple;
			ComportamientoMapper.Instance().Delete(comportamiento);
			llena_DgvDisciplina();
		}
	}
```

### RadioGroup2_EditValueChanged · líneas 14159–14171

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14159](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14159)

```csharp
private void RadioGroup2_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(RadioGroup2.EditValue, true, TextCompare: false))
		{
			UcTxtEnfCronica.Visible = true;
			Label60.Visible = true;
		}
		else
		{
			UcTxtEnfCronica.Visible = false;
			Label60.Visible = false;
		}
	}
```

### RadioGroup3_EditValueChanged · líneas 14173–14185

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14173](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14173)

```csharp
private void RadioGroup3_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(RadioGroup3.EditValue, true, TextCompare: false))
		{
			UcTxtFamDiscap.Visible = true;
			Label62.Visible = true;
		}
		else
		{
			UcTxtFamDiscap.Visible = false;
			Label62.Visible = false;
		}
	}
```

### RadioGroup4_EditValueChanged · líneas 14187–14199

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14187](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14187)

```csharp
private void RadioGroup4_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(RadioGroup4.EditValue, true, TextCompare: false))
		{
			UcTxtAlergico.Visible = true;
			Label65.Visible = true;
		}
		else
		{
			UcTxtAlergico.Visible = false;
			Label65.Visible = false;
		}
	}
```

### Button4_Click · líneas 14201–14210

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14201](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14201)

```csharp
private void Button4_Click(object sender, EventArgs e)
	{
		FrmPeriodoLaboral frmPeriodoLaboral = new FrmPeriodoLaboral();
		frmPeriodoLaboral.CodEmple = CodEmple;
		frmPeriodoLaboral.ShowDialog();
		if (frmPeriodoLaboral.DialogResult == DialogResult.OK)
		{
			llena_dgvPerLab();
		}
	}
```

### llena_dgvPerLab · líneas 14212–14216

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14212](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14212)

```csharp
private void llena_dgvPerLab()
	{
		List<spRRHH_GetPeriodoLaboralByEmpleadoResult> dataSource = Module1.DcGrll.spRRHH_GetPeriodoLaboralByEmpleado(CodEmple).ToList();
		DGVPerLab.DataSource = dataSource;
	}
```

### Button3_Click_1 · líneas 14218–14234

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14218](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14218)

```csharp
private void Button3_Click_1(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewPerLab.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Periodo Lab.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		FrmPeriodoLaboral frmPeriodoLaboral = new FrmPeriodoLaboral();
		frmPeriodoLaboral.CodEmple = CodEmple;
		frmPeriodoLaboral.nro = Conversions.ToInteger(GridViewPerLab.GetRowCellValue(focusedRowHandle, "NroPeriodo"));
		frmPeriodoLaboral.ShowDialog();
		if (frmPeriodoLaboral.DialogResult == DialogResult.OK)
		{
			llena_dgvPerLab();
		}
	}
```

### Button5_Click · líneas 14236–14251

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14236](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14236)

```csharp
private void Button5_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewPerLab.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar una Periodo Lab.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Periodo: ", GridViewPerLab.GetRowCellValue(focusedRowHandle, "FechaIngreso"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			PeriodoLaboral periodoLaboral = new PeriodoLaboral();
			periodoLaboral.NroPeriodo = Conversions.ToInteger(GridViewPerLab.GetRowCellValue(focusedRowHandle, "NroPeriodo"));
			periodoLaboral.IdEmpleado = CodEmple;
			PeriodoLaboralMapper.Instance().Delete(periodoLaboral);
			llena_dgvPerLab();
		}
	}
```

### btnAgregarAsegurado_Click · líneas 14253–14262

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14253](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14253)

```csharp
private void btnAgregarAsegurado_Click(object sender, EventArgs e)
	{
		FrmRegistroAsegurado frmRegistroAsegurado = new FrmRegistroAsegurado();
		frmRegistroAsegurado.idEmpleado = CodEmple;
		frmRegistroAsegurado.ShowDialog();
		if (frmRegistroAsegurado.DialogResult == DialogResult.OK)
		{
			llena_dgvAsegurados();
		}
	}
```

### btnmodificarAsegurado_Click · líneas 14264–14280

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14264](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14264)

```csharp
private void btnmodificarAsegurado_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GVAsegurados.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Asegurado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		FrmRegistroAsegurado frmRegistroAsegurado = new FrmRegistroAsegurado();
		frmRegistroAsegurado.idEmpleado = CodEmple;
		frmRegistroAsegurado.oRRHH_Asegurado.NroBeneficiario = Conversions.ToInteger(GVAsegurados.GetRowCellValue(focusedRowHandle, "NroBeneficiario"));
		frmRegistroAsegurado.ShowDialog();
		if (frmRegistroAsegurado.DialogResult == DialogResult.OK)
		{
			llena_dgvAsegurados();
		}
	}
```

### Button7_Click · líneas 14282–14291

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14282](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14282)

```csharp
private void Button7_Click(object sender, EventArgs e)
	{
		FrmRotaciones frmRotaciones = new FrmRotaciones();
		frmRotaciones.idEmpleado = CodEmple;
		frmRotaciones.ShowDialog();
		if (frmRotaciones.DialogResult == DialogResult.OK)
		{
			llena_dgvExpLab();
		}
	}
```

### XtraTabPage1_DoubleClick · líneas 14293–14295

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14293](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14293)

```csharp
private void XtraTabPage1_DoubleClick(object sender, EventArgs e)
	{
	}
```

### Button6_Click · líneas 14297–14314

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14297](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14297)

```csharp
private void Button6_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewRotaciones.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar Registro");
			return;
		}
		int idRotacion = Conversions.ToInteger(GridViewRotaciones.GetRowCellValue(focusedRowHandle, "idRotacion"));
		FrmRotaciones frmRotaciones = new FrmRotaciones();
		frmRotaciones.idEmpleado = CodEmple;
		frmRotaciones.idRotacion = idRotacion;
		frmRotaciones.ShowDialog();
		if (frmRotaciones.DialogResult == DialogResult.OK)
		{
			llena_dvgRotaciones();
		}
	}
```

### Button8_Click · líneas 14316–14332

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14316](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14316)

```csharp
private void Button8_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewRotaciones.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar un Registro");
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar la Rotación: ", GridViewRotaciones.GetRowCellValue(focusedRowHandle, "NroMemo"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idRotacion = Conversions.ToInteger(GridViewRotaciones.GetRowCellValue(focusedRowHandle, "idRotacion"));
			Rotacion rotacion = new Rotacion();
			rotacion.idRotacion = idRotacion;
			rotacion.idEmpleado = CodEmple;
			RotacionMapper.Instance().Delete(rotacion);
			llena_dvgRotaciones();
		}
	}
```

### Button10_Click · líneas 14334–14343

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14334](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14334)

```csharp
private void Button10_Click(object sender, EventArgs e)
	{
		FrmResoluciones frmResoluciones = new FrmResoluciones();
		frmResoluciones.codemple = CodEmple;
		frmResoluciones.ShowDialog();
		if (frmResoluciones.DialogResult == DialogResult.OK)
		{
			llena_dvgResoluciones();
		}
	}
```

### Button9_Click · líneas 14345–14362

[Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs:14345](../../Software/RecursosHumanos/RecursosHumanos/FrmFichaSocial.cs#L14345)

```csharp
private void Button9_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewResoluciones.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Primero debe Seleccionar Registro");
			return;
		}
		int idResolucion = Conversions.ToInteger(GridViewResoluciones.GetRowCellValue(focusedRowHandle, "idRotacion"));
		FrmResoluciones frmResoluciones = new FrmResoluciones();
		frmResoluciones.codemple = CodEmple;
		frmResoluciones.idResolucion = idResolucion;
		frmResoluciones.ShowDialog();
		if (frmResoluciones.DialogResult == DialogResult.OK)
		{
			llena_dvgResoluciones();
		}
	}
```

<a id="f-020"></a>

## FrmHorarioEsp


### FrmHorarioEsp · líneas 475–483

[Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:475](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L475)

```csharp
public FrmHorarioEsp()
	{
		base.Load += FrmHorarioEsp_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		dt = new List<Horario>();
		InitializeComponent();
	}
```

### FrmHorarioEsp_Load · líneas 924–964

[Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:924](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L924)

```csharp
private void FrmHorarioEsp_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			}
		}
		dt = HorarioMapper.Instance().SelectAll();
		dt.Insert(0, new Horario
		{
			idHorario = 0,
			Descrip_Horario = "--SELECCIONAR--"
		});
		UcCmbTipoPermiso.DataSource = dt;
		UcCmbTipoPermiso.DisplayMember = "Descrip_Horario";
		UcCmbTipoPermiso.ValueMember = "idHorario";
		if (Npermiso != 0)
		{
			HorarioTemporal horarioTemporal = HorarioTemporalMapper.Instance().SelectBy([SpecialName] (HorarioTemporal v) => (v.idEmpleado == idEmpleado) & (v.N == Npermiso)).Single();
			UcCmbTipoPermiso.SelectedValue = horarioTemporal.HorarioAsignado;
			UcTxtRef.Text = horarioTemporal.NroDocumento.ToString();
			UcTxtSisgedo.Text = horarioTemporal.Sisgedo.ToString();
			RangoFecha rango = new RangoFecha(horarioTemporal.FechaInicio.Value, horarioTemporal.FechaFin.Value);
			UcFechas.Rango = rango;
		}
	}
```

### UcCmbTipoPermiso_SelectedIndexChanged · líneas 966–975

[Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:966](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L966)

```csharp
private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UcCmbTipoPermiso.SelectedIndex == 0)
		{
			lblHorario.Text = "";
			return;
		}
		Horario horario = dt[UcCmbTipoPermiso.SelectedIndex];
		lblHorario.Text = "Ingreso: " + horario.Ingreso1 + " | Salida:" + horario.Salida2;
	}
```

### btnGuardar_Click · líneas 977–1018

[Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:977](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L977)

```csharp
private void btnGuardar_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Horario Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Npermiso == 0)
		{
			List<HorarioTemporal> list = HorarioTemporalMapper.Instance().SelectBy([SpecialName] (HorarioTemporal p) => (p.idEmpleado == idEmpleado) & (Operators.CompareString(p.FechaInicio.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) <= 0) & (Operators.CompareString(p.FechaFin.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) >= 0));
			if (list.Count >= 1)
			{
				MessageBox.Show("El Empleado ya Registra este Horario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		HorarioTemporal horarioTemporal = new HorarioTemporal();
		horarioTemporal.idEmpleado = idEmpleado;
		horarioTemporal.FechaFin = Conversions.ToDate(UcFechas.Rango.Hasta.ToShortDateString());
		horarioTemporal.FechaInicio = Conversions.ToDate(UcFechas.Rango.Desde.ToShortDateString());
		object selectedValue = UcCmbTipoPermiso.SelectedValue;
		int? num = default(int?);
		horarioTemporal.HorarioAsignado = ((selectedValue != null) ? ((int?)selectedValue) : num);
		horarioTemporal.NroDocumento = UcTxtRef.Text.Trim();
		horarioTemporal.Sisgedo = UcTxtSisgedo.Text.Trim();
		if (Npermiso == 0)
		{
			horarioTemporal.N = objClassRRHH.SgtIdHorarioTemporal(idEmpleado);
			HorarioTemporalMapper.Instance().Insert(horarioTemporal);
		}
		else
		{
			horarioTemporal.N = Npermiso;
			HorarioTemporalMapper.Instance().Update(horarioTemporal);
		}
		DialogResult = DialogResult.OK;
	}
```

### cmdCerrar_Click · líneas 1020–1023

[Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs:1020](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarioEsp.cs#L1020)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-021"></a>

## FrmHorarios


### FrmHorarios · líneas 289–295

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:289](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L289)

```csharp
[DebuggerNonUserCode]
	public FrmHorarios()
	{
		base.Load += FrmHorarios_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### ConfigurarEditor · líneas 562–563

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:562](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L562)

```csharp
internal void ConfigurarEditor(Func<int?, bool> abrirEditor) =>
        _abrirEditor = abrirEditor ?? throw new ArgumentNullException(nameof(abrirEditor));
```

### AbrirEditor · líneas 566–567

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:566](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L566)

```csharp
public bool AbrirEditor(int? id) => _abrirEditor != null ? _abrirEditor(id) :
        throw new InvalidOperationException("Abra horarios desde el menú principal.");
```

### MostrarHorarios · líneas 570–580

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:570](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L570)

```csharp
public void MostrarHorarios(IReadOnlyList<HorarioDto> horarios)
    {
        GridColumn1.FieldName = nameof(HorarioDto.Id);
        GridColumn6.FieldName = nameof(HorarioDto.Descripcion);
        GridColumn2.FieldName = nameof(HorarioDto.Ingreso1);
        GridColumn4.FieldName = nameof(HorarioDto.Salida1);
        GridColumn5.FieldName = nameof(HorarioDto.Ingreso2);
        GridColumn3.FieldName = nameof(HorarioDto.Salida2);
        GridColumn7.FieldName = nameof(HorarioDto.Estado);
        DGVHorarios.DataSource = new BindingList<HorarioDto>(new List<HorarioDto>(horarios));
    }
```

### HabilitarAcciones · líneas 583–588

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:583](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L583)

```csharp
public void HabilitarAcciones(bool habilitadas)
    {
        BtnAgregar.Enabled = habilitadas;
        BtnMod.Enabled = habilitadas;
        BtnEliminar.Enabled = habilitadas;
    }
```

### ConfirmarEliminacion · líneas 591–593

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:591](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L591)

```csharp
public bool ConfirmarEliminacion() => MessageBox.Show(this,
        "¿Desea eliminar el horario seleccionado?", "Horarios",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
```

### MostrarError · líneas 596–597

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:596](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L596)

```csharp
public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje,
        "Horarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
```

### FrmHorarios_Load · líneas 599–599

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:599](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L599)

```csharp
private void FrmHorarios_Load(object sender, EventArgs e) => CargarSolicitado?.Invoke(this, EventArgs.Empty);
```

### BtnAgregar_Click · líneas 600–600

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:600](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L600)

```csharp
private void BtnAgregar_Click(object sender, EventArgs e) => AgregarSolicitado?.Invoke(this, EventArgs.Empty);
```

### BtnMod_Click · líneas 601–601

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:601](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L601)

```csharp
private void BtnMod_Click(object sender, EventArgs e) => EditarSolicitado?.Invoke(this, EventArgs.Empty);
```

### BtnEliminar_Click · líneas 602–602

[Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs:602](../../Software/RecursosHumanos/RecursosHumanos/FrmHorarios.cs#L602)

```csharp
private void BtnEliminar_Click(object sender, EventArgs e) => EliminarSolicitado?.Invoke(this, EventArgs.Empty);
```

<a id="f-022"></a>

## FrmHorasTrabajadas


### FrmHorasTrabajadas · líneas 349–356

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:349](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L349)

```csharp
[DebuggerNonUserCode]
	public FrmHorasTrabajadas()
	{
		base.FormClosing += FrmHorasTrabajadas_FormClosing;
		base.Load += FrmHorasTrabajadas_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmHorasTrabajadas_FormClosing · líneas 651–661

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:651](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L651)

```csharp
private void FrmHorasTrabajadas_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (objLibroExcel != null)
		{
			EiminaReferencias(ref objHojaExcel);
			EiminaReferencias(ref objLibroExcel);
			EiminaReferencias(ref m_Excel);
		}
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}
```

### FrmHorasTrabajadas_Load · líneas 663–688

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:663](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L663)

```csharp
private void FrmHorasTrabajadas_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}
```

### BtnGenerar_Click · líneas 690–711

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:690](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L690)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Tipo de Trabajador", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridControl gridControl = GridControl1;
		PostgreSqlLegacyContext dcGrll = Module1.DcGrll;
		string fI = fi;
		string obj = ff;
		object selectedValue = UcCBPartidaPresupuestal.SelectedValue;
		int? num = default(int?);
		gridControl.DataSource = dcGrll.spRRHH_GetRecordAsistenciasSemanales(fI, obj, (selectedValue != null) ? ((int?)selectedValue) : num);
	}
```

### BtnExportarExcel_Click · líneas 713–849

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:713](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L713)

```csharp
private void BtnExportarExcel_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_RecordHorasTrabajadas" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_RecordHorasTrabajadas_" + fi + "_" + ff;
		GridControl1.ExportToXls(text2, xlsExportOptions);
		if (!MyProject.Computer.FileSystem.FileExists(text2))
		{
			Interaction.MsgBox(text2 + " No Existe");
			return;
		}
		m_Excel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(m_Excel, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		objLibroExcel = RuntimeHelpers.GetObjectValue(obj);
		objHojaExcel = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objLibroExcel, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.RutaLogo))
		{
			object instance2 = NewLateBinding.LateGet(objHojaExcel, null, "Shapes", new object[0], null, null, null);
			array = new object[7];
			object[] array3 = array;
			MySettings settings = MySettingsProperty.Settings;
			array3[0] = settings.RutaLogo;
			array[1] = MsoTriState.msoFalse;
			array[2] = MsoTriState.msoCTrue;
			array[3] = 5;
			array[4] = 5;
			array[5] = 50;
			array[6] = 50;
			object[] array4 = array;
			object[] arguments2 = array4;
			array2 = new bool[7] { true, false, false, false, false, false, false };
			NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "RowHeight", new object[1] { 48 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "Orientation", new object[1] { 90 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		checked
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance3 = objHojaExcel;
			object[] array4 = new object[2] { "A2", null };
			object[] array5 = array4;
			object obj2 = objHojaExcel;
			object instance4 = obj2;
			array = new object[2];
			object[] array6 = array;
			int num = 2;
			array6[0] = num;
			object[] array7 = array;
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(instance3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Record de Horas Trabajadas" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance6 = objHojaExcel;
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objHojaExcel;
			object instance7 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance7, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance8 = NewLateBinding.LateGet(instance6, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance8, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objHojaExcel, null, "Protect", new object[16]
			{
				"[CLAVE DE PROTECCIÓN OCULTA]", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSet(m_Excel, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

### EiminaReferencias · líneas 851–866

[Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs:851](../../Software/RecursosHumanos/RecursosHumanos/FrmHorasTrabajadas.cs#L851)

```csharp
private void EiminaReferencias(ref object Referencias)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(Referencias));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Referencias = null;
		}
	}
```

<a id="f-023"></a>

## FrmImportarAsistencia


### FrmImportarAsistencia · líneas 190–196

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:190](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L190)

```csharp
[DebuggerNonUserCode]
	public FrmImportarAsistencia()
	{
		base.Load += FrmImportarAsistencia_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 395–400

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:395](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L395)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}
```

### BackgroundWorker1_DoWork · líneas 402–415

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:402](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L402)

```csharp
private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (asistenciaAccess.Access2SqlSEDE(fechaInicial, fechaFinal, Conversions.ToInteger(Interaction.IIf(CheckEditForzar.Checked, 1, 0))))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
```

### BackgroundWorker1_RunWorkerCompleted · líneas 417–421

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:417](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L417)

```csharp
private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
```

### FrmImportarAsistencia_Load · líneas 423–425

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs:423](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistencia.cs#L423)

```csharp
private void FrmImportarAsistencia_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-024"></a>

## FrmImportarAsistenciaBio


### FrmImportarAsistenciaBio · líneas 172–177

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs:172](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs#L172)

```csharp
[DebuggerNonUserCode]
	public FrmImportarAsistenciaBio()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 363–368

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs:363](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs#L363)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}
```

### BackgroundWorker1_DoWork · líneas 370–383

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs:370](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs#L370)

```csharp
private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		RRHHClass rRHHClass = new RRHHClass();
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (rRHHClass.importarBio(fechaInicial, fechaFinal))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
```

### BackgroundWorker1_RunWorkerCompleted · líneas 385–389

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs:385](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaBio.cs#L385)

```csharp
private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
```

<a id="f-025"></a>

## FrmImportarAsistenciaCONSEJO


### FrmImportarAsistenciaCONSEJO · líneas 190–195

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs:190](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs#L190)

```csharp
[DebuggerNonUserCode]
	public FrmImportarAsistenciaCONSEJO()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 388–393

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs:388](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs#L388)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}
```

### BackgroundWorker1_DoWork · líneas 395–408

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs:395](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs#L395)

```csharp
private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (asistenciaAccess.Access2SqlCONSEJO(fechaInicial, fechaFinal, Conversions.ToInteger(Interaction.IIf(CheckEditForzar.Checked, 1, 0))))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
```

### BackgroundWorker1_RunWorkerCompleted · líneas 410–414

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs:410](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaCONSEJO.cs#L410)

```csharp
private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
```

<a id="f-026"></a>

## FrmImportarAsistenciaFueraSEDE


### FrmImportarAsistenciaFueraSEDE · líneas 313–319

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:313](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L313)

```csharp
[DebuggerNonUserCode]
	public FrmImportarAsistenciaFueraSEDE()
	{
		base.Load += FrmImportarAsistenciaFueraSEDE_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### GroupControl1_Paint · líneas 558–560

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:558](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L558)

```csharp
private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}
```

### cmdCerrar_Click · líneas 562–564

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:562](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L562)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
	}
```

### Button1_Click · líneas 566–573

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:566](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L566)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog1.Filter = "mdb files (*.mdb)|*.mdb|All files (*.*)|*.*";
		if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
		{
			txtRuta.Text = OpenFileDialog1.FileName.ToString().Trim();
		}
	}
```

### BtnGenerar_Click · líneas 575–580

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:575](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L575)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}
```

### FrmImportarAsistenciaFueraSEDE_Load · líneas 582–585

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:582](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L582)

```csharp
private void FrmImportarAsistenciaFueraSEDE_Load(object sender, EventArgs e)
	{
		txtRuta.Enabled = false;
	}
```

### BackgroundWorker1_DoWork · líneas 587–601

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:587](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L587)

```csharp
private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
		asistenciaAccess.BD = txtRuta.Text;
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (asistenciaAccess.Access2Sql(fechaInicial, fechaFinal, Conversions.ToInteger(Interaction.IIf(CheckEditForzar.Checked, 1, 0))))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
```

### BackgroundWorker1_RunWorkerCompleted · líneas 603–607

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:603](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L603)

```csharp
private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
```

### txtRuta_EditValueChanged · líneas 609–611

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs:609](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaFueraSEDE.cs#L609)

```csharp
private void txtRuta_EditValueChanged(object sender, EventArgs e)
	{
	}
```

<a id="f-027"></a>

## FrmImportarAsistenciaPROIND


### FrmImportarAsistenciaPROIND · líneas 214–219

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:214](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L214)

```csharp
[DebuggerNonUserCode]
	public FrmImportarAsistenciaPROIND()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### cmdCerrar_Click · líneas 413–416

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:413](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L413)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### BtnGenerar_Click · líneas 418–423

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:418](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L418)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}
```

### BackgroundWorker1_DoWork · líneas 425–438

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:425](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L425)

```csharp
private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (asistenciaAccess.Access2SqlPROIND(fechaInicial, fechaFinal, Conversions.ToInteger(Interaction.IIf(CheckEditForzar.Checked, 1, 0))))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
```

### BackgroundWorker1_RunWorkerCompleted · líneas 440–444

[Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs:440](../../Software/RecursosHumanos/RecursosHumanos/FrmImportarAsistenciaPROIND.cs#L440)

```csharp
private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
```

<a id="f-028"></a>

## FrmListaArchivos


### FrmListaArchivos · líneas 330–337

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L330)

```csharp
public FrmListaArchivos()
	{
		base.Load += FrmListaArchivos_Load;
		__ENCAddToList(this);
		empleado = new Empleado();
		persona = new Persona();
		InitializeComponent();
	}
```

### btnAgregar_Click · líneas 626–635

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:626](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L626)

```csharp
private void btnAgregar_Click(object sender, EventArgs e)
	{
		FrmDocumentos frmDocumentos = new FrmDocumentos();
		frmDocumentos.CodEmple = CodEmple;
		frmDocumentos.ShowDialog();
		if (frmDocumentos.DialogResult == DialogResult.OK)
		{
			llena_dgvDocumentos();
		}
	}
```

### llena_dgvDocumentos · líneas 637–641

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:637](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L637)

```csharp
public void llena_dgvDocumentos()
	{
		List<spRRHH_busca_archivosResult> dataSource = Module1.DcGrll.spRRHH_busca_archivos(CodEmple).ToList();
		GCArchivo.DataSource = dataSource;
	}
```

### FrmListaArchivos_Load · líneas 643–650

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:643](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L643)

```csharp
private void FrmListaArchivos_Load(object sender, EventArgs e)
	{
		empleado = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado c) => c.IdEmpleado == CodEmple).First();
		int num = (int)empleado.IdPersona;
		persona = PersonaMapper.Instance().SelectBy([SpecialName] (Persona p) => p.IdPersona == num).First();
		UcTxtNombres.Text = persona.Apellido_Paterno + " " + persona.Apellido_Materno + " " + persona.Nombres;
		llena_dgvDocumentos();
	}
```

### btnModificar_Click · líneas 652–669

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:652](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L652)

```csharp
private void btnModificar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewArchivo.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Debe Seleccionar un Documento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int codDocumento = Conversions.ToInteger(GridViewArchivo.GetRowCellValue(focusedRowHandle, "idDocumento"));
		FrmDocumentos frmDocumentos = new FrmDocumentos();
		frmDocumentos.CodEmple = CodEmple;
		frmDocumentos.CodDocumento = codDocumento;
		frmDocumentos.ShowDialog();
		if (frmDocumentos.DialogResult == DialogResult.OK)
		{
			llena_dgvDocumentos();
		}
	}
```

### btnEliminar_Click · líneas 671–687

[Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs:671](../../Software/RecursosHumanos/RecursosHumanos/FrmListaArchivos.cs#L671)

```csharp
private void btnEliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridViewArchivo.FocusedRowHandle;
		if (focusedRowHandle < 0)
		{
			MessageBox.Show("Debe Seleccionar un Documento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("Desea eliminar el Documento: ", GridViewArchivo.GetRowCellValue(focusedRowHandle, "DescripDocumento"))), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			int idDocumento = Conversions.ToInteger(GridViewArchivo.GetRowCellValue(focusedRowHandle, "idDocumento"));
			Archivo archivo = new Archivo();
			archivo.idDocumento = idDocumento;
			archivo.IdEmpleado = CodEmple;
			ArchivoMapper.Instance().Delete(archivo);
			llena_dgvDocumentos();
		}
	}
```

<a id="f-029"></a>

## FrmListaOrganica


### FrmListaOrganica · líneas 546–553

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:546](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L546)

```csharp
public FrmListaOrganica()
	{
		base.Load += FrmListaOrganica_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		ds_structura = new DataSet();
		InitializeComponent();
	}
```

### FrmListaOrganica_Load · líneas 995–1083

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:995](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L995)

```csharp
private void FrmListaOrganica_Load(object sender, EventArgs e)
	{
		if (RRHH.Bienestar)
		{
			btn_FichaSocial.Text = "Ficha Social";
			BtnArchivo.Visible = false;
			btn_nuevo.Visible = false;
			btn_editar.Visible = false;
			btn_eliminar.Visible = false;
			BtnArchivo.Enabled = false;
			btn_nuevo.Enabled = false;
			btn_editar.Enabled = false;
			btn_eliminar.Enabled = false;
			BtnAsistenciaManual.Visible = false;
			BtnPermiso.Visible = false;
			Button button = btn_FichaSocial;
			Point location = new Point(15, checked(Height - 113));
			button.Location = location;
		}
		else if (RRHH.Asistencias)
		{
			BtnArchivo.Enabled = false;
			btn_nuevo.Enabled = false;
			btn_editar.Enabled = false;
			btn_eliminar.Enabled = false;
			btn_FichaSocial.Enabled = false;
			BtnImprimir.Enabled = false;
		}
		else if ((Conversions.ToDouble(RRHH.IdROl) == 4.0) | (Conversions.ToDouble(RRHH.IdROl) == 3.0))
		{
			BtnAsistenciaManual.Enabled = false;
			BtnPermiso.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 15.0)
		{
			BtnPermiso.Visible = false;
			BtnAsistenciaManual.Visible = false;
		}
		ban = false;
		WindowState = FormWindowState.Maximized;
		TreeList1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_tree());
		TreeList1.ParentFieldName = "Hijo";
		TreeList1.KeyFieldName = "Padre";
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBPartidaPresupuestal.DataSource = dataSource;
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<TipoTrabajador> dataSource2 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBPartidaPresupuestal.DataSource = dataSource2;
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
			list.Insert(0, new TipoTrabajador
			{
				IdTipoTrabajador = 0,
				Descripcion = "Todos"
			});
			UcCBPartidaPresupuestal.DataSource = list;
			UcCBPartidaPresupuestal.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			List<TipoTrabajador> dataSource3 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => (C.IdTipoTrabajador == 1) | (C.IdTipoTrabajador == 3) | (C.IdTipoTrabajador == 4) | (C.IdTipoTrabajador == 5));
			UcCBPartidaPresupuestal.DataSource = dataSource3;
			UcCBPartidaPresupuestal.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			List<TipoTrabajador> dataSource4 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => C.IdTipoTrabajador == 2);
			UcCBPartidaPresupuestal.DataSource = dataSource4;
			UcCBPartidaPresupuestal.SelectedValue = RRHH.Partida;
		}
		TreeListOperationCollapseExpandToLevel operation = new TreeListOperationCollapseExpandToLevel(expand: true, 0);
		TreeList1.NodesIterator.DoOperation(operation);
		TreeListOperationCollapseExpandToLevel operation2 = new TreeListOperationCollapseExpandToLevel(expand: true, 1);
		TreeList1.NodesIterator.DoOperation(operation2);
		TreeListOperationCollapseExpandToLevel operation3 = new TreeListOperationCollapseExpandToLevel(expand: true, 2);
		TreeList1.NodesIterator.DoOperation(operation3);
	}
```

### TreeList1_FocusedNodeChanged · líneas 1085–1088

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1085](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1085)

```csharp
private void TreeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
	{
		llenar_grid();
	}
```

### GridControl1_DoubleClick · líneas 1090–1106

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1090](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1090)

```csharp
private void GridControl1_DoubleClick(object sender, EventArgs e)
	{
		if (!(RRHH.Bienestar | RRHH.Asistencias))
		{
			FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
			int focusedRowHandle = GridView1.FocusedRowHandle;
			objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
			frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
			if (objClassRRHH.CodigoEmpleado == 0)
			{
				MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
	}
```

### btn_nuevo_Click · líneas 1108–1116

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1108](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1108)

```csharp
private void btn_nuevo_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			llenar_grid();
		}
	}
```

### btn_editar_Click · líneas 1118–1137

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1118](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1118)

```csharp
private void btn_editar_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		objClassRRHH.CodigoEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmMantEmpleado_Basico.MantEmpleado_Basico_Cod = objClassRRHH.CodigoEmpleado;
		if (objClassRRHH.CodigoEmpleado == 0)
		{
			Interaction.MsgBox("Seleccione un Empleado");
		}
		else
		{
			frmMantEmpleado_Basico.Titulo = "Edición Datos Basicos del Empleado";
			frmMantEmpleado_Basico.ShowDialog();
		}
		if (frmMantEmpleado_Basico.DialogResult == DialogResult.OK)
		{
			llenar_grid();
		}
	}
```

### btn_eliminar_Click · líneas 1139–1147

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1139](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1139)

```csharp
private void btn_eliminar_Click(object sender, EventArgs e)
	{
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (MessageBox.Show("Esta seguro de eliminar al Empleado: " + GridView1.GetRowCellValue(focusedRowHandle, "Codigo").ToString(), "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			objClassRRHH.Actualiza_Empleado(Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo")));
			llenar_grid();
		}
	}
```

### btn_FichaSocial_Click · líneas 1149–1160

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1149](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1149)

```csharp
private void btn_FichaSocial_Click(object sender, EventArgs e)
	{
		FrmFichaSocial frmFichaSocial = new FrmFichaSocial();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			Interaction.MsgBox("Seleccione un Empleado");
			return;
		}
		frmFichaSocial.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmFichaSocial.ShowDialog();
	}
```

### llenar_grid · líneas 1162–1170

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1162](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1162)

```csharp
public void llenar_grid()
	{
		if (TreeList1.FocusedNode != null)
		{
			lbl_Area.Text = TreeList1.FocusedNode.GetValue("AreaOrganizacional").ToString();
			string value = Conversions.ToString(TreeList1.FocusedNode.GetValue("Padre"));
			GridControl1.DataSource = objClassRRHH.buscar_empleado_tree(Conversions.ToInteger(value), Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		}
	}
```

### UcCBPartidaPresupuestal_SelectedIndexChanged · líneas 1172–1175

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1172](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1172)

```csharp
private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		llenar_grid();
	}
```

### BtnImprimir_Click · líneas 1177–1191

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1177](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1177)

```csharp
private void BtnImprimir_Click(object sender, EventArgs e)
	{
		FrmReportFicha frmReportFicha = new FrmReportFicha();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Primero debe Seleccionar un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		int codempleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmReportFicha.Codempleado = codempleado;
		frmReportFicha.WindowState = FormWindowState.Maximized;
		frmReportFicha.MdiParent = MyProject.Forms.MainMDI;
		frmReportFicha.Show();
	}
```

### BtnArchivo_Click · líneas 1193–1204

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1193](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1193)

```csharp
private void BtnArchivo_Click(object sender, EventArgs e)
	{
		FrmListaArchivos frmListaArchivos = new FrmListaArchivos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Primero debe Seleccionar un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		frmListaArchivos.CodEmple = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmListaArchivos.ShowDialog();
	}
```

### BtnCerrar_Click · líneas 1206–1209

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1206](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1206)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### Button1_Click · líneas 1211–1222

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1211](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1211)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		FrmConsultaPermisos frmConsultaPermisos = new FrmConsultaPermisos();
		int focusedRowHandle = GridView1.FocusedRowHandle;
		if (Operators.ConditionalCompareObjectEqual(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"), null, TextCompare: false))
		{
			MessageBox.Show("Seleccione un Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		frmConsultaPermisos.idEmpleado = Conversions.ToInteger(GridView1.GetRowCellValue(focusedRowHandle, "Codigo"));
		frmConsultaPermisos.ShowDialog();
	}
```

### PanelSup_Paint · líneas 1224–1226

[Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs:1224](../../Software/RecursosHumanos/RecursosHumanos/FrmListaOrganica.cs#L1224)

```csharp
private void PanelSup_Paint(object sender, PaintEventArgs e)
	{
	}
```

<a id="f-030"></a>

## FrmLocalAsignado


### FrmLocalAsignado · líneas 379–385

[Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:379](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L379)

```csharp
[DebuggerNonUserCode]
	public FrmLocalAsignado()
	{
		base.Load += FrmLocalAsignado_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmLocalAsignado_Load · líneas 676–700

[Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:676](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L676)

```csharp
private void FrmLocalAsignado_Load(object sender, EventArgs e)
	{
		List<Local> dataSource = LocalMapper.Instance().SelectAll();
		RepositoryItemLookUpEdit1.ValueMember = "idLocal";
		RepositoryItemLookUpEdit1.DisplayMember = "NombreLocal";
		RepositoryItemLookUpEdit1.DataSource = dataSource;
		RepositoryItemLookUpEdit1.BestFitMode = BestFitMode.BestFitResizePopup;
		GridColumn4.ColumnEdit.NullText = "SIN LOCAL ASIGNADO";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Local(1, null);
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Local(2, null);
			GridControl1.DataSource = dataSource3;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource4 = Module1.DcGrll.sp_Listar_Empleado_Local(idTipoTrabajador, null);
			GridControl1.DataSource = dataSource4;
		}
	}
```

### cmdCerrar_Click · líneas 702–705

[Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:702](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L702)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### LookUpEditEditValueChanging · líneas 707–710

[Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:707](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L707)

```csharp
public void LookUpEditEditValueChanging(object sender, ChangingEventArgs e)
	{
		Module1.DcGrll.sp_Update_Empleado_idLocal_By_idEmpleado(Conversions.ToInteger(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "idEmpleado")), Conversions.ToInteger(e.NewValue));
	}
```

### BtnBuscar_Click · líneas 712–730

[Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs:712](../../Software/RecursosHumanos/RecursosHumanos/FrmLocalAsignado.cs#L712)

```csharp
private void BtnBuscar_Click(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource = Module1.DcGrll.sp_Listar_Empleado_Local(1, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource2 = Module1.DcGrll.sp_Listar_Empleado_Local(2, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			int? idTipoTrabajador = default(int?);
			ISingleResult<sp_Listar_Empleado_LocalResult> dataSource3 = Module1.DcGrll.sp_Listar_Empleado_Local(idTipoTrabajador, UcTextBox1.Text.Trim());
			GridControl1.DataSource = dataSource3;
		}
	}
```

<a id="f-031"></a>

## FrmLogin


### FrmLogin · líneas 22–25

[Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:22](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L22)

```csharp
public FrmLogin()
	{
		InitializeComponent();
	}
```

### UserName_KeyDown · líneas 99–106

[Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:99](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L99)

```csharp
private void UserName_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter)
		{
			Accept_Click(sender, EventArgs.Empty);
			e.SuppressKeyPress = true;
		}
	}
```

### Accept_Click · líneas 108–162

[Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:108](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L108)

```csharp
private void Accept_Click(object sender, EventArgs e)
	{
		string login = _userName.Text.Trim();
		if (login.Length == 0)
		{
			_status.Text = "Escriba un usuario.";
			_userName.Focus();
			return;
		}
		if (_password.Text.Length == 0)
		{
			_status.Text = "Escriba su contraseña.";
			_password.Focus();
			return;
		}

		_accept.Enabled = false;
		_status.Text = "Conectando con PostgreSQL...";
		Cursor = Cursors.WaitCursor;

		try
		{
			CompositionRoot.VerificarBaseDeDatos();
			AccesoUsuario access = CompositionRoot.CrearObtenerAccesoUsuario().Ejecutar(
				RRHH.Codsys,
				login,
				_password.Text);
			if (access == null)
			{
				_status.Text = "Usuario o contraseña incorrectos, o sin acceso a RRHH.";
				_password.SelectAll();
				_password.Focus();
				return;
			}

			ApplyAccess(access);
			DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception exception)
		{
			_status.Text = "No fue posible conectar con PostgreSQL.";
			MessageBox.Show(
				"Revise RRHH_POSTGRES_CONNECTION y que la base CMI esté disponible.\r\n\r\n" +
				exception.Message,
				"Conexión PostgreSQL",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
		finally
		{
			Cursor = Cursors.Default;
			_accept.Enabled = true;
		}
	}
```

### ApplyAccess · líneas 164–193

[Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs:164](../../Software/RecursosHumanos/RecursosHumanos/FrmLogin.cs#L164)

```csharp
private void ApplyAccess(AccesoUsuario access)
	{
		_password.Clear();
		RRHH.LogUser = access.Login;
		RRHH.codEmple = access.IdEmpleado.Value.ToString();
		RRHH.IdROl = access.IdRol.ToString();
		RRHH.Partida = 0;
		RRHH.Bienestar = false;
		RRHH.Asistencias = false;
		EmployeeDisplayName = string.IsNullOrWhiteSpace(access.NombreEmpleado)
			? access.Login
			: access.NombreEmpleado;

		switch (access.IdRol)
		{
			case 3:
				RRHH.Partida = 2;
				break;
			case 4:
				RRHH.Partida = 1;
				break;
			case 5:
				RRHH.Bienestar = true;
				break;
			case 10:
			case 14:
				RRHH.Asistencias = true;
				break;
		}
	}
```

<a id="f-032"></a>

## FrmMantCargos


### FrmMantCargos · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L330)

```csharp
public FrmMantCargos()
	{
		base.Load += FrmMantCargos_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantCargos_Load · líneas 635–638

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:635](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L635)

```csharp
private void FrmMantCargos_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 640–643

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:640](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L640)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 645–648

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:645](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L645)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 650–653

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:650](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L650)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 655–658

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:655](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L655)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 660–663

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:660](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L660)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 665–668

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:665](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L665)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 670–673

[Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs:670](../../Software/RecursosHumanos/RecursosHumanos/FrmMantCargos.cs#L670)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-033"></a>

## FrmMantDocFile


### FrmMantDocFile · líneas 337–342

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:337](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L337)

```csharp
public FrmMantDocFile()
	{
		base.Load += FrmMantDocFile_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmMantDocFile_Load · líneas 627–630

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:627](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L627)

```csharp
private void FrmMantDocFile_Load(object sender, EventArgs e)
	{
		llenardata();
	}
```

### DataNavigator1_ButtonClick · líneas 632–696

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:632](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L632)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		if (e.Button.ButtonType == NavigatorButtonType.Append)
		{
			if (GridView1.FocusedColumn != null)
			{
				GridView1.FocusedColumn = GridView1.Columns[GridColumn2.FieldName];
				DataNavigator1.Buttons.DoClick(DataNavigator1.Buttons.Last);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(GridView1.FocusedValue)) | (GridView1.FocusedValue == null))
				{
					e.Handled = true;
				}
				GridView1.ClearSorting();
				GridView1.ShowEditor();
			}
			return;
		}
		if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
		{
			Documento obj = (Documento)GridView1.GetRow(GridView1.FocusedRowHandle);
			Actualizar(obj);
		}
		if (e.Button.ButtonType == NavigatorButtonType.Remove)
		{
			Documento documento = (Documento)GridView1.GetRow(GridView1.FocusedRowHandle);
			if ((documento != null && documento.DescripDocumento != null) ? true : false)
			{
				if (MessageBox.Show("Va a eliminar el registro :" + ObtenerMensaje(documento) + "\r\nDesea continuar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					e.Handled = true;
				}
				else
				{
					try
					{
						DocumentoMapper.Instance().Delete(documento);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Interaction.MsgBox("No se pudo eliminar el documento. Puede estar siendo usado por otro registro.\r\n" + ex.Message, MsgBoxStyle.Critical);
						e.Handled = true;
						ProjectData.ClearProjectError();
						return;
					}
				}
			}
			else
			{
				e.Handled = true;
				if (documento == null || documento.DescripDocumento == null)
				{
					GridView1.DeleteRow(GridView1.FocusedRowHandle);
				}
			}
		}
		if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
		{
			Documento documento2 = (Documento)GridView1.GetRow(GridView1.FocusedRowHandle);
			if (documento2 == null || documento2.DescripDocumento == null)
			{
				GridView1.DeleteRow(GridView1.FocusedRowHandle);
			}
		}
	}
```

### Actualizar · líneas 698–712

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:698](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L698)

```csharp
private void Actualizar(Documento obj)
	{
		if (obj.idDocumento == 0)
		{
			List<Documento> documentos = DocumentoMapper.Instance().SelectAll();
			obj.idDocumento = documentos.Count == 0 ? 1 : documentos.Max(n => n.idDocumento) + 1;
			DocumentoMapper.Instance().Insert(obj);
			MessageBox.Show("Se insertÃ³ el registro :" + ObtenerMensaje(obj), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			DocumentoMapper.Instance().Update(obj);
			MessageBox.Show("Se actualizÃ³ el registro :" + ObtenerMensaje(obj), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
```

### ObtenerMensaje · líneas 714–723

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:714](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L714)

```csharp
private string ObtenerMensaje(Documento obj, bool EsEliminar = true)
	{
		string text = "\r\nCÃ³digo=" + Conversions.ToString(obj.idDocumento) + "\r\n";
		text = text + "Ley Regimen=" + obj.DescripDocumento + "\r\n";
		if (!EsEliminar)
		{
			text += " correctamente";
		}
		return text;
	}
```

### Vista1_BeforeLeaveRow · líneas 725–733

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:725](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L725)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		Documento documento = (Documento)GridView1.GetRow(e.RowHandle);
		if (documento != null && documento.DescripDocumento == null)
		{
			e.Allow = false;
			GridView1.ShowEditor();
		}
	}
```

### Vista1_RowUpdated · líneas 735–742

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:735](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L735)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		Documento documento = (Documento)e.Row;
		if (documento.DescripDocumento != null)
		{
			Actualizar(documento);
		}
	}
```

### Vista1_ValidateRow · líneas 744–752

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:744](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L744)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		Documento documento = (Documento)e.Row;
		if (documento.DescripDocumento == null)
		{
			e.ErrorText = "Debe ingresar datos";
			e.Valid = false;
		}
	}
```

### Vista1_ValidatingEditor · líneas 754–761

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:754](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L754)

```csharp
private void Vista1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
	{
		if (Operators.CompareString(GridView1.FocusedColumn.FieldName, "DescripDocumento", TextCompare: false) == 0 && e.Value != null && e.Value.ToString().Trim().Length == 0)
		{
			e.Valid = false;
			e.ErrorText = "Debe ingresar la descripciÃ³n";
		}
	}
```

### llenardata · líneas 763–771

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:763](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L763)

```csharp
private void llenardata()
	{
		string filter = UcTxtCampoBusca.Text ?? string.Empty;
		List<Documento> dataSource = DocumentoMapper.Instance().SelectAll()
			.Where(n => n.DescripDocumento != null && n.DescripDocumento.IndexOf(filter, StringComparison.CurrentCultureIgnoreCase) >= 0)
			.ToList();
		GridControl1.DataSource = dataSource;
		DataNavigator1.DataSource = dataSource;
	}
```

### UcTxtCampoBusca_TextChanged · líneas 773–776

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:773](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L773)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		llenardata();
	}
```

### Button1_Click · líneas 778–781

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:778](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L778)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		llenardata();
	}
```

### BtnCerrar_Click · líneas 783–786

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:783](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L783)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### DataNavigator1_Click · líneas 788–790

[Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs:788](../../Software/RecursosHumanos/RecursosHumanos/FrmMantDocFile.cs#L788)

```csharp
private void DataNavigator1_Click(object sender, EventArgs e)
	{
	}
```

<a id="f-034"></a>

## FrmMantEmpleado_Basico


### FrmMantEmpleado_Basico · líneas 1531–1539

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:1531](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L1531)

```csharp
public FrmMantEmpleado_Basico()
	{
		base.Load += FrmMantEmpleado_Basico_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		objFamiliaresClass = new FamiliaresClass();
		img = null;
		InitializeComponent();
	}
```

### FrmMantEmpleado_Basico_Load · líneas 2768–2981

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:2768](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L2768)

```csharp
private void FrmMantEmpleado_Basico_Load(object sender, EventArgs e)
	{
		UcCBTipoTrab.ValueMember = "IdTipoTrabajador";
		UcCBTipoTrab.DisplayMember = "Descripcion";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource;
			UcCBTipoTrab.SelectedValue = 1;
			UcCBTipoTrab.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<TipoTrabajador> dataSource2 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource2;
			UcCBTipoTrab.SelectedValue = 2;
			UcCBTipoTrab.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<TipoTrabajador> dataSource3 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource3;
			UcCBTipoTrab.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 4.0)
		{
			List<TipoTrabajador> dataSource4 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => (C.IdTipoTrabajador == 1) | (C.IdTipoTrabajador == 3) | (C.IdTipoTrabajador == 4) | (C.IdTipoTrabajador == 5));
			UcCBTipoTrab.DataSource = dataSource4;
			UcCBTipoTrab.Enabled = true;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 3.0)
		{
			List<TipoTrabajador> dataSource5 = TipoTrabajadorMapper.Instance().SelectBy([SpecialName] (TipoTrabajador C) => C.IdTipoTrabajador == 2);
			UcCBTipoTrab.DataSource = dataSource5;
			UcCBTipoTrab.SelectedValue = RRHH.Partida;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 5.0)
		{
			List<TipoTrabajador> dataSource6 = TipoTrabajadorMapper.Instance().SelectAll();
			UcCBTipoTrab.DataSource = dataSource6;
			UcCBTipoTrab.SelectedValue = RRHH.Partida;
			UcCBTipoTrab.Enabled = false;
		}
		UcComboBoxTDI.ValueMember = "TipoDocID";
		UcComboBoxTDI.DisplayMember = "Descripcion";
		UcComboBoxTDI.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_DocID());
		UcCBEstadoCivil.ValueMember = "IdEstadoCivil";
		UcCBEstadoCivil.DisplayMember = "DescripEstCivil";
		DataTable dataTable = (DataTable)objClassRRHH.llena_estCivil();
		DataRow dataRow = dataTable.NewRow();
		dataRow["IdEstadoCivil"] = 0;
		dataRow["DescripEstCivil"] = "(Seleccionar)";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBEstadoCivil.DataSource = dataTable;
		UcCBDiscapacidad.ValueMember = "IdDiscapacidad";
		UcCBDiscapacidad.DisplayMember = "Descrip_Discapacidad";
		DataTable dataTable2 = (DataTable)objClassRRHH.llena_Discapacidad();
		DataRow dataRow2 = dataTable2.NewRow();
		dataRow2["IdDiscapacidad"] = 0;
		dataRow2["Descrip_Discapacidad"] = "(Seleccionar)";
		dataTable2.Rows.InsertAt(dataRow2, 0);
		UcCBDiscapacidad.DataSource = dataTable2;
		UcCBNacionalidad.ValueMember = "IdNacionalidad";
		UcCBNacionalidad.DisplayMember = "Descripcion";
		UcCBNacionalidad.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_Nacionalidad());
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable3 = (DataTable)objClassRRHH.llena_Area();
		DataRow dataRow3 = dataTable3.NewRow();
		dataRow3["idAreaOrganiz"] = 0;
		dataRow3["AreaOrganizacional"] = "(Seleccionar)";
		dataTable3.Rows.InsertAt(dataRow3, 0);
		UcCBArea.DataSource = dataTable3;
		UcUbigeoCmb1.GetDpto();
		UcCBGrupoSanguineo.ValueMember = "IdTipoSangre";
		UcCBGrupoSanguineo.DisplayMember = "DescripTS";
		List<TipoSangre> list = TipoSangreMapper.Instance().SelectAll();
		list.Insert(0, new TipoSangre
		{
			IdTipoSangre = 0,
			DescripTS = "   "
		});
		UcCBGrupoSanguineo.DataSource = list;
		UcUbigeoCmbDirec.GetDpto();
		UcFoto.AjustarImagen = true;
		objClassRRHH.CodigoEmpleado = MantEmpleado_Basico_Cod;
		DataTable dataTable4 = objClassRRHH.BuscarEmpleado_Codigo(objClassRRHH.CodigoEmpleado);
		if (dataTable4.Rows.Count != 1)
		{
			return;
		}
		DateTime? dateTime2 = default(DateTime?);
		foreach (object row in dataTable4.Rows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(row);
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
			{
				img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
				UcFoto.Image = Image.FromStream(memoryStream);
				memoryStream.Close();
			}
			UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
			UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
			UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
			string left = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Sexo" }, null, null, null).ToString();
			if (Operators.CompareString(left, null, TextCompare: false) == 0)
			{
				UcCBSexo.SelectedIndex = -1;
			}
			else if (Operators.CompareString(left, "M", TextCompare: false) == 0)
			{
				UcCBSexo.SelectedIndex = 0;
			}
			else
			{
				UcCBSexo.SelectedIndex = 1;
			}
			UcCBTipoTrab.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idtipotrabajador" }, null, null, null));
			UcComboBoxTDI.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "TipoDocID" }, null, null, null).ToString();
			if (Operators.CompareString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idNacionalidad" }, null, null, null).ToString(), null, TextCompare: false) == 0)
			{
				UcCBNacionalidad.SelectedValue = -1;
			}
			else
			{
				UcCBNacionalidad.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idNacionalidad" }, null, null, null).ToString();
			}
			UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			DateTime? dateTime;
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString().Length == 0)
			{
				dateTime = null;
			}
			else
			{
				object obj = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null);
				dateTime = ((obj != null) ? ((DateTime?)obj) : dateTime2);
			}
			if (!dateTime.HasValue)
			{
				UcDTFechaNac.Value = DateTime.Today;
			}
			else
			{
				UcDTFechaNac.Value = Conversions.ToDate(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString());
			}
			UcTxtFono.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Telefono" }, null, null, null).ToString();
			UcTxtMovil.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumCelular" }, null, null, null).ToString();
			UcTxtCentroLab.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FonoCentroLab" }, null, null, null).ToString();
			UcTxtOtro.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Fax" }, null, null, null).ToString();
			if (Operators.CompareString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdEstadoCivil" }, null, null, null).ToString(), null, TextCompare: false) == 0)
			{
				UcCBEstadoCivil.SelectedValue = -1;
			}
			else
			{
				UcCBEstadoCivil.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdEstadoCivil" }, null, null, null).ToString();
			}
			if (Operators.CompareString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdDiscapacidad" }, null, null, null).ToString(), null, TextCompare: false) == 0)
			{
				UcCBDiscapacidad.SelectedValue = -1;
			}
			else
			{
				UcCBDiscapacidad.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdDiscapacidad" }, null, null, null).ToString();
			}
			if (Operators.CompareString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idtiposangre" }, null, null, null).ToString(), null, TextCompare: false) == 0)
			{
				UcCBGrupoSanguineo.SelectedValue = -1;
			}
			else
			{
				UcCBGrupoSanguineo.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idtiposangre" }, null, null, null));
			}
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdUbigeo" }, null, null, null).ToString().Length > 1)
			{
				UcUbigeoCmb1.Ubigeo = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "IdUbigeo" }, null, null, null));
			}
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "UbigeoDireccion" }, null, null, null).ToString().Length > 1)
			{
				UcUbigeoCmbDirec.Ubigeo = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "UbigeoDireccion" }, null, null, null));
			}
			UcTxtDirec.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Direccion" }, null, null, null).ToString();
			UcTxtExpSocial.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "ExpSocial" }, null, null, null).ToString();
			UcCBArea.SelectedValue = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idAreaOrganiz" }, null, null, null).ToString();
			DateTime? dateTime3;
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaNacimiento" }, null, null, null).ToString().Length == 0)
			{
				dateTime3 = null;
			}
			else
			{
				object obj2 = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaRegistro" }, null, null, null);
				dateTime3 = ((obj2 != null) ? ((DateTime?)obj2) : dateTime2);
			}
			if (!dateTime3.HasValue)
			{
				UcDTFechaReg.Value = DateTime.Today;
			}
			else
			{
				UcDTFechaReg.Value = Conversions.ToDate(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "FechaRegistro" }, null, null, null).ToString());
			}
			UcTxteMail.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "email" }, null, null, null).ToString();
			codPersona = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idpersona" }, null, null, null).ToString());
			UcTxtLibMilitar.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "numlibretamilitar" }, null, null, null).ToString();
			UcTxtGradoInstruccion.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "gradoinstruccion" }, null, null, null).ToString();
			UcTxtBrevete.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "brevete" }, null, null, null).ToString();
			UcTxtNumRUc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumRUC" }, null, null, null).ToString();
			GridControlEmpleado_Area.DataSource = objClassRRHH.llenar_Empleado_Area(objClassRRHH.CodigoEmpleado);
		}
	}
```

### btnGuardar_Click · líneas 2983–3070

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:2983](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L2983)

```csharp
private void btnGuardar_Click(object sender, EventArgs e)
	{
		string fileName = UcFoto.FileName;
		checked
		{
			byte[] foto;
			if (fileName.Length > 0)
			{
				FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
				BinaryReader binaryReader = new BinaryReader(fileStream);
				byte[] array = new byte[(int)(fileStream.Length - 1) + 1];
				binaryReader.Read(array, 0, (int)fileStream.Length);
				binaryReader.Close();
				fileStream.Close();
				foto = array;
			}
			else
			{
				foto = img;
			}
			if (Operators.ConditionalCompareObjectEqual(UcCBGrupoSanguineo.SelectedValue, 0, TextCompare: false))
			{
				MessageBox.Show("Debe Seleccionar un Grupo Sanguineo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(UcCBEstadoCivil.SelectedValue, 0, TextCompare: false))
			{
				MessageBox.Show("Debe Seleccionar un Estado Civil Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(UcCBDiscapacidad.SelectedValue, 0, TextCompare: false))
			{
				MessageBox.Show("Debe Seleccionar una Discapacidad Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(UcCBArea.SelectedValue, 0, TextCompare: false))
			{
				MessageBox.Show("Debe Seleccionar una Unidad Orgánica Válida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (objClassRRHH.CodigoEmpleado == 0)
			{
				try
				{
					int idEmpleado = objClassRRHH.Ingresa_Empleado(objClassRRHH.Anio, Conversions.ToInteger(UcCBArea.SelectedValue), Conversions.ToInteger(UcComboBoxTDI.SelectedValue), UcTxtNDoc.Text, UcTxtApePater.Text, UcTxtApeMater.Text, UcTxtNombres.Text, UcUbigeoCmb1.Ubigeo, UcDTFechaNac.Value, UcTxtDirec.Text, UcTxtFono.Text, UcTxtCentroLab.Text, UcTxtMovil.Text, UcTxtOtro.Text, UcTxteMail.Text, UcUbigeoCmbDirec.Ubigeo, Conversions.ToInteger(UcCBNacionalidad.SelectedValue), UcCBSexo.Text, Conversions.ToInteger(UcCBEstadoCivil.SelectedValue), Conversions.ToInteger(UcCBDiscapacidad.SelectedValue), UcTxtExpSocial.Text, UcDTFechaReg.Value, Conversions.ToInteger(UcCBGrupoSanguineo.SelectedValue), UcTxtBrevete.Text, UcTxtLibMilitar.Text, UcTxtGradoInstruccion.Text, UcTxtNumRUc.Text, Conversions.ToInteger(UcCBTipoTrab.SelectedValue), foto);
					objClassRRHH.ingresa_Empleado_Area(objClassRRHH.Anio, Conversions.ToInteger(UcCBArea.SelectedValue), idEmpleado);
					if (!CheckEquipoMarcacion.Checked)
					{
					}
				}
				catch (SqlException ex)
				{
					ProjectData.SetProjectError(ex);
					SqlException ex2 = ex;
					if (ex2.Number == 547)
					{
						Interaction.MsgBox("Por Favor Llenar Todos los Campos", MsgBoxStyle.Critical, "Alerta");
						ProjectData.ClearProjectError();
						return;
					}
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					objClassRRHH.Actualiza_Empleado(codPersona, objClassRRHH.CodigoEmpleado, objClassRRHH.Anio, Conversions.ToInteger(UcCBArea.SelectedValue), Conversions.ToInteger(UcComboBoxTDI.SelectedValue), UcTxtNDoc.Text, UcTxtApePater.Text, UcTxtApeMater.Text, UcTxtNombres.Text, UcUbigeoCmb1.Ubigeo, UcDTFechaNac.Value, UcTxtDirec.Text, UcTxtFono.Text, UcTxtCentroLab.Text, UcTxtMovil.Text, UcTxtOtro.Text, UcTxteMail.Text, UcUbigeoCmbDirec.Ubigeo, Conversions.ToInteger(UcCBNacionalidad.SelectedValue), UcCBSexo.Text, Conversions.ToInteger(UcCBEstadoCivil.SelectedValue), Conversions.ToInteger(UcCBDiscapacidad.SelectedValue), UcTxtExpSocial.Text, UcDTFechaReg.Value, Conversions.ToInteger(UcCBGrupoSanguineo.SelectedValue), UcTxtBrevete.Text, UcTxtLibMilitar.Text, UcTxtGradoInstruccion.Text, UcTxtNumRUc.Text, Conversions.ToInteger(UcCBTipoTrab.SelectedValue), foto);
					if (!CheckEquipoMarcacion.Checked)
					{
					}
				}
				catch (SqlException ex3)
				{
					ProjectData.SetProjectError(ex3);
					SqlException ex4 = ex3;
					if (ex4.Number == 547)
					{
						Interaction.MsgBox("Por Favor Llenar Todos los Campos", MsgBoxStyle.Critical, "Alerta");
						ProjectData.ClearProjectError();
						return;
					}
					ProjectData.ClearProjectError();
				}
			}
			DialogResult = DialogResult.OK;
		}
	}
```

### buscarxDNI · líneas 3072–3079

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3072](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3072)

```csharp
public void buscarxDNI()
	{
		DataTable dataTable = (DataTable)objFamiliaresClass.Busca_DNI(UcTxtNDoc.Text, Conversions.ToInteger(UcComboBoxTDI.SelectedValue));
		if (dataTable.Rows.Count == 1)
		{
			MessageBox.Show("Verifique el DNI, Ya existe ese Numero\r\nNombres: " + dataTable.Rows[0]["Apellido_Paterno"].ToString() + " " + dataTable.Rows[0]["Apellido_Materno"].ToString() + " " + dataTable.Rows[0]["Nombres"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
```

### repositoryItemButtonEdit_ButtonClick · líneas 3081–3084

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3081](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3081)

```csharp
private void repositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
	{
		MessageBox.Show("You've clicked the button!", Application.ProductName);
	}
```

### UcTxtNDoc_LostFocus · líneas 3086–3089

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3086](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3086)

```csharp
private void UcTxtNDoc_LostFocus(object sender, EventArgs e)
	{
		buscarxDNI();
	}
```

### BtnCerrar_Click · líneas 3091–3094

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3091](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3091)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### GridView1_CustomRowCellEdit · líneas 3096–3102

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3096](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3096)

```csharp
private void GridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
	{
		if (Operators.CompareString(e.Column.FieldName, "Year", TextCompare: false) != 0)
		{
			GridControlListaAreas.DataSource = objClassRRHH.llenar_Areas_by_año(Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Year"))));
		}
	}
```

### GridViewListaAreas_DoubleClick · líneas 3104–3109

[Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs:3104](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEmpleado_Basico.cs#L3104)

```csharp
private void GridViewListaAreas_DoubleClick(object sender, EventArgs e)
	{
		objClassRRHH.Actualizar_Area_Empleado(objClassRRHH.CodigoEmpleado, Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridViewListaAreas.GetRowCellValue(GridViewListaAreas.FocusedRowHandle, "Year"))), Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridViewListaAreas.GetRowCellValue(GridViewListaAreas.FocusedRowHandle, "idAreaOrganiz"))));
		PopupContainerControl1.OwnerEdit.ClosePopup();
		GridControlEmpleado_Area.DataSource = objClassRRHH.llenar_Empleado_Area(objClassRRHH.CodigoEmpleado);
	}
```

<a id="f-035"></a>

## FrmMantEstCivil


### FrmMantEstCivil · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L330)

```csharp
public FrmMantEstCivil()
	{
		base.Load += FrmMantEstCivil_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantEstCivil_Load · líneas 631–634

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:631](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L631)

```csharp
private void FrmMantEstCivil_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 636–639

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:636](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L636)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 641–644

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:641](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L641)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 646–649

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:646](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L646)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 651–654

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:651](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L651)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 656–659

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:656](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L656)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 661–664

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:661](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L661)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 666–669

[Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs:666](../../Software/RecursosHumanos/RecursosHumanos/FrmMantEstCivil.cs#L666)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-036"></a>

## FrmMantGrupoSanguineo


### FrmMantGrupoSanguineo · líneas 312–318

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:312](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L312)

```csharp
public FrmMantGrupoSanguineo()
	{
		base.Load += FrmMantGrupoSanguineo_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantGrupoSanguineo_Load · líneas 607–610

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:607](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L607)

```csharp
private void FrmMantGrupoSanguineo_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 612–615

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:612](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L612)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 617–620

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:617](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L617)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 622–625

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:622](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L622)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 627–630

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:627](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L627)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 632–635

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:632](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L632)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 637–640

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:637](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L637)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 642–645

[Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs:642](../../Software/RecursosHumanos/RecursosHumanos/FrmMantGrupoSanguineo.cs#L642)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-037"></a>

## FrmMantHorarios


### FrmMantHorarios · líneas 271–281

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:271](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L271)

```csharp
[DebuggerNonUserCode]
	public FrmMantHorarios()
	{
		base.Load += FrmMantHorarios_Load;
		__ENCAddToList(this);
		InitializeComponent();
        btnGrabar.Enabled = false;
        CheckEquipoMarcacion.EditValue = false;
        CheckEquipoMarcacion.Enabled = false;
        CheckEquipoMarcacion.Properties.Caption = "Sincronización no disponible";
	}
```

### MostrarHorario · líneas 599–607

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:599](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L599)

```csharp
public void MostrarHorario(HorarioDto horario)
    {
        UcTxtDescripcion.Text = horario.Descripcion ?? string.Empty;
        CheckEdit1.EditValue = horario.Estado;
        Txt_HE.Text = horario.Ingreso1 ?? string.Empty;
        Txt_SR.Text = horario.Salida1 ?? string.Empty;
        Txt_ER.Text = horario.Ingreso2 ?? string.Empty;
        Txt_HS.Text = horario.Salida2 ?? string.Empty;
    }
```

### HabilitarGuardar · líneas 610–610

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:610](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L610)

```csharp
public void HabilitarGuardar(bool habilitado) => btnGrabar.Enabled = habilitado;
```

### MostrarError · líneas 613–614

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:613](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L613)

```csharp
public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje,
        "Horario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
```

### CerrarGuardado · líneas 617–621

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:617](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L617)

```csharp
public void CerrarGuardado()
    {
        DialogResult = DialogResult.OK;
        Close();
    }
```

### FrmMantHorarios_Load · líneas 623–623

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:623](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L623)

```csharp
private void FrmMantHorarios_Load(object sender, EventArgs e) => CargarSolicitado?.Invoke(this, EventArgs.Empty);
```

### btnGrabar_Click · líneas 624–624

[Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs:624](../../Software/RecursosHumanos/RecursosHumanos/FrmMantHorarios.cs#L624)

```csharp
private void btnGrabar_Click(object sender, EventArgs e) => GuardarSolicitado?.Invoke(this, EventArgs.Empty);
```

<a id="f-038"></a>

## FrmMantMotivo


### FrmMantMotivo · líneas 145–154

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:145](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L145)

```csharp
[DebuggerNonUserCode]
	public FrmMantMotivo()
	{
		base.Load += FrmMantMotivo_Load;
		__ENCAddToList(this);
		InitializeComponent();
		CheckEdit1.Properties.AllowGrayed = true;
		UcTxtMotivo.MaxLength = 50;
		UcTxtAbreviatura.MaxLength = 3;
	}
```

### MostrarMotivo · líneas 369–374

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:369](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L369)

```csharp
public void MostrarMotivo(MotivoPermisoDto motivo)
    {
        UcTxtMotivo.Text = motivo.Descripcion ?? string.Empty;
        UcTxtAbreviatura.Text = motivo.Abreviatura ?? string.Empty;
        CheckEdit1.EditValue = motivo.Salario;
    }
```

### MostrarError · líneas 376–376

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:376](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L376)

```csharp
public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje, "Motivo de permiso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
```

### HabilitarGuardar · líneas 377–377

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:377](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L377)

```csharp
public void HabilitarGuardar(bool habilitado) => Button1.Enabled = habilitado;
```

### CerrarGuardado · líneas 378–382

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:378](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L378)

```csharp
public void CerrarGuardado()
    {
        DialogResult = DialogResult.OK;
        Close();
    }
```

### FrmMantMotivo_Load · líneas 385–385

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:385](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L385)

```csharp
private void FrmMantMotivo_Load(object sender, EventArgs e) => CargarSolicitado?.Invoke(this, EventArgs.Empty);
```

### Button1_Click · líneas 386–386

[Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs:386](../../Software/RecursosHumanos/RecursosHumanos/FrmMantMotivo.cs#L386)

```csharp
private void Button1_Click(object sender, EventArgs e) => GuardarSolicitado?.Invoke(this, EventArgs.Empty);
```

<a id="f-039"></a>

## FrmMantNacionalidades


### FrmMantNacionalidades · líneas 354–360

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:354](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L354)

```csharp
public FrmMantNacionalidades()
	{
		base.Load += FrmMantNacionalidades_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantNacionalidades_Load · líneas 655–658

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:655](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L655)

```csharp
private void FrmMantNacionalidades_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 660–663

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:660](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L660)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 665–668

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:665](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L665)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 670–673

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:670](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L670)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 675–678

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:675](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L675)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 680–683

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:680](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L680)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 685–688

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:685](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L685)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### cmdCerrar_Click · líneas 690–692

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:690](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L690)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
	}
```

### BtnCerrar_Click · líneas 694–697

[Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs:694](../../Software/RecursosHumanos/RecursosHumanos/FrmMantNacionalidades.cs#L694)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-040"></a>

## FrmMantRegimen


### FrmMantRegimen · líneas 312–318

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:312](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L312)

```csharp
public FrmMantRegimen()
	{
		base.Load += FrmMantRegimen_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantRegimen_Load · líneas 605–608

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:605](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L605)

```csharp
private void FrmMantRegimen_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 610–613

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:610](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L610)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 615–618

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:615](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L615)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 620–623

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:620](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L620)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 625–628

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:625](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L625)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 630–633

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:630](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L630)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 635–638

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:635](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L635)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 640–643

[Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs:640](../../Software/RecursosHumanos/RecursosHumanos/FrmMantRegimen.cs#L640)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-041"></a>

## FrmMantTipoDocIdent


### FrmMantTipoDocIdent · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L330)

```csharp
public FrmMantTipoDocIdent()
	{
		base.Load += FrmMantTipoDocIdent_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantTipoDocIdent_Load · líneas 628–631

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:628](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L628)

```csharp
private void FrmMantTipoDocIdent_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 633–636

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:633](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L633)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 638–641

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:638](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L638)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 643–646

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:643](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L643)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 648–651

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:648](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L648)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 653–656

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:653](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L653)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 658–661

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:658](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L658)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 663–666

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs:663](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoDocIdent.cs#L663)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-042"></a>

## FrmMantTipoEstudio


### FrmMantTipoEstudio · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L330)

```csharp
public FrmMantTipoEstudio()
	{
		base.Load += FrmMantTipoEstudio_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantTipoEstudio_Load · líneas 629–632

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:629](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L629)

```csharp
private void FrmMantTipoEstudio_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 634–637

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:634](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L634)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 639–642

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:639](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L639)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 644–647

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:644](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L644)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 649–652

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:649](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L649)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 654–657

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:654](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L654)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 659–662

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:659](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L659)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 664–667

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs:664](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoEstudio.cs#L664)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-043"></a>

## FrmMantTipoInst


### FrmMantTipoInst · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L330)

```csharp
public FrmMantTipoInst()
	{
		base.Load += FrmMantTipoInst_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantTipoInst_Load · líneas 628–631

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:628](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L628)

```csharp
private void FrmMantTipoInst_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 633–636

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:633](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L633)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 638–641

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:638](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L638)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 643–646

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:643](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L643)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 648–651

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:648](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L648)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 653–656

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:653](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L653)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 658–661

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:658](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L658)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 663–666

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs:663](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoInst.cs#L663)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-044"></a>

## FrmMantTipoPerm


### FrmMantTipoPerm · líneas 259–265

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:259](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L259)

```csharp
public FrmMantTipoPerm()
	{
		base.Load += FrmMantTipoPerm_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantTipoPerm_Load · líneas 508–511

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:508](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L508)

```csharp
private void FrmMantTipoPerm_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 513–516

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:513](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L513)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 518–521

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:518](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L518)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 523–526

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:523](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L523)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 528–531

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:528](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L528)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 533–536

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:533](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L533)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 538–541

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:538](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L538)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 543–546

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs:543](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoPerm.cs#L543)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-045"></a>

## FrmMantTipoTrab


### FrmMantTipoTrab · líneas 330–336

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:330](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L330)

```csharp
public FrmMantTipoTrab()
	{
		base.Load += FrmMantTipoTrab_Load;
		__ENCAddToList(this);
		InitializeComponent();
		_vista = new VistaCatalogoGrid(this, GridView1, DataNavigator1, () => UcTxtCampoBusca.Text);
	}
```

### FrmMantTipoTrab_Load · líneas 632–635

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:632](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L632)

```csharp
private void FrmMantTipoTrab_Load(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### DataNavigator1_ButtonClick · líneas 637–640

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:637](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L637)

```csharp
private void DataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
	{
		_vista.ClickNavegador(e);
	}
```

### Vista1_BeforeLeaveRow · líneas 642–645

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:642](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L642)

```csharp
private void Vista1_BeforeLeaveRow(object sender, RowAllowEventArgs e)
	{
		_vista.AntesDeSalirDeFila(e);
	}
```

### Vista1_ValidateRow · líneas 647–650

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:647](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L647)

```csharp
private void Vista1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		_vista.ValidarFila(e);
	}
```

### Vista1_RowUpdated · líneas 652–655

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:652](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L652)

```csharp
private void Vista1_RowUpdated(object sender, RowObjectEventArgs e)
	{
		_vista.FilaActualizada(e);
	}
```

### UcTxtCampoBusca_TextChanged · líneas 657–660

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:657](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L657)

```csharp
private void UcTxtCampoBusca_TextChanged(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### Button1_Click · líneas 662–665

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:662](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L662)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		_vista.Buscar();
	}
```

### BtnCerrar_Click · líneas 667–670

[Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs:667](../../Software/RecursosHumanos/RecursosHumanos/FrmMantTipoTrab.cs#L667)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-046"></a>

## FrmMarcacionesAutorizadas


### FrmMarcacionesAutorizadas · líneas 560–567

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:560](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L560)

```csharp
public FrmMarcacionesAutorizadas()
	{
		base.Load += FrmMarcacionesAutorizadas_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### BtnGrabar_Click · líneas 1160–1261

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1160](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1160)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if ((CheckIngreso.CheckState == CheckState.Unchecked) & (CheckSalida.CheckState == CheckState.Unchecked))
		{
			MessageBox.Show("Debe Autorizar, la Entrada o Salida", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (UcTxtRef.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar un Documento de Referencia", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (objClassRRHH.ExistePermiso(idEmpleado, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year, Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Month), DEFecha.DateTime.Month)), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Day), DEFecha.DateTime.Day))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year, Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Month), DEFecha.DateTime.Month)), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + Conversions.ToString(DEFecha.DateTime.Day), DEFecha.DateTime.Day)))) >= 1)
		{
			MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Permiso permiso = new Permiso();
		permiso.FechaFin = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		permiso.FechaInicio = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		object selectedValue = UcCmbMotivo.SelectedValue;
		int? num = default(int?);
		permiso.idMotivo = ((selectedValue != null) ? ((int?)selectedValue) : num);
		permiso.Referencia = UcTxtRef.Text.Trim();
		permiso.Dia = true;
		permiso.Retorno = false;
		permiso.IdEmpleado = idEmpleado;
		int nPermiso = ((PermisoMapper.Instance().SelectBy([SpecialName] (Permiso v) => v.IdEmpleado == idEmpleado).Count == 0) ? 1 : objClassRRHH.SgtIdPermiso(idEmpleado));
		permiso.NPermiso = nPermiso;
		PermisoMapper.Instance().Insert(permiso);
		Horario horario = HorarioMapper.Instance().SelectBy([SpecialName] (Horario v) => v.idHorario == idHorario).Single();
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		Asistencia asistencia = new Asistencia();
		asistencia.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString());
		asistencia.IdEmpleado = idEmpleado;
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Ent = DEHoraIngreso.Text;
			asistencia.Flag_Ent = false;
			if (dataTable.Rows.Count == 0)
			{
				Marcacion marcacion = new Marcacion();
				marcacion.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString() + " " + DEHoraIngreso.Text);
				marcacion.Estado = "1M";
				marcacion.IdEmpleado = idEmpleado;
				MarcacionMapper.Instance().Insert(marcacion);
			}
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Ent = dataTable.Rows[0]["Hor_Ent"].ToString();
			}
			else
			{
				asistencia.Hor_Ent = "00:00:00";
			}
			asistencia.Flag_Ent = true;
		}
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			asistencia.Hor_Sal = DEHoraSalida.Text;
			asistencia.Flag_Sal = false;
			if (dataTable.Rows.Count == 0)
			{
				Marcacion marcacion2 = new Marcacion();
				marcacion2.Fecha = Conversions.ToDate(DEFecha.DateTime.ToShortDateString() + " " + DEHoraSalida.Text);
				marcacion2.Estado = "4M";
				marcacion2.IdEmpleado = idEmpleado;
				MarcacionMapper.Instance().Insert(marcacion2);
			}
		}
		else
		{
			if (dataTable.Rows.Count == 1)
			{
				asistencia.Hor_Sal = dataTable.Rows[0]["Hor_Sal"].ToString();
			}
			else
			{
				asistencia.Hor_Sal = "00:00:00";
			}
			asistencia.Flag_Sal = true;
		}
		asistencia.Estado = true;
		if (dataTable.Rows.Count == 0)
		{
			AsistenciaMapper.Instance().Insert(asistencia);
		}
		else
		{
			AsistenciaMapper.Instance().Update(asistencia);
		}
		MessageBox.Show("Se Grabo Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
	}
```

### FrmMarcacionesAutorizadas_Load · líneas 1263–1393

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1263](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1263)

```csharp
private void FrmMarcacionesAutorizadas_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null) == null)
				{
					MessageBox.Show("Primero debe asignar un Horario al trabajador", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				idHorario = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null));
			}
		}
		ucComboBox ucCmbMotivo = UcCmbMotivo;
		ucCmbMotivo.DisplayMember = "Descrip_Motivo";
		ucCmbMotivo.ValueMember = "idMotivo";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num = 1;
				int? idTipoPermiso = p.idTipoPermiso;
				bool? obj;
				if (!idTipoPermiso.HasValue)
				{
					obj = null;
				}
				else
				{
					bool? flag = idTipoPermiso.GetValueOrDefault() == num;
					obj = flag;
				}
				bool? flag2 = obj;
				bool? flag4;
				if (Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "P", TextCompare: false) != 0)
				{
					bool? flag3 = false;
					flag4 = flag3;
				}
				else
				{
					flag4 = flag2;
				}
				return (bool)flag4;
			});
			list.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num2 = 1;
				int? idTipoPermiso2 = p.idTipoPermiso;
				bool? obj2;
				if (!idTipoPermiso2.HasValue)
				{
					obj2 = null;
				}
				else
				{
					bool? flag5 = idTipoPermiso2.GetValueOrDefault() == num2;
					obj2 = flag5;
				}
				bool? flag6 = obj2;
				bool? flag8;
				if (Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "C", TextCompare: false) != 0)
				{
					bool? flag7 = false;
					flag8 = flag7;
				}
				else
				{
					flag8 = flag6;
				}
				return (bool)flag8;
			});
			list2.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) =>
			{
				int num3 = 1;
				int? idTipoPermiso3 = p.idTipoPermiso;
				bool? obj3;
				if (!idTipoPermiso3.HasValue)
				{
					obj3 = null;
				}
				else
				{
					bool? flag9 = idTipoPermiso3.GetValueOrDefault() == num3;
					obj3 = flag9;
				}
				return (bool)obj3;
			});
			list3.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "--SELECCIONAR--"
			});
			ucCmbMotivo.DataSource = list3;
		}
		ucCmbMotivo = null;
		DEFecha.EditValue = DateAndTime.Today;
	}
```

### DEFecha_EditValueChanged · líneas 1395–1439

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1395](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1395)

```csharp
private void DEFecha_EditValueChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(DEFecha.DateTime.ToShortDateString(), "01/01/0001", TextCompare: false) == 0)
		{
			return;
		}
		string fecha = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DEFecha.DateTime.Year.ToString(), Interaction.IIf(DEFecha.DateTime.Month.ToString().Length == 1, "0" + DEFecha.DateTime.Month, DEFecha.DateTime.Month.ToString())), Interaction.IIf(DEFecha.DateTime.Day.ToString().Length == 1, "0" + DEFecha.DateTime.Day, DEFecha.DateTime.Day.ToString())));
		DataTable dataTable = objClassRRHH.spRRHH_GetAsistenciaDia(idEmpleado, fecha);
		if (dataTable.Rows.Count == 1)
		{
			DEHoraIngreso.Text = dataTable.Rows[0]["Hor_Ent"].ToString();
			DEHoraSalida.Text = dataTable.Rows[0]["Hor_Sal"].ToString();
			if (dataTable.Rows[0]["Estado"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Estado"], true, TextCompare: false) ? true : false))
			{
				if (dataTable.Rows[0]["Flag_Ent"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Flag_Ent"], true, TextCompare: false) ? true : false))
				{
					CheckIngreso.Checked = false;
				}
				else
				{
					CheckIngreso.Checked = true;
				}
				if (dataTable.Rows[0]["Flag_Sal"] == DBNull.Value || (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["Flag_Sal"], true, TextCompare: false) ? true : false))
				{
					CheckSalida.Checked = false;
				}
				else
				{
					CheckSalida.Checked = true;
				}
			}
			else
			{
				CheckIngreso.Checked = false;
				CheckSalida.Checked = false;
			}
		}
		else
		{
			DEHoraIngreso.Text = "";
			DEHoraSalida.Text = "";
			CheckIngreso.Checked = false;
			CheckSalida.Checked = false;
		}
	}
```

### CheckIngreso_CheckedChanged · líneas 1441–1456

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1441](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1441)

```csharp
private void CheckIngreso_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckSalida.CheckState == CheckState.Checked)
		{
			MessageBox.Show("En caso de justificar Entrada y Salida, al mismo tiempo, por favor utilice la interfaz de PERMISOS", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (CheckIngreso.CheckState == CheckState.Checked)
		{
			DEHoraIngreso.Enabled = false;
			DEHoraIngreso.Focus();
		}
		else
		{
			DEHoraIngreso.Enabled = true;
		}
	}
```

### CheckSalida_CheckedChanged · líneas 1458–1473

[Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs:1458](../../Software/RecursosHumanos/RecursosHumanos/FrmMarcacionesAutorizadas.cs#L1458)

```csharp
private void CheckSalida_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckIngreso.CheckState == CheckState.Checked)
		{
			MessageBox.Show("En caso de justificar Entrada y Salida, al mismo tiempo, por favor utilice la interfaz de PERMISOS", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (CheckSalida.CheckState == CheckState.Checked)
		{
			DEHoraSalida.Enabled = false;
			DEHoraSalida.Focus();
		}
		else
		{
			DEHoraSalida.Enabled = true;
		}
	}
```

<a id="f-047"></a>

## FrmMotivoPermiso


### FrmMotivoPermiso · líneas 255–261

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:255](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L255)

```csharp
[DebuggerNonUserCode]
	public FrmMotivoPermiso()
	{
		base.Load += FrmMotivoPermiso_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### ConfigurarEditor · líneas 502–503

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:502](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L502)

```csharp
internal void ConfigurarEditor(Func<int, int?, bool> abrirEditor) =>
        _abrirEditor = abrirEditor ?? throw new ArgumentNullException(nameof(abrirEditor));
```

### AbrirEditor · líneas 505–507

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:505](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L505)

```csharp
public bool AbrirEditor(int tipoPermisoId, int? motivoId) =>
        _abrirEditor != null ? _abrirEditor(tipoPermisoId, motivoId) :
        throw new InvalidOperationException("Abra motivos desde la composición de la aplicación.");
```

### MostrarTipos · líneas 509–522

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:509](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L509)

```csharp
public void MostrarTipos(IList<ItemCatalogoDto> tipos)
    {
        _mostrandoTipos = true;
        try
        {
            var filas = new List<ItemCatalogoDto>(tipos);
            filas.Insert(0, new ItemCatalogoDto { Id = 0, Descripcion = "(SELECCIONAR)" });
            UcComboBox1.ValueMember = nameof(ItemCatalogoDto.Id);
            UcComboBox1.DisplayMember = nameof(ItemCatalogoDto.Descripcion);
            UcComboBox1.DataSource = filas;
            UcComboBox1.SelectedValue = 0;
        }
        finally { _mostrandoTipos = false; }
    }
```

### MostrarMotivos · líneas 524–532

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:524](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L524)

```csharp
public void MostrarMotivos(IReadOnlyList<MotivoPermisoDto> motivos)
    {
        GridControl1.DataSource = new BindingList<MotivoPermisoDto>(new List<MotivoPermisoDto>(motivos));
        GridView1.PopulateColumns();
        foreach (string nombre in new[] { "Id", "TipoPermisoId", "DescripcionTipo", "Modalidad", "Activo" })
            if (GridView1.Columns[nombre] != null) GridView1.Columns[nombre].Visible = false;
        if (GridView1.Columns["Descripcion"] != null) GridView1.Columns["Descripcion"].Caption = "Motivo";
        if (GridView1.Columns["Abreviatura"] != null) GridView1.Columns["Abreviatura"].Caption = "Abreviatura";
    }
```

### HabilitarAcciones · líneas 534–539

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:534](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L534)

```csharp
public void HabilitarAcciones(bool habilitadas)
    {
        btnAgregar.Enabled = habilitadas;
        btnModificar.Enabled = habilitadas;
        btnEliminar.Enabled = habilitadas;
    }
```

### MostrarError · líneas 541–541

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:541](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L541)

```csharp
public void MostrarError(string mensaje) => MessageBox.Show(this, mensaje, "Motivos de permiso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
```

### MostrarInformacion · líneas 542–542

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:542](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L542)

```csharp
public void MostrarInformacion(string mensaje) => MessageBox.Show(this, mensaje, "Motivos de permiso", MessageBoxButtons.OK, MessageBoxIcon.Information);
```

### ConfirmarEliminacion · líneas 543–544

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:543](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L543)

```csharp
public bool ConfirmarEliminacion() => MessageBox.Show(this, "¿Desea eliminar el motivo seleccionado?", "Motivos de permiso",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
```

### GroupControl1_Paint · líneas 546–546

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:546](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L546)

```csharp
private void GroupControl1_Paint(object sender, PaintEventArgs e) { }
```

### FrmMotivoPermiso_Load · líneas 547–547

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:547](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L547)

```csharp
private void FrmMotivoPermiso_Load(object sender, EventArgs e) => CargarSolicitado?.Invoke(this, EventArgs.Empty);
```

### UcComboBox1_SelectedIndexChanged · líneas 548–551

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:548](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L548)

```csharp
private void UcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_mostrandoTipos) TipoCambiado?.Invoke(this, EventArgs.Empty);
    }
```

### btnAgregar_Click · líneas 552–552

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:552](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L552)

```csharp
private void btnAgregar_Click(object sender, EventArgs e) => AgregarSolicitado?.Invoke(this, EventArgs.Empty);
```

### btnModificar_Click · líneas 553–553

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:553](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L553)

```csharp
private void btnModificar_Click(object sender, EventArgs e) => EditarSolicitado?.Invoke(this, EventArgs.Empty);
```

### btnEliminar_Click · líneas 554–554

[Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs:554](../../Software/RecursosHumanos/RecursosHumanos/FrmMotivoPermiso.cs#L554)

```csharp
private void btnEliminar_Click(object sender, EventArgs e) => EliminarSolicitado?.Invoke(this, EventArgs.Empty);
```

<a id="f-048"></a>

## FrmNuevaFicha


### FrmNuevaFicha · líneas 19–24

[Software/RecursosHumanos/RecursosHumanos/FrmNuevaFicha.cs:19](../../Software/RecursosHumanos/RecursosHumanos/FrmNuevaFicha.cs#L19)

```csharp
[DebuggerNonUserCode]
	public FrmNuevaFicha()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}
```

<a id="f-049"></a>

## FrmPeriodoLaboral


### FrmPeriodoLaboral · líneas 279–285

[Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs:279](../../Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs#L279)

```csharp
[DebuggerNonUserCode]
	public FrmPeriodoLaboral()
	{
		base.Load += FrmPeriodoLaboral_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### btnGrabar_Click · líneas 590–615

[Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs:590](../../Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs#L590)

```csharp
private void btnGrabar_Click(object sender, EventArgs e)
	{
		PeriodoLaboral periodoLaboral = new PeriodoLaboral();
		periodoLaboral.IdEmpleado = CodEmple;
		periodoLaboral.FechaIngreso = UcDTIngresoInst.Value;
		periodoLaboral.FechaResoIngreInstitu = UcDTFechaResolIngreInsti.Value;
		periodoLaboral.FechaSalida = UcDateTime1.Value;
		object editValue = CheckEdit2.EditValue;
		bool? flag = default(bool?);
		periodoLaboral.Judicial = ((editValue != null) ? ((bool?)editValue) : flag);
		periodoLaboral.NumResoIngreInstitu = UcTxtResoIngreInsti.Text.Trim();
		periodoLaboral.Obs = UcTextBox1.Text.Trim();
		if (nro == 0)
		{
			List<PeriodoLaboral> list = PeriodoLaboralMapper.Instance().SelectBy([SpecialName] (PeriodoLaboral p) => p.IdEmpleado == CodEmple);
			int nroPeriodo = ((list.Count == 0) ? 1 : checked(((IEnumerable<PeriodoLaboral>)list).Max<PeriodoLaboral, int>((Func<PeriodoLaboral, int>)([SpecialName] (PeriodoLaboral y) => y.NroPeriodo)) + 1));
			periodoLaboral.NroPeriodo = nroPeriodo;
			PeriodoLaboralMapper.Instance().Insert(periodoLaboral);
		}
		else
		{
			periodoLaboral.NroPeriodo = nro;
			PeriodoLaboralMapper.Instance().Update(periodoLaboral);
		}
		DialogResult = DialogResult.OK;
	}
```

### FrmPeriodoLaboral_Load · líneas 617–646

[Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs:617](../../Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs#L617)

```csharp
private void FrmPeriodoLaboral_Load(object sender, EventArgs e)
	{
		if (nro != 0)
		{
			PeriodoLaboral periodoLaboral = PeriodoLaboralMapper.Instance().SelectBy([SpecialName] (PeriodoLaboral p) => (p.IdEmpleado == CodEmple) & (p.NroPeriodo == nro)).First();
			UcDTIngresoInst.Value = (DateTime)periodoLaboral.FechaIngreso;
			UcTxtResoIngreInsti.Text = periodoLaboral.NumResoIngreInstitu.ToString().Trim();
			if (!periodoLaboral.FechaResoIngreInstitu.HasValue)
			{
				UcDTFechaResolIngreInsti.Value = (DateTime)periodoLaboral.FechaResoIngreInstitu;
			}
			UcDTFechaResolIngreInsti.Value = (DateTime)periodoLaboral.FechaResoIngreInstitu;
			if (!periodoLaboral.FechaSalida.HasValue)
			{
				CheckEdit1.EditValue = false;
			}
			else
			{
				CheckEdit1.EditValue = true;
			}
			if (periodoLaboral.Judicial.HasValue)
			{
				CheckEdit2.EditValue = periodoLaboral.Judicial;
			}
			if (periodoLaboral.Obs != null)
			{
				UcTextBox1.Text = periodoLaboral.Obs.ToString().Trim();
			}
		}
	}
```

### CheckEdit1_CheckedChanged · líneas 648–658

[Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs:648](../../Software/RecursosHumanos/RecursosHumanos/FrmPeriodoLaboral.cs#L648)

```csharp
private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(CheckEdit1.EditValue, true, TextCompare: false))
		{
			UcDateTime1.Enabled = true;
		}
		else
		{
			UcDateTime1.Enabled = false;
		}
	}
```

<a id="f-050"></a>

## FrmPermiso


### FrmPermiso · líneas 658–665

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:658](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L658)

```csharp
public FrmPermiso()
	{
		base.Load += FrmPermiso_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmPermiso_Load · líneas 1264–1322

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1264](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1264)

```csharp
private void FrmPermiso_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count == 1)
		{
			foreach (object row in dataTable.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(row);
				if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
				{
					img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
					UcFoto.Image = Image.FromStream(memoryStream);
					memoryStream.Close();
				}
				UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
				UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
				UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
				UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			}
		}
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "--SELECCIONAR--"
		});
		UcCmbTipoPermiso.DataSource = list;
		UcCmbTipoPermiso.DisplayMember = "DescripTipoPermiso";
		UcCmbTipoPermiso.ValueMember = "idTipoPermiso";
		if (Npermiso == 0)
		{
			return;
		}
		Permiso permiso = PermisoMapper.Instance().SelectBy([SpecialName] (Permiso v) => (v.IdEmpleado == idEmpleado) & (v.NPermiso == Npermiso)).Single();
		List<Motivo_Perm> source = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm v) =>
		{
			int idMotivo = v.idMotivo;
			int? idMotivo2 = permiso.idMotivo;
			bool? obj;
			if (!idMotivo2.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idMotivo == idMotivo2.GetValueOrDefault();
				obj = flag;
			}
			return (bool)obj;
		});
		UcCmbTipoPermiso.SelectedValue = source.Single().idTipoPermiso.Value;
		UcCmbMotivo.SelectedValue = permiso.idMotivo.Value;
		UcTxtRef.Text = permiso.Referencia.ToString();
		RangoFecha rango = new RangoFecha(permiso.FechaInicio.Value, permiso.FechaFin.Value);
		UcFechas.Rango = rango;
		UcTxtObs.Text = permiso.Obs.ToString();
	}
```

### UcCmbTipoPermiso_SelectedIndexChanged · líneas 1324–1414

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1324](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1324)

```csharp
private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (UcCmbTipoPermiso.SelectedIndex == 0)
		{
			UcCmbMotivo.Enabled = false;
		}
		else
		{
			UcCmbMotivo.Enabled = true;
			ucComboBox ucCmbMotivo = UcCmbMotivo;
			ucCmbMotivo.DisplayMember = "Descrip_Motivo";
			ucCmbMotivo.ValueMember = "idMotivo";
			if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
			{
				List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "P", TextCompare: false) == 0)));
				list.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
			{
				List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)p.TipoModalidad), "C", TextCompare: false) == 0)));
				list2.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list2;
			}
			else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
			{
				List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm p) => Operators.ConditionalCompareObjectEqual(p.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false));
				list3.Insert(0, new Motivo_Perm
				{
					idMotivo = 0,
					Descrip_Motivo = "--SELECCIONAR--"
				});
				ucCmbMotivo.DataSource = list3;
			}
			ucCmbMotivo = null;
		}
		if (UcCmbTipoPermiso.SelectedIndex == 1)
		{
			Label9.Visible = false;
			UcTxtLugar.Visible = false;
			Label2.Visible = false;
			UcTxtAutorizacion.Visible = false;
			ucTextBox ucTxtRef = UcTxtRef;
			Point location = new Point(88, 125);
			ucTxtRef.Location = location;
			Label label = Label8;
			location = new Point(26, 128);
			label.Location = location;
			ucTextBox ucTxtObs = UcTxtObs;
			location = new Point(88, 151);
			ucTxtObs.Location = location;
			Label label2 = Label11;
			location = new Point(50, 154);
			label2.Location = location;
			CheckEditDia.Visible = true;
			CheckEditDia.EditValue = true;
			CheckEditRetorno.EditValue = false;
			CheckEditRetorno.Visible = false;
		}
		if (UcCmbTipoPermiso.SelectedIndex == 2)
		{
			Label9.Visible = true;
			UcTxtLugar.Visible = true;
			Label2.Visible = true;
			UcTxtAutorizacion.Visible = true;
			ucTextBox ucTxtRef2 = UcTxtRef;
			Point location = new Point(88, 177);
			ucTxtRef2.Location = location;
			Label label3 = Label8;
			location = new Point(26, 180);
			label3.Location = location;
			ucTextBox ucTxtObs2 = UcTxtObs;
			location = new Point(88, 203);
			ucTxtObs2.Location = location;
			Label label4 = Label11;
			location = new Point(50, 206);
			label4.Location = location;
			CheckEditDia.Visible = false;
			CheckEditRetorno.Visible = true;
			CheckEditDia.EditValue = false;
			CheckEditRetorno.EditValue = true;
		}
	}
```

### Button1_Click · líneas 1416–1560

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1416](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1416)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (!UcCmbMotivo.Enabled)
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar un Motivo Válido", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		List<Permiso> list = PermisoMapper.Instance().SelectBy([SpecialName] (Permiso p) =>
		{
			bool flag = true;
			bool? retorno = p.Retorno;
			bool? obj;
			if (!retorno.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag2 = retorno == true == flag;
				obj = flag2;
			}
			bool? flag3 = obj;
			bool? flag5;
			if (!((p.IdEmpleado == idEmpleado) & (Operators.CompareString(p.FechaInicio.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) <= 0) & (Operators.CompareString(p.FechaFin.Value.ToShortDateString(), UcFechas.Rango.Desde.ToShortDateString(), TextCompare: false) >= 0)))
			{
				bool? flag4 = false;
				flag5 = flag4;
			}
			else
			{
				flag5 = flag3;
			}
			bool? flag6 = flag5;
			bool? flag8;
			if (p.Hora_Ret != null)
			{
				bool? flag7 = false;
				flag8 = flag7;
			}
			else
			{
				flag8 = flag6;
			}
			return (bool)flag8;
		});
		if (list.Count >= 1)
		{
			MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 1, TextCompare: false))
		{
		}
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 2, TextCompare: false))
		{
			if (AsistenciaMapper.Instance().SelectBy([SpecialName] (Asistencia a) => (a.IdEmpleado == idEmpleado) & (DateTime.Compare(a.Fecha, DateTime.Today) == 0)).Count == 0)
			{
				MessageBox.Show("El Empleado, no ah asistido hoy al Centro Laboral", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			int count = AsistenciaMapper.Instance().SelectBy([SpecialName] (Asistencia s) => (s.IdEmpleado == idEmpleado) & (DateTime.Compare(s.Fecha, DateTime.Today) == 0) & (Operators.CompareString(s.Hor_Sal, "00:00:00", TextCompare: false) != 0)).Count;
			if (count == 1)
			{
				MessageBox.Show("El Empleado ya se retiro del Centro Laboral", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (DateTime.Compare(UcFechas.Rango.Desde, DateTime.Today) < 0)
			{
				MessageBox.Show("La Fecha de Inicio no Puede ser Menor a la Fecha Actual", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) != 0)
			{
				MessageBox.Show("Solo se puede Asignar una Salida autoriza a un dia", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
		}
		if (Operators.ConditionalCompareObjectEqual(CheckEditDia.EditValue, true, TextCompare: false) && DateTime.Compare(UcFechas.Rango.Desde, UcFechas.Rango.Hasta) != 0)
		{
			TimeSpan timeSpan = UcFechas.Rango.Hasta - UcFechas.Rango.Desde;
			int num = Conversions.ToInteger(timeSpan.TotalDays.ToString());
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				string text = Conversions.ToString(UcFechas.Rango.Desde.Date.AddDays(num2));
				num2 = checked(num2 + 1);
			}
		}
		Permiso permiso = new Permiso();
		permiso.FechaFin = Conversions.ToDate(UcFechas.Rango.Hasta.ToShortDateString());
		permiso.FechaInicio = Conversions.ToDate(UcFechas.Rango.Desde.ToShortDateString());
		object selectedValue = UcCmbMotivo.SelectedValue;
		int? num5 = default(int?);
		permiso.idMotivo = ((selectedValue != null) ? ((int?)selectedValue) : num5);
		permiso.Autorizacion = UcTxtAutorizacion.Text.Trim();
		permiso.Lugar = UcTxtLugar.Text.Trim();
		permiso.Referencia = UcTxtRef.Text.Trim();
		object editValue = CheckEditDia.EditValue;
		bool? flag9 = default(bool?);
		permiso.Dia = ((editValue != null) ? ((bool?)editValue) : flag9);
		object editValue2 = CheckEditRetorno.EditValue;
		permiso.Retorno = ((editValue2 != null) ? ((bool?)editValue2) : flag9);
		permiso.IdEmpleado = idEmpleado;
		permiso.Obs = UcTxtObs.Text.Trim();
		if (Npermiso == 0)
		{
			if (objClassRRHH.ExistePermiso(idEmpleado, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas.Rango.Desde.Year, Interaction.IIf(UcFechas.Rango.Desde.Month.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Desde.Month), UcFechas.Rango.Desde.Month)), Interaction.IIf(UcFechas.Rango.Desde.Day.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Desde.Day), UcFechas.Rango.Desde.Day))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas.Rango.Hasta.Year, Interaction.IIf(UcFechas.Rango.Hasta.Month.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Hasta.Month), UcFechas.Rango.Hasta.Month)), Interaction.IIf(UcFechas.Rango.Hasta.Day.ToString().Length == 1, "0" + Conversions.ToString(UcFechas.Rango.Hasta.Day), UcFechas.Rango.Hasta.Day)))) >= 1)
			{
				MessageBox.Show("El Empleado se Encuentra de Permiso, No se puede agregar Otro Permiso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			permiso.NPermiso = objClassRRHH.SgtIdPermiso(idEmpleado);
			PermisoMapper.Instance().Insert(permiso);
		}
		else
		{
			permiso.NPermiso = Npermiso;
			PermisoMapper.Instance().Update(permiso);
		}
		if (CheckEquipoMarcacion.CheckState == CheckState.Checked)
		{
			AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
			if (!asistenciaAccess.Grabar_SalidaAutorizada(UcTxtNDoc.Text, Npermiso, UcFechas.Rango.Desde.ToShortDateString(), UcFechas.Rango.Hasta.ToShortDateString(), Conversions.ToBoolean(CheckEditDia.EditValue), Conversions.ToBoolean(CheckEditRetorno.EditValue), UcTxtLugar.Text.Trim()))
			{
				MessageBox.Show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		DialogResult = DialogResult.OK;
	}
```

### UcCmbMotivo_SelectedIndexChanged · líneas 1562–1591

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1562](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1562)

```csharp
private void UcCmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label lbl_Tipo = Lbl_Tipo;
		List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Operators.ConditionalCompareObjectEqual(m.idMotivo, UcCmbMotivo.SelectedValue, TextCompare: false));
		if (list.Count >= 1)
		{
			bool flag = true;
			bool? salario = list.First().Salario;
			bool? obj;
			if (!salario.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag2 = salario == true == flag;
				obj = flag2;
			}
			bool? flag3 = obj;
			if (flag3 == true)
			{
				lbl_Tipo.Text = "Asalariado";
			}
			else
			{
				lbl_Tipo.Text = "NO Asalariado";
			}
		}
		lbl_Tipo = null;
	}
```

### CheckEditDia_Click · líneas 1593–1600

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1593](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1593)

```csharp
private void CheckEditDia_Click(object sender, EventArgs e)
	{
		if (CheckEditRetorno.Checked)
		{
			CheckEditDia.Checked = false;
			MessageBox.Show("No puedo Marcar Día, si marca Retorno", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
```

### CheckEditRetorno_Click · líneas 1602–1609

[Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs:1602](../../Software/RecursosHumanos/RecursosHumanos/FrmPermiso.cs#L1602)

```csharp
private void CheckEditRetorno_Click(object sender, EventArgs e)
	{
		if (CheckEditDia.Checked)
		{
			CheckEditRetorno.Checked = false;
			MessageBox.Show("No puedo Marcar Retorno, si marca Día", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
```

<a id="f-051"></a>

## FrmRegistroAsegurado


### FrmRegistroAsegurado · líneas 766–773

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:766](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L766)

```csharp
public FrmRegistroAsegurado()
	{
		base.Load += FrmRegistroAsegurado_Load;
		__ENCAddToList(this);
		oPersona = new Persona();
		oRRHH_Asegurado = new RRHH_Asegurado();
		InitializeComponent();
	}
```

### FrmRegistroAsegurado_Load · líneas 1487–1604

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1487](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1487)

```csharp
private void FrmRegistroAsegurado_Load(object sender, EventArgs e)
	{
		RRHHClass rRHHClass = new RRHHClass();
		UcCBEstadoCivil.ValueMember = "IdEstadoCivil";
		UcCBEstadoCivil.DisplayMember = "DescripEstCivil";
		DataTable dataTable = (DataTable)rRHHClass.llena_estCivil();
		DataRow dataRow = dataTable.NewRow();
		dataRow["IdEstadoCivil"] = 0;
		dataRow["DescripEstCivil"] = "(Seleccionar)";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBEstadoCivil.DataSource = dataTable;
		UcUbigeoCmbDirec.GetDpto();
		UcComboBoxTDI.ValueMember = "TipoDocID";
		UcComboBoxTDI.DisplayMember = "Descripcion";
		UcComboBoxTDI.DataSource = RuntimeHelpers.GetObjectValue(rRHHClass.llena_DocID());
		DEInicioVinculo.DateTime = DateAndTime.Today;
		UcCmboMotivoBaja.ValueMember = "idMotivoBaja";
		UcCmboMotivoBaja.DisplayMember = "Descripcion";
		List<MotivoBaja> list = MotivoBajaMapper.Instance().SelectAll();
		list.Insert(0, new MotivoBaja
		{
			idMotivoBaja = 0,
			Descripcion = "(SELECCIONAR)"
		});
		UcCmboMotivoBaja.DataSource = list;
		if (oRRHH_Asegurado.NroBeneficiario <= 0)
		{
			return;
		}
		oRRHH_Asegurado = RRHH_AseguradoMapper.Instance().SelectBy([SpecialName] (RRHH_Asegurado A) => (A.idEmpleado == idEmpleado) & (A.NroBeneficiario == oRRHH_Asegurado.NroBeneficiario)).First();
		oPersona = PersonaMapper.Instance().SelectBy([SpecialName] (Persona y) =>
		{
			int idPersona = y.IdPersona;
			int? idPersona2 = oRRHH_Asegurado.idPersona;
			bool? obj;
			if (!idPersona2.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = idPersona == idPersona2.GetValueOrDefault();
				obj = flag;
			}
			return (bool)obj;
		}).First();
		UcTxtApellidoPaterno.Text = oPersona.Apellido_Paterno.Trim();
		UcTxtApellidoPaterno.ReadOnly = true;
		UcTxtApelldoMaterno.Text = oPersona.Apellido_Materno.Trim();
		UcTxtApelldoMaterno.ReadOnly = true;
		UcTxtNombres.Text = oPersona.Nombres.Trim();
		UcTxtNombres.ReadOnly = true;
		UcTxtDireccion.Text = oPersona.Direccion.Trim();
		UcTxtDireccion.ReadOnly = true;
		UcUbigeoCmbDirec.Ubigeo = oPersona.UbigeoDireccion;
		DEFechaNacimiento.DateTime = (DateTime)oPersona.FechaNacimiento;
		DEFechaNacimiento.Enabled = true;
		UcComboBoxTDI.SelectedValue = oPersona.TipoDocID;
		UcComboBoxTDI.Enabled = false;
		UcTxtNumeroDocIdent.Text = oPersona.NumDocID.Trim();
		UcTxtNumeroDocIdent.ReadOnly = true;
		btnBuscar.Enabled = false;
		RadioGroup2.EditValue = oRRHH_Asegurado.VinculoFamiliar;
		string vinculoFamiliar = oRRHH_Asegurado.VinculoFamiliar;
		if (Operators.CompareString(vinculoFamiliar, "Hijo", TextCompare: false) == 0)
		{
			UcTNroPartida.Text = oRRHH_Asegurado.NroResolMayorIndiscap;
		}
		else if (Operators.CompareString(vinculoFamiliar, "Conyuge", TextCompare: false) == 0)
		{
			UcTNroPartida.Text = oRRHH_Asegurado.NroPartida;
		}
		DEInicioVinculo.DateTime = (DateTime)oRRHH_Asegurado.FechaInicioVinculo;
		UcCBEstadoCivil.SelectedValue = oRRHH_Asegurado.EstadoCivil.IdEstadoCivil;
		RadioGroupSexo.EditValue = oRRHH_Asegurado.Sexo.ToString();
		RGReEvaluar.EditValue = oRRHH_Asegurado.Reevaluar.ToString();
		if (oRRHH_Asegurado.MotivoBaja == null)
		{
			return;
		}
		UcCmboMotivoBaja.SelectedValue = oRRHH_Asegurado.MotivoBaja.idMotivoBaja;
		DEFEchaFinVinculo.DateTime = (DateTime)oRRHH_Asegurado.FechaFinVinculo;
		int? idMotivoBaja = oRRHH_Asegurado.idMotivoBaja;
		int num = 2;
		bool? obj2;
		bool? flag2;
		if (!idMotivoBaja.HasValue)
		{
			obj2 = null;
		}
		else
		{
			flag2 = idMotivoBaja.GetValueOrDefault() == num;
			obj2 = flag2;
		}
		bool? flag3 = obj2;
		if (flag3 == true)
		{
			UcTxtMotivoBaja.Text = oRRHH_Asegurado.NroPartidaDef;
			return;
		}
		num = 5;
		bool? obj3;
		if (!idMotivoBaja.HasValue)
		{
			obj3 = null;
		}
		else
		{
			flag3 = idMotivoBaja.GetValueOrDefault() == num;
			obj3 = flag3;
		}
		flag2 = obj3;
		if (flag2 == true)
		{
			UcTxtMotivoBaja.Text = oRRHH_Asegurado.OtrosMotivos;
		}
	}
```

### GroupControl1_Paint · líneas 1606–1608

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1606](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1606)

```csharp
private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}
```

### btnBuscar_Click · líneas 1610–1632

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1610](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1610)

```csharp
private void btnBuscar_Click(object sender, EventArgs e)
	{
		FrmBuscarDerechohabiente frmBuscarDerechohabiente = new FrmBuscarDerechohabiente();
		if (frmBuscarDerechohabiente.ShowDialog() == DialogResult.OK)
		{
			oPersona = PersonaMapper.Instance().SelectBy([SpecialName] (Persona y) => y.IdPersona == frmBuscarDerechohabiente.oPersona.IdPersona).First();
			UcTxtApellidoPaterno.Text = oPersona.Apellido_Paterno.Trim();
			UcTxtApellidoPaterno.ReadOnly = true;
			UcTxtApelldoMaterno.Text = oPersona.Apellido_Materno.Trim();
			UcTxtApelldoMaterno.ReadOnly = true;
			UcTxtNombres.Text = oPersona.Nombres.Trim();
			UcTxtNombres.ReadOnly = true;
			UcTxtDireccion.Text = oPersona.Direccion.Trim();
			UcTxtDireccion.ReadOnly = true;
			UcUbigeoCmbDirec.Ubigeo = oPersona.UbigeoDireccion;
			DEFechaNacimiento.DateTime = (DateTime)oPersona.FechaNacimiento;
			DEFechaNacimiento.Enabled = true;
			UcComboBoxTDI.SelectedValue = oPersona.TipoDocID;
			UcComboBoxTDI.Enabled = false;
			UcTxtNumeroDocIdent.Text = oPersona.NumDocID.Trim();
			UcTxtNumeroDocIdent.ReadOnly = true;
		}
	}
```

### btnGuardar_Click · líneas 1634–1754

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1634](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1634)

```csharp
private void btnGuardar_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(RadioGroupSexo.EditValue, null, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar el Sexo del Asegurado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(UcCBEstadoCivil.SelectedValue, 0, TextCompare: false))
		{
			MessageBox.Show("Debe Seleccionar el estado Civil del Asegurado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (string.IsNullOrEmpty(UcTxtNumeroDocIdent.Text))
		{
			MessageBox.Show("Debe ingresar el Nro. del Doc. de Ident. del Asegurado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		RRHH_Asegurado rRHH_Asegurado = new RRHH_Asegurado();
		rRHH_Asegurado.idEmpleado = idEmpleado;
		checked
		{
			if (oRRHH_Asegurado.NroBeneficiario == 0)
			{
				if (RRHH_AseguradoMapper.Instance().SelectBy([SpecialName] (RRHH_Asegurado x) => x.idEmpleado == idEmpleado).Count == 0)
				{
					rRHH_Asegurado.NroBeneficiario = 1;
				}
				else
				{
					rRHH_Asegurado.NroBeneficiario = ((IEnumerable<RRHH_Asegurado>)RRHH_AseguradoMapper.Instance().SelectBy([SpecialName] (RRHH_Asegurado x) => x.idEmpleado == idEmpleado)).Max<RRHH_Asegurado, int>((Func<RRHH_Asegurado, int>)([SpecialName] (RRHH_Asegurado b) => b.NroBeneficiario)) + 1;
				}
			}
			else
			{
				rRHH_Asegurado.NroBeneficiario = oRRHH_Asegurado.NroBeneficiario;
			}
			int? num = default(int?);
			if (oPersona.IdPersona == 0)
			{
				oPersona.IdPersona = ((IEnumerable<Persona>)PersonaMapper.Instance().SelectAll()).Max<Persona, int>((Func<Persona, int>)([SpecialName] (Persona P) => P.IdPersona)) + 1;
				oPersona.Apellido_Paterno = UcTxtApellidoPaterno.Text.Trim();
				oPersona.Apellido_Materno = UcTxtApelldoMaterno.Text.Trim();
				oPersona.Nombres = UcTxtNombres.Text.Trim();
				oPersona.Direccion = UcTxtDireccion.Text.Trim();
				oPersona.UbigeoDireccion = UcUbigeoCmbDirec.Ubigeo;
				Persona persona = oPersona;
				object selectedValue = UcComboBoxTDI.SelectedValue;
				persona.TipoDocID = ((selectedValue != null) ? ((int?)selectedValue) : num);
				oPersona.NumDocID = UcTxtNumeroDocIdent.Text.Trim();
				PersonaMapper.Instance().Insert(oPersona);
			}
			rRHH_Asegurado.idPersona = oPersona.IdPersona;
			object selectedValue2 = UcCBEstadoCivil.SelectedValue;
			rRHH_Asegurado.idEstadoCivil = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
			rRHH_Asegurado.Sexo = Conversions.ToChar(RadioGroupSexo.EditValue.ToString());
			rRHH_Asegurado.VinculoFamiliar = Conversions.ToString(RadioGroup2.EditValue);
			rRHH_Asegurado.Reevaluar = Convert.ToChar(RuntimeHelpers.GetObjectValue(RGReEvaluar.EditValue));
			string vinculoFamiliar = rRHH_Asegurado.VinculoFamiliar;
			if (Operators.CompareString(vinculoFamiliar, "Hijo", TextCompare: false) == 0)
			{
				rRHH_Asegurado.NroResolMayorIndiscap = UcTNroPartida.Text.Trim();
			}
			else if (Operators.CompareString(vinculoFamiliar, "Conyuge", TextCompare: false) == 0)
			{
				rRHH_Asegurado.NroPartida = UcTNroPartida.Text.Trim();
			}
			rRHH_Asegurado.FechaInicioVinculo = DEInicioVinculo.DateTime;
			if (Operators.ConditionalCompareObjectGreater(UcCmboMotivoBaja.SelectedValue, 0, TextCompare: false))
			{
				object selectedValue3 = UcCmboMotivoBaja.SelectedValue;
				rRHH_Asegurado.idMotivoBaja = ((selectedValue3 != null) ? ((int?)selectedValue3) : num);
				rRHH_Asegurado.FechaFinVinculo = DEFEchaFinVinculo.DateTime;
				int? idMotivoBaja = rRHH_Asegurado.idMotivoBaja;
				int num2 = 2;
				bool? obj;
				if (!idMotivoBaja.HasValue)
				{
					obj = null;
				}
				else
				{
					bool? flag = idMotivoBaja.GetValueOrDefault() == num2;
					obj = flag;
				}
				bool? flag2 = obj;
				if (flag2 == true)
				{
					rRHH_Asegurado.NroPartidaDef = UcTxtMotivoBaja.Text;
				}
				else
				{
					num2 = 5;
					bool? obj2;
					if (!idMotivoBaja.HasValue)
					{
						obj2 = null;
					}
					else
					{
						flag2 = idMotivoBaja.GetValueOrDefault() == num2;
						obj2 = flag2;
					}
					bool? flag = obj2;
					if (flag == true)
					{
						rRHH_Asegurado.OtrosMotivos = UcTxtMotivoBaja.Text;
					}
				}
			}
			if (oRRHH_Asegurado.NroBeneficiario > 0)
			{
				rRHH_Asegurado.NroBeneficiario = oRRHH_Asegurado.NroBeneficiario;
				RRHH_AseguradoMapper.Instance().Update(rRHH_Asegurado);
			}
			else
			{
				RRHH_AseguradoMapper.Instance().Insert(rRHH_Asegurado);
			}
			DialogResult = DialogResult.OK;
		}
	}
```

### RadioGroup2_EditValueChanged · líneas 1756–1785

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1756](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1756)

```csharp
private void RadioGroup2_EditValueChanged(object sender, EventArgs e)
	{
		string text = Conversions.ToString(RadioGroup2.EditValue);
		string left = text;
		if (Operators.CompareString(left, "Hijo", TextCompare: false) == 0)
		{
			Label14.Text = "N° de Resolución:";
			Label14.Visible = true;
			UcTNroPartida.Visible = true;
			Label15.Visible = true;
			RGReEvaluar.Visible = true;
		}
		else if (Operators.CompareString(left, "Conyuge", TextCompare: false) == 0)
		{
			Label14.Text = "N° de Partida:";
			Label14.Visible = true;
			UcTNroPartida.Visible = true;
			Label15.Visible = false;
			RGReEvaluar.Visible = false;
			RGReEvaluar.EditValue = null;
		}
		else
		{
			Label15.Visible = false;
			Label14.Visible = false;
			UcTNroPartida.Visible = false;
			RGReEvaluar.Visible = false;
			RGReEvaluar.EditValue = null;
		}
	}
```

### RadioGroup2_SelectedIndexChanged · líneas 1787–1789

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1787](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1787)

```csharp
private void RadioGroup2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
```

### UcCmboMotivoBaja_SelectedIndexChanged · líneas 1791–1805

[Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs:1791](../../Software/RecursosHumanos/RecursosHumanos/FrmRegistroAsegurado.cs#L1791)

```csharp
private void UcCmboMotivoBaja_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (Conversions.ToInteger(UcCmboMotivoBaja.SelectedValue))
		{
		case 2:
			UcTxtMotivoBaja.Visible = true;
			break;
		case 5:
			UcTxtMotivoBaja.Visible = true;
			break;
		default:
			UcTxtMotivoBaja.Visible = false;
			break;
		}
	}
```

<a id="f-052"></a>

## FrmRelacionSalidaAutorizada


### FrmRelacionSalidaAutorizada · líneas 96–101

[Software/RecursosHumanos/RecursosHumanos/FrmRelacionSalidaAutorizada.cs:96](../../Software/RecursosHumanos/RecursosHumanos/FrmRelacionSalidaAutorizada.cs#L96)

```csharp
[DebuggerNonUserCode]
	public FrmRelacionSalidaAutorizada()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}
```

<a id="f-053"></a>

## FrmRepAsistenciaDia


### FrmRepAsistenciaDia · líneas 479–485

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:479](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L479)

```csharp
public FrmRepAsistenciaDia()
	{
		base.Load += FrmRepAsistenciaDia_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmRepAsistenciaDia_Load · líneas 839–850

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:839](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L839)

```csharp
private void FrmRepAsistenciaDia_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--TODOS--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
	}
```

### btnAgregarLista_Click · líneas 852–856

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:852](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L852)

```csharp
private void btnAgregarLista_Click(object sender, EventArgs e)
	{
		objRRHHClass.spRRHH_AgregarReporte(Conversions.ToInteger(ListTrabajadores.SelectedValue), 1);
		CargarListas();
	}
```

### CargarListas · líneas 858–866

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:858](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L858)

```csharp
private void CargarListas()
	{
		ListTrabajadores.DataSource = objRRHHClass.spRRHH_ListarTrabajadores(Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		ListTrabajadores.ValueMember = "IdEmpleado";
		ListTrabajadores.DisplayMember = "NombresCompletos";
		ListTrabajadoresRep.DataSource = objRRHHClass.spRRHH_ListarTrabajadoresRep(Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue));
		ListTrabajadoresRep.ValueMember = "IdEmpleado";
		ListTrabajadoresRep.DisplayMember = "NombresCompletos";
	}
```

### btnQuitarLista_Click · líneas 868–872

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:868](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L868)

```csharp
private void btnQuitarLista_Click(object sender, EventArgs e)
	{
		objRRHHClass.spRRHH_AgregarReporte(Conversions.ToInteger(ListTrabajadoresRep.SelectedValue), 2);
		CargarListas();
	}
```

### UcCBPartidaPresupuestal_SelectedIndexChanged · líneas 874–877

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:874](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L874)

```csharp
private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		CargarListas();
	}
```

### BtnConsultar_Click · líneas 879–890

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:879](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L879)

```csharp
private void BtnConsultar_Click(object sender, EventArgs e)
	{
		fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridControl gridControl = GridControl1;
		RRHHClass rRHHClass = objRRHHClass;
		string obj = fechaI;
		string obj2 = fechaF;
		object selectedValue = UcCBPartidaPresupuestal.SelectedValue;
		int? num = default(int?);
		gridControl.DataSource = rRHHClass.spRRHH_RepAsisdiarria(obj, obj2, null, num, (selectedValue != null) ? ((int?)selectedValue) : num, MySettingsProperty.Settings.AnioActual.ToString().Trim(), Conversions.ToString(0), 1);
	}
```

### Button2_Click · líneas 892–977

[Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs:892](../../Software/RecursosHumanos/RecursosHumanos/FrmRepAsistenciaDia.cs#L892)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Export_Asitencias_diaria_" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Export_Asitencias_diaria";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		GridColumnCollection columns = GridView1.Columns;
		array6[1] = columns.Count;
		array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
		object[] array7 = array3;
		object[] arguments2 = array7;
		array2 = new bool[2] { false, true };
		object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
			{
				num,
				columns.Count,
				RuntimeHelpers.GetObjectValue(array7[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Asistencia" }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
		array7 = new object[2] { "A3", null };
		object[] array8 = array7;
		obj2 = objectValue3;
		object instance4 = obj2;
		object[] array9 = new object[2];
		object[] array10 = array9;
		num = 3;
		array10[0] = num;
		object[] array11 = array9;
		columns = GridView1.Columns;
		array11[1] = columns.Count;
		array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
		array = array7;
		object[] arguments3 = array;
		array2 = new bool[2] { false, true };
		object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
		if (array2[1])
		{
			NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
			{
				num,
				columns.Count,
				RuntimeHelpers.GetObjectValue(array[1])
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + UcFechas1.Rango.Desde.ToLongDateString() + " Al: " + UcFechas1.Rango.Hasta.ToLongDateString() }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
	}
```

<a id="f-054"></a>

## FrmRepFaltas


### FrmRepFaltas · líneas 1136–1142

[Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1136](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1136)

```csharp
public FrmRepFaltas()
	{
		base.Load += FrmRepPermiso_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmRepPermiso_Load · líneas 1787–1794

[Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs:1787](../../Software/RecursosHumanos/RecursosHumanos/FrmRepFaltas.cs#L1787)

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

<a id="f-055"></a>

## FrmRepPermisoDispl


### FrmRepPermisoDispl · líneas 1136–1142

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1136](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1136)

```csharp
public FrmRepPermisoDispl()
	{
		base.Load += FrmRepPermisoDispl_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmRepPermisoDispl_Load · líneas 1765–1783

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs:1765](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisoDispl.cs#L1765)

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

<a id="f-056"></a>

## FrmRepPermisos


### FrmRepPermisos · líneas 421–427

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:421](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L421)

```csharp
public FrmRepPermisos()
	{
		base.Load += FrmRepPermisos_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### Button1_Click · líneas 758–795

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:758](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L758)

```csharp
private void Button1_Click(object sender, EventArgs e)
	{
		int? tipopermiso;
		int? num = default(int?);
		if (Operators.ConditionalCompareObjectEqual(UcCmbTipoPermiso.SelectedValue, 0, TextCompare: false))
		{
			tipopermiso = null;
		}
		else
		{
			object selectedValue = UcCmbTipoPermiso.SelectedValue;
			tipopermiso = ((selectedValue != null) ? ((int?)selectedValue) : num);
		}
		int? motivo;
		if (Operators.ConditionalCompareObjectEqual(UcCmbMotivo.SelectedValue, 0, TextCompare: false))
		{
			motivo = null;
		}
		else
		{
			object selectedValue2 = UcCmbMotivo.SelectedValue;
			motivo = ((selectedValue2 != null) ? ((int?)selectedValue2) : num);
		}
		string fechaI = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year, Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year, Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 1);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, 2);
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			GridControl1.DataSource = objRRHHClass.spRRHH_RepPermisos(fechaI, fechaF, tipopermiso, motivo, num);
		}
	}
```

### FrmRepPermisos_Load · líneas 797–808

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:797](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L797)

```csharp
private void FrmRepPermisos_Load(object sender, EventArgs e)
	{
		UcCmbTipoPermiso.ValueMember = "idTipoPermiso";
		UcCmbTipoPermiso.DisplayMember = "DescripTipoPermiso";
		List<TipoPermiso> list = TipoPermisoMapper.Instance().SelectAll();
		list.Insert(0, new TipoPermiso
		{
			idTipoPermiso = 0,
			DescripTipoPermiso = "-- SELECCIONAR --"
		});
		UcCmbTipoPermiso.DataSource = list;
	}
```

### UcCmbTipoPermiso_SelectedIndexChanged · líneas 810–844

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:810](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L810)

```csharp
private void UcCmbTipoPermiso_SelectedIndexChanged(object sender, EventArgs e)
	{
		UcCmbMotivo.ValueMember = "idMotivo";
		UcCmbMotivo.DisplayMember = "Descrip_Motivo";
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			List<Motivo_Perm> list = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)m.TipoModalidad), "P", TextCompare: false) == 0)));
			list.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			List<Motivo_Perm> list2 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false), Operators.CompareString(Conversions.ToString((char)m.TipoModalidad), "C", TextCompare: false) == 0)));
			list2.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list2;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			List<Motivo_Perm> list3 = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm m) => Operators.ConditionalCompareObjectEqual(m.idTipoPermiso, UcCmbTipoPermiso.SelectedValue, TextCompare: false));
			list3.Insert(0, new Motivo_Perm
			{
				idMotivo = 0,
				Descrip_Motivo = "-- SELECCIONAR --"
			});
			UcCmbMotivo.DataSource = list3;
		}
	}
```

### Button2_Click · líneas 846–940

[Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs:846](../../Software/RecursosHumanos/RecursosHumanos/FrmRepPermisos.cs#L846)

```csharp
private void Button2_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_Permisos" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_Permisos";
		GridControl1.ExportToXls(text2, xlsExportOptions);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
		object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue3, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		object[] array3 = new object[2] { "A2", null };
		object[] array4 = array3;
		object obj2 = objectValue3;
		object instance2 = obj2;
		array = new object[2];
		object[] array5 = array;
		int num = 2;
		array5[0] = num;
		object[] array6 = array;
		checked
		{
			int num2 = GridView1.Columns.Count - 1;
			array6[1] = num2;
			array4[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "Cells", array, null, null, null));
			object[] array7 = array3;
			object[] arguments2 = array7;
			array2 = new bool[2] { false, true };
			object instance3 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments2, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array7[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance3, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de Permisos" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			array7 = new object[2] { "A3", null };
			object[] array8 = array7;
			obj2 = objectValue3;
			object instance4 = obj2;
			object[] array9 = new object[2];
			object[] array10 = array9;
			num = 3;
			array10[0] = num;
			object[] array11 = array9;
			num2 = GridView1.Columns.Count - 1;
			array11[1] = num2;
			array8[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array9, null, null, null));
			array = array7;
			object[] arguments3 = array;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(objectValue3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(objectValue3, null, "Protect", new object[16]
			{
				"[CLAVE DE PROTECCIÓN OCULTA]", false, true, false, false, true, true, true, false, false,
				false, false, false, true, true, true
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSet(objectValue, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

<a id="f-057"></a>

## FrmReportCuadro


### FrmReportCuadro · líneas 1131–1137

[Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs:1131](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs#L1131)

```csharp
public FrmReportCuadro()
	{
		base.Load += FrmReportCuadro_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReportCuadro_Load · líneas 1756–1764

[Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs:1756](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCuadro.cs#L1756)

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

<a id="f-058"></a>

## FrmReportCumple


### FrmReportCumple · líneas 1143–1149

[Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1143](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1143)

```csharp
public FrmReportCumple()
	{
		base.Load += FrmReportCumple_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReportCumple_Load · líneas 1775–1792

[Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1775](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1775)

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

### PrintControl1_Load · líneas 1794–1796

[Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs:1794](../../Software/RecursosHumanos/RecursosHumanos/FrmReportCumple.cs#L1794)

```csharp
private void PrintControl1_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-059"></a>

## FrmReportFicha


### FrmReportFicha · líneas 1131–1137

[Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1131](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1131)

```csharp
public FrmReportFicha()
	{
		base.Load += FrmReportFicha_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReportFicha_Load · líneas 1760–1778

[Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs:1760](../../Software/RecursosHumanos/RecursosHumanos/FrmReportFicha.cs#L1760)

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

<a id="f-060"></a>

## FrmReport_Cargos


### FrmReport_Cargos · líneas 1204–1210

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1204](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1204)

```csharp
public FrmReport_Cargos()
	{
		base.Load += FrmReport_Cargos_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReport_Cargos_Load · líneas 1930–1936

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1930](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1930)

```csharp
private void FrmReport_Cargos_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		CheckedListBoxControl1.DataSource = CargoMapper.Instance().SelectAll();
		CheckedListBoxControl1.ValueMember = "IdCargo";
		CheckedListBoxControl1.DisplayMember = "Cargo";
	}
```

### Button1_Click · líneas 1938–1967

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1938](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1938)

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

### PrintPreviewBarItem22_ItemClick · líneas 1969–1971

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs:1969](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Cargos.cs#L1969)

```csharp
private void PrintPreviewBarItem22_ItemClick(object sender, ItemClickEventArgs e)
	{
	}
```

<a id="f-061"></a>

## FrmReport_Empleado_Ingre


### FrmReport_Empleado_Ingre · líneas 1135–1141

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1135](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1135)

```csharp
public FrmReport_Empleado_Ingre()
	{
		base.Load += FrmReport_Empleado_Ingre_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReport_Empleado_Ingre_Load · líneas 1765–1773

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs:1765](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Empleado_Ingre.cs#L1765)

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

<a id="f-062"></a>

## FrmReport_Selc_Oficina


### FrmReport_Selc_Oficina · líneas 218–224

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:218](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L218)

```csharp
public FrmReport_Selc_Oficina()
	{
		base.Load += FrmReport_Selc_Oficina_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReport_Selc_Oficina_Load · líneas 425–431

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:425](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L425)

```csharp
private void FrmReport_Selc_Oficina_Load(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
		TreeList1.DataSource = RuntimeHelpers.GetObjectValue(objClassRRHH.llena_tree_reporte());
		TreeList1.ParentFieldName = "Hijo";
		TreeList1.KeyFieldName = "Padre";
	}
```

### BtnGenerar_Click · líneas 433–465

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:433](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L433)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		string text;
		int opcion;
		if (CheckEdit1.Checked)
		{
			text = Conversions.ToString(TreeList1.FocusedNode.GetValue("siglafull"));
			opcion = 1;
		}
		else
		{
			text = Conversions.ToString(TreeList1.FocusedNode.GetValue("Padre"));
			opcion = 2;
			List<Empleado> list = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado v) => (double)v.idAreaOrganiz == Conversions.ToDouble(text));
			if (list.Count <= 0)
			{
				MessageBox.Show("No existen Trabajadores Registrados para esta Area", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}
		if (Operators.CompareString(text, "0", TextCompare: false) == 0 || text == null)
		{
			MessageBox.Show("Debe seleccionar una Oficina por lo menos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		FrmReport_Selec_Oficina frmReport_Selec_Oficina = new FrmReport_Selec_Oficina();
		frmReport_Selec_Oficina.opcion = opcion;
		frmReport_Selec_Oficina.Var = text;
		frmReport_Selec_Oficina.WindowState = FormWindowState.Maximized;
		frmReport_Selec_Oficina.MdiParent = MyProject.Forms.MainMDI;
		frmReport_Selec_Oficina.Show();
		Close();
	}
```

### BtnCerrar_Click · líneas 467–470

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:467](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L467)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### TreeList1_FocusedNodeChanged · líneas 472–475

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs:472](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selc_Oficina.cs#L472)

```csharp
private void TreeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
	{
		lbl_area.Text = TreeList1.FocusedNode.GetValue("AreaOrganizacional").ToString();
	}
```

<a id="f-063"></a>

## FrmReport_SelecMes


### FrmReport_SelecMes · líneas 103–109

[Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs:103](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs#L103)

```csharp
[DebuggerNonUserCode]
	public FrmReport_SelecMes()
	{
		base.Load += FrmReport_SelecMes_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 275–290

[Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs:275](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs#L275)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		FrmReportCumple frmReportCumple = new FrmReportCumple();
		frmReportCumple.mes = Conversions.ToInteger(UcCboMes1.SelectedValue);
		if (CheckEdit1.Checked)
		{
			frmReportCumple.mostedad = true;
		}
		else
		{
			frmReportCumple.mostedad = false;
		}
		frmReportCumple.WindowState = FormWindowState.Maximized;
		frmReportCumple.Show();
		Close();
	}
```

### FrmReport_SelecMes_Load · líneas 292–295

[Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs:292](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_SelecMes.cs#L292)

```csharp
private void FrmReport_SelecMes_Load(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
	}
```

<a id="f-064"></a>

## FrmReport_Selec_Fechas


### FrmReport_Selec_Fechas · líneas 107–113

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs:107](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs#L107)

```csharp
public FrmReport_Selec_Fechas()
	{
		base.Load += FrmReport_Selec_Fechas_Load;
		__ENCAddToList(this);
		objReport_Empleado_Ingre = new FrmReport_Empleado_Ingre();
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 276–361

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs:276](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs#L276)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
		DateTime date = UcFechas1.Rango.Desde.Date;
		DateTime date2 = UcFechas1.Rango.Hasta.Date;
		if (DateTime.Compare(date2, date) < 0)
		{
			MessageBox.Show("La Fecha de Termino no puede ser menor que la de Inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
			return;
		}
		List<Empleado> list = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado v) =>
		{
			DateTime t = date;
			DateTime? fechaIngreso = v.FechaIngreso;
			bool? obj;
			if (!fechaIngreso.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = DateTime.Compare(fechaIngreso.GetValueOrDefault(), t) >= 0;
				obj = flag;
			}
			bool? flag2 = obj;
			DateTime t2 = date2;
			DateTime? fechaIngreso2 = v.FechaIngreso;
			bool? obj2;
			if (!fechaIngreso2.HasValue)
			{
				obj2 = null;
			}
			else
			{
				bool? flag3 = DateTime.Compare(fechaIngreso2.GetValueOrDefault(), t2) <= 0;
				obj2 = flag3;
			}
			bool? flag4 = obj2;
			bool? obj3;
			if (flag2 ?? true)
			{
				if (!flag4.HasValue)
				{
					obj3 = null;
				}
				else if (flag4 != true)
				{
					bool? flag5 = false;
					obj3 = flag5;
				}
				else
				{
					obj3 = flag2;
				}
			}
			else
			{
				bool? flag6 = false;
				obj3 = flag6;
			}
			bool? flag7 = obj3;
			bool? flag9;
			if (!v.FechaIngreso.HasValue)
			{
				bool? flag8 = false;
				flag9 = flag8;
			}
			else
			{
				flag9 = flag7;
			}
			return (bool)flag9;
		}).ToList();
		if (list.Count <= 0)
		{
			MessageBox.Show("No existen Trabajadores, registrados entre esas Fechas", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
			return;
		}
		objReport_Empleado_Ingre.fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(date.Year.ToString(), Interaction.IIf(date.Month.ToString().Length == 1, "0" + date.Month, date.Month.ToString())), Interaction.IIf(date.Day.ToString().Length == 1, "0" + date.Day, date.Day.ToString())));
		objReport_Empleado_Ingre.ft = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(date2.Year.ToString(), Interaction.IIf(date2.Month.ToString().Length == 1, "0" + date2.Month, date2.Month.ToString())), Interaction.IIf(date2.Day.ToString().Length == 1, "0" + date2.Day, date2.Day.ToString())));
		objReport_Empleado_Ingre.tipo = Conversions.ToInteger(UcCmBPresupuestal.SelectedValue);
		objReport_Empleado_Ingre.WindowState = FormWindowState.Maximized;
		objReport_Empleado_Ingre.MdiParent = MyProject.Forms.MainMDI;
		objReport_Empleado_Ingre.Show();
		Close();
	}
```

### FrmReport_Selec_Fechas_Load · líneas 363–369

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs:363](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Fechas.cs#L363)

```csharp
private void FrmReport_Selec_Fechas_Load(object sender, EventArgs e)
	{
		UcCmBPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCmBPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
		UcCmBPresupuestal.DataSource = dataSource;
	}
```

<a id="f-065"></a>

## FrmReport_Selec_Oficina


### FrmReport_Selec_Oficina · líneas 1142–1148

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1142](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1142)

```csharp
public FrmReport_Selec_Oficina()
	{
		base.Load += Form1_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### Form1_Load · líneas 1771–1786

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1771](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1771)

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

### PrintControl1_Load · líneas 1788–1790

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs:1788](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Oficina.cs#L1788)

```csharp
private void PrintControl1_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-066"></a>

## FrmReport_Selec_Pliego


### FrmReport_Selec_Pliego · líneas 85–91

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs:85](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs#L85)

```csharp
[DebuggerNonUserCode]
	public FrmReport_Selec_Pliego()
	{
		base.Load += FrmReport_Selec_Pliego_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmReport_Selec_Pliego_Load · líneas 241–252

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs:241](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs#L241)

```csharp
private void FrmReport_Selec_Pliego_Load(object sender, EventArgs e)
	{
		UcCmBPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCmBPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "Todos"
		});
		UcCmBPresupuestal.DataSource = list;
	}
```

### BtnGenerar_Click · líneas 254–263

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs:254](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs#L254)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		int codPre = Conversions.ToInteger(UcCmBPresupuestal.SelectedValue);
		FrmReportCuadro frmReportCuadro = new FrmReportCuadro();
		frmReportCuadro.CodPre = codPre;
		frmReportCuadro.MdiParent = MyProject.Forms.MainMDI;
		frmReportCuadro.WindowState = FormWindowState.Maximized;
		frmReportCuadro.Show();
		Close();
	}
```

### BtnCerrar_Click · líneas 265–268

[Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs:265](../../Software/RecursosHumanos/RecursosHumanos/FrmReport_Selec_Pliego.cs#L265)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-067"></a>

## FrmReporteEstadistico


### FrmReporteEstadistico · líneas 327–333

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:327](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L327)

```csharp
public FrmReporteEstadistico()
	{
		base.Load += FrmReporteEstadistico_Load;
		__ENCAddToList(this);
		oRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReporteEstadistico_Load · líneas 577–620

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:577](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L577)

```csharp
private void FrmReporteEstadistico_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		listaPermiso = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm V) => Operators.CompareString(Conversions.ToString((char)V.TipoModalidad), "P", TextCompare: false) == 0);
		listaPermiso.Insert(0, new Motivo_Perm
		{
			idMotivo = 0,
			Descrip_Motivo = "TODOS"
		});
		ChckListLocal.ValueMember = "idMotivo";
		ChckListLocal.DisplayMember = "Descrip_Motivo";
		ChckListLocal.DataSource = listaPermiso;
		List<EstructOrganiz> list2 = EstructOrganizMapper.Instance().SelectBy([SpecialName] (EstructOrganiz V) => V.Year == DateAndTime.Today.Year);
		list2.Insert(0, new EstructOrganiz
		{
			idAreaOrganiz = 0,
			AreaOrganizacional = "TODOS"
		});
		ChckListUO.ValueMember = "idAreaOrganiz";
		ChckListUO.DisplayMember = "AreaOrganizacional";
		ChckListUO.DataSource = list2;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}
```

### llenarPermisos · líneas 622–633

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:622](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L622)

```csharp
private void llenarPermisos(string Tipo)
	{
		listaPermiso = Motivo_PermMapper.Instance().SelectBy([SpecialName] (Motivo_Perm V) => Operators.CompareString(Conversions.ToString((char)V.TipoModalidad), Tipo, TextCompare: false) == 0);
		listaPermiso.Insert(0, new Motivo_Perm
		{
			idMotivo = 0,
			Descrip_Motivo = "TODOS"
		});
		ChckListLocal.ValueMember = "idMotivo";
		ChckListLocal.DisplayMember = "Descrip_Motivo";
		ChckListLocal.DataSource = listaPermiso;
	}
```

### UcCBPartidaPresupuestal_SelectedIndexChanged · líneas 635–647

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:635](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L635)

```csharp
private void UcCBPartidaPresupuestal_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 1, TextCompare: false))
		{
			TipoTrabjador = Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue);
			llenarPermisos("P");
		}
		else if (Operators.ConditionalCompareObjectEqual(UcCBPartidaPresupuestal.SelectedValue, 2, TextCompare: false))
		{
			TipoTrabjador = Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue);
			llenarPermisos("C");
		}
	}
```

### ChckListLocal_ItemCheck · líneas 649–696

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:649](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L649)

```csharp
private void ChckListLocal_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListLocal.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListLocal.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListLocal.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListLocal.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListLocal.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListLocal.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}
```

### ChckListUO_ItemCheck · líneas 698–745

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:698](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L698)

```csharp
private void ChckListUO_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
	{
		if (e.Index != 0)
		{
			return;
		}
		checked
		{
			if (ChckListUO.GetItemCheckState(0) == CheckState.Checked)
			{
				int num = ChckListUO.ItemCount - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						ChckListUO.SetItemChecked(num2, value: true);
						num2++;
						continue;
					}
					break;
				}
			}
			else
			{
				if (ChckListUO.GetItemCheckState(0) != 0)
				{
					return;
				}
				int num5 = ChckListUO.ItemCount - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						ChckListUO.SetItemChecked(num6, value: false);
						num6++;
						continue;
					}
					break;
				}
			}
		}
	}
```

### GroupControl1_Paint · líneas 747–749

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:747](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L747)

```csharp
private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}
```

### BtnGenerar_Click · líneas 751–1191

[Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs:751](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteEstadistico.cs#L751)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "[";
		string text3 = "isnull([";
		List<int> list = new List<int>();
		checked
		{
			int num = ChckListLocal.ItemCount - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (ChckListLocal.GetItemCheckState(num2) == CheckState.Checked)
				{
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(ChckListLocal.GetItemValue(num2), ",")));
					list.Add(Conversions.ToInteger(ChckListLocal.GetItemValue(num2)));
					int num5 = listaPermiso.Count - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						if (ChckListLocal.GetItemValue(num2).Equals(listaPermiso[num6].idMotivo))
						{
							text2 = text2 + listaPermiso[num6].Abrev.Trim() + "] , [";
							text3 = text3 + listaPermiso[num6].Abrev.Trim() + "],0) , isnull([";
						}
						num6++;
					}
				}
				num2++;
			}
			if (text.Length > 0)
			{
				text = text.Substring(0, text.Length - 1);
				text2 = text2.Substring(0, text2.Length - 3);
				text3 = text3.Substring(0, text3.Length - 10);
				string text4 = "";
				int num8 = ChckListUO.ItemCount - 1;
				int num9 = 1;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					if (ChckListUO.GetItemCheckState(num9) == CheckState.Checked)
					{
						text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(ChckListUO.GetItemValue(num9), ",")));
					}
					num9++;
				}
				if (text4.Length > 0)
				{
					text4 = text4.Substring(0, text4.Length - 1);
					if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
					{
						MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
					ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
					Cursor = Cursors.WaitCursor;
					string text5 = "";
					object obj = null;
					try
					{
						text5 = "RPP" + Strings.Format(DateAndTime.Now, "ddMMyy") + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
						text5 = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + text5;
						FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
						BinaryWriter binaryWriter = new BinaryWriter(fileStream);
						binaryWriter.Write(Resources.ReportePorcentaje, 0, Resources.ReportePorcentaje.Length);
						binaryWriter.Close();
						fileStream.Close();
						obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
						object obj2 = obj;
						object instance = NewLateBinding.LateGet(obj2, null, "Workbooks", new object[0], null, null, null);
						object[] array = new object[1] { text5 };
						object[] arguments = array;
						bool[] array2 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
						if (array2[0])
						{
							text5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						object objectValue = RuntimeHelpers.GetObjectValue(obj3);
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ActiveSheet", new object[0], null, null, null));
						int num11 = 1;
						int num12 = ChckListUO.ItemCount - 1;
						int num13 = 1;
						while (true)
						{
							int num14 = num13;
							int num4 = num12;
							if (num14 > num4)
							{
								break;
							}
							if (ChckListUO.GetItemCheckState(num13) == CheckState.Checked)
							{
								GridControl3.DataSource = oRRHHClass.spRRHH_EstadisticaPermiso(Conversions.ToString(TipoTrabjador), fi, ff, text, text2, text3, Conversions.ToString(ChckListUO.GetItemValue(num13)));
								object instance2 = objectValue;
								object[] array3 = new object[1] { num11 };
								object[] arguments2 = array3;
								array2 = new bool[1] { true };
								object obj4 = NewLateBinding.LateGet(instance2, null, "Sheets", arguments2, null, null, array2);
								if (array2[0])
								{
									num11 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
								}
								objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
								objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ActiveSheet", new object[0], null, null, null));
								if (ChckListUO.GetItemText(num13).Length >= 30)
								{
									NewLateBinding.LateSet(objectValue2, null, "Name", new object[1] { ChckListUO.GetItemText(num13).Substring(0, 30).Trim() }, null, null);
								}
								else
								{
									NewLateBinding.LateSet(objectValue2, null, "Name", new object[1] { ChckListUO.GetItemText(num13).Trim() }, null, null);
								}
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2]
								{
									"B2",
									"PORCENTAJES DE LAS TARDANZAS Y PERMISOS DEL: " + UcFechas1.Rango.Desde.ToShortDateString() + " AL " + UcFechas1.Rango.Hasta.ToShortDateString()
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "B5", "Oficina: " }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2]
								{
									"C5",
									ChckListUO.GetItemText(num13).Trim()
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "B7", "N°" }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "C7", "Apellidos y Nombres" }, null, null);
								NewLateBinding.LateSet(objectValue2, null, "RANGE", new object[2] { "D7", "Minutos Tarde" }, null, null);
								int num15 = GridView3.Columns.Count - 1;
								int num16 = 6;
								while (true)
								{
									int num17 = num16;
									num4 = num15;
									if (num17 > num4)
									{
										break;
									}
									string text6 = GridView3.Columns[num16].Name.Trim();
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										7,
										num16 - 1,
										text6.Substring(3, text6.Length - 3)
									}, null, null);
									num16++;
								}
								int num18 = 8;
								int num19 = GridView3.Columns.Count - 1;
								int num20 = 0;
								while (true)
								{
									int num21 = num20;
									num4 = num19;
									if (num21 > num4)
									{
										break;
									}
									if (num20 == 0)
									{
										int num22 = GridView3.RowCount - 1;
										int num23 = 0;
										while (true)
										{
											int num24 = num23;
											num4 = num22;
											if (num24 > num4)
											{
												break;
											}
											NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
											{
												num18 + num23,
												2 + num20,
												num23 + 1
											}, null, null);
											object objectValue3 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num23, GridView3.Columns[num20]));
											if (unchecked(objectValue3 == DBNull.Value || objectValue3 == null) | (Operators.CompareString(objectValue3.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num23,
													3 + num20,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num23,
													3 + num20,
													objectValue3.ToString()
												}, null, null);
											}
											num23++;
										}
									}
									if (num20 == 3)
									{
										int num25 = GridView3.RowCount - 1;
										int num26 = 0;
										while (true)
										{
											int num27 = num26;
											num4 = num25;
											if (num27 > num4)
											{
												break;
											}
											object objectValue4 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num26, GridView3.Columns[num20]));
											if (unchecked(objectValue4 == DBNull.Value || objectValue4 == null) | (Operators.CompareString(objectValue4.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num26,
													1 + num20,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num26,
													1 + num20,
													objectValue4.ToString()
												}, null, null);
											}
											num26++;
										}
									}
									if (num20 >= 6)
									{
										int num28 = GridView3.RowCount - 1;
										int num29 = 0;
										while (true)
										{
											int num30 = num29;
											num4 = num28;
											if (num30 > num4)
											{
												break;
											}
											object objectValue5 = RuntimeHelpers.GetObjectValue(GridView3.GetRowCellValue(num29, GridView3.Columns[num20]));
											if (unchecked(objectValue5 == DBNull.Value || objectValue5 == null) | (Operators.CompareString(objectValue5.ToString(), string.Empty, TextCompare: false) == 0))
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num29,
													num20 - 1,
													"0"
												}, null, null);
											}
											else
											{
												NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
												{
													num18 + num29,
													num20 - 1,
													objectValue5.ToString()
												}, null, null);
											}
											num29++;
										}
									}
									num20++;
								}
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									6,
									GridView3.Columns.Count + 1,
									"Leyenda: "
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 1,
									"Motivo"
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 2,
									"Cantidad"
								}, null, null);
								NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
								{
									7,
									GridView3.Columns.Count + 3,
									"%"
								}, null, null);
								int num31 = list.Count - 1;
								int num32 = 0;
								while (true)
								{
									int num33 = num32;
									num4 = num31;
									if (num33 > num4)
									{
										break;
									}
									DataTable dataTable = new DataTable();
									dataTable = oRRHHClass.spRRHH_ResumenEstadisticaPermiso(fi, ff, list[num32], Convert.ToInt32(RuntimeHelpers.GetObjectValue(ChckListUO.GetItemValue(num13))));
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										9,
										dataTable.Rows[0][1].ToString()
									}, null, null);
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										10,
										dataTable.Rows[0][2].ToString()
									}, null, null);
									NewLateBinding.LateSet(objectValue2, null, "Cells", new object[3]
									{
										8 + num32,
										11,
										dataTable.Rows[0][3].ToString()
									}, null, null);
									dataTable = null;
									num32++;
								}
								int num34 = GridView3.Columns.Count - 1;
								int num35 = 6;
								while (true)
								{
									int num36 = num35;
									num4 = num34;
									if (num36 > num4)
									{
										break;
									}
									int num37 = ChckListLocal.ItemCount - 1;
									int num38 = 1;
									while (true)
									{
										int num39 = num38;
										num4 = num37;
										if (num39 > num4)
										{
											break;
										}
										if (ChckListLocal.GetItemCheckState(num38) == CheckState.Checked)
										{
										}
										num38++;
									}
									num35++;
								}
								num11++;
								object instance3 = NewLateBinding.LateGet(obj2, null, "Worksheets", new object[0], null, null, null);
								array3 = new object[1];
								object[] array4 = array3;
								object instance4 = obj2;
								array = new object[1];
								object[] array5 = array;
								int num40 = 1;
								array5[0] = num40;
								array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Worksheets", array, null, null, null));
								object[] array6 = array3;
								string[] argumentNames = new string[1] { "After" };
								array2 = new bool[1] { true };
								object obj5 = NewLateBinding.LateGet(instance3, null, "Add", array6, argumentNames, null, array2);
								if (array2[0])
								{
									NewLateBinding.LateSetComplex(instance4, null, "Worksheets", new object[2]
									{
										num40,
										RuntimeHelpers.GetObjectValue(array6[0])
									}, null, null, OptimisticSet: true, RValueBase: false);
								}
								objectValue2 = RuntimeHelpers.GetObjectValue(obj5);
							}
							num13++;
						}
						NewLateBinding.LateSet(obj, null, "Visible", new object[1] { true }, null, null);
						objectValue = null;
						objectValue2 = null;
						obj2 = null;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					finally
					{
						obj = null;
						Cursor = Cursors.Default;
					}
					int num41 = ChckListUO.ItemCount - 1;
					int num42 = 1;
					while (true)
					{
						int num43 = num42;
						int num4 = num41;
						if (num43 <= num4)
						{
							if (ChckListUO.GetItemCheckState(num42) == CheckState.Checked)
							{
								GridControl3.DataSource = oRRHHClass.spRRHH_EstadisticaPermiso(Conversions.ToString(TipoTrabjador), fi, ff, text, text2, text3, Conversions.ToString(ChckListUO.GetItemValue(num42)));
							}
							num42++;
							continue;
						}
						break;
					}
				}
				else
				{
					MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Debe Seleccionar un Lugar de Marcado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
```

<a id="f-068"></a>

## FrmReporteProfesion


### FrmReporteProfesion · líneas 1266–1272

[Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:1266](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L1266)

```csharp
public FrmReporteProfesion()
	{
		base.Load += FrmReporteProfesion_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
		InitializeComponent();
	}
```

### FrmReporteProfesion_Load · líneas 2000–2006

[Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:2000](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L2000)

```csharp
private void FrmReporteProfesion_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		CheckedListBoxControl1.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.ListarProfesiones());
		CheckedListBoxControl1.ValueMember = "profesion";
		CheckedListBoxControl1.DisplayMember = "profesion";
	}
```

### Button1_Click · líneas 2008–2040

[Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs:2008](../../Software/RecursosHumanos/RecursosHumanos/FrmReporteProfesion.cs#L2008)

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

<a id="f-069"></a>

## FrmResoluciones


### FrmResoluciones · líneas 186–192

[Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs:186](../../Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs#L186)

```csharp
public FrmResoluciones()
	{
		base.Load += FrmResoluciones_Load;
		__ENCAddToList(this);
		oResolucion = new Resolucion();
		InitializeComponent();
	}
```

### cmdCerrar_Click · líneas 403–406

[Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs:403](../../Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs#L403)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### FrmResoluciones_Load · líneas 408–420

[Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs:408](../../Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs#L408)

```csharp
private void FrmResoluciones_Load(object sender, EventArgs e)
	{
		UcCBTipoResolucion.ValueMember = "IdTipoResolucion";
		UcCBTipoResolucion.DisplayMember = "DescripTipoResolucion";
		UcCBTipoResolucion.DataSource = TipoResolucionMapper.Instance().SelectAll();
		if (idResolucion != 0)
		{
			Resolucion resolucion = ResolucionMapper.Instance().SelectOneBy([SpecialName] (Resolucion V) => (V.idEmpleado == codemple) & (V.idResolucion == idResolucion));
			UcCBTipoResolucion.SelectedValue = resolucion.idTipoResolucion;
			DateTimePicker1.Value = (DateTime)resolucion.FechaResolucion;
			UcTextBox1.Text = resolucion.NumeroResolucion;
		}
	}
```

### BtnGrabar_Click · líneas 422–449

[Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs:422](../../Software/RecursosHumanos/RecursosHumanos/FrmResoluciones.cs#L422)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		oResolucion.FechaResolucion = DateTimePicker1.Value;
		Resolucion resolucion = oResolucion;
		object selectedValue = UcCBTipoResolucion.SelectedValue;
		int? num = default(int?);
		resolucion.idTipoResolucion = ((selectedValue != null) ? ((int?)selectedValue) : num);
		if (UcTextBox1.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un Número de Resolución", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		oResolucion.NumeroResolucion = UcTextBox1.Text;
		oResolucion.idEmpleado = codemple;
		if (idResolucion == 0)
		{
			int count = ResolucionMapper.Instance().SelectBy([SpecialName] (Resolucion v) => v.idEmpleado == codemple).Count;
			int num2 = ((count == 0) ? 1 : checked(count + 1));
			oResolucion.idResolucion = num2;
			ResolucionMapper.Instance().Insert(oResolucion);
		}
		else
		{
			oResolucion.idResolucion = idResolucion;
			ResolucionMapper.Instance().Update(oResolucion);
		}
		DialogResult = DialogResult.OK;
	}
```

<a id="f-070"></a>

## FrmRotaciones


### FrmRotaciones · líneas 190–197

[Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs:190](../../Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs#L190)

```csharp
public FrmRotaciones()
	{
		base.Load += FrmRotaciones_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		oRotaciones = new Rotacion();
		InitializeComponent();
	}
```

### FrmRotaciones_Load · líneas 408–425

[Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs:408](../../Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs#L408)

```csharp
private void FrmRotaciones_Load(object sender, EventArgs e)
	{
		UcCBArea.ValueMember = "idAreaOrganiz";
		UcCBArea.DisplayMember = "AreaOrganizacional";
		DataTable dataTable = (DataTable)objClassRRHH.llena_Area();
		DataRow dataRow = dataTable.NewRow();
		dataRow["idAreaOrganiz"] = 0;
		dataRow["AreaOrganizacional"] = "(Seleccionar)";
		dataTable.Rows.InsertAt(dataRow, 0);
		UcCBArea.DataSource = dataTable;
		if (idRotacion != 0)
		{
			Rotacion rotacion = RotacionMapper.Instance().SelectOneBy([SpecialName] (Rotacion V) => (V.idEmpleado == idEmpleado) & (V.idRotacion == idRotacion));
			DateTimePicker1.Value = (DateTime)rotacion.FechaMemo;
			UcTextBox1.Text = rotacion.NroMemo;
			UcCBArea.SelectedValue = rotacion.idAreaOrganiz;
		}
	}
```

### btnGrabar_Click · líneas 427–455

[Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs:427](../../Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs#L427)

```csharp
private void btnGrabar_Click(object sender, EventArgs e)
	{
		oRotaciones.FechaMemo = DateTimePicker1.Value;
		if (UcTextBox1.TextLength == 0)
		{
			MessageBox.Show("Debe ingresar un numero de Memorandum ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		oRotaciones.NroMemo = UcTextBox1.Text.Trim();
		Rotacion rotacion = oRotaciones;
		object selectedValue = UcCBArea.SelectedValue;
		int? num = default(int?);
		rotacion.idAreaOrganiz = ((selectedValue != null) ? ((int?)selectedValue) : num);
		oRotaciones.Year = DateTime.Today.Year;
		oRotaciones.idEmpleado = idEmpleado;
		if (idRotacion == 0)
		{
			int count = RotacionMapper.Instance().SelectBy([SpecialName] (Rotacion v) => v.idEmpleado == idEmpleado).Count;
			int num2 = ((count == 0) ? 1 : checked(count + 1));
			oRotaciones.idRotacion = num2;
			RotacionMapper.Instance().Insert(oRotaciones);
		}
		else
		{
			oRotaciones.idRotacion = idRotacion;
			RotacionMapper.Instance().Update(oRotaciones);
		}
		DialogResult = DialogResult.OK;
	}
```

### cmdCerrar_Click · líneas 457–460

[Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs:457](../../Software/RecursosHumanos/RecursosHumanos/FrmRotaciones.cs#L457)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-071"></a>

## FrmSalida


### FrmSalida · líneas 365–371

[Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs:365](../../Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs#L365)

```csharp
[DebuggerNonUserCode]
	public FrmSalida()
	{
		base.Load += FrmSalida_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### FrmSalida_Load · líneas 778–780

[Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs:778](../../Software/RecursosHumanos/RecursosHumanos/FrmSalida.cs#L778)

```csharp
private void FrmSalida_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-072"></a>

## FrmSobreTiempo


### FrmSobreTiempo · líneas 279–286

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:279](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L279)

```csharp
public FrmSobreTiempo()
	{
		base.CloseForm += FrmSobreTiempo_CloseForm;
		base.Load += FrmSobreTiempo_Load;
		__ENCAddToList(this);
		obj = new RRHHClass();
		InitializeComponent();
	}
```

### BtnGenerar_Click · líneas 522–533

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:522](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L522)

```csharp
private void BtnGenerar_Click(object sender, EventArgs e)
	{
		if (DateTime.Compare(UcFechas1.Rango.Desde, UcFechas1.Rango.Hasta) > 0)
		{
			MessageBox.Show("La Fecha de Inicio no puede ser Mayor a la de Término", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		WindowState = FormWindowState.Maximized;
		fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		ff = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		GridControl1.DataSource = RuntimeHelpers.GetObjectValue(obj.spRRHH_ObtenerHorasExtras(fi, ff, Conversions.ToInteger(UcCBPartidaPresupuestal.SelectedValue.ToString())));
	}
```

### FrmSobreTiempo_CloseForm · líneas 535–545

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:535](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L535)

```csharp
private void FrmSobreTiempo_CloseForm(ref bool Cancelar)
	{
		if (objLibroExcel != null)
		{
			EiminaReferencias(ref objHojaExcel);
			EiminaReferencias(ref objLibroExcel);
			EiminaReferencias(ref m_Excel);
		}
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}
```

### FrmSobreTiempo_Load · líneas 547–572

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:547](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L547)

```csharp
private void FrmSobreTiempo_Load(object sender, EventArgs e)
	{
		UcCBPartidaPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCBPartidaPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> list = TipoTrabajadorMapper.Instance().SelectAll();
		list.Insert(0, new TipoTrabajador
		{
			IdTipoTrabajador = 0,
			Descripcion = "--SELECCIONAR--"
		});
		UcCBPartidaPresupuestal.DataSource = list;
		if (Conversions.ToDouble(RRHH.IdROl) == 10.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 1;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 14.0)
		{
			UcCBPartidaPresupuestal.SelectedValue = 2;
			UcCBPartidaPresupuestal.Enabled = false;
		}
		else if (Conversions.ToDouble(RRHH.IdROl) == 13.0)
		{
			UcCBPartidaPresupuestal.Enabled = true;
		}
	}
```

### EiminaReferencias · líneas 574–589

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:574](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L574)

```csharp
private void EiminaReferencias(ref object Referencias)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(Referencias));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Referencias = null;
		}
	}
```

### BtnExportarExcel_Click · líneas 591–724

[Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs:591](../../Software/RecursosHumanos/RecursosHumanos/FrmSobreTiempo.cs#L591)

```csharp
private void BtnExportarExcel_Click(object sender, EventArgs e)
	{
		if (GridView1.RowCount == 0)
		{
			MessageBox.Show("Debe existir como minimo, un registro para exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		XlsExportOptions xlsExportOptions = new XlsExportOptions();
		string text = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString();
		string text2 = text + "\\Reporte_AutoGenerado_SobreTiempo" + Conversions.ToString(DateAndTime.Today.Date.Day) + Conversions.ToString(DateAndTime.Today.Date.Month) + Conversions.ToString(DateAndTime.Today.Date.Year) + DateAndTime.Now.Hour + Conversions.ToString(DateAndTime.Now.Minute) + DateAndTime.Now.Second + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
		xlsExportOptions.SheetName = "Reporte_AutoGenerado_SobreTiempo_" + fi + "_" + ff;
		GridControl1.ExportToXls(text2, xlsExportOptions);
		if (!MyProject.Computer.FileSystem.FileExists(text2))
		{
			Interaction.MsgBox(text2 + " No Existe");
			return;
		}
		m_Excel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
		object instance = NewLateBinding.LateGet(m_Excel, null, "Workbooks", new object[0], null, null, null);
		object[] array = new object[1] { text2 };
		object[] arguments = array;
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(instance, null, "Open", arguments, null, null, array2);
		if (array2[0])
		{
			text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		objLibroExcel = RuntimeHelpers.GetObjectValue(obj);
		objHojaExcel = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objLibroExcel, null, "Worksheets", new object[1] { 1 }, null, null, null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "1:5" }, null, null, null), null, "insert", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objHojaExcel, null, "Select", new object[0], null, null, null, IgnoreReturn: true);
		if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.RutaLogo))
		{
			object instance2 = NewLateBinding.LateGet(objHojaExcel, null, "Shapes", new object[0], null, null, null);
			array = new object[7];
			object[] array3 = array;
			MySettings settings = MySettingsProperty.Settings;
			array3[0] = settings.RutaLogo;
			array[1] = MsoTriState.msoFalse;
			array[2] = MsoTriState.msoCTrue;
			array[3] = 5;
			array[4] = 5;
			array[5] = 50;
			array[6] = 50;
			object[] array4 = array;
			object[] arguments2 = array4;
			array2 = new bool[7] { true, false, false, false, false, false, false };
			NewLateBinding.LateCall(instance2, null, "AddPicture", arguments2, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				settings.RutaLogo = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "RowHeight", new object[1] { 48 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "6:6" }, null, null, null), null, "Orientation", new object[1] { 90 }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
		checked
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "Orientation", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2]
			{
				6,
				GridView1.Columns.Count - 1
			}, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 6, 1 }, null, null, null), null, "VerticalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance3 = objHojaExcel;
			object[] array4 = new object[2] { "A2", null };
			object[] array5 = array4;
			object obj2 = objHojaExcel;
			object instance4 = obj2;
			array = new object[2];
			object[] array6 = array;
			int num = 2;
			array6[0] = num;
			object[] array7 = array;
			int num2 = GridView1.Columns.Count - 1;
			array7[1] = num2;
			array5[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
			object[] array8 = array4;
			object[] arguments3 = array8;
			array2 = new bool[2] { false, true };
			object instance5 = NewLateBinding.LateGet(instance3, null, "Range", arguments3, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array8[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance5, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Reporte de SobreTiempo" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 2, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Rows", new object[1] { "2:2" }, null, null, null), null, "Font", new object[0], null, null, null), null, "Size", new object[1] { 16 }, null, null, OptimisticSet: false, RValueBase: true);
			object instance6 = objHojaExcel;
			array8 = new object[2] { "A3", null };
			object[] array9 = array8;
			obj2 = objHojaExcel;
			object instance7 = obj2;
			object[] array10 = new object[2];
			object[] array11 = array10;
			num = 3;
			array11[0] = num;
			object[] array12 = array10;
			num2 = GridView1.Columns.Count - 1;
			array12[1] = num2;
			array9[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance7, null, "Cells", array10, null, null, null));
			array = array8;
			object[] arguments4 = array;
			array2 = new bool[2] { false, true };
			object instance8 = NewLateBinding.LateGet(instance6, null, "Range", arguments4, null, null, array2);
			if (array2[1])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
				{
					num,
					num2,
					RuntimeHelpers.GetObjectValue(array[1])
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(instance8, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "FormulaR1C1", new object[1] { "Del: " + Conversions.ToString(UcFechas1.Rango.Desde) + " al " + Conversions.ToString(UcFechas1.Rango.Hasta) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "Cells", new object[2] { 3, 1 }, null, null, null), null, "HorizontalAlignment", new object[1] { -4108 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(objHojaExcel, null, "Columns", new object[1] { "A:Z" }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "Orientation", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objHojaExcel, null, "PageSetup", new object[0], null, null, null), null, "PrintTitleRows", new object[1] { "$1:$6" }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSet(m_Excel, null, "Visible", new object[1] { true }, null, null);
		}
	}
```

<a id="f-073"></a>

## FrmSuspenderAsistencia


### FrmSuspenderAsistencia · líneas 314–321

[Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs:314](../../Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs#L314)

```csharp
public FrmSuspenderAsistencia()
	{
		base.Load += FrmSuspenderAsistencia_Load;
		__ENCAddToList(this);
		img = null;
		objClassRRHH = new RRHHClass();
		InitializeComponent();
	}
```

### FrmSuspenderAsistencia_Load · líneas 643–672

[Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs:643](../../Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs#L643)

```csharp
private void FrmSuspenderAsistencia_Load(object sender, EventArgs e)
	{
		DataTable dataTable = objClassRRHH.BuscarEmpleado_Codigo(idEmpleado);
		if (dataTable.Rows.Count != 1)
		{
			return;
		}
		foreach (object row in dataTable.Rows)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(row);
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null).ToString().Length > 0)
			{
				img = (byte[])NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Foto" }, null, null, null);
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(img, 0, checked(img.GetUpperBound(0) + 1));
				UcFoto.Image = Image.FromStream(memoryStream);
				memoryStream.Close();
			}
			UcTxtNombres.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Nombres" }, null, null, null).ToString();
			UcTxtApePater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Paterno" }, null, null, null).ToString();
			UcTxtApeMater.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "Apellido_Materno" }, null, null, null).ToString();
			UcTxtNDoc.Text = NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "NumDocID" }, null, null, null).ToString();
			if (NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null) == null)
			{
				MessageBox.Show("Primero debe asignar un Horario al trabajador", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			}
			idHorario = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { "idHorario" }, null, null, null));
		}
	}
```

### BtnGrabar_Click · líneas 674–685

[Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs:674](../../Software/RecursosHumanos/RecursosHumanos/FrmSuspenderAsistencia.cs#L674)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Esta seguro de aplicar la Suspención?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
			string fecha = Conversions.ToString(Operators.AddObject(Operators.AddObject(DateTimePicker1.Value.Year.ToString(), Interaction.IIf(DateTimePicker1.Value.Month.ToString().Length == 1, "0" + DateTimePicker1.Value.Month, DateTimePicker1.Value.Month.ToString())), Interaction.IIf(DateTimePicker1.Value.Day.ToString().Length == 1, "0" + DateTimePicker1.Value.Day, DateTimePicker1.Value.Day.ToString())));
			if (Conversions.ToBoolean(Operators.NotObject(asistenciaAccess.Grabar_suspencion(UcTxtNDoc.Text, fecha))))
			{
				MessageBox.Show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
```

<a id="f-074"></a>

## FrmTitulos


### FrmTitulos · líneas 222–228

[Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs:222](../../Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs#L222)

```csharp
public FrmTitulos()
	{
		base.Load += FrmTitulos_Load;
		__ENCAddToList(this);
		TituloEmpleado = new TitulosEmpleado();
		InitializeComponent();
	}
```

### BtnGrabar_Click · líneas 504–540

[Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs:504](../../Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs#L504)

```csharp
private void BtnGrabar_Click(object sender, EventArgs e)
	{
		TituloEmpleado.IdEmpleado = CodEmple;
		TituloEmpleado.Fecha = UcDTFecha.Value;
		List<TitulosEmpleado> list = TitulosEmpleadoMapper.Instance().SelectAll();
		if (list.Count > 0)
		{
			foreach (TitulosEmpleado item in list)
			{
				if (Operators.CompareString(UcTxtColegiatura.Text, item.NumColegiatura, TextCompare: false) == 0)
				{
					MessageBox.Show("Ya esta registrado ese Nº de Colegiatura en el Empleado: " + item.Empleado.Persona.Apellido_Paterno + " " + item.Empleado.Persona.Apellido_Materno + " " + item.Empleado.Persona.Nombres + " , Por favor Verifique ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
		}
		if (UcTxtColegiatura.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar Un numero de Colegiatura", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.NumColegiatura = UcTxtColegiatura.Text;
		if (UcTxtDenoTitulo.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar una Denominación del Grado y/o Titulo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.DenominacionGrado = UcTxtDenoTitulo.Text;
		if (UcTxtInstitucion.TextLength == 0)
		{
			MessageBox.Show("Debe Ingresar el Nombre de la Institución", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		TituloEmpleado.Institucion = UcTxtInstitucion.Text;
		TitulosEmpleadoMapper.Instance().Insert(TituloEmpleado);
		DialogResult = DialogResult.OK;
	}
```

### BtnCerrar_Click · líneas 542–545

[Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs:542](../../Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs#L542)

```csharp
private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### FrmTitulos_Load · líneas 547–549

[Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs:547](../../Software/RecursosHumanos/RecursosHumanos/FrmTitulos.cs#L547)

```csharp
private void FrmTitulos_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-075"></a>

## MainMDI


### MainMDI · líneas 1649–1656

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:1649](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L1649)

```csharp
[DebuggerNonUserCode]
	public MainMDI()
	{
		base.FormClosing += MainMDI_FormClosing;
		base.Load += MainMDI_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}
```

### PersonalToolStripMenuItem_Click · líneas 2179–2192

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2179](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2179)

```csharp
private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objListaOrganica == null || (objListaOrganica.IsDisposed ? true : false))
		{
			objListaOrganica = new FrmListaOrganica();
		}
		else
		{
			objListaOrganica.BringToFront();
		}
		objListaOrganica.MdiParent = this;
		objListaOrganica.WindowState = FormWindowState.Maximized;
		objListaOrganica.Show();
	}
```

### SalirToolStripMenuItem_Click · líneas 2194–2197

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2194](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2194)

```csharp
private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### MainMDI_FormClosing · líneas 2199–2205

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2199](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2199)

```csharp
private void MainMDI_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (MessageBox.Show("Esta seguro de Salir del Sistema?", "Salir Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			e.Cancel = true;
		}
	}
```

### MainMDI_Load · líneas 2207–2278

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2207](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2207)

```csharp
private void MainMDI_Load(object sender, EventArgs e)
	{
		FrmLogin frmLogin = new FrmLogin();
		frmLogin.ShowDialog(this);
		if (frmLogin.DialogResult == DialogResult.OK)
		{
			// El nombre ya fue obtenido mediante PostgreSQL durante el login.
			TSSL_Usuario.Text = frmLogin.EmployeeDisplayName;
		}
		else
		{
			Close();
		}
		if ((RRHH.Bienestar && RRHH.Bienestar) ? true : false)
		{
			MantenimientosToolStripMenuItem1.Visible = false;
			ToolStripButton5.Visible = false;
			ToolStripButton7.Visible = false;
			ToolStripButton10.Visible = false;
			MantenimientosToolStripMenuItem.Visible = false;
			RegistroNuevoToolStripMenuItem.Visible = false;
			ToolStripSeparator1.Visible = false;
			ToolStripSeparator4.Visible = false;
			HorariosToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = false;
			ImportacionToolStripMenuItem.Visible = false;
			AsignarHorariosToolStripMenuItem1.Visible = false;
			ToolStripButton6.Visible = false;
			ImportarAsistenciasPROINDToolStripMenuItem.Visible = false;
		}
		else if ((RRHH.Partida == 1) | (RRHH.Partida == 2))
		{
			ToolStripButton5.Visible = false;
			ToolStripButton7.Visible = false;
			ToolStripButton10.Visible = false;
			ToolStripSeparator4.Visible = false;
			MotivoDePermisoToolStripMenuItem.Visible = false;
			FeriadosToolStripMenuItem1.Visible = false;
			TipoDePermisoToolStripMenuItem.Visible = false;
			AsistenciaDiaToolStripMenuItem.Visible = false;
			PermisosToolStripMenuItem.Visible = false;
			FaltasToolStripMenuItem.Visible = false;
			AsistenciasToolStripMenuItem.Visible = false;
			HorariosToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = false;
			ImportacionToolStripMenuItem.Visible = false;
			AsignarHorariosToolStripMenuItem1.Visible = false;
			ImportarAsistenciasPROINDToolStripMenuItem.Visible = false;
		}
		else if ((RRHH.Asistencias && RRHH.Asistencias) ? true : false)
		{
			ImportacionToolStripMenuItem.Visible = true;
			RegistroNuevoToolStripMenuItem.Visible = false;
			ToolStripSeparator1.Visible = false;
			CargosToolStripMenuItem.Visible = false;
			GruposSanguineosToolStripMenuItem.Visible = false;
			CondicionLaboralToolStripMenuItem.Visible = false;
			NacionalidadesToolStripMenuItem.Visible = false;
			RegimenDePensioneToolStripMenuItem.Visible = false;
			EstadoCivilToolStripMenuItem.Visible = false;
			TipoDeInstituciónToolStripMenuItem.Visible = false;
			TipoDeDocumentoIdentidadToolStripMenuItem.Visible = false;
			TipoEstudiosToolStripMenuItem.Visible = false;
			TipoDocFilePersonalToolStripMenuItem.Visible = false;
			CargosToolStripMenuItem1.Visible = false;
			PersonalPorFechaDeIngresoToolStripMenuItem.Visible = false;
			PersonalPorOficinaToolStripMenuItem.Visible = false;
			CumpleañosToolStripMenuItem.Visible = false;
			ListaPersonalToolStripMenuItem.Visible = false;
			RecordAsistenciasSemanalesToolStripMenuItem.Visible = true;
		}
	}
```

### ListaPersonalToolStripMenuItem_Click · líneas 2280–2293

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2280](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2280)

```csharp
private void ListaPersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFicha == null || (ObjFicha.IsDisposed ? true : false))
		{
			ObjFicha = new FrmReport_Selec_Pliego();
		}
		else
		{
			ObjFicha.BringToFront();
		}
		ObjFicha.MdiParent = this;
		ObjFicha.StartPosition = FormStartPosition.CenterParent;
		ObjFicha.Show();
	}
```

### CargosToolStripMenuItem_Click · líneas 2295–2307

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2295](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2295)

```csharp
private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantCargo == null || (ObjMantCargo.IsDisposed ? true : false))
		{
			ObjMantCargo = CompositionRoot.CrearCatalogo<FrmMantCargos>(TipoCatalogo.Cargo);
		}
		else
		{
			ObjMantCargo.BringToFront();
		}
		ObjMantCargo.MdiParent = this;
		ObjMantCargo.Show();
	}
```

### GruposSanguineosToolStripMenuItem_Click · líneas 2309–2321

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2309](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2309)

```csharp
private void GruposSanguineosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantGrupoSangrineo == null || (ObjMantGrupoSangrineo.IsDisposed ? true : false))
		{
			ObjMantGrupoSangrineo = CompositionRoot.CrearCatalogo<FrmMantGrupoSanguineo>(TipoCatalogo.GrupoSanguineo);
		}
		else
		{
			ObjMantGrupoSangrineo.BringToFront();
		}
		ObjMantGrupoSangrineo.MdiParent = this;
		ObjMantGrupoSangrineo.Show();
	}
```

### CondicionLaboralToolStripMenuItem_Click · líneas 2323–2335

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2323](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2323)

```csharp
private void CondicionLaboralToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantTipoTrab == null || (ObjMantTipoTrab.IsDisposed ? true : false))
		{
			ObjMantTipoTrab = CompositionRoot.CrearCatalogo<FrmMantTipoTrab>(TipoCatalogo.TipoTrabajador);
		}
		else
		{
			ObjMantTipoTrab.BringToFront();
		}
		ObjMantTipoTrab.MdiParent = this;
		ObjMantTipoTrab.Show();
	}
```

### RegimenDePensioneToolStripMenuItem_Click · líneas 2337–2349

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2337](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2337)

```csharp
private void RegimenDePensioneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantRegimen == null || (ObjMantRegimen.IsDisposed ? true : false))
		{
			ObjMantRegimen = CompositionRoot.CrearCatalogo<FrmMantRegimen>(TipoCatalogo.RegimenPension);
		}
		else
		{
			ObjMantRegimen.BringToFront();
		}
		ObjMantRegimen.MdiParent = this;
		ObjMantRegimen.Show();
	}
```

### NacionalidadesToolStripMenuItem_Click · líneas 2351–2363

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2351](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2351)

```csharp
private void NacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantNacionalidad == null || (ObjMantNacionalidad.IsDisposed ? true : false))
		{
			ObjMantNacionalidad = CompositionRoot.CrearCatalogo<FrmMantNacionalidades>(TipoCatalogo.Nacionalidad);
		}
		else
		{
			ObjMantNacionalidad.BringToFront();
		}
		ObjMantNacionalidad.MdiParent = this;
		ObjMantNacionalidad.Show();
	}
```

### EstadoCivilToolStripMenuItem_Click · líneas 2365–2377

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2365](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2365)

```csharp
private void EstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantEstCivil == null || (ObjMantEstCivil.IsDisposed ? true : false))
		{
			ObjMantEstCivil = CompositionRoot.CrearCatalogo<FrmMantEstCivil>(TipoCatalogo.EstadoCivil);
		}
		else
		{
			ObjMantEstCivil.BringToFront();
		}
		ObjMantEstCivil.MdiParent = this;
		ObjMantEstCivil.Show();
	}
```

### TipoDeInstituciónToolStripMenuItem_Click · líneas 2379–2391

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2379](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2379)

```csharp
private void TipoDeInstituciónToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantTipoInst == null || (ObjMantTipoInst.IsDisposed ? true : false))
		{
			ObjMantTipoInst = CompositionRoot.CrearCatalogo<FrmMantTipoInst>(TipoCatalogo.TipoInstitucion);
		}
		else
		{
			ObjMantTipoInst.BringToFront();
		}
		ObjMantTipoInst.MdiParent = this;
		ObjMantTipoInst.Show();
	}
```

### TipoDeDocumentoIdentidadToolStripMenuItem_Click · líneas 2393–2405

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2393](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2393)

```csharp
private void TipoDeDocumentoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoDocIdent == null || (ObjFrmMantTipoDocIdent.IsDisposed ? true : false))
		{
			ObjFrmMantTipoDocIdent = CompositionRoot.CrearCatalogo<FrmMantTipoDocIdent>(TipoCatalogo.TipoDocumentoIdentidad);
		}
		else
		{
			ObjFrmMantTipoDocIdent.BringToFront();
		}
		ObjFrmMantTipoDocIdent.MdiParent = this;
		ObjFrmMantTipoDocIdent.Show();
	}
```

### TipoEstudiosToolStripMenuItem_Click · líneas 2407–2419

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2407](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2407)

```csharp
private void TipoEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoEstudio == null || (ObjFrmMantTipoEstudio.IsDisposed ? true : false))
		{
			ObjFrmMantTipoEstudio = CompositionRoot.CrearCatalogo<FrmMantTipoEstudio>(TipoCatalogo.TipoEstudio);
		}
		else
		{
			ObjFrmMantTipoEstudio.BringToFront();
		}
		ObjFrmMantTipoEstudio.MdiParent = this;
		ObjFrmMantTipoEstudio.Show();
	}
```

### BusquedaToolStripMenuItem_Click · líneas 2421–2433

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2421](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2421)

```csharp
private void BusquedaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmPersonal == null || (objFrmPersonal.IsDisposed ? true : false))
		{
			objFrmPersonal = new FrmBuscarPersona();
		}
		else
		{
			objFrmPersonal.BringToFront();
		}
		objFrmPersonal.MdiParent = this;
		objFrmPersonal.Show();
	}
```

### CumpleañosToolStripMenuItem_Click · líneas 2435–2448

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2435](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2435)

```csharp
private void CumpleañosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumplea == null || (objFrmReportCumplea.IsDisposed ? true : false))
		{
			objFrmReportCumplea = new FrmReport_SelecMes();
		}
		else
		{
			objFrmReportCumplea.BringToFront();
		}
		objFrmReportCumplea.MdiParent = this;
		objFrmReportCumplea.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumplea.Show();
	}
```

### PersonalPorOficinaToolStripMenuItem_Click · líneas 2450–2463

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2450](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2450)

```csharp
private void PersonalPorOficinaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumpleb == null || (objFrmReportCumpleb.IsDisposed ? true : false))
		{
			objFrmReportCumpleb = new FrmReport_Selc_Oficina();
		}
		else
		{
			objFrmReportCumpleb.BringToFront();
		}
		objFrmReportCumpleb.MdiParent = this;
		objFrmReportCumpleb.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumpleb.Show();
	}
```

### PersonalPorFechaDeIngresoToolStripMenuItem_Click · líneas 2465–2478

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2465](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2465)

```csharp
private void PersonalPorFechaDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objFrmReportCumple == null || (objFrmReportCumple.IsDisposed ? true : false))
		{
			objFrmReportCumple = new FrmReport_Selec_Fechas();
		}
		else
		{
			objFrmReportCumple.BringToFront();
		}
		objFrmReportCumple.MdiParent = this;
		objFrmReportCumple.StartPosition = FormStartPosition.CenterParent;
		objFrmReportCumple.Show();
	}
```

### ToolStripButton1_Click · líneas 2480–2493

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2480](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2480)

```csharp
private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		if (objListaOrganica == null || (objListaOrganica.IsDisposed ? true : false))
		{
			objListaOrganica = new FrmListaOrganica();
		}
		else
		{
			objListaOrganica.BringToFront();
		}
		objListaOrganica.MdiParent = this;
		objListaOrganica.WindowState = FormWindowState.Maximized;
		objListaOrganica.Show();
	}
```

### ToolStripButton2_Click · líneas 2495–2507

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2495](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2495)

```csharp
private void ToolStripButton2_Click(object sender, EventArgs e)
	{
		if (objFrmPersonal == null || (objFrmPersonal.IsDisposed ? true : false))
		{
			objFrmPersonal = new FrmBuscarPersona();
		}
		else
		{
			objFrmPersonal.BringToFront();
		}
		objFrmPersonal.MdiParent = this;
		objFrmPersonal.Show();
	}
```

### CargosToolStripMenuItem1_Click · líneas 2509–2522

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2509](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2509)

```csharp
private void CargosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (objFrmReportCargos == null || (objFrmReportCargos.IsDisposed ? true : false))
		{
			objFrmReportCargos = new FrmReport_Cargos();
		}
		else
		{
			objFrmReportCargos.BringToFront();
		}
		objFrmReportCargos.MdiParent = this;
		objFrmReportCargos.WindowState = FormWindowState.Maximized;
		objFrmReportCargos.Show();
	}
```

### ToolStripButton3_Click · líneas 2524–2527

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2524](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2524)

```csharp
private void ToolStripButton3_Click(object sender, EventArgs e)
	{
		Close();
	}
```

### RegistroNuevoToolStripMenuItem_Click · líneas 2529–2533

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2529](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2529)

```csharp
private void RegistroNuevoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		FrmMantEmpleado_Basico frmMantEmpleado_Basico = new FrmMantEmpleado_Basico();
		frmMantEmpleado_Basico.ShowDialog();
	}
```

### TipoDocFilePersonalToolStripMenuItem_Click · líneas 2535–2547

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2535](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2535)

```csharp
private void TipoDocFilePersonalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjMantFile == null || (ObjMantFile.IsDisposed ? true : false))
		{
			ObjMantFile = new FrmMantDocFile();
		}
		else
		{
			ObjMantFile.BringToFront();
		}
		ObjMantFile.MdiParent = this;
		ObjMantFile.Show();
	}
```

### AcercaDeToolStripMenuItem_Click · líneas 2549–2563

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2549](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2549)

```csharp
private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (objAcercaDe == null || (objAcercaDe.IsDisposed ? true : false))
		{
			objAcercaDe = new AcercaDe();
		}
		else
		{
			objAcercaDe.BringToFront();
		}
		objAcercaDe.MdiParent = this;
		objAcercaDe.WindowState = FormWindowState.Normal;
		objAcercaDe.StartPosition = FormStartPosition.CenterParent;
		objAcercaDe.Show();
	}
```

### PermisosToolStripMenuItem_Click · líneas 2565–2577

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2565](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2565)

```csharp
private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmPermiso == null || (oFrmPermiso.IsDisposed ? true : false))
		{
			oFrmPermiso = new FrmPermiso();
		}
		else
		{
			oFrmPermiso.BringToFront();
		}
		oFrmPermiso.MdiParent = this;
		oFrmPermiso.Show();
	}
```

### ToolStripButton7_Click · líneas 2579–2591

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2579](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2579)

```csharp
private void ToolStripButton7_Click(object sender, EventArgs e)
	{
		if (ObjHorario == null || (ObjHorario.IsDisposed ? true : false))
		{
			ObjHorario = CompositionRoot.CrearHorarios();
		}
		else
		{
			ObjHorario.BringToFront();
		}
		ObjHorario.MdiParent = this;
		ObjHorario.Show();
	}
```

### ToolStripButton5_Click · líneas 2593–2606

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2593](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2593)

```csharp
private void ToolStripButton5_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaAsistencias == null || (ObjFrmConsultaAsistencias.IsDisposed ? true : false))
		{
			ObjFrmConsultaAsistencias = new FrmConsultaAsistencias();
		}
		else
		{
			ObjFrmConsultaAsistencias.BringToFront();
		}
		ObjFrmConsultaAsistencias.MdiParent = this;
		ObjFrmConsultaAsistencias.WindowState = FormWindowState.Normal;
		ObjFrmConsultaAsistencias.Show();
	}
```

### ToolStripButton8_Click · líneas 2608–2620

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2608](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2608)

```csharp
private void ToolStripButton8_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoPerm == null || (ObjFrmMantTipoPerm.IsDisposed ? true : false))
		{
			ObjFrmMantTipoPerm = CompositionRoot.CrearCatalogo<FrmMantTipoPerm>(TipoCatalogo.TipoPermiso);
		}
		else
		{
			ObjFrmMantTipoPerm.BringToFront();
		}
		ObjFrmMantTipoPerm.MdiParent = this;
		ObjFrmMantTipoPerm.Show();
	}
```

### ToolStripButton9_Click · líneas 2622–2634

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2622](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2622)

```csharp
private void ToolStripButton9_Click(object sender, EventArgs e)
	{
		if (ObjFrmMotivoPermiso == null || (ObjFrmMotivoPermiso.IsDisposed ? true : false))
		{
			ObjFrmMotivoPermiso = CompositionRoot.CrearMotivosPermiso();
		}
		else
		{
			ObjFrmMotivoPermiso.BringToFront();
		}
		ObjFrmMotivoPermiso.MdiParent = this;
		ObjFrmMotivoPermiso.Show();
	}
```

### ToolStripButton10_Click · líneas 2636–2648

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2636](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2636)

```csharp
private void ToolStripButton10_Click(object sender, EventArgs e)
	{
		if (ObjFrmFeriado == null || (ObjFrmFeriado.IsDisposed ? true : false))
		{
			ObjFrmFeriado = CompositionRoot.CrearFeriado();
		}
		else
		{
			ObjFrmFeriado.BringToFront();
		}
		ObjFrmFeriado.MdiParent = this;
		ObjFrmFeriado.Show();
	}
```

### MotivoDePermisoToolStripMenuItem_Click · líneas 2650–2662

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2650](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2650)

```csharp
private void MotivoDePermisoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMotivoPermiso == null || (ObjFrmMotivoPermiso.IsDisposed ? true : false))
		{
			ObjFrmMotivoPermiso = CompositionRoot.CrearMotivosPermiso();
		}
		else
		{
			ObjFrmMotivoPermiso.BringToFront();
		}
		ObjFrmMotivoPermiso.MdiParent = this;
		ObjFrmMotivoPermiso.Show();
	}
```

### TipoDePermisoToolStripMenuItem_Click · líneas 2664–2676

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2664](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2664)

```csharp
private void TipoDePermisoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmMantTipoPerm == null || (ObjFrmMantTipoPerm.IsDisposed ? true : false))
		{
			ObjFrmMantTipoPerm = CompositionRoot.CrearCatalogo<FrmMantTipoPerm>(TipoCatalogo.TipoPermiso);
		}
		else
		{
			ObjFrmMantTipoPerm.BringToFront();
		}
		ObjFrmMantTipoPerm.MdiParent = this;
		ObjFrmMantTipoPerm.Show();
	}
```

### FeriadosToolStripMenuItem1_Click · líneas 2678–2690

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2678](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2678)

```csharp
private void FeriadosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ObjFrmFeriado == null || (ObjFrmFeriado.IsDisposed ? true : false))
		{
			ObjFrmFeriado = CompositionRoot.CrearFeriado();
		}
		else
		{
			ObjFrmFeriado.BringToFront();
		}
		ObjFrmFeriado.MdiParent = this;
		ObjFrmFeriado.Show();
	}
```

### PermisosToolStripMenuItem_Click_1 · líneas 2692–2705

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2692](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2692)

```csharp
private void PermisosToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		if (oFrmRepPermisos == null || (oFrmRepPermisos.IsDisposed ? true : false))
		{
			oFrmRepPermisos = new FrmRepPermisos();
		}
		else
		{
			oFrmRepPermisos.BringToFront();
		}
		oFrmRepPermisos.MdiParent = this;
		oFrmRepPermisos.StartPosition = FormStartPosition.CenterParent;
		oFrmRepPermisos.Show();
	}
```

### FaltasToolStripMenuItem_Click · líneas 2707–2719

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2707](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2707)

```csharp
private void FaltasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaFaltas == null || (ObjFrmConsultaFaltas.IsDisposed ? true : false))
		{
			ObjFrmConsultaFaltas = new FrmConsultaFaltas();
		}
		else
		{
			ObjFrmConsultaFaltas.BringToFront();
		}
		ObjFrmConsultaFaltas.MdiParent = this;
		ObjFrmConsultaFaltas.Show();
	}
```

### AsistenciasToolStripMenuItem_Click · líneas 2721–2733

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2721](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2721)

```csharp
private void AsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjFrmConsultaAsistencias == null || (ObjFrmConsultaAsistencias.IsDisposed ? true : false))
		{
			ObjFrmConsultaAsistencias = new FrmConsultaAsistencias();
		}
		else
		{
			ObjFrmConsultaAsistencias.BringToFront();
		}
		ObjFrmConsultaAsistencias.MdiParent = this;
		ObjFrmConsultaAsistencias.Show();
	}
```

### AsistenciaDiaToolStripMenuItem_Click · líneas 2735–2748

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2735](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2735)

```csharp
private void AsistenciaDiaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmConsultaAsistDiaria == null || (oFrmConsultaAsistDiaria.IsDisposed ? true : false))
		{
			oFrmConsultaAsistDiaria = new FrmConsultaAsistDiaria();
			oFrmConsultaAsistDiaria.MdiParent = this;
			oFrmConsultaAsistDiaria.WindowState = FormWindowState.Normal;
			oFrmConsultaAsistDiaria.Show();
		}
		else
		{
			oFrmConsultaAsistDiaria.BringToFront();
		}
	}
```

### HorariosToolStripMenuItem_Click · líneas 2750–2762

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2750](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2750)

```csharp
private void HorariosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ObjHorario == null || (ObjHorario.IsDisposed ? true : false))
		{
			ObjHorario = CompositionRoot.CrearHorarios();
		}
		else
		{
			ObjHorario.BringToFront();
		}
		ObjHorario.MdiParent = this;
		ObjHorario.Show();
	}
```

### RecordAsistenciasSemanalesToolStripMenuItem_Click · líneas 2764–2776

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2764](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2764)

```csharp
private void RecordAsistenciasSemanalesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmHorasTrabajadas == null || (oFrmHorasTrabajadas.IsDisposed ? true : false))
		{
			oFrmHorasTrabajadas = new FrmHorasTrabajadas();
		}
		else
		{
			oFrmHorasTrabajadas.BringToFront();
		}
		oFrmHorasTrabajadas.MdiParent = this;
		oFrmHorasTrabajadas.Show();
	}
```

### ImportarAsistenciasToolStripMenuItem_Click · líneas 2778–2790

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2778](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2778)

```csharp
private void ImportarAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistencia == null || (oFrmImportarAsistencia.IsDisposed ? true : false))
		{
			oFrmImportarAsistencia = new FrmImportarAsistencia();
		}
		else
		{
			oFrmImportarAsistencia.BringToFront();
		}
		oFrmImportarAsistencia.MdiParent = this;
		oFrmImportarAsistencia.Show();
	}
```

### AsignarHorariosToolStripMenuItem_Click · líneas 2792–2794

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2792](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2792)

```csharp
private void AsignarHorariosToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}
```

### AsignarHorariosToolStripMenuItem1_Click · líneas 2796–2808

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2796](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2796)

```csharp
private void AsignarHorariosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (oFrmAsignarHorario == null || (oFrmAsignarHorario.IsDisposed ? true : false))
		{
			oFrmAsignarHorario = new FrmAsignarHorario();
		}
		else
		{
			oFrmAsignarHorario.BringToFront();
		}
		oFrmAsignarHorario.MdiParent = this;
		oFrmAsignarHorario.Show();
	}
```

### ImportacionAsistenciasNOSEDEToolStripMenuItem_Click · líneas 2810–2822

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2810](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2810)

```csharp
private void ImportacionAsistenciasNOSEDEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaFueraSEDE == null || (oFrmImportarAsistenciaFueraSEDE.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaFueraSEDE = new FrmImportarAsistenciaFueraSEDE();
		}
		else
		{
			oFrmImportarAsistenciaFueraSEDE.BringToFront();
		}
		oFrmImportarAsistenciaFueraSEDE.MdiParent = this;
		oFrmImportarAsistenciaFueraSEDE.Show();
	}
```

### ToolStripButton6_Click · líneas 2824–2837

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2824](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2824)

```csharp
private void ToolStripButton6_Click(object sender, EventArgs e)
	{
		if (oFrmSobreTiempo == null || (oFrmSobreTiempo.IsDisposed ? true : false))
		{
			oFrmSobreTiempo = new FrmSobreTiempo();
		}
		else
		{
			oFrmSobreTiempo.BringToFront();
		}
		oFrmSobreTiempo.MdiParent = this;
		oFrmSobreTiempo.WindowState = FormWindowState.Normal;
		oFrmSobreTiempo.Show();
	}
```

### PersonalPorProfesionToolStripMenuItem_Click · líneas 2839–2852

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2839](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2839)

```csharp
private void PersonalPorProfesionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmReporteProfesion == null || (oFrmReporteProfesion.IsDisposed ? true : false))
		{
			oFrmReporteProfesion = new FrmReporteProfesion();
		}
		else
		{
			oFrmReporteProfesion.BringToFront();
		}
		oFrmReporteProfesion.MdiParent = this;
		oFrmReporteProfesion.WindowState = FormWindowState.Normal;
		oFrmReporteProfesion.Show();
	}
```

### AsistenciaDiaSeleccionToolStripMenuItem_Click · líneas 2854–2867

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2854](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2854)

```csharp
private void AsistenciaDiaSeleccionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmRepAsistenciaDia == null || (oFrmRepAsistenciaDia.IsDisposed ? true : false))
		{
			oFrmRepAsistenciaDia = new FrmRepAsistenciaDia();
		}
		else
		{
			oFrmRepAsistenciaDia.BringToFront();
		}
		oFrmRepAsistenciaDia.MdiParent = this;
		oFrmRepAsistenciaDia.WindowState = FormWindowState.Normal;
		oFrmRepAsistenciaDia.Show();
	}
```

### ImportarAsistenciasPROINDToolStripMenuItem_Click · líneas 2869–2881

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2869](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2869)

```csharp
private void ImportarAsistenciasPROINDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaPROIND == null || (oFrmImportarAsistenciaPROIND.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaPROIND = new FrmImportarAsistenciaPROIND();
		}
		else
		{
			oFrmImportarAsistenciaPROIND.BringToFront();
		}
		oFrmImportarAsistenciaPROIND.MdiParent = this;
		oFrmImportarAsistenciaPROIND.Show();
	}
```

### AsignarLocalToolStripMenuItem_Click · líneas 2883–2895

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2883](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2883)

```csharp
private void AsignarLocalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmLocalAsignado == null || (oFrmLocalAsignado.IsDisposed ? true : false))
		{
			oFrmLocalAsignado = new FrmLocalAsignado();
		}
		else
		{
			oFrmLocalAsignado.BringToFront();
		}
		oFrmLocalAsignado.MdiParent = this;
		oFrmLocalAsignado.Show();
	}
```

### ImportarAsistenciasCONSEJOToolStripMenuItem_Click · líneas 2897–2909

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2897](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2897)

```csharp
private void ImportarAsistenciasCONSEJOToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaCONSEJO == null || (oFrmImportarAsistenciaCONSEJO.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaCONSEJO = new FrmImportarAsistenciaCONSEJO();
		}
		else
		{
			oFrmImportarAsistenciaCONSEJO.BringToFront();
		}
		oFrmImportarAsistenciaCONSEJO.MdiParent = this;
		oFrmImportarAsistenciaCONSEJO.Show();
	}
```

### ImportacionBiometricoToolStripMenuItem_Click · líneas 2911–2923

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2911](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2911)

```csharp
private void ImportacionBiometricoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmImportarAsistenciaBio == null || (oFrmImportarAsistenciaBio.IsDisposed ? true : false))
		{
			oFrmImportarAsistenciaBio = new FrmImportarAsistenciaBio();
		}
		else
		{
			oFrmImportarAsistenciaBio.BringToFront();
		}
		oFrmImportarAsistenciaBio.MdiParent = this;
		oFrmImportarAsistenciaBio.Show();
	}
```

### EstadisticoPermisosToolStripMenuItem_Click · líneas 2925–2937

[Software/RecursosHumanos/RecursosHumanos/MainMDI.cs:2925](../../Software/RecursosHumanos/RecursosHumanos/MainMDI.cs#L2925)

```csharp
private void EstadisticoPermisosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (oFrmReporteEstadistico == null || (oFrmReporteEstadistico.IsDisposed ? true : false))
		{
			oFrmReporteEstadistico = new FrmReporteEstadistico();
		}
		else
		{
			oFrmReporteEstadistico.BringToFront();
		}
		oFrmReporteEstadistico.MdiParent = this;
		oFrmReporteEstadistico.Show();
	}
```

<a id="f-076"></a>

## FrmConsulta


### FrmConsulta · líneas 65–70

[Software/GRLL/GRLL/Common/FrmConsulta.cs:65](../../Software/GRLL/GRLL/Common/FrmConsulta.cs#L65)

```csharp
[DebuggerNonUserCode]
	public FrmConsulta()
	{
		base.Load += FrmConsulta_Load;
		InitializeComponent();
	}
```

### Limpiar · líneas 151–166

[Software/GRLL/GRLL/Common/FrmConsulta.cs:151](../../Software/GRLL/GRLL/Common/FrmConsulta.cs#L151)

```csharp
protected void Limpiar(Control control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Clear();
			}
		}
	}
```

### Validar · líneas 168–187

[Software/GRLL/GRLL/Common/FrmConsulta.cs:168](../../Software/GRLL/GRLL/Common/FrmConsulta.cs#L168)

```csharp
protected bool Validar(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return false;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox) && var.Text.Trim().Length == 0)
			{
				ucTextBox texto = (ucTextBox)var;
				if (texto.IsRequired && !texto.Validar())
				{
					Retorno = false;
				}
			}
		}
		return Retorno;
	}
```

### FrmConsulta_Load · líneas 189–191

[Software/GRLL/GRLL/Common/FrmConsulta.cs:189](../../Software/GRLL/GRLL/Common/FrmConsulta.cs#L189)

```csharp
private void FrmConsulta_Load(object sender, EventArgs e)
	{
	}
```

<a id="f-077"></a>

## FrmMaestro


### FrmMaestro · líneas 956–963

[Software/GRLL/GRLL/Common/FrmMaestro.cs:956](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L956)

```csharp
public FrmMaestro()
	{
		base.Load += FrmMantFamilia_Load;
		EsNuevo = true;
		_TipoMaestro = Tipo.Simple;
		arriba = false;
		InitializeComponent();
	}
```

### FrmMaestro · líneas 965–973

[Software/GRLL/GRLL/Common/FrmMaestro.cs:965](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L965)

```csharp
public FrmMaestro(Tipo Tipo)
	{
		base.Load += FrmMantFamilia_Load;
		EsNuevo = true;
		_TipoMaestro = Tipo.Simple;
		arriba = false;
		InitializeComponent();
		_TipoMaestro = Tipo;
	}
```

### VerBotones · líneas 975–1041

[Software/GRLL/GRLL/Common/FrmMaestro.cs:975](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L975)

```csharp
protected void VerBotones(bool vbVer)
	{
		Tab.TabPages.Clear();
		if (_TipoMaestro == Tipo.Simple)
		{
			btn_cargar.Visible = vbVer;
			btn_sel.Visible = false;
			btn_nuevo.Visible = vbVer;
			btn_editar.Visible = vbVer;
			btn_eliminar.Visible = vbVer;
			btn_guardar.Visible = !vbVer;
			btn_cancelar.Visible = !vbVer;
			btn_imprimir.Visible = !vbVer;
			btn_cerrar.Visible = vbVer;
			if (vbVer)
			{
				ClearErrors(TabEdicion);
				Tab.TabPages.Insert(0, TabLista);
			}
			else
			{
				Tab.TabPages.Insert(0, TabEdicion);
			}
		}
		if (_TipoMaestro == Tipo.SeleccionEditable)
		{
			btn_cargar.Visible = false;
			btn_sel.Visible = vbVer;
			btn_nuevo.Visible = vbVer;
			btn_editar.Visible = vbVer;
			btn_eliminar.Visible = false;
			btn_guardar.Visible = !vbVer;
			btn_cancelar.Visible = !vbVer;
			btn_imprimir.Visible = false;
			btn_cerrar.Visible = vbVer;
			if (vbVer)
			{
				ClearErrors(TabEdicion);
				Tab.TabPages.Insert(0, TabLista);
			}
			else
			{
				Limpiar(TabEdicion);
				Tab.TabPages.Insert(0, TabEdicion);
			}
		}
		if (_TipoMaestro != Tipo.Seleccion)
		{
			return;
		}
		btn_cargar.Visible = false;
		btn_sel.Visible = vbVer;
		btn_nuevo.Visible = false;
		btn_editar.Visible = false;
		btn_eliminar.Visible = false;
		btn_guardar.Visible = !vbVer;
		btn_cancelar.Visible = !vbVer;
		btn_imprimir.Visible = false;
		btn_cerrar.Visible = vbVer;
		Tab.TabPages.Insert(0, TabLista);
		Tab.TabPages.Insert(1, TabEdicion);
		ClearErrors(TabEdicion);
		foreach (Control var in TabEdicion.Controls)
		{
			var.Enabled = false;
		}
	}
```

### FrmMantFamilia_Load · líneas 1043–1045

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1043](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1043)

```csharp
private void FrmMantFamilia_Load(object sender, EventArgs e)
	{
	}
```

### ClearErrors · líneas 1047–1062

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1047](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1047)

```csharp
protected void ClearErrors(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.ClearErrors();
			}
		}
	}
```

### Limpiar · líneas 1064–1079

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1064](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1064)

```csharp
protected void Limpiar(Control control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Clear();
			}
		}
	}
```

### Validar · líneas 1081–1101

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1081](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1081)

```csharp
protected bool Validar(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return false;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox) && var.Text.Trim().Length == 0)
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Validar();
				if (texto.IsRequired)
				{
					Retorno = false;
				}
			}
		}
		return Retorno;
	}
```

### btn_sel_MouseDown · líneas 1103–1108

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1103](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1103)

```csharp
private void btn_sel_MouseDown(object sender, MouseEventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatStyle = FlatStyle.Popup;
		btn.FlatAppearance.BorderSize = 1;
	}
```

### btn_sel_MouseUp · líneas 1110–1115

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1110](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1110)

```csharp
private void btn_sel_MouseUp(object sender, MouseEventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatStyle = FlatStyle.Flat;
		btn.FlatAppearance.BorderSize = 0;
	}
```

### btn_sel_MouseLeave · líneas 1117–1125

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1117](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1117)

```csharp
private void btn_sel_MouseLeave(object sender, EventArgs e)
	{
		if (arriba)
		{
			Button btn = (Button)sender;
			btn.FlatAppearance.BorderSize = 0;
			arriba = false;
		}
	}
```

### btn_sel_MouseEnter · líneas 1127–1132

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1127](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1127)

```csharp
private void btn_sel_MouseEnter(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatAppearance.BorderSize = 1;
		arriba = true;
	}
```

### btn_nuevo_Click · líneas 1134–1137

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1134](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1134)

```csharp
private void btn_nuevo_Click(object sender, EventArgs e)
	{
		Limpiar(TabEdicion);
	}
```

### btn_editar_Click · líneas 1139–1141

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1139](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1139)

```csharp
private void btn_editar_Click(object sender, EventArgs e)
	{
	}
```

### btn_guardar_Click · líneas 1143–1145

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1143](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1143)

```csharp
private void btn_guardar_Click(object sender, EventArgs e)
	{
	}
```

### btn_sel_Click_1 · líneas 1147–1151

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1147](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1147)

```csharp
private void btn_sel_Click_1(object sender, EventArgs e)
	{
		DialogResult = DialogResult.OK;
		Close();
	}
```

### btn_cerrar_Click · líneas 1153–1156

[Software/GRLL/GRLL/Common/FrmMaestro.cs:1153](../../Software/GRLL/GRLL/Common/FrmMaestro.cs#L1153)

```csharp
private void btn_cerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
```

<a id="f-078"></a>

## LoginForm


### LoginForm · líneas 211–215

[Software/GRLL/GRLL/Common/LoginForm.cs:211](../../Software/GRLL/GRLL/Common/LoginForm.cs#L211)

```csharp
[DebuggerNonUserCode]
	public LoginForm()
	{
		InitializeComponent();
	}
```

### cmdOk_Click · líneas 346–356

[Software/GRLL/GRLL/Common/LoginForm.cs:346](../../Software/GRLL/GRLL/Common/LoginForm.cs#L346)

```csharp
private void cmdOk_Click(object sender, EventArgs e)
	{
		bool bCancel = true;
		ClickOk?.Invoke(ref bCancel);
		if (bCancel)
		{
			DialogResult = DialogResult.No;
			Close();
		}
		Close();
	}
```

### cmdCancel_Click · líneas 358–366

[Software/GRLL/GRLL/Common/LoginForm.cs:358](../../Software/GRLL/GRLL/Common/LoginForm.cs#L358)

```csharp
private void cmdCancel_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickCancel?.Invoke(ref bCancel);
		if (!bCancel)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
```

### txtUsername_TextChanged · líneas 368–371

[Software/GRLL/GRLL/Common/LoginForm.cs:368](../../Software/GRLL/GRLL/Common/LoginForm.cs#L368)

```csharp
private void txtUsername_TextChanged(object sender, EventArgs e)
	{
		cmdOk.Enabled = txtUsername.Text.Length > 0;
	}
```

<a id="f-079"></a>

## XMessageBox


### XMessageBox · líneas 33–36

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:33](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L33)

```csharp
private XMessageBox()
	{
		InitializeComponent();
	}
```

### XmessageBox · líneas 38–58

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:38](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L38)

```csharp
private void XmessageBox(string text, string title, Size size, Font font, Color backColor, Color foreColor, bool customSize)
	{
		Text = title;
		TextBox1.Text = text;
		Font = font;
		BackColor = backColor;
		ForeColor = foreColor;
		Graphics graphics = CreateGraphics();
		SizeF sizeF = graphics.MeasureString(text, font);
		graphics.Dispose();
		int num = ((!(sizeF.Width <= 600f)) ? 600 : ((int)sizeF.Width + 15));
		int num2 = TextBox1.LinesCount() * TextBox1.Font.Height + 40 + 40;
		if (customSize)
		{
			base.Size = size;
		}
		else
		{
			base.Size = new Size(num, num2);
		}
	}
```

### SetButtons · líneas 60–129

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:60](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L60)

```csharp
private void SetButtons(XMessageBoxButtons buttons)
	{
		switch (buttons)
		{
		case XMessageBoxButtons.OK:
			button2.Visible = true;
			button2.Text = "OK";
			button2.DialogResult = DialogResult.OK;
			base.ControlBox = true;
			break;
		case XMessageBoxButtons.AbortRetryIgnore:
			button1.Visible = true;
			button1.Text = "Abort";
			button1.DialogResult = DialogResult.Abort;
			button2.Visible = true;
			button2.Text = "Retry";
			button2.DialogResult = DialogResult.Retry;
			button3.Visible = true;
			button3.Text = "Ignore";
			button3.DialogResult = DialogResult.Ignore;
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.RetryCancel:
			button1.Visible = true;
			button1.Text = "Retry";
			button1.DialogResult = DialogResult.Retry;
			button1.Location = new Point(41, 3);
			button2.Visible = true;
			button2.Text = "Cancel";
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(122, 3);
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.YesNo:
			button1.Visible = true;
			button1.Text = "Yes";
			button1.DialogResult = DialogResult.Yes;
			button1.Location = new Point(41, 3);
			button2.Visible = true;
			button2.Text = "No";
			button2.DialogResult = DialogResult.No;
			button2.Location = new Point(122, 3);
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.YesNoCancel:
			button1.Visible = true;
			button1.DialogResult = DialogResult.Yes;
			button1.Text = "Yes";
			button2.Visible = true;
			button2.DialogResult = DialogResult.No;
			button2.Text = "No";
			button3.Visible = true;
			button3.DialogResult = DialogResult.Cancel;
			button3.Text = "Cancel";
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		}
	}
```

### SetIcon · líneas 131–160

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:131](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L131)

```csharp
private void SetIcon(XMessageBoxIcon icon)
	{
		if (base.Height < 104)
		{
			base.Height = 104;
		}
		if (base.Width <= 600)
		{
			base.Width += 55;
		}
		leftPanel.Visible = true;
		switch (icon)
		{
		case XMessageBoxIcon.Information:
			pictureBox1.BackgroundImage = Resources.Information;
			break;
		case XMessageBoxIcon.Warning:
			pictureBox1.BackgroundImage = Resources.Warning;
			break;
		case XMessageBoxIcon.Error:
			pictureBox1.BackgroundImage = Resources.Error;
			break;
		case XMessageBoxIcon.Question:
			pictureBox1.BackgroundImage = Resources.QuestionMark;
			break;
		case XMessageBoxIcon.Delete:
			pictureBox1.BackgroundImage = Resources.Delete;
			break;
		}
	}
```

### show · líneas 162–168

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:162](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L162)

```csharp
public static DialogResult show(string text)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, "", xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 170–176

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:170](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L170)

```csharp
public static DialogResult show(string text, string title)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 178–184

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:178](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L178)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 186–193

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:186](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L186)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 195–201

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:195](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L195)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons, Size size)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 203–210

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:203](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L203)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 212–218

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:212](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L212)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 220–227

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:220](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L220)

```csharp
public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 229–235

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:229](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L229)

```csharp
public static DialogResult show(string text, string title, Color backColor, Color foreColor)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 237–243

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:237](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L237)

```csharp
public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 245–252

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:245](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L245)

```csharp
public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, XMessageBoxIcon icon)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 254–260

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:254](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L254)

```csharp
public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, backColor, foreColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}
```

### show · líneas 262–269

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:262](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L262)

```csharp
public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, backColor, foreColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}
```

### XMessageBox_Resize · líneas 271–275

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:271](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L271)

```csharp
private void XMessageBox_Resize(object sender, EventArgs e)
	{
		int num = (bottomPanel.Width - bottomInnerPanel.Width) / 2;
		bottomInnerPanel.Location = new Point(num, bottomInnerPanel.Location.Y);
	}
```

### XMessageBox_ForeColorChanged · líneas 277–280

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:277](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L277)

```csharp
private void XMessageBox_ForeColorChanged(object sender, EventArgs e)
	{
		TextBox1.ForeColor = ForeColor;
	}
```

### XMessageBox_BackColorChanged · líneas 282–285

[Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs:282](../../Software/CustomFeaturedMessageBox/Custom_Featured_MessageBox/XMessageBox.cs#L282)

```csharp
private void XMessageBox_BackColorChanged(object sender, EventArgs e)
	{
		TextBox1.BackColor = BackColor;
	}
```

<a id="f-080"></a>

## fLogin


### fLogin · líneas 230–235

[Software/GRLL/GRLL/Common/fLogin.cs:230](../../Software/GRLL/GRLL/Common/fLogin.cs#L230)

```csharp
public fLogin()
	{
		base.Load += fLogin_Load;
		oLogin = new clsLogin();
		InitializeComponent();
	}
```

### fLogin_Load · líneas 361–383

[Software/GRLL/GRLL/Common/fLogin.cs:361](../../Software/GRLL/GRLL/Common/fLogin.cs#L361)

```csharp
private void fLogin_Load(object sender, EventArgs e)
	{
		if (TipoOrigen == Origen.ArchivoINI)
		{
			clsLogin clsLogin2 = oLogin;
			clsLogin2.LoadFromIni(_RutaIni);
			clsLogin2 = null;
		}
		else if (TipoOrigen == Origen.AppSettings)
		{
			if (_Settings == null)
			{
				throw new Exception("Error: no se ha asignado los parametros de Conexión");
			}
			clsLogin clsLogin3 = oLogin;
			clsLogin3.Servidor = _Settings.Servidor;
			clsLogin3.BaseDatos = _Settings.BaseDatos;
			clsLogin3.Usuario = _Settings.Usuario;
			clsLogin3.AutenticacionIntegrada = _Settings.SeguridadIntegrada;
			clsLogin3 = null;
		}
		txtUsername.Text = oLogin.Usuario;
	}
```

### cmdOk_Click · líneas 385–404

[Software/GRLL/GRLL/Common/fLogin.cs:385](../../Software/GRLL/GRLL/Common/fLogin.cs#L385)

```csharp
private void cmdOk_Click(object sender, EventArgs e)
	{
		clsLogin clsLogin2 = oLogin;
		clsLogin2.Usuario = txtUsername.Text.Trim();
		clsLogin2.Password = [OCULTA];
		if (clsLogin2.ConectarSql(clsLogin2.AutenticacionIntegrada))
		{
			DialogResult = DialogResult.OK;
			if (clsLogin2.Connection != null)
			{
				clsLogin2.Connection.Close();
				clsLogin2.Connection.Dispose();
			}
			if (_tipoorigen == Origen.ArchivoINI)
			{
				clsLogin2.WriteToIni();
			}
		}
		clsLogin2 = null;
	}
```

### cmdCancel_Click · líneas 406–409

[Software/GRLL/GRLL/Common/fLogin.cs:406](../../Software/GRLL/GRLL/Common/fLogin.cs#L406)

```csharp
private void cmdCancel_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
	}
```

### txtUsername_TextChanged · líneas 411–421

[Software/GRLL/GRLL/Common/fLogin.cs:411](../../Software/GRLL/GRLL/Common/fLogin.cs#L411)

```csharp
private void txtUsername_TextChanged(object sender, EventArgs e)
	{
		if (txtUsername.Text.Trim().Length == 0)
		{
			cmdOk.Enabled = false;
		}
		else
		{
			cmdOk.Enabled = true;
		}
	}
```

### lblUserName_Click · líneas 423–425

[Software/GRLL/GRLL/Common/fLogin.cs:423](../../Software/GRLL/GRLL/Common/fLogin.cs#L423)

```csharp
private void lblUserName_Click(object sender, EventArgs e)
	{
	}
```

<a id="f-081"></a>

## frmBase


### FindWindow · líneas 736–737

[Software/GRLL/GRLL/Common/frmBase.cs:736](../../Software/GRLL/GRLL/Common/frmBase.cs#L736)

```csharp
[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);
```

### SetForegroundWindow · líneas 739–740

[Software/GRLL/GRLL/Common/frmBase.cs:739](../../Software/GRLL/GRLL/Common/frmBase.cs#L739)

```csharp
[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);
```

### cmdCerrar_Click · líneas 742–745

[Software/GRLL/GRLL/Common/frmBase.cs:742](../../Software/GRLL/GRLL/Common/frmBase.cs#L742)

```csharp
private void cmdCerrar_Click(object sender, EventArgs e)
	{
		Salir();
	}
```

### Salir · líneas 747–765

[Software/GRLL/GRLL/Common/frmBase.cs:747](../../Software/GRLL/GRLL/Common/frmBase.cs#L747)

```csharp
public void Salir()
	{
		bool bCancelar = false;
		CloseForm?.Invoke(ref bCancelar);
		if (bCancelar)
		{
			return;
		}
		try
		{
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBase_FormClosing · líneas 767–773

[Software/GRLL/GRLL/Common/frmBase.cs:767](../../Software/GRLL/GRLL/Common/frmBase.cs#L767)

```csharp
private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bSalirConfirmar && MessageBox.Show("Esta seguro de Cerrar el Formulario?", "Cerrar Formulario " + Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			e.Cancel = true;
		}
	}
```

### frmBase_Load · líneas 775–780

[Software/GRLL/GRLL/Common/frmBase.cs:775](../../Software/GRLL/GRLL/Common/frmBase.cs#L775)

```csharp
private void frmBase_Load(object sender, EventArgs e)
	{
		lblTitle.Text = Name;
		Text = sTextFrm;
		CentrarForm(this);
	}
```

### OnPaint · líneas 782–786

[Software/GRLL/GRLL/Common/frmBase.cs:782](../../Software/GRLL/GRLL/Common/frmBase.cs#L782)

```csharp
protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Pintar();
	}
```

### OnParentBackColorChanged · líneas 788–792

[Software/GRLL/GRLL/Common/frmBase.cs:788](../../Software/GRLL/GRLL/Common/frmBase.cs#L788)

```csharp
protected override void OnParentBackColorChanged(EventArgs e)
	{
		base.OnParentBackColorChanged(e);
		Pintar();
	}
```

### frmBase_Shown · líneas 794–798

[Software/GRLL/GRLL/Common/frmBase.cs:794](../../Software/GRLL/GRLL/Common/frmBase.cs#L794)

```csharp
private void frmBase_Shown(object sender, EventArgs e)
	{
		lblTitle.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
		Text = sTextFrm;
	}
```

### Pintar · líneas 800–806

[Software/GRLL/GRLL/Common/frmBase.cs:800](../../Software/GRLL/GRLL/Common/frmBase.cs#L800)

```csharp
private void Pintar()
	{
		GradForm();
		GradPanelSup();
		GradPanelInf();
		cmdCerrar.Visible = bVerCmdCerrar;
	}
```

### GradForm · líneas 808–821

[Software/GRLL/GRLL/Common/frmBase.cs:808](../../Software/GRLL/GRLL/Common/frmBase.cs#L808)

```csharp
private void GradForm()
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (bGradientShow)
		{
			Rectangle rec = new Rectangle(0, 0, Width, Height);
			Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1, nGradColor2, nGradModo);
			CreateGraphics().FillRectangle(LinearBrush, rec);
		}
		else
		{
			BackColor = nGradColor1;
		}
	}
```

### GradPanelSup · líneas 823–847

[Software/GRLL/GRLL/Common/frmBase.cs:823](../../Software/GRLL/GRLL/Common/frmBase.cs#L823)

```csharp
private void GradPanelSup()
	{
		if (!bVerPanelSup || !bGradientShow)
		{
			return;
		}
		if (nGradColor1PanelSup != nGradColor2PanelSup)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelSup.Width, PanelSup.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelSup, nGradColor2PanelSup, nGradModoPanelSup);
				PanelSup.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelSup.BackColor = nGradColor1PanelSup;
	}
```

### GradPanelInf · líneas 849–873

[Software/GRLL/GRLL/Common/frmBase.cs:849](../../Software/GRLL/GRLL/Common/frmBase.cs#L849)

```csharp
private void GradPanelInf()
	{
		if (!bVerPanelInf)
		{
			return;
		}
		if (bGradientShow)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelInf.Width, PanelInf.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelInf, nGradColor2PanelInf, nGradModoPanelInf);
				PanelInf.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelInf.BackColor = nGradColor1PanelInf;
	}
```

### PintarGradiente · líneas 875–905

[Software/GRLL/GRLL/Common/frmBase.cs:875](../../Software/GRLL/GRLL/Common/frmBase.cs#L875)

```csharp
public void PintarGradiente(object oArea, Color nColor1, Color nColor2, LinearGradientMode oMode)
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (!bGradientShow)
		{
			return;
		}
		try
		{
			Rectangle rec = new Rectangle(0, 0, Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Width", new object[0], null, null, null)), Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Height", new object[0], null, null, null)));
			Brush LinearBrush = new LinearGradientBrush(rec, nColor1, nColor1, oMode);
			object instance = NewLateBinding.LateGet(oArea, null, "CreateGraphics", new object[0], null, null, null);
			object[] array = new object[2] { LinearBrush, rec };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(instance, null, "FillRectangle", array, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				LinearBrush = (Brush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Brush));
			}
			if (array2[1])
			{
				rec = (Rectangle)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(Rectangle));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBase · líneas 907–937

[Software/GRLL/GRLL/Common/frmBase.cs:907](../../Software/GRLL/GRLL/Common/frmBase.cs#L907)

```csharp
public frmBase()
	{
		base.FormClosing += frmBase_FormClosing;
		base.Load += frmBase_Load;
		base.Shown += frmBase_Shown;
		bGradientShow = true;
		nGradColor1 = Color.FromArgb(224, 233, 244);
		nGradColor2 = Color.FromArgb(224, 233, 244);
		nGradModo = LinearGradientMode.Vertical;
		nGradColor1PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor2PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor1PanelInf = Color.FromArgb(130, 165, 210);
		nGradColor2PanelInf = Color.FromArgb(130, 165, 210);
		nGradModoPanelSup = LinearGradientMode.Vertical;
		nGradModoPanelInf = LinearGradientMode.Vertical;
		bSalirConfirmar = false;
		GuardarySalir = false;
		sTextFrm = "";
		bVerCal = true;
		bVerPanelInf = true;
		bVerPanelSup = true;
		bVerTituloFrm = false;
		sTituloFrm = "Título principal";
		ref Point reference = ref iTituloFrmubica;
		reference = new Point(325, -1);
		bVerCmdCerrar = false;
		InitializeComponent();
		FormBorderStyle = FormBorderStyle.FixedSingle;
		ShowInTaskbar = false;
		KeyPreview = true;
	}
```

### cmdCalc_Click · líneas 939–952

[Software/GRLL/GRLL/Common/frmBase.cs:939](../../Software/GRLL/GRLL/Common/frmBase.cs#L939)

```csharp
private void cmdCalc_Click(object sender, EventArgs e)
	{
		string lpClassName = null;
		string lpWindowName = "Calculadora";
		IntPtr calculatorHandle = FindWindow(ref lpClassName, ref lpWindowName);
		if (calculatorHandle == IntPtr.Zero)
		{
			Process.Start("CALC.EXE");
		}
		else
		{
			SetForegroundWindow(calculatorHandle);
		}
	}
```

### CentrarForm · líneas 954–961

[Software/GRLL/GRLL/Common/frmBase.cs:954](../../Software/GRLL/GRLL/Common/frmBase.cs#L954)

```csharp
private void CentrarForm(Form oForm)
	{
		if (oForm.MdiParent != null)
		{
			oForm.Top = Conversions.ToInteger(Interaction.IIf(oForm.IsMdiChild, 0, (double)checked(Screen.PrimaryScreen.WorkingArea.Height - oForm.Height) / 2.0));
			oForm.Left = Conversions.ToInteger(Operators.DivideObject(Operators.SubtractObject(Interaction.IIf(oForm.IsMdiChild, oForm.MdiParent.Size.Width, Screen.PrimaryScreen.WorkingArea.Width), oForm.Width), 2));
		}
	}
```

<a id="f-082"></a>

## frmBase1


### FindWindow · líneas 715–716

[Software/GRLL/GRLL/Common/frmBase1.cs:715](../../Software/GRLL/GRLL/Common/frmBase1.cs#L715)

```csharp
[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);
```

### SetForegroundWindow · líneas 718–719

[Software/GRLL/GRLL/Common/frmBase1.cs:718](../../Software/GRLL/GRLL/Common/frmBase1.cs#L718)

```csharp
[DllImport("USER32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);
```

### Salir · líneas 721–739

[Software/GRLL/GRLL/Common/frmBase1.cs:721](../../Software/GRLL/GRLL/Common/frmBase1.cs#L721)

```csharp
public void Salir()
	{
		bool bCancelar = false;
		CloseForm?.Invoke(ref bCancelar);
		if (bCancelar)
		{
			return;
		}
		try
		{
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBase_FormClosing · líneas 741–747

[Software/GRLL/GRLL/Common/frmBase1.cs:741](../../Software/GRLL/GRLL/Common/frmBase1.cs#L741)

```csharp
private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bSalirConfirmar && MessageBox.Show("Esta seguro de Cerrar el Formulario?", "Cerrar Formulario " + Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
		{
			e.Cancel = true;
		}
	}
```

### frmBase_Load · líneas 749–754

[Software/GRLL/GRLL/Common/frmBase1.cs:749](../../Software/GRLL/GRLL/Common/frmBase1.cs#L749)

```csharp
private void frmBase_Load(object sender, EventArgs e)
	{
		lblTitle.Text = Name;
		Text = sTextFrm;
		CentrarForm(this);
	}
```

### OnPaint · líneas 756–760

[Software/GRLL/GRLL/Common/frmBase1.cs:756](../../Software/GRLL/GRLL/Common/frmBase1.cs#L756)

```csharp
protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Pintar();
	}
```

### OnParentBackColorChanged · líneas 762–766

[Software/GRLL/GRLL/Common/frmBase1.cs:762](../../Software/GRLL/GRLL/Common/frmBase1.cs#L762)

```csharp
protected override void OnParentBackColorChanged(EventArgs e)
	{
		base.OnParentBackColorChanged(e);
		Pintar();
	}
```

### frmBase_Shown · líneas 768–772

[Software/GRLL/GRLL/Common/frmBase1.cs:768](../../Software/GRLL/GRLL/Common/frmBase1.cs#L768)

```csharp
private void frmBase_Shown(object sender, EventArgs e)
	{
		lblTitle.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
		Text = sTextFrm;
	}
```

### Pintar · líneas 774–779

[Software/GRLL/GRLL/Common/frmBase1.cs:774](../../Software/GRLL/GRLL/Common/frmBase1.cs#L774)

```csharp
private void Pintar()
	{
		GradForm();
		GradPanelSup();
		GradPanelInf();
	}
```

### GradForm · líneas 781–794

[Software/GRLL/GRLL/Common/frmBase1.cs:781](../../Software/GRLL/GRLL/Common/frmBase1.cs#L781)

```csharp
private void GradForm()
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (bGradientShow)
		{
			Rectangle rec = new Rectangle(0, 0, Width, Height);
			Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1, nGradColor2, nGradModo);
			CreateGraphics().FillRectangle(LinearBrush, rec);
		}
		else
		{
			BackColor = nGradColor1;
		}
	}
```

### GradPanelSup · líneas 796–820

[Software/GRLL/GRLL/Common/frmBase1.cs:796](../../Software/GRLL/GRLL/Common/frmBase1.cs#L796)

```csharp
private void GradPanelSup()
	{
		if (!bVerPanelSup || !bGradientShow)
		{
			return;
		}
		if (nGradColor1PanelSup != nGradColor2PanelSup)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelSup.Width, PanelSup.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelSup, nGradColor2PanelSup, nGradModoPanelSup);
				PanelSup.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelSup.BackColor = nGradColor1PanelSup;
	}
```

### GradPanelInf · líneas 822–846

[Software/GRLL/GRLL/Common/frmBase1.cs:822](../../Software/GRLL/GRLL/Common/frmBase1.cs#L822)

```csharp
private void GradPanelInf()
	{
		if (!bVerPanelInf)
		{
			return;
		}
		if (bGradientShow)
		{
			try
			{
				Rectangle rec = new Rectangle(0, 0, PanelInf.Width, PanelInf.Height);
				Brush LinearBrush = new LinearGradientBrush(rec, nGradColor1PanelInf, nGradColor2PanelInf, nGradModoPanelInf);
				PanelInf.CreateGraphics().FillRectangle(LinearBrush, rec);
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		PanelInf.BackColor = nGradColor1PanelInf;
	}
```

### PintarGradiente · líneas 848–878

[Software/GRLL/GRLL/Common/frmBase1.cs:848](../../Software/GRLL/GRLL/Common/frmBase1.cs#L848)

```csharp
public void PintarGradiente(object oArea, Color nColor1, Color nColor2, LinearGradientMode oMode)
	{
		lblMessage.BackColor = Color.FromName("Transparent");
		if (!bGradientShow)
		{
			return;
		}
		try
		{
			Rectangle rec = new Rectangle(0, 0, Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Width", new object[0], null, null, null)), Conversions.ToInteger(NewLateBinding.LateGet(oArea, null, "Height", new object[0], null, null, null)));
			Brush LinearBrush = new LinearGradientBrush(rec, nColor1, nColor1, oMode);
			object instance = NewLateBinding.LateGet(oArea, null, "CreateGraphics", new object[0], null, null, null);
			object[] array = new object[2] { LinearBrush, rec };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(instance, null, "FillRectangle", array, null, null, array2, IgnoreReturn: true);
			if (array2[0])
			{
				LinearBrush = (Brush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Brush));
			}
			if (array2[1])
			{
				rec = (Rectangle)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(Rectangle));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBase1 · líneas 880–909

[Software/GRLL/GRLL/Common/frmBase1.cs:880](../../Software/GRLL/GRLL/Common/frmBase1.cs#L880)

```csharp
public frmBase1()
	{
		base.Load += frmBase_Load;
		base.Shown += frmBase_Shown;
		base.FormClosing += frmBase_FormClosing;
		bGradientShow = true;
		nGradColor1 = Color.FromArgb(224, 233, 244);
		nGradColor2 = Color.FromArgb(224, 233, 244);
		nGradModo = LinearGradientMode.Vertical;
		nGradColor1PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor2PanelSup = Color.FromArgb(199, 223, 250);
		nGradColor1PanelInf = Color.FromArgb(130, 165, 210);
		nGradColor2PanelInf = Color.FromArgb(130, 165, 210);
		nGradModoPanelSup = LinearGradientMode.Vertical;
		nGradModoPanelInf = LinearGradientMode.Vertical;
		bSalirConfirmar = false;
		GuardarySalir = false;
		sTextFrm = "";
		bVerCal = true;
		bVerPanelInf = true;
		bVerPanelSup = true;
		bVerTituloFrm = false;
		sTituloFrm = "Título principal";
		ref Point reference = ref iTituloFrmubica;
		reference = new Point(325, -1);
		InitializeComponent();
		FormBorderStyle = FormBorderStyle.FixedSingle;
		ShowInTaskbar = false;
		KeyPreview = true;
	}
```

### cmdCalc_Click · líneas 911–924

[Software/GRLL/GRLL/Common/frmBase1.cs:911](../../Software/GRLL/GRLL/Common/frmBase1.cs#L911)

```csharp
private void cmdCalc_Click(object sender, EventArgs e)
	{
		string lpClassName = null;
		string lpWindowName = "Calculadora";
		IntPtr calculatorHandle = FindWindow(ref lpClassName, ref lpWindowName);
		if (calculatorHandle == IntPtr.Zero)
		{
			Process.Start("CALC.EXE");
		}
		else
		{
			SetForegroundWindow(calculatorHandle);
		}
	}
```

### CentrarForm · líneas 926–933

[Software/GRLL/GRLL/Common/frmBase1.cs:926](../../Software/GRLL/GRLL/Common/frmBase1.cs#L926)

```csharp
private void CentrarForm(Form oForm)
	{
		if (oForm.MdiParent != null)
		{
			oForm.Top = Conversions.ToInteger(Interaction.IIf(oForm.IsMdiChild, 0, (double)checked(Screen.PrimaryScreen.WorkingArea.Height - oForm.Height) / 2.0));
			oForm.Left = Conversions.ToInteger(Operators.DivideObject(Operators.SubtractObject(Interaction.IIf(oForm.IsMdiChild, oForm.MdiParent.Size.Width, Screen.PrimaryScreen.WorkingArea.Width), oForm.Width), 2));
		}
	}
```

<a id="f-083"></a>

## frmBaseImg


### frmBaseImg · líneas 33–37

[Software/GRLL/GRLL/Common/frmBaseImg.cs:33](../../Software/GRLL/GRLL/Common/frmBaseImg.cs#L33)

```csharp
[DebuggerNonUserCode]
	public frmBaseImg()
	{
		InitializeComponent();
	}
```

<a id="f-084"></a>

## frmBaseMant


### BTN_SALIR_Click · líneas 2141–2159

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2141](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2141)

```csharp
private void BTN_SALIR_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickSalir?.Invoke(ref bCancel);
		if (bCancel)
		{
			return;
		}
		try
		{
			Salir();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBaseMant_Load · líneas 2161–2176

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2161](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2161)

```csharp
private void frmBaseMant_Load(object sender, EventArgs e)
	{
		LBL_DEL.Visible = false;
		DTP_FI.Visible = false;
		LBL_AL.Visible = false;
		DTP_FF.Visible = false;
		TXT_BUSCA.Visible = true;
		CHK_ITERACTIVO.Visible = true;
		TABs.TabPages.Clear();
		ActivaTab(iNroTabp);
		ToolTipTextChk.SetToolTip(CHK_ITERACTIVO, "Busqueda Iteractiva");
		ToolTipTextChk.Active = true;
		ToolStrip tStMenu = TStMenu;
		Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
		tStMenu.Location = location;
	}
```

### ActivaTab · líneas 2178–2230

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2178](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2178)

```csharp
private void ActivaTab(object NroTab)
	{
		TABs.TabPages.Clear();
		if (Operators.ConditionalCompareObjectEqual(NroTab, 0, TextCompare: false))
		{
			TABs.TabPages.Add(TAB_LIST);
			TStMenu.Items["BTN_NEW"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerNuevo, true, false));
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = false;
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerBuscar, true, false));
			TStMenu.Items["BTN_REFRESH"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerRegrescar, true, false));
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 1, TextCompare: false))
		{
			TABs.TabPages.Add(TAB_EDICION);
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = false;
			TStMenu.Items["BTN_SAVE"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerGrabar, true, false));
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = false;
			TStMenu.Items["BTN_PRINT"].Visible = false;
			TStMenu.Items["BTN_EXCEL"].Visible = false;
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 2, TextCompare: false))
		{
			TABs.TabPages.Add(TAB_BUSCAR);
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSeleccionar, true, false));
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		Reubicar();
	}
```

### GetData · líneas 2232–2260

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2232](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2232)

```csharp
private DataTable GetData(string sSql)
	{
		DataTable Dt = new DataTable();
		SqlDataAdapter da = ((cConnection != null) ? new SqlDataAdapter(sSql, cConnection) : new SqlDataAdapter(sSql, sConnection));
		try
		{
			da.Fill(Dt);
			return Dt;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message);
		}
		finally
		{
			if (Dt != null)
			{
				Dt.Dispose();
				Dt = null;
			}
			if (da != null)
			{
				da.Dispose();
				da = null;
			}
		}
	}
```

### ListarCmb · líneas 2262–2282

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2262](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2262)

```csharp
public void ListarCmb(int NroCmb, string sSql, string sMuestra, string sId)
	{
		DataTable Dt = GetData(sSql);
		switch (NroCmb)
		{
		case 1:
			CMB_1.DataSource = null;
			CMB_1.Items.Clear();
			CMB_1.DisplayMember = sMuestra;
			CMB_1.ValueMember = sId;
			CMB_1.DataSource = Dt;
			break;
		case 2:
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
			CMB_2.DisplayMember = sMuestra;
			CMB_2.ValueMember = sId;
			CMB_2.DataSource = Dt;
			break;
		}
	}
```

### ConfiguraDataGridView · líneas 2284–2296

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2284](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2284)

```csharp
private void ConfiguraDataGridView(ref DataGridView DGV)
	{
		DGV.AllowUserToAddRows = false;
		DGV.AllowUserToDeleteRows = false;
		DGV.AllowUserToOrderColumns = true;
		DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
		DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DGV.EditMode = DataGridViewEditMode.EditProgrammatically;
		DGV.ReadOnly = true;
		DGV.RowHeadersVisible = false;
		DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 239, 240);
	}
```

### ListarDGV · líneas 2298–2306

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2298](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2298)

```csharp
public void ListarDGV(ref bool GrigDatos, string sSql)
	{
		DataGridView DGV = ((!GrigDatos) ? DGV_BUSCAR : DGV_DATOS);
		ConfiguraDataGridView(ref DGV);
		DGV.DataSource = null;
		DGV.DataSource = GetData(sSql);
		DGV.TabIndex = 0;
		Config_DGV?.Invoke(ref DGV);
	}
```

### AlineaCMBs · líneas 2308–2399

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2308](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2308)

```csharp
private void AlineaCMBs()
	{
		if (!bResizeAutomatic)
		{
			return;
		}
		int iTopLbl = 0;
		int iLeftLbl = 0;
		int iCtaCMBs = 0;
		iCtaCMBs = Conversions.ToInteger(Operators.AddObject(Interaction.IIf(bVerCMB1, 1, 0), Interaction.IIf(bVerCMB2, 1, 0)));
		checked
		{
			Point location;
			if (mLblHorizontal)
			{
				iTopLbl = 10;
				iLeftLbl = 2;
				Label lBL_COMBO = LBL_COMBO1;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO.Location = location;
				if (bVerLblCMB1)
				{
					iLeftLbl += LBL_COMBO1.Width + 2;
				}
				ComboBox cMB_ = CMB_1;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_.Location = location;
				ComboBox cMB_2 = CMB_1;
				Size size = new Size((int)Math.Round((double)(TABs.Width - 8) / 2.0 - (double)iLeftLbl - 4.0), CMB_1.Height);
				cMB_2.Size = size;
				if (bVerCMB1)
				{
					iLeftLbl += CMB_1.Width + 4;
				}
				Label lBL_COMBO2 = LBL_COMBO2;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO2.Location = location;
				if (bVerLblCMB2)
				{
					iLeftLbl += LBL_COMBO2.Width + 2;
				}
				ComboBox cMB_3 = CMB_2;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_3.Location = location;
				ComboBox cMB_4 = CMB_2;
				size = new Size(Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((double)(TABs.Width - 8) / 2.0, Interaction.IIf(bVerLblCMB2, LBL_COMBO2.Width, 0)), 3)), CMB_2.Height);
				cMB_4.Size = size;
				if (bVerLblCMB1 || bVerCMB1 || bVerLblCMB2 || bVerCMB1)
				{
					iTopLbl = Conversions.ToInteger(Operators.AddObject(iTopLbl, Operators.AddObject(Interaction.IIf(LBL_COMBO1.Height > CMB_1.Height, LBL_COMBO1.Height, CMB_1.Height), 2)));
				}
				mTopGrid = (short)iTopLbl;
			}
			else
			{
				iTopLbl = 6;
				iLeftLbl = 2;
				Label lBL_COMBO3 = LBL_COMBO1;
				location = new Point(iLeftLbl + 2, iTopLbl);
				lBL_COMBO3.Location = location;
				Label lBL_COMBO4 = LBL_COMBO2;
				location = new Point((int)Math.Round((double)(TABs.Width - 8) / 2.0 + 2.0), iTopLbl);
				lBL_COMBO4.Location = location;
				if (bVerLblCMB1 || bVerLblCMB2)
				{
					iTopLbl += LBL_COMBO1.Height + 2;
				}
				ComboBox cMB_5 = CMB_1;
				location = new Point(2, iTopLbl);
				cMB_5.Location = location;
				ComboBox cMB_6 = CMB_1;
				Size size = new Size((int)Math.Round((double)(TABs.Width - 8) / 2.0 - 6.0), CMB_1.Height);
				cMB_6.Size = size;
				ComboBox cMB_7 = CMB_2;
				location = new Point((int)Math.Round((double)(TABs.Width - 8) / 2.0 + 2.0), iTopLbl);
				cMB_7.Location = location;
				ComboBox cMB_8 = CMB_2;
				size = new Size((int)Math.Round((double)(TABs.Width - 8) / 2.0 - 4.0), CMB_1.Height);
				cMB_8.Size = size;
				if (bVerCMB1 || bVerCMB2)
				{
					iTopLbl += CMB_1.Height + 2;
				}
				mTopGrid = (short)iTopLbl;
			}
			DataGridView dGV_DATOS = DGV_DATOS;
			location = new Point(2, mTopGrid);
			dGV_DATOS.Location = location;
			DGV_DATOS.Height = TABs.Size.Height - 26 - 4 - DGV_DATOS.Location.Y;
			DGV_DATOS.Width = TABs.Width - 8 - 4;
		}
	}
```

### Inicializar · líneas 2401–2406

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2401](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2401)

```csharp
private void Inicializar()
	{
		bResizeAutomatic = true;
		bVerTitulo = true;
		mTopGrid = 25;
	}
```

### Reubicar · líneas 2408–2494

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2408](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2408)

```csharp
private void Reubicar()
	{
		int nTop = Conversions.ToInteger(Interaction.IIf(VerPanelSup, PanelSup.Height, 10));
		checked
		{
			if (bResizeAutomatic)
			{
				nTop = 0;
				if (TituloFrmVer)
				{
					nTop = TituloPosY + LBL_TITLULO.Height + 4;
				}
				Point location;
				if (bVerTituloTab)
				{
					nTop += LBL_TITLULO.Top + LBL_TITLULO.Height;
					Label lBL_TITLULO = LBL_TITLULO;
					location = new Point(0, nTop);
					lBL_TITLULO.Location = location;
				}
				nTop += 4;
				TabControl tABs = TABs;
				location = new Point(10, nTop);
				tABs.Location = location;
				LBL_TITLULO.Width = Width - 10;
				TabControl tABs2 = TABs;
				Size size = new Size(LBL_TITLULO.Width - 20, Conversions.ToInteger(Operators.SubtractObject(ClientSize.Height - TStMenu.Height - 2 - nTop, Interaction.IIf(VerPanelInf, PanelInf.Height, 0))));
				tABs2.Size = size;
				nTop += TABs.Height + 2;
				if (ClientSize.Width > TStMenu.Width)
				{
					location = (TStMenu.Location = new Point((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0), nTop));
				}
				else
				{
					ToolStrip tStMenu = TStMenu;
					location = new Point(2, nTop);
					tStMenu.Location = location;
				}
				AlineaCMBs();
				if ((double)(TABs.Width - 8) / 3.0 < (double)(TABs.Width - 10 - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2 + CMD_BUSCAR.Width)))
				{
					CMB_OPCION.Width = (int)Math.Round((double)(TABs.Width - 8) / 3.0);
				}
				else
				{
					CMB_OPCION.Width = TABs.Width - 10 - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2 + CMD_BUSCAR.Width);
				}
				ComboBox cMB_OPCION = CMB_OPCION;
				location = new Point(2, 8);
				cMB_OPCION.Location = location;
				ucText tXT_BUSCA = TXT_BUSCA;
				location = new Point(2 + CMB_OPCION.Width + 4, 8);
				tXT_BUSCA.Location = location;
				TXT_BUSCA.Width = TABs.Width - 8 - CMB_OPCION.Width - CHK_ITERACTIVO.Width - CMD_BUSCAR.Width - 10;
				CheckBox cHK_ITERACTIVO = CHK_ITERACTIVO;
				location = TXT_BUSCA.Location;
				Point location2 = new Point(location.X + TXT_BUSCA.Width + 2, 12);
				cHK_ITERACTIVO.Location = location2;
				Button cMD_BUSCAR = CMD_BUSCAR;
				location2 = new Point(TABs.Width - 8 - CMD_BUSCAR.Width - 2, 8);
				cMD_BUSCAR.Location = location2;
				int Xi = 2 + CMB_OPCION.Width + 4;
				int Xf = CMD_BUSCAR.Location.X;
				int Xd = Xf - Xi - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2);
				Label lBL_DEL = LBL_DEL;
				location2 = new Point((int)Math.Round((double)Xi + (double)Xd / 2.0), 12);
				lBL_DEL.Location = location2;
				location = (DTP_FI.Location = new Point(LBL_DEL.Location.X + LBL_DEL.Width + 2, 8));
				location = (LBL_AL.Location = new Point(DTP_FI.Location.X + DTP_FI.Width + 2, 12));
				location = (DTP_FF.Location = new Point(LBL_AL.Location.X + LBL_AL.Width + 2, 8));
				DTP_FI.Value = new DateTime(633347424000000000L);
				DTP_FF.Value = new DateTime(633662784000000000L);
				location = (DGV_BUSCAR.Location = new Point(2, TXT_BUSCA.Location.Y + TXT_BUSCA.Height + 2));
				DGV_BUSCAR.Height = TABs.Size.Height - 26 - 4 - DGV_BUSCAR.Location.Y;
				DGV_BUSCAR.Width = TABs.Width - 8 - 4;
			}
			if (!VerPanelSup)
			{
				PanelSup.Top = Height + 50;
			}
			if (!VerPanelInf)
			{
				PanelInf.Top = Height + 50;
			}
		}
	}
```

### DGV_DATOS_CellContentClick · líneas 2496–2498

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2496](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2496)

```csharp
private void DGV_DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
```

### DGV_DATOS_CellFormatting · líneas 2500–2503

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2500](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2500)

```csharp
private void DGV_DATOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DGV_DATOS_CellMouseDoubleClick · líneas 2505–2508

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2505](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2505)

```csharp
private void DGV_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_EDIT.PerformClick();
	}
```

### DGV_BUSCAR_CellFormatting · líneas 2510–2513

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2510](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2510)

```csharp
private void DGV_BUSCAR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DTG_BUSCAR_CellMouseDoubleClick · líneas 2515–2518

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2515](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2515)

```csharp
private void DTG_BUSCAR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_SELEC.PerformClick();
	}
```

### BTN_EXCEL_Click · líneas 2520–2845

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2520](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2520)

```csharp
private void BTN_EXCEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		DT1 = null;
		ClickExportarExcel?.Invoke(ref bCancel, ref DT1);
		if (bCancel)
		{
			return;
		}
		checked
		{
			if (DT1 == null)
			{
				if (Operators.CompareString(TABs.TabPages[0].Name, TAB_LIST.Name, TextCompare: false) == 0)
				{
					DT1 = ((DataTable)DGV_DATOS.DataSource).Copy();
					int num = DGV_DATOS.ColumnCount - 1;
					for (int I = 0; I <= num; I++)
					{
						if (!DGV_DATOS.Columns[I].Visible)
						{
							DT1.Columns.Remove(DGV_DATOS.Columns[I].Name);
						}
					}
				}
				else
				{
					if (Operators.CompareString(TABs.TabPages[0].Name, TAB_BUSCAR.Name, TextCompare: false) != 0)
					{
						return;
					}
					DT1 = (DataTable)DGV_BUSCAR.DataSource;
					int num2 = DGV_DATOS.ColumnCount - 1;
					for (int i = 0; i <= num2; i++)
					{
						if (!DGV_BUSCAR.Columns[i].Visible)
						{
							DT1.Columns.Remove(DGV_BUSCAR.Columns[i].Name);
						}
					}
				}
			}
			if (DT1 == null || DT1.Rows.Count < 1)
			{
				return;
			}
			object oExcel = null;
			string TempFileName = "";
			try
			{
				TempFileName = "Reportes" + Strings.Format(DateAndTime.Now, "ddMMyy") + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
				TempFileName = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + TempFileName;
				FileStream fs = new FileStream(TempFileName, FileMode.Create, FileAccess.Write);
				BinaryWriter fsR = new BinaryWriter(fs);
				fsR.Write(Resources.ReportesTablas, 0, Resources.ReportesTablas.Length);
				fsR.Close();
				fs.Close();
				oExcel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
				object instance = oExcel;
				NewLateBinding.LateSet(instance, null, "Visible", new object[1] { false }, null, null);
				object instance2 = NewLateBinding.LateGet(instance, null, "Workbooks", new object[0], null, null, null);
				object[] array = new object[1] { TempFileName };
				object[] arguments = array;
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(instance2, null, "Open", arguments, null, null, array2);
				if (array2[0])
				{
					TempFileName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object oBook = RuntimeHelpers.GetObjectValue(obj);
				object oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(oBook, null, "ActiveSheet", new object[0], null, null, null));
				NewLateBinding.LateCall(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(oBook, null, "ActiveSheet", new object[0], null, null, null));
				NewLateBinding.LateSet(oSheet, null, "RANGE", new object[2] { "B2", _TituloExcel }, null, null);
				NewLateBinding.LateSet(oSheet, null, "RANGE", new object[2] { "B4", _SubTituloExcel }, null, null);
				int _AnchoCol = 0;
				if (DT1.Columns.Count < 3)
				{
					_AnchoAutomat = true;
					_AnchoCol = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "Width", new object[0], null, null, null));
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					if (DT1.Columns.Count < 2)
					{
						_AnchoCol = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "Width", new object[0], null, null, null));
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				else if (DT1.Columns.Count > 3)
				{
					_AnchoAutomat = true;
					int num3 = DT1.Columns.Count - 1;
					for (int j = 2; j <= num3; j++)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 4 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Insert", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				if (DT1.Rows.Count < 2)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Rows", new object[1] { 7 }, null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
				}
				else if (DT1.Rows.Count > 2)
				{
					int num4 = DT1.Rows.Count - 1;
					for (int k = 2; k <= num4; k++)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Rows", new object[1] { 8 }, null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Insert", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				if (_UsuarioExcel.Trim().Length > 0)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						3,
						DT1.Columns.Count + 1,
						"Impreso Por : " + _UsuarioExcel
					}, null, null);
				}
				if (_VerFechaExcel)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						5,
						DT1.Columns.Count + 1,
						"Impreso el : " + Conversions.ToString(DateTime.Now)
					}, null, null);
				}
				int _FILA = 7;
				int _COL = 2;
				int num5 = DT1.Rows.Count - 1;
				for (int l = 0; l <= num5; l++)
				{
					int num6 = DT1.Columns.Count - 1;
					for (int II = 0; II <= num6; II++)
					{
						NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
						{
							_FILA + l,
							_COL + II,
							RuntimeHelpers.GetObjectValue(DT1.Rows[l][II])
						}, null, null);
					}
				}
				int num7 = DT1.Columns.Count - 1;
				for (int m = 0; m <= num7; m++)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						6,
						_COL + m,
						DT1.Columns[m].ColumnName
					}, null, null);
				}
				object instance3 = oSheet;
				object[] array3 = new object[2];
				object[] array4 = array3;
				object obj2 = oSheet;
				object instance4 = obj2;
				array = new object[2];
				object[] array5 = array;
				int num8 = 2;
				array5[0] = num8;
				object[] array6 = array;
				int num9 = 2;
				array6[1] = num9;
				array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
				object[] array7 = array3;
				object obj3 = oSheet;
				object instance5 = obj3;
				object[] array8 = new object[2];
				object[] array9 = array8;
				int num10 = 2;
				array9[0] = num10;
				object[] array10 = array8;
				int num11 = DT1.Columns.Count + 1;
				array10[1] = num11;
				array7[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance5, null, "Cells", array8, null, null, null));
				object[] array11 = array3;
				object[] arguments2 = array11;
				array2 = new bool[2] { true, true };
				object instance6 = NewLateBinding.LateGet(instance3, null, "Range", arguments2, null, null, array2);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
					{
						num8,
						num9,
						RuntimeHelpers.GetObjectValue(array11[0])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (array2[1])
				{
					NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
					{
						num10,
						num11,
						RuntimeHelpers.GetObjectValue(array11[1])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				NewLateBinding.LateCall(instance6, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
				object instance7 = oSheet;
				array11 = new object[2];
				object[] array12 = array11;
				obj3 = oSheet;
				object instance8 = obj3;
				object[] array13 = new object[2];
				object[] array14 = array13;
				num11 = 4;
				array14[0] = num11;
				object[] array15 = array13;
				num10 = 2;
				array15[1] = num10;
				array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance8, null, "Cells", array13, null, null, null));
				object[] array16 = array11;
				obj2 = oSheet;
				object instance9 = obj2;
				object[] array17 = new object[2];
				object[] array18 = array17;
				num9 = 4;
				array18[0] = num9;
				object[] array19 = array17;
				num8 = DT1.Columns.Count + 1;
				array19[1] = num8;
				array16[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance9, null, "Cells", array17, null, null, null));
				array3 = array11;
				object[] arguments3 = array3;
				array2 = new bool[2] { true, true };
				object instance10 = NewLateBinding.LateGet(instance7, null, "Range", arguments3, null, null, array2);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
					{
						num11,
						num10,
						RuntimeHelpers.GetObjectValue(array3[0])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (array2[1])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
					{
						num9,
						num8,
						RuntimeHelpers.GetObjectValue(array3[1])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				NewLateBinding.LateCall(instance10, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
				if (_AnchoAutomat)
				{
					object instance11 = oSheet;
					array11 = new object[2];
					object[] array20 = array11;
					obj3 = oSheet;
					object instance12 = obj3;
					array13 = new object[2];
					object[] array21 = array13;
					num11 = 4;
					array21[0] = num11;
					object[] array22 = array13;
					num10 = 2;
					array22[1] = num10;
					array20[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance12, null, "Cells", array13, null, null, null));
					object[] array23 = array11;
					obj2 = oSheet;
					object instance13 = obj2;
					array17 = new object[2];
					object[] array24 = array17;
					num9 = 4;
					array24[0] = num9;
					object[] array25 = array17;
					num8 = DT1.Columns.Count + 1;
					array25[1] = num8;
					array23[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance13, null, "Cells", array17, null, null, null));
					array3 = array11;
					object[] arguments4 = array3;
					array2 = new bool[2] { true, true };
					object instance14 = NewLateBinding.LateGet(instance11, null, "Range", arguments4, null, null, array2);
					if (array2[0])
					{
						NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
						{
							num11,
							num10,
							RuntimeHelpers.GetObjectValue(array3[0])
						}, null, null, OptimisticSet: true, RValueBase: false);
					}
					if (array2[1])
					{
						NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
						{
							num9,
							num8,
							RuntimeHelpers.GetObjectValue(array3[1])
						}, null, null, OptimisticSet: true, RValueBase: false);
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(instance14, null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
				}
				if (DT1.TableName.Trim().Length > 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Name", new object[1] { DT1.TableName }, null, null, OptimisticSet: false, RValueBase: true);
				}
				if (DT1 != null)
				{
					DT1.Dispose();
					DT1 = null;
				}
				NewLateBinding.LateSet(oExcel, null, "Visible", new object[1] { true }, null, null);
				oBook = null;
				oSheet = null;
				instance = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			finally
			{
				oExcel = null;
			}
		}
	}
```

### frmBaseMant_Resize · líneas 2847–2850

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2847](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2847)

```csharp
private void frmBaseMant_Resize(object sender, EventArgs e)
	{
		Reubicar();
	}
```

### frmBaseMant · líneas 2852–2893

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2852](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2852)

```csharp
public frmBaseMant()
	{
		base.Resize += frmBaseMant_Resize;
		base.ReubicaCtrls += frmBaseMant_ReubicaCtrls;
		base.Load += frmBaseMant_Load;
		ToolTipTextChk = new ToolTip();
		iNroTabp = 0;
		sConnection = "";
		bEstablecerEdicion = true;
		bResizeAutomatic = true;
		bVerTitulo = true;
		mLblHorizontal = true;
		bNuevo = false;
		bEditar = false;
		bVerCMB1 = true;
		bVerLblCMB1 = true;
		bVerCMB2 = true;
		bVerLblCMB2 = true;
		bVerTituloTab = true;
		sTituloTab = "";
		bVerNuevo = true;
		bVerEditar = true;
		bVerGrabar = true;
		bVerCancelar = true;
		bVerSeleccionar = true;
		bVerEliminar = true;
		bVerBuscar = true;
		bVerRegrescar = true;
		bVerImprimir = true;
		bVerExcel = true;
		bVerSalir = true;
		bVerAyuda = true;
		_Vista = new DataView();
		CadSqlB = "";
		_TituloExcel = "Titulo";
		_SubTituloExcel = "Sub Titulo";
		_VerFechaExcel = true;
		_UsuarioExcel = "";
		_AnchoAutomat = false;
		InitializeComponent();
		Inicializar();
	}
```

### BTN_PRINT_Click · líneas 2895–2905

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2895](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2895)

```csharp
private void BTN_PRINT_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1)
		{
			bool bCancel = false;
			ClickImprimir?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_BUSCAR_Click · líneas 2907–2938

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2907](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2907)

```csharp
private void BTN_BUSCAR_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		ClickBuscar?.Invoke(ref bCancel);
		if (!bCancel && sCampoBuscaName != null && sCampoBuscaName.Length >= 1 && sCampoBuscaFiltrar != null && sCampoBuscaFiltrar.Length >= 1 && mCampoBuscaTipoDato != null && mCampoBuscaTipoDato.Length >= 1)
		{
			if (mCampoBuscaMaxLen == null || mCampoBuscaMaxLen.Length < sCampoBuscaName.Length)
			{
				mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[checked(sCampoBuscaName.Length - 1 + 1)]);
			}
			DT1 = (DataTable)DGV_DATOS.DataSource;
			DGV_BUSCAR.DataSource = DT1;
			CMB_OPCION.Items.Clear();
			CMB_OPCION.Items.AddRange(sCampoBuscaName);
			CMB_OPCION.SelectedIndex = 0;
			ActivaTab(2);
			DataGridView DGV = DGV_BUSCAR;
			ConfiguraDataGridView(ref DGV);
			DGV_BUSCAR = DGV;
			Config_DGVEventHandler config_DGVEvent = Config_DGV;
			if (config_DGVEvent != null)
			{
				DGV = DGV_BUSCAR;
				config_DGVEvent(ref DGV);
				DGV_BUSCAR = DGV;
			}
		}
	}
```

### CMB_OPCION_SelectedIndexChanged · líneas 2940–2959

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2940](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2940)

```csharp
private void CMB_OPCION_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool bCancel = false;
		CmdBuscarIndexChanged?.Invoke(CMB_OPCION.SelectedIndex, ref bCancel);
		if (!bCancel)
		{
			if (mCampoBuscaMaxLen.Length < sCampoBuscaName.Length)
			{
				mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[checked(sCampoBuscaName.Length - 1 + 1)]);
			}
			TXT_BUSCA.Clear();
			TXT_BUSCA.MaxLength = mCampoBuscaMaxLen[CMB_OPCION.SelectedIndex];
			LBL_DEL.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			DTP_FI.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			LBL_AL.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			DTP_FF.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			TXT_BUSCA.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha;
			CHK_ITERACTIVO.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha;
		}
	}
```

### BTN_REFRESH_Click · líneas 2961–2968

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2961](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2961)

```csharp
private void BTN_REFRESH_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickRefrescar?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### BTN_DEL_Click · líneas 2970–2980

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2970](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2970)

```csharp
private void BTN_DEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1 && DGV_DATOS.SelectedCells.Count >= 1)
		{
			bool bCancel = false;
			ClickEliminar?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_CANCEL_Click · líneas 2982–2997

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2982](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2982)

```csharp
private void BTN_CANCEL_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickCancelar?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (GuardarySalir)
			{
				Close();
				return;
			}
			bNuevo = false;
			bEditar = false;
			ActivaTab(0);
		}
	}
```

### BTN_SAVE_Click · líneas 2999–3043

[Software/GRLL/GRLL/Common/frmBaseMant.cs:2999](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L2999)

```csharp
private void BTN_SAVE_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ValidarGrabar?.Invoke(bNuevo, ref bCancel);
		if (bCancel)
		{
			return;
		}
		bool bCargarDatos = false;
		ClickGrabar?.Invoke(ref bCancel, bNuevo, ref bCargarDatos);
		if (bCancel)
		{
			return;
		}
		bNuevo = false;
		bEditar = false;
		if (GuardarySalir)
		{
			Close();
			return;
		}
		ActivaTab(0);
		if (!bCargarDatos)
		{
			return;
		}
		if (VerCMB2)
		{
			Cmb2SelectedIndexChangedEventHandler cmb2SelectedIndexChangedEvent = Cmb2SelectedIndexChanged;
			if (cmb2SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb2SelectedIndexChangedEvent(ref Cancelar);
			}
		}
		else if (VerCMB1)
		{
			Cmb1SelectedIndexChangedEventHandler cmb1SelectedIndexChangedEvent = Cmb1SelectedIndexChanged;
			if (cmb1SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb1SelectedIndexChangedEvent(ref Cancelar);
			}
		}
	}
```

### BTN_EDIT_Click · líneas 3045–3070

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3045](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3045)

```csharp
private void BTN_EDIT_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bEditar = true;
		ClearCtrls?.Invoke();
		if (DGV_DATOS.Visible)
		{
			if (DGV_DATOS.Rows.Count < 1 || DGV_DATOS.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: true, ref bCancel);
		}
		else
		{
			if (!DGV_BUSCAR.Visible || DGV_BUSCAR.Rows.Count < 1 || DGV_BUSCAR.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: false, ref bCancel);
		}
		if (!bCancel && EstablecerEdicion)
		{
			ActivaTab(1);
		}
	}
```

### BTN_NEW_Click · líneas 3072–3085

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3072](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3072)

```csharp
private void BTN_NEW_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bNuevo = true;
		ClickNuevo?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (EstablecerEdicion)
			{
				ActivaTab(1);
			}
			ClearCtrls?.Invoke();
		}
	}
```

### BTN_SELEC_Click · líneas 3087–3099

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3087](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3087)

```csharp
private void BTN_SELEC_Click(object sender, EventArgs e)
	{
		if (DGV_BUSCAR.DataSource != null && DGV_BUSCAR.Rows.Count >= 1 && DGV_BUSCAR.SelectedCells.Count >= 1)
		{
			ClearCtrls?.Invoke();
			bool bCancel = false;
			ClickSeleccionar?.Invoke(ref bCancel);
			if (!bCancel)
			{
				ActivaTab(1);
			}
		}
	}
```

### CMB_1_SelectedIndexChanged · líneas 3101–3118

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3101](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3101)

```csharp
private void CMB_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (VerCMB2)
		{
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
		}
		else
		{
			DGV_DATOS.DataSource = null;
			DGV_DATOS.Rows.Clear();
		}
		bool bCancel = false;
		Cmb1SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### CMB_2_SelectedIndexChanged · líneas 3120–3129

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3120](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3120)

```csharp
private void CMB_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		DGV_DATOS.DataSource = null;
		DGV_DATOS.Rows.Clear();
		bool bCancel = false;
		Cmb2SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### CHK_ITERACTIVO_CheckedChanged · líneas 3131–3134

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3131](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3131)

```csharp
private void CHK_ITERACTIVO_CheckedChanged(object sender, EventArgs e)
	{
		CMD_BUSCAR.Enabled = !CHK_ITERACTIVO.Checked;
	}
```

### frmBaseMant_ReubicaCtrls · líneas 3136–3139

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3136](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3136)

```csharp
private void frmBaseMant_ReubicaCtrls()
	{
		Reubicar();
	}
```

### BTN_HELP_Click · líneas 3141–3144

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3141](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3141)

```csharp
private void BTN_HELP_Click(object sender, EventArgs e)
	{
		ClickAyuda?.Invoke();
	}
```

### TXT_BUSCA_TextChanged · líneas 3146–3152

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3146](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3146)

```csharp
private void TXT_BUSCA_TextChanged(object sender, EventArgs e)
	{
		if (CHK_ITERACTIVO.Checked)
		{
			CMD_BUSCAR.PerformClick();
		}
	}
```

### CMD_BUSCAR_Click · líneas 3154–3193

[Software/GRLL/GRLL/Common/frmBaseMant.cs:3154](../../Software/GRLL/GRLL/Common/frmBaseMant.cs#L3154)

```csharp
private void CMD_BUSCAR_Click(object sender, EventArgs e)
	{
		if (CMB_OPCION.SelectedIndex >= 0 && mCampoBuscaTipoDato.Length >= CMB_OPCION.SelectedIndex && DGV_DATOS.DataSource != null)
		{
			if (mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha)
			{
			}
			string CadStr = "";
			switch (mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex])
			{
			case clsVariables.TipoDato.Fecha:
				CadStr = CadSqlB + " CONVERT( VARCHAR(10), " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + ", 112) BETWEEN " + Strings.Format(DTP_FI.Value, "yyyyMMdd") + " AND " + Strings.Format(DTP_FF.Value, "yyyyMMdd");
				break;
			case clsVariables.TipoDato.LetrasConEspacio:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.LetrasSinEspacio:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.LetrasyNumeros:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.NumeroConSigno:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.NumeroEntero:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.NumeroSinSigno:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.Todo:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			}
			_Vista = DT1.DefaultView;
			_Vista.RowFilter = CadStr;
			DGV_BUSCAR.DataSource = _Vista;
		}
	}
```

<a id="f-085"></a>

## frmMantBaseFTS


### BTN_SALIR_Click · líneas 2166–2184

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2166](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2166)

```csharp
private void BTN_SALIR_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickSalir?.Invoke(ref bCancel);
		if (bCancel)
		{
			return;
		}
		try
		{
			Salir();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBaseMant_Load · líneas 2186–2200

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2186](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2186)

```csharp
private void frmBaseMant_Load(object sender, EventArgs e)
	{
		LBL_DEL.Visible = false;
		DTP_FI.Visible = false;
		LBL_AL.Visible = false;
		DTP_FF.Visible = false;
		TXT_BUSCA.Visible = true;
		CHK_ITERACTIVO.Visible = true;
		ActivaTab(iNroTabp);
		ToolTipTextChk.SetToolTip(CHK_ITERACTIVO, "Busqueda Iteractiva");
		ToolTipTextChk.Active = true;
		ToolStrip tStMenu = TStMenu;
		Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
		tStMenu.Location = location;
	}
```

### ActivaTab · líneas 2202–2260

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2202](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2202)

```csharp
private void ActivaTab(object NroTab)
	{
		TAB_LIST.Visible = false;
		TAB_EDICION.Visible = false;
		TAB_BUSCAR.Visible = false;
		if (Operators.ConditionalCompareObjectEqual(NroTab, 0, TextCompare: false))
		{
			TAB_LIST.Visible = true;
			FTS.SelectedItem = TAB_LIST;
			TStMenu.Items["BTN_NEW"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerNuevo, true, false));
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = false;
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerBuscar, true, false));
			TStMenu.Items["BTN_REFRESH"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerRegrescar, true, false));
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 1, TextCompare: false))
		{
			TAB_EDICION.Visible = true;
			FTS.SelectedItem = TAB_EDICION;
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = false;
			TStMenu.Items["BTN_SAVE"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerGrabar, true, false));
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = false;
			TStMenu.Items["BTN_PRINT"].Visible = false;
			TStMenu.Items["BTN_EXCEL"].Visible = false;
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 2, TextCompare: false))
		{
			TAB_BUSCAR.Visible = true;
			FTS.SelectedItem = TAB_BUSCAR;
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSeleccionar, true, false));
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		Reubicar();
		FTS.AlwaysShowMenuGlyph = false;
	}
```

### GetData · líneas 2262–2302

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2262](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2262)

```csharp
private DataTable GetData(string sSql)
	{
		DataTable Dt = new DataTable();
		SqlDataAdapter da = ((cConnection != null) ? new SqlDataAdapter(sSql, cConnection) : new SqlDataAdapter(sSql, sConnection));
		DataTable GetData;
		try
		{
			da.Fill(Dt);
			GetData = Dt;
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError(ex);
			SqlException ex2 = ex;
			ClsFunciones.MuestraMsj(ex2);
			GetData = null;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ClsFunciones.MuestraMsj(ex4);
			GetData = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (Dt != null)
			{
				Dt.Dispose();
				Dt = null;
			}
			if (da != null)
			{
				da.Dispose();
				da = null;
			}
		}
		return GetData;
	}
```

### ListarCmb · líneas 2304–2324

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2304](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2304)

```csharp
public void ListarCmb(int NroCmb, string sSql, string sMuestra, string sId)
	{
		DataTable Dt = GetData(sSql);
		switch (NroCmb)
		{
		case 1:
			CMB_1.DataSource = null;
			CMB_1.Items.Clear();
			CMB_1.DisplayMember = sMuestra;
			CMB_1.ValueMember = sId;
			CMB_1.DataSource = Dt;
			break;
		case 2:
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
			CMB_2.DisplayMember = sMuestra;
			CMB_2.ValueMember = sId;
			CMB_2.DataSource = Dt;
			break;
		}
	}
```

### ConfiguraDataGridView · líneas 2326–2338

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2326](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2326)

```csharp
private void ConfiguraDataGridView(ref DataGridView DGV)
	{
		DGV.AllowUserToAddRows = false;
		DGV.AllowUserToDeleteRows = false;
		DGV.AllowUserToOrderColumns = true;
		DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
		DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DGV.EditMode = DataGridViewEditMode.EditProgrammatically;
		DGV.ReadOnly = true;
		DGV.RowHeadersVisible = false;
		DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 239, 240);
	}
```

### ListarDGV · líneas 2340–2348

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2340](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2340)

```csharp
public void ListarDGV(ref bool GrigDatos, string sSql)
	{
		DataGridView DGV = ((!GrigDatos) ? DGV_BUSCAR : DGV_DATOS);
		ConfiguraDataGridView(ref DGV);
		DGV.DataSource = null;
		DGV.DataSource = GetData(sSql);
		DGV.TabIndex = 0;
		Config_DGV?.Invoke(ref DGV);
	}
```

### AlineaCMBs · líneas 2350–2441

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2350](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2350)

```csharp
private void AlineaCMBs()
	{
		if (!bResizeAutomatic)
		{
			return;
		}
		int iTopLbl = 0;
		int iLeftLbl = 0;
		int iCtaCMBs = 0;
		iCtaCMBs = Conversions.ToInteger(Operators.AddObject(Interaction.IIf(bVerCMB1, 1, 0), Interaction.IIf(bVerCMB2, 1, 0)));
		checked
		{
			Point location;
			if (mLblHorizontal)
			{
				iTopLbl = 10;
				iLeftLbl = 2;
				Label lBL_COMBO = LBL_COMBO1;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO.Location = location;
				if (bVerLblCMB1)
				{
					iLeftLbl += LBL_COMBO1.Width + 2;
				}
				ComboBox cMB_ = CMB_1;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_.Location = location;
				ComboBox cMB_2 = CMB_1;
				Size size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - (double)iLeftLbl - 4.0), CMB_1.Height);
				cMB_2.Size = size;
				if (bVerCMB1)
				{
					iLeftLbl += CMB_1.Width + 4;
				}
				Label lBL_COMBO2 = LBL_COMBO2;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO2.Location = location;
				if (bVerLblCMB2)
				{
					iLeftLbl += LBL_COMBO2.Width + 2;
				}
				ComboBox cMB_3 = CMB_2;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_3.Location = location;
				ComboBox cMB_4 = CMB_2;
				size = new Size(Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((double)(FTS.Width - 8) / 2.0, Interaction.IIf(bVerLblCMB2, LBL_COMBO2.Width, 0)), 3)), CMB_2.Height);
				cMB_4.Size = size;
				if (bVerLblCMB1 || bVerCMB1 || bVerLblCMB2 || bVerCMB1)
				{
					iTopLbl = Conversions.ToInteger(Operators.AddObject(iTopLbl, Operators.AddObject(Interaction.IIf(LBL_COMBO1.Height > CMB_1.Height, LBL_COMBO1.Height, CMB_1.Height), 2)));
				}
				mTopGrid = (short)iTopLbl;
			}
			else
			{
				iTopLbl = 6;
				iLeftLbl = 2;
				Label lBL_COMBO3 = LBL_COMBO1;
				location = new Point(iLeftLbl + 2, iTopLbl);
				lBL_COMBO3.Location = location;
				Label lBL_COMBO4 = LBL_COMBO2;
				location = new Point((int)Math.Round((double)(FTS.Width - 8) / 2.0 + 2.0), iTopLbl);
				lBL_COMBO4.Location = location;
				if (bVerLblCMB1 || bVerLblCMB2)
				{
					iTopLbl += LBL_COMBO1.Height + 2;
				}
				ComboBox cMB_5 = CMB_1;
				location = new Point(2, iTopLbl);
				cMB_5.Location = location;
				ComboBox cMB_6 = CMB_1;
				Size size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - 6.0), CMB_1.Height);
				cMB_6.Size = size;
				ComboBox cMB_7 = CMB_2;
				location = new Point((int)Math.Round((double)(FTS.Width - 8) / 2.0 + 2.0), iTopLbl);
				cMB_7.Location = location;
				ComboBox cMB_8 = CMB_2;
				size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - 4.0), CMB_1.Height);
				cMB_8.Size = size;
				if (bVerCMB1 || bVerCMB2)
				{
					iTopLbl += CMB_1.Height + 2;
				}
				mTopGrid = (short)iTopLbl;
			}
			DataGridView dGV_DATOS = DGV_DATOS;
			location = new Point(2, mTopGrid);
			dGV_DATOS.Location = location;
			DGV_DATOS.Height = FTS.Size.Height - 26 - 4 - DGV_DATOS.Location.Y;
			DGV_DATOS.Width = FTS.Width - 8 - 4;
		}
	}
```

### Inicializar · líneas 2443–2448

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2443](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2443)

```csharp
private void Inicializar()
	{
		bResizeAutomatic = true;
		bVerTitulo = true;
		mTopGrid = 25;
	}
```

### Reubicar · líneas 2450–2528

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2450](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2450)

```csharp
private void Reubicar()
	{
		int nTop = Conversions.ToInteger(Interaction.IIf(VerPanelSup, PanelSup.Height, 10));
		checked
		{
			if (bResizeAutomatic)
			{
				if (bVerTituloTab)
				{
					nTop = LBL_TITLULO.Top + LBL_TITLULO.Height;
				}
				nTop += 4;
				FATabStrip fTS = FTS;
				Point location = new Point(10, nTop);
				fTS.Location = location;
				LBL_TITLULO.Left = 0;
				LBL_TITLULO.Width = Width - 10;
				FATabStrip fTS2 = FTS;
				Size size = new Size(LBL_TITLULO.Width - 20, Conversions.ToInteger(Operators.SubtractObject(ClientSize.Height - TStMenu.Height - 2 - nTop, Interaction.IIf(VerPanelInf, PanelInf.Height, 0))));
				fTS2.Size = size;
				nTop += FTS.Height + 2;
				if (ClientSize.Width > TStMenu.Width)
				{
					location = (TStMenu.Location = new Point((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0), nTop));
				}
				else
				{
					ToolStrip tStMenu = TStMenu;
					location = new Point(2, nTop);
					tStMenu.Location = location;
				}
				AlineaCMBs();
				if ((double)(FTS.Width - 8) / 3.0 < (double)(FTS.Width - 10 - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2 + CMD_BUSCAR.Width)))
				{
					CMB_OPCION.Width = (int)Math.Round((double)(FTS.Width - 8) / 3.0);
				}
				else
				{
					CMB_OPCION.Width = FTS.Width - 10 - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2 + CMD_BUSCAR.Width);
				}
				ComboBox cMB_OPCION = CMB_OPCION;
				location = new Point(2, 8);
				cMB_OPCION.Location = location;
				ucText tXT_BUSCA = TXT_BUSCA;
				location = new Point(2 + CMB_OPCION.Width + 4, 8);
				tXT_BUSCA.Location = location;
				TXT_BUSCA.Width = FTS.Width - 8 - CMB_OPCION.Width - CHK_ITERACTIVO.Width - CMD_BUSCAR.Width - 10;
				CheckBox cHK_ITERACTIVO = CHK_ITERACTIVO;
				location = TXT_BUSCA.Location;
				Point location2 = new Point(location.X + TXT_BUSCA.Width + 2, 12);
				cHK_ITERACTIVO.Location = location2;
				Button cMD_BUSCAR = CMD_BUSCAR;
				location2 = new Point(FTS.Width - 8 - CMD_BUSCAR.Width - 2, 8);
				cMD_BUSCAR.Location = location2;
				int Xi = 2 + CMB_OPCION.Width + 4;
				int Xf = CMD_BUSCAR.Location.X;
				int Xd = Xf - Xi - (LBL_DEL.Width + 2 + DTP_FI.Width + 2 + LBL_AL.Width + 2 + DTP_FF.Width + 2);
				Label lBL_DEL = LBL_DEL;
				location2 = new Point((int)Math.Round((double)Xi + (double)Xd / 2.0), 12);
				lBL_DEL.Location = location2;
				location = (DTP_FI.Location = new Point(LBL_DEL.Location.X + LBL_DEL.Width + 2, 8));
				location = (LBL_AL.Location = new Point(DTP_FI.Location.X + DTP_FI.Width + 2, 12));
				location = (DTP_FF.Location = new Point(LBL_AL.Location.X + LBL_AL.Width + 2, 8));
				DTP_FI.Value = new DateTime(633347424000000000L);
				DTP_FF.Value = new DateTime(633662784000000000L);
				location = (DGV_BUSCAR.Location = new Point(2, TXT_BUSCA.Location.Y + TXT_BUSCA.Height + 2));
				DGV_BUSCAR.Height = FTS.Size.Height - 26 - 4 - DGV_BUSCAR.Location.Y;
				DGV_BUSCAR.Width = FTS.Width - 8 - 4;
			}
			if (!VerPanelSup)
			{
				PanelSup.Top = Height + 50;
			}
			if (!VerPanelInf)
			{
				PanelInf.Top = Height + 50;
			}
		}
	}
```

### DGV_DATOS_CellContentClick · líneas 2530–2532

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2530](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2530)

```csharp
private void DGV_DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
```

### DGV_DATOS_CellFormatting · líneas 2534–2537

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2534](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2534)

```csharp
private void DGV_DATOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DGV_DATOS_CellMouseDoubleClick · líneas 2539–2542

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2539](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2539)

```csharp
private void DGV_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_EDIT.PerformClick();
	}
```

### DGV_BUSCAR_CellFormatting · líneas 2544–2547

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2544](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2544)

```csharp
private void DGV_BUSCAR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DTG_BUSCAR_CellMouseDoubleClick · líneas 2549–2552

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2549](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2549)

```csharp
private void DTG_BUSCAR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_SELEC.PerformClick();
	}
```

### BTN_EXCEL_Click · líneas 2554–2584

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2554](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2554)

```csharp
private void BTN_EXCEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		DT1 = null;
		ClickExportarExcel?.Invoke(ref bCancel, ref DT1);
		if (bCancel)
		{
			return;
		}
		if (DT1 == null)
		{
			if (Operators.CompareString(FTS.SelectedItem.Name, TAB_LIST.Name, TextCompare: false) == 0)
			{
				DT1 = (DataTable)DGV_DATOS.DataSource;
			}
			else
			{
				if (Operators.CompareString(FTS.SelectedItem.Name, TAB_BUSCAR.Name, TextCompare: false) != 0)
				{
					return;
				}
				DT1 = (DataTable)DGV_BUSCAR.DataSource;
			}
		}
		ClsExcel oCls = new ClsExcel();
		oCls.ExportaExcel(DT1, _TituloExcel, _SubTituloExcel, _AnchoAutomat, _UsuarioExcel, _VerFechaExcel);
	}
```

### frmBaseMant_Resize · líneas 2586–2589

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2586](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2586)

```csharp
private void frmBaseMant_Resize(object sender, EventArgs e)
	{
		Reubicar();
	}
```

### frmMantBaseFTS · líneas 2591–2632

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2591](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2591)

```csharp
public frmMantBaseFTS()
	{
		base.Resize += frmBaseMant_Resize;
		base.ReubicaCtrls += frmBaseMant_ReubicaCtrls;
		base.Load += frmBaseMant_Load;
		ToolTipTextChk = new ToolTip();
		iNroTabp = 0;
		sConnection = "";
		bEstablecerEdicion = true;
		bResizeAutomatic = true;
		bVerTitulo = true;
		mLblHorizontal = true;
		bNuevo = false;
		bEditar = false;
		bVerCMB1 = true;
		bVerLblCMB1 = true;
		bVerCMB2 = true;
		bVerLblCMB2 = true;
		bVerTituloTab = true;
		sTituloTab = "";
		bVerNuevo = true;
		bVerEditar = true;
		bVerGrabar = true;
		bVerCancelar = true;
		bVerSeleccionar = true;
		bVerEliminar = true;
		bVerBuscar = true;
		bVerRegrescar = true;
		bVerImprimir = true;
		bVerExcel = true;
		bVerSalir = true;
		bVerAyuda = true;
		_Vista = new DataView();
		CadSqlB = "";
		_TituloExcel = "Titulo";
		_SubTituloExcel = "Sub Titulo";
		_VerFechaExcel = true;
		_UsuarioExcel = "";
		_AnchoAutomat = false;
		InitializeComponent();
		Inicializar();
	}
```

### BTN_PRINT_Click · líneas 2634–2644

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2634](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2634)

```csharp
private void BTN_PRINT_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1)
		{
			bool bCancel = false;
			ClickImprimir?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_BUSCAR_Click · líneas 2646–2677

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2646](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2646)

```csharp
private void BTN_BUSCAR_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		ClickBuscar?.Invoke(ref bCancel);
		if (!bCancel && sCampoBuscaName != null && sCampoBuscaName.Length >= 1 && sCampoBuscaFiltrar != null && sCampoBuscaFiltrar.Length >= 1 && mCampoBuscaTipoDato != null && mCampoBuscaTipoDato.Length >= 1)
		{
			if (mCampoBuscaMaxLen == null || mCampoBuscaMaxLen.Length < sCampoBuscaName.Length)
			{
				mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[checked(sCampoBuscaName.Length - 1 + 1)]);
			}
			DT1 = (DataTable)DGV_DATOS.DataSource;
			DGV_BUSCAR.DataSource = DT1;
			CMB_OPCION.Items.Clear();
			CMB_OPCION.Items.AddRange(sCampoBuscaName);
			CMB_OPCION.SelectedIndex = 0;
			ActivaTab(2);
			DataGridView DGV = DGV_BUSCAR;
			ConfiguraDataGridView(ref DGV);
			DGV_BUSCAR = DGV;
			Config_DGVEventHandler config_DGVEvent = Config_DGV;
			if (config_DGVEvent != null)
			{
				DGV = DGV_BUSCAR;
				config_DGVEvent(ref DGV);
				DGV_BUSCAR = DGV;
			}
		}
	}
```

### CMB_OPCION_SelectedIndexChanged · líneas 2679–2698

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2679](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2679)

```csharp
private void CMB_OPCION_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool bCancel = false;
		CmdBuscarIndexChanged?.Invoke(CMB_OPCION.SelectedIndex, ref bCancel);
		if (!bCancel)
		{
			if (mCampoBuscaMaxLen.Length < sCampoBuscaName.Length)
			{
				mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[checked(sCampoBuscaName.Length - 1 + 1)]);
			}
			TXT_BUSCA.Clear();
			TXT_BUSCA.MaxLength = mCampoBuscaMaxLen[CMB_OPCION.SelectedIndex];
			LBL_DEL.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			DTP_FI.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			LBL_AL.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			DTP_FF.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] == clsVariables.TipoDato.Fecha;
			TXT_BUSCA.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha;
			CHK_ITERACTIVO.Visible = mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha;
		}
	}
```

### BTN_REFRESH_Click · líneas 2700–2707

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2700](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2700)

```csharp
private void BTN_REFRESH_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickRefrescar?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### BTN_DEL_Click · líneas 2709–2719

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2709](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2709)

```csharp
private void BTN_DEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1 && DGV_DATOS.SelectedCells.Count >= 1)
		{
			bool bCancel = false;
			ClickEliminar?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_CANCEL_Click · líneas 2721–2736

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2721](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2721)

```csharp
private void BTN_CANCEL_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickCancelar?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (GuardarySalir)
			{
				Close();
				return;
			}
			bNuevo = false;
			bEditar = false;
			ActivaTab(0);
		}
	}
```

### BTN_SAVE_Click · líneas 2738–2782

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2738](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2738)

```csharp
private void BTN_SAVE_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ValidarGrabar?.Invoke(bNuevo, ref bCancel);
		if (bCancel)
		{
			return;
		}
		bool bCargarDatos = false;
		ClickGrabar?.Invoke(ref bCancel, bNuevo, ref bCargarDatos);
		if (bCancel)
		{
			return;
		}
		bNuevo = false;
		bEditar = false;
		if (GuardarySalir)
		{
			Close();
			return;
		}
		ActivaTab(0);
		if (!bCargarDatos)
		{
			return;
		}
		if (VerCMB2)
		{
			Cmb2SelectedIndexChangedEventHandler cmb2SelectedIndexChangedEvent = Cmb2SelectedIndexChanged;
			if (cmb2SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb2SelectedIndexChangedEvent(ref Cancelar);
			}
		}
		else if (VerCMB1)
		{
			Cmb1SelectedIndexChangedEventHandler cmb1SelectedIndexChangedEvent = Cmb1SelectedIndexChanged;
			if (cmb1SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb1SelectedIndexChangedEvent(ref Cancelar);
			}
		}
	}
```

### BTN_EDIT_Click · líneas 2784–2809

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2784](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2784)

```csharp
private void BTN_EDIT_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bEditar = true;
		ClearCtrls?.Invoke();
		if (DGV_DATOS.Visible)
		{
			if (DGV_DATOS.Rows.Count < 1 || DGV_DATOS.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: true, ref bCancel);
		}
		else
		{
			if (!DGV_BUSCAR.Visible || DGV_BUSCAR.Rows.Count < 1 || DGV_BUSCAR.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: false, ref bCancel);
		}
		if (!bCancel && EstablecerEdicion)
		{
			ActivaTab(1);
		}
	}
```

### BTN_NEW_Click · líneas 2811–2824

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2811](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2811)

```csharp
private void BTN_NEW_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bNuevo = true;
		ClickNuevo?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (EstablecerEdicion)
			{
				ActivaTab(1);
			}
			ClearCtrls?.Invoke();
		}
	}
```

### BTN_SELEC_Click · líneas 2826–2838

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2826](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2826)

```csharp
private void BTN_SELEC_Click(object sender, EventArgs e)
	{
		if (DGV_BUSCAR.DataSource != null && DGV_BUSCAR.Rows.Count >= 1 && DGV_BUSCAR.SelectedCells.Count >= 1)
		{
			ClearCtrls?.Invoke();
			bool bCancel = false;
			ClickSeleccionar?.Invoke(ref bCancel);
			if (!bCancel)
			{
				ActivaTab(1);
			}
		}
	}
```

### CMB_1_SelectedIndexChanged · líneas 2840–2857

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2840](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2840)

```csharp
private void CMB_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (VerCMB2)
		{
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
		}
		else
		{
			DGV_DATOS.DataSource = null;
			DGV_DATOS.Rows.Clear();
		}
		bool bCancel = false;
		Cmb1SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### CMB_2_SelectedIndexChanged · líneas 2859–2868

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2859](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2859)

```csharp
private void CMB_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		DGV_DATOS.DataSource = null;
		DGV_DATOS.Rows.Clear();
		bool bCancel = false;
		Cmb2SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### CHK_ITERACTIVO_CheckedChanged · líneas 2870–2873

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2870](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2870)

```csharp
private void CHK_ITERACTIVO_CheckedChanged(object sender, EventArgs e)
	{
		CMD_BUSCAR.Enabled = !CHK_ITERACTIVO.Checked;
	}
```

### frmBaseMant_ReubicaCtrls · líneas 2875–2878

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2875](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2875)

```csharp
private void frmBaseMant_ReubicaCtrls()
	{
		Reubicar();
	}
```

### BTN_HELP_Click · líneas 2880–2883

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2880](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2880)

```csharp
private void BTN_HELP_Click(object sender, EventArgs e)
	{
		ClickAyuda?.Invoke();
	}
```

### TXT_BUSCA_TextChanged · líneas 2885–2891

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2885](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2885)

```csharp
private void TXT_BUSCA_TextChanged(object sender, EventArgs e)
	{
		if (CHK_ITERACTIVO.Checked)
		{
			CMD_BUSCAR.PerformClick();
		}
	}
```

### CMD_BUSCAR_Click · líneas 2893–2932

[Software/GRLL/GRLL/Common/frmMantBaseFTS.cs:2893](../../Software/GRLL/GRLL/Common/frmMantBaseFTS.cs#L2893)

```csharp
private void CMD_BUSCAR_Click(object sender, EventArgs e)
	{
		if (CMB_OPCION.SelectedIndex >= 0 && mCampoBuscaTipoDato.Length >= CMB_OPCION.SelectedIndex && DGV_DATOS.DataSource != null)
		{
			if (mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex] != clsVariables.TipoDato.Fecha)
			{
			}
			string CadStr = "";
			switch (mCampoBuscaTipoDato[CMB_OPCION.SelectedIndex])
			{
			case clsVariables.TipoDato.Fecha:
				CadStr = CadSqlB + " CONVERT( VARCHAR(10), " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + ", 112) BETWEEN " + Strings.Format(DTP_FI.Value, "yyyyMMdd") + " AND " + Strings.Format(DTP_FF.Value, "yyyyMMdd");
				break;
			case clsVariables.TipoDato.LetrasConEspacio:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.LetrasSinEspacio:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.LetrasyNumeros:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			case clsVariables.TipoDato.NumeroConSigno:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.NumeroEntero:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.NumeroSinSigno:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like %" + TXT_BUSCA.Text;
				break;
			case clsVariables.TipoDato.Todo:
				CadStr = CadSqlB + " " + sCampoBuscaFiltrar[CMB_OPCION.SelectedIndex] + " Like '%" + TXT_BUSCA.Text + "%'";
				break;
			}
			_Vista = DT1.DefaultView;
			_Vista.RowFilter = CadStr;
			DGV_BUSCAR.DataSource = _Vista;
		}
	}
```

<a id="f-086"></a>

## frmMantBaseFTSb


### BTN_SALIR_Click · líneas 1784–1802

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1784](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1784)

```csharp
private void BTN_SALIR_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickSalir?.Invoke(ref bCancel);
		if (bCancel)
		{
			return;
		}
		try
		{
			Salir();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
```

### frmBaseMant_Load · líneas 1804–1810

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1804](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1804)

```csharp
private void frmBaseMant_Load(object sender, EventArgs e)
	{
		ActivaTab(iNroTabp);
		ToolStrip tStMenu = TStMenu;
		Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
		tStMenu.Location = location;
	}
```

### ActivaTab · líneas 1812–1870

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1812](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1812)

```csharp
private void ActivaTab(object NroTab)
	{
		TAB_LIST.Visible = false;
		TAB_EDICION.Visible = false;
		TAB_BUSCAR.Visible = false;
		if (Operators.ConditionalCompareObjectEqual(NroTab, 0, TextCompare: false))
		{
			TAB_LIST.Visible = true;
			FTS.SelectedItem = TAB_LIST;
			TStMenu.Items["BTN_NEW"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerNuevo, true, false));
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = false;
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerBuscar, true, false));
			TStMenu.Items["BTN_REFRESH"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerRegrescar, true, false));
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 1, TextCompare: false))
		{
			TAB_EDICION.Visible = true;
			FTS.SelectedItem = TAB_EDICION;
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = false;
			TStMenu.Items["BTN_SAVE"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerGrabar, true, false));
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = false;
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = false;
			TStMenu.Items["BTN_PRINT"].Visible = false;
			TStMenu.Items["BTN_EXCEL"].Visible = false;
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		else if (Operators.ConditionalCompareObjectEqual(NroTab, 2, TextCompare: false))
		{
			TAB_BUSCAR.Visible = true;
			FTS.SelectedItem = TAB_BUSCAR;
			TStMenu.Items["BTN_NEW"].Visible = false;
			TStMenu.Items["BTN_EDIT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEditar, true, false));
			TStMenu.Items["BTN_SAVE"].Visible = false;
			TStMenu.Items["BTN_CANCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerCancelar, true, false));
			TStMenu.Items["BTN_SELEC"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSeleccionar, true, false));
			TStMenu.Items["BTN_BUSCAR"].Visible = false;
			TStMenu.Items["BTN_REFRESH"].Visible = false;
			TStMenu.Items["BTN_DEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerEliminar, true, false));
			TStMenu.Items["BTN_PRINT"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerImprimir, true, false));
			TStMenu.Items["BTN_EXCEL"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerExcel, true, false));
			TStMenu.Items["BTN_SALIR"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerSalir, true, false));
			TStMenu.Items["BTN_HELP"].Visible = Conversions.ToBoolean(Interaction.IIf(bVerAyuda, true, false));
		}
		Reubicar();
		FTS.AlwaysShowMenuGlyph = false;
	}
```

### GetData · líneas 1872–1912

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1872](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1872)

```csharp
private DataTable GetData(string sSql)
	{
		DataTable Dt = new DataTable();
		SqlDataAdapter da = ((cConnection != null) ? new SqlDataAdapter(sSql, cConnection) : new SqlDataAdapter(sSql, sConnection));
		DataTable GetData;
		try
		{
			da.Fill(Dt);
			GetData = Dt;
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError(ex);
			SqlException ex2 = ex;
			ClsFunciones.MuestraMsj(ex2);
			GetData = null;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ClsFunciones.MuestraMsj(ex4);
			GetData = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (Dt != null)
			{
				Dt.Dispose();
				Dt = null;
			}
			if (da != null)
			{
				da.Dispose();
				da = null;
			}
		}
		return GetData;
	}
```

### ListarCmb · líneas 1914–1934

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1914](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1914)

```csharp
public void ListarCmb(int NroCmb, string sSql, string sMuestra, string sId)
	{
		DataTable Dt = GetData(sSql);
		switch (NroCmb)
		{
		case 1:
			CMB_1.DataSource = null;
			CMB_1.Items.Clear();
			CMB_1.DisplayMember = sMuestra;
			CMB_1.ValueMember = sId;
			CMB_1.DataSource = Dt;
			break;
		case 2:
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
			CMB_2.DisplayMember = sMuestra;
			CMB_2.ValueMember = sId;
			CMB_2.DataSource = Dt;
			break;
		}
	}
```

### ConfiguraDataGridView · líneas 1936–1948

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1936](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1936)

```csharp
private void ConfiguraDataGridView(ref DataGridView DGV)
	{
		DGV.AllowUserToAddRows = false;
		DGV.AllowUserToDeleteRows = false;
		DGV.AllowUserToOrderColumns = true;
		DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
		DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DGV.EditMode = DataGridViewEditMode.EditProgrammatically;
		DGV.ReadOnly = true;
		DGV.RowHeadersVisible = false;
		DGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 239, 240);
	}
```

### ListarDGV · líneas 1950–1958

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1950](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1950)

```csharp
public void ListarDGV(ref bool GrigDatos, string sSql)
	{
		DataGridView DGV = ((!GrigDatos) ? DGV_BUSCAR : DGV_DATOS);
		ConfiguraDataGridView(ref DGV);
		DGV.DataSource = null;
		DGV.DataSource = GetData(sSql);
		DGV.TabIndex = 0;
		Config_DGV?.Invoke(ref DGV);
	}
```

### AlineaCMBs · líneas 1960–2051

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:1960](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L1960)

```csharp
private void AlineaCMBs()
	{
		if (!bResizeAutomatic)
		{
			return;
		}
		int iTopLbl = 0;
		int iLeftLbl = 0;
		int iCtaCMBs = 0;
		iCtaCMBs = Conversions.ToInteger(Operators.AddObject(Interaction.IIf(bVerCMB1, 1, 0), Interaction.IIf(bVerCMB2, 1, 0)));
		checked
		{
			Point location;
			if (mLblHorizontal)
			{
				iTopLbl = 10;
				iLeftLbl = 2;
				Label lBL_COMBO = LBL_COMBO1;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO.Location = location;
				if (bVerLblCMB1)
				{
					iLeftLbl += LBL_COMBO1.Width + 2;
				}
				ComboBox cMB_ = CMB_1;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_.Location = location;
				ComboBox cMB_2 = CMB_1;
				Size size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - (double)iLeftLbl - 4.0), CMB_1.Height);
				cMB_2.Size = size;
				if (bVerCMB1)
				{
					iLeftLbl += CMB_1.Width + 4;
				}
				Label lBL_COMBO2 = LBL_COMBO2;
				location = new Point(iLeftLbl, iTopLbl);
				lBL_COMBO2.Location = location;
				if (bVerLblCMB2)
				{
					iLeftLbl += LBL_COMBO2.Width + 2;
				}
				ComboBox cMB_3 = CMB_2;
				location = new Point(iLeftLbl, iTopLbl - 4);
				cMB_3.Location = location;
				ComboBox cMB_4 = CMB_2;
				size = new Size(Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject((double)(FTS.Width - 8) / 2.0, Interaction.IIf(bVerLblCMB2, LBL_COMBO2.Width, 0)), 3)), CMB_2.Height);
				cMB_4.Size = size;
				if (bVerLblCMB1 || bVerCMB1 || bVerLblCMB2 || bVerCMB1)
				{
					iTopLbl = Conversions.ToInteger(Operators.AddObject(iTopLbl, Operators.AddObject(Interaction.IIf(LBL_COMBO1.Height > CMB_1.Height, LBL_COMBO1.Height, CMB_1.Height), 2)));
				}
				mTopGrid = (short)iTopLbl;
			}
			else
			{
				iTopLbl = 6;
				iLeftLbl = 2;
				Label lBL_COMBO3 = LBL_COMBO1;
				location = new Point(iLeftLbl + 2, iTopLbl);
				lBL_COMBO3.Location = location;
				Label lBL_COMBO4 = LBL_COMBO2;
				location = new Point((int)Math.Round((double)(FTS.Width - 8) / 2.0 + 2.0), iTopLbl);
				lBL_COMBO4.Location = location;
				if (bVerLblCMB1 || bVerLblCMB2)
				{
					iTopLbl += LBL_COMBO1.Height + 2;
				}
				ComboBox cMB_5 = CMB_1;
				location = new Point(2, iTopLbl);
				cMB_5.Location = location;
				ComboBox cMB_6 = CMB_1;
				Size size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - 6.0), CMB_1.Height);
				cMB_6.Size = size;
				ComboBox cMB_7 = CMB_2;
				location = new Point((int)Math.Round((double)(FTS.Width - 8) / 2.0 + 2.0), iTopLbl);
				cMB_7.Location = location;
				ComboBox cMB_8 = CMB_2;
				size = new Size((int)Math.Round((double)(FTS.Width - 8) / 2.0 - 4.0), CMB_1.Height);
				cMB_8.Size = size;
				if (bVerCMB1 || bVerCMB2)
				{
					iTopLbl += CMB_1.Height + 2;
				}
				mTopGrid = (short)iTopLbl;
			}
			DataGridView dGV_DATOS = DGV_DATOS;
			location = new Point(2, mTopGrid);
			dGV_DATOS.Location = location;
			DGV_DATOS.Height = FTS.Size.Height - 26 - 4 - DGV_DATOS.Location.Y;
			DGV_DATOS.Width = FTS.Width - 8 - 4;
		}
	}
```

### Inicializar · líneas 2053–2058

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2053](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2053)

```csharp
private void Inicializar()
	{
		bResizeAutomatic = true;
		bVerTitulo = true;
		mTopGrid = 25;
	}
```

### Reubicar · líneas 2060–2122

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2060](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2060)

```csharp
private void Reubicar()
	{
		int nTop = Conversions.ToInteger(Interaction.IIf(VerPanelSup, PanelSup.Height, 10));
		checked
		{
			if (bResizeAutomatic)
			{
				nTop = 4;
				if (bVerTituloFrm)
				{
					nTop = TituloFrmUbica.Y + 25 + 4;
				}
				Point location;
				if (bVerTituloTab)
				{
					Label lBL_TITLULO = LBL_TITLULO;
					location = new Point(0, nTop);
					lBL_TITLULO.Location = location;
					nTop = LBL_TITLULO.Top + LBL_TITLULO.Height + 4;
				}
				FATabStrip fTS = FTS;
				location = new Point(10, nTop);
				fTS.Location = location;
				LBL_TITLULO.Width = Width - 10;
				FATabStrip fTS2 = FTS;
				Size size = new Size(LBL_TITLULO.Width - 20, Conversions.ToInteger(Operators.SubtractObject(ClientSize.Height - TStMenu.Height - 2 - nTop, Interaction.IIf(VerPanelInf, PanelInf.Height, 0))));
				fTS2.Size = size;
				nTop += FTS.Height + 2;
				if (ClientSize.Width > TStMenu.Width)
				{
					location = (TStMenu.Location = new Point((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0), nTop));
				}
				else
				{
					ToolStrip tStMenu = TStMenu;
					location = new Point(2, nTop);
					tStMenu.Location = location;
				}
				AlineaCMBs();
				if (FTS.Width - 8 < UcFill1.Width)
				{
					UcFill1.Left = 2;
				}
				else
				{
					UcFill1.Left = (int)Math.Round((double)(FTS.Width - 8 - UcFill1.Width) / 2.0);
				}
				DataGridView dGV_BUSCAR = DGV_BUSCAR;
				Point location2 = new Point(2, UcFill1.Location.Y + UcFill1.Height + 2);
				dGV_BUSCAR.Location = location2;
				DGV_BUSCAR.Height = FTS.Size.Height - 26 - 4 - DGV_BUSCAR.Location.Y;
				DGV_BUSCAR.Width = FTS.Width - 8 - 4;
			}
			if (!VerPanelSup)
			{
				PanelSup.Top = Height + 50;
			}
			if (!VerPanelInf)
			{
				PanelInf.Top = Height + 50;
			}
		}
	}
```

### DGV_DATOS_CellContentClick · líneas 2124–2126

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2124](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2124)

```csharp
private void DGV_DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
```

### DGV_DATOS_CellFormatting · líneas 2128–2131

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2128](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2128)

```csharp
private void DGV_DATOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DGV_DATOS_CellMouseDoubleClick · líneas 2133–2136

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2133](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2133)

```csharp
private void DGV_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_EDIT.PerformClick();
	}
```

### DGV_BUSCAR_CellFormatting · líneas 2138–2141

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2138](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2138)

```csharp
private void DGV_BUSCAR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}
```

### DTG_BUSCAR_CellMouseDoubleClick · líneas 2143–2146

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2143](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2143)

```csharp
private void DTG_BUSCAR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_SELEC.PerformClick();
	}
```

### BTN_EXCEL_Click · líneas 2148–2178

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2148](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2148)

```csharp
private void BTN_EXCEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		DT1 = null;
		ClickExportarExcel?.Invoke(ref bCancel, ref DT1);
		if (bCancel)
		{
			return;
		}
		if (DT1 == null)
		{
			if (Operators.CompareString(FTS.SelectedItem.Name, TAB_LIST.Name, TextCompare: false) == 0)
			{
				DT1 = (DataTable)DGV_DATOS.DataSource;
			}
			else
			{
				if (Operators.CompareString(FTS.SelectedItem.Name, TAB_BUSCAR.Name, TextCompare: false) != 0)
				{
					return;
				}
				DT1 = (DataTable)DGV_BUSCAR.DataSource;
			}
		}
		ClsExcel oCls = new ClsExcel();
		oCls.ExportaExcel(DT1, _TituloExcel, _SubTituloExcel, _AnchoAutomat, _UsuarioExcel, _VerFechaExcel);
	}
```

### frmBaseMant_Resize · líneas 2180–2183

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2180](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2180)

```csharp
private void frmBaseMant_Resize(object sender, EventArgs e)
	{
		Reubicar();
	}
```

### frmMantBaseFTSb · líneas 2185–2227

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2185](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2185)

```csharp
public frmMantBaseFTSb()
	{
		base.Load += frmBaseMant_Load;
		base.Resize += frmBaseMant_Resize;
		base.ReubicaCtrls += frmBaseMant_ReubicaCtrls;
		ToolTipTextChk = new ToolTip();
		iNroTabp = 0;
		sConnection = "";
		bEstablecerEdicion = true;
		bResizeAutomatic = true;
		bVerTitulo = true;
		mLblHorizontal = true;
		bNuevo = false;
		bEditar = false;
		bVerCMB1 = true;
		bVerLblCMB1 = true;
		bVerCMB2 = true;
		bVerLblCMB2 = true;
		bVerTituloFrm = true;
		bVerTituloTab = true;
		sTituloTab = "";
		bVerNuevo = true;
		bVerEditar = true;
		bVerGrabar = true;
		bVerCancelar = true;
		bVerSeleccionar = true;
		bVerEliminar = true;
		bVerBuscar = true;
		bVerRegrescar = true;
		bVerImprimir = true;
		bVerExcel = true;
		bVerSalir = true;
		bVerAyuda = true;
		_Vista = new DataView();
		CadSqlB = "";
		_TituloExcel = "Titulo";
		_SubTituloExcel = "Sub Titulo";
		_VerFechaExcel = true;
		_UsuarioExcel = "";
		_AnchoAutomat = false;
		InitializeComponent();
		Inicializar();
	}
```

### BTN_PRINT_Click · líneas 2229–2239

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2229](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2229)

```csharp
private void BTN_PRINT_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1)
		{
			bool bCancel = false;
			ClickImprimir?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_BUSCAR_Click · líneas 2241–2265

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2241](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2241)

```csharp
private void BTN_BUSCAR_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource == null || DGV_DATOS.Rows.Count < 1)
		{
			return;
		}
		bool bCancel = false;
		ClickBuscar?.Invoke(ref bCancel);
		if (!bCancel && UcFill1.CMB_CAMPO.Items.Count >= 1)
		{
			DT1 = (DataTable)DGV_DATOS.DataSource;
			DGV_BUSCAR.DataSource = DT1;
			ActivaTab(2);
			DataGridView DGV = DGV_BUSCAR;
			ConfiguraDataGridView(ref DGV);
			DGV_BUSCAR = DGV;
			Config_DGVEventHandler config_DGVEvent = Config_DGV;
			if (config_DGVEvent != null)
			{
				DGV = DGV_BUSCAR;
				config_DGVEvent(ref DGV);
				DGV_BUSCAR = DGV;
			}
		}
	}
```

### BTN_REFRESH_Click · líneas 2267–2274

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2267](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2267)

```csharp
private void BTN_REFRESH_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickRefrescar?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### BTN_DEL_Click · líneas 2276–2286

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2276](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2276)

```csharp
private void BTN_DEL_Click(object sender, EventArgs e)
	{
		if (DGV_DATOS.DataSource != null && DGV_DATOS.Rows.Count >= 1 && DGV_DATOS.SelectedCells.Count >= 1)
		{
			bool bCancel = false;
			ClickEliminar?.Invoke(ref bCancel);
			if (!bCancel)
			{
			}
		}
	}
```

### BTN_CANCEL_Click · líneas 2288–2303

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2288](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2288)

```csharp
private void BTN_CANCEL_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickCancelar?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (GuardarySalir)
			{
				Close();
				return;
			}
			bNuevo = false;
			bEditar = false;
			ActivaTab(0);
		}
	}
```

### BTN_SAVE_Click · líneas 2305–2349

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2305](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2305)

```csharp
private void BTN_SAVE_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ValidarGrabar?.Invoke(bNuevo, ref bCancel);
		if (bCancel)
		{
			return;
		}
		bool bCargarDatos = false;
		ClickGrabar?.Invoke(ref bCancel, bNuevo, ref bCargarDatos);
		if (bCancel)
		{
			return;
		}
		bNuevo = false;
		bEditar = false;
		if (GuardarySalir)
		{
			Close();
			return;
		}
		ActivaTab(0);
		if (!bCargarDatos)
		{
			return;
		}
		if (VerCMB2)
		{
			Cmb2SelectedIndexChangedEventHandler cmb2SelectedIndexChangedEvent = Cmb2SelectedIndexChanged;
			if (cmb2SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb2SelectedIndexChangedEvent(ref Cancelar);
			}
		}
		else if (VerCMB1)
		{
			Cmb1SelectedIndexChangedEventHandler cmb1SelectedIndexChangedEvent = Cmb1SelectedIndexChanged;
			if (cmb1SelectedIndexChangedEvent != null)
			{
				bool Cancelar = false;
				cmb1SelectedIndexChangedEvent(ref Cancelar);
			}
		}
	}
```

### BTN_EDIT_Click · líneas 2351–2376

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2351](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2351)

```csharp
private void BTN_EDIT_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bEditar = true;
		ClearCtrls?.Invoke();
		if (DGV_DATOS.Visible)
		{
			if (DGV_DATOS.Rows.Count < 1 || DGV_DATOS.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: true, ref bCancel);
		}
		else
		{
			if (!DGV_BUSCAR.Visible || DGV_BUSCAR.Rows.Count < 1 || DGV_BUSCAR.SelectedCells.Count < 1)
			{
				return;
			}
			ClickEditar?.Invoke(GridListar: false, ref bCancel);
		}
		if (!bCancel && EstablecerEdicion)
		{
			ActivaTab(1);
		}
	}
```

### BTN_NEW_Click · líneas 2378–2391

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2378](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2378)

```csharp
private void BTN_NEW_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		bNuevo = true;
		ClickNuevo?.Invoke(ref bCancel);
		if (!bCancel)
		{
			if (EstablecerEdicion)
			{
				ActivaTab(1);
			}
			ClearCtrls?.Invoke();
		}
	}
```

### BTN_SELEC_Click · líneas 2393–2405

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2393](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2393)

```csharp
private void BTN_SELEC_Click(object sender, EventArgs e)
	{
		if (DGV_BUSCAR.DataSource != null && DGV_BUSCAR.Rows.Count >= 1 && DGV_BUSCAR.SelectedCells.Count >= 1)
		{
			ClearCtrls?.Invoke();
			bool bCancel = false;
			ClickSeleccionar?.Invoke(ref bCancel);
			if (!bCancel)
			{
				ActivaTab(1);
			}
		}
	}
```

### CMB_1_SelectedIndexChanged · líneas 2407–2424

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2407](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2407)

```csharp
private void CMB_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (VerCMB2)
		{
			CMB_2.DataSource = null;
			CMB_2.Items.Clear();
		}
		else
		{
			DGV_DATOS.DataSource = null;
			DGV_DATOS.Rows.Clear();
		}
		bool bCancel = false;
		Cmb1SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### CMB_2_SelectedIndexChanged · líneas 2426–2435

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2426](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2426)

```csharp
private void CMB_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		DGV_DATOS.DataSource = null;
		DGV_DATOS.Rows.Clear();
		bool bCancel = false;
		Cmb2SelectedIndexChanged?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}
```

### frmBaseMant_ReubicaCtrls · líneas 2437–2440

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2437](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2437)

```csharp
private void frmBaseMant_ReubicaCtrls()
	{
		Reubicar();
	}
```

### BTN_HELP_Click · líneas 2442–2445

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2442](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2442)

```csharp
private void BTN_HELP_Click(object sender, EventArgs e)
	{
		ClickAyuda?.Invoke();
	}
```

### UcFill1_ClickBuscar1 · líneas 2447–2478

[Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs:2447](../../Software/GRLL/GRLL/Common/frmMantBaseFTSb.cs#L2447)

```csharp
private void UcFill1_ClickBuscar1(string Campo, string CampoFill, string Condicion, string Valor1, string Valor2)
	{
		if (DGV_DATOS.DataSource != null && UcFill1.SelectedItem != null)
		{
			string CadStr = "";
			switch (UcFill1.TipoDato())
			{
			case ClsTipoDatos.TipoDatosSql.Fecha:
				CadStr = ((Operators.CompareString(Valor1.Trim(), "", TextCompare: false) != 0) ? ((Operators.CompareString(Condicion, "ENTRE", TextCompare: false) != 0) ? ((Operators.CompareString(Condicion, "TODOS", TextCompare: false) != 0) ? (CadSqlB + " CONVERT( VARCHAR(10), " + CampoFill + ", 112) " + Condicion + " " + Valor1) : CadSqlB) : (CadSqlB + " CONVERT( VARCHAR(10), " + CampoFill + ", 112) BETWEEN " + Valor1 + " AND " + Valor2)) : CadSqlB);
				break;
			case ClsTipoDatos.TipoDatosSql.Texto:
				CadStr = ((Operators.CompareString(Valor1.Trim(), "", TextCompare: false) != 0) ? (Condicion switch
				{
					"QUE CONTENGA" => CadSqlB + " " + CampoFill + " Like '%" + Valor1 + "%'",
					"QUE NO CONTENGA" => CadSqlB + " " + CampoFill + " NOT Like '%" + Valor1 + "%'",
					"TODOS" => CadSqlB,
					_ => CadSqlB + " " + CampoFill + " " + Condicion + " '" + Valor1 + "'",
				}) : CadSqlB);
				break;
			case ClsTipoDatos.TipoDatosSql.Numerico:
				CadStr = ((Operators.CompareString(Valor1.Trim(), "", TextCompare: false) != 0) ? ((Operators.CompareString(Condicion, "TODOS", TextCompare: false) != 0) ? (CadSqlB + " " + CampoFill + " " + Condicion + " " + Valor1) : CadSqlB) : CadSqlB);
				break;
			default:
				_Vista = DT1.DefaultView;
				DGV_BUSCAR.DataSource = _Vista;
				return;
			}
			_Vista = DT1.DefaultView;
			_Vista.RowFilter = CadStr;
			DGV_BUSCAR.DataSource = _Vista;
		}
	}
```

<a id="f-087"></a>

## frmPrueba


### frmPrueba · líneas 178–183

[Software/GRLL/GRLL/Common/frmPrueba.cs:178](../../Software/GRLL/GRLL/Common/frmPrueba.cs#L178)

```csharp
[DebuggerNonUserCode]
	public frmPrueba()
	{
		base.Load += frmPrueba_Load;
		InitializeComponent();
	}
```

### frmPrueba_Load · líneas 597–599

[Software/GRLL/GRLL/Common/frmPrueba.cs:597](../../Software/GRLL/GRLL/Common/frmPrueba.cs#L597)

```csharp
private void frmPrueba_Load(object sender, EventArgs e)
	{
	}
```
