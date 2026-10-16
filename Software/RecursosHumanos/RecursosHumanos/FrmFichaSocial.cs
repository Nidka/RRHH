using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.Data;
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
using GRLL.Common;
using GRLL.Common.Conversiones.Rutinas;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmFichaSocial : FrmConsulta
{
	[CompilerGenerated]
	internal class _Closure_0024__5
	{
		public int _0024VB_0024Local_codper;

		public int _0024VB_0024Local_docid;

		[DebuggerNonUserCode]
		public _Closure_0024__5()
		{
		}

		[DebuggerNonUserCode]
		public _Closure_0024__5(_Closure_0024__5 other)
		{
			if (other != null)
			{
				_0024VB_0024Local_docid = other._0024VB_0024Local_docid;
				_0024VB_0024Local_codper = other._0024VB_0024Local_codper;
			}
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

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

	[AccessedThroughProperty("UcTxtNDoc")]
	private ucTextBox _UcTxtNDoc;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("XtraTabControl1")]
	private XtraTabControl _XtraTabControl1;

	[AccessedThroughProperty("XtraTabPage1")]
	private XtraTabPage _XtraTabPage1;

	[AccessedThroughProperty("XtraTabPage2")]
	private XtraTabPage _XtraTabPage2;

	[AccessedThroughProperty("XtraTabPage3")]
	private XtraTabPage _XtraTabPage3;

	[AccessedThroughProperty("XtraTabPage4")]
	private XtraTabPage _XtraTabPage4;

	[AccessedThroughProperty("XtraTabPage5")]
	private XtraTabPage _XtraTabPage5;

	[AccessedThroughProperty("XtraTabPage6")]
	private XtraTabPage _XtraTabPage6;

	[AccessedThroughProperty("XtraTabPage7")]
	private XtraTabPage _XtraTabPage7;

	[AccessedThroughProperty("XtraTabPage8")]
	private XtraTabPage _XtraTabPage8;

	[AccessedThroughProperty("XtraTabPage9")]
	private XtraTabPage _XtraTabPage9;

	[AccessedThroughProperty("XtraTabPage10")]
	private XtraTabPage _XtraTabPage10;

	[AccessedThroughProperty("UcCBViveCon")]
	private ucComboBox _UcCBViveCon;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("RadioGroup1")]
	private RadioGroup _RadioGroup1;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("UcTxtNumHijos")]
	private ucTextBox _UcTxtNumHijos;

	[AccessedThroughProperty("UcTxtCargaFam")]
	private ucTextBox _UcTxtCargaFam;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("btnAgregar")]
	private Button _btnAgregar;

	[AccessedThroughProperty("btnEliminar")]
	private Button _btnEliminar;

	[AccessedThroughProperty("RepositoryItemRadioGroup1")]
	private RepositoryItemRadioGroup _RepositoryItemRadioGroup1;

	[AccessedThroughProperty("UcTxtObsFam")]
	private ucTextBox _UcTxtObsFam;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("UcCBExcretas")]
	private ucComboBox _UcCBExcretas;

	[AccessedThroughProperty("UcCBAgua")]
	private ucComboBox _UcCBAgua;

	[AccessedThroughProperty("UcCBAlumbrado")]
	private ucComboBox _UcCBAlumbrado;

	[AccessedThroughProperty("UcCBUbicacion")]
	private ucComboBox _UcCBUbicacion;

	[AccessedThroughProperty("UcCBConservacion")]
	private ucComboBox _UcCBConservacion;

	[AccessedThroughProperty("UcCBMaterial")]
	private ucComboBox _UcCBMaterial;

	[AccessedThroughProperty("UcCBTipo")]
	private ucComboBox _UcCBTipo;

	[AccessedThroughProperty("UcCBTenencia")]
	private ucComboBox _UcCBTenencia;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("UcTxtAspPsico")]
	private ucTextBox _UcTxtAspPsico;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("UcTxtAspSocial")]
	private ucTextBox _UcTxtAspSocial;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("UcTxtDiagSocial")]
	private ucTextBox _UcTxtDiagSocial;

	[AccessedThroughProperty("btnGuardar")]
	private Button _btnGuardar;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("UcTxtProfesion")]
	private ucTextBox _UcTxtProfesion;

	[AccessedThroughProperty("UcCBCargo")]
	private ucComboBox _UcCBCargo;

	[AccessedThroughProperty("UcCBTipoTrab")]
	private ucComboBox _UcCBTipoTrab;

	[AccessedThroughProperty("UcTxtTipoDocID")]
	private ucTextBox _UcTxtTipoDocID;

	[AccessedThroughProperty("UcTxtSexo")]
	private ucTextBox _UcTxtSexo;

	[AccessedThroughProperty("RepositoryItemCheckEdit1")]
	private RepositoryItemCheckEdit _RepositoryItemCheckEdit1;

	[AccessedThroughProperty("btnModificar")]
	private Button _btnModificar;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("GroupControl3")]
	private GroupControl _GroupControl3;

	[AccessedThroughProperty("GroupControl2")]
	private GroupControl _GroupControl2;

	[AccessedThroughProperty("GroupControl8")]
	private GroupControl _GroupControl8;

	[AccessedThroughProperty("GroupControl7")]
	private GroupControl _GroupControl7;

	[AccessedThroughProperty("GroupControl6")]
	private GroupControl _GroupControl6;

	[AccessedThroughProperty("GroupControl5")]
	private GroupControl _GroupControl5;

	[AccessedThroughProperty("GroupControl4")]
	private GroupControl _GroupControl4;

	[AccessedThroughProperty("UcTxtOtroAgua")]
	private ucTextBox _UcTxtOtroAgua;

	[AccessedThroughProperty("UcTxtOtroExcreta")]
	private ucTextBox _UcTxtOtroExcreta;

	[AccessedThroughProperty("GroupControl9")]
	private GroupControl _GroupControl9;

	[AccessedThroughProperty("UcTxtServHig")]
	private ucTextBox _UcTxtServHig;

	[AccessedThroughProperty("UcTxtNumDormito")]
	private ucTextBox _UcTxtNumDormito;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("UcTxtOtroAlumbrado")]
	private ucTextBox _UcTxtOtroAlumbrado;

	[AccessedThroughProperty("GroupControl10")]
	private GroupControl _GroupControl10;

	[AccessedThroughProperty("GroupControl11")]
	private GroupControl _GroupControl11;

	[AccessedThroughProperty("Label41")]
	private Label _Label41;

	[AccessedThroughProperty("Label40")]
	private Label _Label40;

	[AccessedThroughProperty("Label39")]
	private Label _Label39;

	[AccessedThroughProperty("Label38")]
	private Label _Label38;

	[AccessedThroughProperty("Label37")]
	private Label _Label37;

	[AccessedThroughProperty("Label36")]
	private Label _Label36;

	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[AccessedThroughProperty("UcTxtEgreOtro")]
	private ucTextBox _UcTxtEgreOtro;

	[AccessedThroughProperty("UcTxtEgreDeuda")]
	private ucTextBox _UcTxtEgreDeuda;

	[AccessedThroughProperty("UcTxtEgreRecrea")]
	private ucTextBox _UcTxtEgreRecrea;

	[AccessedThroughProperty("UcTxtEgreVestido")]
	private ucTextBox _UcTxtEgreVestido;

	[AccessedThroughProperty("UcTxtEgreEducac")]
	private ucTextBox _UcTxtEgreEducac;

	[AccessedThroughProperty("UcTxtEgreVivienda")]
	private ucTextBox _UcTxtEgreVivienda;

	[AccessedThroughProperty("UcTxtEgreSalud")]
	private ucTextBox _UcTxtEgreSalud;

	[AccessedThroughProperty("UcTxtEgreAliment")]
	private ucTextBox _UcTxtEgreAliment;

	[AccessedThroughProperty("Label34")]
	private Label _Label34;

	[AccessedThroughProperty("UcTxtIngreBienes")]
	private ucTextBox _UcTxtIngreBienes;

	[AccessedThroughProperty("UcTxtIngreMiembros")]
	private ucTextBox _UcTxtIngreMiembros;

	[AccessedThroughProperty("UcTxtIngreAdic")]
	private ucTextBox _UcTxtIngreAdic;

	[AccessedThroughProperty("UcTxtIngreRemune")]
	private ucTextBox _UcTxtIngreRemune;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("UcTxtNumPers")]
	private ucTextBox _UcTxtNumPers;

	[AccessedThroughProperty("UcTxtIngreMiembroszz")]
	private ucTextBox _UcTxtIngreMiembroszz;

	[AccessedThroughProperty("Label43")]
	private Label _Label43;

	[AccessedThroughProperty("Label42")]
	private Label _Label42;

	[AccessedThroughProperty("Label44")]
	private Label _Label44;

	[AccessedThroughProperty("UcCBAfp")]
	private ucComboBox _UcCBAfp;

	[AccessedThroughProperty("Label45")]
	private Label _Label45;

	[AccessedThroughProperty("UcTxtNroAfp")]
	private ucTextBox _UcTxtNroAfp;

	[AccessedThroughProperty("UcDTInscripAFP")]
	private ucDateTime _UcDTInscripAFP;

	[AccessedThroughProperty("Label48")]
	private Label _Label48;

	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[AccessedThroughProperty("UcCBRegimen")]
	private ucComboBox _UcCBRegimen;

	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[AccessedThroughProperty("UcTxtAutogenSalud")]
	private ucTextBox _UcTxtAutogenSalud;

	[AccessedThroughProperty("RepositoryItemCheckEdit2")]
	private RepositoryItemCheckEdit _RepositoryItemCheckEdit2;

	[AccessedThroughProperty("BtnModEst")]
	private Button _BtnModEst;

	[AccessedThroughProperty("BtnEliminarEst")]
	private Button _BtnEliminarEst;

	[AccessedThroughProperty("BtnAgregarEst")]
	private Button _BtnAgregarEst;

	[AccessedThroughProperty("GroupControl12")]
	private GroupControl _GroupControl12;

	[AccessedThroughProperty("GroupControl13")]
	private GroupControl _GroupControl13;

	[AccessedThroughProperty("BtnAgregarGrados")]
	private Button _BtnAgregarGrados;

	[AccessedThroughProperty("BtnEliminarGrados")]
	private Button _BtnEliminarGrados;

	[AccessedThroughProperty("GroupControl14")]
	private GroupControl _GroupControl14;

	[AccessedThroughProperty("BtnAgregarCap")]
	private Button _BtnAgregarCap;

	[AccessedThroughProperty("BtnEliminarCap")]
	private Button _BtnEliminarCap;

	[AccessedThroughProperty("GroupControl15")]
	private GroupControl _GroupControl15;

	[AccessedThroughProperty("BtnModExpLab")]
	private Button _BtnModExpLab;

	[AccessedThroughProperty("BtnAgregarExp")]
	private Button _BtnAgregarExp;

	[AccessedThroughProperty("BtnElimExpLab")]
	private Button _BtnElimExpLab;

	[AccessedThroughProperty("GroupControl16")]
	private GroupControl _GroupControl16;

	[AccessedThroughProperty("UcDTCese")]
	private ucDateTime _UcDTCese;

	[AccessedThroughProperty("UcTxtResolCese")]
	private ucTextBox _UcTxtResolCese;

	[AccessedThroughProperty("Label46")]
	private Label _Label46;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("UcTxtResol20530")]
	private ucTextBox _UcTxtResol20530;

	[AccessedThroughProperty("Label47")]
	private Label _Label47;

	[AccessedThroughProperty("UcDT20530")]
	private ucDateTime _UcDT20530;

	[AccessedThroughProperty("Label51")]
	private Label _Label51;

	[AccessedThroughProperty("Label52")]
	private Label _Label52;

	[AccessedThroughProperty("UcDTPension")]
	private ucDateTime _UcDTPension;

	[AccessedThroughProperty("UcTxtResolPensionista")]
	private ucTextBox _UcTxtResolPensionista;

	[AccessedThroughProperty("Label53")]
	private Label _Label53;

	[AccessedThroughProperty("GroupControl17")]
	private GroupControl _GroupControl17;

	[AccessedThroughProperty("GroupControl18")]
	private GroupControl _GroupControl18;

	[AccessedThroughProperty("Label54")]
	private Label _Label54;

	[AccessedThroughProperty("UcTxtResoIngreEst")]
	private ucTextBox _UcTxtResoIngreEst;

	[AccessedThroughProperty("Label55")]
	private Label _Label55;

	[AccessedThroughProperty("UcDTIngreEsta")]
	private ucDateTime _UcDTIngreEsta;

	[AccessedThroughProperty("UcCBTipoPersonal")]
	private ucComboBox _UcCBTipoPersonal;

	[AccessedThroughProperty("Label57")]
	private Label _Label57;

	[AccessedThroughProperty("UcDTFechaResolIngreEstado")]
	private ucDateTime _UcDTFechaResolIngreEstado;

	[AccessedThroughProperty("Label58")]
	private Label _Label58;

	[AccessedThroughProperty("XtraTabPage11")]
	private XtraTabPage _XtraTabPage11;

	[AccessedThroughProperty("GroupControl19")]
	private GroupControl _GroupControl19;

	[AccessedThroughProperty("BtnModDisci")]
	private Button _BtnModDisci;

	[AccessedThroughProperty("BtnAgregarDisci")]
	private Button _BtnAgregarDisci;

	[AccessedThroughProperty("BtnEliminarDisci")]
	private Button _BtnEliminarDisci;

	[AccessedThroughProperty("RadioGroup2")]
	private RadioGroup _RadioGroup2;

	[AccessedThroughProperty("UcTxtEnfCronica")]
	private ucTextBox _UcTxtEnfCronica;

	[AccessedThroughProperty("Label60")]
	private Label _Label60;

	[AccessedThroughProperty("UcTxtFamDiscap")]
	private ucTextBox _UcTxtFamDiscap;

	[AccessedThroughProperty("RadioGroup3")]
	private RadioGroup _RadioGroup3;

	[AccessedThroughProperty("Label62")]
	private Label _Label62;

	[AccessedThroughProperty("Label61")]
	private Label _Label61;

	[AccessedThroughProperty("UcCmbAcudeEnf")]
	private ucComboBox _UcCmbAcudeEnf;

	[AccessedThroughProperty("RadioGroup4")]
	private RadioGroup _RadioGroup4;

	[AccessedThroughProperty("Label64")]
	private Label _Label64;

	[AccessedThroughProperty("Label63")]
	private Label _Label63;

	[AccessedThroughProperty("UcTxtAlergico")]
	private ucTextBox _UcTxtAlergico;

	[AccessedThroughProperty("Label65")]
	private Label _Label65;

	[AccessedThroughProperty("UcTxtRec4")]
	private ucTextBox _UcTxtRec4;

	[AccessedThroughProperty("UcCmboRec3")]
	private ucComboBox _UcCmboRec3;

	[AccessedThroughProperty("UcCmboRec2")]
	private ucComboBox _UcCmboRec2;

	[AccessedThroughProperty("UcCmboRec1")]
	private ucComboBox _UcCmboRec1;

	[AccessedThroughProperty("Label68")]
	private Label _Label68;

	[AccessedThroughProperty("Label67")]
	private Label _Label67;

	[AccessedThroughProperty("Label66")]
	private Label _Label66;

	[AccessedThroughProperty("UcTxtRec7")]
	private ucTextBox _UcTxtRec7;

	[AccessedThroughProperty("UcTxtRec6")]
	private ucTextBox _UcTxtRec6;

	[AccessedThroughProperty("UcTxtRec5")]
	private ucTextBox _UcTxtRec5;

	[AccessedThroughProperty("Label71")]
	private Label _Label71;

	[AccessedThroughProperty("Label70")]
	private Label _Label70;

	[AccessedThroughProperty("Label69")]
	private Label _Label69;

	[AccessedThroughProperty("UcTxtTransporte")]
	private ucTextBox _UcTxtTransporte;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("UcTxtEnergElec")]
	private ucTextBox _UcTxtEnergElec;

	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[AccessedThroughProperty("Label32")]
	private Label _Label32;

	[AccessedThroughProperty("UcTxtEgreBajaPol")]
	private ucTextBox _UcTxtEgreBajaPol;

	[AccessedThroughProperty("UcTxtEgreAgua")]
	private ucTextBox _UcTxtEgreAgua;

	[AccessedThroughProperty("Label72")]
	private Label _Label72;

	[AccessedThroughProperty("UcTxtEgreFono")]
	private ucTextBox _UcTxtEgreFono;

	[AccessedThroughProperty("Label73")]
	private Label _Label73;

	[AccessedThroughProperty("UcTxtEgreSegPriv")]
	private ucTextBox _UcTxtEgreSegPriv;

	[AccessedThroughProperty("Label74")]
	private Label _Label74;

	[AccessedThroughProperty("UcTxtObsVivienda")]
	private ucTextBox _UcTxtObsVivienda;

	[AccessedThroughProperty("XtraTabPage12")]
	private XtraTabPage _XtraTabPage12;

	[AccessedThroughProperty("GroupControl20")]
	private GroupControl _GroupControl20;

	[AccessedThroughProperty("UcCmbRelHerm")]
	private ucComboBox _UcCmbRelHerm;

	[AccessedThroughProperty("UcCmbRelPH")]
	private ucComboBox _UcCmbRelPH;

	[AccessedThroughProperty("UcCmbRelPareja")]
	private ucComboBox _UcCmbRelPareja;

	[AccessedThroughProperty("UcCmbTipoFam")]
	private ucComboBox _UcCmbTipoFam;

	[AccessedThroughProperty("Label78")]
	private Label _Label78;

	[AccessedThroughProperty("Label77")]
	private Label _Label77;

	[AccessedThroughProperty("Label76")]
	private Label _Label76;

	[AccessedThroughProperty("Label75")]
	private Label _Label75;

	[AccessedThroughProperty("GroupControl21")]
	private GroupControl _GroupControl21;

	[AccessedThroughProperty("GroupControl25")]
	private GroupControl _GroupControl25;

	[AccessedThroughProperty("GroupControl24")]
	private GroupControl _GroupControl24;

	[AccessedThroughProperty("GroupControl23")]
	private GroupControl _GroupControl23;

	[AccessedThroughProperty("GroupControl22")]
	private GroupControl _GroupControl22;

	[AccessedThroughProperty("Label79")]
	private Label _Label79;

	[AccessedThroughProperty("UcCmbResp1")]
	private ucComboBox _UcCmbResp1;

	[AccessedThroughProperty("Label80")]
	private Label _Label80;

	[AccessedThroughProperty("Label85")]
	private Label _Label85;

	[AccessedThroughProperty("Label84")]
	private Label _Label84;

	[AccessedThroughProperty("UcCmbResp5")]
	private ucComboBox _UcCmbResp5;

	[AccessedThroughProperty("UcCmbResp7")]
	private ucComboBox _UcCmbResp7;

	[AccessedThroughProperty("UcCmbResp6")]
	private ucComboBox _UcCmbResp6;

	[AccessedThroughProperty("Label83")]
	private Label _Label83;

	[AccessedThroughProperty("Label82")]
	private Label _Label82;

	[AccessedThroughProperty("UcCmbResp3")]
	private ucComboBox _UcCmbResp3;

	[AccessedThroughProperty("Label81")]
	private Label _Label81;

	[AccessedThroughProperty("UcCmbResp4")]
	private ucComboBox _UcCmbResp4;

	[AccessedThroughProperty("UcCmbResp2")]
	private ucComboBox _UcCmbResp2;

	[AccessedThroughProperty("Label87")]
	private Label _Label87;

	[AccessedThroughProperty("UcCmbResp8")]
	private ucComboBox _UcCmbResp8;

	[AccessedThroughProperty("UcCmbResp9")]
	private ucComboBox _UcCmbResp9;

	[AccessedThroughProperty("Label86")]
	private Label _Label86;

	[AccessedThroughProperty("Label88")]
	private Label _Label88;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("ChckOtros")]
	private CheckEdit _ChckOtros;

	[AccessedThroughProperty("ChckCable")]
	private CheckEdit _ChckCable;

	[AccessedThroughProperty("ChckInter")]
	private CheckEdit _ChckInter;

	[AccessedThroughProperty("ChckFono")]
	private CheckEdit _ChckFono;

	[AccessedThroughProperty("GroupControl27")]
	private GroupControl _GroupControl27;

	[AccessedThroughProperty("UcTxtPerxDorm")]
	private ucTextBox _UcTxtPerxDorm;

	[AccessedThroughProperty("UcTxtNumCompart")]
	private ucTextBox _UcTxtNumCompart;

	[AccessedThroughProperty("Label90")]
	private Label _Label90;

	[AccessedThroughProperty("Label89")]
	private Label _Label89;

	[AccessedThroughProperty("GroupControl30")]
	private GroupControl _GroupControl30;

	[AccessedThroughProperty("GroupControl29")]
	private GroupControl _GroupControl29;

	[AccessedThroughProperty("GroupControl28")]
	private GroupControl _GroupControl28;

	[AccessedThroughProperty("GroupControl26")]
	private GroupControl _GroupControl26;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("GroupControl32")]
	private GroupControl _GroupControl32;

	[AccessedThroughProperty("GroupControl31")]
	private GroupControl _GroupControl31;

	[AccessedThroughProperty("GroupControl33")]
	private GroupControl _GroupControl33;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("dgvFamiliares")]
	private GridControl _dgvFamiliares;

	[AccessedThroughProperty("GridViewFam")]
	private GridView _GridViewFam;

	[AccessedThroughProperty("GridColumn1")]
	private GridColumn _GridColumn1;

	[AccessedThroughProperty("GridColumn2")]
	private GridColumn _GridColumn2;

	[AccessedThroughProperty("GridColumn3")]
	private GridColumn _GridColumn3;

	[AccessedThroughProperty("GridColumn4")]
	private GridColumn _GridColumn4;

	[AccessedThroughProperty("GridColumn5")]
	private GridColumn _GridColumn5;

	[AccessedThroughProperty("GridColumn6")]
	private GridColumn _GridColumn6;

	[AccessedThroughProperty("GridColumn7")]
	private GridColumn _GridColumn7;

	[AccessedThroughProperty("GridColumn8")]
	private GridColumn _GridColumn8;

	[AccessedThroughProperty("GridColumn9")]
	private GridColumn _GridColumn9;

	[AccessedThroughProperty("DGVEstudios")]
	private GridControl _DGVEstudios;

	[AccessedThroughProperty("GridViewEstudios")]
	private GridView _GridViewEstudios;

	[AccessedThroughProperty("DGVTitulos")]
	private GridControl _DGVTitulos;

	[AccessedThroughProperty("GridViewTitulos")]
	private GridView _GridViewTitulos;

	[AccessedThroughProperty("GridColumn10")]
	private GridColumn _GridColumn10;

	[AccessedThroughProperty("GridColumn11")]
	private GridColumn _GridColumn11;

	[AccessedThroughProperty("GridColumn12")]
	private GridColumn _GridColumn12;

	[AccessedThroughProperty("GridColumn13")]
	private GridColumn _GridColumn13;

	[AccessedThroughProperty("GridColumn14")]
	private GridColumn _GridColumn14;

	[AccessedThroughProperty("GridColumn15")]
	private GridColumn _GridColumn15;

	[AccessedThroughProperty("GridColumn16")]
	private GridColumn _GridColumn16;

	[AccessedThroughProperty("GridColumn17")]
	private GridColumn _GridColumn17;

	[AccessedThroughProperty("GridColumn18")]
	private GridColumn _GridColumn18;

	[AccessedThroughProperty("GridColumn19")]
	private GridColumn _GridColumn19;

	[AccessedThroughProperty("DGVCapacitacion")]
	private GridControl _DGVCapacitacion;

	[AccessedThroughProperty("GridViewCapacitacion")]
	private GridView _GridViewCapacitacion;

	[AccessedThroughProperty("GridColumn20")]
	private GridColumn _GridColumn20;

	[AccessedThroughProperty("GridColumn21")]
	private GridColumn _GridColumn21;

	[AccessedThroughProperty("GridColumn22")]
	private GridColumn _GridColumn22;

	[AccessedThroughProperty("GridColumn23")]
	private GridColumn _GridColumn23;

	[AccessedThroughProperty("GridColumn24")]
	private GridColumn _GridColumn24;

	[AccessedThroughProperty("GridColumn25")]
	private GridColumn _GridColumn25;

	[AccessedThroughProperty("DGVExpLab")]
	private GridControl _DGVExpLab;

	[AccessedThroughProperty("GridViewExpLab")]
	private GridView _GridViewExpLab;

	[AccessedThroughProperty("GridColumn26")]
	private GridColumn _GridColumn26;

	[AccessedThroughProperty("GridColumn27")]
	private GridColumn _GridColumn27;

	[AccessedThroughProperty("GridColumn28")]
	private GridColumn _GridColumn28;

	[AccessedThroughProperty("GridColumn31")]
	private GridColumn _GridColumn31;

	[AccessedThroughProperty("GridColumn29")]
	private GridColumn _GridColumn29;

	[AccessedThroughProperty("GridColumn30")]
	private GridColumn _GridColumn30;

	[AccessedThroughProperty("GridColumn32")]
	private GridColumn _GridColumn32;

	[AccessedThroughProperty("DGV_Disciplina")]
	private GridControl _DGV_Disciplina;

	[AccessedThroughProperty("GridViewDisciplina")]
	private GridView _GridViewDisciplina;

	[AccessedThroughProperty("GridColumn33")]
	private GridColumn _GridColumn33;

	[AccessedThroughProperty("GridColumn34")]
	private GridColumn _GridColumn34;

	[AccessedThroughProperty("GridColumn35")]
	private GridColumn _GridColumn35;

	[AccessedThroughProperty("GridColumn36")]
	private GridColumn _GridColumn36;

	[AccessedThroughProperty("GridColumn37")]
	private GridColumn _GridColumn37;

	[AccessedThroughProperty("GridColumn38")]
	private GridColumn _GridColumn38;

	[AccessedThroughProperty("GridColumn39")]
	private GridColumn _GridColumn39;

	[AccessedThroughProperty("DGVPerLab")]
	private GridControl _DGVPerLab;

	[AccessedThroughProperty("GridViewPerLab")]
	private GridView _GridViewPerLab;

	[AccessedThroughProperty("GridColumn40")]
	private GridColumn _GridColumn40;

	[AccessedThroughProperty("GridColumn41")]
	private GridColumn _GridColumn41;

	[AccessedThroughProperty("GridColumn42")]
	private GridColumn _GridColumn42;

	[AccessedThroughProperty("GridColumn43")]
	private GridColumn _GridColumn43;

	[AccessedThroughProperty("GridColumn44")]
	private GridColumn _GridColumn44;

	[AccessedThroughProperty("GridColumn45")]
	private GridColumn _GridColumn45;

	[AccessedThroughProperty("GridColumn46")]
	private GridColumn _GridColumn46;

	[AccessedThroughProperty("GridColumn47")]
	private GridColumn _GridColumn47;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GroupControl34")]
	private GroupControl _GroupControl34;

	[AccessedThroughProperty("XtraTabPage13")]
	private XtraTabPage _XtraTabPage13;

	[AccessedThroughProperty("GroupControl35")]
	private GroupControl _GroupControl35;

	[AccessedThroughProperty("GCAsegurado")]
	private GridControl _GCAsegurado;

	[AccessedThroughProperty("GVAsegurados")]
	private GridView _GVAsegurados;

	[AccessedThroughProperty("btnmodificarAsegurado")]
	private Button _btnmodificarAsegurado;

	[AccessedThroughProperty("btnAgregarAsegurado")]
	private Button _btnAgregarAsegurado;

	[AccessedThroughProperty("GridColumn48")]
	private GridColumn _GridColumn48;

	[AccessedThroughProperty("GridColumn49")]
	private GridColumn _GridColumn49;

	[AccessedThroughProperty("GridColumn50")]
	private GridColumn _GridColumn50;

	[AccessedThroughProperty("GridColumn52")]
	private GridColumn _GridColumn52;

	[AccessedThroughProperty("GridColumn51")]
	private GridColumn _GridColumn51;

	[AccessedThroughProperty("XtraTabPage14")]
	private XtraTabPage _XtraTabPage14;

	[AccessedThroughProperty("GroupControl36")]
	private GroupControl _GroupControl36;

	[AccessedThroughProperty("GroupControl37")]
	private GroupControl _GroupControl37;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[AccessedThroughProperty("Grid_Resoluciones")]
	private GridControl _Grid_Resoluciones;

	[AccessedThroughProperty("GridViewResoluciones")]
	private GridView _GridViewResoluciones;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Grid_Rotaciones")]
	private GridControl _Grid_Rotaciones;

	[AccessedThroughProperty("GridViewRotaciones")]
	private GridView _GridViewRotaciones;

	[AccessedThroughProperty("GridColumn53")]
	private GridColumn _GridColumn53;

	[AccessedThroughProperty("GridColumn54")]
	private GridColumn _GridColumn54;

	[AccessedThroughProperty("GridColumn55")]
	private GridColumn _GridColumn55;

	[AccessedThroughProperty("GridColumn56")]
	private GridColumn _GridColumn56;

	[AccessedThroughProperty("GridColumn57")]
	private GridColumn _GridColumn57;

	[AccessedThroughProperty("GridColumn58")]
	private GridColumn _GridColumn58;

	[AccessedThroughProperty("GridColumn59")]
	private GridColumn _GridColumn59;

	[AccessedThroughProperty("GridColumn60")]
	private GridColumn _GridColumn60;

	private FichaSocialClass objFichaSocialClass;

	public int CodEmple;

	private Empleado empleado;

	private Persona persona;

	private Egreso egreso;

	private Ingreso ingreso;

	private Vivienda vivienda;

	private RRHH_DinamicaFamiliar RRHH_dinamicafamiliar;

	private RRHH_FuncFam RRHH_FuncFam;

	private RRHH_AspSocio rrhh_aspSocio;

	private RRHH_Salud rrhh_salud;

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
			_UcTxtNDoc = value;
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

	internal XtraTabControl XtraTabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabControl1 = value;
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
			EventHandler value2 = XtraTabPage1_DoubleClick;
			if (_XtraTabPage1 != null)
			{
				_XtraTabPage1.DoubleClick -= value2;
			}
			_XtraTabPage1 = value;
			if (_XtraTabPage1 != null)
			{
				_XtraTabPage1.DoubleClick += value2;
			}
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

	internal XtraTabPage XtraTabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage5 = value;
		}
	}

	internal XtraTabPage XtraTabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage6 = value;
		}
	}

	internal XtraTabPage XtraTabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage7 = value;
		}
	}

	internal XtraTabPage XtraTabPage8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage8 = value;
		}
	}

	internal XtraTabPage XtraTabPage9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage9 = value;
		}
	}

	internal XtraTabPage XtraTabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage10 = value;
		}
	}

	internal ucComboBox UcCBViveCon
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBViveCon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBViveCon = value;
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

	internal ucTextBox UcTxtNumHijos
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumHijos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumHijos = value;
		}
	}

	internal ucTextBox UcTxtCargaFam
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtCargaFam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtCargaFam = value;
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

	internal Button btnAgregar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAgregar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAgregar_Click;
			if (_btnAgregar != null)
			{
				_btnAgregar.Click -= value2;
			}
			_btnAgregar = value;
			if (_btnAgregar != null)
			{
				_btnAgregar.Click += value2;
			}
		}
	}

	internal Button btnEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnEliminar_Click;
			if (_btnEliminar != null)
			{
				_btnEliminar.Click -= value2;
			}
			_btnEliminar = value;
			if (_btnEliminar != null)
			{
				_btnEliminar.Click += value2;
			}
		}
	}

	internal RepositoryItemRadioGroup RepositoryItemRadioGroup1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemRadioGroup1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemRadioGroup1 = value;
		}
	}

	internal ucTextBox UcTxtObsFam
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtObsFam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtObsFam = value;
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

	internal ucComboBox UcCBExcretas
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBExcretas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBExcretas_SelectedIndexChanged;
			if (_UcCBExcretas != null)
			{
				_UcCBExcretas.SelectedIndexChanged -= value2;
			}
			_UcCBExcretas = value;
			if (_UcCBExcretas != null)
			{
				_UcCBExcretas.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucComboBox UcCBAgua
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBAgua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBAgua_SelectedIndexChanged;
			if (_UcCBAgua != null)
			{
				_UcCBAgua.SelectedIndexChanged -= value2;
			}
			_UcCBAgua = value;
			if (_UcCBAgua != null)
			{
				_UcCBAgua.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucComboBox UcCBAlumbrado
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBAlumbrado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBAlumbrado_SelectedIndexChanged;
			if (_UcCBAlumbrado != null)
			{
				_UcCBAlumbrado.SelectedIndexChanged -= value2;
			}
			_UcCBAlumbrado = value;
			if (_UcCBAlumbrado != null)
			{
				_UcCBAlumbrado.SelectedIndexChanged += value2;
			}
		}
	}

	internal ucComboBox UcCBUbicacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBUbicacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBUbicacion = value;
		}
	}

	internal ucComboBox UcCBConservacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBConservacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBConservacion = value;
		}
	}

	internal ucComboBox UcCBMaterial
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBMaterial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBMaterial = value;
		}
	}

	internal ucComboBox UcCBTipo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTipo = value;
		}
	}

	internal ucComboBox UcCBTenencia
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTenencia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBTenencia = value;
		}
	}

	internal Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal ucTextBox UcTxtAspPsico
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAspPsico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAspPsico = value;
		}
	}

	internal Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	internal ucTextBox UcTxtAspSocial
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAspSocial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAspSocial = value;
		}
	}

	internal Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	internal ucTextBox UcTxtDiagSocial
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtDiagSocial;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtDiagSocial = value;
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

	internal Label Label31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label31 = value;
		}
	}

	internal Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label30 = value;
		}
	}

	internal ucTextBox UcTxtProfesion
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtProfesion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtProfesion = value;
		}
	}

	internal ucComboBox UcCBCargo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBCargo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBCargo = value;
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

	internal ucTextBox UcTxtTipoDocID
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtTipoDocID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtTipoDocID = value;
		}
	}

	internal ucTextBox UcTxtSexo
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtSexo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtSexo = value;
		}
	}

	internal RepositoryItemCheckEdit RepositoryItemCheckEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemCheckEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemCheckEdit1 = value;
		}
	}

	internal Button btnModificar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnModificar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnModificar_Click;
			if (_btnModificar != null)
			{
				_btnModificar.Click -= value2;
			}
			_btnModificar = value;
			if (_btnModificar != null)
			{
				_btnModificar.Click += value2;
			}
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

	internal GroupControl GroupControl8
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl8 = value;
		}
	}

	internal GroupControl GroupControl7
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl7 = value;
		}
	}

	internal GroupControl GroupControl6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl6 = value;
		}
	}

	internal GroupControl GroupControl5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl5 = value;
		}
	}

	internal GroupControl GroupControl4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl4 = value;
		}
	}

	internal ucTextBox UcTxtOtroAgua
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtOtroAgua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtOtroAgua = value;
		}
	}

	internal ucTextBox UcTxtOtroExcreta
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtOtroExcreta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtOtroExcreta = value;
		}
	}

	internal GroupControl GroupControl9
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl9 = value;
		}
	}

	internal ucTextBox UcTxtServHig
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtServHig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtServHig = value;
		}
	}

	internal ucTextBox UcTxtNumDormito
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumDormito;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumDormito = value;
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

	internal ucTextBox UcTxtOtroAlumbrado
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtOtroAlumbrado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtOtroAlumbrado = value;
		}
	}

	internal GroupControl GroupControl10
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl10 = value;
		}
	}

	internal GroupControl GroupControl11
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl11 = value;
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

	internal Label Label40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label40 = value;
		}
	}

	internal Label Label39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label39 = value;
		}
	}

	internal Label Label38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label38 = value;
		}
	}

	internal Label Label37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label37 = value;
		}
	}

	internal Label Label36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label36 = value;
		}
	}

	internal Label Label35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label35 = value;
		}
	}

	internal ucTextBox UcTxtEgreOtro
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreOtro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreOtro = value;
		}
	}

	internal ucTextBox UcTxtEgreDeuda
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreDeuda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreDeuda = value;
		}
	}

	internal ucTextBox UcTxtEgreRecrea
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreRecrea;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreRecrea = value;
		}
	}

	internal ucTextBox UcTxtEgreVestido
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreVestido;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreVestido = value;
		}
	}

	internal ucTextBox UcTxtEgreEducac
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreEducac;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreEducac = value;
		}
	}

	internal ucTextBox UcTxtEgreVivienda
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreVivienda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreVivienda = value;
		}
	}

	internal ucTextBox UcTxtEgreSalud
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreSalud;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreSalud = value;
		}
	}

	internal ucTextBox UcTxtEgreAliment
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreAliment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreAliment = value;
		}
	}

	internal Label Label34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label34 = value;
		}
	}

	internal ucTextBox UcTxtIngreBienes
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtIngreBienes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtIngreBienes = value;
		}
	}

	internal ucTextBox UcTxtIngreMiembros
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtIngreMiembros;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtIngreMiembros = value;
		}
	}

	internal ucTextBox UcTxtIngreAdic
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtIngreAdic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtIngreAdic = value;
		}
	}

	internal ucTextBox UcTxtIngreRemune
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtIngreRemune;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtIngreRemune = value;
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

	internal ucTextBox UcTxtNumPers
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumPers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumPers = value;
		}
	}

	internal ucTextBox UcTxtIngreMiembroszz
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtIngreMiembroszz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtIngreMiembroszz = value;
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

	internal ucComboBox UcCBAfp
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBAfp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCBAfp = value;
		}
	}

	internal Label Label45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label45 = value;
		}
	}

	internal ucTextBox UcTxtNroAfp
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNroAfp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNroAfp = value;
		}
	}

	internal ucDateTime UcDTInscripAFP
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTInscripAFP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTInscripAFP = value;
		}
	}

	internal Label Label48
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label48 = value;
		}
	}

	internal Label Label49
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label49 = value;
		}
	}

	internal ucComboBox UcCBRegimen
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBRegimen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBRegimen_SelectedIndexChanged;
			if (_UcCBRegimen != null)
			{
				_UcCBRegimen.SelectedIndexChanged -= value2;
			}
			_UcCBRegimen = value;
			if (_UcCBRegimen != null)
			{
				_UcCBRegimen.SelectedIndexChanged += value2;
			}
		}
	}

	internal Label Label50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label50 = value;
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

	internal RepositoryItemCheckEdit RepositoryItemCheckEdit2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemCheckEdit2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemCheckEdit2 = value;
		}
	}

	internal Button BtnModEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnModEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnModEst_Click;
			if (_BtnModEst != null)
			{
				_BtnModEst.Click -= value2;
			}
			_BtnModEst = value;
			if (_BtnModEst != null)
			{
				_BtnModEst.Click += value2;
			}
		}
	}

	internal Button BtnEliminarEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminarEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminarEst_Click;
			if (_BtnEliminarEst != null)
			{
				_BtnEliminarEst.Click -= value2;
			}
			_BtnEliminarEst = value;
			if (_BtnEliminarEst != null)
			{
				_BtnEliminarEst.Click += value2;
			}
		}
	}

	internal Button BtnAgregarEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregarEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button3_Click;
			if (_BtnAgregarEst != null)
			{
				_BtnAgregarEst.Click -= value2;
			}
			_BtnAgregarEst = value;
			if (_BtnAgregarEst != null)
			{
				_BtnAgregarEst.Click += value2;
			}
		}
	}

	internal GroupControl GroupControl12
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl12 = value;
		}
	}

	internal GroupControl GroupControl13
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl13 = value;
		}
	}

	internal Button BtnAgregarGrados
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregarGrados;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button2_Click;
			if (_BtnAgregarGrados != null)
			{
				_BtnAgregarGrados.Click -= value2;
			}
			_BtnAgregarGrados = value;
			if (_BtnAgregarGrados != null)
			{
				_BtnAgregarGrados.Click += value2;
			}
		}
	}

	internal Button BtnEliminarGrados
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminarGrados;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminarGrados_Click;
			if (_BtnEliminarGrados != null)
			{
				_BtnEliminarGrados.Click -= value2;
			}
			_BtnEliminarGrados = value;
			if (_BtnEliminarGrados != null)
			{
				_BtnEliminarGrados.Click += value2;
			}
		}
	}

	internal GroupControl GroupControl14
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl14 = value;
		}
	}

	internal Button BtnAgregarCap
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregarCap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button1_Click;
			if (_BtnAgregarCap != null)
			{
				_BtnAgregarCap.Click -= value2;
			}
			_BtnAgregarCap = value;
			if (_BtnAgregarCap != null)
			{
				_BtnAgregarCap.Click += value2;
			}
		}
	}

	internal Button BtnEliminarCap
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminarCap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminarCap_Click;
			if (_BtnEliminarCap != null)
			{
				_BtnEliminarCap.Click -= value2;
			}
			_BtnEliminarCap = value;
			if (_BtnEliminarCap != null)
			{
				_BtnEliminarCap.Click += value2;
			}
		}
	}

	internal GroupControl GroupControl15
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl15 = value;
		}
	}

	internal Button BtnModExpLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnModExpLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnModExpLab_Click;
			if (_BtnModExpLab != null)
			{
				_BtnModExpLab.Click -= value2;
			}
			_BtnModExpLab = value;
			if (_BtnModExpLab != null)
			{
				_BtnModExpLab.Click += value2;
			}
		}
	}

	internal Button BtnAgregarExp
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregarExp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnAgregarExp_Click;
			if (_BtnAgregarExp != null)
			{
				_BtnAgregarExp.Click -= value2;
			}
			_BtnAgregarExp = value;
			if (_BtnAgregarExp != null)
			{
				_BtnAgregarExp.Click += value2;
			}
		}
	}

	internal Button BtnElimExpLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnElimExpLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnElimExpLab_Click;
			if (_BtnElimExpLab != null)
			{
				_BtnElimExpLab.Click -= value2;
			}
			_BtnElimExpLab = value;
			if (_BtnElimExpLab != null)
			{
				_BtnElimExpLab.Click += value2;
			}
		}
	}

	internal GroupControl GroupControl16
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl16 = value;
		}
	}

	internal ucDateTime UcDTCese
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTCese;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTCese = value;
		}
	}

	internal ucTextBox UcTxtResolCese
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtResolCese;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtResolCese = value;
		}
	}

	internal Label Label46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label46 = value;
		}
	}

	internal Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal ucTextBox UcTxtResol20530
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtResol20530;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtResol20530 = value;
		}
	}

	internal Label Label47
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label47 = value;
		}
	}

	internal ucDateTime UcDT20530
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDT20530;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDT20530 = value;
		}
	}

	internal Label Label51
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label51 = value;
		}
	}

	internal Label Label52
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label52 = value;
		}
	}

	internal ucDateTime UcDTPension
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTPension;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTPension = value;
		}
	}

	internal ucTextBox UcTxtResolPensionista
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtResolPensionista;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtResolPensionista = value;
		}
	}

	internal Label Label53
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label53 = value;
		}
	}

	internal GroupControl GroupControl17
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl17 = value;
		}
	}

	internal GroupControl GroupControl18
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl18 = value;
		}
	}

	internal Label Label54
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label54 = value;
		}
	}

	internal ucTextBox UcTxtResoIngreEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtResoIngreEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtResoIngreEst = value;
		}
	}

	internal Label Label55
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label55 = value;
		}
	}

	internal ucDateTime UcDTIngreEsta
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTIngreEsta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTIngreEsta = value;
		}
	}

	internal ucComboBox UcCBTipoPersonal
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCBTipoPersonal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = UcCBTipoPersonal_SelectedIndexChanged;
			if (_UcCBTipoPersonal != null)
			{
				_UcCBTipoPersonal.SelectedIndexChanged -= value2;
			}
			_UcCBTipoPersonal = value;
			if (_UcCBTipoPersonal != null)
			{
				_UcCBTipoPersonal.SelectedIndexChanged += value2;
			}
		}
	}

	internal Label Label57
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label57 = value;
		}
	}

	internal ucDateTime UcDTFechaResolIngreEstado
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTFechaResolIngreEstado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTFechaResolIngreEstado = value;
		}
	}

	internal Label Label58
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label58 = value;
		}
	}

	internal XtraTabPage XtraTabPage11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage11 = value;
		}
	}

	internal GroupControl GroupControl19
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl19 = value;
		}
	}

	internal Button BtnModDisci
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnModDisci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnModDisci_Click;
			if (_BtnModDisci != null)
			{
				_BtnModDisci.Click -= value2;
			}
			_BtnModDisci = value;
			if (_BtnModDisci != null)
			{
				_BtnModDisci.Click += value2;
			}
		}
	}

	internal Button BtnAgregarDisci
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnAgregarDisci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnAgregarDisci_Click;
			if (_BtnAgregarDisci != null)
			{
				_BtnAgregarDisci.Click -= value2;
			}
			_BtnAgregarDisci = value;
			if (_BtnAgregarDisci != null)
			{
				_BtnAgregarDisci.Click += value2;
			}
		}
	}

	internal Button BtnEliminarDisci
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnEliminarDisci;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnEliminarDisci_Click;
			if (_BtnEliminarDisci != null)
			{
				_BtnEliminarDisci.Click -= value2;
			}
			_BtnEliminarDisci = value;
			if (_BtnEliminarDisci != null)
			{
				_BtnEliminarDisci.Click += value2;
			}
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
			EventHandler value2 = RadioGroup2_EditValueChanged;
			if (_RadioGroup2 != null)
			{
				_RadioGroup2.EditValueChanged -= value2;
			}
			_RadioGroup2 = value;
			if (_RadioGroup2 != null)
			{
				_RadioGroup2.EditValueChanged += value2;
			}
		}
	}

	internal ucTextBox UcTxtEnfCronica
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEnfCronica;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEnfCronica = value;
		}
	}

	internal Label Label60
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label60 = value;
		}
	}

	internal ucTextBox UcTxtFamDiscap
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtFamDiscap;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtFamDiscap = value;
		}
	}

	internal RadioGroup RadioGroup3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroup3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RadioGroup3_EditValueChanged;
			if (_RadioGroup3 != null)
			{
				_RadioGroup3.EditValueChanged -= value2;
			}
			_RadioGroup3 = value;
			if (_RadioGroup3 != null)
			{
				_RadioGroup3.EditValueChanged += value2;
			}
		}
	}

	internal Label Label62
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label62 = value;
		}
	}

	internal Label Label61
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label61 = value;
		}
	}

	internal ucComboBox UcCmbAcudeEnf
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbAcudeEnf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbAcudeEnf = value;
		}
	}

	internal RadioGroup RadioGroup4
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioGroup4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = RadioGroup4_EditValueChanged;
			if (_RadioGroup4 != null)
			{
				_RadioGroup4.EditValueChanged -= value2;
			}
			_RadioGroup4 = value;
			if (_RadioGroup4 != null)
			{
				_RadioGroup4.EditValueChanged += value2;
			}
		}
	}

	internal Label Label64
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label64 = value;
		}
	}

	internal Label Label63
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label63 = value;
		}
	}

	internal ucTextBox UcTxtAlergico
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtAlergico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtAlergico = value;
		}
	}

	internal Label Label65
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label65 = value;
		}
	}

	internal ucTextBox UcTxtRec4
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtRec4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtRec4 = value;
		}
	}

	internal ucComboBox UcCmboRec3
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmboRec3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmboRec3 = value;
		}
	}

	internal ucComboBox UcCmboRec2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmboRec2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmboRec2 = value;
		}
	}

	internal ucComboBox UcCmboRec1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmboRec1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmboRec1 = value;
		}
	}

	internal Label Label68
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label68 = value;
		}
	}

	internal Label Label67
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label67 = value;
		}
	}

	internal Label Label66
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label66 = value;
		}
	}

	internal ucTextBox UcTxtRec7
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtRec7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtRec7 = value;
		}
	}

	internal ucTextBox UcTxtRec6
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtRec6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtRec6 = value;
		}
	}

	internal ucTextBox UcTxtRec5
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtRec5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtRec5 = value;
		}
	}

	internal Label Label71
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label71 = value;
		}
	}

	internal Label Label70
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label70 = value;
		}
	}

	internal Label Label69
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label69 = value;
		}
	}

	internal ucTextBox UcTxtTransporte
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtTransporte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtTransporte = value;
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

	internal ucTextBox UcTxtEnergElec
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEnergElec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEnergElec = value;
		}
	}

	internal Label Label33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label33 = value;
		}
	}

	internal Label Label32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label32 = value;
		}
	}

	internal ucTextBox UcTxtEgreBajaPol
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreBajaPol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreBajaPol = value;
		}
	}

	internal ucTextBox UcTxtEgreAgua
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreAgua;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreAgua = value;
		}
	}

	internal Label Label72
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label72 = value;
		}
	}

	internal ucTextBox UcTxtEgreFono
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreFono;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreFono = value;
		}
	}

	internal Label Label73
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label73 = value;
		}
	}

	internal ucTextBox UcTxtEgreSegPriv
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtEgreSegPriv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtEgreSegPriv = value;
		}
	}

	internal Label Label74
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label74 = value;
		}
	}

	internal ucTextBox UcTxtObsVivienda
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtObsVivienda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtObsVivienda = value;
		}
	}

	internal XtraTabPage XtraTabPage12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage12 = value;
		}
	}

	internal GroupControl GroupControl20
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl20 = value;
		}
	}

	internal ucComboBox UcCmbRelHerm
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbRelHerm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbRelHerm = value;
		}
	}

	internal ucComboBox UcCmbRelPH
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbRelPH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbRelPH = value;
		}
	}

	internal ucComboBox UcCmbRelPareja
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbRelPareja;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbRelPareja = value;
		}
	}

	internal ucComboBox UcCmbTipoFam
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbTipoFam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbTipoFam = value;
		}
	}

	internal Label Label78
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label78 = value;
		}
	}

	internal Label Label77
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label77 = value;
		}
	}

	internal Label Label76
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label76 = value;
		}
	}

	internal Label Label75
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label75 = value;
		}
	}

	internal GroupControl GroupControl21
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl21 = value;
		}
	}

	internal GroupControl GroupControl25
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl25 = value;
		}
	}

	internal GroupControl GroupControl24
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl24 = value;
		}
	}

	internal GroupControl GroupControl23
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl23 = value;
		}
	}

	internal GroupControl GroupControl22
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl22 = value;
		}
	}

	internal Label Label79
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label79 = value;
		}
	}

	internal ucComboBox UcCmbResp1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp1 = value;
		}
	}

	internal Label Label80
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label80 = value;
		}
	}

	internal Label Label85
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label85 = value;
		}
	}

	internal Label Label84
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label84 = value;
		}
	}

	internal ucComboBox UcCmbResp5
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp5 = value;
		}
	}

	internal ucComboBox UcCmbResp7
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp7 = value;
		}
	}

	internal ucComboBox UcCmbResp6
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp6 = value;
		}
	}

	internal Label Label83
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label83 = value;
		}
	}

	internal Label Label82
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label82 = value;
		}
	}

	internal ucComboBox UcCmbResp3
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp3 = value;
		}
	}

	internal Label Label81
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label81 = value;
		}
	}

	internal ucComboBox UcCmbResp4
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp4 = value;
		}
	}

	internal ucComboBox UcCmbResp2
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp2 = value;
		}
	}

	internal Label Label87
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label87 = value;
		}
	}

	internal ucComboBox UcCmbResp8
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp8 = value;
		}
	}

	internal ucComboBox UcCmbResp9
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbResp9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbResp9 = value;
		}
	}

	internal Label Label86
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label86 = value;
		}
	}

	internal Label Label88
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label88 = value;
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

	internal CheckEdit ChckOtros
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckOtros;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChckOtros = value;
		}
	}

	internal CheckEdit ChckCable
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckCable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChckCable = value;
		}
	}

	internal CheckEdit ChckInter
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckInter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChckInter = value;
		}
	}

	internal CheckEdit ChckFono
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChckFono;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChckFono = value;
		}
	}

	internal GroupControl GroupControl27
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl27 = value;
		}
	}

	internal ucTextBox UcTxtPerxDorm
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtPerxDorm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtPerxDorm = value;
		}
	}

	internal ucTextBox UcTxtNumCompart
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtNumCompart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtNumCompart = value;
		}
	}

	internal Label Label90
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label90 = value;
		}
	}

	internal Label Label89
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label89 = value;
		}
	}

	internal GroupControl GroupControl30
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl30 = value;
		}
	}

	internal GroupControl GroupControl29
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl29 = value;
		}
	}

	internal GroupControl GroupControl28
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl28 = value;
		}
	}

	internal GroupControl GroupControl26
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl26 = value;
		}
	}

	internal Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal GroupControl GroupControl32
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl32 = value;
		}
	}

	internal GroupControl GroupControl31
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl31 = value;
		}
	}

	internal GroupControl GroupControl33
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl33 = value;
		}
	}

	internal Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button3_Click_1;
			if (_Button3 != null)
			{
				_Button3.Click -= value2;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				_Button3.Click += value2;
			}
		}
	}

	internal Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button4_Click;
			if (_Button4 != null)
			{
				_Button4.Click -= value2;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				_Button4.Click += value2;
			}
		}
	}

	internal Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button5_Click;
			if (_Button5 != null)
			{
				_Button5.Click -= value2;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				_Button5.Click += value2;
			}
		}
	}

	private GridControl dgvFamiliares
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgvFamiliares;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dgvFamiliares = value;
		}
	}

	private GridView GridViewFam
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewFam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewFam = value;
		}
	}

	private GridColumn GridColumn1
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

	private GridColumn GridColumn2
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

	private GridColumn GridColumn3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn3 = value;
		}
	}

	private GridColumn GridColumn4
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

	private GridColumn GridColumn5
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

	private GridColumn GridColumn6
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

	private GridColumn GridColumn7
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn7 = value;
		}
	}

	private GridColumn GridColumn8
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn8 = value;
		}
	}

	private GridColumn GridColumn9
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn9 = value;
		}
	}

	private GridControl DGVEstudios
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVEstudios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVEstudios = value;
		}
	}

	private GridView GridViewEstudios
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewEstudios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewEstudios = value;
		}
	}

	private GridControl DGVTitulos
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVTitulos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVTitulos = value;
		}
	}

	private GridView GridViewTitulos
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewTitulos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RowObjectEventHandler value2 = GridViewTitulos_RowUpdated;
			if (_GridViewTitulos != null)
			{
				_GridViewTitulos.RowUpdated -= value2;
			}
			_GridViewTitulos = value;
			if (_GridViewTitulos != null)
			{
				_GridViewTitulos.RowUpdated += value2;
			}
		}
	}

	private GridColumn GridColumn10
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn10 = value;
		}
	}

	private GridColumn GridColumn11
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn11 = value;
		}
	}

	private GridColumn GridColumn12
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn12 = value;
		}
	}

	private GridColumn GridColumn13
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn13 = value;
		}
	}

	private GridColumn GridColumn14
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn14 = value;
		}
	}

	private GridColumn GridColumn15
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn15 = value;
		}
	}

	private GridColumn GridColumn16
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn16 = value;
		}
	}

	private GridColumn GridColumn17
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn17 = value;
		}
	}

	private GridColumn GridColumn18
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn18 = value;
		}
	}

	private GridColumn GridColumn19
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn19 = value;
		}
	}

	private GridControl DGVCapacitacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVCapacitacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVCapacitacion = value;
		}
	}

	private GridView GridViewCapacitacion
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewCapacitacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RowObjectEventHandler value2 = GridViewCapacitacion_RowUpdated;
			if (_GridViewCapacitacion != null)
			{
				_GridViewCapacitacion.RowUpdated -= value2;
			}
			_GridViewCapacitacion = value;
			if (_GridViewCapacitacion != null)
			{
				_GridViewCapacitacion.RowUpdated += value2;
			}
		}
	}

	private GridColumn GridColumn20
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn20 = value;
		}
	}

	private GridColumn GridColumn21
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn21 = value;
		}
	}

	private GridColumn GridColumn22
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn22 = value;
		}
	}

	private GridColumn GridColumn23
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn23 = value;
		}
	}

	private GridColumn GridColumn24
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn24 = value;
		}
	}

	private GridColumn GridColumn25
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn25 = value;
		}
	}

	private GridControl DGVExpLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVExpLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVExpLab = value;
		}
	}

	private GridView GridViewExpLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewExpLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewExpLab = value;
		}
	}

	private GridColumn GridColumn26
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn26 = value;
		}
	}

	private GridColumn GridColumn27
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn27 = value;
		}
	}

	private GridColumn GridColumn28
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn28 = value;
		}
	}

	private GridColumn GridColumn31
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn31 = value;
		}
	}

	private GridColumn GridColumn29
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn29 = value;
		}
	}

	private GridColumn GridColumn30
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn30 = value;
		}
	}

	private GridColumn GridColumn32
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn32 = value;
		}
	}

	private GridControl DGV_Disciplina
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV_Disciplina;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGV_Disciplina = value;
		}
	}

	private GridView GridViewDisciplina
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewDisciplina;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewDisciplina = value;
		}
	}

	private GridColumn GridColumn33
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn33 = value;
		}
	}

	private GridColumn GridColumn34
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn34 = value;
		}
	}

	private GridColumn GridColumn35
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn35 = value;
		}
	}

	private GridColumn GridColumn36
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn36 = value;
		}
	}

	private GridColumn GridColumn37
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn37 = value;
		}
	}

	private GridColumn GridColumn38
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn38 = value;
		}
	}

	private GridColumn GridColumn39
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn39 = value;
		}
	}

	private GridControl DGVPerLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVPerLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVPerLab = value;
		}
	}

	private GridView GridViewPerLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewPerLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewPerLab = value;
		}
	}

	private GridColumn GridColumn40
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn40 = value;
		}
	}

	private GridColumn GridColumn41
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn41 = value;
		}
	}

	private GridColumn GridColumn42
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn42 = value;
		}
	}

	private GridColumn GridColumn43
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn43 = value;
		}
	}

	private GridColumn GridColumn44
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn44 = value;
		}
	}

	private GridColumn GridColumn45
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn45 = value;
		}
	}

	private GridColumn GridColumn46
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn46 = value;
		}
	}

	private GridColumn GridColumn47
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn47 = value;
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

	internal GroupControl GroupControl34
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl34 = value;
		}
	}

	internal XtraTabPage XtraTabPage13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage13 = value;
		}
	}

	internal GroupControl GroupControl35
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl35 = value;
		}
	}

	internal GridControl GCAsegurado
	{
		[DebuggerNonUserCode]
		get
		{
			return _GCAsegurado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GCAsegurado = value;
		}
	}

	internal GridView GVAsegurados
	{
		[DebuggerNonUserCode]
		get
		{
			return _GVAsegurados;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GVAsegurados = value;
		}
	}

	internal Button btnmodificarAsegurado
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnmodificarAsegurado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnmodificarAsegurado_Click;
			if (_btnmodificarAsegurado != null)
			{
				_btnmodificarAsegurado.Click -= value2;
			}
			_btnmodificarAsegurado = value;
			if (_btnmodificarAsegurado != null)
			{
				_btnmodificarAsegurado.Click += value2;
			}
		}
	}

	internal Button btnAgregarAsegurado
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnAgregarAsegurado;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btnAgregarAsegurado_Click;
			if (_btnAgregarAsegurado != null)
			{
				_btnAgregarAsegurado.Click -= value2;
			}
			_btnAgregarAsegurado = value;
			if (_btnAgregarAsegurado != null)
			{
				_btnAgregarAsegurado.Click += value2;
			}
		}
	}

	internal GridColumn GridColumn48
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn48 = value;
		}
	}

	internal GridColumn GridColumn49
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn49 = value;
		}
	}

	internal GridColumn GridColumn50
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn50 = value;
		}
	}

	internal GridColumn GridColumn52
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn52 = value;
		}
	}

	internal GridColumn GridColumn51
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn51 = value;
		}
	}

	internal XtraTabPage XtraTabPage14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XtraTabPage14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XtraTabPage14 = value;
		}
	}

	internal GroupControl GroupControl36
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl36 = value;
		}
	}

	internal GroupControl GroupControl37
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl37 = value;
		}
	}

	internal Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button9_Click;
			if (_Button9 != null)
			{
				_Button9.Click -= value2;
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				_Button9.Click += value2;
			}
		}
	}

	internal Button Button10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button10_Click;
			if (_Button10 != null)
			{
				_Button10.Click -= value2;
			}
			_Button10 = value;
			if (_Button10 != null)
			{
				_Button10.Click += value2;
			}
		}
	}

	internal Button Button11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button11 = value;
		}
	}

	internal GridControl Grid_Resoluciones
	{
		[DebuggerNonUserCode]
		get
		{
			return _Grid_Resoluciones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Grid_Resoluciones = value;
		}
	}

	internal GridView GridViewResoluciones
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewResoluciones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewResoluciones = value;
		}
	}

	internal Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button6_Click;
			if (_Button6 != null)
			{
				_Button6.Click -= value2;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				_Button6.Click += value2;
			}
		}
	}

	internal Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button7_Click;
			if (_Button7 != null)
			{
				_Button7.Click -= value2;
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				_Button7.Click += value2;
			}
		}
	}

	internal Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Button8_Click;
			if (_Button8 != null)
			{
				_Button8.Click -= value2;
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				_Button8.Click += value2;
			}
		}
	}

	internal GridControl Grid_Rotaciones
	{
		[DebuggerNonUserCode]
		get
		{
			return _Grid_Rotaciones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Grid_Rotaciones = value;
		}
	}

	internal GridView GridViewRotaciones
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridViewRotaciones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridViewRotaciones = value;
		}
	}

	internal GridColumn GridColumn53
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn53 = value;
		}
	}

	internal GridColumn GridColumn54
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn54 = value;
		}
	}

	internal GridColumn GridColumn55
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn55 = value;
		}
	}

	internal GridColumn GridColumn56
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn56 = value;
		}
	}

	internal GridColumn GridColumn57
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn57 = value;
		}
	}

	internal GridColumn GridColumn58
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn58 = value;
		}
	}

	internal GridColumn GridColumn59
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn59 = value;
		}
	}

	internal GridColumn GridColumn60
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridColumn60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridColumn60 = value;
		}
	}

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmFichaSocial));
		this.Label24 = new System.Windows.Forms.Label();
		this.UcTxtApePater = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNombres = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtApeMater = new GRLL.Common.ucTextBox(this.components);
		this.UcFoto = new GRLL.Common.ucFoto();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcTxtNDoc = new GRLL.Common.ucTextBox(this.components);
		this.Label5 = new System.Windows.Forms.Label();
		this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
		this.XtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl33 = new DevExpress.XtraEditors.GroupControl();
		this.DGVPerLab = new DevExpress.XtraGrid.GridControl();
		this.GridViewPerLab = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.UcCBTipoPersonal = new GRLL.Common.ucComboBox();
		this.Label57 = new System.Windows.Forms.Label();
		this.GroupControl18 = new DevExpress.XtraEditors.GroupControl();
		this.GroupControl32 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBRegimen = new GRLL.Common.ucComboBox();
		this.Label49 = new System.Windows.Forms.Label();
		this.UcCBAfp = new GRLL.Common.ucComboBox();
		this.Label44 = new System.Windows.Forms.Label();
		this.UcDTInscripAFP = new GRLL.Common.ucDateTime();
		this.Label48 = new System.Windows.Forms.Label();
		this.UcTxtNroAfp = new GRLL.Common.ucTextBox(this.components);
		this.Label45 = new System.Windows.Forms.Label();
		this.GroupControl31 = new DevExpress.XtraEditors.GroupControl();
		this.Label54 = new System.Windows.Forms.Label();
		this.UcTxtResoIngreEst = new GRLL.Common.ucTextBox(this.components);
		this.Label58 = new System.Windows.Forms.Label();
		this.Label55 = new System.Windows.Forms.Label();
		this.UcDTFechaResolIngreEstado = new GRLL.Common.ucDateTime();
		this.UcDTIngreEsta = new GRLL.Common.ucDateTime();
		this.Label31 = new System.Windows.Forms.Label();
		this.UcCBTipoTrab = new GRLL.Common.ucComboBox();
		this.Label50 = new System.Windows.Forms.Label();
		this.UcCBCargo = new GRLL.Common.ucComboBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.UcTxtProfesion = new GRLL.Common.ucTextBox(this.components);
		this.Label28 = new System.Windows.Forms.Label();
		this.UcTxtAutogenSalud = new GRLL.Common.ucTextBox(this.components);
		this.GroupControl16 = new DevExpress.XtraEditors.GroupControl();
		this.UcDTPension = new GRLL.Common.ucDateTime();
		this.UcDT20530 = new GRLL.Common.ucDateTime();
		this.UcDTCese = new GRLL.Common.ucDateTime();
		this.UcTxtResolPensionista = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtResol20530 = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtResolCese = new GRLL.Common.ucTextBox(this.components);
		this.Label53 = new System.Windows.Forms.Label();
		this.Label51 = new System.Windows.Forms.Label();
		this.Label46 = new System.Windows.Forms.Label();
		this.Label52 = new System.Windows.Forms.Label();
		this.Label47 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.GroupControl15 = new DevExpress.XtraEditors.GroupControl();
		this.BtnModExpLab = new System.Windows.Forms.Button();
		this.BtnAgregarExp = new System.Windows.Forms.Button();
		this.BtnElimExpLab = new System.Windows.Forms.Button();
		this.DGVExpLab = new DevExpress.XtraGrid.GridControl();
		this.GridViewExpLab = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.XtraTabPage13 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl35 = new DevExpress.XtraEditors.GroupControl();
		this.GCAsegurado = new DevExpress.XtraGrid.GridControl();
		this.GVAsegurados = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn52 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.btnmodificarAsegurado = new System.Windows.Forms.Button();
		this.btnAgregarAsegurado = new System.Windows.Forms.Button();
		this.XtraTabPage14 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl37 = new DevExpress.XtraEditors.GroupControl();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Grid_Resoluciones = new DevExpress.XtraGrid.GridControl();
		this.GridViewResoluciones = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GroupControl36 = new DevExpress.XtraEditors.GroupControl();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Grid_Rotaciones = new DevExpress.XtraGrid.GridControl();
		this.GridViewRotaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.XtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl14 = new DevExpress.XtraEditors.GroupControl();
		this.Button2 = new System.Windows.Forms.Button();
		this.DGVCapacitacion = new DevExpress.XtraGrid.GridControl();
		this.GridViewCapacitacion = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnAgregarCap = new System.Windows.Forms.Button();
		this.BtnEliminarCap = new System.Windows.Forms.Button();
		this.GroupControl13 = new DevExpress.XtraEditors.GroupControl();
		this.Button1 = new System.Windows.Forms.Button();
		this.DGVTitulos = new DevExpress.XtraGrid.GridControl();
		this.GridViewTitulos = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnAgregarGrados = new System.Windows.Forms.Button();
		this.BtnEliminarGrados = new System.Windows.Forms.Button();
		this.GroupControl12 = new DevExpress.XtraEditors.GroupControl();
		this.DGVEstudios = new DevExpress.XtraGrid.GridControl();
		this.GridViewEstudios = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.BtnModEst = new System.Windows.Forms.Button();
		this.BtnAgregarEst = new System.Windows.Forms.Button();
		this.BtnEliminarEst = new System.Windows.Forms.Button();
		this.XtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl17 = new DevExpress.XtraEditors.GroupControl();
		this.dgvFamiliares = new DevExpress.XtraGrid.GridControl();
		this.GridViewFam = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
		this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.RepositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
		this.RepositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
		this.btnEliminar = new System.Windows.Forms.Button();
		this.btnModificar = new System.Windows.Forms.Button();
		this.btnAgregar = new System.Windows.Forms.Button();
		this.RadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
		this.UcCBViveCon = new GRLL.Common.ucComboBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.UcTxtNumHijos = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtObsFam = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtCargaFam = new GRLL.Common.ucTextBox(this.components);
		this.Label11 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.XtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl21 = new DevExpress.XtraEditors.GroupControl();
		this.GroupControl24 = new DevExpress.XtraEditors.GroupControl();
		this.Label87 = new System.Windows.Forms.Label();
		this.UcCmbResp8 = new GRLL.Common.ucComboBox();
		this.UcCmbResp9 = new GRLL.Common.ucComboBox();
		this.Label88 = new System.Windows.Forms.Label();
		this.Label86 = new System.Windows.Forms.Label();
		this.GroupControl25 = new DevExpress.XtraEditors.GroupControl();
		this.Label85 = new System.Windows.Forms.Label();
		this.Label84 = new System.Windows.Forms.Label();
		this.UcCmbResp5 = new GRLL.Common.ucComboBox();
		this.UcCmbResp7 = new GRLL.Common.ucComboBox();
		this.UcCmbResp6 = new GRLL.Common.ucComboBox();
		this.Label83 = new System.Windows.Forms.Label();
		this.GroupControl23 = new DevExpress.XtraEditors.GroupControl();
		this.Label82 = new System.Windows.Forms.Label();
		this.UcCmbResp3 = new GRLL.Common.ucComboBox();
		this.Label81 = new System.Windows.Forms.Label();
		this.UcCmbResp4 = new GRLL.Common.ucComboBox();
		this.GroupControl22 = new DevExpress.XtraEditors.GroupControl();
		this.Label80 = new System.Windows.Forms.Label();
		this.Label79 = new System.Windows.Forms.Label();
		this.UcCmbResp2 = new GRLL.Common.ucComboBox();
		this.UcCmbResp1 = new GRLL.Common.ucComboBox();
		this.GroupControl20 = new DevExpress.XtraEditors.GroupControl();
		this.UcCmbRelHerm = new GRLL.Common.ucComboBox();
		this.UcCmbRelPH = new GRLL.Common.ucComboBox();
		this.UcCmbRelPareja = new GRLL.Common.ucComboBox();
		this.UcCmbTipoFam = new GRLL.Common.ucComboBox();
		this.Label78 = new System.Windows.Forms.Label();
		this.Label77 = new System.Windows.Forms.Label();
		this.Label76 = new System.Windows.Forms.Label();
		this.Label75 = new System.Windows.Forms.Label();
		this.XtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.GroupControl27 = new DevExpress.XtraEditors.GroupControl();
		this.ChckFono = new DevExpress.XtraEditors.CheckEdit();
		this.ChckOtros = new DevExpress.XtraEditors.CheckEdit();
		this.ChckCable = new DevExpress.XtraEditors.CheckEdit();
		this.ChckInter = new DevExpress.XtraEditors.CheckEdit();
		this.GroupControl6 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtOtroAlumbrado = new GRLL.Common.ucTextBox(this.components);
		this.UcCBAlumbrado = new GRLL.Common.ucComboBox();
		this.GroupControl7 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtOtroAgua = new GRLL.Common.ucTextBox(this.components);
		this.UcCBAgua = new GRLL.Common.ucComboBox();
		this.GroupControl8 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtOtroExcreta = new GRLL.Common.ucTextBox(this.components);
		this.UcCBExcretas = new GRLL.Common.ucComboBox();
		this.Label74 = new System.Windows.Forms.Label();
		this.GroupControl9 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtPerxDorm = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtServHig = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNumCompart = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtNumDormito = new GRLL.Common.ucTextBox(this.components);
		this.Label90 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label89 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.UcTxtObsVivienda = new GRLL.Common.ucTextBox(this.components);
		this.GroupControl5 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBUbicacion = new GRLL.Common.ucComboBox();
		this.GroupControl4 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBConservacion = new GRLL.Common.ucComboBox();
		this.GroupControl3 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBMaterial = new GRLL.Common.ucComboBox();
		this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBTipo = new GRLL.Common.ucComboBox();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.UcCBTenencia = new GRLL.Common.ucComboBox();
		this.XtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl30 = new DevExpress.XtraEditors.GroupControl();
		this.UcCmbAcudeEnf = new GRLL.Common.ucComboBox();
		this.Label63 = new System.Windows.Forms.Label();
		this.GroupControl29 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtAlergico = new GRLL.Common.ucTextBox(this.components);
		this.Label64 = new System.Windows.Forms.Label();
		this.Label65 = new System.Windows.Forms.Label();
		this.RadioGroup4 = new DevExpress.XtraEditors.RadioGroup();
		this.GroupControl28 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtFamDiscap = new GRLL.Common.ucTextBox(this.components);
		this.Label62 = new System.Windows.Forms.Label();
		this.RadioGroup3 = new DevExpress.XtraEditors.RadioGroup();
		this.Label61 = new System.Windows.Forms.Label();
		this.GroupControl26 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtEnfCronica = new GRLL.Common.ucTextBox(this.components);
		this.Label21 = new System.Windows.Forms.Label();
		this.Label60 = new System.Windows.Forms.Label();
		this.RadioGroup2 = new DevExpress.XtraEditors.RadioGroup();
		this.XtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
		this.UcTxtNumPers = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtIngreMiembroszz = new GRLL.Common.ucTextBox(this.components);
		this.GroupControl11 = new DevExpress.XtraEditors.GroupControl();
		this.Label41 = new System.Windows.Forms.Label();
		this.Label73 = new System.Windows.Forms.Label();
		this.Label40 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label37 = new System.Windows.Forms.Label();
		this.Label72 = new System.Windows.Forms.Label();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label32 = new System.Windows.Forms.Label();
		this.UcTxtEgreSalud = new GRLL.Common.ucTextBox(this.components);
		this.Label39 = new System.Windows.Forms.Label();
		this.Label38 = new System.Windows.Forms.Label();
		this.Label36 = new System.Windows.Forms.Label();
		this.Label35 = new System.Windows.Forms.Label();
		this.UcTxtEgreOtro = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtTransporte = new GRLL.Common.ucTextBox(this.components);
		this.Label19 = new System.Windows.Forms.Label();
		this.UcTxtEgreAliment = new GRLL.Common.ucTextBox(this.components);
		this.Label34 = new System.Windows.Forms.Label();
		this.UcTxtEgreSegPriv = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreDeuda = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEnergElec = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreFono = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreBajaPol = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreAgua = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreRecrea = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreVestido = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreEducac = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtEgreVivienda = new GRLL.Common.ucTextBox(this.components);
		this.GroupControl10 = new DevExpress.XtraEditors.GroupControl();
		this.UcTxtIngreBienes = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtIngreMiembros = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtIngreAdic = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtIngreRemune = new GRLL.Common.ucTextBox(this.components);
		this.Label18 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label43 = new System.Windows.Forms.Label();
		this.Label42 = new System.Windows.Forms.Label();
		this.XtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
		this.GroupControl19 = new DevExpress.XtraEditors.GroupControl();
		this.BtnModDisci = new System.Windows.Forms.Button();
		this.BtnAgregarDisci = new System.Windows.Forms.Button();
		this.BtnEliminarDisci = new System.Windows.Forms.Button();
		this.DGV_Disciplina = new DevExpress.XtraGrid.GridControl();
		this.GridViewDisciplina = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.XtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
		this.UcTxtRec7 = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtRec6 = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtRec5 = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtRec4 = new GRLL.Common.ucTextBox(this.components);
		this.UcCmboRec3 = new GRLL.Common.ucComboBox();
		this.UcCmboRec2 = new GRLL.Common.ucComboBox();
		this.UcCmboRec1 = new GRLL.Common.ucComboBox();
		this.Label71 = new System.Windows.Forms.Label();
		this.Label70 = new System.Windows.Forms.Label();
		this.Label69 = new System.Windows.Forms.Label();
		this.Label68 = new System.Windows.Forms.Label();
		this.Label67 = new System.Windows.Forms.Label();
		this.Label66 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.XtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
		this.Label25 = new System.Windows.Forms.Label();
		this.UcTxtAspPsico = new GRLL.Common.ucTextBox(this.components);
		this.XtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
		this.Label26 = new System.Windows.Forms.Label();
		this.UcTxtAspSocial = new GRLL.Common.ucTextBox(this.components);
		this.XtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
		this.Label27 = new System.Windows.Forms.Label();
		this.UcTxtDiagSocial = new GRLL.Common.ucTextBox(this.components);
		this.btnGuardar = new System.Windows.Forms.Button();
		this.UcTxtTipoDocID = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtSexo = new GRLL.Common.ucTextBox(this.components);
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GroupControl34 = new DevExpress.XtraEditors.GroupControl();
		this.GridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
		((System.ComponentModel.ISupportInitialize)this.XtraTabControl1).BeginInit();
		this.XtraTabControl1.SuspendLayout();
		this.XtraTabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl33).BeginInit();
		this.GroupControl33.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVPerLab).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewPerLab).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl18).BeginInit();
		this.GroupControl18.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl32).BeginInit();
		this.GroupControl32.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl31).BeginInit();
		this.GroupControl31.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl16).BeginInit();
		this.GroupControl16.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl15).BeginInit();
		this.GroupControl15.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVExpLab).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewExpLab).BeginInit();
		this.XtraTabPage13.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl35).BeginInit();
		this.GroupControl35.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GCAsegurado).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GVAsegurados).BeginInit();
		this.XtraTabPage14.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl37).BeginInit();
		this.GroupControl37.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Grid_Resoluciones).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewResoluciones).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl36).BeginInit();
		this.GroupControl36.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Grid_Rotaciones).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewRotaciones).BeginInit();
		this.XtraTabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl14).BeginInit();
		this.GroupControl14.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVCapacitacion).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewCapacitacion).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl13).BeginInit();
		this.GroupControl13.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVTitulos).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewTitulos).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl12).BeginInit();
		this.GroupControl12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVEstudios).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewEstudios).BeginInit();
		this.XtraTabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl17).BeginInit();
		this.GroupControl17.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvFamiliares).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewFam).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckEdit2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemRadioGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).BeginInit();
		this.XtraTabPage12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl21).BeginInit();
		this.GroupControl21.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl24).BeginInit();
		this.GroupControl24.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl25).BeginInit();
		this.GroupControl25.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl23).BeginInit();
		this.GroupControl23.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl22).BeginInit();
		this.GroupControl22.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl20).BeginInit();
		this.GroupControl20.SuspendLayout();
		this.XtraTabPage4.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl27).BeginInit();
		this.GroupControl27.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ChckFono.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ChckOtros.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ChckCable.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ChckInter.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl6).BeginInit();
		this.GroupControl6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl7).BeginInit();
		this.GroupControl7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl8).BeginInit();
		this.GroupControl8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl9).BeginInit();
		this.GroupControl9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl5).BeginInit();
		this.GroupControl5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl4).BeginInit();
		this.GroupControl4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl3).BeginInit();
		this.GroupControl3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).BeginInit();
		this.GroupControl2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		this.XtraTabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl30).BeginInit();
		this.GroupControl30.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl29).BeginInit();
		this.GroupControl29.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup4.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl28).BeginInit();
		this.GroupControl28.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup3.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl26).BeginInit();
		this.GroupControl26.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).BeginInit();
		this.XtraTabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl11).BeginInit();
		this.GroupControl11.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl10).BeginInit();
		this.GroupControl10.SuspendLayout();
		this.XtraTabPage11.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl19).BeginInit();
		this.GroupControl19.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV_Disciplina).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewDisciplina).BeginInit();
		this.XtraTabPage7.SuspendLayout();
		this.XtraTabPage8.SuspendLayout();
		this.XtraTabPage9.SuspendLayout();
		this.XtraTabPage10.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl34).BeginInit();
		this.GroupControl34.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(657, 654);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TabIndex = 100;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(730, 24);
		panelSup.Size = size;
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, -48);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(557, 24);
		panelInf2.Size = size;
		this.Label24.AutoSize = true;
		System.Windows.Forms.Label label = this.Label24;
		location = new System.Drawing.Point(397, 117);
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
		location = new System.Drawing.Point(111, 66);
		ucTxtApePater.Location = location;
		this.UcTxtApePater.Name = "UcTxtApePater";
		this.UcTxtApePater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApePater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApePater.OnErrorBlankText = "";
		this.UcTxtApePater.PadLeftLenght = 0;
		this.UcTxtApePater.ReadOnly = true;
		this.UcTxtApePater.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApePater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApePater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApePater2 = this.UcTxtApePater;
		size = new System.Drawing.Size(217, 20);
		ucTxtApePater2.Size = size;
		this.UcTxtApePater.TabIndex = 3;
		this.UcTxtApePater.TabNextControl = false;
		this.UcTxtApePater.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtNombres.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNombres.Formato = null;
		this.UcTxtNombres.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNombres = this.UcTxtNombres;
		location = new System.Drawing.Point(111, 114);
		ucTxtNombres.Location = location;
		this.UcTxtNombres.Name = "UcTxtNombres";
		this.UcTxtNombres.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNombres.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNombres.OnErrorBlankText = "";
		this.UcTxtNombres.PadLeftLenght = 0;
		this.UcTxtNombres.ReadOnly = true;
		this.UcTxtNombres.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtNombres.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNombres.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNombres2 = this.UcTxtNombres;
		size = new System.Drawing.Size(281, 20);
		ucTxtNombres2.Size = size;
		this.UcTxtNombres.TabIndex = 5;
		this.UcTxtNombres.TabNextControl = false;
		this.UcTxtNombres.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtApeMater.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtApeMater.Formato = null;
		this.UcTxtApeMater.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtApeMater = this.UcTxtApeMater;
		location = new System.Drawing.Point(111, 90);
		ucTxtApeMater.Location = location;
		this.UcTxtApeMater.Name = "UcTxtApeMater";
		this.UcTxtApeMater.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtApeMater.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtApeMater.OnErrorBlankText = "";
		this.UcTxtApeMater.PadLeftLenght = 0;
		this.UcTxtApeMater.ReadOnly = true;
		this.UcTxtApeMater.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtApeMater.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtApeMater.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtApeMater2 = this.UcTxtApeMater;
		size = new System.Drawing.Size(217, 20);
		ucTxtApeMater2.Size = size;
		this.UcTxtApeMater.TabIndex = 4;
		this.UcTxtApeMater.TabNextControl = false;
		this.UcTxtApeMater.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcFoto.AjustarImagen = true;
		this.UcFoto.Borde = false;
		this.UcFoto.FileName = "";
		this.UcFoto.Image = null;
		this.UcFoto.ImageChanged = false;
		GRLL.Common.ucFoto ucFoto = this.UcFoto;
		location = new System.Drawing.Point(524, 23);
		ucFoto.Location = location;
		this.UcFoto.Name = "UcFoto";
		GRLL.Common.ucFoto ucFoto2 = this.UcFoto;
		size = new System.Drawing.Size(133, 141);
		ucFoto2.Size = size;
		this.UcFoto.TabIndex = 26;
		this.UcFoto.VerAjuste = false;
		this.UcFoto.VerControles = false;
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label3;
		location = new System.Drawing.Point(18, 69);
		label3.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label4 = this.Label3;
		size = new System.Drawing.Size(87, 13);
		label4.Size = size;
		this.Label3.TabIndex = 31;
		this.Label3.Text = "Apellido Paterno:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label2;
		location = new System.Drawing.Point(18, 43);
		label5.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label6 = this.Label2;
		size = new System.Drawing.Size(87, 13);
		label6.Size = size;
		this.Label2.TabIndex = 30;
		this.Label2.Text = "Tipo Doc. Ident.:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(18, 93);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(89, 13);
		label8.Size = size;
		this.Label4.TabIndex = 32;
		this.Label4.Text = "Apellido Materno:";
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label1;
		location = new System.Drawing.Point(245, 43);
		label9.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label10 = this.Label1;
		size = new System.Drawing.Size(48, 13);
		label10.Size = size;
		this.Label1.TabIndex = 27;
		this.Label1.Text = "Nº Doc.:";
		this.UcTxtNDoc.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNDoc.Formato = null;
		this.UcTxtNDoc.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNDoc = this.UcTxtNDoc;
		location = new System.Drawing.Point(297, 40);
		ucTxtNDoc.Location = location;
		this.UcTxtNDoc.Name = "UcTxtNDoc";
		this.UcTxtNDoc.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNDoc.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNDoc.OnErrorBlankText = "";
		this.UcTxtNDoc.PadLeftLenght = 0;
		this.UcTxtNDoc.ReadOnly = true;
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
		location = new System.Drawing.Point(53, 117);
		label11.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label12 = this.Label5;
		size = new System.Drawing.Size(52, 13);
		label12.Size = size;
		this.Label5.TabIndex = 25;
		this.Label5.Text = "Nombres:";
		this.XtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraTab.XtraTabControl xtraTabControl = this.XtraTabControl1;
		location = new System.Drawing.Point(12, 210);
		xtraTabControl.Location = location;
		this.XtraTabControl1.LookAndFeel.SkinName = "Money Twins";
		this.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.XtraTabControl1.Name = "XtraTabControl1";
		this.XtraTabControl1.SelectedTabPage = this.XtraTabPage1;
		DevExpress.XtraTab.XtraTabControl xtraTabControl2 = this.XtraTabControl1;
		size = new System.Drawing.Size(709, 435);
		xtraTabControl2.Size = size;
		this.XtraTabControl1.TabIndex = 33;
		this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[14]
		{
			this.XtraTabPage13, this.XtraTabPage1, this.XtraTabPage14, this.XtraTabPage6, this.XtraTabPage2, this.XtraTabPage12, this.XtraTabPage4, this.XtraTabPage5, this.XtraTabPage3, this.XtraTabPage11,
			this.XtraTabPage7, this.XtraTabPage8, this.XtraTabPage9, this.XtraTabPage10
		});
		this.XtraTabPage1.AutoScroll = true;
		this.XtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage1.Controls.Add(this.GroupControl33);
		this.XtraTabPage1.Controls.Add(this.UcCBTipoPersonal);
		this.XtraTabPage1.Controls.Add(this.Label57);
		this.XtraTabPage1.Controls.Add(this.GroupControl18);
		this.XtraTabPage1.Controls.Add(this.GroupControl16);
		this.XtraTabPage1.Controls.Add(this.GroupControl15);
		this.XtraTabPage1.Name = "XtraTabPage1";
		DevExpress.XtraTab.XtraTabPage xtraTabPage = this.XtraTabPage1;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage.Size = size;
		this.XtraTabPage1.Text = "Aspecto Laboral";
		this.GroupControl33.Controls.Add(this.DGVPerLab);
		this.GroupControl33.Controls.Add(this.Button3);
		this.GroupControl33.Controls.Add(this.Button4);
		this.GroupControl33.Controls.Add(this.Button5);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl33;
		location = new System.Drawing.Point(13, 430);
		groupControl.Location = location;
		this.GroupControl33.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl33.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl33.Name = "GroupControl33";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl33;
		size = new System.Drawing.Size(677, 164);
		groupControl2.Size = size;
		this.GroupControl33.TabIndex = 14;
		this.GroupControl33.Text = "Periodos Laborales";
		DevExpress.XtraGrid.GridControl dGVPerLab = this.DGVPerLab;
		location = new System.Drawing.Point(0, 17);
		dGVPerLab.Location = location;
		this.DGVPerLab.LookAndFeel.SkinName = "Blue";
		this.DGVPerLab.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVPerLab.MainView = this.GridViewPerLab;
		this.DGVPerLab.Name = "DGVPerLab";
		DevExpress.XtraGrid.GridControl dGVPerLab2 = this.DGVPerLab;
		size = new System.Drawing.Size(591, 139);
		dGVPerLab2.Size = size;
		this.DGVPerLab.TabIndex = 26;
		this.DGVPerLab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewPerLab });
		this.GridViewPerLab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[8] { this.GridColumn40, this.GridColumn41, this.GridColumn45, this.GridColumn42, this.GridColumn44, this.GridColumn46, this.GridColumn43, this.GridColumn47 });
		this.GridViewPerLab.GridControl = this.DGVPerLab;
		this.GridViewPerLab.Name = "GridViewPerLab";
		this.GridViewPerLab.OptionsBehavior.Editable = false;
		this.GridViewPerLab.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewPerLab.OptionsCustomization.AllowFilter = false;
		this.GridViewPerLab.OptionsCustomization.AllowGroup = false;
		this.GridViewPerLab.OptionsView.ShowGroupPanel = false;
		this.GridColumn40.Caption = "IdEmpleado";
		this.GridColumn40.FieldName = "IdEmpleado";
		this.GridColumn40.Name = "GridColumn40";
		this.GridColumn41.Caption = "NroPeriodo";
		this.GridColumn41.FieldName = "NroPeriodo";
		this.GridColumn41.Name = "GridColumn41";
		this.GridColumn45.Caption = "Fecha Ingreso Institución";
		this.GridColumn45.FieldName = "FechaIngreso";
		this.GridColumn45.Name = "GridColumn45";
		this.GridColumn45.Visible = true;
		this.GridColumn45.VisibleIndex = 0;
		this.GridColumn42.Caption = "Num. Resol. Ingreso Inst.";
		this.GridColumn42.FieldName = "NumResoIngreInstitu";
		this.GridColumn42.Name = "GridColumn42";
		this.GridColumn42.Visible = true;
		this.GridColumn42.VisibleIndex = 1;
		this.GridColumn44.Caption = "Fecha Resol. Ingreso Inst.";
		this.GridColumn44.FieldName = "FechaResoIngreInstitu";
		this.GridColumn44.Name = "GridColumn44";
		this.GridColumn44.Visible = true;
		this.GridColumn44.VisibleIndex = 2;
		this.GridColumn46.Caption = "Judicial";
		this.GridColumn46.FieldName = "Judicial";
		this.GridColumn46.Name = "GridColumn46";
		this.GridColumn43.Caption = "Fecha Retiro Institución";
		this.GridColumn43.FieldName = "FechaSalida";
		this.GridColumn43.Name = "GridColumn43";
		this.GridColumn43.Visible = true;
		this.GridColumn43.VisibleIndex = 3;
		this.GridColumn47.Caption = "Observaciones";
		this.GridColumn47.FieldName = "Obs";
		this.GridColumn47.Name = "GridColumn47";
		this.GridColumn47.Visible = true;
		this.GridColumn47.VisibleIndex = 4;
		this.Button3.FlatAppearance.BorderSize = 0;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button3 = this.Button3;
		location = new System.Drawing.Point(595, 67);
		button3.Location = location;
		this.Button3.Name = "Button3";
		System.Windows.Forms.Button button4 = this.Button3;
		size = new System.Drawing.Size(75, 37);
		button4.Size = size;
		this.Button3.TabIndex = 24;
		this.Button3.Text = "Modificar";
		this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button3.UseVisualStyleBackColor = true;
		this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button4.FlatAppearance.BorderSize = 0;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button5 = this.Button4;
		location = new System.Drawing.Point(595, 23);
		button5.Location = location;
		this.Button4.Name = "Button4";
		System.Windows.Forms.Button button6 = this.Button4;
		size = new System.Drawing.Size(75, 35);
		button6.Size = size;
		this.Button4.TabIndex = 23;
		this.Button4.Text = "Agregar";
		this.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button4.UseVisualStyleBackColor = true;
		this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button5.FlatAppearance.BorderSize = 0;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button7 = this.Button5;
		location = new System.Drawing.Point(595, 110);
		button7.Location = location;
		this.Button5.Name = "Button5";
		System.Windows.Forms.Button button8 = this.Button5;
		size = new System.Drawing.Size(75, 36);
		button8.Size = size;
		this.Button5.TabIndex = 25;
		this.Button5.Text = "Eliminar";
		this.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button5.UseVisualStyleBackColor = true;
		this.UcCBTipoPersonal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoPersonal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoPersonal.FormattingEnabled = true;
		this.UcCBTipoPersonal.IncluirNinguno = false;
		this.UcCBTipoPersonal.Items.AddRange(new object[2] { "Activo", "Pensionista" });
		GRLL.Common.ucComboBox ucCBTipoPersonal = this.UcCBTipoPersonal;
		location = new System.Drawing.Point(108, 12);
		ucCBTipoPersonal.Location = location;
		this.UcCBTipoPersonal.Name = "UcCBTipoPersonal";
		GRLL.Common.ucComboBox ucCBTipoPersonal2 = this.UcCBTipoPersonal;
		size = new System.Drawing.Size(121, 21);
		ucCBTipoPersonal2.Size = size;
		this.UcCBTipoPersonal.TabIndex = 13;
		this.Label57.AutoSize = true;
		System.Windows.Forms.Label label13 = this.Label57;
		location = new System.Drawing.Point(10, 15);
		label13.Location = location;
		this.Label57.Name = "Label57";
		System.Windows.Forms.Label label14 = this.Label57;
		size = new System.Drawing.Size(90, 13);
		label14.Size = size;
		this.Label57.TabIndex = 12;
		this.Label57.Text = "Tipo de Personal:";
		this.GroupControl18.Controls.Add(this.GroupControl32);
		this.GroupControl18.Controls.Add(this.GroupControl31);
		this.GroupControl18.Controls.Add(this.Label31);
		this.GroupControl18.Controls.Add(this.UcCBTipoTrab);
		this.GroupControl18.Controls.Add(this.Label50);
		this.GroupControl18.Controls.Add(this.UcCBCargo);
		this.GroupControl18.Controls.Add(this.Label30);
		this.GroupControl18.Controls.Add(this.UcTxtProfesion);
		this.GroupControl18.Controls.Add(this.Label28);
		this.GroupControl18.Controls.Add(this.UcTxtAutogenSalud);
		DevExpress.XtraEditors.GroupControl groupControl3 = this.GroupControl18;
		location = new System.Drawing.Point(3, 39);
		groupControl3.Location = location;
		this.GroupControl18.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl18.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl18.Name = "GroupControl18";
		DevExpress.XtraEditors.GroupControl groupControl4 = this.GroupControl18;
		size = new System.Drawing.Size(667, 253);
		groupControl4.Size = size;
		this.GroupControl18.TabIndex = 7;
		this.GroupControl18.Text = "Para el Personal Activo";
		this.GroupControl32.Controls.Add(this.UcCBRegimen);
		this.GroupControl32.Controls.Add(this.Label49);
		this.GroupControl32.Controls.Add(this.UcCBAfp);
		this.GroupControl32.Controls.Add(this.Label44);
		this.GroupControl32.Controls.Add(this.UcDTInscripAFP);
		this.GroupControl32.Controls.Add(this.Label48);
		this.GroupControl32.Controls.Add(this.UcTxtNroAfp);
		this.GroupControl32.Controls.Add(this.Label45);
		DevExpress.XtraEditors.GroupControl groupControl5 = this.GroupControl32;
		location = new System.Drawing.Point(8, 88);
		groupControl5.Location = location;
		this.GroupControl32.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl32.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl32.Name = "GroupControl32";
		DevExpress.XtraEditors.GroupControl groupControl6 = this.GroupControl32;
		size = new System.Drawing.Size(325, 158);
		groupControl6.Size = size;
		this.GroupControl32.TabIndex = 37;
		this.GroupControl32.Text = "Regimen de Pension";
		this.UcCBRegimen.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBRegimen.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBRegimen.FormattingEnabled = true;
		this.UcCBRegimen.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBRegimen = this.UcCBRegimen;
		location = new System.Drawing.Point(112, 28);
		ucCBRegimen.Location = location;
		this.UcCBRegimen.Name = "UcCBRegimen";
		GRLL.Common.ucComboBox ucCBRegimen2 = this.UcCBRegimen;
		size = new System.Drawing.Size(109, 21);
		ucCBRegimen2.Size = size;
		this.UcCBRegimen.TabIndex = 15;
		this.Label49.AutoSize = true;
		System.Windows.Forms.Label label15 = this.Label49;
		location = new System.Drawing.Point(17, 31);
		label15.Location = location;
		this.Label49.Name = "Label49";
		System.Windows.Forms.Label label16 = this.Label49;
		size = new System.Drawing.Size(89, 13);
		label16.Size = size;
		this.Label49.TabIndex = 34;
		this.Label49.Text = "Reg. de Pensión:";
		this.UcCBAfp.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBAfp.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBAfp.FormattingEnabled = true;
		this.UcCBAfp.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBAfp = this.UcCBAfp;
		location = new System.Drawing.Point(112, 58);
		ucCBAfp.Location = location;
		this.UcCBAfp.Name = "UcCBAfp";
		GRLL.Common.ucComboBox ucCBAfp2 = this.UcCBAfp;
		size = new System.Drawing.Size(134, 21);
		ucCBAfp2.Size = size;
		this.UcCBAfp.TabIndex = 16;
		this.Label44.AutoSize = true;
		System.Windows.Forms.Label label17 = this.Label44;
		location = new System.Drawing.Point(76, 61);
		label17.Location = location;
		this.Label44.Name = "Label44";
		System.Windows.Forms.Label label18 = this.Label44;
		size = new System.Drawing.Size(30, 13);
		label18.Size = size;
		this.Label44.TabIndex = 32;
		this.Label44.Text = "AFP:";
		this.UcDTInscripAFP.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTInscripAFP.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTInscripAFP = this.UcDTInscripAFP;
		location = new System.Drawing.Point(112, 87);
		ucDTInscripAFP.Location = location;
		this.UcDTInscripAFP.Name = "UcDTInscripAFP";
		GRLL.Common.ucDateTime ucDTInscripAFP2 = this.UcDTInscripAFP;
		size = new System.Drawing.Size(206, 20);
		ucDTInscripAFP2.Size = size;
		this.UcDTInscripAFP.TabIndex = 17;
		this.Label48.AutoSize = true;
		System.Windows.Forms.Label label19 = this.Label48;
		location = new System.Drawing.Point(6, 91);
		label19.Location = location;
		this.Label48.Name = "Label48";
		System.Windows.Forms.Label label20 = this.Label48;
		size = new System.Drawing.Size(100, 13);
		label20.Size = size;
		this.Label48.TabIndex = 36;
		this.Label48.Text = "Fecha Inscrip. AFP:";
		this.UcTxtNroAfp.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNroAfp.Formato = null;
		this.UcTxtNroAfp.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNroAfp = this.UcTxtNroAfp;
		location = new System.Drawing.Point(112, 115);
		ucTxtNroAfp.Location = location;
		this.UcTxtNroAfp.MaxLength = 20;
		this.UcTxtNroAfp.Name = "UcTxtNroAfp";
		this.UcTxtNroAfp.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNroAfp.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNroAfp.OnErrorBlankText = "";
		this.UcTxtNroAfp.PadLeftLenght = 0;
		this.UcTxtNroAfp.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNroAfp.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNroAfp2 = this.UcTxtNroAfp;
		size = new System.Drawing.Size(134, 20);
		ucTxtNroAfp2.Size = size;
		this.UcTxtNroAfp.TabIndex = 18;
		this.UcTxtNroAfp.TabNextControl = false;
		this.UcTxtNroAfp.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label45.AutoSize = true;
		System.Windows.Forms.Label label21 = this.Label45;
		location = new System.Drawing.Point(32, 118);
		label21.Location = location;
		this.Label45.Name = "Label45";
		System.Windows.Forms.Label label22 = this.Label45;
		size = new System.Drawing.Size(74, 13);
		label22.Size = size;
		this.Label45.TabIndex = 33;
		this.Label45.Text = "Num. CUSPP:";
		this.GroupControl31.Controls.Add(this.Label54);
		this.GroupControl31.Controls.Add(this.UcTxtResoIngreEst);
		this.GroupControl31.Controls.Add(this.Label58);
		this.GroupControl31.Controls.Add(this.Label55);
		this.GroupControl31.Controls.Add(this.UcDTFechaResolIngreEstado);
		this.GroupControl31.Controls.Add(this.UcDTIngreEsta);
		DevExpress.XtraEditors.GroupControl groupControl7 = this.GroupControl31;
		location = new System.Drawing.Point(346, 88);
		groupControl7.Location = location;
		this.GroupControl31.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl31.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl31.Name = "GroupControl31";
		DevExpress.XtraEditors.GroupControl groupControl8 = this.GroupControl31;
		size = new System.Drawing.Size(325, 158);
		groupControl8.Size = size;
		this.GroupControl31.TabIndex = 37;
		this.GroupControl31.Text = "Ingreso Estado";
		this.Label54.AutoSize = true;
		System.Windows.Forms.Label label23 = this.Label54;
		location = new System.Drawing.Point(5, 70);
		label23.Location = location;
		this.Label54.Name = "Label54";
		System.Windows.Forms.Label label24 = this.Label54;
		size = new System.Drawing.Size(178, 13);
		label24.Size = size;
		this.Label54.TabIndex = 0;
		this.Label54.Text = "N° Resolución de Ingreso al Estado:";
		this.UcTxtResoIngreEst.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtResoIngreEst.Formato = null;
		this.UcTxtResoIngreEst.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtResoIngreEst = this.UcTxtResoIngreEst;
		location = new System.Drawing.Point(8, 86);
		ucTxtResoIngreEst.Location = location;
		this.UcTxtResoIngreEst.MaxLength = 30;
		this.UcTxtResoIngreEst.Name = "UcTxtResoIngreEst";
		this.UcTxtResoIngreEst.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtResoIngreEst.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtResoIngreEst.OnErrorBlankText = "";
		this.UcTxtResoIngreEst.PadLeftLenght = 0;
		this.UcTxtResoIngreEst.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtResoIngreEst.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtResoIngreEst2 = this.UcTxtResoIngreEst;
		size = new System.Drawing.Size(190, 20);
		ucTxtResoIngreEst2.Size = size;
		this.UcTxtResoIngreEst.TabIndex = 11;
		this.UcTxtResoIngreEst.TabNextControl = false;
		this.UcTxtResoIngreEst.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.Label58.AutoSize = true;
		System.Windows.Forms.Label label25 = this.Label58;
		location = new System.Drawing.Point(4, 111);
		label25.Location = location;
		this.Label58.Name = "Label58";
		System.Windows.Forms.Label label26 = this.Label58;
		size = new System.Drawing.Size(173, 13);
		label26.Size = size;
		this.Label58.TabIndex = 0;
		this.Label58.Text = "Fecha Resol. de Ingreso al Estado:";
		this.Label55.AutoSize = true;
		System.Windows.Forms.Label label27 = this.Label55;
		location = new System.Drawing.Point(5, 28);
		label27.Location = location;
		this.Label55.Name = "Label55";
		System.Windows.Forms.Label label28 = this.Label55;
		size = new System.Drawing.Size(140, 13);
		label28.Size = size;
		this.Label55.TabIndex = 0;
		this.Label55.Text = "Fecha de Ingreso al Estado:";
		this.UcDTFechaResolIngreEstado.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTFechaResolIngreEstado.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTFechaResolIngreEstado = this.UcDTFechaResolIngreEstado;
		location = new System.Drawing.Point(7, 127);
		ucDTFechaResolIngreEstado.Location = location;
		this.UcDTFechaResolIngreEstado.Name = "UcDTFechaResolIngreEstado";
		GRLL.Common.ucDateTime ucDTFechaResolIngreEstado2 = this.UcDTFechaResolIngreEstado;
		size = new System.Drawing.Size(203, 20);
		ucDTFechaResolIngreEstado2.Size = size;
		this.UcDTFechaResolIngreEstado.TabIndex = 12;
		this.UcDTIngreEsta.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTIngreEsta.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTIngreEsta = this.UcDTIngreEsta;
		location = new System.Drawing.Point(7, 44);
		ucDTIngreEsta.Location = location;
		this.UcDTIngreEsta.Name = "UcDTIngreEsta";
		GRLL.Common.ucDateTime ucDTIngreEsta2 = this.UcDTIngreEsta;
		size = new System.Drawing.Size(204, 20);
		ucDTIngreEsta2.Size = size;
		this.UcDTIngreEsta.TabIndex = 12;
		this.Label31.AutoSize = true;
		System.Windows.Forms.Label label29 = this.Label31;
		location = new System.Drawing.Point(390, 33);
		label29.Location = location;
		this.Label31.Name = "Label31";
		System.Windows.Forms.Label label30 = this.Label31;
		size = new System.Drawing.Size(38, 13);
		label30.Size = size;
		this.Label31.TabIndex = 30;
		this.Label31.Text = "Cargo:";
		this.UcCBTipoTrab.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipoTrab.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipoTrab.FormattingEnabled = true;
		this.UcCBTipoTrab.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipoTrab = this.UcCBTipoTrab;
		location = new System.Drawing.Point(112, 61);
		ucCBTipoTrab.Location = location;
		this.UcCBTipoTrab.Name = "UcCBTipoTrab";
		GRLL.Common.ucComboBox ucCBTipoTrab2 = this.UcCBTipoTrab;
		size = new System.Drawing.Size(121, 21);
		ucCBTipoTrab2.Size = size;
		this.UcCBTipoTrab.TabIndex = 9;
		this.Label50.AutoSize = true;
		System.Windows.Forms.Label label31 = this.Label50;
		location = new System.Drawing.Point(336, 64);
		label31.Location = location;
		this.Label50.Name = "Label50";
		System.Windows.Forms.Label label32 = this.Label50;
		size = new System.Drawing.Size(92, 13);
		label32.Size = size;
		this.Label50.TabIndex = 30;
		this.Label50.Text = "N° Autogenerado:";
		this.UcCBCargo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBCargo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBCargo.FormattingEnabled = true;
		this.UcCBCargo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBCargo = this.UcCBCargo;
		location = new System.Drawing.Point(434, 30);
		ucCBCargo.Location = location;
		this.UcCBCargo.Name = "UcCBCargo";
		GRLL.Common.ucComboBox ucCBCargo2 = this.UcCBCargo;
		size = new System.Drawing.Size(223, 21);
		ucCBCargo2.Size = size;
		this.UcCBCargo.TabIndex = 8;
		this.Label30.AutoSize = true;
		System.Windows.Forms.Label label33 = this.Label30;
		location = new System.Drawing.Point(13, 33);
		label33.Location = location;
		this.Label30.Name = "Label30";
		System.Windows.Forms.Label label34 = this.Label30;
		size = new System.Drawing.Size(54, 13);
		label34.Size = size;
		this.Label30.TabIndex = 30;
		this.Label30.Text = "Profesión:";
		this.UcTxtProfesion.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtProfesion.Formato = null;
		this.UcTxtProfesion.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtProfesion = this.UcTxtProfesion;
		location = new System.Drawing.Point(74, 30);
		ucTxtProfesion.Location = location;
		this.UcTxtProfesion.MaxLength = 80;
		this.UcTxtProfesion.Name = "UcTxtProfesion";
		this.UcTxtProfesion.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtProfesion.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtProfesion.OnErrorBlankText = "";
		this.UcTxtProfesion.PadLeftLenght = 0;
		this.UcTxtProfesion.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtProfesion.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtProfesion.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtProfesion2 = this.UcTxtProfesion;
		size = new System.Drawing.Size(310, 20);
		ucTxtProfesion2.Size = size;
		this.UcTxtProfesion.TabIndex = 7;
		this.UcTxtProfesion.TabNextControl = false;
		this.UcTxtProfesion.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label28.AutoSize = true;
		System.Windows.Forms.Label label35 = this.Label28;
		location = new System.Drawing.Point(11, 64);
		label35.Location = location;
		this.Label28.Name = "Label28";
		System.Windows.Forms.Label label36 = this.Label28;
		size = new System.Drawing.Size(95, 13);
		label36.Size = size;
		this.Label28.TabIndex = 30;
		this.Label28.Text = "Condicion Laboral:";
		this.UcTxtAutogenSalud.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAutogenSalud.Formato = null;
		this.UcTxtAutogenSalud.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAutogenSalud = this.UcTxtAutogenSalud;
		location = new System.Drawing.Point(434, 61);
		ucTxtAutogenSalud.Location = location;
		this.UcTxtAutogenSalud.MaxLength = 15;
		this.UcTxtAutogenSalud.Name = "UcTxtAutogenSalud";
		this.UcTxtAutogenSalud.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAutogenSalud.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAutogenSalud.OnErrorBlankText = "";
		this.UcTxtAutogenSalud.PadLeftLenght = 0;
		this.UcTxtAutogenSalud.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtAutogenSalud.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAutogenSalud.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAutogenSalud2 = this.UcTxtAutogenSalud;
		size = new System.Drawing.Size(223, 20);
		ucTxtAutogenSalud2.Size = size;
		this.UcTxtAutogenSalud.TabIndex = 10;
		this.UcTxtAutogenSalud.TabNextControl = false;
		this.UcTxtAutogenSalud.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.GroupControl16.Controls.Add(this.UcDTPension);
		this.GroupControl16.Controls.Add(this.UcDT20530);
		this.GroupControl16.Controls.Add(this.UcDTCese);
		this.GroupControl16.Controls.Add(this.UcTxtResolPensionista);
		this.GroupControl16.Controls.Add(this.UcTxtResol20530);
		this.GroupControl16.Controls.Add(this.UcTxtResolCese);
		this.GroupControl16.Controls.Add(this.Label53);
		this.GroupControl16.Controls.Add(this.Label51);
		this.GroupControl16.Controls.Add(this.Label46);
		this.GroupControl16.Controls.Add(this.Label52);
		this.GroupControl16.Controls.Add(this.Label47);
		this.GroupControl16.Controls.Add(this.Label22);
		DevExpress.XtraEditors.GroupControl groupControl9 = this.GroupControl16;
		location = new System.Drawing.Point(13, 98);
		groupControl9.Location = location;
		this.GroupControl16.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl16.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl16.Name = "GroupControl16";
		this.GroupControl16.RightToLeft = System.Windows.Forms.RightToLeft.No;
		DevExpress.XtraEditors.GroupControl groupControl10 = this.GroupControl16;
		size = new System.Drawing.Size(677, 148);
		groupControl10.Size = size;
		this.GroupControl16.TabIndex = 9;
		this.GroupControl16.Text = "Para el Personal Pensionista";
		this.UcDTPension.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTPension.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTPension = this.UcDTPension;
		location = new System.Drawing.Point(467, 106);
		ucDTPension.Location = location;
		this.UcDTPension.Name = "UcDTPension";
		GRLL.Common.ucDateTime ucDTPension2 = this.UcDTPension;
		size = new System.Drawing.Size(205, 20);
		ucDTPension2.Size = size;
		this.UcDTPension.TabIndex = 28;
		this.UcDT20530.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDT20530.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDT = this.UcDT20530;
		location = new System.Drawing.Point(465, 62);
		ucDT.Location = location;
		this.UcDT20530.Name = "UcDT20530";
		GRLL.Common.ucDateTime ucDT2 = this.UcDT20530;
		size = new System.Drawing.Size(205, 20);
		ucDT2.Size = size;
		this.UcDT20530.TabIndex = 26;
		this.UcDTCese.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTCese.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTCese = this.UcDTCese;
		location = new System.Drawing.Point(467, 29);
		ucDTCese.Location = location;
		this.UcDTCese.Name = "UcDTCese";
		GRLL.Common.ucDateTime ucDTCese2 = this.UcDTCese;
		size = new System.Drawing.Size(205, 20);
		ucDTCese2.Size = size;
		this.UcDTCese.TabIndex = 24;
		this.UcTxtResolPensionista.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtResolPensionista.Formato = null;
		this.UcTxtResolPensionista.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtResolPensionista = this.UcTxtResolPensionista;
		location = new System.Drawing.Point(132, 107);
		ucTxtResolPensionista.Location = location;
		this.UcTxtResolPensionista.Name = "UcTxtResolPensionista";
		this.UcTxtResolPensionista.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtResolPensionista.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtResolPensionista.OnErrorBlankText = "";
		this.UcTxtResolPensionista.PadLeftLenght = 0;
		this.UcTxtResolPensionista.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtResolPensionista.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtResolPensionista2 = this.UcTxtResolPensionista;
		size = new System.Drawing.Size(186, 20);
		ucTxtResolPensionista2.Size = size;
		this.UcTxtResolPensionista.TabIndex = 27;
		this.UcTxtResolPensionista.TabNextControl = false;
		this.UcTxtResolPensionista.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtResol20530.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtResol20530.Formato = null;
		this.UcTxtResol20530.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtResol = this.UcTxtResol20530;
		location = new System.Drawing.Point(132, 63);
		ucTxtResol.Location = location;
		this.UcTxtResol20530.Name = "UcTxtResol20530";
		this.UcTxtResol20530.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtResol20530.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtResol20530.OnErrorBlankText = "";
		this.UcTxtResol20530.PadLeftLenght = 0;
		this.UcTxtResol20530.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtResol20530.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtResol2 = this.UcTxtResol20530;
		size = new System.Drawing.Size(186, 20);
		ucTxtResol2.Size = size;
		this.UcTxtResol20530.TabIndex = 25;
		this.UcTxtResol20530.TabNextControl = false;
		this.UcTxtResol20530.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtResolCese.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtResolCese.Formato = null;
		this.UcTxtResolCese.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtResolCese = this.UcTxtResolCese;
		location = new System.Drawing.Point(132, 29);
		ucTxtResolCese.Location = location;
		this.UcTxtResolCese.Name = "UcTxtResolCese";
		this.UcTxtResolCese.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtResolCese.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtResolCese.OnErrorBlankText = "";
		this.UcTxtResolCese.PadLeftLenght = 0;
		this.UcTxtResolCese.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtResolCese.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtResolCese2 = this.UcTxtResolCese;
		size = new System.Drawing.Size(186, 20);
		ucTxtResolCese2.Size = size;
		this.UcTxtResolCese.TabIndex = 23;
		this.UcTxtResolCese.TabNextControl = false;
		this.UcTxtResolCese.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		System.Windows.Forms.Label label37 = this.Label53;
		location = new System.Drawing.Point(337, 100);
		label37.Location = location;
		this.Label53.Name = "Label53";
		System.Windows.Forms.Label label38 = this.Label53;
		size = new System.Drawing.Size(122, 28);
		label38.Size = size;
		this.Label53.TabIndex = 1;
		this.Label53.Text = "Fecha de Pens. Mensual - Cesantía";
		this.Label51.AutoSize = true;
		System.Windows.Forms.Label label39 = this.Label51;
		location = new System.Drawing.Point(335, 66);
		label39.Location = location;
		this.Label51.Name = "Label51";
		System.Windows.Forms.Label label40 = this.Label51;
		size = new System.Drawing.Size(124, 13);
		label40.Size = size;
		this.Label51.TabIndex = 1;
		this.Label51.Text = "Fecha de Incorp. 20530:";
		this.Label46.AutoSize = true;
		System.Windows.Forms.Label label41 = this.Label46;
		location = new System.Drawing.Point(379, 33);
		label41.Location = location;
		this.Label46.Name = "Label46";
		System.Windows.Forms.Label label42 = this.Label46;
		size = new System.Drawing.Size(82, 13);
		label42.Size = size;
		this.Label46.TabIndex = 1;
		this.Label46.Text = "Fecha de Cese:";
		System.Windows.Forms.Label label43 = this.Label52;
		location = new System.Drawing.Point(6, 99);
		label43.Location = location;
		this.Label52.Name = "Label52";
		System.Windows.Forms.Label label44 = this.Label52;
		size = new System.Drawing.Size(120, 28);
		label44.Size = size;
		this.Label52.TabIndex = 0;
		this.Label52.Text = "Nº Resol. Pensionista Mensual - Cesantía:";
		System.Windows.Forms.Label label45 = this.Label47;
		location = new System.Drawing.Point(5, 56);
		label45.Location = location;
		this.Label47.Name = "Label47";
		System.Windows.Forms.Label label46 = this.Label47;
		size = new System.Drawing.Size(120, 28);
		label46.Size = size;
		this.Label47.TabIndex = 0;
		this.Label47.Text = "Nº Resol. de Incorp. 20530:";
		this.Label22.AutoSize = true;
		System.Windows.Forms.Label label47 = this.Label22;
		location = new System.Drawing.Point(5, 29);
		label47.Location = location;
		this.Label22.Name = "Label22";
		System.Windows.Forms.Label label48 = this.Label22;
		size = new System.Drawing.Size(120, 13);
		label48.Size = size;
		this.Label22.TabIndex = 0;
		this.Label22.Text = "Nº Resolución de Cese:";
		this.GroupControl15.Controls.Add(this.BtnModExpLab);
		this.GroupControl15.Controls.Add(this.BtnAgregarExp);
		this.GroupControl15.Controls.Add(this.BtnElimExpLab);
		this.GroupControl15.Controls.Add(this.DGVExpLab);
		DevExpress.XtraEditors.GroupControl groupControl11 = this.GroupControl15;
		location = new System.Drawing.Point(13, 258);
		groupControl11.Location = location;
		this.GroupControl15.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl15.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl15.Name = "GroupControl15";
		DevExpress.XtraEditors.GroupControl groupControl12 = this.GroupControl15;
		size = new System.Drawing.Size(677, 164);
		groupControl12.Size = size;
		this.GroupControl15.TabIndex = 8;
		this.GroupControl15.Text = "Experiencia Laboral";
		this.BtnModExpLab.FlatAppearance.BorderSize = 0;
		this.BtnModExpLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnModExpLab.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button btnModExpLab = this.BtnModExpLab;
		location = new System.Drawing.Point(597, 67);
		btnModExpLab.Location = location;
		this.BtnModExpLab.Name = "BtnModExpLab";
		System.Windows.Forms.Button btnModExpLab2 = this.BtnModExpLab;
		size = new System.Drawing.Size(75, 37);
		btnModExpLab2.Size = size;
		this.BtnModExpLab.TabIndex = 21;
		this.BtnModExpLab.Text = "Modificar";
		this.BtnModExpLab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnModExpLab.UseVisualStyleBackColor = true;
		this.BtnAgregarExp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregarExp.FlatAppearance.BorderSize = 0;
		this.BtnAgregarExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregarExp.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregarExp = this.BtnAgregarExp;
		location = new System.Drawing.Point(597, 23);
		btnAgregarExp.Location = location;
		this.BtnAgregarExp.Name = "BtnAgregarExp";
		System.Windows.Forms.Button btnAgregarExp2 = this.BtnAgregarExp;
		size = new System.Drawing.Size(75, 35);
		btnAgregarExp2.Size = size;
		this.BtnAgregarExp.TabIndex = 20;
		this.BtnAgregarExp.Text = "Agregar";
		this.BtnAgregarExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregarExp.UseVisualStyleBackColor = true;
		this.BtnElimExpLab.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnElimExpLab.FlatAppearance.BorderSize = 0;
		this.BtnElimExpLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnElimExpLab.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnElimExpLab = this.BtnElimExpLab;
		location = new System.Drawing.Point(597, 110);
		btnElimExpLab.Location = location;
		this.BtnElimExpLab.Name = "BtnElimExpLab";
		System.Windows.Forms.Button btnElimExpLab2 = this.BtnElimExpLab;
		size = new System.Drawing.Size(75, 36);
		btnElimExpLab2.Size = size;
		this.BtnElimExpLab.TabIndex = 22;
		this.BtnElimExpLab.Text = "Eliminar";
		this.BtnElimExpLab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnElimExpLab.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl dGVExpLab = this.DGVExpLab;
		location = new System.Drawing.Point(0, 20);
		dGVExpLab.Location = location;
		this.DGVExpLab.LookAndFeel.SkinName = "Blue";
		this.DGVExpLab.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVExpLab.MainView = this.GridViewExpLab;
		this.DGVExpLab.Name = "DGVExpLab";
		DevExpress.XtraGrid.GridControl dGVExpLab2 = this.DGVExpLab;
		size = new System.Drawing.Size(591, 139);
		dGVExpLab2.Size = size;
		this.DGVExpLab.TabIndex = 0;
		this.DGVExpLab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewExpLab });
		this.GridViewExpLab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[7] { this.GridColumn31, this.GridColumn26, this.GridColumn28, this.GridColumn27, this.GridColumn29, this.GridColumn30, this.GridColumn32 });
		this.GridViewExpLab.GridControl = this.DGVExpLab;
		this.GridViewExpLab.Name = "GridViewExpLab";
		this.GridViewExpLab.OptionsBehavior.Editable = false;
		this.GridViewExpLab.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewExpLab.OptionsCustomization.AllowFilter = false;
		this.GridViewExpLab.OptionsCustomization.AllowGroup = false;
		this.GridViewExpLab.OptionsCustomization.AllowRowSizing = true;
		this.GridViewExpLab.OptionsFilter.AllowColumnMRUFilterList = false;
		this.GridViewExpLab.OptionsFilter.AllowFilterEditor = false;
		this.GridViewExpLab.OptionsFilter.AllowMRUFilterList = false;
		this.GridViewExpLab.OptionsMenu.EnableColumnMenu = false;
		this.GridViewExpLab.OptionsPrint.AutoWidth = false;
		this.GridViewExpLab.OptionsView.ColumnAutoWidth = false;
		this.GridViewExpLab.OptionsView.ShowGroupPanel = false;
		this.GridColumn31.Caption = "Tipo de Institución";
		this.GridColumn31.FieldName = "DescripTipoInstitucion";
		this.GridColumn31.Name = "GridColumn31";
		this.GridColumn31.Visible = true;
		this.GridColumn31.VisibleIndex = 0;
		this.GridColumn31.Width = 110;
		this.GridColumn26.Caption = "Nombre de la Institución";
		this.GridColumn26.FieldName = "NomInstitucion";
		this.GridColumn26.Name = "GridColumn26";
		this.GridColumn26.Visible = true;
		this.GridColumn26.VisibleIndex = 1;
		this.GridColumn26.Width = 130;
		this.GridColumn28.Caption = "Unidad Organica";
		this.GridColumn28.FieldName = "unidadOrganica";
		this.GridColumn28.Name = "GridColumn28";
		this.GridColumn28.Visible = true;
		this.GridColumn28.VisibleIndex = 3;
		this.GridColumn28.Width = 80;
		this.GridColumn27.Caption = "Cargo";
		this.GridColumn27.FieldName = "Cargo";
		this.GridColumn27.Name = "GridColumn27";
		this.GridColumn27.Visible = true;
		this.GridColumn27.VisibleIndex = 2;
		this.GridColumn27.Width = 80;
		this.GridColumn29.Caption = "Fecha de Ingreso";
		this.GridColumn29.FieldName = "FechaIngreso";
		this.GridColumn29.Name = "GridColumn29";
		this.GridColumn29.Visible = true;
		this.GridColumn29.VisibleIndex = 4;
		this.GridColumn29.Width = 80;
		this.GridColumn30.Caption = "Fecha de Egreso";
		this.GridColumn30.FieldName = "FechaEgreso";
		this.GridColumn30.Name = "GridColumn30";
		this.GridColumn30.Visible = true;
		this.GridColumn30.VisibleIndex = 5;
		this.GridColumn30.Width = 80;
		this.GridColumn32.Caption = "idExpLab";
		this.GridColumn32.FieldName = "idExpLab";
		this.GridColumn32.Name = "GridColumn32";
		this.XtraTabPage13.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage13.Controls.Add(this.GroupControl35);
		this.XtraTabPage13.Name = "XtraTabPage13";
		DevExpress.XtraTab.XtraTabPage xtraTabPage2 = this.XtraTabPage13;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage2.Size = size;
		this.XtraTabPage13.Text = "Registro de Asegurados";
		this.GroupControl35.Controls.Add(this.GCAsegurado);
		this.GroupControl35.Controls.Add(this.btnmodificarAsegurado);
		this.GroupControl35.Controls.Add(this.btnAgregarAsegurado);
		DevExpress.XtraEditors.GroupControl groupControl13 = this.GroupControl35;
		location = new System.Drawing.Point(3, 3);
		groupControl13.Location = location;
		this.GroupControl35.Name = "GroupControl35";
		DevExpress.XtraEditors.GroupControl groupControl14 = this.GroupControl35;
		size = new System.Drawing.Size(697, 229);
		groupControl14.Size = size;
		this.GroupControl35.TabIndex = 0;
		this.GroupControl35.Text = "Registro de Asegurados";
		DevExpress.XtraGrid.GridControl gCAsegurado = this.GCAsegurado;
		location = new System.Drawing.Point(5, 23);
		gCAsegurado.Location = location;
		this.GCAsegurado.MainView = this.GVAsegurados;
		this.GCAsegurado.Name = "GCAsegurado";
		DevExpress.XtraGrid.GridControl gCAsegurado2 = this.GCAsegurado;
		size = new System.Drawing.Size(606, 200);
		gCAsegurado2.Size = size;
		this.GCAsegurado.TabIndex = 41;
		this.GCAsegurado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GVAsegurados });
		this.GVAsegurados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[5] { this.GridColumn52, this.GridColumn48, this.GridColumn49, this.GridColumn50, this.GridColumn51 });
		this.GVAsegurados.GridControl = this.GCAsegurado;
		this.GVAsegurados.Name = "GVAsegurados";
		this.GVAsegurados.OptionsBehavior.Editable = false;
		this.GVAsegurados.OptionsView.ShowGroupPanel = false;
		this.GridColumn52.Caption = "NroBeneficiario";
		this.GridColumn52.FieldName = "NroBeneficiario";
		this.GridColumn52.Name = "GridColumn52";
		this.GridColumn48.Caption = "Nombres";
		this.GridColumn48.FieldName = "Persona.Nombres";
		this.GridColumn48.Name = "GridColumn48";
		this.GridColumn48.Visible = true;
		this.GridColumn48.VisibleIndex = 0;
		this.GridColumn49.Caption = "Apellido Paterno";
		this.GridColumn49.FieldName = "Persona.Apellido_Paterno";
		this.GridColumn49.Name = "GridColumn49";
		this.GridColumn49.Visible = true;
		this.GridColumn49.VisibleIndex = 1;
		this.GridColumn50.Caption = "Apellido Materno";
		this.GridColumn50.FieldName = "Persona.Apellido_Materno";
		this.GridColumn50.Name = "GridColumn50";
		this.GridColumn50.Visible = true;
		this.GridColumn50.VisibleIndex = 2;
		this.GridColumn51.Caption = "Vinculo Familiar";
		this.GridColumn51.FieldName = "VinculoFamiliar";
		this.GridColumn51.Name = "GridColumn51";
		this.GridColumn51.Visible = true;
		this.GridColumn51.VisibleIndex = 3;
		this.btnmodificarAsegurado.FlatAppearance.BorderSize = 0;
		this.btnmodificarAsegurado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnmodificarAsegurado.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button9 = this.btnmodificarAsegurado;
		location = new System.Drawing.Point(617, 115);
		button9.Location = location;
		this.btnmodificarAsegurado.Name = "btnmodificarAsegurado";
		System.Windows.Forms.Button button10 = this.btnmodificarAsegurado;
		size = new System.Drawing.Size(75, 37);
		button10.Size = size;
		this.btnmodificarAsegurado.TabIndex = 40;
		this.btnmodificarAsegurado.Text = "Modificar";
		this.btnmodificarAsegurado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnmodificarAsegurado.UseVisualStyleBackColor = true;
		this.btnAgregarAsegurado.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAgregarAsegurado.FlatAppearance.BorderSize = 0;
		this.btnAgregarAsegurado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAgregarAsegurado.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button11 = this.btnAgregarAsegurado;
		location = new System.Drawing.Point(617, 74);
		button11.Location = location;
		this.btnAgregarAsegurado.Name = "btnAgregarAsegurado";
		System.Windows.Forms.Button button12 = this.btnAgregarAsegurado;
		size = new System.Drawing.Size(75, 35);
		button12.Size = size;
		this.btnAgregarAsegurado.TabIndex = 39;
		this.btnAgregarAsegurado.Text = "Agregar";
		this.btnAgregarAsegurado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnAgregarAsegurado.UseVisualStyleBackColor = true;
		this.XtraTabPage14.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage14.Controls.Add(this.GroupControl37);
		this.XtraTabPage14.Controls.Add(this.GroupControl36);
		this.XtraTabPage14.Name = "XtraTabPage14";
		DevExpress.XtraTab.XtraTabPage xtraTabPage3 = this.XtraTabPage14;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage3.Size = size;
		this.XtraTabPage14.Text = "Aspecto Laboral";
		this.GroupControl37.Controls.Add(this.Button9);
		this.GroupControl37.Controls.Add(this.Button10);
		this.GroupControl37.Controls.Add(this.Button11);
		this.GroupControl37.Controls.Add(this.Grid_Resoluciones);
		DevExpress.XtraEditors.GroupControl groupControl15 = this.GroupControl37;
		location = new System.Drawing.Point(3, 192);
		groupControl15.Location = location;
		this.GroupControl37.Name = "GroupControl37";
		DevExpress.XtraEditors.GroupControl groupControl16 = this.GroupControl37;
		size = new System.Drawing.Size(694, 186);
		groupControl16.Size = size;
		this.GroupControl37.TabIndex = 1;
		this.GroupControl37.Text = "Resoluciones";
		this.Button9.FlatAppearance.BorderSize = 0;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button9.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button13 = this.Button9;
		location = new System.Drawing.Point(609, 88);
		button13.Location = location;
		this.Button9.Name = "Button9";
		System.Windows.Forms.Button button14 = this.Button9;
		size = new System.Drawing.Size(75, 37);
		button14.Size = size;
		this.Button9.TabIndex = 28;
		this.Button9.Text = "Modificar";
		this.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button9.UseVisualStyleBackColor = true;
		this.Button10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button10.FlatAppearance.BorderSize = 0;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button15 = this.Button10;
		location = new System.Drawing.Point(609, 44);
		button15.Location = location;
		this.Button10.Name = "Button10";
		System.Windows.Forms.Button button16 = this.Button10;
		size = new System.Drawing.Size(75, 35);
		button16.Size = size;
		this.Button10.TabIndex = 27;
		this.Button10.Text = "Agregar";
		this.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button10.UseVisualStyleBackColor = true;
		this.Button11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button11.FlatAppearance.BorderSize = 0;
		this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button11.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button17 = this.Button11;
		location = new System.Drawing.Point(609, 131);
		button17.Location = location;
		this.Button11.Name = "Button11";
		System.Windows.Forms.Button button18 = this.Button11;
		size = new System.Drawing.Size(75, 36);
		button18.Size = size;
		this.Button11.TabIndex = 29;
		this.Button11.Text = "Eliminar";
		this.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button11.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl grid_Resoluciones = this.Grid_Resoluciones;
		location = new System.Drawing.Point(5, 24);
		grid_Resoluciones.Location = location;
		this.Grid_Resoluciones.MainView = this.GridViewResoluciones;
		this.Grid_Resoluciones.Name = "Grid_Resoluciones";
		DevExpress.XtraGrid.GridControl grid_Resoluciones2 = this.Grid_Resoluciones;
		size = new System.Drawing.Size(598, 155);
		grid_Resoluciones2.Size = size;
		this.Grid_Resoluciones.TabIndex = 26;
		this.Grid_Resoluciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewResoluciones });
		this.GridViewResoluciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.GridColumn57, this.GridColumn58, this.GridColumn59, this.GridColumn60 });
		this.GridViewResoluciones.GridControl = this.Grid_Resoluciones;
		this.GridViewResoluciones.Name = "GridViewResoluciones";
		this.GridViewResoluciones.OptionsView.ShowGroupPanel = false;
		this.GroupControl36.Controls.Add(this.Button6);
		this.GroupControl36.Controls.Add(this.Button7);
		this.GroupControl36.Controls.Add(this.Button8);
		this.GroupControl36.Controls.Add(this.Grid_Rotaciones);
		DevExpress.XtraEditors.GroupControl groupControl17 = this.GroupControl36;
		location = new System.Drawing.Point(3, 3);
		groupControl17.Location = location;
		this.GroupControl36.Name = "GroupControl36";
		DevExpress.XtraEditors.GroupControl groupControl18 = this.GroupControl36;
		size = new System.Drawing.Size(694, 183);
		groupControl18.Size = size;
		this.GroupControl36.TabIndex = 0;
		this.GroupControl36.Text = "Rotaciones";
		this.Button6.FlatAppearance.BorderSize = 0;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button19 = this.Button6;
		location = new System.Drawing.Point(609, 87);
		button19.Location = location;
		this.Button6.Name = "Button6";
		System.Windows.Forms.Button button20 = this.Button6;
		size = new System.Drawing.Size(75, 37);
		button20.Size = size;
		this.Button6.TabIndex = 24;
		this.Button6.Text = "Modificar";
		this.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button6.UseVisualStyleBackColor = true;
		this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button7.FlatAppearance.BorderSize = 0;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button21 = this.Button7;
		location = new System.Drawing.Point(609, 43);
		button21.Location = location;
		this.Button7.Name = "Button7";
		System.Windows.Forms.Button button22 = this.Button7;
		size = new System.Drawing.Size(75, 35);
		button22.Size = size;
		this.Button7.TabIndex = 23;
		this.Button7.Text = "Agregar";
		this.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button7.UseVisualStyleBackColor = true;
		this.Button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button8.FlatAppearance.BorderSize = 0;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button8.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button23 = this.Button8;
		location = new System.Drawing.Point(609, 130);
		button23.Location = location;
		this.Button8.Name = "Button8";
		System.Windows.Forms.Button button24 = this.Button8;
		size = new System.Drawing.Size(75, 36);
		button24.Size = size;
		this.Button8.TabIndex = 25;
		this.Button8.Text = "Eliminar";
		this.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button8.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl grid_Rotaciones = this.Grid_Rotaciones;
		location = new System.Drawing.Point(5, 23);
		grid_Rotaciones.Location = location;
		this.Grid_Rotaciones.MainView = this.GridViewRotaciones;
		this.Grid_Rotaciones.Name = "Grid_Rotaciones";
		DevExpress.XtraGrid.GridControl grid_Rotaciones2 = this.Grid_Rotaciones;
		size = new System.Drawing.Size(598, 155);
		grid_Rotaciones2.Size = size;
		this.Grid_Rotaciones.TabIndex = 0;
		this.Grid_Rotaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewRotaciones });
		this.GridViewRotaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.GridColumn53, this.GridColumn54, this.GridColumn55, this.GridColumn56 });
		this.GridViewRotaciones.GridControl = this.Grid_Rotaciones;
		this.GridViewRotaciones.Name = "GridViewRotaciones";
		this.GridViewRotaciones.OptionsView.ShowGroupPanel = false;
		this.GridColumn53.Caption = "Nro";
		this.GridColumn53.FieldName = "idRotacion";
		this.GridColumn53.Name = "GridColumn53";
		this.GridColumn53.Visible = true;
		this.GridColumn53.VisibleIndex = 0;
		this.GridColumn54.Caption = "Fecha Memo.";
		this.GridColumn54.FieldName = "FechaMemo";
		this.GridColumn54.Name = "GridColumn54";
		this.GridColumn54.Visible = true;
		this.GridColumn54.VisibleIndex = 1;
		this.GridColumn55.Caption = "Nro. Memo";
		this.GridColumn55.FieldName = "NroMemo";
		this.GridColumn55.Name = "GridColumn55";
		this.GridColumn55.Visible = true;
		this.GridColumn55.VisibleIndex = 2;
		this.GridColumn56.Caption = "Area Organizacional";
		this.GridColumn56.FieldName = "AreaOrganizacional";
		this.GridColumn56.Name = "GridColumn56";
		this.GridColumn56.Visible = true;
		this.GridColumn56.VisibleIndex = 3;
		this.XtraTabPage6.AutoScroll = true;
		this.XtraTabPage6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage6.Controls.Add(this.GroupControl14);
		this.XtraTabPage6.Controls.Add(this.GroupControl13);
		this.XtraTabPage6.Controls.Add(this.GroupControl12);
		this.XtraTabPage6.Name = "XtraTabPage6";
		DevExpress.XtraTab.XtraTabPage xtraTabPage4 = this.XtraTabPage6;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage4.Size = size;
		this.XtraTabPage6.Text = "Aspecto de Educacion";
		this.GroupControl14.Controls.Add(this.Button2);
		this.GroupControl14.Controls.Add(this.DGVCapacitacion);
		this.GroupControl14.Controls.Add(this.BtnAgregarCap);
		this.GroupControl14.Controls.Add(this.BtnEliminarCap);
		DevExpress.XtraEditors.GroupControl groupControl19 = this.GroupControl14;
		location = new System.Drawing.Point(3, 336);
		groupControl19.Location = location;
		this.GroupControl14.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl14.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl14.Name = "GroupControl14";
		DevExpress.XtraEditors.GroupControl groupControl20 = this.GroupControl14;
		size = new System.Drawing.Size(673, 159);
		groupControl20.Size = size;
		this.GroupControl14.TabIndex = 39;
		this.GroupControl14.Text = "Estudios de Capacitación y Perfeccionamiento";
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button25 = this.Button2;
		location = new System.Drawing.Point(592, 64);
		button25.Location = location;
		this.Button2.Name = "Button2";
		System.Windows.Forms.Button button26 = this.Button2;
		size = new System.Drawing.Size(75, 37);
		button26.Size = size;
		this.Button2.TabIndex = 42;
		this.Button2.Text = "Modificar";
		this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button2.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl dGVCapacitacion = this.DGVCapacitacion;
		location = new System.Drawing.Point(0, 17);
		dGVCapacitacion.Location = location;
		this.DGVCapacitacion.LookAndFeel.SkinName = "Blue";
		this.DGVCapacitacion.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVCapacitacion.MainView = this.GridViewCapacitacion;
		this.DGVCapacitacion.Name = "DGVCapacitacion";
		DevExpress.XtraGrid.GridControl dGVCapacitacion2 = this.DGVCapacitacion;
		size = new System.Drawing.Size(587, 135);
		dGVCapacitacion2.Size = size;
		this.DGVCapacitacion.TabIndex = 40;
		this.DGVCapacitacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewCapacitacion });
		this.GridViewCapacitacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[6] { this.GridColumn20, this.GridColumn21, this.GridColumn22, this.GridColumn23, this.GridColumn24, this.GridColumn25 });
		this.GridViewCapacitacion.GridControl = this.DGVCapacitacion;
		this.GridViewCapacitacion.Name = "GridViewCapacitacion";
		this.GridViewCapacitacion.OptionsBehavior.Editable = false;
		this.GridViewCapacitacion.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewCapacitacion.OptionsCustomization.AllowFilter = false;
		this.GridViewCapacitacion.OptionsCustomization.AllowGroup = false;
		this.GridViewCapacitacion.OptionsCustomization.AllowRowSizing = true;
		this.GridViewCapacitacion.OptionsView.ColumnAutoWidth = false;
		this.GridViewCapacitacion.OptionsView.ShowGroupPanel = false;
		this.GridColumn20.Caption = "Nombre del Curso";
		this.GridColumn20.FieldName = "NombreCurso";
		this.GridColumn20.Name = "GridColumn20";
		this.GridColumn20.Visible = true;
		this.GridColumn20.VisibleIndex = 0;
		this.GridColumn20.Width = 175;
		this.GridColumn21.Caption = "Fecha de Inicio";
		this.GridColumn21.FieldName = "FechaInicio";
		this.GridColumn21.Name = "GridColumn21";
		this.GridColumn21.Visible = true;
		this.GridColumn21.VisibleIndex = 1;
		this.GridColumn21.Width = 85;
		this.GridColumn22.Caption = "Fecha de Termino";
		this.GridColumn22.FieldName = "FechaFin";
		this.GridColumn22.Name = "GridColumn22";
		this.GridColumn22.Visible = true;
		this.GridColumn22.VisibleIndex = 2;
		this.GridColumn22.Width = 90;
		this.GridColumn23.Caption = "Cantidad de Horas";
		this.GridColumn23.FieldName = "NumHoras";
		this.GridColumn23.Name = "GridColumn23";
		this.GridColumn23.Visible = true;
		this.GridColumn23.VisibleIndex = 3;
		this.GridColumn24.Caption = "Institución Organizadora";
		this.GridColumn24.FieldName = "InstitucionOrganizadora";
		this.GridColumn24.Name = "GridColumn24";
		this.GridColumn24.Visible = true;
		this.GridColumn24.VisibleIndex = 4;
		this.GridColumn24.Width = 150;
		this.GridColumn25.Caption = "IdCapacitacion";
		this.GridColumn25.FieldName = "IdCapacitacion";
		this.GridColumn25.Name = "GridColumn25";
		this.BtnAgregarCap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregarCap.FlatAppearance.BorderSize = 0;
		this.BtnAgregarCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregarCap.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregarCap = this.BtnAgregarCap;
		location = new System.Drawing.Point(593, 23);
		btnAgregarCap.Location = location;
		this.BtnAgregarCap.Name = "BtnAgregarCap";
		System.Windows.Forms.Button btnAgregarCap2 = this.BtnAgregarCap;
		size = new System.Drawing.Size(75, 35);
		btnAgregarCap2.Size = size;
		this.BtnAgregarCap.TabIndex = 40;
		this.BtnAgregarCap.Text = "Agregar";
		this.BtnAgregarCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregarCap.UseVisualStyleBackColor = true;
		this.BtnEliminarCap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminarCap.FlatAppearance.BorderSize = 0;
		this.BtnEliminarCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminarCap.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminarCap = this.BtnEliminarCap;
		location = new System.Drawing.Point(593, 107);
		btnEliminarCap.Location = location;
		this.BtnEliminarCap.Name = "BtnEliminarCap";
		System.Windows.Forms.Button btnEliminarCap2 = this.BtnEliminarCap;
		size = new System.Drawing.Size(75, 36);
		btnEliminarCap2.Size = size;
		this.BtnEliminarCap.TabIndex = 41;
		this.BtnEliminarCap.Text = "Eliminar";
		this.BtnEliminarCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnEliminarCap.UseVisualStyleBackColor = true;
		this.GroupControl13.Controls.Add(this.Button1);
		this.GroupControl13.Controls.Add(this.DGVTitulos);
		this.GroupControl13.Controls.Add(this.BtnAgregarGrados);
		this.GroupControl13.Controls.Add(this.BtnEliminarGrados);
		DevExpress.XtraEditors.GroupControl groupControl21 = this.GroupControl13;
		location = new System.Drawing.Point(3, 171);
		groupControl21.Location = location;
		this.GroupControl13.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl13.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl13.Name = "GroupControl13";
		DevExpress.XtraEditors.GroupControl groupControl22 = this.GroupControl13;
		size = new System.Drawing.Size(673, 159);
		groupControl22.Size = size;
		this.GroupControl13.TabIndex = 38;
		this.GroupControl13.Text = "Grados y Titulos";
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button27 = this.Button1;
		location = new System.Drawing.Point(593, 64);
		button27.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button28 = this.Button1;
		size = new System.Drawing.Size(75, 37);
		button28.Size = size;
		this.Button1.TabIndex = 40;
		this.Button1.Text = "Modificar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.Button1.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl dGVTitulos = this.DGVTitulos;
		location = new System.Drawing.Point(0, 17);
		dGVTitulos.Location = location;
		this.DGVTitulos.LookAndFeel.SkinName = "Blue";
		this.DGVTitulos.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVTitulos.MainView = this.GridViewTitulos;
		this.DGVTitulos.Name = "DGVTitulos";
		DevExpress.XtraGrid.GridControl dGVTitulos2 = this.DGVTitulos;
		size = new System.Drawing.Size(587, 135);
		dGVTitulos2.Size = size;
		this.DGVTitulos.TabIndex = 0;
		this.DGVTitulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewTitulos });
		this.GridViewTitulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.GridColumn16, this.GridColumn17, this.GridColumn18, this.GridColumn19 });
		this.GridViewTitulos.GridControl = this.DGVTitulos;
		this.GridViewTitulos.Name = "GridViewTitulos";
		this.GridViewTitulos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridViewTitulos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
		this.GridViewTitulos.OptionsBehavior.Editable = false;
		this.GridViewTitulos.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewTitulos.OptionsCustomization.AllowFilter = false;
		this.GridViewTitulos.OptionsCustomization.AllowGroup = false;
		this.GridViewTitulos.OptionsView.ColumnAutoWidth = false;
		this.GridViewTitulos.OptionsView.ShowGroupPanel = false;
		this.GridColumn16.Caption = "Num. de Colegiatura";
		this.GridColumn16.FieldName = "NumColegiatura";
		this.GridColumn16.Name = "GridColumn16";
		this.GridColumn16.OptionsColumn.AllowEdit = false;
		this.GridColumn16.Visible = true;
		this.GridColumn16.VisibleIndex = 0;
		this.GridColumn16.Width = 90;
		this.GridColumn17.Caption = "Denominación del Grado y/o Titulo";
		this.GridColumn17.FieldName = "DenominacionGrado";
		this.GridColumn17.Name = "GridColumn17";
		this.GridColumn17.Visible = true;
		this.GridColumn17.VisibleIndex = 1;
		this.GridColumn17.Width = 200;
		this.GridColumn18.Caption = "Institución";
		this.GridColumn18.FieldName = "Institucion";
		this.GridColumn18.Name = "GridColumn18";
		this.GridColumn18.Visible = true;
		this.GridColumn18.VisibleIndex = 2;
		this.GridColumn18.Width = 175;
		this.GridColumn19.Caption = "Fecha";
		this.GridColumn19.FieldName = "Fecha";
		this.GridColumn19.Name = "GridColumn19";
		this.GridColumn19.Visible = true;
		this.GridColumn19.VisibleIndex = 3;
		this.BtnAgregarGrados.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregarGrados.FlatAppearance.BorderSize = 0;
		this.BtnAgregarGrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregarGrados.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregarGrados = this.BtnAgregarGrados;
		location = new System.Drawing.Point(593, 23);
		btnAgregarGrados.Location = location;
		this.BtnAgregarGrados.Name = "BtnAgregarGrados";
		System.Windows.Forms.Button btnAgregarGrados2 = this.BtnAgregarGrados;
		size = new System.Drawing.Size(75, 35);
		btnAgregarGrados2.Size = size;
		this.BtnAgregarGrados.TabIndex = 37;
		this.BtnAgregarGrados.Text = "Agregar";
		this.BtnAgregarGrados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregarGrados.UseVisualStyleBackColor = true;
		this.BtnEliminarGrados.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminarGrados.FlatAppearance.BorderSize = 0;
		this.BtnEliminarGrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminarGrados.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminarGrados = this.BtnEliminarGrados;
		location = new System.Drawing.Point(593, 107);
		btnEliminarGrados.Location = location;
		this.BtnEliminarGrados.Name = "BtnEliminarGrados";
		System.Windows.Forms.Button btnEliminarGrados2 = this.BtnEliminarGrados;
		size = new System.Drawing.Size(75, 36);
		btnEliminarGrados2.Size = size;
		this.BtnEliminarGrados.TabIndex = 39;
		this.BtnEliminarGrados.Text = "Eliminar";
		this.BtnEliminarGrados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnEliminarGrados.UseVisualStyleBackColor = true;
		this.GroupControl12.Controls.Add(this.DGVEstudios);
		this.GroupControl12.Controls.Add(this.BtnModEst);
		this.GroupControl12.Controls.Add(this.BtnAgregarEst);
		this.GroupControl12.Controls.Add(this.BtnEliminarEst);
		DevExpress.XtraEditors.GroupControl groupControl23 = this.GroupControl12;
		location = new System.Drawing.Point(3, 6);
		groupControl23.Location = location;
		this.GroupControl12.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl12.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl12.Name = "GroupControl12";
		DevExpress.XtraEditors.GroupControl groupControl24 = this.GroupControl12;
		size = new System.Drawing.Size(673, 159);
		groupControl24.Size = size;
		this.GroupControl12.TabIndex = 37;
		this.GroupControl12.Text = "Estudios Realizados";
		DevExpress.XtraGrid.GridControl dGVEstudios = this.DGVEstudios;
		location = new System.Drawing.Point(0, 17);
		dGVEstudios.Location = location;
		this.DGVEstudios.LookAndFeel.SkinName = "Blue";
		this.DGVEstudios.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGVEstudios.MainView = this.GridViewEstudios;
		this.DGVEstudios.Name = "DGVEstudios";
		DevExpress.XtraGrid.GridControl dGVEstudios2 = this.DGVEstudios;
		size = new System.Drawing.Size(587, 135);
		dGVEstudios2.Size = size;
		this.DGVEstudios.TabIndex = 33;
		this.DGVEstudios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewEstudios });
		this.GridViewEstudios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[6] { this.GridColumn10, this.GridColumn11, this.GridColumn12, this.GridColumn13, this.GridColumn14, this.GridColumn15 });
		this.GridViewEstudios.GridControl = this.DGVEstudios;
		this.GridViewEstudios.Name = "GridViewEstudios";
		this.GridViewEstudios.OptionsBehavior.Editable = false;
		this.GridViewEstudios.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewEstudios.OptionsCustomization.AllowFilter = false;
		this.GridViewEstudios.OptionsCustomization.AllowGroup = false;
		this.GridViewEstudios.OptionsView.ColumnAutoWidth = false;
		this.GridViewEstudios.OptionsView.ShowGroupPanel = false;
		this.GridColumn10.Caption = "Tipo Estudio";
		this.GridColumn10.FieldName = "DescripTipoEst";
		this.GridColumn10.Name = "GridColumn10";
		this.GridColumn10.Visible = true;
		this.GridColumn10.VisibleIndex = 0;
		this.GridColumn10.Width = 90;
		this.GridColumn11.Caption = "Centro de Estudio";
		this.GridColumn11.FieldName = "CentroEstudios";
		this.GridColumn11.Name = "GridColumn11";
		this.GridColumn11.Visible = true;
		this.GridColumn11.VisibleIndex = 1;
		this.GridColumn11.Width = 180;
		this.GridColumn12.Caption = "Año de Inicio";
		this.GridColumn12.FieldName = "Añoinicio";
		this.GridColumn12.Name = "GridColumn12";
		this.GridColumn12.Visible = true;
		this.GridColumn12.VisibleIndex = 2;
		this.GridColumn12.Width = 85;
		this.GridColumn13.Caption = "Año de Termino";
		this.GridColumn13.FieldName = "Añotermino";
		this.GridColumn13.Name = "GridColumn13";
		this.GridColumn13.Visible = true;
		this.GridColumn13.VisibleIndex = 3;
		this.GridColumn13.Width = 85;
		this.GridColumn14.Caption = "Estado";
		this.GridColumn14.FieldName = "DescripEstadoEstudio";
		this.GridColumn14.Name = "GridColumn14";
		this.GridColumn14.Visible = true;
		this.GridColumn14.VisibleIndex = 4;
		this.GridColumn15.Caption = "IdTipoEstudios";
		this.GridColumn15.FieldName = "IdTipoEstudios";
		this.GridColumn15.Name = "GridColumn15";
		this.GridColumn15.OptionsFilter.AllowFilter = false;
		this.BtnModEst.FlatAppearance.BorderSize = 0;
		this.BtnModEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnModEst.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button btnModEst = this.BtnModEst;
		location = new System.Drawing.Point(593, 64);
		btnModEst.Location = location;
		this.BtnModEst.Name = "BtnModEst";
		System.Windows.Forms.Button btnModEst2 = this.BtnModEst;
		size = new System.Drawing.Size(75, 37);
		btnModEst2.Size = size;
		this.BtnModEst.TabIndex = 35;
		this.BtnModEst.Text = "Modificar";
		this.BtnModEst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnModEst.UseVisualStyleBackColor = true;
		this.BtnAgregarEst.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregarEst.FlatAppearance.BorderSize = 0;
		this.BtnAgregarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregarEst.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregarEst = this.BtnAgregarEst;
		location = new System.Drawing.Point(593, 23);
		btnAgregarEst.Location = location;
		this.BtnAgregarEst.Name = "BtnAgregarEst";
		System.Windows.Forms.Button btnAgregarEst2 = this.BtnAgregarEst;
		size = new System.Drawing.Size(75, 35);
		btnAgregarEst2.Size = size;
		this.BtnAgregarEst.TabIndex = 34;
		this.BtnAgregarEst.Text = "Agregar";
		this.BtnAgregarEst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregarEst.UseVisualStyleBackColor = true;
		this.BtnEliminarEst.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminarEst.FlatAppearance.BorderSize = 0;
		this.BtnEliminarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminarEst.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminarEst = this.BtnEliminarEst;
		location = new System.Drawing.Point(593, 107);
		btnEliminarEst.Location = location;
		this.BtnEliminarEst.Name = "BtnEliminarEst";
		System.Windows.Forms.Button btnEliminarEst2 = this.BtnEliminarEst;
		size = new System.Drawing.Size(75, 36);
		btnEliminarEst2.Size = size;
		this.BtnEliminarEst.TabIndex = 36;
		this.BtnEliminarEst.Text = "Eliminar";
		this.BtnEliminarEst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnEliminarEst.UseVisualStyleBackColor = true;
		this.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.Color.Turquoise;
		this.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = true;
		this.XtraTabPage2.AutoScroll = true;
		this.XtraTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage2.Controls.Add(this.GroupControl17);
		this.XtraTabPage2.Controls.Add(this.RadioGroup1);
		this.XtraTabPage2.Controls.Add(this.UcCBViveCon);
		this.XtraTabPage2.Controls.Add(this.Label9);
		this.XtraTabPage2.Controls.Add(this.UcTxtNumHijos);
		this.XtraTabPage2.Controls.Add(this.UcTxtObsFam);
		this.XtraTabPage2.Controls.Add(this.UcTxtCargaFam);
		this.XtraTabPage2.Controls.Add(this.Label11);
		this.XtraTabPage2.Controls.Add(this.Label10);
		this.XtraTabPage2.Controls.Add(this.Label8);
		this.XtraTabPage2.Controls.Add(this.Label7);
		this.XtraTabPage2.Controls.Add(this.Label12);
		this.XtraTabPage2.Controls.Add(this.Label6);
		this.XtraTabPage2.Name = "XtraTabPage2";
		DevExpress.XtraTab.XtraTabPage xtraTabPage5 = this.XtraTabPage2;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage5.Size = size;
		this.XtraTabPage2.Text = "Aspecto Familiar";
		this.GroupControl17.Controls.Add(this.dgvFamiliares);
		this.GroupControl17.Controls.Add(this.btnEliminar);
		this.GroupControl17.Controls.Add(this.btnModificar);
		this.GroupControl17.Controls.Add(this.btnAgregar);
		DevExpress.XtraEditors.GroupControl groupControl25 = this.GroupControl17;
		location = new System.Drawing.Point(3, 79);
		groupControl25.Location = location;
		this.GroupControl17.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl17.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl17.Name = "GroupControl17";
		DevExpress.XtraEditors.GroupControl groupControl26 = this.GroupControl17;
		size = new System.Drawing.Size(694, 225);
		groupControl26.Size = size;
		this.GroupControl17.TabIndex = 24;
		this.GroupControl17.Text = "Composición Familiar";
		this.dgvFamiliares.EmbeddedNavigator.Buttons.Append.Visible = false;
		this.dgvFamiliares.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
		this.dgvFamiliares.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
		this.dgvFamiliares.EmbeddedNavigator.Buttons.Edit.Visible = false;
		this.dgvFamiliares.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
		this.dgvFamiliares.EmbeddedNavigator.Buttons.Remove.Visible = false;
		this.dgvFamiliares.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
		DevExpress.XtraGrid.GridControl gridControl = this.dgvFamiliares;
		location = new System.Drawing.Point(5, 23);
		gridControl.Location = location;
		this.dgvFamiliares.LookAndFeel.SkinName = "Blue";
		this.dgvFamiliares.LookAndFeel.UseDefaultLookAndFeel = false;
		this.dgvFamiliares.MainView = this.GridViewFam;
		this.dgvFamiliares.Name = "dgvFamiliares";
		this.dgvFamiliares.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[3] { this.RepositoryItemRadioGroup1, this.RepositoryItemCheckEdit1, this.RepositoryItemCheckEdit2 });
		DevExpress.XtraGrid.GridControl gridControl2 = this.dgvFamiliares;
		size = new System.Drawing.Size(603, 197);
		gridControl2.Size = size;
		this.dgvFamiliares.TabIndex = 23;
		this.dgvFamiliares.UseEmbeddedNavigator = true;
		this.dgvFamiliares.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewFam });
		this.GridViewFam.BestFitMaxRowCount = 2;
		this.GridViewFam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[9] { this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4, this.GridColumn5, this.GridColumn6, this.GridColumn7, this.GridColumn8, this.GridColumn9 });
		this.GridViewFam.GridControl = this.dgvFamiliares;
		this.GridViewFam.HorzScrollStep = 1;
		this.GridViewFam.Name = "GridViewFam";
		this.GridViewFam.OptionsBehavior.Editable = false;
		this.GridViewFam.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewFam.OptionsCustomization.AllowFilter = false;
		this.GridViewFam.OptionsCustomization.AllowGroup = false;
		this.GridViewFam.OptionsView.ColumnAutoWidth = false;
		this.GridViewFam.OptionsView.ShowGroupPanel = false;
		this.GridColumn1.Caption = "Nombres y Apellidos";
		this.GridColumn1.FieldName = "NombresCompletos";
		this.GridColumn1.Name = "GridColumn1";
		this.GridColumn1.Visible = true;
		this.GridColumn1.VisibleIndex = 0;
		this.GridColumn1.Width = 200;
		this.GridColumn2.Caption = "Fecha Nacimiento";
		this.GridColumn2.FieldName = "fechaNacimiento";
		this.GridColumn2.Name = "GridColumn2";
		this.GridColumn2.Visible = true;
		this.GridColumn2.VisibleIndex = 1;
		this.GridColumn3.Caption = "Sexo";
		this.GridColumn3.FieldName = "famSexo";
		this.GridColumn3.Name = "GridColumn3";
		this.GridColumn3.Visible = true;
		this.GridColumn3.VisibleIndex = 2;
		this.GridColumn4.Caption = "Parentesco";
		this.GridColumn4.FieldName = "DescripTipoFam";
		this.GridColumn4.Name = "GridColumn4";
		this.GridColumn4.Visible = true;
		this.GridColumn4.VisibleIndex = 3;
		this.GridColumn5.Caption = "Grado de Inst.";
		this.GridColumn5.FieldName = "famgradoInstruc";
		this.GridColumn5.Name = "GridColumn5";
		this.GridColumn5.Visible = true;
		this.GridColumn5.VisibleIndex = 4;
		this.GridColumn6.Caption = "E. Civil";
		this.GridColumn6.FieldName = "descripestcivil";
		this.GridColumn6.Name = "GridColumn6";
		this.GridColumn6.Visible = true;
		this.GridColumn6.VisibleIndex = 5;
		this.GridColumn7.Caption = "Vive en Casa";
		this.GridColumn7.ColumnEdit = this.RepositoryItemCheckEdit1;
		this.GridColumn7.FieldName = "vivecasa";
		this.GridColumn7.Name = "GridColumn7";
		this.GridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
		this.GridColumn7.Visible = true;
		this.GridColumn7.VisibleIndex = 6;
		this.GridColumn7.Width = 58;
		this.RepositoryItemCheckEdit1.AutoHeight = false;
		this.RepositoryItemCheckEdit1.LookAndFeel.SkinName = "Money Twins";
		this.RepositoryItemCheckEdit1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1";
		this.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
		this.GridColumn8.Caption = "Idpersona";
		this.GridColumn8.FieldName = "Idpersona";
		this.GridColumn8.Name = "GridColumn8";
		this.GridColumn9.Caption = "Lab. Institución";
		this.GridColumn9.ColumnEdit = this.RepositoryItemCheckEdit2;
		this.GridColumn9.FieldName = "laborainstitucion";
		this.GridColumn9.Name = "GridColumn9";
		this.GridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
		this.GridColumn9.Visible = true;
		this.GridColumn9.VisibleIndex = 7;
		this.RepositoryItemCheckEdit2.AutoHeight = false;
		this.RepositoryItemCheckEdit2.LookAndFeel.SkinName = "Money Twins";
		this.RepositoryItemCheckEdit2.LookAndFeel.UseDefaultLookAndFeel = false;
		this.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2";
		this.RepositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
		this.RepositoryItemRadioGroup1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
		this.RepositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		this.RepositoryItemRadioGroup1.LookAndFeel.SkinName = "Blue";
		this.RepositoryItemRadioGroup1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1";
		this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnEliminar.FlatAppearance.BorderSize = 0;
		this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEliminar.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button button29 = this.btnEliminar;
		location = new System.Drawing.Point(614, 139);
		button29.Location = location;
		this.btnEliminar.Name = "btnEliminar";
		System.Windows.Forms.Button button30 = this.btnEliminar;
		size = new System.Drawing.Size(75, 36);
		button30.Size = size;
		this.btnEliminar.TabIndex = 12;
		this.btnEliminar.Text = "Eliminar";
		this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnEliminar.UseVisualStyleBackColor = true;
		this.btnModificar.FlatAppearance.BorderSize = 0;
		this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnModificar.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button button31 = this.btnModificar;
		location = new System.Drawing.Point(614, 96);
		button31.Location = location;
		this.btnModificar.Name = "btnModificar";
		System.Windows.Forms.Button button32 = this.btnModificar;
		size = new System.Drawing.Size(75, 37);
		button32.Size = size;
		this.btnModificar.TabIndex = 12;
		this.btnModificar.Text = "Modificar";
		this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnModificar.UseVisualStyleBackColor = true;
		this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAgregar.FlatAppearance.BorderSize = 0;
		this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAgregar.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button button33 = this.btnAgregar;
		location = new System.Drawing.Point(614, 55);
		button33.Location = location;
		this.btnAgregar.Name = "btnAgregar";
		System.Windows.Forms.Button button34 = this.btnAgregar;
		size = new System.Drawing.Size(75, 35);
		button34.Size = size;
		this.btnAgregar.TabIndex = 11;
		this.btnAgregar.Text = "Agregar";
		this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btnAgregar.UseVisualStyleBackColor = true;
		DevExpress.XtraEditors.RadioGroup radioGroup = this.RadioGroup1;
		location = new System.Drawing.Point(413, 14);
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
		this.RadioGroup1.TabIndex = 8;
		this.UcCBViveCon.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBViveCon.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBViveCon.FormattingEnabled = true;
		this.UcCBViveCon.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBViveCon = this.UcCBViveCon;
		location = new System.Drawing.Point(132, 19);
		ucCBViveCon.Location = location;
		this.UcCBViveCon.Name = "UcCBViveCon";
		GRLL.Common.ucComboBox ucCBViveCon2 = this.UcCBViveCon;
		size = new System.Drawing.Size(172, 21);
		ucCBViveCon2.Size = size;
		this.UcCBViveCon.TabIndex = 7;
		this.Label9.AutoSize = true;
		System.Windows.Forms.Label label49 = this.Label9;
		location = new System.Drawing.Point(241, 49);
		label49.Location = location;
		this.Label9.Name = "Label9";
		System.Windows.Forms.Label label50 = this.Label9;
		size = new System.Drawing.Size(33, 13);
		label50.Size = size;
		this.Label9.TabIndex = 0;
		this.Label9.Text = "Hijos:";
		this.UcTxtNumHijos.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumHijos.Formato = null;
		this.UcTxtNumHijos.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumHijos = this.UcTxtNumHijos;
		location = new System.Drawing.Point(298, 46);
		ucTxtNumHijos.Location = location;
		this.UcTxtNumHijos.MaxLength = 2;
		this.UcTxtNumHijos.Name = "UcTxtNumHijos";
		this.UcTxtNumHijos.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumHijos.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumHijos.OnErrorBlankText = "";
		this.UcTxtNumHijos.PadLeftLenght = 0;
		this.UcTxtNumHijos.RegularExpression = "^[0-9]*$";
		this.UcTxtNumHijos.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumHijos.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumHijos2 = this.UcTxtNumHijos;
		size = new System.Drawing.Size(96, 20);
		ucTxtNumHijos2.Size = size;
		this.UcTxtNumHijos.TabIndex = 10;
		this.UcTxtNumHijos.TabNextControl = false;
		this.UcTxtNumHijos.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtObsFam.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtObsFam.Formato = null;
		this.UcTxtObsFam.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtObsFam = this.UcTxtObsFam;
		location = new System.Drawing.Point(99, 320);
		ucTxtObsFam.Location = location;
		this.UcTxtObsFam.MaxLength = 1000;
		this.UcTxtObsFam.Multiline = true;
		this.UcTxtObsFam.Name = "UcTxtObsFam";
		this.UcTxtObsFam.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtObsFam.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtObsFam.OnErrorBlankText = "";
		this.UcTxtObsFam.PadLeftLenght = 0;
		this.UcTxtObsFam.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtObsFam.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtObsFam.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtObsFam2 = this.UcTxtObsFam;
		size = new System.Drawing.Size(598, 59);
		ucTxtObsFam2.Size = size;
		this.UcTxtObsFam.TabIndex = 22;
		this.UcTxtObsFam.TabNextControl = false;
		this.UcTxtObsFam.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.UcTxtCargaFam.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtCargaFam.Formato = null;
		this.UcTxtCargaFam.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtCargaFam = this.UcTxtCargaFam;
		location = new System.Drawing.Point(132, 46);
		ucTxtCargaFam.Location = location;
		this.UcTxtCargaFam.MaxLength = 2;
		this.UcTxtCargaFam.Name = "UcTxtCargaFam";
		this.UcTxtCargaFam.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtCargaFam.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtCargaFam.OnErrorBlankText = "";
		this.UcTxtCargaFam.PadLeftLenght = 0;
		this.UcTxtCargaFam.RegularExpression = "^[0-9]*$";
		this.UcTxtCargaFam.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtCargaFam.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtCargaFam2 = this.UcTxtCargaFam;
		size = new System.Drawing.Size(97, 20);
		ucTxtCargaFam2.Size = size;
		this.UcTxtCargaFam.TabIndex = 9;
		this.UcTxtCargaFam.TabNextControl = false;
		this.UcTxtCargaFam.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.Label11.AutoSize = true;
		System.Windows.Forms.Label label51 = this.Label11;
		location = new System.Drawing.Point(276, 49);
		label51.Location = location;
		this.Label11.Name = "Label11";
		System.Windows.Forms.Label label52 = this.Label11;
		size = new System.Drawing.Size(22, 13);
		label52.Size = size;
		this.Label11.TabIndex = 0;
		this.Label11.Text = "Nº:";
		this.Label10.AutoSize = true;
		System.Windows.Forms.Label label53 = this.Label10;
		location = new System.Drawing.Point(110, 49);
		label53.Location = location;
		this.Label10.Name = "Label10";
		System.Windows.Forms.Label label54 = this.Label10;
		size = new System.Drawing.Size(22, 13);
		label54.Size = size;
		this.Label10.TabIndex = 0;
		this.Label10.Text = "Nº:";
		this.Label8.AutoSize = true;
		System.Windows.Forms.Label label55 = this.Label8;
		location = new System.Drawing.Point(32, 49);
		label55.Location = location;
		this.Label8.Name = "Label8";
		System.Windows.Forms.Label label56 = this.Label8;
		size = new System.Drawing.Size(76, 13);
		label56.Size = size;
		this.Label8.TabIndex = 0;
		this.Label8.Text = "Carga Familiar:";
		this.Label7.AutoSize = true;
		System.Windows.Forms.Label label57 = this.Label7;
		location = new System.Drawing.Point(317, 22);
		label57.Location = location;
		this.Label7.Name = "Label7";
		System.Windows.Forms.Label label58 = this.Label7;
		size = new System.Drawing.Size(92, 13);
		label58.Size = size;
		this.Label7.TabIndex = 0;
		this.Label7.Text = "Es Jefe de Hogar:";
		this.Label12.AutoSize = true;
		System.Windows.Forms.Label label59 = this.Label12;
		location = new System.Drawing.Point(12, 323);
		label59.Location = location;
		this.Label12.Name = "Label12";
		System.Windows.Forms.Label label60 = this.Label12;
		size = new System.Drawing.Size(81, 13);
		label60.Size = size;
		this.Label12.TabIndex = 0;
		this.Label12.Text = "Observaciones:";
		this.Label6.AutoSize = true;
		System.Windows.Forms.Label label61 = this.Label6;
		location = new System.Drawing.Point(12, 22);
		label61.Location = location;
		this.Label6.Name = "Label6";
		System.Windows.Forms.Label label62 = this.Label6;
		size = new System.Drawing.Size(114, 13);
		label62.Size = size;
		this.Label6.TabIndex = 0;
		this.Label6.Text = "Vive Actualmente con:";
		this.XtraTabPage12.AutoScroll = true;
		this.XtraTabPage12.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage12.Controls.Add(this.GroupControl21);
		this.XtraTabPage12.Controls.Add(this.GroupControl20);
		this.XtraTabPage12.Name = "XtraTabPage12";
		DevExpress.XtraTab.XtraTabPage xtraTabPage6 = this.XtraTabPage12;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage6.Size = size;
		this.XtraTabPage12.Text = "Aspecto Familiar";
		this.GroupControl21.Controls.Add(this.GroupControl24);
		this.GroupControl21.Controls.Add(this.GroupControl25);
		this.GroupControl21.Controls.Add(this.GroupControl23);
		this.GroupControl21.Controls.Add(this.GroupControl22);
		DevExpress.XtraEditors.GroupControl groupControl27 = this.GroupControl21;
		location = new System.Drawing.Point(3, 120);
		groupControl27.Location = location;
		this.GroupControl21.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl21.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl21.Name = "GroupControl21";
		DevExpress.XtraEditors.GroupControl groupControl28 = this.GroupControl21;
		size = new System.Drawing.Size(600, 221);
		groupControl28.Size = size;
		this.GroupControl21.TabIndex = 27;
		this.GroupControl21.Text = "Funcionamiento Familiar";
		this.GroupControl24.Controls.Add(this.Label87);
		this.GroupControl24.Controls.Add(this.UcCmbResp8);
		this.GroupControl24.Controls.Add(this.UcCmbResp9);
		this.GroupControl24.Controls.Add(this.Label88);
		this.GroupControl24.Controls.Add(this.Label86);
		DevExpress.XtraEditors.GroupControl groupControl29 = this.GroupControl24;
		location = new System.Drawing.Point(299, 107);
		groupControl29.Location = location;
		this.GroupControl24.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl24.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl24.Name = "GroupControl24";
		DevExpress.XtraEditors.GroupControl groupControl30 = this.GroupControl24;
		size = new System.Drawing.Size(296, 104);
		groupControl30.Size = size;
		this.GroupControl24.TabIndex = 0;
		this.GroupControl24.Text = "Toma de Decisiones";
		this.Label87.AutoSize = true;
		System.Windows.Forms.Label label63 = this.Label87;
		location = new System.Drawing.Point(61, 80);
		label63.Location = location;
		this.Label87.Name = "Label87";
		System.Windows.Forms.Label label64 = this.Label87;
		size = new System.Drawing.Size(173, 13);
		label64.Size = size;
		this.Label87.TabIndex = 0;
		this.Label87.Text = "Solo los padres buscan la solución:";
		this.UcCmbResp8.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp8.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp8.FormattingEnabled = true;
		this.UcCmbResp8.IncluirNinguno = false;
		this.UcCmbResp8.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp = this.UcCmbResp8;
		location = new System.Drawing.Point(240, 50);
		ucCmbResp.Location = location;
		this.UcCmbResp8.Name = "UcCmbResp8";
		GRLL.Common.ucComboBox ucCmbResp2 = this.UcCmbResp8;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp2.Size = size;
		this.UcCmbResp8.TabIndex = 1;
		this.UcCmbResp9.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp9.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp9.FormattingEnabled = true;
		this.UcCmbResp9.IncluirNinguno = false;
		this.UcCmbResp9.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp3 = this.UcCmbResp9;
		location = new System.Drawing.Point(240, 77);
		ucCmbResp3.Location = location;
		this.UcCmbResp9.Name = "UcCmbResp9";
		GRLL.Common.ucComboBox ucCmbResp4 = this.UcCmbResp9;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp4.Size = size;
		this.UcCmbResp9.TabIndex = 1;
		this.Label88.AutoSize = true;
		System.Windows.Forms.Label label65 = this.Label88;
		location = new System.Drawing.Point(5, 26);
		label65.Location = location;
		this.Label88.Name = "Label88";
		System.Windows.Forms.Label label66 = this.Label88;
		size = new System.Drawing.Size(94, 13);
		label66.Size = size;
		this.Label88.TabIndex = 0;
		this.Label88.Text = "Ante un Problema:";
		this.Label86.AutoSize = true;
		System.Windows.Forms.Label label67 = this.Label86;
		location = new System.Drawing.Point(77, 53);
		label67.Location = location;
		this.Label86.Name = "Label86";
		System.Windows.Forms.Label label68 = this.Label86;
		size = new System.Drawing.Size(157, 13);
		label68.Size = size;
		this.Label86.TabIndex = 0;
		this.Label86.Text = "Todos participan en la solución:";
		this.GroupControl25.Controls.Add(this.Label85);
		this.GroupControl25.Controls.Add(this.Label84);
		this.GroupControl25.Controls.Add(this.UcCmbResp5);
		this.GroupControl25.Controls.Add(this.UcCmbResp7);
		this.GroupControl25.Controls.Add(this.UcCmbResp6);
		this.GroupControl25.Controls.Add(this.Label83);
		DevExpress.XtraEditors.GroupControl groupControl31 = this.GroupControl25;
		location = new System.Drawing.Point(5, 107);
		groupControl31.Location = location;
		this.GroupControl25.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl25.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl25.Name = "GroupControl25";
		DevExpress.XtraEditors.GroupControl groupControl32 = this.GroupControl25;
		size = new System.Drawing.Size(286, 104);
		groupControl32.Size = size;
		this.GroupControl25.TabIndex = 0;
		this.GroupControl25.Text = "Socialización";
		this.Label85.AutoSize = true;
		System.Windows.Forms.Label label69 = this.Label85;
		location = new System.Drawing.Point(31, 80);
		label69.Location = location;
		this.Label85.Name = "Label85";
		System.Windows.Forms.Label label70 = this.Label85;
		size = new System.Drawing.Size(197, 13);
		label70.Size = size;
		this.Label85.TabIndex = 0;
		this.Label85.Text = "Buena relaciones con amigos y vecinos:";
		this.Label84.AutoSize = true;
		System.Windows.Forms.Label label71 = this.Label84;
		location = new System.Drawing.Point(18, 53);
		label71.Location = location;
		this.Label84.Name = "Label84";
		System.Windows.Forms.Label label72 = this.Label84;
		size = new System.Drawing.Size(210, 13);
		label72.Size = size;
		this.Label84.TabIndex = 0;
		this.Label84.Text = "Realizan sus propias actividades familiares:";
		this.UcCmbResp5.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp5.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp5.FormattingEnabled = true;
		this.UcCmbResp5.IncluirNinguno = false;
		this.UcCmbResp5.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp5 = this.UcCmbResp5;
		location = new System.Drawing.Point(234, 23);
		ucCmbResp5.Location = location;
		this.UcCmbResp5.Name = "UcCmbResp5";
		GRLL.Common.ucComboBox ucCmbResp6 = this.UcCmbResp5;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp6.Size = size;
		this.UcCmbResp5.TabIndex = 1;
		this.UcCmbResp7.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp7.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp7.FormattingEnabled = true;
		this.UcCmbResp7.IncluirNinguno = false;
		this.UcCmbResp7.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp7 = this.UcCmbResp7;
		location = new System.Drawing.Point(233, 77);
		ucCmbResp7.Location = location;
		this.UcCmbResp7.Name = "UcCmbResp7";
		GRLL.Common.ucComboBox ucCmbResp8 = this.UcCmbResp7;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp8.Size = size;
		this.UcCmbResp7.TabIndex = 1;
		this.UcCmbResp6.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp6.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp6.FormattingEnabled = true;
		this.UcCmbResp6.IncluirNinguno = false;
		this.UcCmbResp6.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp9 = this.UcCmbResp6;
		location = new System.Drawing.Point(234, 50);
		ucCmbResp9.Location = location;
		this.UcCmbResp6.Name = "UcCmbResp6";
		GRLL.Common.ucComboBox ucCmbResp10 = this.UcCmbResp6;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp10.Size = size;
		this.UcCmbResp6.TabIndex = 1;
		this.Label83.AutoSize = true;
		System.Windows.Forms.Label label73 = this.Label83;
		location = new System.Drawing.Point(5, 26);
		label73.Location = location;
		this.Label83.Name = "Label83";
		System.Windows.Forms.Label label74 = this.Label83;
		size = new System.Drawing.Size(223, 13);
		label74.Size = size;
		this.Label83.TabIndex = 0;
		this.Label83.Text = "Participan de Clubs, Juntas Vecinales y Otros:";
		this.GroupControl23.Controls.Add(this.Label82);
		this.GroupControl23.Controls.Add(this.UcCmbResp3);
		this.GroupControl23.Controls.Add(this.Label81);
		this.GroupControl23.Controls.Add(this.UcCmbResp4);
		DevExpress.XtraEditors.GroupControl groupControl33 = this.GroupControl23;
		location = new System.Drawing.Point(299, 23);
		groupControl33.Location = location;
		this.GroupControl23.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl23.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl23.Name = "GroupControl23";
		DevExpress.XtraEditors.GroupControl groupControl34 = this.GroupControl23;
		size = new System.Drawing.Size(296, 78);
		groupControl34.Size = size;
		this.GroupControl23.TabIndex = 0;
		this.GroupControl23.Text = "Afectividad";
		this.Label82.AutoSize = true;
		System.Windows.Forms.Label label75 = this.Label82;
		location = new System.Drawing.Point(87, 53);
		label75.Location = location;
		this.Label82.Name = "Label82";
		System.Windows.Forms.Label label76 = this.Label82;
		size = new System.Drawing.Size(147, 13);
		label76.Size = size;
		this.Label82.TabIndex = 0;
		this.Label82.Text = "Se aceptan y toleran entre sí:";
		this.UcCmbResp3.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp3.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp3.FormattingEnabled = true;
		this.UcCmbResp3.IncluirNinguno = false;
		this.UcCmbResp3.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp11 = this.UcCmbResp3;
		location = new System.Drawing.Point(240, 23);
		ucCmbResp11.Location = location;
		this.UcCmbResp3.Name = "UcCmbResp3";
		GRLL.Common.ucComboBox ucCmbResp12 = this.UcCmbResp3;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp12.Size = size;
		this.UcCmbResp3.TabIndex = 1;
		this.Label81.AutoSize = true;
		System.Windows.Forms.Label label77 = this.Label81;
		location = new System.Drawing.Point(5, 26);
		label77.Location = location;
		this.Label81.Name = "Label81";
		System.Windows.Forms.Label label78 = this.Label81;
		size = new System.Drawing.Size(229, 13);
		label78.Size = size;
		this.Label81.TabIndex = 0;
		this.Label81.Text = "Se brindan abrazos, besos, palabras cariñosas:";
		this.UcCmbResp4.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp4.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp4.FormattingEnabled = true;
		this.UcCmbResp4.IncluirNinguno = false;
		this.UcCmbResp4.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp13 = this.UcCmbResp4;
		location = new System.Drawing.Point(240, 50);
		ucCmbResp13.Location = location;
		this.UcCmbResp4.Name = "UcCmbResp4";
		GRLL.Common.ucComboBox ucCmbResp14 = this.UcCmbResp4;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp14.Size = size;
		this.UcCmbResp4.TabIndex = 1;
		this.GroupControl22.Controls.Add(this.Label80);
		this.GroupControl22.Controls.Add(this.Label79);
		this.GroupControl22.Controls.Add(this.UcCmbResp2);
		this.GroupControl22.Controls.Add(this.UcCmbResp1);
		DevExpress.XtraEditors.GroupControl groupControl35 = this.GroupControl22;
		location = new System.Drawing.Point(5, 23);
		groupControl35.Location = location;
		this.GroupControl22.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl22.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl22.Name = "GroupControl22";
		DevExpress.XtraEditors.GroupControl groupControl36 = this.GroupControl22;
		size = new System.Drawing.Size(286, 78);
		groupControl36.Size = size;
		this.GroupControl22.TabIndex = 0;
		this.GroupControl22.Text = "Comunicación";
		this.Label80.AutoSize = true;
		System.Windows.Forms.Label label79 = this.Label80;
		location = new System.Drawing.Point(82, 53);
		label79.Location = location;
		this.Label80.Name = "Label80";
		System.Windows.Forms.Label label80 = this.Label80;
		size = new System.Drawing.Size(146, 13);
		label80.Size = size;
		this.Label80.TabIndex = 0;
		this.Label80.Text = "Solo cuando hay dificultades:";
		this.Label79.AutoSize = true;
		System.Windows.Forms.Label label81 = this.Label79;
		location = new System.Drawing.Point(61, 26);
		label81.Location = location;
		this.Label79.Name = "Label79";
		System.Windows.Forms.Label label82 = this.Label79;
		size = new System.Drawing.Size(167, 13);
		label82.Size = size;
		this.Label79.TabIndex = 0;
		this.Label79.Text = "Es verbal, fluida y abierta siempre:";
		this.UcCmbResp2.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp2.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp2.FormattingEnabled = true;
		this.UcCmbResp2.IncluirNinguno = false;
		this.UcCmbResp2.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp15 = this.UcCmbResp2;
		location = new System.Drawing.Point(234, 50);
		ucCmbResp15.Location = location;
		this.UcCmbResp2.Name = "UcCmbResp2";
		GRLL.Common.ucComboBox ucCmbResp16 = this.UcCmbResp2;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp16.Size = size;
		this.UcCmbResp2.TabIndex = 1;
		this.UcCmbResp1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbResp1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbResp1.FormattingEnabled = true;
		this.UcCmbResp1.IncluirNinguno = false;
		this.UcCmbResp1.Items.AddRange(new object[4] { "---", "N", "AV", "CS" });
		GRLL.Common.ucComboBox ucCmbResp17 = this.UcCmbResp1;
		location = new System.Drawing.Point(234, 23);
		ucCmbResp17.Location = location;
		this.UcCmbResp1.Name = "UcCmbResp1";
		GRLL.Common.ucComboBox ucCmbResp18 = this.UcCmbResp1;
		size = new System.Drawing.Size(48, 21);
		ucCmbResp18.Size = size;
		this.UcCmbResp1.TabIndex = 1;
		this.GroupControl20.Controls.Add(this.UcCmbRelHerm);
		this.GroupControl20.Controls.Add(this.UcCmbRelPH);
		this.GroupControl20.Controls.Add(this.UcCmbRelPareja);
		this.GroupControl20.Controls.Add(this.UcCmbTipoFam);
		this.GroupControl20.Controls.Add(this.Label78);
		this.GroupControl20.Controls.Add(this.Label77);
		this.GroupControl20.Controls.Add(this.Label76);
		this.GroupControl20.Controls.Add(this.Label75);
		DevExpress.XtraEditors.GroupControl groupControl37 = this.GroupControl20;
		location = new System.Drawing.Point(3, 18);
		groupControl37.Location = location;
		this.GroupControl20.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl20.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl20.Name = "GroupControl20";
		DevExpress.XtraEditors.GroupControl groupControl38 = this.GroupControl20;
		size = new System.Drawing.Size(600, 87);
		groupControl38.Size = size;
		this.GroupControl20.TabIndex = 26;
		this.GroupControl20.Text = "Dinámica Familiar";
		this.UcCmbRelHerm.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbRelHerm.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbRelHerm.FormattingEnabled = true;
		this.UcCmbRelHerm.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbRelHerm = this.UcCmbRelHerm;
		location = new System.Drawing.Point(423, 54);
		ucCmbRelHerm.Location = location;
		this.UcCmbRelHerm.Name = "UcCmbRelHerm";
		GRLL.Common.ucComboBox ucCmbRelHerm2 = this.UcCmbRelHerm;
		size = new System.Drawing.Size(156, 21);
		ucCmbRelHerm2.Size = size;
		this.UcCmbRelHerm.TabIndex = 1;
		this.UcCmbRelPH.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbRelPH.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbRelPH.FormattingEnabled = true;
		this.UcCmbRelPH.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbRelPH = this.UcCmbRelPH;
		location = new System.Drawing.Point(423, 27);
		ucCmbRelPH.Location = location;
		this.UcCmbRelPH.Name = "UcCmbRelPH";
		GRLL.Common.ucComboBox ucCmbRelPH2 = this.UcCmbRelPH;
		size = new System.Drawing.Size(156, 21);
		ucCmbRelPH2.Size = size;
		this.UcCmbRelPH.TabIndex = 1;
		this.UcCmbRelPareja.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbRelPareja.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbRelPareja.FormattingEnabled = true;
		this.UcCmbRelPareja.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbRelPareja = this.UcCmbRelPareja;
		location = new System.Drawing.Point(110, 54);
		ucCmbRelPareja.Location = location;
		this.UcCmbRelPareja.Name = "UcCmbRelPareja";
		GRLL.Common.ucComboBox ucCmbRelPareja2 = this.UcCmbRelPareja;
		size = new System.Drawing.Size(156, 21);
		ucCmbRelPareja2.Size = size;
		this.UcCmbRelPareja.TabIndex = 1;
		this.UcCmbTipoFam.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbTipoFam.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbTipoFam.FormattingEnabled = true;
		this.UcCmbTipoFam.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbTipoFam = this.UcCmbTipoFam;
		location = new System.Drawing.Point(110, 27);
		ucCmbTipoFam.Location = location;
		this.UcCmbTipoFam.Name = "UcCmbTipoFam";
		GRLL.Common.ucComboBox ucCmbTipoFam2 = this.UcCmbTipoFam;
		size = new System.Drawing.Size(156, 21);
		ucCmbTipoFam2.Size = size;
		this.UcCmbTipoFam.TabIndex = 1;
		this.Label78.AutoSize = true;
		System.Windows.Forms.Label label83 = this.Label78;
		location = new System.Drawing.Point(286, 57);
		label83.Location = location;
		this.Label78.Name = "Label78";
		System.Windows.Forms.Label label84 = this.Label78;
		size = new System.Drawing.Size(131, 13);
		label84.Size = size;
		this.Label78.TabIndex = 0;
		this.Label78.Text = "Relación Entre Hermanos:";
		this.Label77.AutoSize = true;
		System.Windows.Forms.Label label85 = this.Label77;
		location = new System.Drawing.Point(297, 30);
		label85.Location = location;
		this.Label77.Name = "Label77";
		System.Windows.Forms.Label label86 = this.Label77;
		size = new System.Drawing.Size(120, 13);
		label86.Size = size;
		this.Label77.TabIndex = 0;
		this.Label77.Text = "Relación Padres - Hijos:";
		this.Label76.AutoSize = true;
		System.Windows.Forms.Label label87 = this.Label76;
		location = new System.Drawing.Point(4, 57);
		label87.Location = location;
		this.Label76.Name = "Label76";
		System.Windows.Forms.Label label88 = this.Label76;
		size = new System.Drawing.Size(100, 13);
		label88.Size = size;
		this.Label76.TabIndex = 0;
		this.Label76.Text = "Relación de Pareja:";
		this.Label75.AutoSize = true;
		System.Windows.Forms.Label label89 = this.Label75;
		location = new System.Drawing.Point(23, 30);
		label89.Location = location;
		this.Label75.Name = "Label75";
		System.Windows.Forms.Label label90 = this.Label75;
		size = new System.Drawing.Size(81, 13);
		label90.Size = size;
		this.Label75.TabIndex = 0;
		this.Label75.Text = "Tipo de Familia:";
		this.XtraTabPage4.AutoScroll = true;
		this.XtraTabPage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage4.Controls.Add(this.GroupBox1);
		this.XtraTabPage4.Controls.Add(this.Label74);
		this.XtraTabPage4.Controls.Add(this.GroupControl9);
		this.XtraTabPage4.Controls.Add(this.UcTxtObsVivienda);
		this.XtraTabPage4.Controls.Add(this.GroupControl5);
		this.XtraTabPage4.Controls.Add(this.GroupControl4);
		this.XtraTabPage4.Controls.Add(this.GroupControl3);
		this.XtraTabPage4.Controls.Add(this.GroupControl2);
		this.XtraTabPage4.Controls.Add(this.GroupControl1);
		this.XtraTabPage4.Name = "XtraTabPage4";
		DevExpress.XtraTab.XtraTabPage xtraTabPage7 = this.XtraTabPage4;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage7.Size = size;
		this.XtraTabPage4.Text = "Aspecto Vivienda";
		this.GroupBox1.Controls.Add(this.GroupControl27);
		this.GroupBox1.Controls.Add(this.GroupControl6);
		this.GroupBox1.Controls.Add(this.GroupControl7);
		this.GroupBox1.Controls.Add(this.GroupControl8);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
		location = new System.Drawing.Point(14, 122);
		groupBox.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
		size = new System.Drawing.Size(488, 183);
		groupBox2.Size = size;
		this.GroupBox1.TabIndex = 18;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Servicios";
		this.GroupControl27.Controls.Add(this.ChckFono);
		this.GroupControl27.Controls.Add(this.ChckOtros);
		this.GroupControl27.Controls.Add(this.ChckCable);
		this.GroupControl27.Controls.Add(this.ChckInter);
		DevExpress.XtraEditors.GroupControl groupControl39 = this.GroupControl27;
		location = new System.Drawing.Point(244, 101);
		groupControl39.Location = location;
		this.GroupControl27.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl27.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl27.Name = "GroupControl27";
		DevExpress.XtraEditors.GroupControl groupControl40 = this.GroupControl27;
		size = new System.Drawing.Size(232, 76);
		groupControl40.Size = size;
		this.GroupControl27.TabIndex = 17;
		this.GroupControl27.Text = "Comunicación";
		DevExpress.XtraEditors.CheckEdit chckFono = this.ChckFono;
		location = new System.Drawing.Point(8, 23);
		chckFono.Location = location;
		this.ChckFono.Name = "ChckFono";
		this.ChckFono.Properties.Caption = "Teléfono";
		this.ChckFono.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
		DevExpress.XtraEditors.CheckEdit chckFono2 = this.ChckFono;
		size = new System.Drawing.Size(75, 22);
		chckFono2.Size = size;
		this.ChckFono.TabIndex = 16;
		DevExpress.XtraEditors.CheckEdit chckOtros = this.ChckOtros;
		location = new System.Drawing.Point(145, 49);
		chckOtros.Location = location;
		this.ChckOtros.Name = "ChckOtros";
		this.ChckOtros.Properties.Caption = "Otros";
		this.ChckOtros.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
		DevExpress.XtraEditors.CheckEdit chckOtros2 = this.ChckOtros;
		size = new System.Drawing.Size(75, 22);
		chckOtros2.Size = size;
		this.ChckOtros.TabIndex = 16;
		DevExpress.XtraEditors.CheckEdit chckCable = this.ChckCable;
		location = new System.Drawing.Point(145, 21);
		chckCable.Location = location;
		this.ChckCable.Name = "ChckCable";
		this.ChckCable.Properties.Caption = "Cable";
		this.ChckCable.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
		DevExpress.XtraEditors.CheckEdit chckCable2 = this.ChckCable;
		size = new System.Drawing.Size(75, 22);
		chckCable2.Size = size;
		this.ChckCable.TabIndex = 16;
		DevExpress.XtraEditors.CheckEdit chckInter = this.ChckInter;
		location = new System.Drawing.Point(8, 49);
		chckInter.Location = location;
		this.ChckInter.Name = "ChckInter";
		this.ChckInter.Properties.Caption = "Internet";
		this.ChckInter.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
		DevExpress.XtraEditors.CheckEdit chckInter2 = this.ChckInter;
		size = new System.Drawing.Size(75, 22);
		chckInter2.Size = size;
		this.ChckInter.TabIndex = 16;
		this.GroupControl6.Controls.Add(this.UcTxtOtroAlumbrado);
		this.GroupControl6.Controls.Add(this.UcCBAlumbrado);
		DevExpress.XtraEditors.GroupControl groupControl41 = this.GroupControl6;
		location = new System.Drawing.Point(6, 101);
		groupControl41.Location = location;
		this.GroupControl6.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl6.Name = "GroupControl6";
		DevExpress.XtraEditors.GroupControl groupControl42 = this.GroupControl6;
		size = new System.Drawing.Size(232, 76);
		groupControl42.Size = size;
		this.GroupControl6.TabIndex = 12;
		this.GroupControl6.Text = "Alumbrado";
		this.UcTxtOtroAlumbrado.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtOtroAlumbrado.Formato = null;
		this.UcTxtOtroAlumbrado.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtOtroAlumbrado = this.UcTxtOtroAlumbrado;
		location = new System.Drawing.Point(5, 48);
		ucTxtOtroAlumbrado.Location = location;
		this.UcTxtOtroAlumbrado.Name = "UcTxtOtroAlumbrado";
		this.UcTxtOtroAlumbrado.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtOtroAlumbrado.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtOtroAlumbrado.OnErrorBlankText = "";
		this.UcTxtOtroAlumbrado.PadLeftLenght = 0;
		this.UcTxtOtroAlumbrado.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtOtroAlumbrado.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtOtroAlumbrado.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtOtroAlumbrado2 = this.UcTxtOtroAlumbrado;
		size = new System.Drawing.Size(222, 20);
		ucTxtOtroAlumbrado2.Size = size;
		this.UcTxtOtroAlumbrado.TabIndex = 13;
		this.UcTxtOtroAlumbrado.TabNextControl = false;
		this.UcTxtOtroAlumbrado.Text = "ESPECIFICAR OTRO TIPO";
		this.UcTxtOtroAlumbrado.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.UcTxtOtroAlumbrado.Visible = false;
		this.UcCBAlumbrado.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBAlumbrado.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBAlumbrado.FormattingEnabled = true;
		this.UcCBAlumbrado.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBAlumbrado = this.UcCBAlumbrado;
		location = new System.Drawing.Point(5, 23);
		ucCBAlumbrado.Location = location;
		this.UcCBAlumbrado.Name = "UcCBAlumbrado";
		GRLL.Common.ucComboBox ucCBAlumbrado2 = this.UcCBAlumbrado;
		size = new System.Drawing.Size(222, 21);
		ucCBAlumbrado2.Size = size;
		this.UcCBAlumbrado.TabIndex = 12;
		this.GroupControl7.Controls.Add(this.UcTxtOtroAgua);
		this.GroupControl7.Controls.Add(this.UcCBAgua);
		DevExpress.XtraEditors.GroupControl groupControl43 = this.GroupControl7;
		location = new System.Drawing.Point(6, 19);
		groupControl43.Location = location;
		this.GroupControl7.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl7.Name = "GroupControl7";
		DevExpress.XtraEditors.GroupControl groupControl44 = this.GroupControl7;
		size = new System.Drawing.Size(232, 76);
		groupControl44.Size = size;
		this.GroupControl7.TabIndex = 13;
		this.GroupControl7.Text = "Abastecimiento de Agua";
		this.UcTxtOtroAgua.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtOtroAgua.Formato = null;
		this.UcTxtOtroAgua.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtOtroAgua = this.UcTxtOtroAgua;
		location = new System.Drawing.Point(7, 50);
		ucTxtOtroAgua.Location = location;
		this.UcTxtOtroAgua.Name = "UcTxtOtroAgua";
		this.UcTxtOtroAgua.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtOtroAgua.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtOtroAgua.OnErrorBlankText = "";
		this.UcTxtOtroAgua.PadLeftLenght = 0;
		this.UcTxtOtroAgua.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtOtroAgua.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtOtroAgua.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtOtroAgua2 = this.UcTxtOtroAgua;
		size = new System.Drawing.Size(220, 20);
		ucTxtOtroAgua2.Size = size;
		this.UcTxtOtroAgua.TabIndex = 19;
		this.UcTxtOtroAgua.TabNextControl = false;
		this.UcTxtOtroAgua.Text = "ESPECIFICAR OTRO TIPO";
		this.UcTxtOtroAgua.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.UcTxtOtroAgua.Visible = false;
		this.UcCBAgua.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBAgua.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBAgua.FormattingEnabled = true;
		this.UcCBAgua.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBAgua = this.UcCBAgua;
		location = new System.Drawing.Point(7, 23);
		ucCBAgua.Location = location;
		this.UcCBAgua.Name = "UcCBAgua";
		GRLL.Common.ucComboBox ucCBAgua2 = this.UcCBAgua;
		size = new System.Drawing.Size(220, 21);
		ucCBAgua2.Size = size;
		this.UcCBAgua.TabIndex = 18;
		this.GroupControl8.Controls.Add(this.UcTxtOtroExcreta);
		this.GroupControl8.Controls.Add(this.UcCBExcretas);
		DevExpress.XtraEditors.GroupControl groupControl45 = this.GroupControl8;
		location = new System.Drawing.Point(244, 19);
		groupControl45.Location = location;
		this.GroupControl8.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl8.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl8.Name = "GroupControl8";
		DevExpress.XtraEditors.GroupControl groupControl46 = this.GroupControl8;
		size = new System.Drawing.Size(232, 76);
		groupControl46.Size = size;
		this.GroupControl8.TabIndex = 15;
		this.GroupControl8.Text = "Eliminación de Excretas";
		this.UcTxtOtroExcreta.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtOtroExcreta.Formato = null;
		this.UcTxtOtroExcreta.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtOtroExcreta = this.UcTxtOtroExcreta;
		location = new System.Drawing.Point(5, 50);
		ucTxtOtroExcreta.Location = location;
		this.UcTxtOtroExcreta.Name = "UcTxtOtroExcreta";
		this.UcTxtOtroExcreta.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtOtroExcreta.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtOtroExcreta.OnErrorBlankText = "";
		this.UcTxtOtroExcreta.PadLeftLenght = 0;
		this.UcTxtOtroExcreta.RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
		this.UcTxtOtroExcreta.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtOtroExcreta.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtOtroExcreta2 = this.UcTxtOtroExcreta;
		size = new System.Drawing.Size(220, 20);
		ucTxtOtroExcreta2.Size = size;
		this.UcTxtOtroExcreta.TabIndex = 21;
		this.UcTxtOtroExcreta.TabNextControl = false;
		this.UcTxtOtroExcreta.Text = "ESPECIFICAR OTRO TIPO";
		this.UcTxtOtroExcreta.Tipo = GRLL.Common.ucTextBox.TipoDato.LetrasNumeros;
		this.UcTxtOtroExcreta.Visible = false;
		this.UcCBExcretas.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBExcretas.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBExcretas.FormattingEnabled = true;
		this.UcCBExcretas.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBExcretas = this.UcCBExcretas;
		location = new System.Drawing.Point(5, 23);
		ucCBExcretas.Location = location;
		this.UcCBExcretas.Name = "UcCBExcretas";
		GRLL.Common.ucComboBox ucCBExcretas2 = this.UcCBExcretas;
		size = new System.Drawing.Size(220, 21);
		ucCBExcretas2.Size = size;
		this.UcCBExcretas.TabIndex = 20;
		this.Label74.AutoSize = true;
		System.Windows.Forms.Label label91 = this.Label74;
		location = new System.Drawing.Point(16, 397);
		label91.Location = location;
		this.Label74.Name = "Label74";
		System.Windows.Forms.Label label92 = this.Label74;
		size = new System.Drawing.Size(47, 13);
		label92.Size = size;
		this.Label74.TabIndex = 17;
		this.Label74.Text = "Observ.:";
		this.GroupControl9.Controls.Add(this.UcTxtPerxDorm);
		this.GroupControl9.Controls.Add(this.UcTxtServHig);
		this.GroupControl9.Controls.Add(this.UcTxtNumCompart);
		this.GroupControl9.Controls.Add(this.UcTxtNumDormito);
		this.GroupControl9.Controls.Add(this.Label90);
		this.GroupControl9.Controls.Add(this.Label14);
		this.GroupControl9.Controls.Add(this.Label89);
		this.GroupControl9.Controls.Add(this.Label13);
		DevExpress.XtraEditors.GroupControl groupControl47 = this.GroupControl9;
		location = new System.Drawing.Point(14, 311);
		groupControl47.Location = location;
		this.GroupControl9.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl9.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl9.Name = "GroupControl9";
		DevExpress.XtraEditors.GroupControl groupControl48 = this.GroupControl9;
		size = new System.Drawing.Size(589, 70);
		groupControl48.Size = size;
		this.GroupControl9.TabIndex = 14;
		this.GroupControl9.Text = "Distribucion de Ambientes";
		this.UcTxtPerxDorm.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtPerxDorm.Formato = null;
		this.UcTxtPerxDorm.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtPerxDorm = this.UcTxtPerxDorm;
		location = new System.Drawing.Point(417, 46);
		ucTxtPerxDorm.Location = location;
		this.UcTxtPerxDorm.Name = "UcTxtPerxDorm";
		this.UcTxtPerxDorm.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtPerxDorm.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtPerxDorm.OnErrorBlankText = "";
		this.UcTxtPerxDorm.PadLeftLenght = 0;
		this.UcTxtPerxDorm.RegularExpression = "^[0-9]*$";
		this.UcTxtPerxDorm.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtPerxDorm.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtPerxDorm2 = this.UcTxtPerxDorm;
		size = new System.Drawing.Size(111, 20);
		ucTxtPerxDorm2.Size = size;
		this.UcTxtPerxDorm.TabIndex = 17;
		this.UcTxtPerxDorm.TabNextControl = false;
		this.UcTxtPerxDorm.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtServHig.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtServHig.Formato = null;
		this.UcTxtServHig.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtServHig = this.UcTxtServHig;
		location = new System.Drawing.Point(127, 46);
		ucTxtServHig.Location = location;
		this.UcTxtServHig.Name = "UcTxtServHig";
		this.UcTxtServHig.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtServHig.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtServHig.OnErrorBlankText = "";
		this.UcTxtServHig.PadLeftLenght = 0;
		this.UcTxtServHig.RegularExpression = "^[0-9]*$";
		this.UcTxtServHig.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtServHig.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtServHig2 = this.UcTxtServHig;
		size = new System.Drawing.Size(111, 20);
		ucTxtServHig2.Size = size;
		this.UcTxtServHig.TabIndex = 17;
		this.UcTxtServHig.TabNextControl = false;
		this.UcTxtServHig.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtNumCompart.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumCompart.Formato = null;
		this.UcTxtNumCompart.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumCompart = this.UcTxtNumCompart;
		location = new System.Drawing.Point(417, 23);
		ucTxtNumCompart.Location = location;
		this.UcTxtNumCompart.Name = "UcTxtNumCompart";
		this.UcTxtNumCompart.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumCompart.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumCompart.OnErrorBlankText = "";
		this.UcTxtNumCompart.PadLeftLenght = 0;
		this.UcTxtNumCompart.RegularExpression = "^[0-9]*$";
		this.UcTxtNumCompart.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumCompart.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumCompart2 = this.UcTxtNumCompart;
		size = new System.Drawing.Size(111, 20);
		ucTxtNumCompart2.Size = size;
		this.UcTxtNumCompart.TabIndex = 16;
		this.UcTxtNumCompart.TabNextControl = false;
		this.UcTxtNumCompart.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtNumDormito.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumDormito.Formato = null;
		this.UcTxtNumDormito.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumDormito = this.UcTxtNumDormito;
		location = new System.Drawing.Point(127, 23);
		ucTxtNumDormito.Location = location;
		this.UcTxtNumDormito.Name = "UcTxtNumDormito";
		this.UcTxtNumDormito.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumDormito.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumDormito.OnErrorBlankText = "";
		this.UcTxtNumDormito.PadLeftLenght = 0;
		this.UcTxtNumDormito.RegularExpression = "^[0-9]*$";
		this.UcTxtNumDormito.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumDormito.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumDormito2 = this.UcTxtNumDormito;
		size = new System.Drawing.Size(111, 20);
		ucTxtNumDormito2.Size = size;
		this.UcTxtNumDormito.TabIndex = 16;
		this.UcTxtNumDormito.TabNextControl = false;
		this.UcTxtNumDormito.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.Label90.AutoSize = true;
		System.Windows.Forms.Label label93 = this.Label90;
		location = new System.Drawing.Point(296, 49);
		label93.Location = location;
		this.Label90.Name = "Label90";
		System.Windows.Forms.Label label94 = this.Label90;
		size = new System.Drawing.Size(115, 13);
		label94.Size = size;
		this.Label90.TabIndex = 1;
		this.Label90.Text = "Personas por Dorm. Nº";
		this.Label14.AutoSize = true;
		System.Windows.Forms.Label label95 = this.Label14;
		location = new System.Drawing.Point(22, 49);
		label95.Location = location;
		this.Label14.Name = "Label14";
		System.Windows.Forms.Label label96 = this.Label14;
		size = new System.Drawing.Size(99, 13);
		label96.Size = size;
		this.Label14.TabIndex = 1;
		this.Label14.Text = "Serv. Higienicos Nº";
		this.Label89.AutoSize = true;
		System.Windows.Forms.Label label97 = this.Label89;
		location = new System.Drawing.Point(312, 26);
		label97.Location = location;
		this.Label89.Name = "Label89";
		System.Windows.Forms.Label label98 = this.Label89;
		size = new System.Drawing.Size(99, 13);
		label98.Size = size;
		this.Label89.TabIndex = 1;
		this.Label89.Text = "Compartimientos Nº";
		this.Label13.AutoSize = true;
		System.Windows.Forms.Label label99 = this.Label13;
		location = new System.Drawing.Point(47, 26);
		label99.Location = location;
		this.Label13.Name = "Label13";
		System.Windows.Forms.Label label100 = this.Label13;
		size = new System.Drawing.Size(74, 13);
		label100.Size = size;
		this.Label13.TabIndex = 1;
		this.Label13.Text = "Dormitorios Nº";
		this.UcTxtObsVivienda.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtObsVivienda.Formato = null;
		this.UcTxtObsVivienda.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtObsVivienda = this.UcTxtObsVivienda;
		location = new System.Drawing.Point(69, 387);
		ucTxtObsVivienda.Location = location;
		this.UcTxtObsVivienda.Multiline = true;
		this.UcTxtObsVivienda.Name = "UcTxtObsVivienda";
		this.UcTxtObsVivienda.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtObsVivienda.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtObsVivienda.OnErrorBlankText = "";
		this.UcTxtObsVivienda.PadLeftLenght = 0;
		this.UcTxtObsVivienda.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtObsVivienda.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtObsVivienda2 = this.UcTxtObsVivienda;
		size = new System.Drawing.Size(534, 33);
		ucTxtObsVivienda2.Size = size;
		this.UcTxtObsVivienda.TabIndex = 16;
		this.UcTxtObsVivienda.TabNextControl = false;
		this.UcTxtObsVivienda.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.GroupControl5.Controls.Add(this.UcCBUbicacion);
		DevExpress.XtraEditors.GroupControl groupControl49 = this.GroupControl5;
		location = new System.Drawing.Point(207, 72);
		groupControl49.Location = location;
		this.GroupControl5.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl5.Name = "GroupControl5";
		DevExpress.XtraEditors.GroupControl groupControl50 = this.GroupControl5;
		size = new System.Drawing.Size(176, 49);
		groupControl50.Size = size;
		this.GroupControl5.TabIndex = 10;
		this.GroupControl5.Text = "Ubicación";
		this.UcCBUbicacion.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBUbicacion.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBUbicacion.FormattingEnabled = true;
		this.UcCBUbicacion.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBUbicacion = this.UcCBUbicacion;
		location = new System.Drawing.Point(5, 23);
		ucCBUbicacion.Location = location;
		this.UcCBUbicacion.Name = "UcCBUbicacion";
		GRLL.Common.ucComboBox ucCBUbicacion2 = this.UcCBUbicacion;
		size = new System.Drawing.Size(166, 21);
		ucCBUbicacion2.Size = size;
		this.UcCBUbicacion.TabIndex = 9;
		this.GroupControl4.Controls.Add(this.UcCBConservacion);
		DevExpress.XtraEditors.GroupControl groupControl51 = this.GroupControl4;
		location = new System.Drawing.Point(14, 14);
		groupControl51.Location = location;
		this.GroupControl4.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl4.Name = "GroupControl4";
		DevExpress.XtraEditors.GroupControl groupControl52 = this.GroupControl4;
		size = new System.Drawing.Size(176, 49);
		groupControl52.Size = size;
		this.GroupControl4.TabIndex = 11;
		this.GroupControl4.Text = "Estado";
		this.UcCBConservacion.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBConservacion.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBConservacion.FormattingEnabled = true;
		this.UcCBConservacion.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBConservacion = this.UcCBConservacion;
		location = new System.Drawing.Point(5, 23);
		ucCBConservacion.Location = location;
		this.UcCBConservacion.Name = "UcCBConservacion";
		GRLL.Common.ucComboBox ucCBConservacion2 = this.UcCBConservacion;
		size = new System.Drawing.Size(166, 21);
		ucCBConservacion2.Size = size;
		this.UcCBConservacion.TabIndex = 10;
		this.GroupControl3.Controls.Add(this.UcCBMaterial);
		DevExpress.XtraEditors.GroupControl groupControl53 = this.GroupControl3;
		location = new System.Drawing.Point(207, 17);
		groupControl53.Location = location;
		this.GroupControl3.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl3.Name = "GroupControl3";
		DevExpress.XtraEditors.GroupControl groupControl54 = this.GroupControl3;
		size = new System.Drawing.Size(176, 49);
		groupControl54.Size = size;
		this.GroupControl3.TabIndex = 9;
		this.GroupControl3.Text = "Material";
		this.UcCBMaterial.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBMaterial.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBMaterial.FormattingEnabled = true;
		this.UcCBMaterial.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBMaterial = this.UcCBMaterial;
		location = new System.Drawing.Point(5, 23);
		ucCBMaterial.Location = location;
		this.UcCBMaterial.Name = "UcCBMaterial";
		GRLL.Common.ucComboBox ucCBMaterial2 = this.UcCBMaterial;
		size = new System.Drawing.Size(166, 21);
		ucCBMaterial2.Size = size;
		this.UcCBMaterial.TabIndex = 11;
		this.GroupControl2.Controls.Add(this.UcCBTipo);
		DevExpress.XtraEditors.GroupControl groupControl55 = this.GroupControl2;
		location = new System.Drawing.Point(14, 72);
		groupControl55.Location = location;
		this.GroupControl2.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl2.Name = "GroupControl2";
		DevExpress.XtraEditors.GroupControl groupControl56 = this.GroupControl2;
		size = new System.Drawing.Size(176, 50);
		groupControl56.Size = size;
		this.GroupControl2.TabIndex = 8;
		this.GroupControl2.Text = "Tipo";
		this.UcCBTipo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTipo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTipo.FormattingEnabled = true;
		this.UcCBTipo.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTipo = this.UcCBTipo;
		location = new System.Drawing.Point(5, 23);
		ucCBTipo.Location = location;
		this.UcCBTipo.Name = "UcCBTipo";
		GRLL.Common.ucComboBox ucCBTipo2 = this.UcCBTipo;
		size = new System.Drawing.Size(166, 21);
		ucCBTipo2.Size = size;
		this.UcCBTipo.TabIndex = 8;
		this.GroupControl1.Controls.Add(this.UcCBTenencia);
		DevExpress.XtraEditors.GroupControl groupControl57 = this.GroupControl1;
		location = new System.Drawing.Point(401, 14);
		groupControl57.Location = location;
		this.GroupControl1.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl58 = this.GroupControl1;
		size = new System.Drawing.Size(176, 50);
		groupControl58.Size = size;
		this.GroupControl1.TabIndex = 7;
		this.GroupControl1.Text = "Tenencia";
		this.UcCBTenencia.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCBTenencia.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCBTenencia.FormattingEnabled = true;
		this.UcCBTenencia.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCBTenencia = this.UcCBTenencia;
		location = new System.Drawing.Point(5, 23);
		ucCBTenencia.Location = location;
		this.UcCBTenencia.Name = "UcCBTenencia";
		GRLL.Common.ucComboBox ucCBTenencia2 = this.UcCBTenencia;
		size = new System.Drawing.Size(166, 21);
		ucCBTenencia2.Size = size;
		this.UcCBTenencia.TabIndex = 7;
		this.XtraTabPage5.AutoScroll = true;
		this.XtraTabPage5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage5.Controls.Add(this.GroupControl30);
		this.XtraTabPage5.Controls.Add(this.GroupControl29);
		this.XtraTabPage5.Controls.Add(this.GroupControl28);
		this.XtraTabPage5.Controls.Add(this.GroupControl26);
		this.XtraTabPage5.Name = "XtraTabPage5";
		DevExpress.XtraTab.XtraTabPage xtraTabPage8 = this.XtraTabPage5;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage8.Size = size;
		this.XtraTabPage5.Text = "Aspecto de Salud";
		this.GroupControl30.Controls.Add(this.UcCmbAcudeEnf);
		this.GroupControl30.Controls.Add(this.Label63);
		DevExpress.XtraEditors.GroupControl groupControl59 = this.GroupControl30;
		location = new System.Drawing.Point(11, 176);
		groupControl59.Location = location;
		this.GroupControl30.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl30.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl30.Name = "GroupControl30";
		DevExpress.XtraEditors.GroupControl groupControl60 = this.GroupControl30;
		size = new System.Drawing.Size(586, 67);
		groupControl60.Size = size;
		this.GroupControl30.TabIndex = 36;
		this.GroupControl30.Text = "Casos de Enfermedad";
		this.UcCmbAcudeEnf.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbAcudeEnf.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbAcudeEnf.FormattingEnabled = true;
		this.UcCmbAcudeEnf.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbAcudeEnf = this.UcCmbAcudeEnf;
		location = new System.Drawing.Point(218, 28);
		ucCmbAcudeEnf.Location = location;
		this.UcCmbAcudeEnf.Name = "UcCmbAcudeEnf";
		GRLL.Common.ucComboBox ucCmbAcudeEnf2 = this.UcCmbAcudeEnf;
		size = new System.Drawing.Size(177, 21);
		ucCmbAcudeEnf2.Size = size;
		this.UcCmbAcudeEnf.TabIndex = 33;
		this.Label63.AutoSize = true;
		System.Windows.Forms.Label label101 = this.Label63;
		location = new System.Drawing.Point(19, 31);
		label101.Location = location;
		this.Label63.Name = "Label63";
		System.Windows.Forms.Label label102 = this.Label63;
		size = new System.Drawing.Size(192, 13);
		label102.Size = size;
		this.Label63.TabIndex = 30;
		this.Label63.Text = "Donde Acude en caso de Enfermedad:";
		this.GroupControl29.Controls.Add(this.UcTxtAlergico);
		this.GroupControl29.Controls.Add(this.Label64);
		this.GroupControl29.Controls.Add(this.Label65);
		this.GroupControl29.Controls.Add(this.RadioGroup4);
		DevExpress.XtraEditors.GroupControl groupControl61 = this.GroupControl29;
		location = new System.Drawing.Point(11, 249);
		groupControl61.Location = location;
		this.GroupControl29.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl29.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl29.Name = "GroupControl29";
		DevExpress.XtraEditors.GroupControl groupControl62 = this.GroupControl29;
		size = new System.Drawing.Size(586, 73);
		groupControl62.Size = size;
		this.GroupControl29.TabIndex = 35;
		this.GroupControl29.Text = "Alergias";
		this.UcTxtAlergico.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAlergico.Formato = null;
		this.UcTxtAlergico.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAlergico = this.UcTxtAlergico;
		location = new System.Drawing.Point(346, 23);
		ucTxtAlergico.Location = location;
		this.UcTxtAlergico.Multiline = true;
		this.UcTxtAlergico.Name = "UcTxtAlergico";
		this.UcTxtAlergico.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAlergico.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAlergico.OnErrorBlankText = "";
		this.UcTxtAlergico.PadLeftLenght = 0;
		this.UcTxtAlergico.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtAlergico.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAlergico.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAlergico2 = this.UcTxtAlergico;
		size = new System.Drawing.Size(235, 41);
		ucTxtAlergico2.Size = size;
		this.UcTxtAlergico.TabIndex = 32;
		this.UcTxtAlergico.TabNextControl = false;
		this.UcTxtAlergico.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label64.AutoSize = true;
		System.Windows.Forms.Label label103 = this.Label64;
		location = new System.Drawing.Point(22, 26);
		label103.Location = location;
		this.Label64.Name = "Label64";
		System.Windows.Forms.Label label104 = this.Label64;
		size = new System.Drawing.Size(167, 13);
		label104.Size = size;
		this.Label64.TabIndex = 30;
		this.Label64.Text = "Es Alergico a algún medicamento:";
		this.Label65.AutoSize = true;
		System.Windows.Forms.Label label105 = this.Label65;
		location = new System.Drawing.Point(275, 26);
		label105.Location = location;
		this.Label65.Name = "Label65";
		System.Windows.Forms.Label label106 = this.Label65;
		size = new System.Drawing.Size(65, 13);
		label106.Size = size;
		this.Label65.TabIndex = 30;
		this.Label65.Text = "Especifique:";
		DevExpress.XtraEditors.RadioGroup radioGroup3 = this.RadioGroup4;
		location = new System.Drawing.Point(189, 23);
		radioGroup3.Location = location;
		this.RadioGroup4.Name = "RadioGroup4";
		this.RadioGroup4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup4.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroup4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		DevExpress.XtraEditors.RadioGroup radioGroup4 = this.RadioGroup4;
		size = new System.Drawing.Size(82, 24);
		radioGroup4.Size = size;
		this.RadioGroup4.TabIndex = 31;
		this.GroupControl28.Controls.Add(this.UcTxtFamDiscap);
		this.GroupControl28.Controls.Add(this.Label62);
		this.GroupControl28.Controls.Add(this.RadioGroup3);
		this.GroupControl28.Controls.Add(this.Label61);
		DevExpress.XtraEditors.GroupControl groupControl63 = this.GroupControl28;
		location = new System.Drawing.Point(10, 97);
		groupControl63.Location = location;
		this.GroupControl28.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl28.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl28.Name = "GroupControl28";
		DevExpress.XtraEditors.GroupControl groupControl64 = this.GroupControl28;
		size = new System.Drawing.Size(587, 73);
		groupControl64.Size = size;
		this.GroupControl28.TabIndex = 35;
		this.GroupControl28.Text = "Familia con Discapacidad";
		this.UcTxtFamDiscap.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtFamDiscap.Formato = null;
		this.UcTxtFamDiscap.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtFamDiscap = this.UcTxtFamDiscap;
		location = new System.Drawing.Point(347, 23);
		ucTxtFamDiscap.Location = location;
		this.UcTxtFamDiscap.Multiline = true;
		this.UcTxtFamDiscap.Name = "UcTxtFamDiscap";
		this.UcTxtFamDiscap.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtFamDiscap.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtFamDiscap.OnErrorBlankText = "";
		this.UcTxtFamDiscap.PadLeftLenght = 0;
		this.UcTxtFamDiscap.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtFamDiscap.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtFamDiscap.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtFamDiscap2 = this.UcTxtFamDiscap;
		size = new System.Drawing.Size(235, 41);
		ucTxtFamDiscap2.Size = size;
		this.UcTxtFamDiscap.TabIndex = 32;
		this.UcTxtFamDiscap.TabNextControl = false;
		this.UcTxtFamDiscap.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label62.AutoSize = true;
		System.Windows.Forms.Label label107 = this.Label62;
		location = new System.Drawing.Point(287, 26);
		label107.Location = location;
		this.Label62.Name = "Label62";
		System.Windows.Forms.Label label108 = this.Label62;
		size = new System.Drawing.Size(57, 13);
		label108.Size = size;
		this.Label62.TabIndex = 30;
		this.Label62.Text = "Mencione:";
		DevExpress.XtraEditors.RadioGroup radioGroup5 = this.RadioGroup3;
		location = new System.Drawing.Point(190, 23);
		radioGroup5.Location = location;
		this.RadioGroup3.Name = "RadioGroup3";
		this.RadioGroup3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup3.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroup3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		DevExpress.XtraEditors.RadioGroup radioGroup6 = this.RadioGroup3;
		size = new System.Drawing.Size(82, 21);
		radioGroup6.Size = size;
		this.RadioGroup3.TabIndex = 31;
		this.Label61.AutoSize = true;
		System.Windows.Forms.Label label109 = this.Label61;
		location = new System.Drawing.Point(-2, 26);
		label109.Location = location;
		this.Label61.Name = "Label61";
		System.Windows.Forms.Label label110 = this.Label61;
		size = new System.Drawing.Size(194, 13);
		label110.Size = size;
		this.Label61.TabIndex = 30;
		this.Label61.Text = "Miembros de Familia con Discapacidad:";
		this.GroupControl26.Controls.Add(this.UcTxtEnfCronica);
		this.GroupControl26.Controls.Add(this.Label21);
		this.GroupControl26.Controls.Add(this.Label60);
		this.GroupControl26.Controls.Add(this.RadioGroup2);
		DevExpress.XtraEditors.GroupControl groupControl65 = this.GroupControl26;
		location = new System.Drawing.Point(10, 18);
		groupControl65.Location = location;
		this.GroupControl26.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl26.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl26.Name = "GroupControl26";
		DevExpress.XtraEditors.GroupControl groupControl66 = this.GroupControl26;
		size = new System.Drawing.Size(587, 73);
		groupControl66.Size = size;
		this.GroupControl26.TabIndex = 34;
		this.GroupControl26.Text = "Enferm. Crónica";
		this.UcTxtEnfCronica.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEnfCronica.Formato = null;
		this.UcTxtEnfCronica.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEnfCronica = this.UcTxtEnfCronica;
		location = new System.Drawing.Point(347, 23);
		ucTxtEnfCronica.Location = location;
		this.UcTxtEnfCronica.Multiline = true;
		this.UcTxtEnfCronica.Name = "UcTxtEnfCronica";
		this.UcTxtEnfCronica.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEnfCronica.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEnfCronica.OnErrorBlankText = "";
		this.UcTxtEnfCronica.PadLeftLenght = 0;
		this.UcTxtEnfCronica.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtEnfCronica.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEnfCronica.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEnfCronica2 = this.UcTxtEnfCronica;
		size = new System.Drawing.Size(235, 41);
		ucTxtEnfCronica2.Size = size;
		this.UcTxtEnfCronica.TabIndex = 32;
		this.UcTxtEnfCronica.TabNextControl = false;
		this.UcTxtEnfCronica.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.Label21.AutoSize = true;
		System.Windows.Forms.Label label111 = this.Label21;
		location = new System.Drawing.Point(7, 26);
		label111.Location = location;
		this.Label21.Name = "Label21";
		System.Windows.Forms.Label label112 = this.Label21;
		size = new System.Drawing.Size(183, 13);
		label112.Size = size;
		this.Label21.TabIndex = 30;
		this.Label21.Text = "Enfermedad Crónica o Discapacidad:";
		this.Label60.AutoSize = true;
		System.Windows.Forms.Label label113 = this.Label60;
		location = new System.Drawing.Point(287, 26);
		label113.Location = location;
		this.Label60.Name = "Label60";
		System.Windows.Forms.Label label114 = this.Label60;
		size = new System.Drawing.Size(57, 13);
		label114.Size = size;
		this.Label60.TabIndex = 30;
		this.Label60.Text = "Mencione:";
		DevExpress.XtraEditors.RadioGroup radioGroup7 = this.RadioGroup2;
		location = new System.Drawing.Point(190, 23);
		radioGroup7.Location = location;
		this.RadioGroup2.Name = "RadioGroup2";
		this.RadioGroup2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
		this.RadioGroup2.Properties.Appearance.Options.UseBackColor = true;
		this.RadioGroup2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.RadioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
		{
			new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Si"),
			new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "No")
		});
		DevExpress.XtraEditors.RadioGroup radioGroup8 = this.RadioGroup2;
		size = new System.Drawing.Size(82, 18);
		radioGroup8.Size = size;
		this.RadioGroup2.TabIndex = 31;
		this.XtraTabPage3.AutoScroll = true;
		this.XtraTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage3.Controls.Add(this.UcTxtNumPers);
		this.XtraTabPage3.Controls.Add(this.UcTxtIngreMiembroszz);
		this.XtraTabPage3.Controls.Add(this.GroupControl11);
		this.XtraTabPage3.Controls.Add(this.GroupControl10);
		this.XtraTabPage3.Controls.Add(this.Label43);
		this.XtraTabPage3.Controls.Add(this.Label42);
		this.XtraTabPage3.Name = "XtraTabPage3";
		DevExpress.XtraTab.XtraTabPage xtraTabPage9 = this.XtraTabPage3;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage9.Size = size;
		this.XtraTabPage3.Text = "Aspecto Economico";
		this.UcTxtNumPers.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtNumPers.Formato = null;
		this.UcTxtNumPers.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtNumPers = this.UcTxtNumPers;
		location = new System.Drawing.Point(408, 261);
		ucTxtNumPers.Location = location;
		this.UcTxtNumPers.Name = "UcTxtNumPers";
		this.UcTxtNumPers.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtNumPers.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtNumPers.OnErrorBlankText = "";
		this.UcTxtNumPers.PadLeftLenght = 0;
		this.UcTxtNumPers.RegularExpression = "^[0-9]*$";
		this.UcTxtNumPers.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtNumPers.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtNumPers2 = this.UcTxtNumPers;
		size = new System.Drawing.Size(97, 20);
		ucTxtNumPers2.Size = size;
		this.UcTxtNumPers.TabIndex = 24;
		this.UcTxtNumPers.TabNextControl = false;
		this.UcTxtNumPers.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.UcTxtIngreMiembroszz.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtIngreMiembroszz.Formato = null;
		this.UcTxtIngreMiembroszz.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtIngreMiembroszz = this.UcTxtIngreMiembroszz;
		location = new System.Drawing.Point(337, 232);
		ucTxtIngreMiembroszz.Location = location;
		this.UcTxtIngreMiembroszz.Name = "UcTxtIngreMiembroszz";
		this.UcTxtIngreMiembroszz.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtIngreMiembroszz.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtIngreMiembroszz.OnErrorBlankText = "";
		this.UcTxtIngreMiembroszz.PadLeftLenght = 0;
		this.UcTxtIngreMiembroszz.RegularExpression = "^[0-9]*$";
		this.UcTxtIngreMiembroszz.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtIngreMiembroszz.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtIngreMiembroszz2 = this.UcTxtIngreMiembroszz;
		size = new System.Drawing.Size(97, 20);
		ucTxtIngreMiembroszz2.Size = size;
		this.UcTxtIngreMiembroszz.TabIndex = 23;
		this.UcTxtIngreMiembroszz.TabNextControl = false;
		this.UcTxtIngreMiembroszz.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		this.GroupControl11.Controls.Add(this.Label41);
		this.GroupControl11.Controls.Add(this.Label73);
		this.GroupControl11.Controls.Add(this.Label40);
		this.GroupControl11.Controls.Add(this.Label20);
		this.GroupControl11.Controls.Add(this.Label37);
		this.GroupControl11.Controls.Add(this.Label72);
		this.GroupControl11.Controls.Add(this.Label33);
		this.GroupControl11.Controls.Add(this.Label32);
		this.GroupControl11.Controls.Add(this.UcTxtEgreSalud);
		this.GroupControl11.Controls.Add(this.Label39);
		this.GroupControl11.Controls.Add(this.Label38);
		this.GroupControl11.Controls.Add(this.Label36);
		this.GroupControl11.Controls.Add(this.Label35);
		this.GroupControl11.Controls.Add(this.UcTxtEgreOtro);
		this.GroupControl11.Controls.Add(this.UcTxtTransporte);
		this.GroupControl11.Controls.Add(this.Label19);
		this.GroupControl11.Controls.Add(this.UcTxtEgreAliment);
		this.GroupControl11.Controls.Add(this.Label34);
		this.GroupControl11.Controls.Add(this.UcTxtEgreSegPriv);
		this.GroupControl11.Controls.Add(this.UcTxtEgreDeuda);
		this.GroupControl11.Controls.Add(this.UcTxtEnergElec);
		this.GroupControl11.Controls.Add(this.UcTxtEgreFono);
		this.GroupControl11.Controls.Add(this.UcTxtEgreBajaPol);
		this.GroupControl11.Controls.Add(this.UcTxtEgreAgua);
		this.GroupControl11.Controls.Add(this.UcTxtEgreRecrea);
		this.GroupControl11.Controls.Add(this.UcTxtEgreVestido);
		this.GroupControl11.Controls.Add(this.UcTxtEgreEducac);
		this.GroupControl11.Controls.Add(this.UcTxtEgreVivienda);
		DevExpress.XtraEditors.GroupControl groupControl67 = this.GroupControl11;
		location = new System.Drawing.Point(251, 3);
		groupControl67.Location = location;
		this.GroupControl11.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl11.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl11.Name = "GroupControl11";
		DevExpress.XtraEditors.GroupControl groupControl68 = this.GroupControl11;
		size = new System.Drawing.Size(352, 211);
		groupControl68.Size = size;
		this.GroupControl11.TabIndex = 2;
		this.GroupControl11.Text = "Egresos";
		this.Label41.AutoSize = true;
		System.Windows.Forms.Label label115 = this.Label41;
		location = new System.Drawing.Point(224, 186);
		label115.Location = location;
		this.Label41.Name = "Label41";
		System.Windows.Forms.Label label116 = this.Label41;
		size = new System.Drawing.Size(35, 13);
		label116.Size = size;
		this.Label41.TabIndex = 0;
		this.Label41.Text = "Otros:";
		this.Label73.AutoSize = true;
		System.Windows.Forms.Label label117 = this.Label73;
		location = new System.Drawing.Point(9, 160);
		label117.Location = location;
		this.Label73.Name = "Label73";
		System.Windows.Forms.Label label118 = this.Label73;
		size = new System.Drawing.Size(71, 13);
		label118.Size = size;
		this.Label73.TabIndex = 0;
		this.Label73.Text = "Seg. Privado:";
		this.Label40.AutoSize = true;
		System.Windows.Forms.Label label119 = this.Label40;
		location = new System.Drawing.Point(181, 160);
		label119.Location = location;
		this.Label40.Name = "Label40";
		System.Windows.Forms.Label label120 = this.Label40;
		size = new System.Drawing.Size(79, 13);
		label120.Size = size;
		this.Label40.TabIndex = 0;
		this.Label40.Text = "Tarjeta Crédito:";
		this.Label20.AutoSize = true;
		System.Windows.Forms.Label label121 = this.Label20;
		location = new System.Drawing.Point(168, 82);
		label121.Location = location;
		this.Label20.Name = "Label20";
		System.Windows.Forms.Label label122 = this.Label20;
		size = new System.Drawing.Size(92, 13);
		label122.Size = size;
		this.Label20.TabIndex = 0;
		this.Label20.Text = "Energía Eléctrica:";
		this.Label37.AutoSize = true;
		System.Windows.Forms.Label label123 = this.Label37;
		location = new System.Drawing.Point(43, 186);
		label123.Location = location;
		this.Label37.Name = "Label37";
		System.Windows.Forms.Label label124 = this.Label37;
		size = new System.Drawing.Size(37, 13);
		label124.Size = size;
		this.Label37.TabIndex = 0;
		this.Label37.Text = "Salud:";
		this.Label72.AutoSize = true;
		System.Windows.Forms.Label label125 = this.Label72;
		location = new System.Drawing.Point(28, 134);
		label125.Location = location;
		this.Label72.Name = "Label72";
		System.Windows.Forms.Label label126 = this.Label72;
		size = new System.Drawing.Size(52, 13);
		label126.Size = size;
		this.Label72.TabIndex = 0;
		this.Label72.Text = "Teléfono:";
		this.Label33.AutoSize = true;
		System.Windows.Forms.Label label127 = this.Label33;
		location = new System.Drawing.Point(193, 108);
		label127.Location = location;
		this.Label33.Name = "Label33";
		System.Windows.Forms.Label label128 = this.Label33;
		size = new System.Drawing.Size(67, 13);
		label128.Size = size;
		this.Label33.TabIndex = 0;
		this.Label33.Text = "Baja Policía:";
		this.Label32.AutoSize = true;
		System.Windows.Forms.Label label129 = this.Label32;
		location = new System.Drawing.Point(45, 108);
		label129.Location = location;
		this.Label32.Name = "Label32";
		System.Windows.Forms.Label label130 = this.Label32;
		size = new System.Drawing.Size(35, 13);
		label130.Size = size;
		this.Label32.TabIndex = 0;
		this.Label32.Text = "Agua:";
		this.UcTxtEgreSalud.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreSalud.Formato = null;
		this.UcTxtEgreSalud.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreSalud = this.UcTxtEgreSalud;
		location = new System.Drawing.Point(86, 183);
		ucTxtEgreSalud.Location = location;
		this.UcTxtEgreSalud.Name = "UcTxtEgreSalud";
		this.UcTxtEgreSalud.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreSalud.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreSalud.OnErrorBlankText = "";
		this.UcTxtEgreSalud.PadLeftLenght = 0;
		this.UcTxtEgreSalud.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreSalud.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreSalud.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreSalud2 = this.UcTxtEgreSalud;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreSalud2.Size = size;
		this.UcTxtEgreSalud.TabIndex = 16;
		this.UcTxtEgreSalud.TabNextControl = false;
		this.UcTxtEgreSalud.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.Label39.AutoSize = true;
		System.Windows.Forms.Label label131 = this.Label39;
		location = new System.Drawing.Point(195, 134);
		label131.Location = location;
		this.Label39.Name = "Label39";
		System.Windows.Forms.Label label132 = this.Label39;
		size = new System.Drawing.Size(65, 13);
		label132.Size = size;
		this.Label39.TabIndex = 0;
		this.Label39.Text = "Recreación:";
		this.Label38.AutoSize = true;
		System.Windows.Forms.Label label133 = this.Label38;
		location = new System.Drawing.Point(35, 82);
		label133.Location = location;
		this.Label38.Name = "Label38";
		System.Windows.Forms.Label label134 = this.Label38;
		size = new System.Drawing.Size(45, 13);
		label134.Size = size;
		this.Label38.TabIndex = 0;
		this.Label38.Text = "Vestido:";
		this.Label36.AutoSize = true;
		System.Windows.Forms.Label label135 = this.Label36;
		location = new System.Drawing.Point(199, 30);
		label135.Location = location;
		this.Label36.Name = "Label36";
		System.Windows.Forms.Label label136 = this.Label36;
		size = new System.Drawing.Size(61, 13);
		label136.Size = size;
		this.Label36.TabIndex = 0;
		this.Label36.Text = "Educación:";
		this.Label35.AutoSize = true;
		System.Windows.Forms.Label label137 = this.Label35;
		location = new System.Drawing.Point(29, 30);
		label137.Location = location;
		this.Label35.Name = "Label35";
		System.Windows.Forms.Label label138 = this.Label35;
		size = new System.Drawing.Size(51, 13);
		label138.Size = size;
		this.Label35.TabIndex = 0;
		this.Label35.Text = "Vivienda:";
		this.UcTxtEgreOtro.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreOtro.Formato = null;
		this.UcTxtEgreOtro.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreOtro = this.UcTxtEgreOtro;
		location = new System.Drawing.Point(265, 183);
		ucTxtEgreOtro.Location = location;
		this.UcTxtEgreOtro.Name = "UcTxtEgreOtro";
		this.UcTxtEgreOtro.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreOtro.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreOtro.OnErrorBlankText = "";
		this.UcTxtEgreOtro.PadLeftLenght = 0;
		this.UcTxtEgreOtro.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreOtro.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreOtro.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreOtro2 = this.UcTxtEgreOtro;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreOtro2.Size = size;
		this.UcTxtEgreOtro.TabIndex = 22;
		this.UcTxtEgreOtro.TabNextControl = false;
		this.UcTxtEgreOtro.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtTransporte.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtTransporte.Formato = null;
		this.UcTxtTransporte.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtTransporte = this.UcTxtTransporte;
		location = new System.Drawing.Point(266, 53);
		ucTxtTransporte.Location = location;
		this.UcTxtTransporte.Name = "UcTxtTransporte";
		this.UcTxtTransporte.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtTransporte.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtTransporte.OnErrorBlankText = "";
		this.UcTxtTransporte.PadLeftLenght = 0;
		this.UcTxtTransporte.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtTransporte.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtTransporte.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtTransporte2 = this.UcTxtTransporte;
		size = new System.Drawing.Size(81, 20);
		ucTxtTransporte2.Size = size;
		this.UcTxtTransporte.TabIndex = 15;
		this.UcTxtTransporte.TabNextControl = false;
		this.UcTxtTransporte.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.Label19.AutoSize = true;
		System.Windows.Forms.Label label139 = this.Label19;
		location = new System.Drawing.Point(199, 59);
		label139.Location = location;
		this.Label19.Name = "Label19";
		System.Windows.Forms.Label label140 = this.Label19;
		size = new System.Drawing.Size(61, 13);
		label140.Size = size;
		this.Label19.TabIndex = 0;
		this.Label19.Text = "Transporte:";
		this.UcTxtEgreAliment.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreAliment.Formato = null;
		this.UcTxtEgreAliment.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreAliment = this.UcTxtEgreAliment;
		location = new System.Drawing.Point(86, 53);
		ucTxtEgreAliment.Location = location;
		this.UcTxtEgreAliment.Name = "UcTxtEgreAliment";
		this.UcTxtEgreAliment.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreAliment.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreAliment.OnErrorBlankText = "";
		this.UcTxtEgreAliment.PadLeftLenght = 0;
		this.UcTxtEgreAliment.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreAliment.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreAliment.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreAliment2 = this.UcTxtEgreAliment;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreAliment2.Size = size;
		this.UcTxtEgreAliment.TabIndex = 15;
		this.UcTxtEgreAliment.TabNextControl = false;
		this.UcTxtEgreAliment.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.Label34.AutoSize = true;
		System.Windows.Forms.Label label141 = this.Label34;
		location = new System.Drawing.Point(10, 56);
		label141.Location = location;
		this.Label34.Name = "Label34";
		System.Windows.Forms.Label label142 = this.Label34;
		size = new System.Drawing.Size(70, 13);
		label142.Size = size;
		this.Label34.TabIndex = 0;
		this.Label34.Text = "Alimentación:";
		this.UcTxtEgreSegPriv.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreSegPriv.Formato = null;
		this.UcTxtEgreSegPriv.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreSegPriv = this.UcTxtEgreSegPriv;
		location = new System.Drawing.Point(86, 157);
		ucTxtEgreSegPriv.Location = location;
		this.UcTxtEgreSegPriv.Name = "UcTxtEgreSegPriv";
		this.UcTxtEgreSegPriv.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreSegPriv.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreSegPriv.OnErrorBlankText = "";
		this.UcTxtEgreSegPriv.PadLeftLenght = 0;
		this.UcTxtEgreSegPriv.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreSegPriv.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreSegPriv.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreSegPriv2 = this.UcTxtEgreSegPriv;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreSegPriv2.Size = size;
		this.UcTxtEgreSegPriv.TabIndex = 21;
		this.UcTxtEgreSegPriv.TabNextControl = false;
		this.UcTxtEgreSegPriv.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreDeuda.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreDeuda.Formato = null;
		this.UcTxtEgreDeuda.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreDeuda = this.UcTxtEgreDeuda;
		location = new System.Drawing.Point(266, 157);
		ucTxtEgreDeuda.Location = location;
		this.UcTxtEgreDeuda.Name = "UcTxtEgreDeuda";
		this.UcTxtEgreDeuda.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreDeuda.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreDeuda.OnErrorBlankText = "";
		this.UcTxtEgreDeuda.PadLeftLenght = 0;
		this.UcTxtEgreDeuda.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreDeuda.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreDeuda.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreDeuda2 = this.UcTxtEgreDeuda;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreDeuda2.Size = size;
		this.UcTxtEgreDeuda.TabIndex = 21;
		this.UcTxtEgreDeuda.TabNextControl = false;
		this.UcTxtEgreDeuda.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEnergElec.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEnergElec.Formato = null;
		this.UcTxtEnergElec.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEnergElec = this.UcTxtEnergElec;
		location = new System.Drawing.Point(266, 79);
		ucTxtEnergElec.Location = location;
		this.UcTxtEnergElec.Name = "UcTxtEnergElec";
		this.UcTxtEnergElec.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEnergElec.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEnergElec.OnErrorBlankText = "";
		this.UcTxtEnergElec.PadLeftLenght = 0;
		this.UcTxtEnergElec.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEnergElec.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEnergElec.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEnergElec2 = this.UcTxtEnergElec;
		size = new System.Drawing.Size(81, 20);
		ucTxtEnergElec2.Size = size;
		this.UcTxtEnergElec.TabIndex = 20;
		this.UcTxtEnergElec.TabNextControl = false;
		this.UcTxtEnergElec.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreFono.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreFono.Formato = null;
		this.UcTxtEgreFono.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreFono = this.UcTxtEgreFono;
		location = new System.Drawing.Point(86, 131);
		ucTxtEgreFono.Location = location;
		this.UcTxtEgreFono.Name = "UcTxtEgreFono";
		this.UcTxtEgreFono.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreFono.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreFono.OnErrorBlankText = "";
		this.UcTxtEgreFono.PadLeftLenght = 0;
		this.UcTxtEgreFono.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreFono.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreFono.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreFono2 = this.UcTxtEgreFono;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreFono2.Size = size;
		this.UcTxtEgreFono.TabIndex = 20;
		this.UcTxtEgreFono.TabNextControl = false;
		this.UcTxtEgreFono.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreBajaPol.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreBajaPol.Formato = null;
		this.UcTxtEgreBajaPol.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreBajaPol = this.UcTxtEgreBajaPol;
		location = new System.Drawing.Point(266, 105);
		ucTxtEgreBajaPol.Location = location;
		this.UcTxtEgreBajaPol.Name = "UcTxtEgreBajaPol";
		this.UcTxtEgreBajaPol.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreBajaPol.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreBajaPol.OnErrorBlankText = "";
		this.UcTxtEgreBajaPol.PadLeftLenght = 0;
		this.UcTxtEgreBajaPol.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreBajaPol.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreBajaPol.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreBajaPol2 = this.UcTxtEgreBajaPol;
		size = new System.Drawing.Size(80, 20);
		ucTxtEgreBajaPol2.Size = size;
		this.UcTxtEgreBajaPol.TabIndex = 20;
		this.UcTxtEgreBajaPol.TabNextControl = false;
		this.UcTxtEgreBajaPol.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreAgua.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreAgua.Formato = null;
		this.UcTxtEgreAgua.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreAgua = this.UcTxtEgreAgua;
		location = new System.Drawing.Point(86, 105);
		ucTxtEgreAgua.Location = location;
		this.UcTxtEgreAgua.Name = "UcTxtEgreAgua";
		this.UcTxtEgreAgua.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreAgua.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreAgua.OnErrorBlankText = "";
		this.UcTxtEgreAgua.PadLeftLenght = 0;
		this.UcTxtEgreAgua.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreAgua.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreAgua.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreAgua2 = this.UcTxtEgreAgua;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreAgua2.Size = size;
		this.UcTxtEgreAgua.TabIndex = 20;
		this.UcTxtEgreAgua.TabNextControl = false;
		this.UcTxtEgreAgua.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreRecrea.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreRecrea.Formato = null;
		this.UcTxtEgreRecrea.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreRecrea = this.UcTxtEgreRecrea;
		location = new System.Drawing.Point(266, 131);
		ucTxtEgreRecrea.Location = location;
		this.UcTxtEgreRecrea.Name = "UcTxtEgreRecrea";
		this.UcTxtEgreRecrea.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreRecrea.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreRecrea.OnErrorBlankText = "";
		this.UcTxtEgreRecrea.PadLeftLenght = 0;
		this.UcTxtEgreRecrea.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreRecrea.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreRecrea.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreRecrea2 = this.UcTxtEgreRecrea;
		size = new System.Drawing.Size(80, 20);
		ucTxtEgreRecrea2.Size = size;
		this.UcTxtEgreRecrea.TabIndex = 20;
		this.UcTxtEgreRecrea.TabNextControl = false;
		this.UcTxtEgreRecrea.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreVestido.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreVestido.Formato = null;
		this.UcTxtEgreVestido.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreVestido = this.UcTxtEgreVestido;
		location = new System.Drawing.Point(86, 79);
		ucTxtEgreVestido.Location = location;
		this.UcTxtEgreVestido.Name = "UcTxtEgreVestido";
		this.UcTxtEgreVestido.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreVestido.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreVestido.OnErrorBlankText = "";
		this.UcTxtEgreVestido.PadLeftLenght = 0;
		this.UcTxtEgreVestido.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreVestido.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreVestido.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreVestido2 = this.UcTxtEgreVestido;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreVestido2.Size = size;
		this.UcTxtEgreVestido.TabIndex = 19;
		this.UcTxtEgreVestido.TabNextControl = false;
		this.UcTxtEgreVestido.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreEducac.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreEducac.Formato = null;
		this.UcTxtEgreEducac.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreEducac = this.UcTxtEgreEducac;
		location = new System.Drawing.Point(266, 27);
		ucTxtEgreEducac.Location = location;
		this.UcTxtEgreEducac.Name = "UcTxtEgreEducac";
		this.UcTxtEgreEducac.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreEducac.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreEducac.OnErrorBlankText = "";
		this.UcTxtEgreEducac.PadLeftLenght = 0;
		this.UcTxtEgreEducac.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreEducac.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreEducac.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreEducac2 = this.UcTxtEgreEducac;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreEducac2.Size = size;
		this.UcTxtEgreEducac.TabIndex = 18;
		this.UcTxtEgreEducac.TabNextControl = false;
		this.UcTxtEgreEducac.Text = " ";
		this.UcTxtEgreEducac.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtEgreVivienda.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtEgreVivienda.Formato = null;
		this.UcTxtEgreVivienda.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtEgreVivienda = this.UcTxtEgreVivienda;
		location = new System.Drawing.Point(86, 27);
		ucTxtEgreVivienda.Location = location;
		this.UcTxtEgreVivienda.Name = "UcTxtEgreVivienda";
		this.UcTxtEgreVivienda.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtEgreVivienda.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtEgreVivienda.OnErrorBlankText = "";
		this.UcTxtEgreVivienda.PadLeftLenght = 0;
		this.UcTxtEgreVivienda.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtEgreVivienda.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtEgreVivienda.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtEgreVivienda2 = this.UcTxtEgreVivienda;
		size = new System.Drawing.Size(81, 20);
		ucTxtEgreVivienda2.Size = size;
		this.UcTxtEgreVivienda.TabIndex = 17;
		this.UcTxtEgreVivienda.TabNextControl = false;
		this.UcTxtEgreVivienda.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.GroupControl10.Controls.Add(this.UcTxtIngreBienes);
		this.GroupControl10.Controls.Add(this.UcTxtIngreMiembros);
		this.GroupControl10.Controls.Add(this.UcTxtIngreAdic);
		this.GroupControl10.Controls.Add(this.UcTxtIngreRemune);
		this.GroupControl10.Controls.Add(this.Label18);
		this.GroupControl10.Controls.Add(this.Label17);
		this.GroupControl10.Controls.Add(this.Label16);
		this.GroupControl10.Controls.Add(this.Label15);
		DevExpress.XtraEditors.GroupControl groupControl69 = this.GroupControl10;
		location = new System.Drawing.Point(3, 3);
		groupControl69.Location = location;
		this.GroupControl10.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl10.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl10.Name = "GroupControl10";
		DevExpress.XtraEditors.GroupControl groupControl70 = this.GroupControl10;
		size = new System.Drawing.Size(242, 134);
		groupControl70.Size = size;
		this.GroupControl10.TabIndex = 1;
		this.GroupControl10.Text = "Ingresos";
		this.UcTxtIngreBienes.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtIngreBienes.Formato = null;
		this.UcTxtIngreBienes.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtIngreBienes = this.UcTxtIngreBienes;
		location = new System.Drawing.Point(138, 105);
		ucTxtIngreBienes.Location = location;
		this.UcTxtIngreBienes.Name = "UcTxtIngreBienes";
		this.UcTxtIngreBienes.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtIngreBienes.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtIngreBienes.OnErrorBlankText = "";
		this.UcTxtIngreBienes.PadLeftLenght = 0;
		this.UcTxtIngreBienes.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtIngreBienes.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtIngreBienes.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtIngreBienes2 = this.UcTxtIngreBienes;
		size = new System.Drawing.Size(97, 20);
		ucTxtIngreBienes2.Size = size;
		this.UcTxtIngreBienes.TabIndex = 10;
		this.UcTxtIngreBienes.TabNextControl = false;
		this.UcTxtIngreBienes.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtIngreMiembros.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtIngreMiembros.Formato = null;
		this.UcTxtIngreMiembros.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtIngreMiembros = this.UcTxtIngreMiembros;
		location = new System.Drawing.Point(138, 79);
		ucTxtIngreMiembros.Location = location;
		this.UcTxtIngreMiembros.Name = "UcTxtIngreMiembros";
		this.UcTxtIngreMiembros.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtIngreMiembros.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtIngreMiembros.OnErrorBlankText = "";
		this.UcTxtIngreMiembros.PadLeftLenght = 0;
		this.UcTxtIngreMiembros.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtIngreMiembros.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtIngreMiembros.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtIngreMiembros2 = this.UcTxtIngreMiembros;
		size = new System.Drawing.Size(97, 20);
		ucTxtIngreMiembros2.Size = size;
		this.UcTxtIngreMiembros.TabIndex = 9;
		this.UcTxtIngreMiembros.TabNextControl = false;
		this.UcTxtIngreMiembros.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtIngreAdic.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtIngreAdic.Formato = null;
		this.UcTxtIngreAdic.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtIngreAdic = this.UcTxtIngreAdic;
		location = new System.Drawing.Point(138, 53);
		ucTxtIngreAdic.Location = location;
		this.UcTxtIngreAdic.Name = "UcTxtIngreAdic";
		this.UcTxtIngreAdic.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtIngreAdic.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtIngreAdic.OnErrorBlankText = "";
		this.UcTxtIngreAdic.PadLeftLenght = 0;
		this.UcTxtIngreAdic.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtIngreAdic.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtIngreAdic.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtIngreAdic2 = this.UcTxtIngreAdic;
		size = new System.Drawing.Size(97, 20);
		ucTxtIngreAdic2.Size = size;
		this.UcTxtIngreAdic.TabIndex = 8;
		this.UcTxtIngreAdic.TabNextControl = false;
		this.UcTxtIngreAdic.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.UcTxtIngreRemune.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtIngreRemune.Formato = null;
		this.UcTxtIngreRemune.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtIngreRemune = this.UcTxtIngreRemune;
		location = new System.Drawing.Point(138, 27);
		ucTxtIngreRemune.Location = location;
		this.UcTxtIngreRemune.Name = "UcTxtIngreRemune";
		this.UcTxtIngreRemune.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtIngreRemune.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtIngreRemune.OnErrorBlankText = "";
		this.UcTxtIngreRemune.PadLeftLenght = 0;
		this.UcTxtIngreRemune.RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
		this.UcTxtIngreRemune.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtIngreRemune.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtIngreRemune2 = this.UcTxtIngreRemune;
		size = new System.Drawing.Size(97, 20);
		ucTxtIngreRemune2.Size = size;
		this.UcTxtIngreRemune.TabIndex = 7;
		this.UcTxtIngreRemune.TabNextControl = false;
		this.UcTxtIngreRemune.Tipo = GRLL.Common.ucTextBox.TipoDato.Decimales;
		this.Label18.AutoSize = true;
		System.Windows.Forms.Label label143 = this.Label18;
		location = new System.Drawing.Point(5, 108);
		label143.Location = location;
		this.Label18.Name = "Label18";
		System.Windows.Forms.Label label144 = this.Label18;
		size = new System.Drawing.Size(127, 13);
		label144.Size = size;
		this.Label18.TabIndex = 0;
		this.Label18.Text = "Total del Ingreso Familiar:";
		this.Label17.AutoSize = true;
		System.Windows.Forms.Label label145 = this.Label17;
		location = new System.Drawing.Point(26, 82);
		label145.Location = location;
		this.Label17.Name = "Label17";
		System.Windows.Forms.Label label146 = this.Label17;
		size = new System.Drawing.Size(106, 13);
		label146.Size = size;
		this.Label17.TabIndex = 0;
		this.Label17.Text = "Total Aporte Familiar:";
		this.Label16.AutoSize = true;
		System.Windows.Forms.Label label147 = this.Label16;
		location = new System.Drawing.Point(60, 56);
		label147.Location = location;
		this.Label16.Name = "Label16";
		System.Windows.Forms.Label label148 = this.Label16;
		size = new System.Drawing.Size(72, 13);
		label148.Size = size;
		this.Label16.TabIndex = 0;
		this.Label16.Text = "Ingreso Adic.:";
		this.Label15.AutoSize = true;
		System.Windows.Forms.Label label149 = this.Label15;
		location = new System.Drawing.Point(21, 30);
		label149.Location = location;
		this.Label15.Name = "Label15";
		System.Windows.Forms.Label label150 = this.Label15;
		size = new System.Drawing.Size(111, 13);
		label150.Size = size;
		this.Label15.TabIndex = 0;
		this.Label15.Text = "Remuneración Mens.:";
		this.Label43.AutoSize = true;
		System.Windows.Forms.Label label151 = this.Label43;
		location = new System.Drawing.Point(9, 264);
		label151.Location = location;
		this.Label43.Name = "Label43";
		System.Windows.Forms.Label label152 = this.Label43;
		size = new System.Drawing.Size(393, 13);
		label152.Size = size;
		this.Label43.TabIndex = 0;
		this.Label43.Text = "Nº de personas que aportan económicamente en la manutención de la familia:  Nº";
		this.Label42.AutoSize = true;
		System.Windows.Forms.Label label153 = this.Label42;
		location = new System.Drawing.Point(9, 235);
		label153.Location = location;
		this.Label42.Name = "Label42";
		System.Windows.Forms.Label label154 = this.Label42;
		size = new System.Drawing.Size(323, 13);
		label154.Size = size;
		this.Label42.TabIndex = 0;
		this.Label42.Text = "Monto de ingresos generados por otros miembros de la familia:  S/.:";
		this.XtraTabPage11.AutoScroll = true;
		this.XtraTabPage11.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage11.Controls.Add(this.GroupControl19);
		this.XtraTabPage11.Name = "XtraTabPage11";
		DevExpress.XtraTab.XtraTabPage xtraTabPage10 = this.XtraTabPage11;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage10.Size = size;
		this.XtraTabPage11.Text = "Aspecto Disciplinario";
		this.GroupControl19.Controls.Add(this.BtnModDisci);
		this.GroupControl19.Controls.Add(this.BtnAgregarDisci);
		this.GroupControl19.Controls.Add(this.BtnEliminarDisci);
		this.GroupControl19.Controls.Add(this.DGV_Disciplina);
		DevExpress.XtraEditors.GroupControl groupControl71 = this.GroupControl19;
		location = new System.Drawing.Point(3, 17);
		groupControl71.Location = location;
		this.GroupControl19.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl19.LookAndFeel.UseDefaultLookAndFeel = false;
		this.GroupControl19.Name = "GroupControl19";
		DevExpress.XtraEditors.GroupControl groupControl72 = this.GroupControl19;
		size = new System.Drawing.Size(694, 235);
		groupControl72.Size = size;
		this.GroupControl19.TabIndex = 0;
		this.GroupControl19.Text = "Méritos y/o Deméritos Obtenidos";
		this.BtnModDisci.FlatAppearance.BorderSize = 0;
		this.BtnModDisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnModDisci.Image = RecursosHumanos.My.Resources.Resources.document_edit;
		System.Windows.Forms.Button btnModDisci = this.BtnModDisci;
		location = new System.Drawing.Point(614, 106);
		btnModDisci.Location = location;
		this.BtnModDisci.Name = "BtnModDisci";
		System.Windows.Forms.Button btnModDisci2 = this.BtnModDisci;
		size = new System.Drawing.Size(75, 37);
		btnModDisci2.Size = size;
		this.BtnModDisci.TabIndex = 38;
		this.BtnModDisci.Text = "Modificar";
		this.BtnModDisci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnModDisci.UseVisualStyleBackColor = true;
		this.BtnAgregarDisci.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnAgregarDisci.FlatAppearance.BorderSize = 0;
		this.BtnAgregarDisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnAgregarDisci.Image = RecursosHumanos.My.Resources.Resources.add2;
		System.Windows.Forms.Button btnAgregarDisci = this.BtnAgregarDisci;
		location = new System.Drawing.Point(614, 65);
		btnAgregarDisci.Location = location;
		this.BtnAgregarDisci.Name = "BtnAgregarDisci";
		System.Windows.Forms.Button btnAgregarDisci2 = this.BtnAgregarDisci;
		size = new System.Drawing.Size(75, 35);
		btnAgregarDisci2.Size = size;
		this.BtnAgregarDisci.TabIndex = 37;
		this.BtnAgregarDisci.Text = "Agregar";
		this.BtnAgregarDisci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnAgregarDisci.UseVisualStyleBackColor = true;
		this.BtnEliminarDisci.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnEliminarDisci.FlatAppearance.BorderSize = 0;
		this.BtnEliminarDisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnEliminarDisci.Image = RecursosHumanos.My.Resources.Resources.delete2;
		System.Windows.Forms.Button btnEliminarDisci = this.BtnEliminarDisci;
		location = new System.Drawing.Point(614, 149);
		btnEliminarDisci.Location = location;
		this.BtnEliminarDisci.Name = "BtnEliminarDisci";
		System.Windows.Forms.Button btnEliminarDisci2 = this.BtnEliminarDisci;
		size = new System.Drawing.Size(75, 36);
		btnEliminarDisci2.Size = size;
		this.BtnEliminarDisci.TabIndex = 39;
		this.BtnEliminarDisci.Text = "Eliminar";
		this.BtnEliminarDisci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnEliminarDisci.UseVisualStyleBackColor = true;
		DevExpress.XtraGrid.GridControl dGV_Disciplina = this.DGV_Disciplina;
		location = new System.Drawing.Point(5, 23);
		dGV_Disciplina.Location = location;
		this.DGV_Disciplina.LookAndFeel.SkinName = "Blue";
		this.DGV_Disciplina.LookAndFeel.UseDefaultLookAndFeel = false;
		this.DGV_Disciplina.MainView = this.GridViewDisciplina;
		this.DGV_Disciplina.Name = "DGV_Disciplina";
		DevExpress.XtraGrid.GridControl dGV_Disciplina2 = this.DGV_Disciplina;
		size = new System.Drawing.Size(603, 200);
		dGV_Disciplina2.Size = size;
		this.DGV_Disciplina.TabIndex = 0;
		this.DGV_Disciplina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridViewDisciplina });
		this.GridViewDisciplina.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[7] { this.GridColumn33, this.GridColumn34, this.GridColumn35, this.GridColumn36, this.GridColumn37, this.GridColumn38, this.GridColumn39 });
		this.GridViewDisciplina.GridControl = this.DGV_Disciplina;
		this.GridViewDisciplina.Name = "GridViewDisciplina";
		this.GridViewDisciplina.OptionsBehavior.Editable = false;
		this.GridViewDisciplina.OptionsCustomization.AllowColumnMoving = false;
		this.GridViewDisciplina.OptionsCustomization.AllowFilter = false;
		this.GridViewDisciplina.OptionsCustomization.AllowGroup = false;
		this.GridViewDisciplina.OptionsFilter.AllowColumnMRUFilterList = false;
		this.GridViewDisciplina.OptionsFilter.AllowFilterEditor = false;
		this.GridViewDisciplina.OptionsPrint.AutoWidth = false;
		this.GridViewDisciplina.OptionsView.ShowGroupPanel = false;
		this.GridColumn33.Caption = "Tipo";
		this.GridColumn33.FieldName = "TipoCompDescrip";
		this.GridColumn33.Name = "GridColumn33";
		this.GridColumn33.Visible = true;
		this.GridColumn33.VisibleIndex = 0;
		this.GridColumn34.Caption = "Fecha";
		this.GridColumn34.FieldName = "Fecha";
		this.GridColumn34.Name = "GridColumn34";
		this.GridColumn34.Visible = true;
		this.GridColumn34.VisibleIndex = 1;
		this.GridColumn35.Caption = "Num. Documento";
		this.GridColumn35.FieldName = "NumResol";
		this.GridColumn35.Name = "GridColumn35";
		this.GridColumn35.Visible = true;
		this.GridColumn35.VisibleIndex = 2;
		this.GridColumn36.Caption = "Titulo";
		this.GridColumn36.FieldName = "Titulo";
		this.GridColumn36.Name = "GridColumn36";
		this.GridColumn36.Visible = true;
		this.GridColumn36.VisibleIndex = 3;
		this.GridColumn37.Caption = "Descripcion";
		this.GridColumn37.FieldName = "Descripcion";
		this.GridColumn37.Name = "GridColumn37";
		this.GridColumn37.Visible = true;
		this.GridColumn37.VisibleIndex = 4;
		this.GridColumn38.Caption = "idComportamiento";
		this.GridColumn38.FieldName = "idComportamiento";
		this.GridColumn38.Name = "GridColumn38";
		this.GridColumn39.Caption = "idEmpleado";
		this.GridColumn39.FieldName = "idEmpleado";
		this.GridColumn39.Name = "GridColumn39";
		this.XtraTabPage7.AutoScroll = true;
		this.XtraTabPage7.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage7.Controls.Add(this.UcTxtRec7);
		this.XtraTabPage7.Controls.Add(this.UcTxtRec6);
		this.XtraTabPage7.Controls.Add(this.UcTxtRec5);
		this.XtraTabPage7.Controls.Add(this.UcTxtRec4);
		this.XtraTabPage7.Controls.Add(this.UcCmboRec3);
		this.XtraTabPage7.Controls.Add(this.UcCmboRec2);
		this.XtraTabPage7.Controls.Add(this.UcCmboRec1);
		this.XtraTabPage7.Controls.Add(this.Label71);
		this.XtraTabPage7.Controls.Add(this.Label70);
		this.XtraTabPage7.Controls.Add(this.Label69);
		this.XtraTabPage7.Controls.Add(this.Label68);
		this.XtraTabPage7.Controls.Add(this.Label67);
		this.XtraTabPage7.Controls.Add(this.Label66);
		this.XtraTabPage7.Controls.Add(this.Label23);
		this.XtraTabPage7.Name = "XtraTabPage7";
		DevExpress.XtraTab.XtraTabPage xtraTabPage11 = this.XtraTabPage7;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage11.Size = size;
		this.XtraTabPage7.Text = "Aspecto Recreacional";
		this.UcTxtRec7.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRec7.Formato = null;
		this.UcTxtRec7.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRec = this.UcTxtRec7;
		location = new System.Drawing.Point(16, 349);
		ucTxtRec.Location = location;
		this.UcTxtRec7.Multiline = true;
		this.UcTxtRec7.Name = "UcTxtRec7";
		this.UcTxtRec7.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtRec7.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtRec7.OnErrorBlankText = "";
		this.UcTxtRec7.PadLeftLenght = 0;
		this.UcTxtRec7.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtRec7.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtRec7.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtRec2 = this.UcTxtRec7;
		size = new System.Drawing.Size(412, 38);
		ucTxtRec2.Size = size;
		this.UcTxtRec7.TabIndex = 36;
		this.UcTxtRec7.TabNextControl = false;
		this.UcTxtRec7.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtRec6.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRec6.Formato = null;
		this.UcTxtRec6.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRec3 = this.UcTxtRec6;
		location = new System.Drawing.Point(16, 292);
		ucTxtRec3.Location = location;
		this.UcTxtRec6.Multiline = true;
		this.UcTxtRec6.Name = "UcTxtRec6";
		this.UcTxtRec6.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtRec6.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtRec6.OnErrorBlankText = "";
		this.UcTxtRec6.PadLeftLenght = 0;
		this.UcTxtRec6.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtRec6.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtRec6.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtRec4 = this.UcTxtRec6;
		size = new System.Drawing.Size(412, 38);
		ucTxtRec4.Size = size;
		this.UcTxtRec6.TabIndex = 36;
		this.UcTxtRec6.TabNextControl = false;
		this.UcTxtRec6.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtRec5.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRec5.Formato = null;
		this.UcTxtRec5.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRec5 = this.UcTxtRec5;
		location = new System.Drawing.Point(16, 235);
		ucTxtRec5.Location = location;
		this.UcTxtRec5.Multiline = true;
		this.UcTxtRec5.Name = "UcTxtRec5";
		this.UcTxtRec5.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtRec5.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtRec5.OnErrorBlankText = "";
		this.UcTxtRec5.PadLeftLenght = 0;
		this.UcTxtRec5.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtRec5.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtRec5.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtRec6 = this.UcTxtRec5;
		size = new System.Drawing.Size(412, 38);
		ucTxtRec6.Size = size;
		this.UcTxtRec5.TabIndex = 36;
		this.UcTxtRec5.TabNextControl = false;
		this.UcTxtRec5.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcTxtRec4.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtRec4.Formato = null;
		this.UcTxtRec4.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtRec7 = this.UcTxtRec4;
		location = new System.Drawing.Point(16, 178);
		ucTxtRec7.Location = location;
		this.UcTxtRec4.Multiline = true;
		this.UcTxtRec4.Name = "UcTxtRec4";
		this.UcTxtRec4.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtRec4.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtRec4.OnErrorBlankText = "";
		this.UcTxtRec4.PadLeftLenght = 0;
		this.UcTxtRec4.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtRec4.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtRec4.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtRec8 = this.UcTxtRec4;
		size = new System.Drawing.Size(412, 38);
		ucTxtRec8.Size = size;
		this.UcTxtRec4.TabIndex = 36;
		this.UcTxtRec4.TabNextControl = false;
		this.UcTxtRec4.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.UcCmboRec3.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmboRec3.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmboRec3.FormattingEnabled = true;
		this.UcCmboRec3.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmboRec = this.UcCmboRec3;
		location = new System.Drawing.Point(16, 132);
		ucCmboRec.Location = location;
		this.UcCmboRec3.Name = "UcCmboRec3";
		GRLL.Common.ucComboBox ucCmboRec2 = this.UcCmboRec3;
		size = new System.Drawing.Size(412, 21);
		ucCmboRec2.Size = size;
		this.UcCmboRec3.TabIndex = 35;
		this.UcCmboRec2.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmboRec2.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmboRec2.FormattingEnabled = true;
		this.UcCmboRec2.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmboRec3 = this.UcCmboRec2;
		location = new System.Drawing.Point(16, 83);
		ucCmboRec3.Location = location;
		this.UcCmboRec2.Name = "UcCmboRec2";
		GRLL.Common.ucComboBox ucCmboRec4 = this.UcCmboRec2;
		size = new System.Drawing.Size(412, 21);
		ucCmboRec4.Size = size;
		this.UcCmboRec2.TabIndex = 35;
		this.UcCmboRec1.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmboRec1.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmboRec1.FormattingEnabled = true;
		this.UcCmboRec1.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmboRec5 = this.UcCmboRec1;
		location = new System.Drawing.Point(16, 35);
		ucCmboRec5.Location = location;
		this.UcCmboRec1.Name = "UcCmboRec1";
		GRLL.Common.ucComboBox ucCmboRec6 = this.UcCmboRec1;
		size = new System.Drawing.Size(412, 21);
		ucCmboRec6.Size = size;
		this.UcCmboRec1.TabIndex = 35;
		this.Label71.AutoSize = true;
		System.Windows.Forms.Label label155 = this.Label71;
		location = new System.Drawing.Point(19, 333);
		label155.Location = location;
		this.Label71.Name = "Label71";
		System.Windows.Forms.Label label156 = this.Label71;
		size = new System.Drawing.Size(332, 13);
		label156.Size = size;
		this.Label71.TabIndex = 34;
		this.Label71.Text = "Qué actividades recreativas le gustaría realizar en centro de trabajo?";
		this.Label70.AutoSize = true;
		System.Windows.Forms.Label label157 = this.Label70;
		location = new System.Drawing.Point(17, 276);
		label157.Location = location;
		this.Label70.Name = "Label70";
		System.Windows.Forms.Label label158 = this.Label70;
		size = new System.Drawing.Size(96, 13);
		label158.Size = size;
		this.Label70.TabIndex = 34;
		this.Label70.Text = "Cúal es su Hobby?";
		this.Label69.AutoSize = true;
		System.Windows.Forms.Label label159 = this.Label69;
		location = new System.Drawing.Point(19, 219);
		label159.Location = location;
		this.Label69.Name = "Label69";
		System.Windows.Forms.Label label160 = this.Label69;
		size = new System.Drawing.Size(394, 13);
		label160.Size = size;
		this.Label69.TabIndex = 34;
		this.Label69.Text = "Qué propone usted para mejorar esas situaciones problemáticas en su Institución?";
		this.Label68.AutoSize = true;
		System.Windows.Forms.Label label161 = this.Label68;
		location = new System.Drawing.Point(17, 162);
		label161.Location = location;
		this.Label68.Name = "Label68";
		System.Windows.Forms.Label label162 = this.Label68;
		size = new System.Drawing.Size(411, 13);
		label162.Size = size;
		this.Label68.TabIndex = 34;
		this.Label68.Text = "Cuáles son los principales problemas conocidos por UD. que existen en la Institución?";
		this.Label67.AutoSize = true;
		System.Windows.Forms.Label label163 = this.Label67;
		location = new System.Drawing.Point(19, 116);
		label163.Location = location;
		this.Label67.Name = "Label67";
		System.Windows.Forms.Label label164 = this.Label67;
		size = new System.Drawing.Size(301, 13);
		label164.Size = size;
		this.Label67.TabIndex = 34;
		this.Label67.Text = "En General. Comó se siente tratado por su superior Inmediato?";
		this.Label66.AutoSize = true;
		System.Windows.Forms.Label label165 = this.Label66;
		location = new System.Drawing.Point(17, 67);
		label165.Location = location;
		this.Label66.Name = "Label66";
		System.Windows.Forms.Label label166 = this.Label66;
		size = new System.Drawing.Size(184, 13);
		label166.Size = size;
		this.Label66.TabIndex = 34;
		this.Label66.Text = "Como se Siente en su ámbito laboral?";
		this.Label23.AutoSize = true;
		System.Windows.Forms.Label label167 = this.Label23;
		location = new System.Drawing.Point(17, 19);
		label167.Location = location;
		this.Label23.Name = "Label23";
		System.Windows.Forms.Label label168 = this.Label23;
		size = new System.Drawing.Size(229, 13);
		label168.Size = size;
		this.Label23.TabIndex = 34;
		this.Label23.Text = "Se lleva bien con sus compañeros de Trabajo?";
		this.XtraTabPage8.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage8.Controls.Add(this.Label25);
		this.XtraTabPage8.Controls.Add(this.UcTxtAspPsico);
		this.XtraTabPage8.Name = "XtraTabPage8";
		DevExpress.XtraTab.XtraTabPage xtraTabPage12 = this.XtraTabPage8;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage12.Size = size;
		this.XtraTabPage8.Text = "Aspecto Psicologico";
		this.Label25.AutoSize = true;
		System.Windows.Forms.Label label169 = this.Label25;
		location = new System.Drawing.Point(17, 19);
		label169.Location = location;
		this.Label25.Name = "Label25";
		System.Windows.Forms.Label label170 = this.Label25;
		size = new System.Drawing.Size(66, 13);
		label170.Size = size;
		this.Label25.TabIndex = 34;
		this.Label25.Text = "Descripcion:";
		this.UcTxtAspPsico.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAspPsico.Formato = null;
		this.UcTxtAspPsico.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAspPsico = this.UcTxtAspPsico;
		location = new System.Drawing.Point(93, 16);
		ucTxtAspPsico.Location = location;
		this.UcTxtAspPsico.MaxLength = 1000;
		this.UcTxtAspPsico.Multiline = true;
		this.UcTxtAspPsico.Name = "UcTxtAspPsico";
		this.UcTxtAspPsico.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAspPsico.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAspPsico.OnErrorBlankText = "";
		this.UcTxtAspPsico.PadLeftLenght = 0;
		this.UcTxtAspPsico.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtAspPsico.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAspPsico.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAspPsico2 = this.UcTxtAspPsico;
		size = new System.Drawing.Size(510, 148);
		ucTxtAspPsico2.Size = size;
		this.UcTxtAspPsico.TabIndex = 7;
		this.UcTxtAspPsico.TabNextControl = false;
		this.UcTxtAspPsico.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.XtraTabPage9.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage9.Controls.Add(this.Label26);
		this.XtraTabPage9.Controls.Add(this.UcTxtAspSocial);
		this.XtraTabPage9.Name = "XtraTabPage9";
		DevExpress.XtraTab.XtraTabPage xtraTabPage13 = this.XtraTabPage9;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage13.Size = size;
		this.XtraTabPage9.Text = "Aspecto Social";
		this.Label26.AutoSize = true;
		System.Windows.Forms.Label label171 = this.Label26;
		location = new System.Drawing.Point(17, 19);
		label171.Location = location;
		this.Label26.Name = "Label26";
		System.Windows.Forms.Label label172 = this.Label26;
		size = new System.Drawing.Size(66, 13);
		label172.Size = size;
		this.Label26.TabIndex = 34;
		this.Label26.Text = "Descripcion:";
		this.UcTxtAspSocial.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtAspSocial.Formato = null;
		this.UcTxtAspSocial.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtAspSocial = this.UcTxtAspSocial;
		location = new System.Drawing.Point(93, 16);
		ucTxtAspSocial.Location = location;
		this.UcTxtAspSocial.MaxLength = 1000;
		this.UcTxtAspSocial.Multiline = true;
		this.UcTxtAspSocial.Name = "UcTxtAspSocial";
		this.UcTxtAspSocial.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtAspSocial.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtAspSocial.OnErrorBlankText = "";
		this.UcTxtAspSocial.PadLeftLenght = 0;
		this.UcTxtAspSocial.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtAspSocial.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtAspSocial.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtAspSocial2 = this.UcTxtAspSocial;
		size = new System.Drawing.Size(510, 148);
		ucTxtAspSocial2.Size = size;
		this.UcTxtAspSocial.TabIndex = 7;
		this.UcTxtAspSocial.TabNextControl = false;
		this.UcTxtAspSocial.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.XtraTabPage10.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.XtraTabPage10.Controls.Add(this.Label27);
		this.XtraTabPage10.Controls.Add(this.UcTxtDiagSocial);
		this.XtraTabPage10.Name = "XtraTabPage10";
		DevExpress.XtraTab.XtraTabPage xtraTabPage14 = this.XtraTabPage10;
		size = new System.Drawing.Size(700, 405);
		xtraTabPage14.Size = size;
		this.XtraTabPage10.Text = "Diagnostico Social";
		this.Label27.AutoSize = true;
		System.Windows.Forms.Label label173 = this.Label27;
		location = new System.Drawing.Point(17, 19);
		label173.Location = location;
		this.Label27.Name = "Label27";
		System.Windows.Forms.Label label174 = this.Label27;
		size = new System.Drawing.Size(66, 13);
		label174.Size = size;
		this.Label27.TabIndex = 34;
		this.Label27.Text = "Descripcion:";
		this.UcTxtDiagSocial.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtDiagSocial.Formato = null;
		this.UcTxtDiagSocial.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtDiagSocial = this.UcTxtDiagSocial;
		location = new System.Drawing.Point(93, 16);
		ucTxtDiagSocial.Location = location;
		this.UcTxtDiagSocial.MaxLength = 1000;
		this.UcTxtDiagSocial.Multiline = true;
		this.UcTxtDiagSocial.Name = "UcTxtDiagSocial";
		this.UcTxtDiagSocial.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtDiagSocial.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtDiagSocial.OnErrorBlankText = "";
		this.UcTxtDiagSocial.PadLeftLenght = 0;
		this.UcTxtDiagSocial.RegularExpression = "^[A-Z,a-z,\\s]+$";
		this.UcTxtDiagSocial.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtDiagSocial.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtDiagSocial2 = this.UcTxtDiagSocial;
		size = new System.Drawing.Size(510, 148);
		ucTxtDiagSocial2.Size = size;
		this.UcTxtDiagSocial.TabIndex = 7;
		this.UcTxtDiagSocial.TabNextControl = false;
		this.UcTxtDiagSocial.Tipo = GRLL.Common.ucTextBox.TipoDato.SoloLetras;
		this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGuardar.AutoSize = true;
		this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnGuardar.FlatAppearance.BorderSize = 0;
		this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
		System.Windows.Forms.Button button35 = this.btnGuardar;
		location = new System.Drawing.Point(12, 651);
		button35.Location = location;
		this.btnGuardar.Name = "btnGuardar";
		System.Windows.Forms.Button button36 = this.btnGuardar;
		size = new System.Drawing.Size(71, 23);
		button36.Size = size;
		this.btnGuardar.TabIndex = 46;
		this.btnGuardar.Text = "Guardar";
		this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnGuardar.UseVisualStyleBackColor = true;
		this.UcTxtTipoDocID.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtTipoDocID.BackColor = System.Drawing.SystemColors.Control;
		this.UcTxtTipoDocID.ForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtTipoDocID.Formato = null;
		this.UcTxtTipoDocID.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtTipoDocID = this.UcTxtTipoDocID;
		location = new System.Drawing.Point(111, 40);
		ucTxtTipoDocID.Location = location;
		this.UcTxtTipoDocID.Name = "UcTxtTipoDocID";
		this.UcTxtTipoDocID.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtTipoDocID.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtTipoDocID.OnErrorBlankText = "";
		this.UcTxtTipoDocID.PadLeftLenght = 0;
		this.UcTxtTipoDocID.ReadOnly = true;
		this.UcTxtTipoDocID.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtTipoDocID.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtTipoDocID2 = this.UcTxtTipoDocID;
		size = new System.Drawing.Size(121, 20);
		ucTxtTipoDocID2.Size = size;
		this.UcTxtTipoDocID.TabIndex = 1;
		this.UcTxtTipoDocID.TabNextControl = false;
		this.UcTxtTipoDocID.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtSexo.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtSexo.Formato = null;
		this.UcTxtSexo.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtSexo = this.UcTxtSexo;
		location = new System.Drawing.Point(437, 114);
		ucTxtSexo.Location = location;
		this.UcTxtSexo.Name = "UcTxtSexo";
		this.UcTxtSexo.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtSexo.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtSexo.OnErrorBlankText = "";
		this.UcTxtSexo.PadLeftLenght = 0;
		this.UcTxtSexo.ReadOnly = true;
		this.UcTxtSexo.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtSexo.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtSexo2 = this.UcTxtSexo;
		size = new System.Drawing.Size(66, 20);
		ucTxtSexo2.Size = size;
		this.UcTxtSexo.TabIndex = 6;
		this.UcTxtSexo.TabNextControl = false;
		this.UcTxtSexo.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		this.GroupControl34.Controls.Add(this.UcFoto);
		this.GroupControl34.Controls.Add(this.Label5);
		this.GroupControl34.Controls.Add(this.UcTxtNDoc);
		this.GroupControl34.Controls.Add(this.Label24);
		this.GroupControl34.Controls.Add(this.UcTxtTipoDocID);
		this.GroupControl34.Controls.Add(this.UcTxtApePater);
		this.GroupControl34.Controls.Add(this.UcTxtSexo);
		this.GroupControl34.Controls.Add(this.UcTxtNombres);
		this.GroupControl34.Controls.Add(this.Label1);
		this.GroupControl34.Controls.Add(this.UcTxtApeMater);
		this.GroupControl34.Controls.Add(this.Label4);
		this.GroupControl34.Controls.Add(this.Label2);
		this.GroupControl34.Controls.Add(this.Label3);
		DevExpress.XtraEditors.GroupControl groupControl73 = this.GroupControl34;
		location = new System.Drawing.Point(12, 35);
		groupControl73.Location = location;
		this.GroupControl34.Name = "GroupControl34";
		DevExpress.XtraEditors.GroupControl groupControl74 = this.GroupControl34;
		size = new System.Drawing.Size(706, 169);
		groupControl74.Size = size;
		this.GroupControl34.TabIndex = 101;
		this.GroupControl34.Text = "Datos del Empleado";
		this.GridColumn57.Caption = "Tipo Resolucion";
		this.GridColumn57.FieldName = "DescripTipoResolucion";
		this.GridColumn57.Name = "GridColumn57";
		this.GridColumn57.Visible = true;
		this.GridColumn57.VisibleIndex = 0;
		this.GridColumn58.Caption = "Fecha Resolucion";
		this.GridColumn58.FieldName = "FechaResolucion";
		this.GridColumn58.Name = "GridColumn58";
		this.GridColumn58.Visible = true;
		this.GridColumn58.VisibleIndex = 1;
		this.GridColumn59.Caption = "Numero Resolucion";
		this.GridColumn59.FieldName = "NumeroResolucion";
		this.GridColumn59.Name = "GridColumn59";
		this.GridColumn59.Visible = true;
		this.GridColumn59.VisibleIndex = 2;
		this.GridColumn60.Caption = "idResolucion";
		this.GridColumn60.FieldName = "idResolucion";
		this.GridColumn60.Name = "GridColumn60";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(730, 689);
		this.ClientSize = size;
		this.Controls.Add(this.GroupControl34);
		this.Controls.Add(this.btnGuardar);
		this.Controls.Add(this.XtraTabControl1);
		this.Name = "FrmFichaSocial";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Ficha Escalafonaria del Empleado";
		this.VerCmdCerrar = true;
		this.VerPanelInf = false;
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.XtraTabControl1, 0);
		this.Controls.SetChildIndex(this.btnGuardar, 0);
		this.Controls.SetChildIndex(this.GroupControl34, 0);
		((System.ComponentModel.ISupportInitialize)this.XtraTabControl1).EndInit();
		this.XtraTabControl1.ResumeLayout(false);
		this.XtraTabPage1.ResumeLayout(false);
		this.XtraTabPage1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl33).EndInit();
		this.GroupControl33.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVPerLab).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewPerLab).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl18).EndInit();
		this.GroupControl18.ResumeLayout(false);
		this.GroupControl18.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl32).EndInit();
		this.GroupControl32.ResumeLayout(false);
		this.GroupControl32.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl31).EndInit();
		this.GroupControl31.ResumeLayout(false);
		this.GroupControl31.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl16).EndInit();
		this.GroupControl16.ResumeLayout(false);
		this.GroupControl16.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl15).EndInit();
		this.GroupControl15.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVExpLab).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewExpLab).EndInit();
		this.XtraTabPage13.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl35).EndInit();
		this.GroupControl35.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GCAsegurado).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GVAsegurados).EndInit();
		this.XtraTabPage14.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl37).EndInit();
		this.GroupControl37.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.Grid_Resoluciones).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewResoluciones).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl36).EndInit();
		this.GroupControl36.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.Grid_Rotaciones).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewRotaciones).EndInit();
		this.XtraTabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl14).EndInit();
		this.GroupControl14.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVCapacitacion).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewCapacitacion).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl13).EndInit();
		this.GroupControl13.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVTitulos).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewTitulos).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl12).EndInit();
		this.GroupControl12.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVEstudios).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewEstudios).EndInit();
		this.XtraTabPage2.ResumeLayout(false);
		this.XtraTabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl17).EndInit();
		this.GroupControl17.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvFamiliares).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewFam).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckEdit2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemRadioGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup1.Properties).EndInit();
		this.XtraTabPage12.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl21).EndInit();
		this.GroupControl21.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl24).EndInit();
		this.GroupControl24.ResumeLayout(false);
		this.GroupControl24.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl25).EndInit();
		this.GroupControl25.ResumeLayout(false);
		this.GroupControl25.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl23).EndInit();
		this.GroupControl23.ResumeLayout(false);
		this.GroupControl23.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl22).EndInit();
		this.GroupControl22.ResumeLayout(false);
		this.GroupControl22.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl20).EndInit();
		this.GroupControl20.ResumeLayout(false);
		this.GroupControl20.PerformLayout();
		this.XtraTabPage4.ResumeLayout(false);
		this.XtraTabPage4.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl27).EndInit();
		this.GroupControl27.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ChckFono.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ChckOtros.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ChckCable.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ChckInter.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl6).EndInit();
		this.GroupControl6.ResumeLayout(false);
		this.GroupControl6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl7).EndInit();
		this.GroupControl7.ResumeLayout(false);
		this.GroupControl7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl8).EndInit();
		this.GroupControl8.ResumeLayout(false);
		this.GroupControl8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl9).EndInit();
		this.GroupControl9.ResumeLayout(false);
		this.GroupControl9.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl5).EndInit();
		this.GroupControl5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl4).EndInit();
		this.GroupControl4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl3).EndInit();
		this.GroupControl3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl2).EndInit();
		this.GroupControl2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.XtraTabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl30).EndInit();
		this.GroupControl30.ResumeLayout(false);
		this.GroupControl30.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl29).EndInit();
		this.GroupControl29.ResumeLayout(false);
		this.GroupControl29.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup4.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl28).EndInit();
		this.GroupControl28.ResumeLayout(false);
		this.GroupControl28.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup3.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl26).EndInit();
		this.GroupControl26.ResumeLayout(false);
		this.GroupControl26.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.RadioGroup2.Properties).EndInit();
		this.XtraTabPage3.ResumeLayout(false);
		this.XtraTabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl11).EndInit();
		this.GroupControl11.ResumeLayout(false);
		this.GroupControl11.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl10).EndInit();
		this.GroupControl10.ResumeLayout(false);
		this.GroupControl10.PerformLayout();
		this.XtraTabPage11.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GroupControl19).EndInit();
		this.GroupControl19.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV_Disciplina).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridViewDisciplina).EndInit();
		this.XtraTabPage7.ResumeLayout(false);
		this.XtraTabPage7.PerformLayout();
		this.XtraTabPage8.ResumeLayout(false);
		this.XtraTabPage8.PerformLayout();
		this.XtraTabPage9.ResumeLayout(false);
		this.XtraTabPage9.PerformLayout();
		this.XtraTabPage10.ResumeLayout(false);
		this.XtraTabPage10.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.GroupControl34).EndInit();
		this.GroupControl34.ResumeLayout(false);
		this.GroupControl34.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

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

	public void llena_dvgResoluciones()
	{
		List<spRRHH_ListarResolucionResult> dataSource = Module1.DcGrll.spRRHH_ListarResolucion(CodEmple).ToList();
		Grid_Resoluciones.DataSource = dataSource;
	}

	public void llena_dvgRotaciones()
	{
		List<spRRHH_ListarRotacionesResult> dataSource = Module1.DcGrll.spRRHH_ListarRotaciones(CodEmple).ToList();
		Grid_Rotaciones.DataSource = dataSource;
	}

	public void llena_dgvAsegurados()
	{
		GCAsegurado.DataSource = RRHH_AseguradoMapper.Instance().SelectBy([SpecialName] (RRHH_Asegurado P) => P.idEmpleado == CodEmple);
	}

	public void llena_dgvFamilia()
	{
		dgvFamiliares.DataSource = RuntimeHelpers.GetObjectValue(objFichaSocialClass.llenarFamiliares(CodEmple));
	}

	public void llena_dgvEstudios()
	{
		List<spRRHH_buscarEstudiosResult> dataSource = Module1.DcGrll.spRRHH_buscarEstudios(CodEmple).ToList();
		DGVEstudios.DataSource = dataSource;
	}

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

	public void llena_dgvExpLab()
	{
		List<spRRHH_BuscarExpLabResult> dataSource = Module1.DcGrll.spRRHH_BuscarExpLab(CodEmple).ToList();
		DGVExpLab.DataSource = dataSource;
	}

	public void llena_DgvDisciplina()
	{
		List<spRRHH_busca_DisciplinaResult> dataSource = Module1.DcGrll.spRRHH_busca_Disciplina(CodEmple).ToList();
		DGV_Disciplina.DataSource = dataSource;
	}

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

	private void GridViewTitulos_RowUpdated(object sender, RowObjectEventArgs e)
	{
		TitulosEmpleado titulosEmpleado = (TitulosEmpleado)e.Row;
		if (titulosEmpleado.DenominacionGrado != null)
		{
			TitulosEmpleadoMapper.Instance().Update(titulosEmpleado);
			MessageBox.Show("Se actualizó el registro :" + ObtenerMensaje(titulosEmpleado), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

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

	private void GridViewCapacitacion_RowUpdated(object sender, RowObjectEventArgs e)
	{
		Capacitacion capacitacion = (Capacitacion)e.Row;
		if (capacitacion.NombreCurso != null)
		{
			CapacitacionMapper.Instance().Update(capacitacion);
			MessageBox.Show("Se actualizó el registro :" + ObtenerMensajeCap(capacitacion), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

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

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

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

	private void llena_dgvPerLab()
	{
		List<spRRHH_GetPeriodoLaboralByEmpleadoResult> dataSource = Module1.DcGrll.spRRHH_GetPeriodoLaboralByEmpleado(CodEmple).ToList();
		DGVPerLab.DataSource = dataSource;
	}

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

	private void XtraTabPage1_DoubleClick(object sender, EventArgs e)
	{
	}

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
}
