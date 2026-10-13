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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GRLL.Common;
using GRLL.Common.Conversiones.Rutinas;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmFamiliar : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcCBSexo")]
	private ucComboBox _UcCBSexo;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("UcTxtApePater")]
	private ucTextBox _UcTxtApePater;

	[AccessedThroughProperty("UcTxtNombres")]
	private ucTextBox _UcTxtNombres;

	[AccessedThroughProperty("UcTxtApeMater")]
	private ucTextBox _UcTxtApeMater;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCBTDI")]
	private ucComboBox _UcCBTDI;

	[AccessedThroughProperty("UcTxtNDoc")]
	private ucTextBox _UcTxtNDoc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcCBParentesco")]
	private ucComboBox _UcCBParentesco;

	[AccessedThroughProperty("UcCBEstadoCivil")]
	private ucComboBox _UcCBEstadoCivil;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("RadioGroup1")]
	private RadioGroup _RadioGroup1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("UcTxtGradoInstruc")]
	private ucTextBox _UcTxtGradoInstruc;

	[AccessedThroughProperty("UcDateTime1")]
	private ucDateTime _UcDateTime1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("btnGrabar")]
	private Button _btnGrabar;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("RadioGroup2")]
	private RadioGroup _RadioGroup2;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("UcTxtAutogenSalud")]
	private ucTextBox _UcTxtAutogenSalud;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("UcTxtDomicilio")]
	private ucTextBox _UcTxtDomicilio;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("UcTxtFono")]
	private ucTextBox _UcTxtFono;

	[AccessedThroughProperty("UcCBDiscapacidad")]
	private ucComboBox _UcCBDiscapacidad;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("UcTxtTiempo")]
	private ucTextBox _UcTxtTiempo;

	[AccessedThroughProperty("UcTxtEnfermedad")]
	private ucTextBox _UcTxtEnfermedad;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("UcTxtOcupacion")]
	private ucTextBox _UcTxtOcupacion;

	[AccessedThroughProperty("UcTxtLugTrabajo")]
	private ucTextBox _UcTxtLugTrabajo;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("UcCmbTipoSangre")]
	private ucComboBox _UcCmbTipoSangre;

	private FamiliaresClass objFamiliaresClass;

	public int CodEmple;

	private RRHHClass objClassRRHH;

	public int codper;

	private Persona persona;

	private int opt;

	private int focus;

	internal ucComboBox UcCBSexo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBSexo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBSexo = value;
		}
	}

	internal Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal ucTextBox UcTxtApePater
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApePater;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApePater = value;
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

	internal ucTextBox UcTxtApeMater
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtApeMater;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtApeMater = value;
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

	internal ucComboBox UcCBTDI
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTDI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTDI = value;
		}
	}

	internal ucTextBox UcTxtNDoc
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcTxtNDoc_LostFocus;
			EventHandler value3 = UcTxtNDoc_TextChanged;
			if (_UcTxtNDoc != null)
			{
				_UcTxtNDoc.LostFocus -= value2;
				_UcTxtNDoc.TextChanged -= value3;
			}
			_UcTxtNDoc = value;
			if (_UcTxtNDoc != null)
			{
				_UcTxtNDoc.LostFocus += value2;
				_UcTxtNDoc.TextChanged += value3;
			}
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

	internal ucComboBox UcCBParentesco
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBParentesco;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBParentesco = value;
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

	internal RadioGroup RadioGroup1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroup1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioGroup1 = value;
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

	internal ucTextBox UcTxtGradoInstruc
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtGradoInstruc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtGradoInstruc = value;
		}
	}

	internal ucDateTime UcDateTime1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDateTime1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDateTime1 = value;
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

	internal Button btnGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnGrabar_Click;
			if (_btnGrabar != null)
			{
				_btnGrabar.Click -= value2;
			}
			_btnGrabar = value;
			if (_btnGrabar != null)
			{
				_btnGrabar.Click += value2;
			}
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
			_RadioGroup2 = value;
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

	internal ucTextBox UcTxtAutogenSalud
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAutogenSalud;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAutogenSalud = value;
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

	internal ucTextBox UcTxtDomicilio
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDomicilio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDomicilio = value;
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

	internal ucTextBox UcTxtFono
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtFono;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtFono = value;
		}
	}

	internal ucComboBox UcCBDiscapacidad
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBDiscapacidad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBDiscapacidad = value;
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
			_GroupControl1 = value;
		}
	}

	internal Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal ucTextBox UcTxtTiempo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtTiempo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtTiempo = value;
		}
	}

	internal ucTextBox UcTxtEnfermedad
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEnfermedad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEnfermedad = value;
		}
	}

	internal Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal ucTextBox UcTxtOcupacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtOcupacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtOcupacion = value;
		}
	}

	internal ucTextBox UcTxtLugTrabajo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtLugTrabajo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtLugTrabajo = value;
		}
	}

	internal Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal ucComboBox UcCmbTipoSangre
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbTipoSangre;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbTipoSangre = value;
		}
	}

	public FrmFamiliar()
	{
		base.Load += FrmFamiliar_Load;
		__ENCAddToList(this);
		objFamiliaresClass = new FamiliaresClass();
		objClassRRHH = new RRHHClass();
		opt = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmFamiliar));
		this.UcCBSexo = new GRLL.Common.ucComboBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.UcTxtApePater = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApeMater = new GRLL.Common.ucTextBox(this.components);
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcCBTDI = new GRLL.Common.ucComboBox();
		this.UcTxtNDoc = new GRLL.Common.ucTextBox(this.components);
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.UcCBParentesco = new GRLL.Common.ucComboBox();
		this.UcCBEstadoCivil = new GRLL.Common.ucComboBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.RadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.UcTxtGradoInstruc = new GRLL.Common.ucTextBox(this.components);
		this.UcDateTime1 = new GRLL.Common.ucDateTime();
		this.Label9 = new System.Windows.Forms.Label();
		this.btnGrabar = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.RadioGroup2 = new DevExpress.XtraEditors.RadioGroup();
		this.Label11 = new System.Windows.Forms.Label();
		this.UcTxtAutogenSalud = new GRLL.Common.ucTextBox(this.components);
		this.Label12 = new System.Windows.Forms.Label();
		this.UcTxtDomicilio = new GRLL.Common.ucTextBox(this.components);
		this.Label13 = new System.Windows.Forms.Label();
		this.UcTxtFono = new GRLL.Common.ucTextBox(this.components);
		this.UcCBDiscapacidad = new GRLL.Common.ucComboBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.UcTxtTiempo = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEnfermedad = new GRLL.Common.ucTextBox(this.components);
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.UcTxtOcupacion = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtLugTrabajo = new GRLL.Common.ucTextBox(this.components);
		this.Label20 = new System.Windows.Forms.Label();
		this.UcCmbTipoSangre = new GRLL.Common.ucComboBox();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(389, 467);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 18;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(462, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 502);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(462, 27);
		panelInf2.Size = size;
		this.UcCBSexo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBSexo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBSexo.FormattingEnabled = true;
		this.UcCBSexo.IncluirNinguno = false;
		this.UcCBSexo.Items.AddRange(new object[2] { "M", "F" });
		GRLL.Common.ucComboBox ucCBSexo = this.UcCBSexo;
		location = new System.Drawing.Point(372, 162);
		ucCBSexo.Location = location;
		this.UcCBSexo.Name = "UcCBSexo";
		GRLL.Common.ucComboBox ucCBSexo2 = this.UcCBSexo;
		size = new System.Drawing.Size(59, 21);
		ucCBSexo2.Size = size;
		this.UcCBSexo.TabIndex = 8;
		this.Label24.AutoSize = true;
		System.Windows.Forms.Label label = this.Label24;
		location = new System.Drawing.Point(332, 165);
		label.Location = location;
		this.Label24.Name = "Label24";
		System.Windows.Forms.Label label2 = this.Label24;
		size = new System.Drawing.Size(34, 13);
		label2.Size = size;
		this.Label24.TabIndex = 42;
		this.Label24.Text = "Sexo:";
		this.UcTxtApePater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApePater.Formato = null;
		this.UcTxtApePater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApePater = this.UcTxtApePater;
		location = new System.Drawing.Point(108, 57);
		ucTxtApePater.Location = location;
		this.UcTxtApePater.MaxLength = 30;
		this.UcTxtApePater.Name = "UcTxtApePater";
		this.UcTxtApePater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApePater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApePater.OnErrorBlankText = "";
		this.UcTxtApePater.PadLeftLenght = 0;
		this.UcTxtApePater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApePater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApePater2 = this.UcTxtApePater;
		size = new System.Drawing.Size(211, 20);
		ucTxtApePater2.Size = size;
		this.UcTxtApePater.TabIndex = 3;
		this.UcTxtApePater.TabNextControl = false;
		this.UcTxtApePater.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(108, 109);
		ucTxtNombres.Location = location;
		this.UcTxtNombres.MaxLength = 100;
		this.UcTxtNombres.Name = "UcTxtNombres";
		this.UcTxtNombres.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNombres.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNombres.OnErrorBlankText = "";
		this.UcTxtNombres.PadLeftLenght = 0;
		this.UcTxtNombres.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNombres.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNombres2 = this.UcTxtNombres;
		size = new System.Drawing.Size(295, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 5;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtApeMater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApeMater.Formato = null;
		this.UcTxtApeMater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApeMater = this.UcTxtApeMater;
		location = new System.Drawing.Point(108, 83);
		ucTxtApeMater.Location = location;
		this.UcTxtApeMater.MaxLength = 30;
		this.UcTxtApeMater.Name = "UcTxtApeMater";
		this.UcTxtApeMater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApeMater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApeMater.OnErrorBlankText = "";
		this.UcTxtApeMater.PadLeftLenght = 0;
		this.UcTxtApeMater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApeMater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApeMater2 = this.UcTxtApeMater;
		size = new System.Drawing.Size(211, 20);
		ucTxtApeMater2.Size = size;
		this.UcTxtApeMater.TabIndex = 4;
		this.UcTxtApeMater.TabNextControl = false;
		this.UcTxtApeMater.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label3;
		location = new System.Drawing.Point(15, 60);
		label3.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label4 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label4.Size = size;
		this.Label3.TabIndex = 44;
		this.Label3.Text = "Apellido Paterno:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label2;
		location = new System.Drawing.Point(15, 33);
		label5.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label6 = this.Label2;
		size = new System.Drawing.Size(87, 13);
		label6.Size = size;
		this.Label2.TabIndex = 43;
		this.Label2.Text = "Tipo Doc. Ident.:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(15, 86);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label8.Size = size;
		this.Label4.TabIndex = 45;
		this.Label4.Text = "Apellido Materno:";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label1;
		location = new System.Drawing.Point(271, 36);
		label9.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label10 = this.Label1;
		size = new System.Drawing.Size(48, 13);
		label10.Size = size;
		this.Label1.TabIndex = 40;
		this.Label1.Text = "Nº Doc.:";
		this.UcCBTDI.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTDI.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTDI.FormattingEnabled = true;
		this.UcCBTDI.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTDI = this.UcCBTDI;
		location = new System.Drawing.Point(108, 30);
		ucCBTDI.Location = location;
		this.UcCBTDI.Name = "UcCBTDI";
		GRLL.Common.ucComboBox ucCBTDI2 = this.UcCBTDI;
		size = new System.Drawing.Size(121, 21);
		ucCBTDI2.Size = size;
		this.UcCBTDI.TabIndex = 1;
		this.UcTxtNDoc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNDoc.Formato = null;
		this.UcTxtNDoc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNDoc = this.UcTxtNDoc;
		location = new System.Drawing.Point(323, 33);
		ucTxtNDoc.Location = location;
		this.UcTxtNDoc.MaxLength = 12;
		this.UcTxtNDoc.Name = "UcTxtNDoc";
		this.UcTxtNDoc.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNDoc.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNDoc.OnErrorBlankText = "";
		this.UcTxtNDoc.PadLeftLenght = 0;
		this.UcTxtNDoc.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNDoc.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNDoc2 = this.UcTxtNDoc;
		size = new System.Drawing.Size(121, 20);
		ucTxtNDoc2.Size = size;
		this.UcTxtNDoc.TabIndex = 2;
		this.UcTxtNDoc.TabNextControl = false;
		this.UcTxtNDoc.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label11 = this.Label5;
		location = new System.Drawing.Point(50, 112);
		label11.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label12 = this.Label5;
		size = new System.Drawing.Size(52, 13);
		label12.Size = size;
		this.Label5.TabIndex = 38;
		this.Label5.Text = "Nombres:";
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label6;
		location = new System.Drawing.Point(38, 138);
		label13.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label14 = this.Label6;
		size = new System.Drawing.Size(64, 13);
		label14.Size = size;
		this.Label6.TabIndex = 38;
		this.Label6.Text = "Parentesco:";
		this.UcCBParentesco.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBParentesco.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBParentesco.FormattingEnabled = true;
		this.UcCBParentesco.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBParentesco = this.UcCBParentesco;
		location = new System.Drawing.Point(108, 135);
		ucCBParentesco.Location = location;
		this.UcCBParentesco.Name = "UcCBParentesco";
		GRLL.Common.ucComboBox ucCBParentesco2 = this.UcCBParentesco;
		size = new System.Drawing.Size(295, 21);
		ucCBParentesco2.Size = size;
		this.UcCBParentesco.TabIndex = 6;
		this.UcCBEstadoCivil.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBEstadoCivil.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBEstadoCivil.FormattingEnabled = true;
		this.UcCBEstadoCivil.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBEstadoCivil = this.UcCBEstadoCivil;
		location = new System.Drawing.Point(323, 187);
		ucCBEstadoCivil.Location = location;
		this.UcCBEstadoCivil.Name = "UcCBEstadoCivil";
		GRLL.Common.ucComboBox ucCBEstadoCivil2 = this.UcCBEstadoCivil;
		size = new System.Drawing.Size(119, 21);
		ucCBEstadoCivil2.Size = size;
		this.UcCBEstadoCivil.TabIndex = 10;
		this.Label15.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label15;
		location = new System.Drawing.Point(252, 190);
		label15.Location = location;
		this.Label15.Name = "Label15";
		System.Windows.Forms.Label label16 = this.Label15;
		size = new System.Drawing.Size(65, 13);
		label16.Size = size;
		this.Label15.TabIndex = 47;
		this.Label15.Text = "Estado Civil:";
		DevExpress.XtraEditors.RadioGroup radioGroup = this.RadioGroup1;
		location = new System.Drawing.Point(323, 211);
		radioGroup.Location = location;
		this.RadioGroup1.Name = "RadioGroup1";
		this.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup1.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		this.RadioGroup1.Properties.LookAndFeel.SkinName = "The Asphalt World";
		this.RadioGroup1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
		DevExpress.XtraEditors.RadioGroup radioGroup2 = this.RadioGroup1;
		size = new System.Drawing.Size(76, 30);
		radioGroup2.Size = size;
		this.RadioGroup1.TabIndex = 12;
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label7;
		location = new System.Drawing.Point(244, 217);
		label17.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label18 = this.Label7;
		size = new System.Drawing.Size(73, 13);
		label18.Size = size;
		this.Label7.TabIndex = 48;
		this.Label7.Text = "Vive en Casa:";
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label19 = this.Label8;
		location = new System.Drawing.Point(25, 296);
		label19.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label20 = this.Label8;
		size = new System.Drawing.Size(77, 13);
		label20.Size = size;
		this.Label8.TabIndex = 38;
		this.Label8.Text = "Grado de Inst.:";
		this.UcTxtGradoInstruc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtGradoInstruc.Formato = null;
		this.UcTxtGradoInstruc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtGradoInstruc = this.UcTxtGradoInstruc;
		location = new System.Drawing.Point(108, 293);
		ucTxtGradoInstruc.Location = location;
		this.UcTxtGradoInstruc.MaxLength = 80;
		this.UcTxtGradoInstruc.Name = "UcTxtGradoInstruc";
		this.UcTxtGradoInstruc.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtGradoInstruc.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtGradoInstruc.OnErrorBlankText = "";
		this.UcTxtGradoInstruc.PadLeftLenght = 0;
		this.UcTxtGradoInstruc.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtGradoInstruc.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtGradoInstruc.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtGradoInstruc2 = this.UcTxtGradoInstruc;
		size = new System.Drawing.Size(334, 20);
		ucTxtGradoInstruc2.Size = size;
		this.UcTxtGradoInstruc.TabIndex = 16;
		this.UcTxtGradoInstruc.TabNextControl = false;
		this.UcTxtGradoInstruc.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcDateTime1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDateTime1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDateTime = this.UcDateTime1;
		location = new System.Drawing.Point(108, 161);
		ucDateTime.Location = location;
		this.UcDateTime1.Name = "UcDateTime1";
		GRLL.Common.ucDateTime ucDateTime2 = this.UcDateTime1;
		size = new System.Drawing.Size(200, 20);
		ucDateTime2.Size = size;
		this.UcDateTime1.TabIndex = 7;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label21 = this.Label9;
		location = new System.Drawing.Point(8, 165);
		label21.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label22 = this.Label9;
		size = new System.Drawing.Size(96, 13);
		label22.Size = size;
		this.Label9.TabIndex = 48;
		this.Label9.Text = "Fecha Nacimiento:";
		this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGrabar.AutoSize = true;
		this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGrabar.FlatAppearance.BorderSize = 0;
		this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGrabar.Image = (System.Drawing.Image)resources.GetObject("btnGrabar.Image");
		System.Windows.Forms.Button button3 = this.btnGrabar;
		location = new System.Drawing.Point(12, 467);
		button3.Location = location;
		this.btnGrabar.Name = "btnGrabar";
		System.Windows.Forms.Button button4 = this.btnGrabar;
		size = new System.Drawing.Size(65, 23);
		button4.Size = size;
		this.btnGrabar.TabIndex = 17;
		this.btnGrabar.Text = "Grabar";
		this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGrabar.UseVisualStyleBackColor = true;
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label23 = this.Label10;
		location = new System.Drawing.Point(12, 325);
		label23.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label24 = this.Label10;
		size = new System.Drawing.Size(120, 13);
		label24.Size = size;
		this.Label10.TabIndex = 48;
		this.Label10.Text = "Labora en la Institución:";
		DevExpress.XtraEditors.RadioGroup radioGroup3 = this.RadioGroup2;
		location = new System.Drawing.Point(128, 317);
		radioGroup3.Location = location;
		this.RadioGroup2.Name = "RadioGroup2";
		this.RadioGroup2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup2.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		this.RadioGroup2.Properties.LookAndFeel.SkinName = "The Asphalt World";
		this.RadioGroup2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
		DevExpress.XtraEditors.RadioGroup radioGroup4 = this.RadioGroup2;
		size = new System.Drawing.Size(76, 30);
		radioGroup4.Size = size;
		this.RadioGroup2.TabIndex = 17;
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label25 = this.Label11;
		location = new System.Drawing.Point(216, 270);
		label25.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label26 = this.Label11;
		size = new System.Drawing.Size(92, 13);
		label26.Size = size;
		this.Label11.TabIndex = 48;
		this.Label11.Text = "N° Autogenerado:";
		this.UcTxtAutogenSalud.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAutogenSalud.Formato = null;
		this.UcTxtAutogenSalud.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAutogenSalud = this.UcTxtAutogenSalud;
		location = new System.Drawing.Point(314, 267);
		ucTxtAutogenSalud.Location = location;
		this.UcTxtAutogenSalud.MaxLength = 15;
		this.UcTxtAutogenSalud.Name = "UcTxtAutogenSalud";
		this.UcTxtAutogenSalud.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAutogenSalud.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAutogenSalud.OnErrorBlankText = "";
		this.UcTxtAutogenSalud.PadLeftLenght = 0;
		this.UcTxtAutogenSalud.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAutogenSalud.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAutogenSalud2 = this.UcTxtAutogenSalud;
		size = new System.Drawing.Size(128, 20);
		ucTxtAutogenSalud2.Size = size;
		this.UcTxtAutogenSalud.TabIndex = 15;
		this.UcTxtAutogenSalud.TabNextControl = false;
		this.UcTxtAutogenSalud.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label12.AutoSize = true;
		System.Windows.Forms.Label label27 = this.Label12;
		location = new System.Drawing.Point(17, 244);
		label27.Location = location;
		this.Label12.Name = "Label12";
		System.Windows.Forms.Label label28 = this.Label12;
		size = new System.Drawing.Size(85, 13);
		label28.Size = size;
		this.Label12.TabIndex = 38;
		this.Label12.Text = "Domicilio Actual:";
		this.UcTxtDomicilio.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDomicilio.Formato = null;
		this.UcTxtDomicilio.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDomicilio = this.UcTxtDomicilio;
		location = new System.Drawing.Point(108, 241);
		ucTxtDomicilio.Location = location;
		this.UcTxtDomicilio.MaxLength = 100;
		this.UcTxtDomicilio.Name = "UcTxtDomicilio";
		this.UcTxtDomicilio.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDomicilio.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDomicilio.OnErrorBlankText = "";
		this.UcTxtDomicilio.PadLeftLenght = 0;
		this.UcTxtDomicilio.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDomicilio.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDomicilio2 = this.UcTxtDomicilio;
		size = new System.Drawing.Size(334, 20);
		ucTxtDomicilio2.Size = size;
		this.UcTxtDomicilio.TabIndex = 13;
		this.UcTxtDomicilio.TabNextControl = false;
		this.UcTxtDomicilio.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label13.AutoSize = true;
		System.Windows.Forms.Label label29 = this.Label13;
		location = new System.Drawing.Point(50, 270);
		label29.Location = location;
		this.Label13.Name = "Label13";
		System.Windows.Forms.Label label30 = this.Label13;
		size = new System.Drawing.Size(52, 13);
		label30.Size = size;
		this.Label13.TabIndex = 38;
		this.Label13.Text = "Teléfono:";
		this.UcTxtFono.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtFono.Formato = null;
		this.UcTxtFono.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtFono = this.UcTxtFono;
		location = new System.Drawing.Point(108, 267);
		ucTxtFono.Location = location;
		this.UcTxtFono.MaxLength = 15;
		this.UcTxtFono.Name = "UcTxtFono";
		this.UcTxtFono.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtFono.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtFono.OnErrorBlankText = "";
		this.UcTxtFono.PadLeftLenght = 0;
		this.UcTxtFono.RegularExpression = "^[0-9]*$";
		this.UcTxtFono.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtFono.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtFono2 = this.UcTxtFono;
		size = new System.Drawing.Size(103, 20);
		ucTxtFono2.Size = size;
		this.UcTxtFono.TabIndex = 14;
		this.UcTxtFono.TabNextControl = false;
		this.UcTxtFono.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcCBDiscapacidad.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBDiscapacidad.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBDiscapacidad.FormattingEnabled = true;
		this.UcCBDiscapacidad.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBDiscapacidad = this.UcCBDiscapacidad;
		location = new System.Drawing.Point(108, 214);
		ucCBDiscapacidad.Location = location;
		this.UcCBDiscapacidad.Name = "UcCBDiscapacidad";
		GRLL.Common.ucComboBox ucCBDiscapacidad2 = this.UcCBDiscapacidad;
		size = new System.Drawing.Size(121, 21);
		ucCBDiscapacidad2.Size = size;
		this.UcCBDiscapacidad.TabIndex = 11;
		this.Label14.AutoSize = true;
		System.Windows.Forms.Label label31 = this.Label14;
		location = new System.Drawing.Point(27, 217);
		label31.Location = location;
		this.Label14.Name = "Label14";
		System.Windows.Forms.Label label32 = this.Label14;
		size = new System.Drawing.Size(75, 13);
		label32.Size = size;
		this.Label14.TabIndex = 47;
		this.Label14.Text = "Discapacidad:";
		this.GroupControl1.Controls.Add(this.Label17);
		this.GroupControl1.Controls.Add(this.Label16);
		this.GroupControl1.Controls.Add(this.UcTxtTiempo);
		this.GroupControl1.Controls.Add(this.UcTxtEnfermedad);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(15, 379);
		groupControl.Location = location;
		this.GroupControl1.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(438, 79);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 49;
		this.GroupControl1.Text = "Enfermedades";
		this.Label17.AutoSize = true;
		System.Windows.Forms.Label label33 = this.Label17;
		location = new System.Drawing.Point(37, 52);
		label33.Location = location;
		this.Label17.Name = "Label17";
		System.Windows.Forms.Label label34 = this.Label17;
		size = new System.Drawing.Size(45, 13);
		label34.Size = size;
		this.Label17.TabIndex = 38;
		this.Label17.Text = "Tiempo:";
		this.Label16.AutoSize = true;
		System.Windows.Forms.Label label35 = this.Label16;
		location = new System.Drawing.Point(15, 26);
		label35.Location = location;
		this.Label16.Name = "Label16";
		System.Windows.Forms.Label label36 = this.Label16;
		size = new System.Drawing.Size(67, 13);
		label36.Size = size;
		this.Label16.TabIndex = 38;
		this.Label16.Text = "Enfermedad:";
		this.UcTxtTiempo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtTiempo.Formato = null;
		this.UcTxtTiempo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtTiempo = this.UcTxtTiempo;
		location = new System.Drawing.Point(88, 49);
		ucTxtTiempo.Location = location;
		this.UcTxtTiempo.MaxLength = 200;
		this.UcTxtTiempo.Name = "UcTxtTiempo";
		this.UcTxtTiempo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtTiempo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtTiempo.OnErrorBlankText = "";
		this.UcTxtTiempo.PadLeftLenght = 0;
		this.UcTxtTiempo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtTiempo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtTiempo2 = this.UcTxtTiempo;
		size = new System.Drawing.Size(103, 20);
		ucTxtTiempo2.Size = size;
		this.UcTxtTiempo.TabIndex = 21;
		this.UcTxtTiempo.TabNextControl = false;
		this.UcTxtTiempo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtEnfermedad.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEnfermedad.Formato = null;
		this.UcTxtEnfermedad.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEnfermedad = this.UcTxtEnfermedad;
		location = new System.Drawing.Point(88, 23);
		ucTxtEnfermedad.Location = location;
		this.UcTxtEnfermedad.MaxLength = 200;
		this.UcTxtEnfermedad.Name = "UcTxtEnfermedad";
		this.UcTxtEnfermedad.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEnfermedad.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEnfermedad.OnErrorBlankText = "";
		this.UcTxtEnfermedad.PadLeftLenght = 0;
		this.UcTxtEnfermedad.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEnfermedad.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEnfermedad2 = this.UcTxtEnfermedad;
		size = new System.Drawing.Size(303, 20);
		ucTxtEnfermedad2.Size = size;
		this.UcTxtEnfermedad.TabIndex = 20;
		this.UcTxtEnfermedad.TabNextControl = false;
		this.UcTxtEnfermedad.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label18.AutoSize = true;
		System.Windows.Forms.Label label37 = this.Label18;
		location = new System.Drawing.Point(206, 325);
		label37.Location = location;
		this.Label18.Name = "Label18";
		System.Windows.Forms.Label label38 = this.Label18;
		size = new System.Drawing.Size(62, 13);
		label38.Size = size;
		this.Label18.TabIndex = 38;
		this.Label18.Text = "Ocupación:";
		this.Label19.AutoSize = true;
		System.Windows.Forms.Label label39 = this.Label19;
		location = new System.Drawing.Point(15, 356);
		label39.Location = location;
		this.Label19.Name = "Label19";
		System.Windows.Forms.Label label40 = this.Label19;
		size = new System.Drawing.Size(91, 13);
		label40.Size = size;
		this.Label19.TabIndex = 38;
		this.Label19.Text = "Lugar de Trabajo:";
		this.UcTxtOcupacion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtOcupacion.Formato = null;
		this.UcTxtOcupacion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtOcupacion = this.UcTxtOcupacion;
		location = new System.Drawing.Point(274, 322);
		ucTxtOcupacion.Location = location;
		this.UcTxtOcupacion.MaxLength = 20;
		this.UcTxtOcupacion.Name = "UcTxtOcupacion";
		this.UcTxtOcupacion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtOcupacion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtOcupacion.OnErrorBlankText = "";
		this.UcTxtOcupacion.PadLeftLenght = 0;
		this.UcTxtOcupacion.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtOcupacion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtOcupacion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtOcupacion2 = this.UcTxtOcupacion;
		size = new System.Drawing.Size(168, 20);
		ucTxtOcupacion2.Size = size;
		this.UcTxtOcupacion.TabIndex = 18;
		this.UcTxtOcupacion.TabNextControl = false;
		this.UcTxtOcupacion.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtLugTrabajo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtLugTrabajo.Formato = null;
		this.UcTxtLugTrabajo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtLugTrabajo = this.UcTxtLugTrabajo;
		location = new System.Drawing.Point(108, 353);
		ucTxtLugTrabajo.Location = location;
		this.UcTxtLugTrabajo.MaxLength = 50;
		this.UcTxtLugTrabajo.Name = "UcTxtLugTrabajo";
		this.UcTxtLugTrabajo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtLugTrabajo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtLugTrabajo.OnErrorBlankText = "";
		this.UcTxtLugTrabajo.PadLeftLenght = 0;
		this.UcTxtLugTrabajo.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtLugTrabajo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtLugTrabajo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtLugTrabajo2 = this.UcTxtLugTrabajo;
		size = new System.Drawing.Size(334, 20);
		ucTxtLugTrabajo2.Size = size;
		this.UcTxtLugTrabajo.TabIndex = 19;
		this.UcTxtLugTrabajo.TabNextControl = false;
		this.UcTxtLugTrabajo.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label20.AutoSize = true;
		System.Windows.Forms.Label label41 = this.Label20;
		location = new System.Drawing.Point(19, 190);
		label41.Location = location;
		this.Label20.Name = "Label20";
		System.Windows.Forms.Label label42 = this.Label20;
		size = new System.Drawing.Size(83, 13);
		label42.Size = size;
		this.Label20.TabIndex = 47;
		this.Label20.Text = "Tipo de Sangre:";
		this.UcCmbTipoSangre.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbTipoSangre.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbTipoSangre.FormattingEnabled = true;
		this.UcCmbTipoSangre.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbTipoSangre = this.UcCmbTipoSangre;
		location = new System.Drawing.Point(108, 187);
		ucCmbTipoSangre.Location = location;
		this.UcCmbTipoSangre.Name = "UcCmbTipoSangre";
		GRLL.Common.ucComboBox ucCmbTipoSangre2 = this.UcCmbTipoSangre;
		size = new System.Drawing.Size(63, 21);
		ucCmbTipoSangre2.Size = size;
		this.UcCmbTipoSangre.TabIndex = 9;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(462, 529);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl1);
		this.Controls.Add(this.UcCmbTipoSangre);
		this.Controls.Add(this.UcCBDiscapacidad);
		this.Controls.Add(this.UcTxtAutogenSalud);
		this.Controls.Add(this.btnGrabar);
		this.Controls.Add(this.UcDateTime1);
		this.Controls.Add(this.RadioGroup2);
		this.Controls.Add(this.RadioGroup1);
		this.Controls.Add(this.Label9);
		this.Controls.Add(this.Label11);
		this.Controls.Add(this.Label10);
		this.Controls.Add(this.Label7);
		this.Controls.Add(this.Label20);
		this.Controls.Add(this.UcCBEstadoCivil);
		this.Controls.Add(this.Label14);
		this.Controls.Add(this.Label15);
		this.Controls.Add(this.UcCBSexo);
		this.Controls.Add(this.Label24);
		this.Controls.Add(this.UcTxtApePater);
		this.Controls.Add(this.UcTxtFono);
		this.Controls.Add(this.UcTxtDomicilio);
		this.Controls.Add(this.UcTxtLugTrabajo);
		this.Controls.Add(this.UcTxtOcupacion);
		this.Controls.Add(this.UcTxtGradoInstruc);
		this.Controls.Add(this.UcTxtNombres);
		this.Controls.Add(this.UcTxtApeMater);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcCBParentesco);
		this.Controls.Add(this.UcCBTDI);
		this.Controls.Add(this.UcTxtNDoc);
		this.Controls.Add(this.Label13);
		this.Controls.Add(this.Label12);
		this.Controls.Add(this.Label19);
		this.Controls.Add(this.Label18);
		this.Controls.Add(this.Label8);
		this.Controls.Add(this.Label6);
		this.Controls.Add(this.Label5);
		this.MessageShow = true;
		this.Name = "FrmFamiliar";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Familiares";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.Label6, 0);
		this.Controls.SetChildIndex(this.Label8, 0);
		this.Controls.SetChildIndex(this.Label18, 0);
		this.Controls.SetChildIndex(this.Label19, 0);
		this.Controls.SetChildIndex(this.Label12, 0);
		this.Controls.SetChildIndex(this.Label13, 0);
		this.Controls.SetChildIndex(this.UcTxtNDoc, 0);
		this.Controls.SetChildIndex(this.UcCBTDI, 0);
		this.Controls.SetChildIndex(this.UcCBParentesco, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.UcTxtApeMater, 0);
		this.Controls.SetChildIndex(this.UcTxtNombres, 0);
		this.Controls.SetChildIndex(this.UcTxtGradoInstruc, 0);
		this.Controls.SetChildIndex(this.UcTxtOcupacion, 0);
		this.Controls.SetChildIndex(this.UcTxtLugTrabajo, 0);
		this.Controls.SetChildIndex(this.UcTxtDomicilio, 0);
		this.Controls.SetChildIndex(this.UcTxtFono, 0);
		this.Controls.SetChildIndex(this.UcTxtApePater, 0);
		this.Controls.SetChildIndex(this.Label24, 0);
		this.Controls.SetChildIndex(this.UcCBSexo, 0);
		this.Controls.SetChildIndex(this.Label15, 0);
		this.Controls.SetChildIndex(this.Label14, 0);
		this.Controls.SetChildIndex(this.UcCBEstadoCivil, 0);
		this.Controls.SetChildIndex(this.Label20, 0);
		this.Controls.SetChildIndex(this.Label7, 0);
		this.Controls.SetChildIndex(this.Label10, 0);
		this.Controls.SetChildIndex(this.Label11, 0);
		this.Controls.SetChildIndex(this.Label9, 0);
		this.Controls.SetChildIndex(this.RadioGroup1, 0);
		this.Controls.SetChildIndex(this.RadioGroup2, 0);
		this.Controls.SetChildIndex(this.UcDateTime1, 0);
		this.Controls.SetChildIndex(this.btnGrabar, 0);
		this.Controls.SetChildIndex(this.UcTxtAutogenSalud, 0);
		this.Controls.SetChildIndex(this.UcCBDiscapacidad, 0);
		this.Controls.SetChildIndex(this.UcCmbTipoSangre, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

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

	private void UcTxtNDoc_LostFocus(object sender, EventArgs e)
	{
		if (codper == 0)
		{
			buscarxDNI();
			focus = 1;
		}
	}

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

	private void btnGrabar_Click(object sender, EventArgs e)
	{
		GrabarFamiliar();
		DialogResult = DialogResult.OK;
	}

	private void UcTxtNDoc_TextChanged(object sender, EventArgs e)
	{
		if (focus > 0)
		{
			this.Limpiar_Controles(UcTxtNDoc.Name);
			buscarxDNI();
		}
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
