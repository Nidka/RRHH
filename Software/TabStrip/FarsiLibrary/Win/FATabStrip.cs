using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FarsiLibrary.Win.BaseClasses;
using FarsiLibrary.Win.Design;

namespace FarsiLibrary.Win;

[DefaultProperty("Items")]
[ToolboxItem(true)]
[ToolboxBitmap("FATabStrip.bmp")]
[Designer(typeof(FATabStripDesigner))]
[DefaultEvent("TabStripItemSelectionChanged")]
public class FATabStrip : BaseStyledPanel, ISupportInitialize, IDisposable
{
	private const int DEF_HEADER_HEIGHT = 19;

	private const int DEF_GLYPH_WIDTH = 40;

	internal static int PreferredWidth = 350;

	internal static int PreferredHeight = 200;

	private int DEF_START_POS = 10;

	private Rectangle stripButtonRect = Rectangle.Empty;

	private FATabStripItem selectedItem;

	private ContextMenuStrip menu;

	private FATabStripMenuGlyph menuGlyph;

	private FATabStripCloseButton closeButton;

	private FATabStripItemCollection items;

	private StringFormat sf;

	private static Font defaultFont = new Font("Tahoma", 8.25f, FontStyle.Regular);

	private bool alwaysShowClose = true;

	private bool isIniting;

	private bool alwaysShowMenuGlyph = true;

