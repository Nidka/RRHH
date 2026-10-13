using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucTViewNT : UserControl
{
	public delegate void SelectedNodeEventHandler(object Sender, TreeViewEventArgs e);

	public delegate void OnErrorEventHandler(string Msg);

	public delegate void TreeView_MouseDownEventHandler(object sender, MouseEventArgs e);

	public delegate void Menu_ClickEventHandler(object sender, EventArgs e, string Menu, TreeNode nObjNode);

	private IContainer components;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("TreeView1")]
	private TreeView _TreeView1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("NuevoToolStripMenuItem")]
	private ToolStripMenuItem _NuevoToolStripMenuItem;

	[AccessedThroughProperty("ModificarToolStripMenuItem")]
	private ToolStripMenuItem _ModificarToolStripMenuItem;

	[AccessedThroughProperty("EliminarToolStripMenuItem")]
	private ToolStripMenuItem _EliminarToolStripMenuItem;

	[AccessedThroughProperty("ConsultarToolStripMenuItem")]
	private ToolStripMenuItem _ConsultarToolStripMenuItem;

	[AccessedThroughProperty("NuevoParentToolStripMenuItem")]
	private ToolStripMenuItem _NuevoParentToolStripMenuItem;

	[AccessedThroughProperty("NuevoHijoToolStripMenuItem")]
	private ToolStripMenuItem _NuevoHijoToolStripMenuItem;

	private Color oColor1;

	private Color oColor2;

	private string[] _IdFildName;

	private string[] cTabla;

	private string[] cIdFildName;

	private string[] nIdValor;

	private string[] cViewField;

	private string[] cIdFildNameWhere;

	private string[] nIdValorWhere;

	private string[] sSqlCad;

	private string[] sSqlParam;

	private bool bVerMenu;

	private bool[] bVerMenuNewParent;

	private bool[] bVerMenuNew;

	private bool[] bVerMenuMod;

	private bool[] bVerMenuDel;

	private bool[] bVerMenuConsult;

	private bool[] bVerMenuNewHijo;

	private string[] sMenuNewP;

	private string[] sMenuNew;

	private string[] sMenuMod;

	private string[] sMenuDel;

	private string[] sMenuConsult;

	private string[] sMenuNewH;

	private TreeNode nObjNode;

	private SqlConnection cConnection;

	private string sConnection;

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

	public virtual TreeView TreeView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = TreeView1_MouseDown;
			TreeViewCancelEventHandler value3 = TreeView1_BeforeExpand;
			MouseEventHandler value4 = TreeView1_MouseClick;
			TreeViewEventHandler value5 = TreeView1_AfterSelect;
			if (_TreeView1 != null)
			{
				_TreeView1.MouseDown -= value2;
				_TreeView1.BeforeExpand -= value3;
				_TreeView1.MouseClick -= value4;
				_TreeView1.AfterSelect -= value5;
			}
			_TreeView1 = value;
			if (_TreeView1 != null)
			{
				_TreeView1.MouseDown += value2;
				_TreeView1.BeforeExpand += value3;
				_TreeView1.MouseClick += value4;
				_TreeView1.AfterSelect += value5;
			}
		}
	}

	internal ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal ToolStripMenuItem NuevoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NuevoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_NuevoToolStripMenuItem != null)
			{
				_NuevoToolStripMenuItem.Click -= value2;
			}
			_NuevoToolStripMenuItem = value;
			if (_NuevoToolStripMenuItem != null)
			{
				_NuevoToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ModificarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ModificarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_ModificarToolStripMenuItem != null)
			{
				_ModificarToolStripMenuItem.Click -= value2;
			}
			_ModificarToolStripMenuItem = value;
			if (_ModificarToolStripMenuItem != null)
			{
				_ModificarToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem EliminarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EliminarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_EliminarToolStripMenuItem != null)
			{
				_EliminarToolStripMenuItem.Click -= value2;
			}
			_EliminarToolStripMenuItem = value;
			if (_EliminarToolStripMenuItem != null)
			{
				_EliminarToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem ConsultarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ConsultarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_ConsultarToolStripMenuItem != null)
			{
				_ConsultarToolStripMenuItem.Click -= value2;
			}
			_ConsultarToolStripMenuItem = value;
			if (_ConsultarToolStripMenuItem != null)
			{
				_ConsultarToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem NuevoParentToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NuevoParentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_NuevoParentToolStripMenuItem != null)
			{
				_NuevoParentToolStripMenuItem.Click -= value2;
			}
			_NuevoParentToolStripMenuItem = value;
			if (_NuevoParentToolStripMenuItem != null)
			{
				_NuevoParentToolStripMenuItem.Click += value2;
			}
		}
	}

	internal ToolStripMenuItem NuevoHijoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NuevoHijoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = NuevoToolStripMenuItem_Click;
			if (_NuevoHijoToolStripMenuItem != null)
			{
				_NuevoHijoToolStripMenuItem.Click -= value2;
			}
			_NuevoHijoToolStripMenuItem = value;
			if (_NuevoHijoToolStripMenuItem != null)
			{
				_NuevoHijoToolStripMenuItem.Click += value2;
			}
		}
	}

	public string MenuNuevoParentText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuNewP.Length - 1))
			{
				return "";
			}
			return sMenuNewP[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuNewP == null)
					{
						sMenuNewP = new string[1];
					}
					if (I > sMenuNewP.Length - 1)
					{
						sMenuNewP = (string[])Utils.CopyArray(sMenuNewP, new string[I + 1]);
					}
					sMenuNewP[I] = value;
				}
			}
		}
	}

	public string MenuNuevoText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuNew.Length - 1))
			{
				return "";
			}
			return sMenuNew[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuNew == null)
					{
						sMenuNew = new string[1];
					}
					if (I > sMenuNew.Length - 1)
					{
						sMenuNew = (string[])Utils.CopyArray(sMenuNew, new string[I + 1]);
					}
					sMenuNew[I] = value;
				}
			}
		}
	}

	public string MenuModificaText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuMod.Length - 1))
			{
				return "";
			}
			return sMenuMod[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuMod == null)
					{
						sMenuMod = new string[1];
					}
					if (I > sMenuMod.Length - 1)
					{
						sMenuMod = (string[])Utils.CopyArray(sMenuMod, new string[I + 1]);
					}
					sMenuMod[I] = value;
				}
			}
		}
	}

	public string MenuConsultaText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuConsult.Length - 1))
			{
				return "";
			}
			return sMenuConsult[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuConsult == null)
					{
						sMenuConsult = new string[1];
					}
					if (I > sMenuConsult.Length - 1)
					{
						sMenuConsult = (string[])Utils.CopyArray(sMenuConsult, new string[I + 1]);
					}
					sMenuConsult[I] = value;
				}
			}
		}
	}

	public string MenuEliminaText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuDel.Length - 1))
			{
				return "";
			}
			return sMenuDel[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuDel == null)
					{
						sMenuDel = new string[1];
					}
					if (I > sMenuDel.Length - 1)
					{
						sMenuDel = (string[])Utils.CopyArray(sMenuDel, new string[I + 1]);
					}
					sMenuDel[I] = value;
				}
			}
		}
	}

	public string MenuNuevoHijoText
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sMenuNewH.Length - 1))
			{
				return "";
			}
			return sMenuNewH[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sMenuNewH == null)
					{
						sMenuNewH = new string[1];
					}
					if (I > sMenuNewH.Length - 1)
					{
						sMenuNewH = (string[])Utils.CopyArray(sMenuNewH, new string[I + 1]);
					}
					sMenuNewH[I] = value;
				}
			}
		}
	}

	public bool MenuVer
	{
		get
		{
			return bVerMenu;
		}
		set
		{
			bVerMenu = value;
		}
	}

	public bool MenuNuevoParentVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuNewParent.Length - 1))
			{
				return false;
			}
			return bVerMenuNewParent[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuNewParent == null)
					{
						bVerMenuNewParent = new bool[1];
					}
					if (I > bVerMenuNewParent.Length - 1)
					{
						bVerMenuNewParent = (bool[])Utils.CopyArray(bVerMenuNewParent, new bool[I + 1]);
					}
					bVerMenuNewParent[I] = value;
				}
			}
		}
	}

	public bool MenuNuevoVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuNew.Length - 1))
			{
				return false;
			}
			return bVerMenuNew[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuNew == null)
					{
						bVerMenuNew = new bool[1];
					}
					if (I > bVerMenuNew.Length - 1)
					{
						bVerMenuNew = (bool[])Utils.CopyArray(bVerMenuNew, new bool[I + 1]);
					}
					bVerMenuNew[I] = value;
				}
			}
		}
	}

	public bool MenuModificaVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuMod.Length - 1))
			{
				return false;
			}
			return bVerMenuMod[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuMod == null)
					{
						bVerMenuMod = new bool[1];
					}
					if (I > bVerMenuMod.Length - 1)
					{
						bVerMenuMod = (bool[])Utils.CopyArray(bVerMenuMod, new bool[I + 1]);
					}
					bVerMenuMod[I] = value;
				}
			}
		}
	}

	public bool MenuConsultaVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuConsult.Length - 1))
			{
				return false;
			}
			return bVerMenuConsult[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuConsult == null)
					{
						bVerMenuConsult = new bool[1];
					}
					if (I > bVerMenuConsult.Length - 1)
					{
						bVerMenuConsult = (bool[])Utils.CopyArray(bVerMenuConsult, new bool[I + 1]);
					}
					bVerMenuConsult[I] = value;
				}
			}
		}
	}

	public bool MenuEliminaVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuDel.Length - 1))
			{
				return false;
			}
			return bVerMenuDel[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuDel == null)
					{
						bVerMenuDel = new bool[1];
					}
					if (I > bVerMenuDel.Length - 1)
					{
						bVerMenuDel = (bool[])Utils.CopyArray(bVerMenuDel, new bool[I + 1]);
					}
					bVerMenuDel[I] = value;
				}
			}
		}
	}

	public bool MenuNuevoHijoVer
	{
		get
		{
			if (I < 0)
			{
				return false;
			}
			if (I > checked(bVerMenuNewHijo.Length - 1))
			{
				return false;
			}
			return bVerMenuNewHijo[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (bVerMenuNewHijo == null)
					{
						bVerMenuNewHijo = new bool[1];
					}
					if (I > bVerMenuNewHijo.Length - 1)
					{
						bVerMenuNewHijo = (bool[])Utils.CopyArray(bVerMenuNewHijo, new bool[I + 1]);
					}
					bVerMenuNewHijo[I] = value;
				}
			}
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

	public string Tabla
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cTabla.Length - 1))
			{
				return "";
			}
			return cTabla[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cTabla == null)
					{
						cTabla = new string[1];
					}
					if (I > cTabla.Length - 1)
					{
						cTabla = (string[])Utils.CopyArray(cTabla, new string[I + 1]);
					}
					cTabla[I] = value.Trim();
				}
			}
		}
	}

	public string IdFldName
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdFildName.Length - 1))
			{
				return "";
			}
			return cIdFildName[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cIdFildName == null)
					{
						cIdFildName = new string[1];
					}
					if (I > cIdFildName.Length - 1)
					{
						cIdFildName = (string[])Utils.CopyArray(cIdFildName, new string[I + 1]);
					}
					cIdFildName[I] = value.Trim();
				}
			}
		}
	}

	public string ViewField
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cViewField.Length - 1))
			{
				return "";
			}
			return cViewField[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cViewField == null)
					{
						cViewField = new string[1];
					}
					if (I > cViewField.Length - 1)
					{
						cViewField = (string[])Utils.CopyArray(cViewField, new string[I + 1]);
					}
					cViewField[I] = value;
				}
			}
		}
	}

	public string IdValor
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(nIdValor.Length - 1))
			{
				return "";
			}
			return nIdValor[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (nIdValor == null)
					{
						nIdValor = new string[1];
					}
					if (I > nIdValor.Length - 1)
					{
						nIdValor = (string[])Utils.CopyArray(nIdValor, new string[I + 1]);
					}
					nIdValor[I] = value;
				}
			}
		}
	}

	public string IdFldNameWhere
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdFildNameWhere.Length - 1))
			{
				return "";
			}
			return cIdFildNameWhere[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cIdFildNameWhere == null)
					{
						cIdFildNameWhere = new string[1];
					}
					if (I > cIdFildNameWhere.Length - 1)
					{
						cIdFildNameWhere = (string[])Utils.CopyArray(cIdFildNameWhere, new string[I + 1]);
					}
					cIdFildNameWhere[I] = value.Trim();
				}
			}
		}
	}

	public string IdValorWhere
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(nIdValorWhere.Length - 1))
			{
				return "";
			}
			return nIdValorWhere[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (nIdValorWhere == null)
					{
						nIdValorWhere = new string[1];
					}
					if (I > nIdValorWhere.Length - 1)
					{
						nIdValorWhere = (string[])Utils.CopyArray(nIdValorWhere, new string[I + 1]);
					}
					nIdValorWhere[I] = value;
				}
			}
		}
	}

	public string SqlCad
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sSqlCad.Length - 1))
			{
				return "";
			}
			return sSqlCad[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sSqlCad == null)
					{
						sSqlCad = new string[1];
					}
					if (I > sSqlCad.Length - 1)
					{
						sSqlCad = (string[])Utils.CopyArray(sSqlCad, new string[I + 1]);
					}
					sSqlCad[I] = value;
				}
			}
		}
	}

	public string SqlParam
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(sSqlParam.Length - 1))
			{
				return "";
			}
			return sSqlParam[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (sSqlParam == null)
					{
						sSqlParam = new string[1];
					}
					if (I > sSqlParam.Length - 1)
					{
						sSqlParam = (string[])Utils.CopyArray(sSqlParam, new string[I + 1]);
					}
					sSqlParam[I] = value;
				}
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event SelectedNodeEventHandler SelectedNode;

	[method: DebuggerNonUserCode]
	public event OnErrorEventHandler OnError;

	[method: DebuggerNonUserCode]
	public event TreeView_MouseDownEventHandler TreeView_MouseDown;

	[method: DebuggerNonUserCode]
	public event Menu_ClickEventHandler Menu_Click;

	public ucTViewNT()
	{
		base.Load += ucTViewNT_Load;
		base.Resize += ucTViewNT_Resize;
		oColor1 = Color.AliceBlue;
		oColor2 = Color.Aqua;
		bVerMenu = false;
		sConnection = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		this.TreeView1 = new System.Windows.Forms.TreeView();
		this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.NuevoParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NuevoHijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ContextMenuStrip1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.SuspendLayout();
		this.TreeView1.HideSelection = false;
		this.TreeView1.HotTracking = true;
		System.Windows.Forms.TreeView treeView = this.TreeView1;
		System.Drawing.Point location = new System.Drawing.Point(6, 12);
		treeView.Location = location;
		this.TreeView1.Name = "TreeView1";
		System.Windows.Forms.TreeView treeView2 = this.TreeView1;
		System.Drawing.Size size = new System.Drawing.Size(138, 281);
		treeView2.Size = size;
		this.TreeView1.TabIndex = 0;
		this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.NuevoParentToolStripMenuItem, this.NuevoToolStripMenuItem, this.ModificarToolStripMenuItem, this.EliminarToolStripMenuItem, this.ConsultarToolStripMenuItem, this.NuevoHijoToolStripMenuItem });
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		System.Windows.Forms.ContextMenuStrip contextMenuStrip = this.ContextMenuStrip1;
		size = new System.Drawing.Size(152, 136);
		contextMenuStrip.Size = size;
		this.NuevoParentToolStripMenuItem.Name = "NuevoParentToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem nuevoParentToolStripMenuItem = this.NuevoParentToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		nuevoParentToolStripMenuItem.Size = size;
		this.NuevoParentToolStripMenuItem.Tag = "NuevoP";
		this.NuevoParentToolStripMenuItem.Text = "Nuevo Parent";
		this.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem = this.NuevoToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		nuevoToolStripMenuItem.Size = size;
		this.NuevoToolStripMenuItem.Tag = "Nuevo";
		this.NuevoToolStripMenuItem.Text = "Nuevo";
		this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem = this.ModificarToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		modificarToolStripMenuItem.Size = size;
		this.ModificarToolStripMenuItem.Tag = "Modificar";
		this.ModificarToolStripMenuItem.Text = "Modificar";
		this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem = this.EliminarToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		eliminarToolStripMenuItem.Size = size;
		this.EliminarToolStripMenuItem.Tag = "Eliminar";
		this.EliminarToolStripMenuItem.Text = "Eliminar";
		this.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem = this.ConsultarToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		consultarToolStripMenuItem.Size = size;
		this.ConsultarToolStripMenuItem.Tag = "Consultar";
		this.ConsultarToolStripMenuItem.Text = "Consultar";
		this.NuevoHijoToolStripMenuItem.Name = "NuevoHijoToolStripMenuItem";
		System.Windows.Forms.ToolStripMenuItem nuevoHijoToolStripMenuItem = this.NuevoHijoToolStripMenuItem;
		size = new System.Drawing.Size(151, 22);
		nuevoHijoToolStripMenuItem.Size = size;
		this.NuevoHijoToolStripMenuItem.Tag = "NuevoH";
		this.NuevoHijoToolStripMenuItem.Text = "Nuevo Hijo";
		this.GroupBox1.Controls.Add(this.TreeView1);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
		location = new System.Drawing.Point(0, -4);
		groupBox.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
		size = new System.Drawing.Size(150, 300);
		groupBox2.Size = size;
		this.GroupBox1.TabIndex = 3;
		this.GroupBox1.TabStop = false;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.GroupBox1);
		this.Name = "ucTViewNT";
		size = new System.Drawing.Size(150, 300);
		this.Size = size;
		this.ContextMenuStrip1.ResumeLayout(false);
		this.GroupBox1.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	public void Clear()
	{
		TreeView1.Nodes.Clear();
	}

	public void GetData()
	{
		LLenaSubNodos();
	}

	private void TreeView1_MouseClick(object sender, MouseEventArgs e)
	{
		Rectangle oRec = new Rectangle(0, 0, Width, Height);
		Brush oLineaBrush = new LinearGradientBrush(oRec, Color.Beige, Color.White, LinearGradientMode.Vertical);
		CreateGraphics().FillRectangle(oLineaBrush, oRec);
	}

	private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
	{
		if (Operators.CompareString(e.Node.Nodes[0].Text, "_Dummy", TextCompare: false) == 0)
		{
			e.Node.Nodes[0].Remove();
		}
		if (e.Node.Nodes.Count <= 0 && e.Node.Level <= checked(cTabla.Length - 1))
		{
			LLenaSubNodos(e.Node);
		}
	}

	private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		Rectangle oRec = new Rectangle(0, 0, Width, Height);
		Brush oLineaBrush = new LinearGradientBrush(oRec, oColor1, oColor2, LinearGradientMode.Vertical);
		CreateGraphics().FillRectangle(oLineaBrush, oRec);
		if (nIdValor == null)
		{
			nIdValor = new string[2];
		}
		if (nIdValor.Length < 2)
		{
			nIdValor = new string[2];
		}
		checked
		{
			if (e.Node.Level <= 0)
			{
				nIdValor[0] = Conversions.ToString(e.Node.Tag);
				nIdValor[1] = Conversions.ToString(-1);
			}
			else
			{
				if (nIdValor.Length < e.Node.Level + 1)
				{
					nIdValor = (string[])Utils.CopyArray(nIdValor, new string[e.Node.Level + 1 + 1]);
				}
				nIdValor[e.Node.Level - 1] = Conversions.ToString(e.Node.Parent.Tag);
				nIdValor[e.Node.Level] = Conversions.ToString(e.Node.Tag);
			}
			SelectedNode?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void LLenaSubNodos(TreeNode oNodo = null)
	{
		DataTable oDt = ((oNodo != null) ? GetHijos(oNodo) : GetHijos());
		if (oDt == null)
		{
			return;
		}
		checked
		{
			foreach (DataRow oReg in oDt.Rows)
			{
				TreeNode oNewNode = new TreeNode();
				if (oNodo == null)
				{
					oNewNode.Text = Conversions.ToString(oReg[cViewField[0]]);
					oNewNode.Tag = RuntimeHelpers.GetObjectValue(oReg[cIdFildName[0]]);
				}
				else
				{
					oNewNode.Text = Conversions.ToString(oReg[cViewField[oNodo.Level + 1]]);
					oNewNode.Tag = RuntimeHelpers.GetObjectValue(oReg[cIdFildName[oNodo.Level + 1]]);
				}
				if (oNodo == null)
				{
					TreeView1.Nodes.Add(oNewNode);
				}
				else
				{
					oNodo.Nodes.Add(oNewNode);
				}
				oNewNode.Nodes.Add("_Dummy");
			}
		}
	}

	private DataTable GetHijos(TreeNode oNodo = null)
	{
		DataSet oDs = new DataSet();
		SqlCommand oCmd = new SqlCommand();
		DataTable GetHijos;
		checked
		{
			try
			{
				if (cTabla.Length <= 1 || cIdFildName.Length <= 1)
				{
					GetHijos = null;
					goto IL_03ef;
				}
				if (cConnection == null)
				{
					oCmd.Connection = new SqlConnection(sConnection);
				}
				else
				{
					oCmd.Connection = cConnection;
				}
				if (oNodo == null)
				{
					if (sSqlCad != null && sSqlCad.Length > 0)
					{
						if (sSqlParam != null && sSqlParam[0].Length > 0)
						{
							oCmd.CommandText = sSqlCad[0] + " " + sSqlParam[0];
						}
						else
						{
							oCmd.CommandText = sSqlCad[0] + " ''";
						}
					}
					else if (nIdValorWhere != null && nIdValorWhere[0].Length > 0)
					{
						if (nIdValorWhere[0].ToString().Trim().Length > 0 && Strings.InStr(nIdValorWhere[0], ".") > 0)
						{
							oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = '" + nIdValorWhere[0].ToString() + "'";
						}
						else
						{
							oCmd.CommandText = "SELECT * FROM " + cTabla[0] + " WHERE " + cIdFildNameWhere[0] + " = " + nIdValorWhere[0].ToString();
						}
					}
					else
					{
						oCmd.CommandText = "SELECT * FROM " + cTabla[0];
					}
				}
				else if (sSqlCad != null && sSqlCad[oNodo.Level + 1].Length > 0)
				{
					if (sSqlParam != null && sSqlParam[oNodo.Level + 1].Length > 0)
					{
						oCmd.CommandText = sSqlCad[oNodo.Level + 1] + " " + sSqlParam[oNodo.Level + 1];
					}
					else
					{
						oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(sSqlCad[oNodo.Level + 1] + " '", oNodo.Tag), "'"));
					}
				}
				else if (oNodo.Tag.ToString().Trim().Length > 0 && Strings.InStr(Conversions.ToString(oNodo.Tag), ".") > 0)
				{
					oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = '"), oNodo.Tag), "'"));
				}
				else
				{
					oCmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat("SELECT * FROM " + cTabla[oNodo.Level + 1], " WHERE "), cIdFildNameWhere[oNodo.Level + 1]), " = "), oNodo.Tag));
				}
				SqlDataAdapter oDa = new SqlDataAdapter();
				oDa.SelectCommand = oCmd;
				oDa.Fill(oDs);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				OnError?.Invoke("ERROR: " + Information.Err().Description);
				GetHijos = null;
				ProjectData.ClearProjectError();
				goto IL_03ef;
			}
			return oDs.Tables[0];
		}
		IL_03ef:
		return GetHijos;
	}

	private void TreeView1_MouseDown(object sender, MouseEventArgs e)
	{
		checked
		{
			if (e.Button == MouseButtons.Right && bVerMenu)
			{
				if (TreeView1.SelectedNode == null)
				{
					ContextMenuStrip1.Items["NuevoParentToolStripMenuItem"].Visible = false;
					if (sMenuNew == null || sMenuNew.Length < 1)
					{
						ContextMenuStrip1.Items["NuevoToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuNew[0])
						{
							ContextMenuStrip1.Items[1].Text = sMenuNew[0];
						}
						ContextMenuStrip1.Items["NuevoToolStripMenuItem"].Visible = bVerMenuNew[0];
					}
					if (sMenuMod == null || sMenuMod.Length < 1)
					{
						ContextMenuStrip1.Items["ModificarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuMod[0])
						{
							ContextMenuStrip1.Items[2].Text = sMenuMod[0];
						}
						ContextMenuStrip1.Items["ModificarToolStripMenuItem"].Visible = bVerMenuMod[0];
					}
					if (sMenuDel == null || sMenuDel.Length < 1)
					{
						ContextMenuStrip1.Items["EliminarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuDel[0])
						{
							ContextMenuStrip1.Items[3].Text = sMenuDel[0];
						}
						ContextMenuStrip1.Items["EliminarToolStripMenuItem"].Visible = bVerMenuDel[0];
					}
					if (sMenuConsult == null || sMenuConsult.Length < 1)
					{
						ContextMenuStrip1.Items["ConsultarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuConsult[0])
						{
							ContextMenuStrip1.Items[4].Text = sMenuConsult[0];
						}
						ContextMenuStrip1.Items["ConsultarToolStripMenuItem"].Visible = bVerMenuConsult[0];
					}
					ContextMenuStrip1.Items["NuevoHijoToolStripMenuItem"].Visible = false;
					ContextMenuStrip1.Visible = bVerMenu;
				}
				else
				{
					int I = TreeView1.SelectedNode.Level;
					if (sMenuNewP == null || sMenuNewP.Length <= I + 1 || sMenuNewP[I + 1] == null || sMenuNewP[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["NuevoParentToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuNewParent[I + 1])
						{
							ContextMenuStrip1.Items[0].Text = sMenuNewP[I + 1];
						}
						ContextMenuStrip1.Items["NuevoParentToolStripMenuItem"].Visible = bVerMenuNewParent[I + 1];
					}
					if (sMenuNew == null || sMenuNew.Length <= I + 1 || sMenuNew[I + 1] == null || sMenuNew[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["NuevoToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuNew[I + 1])
						{
							ContextMenuStrip1.Items[1].Text = sMenuNew[I + 1];
						}
						ContextMenuStrip1.Items["NuevoToolStripMenuItem"].Visible = bVerMenuNew[I + 1];
					}
					if (sMenuMod == null || sMenuMod.Length <= I + 1 || sMenuMod[I + 1] == null || sMenuMod[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["ModificarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuMod[I + 1])
						{
							ContextMenuStrip1.Items[2].Text = sMenuMod[I + 1];
						}
						ContextMenuStrip1.Items["ModificarToolStripMenuItem"].Visible = bVerMenuMod[I + 1];
					}
					if (sMenuDel == null || sMenuDel.Length <= I + 1 || sMenuDel[I + 1] == null || sMenuDel[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["EliminarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuDel[I + 1])
						{
							ContextMenuStrip1.Items[3].Text = sMenuDel[I + 1];
						}
						ContextMenuStrip1.Items["EliminarToolStripMenuItem"].Visible = bVerMenuDel[I + 1];
					}
					if (sMenuConsult == null || sMenuConsult.Length <= I + 1 || sMenuConsult[I + 1] == null || sMenuConsult[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["ConsultarToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuConsult[I + 1])
						{
							ContextMenuStrip1.Items[4].Text = sMenuConsult[I + 1];
						}
						ContextMenuStrip1.Items["ConsultarToolStripMenuItem"].Visible = bVerMenuConsult[I + 1];
					}
					if (sMenuNewH == null || sMenuNewH.Length <= I + 1 || sMenuNewH[I + 1] == null || sMenuNewH[I + 1].Trim().Length < 2)
					{
						ContextMenuStrip1.Items["NuevoHijoToolStripMenuItem"].Visible = false;
					}
					else
					{
						if (bVerMenuNewHijo[I + 1])
						{
							ContextMenuStrip1.Items[5].Text = sMenuNewH[I + 1];
						}
						ContextMenuStrip1.Items["NuevoHijoToolStripMenuItem"].Visible = bVerMenuNewHijo[I + 1];
					}
				}
				ContextMenuStrip1.Show(TreeView1, e.Location, ToolStripDropDownDirection.Default);
			}
			TreeView_MouseDown?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToolStripMenuItem sMenu;
		if (TreeView1.SelectedNode == null)
		{
			nObjNode = null;
			sMenu = (ToolStripMenuItem)sender;
		}
		else
		{
			nObjNode = TreeView1.SelectedNode;
			sMenu = (ToolStripMenuItem)sender;
		}
		Menu_Click?.Invoke(RuntimeHelpers.GetObjectValue(sender), e, Conversions.ToString(sMenu.Tag), nObjNode);
	}

	private void ucTViewNT_Load(object sender, EventArgs e)
	{
	}

	private void ucTViewNT_Resize(object sender, EventArgs e)
	{
		GroupBox1.Size = Size;
		checked
		{
			TreeView1.Width = Size.Width - 12;
			TreeView1.Height = Size.Height - 19;
		}
	}
}
