using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RecursosHumanos.My;

namespace RecursosHumanos.DataSet1TableAdapters;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[ToolboxItem(true)]
public class spRRHH_Ficha_ViviendaTableAdapter : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("_adapter")]
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private SqlDataAdapter _adapter
	{
		[DebuggerNonUserCode]
		get
		{
			return __adapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__adapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.DeleteCommand != null) ? true : false)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.InsertCommand != null) ? true : false)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if ((Adapter != null && Adapter.UpdateCommand != null) ? true : false)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_Ficha_ViviendaTableAdapter()
	{
		__ENCAddToList(this);
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "spRRHH_Ficha_Vivienda";
		dataTableMapping.ColumnMappings.Add("DescripTenencia", "DescripTenencia");
		dataTableMapping.ColumnMappings.Add("DescripTipo", "DescripTipo");
		dataTableMapping.ColumnMappings.Add("DescripMaterial", "DescripMaterial");
		dataTableMapping.ColumnMappings.Add("DescripConserva", "DescripConserva");
		dataTableMapping.ColumnMappings.Add("NumDormitorio", "NumDormitorio");
		dataTableMapping.ColumnMappings.Add("NumServHig", "NumServHig");
		dataTableMapping.ColumnMappings.Add("DescripUbicacion", "DescripUbicacion");
		dataTableMapping.ColumnMappings.Add("DescripAlumbrado", "DescripAlumbrado");
		dataTableMapping.ColumnMappings.Add("otroalumbrado", "otroalumbrado");
		dataTableMapping.ColumnMappings.Add("descripAgua", "descripAgua");
		dataTableMapping.ColumnMappings.Add("OtroAgua", "OtroAgua");
		dataTableMapping.ColumnMappings.Add("DescripExcretas", "DescripExcretas");
		dataTableMapping.ColumnMappings.Add("OtroExcreta", "OtroExcreta");
		dataTableMapping.ColumnMappings.Add("telefono", "telefono");
		dataTableMapping.ColumnMappings.Add("cable", "cable");
		dataTableMapping.ColumnMappings.Add("internet", "internet");
		dataTableMapping.ColumnMappings.Add("otros", "otros");
		dataTableMapping.ColumnMappings.Add("NumCompart", "NumCompart");
		dataTableMapping.ColumnMappings.Add("NumPerDorm", "NumPerDorm");
		dataTableMapping.ColumnMappings.Add("observacion", "observacion");
		_adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitConnection()
	{
		_connection = new SqlConnection();
		_connection.ConnectionString = MySettings.Default.CMIConnectionString;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "dbo.spRRHH_Ficha_Vivienda";
		_commandCollection[0].CommandType = CommandType.StoredProcedure;
		_commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@CodEmple", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(DataSet1.spRRHH_Ficha_ViviendaDataTable dataTable, int? CodEmple)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (CodEmple.HasValue)
		{
			Adapter.SelectCommand.Parameters[1].Value = CodEmple.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual DataSet1.spRRHH_Ficha_ViviendaDataTable GetData(int? CodEmple)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (CodEmple.HasValue)
		{
			Adapter.SelectCommand.Parameters[1].Value = CodEmple.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		DataSet1.spRRHH_Ficha_ViviendaDataTable spRRHH_Ficha_ViviendaDataTable = new DataSet1.spRRHH_Ficha_ViviendaDataTable();
		Adapter.Fill(spRRHH_Ficha_ViviendaDataTable);
		return spRRHH_Ficha_ViviendaDataTable;
	}
}