	private bool menuOpen;

	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(null)]
	public FATabStripItem SelectedItem
	{
		get
		{
			return selectedItem;
		}
		set
		{
			if (selectedItem == value)
			{
				return;
			}
			if (value == null && Items.Count > 0)
			{
				FATabStripItem fATabStripItem = Items[0];
				if (fATabStripItem.Visible)
				{
					selectedItem = fATabStripItem;
					selectedItem.Selected = true;
					selectedItem.Dock = DockStyle.Fill;
				}
			}
			else
			{
				selectedItem = value;
			}
			foreach (FATabStripItem item in Items)
			{
				if (item == selectedItem)
				{
					SelectItem(item);
					item.Dock = DockStyle.Fill;
					item.Show();
				}
				else
				{
					UnSelectItem(item);
					item.Hide();
				}
			}
			SelectItem(selectedItem);
			Invalidate();
			if (!selectedItem.IsDrawn)
			{
				Items.MoveTo(0, selectedItem);
				Invalidate();
			}
			OnTabStripItemChanged(new TabStripItemChangedEventArgs(selectedItem, FATabStripItemChangeTypes.SelectionChanged));
		}
	}

	[DefaultValue(true)]
	public bool AlwaysShowMenuGlyph
	{
		get
		{
			return alwaysShowMenuGlyph;
		}
		set
		{
			if (alwaysShowMenuGlyph != value)
			{
				alwaysShowMenuGlyph = value;
				Invalidate();
			}
		}
	}

	[DefaultValue(true)]
	public bool AlwaysShowClose
	{
		get
		{
			return alwaysShowClose;
		}
		set
		{
			if (alwaysShowClose != value)
			{
				alwaysShowClose = value;
				Invalidate();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public FATabStripItemCollection Items => items;

	[DefaultValue(typeof(Size), "350,200")]
	public new Size Size
	{
		get
		{
			return base.Size;
		}
		set
		{
			if (!(base.Size == value))
			{
				base.Size = value;
				UpdateLayout();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new ControlCollection Controls => base.Controls;

	public event TabStripItemClosingHandler TabStripItemClosing;

	public event TabStripItemChangedHandler TabStripItemSelectionChanged;

	public event HandledEventHandler MenuItemsLoading;

	public event EventHandler MenuItemsLoaded;

	public event EventHandler TabStripItemClosed;

	public HitTestResult HitTest(Point pt)
	{
		if (closeButton.Bounds.Contains(pt))
		{
			return HitTestResult.CloseButton;
		}
		if (menuGlyph.Bounds.Contains(pt))
		{
			return HitTestResult.MenuGlyph;
		}
		if (GetTabItemByPoint(pt) != null)
		{
			return HitTestResult.TabItem;
		}
		return HitTestResult.None;
	}

	public void AddTab(FATabStripItem tabItem)
	{
		AddTab(tabItem, autoSelect: false);
	}

	public void AddTab(FATabStripItem tabItem, bool autoSelect)
	{
		tabItem.Dock = DockStyle.Fill;
		Items.Add(tabItem);
		if ((autoSelect && tabItem.Visible) || (tabItem.Visible && Items.DrawnCount < 1))
		{
			SelectedItem = tabItem;
			SelectItem(tabItem);
		}
	}

	public void RemoveTab(FATabStripItem tabItem)
	{
		int num = Items.IndexOf(tabItem);
		if (num >= 0)
		{
			UnSelectItem(tabItem);
			Items.Remove(tabItem);
		}
		if (Items.Count <= 0)
		{
			return;
		}
		if (RightToLeft == RightToLeft.No)
		{
			if (Items[num - 1] != null)
			{
				SelectedItem = Items[num - 1];
			}
			else
			{
				SelectedItem = Items.FirstVisible;
			}
		}
		else if (Items[num + 1] != null)
		{
			SelectedItem = Items[num + 1];
		}
		else
		{
			SelectedItem = Items.LastVisible;
		}
	}

	public FATabStripItem GetTabItemByPoint(Point pt)
	{
		FATabStripItem result = null;
		bool flag = false;
		for (int i = 0; i < Items.Count; i++)
		{
			FATabStripItem fATabStripItem = Items[i];
			if (fATabStripItem.StripRect.Contains(pt) && fATabStripItem.Visible && fATabStripItem.IsDrawn)
			{
				result = fATabStripItem;
				flag = true;
			}
			if (flag)
			{
				break;
			}
		}
		return result;
	}

	public virtual void ShowMenu()
	{
		if (!menu.Visible && menu.Items.Count > 0)
		{
			if (RightToLeft == RightToLeft.No)
			{
				menu.Show(this, new Point(menuGlyph.Bounds.Left, menuGlyph.Bounds.Bottom));
			}
			else
			{
				menu.Show(this, new Point(menuGlyph.Bounds.Right, menuGlyph.Bounds.Bottom));
			}
			menuOpen = true;
		}
	}

	internal void UnDrawAll()
	{
		for (int i = 0; i < Items.Count; i++)
		{
			Items[i].IsDrawn = false;
		}
	}

	internal void SelectItem(FATabStripItem tabItem)
	{
		tabItem.Dock = DockStyle.Fill;
		tabItem.Visible = true;
		tabItem.Selected = true;
	}

	internal void UnSelectItem(FATabStripItem tabItem)
	{
		tabItem.Selected = false;
	}

	protected internal void OnTabStripItemClosing(TabStripItemClosingEventArgs e)
	{
		if (this.TabStripItemClosing != null)
		{
			this.TabStripItemClosing(e);
		}
	}

	protected internal void OnTabStripItemClosed(EventArgs e)
	{
		if (this.TabStripItemClosed != null)
		{
			this.TabStripItemClosed(this, e);
		}
	}

	protected virtual void OnMenuItemsLoading(HandledEventArgs e)
	{
		if (this.MenuItemsLoading != null)
		{
			this.MenuItemsLoading(this, e);
		}
	}

	protected virtual void OnMenuItemsLoaded(EventArgs e)
	{
		if (this.MenuItemsLoaded != null)
		{
			this.MenuItemsLoaded(this, e);
		}
	}

	protected virtual void OnTabStripItemChanged(TabStripItemChangedEventArgs e)
	{
		if (this.TabStripItemSelectionChanged != null)
		{
			this.TabStripItemSelectionChanged(e);
		}
	}

	protected virtual void OnMenuItemsLoad(EventArgs e)
	{
		menu.RightToLeft = RightToLeft;
		menu.Items.Clear();
		for (int i = 0; i < Items.Count; i++)
		{
			FATabStripItem fATabStripItem = Items[i];
			if (fATabStripItem.Visible)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(fATabStripItem.Title);
				toolStripMenuItem.Tag = fATabStripItem;
				toolStripMenuItem.Image = fATabStripItem.Image;
				menu.Items.Add(toolStripMenuItem);
			}
		}
		OnMenuItemsLoaded(EventArgs.Empty);
	}

	protected override void OnRightToLeftChanged(EventArgs e)
	{
		base.OnRightToLeftChanged(e);
		UpdateLayout();
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		SetDefaultSelected();
		Rectangle clientRectangle = base.ClientRectangle;
		clientRectangle.Width--;
		clientRectangle.Height--;
		if (RightToLeft == RightToLeft.No)
		{
			DEF_START_POS = 10;
		}
		else
		{
			DEF_START_POS = stripButtonRect.Right;
		}
		e.Graphics.DrawRectangle(SystemPens.ControlDark, clientRectangle);
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		for (int i = 0; i < Items.Count; i++)
		{
			FATabStripItem fATabStripItem = Items[i];
			if (fATabStripItem.Visible || base.DesignMode)
			{
				OnCalcTabPage(e.Graphics, fATabStripItem);
				fATabStripItem.IsDrawn = false;
				if (AllowDraw(fATabStripItem))
				{
					OnDrawTabPage(e.Graphics, fATabStripItem);
				}
			}
		}
		if (RightToLeft == RightToLeft.No)
		{
			if (Items.DrawnCount == 0 || Items.VisibleCount == 0)
			{
				e.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), new Point(base.ClientRectangle.Width, 19));
			}
			else if (SelectedItem != null && SelectedItem.IsDrawn)
			{
				Point point = new Point((int)SelectedItem.StripRect.Left - 9, 19);
				e.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), point);
				point.X += (int)SelectedItem.StripRect.Width + 10;
				e.Graphics.DrawLine(SystemPens.ControlDark, point, new Point(base.ClientRectangle.Width, 19));
			}
		}
		else if (Items.DrawnCount == 0 || Items.VisibleCount == 0)
		{
			e.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), new Point(base.ClientRectangle.Width, 19));
		}
		else if (SelectedItem != null && SelectedItem.IsDrawn)
		{
			Point point2 = new Point((int)SelectedItem.StripRect.Left, 19);
			e.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), point2);
			point2.X += (int)SelectedItem.StripRect.Width + 20;
			e.Graphics.DrawLine(SystemPens.ControlDark, point2, new Point(base.ClientRectangle.Width, 19));
		}
		if (AlwaysShowMenuGlyph || Items.DrawnCount > Items.VisibleCount)
		{
			menuGlyph.DrawGlyph(e.Graphics);
		}
		if (AlwaysShowClose || (SelectedItem != null && SelectedItem.CanClose))
		{
			closeButton.DrawCross(e.Graphics);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		switch (HitTest(e.Location))
		{
		case HitTestResult.MenuGlyph:
		{
			HandledEventArgs handledEventArgs = new HandledEventArgs(defaultHandledValue: false);
			OnMenuItemsLoading(handledEventArgs);
			if (!handledEventArgs.Handled)
			{
				OnMenuItemsLoad(EventArgs.Empty);
			}
			ShowMenu();
			break;
		}
		case HitTestResult.CloseButton:
			if (SelectedItem != null)
			{
				TabStripItemClosingEventArgs tabStripItemClosingEventArgs = new TabStripItemClosingEventArgs(SelectedItem);
				OnTabStripItemClosing(tabStripItemClosingEventArgs);
				if (!tabStripItemClosingEventArgs.Cancel && SelectedItem.CanClose)
				{
					RemoveTab(SelectedItem);
					OnTabStripItemClosed(EventArgs.Empty);
				}
			}
			break;
		case HitTestResult.TabItem:
		{
			FATabStripItem tabItemByPoint = GetTabItemByPoint(e.Location);
			if (tabItemByPoint != null)
			{
				SelectedItem = tabItemByPoint;
			}
			break;
		}
		}
		Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (menuGlyph.Bounds.Contains(e.Location))
		{
			menuGlyph.IsMouseOver = true;
			Invalidate(menuGlyph.Bounds);
		}
		else if (menuGlyph.IsMouseOver && !menuOpen)
		{
			menuGlyph.IsMouseOver = false;
			Invalidate(menuGlyph.Bounds);
		}
		if (closeButton.Bounds.Contains(e.Location))
		{
			closeButton.IsMouseOver = true;
			Invalidate(closeButton.Bounds);
		}
		else if (closeButton.IsMouseOver)
		{
			closeButton.IsMouseOver = false;
			Invalidate(closeButton.Bounds);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		menuGlyph.IsMouseOver = false;
		Invalidate(menuGlyph.Bounds);
		closeButton.IsMouseOver = false;
		Invalidate(closeButton.Bounds);
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		base.OnSizeChanged(e);
		if (!isIniting)
		{
			UpdateLayout();
		}
	}

	private bool AllowDraw(FATabStripItem item)
	{
		bool result = true;
		if (RightToLeft == RightToLeft.No)
		{
			if (item.StripRect.Right >= (float)stripButtonRect.Width)
			{
				result = false;
			}
		}
		else if (item.StripRect.Left <= (float)stripButtonRect.Left)
		{
			return false;
		}
		return result;
	}

	private void SetDefaultSelected()
	{
		if (selectedItem == null && Items.Count > 0)
		{
			SelectedItem = Items[0];
		}
		for (int i = 0; i < Items.Count; i++)
		{
			FATabStripItem fATabStripItem = Items[i];
			fATabStripItem.Dock = DockStyle.Fill;
		}
	}

	private void OnMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		FATabStripItem fATabStripItem = (FATabStripItem)e.ClickedItem.Tag;
		SelectedItem = fATabStripItem;
	}

	private void OnMenuVisibleChanged(object sender, EventArgs e)
	{
		if (!menu.Visible)
		{
			menuOpen = false;
		}
	}

	private void OnCalcTabPage(Graphics g, FATabStripItem currentItem)
	{
		Font font = Font;
		if (currentItem == SelectedItem)
		{
			font = new Font(Font, FontStyle.Bold);
		}
		SizeF sizeF = g.MeasureString(currentItem.Title, font, new SizeF(200f, 10f), sf);
		sizeF.Width += 20f;
		if (RightToLeft == RightToLeft.No)
		{
			RectangleF stripRect = new RectangleF(DEF_START_POS, 3f, sizeF.Width, 17f);
			currentItem.StripRect = stripRect;
			DEF_START_POS += (int)sizeF.Width;
		}
		else
		{
			RectangleF stripRect2 = new RectangleF((float)DEF_START_POS - sizeF.Width + 1f, 3f, sizeF.Width - 1f, 17f);
			currentItem.StripRect = stripRect2;
			DEF_START_POS -= (int)sizeF.Width;
		}
	}

	private void OnDrawTabPage(Graphics g, FATabStripItem currentItem)
	{
		bool flag = Items.IndexOf(currentItem) == 0;
		Font font = Font;
		if (currentItem == SelectedItem)
		{
			font = new Font(Font, FontStyle.Bold);
		}
		SizeF sizeF = g.MeasureString(currentItem.Title, font, new SizeF(200f, 10f), sf);
		sizeF.Width += 20f;
		RectangleF stripRect = currentItem.StripRect;
		GraphicsPath graphicsPath = new GraphicsPath();
		int num = 3;
		if (RightToLeft == RightToLeft.No)
		{
			if (currentItem == SelectedItem || flag)
			{
				graphicsPath.AddLine(stripRect.Left - 10f, stripRect.Bottom - 1f, stripRect.Left + stripRect.Height / 2f - 4f, num + 4);
			}
			else
			{
				graphicsPath.AddLine(stripRect.Left, stripRect.Bottom - 1f, stripRect.Left, stripRect.Bottom - stripRect.Height / 2f - 2f);
				graphicsPath.AddLine(stripRect.Left, stripRect.Bottom - stripRect.Height / 2f - 3f, stripRect.Left + stripRect.Height / 2f - 4f, num + 3);
			}
			graphicsPath.AddLine(stripRect.Left + stripRect.Height / 2f + 2f, num, stripRect.Right - 3f, num);
			graphicsPath.AddLine(stripRect.Right, num + 2, stripRect.Right, stripRect.Bottom - 1f);
			graphicsPath.AddLine(stripRect.Right - 4f, stripRect.Bottom - 1f, stripRect.Left, stripRect.Bottom - 1f);
			graphicsPath.CloseFigure();
			LinearGradientBrush brush = ((currentItem != SelectedItem) ? new LinearGradientBrush(stripRect, SystemColors.ControlLightLight, SystemColors.Control, LinearGradientMode.Vertical) : new LinearGradientBrush(stripRect, SystemColors.ControlLightLight, SystemColors.Window, LinearGradientMode.Vertical));
			g.FillPath(brush, graphicsPath);
			g.DrawPath(SystemPens.ControlDark, graphicsPath);
			if (currentItem == SelectedItem)
			{
				g.DrawLine(new Pen(brush), stripRect.Left - 9f, stripRect.Height + 2f, stripRect.Left + stripRect.Width - 1f, stripRect.Height + 2f);
			}
			PointF location = new PointF(stripRect.Left + stripRect.Height - 4f, stripRect.Top + stripRect.Height / 2f - sizeF.Height / 2f - 3f);
			RectangleF layoutRectangle = stripRect;
			layoutRectangle.Location = location;
			layoutRectangle.Width = stripRect.Width - (layoutRectangle.Left - stripRect.Left) - 4f;
			layoutRectangle.Height = sizeF.Height + font.Size / 2f;
			if (currentItem == SelectedItem)
			{
				g.DrawString(currentItem.Title, font, new SolidBrush(ForeColor), layoutRectangle, sf);
			}
			else
			{
				g.DrawString(currentItem.Title, font, new SolidBrush(ForeColor), layoutRectangle, sf);
			}
		}
		if (RightToLeft == RightToLeft.Yes)
		{
			if (currentItem == SelectedItem || flag)
			{
				graphicsPath.AddLine(stripRect.Right + 10f, stripRect.Bottom - 1f, stripRect.Right - stripRect.Height / 2f + 4f, num + 4);
			}
			else
			{
				graphicsPath.AddLine(stripRect.Right, stripRect.Bottom - 1f, stripRect.Right, stripRect.Bottom - stripRect.Height / 2f - 2f);
				graphicsPath.AddLine(stripRect.Right, stripRect.Bottom - stripRect.Height / 2f - 3f, stripRect.Right - stripRect.Height / 2f + 4f, num + 3);
			}
			graphicsPath.AddLine(stripRect.Right - stripRect.Height / 2f - 2f, num, stripRect.Left + 3f, num);
			graphicsPath.AddLine(stripRect.Left, num + 2, stripRect.Left, stripRect.Bottom - 1f);
			graphicsPath.AddLine(stripRect.Left + 4f, stripRect.Bottom - 1f, stripRect.Right, stripRect.Bottom - 1f);
			graphicsPath.CloseFigure();
			LinearGradientBrush brush = ((currentItem != SelectedItem) ? new LinearGradientBrush(stripRect, SystemColors.ControlLightLight, SystemColors.Control, LinearGradientMode.Vertical) : new LinearGradientBrush(stripRect, SystemColors.ControlLightLight, SystemColors.Window, LinearGradientMode.Vertical));
			g.FillPath(brush, graphicsPath);
			g.DrawPath(SystemPens.ControlDark, graphicsPath);
			if (currentItem == SelectedItem)
			{
				g.DrawLine(new Pen(brush), stripRect.Right + 9f, stripRect.Height + 2f, stripRect.Right - stripRect.Width + 1f, stripRect.Height + 2f);
			}
			PointF location2 = new PointF(stripRect.Left + 2f, stripRect.Top + stripRect.Height / 2f - sizeF.Height / 2f - 2f);
			RectangleF layoutRectangle2 = stripRect;
			layoutRectangle2.Location = location2;
			layoutRectangle2.Width = stripRect.Width - (layoutRectangle2.Left - stripRect.Left) - 10f;
			layoutRectangle2.Height = sizeF.Height + font.Size / 2f;
			if (currentItem == SelectedItem)
			{
				layoutRectangle2.Y -= 1f;
				g.DrawString(currentItem.Title, font, new SolidBrush(ForeColor), layoutRectangle2, sf);
			}
			else
			{
				g.DrawString(currentItem.Title, font, new SolidBrush(ForeColor), layoutRectangle2, sf);
			}
		}
		currentItem.IsDrawn = true;
	}

	private void UpdateLayout()
	{
		if (RightToLeft == RightToLeft.No)
		{
			sf.Trimming = StringTrimming.EllipsisCharacter;
			sf.FormatFlags |= StringFormatFlags.NoWrap;
			sf.FormatFlags &= StringFormatFlags.DirectionRightToLeft;
			stripButtonRect = new Rectangle(0, 0, base.ClientSize.Width - 40 - 2, 10);
			menuGlyph.Bounds = new Rectangle(base.ClientSize.Width - 40, 2, 16, 16);
			closeButton.Bounds = new Rectangle(base.ClientSize.Width - 20, 2, 16, 16);
		}
		else
		{
			sf.Trimming = StringTrimming.EllipsisCharacter;
			sf.FormatFlags |= StringFormatFlags.NoWrap;
			sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
			stripButtonRect = new Rectangle(42, 0, base.ClientSize.Width - 40 - 15, 10);
			closeButton.Bounds = new Rectangle(4, 2, 16, 16);
			menuGlyph.Bounds = new Rectangle(24, 2, 16, 16);
		}
		base.DockPadding.Top = 20;
		base.DockPadding.Bottom = 1;
		base.DockPadding.Right = 1;
		base.DockPadding.Left = 1;
	}

	private void OnCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
		FATabStripItem fATabStripItem = (FATabStripItem)e.Element;
		if (e.Action == CollectionChangeAction.Add)
		{
			Controls.Add(fATabStripItem);
			OnTabStripItemChanged(new TabStripItemChangedEventArgs(fATabStripItem, FATabStripItemChangeTypes.Added));
		}
		else if (e.Action == CollectionChangeAction.Remove)
		{
			Controls.Remove(fATabStripItem);
			OnTabStripItemChanged(new TabStripItemChangedEventArgs(fATabStripItem, FATabStripItemChangeTypes.Removed));
		}
		else
		{
			OnTabStripItemChanged(new TabStripItemChangedEventArgs(fATabStripItem, FATabStripItemChangeTypes.Changed));
		}
		UpdateLayout();
		Invalidate();
	}

	public FATabStrip()
	{
		BeginInit();
		SetStyle(ControlStyles.ContainerControl, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.Selectable, value: true);
		items = new FATabStripItemCollection();
		items.CollectionChanged += OnCollectionChanged;
		base.Size = new Size(350, 200);
		menu = new ContextMenuStrip();
		menu.Renderer = base.ToolStripRenderer;
		menu.ItemClicked += OnMenuItemClicked;
		menu.VisibleChanged += OnMenuVisibleChanged;
		menuGlyph = new FATabStripMenuGlyph(base.ToolStripRenderer);
		closeButton = new FATabStripCloseButton(base.ToolStripRenderer);
		Font = defaultFont;
		sf = new StringFormat();
		EndInit();
		UpdateLayout();
	}

	public bool ShouldSerializeFont()
	{
		if (Font != null)
		{
			return !Font.Equals(defaultFont);
		}
		return false;
	}

	public bool ShouldSerializeSelectedItem()
	{
		return true;
	}

	public bool ShouldSerializeItems()
	{
		return items.Count > 0;
	}

	public new void ResetFont()
	{
		Font = defaultFont;
	}

	public void BeginInit()
	{
		isIniting = true;
	}

	public void EndInit()
	{
		isIniting = false;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			items.CollectionChanged -= OnCollectionChanged;
			menu.ItemClicked -= OnMenuItemClicked;
			menu.VisibleChanged -= OnMenuVisibleChanged;
			foreach (FATabStripItem item in items)
			{
				if (item != null && !item.IsDisposed)
				{
					item.Dispose();
				}
			}
			if (menu != null && !menu.IsDisposed)
			{
				menu.Dispose();
			}
			if (sf != null)
			{
				sf.Dispose();
			}
		}
		base.Dispose(disposing);
	}
}
