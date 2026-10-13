using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GRLL.Common;

public class ucCboAnio : ComboBox
{
	private IContainer components;

	public ucCboAnio(IContainer Container)
	{
		InitializeComponent();
		Container.Add(this);
		DataTable dt = new DataTable
		{
			Columns = { "IdAnio", "Anio" }
		};
		for (int I = DateTime.Now.Year; I >= 2000; I = checked(I + -1))
		{
			DataRow dr = dt.NewRow();
			dr[0] = Strings.Right(I.ToString(), 2);
			dr[1] = I.ToString();
			dt.Rows.Add(dr);
		}
		DisplayMember = "Anio";
		ValueMember = "IDAnio";
		DataSource = dt;
	}

	public ucCboAnio()
	{
		InitializeComponent();
		DataTable dt = new DataTable
		{
			Columns = { "IdAnio", "Anio" }
		};
		for (int I = DateTime.Now.Year; I >= 2000; I = checked(I + -1))
		{
			DataRow dr = dt.NewRow();
			dr[0] = Strings.Right(I.ToString(), 2);
			dr[1] = I.ToString();
		}
		DisplayMember = "Anio";
		ValueMember = "IDAnio";
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
