using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class frmBaseImg : frmBase1
{
	private IContainer components;

	[AccessedThroughProperty("ImgLstB")]
	private ImageList _ImgLstB;

	public virtual ImageList ImgLstB
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImgLstB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImgLstB = value;
		}
	}

	[DebuggerNonUserCode]
	public frmBaseImg()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.frmBaseImg));
		this.ImgLstB = new System.Windows.Forms.ImageList(this.components);
		this.SuspendLayout();
		this.ImgLstB.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImgLstB.ImageStream");
		this.ImgLstB.TransparentColor = System.Drawing.Color.Transparent;
		this.ImgLstB.Images.SetKeyName(0, "Salir_5.jpg");
		this.ImgLstB.Images.SetKeyName(1, "page_white_star.png");
		this.ImgLstB.Images.SetKeyName(2, "save.ico");
		this.ImgLstB.Images.SetKeyName(3, "Icon 247.ico");
		this.ImgLstB.Images.SetKeyName(4, "Wrong.png");
		this.ImgLstB.Images.SetKeyName(5, "223.png");
		this.ImgLstB.Images.SetKeyName(6, "Wincal.png");
		this.ImgLstB.Images.SetKeyName(7, "Wordpad.png");
		this.ImgLstB.Images.SetKeyName(8, "mobsync.png");
		this.ImgLstB.Images.SetKeyName(9, "Notepad.png");
		this.ImgLstB.Images.SetKeyName(10, "Recycle Bin Empty.png");
		this.ImgLstB.Images.SetKeyName(11, "Recycle Bin Full.png");
		this.ImgLstB.Images.SetKeyName(12, "Search.png");
		this.ImgLstB.Images.SetKeyName(13, "Crystal_Clear_mimetype_recycled.png");
		this.ImgLstB.Images.SetKeyName(14, "Crystal_Clear_action_fileprint.png");
		this.ImgLstB.Images.SetKeyName(15, "Crystal_Clear_action_fonts.png");
		this.ImgLstB.Images.SetKeyName(16, "Crystal_Clear_app_khelpcenter.png");
		this.ImgLstB.Images.SetKeyName(17, "Salir.jpg");
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		System.Drawing.Size clientSize = new System.Drawing.Size(793, 502);
		this.ClientSize = clientSize;
		this.MessageShow = true;
		this.Name = "frmBaseImg1";
		this.TitleMsg = "frmBase1";
		this.ResumeLayout(false);
	}
}
