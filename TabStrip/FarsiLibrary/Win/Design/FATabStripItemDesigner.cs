using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FarsiLibrary.Win.Design;

public class FATabStripItemDesigner : ParentControlDesigner
{
	private FATabStripItem TabStrip;

	public override SelectionRules SelectionRules => SelectionRules.None;

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		TabStrip = component as FATabStripItem;
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		base.PreFilterProperties(properties);
		properties.Remove("Dock");
		properties.Remove("AutoScroll");
		properties.Remove("AutoScrollMargin");
		properties.Remove("AutoScrollMinSize");
		properties.Remove("DockPadding");
		properties.Remove("DrawGrid");
		properties.Remove("Font");
		properties.Remove("Padding");
		properties.Remove("MinimumSize");
		properties.Remove("MaximumSize");
		properties.Remove("Margin");
		properties.Remove("ForeColor");
		properties.Remove("BackColor");
		properties.Remove("BackgroundImage");
		properties.Remove("BackgroundImageLayout");
		properties.Remove("RightToLeft");
		properties.Remove("GridSize");
		properties.Remove("ImeMode");
		properties.Remove("BorderStyle");
		properties.Remove("AutoSize");
		properties.Remove("AutoSizeMode");
		properties.Remove("Location");
	}

	public override bool CanBeParentedTo(IDesigner parentDesigner)
	{
		return parentDesigner.Component is FATabStrip;
	}

	protected override void OnPaintAdornments(PaintEventArgs pe)
	{
		if (TabStrip != null)
		{
			using (Pen pen = new Pen(SystemColors.ControlDark))
			{
				pen.DashStyle = DashStyle.Dash;
				pe.Graphics.DrawRectangle(pen, 0, 0, TabStrip.Width - 1, TabStrip.Height - 1);
			}
		}
	}
}
