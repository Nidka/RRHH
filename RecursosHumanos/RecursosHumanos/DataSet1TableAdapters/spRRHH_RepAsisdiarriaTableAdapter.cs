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

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class spRRHH_RepAsisdiarriaTableAdapter : Component
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	public spRRHH_RepAsisdiarriaTableAdapter()
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
		dataTableMapping.DataSetTable = "spRRHH_RepAsisdiarria";
		dataTableMapping.ColumnMappings.Add("nombres", "nombres");
		dataTableMapping.ColumnMappings.Add("HoraE", "HoraE");
		dataTableMapping.ColumnMappings.Add("HoraS", "HoraS");
		dataTableMapping.ColumnMappings.Add("fecha1", "fecha1");
		_adapter.TableMappings.Add(dataTableMapping);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		_commandCollection[0].CommandText = "dbo.spRRHH_RepAsisdiarria";
		_commandCollection[0].CommandType = CommandType.StoredProcedure;
		_commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@FechaI", SqlDbType.NVarChar, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@fechaF", SqlDbType.NVarChar, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(DataSet1.spRRHH_RepAsisdiarriaDataTable dataTable, string FechaI, string fechaF)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (FechaI == null)
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = FechaI;
		}
		if (fechaF == null)
		{
			Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[2].Value = fechaF;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual DataSet1.spRRHH_RepAsisdiarriaDataTable GetData(string FechaI, string fechaF)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (FechaI == null)
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = FechaI;
		}
		if (fechaF == null)
		{
			Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[2].Value = fechaF;
		}
		DataSet1.spRRHH_RepAsisdiarriaDataTable spRRHH_RepAsisdiarriaDataTable = new DataSet1.spRRHH_RepAsisdiarriaDataTable();
		Adapter.Fill(spRRHH_RepAsisdiarriaDataTable);
		return spRRHH_RepAsisdiarriaDataTable;
	}
}
