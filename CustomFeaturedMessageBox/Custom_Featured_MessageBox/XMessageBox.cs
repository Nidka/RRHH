using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Custom_Featured_MessageBox.Properties;

namespace Custom_Featured_MessageBox;

public class XMessageBox : Form
{
	private const int minWidth = 262;

	private const int maxWidth = 600;

	private IContainer components;

	private Panel bottomPanel;

	private Button button2;

	private Button button3;

	private Button button1;

	private XTextBox TextBox1;

	private Panel bottomInnerPanel;

	private Panel leftPanel;

	private PictureBox pictureBox1;

	private XMessageBox()
	{
		InitializeComponent();
	}

	private void XmessageBox(string text, string title, Size size, Font font, Color backColor, Color foreColor, bool customSize)
	{
		Text = title;
		TextBox1.Text = text;
		Font = font;
		BackColor = backColor;
		ForeColor = foreColor;
		Graphics graphics = CreateGraphics();
		SizeF sizeF = graphics.MeasureString(text, font);
		graphics.Dispose();
		int num = ((!(sizeF.Width <= 600f)) ? 600 : ((int)sizeF.Width + 15));
		int num2 = TextBox1.LinesCount() * TextBox1.Font.Height + 40 + 40;
		if (customSize)
		{
			base.Size = size;
		}
		else
		{
			base.Size = new Size(num, num2);
		}
	}

	private void SetButtons(XMessageBoxButtons buttons)
	{
		switch (buttons)
		{
		case XMessageBoxButtons.OK:
			button2.Visible = true;
			button2.Text = "OK";
			button2.DialogResult = DialogResult.OK;
			base.ControlBox = true;
			break;
		case XMessageBoxButtons.AbortRetryIgnore:
			button1.Visible = true;
			button1.Text = "Abort";
			button1.DialogResult = DialogResult.Abort;
			button2.Visible = true;
			button2.Text = "Retry";
			button2.DialogResult = DialogResult.Retry;
			button3.Visible = true;
			button3.Text = "Ignore";
			button3.DialogResult = DialogResult.Ignore;
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.RetryCancel:
			button1.Visible = true;
			button1.Text = "Retry";
			button1.DialogResult = DialogResult.Retry;
			button1.Location = new Point(41, 3);
			button2.Visible = true;
			button2.Text = "Cancel";
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(122, 3);
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.YesNo:
			button1.Visible = true;
			button1.Text = "Yes";
			button1.DialogResult = DialogResult.Yes;
			button1.Location = new Point(41, 3);
			button2.Visible = true;
			button2.Text = "No";
			button2.DialogResult = DialogResult.No;
			button2.Location = new Point(122, 3);
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		case XMessageBoxButtons.YesNoCancel:
			button1.Visible = true;
			button1.DialogResult = DialogResult.Yes;
			button1.Text = "Yes";
			button2.Visible = true;
			button2.DialogResult = DialogResult.No;
			button2.Text = "No";
			button3.Visible = true;
			button3.DialogResult = DialogResult.Cancel;
			button3.Text = "Cancel";
			if (base.Width < 262)
			{
				base.Width = 262;
			}
			break;
		}
	}

	private void SetIcon(XMessageBoxIcon icon)
	{
		if (base.Height < 104)
		{
			base.Height = 104;
		}
		if (base.Width <= 600)
		{
			base.Width += 55;
		}
		leftPanel.Visible = true;
		switch (icon)
		{
		case XMessageBoxIcon.Information:
			pictureBox1.BackgroundImage = Resources.Information;
			break;
		case XMessageBoxIcon.Warning:
			pictureBox1.BackgroundImage = Resources.Warning;
			break;
		case XMessageBoxIcon.Error:
			pictureBox1.BackgroundImage = Resources.Error;
			break;
		case XMessageBoxIcon.Question:
			pictureBox1.BackgroundImage = Resources.QuestionMark;
			break;
		case XMessageBoxIcon.Delete:
			pictureBox1.BackgroundImage = Resources.Delete;
			break;
		}
	}

