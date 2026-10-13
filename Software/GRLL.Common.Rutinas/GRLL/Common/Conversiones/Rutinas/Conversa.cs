using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRLL.Common.Conversiones.Rutinas;

public static class Conversa
{
	public delegate object[] CreateRowDelegate<T>(T t);

	private const string regExNumericParse = "^-{0,1}\\d+$";

	private const string regExNumericParseWithDot = "^-{0,1}\\d*\\.{0,1}\\d+$";

	private const string regExNumericParseWithComma = "^-{0,1}\\d*\\,{0,1}\\d+$";

	public static bool ToMsg(this string ms)
	{
		return true;
	}

	public static decimal Sum(this DataGridView grid, string ColumnName)
	{
		if (grid.Columns[ColumnName].ValueType != typeof(int) || grid.Columns[ColumnName].ValueType != typeof(decimal) || grid.Columns[ColumnName].ValueType != typeof(double))
		{
			return 0m;
		}
		DataGridViewRowCollection rows = grid.Rows;
		decimal result = 0m;
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rows)
			{
				if (item.Cells[ColumnName].Value != null)
				{
					result += item.Cells[ColumnName].Value.ToString().ToDecimal();
				}
			}
			return result;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static decimal Sum(this DataGridView grid, int ColumnIndex)
	{
		if (grid.Columns[ColumnIndex].ValueType != typeof(int) && grid.Columns[ColumnIndex].ValueType != typeof(decimal) && grid.Columns[ColumnIndex].ValueType != typeof(double))
		{
			return 0m;
		}
		DataGridViewRowCollection rows = grid.Rows;
		decimal result = 0m;
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rows)
			{
				if (item.Cells[ColumnIndex].Value != null)
				{
					result += item.Cells[ColumnIndex].Value.ToString().ToDecimal();
				}
			}
			return result;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static bool FindAndSel(this DataGridView grid, string ColumnName, string Param)
	{
		DataGridViewRowCollection rows = grid.Rows;
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rows)
			{
				if (item.Cells[ColumnName].Value.ToString().Trim() == Param)
				{
					if (grid.Columns[ColumnName].Visible)
					{
						grid.CurrentCell = grid.Rows[item.Index].Cells[0];
					}
					return true;
				}
			}
			return false;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static bool FindAndSel(this DataGridView grid, int ColumnIndex, string Param)
	{
		DataGridViewRowCollection rows = grid.Rows;
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rows)
			{
				if (item.Cells[ColumnIndex].Value.ToString().Trim() == Param)
				{
					if (grid.Columns[ColumnIndex].Visible)
					{
						grid.CurrentCell = grid.Rows[item.Index].Cells[0];
					}
					return true;
				}
			}
			return false;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataGridView grid, string ColumnName, string Param)
	{
		try
		{
			return grid.Rows.FindRow(ColumnName, Param);
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataGridView grid, int ColumnIndex, string Param)
	{
		try
		{
			return grid.Rows.FindRow(ColumnIndex, Param);
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataGridViewRowCollection rowCol, string ColumnName, string Param)
	{
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rowCol)
			{
				if (item.Cells[ColumnName].Value.ToString().Trim() == Param)
				{
					return item.Index;
				}
			}
			return -1;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataGridViewRowCollection rowCol, int ColumnIndex, string Param)
	{
		try
		{
			foreach (DataGridViewRow item in (IEnumerable)rowCol)
			{
				if (item.Cells[ColumnIndex].Value.ToString().Trim() == Param)
				{
					return item.Index;
				}
			}
			return -1;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataRowCollection rowCol, string ColumnName, string Param)
	{
		int num = 0;
		try
		{
			foreach (DataRow item in rowCol)
			{
				if (item[ColumnName].ToString().Trim() == Param)
				{
					return num;
				}
				num++;
			}
			return -1;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static int FindRow(this DataRowCollection rowCol, int ColumnIndex, string Param)
	{
		int num = 0;
		try
		{
			foreach (DataRow item in rowCol)
			{
				if (item[ColumnIndex].ToString().Trim() == Param)
				{
					return num;
				}
				num++;
			}
			return -1;
		}
		catch (Exception)
		{
			throw;
		}
	}

	public static string Right(this string ms, int num)
	{
		try
		{
			return ms.Substring(ms.Length - num, num);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	public static string Left(this string ms, int num)
	{
		try
		{
			return ms.Substring(0, num);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	public static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
	{
		DataTable dataTable = new DataTable("tabla");
		if (varlist == null || varlist.Count() == 0)
		{
			return null;
		}
		PropertyInfo[] properties = varlist.ElementAt(0).GetType().GetProperties();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			if (propertyInfo.PropertyType == typeof(decimal?))
			{
				dataTable.Columns.Add(propertyInfo.Name, typeof(decimal));
			}
			else if (propertyInfo.PropertyType == typeof(int?))
			{
				dataTable.Columns.Add(propertyInfo.Name, typeof(int));
			}
			else if (propertyInfo.PropertyType == typeof(DateTime?))
			{
				dataTable.Columns.Add(propertyInfo.Name, typeof(DateTime));
			}
			else if (propertyInfo.PropertyType == typeof(char?))
			{
				dataTable.Columns.Add(propertyInfo.Name, typeof(char));
			}
			else if (propertyInfo.PropertyType == typeof(long?))
			{
				dataTable.Columns.Add(propertyInfo.Name, typeof(long));
			}
			else
			{
				dataTable.Columns.Add(propertyInfo.Name, propertyInfo.PropertyType);
			}
		}
		foreach (T item in varlist)
		{
			DataRow dataRow = dataTable.NewRow();
			PropertyInfo[] array2 = properties;
			foreach (PropertyInfo propertyInfo2 in array2)
			{
				if (propertyInfo2.GetValue(item, null) != null)
				{
					dataRow[propertyInfo2.Name] = propertyInfo2.GetValue(item, null);
				}
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	public static int ExisteEn(this string cadena, params string[] values)
	{
		if (values.Length > 0 && cadena.Length > 0)
		{
			int num = 0;
			foreach (string text in values)
			{
				if (text.ToUpper().Trim() == cadena.ToUpper().Trim())
				{
					return num;
				}
				num++;
			}
			return -1;
		}
		return -1;
	}

	public static void Limpiar_Controles(this Control miControl, params string[] excepciones)
	{
		foreach (Control control in miControl.Controls)
		{
			if (control.Name.ExisteEn(excepciones) == -1)
			{
				if (control.GetType() == typeof(ucTextBox))
				{
					control.Text = "";
				}
				if (control.GetType() == typeof(TextBox))
				{
					control.Text = "";
				}
				if (control.GetType() == typeof(ucComboBox))
				{
					ComboBox comboBox = (ucComboBox)control;
					if (comboBox.Items.Count > 0)
					{
						comboBox.SelectedIndex = 0;
					}
					else
					{
						comboBox.Text = "";
					}
				}
				if (control.GetType() == typeof(ComboBox))
				{
					ComboBox comboBox2 = (ComboBox)control;
					if (comboBox2.Items.Count > 0)
					{
						comboBox2.SelectedIndex = 0;
					}
					else
					{
						comboBox2.Text = "";
					}
				}
				if (control.GetType() == typeof(ucDateTime))
				{
					ucDateTime ucDateTime = (ucDateTime)control;
					ucDateTime.Value = DateTime.Today;
				}
				if (control.GetType() == typeof(DateTimePicker))
				{
					DateTimePicker dateTimePicker = (DateTimePicker)control;
					dateTimePicker.Value = DateTime.Today;
				}
			}
			control.Limpiar_Controles(excepciones);
		}
	}

	public static DateTime FechaCorta(this DateTime Dato)
	{
		return DateTime.Parse(Dato.ToShortDateString());
	}

	public static bool Vacio(this TextBox txt)
	{
		if (txt.Text == null)
		{
			return true;
		}
		if (txt.Text.Trim().Length == 0)
		{
			return true;
		}
		return false;
	}

	public static string SinNulo(this string texto)
	{
		if (texto == null)
		{
			return "";
		}
		return texto;
	}

	public static char SinNulo(this char texto)
	{
		return texto;
	}

	public static char? SinNulo(this char? texto)
	{
		if (!((int?)texto).HasValue)
		{
			return char.Parse(" ");
		}
		return texto;
	}

	public static decimal ToDecimal(this string dato)
	{
		if (dato.Trim().Length == 0)
		{
			return 0m;
		}
		if (!IsNumeric(dato, '.'))
		{
			return 0m;
		}
		return decimal.Parse(dato);
	}

	public static int ToInteger(this string dato)
	{
		if (dato.Trim().Length == 0)
		{
			return 0;
		}
		if (!IsNumeric(dato))
		{
			return 0;
		}
		return int.Parse(dato);
	}

	public static double ToDouble(this string dato)
	{
		if (dato.Trim().Length == 0)
		{
			return 0.0;
		}
		if (!IsNumeric(dato, '.'))
		{
			return 0.0;
		}
		return double.Parse(dato);
	}

	public static bool EsNulo(object valor)
	{
		if (valor == null)
		{
			return true;
		}
		return false;
	}

	public static void ShowChild(this Form form, Form parent)
	{
		form.MdiParent = parent;
		form.Show();
		form.Focus();
		form.BringToFront();
	}

	public static bool IsNumeric(string number)
	{
		return IsNumeric(number, ' ');
	}

	public static bool IsNumeric(string number, char decimalSeparator)
	{
		if (decimalSeparator != '.' && decimalSeparator != ',' && decimalSeparator != ' ')
		{
			throw new ArgumentException("decimalSeparator must be '.' or ','", "decimalSeparator");
		}
		return decimalSeparator switch
		{
			'.' => Regex.IsMatch(number.Trim(), "^-{0,1}\\d*\\.{0,1}\\d+$"),
			',' => Regex.IsMatch(number.Trim(), "^-{0,1}\\d*\\,{0,1}\\d+$"),
			' ' => Regex.IsMatch(number.Trim(), "^-{0,1}\\d+$"),
			_ => false,
		};
	}
}
