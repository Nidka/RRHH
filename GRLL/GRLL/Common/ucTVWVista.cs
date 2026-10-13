using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ucTVWVista : TreeView
{
	public enum TreeExpanderStyle
	{
		PlusMinus,
		Arrow
	}

	private string CollapsedString;

	private string CollapsedArrowString;

	private Image CollapsedIcon;

	private string ExpandedString;

	private string ExpandedArrowString;

	private Image ExpandedIcon;

	private StringFormat TextFormat;

	private Pen HighlightBorderPen;

	private Color HighlightColor;

	private SolidBrush HighlightBrush;

	private Color RootColor;

	private bool _haveImages;

	private TreeExpanderStyle _expanderStyle;

	private Image _backgroundimage;

	private string _lastKnowTopIndex;

	private Brush NodeBrush;

	private Color mBaseColor;

	private Color mNodeColor;

	private Color mSelectedColor;

	private Color mHotTrackingColor;

	private Font mFontHotTracking;

	[Category("Appearance")]
	[Description("The backing color that the rest of the highlighted area is drawn. For a glassier effect set this property to Transparent.")]
	[DefaultValue(typeof(Color), "0, 5, 10")]
	public Color NodeBaseColor
	{
		get
		{
			return mBaseColor;
		}
		set
		{
			mBaseColor = value;
			Invalidate();
		}
	}

	[DefaultValue(typeof(Color), "0, 0, 32")]
	[Category("Appearance")]
	[Description("The bottom color of the highlighted node that will be drawn over the base color.")]
	public Color NodeColor
	{
		get
		{
			return mNodeColor;
		}
		set
		{
			mNodeColor = value;
			Invalidate();
		}
	}

	[Category("Appearance")]
	[Description("The font color of a selected node.")]
	[DefaultValue(typeof(Color), "White")]
	public Color FontColorSelected
	{
		get
		{
			return mSelectedColor;
		}
		set
		{
			mSelectedColor = value;
			Invalidate();
		}
	}

	[Description("The font color of a hovered node if the hottracking is on.")]
	[DefaultValue(typeof(Color), "Silver")]
	[Category("Appearance")]
	public Color FontColorHotTracking
	{
		get
		{
			return mHotTrackingColor;
		}
		set
		{
			mHotTrackingColor = value;
			Invalidate();
		}
	}

	[Description("The hovered node font if the hottracking is on.")]
	[Category("Appearance")]
	public Font FontHotTracking
	{
		get
		{
			return mFontHotTracking;
		}
		set
		{
			mFontHotTracking = value;
			Invalidate();
		}
	}

	[DefaultValue(typeof(TreeExpanderStyle), "Arrow")]
	[Description("Collapsing arrow style.")]
	[Category("Behavior")]
	public TreeExpanderStyle ExpanderStyle
	{
		get
		{
			return _expanderStyle;
		}
		set
		{
			if (_expanderStyle != value)
			{
				_expanderStyle = value;
				LoadExpanderImages();
				Invalidate();
			}
		}
	}

	[DefaultValue(typeof(Image), null)]
	[Description("The image displayed on the treeview background.")]
	[Browsable(true)]
	[Bindable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Category("Image")]
	public override Image BackgroundImage
	{
		get
		{
			return _backgroundimage;
		}
		set
		{
			_backgroundimage = value;
			Invalidate();
		}
	}

	public new ImageList ImageList
	{
		get
		{
			return base.ImageList;
		}
		set
		{
			base.ImageList = value;
			_haveImages = base.ImageList != null;
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	public new Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
			SetTreeviewStyle();
		}
	}

	[ReadOnly(true)]
	[Browsable(false)]
	public new TreeViewDrawMode DrawMode => base.DrawMode;

	[ReadOnly(true)]
	[Browsable(false)]
	public new bool ShowLines => base.ShowLines;

	[ReadOnly(true)]
	[Browsable(false)]
	public new bool ShowRootLines => base.ShowRootLines;

	[Browsable(false)]
	[ReadOnly(true)]
	public new bool LabelEdit => base.LabelEdit;

	[Browsable(false)]
	[ReadOnly(true)]
	public new bool ShowPlusMinus => base.ShowPlusMinus;

	[Browsable(false)]
	[ReadOnly(true)]
	public new Color LineColor => base.LineColor;

	[Browsable(false)]
	[ReadOnly(true)]
	public new bool CheckBoxes => base.CheckBoxes;

	public ucTVWVista()
	{
		CollapsedString = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAARpJREFUOE+lk9tKAmEUhfWhfIiew1eyUkkvPCaNdZdHbPCACIqCklZERQZCZhNZeZylS5jRhvlHcAb2zcD61tqLfzsBOGx9BNgZXdwffCKYLCEgFXF2IcN3XoA3nsNJJAtPOK1Ptd5Z+21NdUDwsgxVBRZLFdPZEj9/CyjjOd6VKd6GEzwPfnH/OobryG0OCEilvWK58SIGMLbRmW6ac+fpG1fynRjgX+9sjE0AY1PcfPiCVLAAnMby+s4UGqfWVZDI98QJjqMZ08LoTHG5PUI82xUDPJH0v7YZmyk08U3rA9HMHsBuYbvOFOcaQ4RTt9YJWFix2Ueq8rgpjDszNp0pDl1bAPjCzMoz/hO+xEPvwdYhbS75UGdNtwLNm+LI5h1FwAAAAABJRU5ErkJggg==";
		CollapsedArrowString = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAANFJREFUOE+l00kKhDAQheHq+x/KlaALxXkeF04o4g1ep0J3Y0OEiILoIvnyK9QLAD26GHhyKzc7joNpmmhZFtq2jfZ9p+M4lGsvgTOyrqtEVKWXQN/3YGQcR1nCiDZg2zbatsUZmef5HlBVFZqmQdd1smQYBn3AsizkeY6yLP8Q7U8wTRNpmv4QLhAl+gUMRFGEJEnA76KE6rrWBwzDQBAE4KdAKMsyKoriHvBBSJTQF9H+B7zZdV3yPI9836cwDCmOY/2CO7PxaJDkJN85TbX2Db5d1YfJcQ3TAAAAAElFTkSuQmCC";
		ExpandedString = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAO9JREFUOE+lk9sKAVEUhnkoD+E5vJJzuHEshzs1DiGUQ0RRigsKJceRcWZ+tppxmjXKTK2bqe/791p7Lz0AnaaPCbSUDI8mK3iiBbgjebjCOThCGdiDKVh9SZi9nFylWvue9wyVBZ5YEaIIXK4ijqcrtvsLeOGMGX/EeH7AYLJDdyjAYDQpC9yRwk+43d/QAnZstWQGN3prWuC890wdW4IrHZ4W2AJpuWfW52cxuNha0gKLP/E1sNdkBmebC1pg9nFv01aCU/W5ukC6KgrmqjN1AbtnNThentIC9sKUhvf5j3yJ/+6DpkV6bPK/yRJ3A/PE7e2oP8DgAAAAAElFTkSuQmCCAPjCzMoz/hO+xEPvwdYhbS75UGdNtwLNm+LI5h1FwAAAAABJRU5ErkJggg==";
		ExpandedArrowString = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAM9JREFUOE/N0kkKg0AQBdCf+x/KlaALxXkeF04o4g0qXU1sDPQqBhLhI72o17+gH0SEWx8Dd3JrWLa/c/t3Ac/ziOM4Dtm2LWNZFpmmKWMYhsq1tVphmiYw0Pc9tW1LVVVRnueUpilFUURBEEjAdd23tdVhWRZckaZpqCxLiSRJIocFwpfogW3bwMg4juDqXdfRifCwQCCawPd9PbDvO9Z1VQgPMcJ/0QRZloGRMAz1wHEcOJF5njEMA14I6rpGURQSieNYD3z6Hv7oIf1shSf3G9UMQ+Vu/QAAAABJRU5ErkJggg==";
		TextFormat = new StringFormat(StringFormatFlags.NoWrap);
		HighlightBorderPen = new Pen(Color.FromArgb(255, 127, 157, 185));
		HighlightColor = Color.FromArgb(255, 204, 230, 255);
		HighlightBrush = new SolidBrush(HighlightColor);
		RootColor = Color.FromArgb(255, 204, 204, 204);
		_lastKnowTopIndex = "";
		mBaseColor = Color.FromArgb(0, 5, 10);
		mNodeColor = Color.FromArgb(0, 0, 32);
		mSelectedColor = Color.White;
		mHotTrackingColor = Color.Silver;
		mFontHotTracking = Font;
		base.LineColor = SystemColors.GrayText;
		_expanderStyle = TreeExpanderStyle.Arrow;
		BackColor = Color.FromArgb(232, 232, 232);
		LoadExpanderImages();
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
		UpdateStyles();
		SetTreeviewStyle();
	}

	protected override void InitLayout()
	{
		base.InitLayout();
		base.DrawMode = TreeViewDrawMode.OwnerDrawAll;
		base.ShowPlusMinus = true;
		base.ShowLines = false;
		base.ShowRootLines = true;
		base.CheckBoxes = false;
		base.LineColor = Color.Black;
	}

	protected override void OnAfterCollapse(TreeViewEventArgs e)
	{
		base.OnAfterCollapse(e);
	}

	protected override void OnAfterExpand(TreeViewEventArgs e)
	{
		base.OnAfterExpand(e);
	}

	protected override void OnParentFontChanged(EventArgs e)
	{
		base.OnParentFontChanged(e);
		SetTreeviewStyle();
	}

	protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
	{
		base.OnBeforeSelect(e);
		try
		{
			VistaNode _node = (VistaNode)e.Node;
			if (_node.Title)
			{
				e.Cancel = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
	{
		base.OnBeforeExpand(e);
		Invalidate();
	}

	protected override void OnBeforeCollapse(TreeViewCancelEventArgs e)
	{
		try
		{
			VistaNode _node = (VistaNode)e.Node;
			if (_node.Title)
			{
				e.Cancel = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		base.OnBeforeCollapse(e);
		Invalidate();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		checked
		{
			if (_backgroundimage != null)
			{
				pevent.Graphics.InterpolationMode = InterpolationMode.Low;
				Graphics graphics = pevent.Graphics;
				Image backgroundimage = _backgroundimage;
				Rectangle rect = new Rectangle(0, 0, Width, Height);
				graphics.DrawImage(backgroundimage, rect);
			}
			else
			{
				PointF point = Point.Empty;
				PointF point2 = new PointF(0f, Height);
				LinearGradientBrush b = new LinearGradientBrush(point, point2, Color.FromArgb(163, 215, 250), BackColor);
				GraphicsPath border = new GraphicsPath();
				Graphics graphics2 = pevent.Graphics;
				LinearGradientBrush brush = b;
				Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
				graphics2.FillRectangle(brush, rect);
				int glowSize = Convert.ToInt32(Convert.ToSingle(Height) / 2f);
				Rectangle glow = new Rectangle(0, Height - glowSize - 1, Width - 1, glowSize);
				Point point3 = new Point(0, glow.Top - 1);
				PointF point4 = point3;
				point2 = new PointF(0f, glow.Bottom);
				b = new LinearGradientBrush(point4, point2, Color.FromArgb(0, Color.FromArgb(67, 83, 122)), Color.FromArgb(224, 233, 244));
				pevent.Graphics.FillRectangle(b, glow);
			}
			if (TopNode != null && Operators.CompareString(_lastKnowTopIndex, TopNode.Name, TextCompare: false) != 0)
			{
				Invalidate();
				_lastKnowTopIndex = TopNode.Name;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		PaintNodes(base.Nodes, e);
	}

	private void LoadExpanderImages()
	{
		TreeExpanderStyle expanderStyle = _expanderStyle;
		byte[] b = ((expanderStyle != TreeExpanderStyle.Arrow) ? Convert.FromBase64String(ExpandedString) : Convert.FromBase64String(ExpandedArrowString));
		MemoryStream ms = new MemoryStream();
		ms.Write(b, 0, b.Length);
		ExpandedIcon = Image.FromStream(ms);
		TreeExpanderStyle expanderStyle2 = _expanderStyle;
		b = ((expanderStyle2 != TreeExpanderStyle.Arrow) ? Convert.FromBase64String(CollapsedString) : Convert.FromBase64String(CollapsedArrowString));
		ms.Position = 0L;
		ms.Write(b, 0, b.Length);
		CollapsedIcon = Image.FromStream(ms);
		ms.Close();
	}

	private void SetTreeviewStyle()
	{
		if (base.SelectedNode == null)
		{
			{
				IEnumerator enumerator = base.Nodes.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						TreeNode n = (TreeNode)enumerator.Current;
						base.SelectedNode = n;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		Graphics g = CreateGraphics();
		int newHeight = Convert.ToInt32(Math.Ceiling(g.MeasureString(CollapsedString.Substring(0, 2), Font, 125).Height));
		if (newHeight > base.ItemHeight)
		{
			base.ItemHeight = newHeight;
		}
		g.Dispose();
		NodeBrush = new SolidBrush(ForeColor);
	}

	private void PaintNodes(TreeNodeCollection parentNodes, PaintEventArgs args)
	{
		VistaNode on_item = null;
		TreeNode on_item2 = null;
		if (HotTracking)
		{
			Point LocalMousePosition = PointToClient(Cursor.Position);
			on_item2 = GetNodeAt(LocalMousePosition);
		}
		foreach (TreeNode n in parentNodes)
		{
			Rectangle b = new Rectangle(0, n.Bounds.Y, base.ClientSize.Width, n.Bounds.Height);
			if (args.ClipRectangle.IntersectsWith(b))
			{
				b = new Rectangle(n.Bounds.X, n.Bounds.Y, checked(base.ClientSize.Width - n.Bounds.X - 1), n.Bounds.Height);
				DrawThisNode(args.Graphics, n, b, n == on_item);
			}
			n.Text = n.Name;
			if (n.Nodes.Count > 0)
			{
				PaintNodes(n.Nodes, args);
			}
		}
	}

	private void DrawThisNode(Graphics g, TreeNode node, Rectangle rBounds, bool HotTracked)
	{
		bool selected = node.IsSelected;
		checked
		{
			Rectangle rBorder;
			if (selected)
			{
				rBorder = new Rectangle(-2, rBounds.Y, base.Width + 2, rBounds.Height);
				DrawNodeBackground(g, rBorder);
			}
			Rectangle expRect = new Rectangle(rBounds.X - 17, rBounds.Y, rBounds.Width + 12, rBounds.Height);
			if (base.ImageList != null)
			{
				int num = base.ImageList.ImageSize.Width;
				if (num >= 1 && num <= 16)
				{
					expRect = new Rectangle(rBounds.X - base.ImageList.ImageSize.Width - 20, rBounds.Y, rBounds.Width + base.ImageList.ImageSize.Width + 3, rBounds.Height);
				}
				else if (num > 16)
				{
					expRect = new Rectangle(rBounds.X - 2 * base.ImageList.ImageSize.Width - 4, rBounds.Y, rBounds.Width + 2 * base.ImageList.ImageSize.Width - 13, rBounds.Height);
				}
			}
			bool hasExpander = DrawNodeExpander(g, node, expRect);
			rBorder = new Rectangle(expRect.X + 22, rBounds.Y, expRect.Width - 17, rBounds.Height);
			Size imageSize = DrawNodeImage(g, node, rBorder);
			Rectangle rBorder2 = new Rectangle(expRect.X + imageSize.Width + 22, rBounds.Y, expRect.Width - imageSize.Width - 17 + rBounds.X, rBounds.Height - 1);
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			RectangleF rText = DrawNodeText(g, node, rBorder2, selected, HotTracked);
			DrawNodeCustom(g, node, rText);
		}
	}

	private Size DrawNodeImage(Graphics g, TreeNode node, Rectangle r)
	{
		if (!_haveImages)
		{
			return new Size(0, 0);
		}
		if (node is VistaNode { Title: not false })
		{
			return new Size(0, 0);
		}
		Image img = null;
		if (node.IsSelected)
		{
			if (node.SelectedImageIndex >= 0)
			{
				img = base.ImageList.Images[node.SelectedImageIndex];
			}
			else if (node.SelectedImageKey != null)
			{
				img = base.ImageList.Images[node.SelectedImageKey];
			}
		}
		else if (node.ImageIndex >= 0)
		{
			img = base.ImageList.Images[node.ImageIndex];
		}
		else if (node.ImageKey != null)
		{
			img = base.ImageList.Images[node.ImageKey];
		}
		if (img == null)
		{
			return new Size(0, 0);
		}
		checked
		{
			int yPosition = r.Y + unchecked(checked(base.ItemHeight - img.Height) / 2);
			g.DrawImage(img, r.X, yPosition);
			return new Size(img.Width + 8, img.Height);
		}
	}

	private bool DrawNodeExpander(Graphics g, TreeNode node, Rectangle r)
	{
		bool result = default(bool);
		if (node is VistaNode { Title: not false })
		{
			return result;
		}
		checked
		{
			if (node.IsExpanded)
			{
				int yPosition = r.Y + unchecked(checked(base.ItemHeight - ExpandedIcon.Height) / 2);
				g.DrawImage(ExpandedIcon, r.X, yPosition);
				return true;
			}
			if (node.Nodes.Count > 0)
			{
				int yPosition2 = r.Y + unchecked(checked(base.ItemHeight - CollapsedIcon.Height) / 2);
				g.DrawImage(CollapsedIcon, r.X, yPosition2);
				return true;
			}
			return result;
		}
	}

	private void DrawNodeBackground(Graphics g, Rectangle rBorder)
	{
		DrawBackground(g, rBorder);
		DrawOuterStroke(g, rBorder);
		DrawInnerStroke(g, rBorder);
		DrawHighlight(g, rBorder);
		DrawGlossyEffect(g, rBorder);
	}

	private void DrawBackground(Graphics g, Rectangle r)
	{
		int alpha = 127;
		SolidBrush sb = new SolidBrush(NodeBaseColor);
		g.FillRectangle(sb, r);
		SetClip(g);
		g.ResetClip();
		sb = new SolidBrush(Color.FromArgb(alpha, NodeColor));
		g.FillRectangle(sb, r);
	}

	private void DrawOuterStroke(Graphics g, Rectangle r)
	{
		Pen p = new Pen(NodeColor);
		checked
		{
			g.DrawLine(p, r.Left, r.Top, r.Right - 1, r.Top);
			g.DrawLine(p, r.Left, r.Bottom - 1, r.Right - 1, r.Bottom - 1);
		}
	}

	private void DrawInnerStroke(Graphics g, Rectangle r)
	{
		checked
		{
			r.X++;
			r.Y++;
			r.Width -= 2;
			r.Height -= 2;
			Pen p = new Pen(HighlightColor);
			g.DrawLine(p, r.Left, r.Top, r.Right - 1, r.Top);
			g.DrawLine(p, r.Left, r.Bottom - 1, r.Right - 1, r.Bottom - 1);
		}
	}

	private void DrawHighlight(Graphics g, Rectangle rBorder)
	{
		checked
		{
			if (Enabled)
			{
				int alpha = 150;
				Rectangle r = new Rectangle(rBorder.X, rBorder.Y, rBorder.Width, (int)Math.Round((double)rBorder.Height / 2.0));
				LinearGradientBrush lg = new LinearGradientBrush(r, Color.FromArgb(alpha, HighlightColor), Color.FromArgb((int)Math.Round((double)alpha / 3.0), HighlightColor), 90.1f, isAngleScaleable: true);
				lg.WrapMode = WrapMode.TileFlipXY;
				g.FillRectangle(lg, r);
			}
		}
	}

	private void DrawGlossyEffect(Graphics g, Rectangle rBorder)
	{
		SetClip(g);
		Rectangle r = new Rectangle(rBorder.X, rBorder.Y, rBorder.Width, rBorder.Height);
		GraphicsPath glow = CreateTopRoundRectangle(r, 2);
		PathGradientBrush gl = new PathGradientBrush(glow);
		gl.CenterColor = Color.FromArgb(70, Color.FromArgb(141, 189, 255));
		gl.SurroundColors = new Color[1] { Color.FromArgb(0, Color.FromArgb(141, 189, 255)) };
		g.FillPath(gl, glow);
		g.ResetClip();
	}

	private void SetClip(Graphics g)
	{
		Rectangle r = ClientRectangle;
		checked
		{
			r.X++;
			r.Y++;
			r.Width -= 3;
			r.Height -= 3;
			g.SetClip(r);
		}
	}

	private RectangleF DrawNodeText(Graphics g, TreeNode node, Rectangle rBounds, bool selected, bool HotTracked)
	{
		string txt = node.Text;
		bool title = false;
		Font NodeFont;
		if (HotTracked && !selected)
		{
			NodeFont = FontHotTracking;
			NodeBrush = new SolidBrush(FontColorHotTracking);
		}
		else if (selected)
		{
			NodeFont = Font;
			NodeBrush = new SolidBrush(FontColorSelected);
		}
		else
		{
			NodeFont = Font;
			if (node.ForeColor.IsEmpty)
			{
				NodeBrush = new SolidBrush(ForeColor);
			}
			else
			{
				NodeBrush = new SolidBrush(node.ForeColor);
			}
		}
		if (node is VistaNode n)
		{
			if (n.NodeFont != null)
			{
				NodeFont = n.NodeFont;
			}
			if (n.Highlighted)
			{
				NodeBrush = new SolidBrush(n.HighlightedColor);
				NodeFont = new Font(NodeFont.FontFamily, NodeFont.Size, FontStyle.Bold);
			}
			title = n.Title;
		}
		SizeF sz = g.MeasureString(txt, NodeFont, rBounds.Width, TextFormat);
		RectangleF textBounds = checked((!title) ? new RectangleF(rBounds.X, rBounds.Y + Convert.ToInt32(((float)rBounds.Height - sz.Height) / 2f), rBounds.Width, Convert.ToInt32(sz.Height)) : new RectangleF(10f, rBounds.Y + Convert.ToInt32(((float)rBounds.Height - sz.Height) / 2f), rBounds.Width, Convert.ToInt32(sz.Height)));
		g.DrawString(node.Text, NodeFont, NodeBrush, textBounds, TextFormat);
		textBounds.Width = sz.Width;
		return textBounds;
	}

	private void DrawNodeCustom(Graphics g, TreeNode node, RectangleF rText)
	{
		if (node is VistaNode { PostTextColor: var col } n)
		{
			Font NodeFont = ((n.Font != null) ? n.Font : Font);
			Brush br = ((!col.IsEmpty) ? new SolidBrush(n.PostTextColor) : NodeBrush);
			if (n.Highlighted)
			{
				br = new SolidBrush(n.HighlightedColor);
				NodeFont = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
			}
			g.DrawString(string.Format(CultureInfo.CurrentUICulture, " {0}", n.PostText), NodeFont, br, rText.X + rText.Width, rText.Y);
		}
	}

	public GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
	{
		float x = r.X;
		float y = r.Y;
		float w = r.Width;
		float h = r.Height;
		GraphicsPath rr = new GraphicsPath();
		rr.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
		rr.AddLine(x + r1, y, x + w - r2, y);
		rr.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
		rr.AddLine(x + w, y + r2, x + w, y + h - r3);
		rr.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
		rr.AddLine(x + w - r3, y + h, x + r4, y + h);
		rr.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
		rr.AddLine(x, y + h - r4, x, y + r1);
		return rr;
	}

	private GraphicsPath CreateTopRoundRectangle(Rectangle rectangle, int radius)
	{
		GraphicsPath path = new GraphicsPath();
		int l = rectangle.Left;
		int t = rectangle.Top;
		int w = rectangle.Width;
		int h = rectangle.Height;
		int d = radius << 1;
		path.AddArc(l, t, d, d, 180f, 90f);
		checked
		{
			path.AddLine(l + radius, t, l + w - radius, t);
			path.AddArc(l + w - d, t, d, d, 270f, 90f);
			path.AddLine(l + w, t + radius, l + w, t + h);
			path.AddLine(l + w, t + h, l, t + h);
			path.AddLine(l, t + h, l, t + radius);
			path.CloseFigure();
			return path;
		}
	}
}
