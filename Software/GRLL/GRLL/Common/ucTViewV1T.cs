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
public class ucTViewV1T : UserControl
{
	public delegate void SelectedNodeEventHandler(object Sender, TreeViewEventArgs e);

	public delegate void TVW_MouseDownEventHandler(object sender, MouseEventArgs e);

	private IContainer components;

	[AccessedThroughProperty("TreeView1")]
	private ucTVWVista _TreeView1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	private Color oColor1;

	private Color oColor2;

	private string cTabla;

	private string[] cIdField1;

	private string cViewField;

	private string[] cIdParentField1;

	private string cSql;

	private string cWhere;

	private string cWhereAdd;

	private SqlConnection cConnection;

	private string sConnection;

	private bool _IdIsString;

	public virtual ucTVWVista TreeView1
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
			TreeViewCancelEventHandler value2 = TreeView1_BeforeExpand;
			MouseEventHandler value3 = TreeView1_MouseClick;
			TreeViewEventHandler value4 = TreeView1_AfterSelect;
			MouseEventHandler value5 = TreeView1_MouseDown;
			if (_TreeView1 != null)
			{
				_TreeView1.BeforeExpand -= value2;
				_TreeView1.MouseClick -= value3;
				_TreeView1.AfterSelect -= value4;
				_TreeView1.MouseDown -= value5;
			}
			_TreeView1 = value;
			if (_TreeView1 != null)
			{
				_TreeView1.BeforeExpand += value2;
				_TreeView1.MouseClick += value3;
				_TreeView1.AfterSelect += value4;
				_TreeView1.MouseDown += value5;
			}
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

