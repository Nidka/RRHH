using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTabbedMdi;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmMantEmpleado_Basico : FrmConsulta
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

	[AccessedThroughProperty("UcFoto")]
	private ucFoto _UcFoto;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcComboBoxTDI")]
	private ucComboBox _UcComboBoxTDI;

	[AccessedThroughProperty("UcTxtNDoc")]
	private ucTextBox _UcTxtNDoc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcCBEstadoCivil")]
	private ucComboBox _UcCBEstadoCivil;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("UcDTFechaReg")]
	private ucDateTime _UcDTFechaReg;

	[AccessedThroughProperty("UcTxtGradoInstruccion")]
	private ucTextBox _UcTxtGradoInstruccion;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("btnGuardar")]
	private Button _btnGuardar;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("UcCBArea")]
	private ucComboBox _UcCBArea;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("UcTxtLibMilitar")]
	private ucTextBox _UcTxtLibMilitar;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("UcTxtNumRUc")]
	private ucTextBox _UcTxtNumRUc;

	[AccessedThroughProperty("XtraTabbedMdiManager1")]
	private XtraTabbedMdiManager _XtraTabbedMdiManager1;

	[AccessedThroughProperty("CheckEquipoMarcacion")]
	private CheckEdit _CheckEquipoMarcacion;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("XtraTabControl2")]
	private XtraTabControl _XtraTabControl2;

	[AccessedThroughProperty("XtraTabPage2")]
	private XtraTabPage _XtraTabPage2;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("UcTxtDirec")]
	private ucTextBox _UcTxtDirec;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("UcCBNacionalidad")]
	private ucComboBox _UcCBNacionalidad;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("UcTxtMovil")]
	private ucTextBox _UcTxtMovil;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("UcTxtOtro")]
	private ucTextBox _UcTxtOtro;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("UcTxtCentroLab")]
	private ucTextBox _UcTxtCentroLab;

	[AccessedThroughProperty("UcTxtFono")]
	private ucTextBox _UcTxtFono;

	[AccessedThroughProperty("UcTxteMail")]
	private ucTextBox _UcTxteMail;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("UcUbigeoCmbDirec")]
	private ucUbigeoCmb _UcUbigeoCmbDirec;

	[AccessedThroughProperty("XtraTabPage1")]
	private XtraTabPage _XtraTabPage1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("UcUbigeoCmb1")]
	private ucUbigeoCmb _UcUbigeoCmb1;

	[AccessedThroughProperty("UcDTFechaNac")]
	private ucDateTime _UcDTFechaNac;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("XtraTabPage3")]
	private XtraTabPage _XtraTabPage3;

	[AccessedThroughProperty("UcCBDiscapacidad")]
	private ucComboBox _UcCBDiscapacidad;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("UcTxtExpSocial")]
	private ucTextBox _UcTxtExpSocial;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("UcTxtBrevete")]
	private ucTextBox _UcTxtBrevete;

	[AccessedThroughProperty("UcCBGrupoSanguineo")]
	private ucComboBox _UcCBGrupoSanguineo;

	[AccessedThroughProperty("XtraTabPage4")]
	private XtraTabPage _XtraTabPage4;

	[AccessedThroughProperty("GridControlEmpleado_Area")]
	private GridControl _GridControlEmpleado_Area;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("RepositoryItemComboBox1")]
	private RepositoryItemComboBox _RepositoryItemComboBox1;

	[AccessedThroughProperty("RepositoryItemComboBox2")]
	private RepositoryItemComboBox _RepositoryItemComboBox2;

	[AccessedThroughProperty("RepositoryItemLookUpEdit1")]
	private RepositoryItemLookUpEdit _RepositoryItemLookUpEdit1;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("RepositoryItemComboBox3")]
	private RepositoryItemComboBox _RepositoryItemComboBox3;

	[AccessedThroughProperty("RepositoryItemPopupContainerEdit1")]
	private RepositoryItemPopupContainerEdit _RepositoryItemPopupContainerEdit1;

	[AccessedThroughProperty("PopupContainerControl1")]
	private PopupContainerControl _PopupContainerControl1;

	[AccessedThroughProperty("GridControlListaAreas")]
	private GridControl _GridControlListaAreas;

	[AccessedThroughProperty("GridViewListaAreas")]
	private GridView _GridViewListaAreas;

	[AccessedThroughProperty("RepositoryItemButtonEdit1")]
	private RepositoryItemButtonEdit _RepositoryItemButtonEdit1;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("UcCBTipoTrab")]
	private ucComboBox _UcCBTipoTrab;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	private RRHHClass objClassRRHH;

	private FamiliaresClass objFamiliaresClass;

	public int MantEmpleado_Basico_Cod;

	private int codPersona;

	private byte[] img;

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

	internal ucFoto UcFoto
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcFoto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcFoto = value;
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
			if (_UcTxtNDoc != null)
			{
				_UcTxtNDoc.LostFocus -= value2;
			}
			_UcTxtNDoc = value;
			if (_UcTxtNDoc != null)
			{
				_UcTxtNDoc.LostFocus += value2;
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

	internal ucDateTime UcDTFechaReg
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFechaReg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFechaReg = value;
		}
	}

	internal ucTextBox UcTxtGradoInstruccion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtGradoInstruccion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtGradoInstruccion = value;
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

	internal Label Label44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label44 = value;
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

	internal ucComboBox UcCBArea
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBArea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBArea = value;
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

	internal ucTextBox UcTxtLibMilitar
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtLibMilitar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtLibMilitar = value;
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

	internal ucTextBox UcTxtNumRUc
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumRUc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumRUc = value;
		}
	}

	internal XtraTabbedMdiManager XtraTabbedMdiManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabbedMdiManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabbedMdiManager1 = value;
		}
	}

	internal CheckEdit CheckEquipoMarcacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEquipoMarcacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEquipoMarcacion = value;
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

	internal XtraTabControl XtraTabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabControl2 = value;
		}
	}

	internal XtraTabPage XtraTabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage2 = value;
		}
	}

	internal GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal ucTextBox UcTxtDirec
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDirec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDirec = value;
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

	internal ucComboBox UcCBNacionalidad
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBNacionalidad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBNacionalidad = value;
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

	internal Label Label41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label41 = value;
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

	internal ucTextBox UcTxtMovil
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtMovil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtMovil = value;
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

	internal ucTextBox UcTxtOtro
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtOtro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtOtro = value;
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

	internal ucTextBox UcTxtCentroLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCentroLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtCentroLab = value;
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

	internal ucTextBox UcTxteMail
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxteMail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxteMail = value;
		}
	}

	internal Label Label42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label42 = value;
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

	internal XtraTabPage XtraTabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage1 = value;
		}
	}

	internal GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal ucUbigeoCmb UcUbigeoCmb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcUbigeoCmb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcUbigeoCmb1 = value;
		}
	}

	internal ucDateTime UcDTFechaNac
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFechaNac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFechaNac = value;
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

	internal XtraTabPage XtraTabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage3 = value;
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

	internal ucTextBox UcTxtExpSocial
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtExpSocial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtExpSocial = value;
		}
	}

	internal Label Label43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label43 = value;
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

	internal ucTextBox UcTxtBrevete
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtBrevete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtBrevete = value;
		}
	}

	internal ucComboBox UcCBGrupoSanguineo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBGrupoSanguineo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBGrupoSanguineo = value;
		}
	}

	internal XtraTabPage XtraTabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage4 = value;
		}
	}

	internal GridControl GridControlEmpleado_Area
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControlEmpleado_Area;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControlEmpleado_Area = value;
		}
	}

	internal GridView GridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			CustomRowCellEditEventHandler value2 = GridView1_CustomRowCellEdit;
			if (_GridView1 != null)
			{
				_GridView1.CustomRowCellEdit -= value2;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.CustomRowCellEdit += value2;
			}
		}
	}

	internal RepositoryItemComboBox RepositoryItemComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemComboBox1 = value;
		}
	}

	internal RepositoryItemComboBox RepositoryItemComboBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemComboBox2 = value;
		}
	}

	internal RepositoryItemLookUpEdit RepositoryItemLookUpEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemLookUpEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemLookUpEdit1 = value;
		}
	}

	internal GridColumn GridColumn1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn1 = value;
		}
	}

	internal GridColumn GridColumn2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn2 = value;
		}
	}

	internal RepositoryItemComboBox RepositoryItemComboBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemComboBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemComboBox3 = value;
		}
	}

	internal RepositoryItemPopupContainerEdit RepositoryItemPopupContainerEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemPopupContainerEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemPopupContainerEdit1 = value;
		}
	}

	internal PopupContainerControl PopupContainerControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PopupContainerControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PopupContainerControl1 = value;
		}
	}

	internal GridControl GridControlListaAreas
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControlListaAreas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControlListaAreas = value;
		}
	}

	internal GridView GridViewListaAreas
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewListaAreas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = GridViewListaAreas_DoubleClick;
			if (_GridViewListaAreas != null)
			{
				_GridViewListaAreas.DoubleClick -= value2;
			}
			_GridViewListaAreas = value;
			if (_GridViewListaAreas != null)
			{
				_GridViewListaAreas.DoubleClick += value2;
			}
		}
	}

	internal RepositoryItemButtonEdit RepositoryItemButtonEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemButtonEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ButtonPressedEventHandler value2 = repositoryItemButtonEdit_ButtonClick;
			if (_RepositoryItemButtonEdit1 != null)
			{
				_RepositoryItemButtonEdit1.ButtonClick -= value2;
			}
			_RepositoryItemButtonEdit1 = value;
			if (_RepositoryItemButtonEdit1 != null)
			{
				_RepositoryItemButtonEdit1.ButtonClick += value2;
			}
		}
	}

	internal GridColumn GridColumn4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn4 = value;
		}
	}

	internal GridColumn GridColumn5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn5 = value;
		}
	}

	internal GridColumn GridColumn6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn6 = value;
		}
	}

	internal ucComboBox UcCBTipoTrab
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoTrab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTipoTrab = value;
		}
	}

	internal Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	public FrmMantEmpleado_Basico()
	{
		base.Load += FrmMantEmpleado_Basico_Load;
		__ENCAddToList(this);
		objClassRRHH = new RRHHClass();
		objFamiliaresClass = new FamiliaresClass();
		img = null;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmMantEmpleado_Basico));
		this.UcCBSexo = new GRLL.Common.ucComboBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.UcTxtApePater = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApeMater = new GRLL.Common.ucTextBox(this.components);
		this.UcFoto = new GRLL.Common.ucFoto();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcComboBoxTDI = new GRLL.Common.ucComboBox();
		this.UcTxtNDoc = new GRLL.Common.ucTextBox(this.components);
		this.Label5 = new System.Windows.Forms.Label();
		this.UcCBEstadoCivil = new GRLL.Common.ucComboBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.UcDTFechaReg = new GRLL.Common.ucDateTime();
		this.UcTxtGradoInstruccion = new GRLL.Common.ucTextBox(this.components);
		this.Label12 = new System.Windows.Forms.Label();
		this.Label44 = new System.Windows.Forms.Label();
		this.btnGuardar = new System.Windows.Forms.Button();
		this.Label13 = new System.Windows.Forms.Label();
		this.UcCBArea = new GRLL.Common.ucComboBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.UcTxtLibMilitar = new GRLL.Common.ucTextBox(this.components);
		this.Label19 = new System.Windows.Forms.Label();
		this.UcTxtNumRUc = new GRLL.Common.ucTextBox(this.components);
		this.XtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
		this.CheckEquipoMarcacion = new DevExpress.XtraEditors.CheckEdit();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.XtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
		this.GridControlEmpleado_Area = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
		this.PopupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
		this.GridControlListaAreas = new DevExpress.XtraGrid.GridControl();
		this.GridViewListaAreas = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
		this.RepositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
		this.RepositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
		this.RepositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
		this.RepositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
		this.XtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
		this.UcCBDiscapacidad = new GRLL.Common.ucComboBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.UcTxtExpSocial = new GRLL.Common.ucTextBox(this.components);
		this.Label43 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.UcTxtBrevete = new GRLL.Common.ucTextBox(this.components);
		this.UcCBGrupoSanguineo = new GRLL.Common.ucComboBox();
		this.XtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.UcUbigeoCmb1 = new GRLL.Common.ucUbigeoCmb();
		this.UcDTFechaNac = new GRLL.Common.ucDateTime();
		this.Label11 = new System.Windows.Forms.Label();
		this.XtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.UcTxtDirec = new GRLL.Common.ucTextBox(this.components);
		this.Label6 = new System.Windows.Forms.Label();
		this.UcCBNacionalidad = new GRLL.Common.ucComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label41 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.UcTxtMovil = new GRLL.Common.ucTextBox(this.components);
		this.Label8 = new System.Windows.Forms.Label();
		this.UcTxtOtro = new GRLL.Common.ucTextBox(this.components);
		this.Label9 = new System.Windows.Forms.Label();
		this.UcTxtCentroLab = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtFono = new GRLL.Common.ucTextBox(this.components);
		this.UcTxteMail = new GRLL.Common.ucTextBox(this.components);
		this.Label42 = new System.Windows.Forms.Label();
		this.UcUbigeoCmbDirec = new GRLL.Common.ucUbigeoCmb();
		this.XtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
		this.UcCBTipoTrab = new GRLL.Common.ucComboBox();
		this.Label28 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.XtraTabbedMdiManager1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).BeginInit();
		this.XtraTabPage4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControlEmpleado_Area).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemPopupContainerEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PopupContainerControl1).BeginInit();
		this.PopupContainerControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControlListaAreas).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewListaAreas).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemButtonEdit1).BeginInit();
		this.XtraTabPage3.SuspendLayout();
		this.XtraTabPage1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.XtraTabPage2.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.XtraTabControl2).BeginInit();
		this.XtraTabControl2.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(514, 554);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 29;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(587, 24);
		panelSup.Size = size;
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, -54);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(553, 27);
		panelInf2.Size = size;
		this.UcCBSexo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBSexo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBSexo.FormattingEnabled = true;
		this.UcCBSexo.IncluirNinguno = false;
		this.UcCBSexo.Items.AddRange(new object[2] { "M", "F" });
		GRLL.Common.ucComboBox ucCBSexo = this.UcCBSexo;
		location = new System.Drawing.Point(278, 176);
		ucCBSexo.Location = location;
		this.UcCBSexo.Name = "UcCBSexo";
		GRLL.Common.ucComboBox ucCBSexo2 = this.UcCBSexo;
		size = new System.Drawing.Size(50, 21);
		ucCBSexo2.Size = size;
		this.UcCBSexo.TabIndex = 8;
		this.Label24.AutoSize = true;
		System.Windows.Forms.Label label = this.Label24;
		location = new System.Drawing.Point(238, 179);
		label.Location = location;
		this.Label24.Name = "Label24";
		System.Windows.Forms.Label label2 = this.Label24;
		size = new System.Drawing.Size(34, 13);
		label2.Size = size;
		this.Label24.TabIndex = 29;
		this.Label24.Text = "Sexo:";
		this.UcTxtApePater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApePater.Formato = null;
		this.UcTxtApePater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApePater = this.UcTxtApePater;
		location = new System.Drawing.Point(101, 99);
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
		size = new System.Drawing.Size(217, 20);
		ucTxtApePater2.Size = size;
		this.UcTxtApePater.TabIndex = 3;
		this.UcTxtApePater.TabNextControl = false;
		this.UcTxtApePater.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(101, 149);
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
		size = new System.Drawing.Size(309, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 5;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtApeMater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApeMater.Formato = null;
		this.UcTxtApeMater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApeMater = this.UcTxtApeMater;
		location = new System.Drawing.Point(101, 124);
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
		size = new System.Drawing.Size(217, 20);
		ucTxtApeMater2.Size = size;
		this.UcTxtApeMater.TabIndex = 4;
		this.UcTxtApeMater.TabNextControl = false;
		this.UcTxtApeMater.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcFoto.AjustarImagen = true;
		this.UcFoto.Borde = false;
		this.UcFoto.FileName = "";
		this.UcFoto.Image = null;
		this.UcFoto.ImageChanged = false;
		GRLL.Common.ucFoto ucFoto = this.UcFoto;
		location = new System.Drawing.Point(426, 71);
		ucFoto.Location = location;
		this.UcFoto.Name = "UcFoto";
		GRLL.Common.ucFoto ucFoto2 = this.UcFoto;
		size = new System.Drawing.Size(149, 173);
		ucFoto2.Size = size;
		this.UcFoto.TabIndex = 6;
		this.UcFoto.VerAjuste = false;
		this.UcFoto.VerControles = true;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label3;
		location = new System.Drawing.Point(11, 102);
		label3.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label4 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label4.Size = size;
		this.Label3.TabIndex = 31;
		this.Label3.Text = "Apellido Paterno:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label2;
		location = new System.Drawing.Point(11, 75);
		label5.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label6 = this.Label2;
		size = new System.Drawing.Size(87, 13);
		label6.Size = size;
		this.Label2.TabIndex = 30;
		this.Label2.Text = "Tipo Doc. Ident.:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(9, 127);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label8.Size = size;
		this.Label4.TabIndex = 32;
		this.Label4.Text = "Apellido Materno:";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label1;
		location = new System.Drawing.Point(235, 75);
		label9.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label10 = this.Label1;
		size = new System.Drawing.Size(48, 13);
		label10.Size = size;
		this.Label1.TabIndex = 27;
		this.Label1.Text = "Nº Doc.:";
		this.UcComboBoxTDI.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcComboBoxTDI.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcComboBoxTDI.FormattingEnabled = true;
		this.UcComboBoxTDI.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucComboBoxTDI = this.UcComboBoxTDI;
		location = new System.Drawing.Point(101, 71);
		ucComboBoxTDI.Location = location;
		this.UcComboBoxTDI.Name = "UcComboBoxTDI";
		GRLL.Common.ucComboBox ucComboBoxTDI2 = this.UcComboBoxTDI;
		size = new System.Drawing.Size(121, 21);
		ucComboBoxTDI2.Size = size;
		this.UcComboBoxTDI.TabIndex = 1;
		this.UcTxtNDoc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNDoc.Formato = null;
		this.UcTxtNDoc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNDoc = this.UcTxtNDoc;
		location = new System.Drawing.Point(289, 71);
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
		location = new System.Drawing.Point(46, 152);
		label11.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label12 = this.Label5;
		size = new System.Drawing.Size(52, 13);
		label12.Size = size;
		this.Label5.TabIndex = 25;
		this.Label5.Text = "Nombres:";
		this.UcCBEstadoCivil.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBEstadoCivil.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBEstadoCivil.FormattingEnabled = true;
		this.UcCBEstadoCivil.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBEstadoCivil = this.UcCBEstadoCivil;
		location = new System.Drawing.Point(102, 176);
		ucCBEstadoCivil.Location = location;
		this.UcCBEstadoCivil.Name = "UcCBEstadoCivil";
		GRLL.Common.ucComboBox ucCBEstadoCivil2 = this.UcCBEstadoCivil;
		size = new System.Drawing.Size(119, 21);
		ucCBEstadoCivil2.Size = size;
		this.UcCBEstadoCivil.TabIndex = 7;
		this.Label15.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label15;
		location = new System.Drawing.Point(34, 179);
		label13.Location = location;
		this.Label15.Name = "Label15";
		System.Windows.Forms.Label label14 = this.Label15;
		size = new System.Drawing.Size(65, 13);
		label14.Size = size;
		this.Label15.TabIndex = 43;
		this.Label15.Text = "Estado Civil:";
		this.UcDTFechaReg.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFechaReg.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcDTFechaReg.Enabled = false;
		GRLL.Common.ucDateTime ucDTFechaReg = this.UcDTFechaReg;
		location = new System.Drawing.Point(351, 35);
		ucDTFechaReg.Location = location;
		this.UcDTFechaReg.Name = "UcDTFechaReg";
		GRLL.Common.ucDateTime ucDTFechaReg2 = this.UcDTFechaReg;
		size = new System.Drawing.Size(212, 20);
		ucDTFechaReg2.Size = size;
		this.UcDTFechaReg.TabIndex = 11;
		this.UcTxtGradoInstruccion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtGradoInstruccion.Formato = null;
		this.UcTxtGradoInstruccion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtGradoInstruccion = this.UcTxtGradoInstruccion;
		location = new System.Drawing.Point(139, 228);
		ucTxtGradoInstruccion.Location = location;
		this.UcTxtGradoInstruccion.Name = "UcTxtGradoInstruccion";
		this.UcTxtGradoInstruccion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtGradoInstruccion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtGradoInstruccion.OnErrorBlankText = "";
		this.UcTxtGradoInstruccion.PadLeftLenght = 0;
		this.UcTxtGradoInstruccion.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtGradoInstruccion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtGradoInstruccion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtGradoInstruccion2 = this.UcTxtGradoInstruccion;
		size = new System.Drawing.Size(281, 20);
		ucTxtGradoInstruccion2.Size = size;
		this.UcTxtGradoInstruccion.TabIndex = 16;
		this.UcTxtGradoInstruccion.TabNextControl = false;
		this.UcTxtGradoInstruccion.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label12.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label12;
		location = new System.Drawing.Point(279, 39);
		label15.Location = location;
		this.Label12.Name = "Label12";
		System.Windows.Forms.Label label16 = this.Label12;
		size = new System.Drawing.Size(66, 13);
		label16.Size = size;
		this.Label12.TabIndex = 33;
		this.Label12.Text = "Fecha Reg.:";
		this.Label44.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label44;
		location = new System.Drawing.Point(24, 231);
		label17.Location = location;
		this.Label44.Name = "Label44";
		System.Windows.Forms.Label label18 = this.Label44;
		size = new System.Drawing.Size(109, 13);
		label18.Size = size;
		this.Label44.TabIndex = 36;
		this.Label44.Text = "Grado de Instruccion:";
		this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGuardar.AutoSize = true;
		this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGuardar.FlatAppearance.BorderSize = 0;
		this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
		System.Windows.Forms.Button button3 = this.btnGuardar;
		location = new System.Drawing.Point(14, 552);
		button3.Location = location;
		this.btnGuardar.Name = "btnGuardar";
		System.Windows.Forms.Button button4 = this.btnGuardar;
		size = new System.Drawing.Size(71, 23);
		button4.Size = size;
		this.btnGuardar.TabIndex = 28;
		this.btnGuardar.Text = "Guardar";
		this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGuardar.UseVisualStyleBackColor = true;
		this.Label13.AutoSize = true;
		System.Windows.Forms.Label label19 = this.Label13;
		location = new System.Drawing.Point(42, 257);
		label19.Location = location;
		this.Label13.Name = "Label13";
		System.Windows.Forms.Label label20 = this.Label13;
		size = new System.Drawing.Size(91, 13);
		label20.Size = size;
		this.Label13.TabIndex = 36;
		this.Label13.Text = "Lugar de Trabajo:";
		this.UcCBArea.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBArea.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBArea.FormattingEnabled = true;
		this.UcCBArea.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBArea = this.UcCBArea;
		location = new System.Drawing.Point(139, 254);
		ucCBArea.Location = location;
		this.UcCBArea.Name = "UcCBArea";
		GRLL.Common.ucComboBox ucCBArea2 = this.UcCBArea;
		size = new System.Drawing.Size(281, 21);
		ucCBArea2.Size = size;
		this.UcCBArea.TabIndex = 17;
		this.Label17.AutoSize = true;
		System.Windows.Forms.Label label21 = this.Label17;
		location = new System.Drawing.Point(238, 206);
		label21.Location = location;
		this.Label17.Name = "Label17";
		System.Windows.Forms.Label label22 = this.Label17;
		size = new System.Drawing.Size(85, 13);
		label22.Size = size;
		this.Label17.TabIndex = 47;
		this.Label17.Text = "Num. Lib. Militar:";
		this.UcTxtLibMilitar.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtLibMilitar.Formato = null;
		this.UcTxtLibMilitar.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtLibMilitar = this.UcTxtLibMilitar;
		location = new System.Drawing.Point(329, 202);
		ucTxtLibMilitar.Location = location;
		this.UcTxtLibMilitar.MaxLength = 11;
		this.UcTxtLibMilitar.Name = "UcTxtLibMilitar";
		this.UcTxtLibMilitar.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtLibMilitar.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtLibMilitar.OnErrorBlankText = "";
		this.UcTxtLibMilitar.PadLeftLenght = 0;
		this.UcTxtLibMilitar.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtLibMilitar.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtLibMilitar2 = this.UcTxtLibMilitar;
		size = new System.Drawing.Size(91, 20);
		ucTxtLibMilitar2.Size = size;
		this.UcTxtLibMilitar.TabIndex = 13;
		this.UcTxtLibMilitar.TabNextControl = false;
		this.UcTxtLibMilitar.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label19.AutoSize = true;
		System.Windows.Forms.Label label23 = this.Label19;
		location = new System.Drawing.Point(31, 206);
		label23.Location = location;
		this.Label19.Name = "Label19";
		System.Windows.Forms.Label label24 = this.Label19;
		size = new System.Drawing.Size(63, 13);
		label24.Size = size;
		this.Label19.TabIndex = 46;
		this.Label19.Text = "N° de RUC:";
		this.UcTxtNumRUc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumRUc.Formato = null;
		this.UcTxtNumRUc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumRUc = this.UcTxtNumRUc;
		location = new System.Drawing.Point(100, 202);
		ucTxtNumRUc.Location = location;
		this.UcTxtNumRUc.Name = "UcTxtNumRUc";
		this.UcTxtNumRUc.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumRUc.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumRUc.OnErrorBlankText = "";
		this.UcTxtNumRUc.PadLeftLenght = 0;
		this.UcTxtNumRUc.RegularExpression = "^[0-9]*$";
		this.UcTxtNumRUc.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumRUc.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumRUc2 = this.UcTxtNumRUc;
		size = new System.Drawing.Size(121, 20);
		ucTxtNumRUc2.Size = size;
		this.UcTxtNumRUc.TabIndex = 14;
		this.UcTxtNumRUc.TabNextControl = false;
		this.UcTxtNumRUc.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.XtraTabbedMdiManager1.MdiParent = this;
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion = this.CheckEquipoMarcacion;
		location = new System.Drawing.Point(16, 518);
		checkEquipoMarcacion.Location = location;
		this.CheckEquipoMarcacion.Name = "CheckEquipoMarcacion";
		this.CheckEquipoMarcacion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.CheckEquipoMarcacion.Properties.Appearance.Options.UseBackColor = true;
		this.CheckEquipoMarcacion.Properties.Caption = "Actualizar Equipo Marcacion";
		DevExpress.XtraEditors.CheckEdit checkEquipoMarcacion2 = this.CheckEquipoMarcacion;
		size = new System.Drawing.Size(169, 18);
		checkEquipoMarcacion2.Size = size;
		this.CheckEquipoMarcacion.TabIndex = 51;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.XtraTabPage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage4.Controls.Add(this.GridControlEmpleado_Area);
		this.XtraTabPage4.Name = "XtraTabPage4";
		DevExpress.XtraTab.XtraTabPage xtraTabPage = this.XtraTabPage4;
		size = new System.Drawing.Size(546, 174);
		xtraTabPage.Size = size;
		this.XtraTabPage4.Text = "Dependencias";
		DevExpress.XtraGrid.GridControl gridControlEmpleado_Area = this.GridControlEmpleado_Area;
		location = new System.Drawing.Point(11, 8);
		gridControlEmpleado_Area.Location = location;
		this.GridControlEmpleado_Area.MainView = this.GridView1;
		this.GridControlEmpleado_Area.Name = "GridControlEmpleado_Area";
		this.GridControlEmpleado_Area.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[6] { this.RepositoryItemComboBox1, this.RepositoryItemComboBox2, this.RepositoryItemLookUpEdit1, this.RepositoryItemComboBox3, this.RepositoryItemPopupContainerEdit1, this.RepositoryItemButtonEdit1 });
		DevExpress.XtraGrid.GridControl gridControlEmpleado_Area2 = this.GridControlEmpleado_Area;
		size = new System.Drawing.Size(532, 200);
		gridControlEmpleado_Area2.Size = size;
		this.GridControlEmpleado_Area.TabIndex = 0;
		this.GridControlEmpleado_Area.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.GridColumn1, this.GridColumn2 });
		this.GridView1.GridControl = this.GridControlEmpleado_Area;
		this.GridView1.Name = "GridView1";
		this.GridView1.OptionsCustomization.AllowFilter = false;
		this.GridView1.OptionsCustomization.AllowGroup = false;
		this.GridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
		this.GridView1.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Año";
		this.GridColumn1.FieldName = "Year";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.OptionsColumn.AllowEdit = false;
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 80;
		this.GridColumn2.Caption = "Area Organizacional";
		this.GridColumn2.ColumnEdit = this.RepositoryItemPopupContainerEdit1;
		this.GridColumn2.FieldName = "AreaOrganizacional";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn2.Width = 431;
		this.RepositoryItemPopupContainerEdit1.AutoHeight = false;
		this.RepositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1";
		this.RepositoryItemPopupContainerEdit1.PopupControl = this.PopupContainerControl1;
		this.PopupContainerControl1.Controls.Add(this.GridControlListaAreas);
		DevExpress.XtraEditors.PopupContainerControl popupContainerControl = this.PopupContainerControl1;
		location = new System.Drawing.Point(124, 497);
		popupContainerControl.Location = location;
		this.PopupContainerControl1.Name = "PopupContainerControl1";
		DevExpress.XtraEditors.PopupContainerControl popupContainerControl2 = this.PopupContainerControl1;
		size = new System.Drawing.Size(436, 143);
		popupContainerControl2.Size = size;
		this.PopupContainerControl1.TabIndex = 52;
		this.GridControlListaAreas.Dock = System.Windows.Forms.DockStyle.Fill;
		DevExpress.XtraGrid.GridControl gridControlListaAreas = this.GridControlListaAreas;
		location = new System.Drawing.Point(0, 0);
		gridControlListaAreas.Location = location;
		this.GridControlListaAreas.MainView = this.GridViewListaAreas;
		this.GridControlListaAreas.Name = "GridControlListaAreas";
		DevExpress.XtraGrid.GridControl gridControlListaAreas2 = this.GridControlListaAreas;
		size = new System.Drawing.Size(436, 143);
		gridControlListaAreas2.Size = size;
		this.GridControlListaAreas.TabIndex = 0;
		this.GridControlListaAreas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewListaAreas });
		this.GridViewListaAreas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.GridColumn4, this.GridColumn5, this.GridColumn6 });
		this.GridViewListaAreas.GridControl = this.GridControlListaAreas;
		this.GridViewListaAreas.Name = "GridViewListaAreas";
		this.GridViewListaAreas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridViewListaAreas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridViewListaAreas.OptionsBehavior.Editable = false;
		this.GridViewListaAreas.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewListaAreas.OptionsCustomization.AllowFilter = false;
		this.GridViewListaAreas.OptionsCustomization.AllowGroup = false;
		this.GridViewListaAreas.OptionsView.ShowGroupPanel = false;
		this.GridColumn4.Caption = "GridColumn4";
		this.GridColumn4.FieldName = "Year";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn5.Caption = "GridColumn5";
		this.GridColumn5.FieldName = "idAreaOrganiz";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn6.Caption = "Area Organizacional";
		this.GridColumn6.FieldName = "AreaOrganizacional";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 0;
		this.RepositoryItemComboBox1.AutoHeight = false;
		this.RepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1";
		this.RepositoryItemComboBox2.AutoHeight = false;
		this.RepositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2";
		this.RepositoryItemLookUpEdit1.AutoHeight = false;
		this.RepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemLookUpEdit1.DisplayMember = "AreaOrganizacional";
		this.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1";
		this.RepositoryItemLookUpEdit1.ValueMember = "idAreaOrganiz";
		this.RepositoryItemComboBox3.AutoHeight = false;
		this.RepositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3";
		this.RepositoryItemButtonEdit1.AutoHeight = false;
		this.RepositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton()
		});
		this.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1";
		this.XtraTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage3.Controls.Add(this.UcCBDiscapacidad);
		this.XtraTabPage3.Controls.Add(this.Label14);
		this.XtraTabPage3.Controls.Add(this.Label18);
		this.XtraTabPage3.Controls.Add(this.UcTxtExpSocial);
		this.XtraTabPage3.Controls.Add(this.Label43);
		this.XtraTabPage3.Controls.Add(this.Label16);
		this.XtraTabPage3.Controls.Add(this.UcTxtBrevete);
		this.XtraTabPage3.Controls.Add(this.UcCBGrupoSanguineo);
		this.XtraTabPage3.Name = "XtraTabPage3";
		DevExpress.XtraTab.XtraTabPage xtraTabPage2 = this.XtraTabPage3;
		size = new System.Drawing.Size(546, 174);
		xtraTabPage2.Size = size;
		this.XtraTabPage3.Text = "Inf. Complementaria";
		this.UcCBDiscapacidad.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBDiscapacidad.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBDiscapacidad.FormattingEnabled = true;
		this.UcCBDiscapacidad.IncluirNinguno = false;
		this.UcCBDiscapacidad.ItemHeight = 13;
		GRLL.Common.ucComboBox ucCBDiscapacidad = this.UcCBDiscapacidad;
		location = new System.Drawing.Point(86, 22);
		ucCBDiscapacidad.Location = location;
		this.UcCBDiscapacidad.Name = "UcCBDiscapacidad";
		GRLL.Common.ucComboBox ucCBDiscapacidad2 = this.UcCBDiscapacidad;
		size = new System.Drawing.Size(119, 21);
		ucCBDiscapacidad2.Size = size;
		this.UcCBDiscapacidad.TabIndex = 10;
		this.Label14.AutoSize = true;
		System.Windows.Forms.Label label25 = this.Label14;
		location = new System.Drawing.Point(18, 53);
		label25.Location = location;
		this.Label14.Name = "Label14";
		System.Windows.Forms.Label label26 = this.Label14;
		size = new System.Drawing.Size(63, 13);
		label26.Size = size;
		this.Label14.TabIndex = 36;
		this.Label14.Text = "Exp. Social:";
		this.Label18.AutoSize = true;
		System.Windows.Forms.Label label27 = this.Label18;
		location = new System.Drawing.Point(34, 79);
		label27.Location = location;
		this.Label18.Name = "Label18";
		System.Windows.Forms.Label label28 = this.Label18;
		size = new System.Drawing.Size(47, 13);
		label28.Size = size;
		this.Label18.TabIndex = 48;
		this.Label18.Text = "Brevete:";
		this.UcTxtExpSocial.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtExpSocial.Formato = null;
		this.UcTxtExpSocial.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtExpSocial = this.UcTxtExpSocial;
		location = new System.Drawing.Point(86, 49);
		ucTxtExpSocial.Location = location;
		this.UcTxtExpSocial.Name = "UcTxtExpSocial";
		this.UcTxtExpSocial.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtExpSocial.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtExpSocial.OnErrorBlankText = "";
		this.UcTxtExpSocial.PadLeftLenght = 0;
		this.UcTxtExpSocial.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtExpSocial.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtExpSocial.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtExpSocial2 = this.UcTxtExpSocial;
		size = new System.Drawing.Size(182, 20);
		ucTxtExpSocial2.Size = size;
		this.UcTxtExpSocial.TabIndex = 12;
		this.UcTxtExpSocial.TabNextControl = false;
		this.UcTxtExpSocial.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.Label43.AutoSize = true;
		System.Windows.Forms.Label label29 = this.Label43;
		location = new System.Drawing.Point(6, 26);
		label29.Location = location;
		this.Label43.Name = "Label43";
		System.Windows.Forms.Label label30 = this.Label43;
		size = new System.Drawing.Size(75, 13);
		label30.Size = size;
		this.Label43.TabIndex = 42;
		this.Label43.Text = "Discapacidad:";
		this.Label16.AutoSize = true;
		System.Windows.Forms.Label label31 = this.Label16;
		location = new System.Drawing.Point(221, 26);
		label31.Location = location;
		this.Label16.Name = "Label16";
		System.Windows.Forms.Label label32 = this.Label16;
		size = new System.Drawing.Size(93, 13);
		label32.Size = size;
		this.Label16.TabIndex = 46;
		this.Label16.Text = "Grupo Sanguineo:";
		this.UcTxtBrevete.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtBrevete.Formato = null;
		this.UcTxtBrevete.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtBrevete = this.UcTxtBrevete;
		location = new System.Drawing.Point(86, 75);
		ucTxtBrevete.Location = location;
		this.UcTxtBrevete.Name = "UcTxtBrevete";
		this.UcTxtBrevete.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtBrevete.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtBrevete.OnErrorBlankText = "";
		this.UcTxtBrevete.PadLeftLenght = 0;
		this.UcTxtBrevete.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtBrevete.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtBrevete2 = this.UcTxtBrevete;
		size = new System.Drawing.Size(184, 20);
		ucTxtBrevete2.Size = size;
		this.UcTxtBrevete.TabIndex = 15;
		this.UcTxtBrevete.TabNextControl = false;
		this.UcTxtBrevete.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcCBGrupoSanguineo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBGrupoSanguineo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBGrupoSanguineo.FormattingEnabled = true;
		this.UcCBGrupoSanguineo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBGrupoSanguineo = this.UcCBGrupoSanguineo;
		location = new System.Drawing.Point(317, 22);
		ucCBGrupoSanguineo.Location = location;
		this.UcCBGrupoSanguineo.Name = "UcCBGrupoSanguineo";
		GRLL.Common.ucComboBox ucCBGrupoSanguineo2 = this.UcCBGrupoSanguineo;
		size = new System.Drawing.Size(51, 21);
		ucCBGrupoSanguineo2.Size = size;
		this.UcCBGrupoSanguineo.TabIndex = 9;
		this.XtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage1.Controls.Add(this.GroupBox1);
		this.XtraTabPage1.Name = "XtraTabPage1";
		DevExpress.XtraTab.XtraTabPage xtraTabPage3 = this.XtraTabPage1;
		size = new System.Drawing.Size(546, 174);
		xtraTabPage3.Size = size;
		this.XtraTabPage1.Text = "Lugar de Nac.";
		this.GroupBox1.Controls.Add(this.UcUbigeoCmb1);
		this.GroupBox1.Controls.Add(this.UcDTFechaNac);
		this.GroupBox1.Controls.Add(this.Label11);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
		location = new System.Drawing.Point(3, 3);
		groupBox.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
		size = new System.Drawing.Size(526, 105);
		groupBox2.Size = size;
		this.GroupBox1.TabIndex = 39;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Lugar de Nacimiento";
		this.UcUbigeoCmb1.BackColor = System.Drawing.Color.Transparent;
		this.UcUbigeoCmb1.Conexion = null;
		GRLL.Common.ucUbigeoCmb ucUbigeoCmb = this.UcUbigeoCmb1;
		location = new System.Drawing.Point(7, 19);
		ucUbigeoCmb.Location = location;
		this.UcUbigeoCmb1.Name = "UcUbigeoCmb1";
		GRLL.Common.ucUbigeoCmb ucUbigeoCmb2 = this.UcUbigeoCmb1;
		size = new System.Drawing.Size(304, 86);
		ucUbigeoCmb2.Size = size;
		this.UcUbigeoCmb1.TabIndex = 18;
		this.UcUbigeoCmb1.Ubigeo = "000000";
		this.UcDTFechaNac.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFechaNac.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFechaNac = this.UcDTFechaNac;
		location = new System.Drawing.Point(317, 44);
		ucDTFechaNac.Location = location;
		this.UcDTFechaNac.Name = "UcDTFechaNac";
		GRLL.Common.ucDateTime ucDTFechaNac2 = this.UcDTFechaNac;
		size = new System.Drawing.Size(197, 20);
		ucDTFechaNac2.Size = size;
		this.UcDTFechaNac.TabIndex = 19;
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label33 = this.Label11;
		location = new System.Drawing.Point(317, 28);
		label33.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label34 = this.Label11;
		size = new System.Drawing.Size(66, 13);
		label34.Size = size;
		this.Label11.TabIndex = 0;
		this.Label11.Text = "Fecha Nac.:";
		this.XtraTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage2.Controls.Add(this.GroupBox2);
		this.XtraTabPage2.Name = "XtraTabPage2";
		DevExpress.XtraTab.XtraTabPage xtraTabPage4 = this.XtraTabPage2;
		size = new System.Drawing.Size(546, 174);
		xtraTabPage4.Size = size;
		this.XtraTabPage2.Text = "Domicilio Actual";
		this.GroupBox2.Controls.Add(this.UcTxtDirec);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.UcCBNacionalidad);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label41);
		this.GroupBox2.Controls.Add(this.Label10);
		this.GroupBox2.Controls.Add(this.UcTxtMovil);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.UcTxtOtro);
		this.GroupBox2.Controls.Add(this.Label9);
		this.GroupBox2.Controls.Add(this.UcTxtCentroLab);
		this.GroupBox2.Controls.Add(this.UcTxtFono);
		this.GroupBox2.Controls.Add(this.UcTxteMail);
		this.GroupBox2.Controls.Add(this.Label42);
		this.GroupBox2.Controls.Add(this.UcUbigeoCmbDirec);
		System.Windows.Forms.GroupBox groupBox3 = this.GroupBox2;
		location = new System.Drawing.Point(3, 3);
		groupBox3.Location = location;
		this.GroupBox2.Name = "GroupBox2";
		System.Windows.Forms.GroupBox groupBox4 = this.GroupBox2;
		size = new System.Drawing.Size(528, 170);
		groupBox4.Size = size;
		this.GroupBox2.TabIndex = 44;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "Domicilio Actual";
		this.UcTxtDirec.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDirec.Formato = null;
		this.UcTxtDirec.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDirec = this.UcTxtDirec;
		location = new System.Drawing.Point(76, 19);
		ucTxtDirec.Location = location;
		this.UcTxtDirec.Name = "UcTxtDirec";
		this.UcTxtDirec.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDirec.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDirec.OnErrorBlankText = "";
		this.UcTxtDirec.PadLeftLenght = 0;
		this.UcTxtDirec.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtDirec.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDirec.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDirec2 = this.UcTxtDirec;
		size = new System.Drawing.Size(235, 20);
		ucTxtDirec2.Size = size;
		this.UcTxtDirec.TabIndex = 20;
		this.UcTxtDirec.TabNextControl = false;
		this.UcTxtDirec.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label35 = this.Label6;
		location = new System.Drawing.Point(20, 22);
		label35.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label36 = this.Label6;
		size = new System.Drawing.Size(55, 13);
		label36.Size = size;
		this.Label6.TabIndex = 0;
		this.Label6.Text = "Dirección:";
		this.UcCBNacionalidad.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBNacionalidad.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBNacionalidad.FormattingEnabled = true;
		this.UcCBNacionalidad.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBNacionalidad = this.UcCBNacionalidad;
		location = new System.Drawing.Point(391, 18);
		ucCBNacionalidad.Location = location;
		this.UcCBNacionalidad.Name = "UcCBNacionalidad";
		GRLL.Common.ucComboBox ucCBNacionalidad2 = this.UcCBNacionalidad;
		size = new System.Drawing.Size(119, 21);
		ucCBNacionalidad2.Size = size;
		this.UcCBNacionalidad.TabIndex = 21;
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label37 = this.Label7;
		location = new System.Drawing.Point(23, 46);
		label37.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label38 = this.Label7;
		size = new System.Drawing.Size(52, 13);
		label38.Size = size;
		this.Label7.TabIndex = 0;
		this.Label7.Text = "Teléfono:";
		this.Label41.AutoSize = true;
		System.Windows.Forms.Label label39 = this.Label41;
		location = new System.Drawing.Point(317, 22);
		label39.Location = location;
		this.Label41.Name = "Label41";
		System.Windows.Forms.Label label40 = this.Label41;
		size = new System.Drawing.Size(72, 13);
		label40.Size = size;
		this.Label41.TabIndex = 0;
		this.Label41.Text = "Nacionalidad:";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label41 = this.Label10;
		location = new System.Drawing.Point(179, 70);
		label41.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label42 = this.Label10;
		size = new System.Drawing.Size(38, 13);
		label42.Size = size;
		this.Label10.TabIndex = 0;
		this.Label10.Text = "e-Mail:";
		this.UcTxtMovil.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtMovil.Formato = null;
		this.UcTxtMovil.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtMovil = this.UcTxtMovil;
		location = new System.Drawing.Point(391, 43);
		ucTxtMovil.Location = location;
		this.UcTxtMovil.Name = "UcTxtMovil";
		this.UcTxtMovil.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtMovil.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtMovil.OnErrorBlankText = "";
		this.UcTxtMovil.PadLeftLenght = 0;
		this.UcTxtMovil.RegularExpression = "^[0-9]*$";
		this.UcTxtMovil.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtMovil.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtMovil2 = this.UcTxtMovil;
		size = new System.Drawing.Size(98, 20);
		ucTxtMovil2.Size = size;
		this.UcTxtMovil.TabIndex = 24;
		this.UcTxtMovil.TabNextControl = false;
		this.UcTxtMovil.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label43 = this.Label8;
		location = new System.Drawing.Point(350, 46);
		label43.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label44 = this.Label8;
		size = new System.Drawing.Size(35, 13);
		label44.Size = size;
		this.Label8.TabIndex = 0;
		this.Label8.Text = "Móvil:";
		this.UcTxtOtro.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtOtro.Formato = null;
		this.UcTxtOtro.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtOtro = this.UcTxtOtro;
		location = new System.Drawing.Point(76, 67);
		ucTxtOtro.Location = location;
		this.UcTxtOtro.Name = "UcTxtOtro";
		this.UcTxtOtro.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtOtro.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtOtro.OnErrorBlankText = "";
		this.UcTxtOtro.PadLeftLenght = 0;
		this.UcTxtOtro.RegularExpression = "^[0-9]*$";
		this.UcTxtOtro.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtOtro.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtOtro2 = this.UcTxtOtro;
		size = new System.Drawing.Size(98, 20);
		ucTxtOtro2.Size = size;
		this.UcTxtOtro.TabIndex = 25;
		this.UcTxtOtro.TabNextControl = false;
		this.UcTxtOtro.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label45 = this.Label9;
		location = new System.Drawing.Point(179, 46);
		label45.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label46 = this.Label9;
		size = new System.Drawing.Size(65, 13);
		label46.Size = size;
		this.Label9.TabIndex = 0;
		this.Label9.Text = "Centro Lab.:";
		this.UcTxtCentroLab.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCentroLab.Formato = null;
		this.UcTxtCentroLab.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCentroLab = this.UcTxtCentroLab;
		location = new System.Drawing.Point(250, 43);
		ucTxtCentroLab.Location = location;
		this.UcTxtCentroLab.Name = "UcTxtCentroLab";
		this.UcTxtCentroLab.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCentroLab.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCentroLab.OnErrorBlankText = "";
		this.UcTxtCentroLab.PadLeftLenght = 0;
		this.UcTxtCentroLab.RegularExpression = "^[0-9]*$";
		this.UcTxtCentroLab.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCentroLab.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCentroLab2 = this.UcTxtCentroLab;
		size = new System.Drawing.Size(98, 20);
		ucTxtCentroLab2.Size = size;
		this.UcTxtCentroLab.TabIndex = 23;
		this.UcTxtCentroLab.TabNextControl = false;
		this.UcTxtCentroLab.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtFono.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtFono.Formato = null;
		this.UcTxtFono.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtFono = this.UcTxtFono;
		location = new System.Drawing.Point(76, 43);
		ucTxtFono.Location = location;
		this.UcTxtFono.Name = "UcTxtFono";
		this.UcTxtFono.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtFono.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtFono.OnErrorBlankText = "";
		this.UcTxtFono.PadLeftLenght = 0;
		this.UcTxtFono.RegularExpression = "^[0-9]*$";
		this.UcTxtFono.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtFono.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtFono2 = this.UcTxtFono;
		size = new System.Drawing.Size(98, 20);
		ucTxtFono2.Size = size;
		this.UcTxtFono.TabIndex = 22;
		this.UcTxtFono.TabNextControl = false;
		this.UcTxtFono.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxteMail.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxteMail.Formato = null;
		this.UcTxteMail.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxteMail = this.UcTxteMail;
		location = new System.Drawing.Point(223, 67);
		ucTxteMail.Location = location;
		this.UcTxteMail.Name = "UcTxteMail";
		this.UcTxteMail.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxteMail.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxteMail.OnErrorBlankText = "";
		this.UcTxteMail.PadLeftLenght = 0;
		this.UcTxteMail.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxteMail.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxteMail2 = this.UcTxteMail;
		size = new System.Drawing.Size(300, 20);
		ucTxteMail2.Size = size;
		this.UcTxteMail.TabIndex = 26;
		this.UcTxteMail.TabNextControl = false;
		this.UcTxteMail.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label42.AutoSize = true;
		System.Windows.Forms.Label label47 = this.Label42;
		location = new System.Drawing.Point(40, 70);
		label47.Location = location;
		this.Label42.Name = "Label42";
		System.Windows.Forms.Label label48 = this.Label42;
		size = new System.Drawing.Size(30, 13);
		label48.Size = size;
		this.Label42.TabIndex = 0;
		this.Label42.Text = "Otro:";
		this.UcUbigeoCmbDirec.BackColor = System.Drawing.Color.Transparent;
		this.UcUbigeoCmbDirec.Conexion = null;
		GRLL.Common.ucUbigeoCmb ucUbigeoCmbDirec = this.UcUbigeoCmbDirec;
		location = new System.Drawing.Point(10, 86);
		ucUbigeoCmbDirec.Location = location;
		this.UcUbigeoCmbDirec.Name = "UcUbigeoCmbDirec";
		GRLL.Common.ucUbigeoCmb ucUbigeoCmbDirec2 = this.UcUbigeoCmbDirec;
		size = new System.Drawing.Size(304, 86);
		ucUbigeoCmbDirec2.Size = size;
		this.UcUbigeoCmbDirec.TabIndex = 27;
		this.UcUbigeoCmbDirec.Ubigeo = "000000";
		this.XtraTabControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.XtraTabControl2.Appearance.Options.UseBackColor = true;
		this.XtraTabControl2.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
		DevExpress.XtraTab.XtraTabControl xtraTabControl = this.XtraTabControl2;
		location = new System.Drawing.Point(12, 308);
		xtraTabControl.Location = location;
		this.XtraTabControl2.Name = "XtraTabControl2";
		this.XtraTabControl2.SelectedTabPage = this.XtraTabPage2;
		DevExpress.XtraTab.XtraTabControl xtraTabControl2 = this.XtraTabControl2;
		size = new System.Drawing.Size(555, 204);
		xtraTabControl2.Size = size;
		this.XtraTabControl2.TabIndex = 49;
		this.XtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[4] { this.XtraTabPage2, this.XtraTabPage1, this.XtraTabPage3, this.XtraTabPage4 });
		this.UcCBTipoTrab.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoTrab.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoTrab.FormattingEnabled = true;
		this.UcCBTipoTrab.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoTrab = this.UcCBTipoTrab;
		location = new System.Drawing.Point(139, 281);
		ucCBTipoTrab.Location = location;
		this.UcCBTipoTrab.Name = "UcCBTipoTrab";
		GRLL.Common.ucComboBox ucCBTipoTrab2 = this.UcCBTipoTrab;
		size = new System.Drawing.Size(121, 21);
		ucCBTipoTrab2.Size = size;
		this.UcCBTipoTrab.TabIndex = 53;
		this.Label28.AutoSize = true;
		System.Windows.Forms.Label label49 = this.Label28;
		location = new System.Drawing.Point(38, 284);
		label49.Location = location;
		this.Label28.Name = "Label28";
		System.Windows.Forms.Label label50 = this.Label28;
		size = new System.Drawing.Size(95, 13);
		label50.Size = size;
		this.Label28.TabIndex = 54;
		this.Label28.Text = "Condicion Laboral:";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(587, 587);
		this.ClientSize = size;
		this.Controls.Add(this.UcCBTipoTrab);
		this.Controls.Add(this.Label28);
		this.Controls.Add(this.Label17);
		this.Controls.Add(this.Label19);
		this.Controls.Add(this.btnGuardar);
		this.Controls.Add(this.XtraTabControl2);
		this.Controls.Add(this.UcCBArea);
		this.Controls.Add(this.UcCBEstadoCivil);
		this.Controls.Add(this.CheckEquipoMarcacion);
		this.Controls.Add(this.Label15);
		this.Controls.Add(this.UcDTFechaReg);
		this.Controls.Add(this.UcTxtNumRUc);
		this.Controls.Add(this.UcTxtLibMilitar);
		this.Controls.Add(this.UcTxtGradoInstruccion);
		this.Controls.Add(this.PopupContainerControl1);
		this.Controls.Add(this.Label12);
		this.Controls.Add(this.Label13);
		this.Controls.Add(this.Label44);
		this.Controls.Add(this.UcCBSexo);
		this.Controls.Add(this.Label24);
		this.Controls.Add(this.UcTxtApePater);
		this.Controls.Add(this.UcTxtNombres);
		this.Controls.Add(this.UcTxtApeMater);
		this.Controls.Add(this.UcFoto);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.Label4);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcComboBoxTDI);
		this.Controls.Add(this.UcTxtNDoc);
		this.Controls.Add(this.Label5);
		this.IsMdiContainer = true;
		this.Name = "FrmMantEmpleado_Basico";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Registro Datos Basicos del Empleado";
		this.VerCmdCerrar = true;
		this.VerPanelInf = false;
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.UcTxtNDoc, 0);
		this.Controls.SetChildIndex(this.UcComboBoxTDI, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.UcFoto, 0);
		this.Controls.SetChildIndex(this.UcTxtApeMater, 0);
		this.Controls.SetChildIndex(this.UcTxtNombres, 0);
		this.Controls.SetChildIndex(this.UcTxtApePater, 0);
		this.Controls.SetChildIndex(this.Label24, 0);
		this.Controls.SetChildIndex(this.UcCBSexo, 0);
		this.Controls.SetChildIndex(this.Label44, 0);
		this.Controls.SetChildIndex(this.Label13, 0);
		this.Controls.SetChildIndex(this.Label12, 0);
		this.Controls.SetChildIndex(this.PopupContainerControl1, 0);
		this.Controls.SetChildIndex(this.UcTxtGradoInstruccion, 0);
		this.Controls.SetChildIndex(this.UcTxtLibMilitar, 0);
		this.Controls.SetChildIndex(this.UcTxtNumRUc, 0);
		this.Controls.SetChildIndex(this.UcDTFechaReg, 0);
		this.Controls.SetChildIndex(this.Label15, 0);
		this.Controls.SetChildIndex(this.CheckEquipoMarcacion, 0);
		this.Controls.SetChildIndex(this.UcCBEstadoCivil, 0);
		this.Controls.SetChildIndex(this.UcCBArea, 0);
		this.Controls.SetChildIndex(this.XtraTabControl2, 0);
		this.Controls.SetChildIndex(this.btnGuardar, 0);
		this.Controls.SetChildIndex(this.Label19, 0);
		this.Controls.SetChildIndex(this.Label17, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label28, 0);
		this.Controls.SetChildIndex(this.UcCBTipoTrab, 0);
		((System.ComponentModel.ISupportInitialize)this.XtraTabbedMdiManager1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckEquipoMarcacion.Properties).EndInit();
		this.XtraTabPage4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControlEmpleado_Area).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemPopupContainerEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PopupContainerControl1).EndInit();
		this.PopupContainerControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControlListaAreas).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewListaAreas).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemButtonEdit1).EndInit();
		this.XtraTabPage3.ResumeLayout(false);
		this.XtraTabPage3.PerformLayout();
		this.XtraTabPage1.ResumeLayout(false);
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.XtraTabPage2.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.XtraTabControl2).EndInit();
		this.XtraTabControl2.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

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

	public void buscarxDNI()
	{
		DataTable dataTable = (DataTable)objFamiliaresClass.Busca_DNI(UcTxtNDoc.Text, Conversions.ToInteger(UcComboBoxTDI.SelectedValue));
		if (dataTable.Rows.Count == 1)
		{
			MessageBox.Show("Verifique el DNI, Ya existe ese Numero\r\nNombres: " + dataTable.Rows[0]["Apellido_Paterno"].ToString() + " " + dataTable.Rows[0]["Apellido_Materno"].ToString() + " " + dataTable.Rows[0]["Nombres"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void repositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
	{
		MessageBox.Show("You've clicked the button!", Application.ProductName);
	}

	private void UcTxtNDoc_LostFocus(object sender, EventArgs e)
	{
		buscarxDNI();
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void GridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
	{
		if (Operators.CompareString(e.Column.FieldName, "Year", TextCompare: false) != 0)
		{
			GridControlListaAreas.DataSource = objClassRRHH.llenar_Areas_by_año(Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Year"))));
		}
	}

	private void GridViewListaAreas_DoubleClick(object sender, EventArgs e)
	{
		objClassRRHH.Actualizar_Area_Empleado(objClassRRHH.CodigoEmpleado, Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridViewListaAreas.GetRowCellValue(GridViewListaAreas.FocusedRowHandle, "Year"))), Convert.ToInt32(RuntimeHelpers.GetObjectValue(GridViewListaAreas.GetRowCellValue(GridViewListaAreas.FocusedRowHandle, "idAreaOrganiz"))));
		PopupContainerControl1.OwnerEdit.ClosePopup();
		GridControlEmpleado_Area.DataSource = objClassRRHH.llenar_Empleado_Area(objClassRRHH.CodigoEmpleado);
	}
}
