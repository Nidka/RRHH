using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RecursosHumanos.My;

namespace RecursosHumanos.DataSet_PorcentajeTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[ToolboxItem(true)]
public class QueriesTableAdapter : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IDbCommand[] _commandCollection;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected IDbCommand[] CommandCollection
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

	[DebuggerNonUserCode]
	public QueriesTableAdapter()
	{
		__ENCAddToList(this);
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new IDbCommand[1];
		_commandCollection[0] = new SqlCommand();
		((SqlCommand)_commandCollection[0]).Connection = new SqlConnection(MySettings.Default.CMIConnectionString);
		((SqlCommand)_commandCollection[0]).CommandText = "dbo.spRRHH_EstadisticaPermiso";
		((SqlCommand)_commandCollection[0]).CommandType = CommandType.StoredProcedure;
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@IdTipoTrabajador", SqlDbType.Char, 1, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.Char, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.Char, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@idMotivos", SqlDbType.VarChar, 150, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@Motivos", SqlDbType.VarChar, 450, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@MotivosNull", SqlDbType.VarChar, 2050, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@idAreas", SqlDbType.VarChar, 450, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual object spRRHH_EstadisticaPermiso(string IdTipoTrabajador, string FechaInicio, string FechaFin, string idMotivos, string Motivos, string MotivosNull, string idAreas)
	{
		SqlCommand sqlCommand = (SqlCommand)CommandCollection[0];
		if (IdTipoTrabajador == null)
		{
			sqlCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[1].Value = IdTipoTrabajador;
		}
		if (FechaInicio == null)
		{
			sqlCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[2].Value = FechaInicio;
		}
		if (FechaFin == null)
		{
			sqlCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[3].Value = FechaFin;
		}
		if (idMotivos == null)
		{
			sqlCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[4].Value = idMotivos;
		}
		if (Motivos == null)
		{
			sqlCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[5].Value = Motivos;
		}
		if (MotivosNull == null)
		{
			sqlCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[6].Value = MotivosNull;
		}
		if (idAreas == null)
		{
			sqlCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			sqlCommand.Parameters[7].Value = idAreas;
		}
		ConnectionState state = sqlCommand.Connection.State;
		if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			sqlCommand.Connection.Open();
		}
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar());
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				sqlCommand.Connection.Close();
			}
		}
		if (objectValue == null || ((objectValue.GetType() == typeof(DBNull)) ? true : false))
		{
			return null;
		}
		return objectValue;
	}
}