	public bool IdIsString
	{
		get
		{
			return _IdIsString;
		}
		set
		{
			_IdIsString = value;
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

	public string cadWhereAdd
	{
		get
		{
			return cWhereAdd;
		}
		set
		{
			cWhereAdd = value.Trim();
		}
	}

	public string cadWhere
	{
		get
		{
			return cWhere;
		}
		set
		{
			cWhere = value.Trim();
		}
	}

	public string cadSql
	{
		get
		{
			return cSql;
		}
		set
		{
			cSql = value.Trim();
		}
	}

	public string idField1
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdField1.Length - 1))
			{
				return "";
			}
			return cIdField1[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cIdField1 == null)
					{
						cIdField1 = new string[1];
					}
					if (I > cIdField1.Length - 1)
					{
						cIdField1 = (string[])Utils.CopyArray(cIdField1, new string[I + 1]);
					}
					cIdField1[I] = value.Trim();
				}
			}
		}
	}

	public string idField_Val
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdField1.Length - 1))
			{
				return "";
			}
			if (nodo == null)
			{
				return "";
			}
			if (nodo.Tag == null)
			{
				return "";
			}
			string[] tArray = nodo.Tag.ToString().Split('|');
			return tArray[I];
		}
	}

	public string idParentField1
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdParentField1.Length - 1))
			{
				return "";
			}
			return cIdParentField1[I];
		}
		set
		{
			checked
			{
				if (I >= 0)
				{
					if (cIdParentField1 == null)
					{
						cIdParentField1 = new string[1];
					}
					if (I > cIdParentField1.Length - 1)
					{
						cIdParentField1 = (string[])Utils.CopyArray(cIdParentField1, new string[I + 1]);
					}
					cIdParentField1[I] = value.Trim();
				}
			}
		}
	}

	public string idParentField_Val
	{
		get
		{
			if (I < 0)
			{
				return "";
			}
			if (I > checked(cIdParentField1.Length - 1))
			{
				return "";
			}
			if (nodo == null)
			{
				return "";
			}
			if (nodo.Parent == null)
			{
				return "";
			}
			if (nodo.Parent.Tag == null)
			{
				return "";
			}
			string[] tArray = nodo.Parent.Tag.ToString().Split('|');
			return tArray[I];
		}
	}

	public string Tabla
	{
		get
		{
			return cTabla;
		}
		set
		{
			cTabla = value.Trim();
		}
	}

	public string ViewField
	{
		get
		{
			return cViewField;
		}
		set
		{
			cViewField = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event SelectedNodeEventHandler SelectedNode;

	[method: DebuggerNonUserCode]
	public event TVW_MouseDownEventHandler TVW_MouseDown;

	public ucTViewV1T()
	{
		base.Resize += ucTView1T_Resize;
		oColor1 = Color.AliceBlue;
		oColor2 = Color.Aqua;
		cTabla = "";
		cViewField = "";
		cSql = "";
		cWhere = "";
		cWhereAdd = "";
		sConnection = "";
		_IdIsString = false;
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
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TreeView1 = new GRLL.Common.ucTVWVista();
		this.GroupBox1.SuspendLayout();
		this.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TreeView1);
		System.Windows.Forms.GroupBox groupBox = this.GroupBox1;
		System.Drawing.Point location = new System.Drawing.Point(0, -4);
		groupBox.Location = location;
		System.Windows.Forms.GroupBox groupBox2 = this.GroupBox1;
		System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(0);
		groupBox2.Margin = margin;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox3 = this.GroupBox1;
		System.Drawing.Size size = new System.Drawing.Size(150, 300);
		groupBox3.Size = size;
		this.GroupBox1.TabIndex = 3;
		this.GroupBox1.TabStop = false;
		this.TreeView1.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
		this.TreeView1.ExpanderStyle = GRLL.Common.ucTVWVista.TreeExpanderStyle.PlusMinus;
		this.TreeView1.FontColorHotTracking = System.Drawing.Color.Gainsboro;
		this.TreeView1.FontHotTracking = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TreeView1.ForeColor = System.Drawing.Color.DarkBlue;
		this.TreeView1.FullRowSelect = true;
		this.TreeView1.HideSelection = false;
		this.TreeView1.HotTracking = true;
		GRLL.Common.ucTVWVista treeView = this.TreeView1;
		location = new System.Drawing.Point(6, 12);
		treeView.Location = location;
		this.TreeView1.Name = "TreeView1";
		this.TreeView1.NodeBaseColor = System.Drawing.Color.Cornsilk;
		this.TreeView1.NodeColor = System.Drawing.Color.FromArgb(128, 64, 64);
		GRLL.Common.ucTVWVista treeView2 = this.TreeView1;
		size = new System.Drawing.Size(138, 281);
		treeView2.Size = size;
		this.TreeView1.TabIndex = 0;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.GroupBox1);
		this.Name = "ucTViewV1T";
		size = new System.Drawing.Size(150, 300);
		this.Size = size;
		this.GroupBox1.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		Rectangle oRec = new Rectangle(0, 0, Width, Height);
		Brush oLineaBrush = new LinearGradientBrush(oRec, oColor1, oColor2, LinearGradientMode.Vertical);
		CreateGraphics().FillRectangle(oLineaBrush, oRec);
		SelectedNode?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void TreeView1_MouseClick(object sender, MouseEventArgs e)
	{
		Rectangle oRec = new Rectangle(0, 0, Width, Height);
		Brush oLineaBrush = new LinearGradientBrush(oRec, Color.Beige, Color.White, LinearGradientMode.Vertical);
		CreateGraphics().FillRectangle(oLineaBrush, oRec);
	}

	public void GetData()
	{
		TreeView1.Nodes.Clear();
		LLenaSubNodos();
	}

	public void GetData(int[] nCodPadre1)
	{
		VistaNode oNodo = null;
		TreeView1.Nodes.Clear();
		DataTable oDt = GetHijos(nCodPadre1);
		if (oDt == null)
		{
			return;
		}
		checked
		{
			foreach (DataRow oReg in oDt.Rows)
			{
				VistaNode oNewNode = new VistaNode();
				oNewNode.Text = Conversions.ToString(oReg[cViewField]);
				oNewNode.Name = Conversions.ToString(oReg[cViewField]);
				oNewNode.Title = true;
				if (_IdIsString)
				{
					oNewNode.Tag = RuntimeHelpers.GetObjectValue(oReg[cIdField1[0]]);
				}
				else
				{
					int num = cIdField1.Length - 1;
					for (int I = 0; I <= num; I++)
					{
						VistaNode vistaNode = oNewNode;
						vistaNode.Tag = Operators.ConcatenateObject(vistaNode.Tag, Operators.ConcatenateObject(Interaction.IIf(I > 0, "|", ""), oReg[cIdField1[I]]));
					}
				}
				if (oNodo == null)
				{
					TreeView1.Nodes.Add(oNewNode);
				}
				else
				{
					oNodo.Nodes.Add(oNewNode);
				}
			}
		}
	}

	public void GetData(string[] nCodPadre1)
	{
		VistaNode oNodo = null;
		TreeView1.Nodes.Clear();
		DataTable oDt = GetHijos(nCodPadre1);
		if (oDt == null)
		{
			return;
		}
		checked
		{
			foreach (DataRow oReg in oDt.Rows)
			{
				VistaNode oNewNode = new VistaNode();
				oNewNode.Text = Conversions.ToString(oReg[cViewField]);
				oNewNode.Name = Conversions.ToString(oReg[cViewField]);
				oNewNode.Title = true;
				if (_IdIsString)
				{
					oNewNode.Tag = RuntimeHelpers.GetObjectValue(oReg[cIdField1[0]]);
				}
				else
				{
					int num = cIdField1.Length - 1;
					for (int I = 0; I <= num; I++)
					{
						VistaNode vistaNode = oNewNode;
						vistaNode.Tag = Operators.ConcatenateObject(vistaNode.Tag, Operators.AddObject(Interaction.IIf(I > 0, "|", ""), oReg[cIdField1[I]]));
					}
				}
				if (oNodo == null)
				{
					TreeView1.Nodes.Add(oNewNode);
				}
				else
				{
					oNodo.Nodes.Add(oNewNode);
				}
			}
		}
	}

	private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
	{
		if (Operators.CompareString(e.Node.Nodes[0].Text, "_Dummy", TextCompare: false) == 0)
		{
			e.Node.Nodes[0].Remove();
		}
		if (e.Node.Nodes.Count <= 0)
		{
			LLenaSubNodos((VistaNode)e.Node);
		}
	}

	private void LLenaSubNodos(VistaNode oNodo = null)
	{
		int[] iNodH = new int[1] { 0 };
		string[] iNodHs = new string[1] { "" };
		checked
		{
			if (oNodo != null)
			{
				string[] iNodH_T = oNodo.Tag.ToString().Split('|');
				int num = iNodH_T.Length - 1;
				for (int I = 0; I <= num; I++)
				{
					if (_IdIsString)
					{
						iNodHs = (string[])Utils.CopyArray(iNodHs, new string[I + 1]);
						iNodHs[I] = iNodH_T[I];
					}
					else
					{
						iNodH = (int[])Utils.CopyArray(iNodH, new int[I + 1]);
						iNodH[I] = (int)Math.Round(Conversion.Val(iNodH_T[I]));
					}
				}
			}
			DataTable oDt = ((!_IdIsString) ? GetHijos(iNodH) : GetHijos(iNodHs));
			if (oDt == null)
			{
				return;
			}
			foreach (DataRow oReg in oDt.Rows)
			{
				VistaNode oNewNode = new VistaNode();
				oNewNode.Text = Conversions.ToString(oReg[cViewField]);
				oNewNode.Name = Conversions.ToString(oReg[cViewField]);
				oNewNode.Title = true;
				oNewNode.Tag = "";
				if (_IdIsString)
				{
					oNewNode.Tag = RuntimeHelpers.GetObjectValue(oReg[cIdField1[0]]);
				}
				else
				{
					int num2 = cIdField1.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						VistaNode vistaNode = oNewNode;
						vistaNode.Tag = Operators.ConcatenateObject(vistaNode.Tag, Operators.ConcatenateObject(Interaction.IIf(i > 0, "|", ""), oReg[cIdField1[i]]));
					}
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

	private DataTable GetHijos(int[] nCodPadre1)
	{
		DataSet oDs = new DataSet();
		SqlCommand oCmd = new SqlCommand();
		DataTable GetHijos;
		checked
		{
			try
			{
				if (cIdParentField1.Length > nCodPadre1.Length)
				{
					int num = nCodPadre1.Length;
					int num2 = cIdParentField1.Length - 1;
					for (int I = num; I <= num2; I++)
					{
						nCodPadre1 = (int[])Utils.CopyArray(nCodPadre1, new int[I + 1]);
						nCodPadre1[I] = 0;
					}
				}
				string sSql;
				if (cSql.Trim().Length < 1)
				{
					if (cTabla.Length <= 0 || cIdParentField1.Length <= 0)
					{
						GetHijos = null;
						goto IL_021a;
					}
					sSql = "SELECT * FROM " + cTabla + " WHERE ";
					int num3 = cIdParentField1.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						sSql = Conversions.ToString(Operators.ConcatenateObject(sSql, Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(i > 0, " AND ", ""), cIdParentField1[i]), Interaction.IIf(nCodPadre1[i] <= 0, " IS Null ", " = " + nCodPadre1[i]))));
					}
				}
				else
				{
					sSql = cSql;
					int num4 = cIdParentField1.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						sSql = Conversions.ToString(Operators.ConcatenateObject(sSql, Operators.ConcatenateObject(Interaction.IIf(j > 0, ", ", RuntimeHelpers.GetObjectValue(Interaction.IIf(Strings.InStr(sSql, " ") > 0, ", ", " "))), nCodPadre1[j])));
					}
				}
				if (cConnection == null)
				{
					oCmd.Connection = new SqlConnection(sConnection);
				}
				else
				{
					oCmd.Connection = cConnection;
				}
				oCmd.CommandText = sSql;
				SqlDataAdapter oDa = new SqlDataAdapter();
				oDa.SelectCommand = oCmd;
				oDa.Fill(oDs);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("ERROR: " + Information.Err().Description, "Jerarquia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				GetHijos = null;
				ProjectData.ClearProjectError();
				goto IL_021a;
			}
			finally
			{
			}
			return oDs.Tables[0];
		}
		IL_021a:
		return GetHijos;
	}

	private DataTable GetHijos(string[] nCodPadre1)
	{
		DataSet oDs = new DataSet();
		SqlCommand oCmd = new SqlCommand();
		DataTable GetHijos;
		checked
		{
			try
			{
				if (cIdParentField1.Length > nCodPadre1.Length)
				{
					int num = nCodPadre1.Length;
					int num2 = cIdParentField1.Length - 1;
					for (int I = num; I <= num2; I++)
					{
						nCodPadre1 = (string[])Utils.CopyArray(nCodPadre1, new string[I + 1]);
						nCodPadre1[I] = "";
					}
				}
				string sSql;
				if (cSql.Trim().Length < 1)
				{
					if (cTabla.Length <= 0 || cIdParentField1.Length <= 0)
					{
						GetHijos = null;
						goto IL_0236;
					}
					sSql = "SELECT * FROM " + cTabla + " WHERE ";
					int num3 = cIdParentField1.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						sSql = Conversions.ToString(Operators.ConcatenateObject(sSql, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(i > 0, " AND ", ""), cIdParentField1[i]), Interaction.IIf(Conversions.ToDouble(nCodPadre1[i]) <= 0.0, " IS Null ", " = '" + nCodPadre1[i].ToString())), "' ")));
					}
				}
				else
				{
					sSql = cSql;
					int num4 = cIdParentField1.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						sSql = Conversions.ToString(Operators.ConcatenateObject(sSql, Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(j > 0, ", '", RuntimeHelpers.GetObjectValue(Interaction.IIf(Strings.InStr(sSql, " ") > 0, ", '", " '"))), nCodPadre1[j]), "' ")));
					}
				}
				if (cConnection == null)
				{
					oCmd.Connection = new SqlConnection(sConnection);
				}
				else
				{
					oCmd.Connection = cConnection;
				}
				oCmd.CommandText = sSql;
				SqlDataAdapter oDa = new SqlDataAdapter();
				oDa.SelectCommand = oCmd;
				oDa.Fill(oDs);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("ERROR: " + Information.Err().Description, "Jerarquia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				GetHijos = null;
				ProjectData.ClearProjectError();
				goto IL_0236;
			}
			finally
			{
			}
			return oDs.Tables[0];
		}
		IL_0236:
		return GetHijos;
	}

	private void TreeView1_MouseDown(object sender, MouseEventArgs e)
	{
		TVW_MouseDown?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ucTView1T_Resize(object sender, EventArgs e)
	{
		GroupBox1.Size = Size;
		checked
		{
			TreeView1.Width = Size.Width - 12;
			TreeView1.Height = Size.Height - 19;
		}
	}
}
