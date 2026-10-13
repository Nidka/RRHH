using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FarsiLibrary.Win;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class frmMantBaseFTS : frmBase1
{
	public delegate void CmdBuscarIndexChangedEventHandler(int Index, ref bool Cancelar);

	public delegate void ClearCtrlsEventHandler();

	public delegate void Cmb1SelectedIndexChangedEventHandler(ref bool Cancelar);

	public delegate void Cmb2SelectedIndexChangedEventHandler(ref bool Cancelar);

	public delegate void Config_DGVEventHandler(ref DataGridView DGV);

	public delegate void CellFormatting_DGVEventHandler(object sender, DataGridViewCellFormattingEventArgs e);

	public delegate void ValidarGrabarEventHandler(bool IsNew, ref bool Cancelar);

	public delegate void ClickNuevoEventHandler(ref bool Cancelar);

	public delegate void ClickEditarEventHandler(bool GridListar, ref bool Cancelar);

	public delegate void ClickGrabarEventHandler(ref bool Cancelar, bool IsNew, ref bool bCargarDatos);

	public delegate void ClickCancelarEventHandler(ref bool Cancelar);

	public delegate void ClickSeleccionarEventHandler(ref bool Cancelar);

	public delegate void ClickEliminarEventHandler(ref bool Cancelar);

	public delegate void ClickBuscarEventHandler(ref bool Cancelar);

	public delegate void ClickRefrescarEventHandler(ref bool Cancelar);

	public delegate void ClickImprimirEventHandler(ref bool Cancelar);

	public delegate void ClickExportarExcelEventHandler(ref bool Cancelar, ref DataTable tDTT);

	public delegate void ClickSalirEventHandler(ref bool Cancelar);

	public delegate void ClickAyudaEventHandler();

	private IContainer components;

	[AccessedThroughProperty("LBL_COMBO1")]
	private Label _LBL_COMBO1;

	[AccessedThroughProperty("CMB_OPCION")]
	private ComboBox _CMB_OPCION;

	[AccessedThroughProperty("CMD_BUSCAR")]
	private Button _CMD_BUSCAR;

	[AccessedThroughProperty("TXT_BUSCA")]
	private ucText _TXT_BUSCA;

	[AccessedThroughProperty("BTN_NEW")]
	private ToolStripButton _BTN_NEW;

	[AccessedThroughProperty("BTN_EDIT")]
	private ToolStripButton _BTN_EDIT;

	[AccessedThroughProperty("BTN_DEL")]
	private ToolStripButton _BTN_DEL;

	[AccessedThroughProperty("BTN_PRINT")]
	private ToolStripButton _BTN_PRINT;

	[AccessedThroughProperty("BTN_SAVE")]
	private ToolStripButton _BTN_SAVE;

	[AccessedThroughProperty("BTN_HELP")]
	private ToolStripButton _BTN_HELP;

	[AccessedThroughProperty("BTN_CANCEL")]
	private ToolStripButton _BTN_CANCEL;

	[AccessedThroughProperty("BTN_SALIR")]
	private ToolStripButton _BTN_SALIR;

	[AccessedThroughProperty("BTN_EXCEL")]
	private ToolStripButton _BTN_EXCEL;

	[AccessedThroughProperty("LBL_COMBO2")]
	private Label _LBL_COMBO2;

	[AccessedThroughProperty("BTN_SELEC")]
	private ToolStripButton _BTN_SELEC;

	[AccessedThroughProperty("BTN_REFRESH")]
	private ToolStripButton _BTN_REFRESH;

	[AccessedThroughProperty("LBL_TITLULO")]
	private Label _LBL_TITLULO;

	[AccessedThroughProperty("CHK_ITERACTIVO")]
	private CheckBox _CHK_ITERACTIVO;

	[AccessedThroughProperty("TStMenu")]
	private ToolStrip _TStMenu;

	[AccessedThroughProperty("CMB_1")]
	private ComboBox _CMB_1;

	[AccessedThroughProperty("CMB_2")]
	private ComboBox _CMB_2;

	[AccessedThroughProperty("DGV_BUSCAR")]
	private DataGridView _DGV_BUSCAR;

	[AccessedThroughProperty("BTN_BUSCAR")]
	private ToolStripButton _BTN_BUSCAR;

	[AccessedThroughProperty("LBL_AL")]
	private Label _LBL_AL;

	[AccessedThroughProperty("LBL_DEL")]
	private Label _LBL_DEL;

	[AccessedThroughProperty("DTP_FF")]
	private DateTimePicker _DTP_FF;

	[AccessedThroughProperty("DTP_FI")]
	private DateTimePicker _DTP_FI;

	[AccessedThroughProperty("DGV_DATOS")]
	private DataGridView _DGV_DATOS;

	[AccessedThroughProperty("TAB_BUSCAR")]
	private FATabStripItem _TAB_BUSCAR;

	[AccessedThroughProperty("TAB_EDICION")]
	private FATabStripItem _TAB_EDICION;

	[AccessedThroughProperty("ImgLst")]
	private ImageList _ImgLst;

	[AccessedThroughProperty("TAB_LIST")]
	private FATabStripItem _TAB_LIST;

	[AccessedThroughProperty("FTS")]
	private FATabStrip _FTS;

	private ToolTip ToolTipTextChk;

	public int iNroTabp;

	private SqlConnection cConnection;

	private string sConnection;

	private bool bEstablecerEdicion;

	private bool bResizeAutomatic;

	private bool bVerTitulo;

	private short mTopGrid;

	private bool mLblHorizontal;

	private bool bNuevo;

	private bool bEditar;

	private bool bVerCMB1;

	private bool bVerLblCMB1;

	private string sLabelCmb1;

	private bool bVerCMB2;

	private bool bVerLblCMB2;

	private string sLabelCmb2;

	private bool bVerTituloTab;

	private string sTituloTab;

	private ContentAlignment aTituloAlinear;

	private int iTituloPosY;

	private Color cTituloForeColor;

	private Color cTituloBackColor;

	private int iVerTab;

	private bool bVerNuevo;

	private bool bVerEditar;

	private bool bVerGrabar;

	private bool bVerCancelar;

	private bool bVerSeleccionar;

	private bool bVerEliminar;

	private bool bVerBuscar;

	private bool bVerRegrescar;

	private bool bVerImprimir;

	private bool bVerExcel;

	private bool bVerSalir;

	private bool bVerAyuda;

	private string[] sCampoBuscaName;

	private string[] sCampoBuscaFiltrar;

	private int[] mCampoBuscaMaxLen;

	private clsVariables.TipoDato[] mCampoBuscaTipoDato;

	private DataTable DT1;

	private DataView _Vista;

	public string CadSqlB;

	private string _TituloExcel;

	private string _SubTituloExcel;

	private bool _VerFechaExcel;

	private string _UsuarioExcel;

	private bool _AnchoAutomat;

	internal Label LBL_COMBO1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_COMBO1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_COMBO1 = value;
		}
	}

	internal ComboBox CMB_OPCION
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_OPCION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_OPCION_SelectedIndexChanged;
			if (_CMB_OPCION != null)
			{
				_CMB_OPCION.SelectedIndexChanged -= value2;
			}
			_CMB_OPCION = value;
			if (_CMB_OPCION != null)
			{
				_CMB_OPCION.SelectedIndexChanged += value2;
			}
		}
	}

	internal Button CMD_BUSCAR
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMD_BUSCAR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMD_BUSCAR_Click;
			if (_CMD_BUSCAR != null)
			{
				_CMD_BUSCAR.Click -= value2;
			}
			_CMD_BUSCAR = value;
			if (_CMD_BUSCAR != null)
			{
				_CMD_BUSCAR.Click += value2;
			}
		}
	}

	internal ucText TXT_BUSCA
	{
		[DebuggerNonUserCode]
		get
		{
			return _TXT_BUSCA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = TXT_BUSCA_TextChanged;
			if (_TXT_BUSCA != null)
			{
				_TXT_BUSCA.TextChanged -= value2;
			}
			_TXT_BUSCA = value;
			if (_TXT_BUSCA != null)
			{
				_TXT_BUSCA.TextChanged += value2;
			}
		}
	}

	internal ToolStripButton BTN_NEW
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_NEW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_NEW_Click;
			if (_BTN_NEW != null)
			{
				_BTN_NEW.Click -= value2;
			}
			_BTN_NEW = value;
			if (_BTN_NEW != null)
			{
				_BTN_NEW.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_EDIT
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_EDIT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_EDIT_Click;
			if (_BTN_EDIT != null)
			{
				_BTN_EDIT.Click -= value2;
			}
			_BTN_EDIT = value;
			if (_BTN_EDIT != null)
			{
				_BTN_EDIT.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_DEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_DEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_DEL_Click;
			if (_BTN_DEL != null)
			{
				_BTN_DEL.Click -= value2;
			}
			_BTN_DEL = value;
			if (_BTN_DEL != null)
			{
				_BTN_DEL.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_PRINT
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_PRINT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_PRINT_Click;
			if (_BTN_PRINT != null)
			{
				_BTN_PRINT.Click -= value2;
			}
			_BTN_PRINT = value;
			if (_BTN_PRINT != null)
			{
				_BTN_PRINT.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_SAVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_SAVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_SAVE_Click;
			if (_BTN_SAVE != null)
			{
				_BTN_SAVE.Click -= value2;
			}
			_BTN_SAVE = value;
			if (_BTN_SAVE != null)
			{
				_BTN_SAVE.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_HELP
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_HELP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_HELP_Click;
			if (_BTN_HELP != null)
			{
				_BTN_HELP.Click -= value2;
			}
			_BTN_HELP = value;
			if (_BTN_HELP != null)
			{
				_BTN_HELP.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_CANCEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_CANCEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_CANCEL_Click;
			if (_BTN_CANCEL != null)
			{
				_BTN_CANCEL.Click -= value2;
			}
			_BTN_CANCEL = value;
			if (_BTN_CANCEL != null)
			{
				_BTN_CANCEL.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_SALIR
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_SALIR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_SALIR_Click;
			if (_BTN_SALIR != null)
			{
				_BTN_SALIR.Click -= value2;
			}
			_BTN_SALIR = value;
			if (_BTN_SALIR != null)
			{
				_BTN_SALIR.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_EXCEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_EXCEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_EXCEL_Click;
			if (_BTN_EXCEL != null)
			{
				_BTN_EXCEL.Click -= value2;
			}
			_BTN_EXCEL = value;
			if (_BTN_EXCEL != null)
			{
				_BTN_EXCEL.Click += value2;
			}
		}
	}

	internal Label LBL_COMBO2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_COMBO2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_COMBO2 = value;
		}
	}

	internal ToolStripButton BTN_SELEC
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_SELEC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_SELEC_Click;
			if (_BTN_SELEC != null)
			{
				_BTN_SELEC.Click -= value2;
			}
			_BTN_SELEC = value;
			if (_BTN_SELEC != null)
			{
				_BTN_SELEC.Click += value2;
			}
		}
	}

	internal ToolStripButton BTN_REFRESH
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_REFRESH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_REFRESH_Click;
			if (_BTN_REFRESH != null)
			{
				_BTN_REFRESH.Click -= value2;
			}
			_BTN_REFRESH = value;
			if (_BTN_REFRESH != null)
			{
				_BTN_REFRESH.Click += value2;
			}
		}
	}

	internal Label LBL_TITLULO
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_TITLULO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_TITLULO = value;
		}
	}

	internal CheckBox CHK_ITERACTIVO
	{
		[DebuggerNonUserCode]
		get
		{
			return _CHK_ITERACTIVO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CHK_ITERACTIVO_CheckedChanged;
			if (_CHK_ITERACTIVO != null)
			{
				_CHK_ITERACTIVO.CheckedChanged -= value2;
			}
			_CHK_ITERACTIVO = value;
			if (_CHK_ITERACTIVO != null)
			{
				_CHK_ITERACTIVO.CheckedChanged += value2;
			}
		}
	}

	internal ToolStrip TStMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _TStMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TStMenu = value;
		}
	}

	public virtual ComboBox CMB_1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_1_SelectedIndexChanged;
			if (_CMB_1 != null)
			{
				_CMB_1.SelectedIndexChanged -= value2;
			}
			_CMB_1 = value;
			if (_CMB_1 != null)
			{
				_CMB_1.SelectedIndexChanged += value2;
			}
		}
	}

	public virtual ComboBox CMB_2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CMB_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = CMB_2_SelectedIndexChanged;
			if (_CMB_2 != null)
			{
				_CMB_2.SelectedIndexChanged -= value2;
			}
			_CMB_2 = value;
			if (_CMB_2 != null)
			{
				_CMB_2.SelectedIndexChanged += value2;
			}
		}
	}

	public virtual DataGridView DGV_BUSCAR
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV_BUSCAR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataGridViewCellMouseEventHandler value2 = DTG_BUSCAR_CellMouseDoubleClick;
			DataGridViewCellFormattingEventHandler value3 = DGV_BUSCAR_CellFormatting;
			if (_DGV_BUSCAR != null)
			{
				_DGV_BUSCAR.CellMouseDoubleClick -= value2;
				_DGV_BUSCAR.CellFormatting -= value3;
			}
			_DGV_BUSCAR = value;
			if (_DGV_BUSCAR != null)
			{
				_DGV_BUSCAR.CellMouseDoubleClick += value2;
				_DGV_BUSCAR.CellFormatting += value3;
			}
		}
	}

	public virtual ToolStripButton BTN_BUSCAR
	{
		[DebuggerNonUserCode]
		get
		{
			return _BTN_BUSCAR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BTN_BUSCAR_Click;
			if (_BTN_BUSCAR != null)
			{
				_BTN_BUSCAR.Click -= value2;
			}
			_BTN_BUSCAR = value;
			if (_BTN_BUSCAR != null)
			{
				_BTN_BUSCAR.Click += value2;
			}
		}
	}

	internal Label LBL_AL
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_AL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_AL = value;
		}
	}

	internal Label LBL_DEL
	{
		[DebuggerNonUserCode]
		get
		{
			return _LBL_DEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LBL_DEL = value;
		}
	}

	internal DateTimePicker DTP_FF
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTP_FF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DTP_FF = value;
		}
	}

	internal DateTimePicker DTP_FI
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTP_FI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DTP_FI = value;
		}
	}

	public virtual DataGridView DGV_DATOS
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGV_DATOS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataGridViewCellMouseEventHandler value2 = DGV_DATOS_CellMouseDoubleClick;
			DataGridViewCellFormattingEventHandler value3 = DGV_DATOS_CellFormatting;
			DataGridViewCellEventHandler value4 = DGV_DATOS_CellContentClick;
			if (_DGV_DATOS != null)
			{
				_DGV_DATOS.CellMouseDoubleClick -= value2;
				_DGV_DATOS.CellFormatting -= value3;
				_DGV_DATOS.CellContentClick -= value4;
			}
			_DGV_DATOS = value;
			if (_DGV_DATOS != null)
			{
				_DGV_DATOS.CellMouseDoubleClick += value2;
				_DGV_DATOS.CellFormatting += value3;
				_DGV_DATOS.CellContentClick += value4;
			}
		}
	}

	internal FATabStripItem TAB_BUSCAR
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAB_BUSCAR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAB_BUSCAR = value;
		}
	}

	public virtual FATabStripItem TAB_EDICION
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAB_EDICION;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAB_EDICION = value;
		}
	}

	protected virtual ImageList ImgLst
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImgLst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImgLst = value;
		}
	}

	internal FATabStripItem TAB_LIST
	{
		[DebuggerNonUserCode]
		get
		{
			return _TAB_LIST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TAB_LIST = value;
		}
	}

	public virtual FATabStrip FTS
	{
		[DebuggerNonUserCode]
		get
		{
			return _FTS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FTS = value;
		}
	}

	public clsVariables.TipoDato CampoBuscaTipoDato
	{
		get
		{
			if (I < 0)
			{
				return (clsVariables.TipoDato)Conversions.ToInteger("");
			}
			if (I > checked(mCampoBuscaTipoDato.Length - 1))
			{
				return (clsVariables.TipoDato)Conversions.ToInteger("");
			}
			return mCampoBuscaTipoDato[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (mCampoBuscaTipoDato == null)
					{
						mCampoBuscaTipoDato = new clsVariables.TipoDato[1];
					}
					if (I > mCampoBuscaTipoDato.Length - 1)
					{
						mCampoBuscaTipoDato = (clsVariables.TipoDato[])Utils.CopyArray(mCampoBuscaTipoDato, new clsVariables.TipoDato[I + 1]);
					}
					mCampoBuscaTipoDato[I] = value;
				}
			}
		}
	}

	public string CampoBuscaName
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sCampoBuscaName.Length - 1))
			{
				return "";
			}
			return sCampoBuscaName[I];
		}
		set
		{
			if (I < 0)
			{
				return;
			}
			if (sCampoBuscaName == null)
			{
				sCampoBuscaName = new string[1];
			}
			checked
			{
				if (I > sCampoBuscaName.Length - 1)
				{
					sCampoBuscaName = (string[])Utils.CopyArray(sCampoBuscaName, new string[I + 1]);
				}
				sCampoBuscaName[I] = value;
				if (mCampoBuscaTipoDato == null)
				{
					mCampoBuscaTipoDato = new clsVariables.TipoDato[1];
					mCampoBuscaTipoDato[0] = clsVariables.TipoDato.LetrasConEspacio;
				}
				if (mCampoBuscaTipoDato.Length - 1 < I)
				{
					for (int II = mCampoBuscaTipoDato.Length; II <= I; II++)
					{
						mCampoBuscaTipoDato = (clsVariables.TipoDato[])Utils.CopyArray(mCampoBuscaTipoDato, new clsVariables.TipoDato[II + 1]);
						mCampoBuscaTipoDato[II] = clsVariables.TipoDato.LetrasConEspacio;
					}
				}
				if (mCampoBuscaMaxLen == null)
				{
					mCampoBuscaMaxLen = new int[1];
					mCampoBuscaMaxLen[0] = 0;
				}
				if (mCampoBuscaMaxLen.Length - 1 < I)
				{
					for (int i = mCampoBuscaMaxLen.Length; i <= I; i++)
					{
						mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[i + 1]);
						mCampoBuscaMaxLen[i] = 0;
					}
				}
				if (sCampoBuscaFiltrar == null)
				{
					sCampoBuscaFiltrar = new string[1];
					sCampoBuscaFiltrar[0] = sCampoBuscaName[0];
				}
				if (sCampoBuscaFiltrar.Length - 1 < I)
				{
					for (int j = sCampoBuscaFiltrar.Length; j <= I; j++)
					{
						sCampoBuscaFiltrar = (string[])Utils.CopyArray(sCampoBuscaFiltrar, new string[j + 1]);
						sCampoBuscaFiltrar[j] = sCampoBuscaName[j];
					}
				}
			}
		}
	}

	public string CampoBuscaFiltrar
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sCampoBuscaFiltrar.Length - 1))
			{
				return "";
			}
			return sCampoBuscaFiltrar[I];
		}
		set
		{
			if (I < 0)
			{
				return;
			}
			if (sCampoBuscaFiltrar == null)
			{
				if (sCampoBuscaName == null)
				{
					return;
				}
				sCampoBuscaFiltrar = new string[1];
				sCampoBuscaFiltrar[0] = sCampoBuscaName[0];
			}
			checked
			{
				if (I > sCampoBuscaFiltrar.Length - 1)
				{
					if (sCampoBuscaFiltrar.Length >= sCampoBuscaName.Length)
					{
						return;
					}
					sCampoBuscaFiltrar = (string[])Utils.CopyArray(sCampoBuscaFiltrar, new string[I + 1]);
					sCampoBuscaFiltrar[I] = sCampoBuscaName[I];
				}
				sCampoBuscaFiltrar[I] = value;
			}
		}
	}

	public int CampoBuscaMaxLen
	{
		get
		{
			if (I < 0)
			{
				return Conversions.ToInteger("");
			}
			if (I > checked(mCampoBuscaMaxLen.Length - 1))
			{
				return Conversions.ToInteger("");
			}
			return mCampoBuscaMaxLen[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (mCampoBuscaMaxLen == null)
					{
						mCampoBuscaMaxLen = new int[1];
					}
					if (I > mCampoBuscaMaxLen.Length - 1)
					{
						mCampoBuscaMaxLen = (int[])Utils.CopyArray(mCampoBuscaMaxLen, new int[I + 1]);
					}
					mCampoBuscaMaxLen[I] = value;
				}
			}
		}
	}

	public string TituloExcel
	{
		get
		{
			return _TituloExcel;
		}
		set
		{
			_TituloExcel = value;
		}
	}

	public string SubTituloExcel
	{
		get
		{
			return _SubTituloExcel;
		}
		set
		{
			_SubTituloExcel = value;
		}
	}

	public string UsuarioExcel
	{
		get
		{
			return _UsuarioExcel;
		}
		set
		{
			_UsuarioExcel = value;
		}
	}

	public bool VerFechaExcel
	{
		get
		{
			return _VerFechaExcel;
		}
		set
		{
			_VerFechaExcel = value;
		}
	}

	public bool AnchoAutomat
	{
		get
		{
			return _AnchoAutomat;
		}
		set
		{
			_AnchoAutomat = value;
		}
	}

	public SqlConnection Connetion
	{
		get
		{
			return cConnection;
		}
		set
		{
			cConnection = value;
		}
	}

	public string Conexion
	{
		get
		{
			return sConnection;
		}
		set
		{
			sConnection = value;
		}
	}

	public bool VerBotonNuevo
	{
		get
		{
			return bVerNuevo;
		}
		set
		{
			bVerNuevo = value;
			BTN_NEW.Visible = bVerNuevo;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonEditar
	{
		get
		{
			return bVerEditar;
		}
		set
		{
			bVerEditar = value;
			BTN_EDIT.Visible = bVerEditar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonGrabar
	{
		get
		{
			return bVerGrabar;
		}
		set
		{
			bVerGrabar = value;
			BTN_SAVE.Visible = bVerGrabar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonCancelar
	{
		get
		{
			return bVerCancelar;
		}
		set
		{
			bVerCancelar = value;
			BTN_CANCEL.Visible = bVerCancelar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonSeleccionar
	{
		get
		{
			return bVerSeleccionar;
		}
		set
		{
			bVerSeleccionar = value;
			BTN_SELEC.Visible = bVerSeleccionar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonEliminar
	{
		get
		{
			return bVerEliminar;
		}
		set
		{
			bVerEliminar = value;
			BTN_DEL.Visible = bVerEliminar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonBuscar
	{
		get
		{
			return bVerBuscar;
		}
		set
		{
			bVerBuscar = value;
			BTN_BUSCAR.Visible = bVerBuscar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonRegrescar
	{
		get
		{
			return bVerRegrescar;
		}
		set
		{
			bVerRegrescar = value;
			BTN_REFRESH.Visible = bVerRegrescar;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonImprimir
	{
		get
		{
			return bVerImprimir;
		}
		set
		{
			bVerImprimir = value;
			BTN_PRINT.Visible = bVerImprimir;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonExcel
	{
		get
		{
			return bVerExcel;
		}
		set
		{
			bVerExcel = value;
			BTN_EXCEL.Visible = bVerExcel;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonSalir
	{
		get
		{
			return bVerSalir;
		}
		set
		{
			bVerSalir = value;
			BTN_SALIR.Visible = bVerSalir;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public bool VerBotonAyuda
	{
		get
		{
			return bVerAyuda;
		}
		set
		{
			bVerAyuda = value;
			BTN_HELP.Visible = bVerAyuda;
			ToolStrip tStMenu = TStMenu;
			Point location = new Point(checked((int)Math.Round((double)(ClientSize.Width - TStMenu.Width) / 2.0)), TStMenu.Location.Y);
			tStMenu.Location = location;
		}
	}

	public int VerTab
	{
		get
		{
			return iVerTab;
		}
		set
		{
			if (value <= 2 && value != iVerTab)
			{
				iVerTab = value;
				ActivaTab(iVerTab);
			}
		}
	}

	public Color TituloBackColor
	{
		get
		{
			return cTituloBackColor;
		}
		set
		{
			cTituloBackColor = value;
			LBL_TITLULO.BackColor = cTituloBackColor;
		}
	}

	public Color TituloForeColor
	{
		get
		{
			return cTituloForeColor;
		}
		set
		{
			cTituloForeColor = value;
			LBL_TITLULO.ForeColor = cTituloForeColor;
		}
	}

	public int TituloPosY
	{
		get
		{
			return iTituloPosY;
		}
		set
		{
			iTituloPosY = value;
			LBL_TITLULO.Left = 0;
			LBL_TITLULO.Width = Width;
			Label lBL_TITLULO = LBL_TITLULO;
			Point location = new Point(LBL_TITLULO.Location.X, iTituloPosY);
			lBL_TITLULO.Location = location;
		}
	}

	public ContentAlignment TituloAlinear
	{
		get
		{
			return aTituloAlinear;
		}
		set
		{
			aTituloAlinear = value;
			LBL_TITLULO.TextAlign = aTituloAlinear;
		}
	}

	public string TituloTab
	{
		get
		{
			return sTituloTab;
		}
		set
		{
			sTituloTab = value;
			LBL_TITLULO.Text = sTituloTab;
		}
	}

	public bool VerTituloTab
	{
		get
		{
			return bVerTituloTab;
		}
		set
		{
			bVerTituloTab = value;
			LBL_TITLULO.Visible = bVerTituloTab;
			Reubicar();
		}
	}

	public bool ResizeAutomatic
	{
		get
		{
			return bResizeAutomatic;
		}
		set
		{
			bResizeAutomatic = value;
			Reubicar();
		}
	}

	public bool VerCMB1
	{
		get
		{
			return bVerCMB1;
		}
		set
		{
			bVerCMB1 = value;
			CMB_1.Visible = bVerCMB1;
			Reubicar();
		}
	}

	public bool VerLblCMB1
	{
		get
		{
			return bVerLblCMB1;
		}
		set
		{
			bVerLblCMB1 = value;
			LBL_COMBO1.Visible = bVerLblCMB1;
			Reubicar();
		}
	}

	public string LabelCMB1
	{
		get
		{
			return sLabelCmb1;
		}
		set
		{
			sLabelCmb1 = value;
			LBL_COMBO1.Text = value;
			if (!mLblHorizontal)
			{
				Reubicar();
			}
		}
	}

	public bool VerCMB2
	{
		get
		{
			return bVerCMB2;
		}
		set
		{
			bVerCMB2 = value;
			CMB_2.Visible = bVerCMB2;
			Reubicar();
		}
	}

	public bool VerLblCMB2
	{
		get
		{
			return bVerLblCMB2;
		}
		set
		{
			bVerLblCMB2 = value;
			LBL_COMBO2.Visible = bVerLblCMB2;
			Reubicar();
		}
	}

	public string LabelCMB2
	{
		get
		{
			return sLabelCmb2;
		}
		set
		{
			sLabelCmb2 = value;
			LBL_COMBO2.Text = value;
			if (!mLblHorizontal)
			{
				Reubicar();
			}
		}
	}

	public bool EstablecerEdicion
	{
		get
		{
			return bEstablecerEdicion;
		}
		set
		{
			bEstablecerEdicion = value;
		}
	}

	public bool LblCmbHorizontal
	{
		get
		{
			return mLblHorizontal;
		}
		set
		{
			mLblHorizontal = value;
			AlineaCMBs();
		}
	}

	public short TopGridDatos
	{
		get
		{
			return mTopGrid;
		}
		set
		{
			mTopGrid = value;
			AlineaCMBs();
		}
	}

	[method: DebuggerNonUserCode]
	public event CmdBuscarIndexChangedEventHandler CmdBuscarIndexChanged;

	[method: DebuggerNonUserCode]
	public event ClearCtrlsEventHandler ClearCtrls;

	[method: DebuggerNonUserCode]
	public event Cmb1SelectedIndexChangedEventHandler Cmb1SelectedIndexChanged;

	[method: DebuggerNonUserCode]
	public event Cmb2SelectedIndexChangedEventHandler Cmb2SelectedIndexChanged;

	[method: DebuggerNonUserCode]
	public event Config_DGVEventHandler Config_DGV;

	[method: DebuggerNonUserCode]
	public event CellFormatting_DGVEventHandler CellFormatting_DGV;

	[method: DebuggerNonUserCode]
	public event ValidarGrabarEventHandler ValidarGrabar;

	[method: DebuggerNonUserCode]
	public event ClickNuevoEventHandler ClickNuevo;

	[method: DebuggerNonUserCode]
	public event ClickEditarEventHandler ClickEditar;

	[method: DebuggerNonUserCode]
	public event ClickGrabarEventHandler ClickGrabar;

	[method: DebuggerNonUserCode]
	public event ClickCancelarEventHandler ClickCancelar;

	[method: DebuggerNonUserCode]
	public event ClickSeleccionarEventHandler ClickSeleccionar;

	[method: DebuggerNonUserCode]
	public event ClickEliminarEventHandler ClickEliminar;

	[method: DebuggerNonUserCode]
	public event ClickBuscarEventHandler ClickBuscar;

	[method: DebuggerNonUserCode]
	public event ClickRefrescarEventHandler ClickRefrescar;

	[method: DebuggerNonUserCode]
	public event ClickImprimirEventHandler ClickImprimir;

	[method: DebuggerNonUserCode]
	public event ClickExportarExcelEventHandler ClickExportarExcel;

	[method: DebuggerNonUserCode]
	public event ClickSalirEventHandler ClickSalir;

	[method: DebuggerNonUserCode]
	public event ClickAyudaEventHandler ClickAyuda;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.frmMantBaseFTS));
		this.LBL_COMBO2 = new System.Windows.Forms.Label();
		this.CMB_2 = new System.Windows.Forms.ComboBox();
		this.LBL_COMBO1 = new System.Windows.Forms.Label();
		this.CMB_1 = new System.Windows.Forms.ComboBox();
		this.DGV_DATOS = new System.Windows.Forms.DataGridView();
		this.LBL_AL = new System.Windows.Forms.Label();
		this.LBL_DEL = new System.Windows.Forms.Label();
		this.DTP_FF = new System.Windows.Forms.DateTimePicker();
		this.DTP_FI = new System.Windows.Forms.DateTimePicker();
		this.CHK_ITERACTIVO = new System.Windows.Forms.CheckBox();
		this.CMB_OPCION = new System.Windows.Forms.ComboBox();
		this.CMD_BUSCAR = new System.Windows.Forms.Button();
		this.DGV_BUSCAR = new System.Windows.Forms.DataGridView();
		this.TXT_BUSCA = new GRLL.Common.ucText();
		this.TStMenu = new System.Windows.Forms.ToolStrip();
		this.BTN_NEW = new System.Windows.Forms.ToolStripButton();
		this.BTN_EDIT = new System.Windows.Forms.ToolStripButton();
		this.BTN_SAVE = new System.Windows.Forms.ToolStripButton();
		this.BTN_CANCEL = new System.Windows.Forms.ToolStripButton();
		this.BTN_SELEC = new System.Windows.Forms.ToolStripButton();
		this.BTN_DEL = new System.Windows.Forms.ToolStripButton();
		this.BTN_BUSCAR = new System.Windows.Forms.ToolStripButton();
		this.BTN_REFRESH = new System.Windows.Forms.ToolStripButton();
		this.BTN_PRINT = new System.Windows.Forms.ToolStripButton();
		this.BTN_EXCEL = new System.Windows.Forms.ToolStripButton();
		this.BTN_HELP = new System.Windows.Forms.ToolStripButton();
		this.BTN_SALIR = new System.Windows.Forms.ToolStripButton();
		this.LBL_TITLULO = new System.Windows.Forms.Label();
		this.FTS = new FarsiLibrary.Win.FATabStrip();
		this.TAB_LIST = new FarsiLibrary.Win.FATabStripItem();
		this.TAB_EDICION = new FarsiLibrary.Win.FATabStripItem();
		this.TAB_BUSCAR = new FarsiLibrary.Win.FATabStripItem();
		this.ImgLst = new System.Windows.Forms.ImageList(this.components);
		((System.ComponentModel.ISupportInitialize)this.DGV_DATOS).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV_BUSCAR).BeginInit();
		this.TStMenu.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.FTS).BeginInit();
		this.FTS.SuspendLayout();
		this.TAB_LIST.SuspendLayout();
		this.TAB_BUSCAR.SuspendLayout();
		this.SuspendLayout();
		this.PanelSup.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Point location = new System.Drawing.Point(0, 536);
		panelSup.Location = location;
		System.Windows.Forms.Panel panelSup2 = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(824, 24);
		panelSup2.Size = size;
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 536);
		panelInf.Location = location;
		this.LBL_COMBO2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.LBL_COMBO2.AutoSize = true;
		System.Windows.Forms.Label lBL_COMBO = this.LBL_COMBO2;
		location = new System.Drawing.Point(329, 11);
		lBL_COMBO.Location = location;
		this.LBL_COMBO2.Name = "LBL_COMBO2";
		System.Windows.Forms.Label lBL_COMBO2 = this.LBL_COMBO2;
		size = new System.Drawing.Size(38, 13);
		lBL_COMBO2.Size = size;
		this.LBL_COMBO2.TabIndex = 8;
		this.LBL_COMBO2.Text = "Label1";
		this.CMB_2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CMB_2.FormattingEnabled = true;
		System.Windows.Forms.ComboBox cMB_ = this.CMB_2;
		location = new System.Drawing.Point(374, 8);
		cMB_.Location = location;
		this.CMB_2.Name = "CMB_2";
		System.Windows.Forms.ComboBox cMB_2 = this.CMB_2;
		size = new System.Drawing.Size(242, 21);
		cMB_2.Size = size;
		this.CMB_2.TabIndex = 7;
		this.LBL_COMBO1.AutoSize = true;
		System.Windows.Forms.Label lBL_COMBO3 = this.LBL_COMBO1;
		location = new System.Drawing.Point(13, 12);
		lBL_COMBO3.Location = location;
		this.LBL_COMBO1.Name = "LBL_COMBO1";
		System.Windows.Forms.Label lBL_COMBO4 = this.LBL_COMBO1;
		size = new System.Drawing.Size(38, 13);
		lBL_COMBO4.Size = size;
		this.LBL_COMBO1.TabIndex = 6;
		this.LBL_COMBO1.Text = "Label1";
		this.CMB_1.FormattingEnabled = true;
		System.Windows.Forms.ComboBox cMB_3 = this.CMB_1;
		location = new System.Drawing.Point(52, 8);
		cMB_3.Location = location;
		this.CMB_1.Name = "CMB_1";
		System.Windows.Forms.ComboBox cMB_4 = this.CMB_1;
		size = new System.Drawing.Size(248, 21);
		cMB_4.Size = size;
		this.CMB_1.TabIndex = 5;
		this.DGV_DATOS.AllowUserToAddRows = false;
		this.DGV_DATOS.AllowUserToDeleteRows = false;
		this.DGV_DATOS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DGV_DATOS.BackgroundColor = System.Drawing.Color.LightSteelBlue;
		this.DGV_DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		System.Windows.Forms.DataGridView dGV_DATOS = this.DGV_DATOS;
		location = new System.Drawing.Point(11, 40);
		dGV_DATOS.Location = location;
		this.DGV_DATOS.Name = "DGV_DATOS";
		System.Windows.Forms.DataGridView dGV_DATOS2 = this.DGV_DATOS;
		size = new System.Drawing.Size(612, 259);
		dGV_DATOS2.Size = size;
		this.DGV_DATOS.TabIndex = 0;
		this.LBL_AL.AutoSize = true;
		System.Windows.Forms.Label lBL_AL = this.LBL_AL;
		location = new System.Drawing.Point(343, 32);
		lBL_AL.Location = location;
		this.LBL_AL.Name = "LBL_AL";
		System.Windows.Forms.Label lBL_AL2 = this.LBL_AL;
		size = new System.Drawing.Size(53, 13);
		lBL_AL2.Size = size;
		this.LBL_AL.TabIndex = 24;
		this.LBL_AL.Text = "Hasta el :";
		this.LBL_DEL.AutoSize = true;
		System.Windows.Forms.Label lBL_DEL = this.LBL_DEL;
		location = new System.Drawing.Point(202, 32);
		lBL_DEL.Location = location;
		this.LBL_DEL.Name = "LBL_DEL";
		System.Windows.Forms.Label lBL_DEL2 = this.LBL_DEL;
		size = new System.Drawing.Size(55, 13);
		lBL_DEL2.Size = size;
		this.LBL_DEL.TabIndex = 25;
		this.LBL_DEL.Text = "Desde el :";
		this.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dTP_FF = this.DTP_FF;
		location = new System.Drawing.Point(390, 28);
		dTP_FF.Location = location;
		this.DTP_FF.Name = "DTP_FF";
		System.Windows.Forms.DateTimePicker dTP_FF2 = this.DTP_FF;
		size = new System.Drawing.Size(83, 21);
		dTP_FF2.Size = size;
		this.DTP_FF.TabIndex = 23;
		this.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		System.Windows.Forms.DateTimePicker dTP_FI = this.DTP_FI;
		location = new System.Drawing.Point(252, 28);
		dTP_FI.Location = location;
		this.DTP_FI.Name = "DTP_FI";
		System.Windows.Forms.DateTimePicker dTP_FI2 = this.DTP_FI;
		size = new System.Drawing.Size(85, 21);
		dTP_FI2.Size = size;
		this.DTP_FI.TabIndex = 22;
		this.CHK_ITERACTIVO.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CHK_ITERACTIVO.AutoSize = true;
		System.Windows.Forms.CheckBox cHK_ITERACTIVO = this.CHK_ITERACTIVO;
		location = new System.Drawing.Point(500, 16);
		cHK_ITERACTIVO.Location = location;
		this.CHK_ITERACTIVO.Name = "CHK_ITERACTIVO";
		System.Windows.Forms.CheckBox cHK_ITERACTIVO2 = this.CHK_ITERACTIVO;
		size = new System.Drawing.Size(15, 14);
		cHK_ITERACTIVO2.Size = size;
		this.CHK_ITERACTIVO.TabIndex = 5;
		this.CHK_ITERACTIVO.UseVisualStyleBackColor = true;
		this.CMB_OPCION.FormattingEnabled = true;
		System.Windows.Forms.ComboBox cMB_OPCION = this.CMB_OPCION;
		location = new System.Drawing.Point(13, 12);
		cMB_OPCION.Location = location;
		this.CMB_OPCION.Name = "CMB_OPCION";
		System.Windows.Forms.ComboBox cMB_OPCION2 = this.CMB_OPCION;
		size = new System.Drawing.Size(182, 21);
		cMB_OPCION2.Size = size;
		this.CMB_OPCION.TabIndex = 4;
		this.CMD_BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		System.Windows.Forms.Button cMD_BUSCAR = this.CMD_BUSCAR;
		location = new System.Drawing.Point(516, 12);
		cMD_BUSCAR.Location = location;
		this.CMD_BUSCAR.Name = "CMD_BUSCAR";
		System.Windows.Forms.Button cMD_BUSCAR2 = this.CMD_BUSCAR;
		size = new System.Drawing.Size(65, 20);
		cMD_BUSCAR2.Size = size;
		this.CMD_BUSCAR.TabIndex = 3;
		this.CMD_BUSCAR.Text = "Buscar";
		this.CMD_BUSCAR.UseVisualStyleBackColor = true;
		this.DGV_BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DGV_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		System.Windows.Forms.DataGridView dGV_BUSCAR = this.DGV_BUSCAR;
		location = new System.Drawing.Point(9, 64);
		dGV_BUSCAR.Location = location;
		this.DGV_BUSCAR.Name = "DGV_BUSCAR";
		System.Windows.Forms.DataGridView dGV_BUSCAR2 = this.DGV_BUSCAR;
		size = new System.Drawing.Size(574, 208);
		dGV_BUSCAR2.Size = size;
		this.DGV_BUSCAR.TabIndex = 1;
		this.TXT_BUSCA.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.TXT_BUSCA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.TXT_BUSCA.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.TXT_BUSCA.ExitOnEnter = true;
		this.TXT_BUSCA.ExitOnMaxLength = true;
		this.TXT_BUSCA.ForeColorFocus = System.Drawing.Color.Blue;
		this.TXT_BUSCA.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText tXT_BUSCA = this.TXT_BUSCA;
		location = new System.Drawing.Point(198, 12);
		tXT_BUSCA.Location = location;
		this.TXT_BUSCA.MsgError = "";
		this.TXT_BUSCA.Name = "TXT_BUSCA";
		this.TXT_BUSCA.SelectOnEnter = true;
		GRLL.Common.ucText tXT_BUSCA2 = this.TXT_BUSCA;
		size = new System.Drawing.Size(296, 21);
		tXT_BUSCA2.Size = size;
		this.TXT_BUSCA.TabIndex = 2;
		this.TXT_BUSCA.TipoDato = GRLL.Common.clsVariables.TipoDato.LetrasConEspacio;
		this.TXT_BUSCA.Valida = false;
		this.TStMenu.BackColor = System.Drawing.Color.FromArgb(130, 165, 210);
		this.TStMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.TStMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.TStMenu.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TStMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.TStMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[12]
		{
			this.BTN_NEW, this.BTN_EDIT, this.BTN_SAVE, this.BTN_CANCEL, this.BTN_SELEC, this.BTN_DEL, this.BTN_BUSCAR, this.BTN_REFRESH, this.BTN_PRINT, this.BTN_EXCEL,
			this.BTN_HELP, this.BTN_SALIR
		});
		this.TStMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
		System.Windows.Forms.ToolStrip tStMenu = this.TStMenu;
		location = new System.Drawing.Point(0, 418);
		tStMenu.Location = location;
		this.TStMenu.Name = "TStMenu";
		this.TStMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		System.Windows.Forms.ToolStrip tStMenu2 = this.TStMenu;
		size = new System.Drawing.Size(683, 36);
		tStMenu2.Size = size;
		this.TStMenu.TabIndex = 5;
		this.BTN_NEW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_NEW.Image = (System.Drawing.Image)resources.GetObject("BTN_NEW.Image");
		this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BTN_NEW.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_NEW.Name = "BTN_NEW";
		System.Windows.Forms.ToolStripButton bTN_NEW = this.BTN_NEW;
		size = new System.Drawing.Size(46, 33);
		bTN_NEW.Size = size;
		this.BTN_NEW.Text = "Nuevo";
		this.BTN_NEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_NEW.ToolTipText = "Nuevo Registro";
		this.BTN_EDIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_EDIT.Image = (System.Drawing.Image)resources.GetObject("BTN_EDIT.Image");
		this.BTN_EDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_EDIT.Name = "BTN_EDIT";
		System.Windows.Forms.ToolStripButton bTN_EDIT = this.BTN_EDIT;
		size = new System.Drawing.Size(44, 33);
		bTN_EDIT.Size = size;
		this.BTN_EDIT.Text = "Editar";
		this.BTN_EDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_EDIT.ToolTipText = "Editar Registro";
		this.BTN_SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_SAVE.Image = (System.Drawing.Image)resources.GetObject("BTN_SAVE.Image");
		this.BTN_SAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_SAVE.Name = "BTN_SAVE";
		System.Windows.Forms.ToolStripButton bTN_SAVE = this.BTN_SAVE;
		size = new System.Drawing.Size(50, 33);
		bTN_SAVE.Size = size;
		this.BTN_SAVE.Text = "Grabar";
		this.BTN_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_SAVE.ToolTipText = "Grabar Registro";
		this.BTN_CANCEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_CANCEL.Image = (System.Drawing.Image)resources.GetObject("BTN_CANCEL.Image");
		this.BTN_CANCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_CANCEL.Name = "BTN_CANCEL";
		System.Windows.Forms.ToolStripButton bTN_CANCEL = this.BTN_CANCEL;
		size = new System.Drawing.Size(60, 33);
		bTN_CANCEL.Size = size;
		this.BTN_CANCEL.Text = "Cancelar";
		this.BTN_CANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_CANCEL.ToolTipText = "Cancelar Inserción / Edición";
		this.BTN_SELEC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_SELEC.Image = (System.Drawing.Image)resources.GetObject("BTN_SELEC.Image");
		this.BTN_SELEC.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_SELEC.Name = "BTN_SELEC";
		System.Windows.Forms.ToolStripButton bTN_SELEC = this.BTN_SELEC;
		size = new System.Drawing.Size(76, 33);
		bTN_SELEC.Size = size;
		this.BTN_SELEC.Text = "Seleccionar";
		this.BTN_SELEC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_SELEC.ToolTipText = "Seleccionar Registro";
		this.BTN_DEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_DEL.Image = (System.Drawing.Image)resources.GetObject("BTN_DEL.Image");
		this.BTN_DEL.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_DEL.Name = "BTN_DEL";
		System.Windows.Forms.ToolStripButton bTN_DEL = this.BTN_DEL;
		size = new System.Drawing.Size(56, 33);
		bTN_DEL.Size = size;
		this.BTN_DEL.Text = "Eliminar";
		this.BTN_DEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_DEL.ToolTipText = "Eliminar Registro";
		this.BTN_BUSCAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_BUSCAR.Image = (System.Drawing.Image)resources.GetObject("BTN_BUSCAR.Image");
		this.BTN_BUSCAR.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_BUSCAR.Name = "BTN_BUSCAR";
		System.Windows.Forms.ToolStripButton bTN_BUSCAR = this.BTN_BUSCAR;
		size = new System.Drawing.Size(49, 33);
		bTN_BUSCAR.Size = size;
		this.BTN_BUSCAR.Text = "Buscar";
		this.BTN_BUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_BUSCAR.ToolTipText = "Buscar Registro";
		this.BTN_REFRESH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_REFRESH.Image = (System.Drawing.Image)resources.GetObject("BTN_REFRESH.Image");
		this.BTN_REFRESH.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_REFRESH.Name = "BTN_REFRESH";
		System.Windows.Forms.ToolStripButton bTN_REFRESH = this.BTN_REFRESH;
		size = new System.Drawing.Size(66, 33);
		bTN_REFRESH.Size = size;
		this.BTN_REFRESH.Text = "Refrescar";
		this.BTN_REFRESH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_REFRESH.ToolTipText = "Refrescar Registros";
		this.BTN_PRINT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_PRINT.Image = (System.Drawing.Image)resources.GetObject("BTN_PRINT.Image");
		this.BTN_PRINT.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_PRINT.Name = "BTN_PRINT";
		System.Windows.Forms.ToolStripButton bTN_PRINT = this.BTN_PRINT;
		size = new System.Drawing.Size(61, 33);
		bTN_PRINT.Size = size;
		this.BTN_PRINT.Text = "Imprimir";
		this.BTN_PRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_PRINT.ToolTipText = "Imprimir Reporte";
		this.BTN_EXCEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_EXCEL.Image = (System.Drawing.Image)resources.GetObject("BTN_EXCEL.Image");
		this.BTN_EXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_EXCEL.Name = "BTN_EXCEL";
		System.Windows.Forms.ToolStripButton bTN_EXCEL = this.BTN_EXCEL;
		size = new System.Drawing.Size(40, 33);
		bTN_EXCEL.Size = size;
		this.BTN_EXCEL.Text = "Excel";
		this.BTN_EXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_EXCEL.ToolTipText = "Exportar Registros a Microsoft Excel";
		this.BTN_HELP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.BTN_HELP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_HELP.Image = (System.Drawing.Image)resources.GetObject("BTN_HELP.Image");
		this.BTN_HELP.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_HELP.Name = "BTN_HELP";
		System.Windows.Forms.ToolStripButton bTN_HELP = this.BTN_HELP;
		size = new System.Drawing.Size(47, 33);
		bTN_HELP.Size = size;
		this.BTN_HELP.Text = "Ayuda";
		this.BTN_HELP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_HELP.ToolTipText = "Ayuda para el usuario";
		this.BTN_SALIR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.BTN_SALIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BTN_SALIR.Image = (System.Drawing.Image)resources.GetObject("BTN_SALIR.Image");
		this.BTN_SALIR.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BTN_SALIR.Name = "BTN_SALIR";
		System.Windows.Forms.ToolStripButton bTN_SALIR = this.BTN_SALIR;
		size = new System.Drawing.Size(36, 33);
		bTN_SALIR.Size = size;
		this.BTN_SALIR.Text = "Salir";
		this.BTN_SALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BTN_SALIR.ToolTipText = "Salir de esta ventana";
		System.Windows.Forms.Label lBL_TITLULO = this.LBL_TITLULO;
		location = new System.Drawing.Point(106, 9);
		lBL_TITLULO.Location = location;
		this.LBL_TITLULO.Name = "LBL_TITLULO";
		System.Windows.Forms.Label lBL_TITLULO2 = this.LBL_TITLULO;
		size = new System.Drawing.Size(68, 13);
		lBL_TITLULO2.Size = size;
		this.LBL_TITLULO.TabIndex = 6;
		this.LBL_TITLULO.Text = "Titulo";
		this.LBL_TITLULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FTS.AlwaysShowClose = false;
		this.FTS.AlwaysShowMenuGlyph = false;
		this.FTS.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.FTS.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[3] { this.TAB_LIST, this.TAB_EDICION, this.TAB_BUSCAR });
		FarsiLibrary.Win.FATabStrip fTS = this.FTS;
		location = new System.Drawing.Point(12, 45);
		fTS.Location = location;
		this.FTS.Name = "FTS";
		this.FTS.SelectedItem = this.TAB_LIST;
		FarsiLibrary.Win.FATabStrip fTS2 = this.FTS;
		size = new System.Drawing.Size(650, 328);
		fTS2.Size = size;
		this.FTS.TabIndex = 7;
		this.FTS.Text = "FaTabStrip1";
		this.TAB_LIST.CanClose = false;
		this.TAB_LIST.Controls.Add(this.LBL_COMBO2);
		this.TAB_LIST.Controls.Add(this.LBL_COMBO1);
		this.TAB_LIST.Controls.Add(this.CMB_2);
		this.TAB_LIST.Controls.Add(this.DGV_DATOS);
		this.TAB_LIST.Controls.Add(this.CMB_1);
		this.TAB_LIST.IsDrawn = true;
		this.TAB_LIST.Name = "TAB_LIST";
		this.TAB_LIST.Selected = true;
		FarsiLibrary.Win.FATabStripItem tAB_LIST = this.TAB_LIST;
		size = new System.Drawing.Size(648, 307);
		tAB_LIST.Size = size;
		this.TAB_LIST.TabIndex = 0;
		this.TAB_LIST.Title = "Listado de Registro";
		this.TAB_EDICION.CanClose = false;
		this.TAB_EDICION.IsDrawn = true;
		this.TAB_EDICION.Name = "TAB_EDICION";
		FarsiLibrary.Win.FATabStripItem tAB_EDICION = this.TAB_EDICION;
		size = new System.Drawing.Size(648, 307);
		tAB_EDICION.Size = size;
		this.TAB_EDICION.TabIndex = 1;
		this.TAB_EDICION.Title = "Editar Registro";
		this.TAB_BUSCAR.CanClose = false;
		this.TAB_BUSCAR.Controls.Add(this.LBL_AL);
		this.TAB_BUSCAR.Controls.Add(this.CMB_OPCION);
		this.TAB_BUSCAR.Controls.Add(this.LBL_DEL);
		this.TAB_BUSCAR.Controls.Add(this.TXT_BUSCA);
		this.TAB_BUSCAR.Controls.Add(this.DTP_FF);
		this.TAB_BUSCAR.Controls.Add(this.DGV_BUSCAR);
		this.TAB_BUSCAR.Controls.Add(this.DTP_FI);
		this.TAB_BUSCAR.Controls.Add(this.CMD_BUSCAR);
		this.TAB_BUSCAR.Controls.Add(this.CHK_ITERACTIVO);
		this.TAB_BUSCAR.IsDrawn = true;
		this.TAB_BUSCAR.Name = "TAB_BUSCAR";
		FarsiLibrary.Win.FATabStripItem tAB_BUSCAR = this.TAB_BUSCAR;
		size = new System.Drawing.Size(648, 307);
		tAB_BUSCAR.Size = size;
		this.TAB_BUSCAR.TabIndex = 2;
		this.TAB_BUSCAR.Title = "Buscar Registro";
		this.ImgLst.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImgLst.ImageStream");
		this.ImgLst.TransparentColor = System.Drawing.Color.Transparent;
		this.ImgLst.Images.SetKeyName(0, "");
		this.ImgLst.Images.SetKeyName(1, "");
		this.ImgLst.Images.SetKeyName(2, "");
		this.ImgLst.Images.SetKeyName(3, "");
		this.ImgLst.Images.SetKeyName(4, "");
		this.ImgLst.Images.SetKeyName(5, "");
		this.ImgLst.Images.SetKeyName(6, "");
		this.ImgLst.Images.SetKeyName(7, "");
		this.ImgLst.Images.SetKeyName(8, "");
		this.ImgLst.Images.SetKeyName(9, "");
		this.ImgLst.Images.SetKeyName(10, "");
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		size = new System.Drawing.Size(683, 454);
		this.ClientSize = size;
		this.Controls.Add(this.FTS);
		this.Controls.Add(this.LBL_TITLULO);
		this.Controls.Add(this.TStMenu);
		this.MessageShow = true;
		this.Name = "frmMantBaseFTS";
		this.Text = "";
		this.TitleMsg = "frmBase";
		this.VerPanelInf = false;
		this.VerPanelSup = false;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.TStMenu, 0);
		this.Controls.SetChildIndex(this.LBL_TITLULO, 0);
		this.Controls.SetChildIndex(this.FTS, 0);
		((System.ComponentModel.ISupportInitialize)this.DGV_DATOS).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV_BUSCAR).EndInit();
		this.TStMenu.ResumeLayout(false);
		this.TStMenu.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.FTS).EndInit();
		this.FTS.ResumeLayout(false);
		this.TAB_LIST.ResumeLayout(false);
		this.TAB_LIST.PerformLayout();
		this.TAB_BUSCAR.ResumeLayout(false);
		this.TAB_BUSCAR.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

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

	public void ListarDGV(ref bool GrigDatos, string sSql)
	{
		DataGridView DGV = ((!GrigDatos) ? DGV_BUSCAR : DGV_DATOS);
		ConfiguraDataGridView(ref DGV);
		DGV.DataSource = null;
		DGV.DataSource = GetData(sSql);
		DGV.TabIndex = 0;
		Config_DGV?.Invoke(ref DGV);
	}

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

	private void Inicializar()
	{
		bResizeAutomatic = true;
		bVerTitulo = true;
		mTopGrid = 25;
	}

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

	private void DGV_DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DGV_DATOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void DGV_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_EDIT.PerformClick();
	}

	private void DGV_BUSCAR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		CellFormatting_DGV?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void DTG_BUSCAR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		BTN_SELEC.PerformClick();
	}

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

	private void frmBaseMant_Resize(object sender, EventArgs e)
	{
		Reubicar();
	}

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

	private void BTN_REFRESH_Click(object sender, EventArgs e)
	{
		bool bCancel = false;
		ClickRefrescar?.Invoke(ref bCancel);
		if (!bCancel)
		{
		}
	}

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

	private void CHK_ITERACTIVO_CheckedChanged(object sender, EventArgs e)
	{
		CMD_BUSCAR.Enabled = !CHK_ITERACTIVO.Checked;
	}

	private void frmBaseMant_ReubicaCtrls()
	{
		Reubicar();
	}

	private void BTN_HELP_Click(object sender, EventArgs e)
	{
		ClickAyuda?.Invoke();
	}

	private void TXT_BUSCA_TextChanged(object sender, EventArgs e)
	{
		if (CHK_ITERACTIVO.Checked)
		{
			CMD_BUSCAR.PerformClick();
		}
	}

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
}
