using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[ToolboxItem(true)]
[ToolboxBitmap(typeof(ucTextBox))]
public class ucTextBox : TextBox
{
	public delegate void BorderChangedEventHandler(object sender, FlatBoxEventArgs e);

	public delegate void onESCAPEEventHandler();

	public enum TipoDato
	{
		Enteros,
		EnterosConNegativos,
		Decimales,
		DecimalesConNegativos,
		SoloLetras,
		LetrasNumeros,
		Todos,
		Custom
	}

	public delegate void EnterPressEventHandler();

	private const int WM_PAINT = 15;

	private bool IamON;

	private bool IamFocus;

	private string _OnErrorBlankText;

	private Regex Expression;

	private TipoDato sTipo;

	private Color sColor;

	private Color nColor;

	private string m_RegularExpression;

	private bool _IsRequired;

	private string _ErrorMessage;

	private string _Formato;

	private bool _TabNextControl;

	private Color _ActiveBorderColor;

	private Color _InactiveBorderColor;

	private Color _BorderColor;

	private Color _SelectionColor;

	private Color _NormalColor;

	private Color _SelectionForeColor;

	private Color _NormalForeColor;

	private int _PadLeftLenght;

	private IContainer components;

	private ErrorProvider vError;

	public string Formato
	{
		get
		{
			return _Formato;
		}
		set
		{
			_Formato = value;
		}
	}

	[DefaultValue(false)]
	public bool IsRequired
	{
		get
		{
			return _IsRequired;
		}
		set
		{
			_IsRequired = value;
		}
	}

	public Color SelectionForeColor
	{
		get
		{
			return _SelectionForeColor;
		}
		set
		{
			_SelectionForeColor = value;
		}
	}

	public Color SelectionBackColor
	{
		get
		{
			return _SelectionColor;
		}
		set
		{
			_SelectionColor = value;
		}
	}

	public Color NormalColor
	{
		get
		{
			return _NormalColor;
		}
		set
		{
			_NormalColor = value;
		}
	}

	public Color NormalForeColor
	{
		get
		{
			return _NormalForeColor;
		}
		set
		{
			_NormalForeColor = value;
		}
	}

	public Color ActiveBorderColor
	{
		get
		{
			return _ActiveBorderColor;
		}
		set
		{
			_ActiveBorderColor = value;
		}
	}

	public Color InactiveBorderColor
	{
		get
		{
			return _InactiveBorderColor;
		}
		set
		{
			_InactiveBorderColor = value;
		}
	}

	[DefaultValue(".*")]
	public string RegularExpression
	{
		get
		{
			return m_RegularExpression;
		}
		set
		{
			m_RegularExpression = value;
		}
	}

	public TipoDato Tipo
	{
		get
		{
			return sTipo;
		}
		set
		{
			sTipo = value;
			switch (sTipo)
			{
			case TipoDato.Decimales:
				m_RegularExpression = "(^\\d*\\.?\\d*[0-9]+\\d*$)|(^[0-9]+\\d*\\.\\d*$)";
				break;
			case TipoDato.DecimalesConNegativos:
				m_RegularExpression = "^(\\d|-)?(\\d|,)*\\.?\\d*$";
				break;
			case TipoDato.Enteros:
				m_RegularExpression = "^[0-9]*$";
				break;
			case TipoDato.EnterosConNegativos:
				m_RegularExpression = "^[-+]?\\d*$";
				break;
			case TipoDato.SoloLetras:
				m_RegularExpression = "^[A-Z,a-z,\\s]+$";
				break;
			case TipoDato.LetrasNumeros:
				m_RegularExpression = "^[A-Z,a-z,0-9,\\s]+$";
				break;
			case TipoDato.Todos:
				m_RegularExpression = ".*";
				break;
			case TipoDato.Custom:
				break;
			}
		}
	}

	public bool TabNextControl
	{
		get
		{
			return _TabNextControl;
		}
		set
		{
			_TabNextControl = value;
		}
	}

