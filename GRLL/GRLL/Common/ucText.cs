using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucText : TextBox
{
	public delegate void BorderChangedEventHandler(object sender, FlatBoxEventArgs e);

	public delegate void KeyEnterEventHandler();

	public class FlatBoxEventArgs : EventArgs
	{
		public Color BorderColor;

		public bool GotFocus;

		public FlatBoxEventArgs(Color Bordercolor, bool GotFocus)
		{
			BorderColor = Bordercolor;
			this.GotFocus = GotFocus;
		}
	}

	public class AutoCompleteEventArgs : EventArgs
	{
		public string Text;

		public AutoCompleteEventArgs(string Text)
		{
			this.Text = Text;
		}
	}

	private IContainer components;

	private const int WM_PAINT = 15;

	private bool IamON;

	private bool IamFocus;

	private Color _ActiveBorderColor;

	private Color _InactiveBorderColor;

	private Color _BorderColor;

	private bool _SelectOnEnter;

	private bool _ExitOnEnter;

	private bool _ExitOnMaxLength;

	private Color _ForeColor;

	private Color _BackColor;

	private Color _ForeColorFocus;

	private Color _BackColorFocus;

	private string _ValueOriginal;

	private bool _ValueChanged;

	private string _MsgError;

	private bool _IsError;

	private bool _Valida;

	private ErrorProvider ErrorP;

	private clsVariables.TipoDato _TipoDato;

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

	public clsVariables.TipoDato TipoDato
	{
		get
		{
			return _TipoDato;
		}
		set
		{
			_TipoDato = value;
		}
	}

	public bool Valida
	{
		get
		{
			return _Valida;
		}
		set
		{
			_Valida = value;
		}
	}

	public string MsgError
	{
		get
		{
			return ErrorP.GetError(this);
		}
		set
		{
			_MsgError = value;
		}
	}

	public bool IsError
	{
		get
		{
			ValidaTxt();
			return _IsError;
		}
	}

	public bool SelectOnEnter
	{
		get
		{
			return _SelectOnEnter;
		}
		set
		{
			_SelectOnEnter = value;
		}
	}

	public bool ValueChanged => _ValueChanged;

	public string ValueOriginal => _ValueOriginal;

	public new Color ForeColor
	{
		get
		{
			return _ForeColor;
		}
		set
		{
			_ForeColor = value;
			base.ForeColor = _ForeColor;
		}
	}

	public new Color BackColor
	{
		get
		{
			return _BackColor;
		}
		set
		{
			_BackColor = value;
			base.BackColor = _BackColor;
		}
	}

	public Color ForeColorFocus
	{
		get
		{
			return _ForeColorFocus;
		}
		set
		{
			_ForeColorFocus = value;
		}
	}

	public Color BackColorFocus
	{
		get
		{
			return _BackColorFocus;
		}
		set
		{
			_BackColorFocus = value;
		}
	}

	public bool ExitOnEnter
	{
		get
		{
			return _ExitOnEnter;
		}
		set
		{
			_ExitOnEnter = value;
		}
	}

	public bool ExitOnMaxLength
	{
		get
		{
			return _ExitOnMaxLength;
		}
		set
		{
			_ExitOnMaxLength = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

	[method: DebuggerNonUserCode]
	public event KeyEnterEventHandler KeyEnter;

	public ucText()
	{
		base.TextChanged += ucText_TextChanged;
		base.KeyUp += ucText_KeyUp;
		base.LostFocus += ucText_LostFocus;
		base.MouseEnter += ucText_MouseEnter;
		base.MouseLeave += ucText_MouseLeave;
		base.MouseHover += ucText_MouseHover;
		base.MultilineChanged += ucText_MultilineChanged;
		base.Leave += ucText_Leave;
		base.LostFocus += ucText_Leave;
		base.GotFocus += ucText_GotFocus;
		base.KeyPress += ucText_KeyPress;
		_ActiveBorderColor = SystemColors.ControlDarkDark;
		_InactiveBorderColor = SystemColors.ControlDark;
		_SelectOnEnter = true;
		_ExitOnEnter = true;
		_ExitOnMaxLength = true;
		_ForeColor = Color.FromKnownColor(KnownColor.WindowText);
		_BackColor = Color.FromKnownColor(KnownColor.Window);
		_ForeColorFocus = Color.FromKnownColor(KnownColor.Blue);
		_BackColorFocus = Color.FromArgb(255, 192, 255);
		_ValueOriginal = "";
		_ValueChanged = false;
		_MsgError = "Un dato es requerido aquí";
		_IsError = true;
		_Valida = false;
		ErrorP = new ErrorProvider();
		_TipoDato = clsVariables.TipoDato.LetrasConEspacio;
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
		this.SuspendLayout();
		this.Name = "ucText";
		System.Drawing.Size size = new System.Drawing.Size(159, 54);
		this.Size = size;
		this.ResumeLayout(false);
	}

	protected override void OnValidating(CancelEventArgs e)
	{
		if (_Valida)
		{
			ValidaTxt();
		}
	}

	private void ValidaTxt()
	{
		if (Text.Length == 0)
		{
			if (DesignMode)
			{
				_IsError = false;
			}
			else
			{
				ErrorP.SetError(this, _MsgError);
				_IsError = true;
			}
			if (!_Valida)
			{
				ErrorP.SetError(this, "");
				_IsError = false;
			}
		}
		else
		{
			ErrorP.SetError(this, "");
			_IsError = false;
		}
	}

	private void ucText_GotFocus(object sender, EventArgs e)
	{
		base.ForeColor = _ForeColorFocus;
		base.BackColor = _BackColorFocus;
		if (_SelectOnEnter)
		{
			base.SelectionStart = 0;
			base.SelectionLength = base.Text.Length;
		}
		IamON = true;
		Invalidate();
	}

	private void ucText_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.KeyChar) == 13)
		{
			KeyEnter?.Invoke();
			if (Multiline)
			{
				e.Handled = false;
				return;
			}
			if (_ExitOnEnter)
			{
				SendKeys.Send("{Tab}");
			}
		}
		if (Strings.Asc(e.KeyChar) == 8)
		{
			return;
		}
		string CadValidar = "";
		switch (_TipoDato)
		{
		case clsVariables.TipoDato.NumeroConSigno:
			switch (Strings.Asc(e.KeyChar))
			{
			case 45:
				if (Strings.Len(base.Text.Trim()) > 0)
				{
					e.Handled = true;
				}
				break;
			case 46:
				if (Strings.Len(base.Text.Trim()) < 1 || base.Text.Contains("."))
				{
					e.Handled = true;
				}
				break;
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
				break;
			default:
				e.Handled = true;
				break;
			}
			break;
		case clsVariables.TipoDato.NumeroSinSigno:
			switch (Strings.Asc(e.KeyChar))
			{
			case 46:
				if (Strings.Len(base.Text.Trim()) < 1 || base.Text.Contains("."))
				{
					e.Handled = true;
				}
				break;
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
				break;
			default:
				e.Handled = true;
				break;
			}
			break;
		case clsVariables.TipoDato.NumeroEntero:
		{
			int num = Strings.Asc(e.KeyChar);
			if (num < 48 || num > 57)
			{
				e.Handled = true;
			}
			break;
		}
		case clsVariables.TipoDato.LetrasSinEspacio:
			CadValidar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚÄËÏÖÜÂÊÎÔÛ";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.LetrasConEspacio:
			CadValidar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚÄËÏÖÜÂÊÎÔÛ ";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.LetrasyNumeros:
			CadValidar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚÄËÏÖÜÂÊÎÔÛ 0123456789";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.Direccion:
			CadValidar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) >= 1)
			{
				break;
			}
			if (Strings.Len(base.Text.Trim()) < 1)
			{
				e.Handled = true;
				break;
			}
			CadValidar = "áéíóúÁÉÍÓÚÄËÏÖÜÂÊÎÔÛ 0123456789ª°/-\\.";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.Fonos:
			CadValidar = "0123456789";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) >= 1)
			{
				break;
			}
			if (Strings.Len(base.Text.Trim()) < 1)
			{
				e.Handled = true;
				break;
			}
			CadValidar = "(-)";
			CadValidar = "-";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
				break;
			}
			switch (e.KeyChar)
			{
			case '(':
				if (!Versioned.IsNumeric(ModFunciones.Right(base.Text.Trim(), 1)))
				{
					e.Handled = true;
				}
				break;
			case ')':
				if (!Versioned.IsNumeric(ModFunciones.Right(base.Text.Trim(), 1)))
				{
					e.Handled = true;
				}
				else if (Strings.InStr(base.Text, "(", CompareMethod.Text) < 1)
				{
					e.Handled = true;
				}
				break;
			case '-':
				if (!Versioned.IsNumeric(ModFunciones.Right(base.Text.Trim(), 1)))
				{
					e.Handled = true;
				}
				break;
			case '*':
			case '+':
			case ',':
				break;
			}
			break;
		case clsVariables.TipoDato.Email:
			CadValidar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) >= 1 || Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) >= 1)
			{
				break;
			}
			if (Strings.Len(base.Text.Trim()) < 1)
			{
				e.Handled = true;
				break;
			}
			CadValidar = "@_.";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.Fecha:
			CadValidar = "0123456789-/";
			if (Text.Trim().Length > 10)
			{
				e.Handled = true;
			}
			else if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		case clsVariables.TipoDato.Todo:
			CadValidar = "0123456789.abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ @_°\\/*-+[]½()¼{¾}%ºª¹²³~:,&";
			if (Strings.InStr(CadValidar, Conversions.ToString(e.KeyChar), CompareMethod.Text) < 1)
			{
				e.Handled = true;
			}
			break;
		}
	}

	private void ucText_TextChanged(object sender, EventArgs e)
	{
		_ValueChanged = Operators.CompareString(_ValueOriginal, Text, TextCompare: false) != 0;
		if (base.MaxLength > 0 && _ExitOnMaxLength && base.SelectionStart >= base.MaxLength)
		{
			SendKeys.Send("{Tab}");
		}
	}

	private void ucText_KeyUp(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Down:
			if (!Multiline)
			{
				SendKeys.Send("{Tab}");
				e.Handled = true;
			}
			break;
		case Keys.Up:
			if (!Multiline)
			{
				SendKeys.Send("+{Tab}");
				e.Handled = true;
			}
			break;
		case Keys.Right:
			break;
		}
	}

	private void ucText_LostFocus(object sender, EventArgs e)
	{
		base.ForeColor = _ForeColor;
		base.BackColor = _BackColor;
		IamON = false;
	}

	public void SetStartEdit()
	{
		_ValueOriginal = Text;
	}

	public void Reset()
	{
		Text = _ValueOriginal;
	}

	private void ucText_MouseEnter(object sender, EventArgs e)
	{
		IamON = true;
		Invalidate();
	}

	private void ucText_MouseLeave(object sender, EventArgs e)
	{
		IamON = false;
		Invalidate();
	}

	private void ucText_MouseHover(object sender, EventArgs e)
	{
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
				g.DrawRectangle(new Pen(_BorderColor), 0, 0, cliente.Width - 1, cliente.Height - 1);
				g.Dispose();
				BorderChanged?.Invoke(this, new FlatBoxEventArgs(_BorderColor, IamON));
			}
		}
	}

	private void ucText_MultilineChanged(object sender, EventArgs e)
	{
		if (Multiline)
		{
			ScrollBars = ScrollBars.Vertical;
		}
		else
		{
			ScrollBars = ScrollBars.None;
		}
	}

	private void ucText_Leave(object sender, EventArgs e)
	{
		if (Operators.CompareString(ModFunciones.Right(base.Text.Trim(), 1), "(", TextCompare: false) == 0)
		{
			base.Text = ModFunciones.Left(base.Text.Trim(), checked(base.Text.Length - 1));
		}
	}
}
