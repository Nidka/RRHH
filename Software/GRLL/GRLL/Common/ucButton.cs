using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRLL.Common;

public class ucButton : Button
{
	public ucButton()
	{
		base.Resize += uc_Button_Resize;
		FlatStyle = FlatStyle.Flat;
		Cursor = Cursors.Hand;
		FlatAppearance.BorderSize = 0;
		FlatAppearance.MouseDownBackColor = Color.DarkGray;
		FlatStyle = FlatStyle.Flat;
		ImageAlign = ContentAlignment.MiddleLeft;
		TextAlign = ContentAlignment.MiddleRight;
		UseVisualStyleBackColor = true;
		FlatAppearance.BorderColor = SystemColors.MenuBar;
	}

	protected override void OnMouseDown(MouseEventArgs mevent)
	{
		FlatAppearance.BorderSize = 0;
		FlatAppearance.BorderColor = SystemColors.MenuBar;
		base.OnMouseDown(mevent);
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		FlatAppearance.BorderColor = SystemColors.MenuBar;
		FlatAppearance.BorderSize = 1;
		base.OnMouseUp(mevent);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		FlatAppearance.BorderSize = 1;
		FlatStyle = FlatStyle.Popup;
		base.OnMouseEnter(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		base.OnMouseWheel(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		FlatStyle = FlatStyle.Flat;
		FlatAppearance.BorderSize = 0;
		base.OnMouseLeave(e);
	}

	private void uc_Button_Resize(object sender, EventArgs e)
	{
		if (DesignMode)
		{
			Cursor = Cursors.Hand;
			FlatStyle = FlatStyle.Popup;
			FlatAppearance.BorderSize = 0;
			FlatAppearance.MouseDownBackColor = Color.DarkGray;
			ImageAlign = ContentAlignment.MiddleLeft;
			TextAlign = ContentAlignment.MiddleRight;
			UseVisualStyleBackColor = true;
		}
		else
		{
			FlatStyle = FlatStyle.Flat;
		}
	}
}