	public int PadLeftLenght
	{
		get
		{
			return _PadLeftLenght;
		}
		set
		{
			_PadLeftLenght = value;
		}
	}

	public string OnErrorBlankText
	{
		get
		{
			return _OnErrorBlankText;
		}
		set
		{
			_OnErrorBlankText = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

	[method: DebuggerNonUserCode]
	public event onESCAPEEventHandler onESCAPE;

	[method: DebuggerNonUserCode]
	public event EnterPressEventHandler EnterPress;

	public ucTextBox(IContainer Container)
	{
		base.KeyDown += ucTextBox_KeyDown;
		base.KeyUp += ucTextBox_KeyUp;
		base.LostFocus += ucTextBox_LostFocus;
		base.TextChanged += uc_TextBox_TextChanged;
		base.Validated += ucTextBox_Validated;
		base.Validating += ucTextBox_Validating;
		base.VisibleChanged += uc_TextBox_VisibleChanged;
		_OnErrorBlankText = "";
		_TabNextControl = false;
		_ActiveBorderColor = SystemColors.ControlDark;
		_InactiveBorderColor = SystemColors.ControlDark;
		_SelectionColor = Color.FromArgb(255, 192, 255);
		_NormalColor = SystemColors.Window;
		_SelectionForeColor = Color.FromKnownColor(KnownColor.Blue);
		_NormalForeColor = SystemColors.ControlText;
		vError = new ErrorProvider();
		InitializeComponent();
		Container.Add(this);
	}

	public ucTextBox()
	{
		base.KeyDown += ucTextBox_KeyDown;
		base.KeyUp += ucTextBox_KeyUp;
		base.LostFocus += ucTextBox_LostFocus;
		base.TextChanged += uc_TextBox_TextChanged;
		base.Validated += ucTextBox_Validated;
		base.Validating += ucTextBox_Validating;
		base.VisibleChanged += uc_TextBox_VisibleChanged;
		_OnErrorBlankText = "";
		_TabNextControl = false;
		_ActiveBorderColor = SystemColors.ControlDark;
		_InactiveBorderColor = SystemColors.ControlDark;
		_SelectionColor = Color.FromArgb(255, 192, 255);
		_NormalColor = SystemColors.Window;
		_SelectionForeColor = Color.FromKnownColor(KnownColor.Blue);
		_NormalForeColor = SystemColors.ControlText;
		vError = new ErrorProvider();
		sColor = Color.Brown;
		nColor = Color.White;
		_PadLeftLenght = 0;
		InitializeComponent();
		ClearUndo();
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
		this.components = new System.ComponentModel.Container();
	}

	public void ClearErrors()
	{
		vError.Clear();
	}

	public bool Validar()
	{
		if (IsRequired)
		{
			if (Enabled & (Text.Trim().Length == 0))
			{
				if (Operators.CompareString(_OnErrorBlankText, "", TextCompare: false) == 0)
				{
					_OnErrorBlankText = "Dato incompleto";
				}
				vError.SetError(this, _OnErrorBlankText);
				return false;
			}
			vError.Clear();
			return true;
		}
		return true;
	}

	protected override void OnValidating(CancelEventArgs e)
	{
		if (IsRequired)
		{
			if (Focused & Enabled & (Text.Trim().Length == 0))
			{
				if (Operators.CompareString(_OnErrorBlankText, "", TextCompare: false) == 0)
				{
					_OnErrorBlankText = "Dato incompleto";
				}
				vError.SetError(this, _OnErrorBlankText);
				e.Cancel = true;
			}
			else
			{
				vError.Clear();
				e.Cancel = false;
			}
		}
		else
		{
			e.Cancel = false;
		}
		base.OnValidating(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		IamON = true;
		Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		IamON = false;
		Invalidate();
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		if (TextAlign == HorizontalAlignment.Right)
		{
			SelectionStart = 0;
			SelectionLength = TextLength;
		}
		base.OnMouseClick(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		if (!ReadOnly)
		{
			ForeColor = _NormalForeColor;
			BackColor = _NormalColor;
			IamON = false;
			Invalidate();
			if ((Tipo == TipoDato.Decimales) & (Text.Trim().Length > 0))
			{
				Text = Strings.Format(Conversions.ToDouble(Text), Formato);
			}
			if (((Tipo == TipoDato.Decimales) | (Tipo == TipoDato.Enteros)) && Text.Length > 0)
			{
				Text = Text.PadLeft(_PadLeftLenght, '0');
			}
		}
		base.OnLostFocus(e);
		vError.Clear();
	}

	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		if (!ReadOnly)
		{
			if (Enabled)
			{
				ForeColor = _SelectionForeColor;
				BackColor = _SelectionColor;
			}
			else
			{
				ForeColor = _NormalForeColor;
				BackColor = _NormalColor;
			}
		}
		if (TextAlign == HorizontalAlignment.Right)
		{
			SelectionStart = 0;
			SelectionLength = TextLength;
		}
		IamON = true;
		Invalidate();
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
		IamON = true;
		Invalidate();
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		checked
		{
			if (m.Msg == 15)
			{
				Graphics g = CreateGraphics();
				Rectangle cliente = ClientRectangle;
				if (IamON)
				{
					_BorderColor = _ActiveBorderColor;
				}
				else
				{
					_BorderColor = _InactiveBorderColor;
				}
				if (BorderStyle != BorderStyle.Fixed3D)
				{
					g.DrawRectangle(new Pen(_BorderColor), 0, 0, cliente.Width - 1, cliente.Height - 1);
					g.Dispose();
				}
				BorderChanged?.Invoke(this, new FlatBoxEventArgs(_BorderColor, IamON));
			}
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		base.OnKeyPress(e);
		if (e.KeyChar.CompareTo('\u001b') != 0 && e.KeyChar.CompareTo('\b') != 0 && e.KeyChar.CompareTo('\r') != 0)
		{
			if (m_RegularExpression.Length == 0)
			{
				m_RegularExpression = ".*";
			}
			Expression = new Regex(m_RegularExpression);
			string s = ((SelectionStart <= 0) ? e.KeyChar.ToString() : Text.Insert(SelectionStart, Conversions.ToString(e.KeyChar)));
			if (char.IsLetter(e.KeyChar))
			{
				e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
			}
			if (Expression.IsMatch(s))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
		if (e.KeyChar.CompareTo('\r') == 0)
		{
			if (((Tipo == TipoDato.Decimales) | (Tipo == TipoDato.Enteros)) && Text.Length > 0)
			{
				Text = Text.PadLeft(_PadLeftLenght, '0');
			}
			if (!Multiline)
			{
				EnterPress?.Invoke();
			}
		}
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		return base.ProcessDialogKey(keyData);
	}

	private void ucTextBox_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void ucTextBox_KeyUp(object sender, KeyEventArgs e)
	{
		if (!Multiline)
		{
			if ((e.KeyValue == 40) | (e.KeyValue == 13))
			{
				SendKeys.Send("{TAB}");
			}
			if (e.KeyValue == 38)
			{
				SendKeys.Send("+{TAB}");
			}
		}
	}

	private void ucTextBox_LostFocus(object sender, EventArgs e)
	{
	}

	private void uc_TextBox_TextChanged(object sender, EventArgs e)
	{
	}

	private void ucTextBox_Validated(object sender, EventArgs e)
	{
	}

	private void ucTextBox_Validating(object sender, CancelEventArgs e)
	{
	}

	private void uc_TextBox_VisibleChanged(object sender, EventArgs e)
	{
		if (Text.Length != 0 && Formato != null && Formato.Length != 0)
		{
			if ((Tipo == TipoDato.Decimales) & (Text.Trim().Length > 0))
			{
				Text = Strings.Format(Conversions.ToDouble(Text), Formato);
			}
			if (((Tipo == TipoDato.Decimales) | (Tipo == TipoDato.Enteros)) && Text.Length > 0)
			{
				Text = Text.PadLeft(_PadLeftLenght, '0');
			}
		}
	}
}
