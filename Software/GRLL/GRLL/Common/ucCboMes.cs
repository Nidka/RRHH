using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GRLL.Common;

public class ucCboMes : ComboBox
{
	private IContainer components;

	public ucCboMes(IContainer Container)
	{
		InitializeComponent();
		Container.Add(this);
		DataTable dt = new DataTable
		{
			Columns = { "IDMes", "Mes" }
		};
		int I = 1;
		do
		{
			DataRow dr = dt.NewRow();
			dr["IDMes"] = I.ToString();
			dr["Mes"] = DateAndTime.MonthName(I).ToUpper();
			dt.Rows.Add(dr);
			I = checked(I + 1);
		}
		while (I <= 12);
		DisplayMember = "Mes";
		ValueMember = "IDMes";
		DataSource = dt;
	}

	public ucCboMes()
	{
		InitializeComponent();
		DataTable dt = new DataTable
		{
			Columns = { "IDMes", "Mes" }
		};
		int I = 1;
		do
		{
			DataRow dr = dt.NewRow();
			dr["IDMes"] = I.ToString();
			dr["Mes"] = DateAndTime.MonthName(I).ToUpper();
			dt.Rows.Add(dr);
			I = checked(I + 1);
		}
		while (I <= 12);
		DisplayMember = "Mes";
		ValueMember = "IDMes";
		DataSource = dt;
	}

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
		this.SuspendLayout();
		this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ResumeLayout(false);
	}
}