	public static DialogResult show(string text)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, "", xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons, Size size)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, xMessageBox.Font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, xMessageBox.BackColor, xMessageBox.ForeColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, Color backColor, Color foreColor)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(XMessageBoxButtons.OK);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, XMessageBoxIcon icon)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, xMessageBox.Size, xMessageBox.Font, backColor, foreColor, customSize: false);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, backColor, foreColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		return xMessageBox.ShowDialog();
	}

	public static DialogResult show(string text, string title, Color backColor, Color foreColor, XMessageBoxButtons buttons, XMessageBoxIcon icon, Size size, Font font)
	{
		XMessageBox xMessageBox = new XMessageBox();
		xMessageBox.XmessageBox(text, title, size, font, backColor, foreColor, customSize: true);
		xMessageBox.SetButtons(buttons);
		xMessageBox.SetIcon(icon);
		return xMessageBox.ShowDialog();
	}

	private void XMessageBox_Resize(object sender, EventArgs e)
	{
		int num = (bottomPanel.Width - bottomInnerPanel.Width) / 2;
		bottomInnerPanel.Location = new Point(num, bottomInnerPanel.Location.Y);
	}

	private void XMessageBox_ForeColorChanged(object sender, EventArgs e)
	{
		TextBox1.ForeColor = ForeColor;
	}

	private void XMessageBox_BackColorChanged(object sender, EventArgs e)
	{
		TextBox1.BackColor = BackColor;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.bottomPanel = new System.Windows.Forms.Panel();
		this.bottomInnerPanel = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.leftPanel = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.TextBox1 = new Custom_Featured_MessageBox.XTextBox();
		this.bottomPanel.SuspendLayout();
		this.bottomInnerPanel.SuspendLayout();
		this.leftPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bottomPanel.Controls.Add(this.bottomInnerPanel);
		this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.bottomPanel.Location = new System.Drawing.Point(10, 38);
		this.bottomPanel.Name = "bottomPanel";
		this.bottomPanel.Size = new System.Drawing.Size(232, 30);
		this.bottomPanel.TabIndex = 1;
		this.bottomInnerPanel.Controls.Add(this.button2);
		this.bottomInnerPanel.Controls.Add(this.button1);
		this.bottomInnerPanel.Controls.Add(this.button3);
		this.bottomInnerPanel.Location = new System.Drawing.Point(0, 0);
		this.bottomInnerPanel.Name = "bottomInnerPanel";
		this.bottomInnerPanel.Size = new System.Drawing.Size(236, 30);
		this.bottomInnerPanel.TabIndex = 3;
		this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.button2.Location = new System.Drawing.Point(81, 3);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(75, 23);
		this.button2.TabIndex = 0;
		this.button2.Text = "Button2";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Visible = false;
		this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.button1.Location = new System.Drawing.Point(0, 3);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 1;
		this.button1.Text = "Button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Visible = false;
		this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.button3.Location = new System.Drawing.Point(162, 3);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(75, 23);
		this.button3.TabIndex = 3;
		this.button3.Text = "Button3";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Visible = false;
		this.leftPanel.Controls.Add(this.pictureBox1);
		this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.leftPanel.Location = new System.Drawing.Point(10, 10);
		this.leftPanel.Name = "leftPanel";
		this.leftPanel.Size = new System.Drawing.Size(48, 28);
		this.leftPanel.TabIndex = 3;
		this.leftPanel.Visible = false;
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		this.pictureBox1.Location = new System.Drawing.Point(0, 0);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(32, 32);
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Location = new System.Drawing.Point(58, 10);
		this.TextBox1.MaxLength = 0;
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(184, 28);
		this.TextBox1.TabIndex = 0;
		this.TextBox1.TabStop = false;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(252, 68);
		base.ControlBox = false;
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.leftPanel);
		base.Controls.Add(this.bottomPanel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "XMessageBox";
		base.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Form1";
		base.Resize += new System.EventHandler(XMessageBox_Resize);
		base.ForeColorChanged += new System.EventHandler(XMessageBox_ForeColorChanged);
		base.BackColorChanged += new System.EventHandler(XMessageBox_BackColorChanged);
		this.bottomPanel.ResumeLayout(false);
		this.bottomInnerPanel.ResumeLayout(false);
		this.leftPanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
