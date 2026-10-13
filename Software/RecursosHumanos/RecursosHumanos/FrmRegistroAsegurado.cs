using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmRegistroAsegurado : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("DEFEchaFinVinculo")]
	private DateEdit _DEFEchaFinVinculo;

	[AccessedThroughProperty("UcCmboMotivoBaja")]
	private ucComboBox _UcCmboMotivoBaja;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcTxtMotivoBaja")]
	private ucTextBox _UcTxtMotivoBaja;

	[AccessedThroughProperty("GroupControl3")]
	private GroupControl _GroupControl3;

	[AccessedThroughProperty("UcTxtNumeroDocIdent")]
	private ucTextBox _UcTxtNumeroDocIdent;

	[AccessedThroughProperty("UcComboBoxTDI")]
	private ucComboBox _UcComboBoxTDI;

	[AccessedThroughProperty("btnBuscar")]
	private Button _btnBuscar;

	[AccessedThroughProperty("UcTxtNombres")]
	private ucTextBox _UcTxtNombres;

	[AccessedThroughProperty("UcTxtApelldoMaterno")]
	private ucTextBox _UcTxtApelldoMaterno;

	[AccessedThroughProperty("UcTxtApellidoPaterno")]
	private ucTextBox _UcTxtApellidoPaterno;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("UcCBEstadoCivil")]
	private ucComboBox _UcCBEstadoCivil;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("RadioGroupSexo")]
	private RadioGroup _RadioGroupSexo;

	[AccessedThroughProperty("DEFechaNacimiento")]
	private DateEdit _DEFechaNacimiento;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("UcTxtDireccion")]
	private ucTextBox _UcTxtDireccion;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("RadioGroup2")]
	private RadioGroup _RadioGroup2;

	[AccessedThroughProperty("DEInicioVinculo")]
	private DateEdit _DEInicioVinculo;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("UcTNroPartida")]
	private ucTextBox _UcTNroPartida;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("btnGuardar")]
	private Button _btnGuardar;

	[AccessedThroughProperty("UcUbigeoCmbDirec")]
	private ucUbigeoCmb _UcUbigeoCmbDirec;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("RGReEvaluar")]
	private RadioGroup _RGReEvaluar;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	private Persona oPersona;

	public RRHH_Asegurado oRRHH_Asegurado;

	public int idEmpleado;

	internal GroupControl GroupControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl2 = value;
		}
	}

	internal Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal DateEdit DEFEchaFinVinculo
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEFEchaFinVinculo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEFEchaFinVinculo = value;
		}
	}

	internal ucComboBox UcCmboMotivoBaja
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmboMotivoBaja;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCmboMotivoBaja_SelectedIndexChanged;
			if (_UcCmboMotivoBaja != null)
			{
				_UcCmboMotivoBaja.SelectedIndexChanged -= value2;
			}
			_UcCmboMotivoBaja = value;
			if (_UcCmboMotivoBaja != null)
			{
				_UcCmboMotivoBaja.SelectedIndexChanged += value2;
			}
		}
	}

	internal Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal ucTextBox UcTxtMotivoBaja
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtMotivoBaja;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtMotivoBaja = value;
		}
	}

	internal GroupControl GroupControl3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl3 = value;
		}
	}

	internal ucTextBox UcTxtNumeroDocIdent
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumeroDocIdent;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumeroDocIdent = value;
		}
	}

	internal ucComboBox UcComboBoxTDI
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcComboBoxTDI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcComboBoxTDI = value;
		}
	}

	internal Button btnBuscar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnBuscar_Click;
			if (_btnBuscar != null)
			{
				_btnBuscar.Click -= value2;
			}
			_btnBuscar = value;
			if (_btnBuscar != null)
			{
				_btnBuscar.Click += value2;
			}
		}
	}

	internal ucTextBox UcTxtNombres
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNombres;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNombres = value;
		}
	}

	internal ucTextBox UcTxtApelldoMaterno
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApelldoMaterno;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApelldoMaterno = value;
		}
	}

	internal ucTextBox UcTxtApellidoPaterno
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApellidoPaterno;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApellidoPaterno = value;
		}
	}

	internal Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal ucComboBox UcCBEstadoCivil
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBEstadoCivil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBEstadoCivil = value;
		}
	}

	internal Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal GroupControl GroupControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			PaintEventHandler value2 = GroupControl1_Paint;
			if (_GroupControl1 != null)
			{
				_GroupControl1.Paint -= value2;
			}
			_GroupControl1 = value;
			if (_GroupControl1 != null)
			{
				_GroupControl1.Paint += value2;
			}
		}
	}

	internal RadioGroup RadioGroupSexo
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroupSexo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioGroupSexo = value;
		}
	}

	internal DateEdit DEFechaNacimiento
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEFechaNacimiento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEFechaNacimiento = value;
		}
	}

	internal Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal ucTextBox UcTxtDireccion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDireccion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDireccion = value;
		}
	}

	internal Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal RadioGroup RadioGroup2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroup2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RadioGroup2_SelectedIndexChanged;
			EventHandler value3 = RadioGroup2_EditValueChanged;
			if (_RadioGroup2 != null)
			{
				_RadioGroup2.SelectedIndexChanged -= value2;
				_RadioGroup2.EditValueChanged -= value3;
			}
			_RadioGroup2 = value;
			if (_RadioGroup2 != null)
			{
				_RadioGroup2.SelectedIndexChanged += value2;
				_RadioGroup2.EditValueChanged += value3;
			}
		}
	}

	internal DateEdit DEInicioVinculo
	{
		[DebuggerNonUserCode]
		get
		{
			return _DEInicioVinculo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DEInicioVinculo = value;
		}
	}

	internal Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal ucTextBox UcTNroPartida
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTNroPartida;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTNroPartida = value;
		}
	}

	internal Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal Button btnGuardar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGuardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnGuardar_Click;
			if (_btnGuardar != null)
			{
				_btnGuardar.Click -= value2;
			}
			_btnGuardar = value;
			if (_btnGuardar != null)
			{
				_btnGuardar.Click += value2;
			}
		}
	}

	internal ucUbigeoCmb UcUbigeoCmbDirec
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcUbigeoCmbDirec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcUbigeoCmbDirec = value;
		}
	}

	internal DefaultLookAndFeel DefaultLookAndFeel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DefaultLookAndFeel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DefaultLookAndFeel1 = value;
		}
	}

	internal RadioGroup RGReEvaluar
	{
		[DebuggerNonUserCode]
		get
		{
			return _RGReEvaluar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RGReEvaluar = value;
		}
	}

	internal Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	public FrmRegistroAsegurado()
	{
		base.Load += FrmRegistroAsegurado_Load;
		__ENCAddToList(this);
		oPersona = new Persona();
		oRRHH_Asegurado = new RRHH_Asegurado();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtMotivoBaja = new GRLL.Common.ucTextBox(this.components);
		this.Label6 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.DEFEchaFinVinculo = new DevExpress.XtraEditors.DateEdit();
		this.UcCmboMotivoBaja = new GRLL.Common.ucComboBox();
		this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
		this.UcTNroPartida = new GRLL.Common.ucTextBox(this.components);
		this.RadioGroup2 = new DevExpress.XtraEditors.RadioGroup();
		this.DEInicioVinculo = new DevExpress.XtraEditors.DateEdit();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcUbigeoCmbDirec = new GRLL.Common.ucUbigeoCmb();
		this.UcTxtDireccion = new GRLL.Common.ucTextBox(this.components);
		this.Label11 = new System.Windows.Forms.Label();
		this.RadioGroupSexo = new DevExpress.XtraEditors.RadioGroup();
		this.DEFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
		this.UcCBEstadoCivil = new GRLL.Common.ucComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcTxtNumeroDocIdent = new GRLL.Common.ucTextBox(this.components);
		this.UcComboBoxTDI = new GRLL.Common.ucComboBox();
		this.btnBuscar = new System.Windows.Forms.Button();
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApelldoMaterno = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApellidoPaterno = new GRLL.Common.ucTextBox(this.components);
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnGuardar = new System.Windows.Forms.Button();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.Label15 = new System.Windows.Forms.Label();
		this.RGReEvaluar = new DevExpress.XtraEditors.RadioGroup();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DEFEchaFinVinculo.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFEchaFinVinculo.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl3).BeginInit();
		this.GroupControl3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEInicioVinculo.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEInicioVinculo.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroupSexo.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFechaNacimiento.Properties.VistaTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DEFechaNacimiento.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RGReEvaluar.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(626, 541);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(699, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 570);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(699, 27);
		panelInf2.Size = size;
		this.GroupControl2.Controls.Add(this.UcTxtMotivoBaja);
		this.GroupControl2.Controls.Add(this.Label6);
		this.GroupControl2.Controls.Add(this.Label2);
		this.GroupControl2.Controls.Add(this.DEFEchaFinVinculo);
		this.GroupControl2.Controls.Add(this.UcCmboMotivoBaja);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl2;
		location = new System.Drawing.Point(12, 420);
		groupControl.Location = location;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl2;
		size = new System.Drawing.Size(675, 102);
		groupControl2.Size = size;
		this.GroupControl2.TabIndex = 5;
		this.GroupControl2.Text = "Motivo de Baja";
		this.UcTxtMotivoBaja.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtMotivoBaja.Formato = null;
		this.UcTxtMotivoBaja.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtMotivoBaja = this.UcTxtMotivoBaja;
		location = new System.Drawing.Point(313, 32);
		ucTxtMotivoBaja.Location = location;
		this.UcTxtMotivoBaja.Name = "UcTxtMotivoBaja";
		this.UcTxtMotivoBaja.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtMotivoBaja.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtMotivoBaja.OnErrorBlankText = "";
		this.UcTxtMotivoBaja.PadLeftLenght = 0;
		this.UcTxtMotivoBaja.RegularExpression = "^[0-9]*$";
		this.UcTxtMotivoBaja.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtMotivoBaja.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtMotivoBaja2 = this.UcTxtMotivoBaja;
		size = new System.Drawing.Size(296, 20);
		ucTxtMotivoBaja2.Size = size;
		this.UcTxtMotivoBaja.TabIndex = 4;
		this.UcTxtMotivoBaja.TabNextControl = false;
		this.UcTxtMotivoBaja.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label = this.Label6;
		location = new System.Drawing.Point(26, 35);
		label.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label2 = this.Label6;
		size = new System.Drawing.Size(81, 13);
		label2.Size = size;
		this.Label6.TabIndex = 3;
		this.Label6.Text = "Motivo de Baja:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(26, 72);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(197, 13);
		label4.Size = size;
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Fecha de Fin de Vinculo / Fallecimiento:";
		this.DEFEchaFinVinculo.EditValue = null;
		DevExpress.XtraEditors.DateEdit dEFEchaFinVinculo = this.DEFEchaFinVinculo;
		location = new System.Drawing.Point(226, 69);
		dEFEchaFinVinculo.Location = location;
		this.DEFEchaFinVinculo.Name = "DEFEchaFinVinculo";
		this.DEFEchaFinVinculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.DEFEchaFinVinculo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEFEchaFinVinculo2 = this.DEFEchaFinVinculo;
		size = new System.Drawing.Size(262, 20);
		dEFEchaFinVinculo2.Size = size;
		this.DEFEchaFinVinculo.TabIndex = 1;
		this.UcCmboMotivoBaja.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmboMotivoBaja.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmboMotivoBaja.FormattingEnabled = true;
		this.UcCmboMotivoBaja.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmboMotivoBaja = this.UcCmboMotivoBaja;
		location = new System.Drawing.Point(113, 32);
		ucCmboMotivoBaja.Location = location;
		this.UcCmboMotivoBaja.Name = "UcCmboMotivoBaja";
		GRLL.Common.ucComboBox ucCmboMotivoBaja2 = this.UcCmboMotivoBaja;
		size = new System.Drawing.Size(185, 21);
		ucCmboMotivoBaja2.Size = size;
		this.UcCmboMotivoBaja.TabIndex = 0;
		this.GroupControl3.Controls.Add(this.RGReEvaluar);
		this.GroupControl3.Controls.Add(this.UcTNroPartida);
		this.GroupControl3.Controls.Add(this.RadioGroup2);
		this.GroupControl3.Controls.Add(this.DEInicioVinculo);
		this.GroupControl3.Controls.Add(this.GroupControl1);
		this.GroupControl3.Controls.Add(this.RadioGroupSexo);
		this.GroupControl3.Controls.Add(this.DEFechaNacimiento);
		this.GroupControl3.Controls.Add(this.UcCBEstadoCivil);
		this.GroupControl3.Controls.Add(this.Label7);
		this.GroupControl3.Controls.Add(this.Label10);
		this.GroupControl3.Controls.Add(this.Label9);
		this.GroupControl3.Controls.Add(this.Label8);
		this.GroupControl3.Controls.Add(this.Label12);
		this.GroupControl3.Controls.Add(this.Label5);
		this.GroupControl3.Controls.Add(this.UcTxtNumeroDocIdent);
		this.GroupControl3.Controls.Add(this.UcComboBoxTDI);
		this.GroupControl3.Controls.Add(this.btnBuscar);
		this.GroupControl3.Controls.Add(this.UcTxtNombres);
		this.GroupControl3.Controls.Add(this.UcTxtApelldoMaterno);
		this.GroupControl3.Controls.Add(this.UcTxtApellidoPaterno);
		this.GroupControl3.Controls.Add(this.Label14);
		this.GroupControl3.Controls.Add(this.Label15);
		this.GroupControl3.Controls.Add(this.Label13);
		this.GroupControl3.Controls.Add(this.Label4);
		this.GroupControl3.Controls.Add(this.Label3);
		this.GroupControl3.Controls.Add(this.Label1);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl3;
		location = new System.Drawing.Point(12, 35);
		groupControl3.Location = location;
		this.GroupControl3.Name = "GroupControl3";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl3;
		size = new System.Drawing.Size(675, 379);
		groupControl4.Size = size;
		this.GroupControl3.TabIndex = 6;
		this.GroupControl3.Text = "Datos de los DerechoHabientes";
		this.UcTNroPartida.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTNroPartida.Formato = null;
		this.UcTNroPartida.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTNroPartida = this.UcTNroPartida;
		location = new System.Drawing.Point(108, 146);
		ucTNroPartida.Location = location;
		this.UcTNroPartida.Name = "UcTNroPartida";
		this.UcTNroPartida.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTNroPartida.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTNroPartida.OnErrorBlankText = "";
		this.UcTNroPartida.PadLeftLenght = 0;
		this.UcTNroPartida.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTNroPartida.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTNroPartida2 = this.UcTNroPartida;
		size = new System.Drawing.Size(178, 20);
		ucTNroPartida2.Size = size;
		this.UcTNroPartida.TabIndex = 12;
		this.UcTNroPartida.TabNextControl = false;
		this.UcTNroPartida.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		DevExpress.XtraEditors.RadioGroup radioGroup = this.RadioGroup2;
		location = new System.Drawing.Point(109, 109);
		radioGroup.Location = location;
		this.RadioGroup2.Name = "RadioGroup2";
		this.RadioGroup2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup2.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[4]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem("Conyuge", "Conyuge"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("Concubino", "Concubino(A)"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("Gestante", "Gestante"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("Hijo", "Hijo(A)")
		});
		DevExpress.XtraEditors.RadioGroup radioGroup2 = this.RadioGroup2;
		size = new System.Drawing.Size(397, 26);
		radioGroup2.Size = size;
		this.RadioGroup2.TabIndex = 11;
		this.DEInicioVinculo.EditValue = null;
		DevExpress.XtraEditors.DateEdit dEInicioVinculo = this.DEInicioVinculo;
		location = new System.Drawing.Point(466, 33);
		dEInicioVinculo.Location = location;
		this.DEInicioVinculo.Name = "DEInicioVinculo";
		this.DEInicioVinculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.DEInicioVinculo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEInicioVinculo2 = this.DEInicioVinculo;
		size = new System.Drawing.Size(204, 20);
		dEInicioVinculo2.Size = size;
		this.DEInicioVinculo.TabIndex = 10;
		this.GroupControl1.Controls.Add(this.UcUbigeoCmbDirec);
		this.GroupControl1.Controls.Add(this.UcTxtDireccion);
		this.GroupControl1.Controls.Add(this.Label11);
		DevExpress.XtraEditors.GroupControl groupControl5 = this.GroupControl1;
		location = new System.Drawing.Point(5, 256);
		groupControl5.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl6 = this.GroupControl1;
		size = new System.Drawing.Size(665, 114);
		groupControl6.Size = size;
		this.GroupControl1.TabIndex = 9;
		this.GroupControl1.Text = "Domicilio";
		this.UcUbigeoCmbDirec.BackColor = System.Drawing.Color.Transparent;
		this.UcUbigeoCmbDirec.Conexion = null;
		GRLL.Common.ucUbigeoCmb ucUbigeoCmbDirec = this.UcUbigeoCmbDirec;
		location = new System.Drawing.Point(11, 23);
		ucUbigeoCmbDirec.Location = location;
		this.UcUbigeoCmbDirec.Name = "UcUbigeoCmbDirec";
		GRLL.Common.ucUbigeoCmb ucUbigeoCmbDirec2 = this.UcUbigeoCmbDirec;
		size = new System.Drawing.Size(304, 86);
		ucUbigeoCmbDirec2.Size = size;
		this.UcUbigeoCmbDirec.TabIndex = 5;
		this.UcUbigeoCmbDirec.Ubigeo = "000000";
		this.UcTxtDireccion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDireccion.Formato = null;
		this.UcTxtDireccion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDireccion = this.UcTxtDireccion;
		location = new System.Drawing.Point(382, 55);
		ucTxtDireccion.Location = location;
		this.UcTxtDireccion.Name = "UcTxtDireccion";
		this.UcTxtDireccion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDireccion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDireccion.OnErrorBlankText = "";
		this.UcTxtDireccion.PadLeftLenght = 0;
		this.UcTxtDireccion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDireccion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDireccion2 = this.UcTxtDireccion;
		size = new System.Drawing.Size(268, 20);
		ucTxtDireccion2.Size = size;
		this.UcTxtDireccion.TabIndex = 4;
		this.UcTxtDireccion.TabNextControl = false;
		this.UcTxtDireccion.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label11;
		location = new System.Drawing.Point(321, 58);
		label5.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label6 = this.Label11;
		size = new System.Drawing.Size(55, 13);
		label6.Size = size;
		this.Label11.TabIndex = 3;
		this.Label11.Text = "Direccion:";
		DevExpress.XtraEditors.RadioGroup radioGroupSexo = this.RadioGroupSexo;
		location = new System.Drawing.Point(393, 221);
		radioGroupSexo.Location = location;
		this.RadioGroupSexo.Name = "RadioGroupSexo";
		this.RadioGroupSexo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroupSexo.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroupSexo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroupSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Masculino"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Femenino")
		});
		DevExpress.XtraEditors.RadioGroup radioGroupSexo2 = this.RadioGroupSexo;
		size = new System.Drawing.Size(179, 29);
		radioGroupSexo2.Size = size;
		this.RadioGroupSexo.TabIndex = 8;
		this.DEFechaNacimiento.EditValue = null;
		DevExpress.XtraEditors.DateEdit dEFechaNacimiento = this.DEFechaNacimiento;
		location = new System.Drawing.Point(108, 226);
		dEFechaNacimiento.Location = location;
		this.DEFechaNacimiento.Name = "DEFechaNacimiento";
		this.DEFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.DEFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		DevExpress.XtraEditors.DateEdit dEFechaNacimiento2 = this.DEFechaNacimiento;
		size = new System.Drawing.Size(215, 20);
		dEFechaNacimiento2.Size = size;
		this.DEFechaNacimiento.TabIndex = 7;
		this.UcCBEstadoCivil.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBEstadoCivil.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBEstadoCivil.FormattingEnabled = true;
		this.UcCBEstadoCivil.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBEstadoCivil = this.UcCBEstadoCivil;
		location = new System.Drawing.Point(108, 199);
		ucCBEstadoCivil.Location = location;
		this.UcCBEstadoCivil.Name = "UcCBEstadoCivil";
		GRLL.Common.ucComboBox ucCBEstadoCivil2 = this.UcCBEstadoCivil;
		size = new System.Drawing.Size(167, 21);
		ucCBEstadoCivil2.Size = size;
		this.UcCBEstadoCivil.TabIndex = 6;
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label7;
		location = new System.Drawing.Point(249, 175);
		label7.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label8 = this.Label7;
		size = new System.Drawing.Size(47, 13);
		label8.Size = size;
		this.Label7.TabIndex = 5;
		this.Label7.Text = "Numero:";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label10;
		location = new System.Drawing.Point(353, 229);
		label9.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label10 = this.Label10;
		size = new System.Drawing.Size(34, 13);
		label10.Size = size;
		this.Label10.TabIndex = 5;
		this.Label10.Text = "Sexo:";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label9;
		location = new System.Drawing.Point(36, 229);
		label11.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label12 = this.Label9;
		size = new System.Drawing.Size(66, 13);
		label12.Size = size;
		this.Label9.TabIndex = 5;
		this.Label9.Text = "Fecha Nac.:";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label8;
		location = new System.Drawing.Point(35, 202);
		label13.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label14 = this.Label8;
		size = new System.Drawing.Size(65, 13);
		label14.Size = size;
		this.Label8.TabIndex = 5;
		this.Label8.Text = "Estado Civil:";
		this.Label12.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label12;
		location = new System.Drawing.Point(324, 36);
		label15.Location = location;
		this.Label12.Name = "Label12";
		System.Windows.Forms.Label label16 = this.Label12;
		size = new System.Drawing.Size(136, 13);
		label16.Size = size;
		this.Label12.TabIndex = 5;
		this.Label12.Text = "Fecha de Inicio de Vinculo:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label5;
		location = new System.Drawing.Point(18, 175);
		label17.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label18 = this.Label5;
		size = new System.Drawing.Size(87, 13);
		label18.Size = size;
		this.Label5.TabIndex = 5;
		this.Label5.Text = "Tipo Doc. Ident.:";
		this.UcTxtNumeroDocIdent.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumeroDocIdent.Formato = null;
		this.UcTxtNumeroDocIdent.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumeroDocIdent = this.UcTxtNumeroDocIdent;
		location = new System.Drawing.Point(302, 172);
		ucTxtNumeroDocIdent.Location = location;
		this.UcTxtNumeroDocIdent.Name = "UcTxtNumeroDocIdent";
		this.UcTxtNumeroDocIdent.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumeroDocIdent.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumeroDocIdent.OnErrorBlankText = "";
		this.UcTxtNumeroDocIdent.PadLeftLenght = 0;
		this.UcTxtNumeroDocIdent.RegularExpression = "^[0-9]*$";
		this.UcTxtNumeroDocIdent.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumeroDocIdent.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumeroDocIdent2 = this.UcTxtNumeroDocIdent;
		size = new System.Drawing.Size(116, 20);
		ucTxtNumeroDocIdent2.Size = size;
		this.UcTxtNumeroDocIdent.TabIndex = 4;
		this.UcTxtNumeroDocIdent.TabNextControl = false;
		this.UcTxtNumeroDocIdent.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcComboBoxTDI.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcComboBoxTDI.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcComboBoxTDI.FormattingEnabled = true;
		this.UcComboBoxTDI.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucComboBoxTDI = this.UcComboBoxTDI;
		location = new System.Drawing.Point(108, 172);
		ucComboBoxTDI.Location = location;
		this.UcComboBoxTDI.Name = "UcComboBoxTDI";
		GRLL.Common.ucComboBox ucComboBoxTDI2 = this.UcComboBoxTDI;
		size = new System.Drawing.Size(121, 21);
		ucComboBoxTDI2.Size = size;
		this.UcComboBoxTDI.TabIndex = 3;
		this.btnBuscar.AutoSize = true;
		this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnBuscar.FlatAppearance.BorderSize = 0;
		this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnBuscar.Image = RecursosHumanos.My.Resources.Resources.view1;
		System.Windows.Forms.Button button3 = this.btnBuscar;
		location = new System.Drawing.Point(292, 29);
		button3.Location = location;
		this.btnBuscar.Name = "btnBuscar";
		System.Windows.Forms.Button button4 = this.btnBuscar;
		size = new System.Drawing.Size(22, 22);
		button4.Size = size;
		this.btnBuscar.TabIndex = 2;
		this.btnBuscar.UseVisualStyleBackColor = true;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(109, 84);
		ucTxtNombres.Location = location;
		this.UcTxtNombres.Name = "UcTxtNombres";
		this.UcTxtNombres.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNombres.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNombres.OnErrorBlankText = "";
		this.UcTxtNombres.PadLeftLenght = 0;
		this.UcTxtNombres.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtNombres.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNombres.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNombres2 = this.UcTxtNombres;
		size = new System.Drawing.Size(310, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 1;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtApelldoMaterno.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApelldoMaterno.Formato = null;
		this.UcTxtApelldoMaterno.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApelldoMaterno = this.UcTxtApelldoMaterno;
		location = new System.Drawing.Point(109, 58);
		ucTxtApelldoMaterno.Location = location;
		this.UcTxtApelldoMaterno.Name = "UcTxtApelldoMaterno";
		this.UcTxtApelldoMaterno.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApelldoMaterno.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApelldoMaterno.OnErrorBlankText = "";
		this.UcTxtApelldoMaterno.PadLeftLenght = 0;
		this.UcTxtApelldoMaterno.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApelldoMaterno.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApelldoMaterno.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApelldoMaterno2 = this.UcTxtApelldoMaterno;
		size = new System.Drawing.Size(177, 20);
		ucTxtApelldoMaterno2.Size = size;
		this.UcTxtApelldoMaterno.TabIndex = 1;
		this.UcTxtApelldoMaterno.TabNextControl = false;
		this.UcTxtApelldoMaterno.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtApellidoPaterno.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApellidoPaterno.Formato = null;
		this.UcTxtApellidoPaterno.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApellidoPaterno = this.UcTxtApellidoPaterno;
		location = new System.Drawing.Point(109, 31);
		ucTxtApellidoPaterno.Location = location;
		this.UcTxtApellidoPaterno.Name = "UcTxtApellidoPaterno";
		this.UcTxtApellidoPaterno.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApellidoPaterno.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApellidoPaterno.OnErrorBlankText = "";
		this.UcTxtApellidoPaterno.PadLeftLenght = 0;
		this.UcTxtApellidoPaterno.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApellidoPaterno.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApellidoPaterno.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApellidoPaterno2 = this.UcTxtApellidoPaterno;
		size = new System.Drawing.Size(177, 20);
		ucTxtApellidoPaterno2.Size = size;
		this.UcTxtApellidoPaterno.TabIndex = 1;
		this.UcTxtApellidoPaterno.TabNextControl = false;
		this.UcTxtApellidoPaterno.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label14.AutoSize = true;
		System.Windows.Forms.Label label19 = this.Label14;
		location = new System.Drawing.Point(20, 149);
		label19.Location = location;
		this.Label14.Name = "Label14";
		System.Windows.Forms.Label label20 = this.Label14;
		size = new System.Drawing.Size(73, 13);
		label20.Size = size;
		this.Label14.TabIndex = 0;
		this.Label14.Text = "N° de Partida:";
		this.Label13.AutoSize = true;
		System.Windows.Forms.Label label21 = this.Label13;
		location = new System.Drawing.Point(19, 114);
		label21.Location = location;
		this.Label13.Name = "Label13";
		System.Windows.Forms.Label label22 = this.Label13;
		size = new System.Drawing.Size(83, 13);
		label22.Size = size;
		this.Label13.TabIndex = 0;
		this.Label13.Text = "Vinculo Familiar:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label23 = this.Label4;
		location = new System.Drawing.Point(50, 87);
		label23.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label24 = this.Label4;
		size = new System.Drawing.Size(52, 13);
		label24.Size = size;
		this.Label4.TabIndex = 0;
		this.Label4.Text = "Nombres:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label25 = this.Label3;
		location = new System.Drawing.Point(13, 61);
		label25.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label26 = this.Label3;
		size = new System.Drawing.Size(89, 13);
		label26.Size = size;
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Apellido Materno:";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label27 = this.Label1;
		location = new System.Drawing.Point(15, 34);
		label27.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label28 = this.Label1;
		size = new System.Drawing.Size(87, 13);
		label28.Size = size;
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Apellido Paterno:";
		this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGuardar.AutoSize = true;
		this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGuardar.FlatAppearance.BorderSize = 0;
		this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGuardar.Image = RecursosHumanos.My.Resources.Resources.disk_blue;
		System.Windows.Forms.Button button5 = this.btnGuardar;
		location = new System.Drawing.Point(12, 541);
		button5.Location = location;
		this.btnGuardar.Name = "btnGuardar";
		System.Windows.Forms.Button button6 = this.btnGuardar;
		size = new System.Drawing.Size(71, 23);
		button6.Size = size;
		this.btnGuardar.TabIndex = 7;
		this.btnGuardar.Text = "&Guardar";
		this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGuardar.UseVisualStyleBackColor = true;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.Label15.AutoSize = true;
		System.Windows.Forms.Label label29 = this.Label15;
		location = new System.Drawing.Point(310, 149);
		label29.Location = location;
		this.Label15.Name = "Label15";
		System.Windows.Forms.Label label30 = this.Label15;
		size = new System.Drawing.Size(59, 13);
		label30.Size = size;
		this.Label15.TabIndex = 0;
		this.Label15.Text = "Reevaluar:";
		this.Label15.Visible = false;
		DevExpress.XtraEditors.RadioGroup rGReEvaluar = this.RGReEvaluar;
		location = new System.Drawing.Point(375, 146);
		rGReEvaluar.Location = location;
		this.RGReEvaluar.Name = "RGReEvaluar";
		this.RGReEvaluar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RGReEvaluar.Properties.Appearance.Options.UseBackColor = true;
		this.RGReEvaluar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RGReEvaluar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[3]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "2 años"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("3", "3 años"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem("5", "5 años")
		});
		DevExpress.XtraEditors.RadioGroup rGReEvaluar2 = this.RGReEvaluar;
		size = new System.Drawing.Size(209, 20);
		rGReEvaluar2.Size = size;
		this.RGReEvaluar.TabIndex = 13;
		this.RGReEvaluar.Visible = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(699, 597);
		this.ClientSize = size;
		this.Controls.Add(this.btnGuardar);
		this.Controls.Add(this.GroupControl3);
		this.Controls.Add(this.GroupControl2);
		this.MessageShow = true;
		this.Name = "FrmRegistroAsegurado";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Registro de Asegurados";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl2, 0);
		this.Controls.SetChildIndex(this.GroupControl3, 0);
		this.Controls.SetChildIndex(this.btnGuardar, 0);
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		this.GroupControl2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DEFEchaFinVinculo.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFEchaFinVinculo.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl3).EndInit();
		this.GroupControl3.ResumeLayout(false);
		this.GroupControl3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEInicioVinculo.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEInicioVinculo.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroupSexo.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFechaNacimiento.Properties.VistaTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DEFechaNacimiento.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RGReEvaluar.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

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
		UcUbigeoCmbDirec.Conexion = rRHHClass.ObjCnn;
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

	private void GroupControl1_Paint(object sender, PaintEventArgs e)
	{
	}

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

	private void RadioGroup2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

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
}
