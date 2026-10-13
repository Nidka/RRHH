using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
[DefaultEvent("SelectionValue")]
public class ucTextCombo : UserControl
{
	public delegate void SelectionValueEventHandler();

	private IContainer components;

	[AccessedThroughProperty("pError")]
	private ErrorProvider _pError;

	[AccessedThroughProperty("cbo")]
	private ucComboBox _cbo;

	[AccessedThroughProperty("txtCod")]
	private ucTextBox _txtCod;

	private DataTable _DataSource;

	internal ErrorProvider pError
	{
		[DebuggerNonUserCode]
		get
		{
			return _pError;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pError = value;
		}
	}

	private ucComboBox cbo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cbo_SelectedIndexChanged;
			EventHandler value3 = cbo_DropDown;
			if (_cbo != null)
			{
				_cbo.SelectedIndexChanged -= value2;
				_cbo.DropDown -= value3;
			}
			_cbo = value;
			if (_cbo != null)
			{
				_cbo.SelectedIndexChanged += value2;
				_cbo.DropDown += value3;
			}
		}
	}

	private ucTextBox txtCod
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = txtCod_TextChanged;
			ucTextBox.EnterPressEventHandler obj = txtCod_EnterPress;
			if (_txtCod != null)
			{
				_txtCod.TextChanged -= value2;
				_txtCod.EnterPress -= obj;
			}
			_txtCod = value;
			if (_txtCod != null)
			{
				_txtCod.TextChanged += value2;
				_txtCod.EnterPress += obj;
			}
		}
	}

	public DataTable Datasource
	{
		get
		{
			return _DataSource;
		}
		set
		{
			_DataSource = value;
		}
	}

	public string ValueMember
	{
		get
		{
			return cbo.ValueMember;
		}
		set
		{
			cbo.ValueMember = value;
		}
	}

	public string DisplayMember
	{
		get
		{
			return cbo.DisplayMember;
		}
		set
		{
			cbo.DisplayMember = value;
		}
	}

	[DefaultValue(0)]
	public int TextPadLeft
	{
		get
		{
			return txtCod.PadLeftLenght;
		}
		set
		{
			txtCod.PadLeftLenght = value;
		}
	}

	[DefaultValue(32767)]
	public int MaxLength
	{
		get
		{
			return txtCod.MaxLength;
		}
		set
		{
			txtCod.MaxLength = value;
		}
	}

	public string ValorSeleccionado
	{
		get
		{
			return txtCod.Text;
		}
		set
		{
			txtCod.Text = value;
			if (txtCod.Text != null && Operators.CompareString(txtCod.Text, "", TextCompare: false) != 0)
			{
				txtCod_EnterPress();
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event SelectionValueEventHandler SelectionValue;

	[DebuggerNonUserCode]
	public ucTextCombo()
	{
		base.Load += ucTextCombo_Load;
		base.Resize += ucTextCombo_Resize;
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
		this.pError = new System.Windows.Forms.ErrorProvider(this.components);
		this.cbo = new GRLL.Common.ucComboBox();
		this.txtCod = new GRLL.Common.ucTextBox(this.components);
		((System.ComponentModel.ISupportInitialize)this.pError).BeginInit();
		this.SuspendLayout();
		this.pError.ContainerControl = this;
		this.cbo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.cbo.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.cbo.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cbo.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbo.FormattingEnabled = true;
		this.cbo.IncluirNinguno = false;
		GRLL.Common.ucComboBox obj = this.cbo;
		System.Drawing.Point location = new System.Drawing.Point(38, 0);
		obj.Location = location;
		this.cbo.Name = "cbo";
		GRLL.Common.ucComboBox obj2 = this.cbo;
		System.Drawing.Size size = new System.Drawing.Size(195, 21);
		obj2.Size = size;
		this.cbo.TabIndex = 1;
		this.cbo.TabStop = false;
		this.txtCod.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtCod.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCod.Formato = null;
		this.txtCod.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox obj3 = this.txtCod;
		location = new System.Drawing.Point(0, 0);
		obj3.Location = location;
		this.txtCod.Name = "txtCod";
		this.txtCod.NormalColor = System.Drawing.SystemColors.Window;
		this.txtCod.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.txtCod.OnErrorBlankText = "";
		this.txtCod.PadLeftLenght = 0;
		this.txtCod.RegularExpression = "^[0-9]*$";
		this.txtCod.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.txtCod.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox obj4 = this.txtCod;
		size = new System.Drawing.Size(37, 21);
		obj4.Size = size;
		this.txtCod.TabIndex = 0;
		this.txtCod.TabNextControl = true;
		this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtCod.Tipo = GRLL.Common.ucTextBox.TipoDato.Enteros;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.cbo);
		this.Controls.Add(this.txtCod);
		this.Name = "ucTextCombo";
		size = new System.Drawing.Size(233, 94);
		this.Size = size;
		((System.ComponentModel.ISupportInitialize)this.pError).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	public new void Show()
	{
		string mivalor = default(string);
		if (ValorSeleccionado.Trim().Length != 0)
		{
			mivalor = ValorSeleccionado;
		}
		cbo.DataSource = _DataSource;
		if (mivalor != null)
		{
			cbo.SelectedValue = mivalor;
		}
	}

	private void ucTextCombo_Load(object sender, EventArgs e)
	{
		cbo.DropDownStyle = ComboBoxStyle.DropDownList;
	}

	private void cbo_DropDown(object sender, EventArgs e)
	{
		FindWidthForDropDown();
	}

	private void txtCod_EnterPress()
	{
		if (cbo.DataSource == null)
		{
			cbo.DataSource = _DataSource;
		}
		if (_DataSource == null)
		{
			return;
		}
		foreach (DataRow dr in _DataSource.Rows)
		{
			if (Operators.CompareString(dr[cbo.ValueMember].ToString().Trim().ToUpper(), txtCod.Text.Trim().ToUpper(), TextCompare: false) == 0)
			{
				cbo.SelectedValue = txtCod.Text.Trim();
				return;
			}
		}
		pError.SetError(txtCod, "No se encontró el registro : " + txtCod.Text);
		txtCod.Clear();
		cbo.SelectedIndex = -1;
	}

	private void ucTextCombo_Resize(object sender, EventArgs e)
	{
		try
		{
			Height = cbo.Height;
			cbo.Width = checked(Width - cbo.Left);
			if (Width < 60)
			{
				Width = 60;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void cbo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cbo.SelectedValue == null)
		{
			txtCod.Clear();
			return;
		}
		txtCod.Text = cbo.SelectedValue.ToString().Trim();
		SelectionValue?.Invoke();
		pError.Clear();
	}

	private void FindWidthForDropDown()
	{
		Graphics g = CreateGraphics();
		bool IsDatabound = ((cbo.DataSource != null && Operators.CompareString(cbo.DisplayMember, "", TextCompare: false) != 0) ? true : false);
		int WidestWidth = cbo.DropDownWidth;
		checked
		{
			int num = cbo.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string ValueToMeasure = ((!IsDatabound) ? ((string)cbo.Items[i]) : ((string)((DataRowView)cbo.Items[i])[cbo.DisplayMember]));
				int CurrentWidth = (int)Math.Round(g.MeasureString(ValueToMeasure, cbo.Font).Width);
				if (CurrentWidth > WidestWidth)
				{
					WidestWidth = CurrentWidth;
				}
			}
			cbo.DropDownWidth = WidestWidth;
			g.Dispose();
		}
	}

	private void txtCod_TextChanged(object sender, EventArgs e)
	{
	}
}
