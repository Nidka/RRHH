using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace GRLL.Common;

[Serializable]
public class VistaNode : TreeNode
{
	private string _postText;

	private Color _postTextColor;

	private bool _postTextShow;

	private Font _font;

	private bool _highlighted;

	private Color _highlightedColor;

	private bool _title;

	public string PostText
	{
		get
		{
			return _postText;
		}
		set
		{
			_postText = value;
			ForceUpdate();
		}
	}

	public Color PostTextColor
	{
		get
		{
			return _postTextColor;
		}
		set
		{
			_postTextColor = value;
			ForceUpdate();
		}
	}

	public Font Font
	{
		get
		{
			return _font;
		}
		set
		{
			_font = value;
			ForceUpdate();
		}
	}

	public Color HighlightedColor
	{
		get
		{
			return _highlightedColor;
		}
		set
		{
			_highlightedColor = value;
			ForceUpdate();
		}
	}

	public bool Highlighted
	{
		get
		{
			return _highlighted;
		}
		set
		{
			_highlighted = value;
			ForceUpdate();
		}
	}

	public bool PostTextShow
	{
		get
		{
			return _postTextShow;
		}
		set
		{
			_postTextShow = value;
			ForceUpdate();
		}
	}

	public bool Title
	{
		get
		{
			return _title;
		}
		set
		{
			_title = value;
		}
	}

	protected VistaNode(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public VistaNode()
	{
		_postTextColor = Color.Empty;
		_postTextShow = true;
		_postText = string.Empty;
		_font = null;
		_highlighted = false;
		_highlightedColor = Color.Empty;
		_title = false;
	}

	private void ForceUpdate()
	{
		base.Text = base.Text;
	}
}
