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

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[ToolboxItem(true)]
public class spRRHH_Ficha_DatosPersonalesTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public spRRHH_Ficha_DatosPersonalesTableAdapter()
	{
		__ENCAddToList(this);
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "spRRHH_Ficha_DatosPersonales";
		dataTableMapping.ColumnMappings.Add("edadEmpleado", "edadEmpleado");
		dataTableMapping.ColumnMappings.Add("Nombres", "Nombres");
		dataTableMapping.ColumnMappings.Add("Apellido_Paterno", "Apellido_Paterno");
		dataTableMapping.ColumnMappings.Add("Apellido_Materno", "Apellido_Materno");
		dataTableMapping.ColumnMappings.Add("sexo", "sexo");
		dataTableMapping.ColumnMappings.Add("NumDocId", "NumDocId");
		dataTableMapping.ColumnMappings.Add("TipoDoc", "TipoDoc");
		dataTableMapping.ColumnMappings.Add("Nacionalidad", "Nacionalidad");
		dataTableMapping.ColumnMappings.Add("FechaNacimiento", "FechaNacimiento");
		dataTableMapping.ColumnMappings.Add("Telefono", "Telefono");
		dataTableMapping.ColumnMappings.Add("Fax", "Fax");
		dataTableMapping.ColumnMappings.Add("NumCelular", "NumCelular");
		dataTableMapping.ColumnMappings.Add("FonoCentroLab", "FonoCentroLab");
		dataTableMapping.ColumnMappings.Add("EstadoCivil", "EstadoCivil");
		dataTableMapping.ColumnMappings.Add("Discapacidad", "Discapacidad");
		dataTableMapping.ColumnMappings.Add("gradoInstruccion", "gradoInstruccion");
		dataTableMapping.ColumnMappings.Add("desdepartamento", "desdepartamento");
		dataTableMapping.ColumnMappings.Add("desprovincia", "desprovincia");
		dataTableMapping.ColumnMappings.Add("desdistrito", "desdistrito");
		dataTableMapping.ColumnMappings.Add("depCasa", "depCasa");
		dataTableMapping.ColumnMappings.Add("ProvCasa", "ProvCasa");
		dataTableMapping.ColumnMappings.Add("DistCasa", "DistCasa");
		dataTableMapping.ColumnMappings.Add("direccion", "direccion");
		dataTableMapping.ColumnMappings.Add("NumRUC", "NumRUC");
		dataTableMapping.ColumnMappings.Add("NumLibretaMilitar", "NumLibretaMilitar");
		dataTableMapping.ColumnMappings.Add("foto", "foto");
		dataTableMapping.ColumnMappings.Add("idempleado", "idempleado");
		dataTableMapping.ColumnMappings.Add("FechaRegistro", "FechaRegistro");
		dataTableMapping.ColumnMappings.Add("ExpSocial", "ExpSocial");
		dataTableMapping.ColumnMappings.Add("brevete", "brevete");
		dataTableMapping.ColumnMappings.Add("DescripTS", "DescripTS");
		dataTableMapping.ColumnMappings.Add("Descripvivecon", "Descripvivecon");
		dataTableMapping.ColumnMappings.Add("JefeHogar", "JefeHogar");
		dataTableMapping.ColumnMappings.Add("CargaFam", "CargaFam");
		dataTableMapping.ColumnMappings.Add("Numhijos", "Numhijos");
		dataTableMapping.ColumnMappings.Add("ObsFam", "ObsFam");
		dataTableMapping.ColumnMappings.Add("TipoFamDescrip", "TipoFamDescrip");
		dataTableMapping.ColumnMappings.Add("relacParejaDescrip", "relacParejaDescrip");
		dataTableMapping.ColumnMappings.Add("RelacPHDescrip", "RelacPHDescrip");
		dataTableMapping.ColumnMappings.Add("RelacHermanoDescrip", "RelacHermanoDescrip");
		dataTableMapping.ColumnMappings.Add("com1", "com1");
		dataTableMapping.ColumnMappings.Add("com2", "com2");
		dataTableMapping.ColumnMappings.Add("afec1", "afec1");
		dataTableMapping.ColumnMappings.Add("afec2", "afec2");
		dataTableMapping.ColumnMappings.Add("decis1", "decis1");
		dataTableMapping.ColumnMappings.Add("decis2", "decis2");
		dataTableMapping.ColumnMappings.Add("soc1", "soc1");
		dataTableMapping.ColumnMappings.Add("soc2", "soc2");
		dataTableMapping.ColumnMappings.Add("soc3", "soc3");
		dataTableMapping.ColumnMappings.Add("respues1", "respues1");
		dataTableMapping.ColumnMappings.Add("respues2", "respues2");
		dataTableMapping.ColumnMappings.Add("respues3", "respues3");
		dataTableMapping.ColumnMappings.Add("PrincipProblemas", "PrincipProblemas");
		dataTableMapping.ColumnMappings.Add("PropMejoraInstitu", "PropMejoraInstitu");
		dataTableMapping.ColumnMappings.Add("hobby", "hobby");
		dataTableMapping.ColumnMappings.Add("ActRecreaInstitu", "ActRecreaInstitu");
		dataTableMapping.ColumnMappings.Add("AcudeEnfermDescrip", "AcudeEnfermDescrip");
		dataTableMapping.ColumnMappings.Add("enfercronica", "enfercronica");
		dataTableMapping.ColumnMappings.Add("enfercronicadescrip", "enfercronicadescrip");
		dataTableMapping.ColumnMappings.Add("famdiscapacidad", "famdiscapacidad");
		dataTableMapping.ColumnMappings.Add("famdiscapdescrip", "famdiscapdescrip");
		dataTableMapping.ColumnMappings.Add("alergico", "alergico");
		dataTableMapping.ColumnMappings.Add("alergicodescrip", "alergicodescrip");
		_adapter.TableMappings.Add(dataTableMapping);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitConnection()
	{
		_connection = new SqlConnection();
		_connection.ConnectionString = MySettings.Default.CMIConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "dbo.spRRHH_Ficha_DatosPersonales";
		_commandCollection[0].CommandType = CommandType.StoredProcedure;
		_commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@CodEmple", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(DataSet1.spRRHH_Ficha_DatosPersonalesDataTable dataTable, int? CodEmple)
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual DataSet1.spRRHH_Ficha_DatosPersonalesDataTable GetData(int? CodEmple)
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
		DataSet1.spRRHH_Ficha_DatosPersonalesDataTable spRRHH_Ficha_DatosPersonalesDataTable = new DataSet1.spRRHH_Ficha_DatosPersonalesDataTable();
		Adapter.Fill(spRRHH_Ficha_DatosPersonalesDataTable);
		return spRRHH_Ficha_DatosPersonalesDataTable;
	}
}
