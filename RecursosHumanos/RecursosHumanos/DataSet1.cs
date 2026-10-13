using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[Serializable]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("DataSet1")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
public class DataSet1 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_ExpLabRowChangeEventHandler(object sender, spRRHH_Ficha_ExpLabRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_ExpLab_DatosRowChangeEventHandler(object sender, spRRHH_Ficha_ExpLab_DatosRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Det_FamiliarRowChangeEventHandler(object sender, spRRHH_Ficha_Det_FamiliarRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Estudio_RealizadoRowChangeEventHandler(object sender, spRRHH_Ficha_Estudio_RealizadoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Estudio_TituloRowChangeEventHandler(object sender, spRRHH_Ficha_Estudio_TituloRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Estudio_CapacitacionRowChangeEventHandler(object sender, spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Report_CuadroPerRowChangeEventHandler(object sender, spRRHH_Report_CuadroPerRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Report_OficinaRowChangeEventHandler(object sender, spRRHH_Report_OficinaRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Report_CumpleRowChangeEventHandler(object sender, spRRHH_Report_CumpleRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Rep_cargosRowChangeEventHandler(object sender, spRRHH_Rep_cargosRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Ingreso_EgresoRowChangeEventHandler(object sender, spRRHH_Ficha_Ingreso_EgresoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_DatosPersonalesRowChangeEventHandler(object sender, spRRHH_Ficha_DatosPersonalesRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_Det_Familiar_SaludRowChangeEventHandler(object sender, spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Ficha_ViviendaRowChangeEventHandler(object sender, spRRHH_Ficha_ViviendaRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_FaltasRowChangeEventHandler(object sender, spRRHH_FaltasRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_RepPermisosRowChangeEventHandler(object sender, spRRHH_RepPermisosRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_RepAsisdiarriaRowChangeEventHandler(object sender, spRRHH_RepAsisdiarriaRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Report_FechaIngresoRowChangeEventHandler(object sender, spRRHH_Report_FechaIngresoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_Rep_profesionRowChangeEventHandler(object sender, spRRHH_Rep_profesionRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void spRRHH_busca_DisciplinaRowChangeEventHandler(object sender, spRRHH_busca_DisciplinaRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_ExpLabDataTable : TypedTableBase<spRRHH_Ficha_ExpLabRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnNomInstitucion;

		private DataColumn columnCargoExp;

		private DataColumn columnFechaIngresoExp;

		private DataColumn columnFEchaEgresoExp;

		private DataColumn columnUnidadOrgaExp;

		private DataColumn columnDescriptipoInstitucion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NomInstitucionColumn => columnNomInstitucion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CargoExpColumn => columnCargoExp;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaIngresoExpColumn => columnFechaIngresoExp;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FEchaEgresoExpColumn => columnFEchaEgresoExp;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn UnidadOrgaExpColumn => columnUnidadOrgaExp;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescriptipoInstitucionColumn => columnDescriptipoInstitucion;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLabRow this[int index] => (spRRHH_Ficha_ExpLabRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLabRowChangeEventHandler spRRHH_Ficha_ExpLabRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLabRowChangeEventHandler spRRHH_Ficha_ExpLabRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLabRowChangeEventHandler spRRHH_Ficha_ExpLabRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLabRowChangeEventHandler spRRHH_Ficha_ExpLabRowDeleted;

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
		public spRRHH_Ficha_ExpLabDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_ExpLab";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_ExpLabDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_ExpLabDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_ExpLabRow(spRRHH_Ficha_ExpLabRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLabRow AddspRRHH_Ficha_ExpLabRow(string NomInstitucion, string CargoExp, DateTime FechaIngresoExp, DateTime FEchaEgresoExp, string UnidadOrgaExp, string DescriptipoInstitucion)
		{
			spRRHH_Ficha_ExpLabRow spRRHH_Ficha_ExpLabRow = (spRRHH_Ficha_ExpLabRow)NewRow();
			object[] itemArray = new object[6] { NomInstitucion, CargoExp, FechaIngresoExp, FEchaEgresoExp, UnidadOrgaExp, DescriptipoInstitucion };
			spRRHH_Ficha_ExpLabRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_ExpLabRow);
			return spRRHH_Ficha_ExpLabRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_ExpLabDataTable spRRHH_Ficha_ExpLabDataTable = (spRRHH_Ficha_ExpLabDataTable)base.Clone();
			spRRHH_Ficha_ExpLabDataTable.InitVars();
			return spRRHH_Ficha_ExpLabDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_ExpLabDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnNomInstitucion = base.Columns["NomInstitucion"];
			columnCargoExp = base.Columns["CargoExp"];
			columnFechaIngresoExp = base.Columns["FechaIngresoExp"];
			columnFEchaEgresoExp = base.Columns["FEchaEgresoExp"];
			columnUnidadOrgaExp = base.Columns["UnidadOrgaExp"];
			columnDescriptipoInstitucion = base.Columns["DescriptipoInstitucion"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnNomInstitucion = new DataColumn("NomInstitucion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNomInstitucion);
			columnCargoExp = new DataColumn("CargoExp", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCargoExp);
			columnFechaIngresoExp = new DataColumn("FechaIngresoExp", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaIngresoExp);
			columnFEchaEgresoExp = new DataColumn("FEchaEgresoExp", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFEchaEgresoExp);
			columnUnidadOrgaExp = new DataColumn("UnidadOrgaExp", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUnidadOrgaExp);
			columnDescriptipoInstitucion = new DataColumn("DescriptipoInstitucion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescriptipoInstitucion);
			columnNomInstitucion.MaxLength = 120;
			columnCargoExp.MaxLength = 40;
			columnUnidadOrgaExp.MaxLength = 100;
			columnDescriptipoInstitucion.MaxLength = 15;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_ExpLabRow NewspRRHH_Ficha_ExpLabRow()
		{
			return (spRRHH_Ficha_ExpLabRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_ExpLabRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_ExpLabRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_ExpLabRowChanged != null)
			{
				spRRHH_Ficha_ExpLabRowChanged?.Invoke(this, new spRRHH_Ficha_ExpLabRowChangeEvent((spRRHH_Ficha_ExpLabRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_ExpLabRowChanging != null)
			{
				spRRHH_Ficha_ExpLabRowChanging?.Invoke(this, new spRRHH_Ficha_ExpLabRowChangeEvent((spRRHH_Ficha_ExpLabRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_ExpLabRowDeleted != null)
			{
				spRRHH_Ficha_ExpLabRowDeleted?.Invoke(this, new spRRHH_Ficha_ExpLabRowChangeEvent((spRRHH_Ficha_ExpLabRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_ExpLabRowDeleting != null)
			{
				spRRHH_Ficha_ExpLabRowDeleting?.Invoke(this, new spRRHH_Ficha_ExpLabRowChangeEvent((spRRHH_Ficha_ExpLabRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Ficha_ExpLabRow(spRRHH_Ficha_ExpLabRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_ExpLabDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_ExpLab_DatosDataTable : TypedTableBase<spRRHH_Ficha_ExpLab_DatosRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnAreaOrganizacional;

		private DataColumn columnCondicionLab;

		private DataColumn columnFechaingreso;

		private DataColumn columnFechaIngreEstado;

		private DataColumn columnNumResoIngreEsta;

		private DataColumn columnNumResoIngreInstitu;

		private DataColumn columnNumResolCese;

		private DataColumn columnFechaResolCese;

		private DataColumn columnNumResol20530;

		private DataColumn columnFechaResol20530;

		private DataColumn columnNumResolPenMen;

		private DataColumn columnFechaResolPenMen;

		private DataColumn columnNumAutogenSalud;

		private DataColumn columnLeyRegimen;

		private DataColumn columnprofesion;

		private DataColumn columncargo;

		private DataColumn columnDescripAFP;

		private DataColumn columnFechaAFP;

		private DataColumn columnNroAFP;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CondicionLabColumn => columnCondicionLab;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaingresoColumn => columnFechaingreso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaIngreEstadoColumn => columnFechaIngreEstado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumResoIngreEstaColumn => columnNumResoIngreEsta;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumResoIngreInstituColumn => columnNumResoIngreInstitu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumResolCeseColumn => columnNumResolCese;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaResolCeseColumn => columnFechaResolCese;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumResol20530Column => columnNumResol20530;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaResol20530Column => columnFechaResol20530;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumResolPenMenColumn => columnNumResolPenMen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaResolPenMenColumn => columnFechaResolPenMen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumAutogenSaludColumn => columnNumAutogenSalud;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LeyRegimenColumn => columnLeyRegimen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn profesionColumn => columnprofesion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn cargoColumn => columncargo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripAFPColumn => columnDescripAFP;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaAFPColumn => columnFechaAFP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NroAFPColumn => columnNroAFP;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLab_DatosRow this[int index] => (spRRHH_Ficha_ExpLab_DatosRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLab_DatosRowChangeEventHandler spRRHH_Ficha_ExpLab_DatosRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLab_DatosRowChangeEventHandler spRRHH_Ficha_ExpLab_DatosRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLab_DatosRowChangeEventHandler spRRHH_Ficha_ExpLab_DatosRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ExpLab_DatosRowChangeEventHandler spRRHH_Ficha_ExpLab_DatosRowDeleted;

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
		public spRRHH_Ficha_ExpLab_DatosDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_ExpLab_Datos";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_ExpLab_DatosDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Ficha_ExpLab_DatosDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_ExpLab_DatosRow(spRRHH_Ficha_ExpLab_DatosRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLab_DatosRow AddspRRHH_Ficha_ExpLab_DatosRow(string AreaOrganizacional, string CondicionLab, DateTime Fechaingreso, DateTime FechaIngreEstado, string NumResoIngreEsta, string NumResoIngreInstitu, string NumResolCese, DateTime FechaResolCese, string NumResol20530, DateTime FechaResol20530, string NumResolPenMen, DateTime FechaResolPenMen, string NumAutogenSalud, string LeyRegimen, string profesion, string cargo, string DescripAFP, DateTime FechaAFP, string NroAFP)
		{
			spRRHH_Ficha_ExpLab_DatosRow spRRHH_Ficha_ExpLab_DatosRow = (spRRHH_Ficha_ExpLab_DatosRow)NewRow();
			object[] itemArray = new object[19]
			{
				AreaOrganizacional, CondicionLab, Fechaingreso, FechaIngreEstado, NumResoIngreEsta, NumResoIngreInstitu, NumResolCese, FechaResolCese, NumResol20530, FechaResol20530,
				NumResolPenMen, FechaResolPenMen, NumAutogenSalud, LeyRegimen, profesion, cargo, DescripAFP, FechaAFP, NroAFP
			};
			spRRHH_Ficha_ExpLab_DatosRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_ExpLab_DatosRow);
			return spRRHH_Ficha_ExpLab_DatosRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Ficha_ExpLab_DatosDataTable spRRHH_Ficha_ExpLab_DatosDataTable = (spRRHH_Ficha_ExpLab_DatosDataTable)base.Clone();
			spRRHH_Ficha_ExpLab_DatosDataTable.InitVars();
			return spRRHH_Ficha_ExpLab_DatosDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_ExpLab_DatosDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columnCondicionLab = base.Columns["CondicionLab"];
			columnFechaingreso = base.Columns["Fechaingreso"];
			columnFechaIngreEstado = base.Columns["FechaIngreEstado"];
			columnNumResoIngreEsta = base.Columns["NumResoIngreEsta"];
			columnNumResoIngreInstitu = base.Columns["NumResoIngreInstitu"];
			columnNumResolCese = base.Columns["NumResolCese"];
			columnFechaResolCese = base.Columns["FechaResolCese"];
			columnNumResol20530 = base.Columns["NumResol20530"];
			columnFechaResol20530 = base.Columns["FechaResol20530"];
			columnNumResolPenMen = base.Columns["NumResolPenMen"];
			columnFechaResolPenMen = base.Columns["FechaResolPenMen"];
			columnNumAutogenSalud = base.Columns["NumAutogenSalud"];
			columnLeyRegimen = base.Columns["LeyRegimen"];
			columnprofesion = base.Columns["profesion"];
			columncargo = base.Columns["cargo"];
			columnDescripAFP = base.Columns["DescripAFP"];
			columnFechaAFP = base.Columns["FechaAFP"];
			columnNroAFP = base.Columns["NroAFP"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnCondicionLab = new DataColumn("CondicionLab", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCondicionLab);
			columnFechaingreso = new DataColumn("Fechaingreso", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaingreso);
			columnFechaIngreEstado = new DataColumn("FechaIngreEstado", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaIngreEstado);
			columnNumResoIngreEsta = new DataColumn("NumResoIngreEsta", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResoIngreEsta);
			columnNumResoIngreInstitu = new DataColumn("NumResoIngreInstitu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResoIngreInstitu);
			columnNumResolCese = new DataColumn("NumResolCese", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResolCese);
			columnFechaResolCese = new DataColumn("FechaResolCese", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaResolCese);
			columnNumResol20530 = new DataColumn("NumResol20530", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResol20530);
			columnFechaResol20530 = new DataColumn("FechaResol20530", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaResol20530);
			columnNumResolPenMen = new DataColumn("NumResolPenMen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResolPenMen);
			columnFechaResolPenMen = new DataColumn("FechaResolPenMen", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaResolPenMen);
			columnNumAutogenSalud = new DataColumn("NumAutogenSalud", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumAutogenSalud);
			columnLeyRegimen = new DataColumn("LeyRegimen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLeyRegimen);
			columnprofesion = new DataColumn("profesion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprofesion);
			columncargo = new DataColumn("cargo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncargo);
			columnDescripAFP = new DataColumn("DescripAFP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripAFP);
			columnFechaAFP = new DataColumn("FechaAFP", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaAFP);
			columnNroAFP = new DataColumn("NroAFP", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNroAFP);
			columnAreaOrganizacional.MaxLength = 200;
			columnCondicionLab.MaxLength = 30;
			columnNumResoIngreEsta.MaxLength = 20;
			columnNumResoIngreInstitu.MaxLength = 20;
			columnNumResolCese.MaxLength = 20;
			columnNumResol20530.MaxLength = 20;
			columnNumResolPenMen.MaxLength = 20;
			columnNumAutogenSalud.MaxLength = 15;
			columnLeyRegimen.MaxLength = 5;
			columnprofesion.MaxLength = 80;
			columncargo.MaxLength = 50;
			columnDescripAFP.MaxLength = 50;
			columnNroAFP.MaxLength = 20;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_ExpLab_DatosRow NewspRRHH_Ficha_ExpLab_DatosRow()
		{
			return (spRRHH_Ficha_ExpLab_DatosRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_ExpLab_DatosRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_ExpLab_DatosRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_ExpLab_DatosRowChanged != null)
			{
				spRRHH_Ficha_ExpLab_DatosRowChanged?.Invoke(this, new spRRHH_Ficha_ExpLab_DatosRowChangeEvent((spRRHH_Ficha_ExpLab_DatosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_ExpLab_DatosRowChanging != null)
			{
				spRRHH_Ficha_ExpLab_DatosRowChanging?.Invoke(this, new spRRHH_Ficha_ExpLab_DatosRowChangeEvent((spRRHH_Ficha_ExpLab_DatosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_ExpLab_DatosRowDeleted != null)
			{
				spRRHH_Ficha_ExpLab_DatosRowDeleted?.Invoke(this, new spRRHH_Ficha_ExpLab_DatosRowChangeEvent((spRRHH_Ficha_ExpLab_DatosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_ExpLab_DatosRowDeleting != null)
			{
				spRRHH_Ficha_ExpLab_DatosRowDeleting?.Invoke(this, new spRRHH_Ficha_ExpLab_DatosRowChangeEvent((spRRHH_Ficha_ExpLab_DatosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Ficha_ExpLab_DatosRow(spRRHH_Ficha_ExpLab_DatosRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_ExpLab_DatosDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Det_FamiliarDataTable : TypedTableBase<spRRHH_Ficha_Det_FamiliarRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnedadFamiliar;

		private DataColumn columnNombresFamilia;

		private DataColumn columnFamSexo;

		private DataColumn columnDescripTipoFam;

		private DataColumn columnFamGradoInstruc;

		private DataColumn columnDescripEstCivil;

		private DataColumn columnViveCasa;

		private DataColumn columnLaboraInstitucion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn edadFamiliarColumn => columnedadFamiliar;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NombresFamiliaColumn => columnNombresFamilia;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FamSexoColumn => columnFamSexo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripTipoFamColumn => columnDescripTipoFam;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FamGradoInstrucColumn => columnFamGradoInstruc;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripEstCivilColumn => columnDescripEstCivil;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ViveCasaColumn => columnViveCasa;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LaboraInstitucionColumn => columnLaboraInstitucion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Det_FamiliarRow this[int index] => (spRRHH_Ficha_Det_FamiliarRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_FamiliarRowChangeEventHandler spRRHH_Ficha_Det_FamiliarRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_FamiliarRowChangeEventHandler spRRHH_Ficha_Det_FamiliarRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_FamiliarRowChangeEventHandler spRRHH_Ficha_Det_FamiliarRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_FamiliarRowChangeEventHandler spRRHH_Ficha_Det_FamiliarRowDeleted;

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
		public spRRHH_Ficha_Det_FamiliarDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Det_Familiar";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Det_FamiliarDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_Det_FamiliarDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Ficha_Det_FamiliarRow(spRRHH_Ficha_Det_FamiliarRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_FamiliarRow AddspRRHH_Ficha_Det_FamiliarRow(int edadFamiliar, string NombresFamilia, string FamSexo, string DescripTipoFam, string FamGradoInstruc, string DescripEstCivil, bool ViveCasa, bool LaboraInstitucion)
		{
			spRRHH_Ficha_Det_FamiliarRow spRRHH_Ficha_Det_FamiliarRow = (spRRHH_Ficha_Det_FamiliarRow)NewRow();
			object[] itemArray = new object[8] { edadFamiliar, NombresFamilia, FamSexo, DescripTipoFam, FamGradoInstruc, DescripEstCivil, ViveCasa, LaboraInstitucion };
			spRRHH_Ficha_Det_FamiliarRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Det_FamiliarRow);
			return spRRHH_Ficha_Det_FamiliarRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Det_FamiliarDataTable spRRHH_Ficha_Det_FamiliarDataTable = (spRRHH_Ficha_Det_FamiliarDataTable)base.Clone();
			spRRHH_Ficha_Det_FamiliarDataTable.InitVars();
			return spRRHH_Ficha_Det_FamiliarDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Det_FamiliarDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnedadFamiliar = base.Columns["edadFamiliar"];
			columnNombresFamilia = base.Columns["NombresFamilia"];
			columnFamSexo = base.Columns["FamSexo"];
			columnDescripTipoFam = base.Columns["DescripTipoFam"];
			columnFamGradoInstruc = base.Columns["FamGradoInstruc"];
			columnDescripEstCivil = base.Columns["DescripEstCivil"];
			columnViveCasa = base.Columns["ViveCasa"];
			columnLaboraInstitucion = base.Columns["LaboraInstitucion"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnedadFamiliar = new DataColumn("edadFamiliar", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnedadFamiliar);
			columnNombresFamilia = new DataColumn("NombresFamilia", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombresFamilia);
			columnFamSexo = new DataColumn("FamSexo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFamSexo);
			columnDescripTipoFam = new DataColumn("DescripTipoFam", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTipoFam);
			columnFamGradoInstruc = new DataColumn("FamGradoInstruc", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFamGradoInstruc);
			columnDescripEstCivil = new DataColumn("DescripEstCivil", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripEstCivil);
			columnViveCasa = new DataColumn("ViveCasa", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnViveCasa);
			columnLaboraInstitucion = new DataColumn("LaboraInstitucion", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnLaboraInstitucion);
			columnedadFamiliar.ReadOnly = true;
			columnNombresFamilia.ReadOnly = true;
			columnNombresFamilia.MaxLength = 162;
			columnFamSexo.MaxLength = 1;
			columnDescripTipoFam.MaxLength = 10;
			columnFamGradoInstruc.MaxLength = 15;
			columnDescripEstCivil.MaxLength = 11;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_FamiliarRow NewspRRHH_Ficha_Det_FamiliarRow()
		{
			return (spRRHH_Ficha_Det_FamiliarRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Det_FamiliarRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Det_FamiliarRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Det_FamiliarRowChanged != null)
			{
				spRRHH_Ficha_Det_FamiliarRowChanged?.Invoke(this, new spRRHH_Ficha_Det_FamiliarRowChangeEvent((spRRHH_Ficha_Det_FamiliarRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Det_FamiliarRowChanging != null)
			{
				spRRHH_Ficha_Det_FamiliarRowChanging?.Invoke(this, new spRRHH_Ficha_Det_FamiliarRowChangeEvent((spRRHH_Ficha_Det_FamiliarRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Det_FamiliarRowDeleted != null)
			{
				spRRHH_Ficha_Det_FamiliarRowDeleted?.Invoke(this, new spRRHH_Ficha_Det_FamiliarRowChangeEvent((spRRHH_Ficha_Det_FamiliarRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Det_FamiliarRowDeleting != null)
			{
				spRRHH_Ficha_Det_FamiliarRowDeleting?.Invoke(this, new spRRHH_Ficha_Det_FamiliarRowChangeEvent((spRRHH_Ficha_Det_FamiliarRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Ficha_Det_FamiliarRow(spRRHH_Ficha_Det_FamiliarRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Det_FamiliarDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Estudio_RealizadoDataTable : TypedTableBase<spRRHH_Ficha_Estudio_RealizadoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDescripTipoEst;

		private DataColumn columnCentroEstudios;

		private DataColumn columnAñoInicio;

		private DataColumn columnAñotermino;

		private DataColumn columnDescripEstadoEstudio;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripTipoEstColumn => columnDescripTipoEst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CentroEstudiosColumn => columnCentroEstudios;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AñoInicioColumn => columnAñoInicio;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AñoterminoColumn => columnAñotermino;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripEstadoEstudioColumn => columnDescripEstadoEstudio;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_RealizadoRow this[int index] => (spRRHH_Ficha_Estudio_RealizadoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_RealizadoRowChangeEventHandler spRRHH_Ficha_Estudio_RealizadoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_RealizadoRowChangeEventHandler spRRHH_Ficha_Estudio_RealizadoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_RealizadoRowChangeEventHandler spRRHH_Ficha_Estudio_RealizadoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_RealizadoRowChangeEventHandler spRRHH_Ficha_Estudio_RealizadoRowDeleted;

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
		public spRRHH_Ficha_Estudio_RealizadoDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Estudio_Realizado";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Estudio_RealizadoDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_Estudio_RealizadoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_Estudio_RealizadoRow(spRRHH_Ficha_Estudio_RealizadoRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_RealizadoRow AddspRRHH_Ficha_Estudio_RealizadoRow(string DescripTipoEst, string CentroEstudios, DateTime AñoInicio, DateTime Añotermino, string DescripEstadoEstudio)
		{
			spRRHH_Ficha_Estudio_RealizadoRow spRRHH_Ficha_Estudio_RealizadoRow = (spRRHH_Ficha_Estudio_RealizadoRow)NewRow();
			object[] itemArray = new object[5] { DescripTipoEst, CentroEstudios, AñoInicio, Añotermino, DescripEstadoEstudio };
			spRRHH_Ficha_Estudio_RealizadoRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Estudio_RealizadoRow);
			return spRRHH_Ficha_Estudio_RealizadoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Estudio_RealizadoDataTable spRRHH_Ficha_Estudio_RealizadoDataTable = (spRRHH_Ficha_Estudio_RealizadoDataTable)base.Clone();
			spRRHH_Ficha_Estudio_RealizadoDataTable.InitVars();
			return spRRHH_Ficha_Estudio_RealizadoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Estudio_RealizadoDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnDescripTipoEst = base.Columns["DescripTipoEst"];
			columnCentroEstudios = base.Columns["CentroEstudios"];
			columnAñoInicio = base.Columns["AñoInicio"];
			columnAñotermino = base.Columns["Añotermino"];
			columnDescripEstadoEstudio = base.Columns["DescripEstadoEstudio"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnDescripTipoEst = new DataColumn("DescripTipoEst", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTipoEst);
			columnCentroEstudios = new DataColumn("CentroEstudios", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCentroEstudios);
			columnAñoInicio = new DataColumn("AñoInicio", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnAñoInicio);
			columnAñotermino = new DataColumn("Añotermino", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnAñotermino);
			columnDescripEstadoEstudio = new DataColumn("DescripEstadoEstudio", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripEstadoEstudio);
			columnDescripTipoEst.MaxLength = 15;
			columnCentroEstudios.MaxLength = 50;
			columnDescripEstadoEstudio.MaxLength = 10;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_RealizadoRow NewspRRHH_Ficha_Estudio_RealizadoRow()
		{
			return (spRRHH_Ficha_Estudio_RealizadoRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Estudio_RealizadoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Estudio_RealizadoRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Estudio_RealizadoRowChanged != null)
			{
				spRRHH_Ficha_Estudio_RealizadoRowChanged?.Invoke(this, new spRRHH_Ficha_Estudio_RealizadoRowChangeEvent((spRRHH_Ficha_Estudio_RealizadoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Estudio_RealizadoRowChanging != null)
			{
				spRRHH_Ficha_Estudio_RealizadoRowChanging?.Invoke(this, new spRRHH_Ficha_Estudio_RealizadoRowChangeEvent((spRRHH_Ficha_Estudio_RealizadoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Estudio_RealizadoRowDeleted != null)
			{
				spRRHH_Ficha_Estudio_RealizadoRowDeleted?.Invoke(this, new spRRHH_Ficha_Estudio_RealizadoRowChangeEvent((spRRHH_Ficha_Estudio_RealizadoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Estudio_RealizadoRowDeleting != null)
			{
				spRRHH_Ficha_Estudio_RealizadoRowDeleting?.Invoke(this, new spRRHH_Ficha_Estudio_RealizadoRowChangeEvent((spRRHH_Ficha_Estudio_RealizadoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Ficha_Estudio_RealizadoRow(spRRHH_Ficha_Estudio_RealizadoRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Estudio_RealizadoDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Estudio_TituloDataTable : TypedTableBase<spRRHH_Ficha_Estudio_TituloRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnNumColegiatura;

		private DataColumn columnDenominacionGrado;

		private DataColumn columnInstitucion;

		private DataColumn columnFecha;

		private DataColumn columnIdEmpleado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumColegiaturaColumn => columnNumColegiatura;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DenominacionGradoColumn => columnDenominacionGrado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn InstitucionColumn => columnInstitucion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaColumn => columnFecha;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IdEmpleadoColumn => columnIdEmpleado;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_TituloRow this[int index] => (spRRHH_Ficha_Estudio_TituloRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_TituloRowChangeEventHandler spRRHH_Ficha_Estudio_TituloRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_TituloRowChangeEventHandler spRRHH_Ficha_Estudio_TituloRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_TituloRowChangeEventHandler spRRHH_Ficha_Estudio_TituloRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_TituloRowChangeEventHandler spRRHH_Ficha_Estudio_TituloRowDeleted;

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
		public spRRHH_Ficha_Estudio_TituloDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Estudio_Titulo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Estudio_TituloDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Ficha_Estudio_TituloDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Ficha_Estudio_TituloRow(spRRHH_Ficha_Estudio_TituloRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_TituloRow AddspRRHH_Ficha_Estudio_TituloRow(string NumColegiatura, string DenominacionGrado, string Institucion, DateTime Fecha, int IdEmpleado)
		{
			spRRHH_Ficha_Estudio_TituloRow spRRHH_Ficha_Estudio_TituloRow = (spRRHH_Ficha_Estudio_TituloRow)NewRow();
			object[] itemArray = new object[5] { NumColegiatura, DenominacionGrado, Institucion, Fecha, IdEmpleado };
			spRRHH_Ficha_Estudio_TituloRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Estudio_TituloRow);
			return spRRHH_Ficha_Estudio_TituloRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_TituloRow FindByNumColegiatura(string NumColegiatura)
		{
			return (spRRHH_Ficha_Estudio_TituloRow)Rows.Find(new object[1] { NumColegiatura });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Estudio_TituloDataTable spRRHH_Ficha_Estudio_TituloDataTable = (spRRHH_Ficha_Estudio_TituloDataTable)base.Clone();
			spRRHH_Ficha_Estudio_TituloDataTable.InitVars();
			return spRRHH_Ficha_Estudio_TituloDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Estudio_TituloDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnNumColegiatura = base.Columns["NumColegiatura"];
			columnDenominacionGrado = base.Columns["DenominacionGrado"];
			columnInstitucion = base.Columns["Institucion"];
			columnFecha = base.Columns["Fecha"];
			columnIdEmpleado = base.Columns["IdEmpleado"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnNumColegiatura = new DataColumn("NumColegiatura", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumColegiatura);
			columnDenominacionGrado = new DataColumn("DenominacionGrado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDenominacionGrado);
			columnInstitucion = new DataColumn("Institucion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnInstitucion);
			columnFecha = new DataColumn("Fecha", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFecha);
			columnIdEmpleado = new DataColumn("IdEmpleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIdEmpleado);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnNumColegiatura }, isPrimaryKey: true));
			columnNumColegiatura.AllowDBNull = false;
			columnNumColegiatura.Unique = true;
			columnNumColegiatura.MaxLength = 20;
			columnDenominacionGrado.MaxLength = 100;
			columnInstitucion.MaxLength = 60;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_TituloRow NewspRRHH_Ficha_Estudio_TituloRow()
		{
			return (spRRHH_Ficha_Estudio_TituloRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Estudio_TituloRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Estudio_TituloRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Estudio_TituloRowChanged != null)
			{
				spRRHH_Ficha_Estudio_TituloRowChanged?.Invoke(this, new spRRHH_Ficha_Estudio_TituloRowChangeEvent((spRRHH_Ficha_Estudio_TituloRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Estudio_TituloRowChanging != null)
			{
				spRRHH_Ficha_Estudio_TituloRowChanging?.Invoke(this, new spRRHH_Ficha_Estudio_TituloRowChangeEvent((spRRHH_Ficha_Estudio_TituloRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Estudio_TituloRowDeleted != null)
			{
				spRRHH_Ficha_Estudio_TituloRowDeleted?.Invoke(this, new spRRHH_Ficha_Estudio_TituloRowChangeEvent((spRRHH_Ficha_Estudio_TituloRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Estudio_TituloRowDeleting != null)
			{
				spRRHH_Ficha_Estudio_TituloRowDeleting?.Invoke(this, new spRRHH_Ficha_Estudio_TituloRowChangeEvent((spRRHH_Ficha_Estudio_TituloRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Ficha_Estudio_TituloRow(spRRHH_Ficha_Estudio_TituloRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Estudio_TituloDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Estudio_CapacitacionDataTable : TypedTableBase<spRRHH_Ficha_Estudio_CapacitacionRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnIdCapacitacion;

		private DataColumn columnNombreCurso;

		private DataColumn columnFechaInicio;

		private DataColumn columnFechaFin;

		private DataColumn columnNumHoras;

		private DataColumn columnInstitucionOrganizadora;

		private DataColumn columnIdEmpleado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IdCapacitacionColumn => columnIdCapacitacion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NombreCursoColumn => columnNombreCurso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaInicioColumn => columnFechaInicio;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaFinColumn => columnFechaFin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumHorasColumn => columnNumHoras;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn InstitucionOrganizadoraColumn => columnInstitucionOrganizadora;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IdEmpleadoColumn => columnIdEmpleado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRow this[int index] => (spRRHH_Ficha_Estudio_CapacitacionRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_CapacitacionRowChangeEventHandler spRRHH_Ficha_Estudio_CapacitacionRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_CapacitacionRowChangeEventHandler spRRHH_Ficha_Estudio_CapacitacionRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_CapacitacionRowChangeEventHandler spRRHH_Ficha_Estudio_CapacitacionRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Estudio_CapacitacionRowChangeEventHandler spRRHH_Ficha_Estudio_CapacitacionRowDeleted;

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
		public spRRHH_Ficha_Estudio_CapacitacionDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Estudio_Capacitacion";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Estudio_CapacitacionDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Ficha_Estudio_CapacitacionDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_Estudio_CapacitacionRow(spRRHH_Ficha_Estudio_CapacitacionRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRow AddspRRHH_Ficha_Estudio_CapacitacionRow(int IdCapacitacion, string NombreCurso, DateTime FechaInicio, DateTime FechaFin, string NumHoras, string InstitucionOrganizadora, int IdEmpleado)
		{
			spRRHH_Ficha_Estudio_CapacitacionRow spRRHH_Ficha_Estudio_CapacitacionRow = (spRRHH_Ficha_Estudio_CapacitacionRow)NewRow();
			object[] itemArray = new object[7] { IdCapacitacion, NombreCurso, FechaInicio, FechaFin, NumHoras, InstitucionOrganizadora, IdEmpleado };
			spRRHH_Ficha_Estudio_CapacitacionRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Estudio_CapacitacionRow);
			return spRRHH_Ficha_Estudio_CapacitacionRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRow FindByIdCapacitacion(int IdCapacitacion)
		{
			return (spRRHH_Ficha_Estudio_CapacitacionRow)Rows.Find(new object[1] { IdCapacitacion });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Estudio_CapacitacionDataTable spRRHH_Ficha_Estudio_CapacitacionDataTable = (spRRHH_Ficha_Estudio_CapacitacionDataTable)base.Clone();
			spRRHH_Ficha_Estudio_CapacitacionDataTable.InitVars();
			return spRRHH_Ficha_Estudio_CapacitacionDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Estudio_CapacitacionDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnIdCapacitacion = base.Columns["IdCapacitacion"];
			columnNombreCurso = base.Columns["NombreCurso"];
			columnFechaInicio = base.Columns["FechaInicio"];
			columnFechaFin = base.Columns["FechaFin"];
			columnNumHoras = base.Columns["NumHoras"];
			columnInstitucionOrganizadora = base.Columns["InstitucionOrganizadora"];
			columnIdEmpleado = base.Columns["IdEmpleado"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnIdCapacitacion = new DataColumn("IdCapacitacion", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIdCapacitacion);
			columnNombreCurso = new DataColumn("NombreCurso", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombreCurso);
			columnFechaInicio = new DataColumn("FechaInicio", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaInicio);
			columnFechaFin = new DataColumn("FechaFin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaFin);
			columnNumHoras = new DataColumn("NumHoras", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumHoras);
			columnInstitucionOrganizadora = new DataColumn("InstitucionOrganizadora", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnInstitucionOrganizadora);
			columnIdEmpleado = new DataColumn("IdEmpleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIdEmpleado);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnIdCapacitacion }, isPrimaryKey: true));
			columnIdCapacitacion.AllowDBNull = false;
			columnIdCapacitacion.Unique = true;
			columnNombreCurso.MaxLength = 200;
			columnNumHoras.MaxLength = 2;
			columnInstitucionOrganizadora.MaxLength = 200;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRow NewspRRHH_Ficha_Estudio_CapacitacionRow()
		{
			return (spRRHH_Ficha_Estudio_CapacitacionRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Estudio_CapacitacionRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Estudio_CapacitacionRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Estudio_CapacitacionRowChanged != null)
			{
				spRRHH_Ficha_Estudio_CapacitacionRowChanged?.Invoke(this, new spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent((spRRHH_Ficha_Estudio_CapacitacionRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Estudio_CapacitacionRowChanging != null)
			{
				spRRHH_Ficha_Estudio_CapacitacionRowChanging?.Invoke(this, new spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent((spRRHH_Ficha_Estudio_CapacitacionRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Estudio_CapacitacionRowDeleted != null)
			{
				spRRHH_Ficha_Estudio_CapacitacionRowDeleted?.Invoke(this, new spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent((spRRHH_Ficha_Estudio_CapacitacionRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Estudio_CapacitacionRowDeleting != null)
			{
				spRRHH_Ficha_Estudio_CapacitacionRowDeleting?.Invoke(this, new spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent((spRRHH_Ficha_Estudio_CapacitacionRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Ficha_Estudio_CapacitacionRow(spRRHH_Ficha_Estudio_CapacitacionRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Estudio_CapacitacionDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Report_CuadroPerDataTable : TypedTableBase<spRRHH_Report_CuadroPerRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnidTipoTrabajador;

		private DataColumn columnDescripcion;

		private DataColumn columnCodigo;

		private DataColumn columnDNI;

		private DataColumn columnNombresCompletos;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columncargo;

		private DataColumn columnEstado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idTipoTrabajadorColumn => columnidTipoTrabajador;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripcionColumn => columnDescripcion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CodigoColumn => columnCodigo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DNIColumn => columnDNI;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NombresCompletosColumn => columnNombresCompletos;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn cargoColumn => columncargo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn EstadoColumn => columnEstado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_CuadroPerRow this[int index] => (spRRHH_Report_CuadroPerRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CuadroPerRowChangeEventHandler spRRHH_Report_CuadroPerRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CuadroPerRowChangeEventHandler spRRHH_Report_CuadroPerRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CuadroPerRowChangeEventHandler spRRHH_Report_CuadroPerRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CuadroPerRowChangeEventHandler spRRHH_Report_CuadroPerRowDeleted;

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
		public spRRHH_Report_CuadroPerDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Report_CuadroPer";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_CuadroPerDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Report_CuadroPerDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Report_CuadroPerRow(spRRHH_Report_CuadroPerRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_CuadroPerRow AddspRRHH_Report_CuadroPerRow(int idTipoTrabajador, string Descripcion, int Codigo, string DNI, string NombresCompletos, string AreaOrganizacional, int cargo, string Estado)
		{
			spRRHH_Report_CuadroPerRow spRRHH_Report_CuadroPerRow = (spRRHH_Report_CuadroPerRow)NewRow();
			object[] itemArray = new object[8] { idTipoTrabajador, Descripcion, Codigo, DNI, NombresCompletos, AreaOrganizacional, cargo, Estado };
			spRRHH_Report_CuadroPerRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Report_CuadroPerRow);
			return spRRHH_Report_CuadroPerRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Report_CuadroPerDataTable spRRHH_Report_CuadroPerDataTable = (spRRHH_Report_CuadroPerDataTable)base.Clone();
			spRRHH_Report_CuadroPerDataTable.InitVars();
			return spRRHH_Report_CuadroPerDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Report_CuadroPerDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnidTipoTrabajador = base.Columns["idTipoTrabajador"];
			columnDescripcion = base.Columns["Descripcion"];
			columnCodigo = base.Columns["Codigo"];
			columnDNI = base.Columns["DNI"];
			columnNombresCompletos = base.Columns["NombresCompletos"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columncargo = base.Columns["cargo"];
			columnEstado = base.Columns["Estado"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnidTipoTrabajador = new DataColumn("idTipoTrabajador", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidTipoTrabajador);
			columnDescripcion = new DataColumn("Descripcion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripcion);
			columnCodigo = new DataColumn("Codigo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnCodigo);
			columnDNI = new DataColumn("DNI", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDNI);
			columnNombresCompletos = new DataColumn("NombresCompletos", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombresCompletos);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columncargo = new DataColumn("cargo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columncargo);
			columnEstado = new DataColumn("Estado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEstado);
			columnidTipoTrabajador.AllowDBNull = false;
			columnDescripcion.MaxLength = 30;
			columnCodigo.AllowDBNull = false;
			columnDNI.MaxLength = 12;
			columnNombresCompletos.ReadOnly = true;
			columnNombresCompletos.MaxLength = 162;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
			columnEstado.MaxLength = 1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_CuadroPerRow NewspRRHH_Report_CuadroPerRow()
		{
			return (spRRHH_Report_CuadroPerRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Report_CuadroPerRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Report_CuadroPerRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Report_CuadroPerRowChanged != null)
			{
				spRRHH_Report_CuadroPerRowChanged?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Report_CuadroPerRowChanging != null)
			{
				spRRHH_Report_CuadroPerRowChanging?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Report_CuadroPerRowDeleted != null)
			{
				spRRHH_Report_CuadroPerRowDeleted?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Report_CuadroPerRowDeleting != null)
			{
				spRRHH_Report_CuadroPerRowDeleting?.Invoke(this, new spRRHH_Report_CuadroPerRowChangeEvent((spRRHH_Report_CuadroPerRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Report_CuadroPerRow(spRRHH_Report_CuadroPerRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Report_CuadroPerDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Report_OficinaDataTable : TypedTableBase<spRRHH_Report_OficinaRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnidempleado;

		private DataColumn columnidpersona;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columnApellido_paterno;

		private DataColumn columnapellido_materno;

		private DataColumn columnnombres;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idempleadoColumn => columnidempleado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idpersonaColumn => columnidpersona;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Apellido_paternoColumn => columnApellido_paterno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn apellido_maternoColumn => columnapellido_materno;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn nombresColumn => columnnombres;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_OficinaRow this[int index] => (spRRHH_Report_OficinaRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_OficinaRowChangeEventHandler spRRHH_Report_OficinaRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_OficinaRowChangeEventHandler spRRHH_Report_OficinaRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_OficinaRowChangeEventHandler spRRHH_Report_OficinaRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_OficinaRowChangeEventHandler spRRHH_Report_OficinaRowDeleted;

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
		public spRRHH_Report_OficinaDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Report_Oficina";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Report_OficinaDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Report_OficinaDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Report_OficinaRow(spRRHH_Report_OficinaRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_OficinaRow AddspRRHH_Report_OficinaRow(int idempleado, int idpersona, string AreaOrganizacional, string Apellido_paterno, string apellido_materno, string nombres)
		{
			spRRHH_Report_OficinaRow spRRHH_Report_OficinaRow = (spRRHH_Report_OficinaRow)NewRow();
			object[] itemArray = new object[6] { idempleado, idpersona, AreaOrganizacional, Apellido_paterno, apellido_materno, nombres };
			spRRHH_Report_OficinaRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Report_OficinaRow);
			return spRRHH_Report_OficinaRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_OficinaRow FindByidempleado(int idempleado)
		{
			return (spRRHH_Report_OficinaRow)Rows.Find(new object[1] { idempleado });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Report_OficinaDataTable spRRHH_Report_OficinaDataTable = (spRRHH_Report_OficinaDataTable)base.Clone();
			spRRHH_Report_OficinaDataTable.InitVars();
			return spRRHH_Report_OficinaDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Report_OficinaDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnidempleado = base.Columns["idempleado"];
			columnidpersona = base.Columns["idpersona"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columnApellido_paterno = base.Columns["Apellido_paterno"];
			columnapellido_materno = base.Columns["apellido_materno"];
			columnnombres = base.Columns["nombres"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnidempleado = new DataColumn("idempleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidempleado);
			columnidpersona = new DataColumn("idpersona", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidpersona);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnApellido_paterno = new DataColumn("Apellido_paterno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_paterno);
			columnapellido_materno = new DataColumn("apellido_materno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnapellido_materno);
			columnnombres = new DataColumn("nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnombres);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnidempleado }, isPrimaryKey: true));
			columnidempleado.AllowDBNull = false;
			columnidempleado.Unique = true;
			columnAreaOrganizacional.MaxLength = 200;
			columnApellido_paterno.MaxLength = 30;
			columnapellido_materno.MaxLength = 30;
			columnnombres.MaxLength = 100;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_OficinaRow NewspRRHH_Report_OficinaRow()
		{
			return (spRRHH_Report_OficinaRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Report_OficinaRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Report_OficinaRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Report_OficinaRowChanged != null)
			{
				spRRHH_Report_OficinaRowChanged?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Report_OficinaRowChanging != null)
			{
				spRRHH_Report_OficinaRowChanging?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Report_OficinaRowDeleted != null)
			{
				spRRHH_Report_OficinaRowDeleted?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Report_OficinaRowDeleting != null)
			{
				spRRHH_Report_OficinaRowDeleting?.Invoke(this, new spRRHH_Report_OficinaRowChangeEvent((spRRHH_Report_OficinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Report_OficinaRow(spRRHH_Report_OficinaRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Report_OficinaDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Report_CumpleDataTable : TypedTableBase<spRRHH_Report_CumpleRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnedadEmpleado;

		private DataColumn columnNombresCompletos;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columnEstado;

		private DataColumn columnDia;

		private DataColumn columnmes;

		private DataColumn columnMESletras;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn edadEmpleadoColumn => columnedadEmpleado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NombresCompletosColumn => columnNombresCompletos;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn EstadoColumn => columnEstado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiaColumn => columnDia;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mesColumn => columnmes;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MESletrasColumn => columnMESletras;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_CumpleRow this[int index] => (spRRHH_Report_CumpleRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CumpleRowChangeEventHandler spRRHH_Report_CumpleRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CumpleRowChangeEventHandler spRRHH_Report_CumpleRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CumpleRowChangeEventHandler spRRHH_Report_CumpleRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_CumpleRowChangeEventHandler spRRHH_Report_CumpleRowDeleted;

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
		public spRRHH_Report_CumpleDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Report_Cumple";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_CumpleDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Report_CumpleDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Report_CumpleRow(spRRHH_Report_CumpleRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_CumpleRow AddspRRHH_Report_CumpleRow(int edadEmpleado, string NombresCompletos, string AreaOrganizacional, string Estado, int Dia, int mes, string MESletras)
		{
			spRRHH_Report_CumpleRow spRRHH_Report_CumpleRow = (spRRHH_Report_CumpleRow)NewRow();
			object[] itemArray = new object[7] { edadEmpleado, NombresCompletos, AreaOrganizacional, Estado, Dia, mes, MESletras };
			spRRHH_Report_CumpleRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Report_CumpleRow);
			return spRRHH_Report_CumpleRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Report_CumpleDataTable spRRHH_Report_CumpleDataTable = (spRRHH_Report_CumpleDataTable)base.Clone();
			spRRHH_Report_CumpleDataTable.InitVars();
			return spRRHH_Report_CumpleDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Report_CumpleDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnedadEmpleado = base.Columns["edadEmpleado"];
			columnNombresCompletos = base.Columns["NombresCompletos"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columnEstado = base.Columns["Estado"];
			columnDia = base.Columns["Dia"];
			columnmes = base.Columns["mes"];
			columnMESletras = base.Columns["MESletras"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnedadEmpleado = new DataColumn("edadEmpleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnedadEmpleado);
			columnNombresCompletos = new DataColumn("NombresCompletos", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombresCompletos);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnEstado = new DataColumn("Estado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEstado);
			columnDia = new DataColumn("Dia", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnDia);
			columnmes = new DataColumn("mes", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnmes);
			columnMESletras = new DataColumn("MESletras", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMESletras);
			columnedadEmpleado.ReadOnly = true;
			columnNombresCompletos.ReadOnly = true;
			columnNombresCompletos.MaxLength = 162;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
			columnEstado.MaxLength = 1;
			columnDia.ReadOnly = true;
			columnmes.ReadOnly = true;
			columnMESletras.ReadOnly = true;
			columnMESletras.MaxLength = 10;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_CumpleRow NewspRRHH_Report_CumpleRow()
		{
			return (spRRHH_Report_CumpleRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Report_CumpleRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Report_CumpleRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Report_CumpleRowChanged != null)
			{
				spRRHH_Report_CumpleRowChanged?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Report_CumpleRowChanging != null)
			{
				spRRHH_Report_CumpleRowChanging?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Report_CumpleRowDeleted != null)
			{
				spRRHH_Report_CumpleRowDeleted?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Report_CumpleRowDeleting != null)
			{
				spRRHH_Report_CumpleRowDeleting?.Invoke(this, new spRRHH_Report_CumpleRowChangeEvent((spRRHH_Report_CumpleRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Report_CumpleRow(spRRHH_Report_CumpleRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Report_CumpleDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Rep_cargosDataTable : TypedTableBase<spRRHH_Rep_cargosRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnApellido_Paterno;

		private DataColumn columnApellido_Materno;

		private DataColumn columnnombres;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columncargo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Apellido_PaternoColumn => columnApellido_Paterno;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Apellido_MaternoColumn => columnApellido_Materno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn nombresColumn => columnnombres;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn cargoColumn => columncargo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_cargosRow this[int index] => (spRRHH_Rep_cargosRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_cargosRowChangeEventHandler spRRHH_Rep_cargosRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_cargosRowChangeEventHandler spRRHH_Rep_cargosRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_cargosRowChangeEventHandler spRRHH_Rep_cargosRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_cargosRowChangeEventHandler spRRHH_Rep_cargosRowDeleted;

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
		public spRRHH_Rep_cargosDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Rep_cargos";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Rep_cargosDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Rep_cargosDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Rep_cargosRow(spRRHH_Rep_cargosRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_cargosRow AddspRRHH_Rep_cargosRow(string Apellido_Paterno, string Apellido_Materno, string nombres, string AreaOrganizacional, string cargo)
		{
			spRRHH_Rep_cargosRow spRRHH_Rep_cargosRow = (spRRHH_Rep_cargosRow)NewRow();
			object[] itemArray = new object[5] { Apellido_Paterno, Apellido_Materno, nombres, AreaOrganizacional, cargo };
			spRRHH_Rep_cargosRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Rep_cargosRow);
			return spRRHH_Rep_cargosRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Rep_cargosDataTable spRRHH_Rep_cargosDataTable = (spRRHH_Rep_cargosDataTable)base.Clone();
			spRRHH_Rep_cargosDataTable.InitVars();
			return spRRHH_Rep_cargosDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Rep_cargosDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnApellido_Paterno = base.Columns["Apellido_Paterno"];
			columnApellido_Materno = base.Columns["Apellido_Materno"];
			columnnombres = base.Columns["nombres"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columncargo = base.Columns["cargo"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnApellido_Paterno = new DataColumn("Apellido_Paterno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Paterno);
			columnApellido_Materno = new DataColumn("Apellido_Materno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Materno);
			columnnombres = new DataColumn("nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnombres);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columncargo = new DataColumn("cargo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncargo);
			columnApellido_Paterno.MaxLength = 30;
			columnApellido_Materno.MaxLength = 30;
			columnnombres.MaxLength = 100;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
			columncargo.AllowDBNull = false;
			columncargo.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_cargosRow NewspRRHH_Rep_cargosRow()
		{
			return (spRRHH_Rep_cargosRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Rep_cargosRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Rep_cargosRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Rep_cargosRowChanged != null)
			{
				spRRHH_Rep_cargosRowChanged?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Rep_cargosRowChanging != null)
			{
				spRRHH_Rep_cargosRowChanging?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Rep_cargosRowDeleted != null)
			{
				spRRHH_Rep_cargosRowDeleted?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Rep_cargosRowDeleting != null)
			{
				spRRHH_Rep_cargosRowDeleting?.Invoke(this, new spRRHH_Rep_cargosRowChangeEvent((spRRHH_Rep_cargosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Rep_cargosRow(spRRHH_Rep_cargosRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Rep_cargosDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Ingreso_EgresoDataTable : TypedTableBase<spRRHH_Ficha_Ingreso_EgresoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnRemuneracion;

		private DataColumn columnhonorarios;

		private DataColumn columnAlqPredio;

		private DataColumn columnAlqBienes;

		private DataColumn columnCapitalesColocados;

		private DataColumn columnDietas;

		private DataColumn columnNegocios;

		private DataColumn columnOtrosIngresos;

		private DataColumn columnIngresoMiembros;

		private DataColumn columnNumPersonaAportan;

		private DataColumn columnTotalIngreso;

		private DataColumn columnAlimentacion;

		private DataColumn columnvivienda;

		private DataColumn columneducacion;

		private DataColumn columnsalud;

		private DataColumn columnvestido;

		private DataColumn columnrecreacion;

		private DataColumn columnprestamos;

		private DataColumn columntransporte;

		private DataColumn columnenergiaelec;

		private DataColumn columnagua;

		private DataColumn columnbajapolicia;

		private DataColumn columntelefono;

		private DataColumn columnseguropriv;

		private DataColumn columntarjcredito;

		private DataColumn columnOtrosEgresos;

		private DataColumn columnTotalEgreso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RemuneracionColumn => columnRemuneracion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn honorariosColumn => columnhonorarios;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AlqPredioColumn => columnAlqPredio;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AlqBienesColumn => columnAlqBienes;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CapitalesColocadosColumn => columnCapitalesColocados;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DietasColumn => columnDietas;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NegociosColumn => columnNegocios;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OtrosIngresosColumn => columnOtrosIngresos;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IngresoMiembrosColumn => columnIngresoMiembros;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumPersonaAportanColumn => columnNumPersonaAportan;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TotalIngresoColumn => columnTotalIngreso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AlimentacionColumn => columnAlimentacion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn viviendaColumn => columnvivienda;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn educacionColumn => columneducacion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn saludColumn => columnsalud;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn vestidoColumn => columnvestido;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn recreacionColumn => columnrecreacion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn prestamosColumn => columnprestamos;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn transporteColumn => columntransporte;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn energiaelecColumn => columnenergiaelec;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn aguaColumn => columnagua;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bajapoliciaColumn => columnbajapolicia;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn telefonoColumn => columntelefono;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn seguroprivColumn => columnseguropriv;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tarjcreditoColumn => columntarjcredito;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OtrosEgresosColumn => columnOtrosEgresos;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalEgresoColumn => columnTotalEgreso;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Ingreso_EgresoRow this[int index] => (spRRHH_Ficha_Ingreso_EgresoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Ingreso_EgresoRowChangeEventHandler spRRHH_Ficha_Ingreso_EgresoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Ingreso_EgresoRowChangeEventHandler spRRHH_Ficha_Ingreso_EgresoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Ingreso_EgresoRowChangeEventHandler spRRHH_Ficha_Ingreso_EgresoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Ingreso_EgresoRowChangeEventHandler spRRHH_Ficha_Ingreso_EgresoRowDeleted;

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
		public spRRHH_Ficha_Ingreso_EgresoDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Ingreso_Egreso";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_Ingreso_EgresoDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_Ingreso_EgresoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Ficha_Ingreso_EgresoRow(spRRHH_Ficha_Ingreso_EgresoRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Ingreso_EgresoRow AddspRRHH_Ficha_Ingreso_EgresoRow(decimal Remuneracion, decimal honorarios, decimal AlqPredio, decimal AlqBienes, decimal CapitalesColocados, decimal Dietas, decimal Negocios, decimal OtrosIngresos, decimal IngresoMiembros, string NumPersonaAportan, decimal TotalIngreso, decimal Alimentacion, decimal vivienda, decimal educacion, decimal salud, decimal vestido, decimal recreacion, decimal prestamos, decimal transporte, decimal energiaelec, decimal agua, decimal bajapolicia, decimal telefono, decimal seguropriv, decimal tarjcredito, decimal OtrosEgresos, decimal TotalEgreso)
		{
			spRRHH_Ficha_Ingreso_EgresoRow spRRHH_Ficha_Ingreso_EgresoRow = (spRRHH_Ficha_Ingreso_EgresoRow)NewRow();
			object[] itemArray = new object[27]
			{
				Remuneracion, honorarios, AlqPredio, AlqBienes, CapitalesColocados, Dietas, Negocios, OtrosIngresos, IngresoMiembros, NumPersonaAportan,
				TotalIngreso, Alimentacion, vivienda, educacion, salud, vestido, recreacion, prestamos, transporte, energiaelec,
				agua, bajapolicia, telefono, seguropriv, tarjcredito, OtrosEgresos, TotalEgreso
			};
			spRRHH_Ficha_Ingreso_EgresoRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Ingreso_EgresoRow);
			return spRRHH_Ficha_Ingreso_EgresoRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Ingreso_EgresoDataTable spRRHH_Ficha_Ingreso_EgresoDataTable = (spRRHH_Ficha_Ingreso_EgresoDataTable)base.Clone();
			spRRHH_Ficha_Ingreso_EgresoDataTable.InitVars();
			return spRRHH_Ficha_Ingreso_EgresoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Ingreso_EgresoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnRemuneracion = base.Columns["Remuneracion"];
			columnhonorarios = base.Columns["honorarios"];
			columnAlqPredio = base.Columns["AlqPredio"];
			columnAlqBienes = base.Columns["AlqBienes"];
			columnCapitalesColocados = base.Columns["CapitalesColocados"];
			columnDietas = base.Columns["Dietas"];
			columnNegocios = base.Columns["Negocios"];
			columnOtrosIngresos = base.Columns["OtrosIngresos"];
			columnIngresoMiembros = base.Columns["IngresoMiembros"];
			columnNumPersonaAportan = base.Columns["NumPersonaAportan"];
			columnTotalIngreso = base.Columns["TotalIngreso"];
			columnAlimentacion = base.Columns["Alimentacion"];
			columnvivienda = base.Columns["vivienda"];
			columneducacion = base.Columns["educacion"];
			columnsalud = base.Columns["salud"];
			columnvestido = base.Columns["vestido"];
			columnrecreacion = base.Columns["recreacion"];
			columnprestamos = base.Columns["prestamos"];
			columntransporte = base.Columns["transporte"];
			columnenergiaelec = base.Columns["energiaelec"];
			columnagua = base.Columns["agua"];
			columnbajapolicia = base.Columns["bajapolicia"];
			columntelefono = base.Columns["telefono"];
			columnseguropriv = base.Columns["seguropriv"];
			columntarjcredito = base.Columns["tarjcredito"];
			columnOtrosEgresos = base.Columns["OtrosEgresos"];
			columnTotalEgreso = base.Columns["TotalEgreso"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnRemuneracion = new DataColumn("Remuneracion", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnRemuneracion);
			columnhonorarios = new DataColumn("honorarios", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnhonorarios);
			columnAlqPredio = new DataColumn("AlqPredio", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnAlqPredio);
			columnAlqBienes = new DataColumn("AlqBienes", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnAlqBienes);
			columnCapitalesColocados = new DataColumn("CapitalesColocados", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCapitalesColocados);
			columnDietas = new DataColumn("Dietas", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnDietas);
			columnNegocios = new DataColumn("Negocios", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnNegocios);
			columnOtrosIngresos = new DataColumn("OtrosIngresos", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnOtrosIngresos);
			columnIngresoMiembros = new DataColumn("IngresoMiembros", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnIngresoMiembros);
			columnNumPersonaAportan = new DataColumn("NumPersonaAportan", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumPersonaAportan);
			columnTotalIngreso = new DataColumn("TotalIngreso", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTotalIngreso);
			columnAlimentacion = new DataColumn("Alimentacion", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnAlimentacion);
			columnvivienda = new DataColumn("vivienda", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnvivienda);
			columneducacion = new DataColumn("educacion", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columneducacion);
			columnsalud = new DataColumn("salud", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnsalud);
			columnvestido = new DataColumn("vestido", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnvestido);
			columnrecreacion = new DataColumn("recreacion", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnrecreacion);
			columnprestamos = new DataColumn("prestamos", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnprestamos);
			columntransporte = new DataColumn("transporte", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columntransporte);
			columnenergiaelec = new DataColumn("energiaelec", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnenergiaelec);
			columnagua = new DataColumn("agua", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnagua);
			columnbajapolicia = new DataColumn("bajapolicia", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnbajapolicia);
			columntelefono = new DataColumn("telefono", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columntelefono);
			columnseguropriv = new DataColumn("seguropriv", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnseguropriv);
			columntarjcredito = new DataColumn("tarjcredito", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columntarjcredito);
			columnOtrosEgresos = new DataColumn("OtrosEgresos", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnOtrosEgresos);
			columnTotalEgreso = new DataColumn("TotalEgreso", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTotalEgreso);
			columnNumPersonaAportan.MaxLength = 2;
			columnTotalIngreso.ReadOnly = true;
			columnTotalEgreso.ReadOnly = true;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Ingreso_EgresoRow NewspRRHH_Ficha_Ingreso_EgresoRow()
		{
			return (spRRHH_Ficha_Ingreso_EgresoRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Ingreso_EgresoRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Ingreso_EgresoRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Ingreso_EgresoRowChanged != null)
			{
				spRRHH_Ficha_Ingreso_EgresoRowChanged?.Invoke(this, new spRRHH_Ficha_Ingreso_EgresoRowChangeEvent((spRRHH_Ficha_Ingreso_EgresoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Ingreso_EgresoRowChanging != null)
			{
				spRRHH_Ficha_Ingreso_EgresoRowChanging?.Invoke(this, new spRRHH_Ficha_Ingreso_EgresoRowChangeEvent((spRRHH_Ficha_Ingreso_EgresoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Ingreso_EgresoRowDeleted != null)
			{
				spRRHH_Ficha_Ingreso_EgresoRowDeleted?.Invoke(this, new spRRHH_Ficha_Ingreso_EgresoRowChangeEvent((spRRHH_Ficha_Ingreso_EgresoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Ingreso_EgresoRowDeleting != null)
			{
				spRRHH_Ficha_Ingreso_EgresoRowDeleting?.Invoke(this, new spRRHH_Ficha_Ingreso_EgresoRowChangeEvent((spRRHH_Ficha_Ingreso_EgresoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Ficha_Ingreso_EgresoRow(spRRHH_Ficha_Ingreso_EgresoRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Ingreso_EgresoDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_DatosPersonalesDataTable : TypedTableBase<spRRHH_Ficha_DatosPersonalesRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnedadEmpleado;

		private DataColumn columnNombres;

		private DataColumn columnApellido_Paterno;

		private DataColumn columnApellido_Materno;

		private DataColumn columnsexo;

		private DataColumn columnNumDocId;

		private DataColumn columnTipoDoc;

		private DataColumn columnNacionalidad;

		private DataColumn columnFechaNacimiento;

		private DataColumn columnTelefono;

		private DataColumn columnFax;

		private DataColumn columnNumCelular;

		private DataColumn columnFonoCentroLab;

		private DataColumn columnEstadoCivil;

		private DataColumn columnDiscapacidad;

		private DataColumn columngradoInstruccion;

		private DataColumn columndesdepartamento;

		private DataColumn columndesprovincia;

		private DataColumn columndesdistrito;

		private DataColumn columndepCasa;

		private DataColumn columnProvCasa;

		private DataColumn columnDistCasa;

		private DataColumn columndireccion;

		private DataColumn columnNumRUC;

		private DataColumn columnNumLibretaMilitar;

		private DataColumn columnfoto;

		private DataColumn columnidempleado;

		private DataColumn columnFechaRegistro;

		private DataColumn columnExpSocial;

		private DataColumn columnbrevete;

		private DataColumn columnDescripTS;

		private DataColumn columnDescripvivecon;

		private DataColumn columnJefeHogar;

		private DataColumn columnCargaFam;

		private DataColumn columnNumhijos;

		private DataColumn columnObsFam;

		private DataColumn columnTipoFamDescrip;

		private DataColumn columnrelacParejaDescrip;

		private DataColumn columnRelacPHDescrip;

		private DataColumn columnRelacHermanoDescrip;

		private DataColumn columncom1;

		private DataColumn columncom2;

		private DataColumn columnafec1;

		private DataColumn columnafec2;

		private DataColumn columndecis1;

		private DataColumn columndecis2;

		private DataColumn columnsoc1;

		private DataColumn columnsoc2;

		private DataColumn columnsoc3;

		private DataColumn columnrespues1;

		private DataColumn columnrespues2;

		private DataColumn columnrespues3;

		private DataColumn columnPrincipProblemas;

		private DataColumn columnPropMejoraInstitu;

		private DataColumn columnhobby;

		private DataColumn columnActRecreaInstitu;

		private DataColumn columnAcudeEnfermDescrip;

		private DataColumn columnenfercronica;

		private DataColumn columnenfercronicadescrip;

		private DataColumn columnfamdiscapacidad;

		private DataColumn columnfamdiscapdescrip;

		private DataColumn columnalergico;

		private DataColumn columnalergicodescrip;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn edadEmpleadoColumn => columnedadEmpleado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NombresColumn => columnNombres;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Apellido_PaternoColumn => columnApellido_Paterno;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Apellido_MaternoColumn => columnApellido_Materno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn sexoColumn => columnsexo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumDocIdColumn => columnNumDocId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TipoDocColumn => columnTipoDoc;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NacionalidadColumn => columnNacionalidad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechaNacimientoColumn => columnFechaNacimiento;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TelefonoColumn => columnTelefono;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FaxColumn => columnFax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumCelularColumn => columnNumCelular;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FonoCentroLabColumn => columnFonoCentroLab;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn EstadoCivilColumn => columnEstadoCivil;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DiscapacidadColumn => columnDiscapacidad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn gradoInstruccionColumn => columngradoInstruccion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn desdepartamentoColumn => columndesdepartamento;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn desprovinciaColumn => columndesprovincia;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn desdistritoColumn => columndesdistrito;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn depCasaColumn => columndepCasa;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProvCasaColumn => columnProvCasa;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DistCasaColumn => columnDistCasa;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn direccionColumn => columndireccion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumRUCColumn => columnNumRUC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumLibretaMilitarColumn => columnNumLibretaMilitar;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn fotoColumn => columnfoto;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idempleadoColumn => columnidempleado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaRegistroColumn => columnFechaRegistro;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ExpSocialColumn => columnExpSocial;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn breveteColumn => columnbrevete;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripTSColumn => columnDescripTS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripviveconColumn => columnDescripvivecon;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn JefeHogarColumn => columnJefeHogar;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CargaFamColumn => columnCargaFam;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumhijosColumn => columnNumhijos;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ObsFamColumn => columnObsFam;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TipoFamDescripColumn => columnTipoFamDescrip;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn relacParejaDescripColumn => columnrelacParejaDescrip;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RelacPHDescripColumn => columnRelacPHDescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RelacHermanoDescripColumn => columnRelacHermanoDescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn com1Column => columncom1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn com2Column => columncom2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn afec1Column => columnafec1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn afec2Column => columnafec2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn decis1Column => columndecis1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn decis2Column => columndecis2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn soc1Column => columnsoc1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn soc2Column => columnsoc2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn soc3Column => columnsoc3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn respues1Column => columnrespues1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn respues2Column => columnrespues2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn respues3Column => columnrespues3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PrincipProblemasColumn => columnPrincipProblemas;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PropMejoraInstituColumn => columnPropMejoraInstitu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn hobbyColumn => columnhobby;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ActRecreaInstituColumn => columnActRecreaInstitu;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AcudeEnfermDescripColumn => columnAcudeEnfermDescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn enfercronicaColumn => columnenfercronica;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn enfercronicadescripColumn => columnenfercronicadescrip;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn famdiscapacidadColumn => columnfamdiscapacidad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn famdiscapdescripColumn => columnfamdiscapdescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn alergicoColumn => columnalergico;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn alergicodescripColumn => columnalergicodescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_DatosPersonalesRow this[int index] => (spRRHH_Ficha_DatosPersonalesRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_DatosPersonalesRowChangeEventHandler spRRHH_Ficha_DatosPersonalesRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_DatosPersonalesRowChangeEventHandler spRRHH_Ficha_DatosPersonalesRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_DatosPersonalesRowChangeEventHandler spRRHH_Ficha_DatosPersonalesRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_DatosPersonalesRowChangeEventHandler spRRHH_Ficha_DatosPersonalesRowDeleted;

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
		public spRRHH_Ficha_DatosPersonalesDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_DatosPersonales";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_DatosPersonalesDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_DatosPersonalesDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_DatosPersonalesRow(spRRHH_Ficha_DatosPersonalesRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_DatosPersonalesRow AddspRRHH_Ficha_DatosPersonalesRow(int edadEmpleado, string Nombres, string Apellido_Paterno, string Apellido_Materno, string sexo, string NumDocId, string TipoDoc, string Nacionalidad, DateTime FechaNacimiento, string Telefono, string Fax, string NumCelular, string FonoCentroLab, string EstadoCivil, string Discapacidad, string gradoInstruccion, string desdepartamento, string desprovincia, string desdistrito, string depCasa, string ProvCasa, string DistCasa, string direccion, string NumRUC, string NumLibretaMilitar, byte[] foto, int idempleado, DateTime FechaRegistro, string ExpSocial, string brevete, string DescripTS, string Descripvivecon, bool JefeHogar, string CargaFam, string Numhijos, string ObsFam, string TipoFamDescrip, string relacParejaDescrip, string RelacPHDescrip, string RelacHermanoDescrip, string com1, string com2, string afec1, string afec2, string decis1, string decis2, string soc1, string soc2, string soc3, string respues1, string respues2, string respues3, string PrincipProblemas, string PropMejoraInstitu, string hobby, string ActRecreaInstitu, string AcudeEnfermDescrip, bool enfercronica, string enfercronicadescrip, bool famdiscapacidad, string famdiscapdescrip, bool alergico, string alergicodescrip)
		{
			spRRHH_Ficha_DatosPersonalesRow spRRHH_Ficha_DatosPersonalesRow = (spRRHH_Ficha_DatosPersonalesRow)NewRow();
			object[] itemArray = new object[63]
			{
				edadEmpleado, Nombres, Apellido_Paterno, Apellido_Materno, sexo, NumDocId, TipoDoc, Nacionalidad, FechaNacimiento, Telefono,
				Fax, NumCelular, FonoCentroLab, EstadoCivil, Discapacidad, gradoInstruccion, desdepartamento, desprovincia, desdistrito, depCasa,
				ProvCasa, DistCasa, direccion, NumRUC, NumLibretaMilitar, foto, idempleado, FechaRegistro, ExpSocial, brevete,
				DescripTS, Descripvivecon, JefeHogar, CargaFam, Numhijos, ObsFam, TipoFamDescrip, relacParejaDescrip, RelacPHDescrip, RelacHermanoDescrip,
				com1, com2, afec1, afec2, decis1, decis2, soc1, soc2, soc3, respues1,
				respues2, respues3, PrincipProblemas, PropMejoraInstitu, hobby, ActRecreaInstitu, AcudeEnfermDescrip, enfercronica, enfercronicadescrip, famdiscapacidad,
				famdiscapdescrip, alergico, alergicodescrip
			};
			spRRHH_Ficha_DatosPersonalesRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_DatosPersonalesRow);
			return spRRHH_Ficha_DatosPersonalesRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_DatosPersonalesRow FindByidempleado(int idempleado)
		{
			return (spRRHH_Ficha_DatosPersonalesRow)Rows.Find(new object[1] { idempleado });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_DatosPersonalesDataTable spRRHH_Ficha_DatosPersonalesDataTable = (spRRHH_Ficha_DatosPersonalesDataTable)base.Clone();
			spRRHH_Ficha_DatosPersonalesDataTable.InitVars();
			return spRRHH_Ficha_DatosPersonalesDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_DatosPersonalesDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnedadEmpleado = base.Columns["edadEmpleado"];
			columnNombres = base.Columns["Nombres"];
			columnApellido_Paterno = base.Columns["Apellido_Paterno"];
			columnApellido_Materno = base.Columns["Apellido_Materno"];
			columnsexo = base.Columns["sexo"];
			columnNumDocId = base.Columns["NumDocId"];
			columnTipoDoc = base.Columns["TipoDoc"];
			columnNacionalidad = base.Columns["Nacionalidad"];
			columnFechaNacimiento = base.Columns["FechaNacimiento"];
			columnTelefono = base.Columns["Telefono"];
			columnFax = base.Columns["Fax"];
			columnNumCelular = base.Columns["NumCelular"];
			columnFonoCentroLab = base.Columns["FonoCentroLab"];
			columnEstadoCivil = base.Columns["EstadoCivil"];
			columnDiscapacidad = base.Columns["Discapacidad"];
			columngradoInstruccion = base.Columns["gradoInstruccion"];
			columndesdepartamento = base.Columns["desdepartamento"];
			columndesprovincia = base.Columns["desprovincia"];
			columndesdistrito = base.Columns["desdistrito"];
			columndepCasa = base.Columns["depCasa"];
			columnProvCasa = base.Columns["ProvCasa"];
			columnDistCasa = base.Columns["DistCasa"];
			columndireccion = base.Columns["direccion"];
			columnNumRUC = base.Columns["NumRUC"];
			columnNumLibretaMilitar = base.Columns["NumLibretaMilitar"];
			columnfoto = base.Columns["foto"];
			columnidempleado = base.Columns["idempleado"];
			columnFechaRegistro = base.Columns["FechaRegistro"];
			columnExpSocial = base.Columns["ExpSocial"];
			columnbrevete = base.Columns["brevete"];
			columnDescripTS = base.Columns["DescripTS"];
			columnDescripvivecon = base.Columns["Descripvivecon"];
			columnJefeHogar = base.Columns["JefeHogar"];
			columnCargaFam = base.Columns["CargaFam"];
			columnNumhijos = base.Columns["Numhijos"];
			columnObsFam = base.Columns["ObsFam"];
			columnTipoFamDescrip = base.Columns["TipoFamDescrip"];
			columnrelacParejaDescrip = base.Columns["relacParejaDescrip"];
			columnRelacPHDescrip = base.Columns["RelacPHDescrip"];
			columnRelacHermanoDescrip = base.Columns["RelacHermanoDescrip"];
			columncom1 = base.Columns["com1"];
			columncom2 = base.Columns["com2"];
			columnafec1 = base.Columns["afec1"];
			columnafec2 = base.Columns["afec2"];
			columndecis1 = base.Columns["decis1"];
			columndecis2 = base.Columns["decis2"];
			columnsoc1 = base.Columns["soc1"];
			columnsoc2 = base.Columns["soc2"];
			columnsoc3 = base.Columns["soc3"];
			columnrespues1 = base.Columns["respues1"];
			columnrespues2 = base.Columns["respues2"];
			columnrespues3 = base.Columns["respues3"];
			columnPrincipProblemas = base.Columns["PrincipProblemas"];
			columnPropMejoraInstitu = base.Columns["PropMejoraInstitu"];
			columnhobby = base.Columns["hobby"];
			columnActRecreaInstitu = base.Columns["ActRecreaInstitu"];
			columnAcudeEnfermDescrip = base.Columns["AcudeEnfermDescrip"];
			columnenfercronica = base.Columns["enfercronica"];
			columnenfercronicadescrip = base.Columns["enfercronicadescrip"];
			columnfamdiscapacidad = base.Columns["famdiscapacidad"];
			columnfamdiscapdescrip = base.Columns["famdiscapdescrip"];
			columnalergico = base.Columns["alergico"];
			columnalergicodescrip = base.Columns["alergicodescrip"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnedadEmpleado = new DataColumn("edadEmpleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnedadEmpleado);
			columnNombres = new DataColumn("Nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombres);
			columnApellido_Paterno = new DataColumn("Apellido_Paterno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Paterno);
			columnApellido_Materno = new DataColumn("Apellido_Materno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Materno);
			columnsexo = new DataColumn("sexo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnsexo);
			columnNumDocId = new DataColumn("NumDocId", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumDocId);
			columnTipoDoc = new DataColumn("TipoDoc", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTipoDoc);
			columnNacionalidad = new DataColumn("Nacionalidad", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNacionalidad);
			columnFechaNacimiento = new DataColumn("FechaNacimiento", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaNacimiento);
			columnTelefono = new DataColumn("Telefono", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTelefono);
			columnFax = new DataColumn("Fax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFax);
			columnNumCelular = new DataColumn("NumCelular", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumCelular);
			columnFonoCentroLab = new DataColumn("FonoCentroLab", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFonoCentroLab);
			columnEstadoCivil = new DataColumn("EstadoCivil", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEstadoCivil);
			columnDiscapacidad = new DataColumn("Discapacidad", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiscapacidad);
			columngradoInstruccion = new DataColumn("gradoInstruccion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columngradoInstruccion);
			columndesdepartamento = new DataColumn("desdepartamento", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndesdepartamento);
			columndesprovincia = new DataColumn("desprovincia", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndesprovincia);
			columndesdistrito = new DataColumn("desdistrito", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndesdistrito);
			columndepCasa = new DataColumn("depCasa", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndepCasa);
			columnProvCasa = new DataColumn("ProvCasa", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProvCasa);
			columnDistCasa = new DataColumn("DistCasa", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDistCasa);
			columndireccion = new DataColumn("direccion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndireccion);
			columnNumRUC = new DataColumn("NumRUC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumRUC);
			columnNumLibretaMilitar = new DataColumn("NumLibretaMilitar", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumLibretaMilitar);
			columnfoto = new DataColumn("foto", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnfoto);
			columnidempleado = new DataColumn("idempleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidempleado);
			columnFechaRegistro = new DataColumn("FechaRegistro", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaRegistro);
			columnExpSocial = new DataColumn("ExpSocial", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnExpSocial);
			columnbrevete = new DataColumn("brevete", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnbrevete);
			columnDescripTS = new DataColumn("DescripTS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTS);
			columnDescripvivecon = new DataColumn("Descripvivecon", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripvivecon);
			columnJefeHogar = new DataColumn("JefeHogar", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnJefeHogar);
			columnCargaFam = new DataColumn("CargaFam", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCargaFam);
			columnNumhijos = new DataColumn("Numhijos", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumhijos);
			columnObsFam = new DataColumn("ObsFam", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnObsFam);
			columnTipoFamDescrip = new DataColumn("TipoFamDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTipoFamDescrip);
			columnrelacParejaDescrip = new DataColumn("relacParejaDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnrelacParejaDescrip);
			columnRelacPHDescrip = new DataColumn("RelacPHDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRelacPHDescrip);
			columnRelacHermanoDescrip = new DataColumn("RelacHermanoDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRelacHermanoDescrip);
			columncom1 = new DataColumn("com1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncom1);
			columncom2 = new DataColumn("com2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncom2);
			columnafec1 = new DataColumn("afec1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnafec1);
			columnafec2 = new DataColumn("afec2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnafec2);
			columndecis1 = new DataColumn("decis1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndecis1);
			columndecis2 = new DataColumn("decis2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndecis2);
			columnsoc1 = new DataColumn("soc1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnsoc1);
			columnsoc2 = new DataColumn("soc2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnsoc2);
			columnsoc3 = new DataColumn("soc3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnsoc3);
			columnrespues1 = new DataColumn("respues1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnrespues1);
			columnrespues2 = new DataColumn("respues2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnrespues2);
			columnrespues3 = new DataColumn("respues3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnrespues3);
			columnPrincipProblemas = new DataColumn("PrincipProblemas", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPrincipProblemas);
			columnPropMejoraInstitu = new DataColumn("PropMejoraInstitu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPropMejoraInstitu);
			columnhobby = new DataColumn("hobby", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnhobby);
			columnActRecreaInstitu = new DataColumn("ActRecreaInstitu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnActRecreaInstitu);
			columnAcudeEnfermDescrip = new DataColumn("AcudeEnfermDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAcudeEnfermDescrip);
			columnenfercronica = new DataColumn("enfercronica", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnenfercronica);
			columnenfercronicadescrip = new DataColumn("enfercronicadescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnenfercronicadescrip);
			columnfamdiscapacidad = new DataColumn("famdiscapacidad", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnfamdiscapacidad);
			columnfamdiscapdescrip = new DataColumn("famdiscapdescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnfamdiscapdescrip);
			columnalergico = new DataColumn("alergico", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnalergico);
			columnalergicodescrip = new DataColumn("alergicodescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnalergicodescrip);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnidempleado }, isPrimaryKey: true));
			columnedadEmpleado.ReadOnly = true;
			columnNombres.MaxLength = 100;
			columnApellido_Paterno.MaxLength = 30;
			columnApellido_Materno.MaxLength = 30;
			columnsexo.MaxLength = 1;
			columnNumDocId.MaxLength = 12;
			columnTipoDoc.MaxLength = 40;
			columnNacionalidad.MaxLength = 50;
			columnTelefono.MaxLength = 15;
			columnFax.MaxLength = 15;
			columnNumCelular.MaxLength = 15;
			columnFonoCentroLab.MaxLength = 15;
			columnEstadoCivil.MaxLength = 11;
			columnDiscapacidad.MaxLength = 12;
			columngradoInstruccion.MaxLength = 80;
			columndesdepartamento.ReadOnly = true;
			columndesdepartamento.MaxLength = 120;
			columndesprovincia.ReadOnly = true;
			columndesprovincia.MaxLength = 120;
			columndesdistrito.MaxLength = 120;
			columndepCasa.ReadOnly = true;
			columndepCasa.MaxLength = 120;
			columnProvCasa.ReadOnly = true;
			columnProvCasa.MaxLength = 120;
			columnDistCasa.MaxLength = 120;
			columndireccion.MaxLength = 100;
			columnNumRUC.MaxLength = 12;
			columnNumLibretaMilitar.MaxLength = 10;
			columnidempleado.AllowDBNull = false;
			columnidempleado.Unique = true;
			columnExpSocial.MaxLength = 20;
			columnbrevete.MaxLength = 12;
			columnDescripTS.MaxLength = 5;
			columnDescripvivecon.MaxLength = 27;
			columnCargaFam.MaxLength = 2;
			columnNumhijos.MaxLength = 2;
			columnObsFam.MaxLength = 500;
			columnTipoFamDescrip.MaxLength = 10;
			columnrelacParejaDescrip.MaxLength = 12;
			columnRelacPHDescrip.MaxLength = 14;
			columnRelacHermanoDescrip.MaxLength = 12;
			columncom1.MaxLength = 2;
			columncom2.MaxLength = 2;
			columnafec1.MaxLength = 2;
			columnafec2.MaxLength = 2;
			columndecis1.MaxLength = 2;
			columndecis2.MaxLength = 2;
			columnsoc1.MaxLength = 2;
			columnsoc2.MaxLength = 2;
			columnsoc3.MaxLength = 2;
			columnrespues1.MaxLength = 83;
			columnrespues2.MaxLength = 22;
			columnrespues3.MaxLength = 23;
			columnPrincipProblemas.MaxLength = 400;
			columnPropMejoraInstitu.MaxLength = 400;
			columnhobby.MaxLength = 400;
			columnActRecreaInstitu.MaxLength = 400;
			columnAcudeEnfermDescrip.MaxLength = 16;
			columnenfercronicadescrip.MaxLength = 200;
			columnfamdiscapdescrip.MaxLength = 200;
			columnalergicodescrip.MaxLength = 200;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_DatosPersonalesRow NewspRRHH_Ficha_DatosPersonalesRow()
		{
			return (spRRHH_Ficha_DatosPersonalesRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_DatosPersonalesRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_DatosPersonalesRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_DatosPersonalesRowChanged != null)
			{
				spRRHH_Ficha_DatosPersonalesRowChanged?.Invoke(this, new spRRHH_Ficha_DatosPersonalesRowChangeEvent((spRRHH_Ficha_DatosPersonalesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_DatosPersonalesRowChanging != null)
			{
				spRRHH_Ficha_DatosPersonalesRowChanging?.Invoke(this, new spRRHH_Ficha_DatosPersonalesRowChangeEvent((spRRHH_Ficha_DatosPersonalesRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_DatosPersonalesRowDeleted != null)
			{
				spRRHH_Ficha_DatosPersonalesRowDeleted?.Invoke(this, new spRRHH_Ficha_DatosPersonalesRowChangeEvent((spRRHH_Ficha_DatosPersonalesRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_DatosPersonalesRowDeleting != null)
			{
				spRRHH_Ficha_DatosPersonalesRowDeleting?.Invoke(this, new spRRHH_Ficha_DatosPersonalesRowChangeEvent((spRRHH_Ficha_DatosPersonalesRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Ficha_DatosPersonalesRow(spRRHH_Ficha_DatosPersonalesRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_DatosPersonalesDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_Det_Familiar_SaludDataTable : TypedTableBase<spRRHH_Ficha_Det_Familiar_SaludRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnnumdocid;

		private DataColumn columnDescripTipoFam;

		private DataColumn columnenfermedad;

		private DataColumn columntiempoenfermedad;

		private DataColumn columnnumautogensalud;

		private DataColumn columndescripts;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn numdocidColumn => columnnumdocid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripTipoFamColumn => columnDescripTipoFam;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn enfermedadColumn => columnenfermedad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn tiempoenfermedadColumn => columntiempoenfermedad;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn numautogensaludColumn => columnnumautogensalud;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn descriptsColumn => columndescripts;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_Familiar_SaludRow this[int index] => (spRRHH_Ficha_Det_Familiar_SaludRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_Familiar_SaludRowChangeEventHandler spRRHH_Ficha_Det_Familiar_SaludRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_Familiar_SaludRowChangeEventHandler spRRHH_Ficha_Det_Familiar_SaludRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_Familiar_SaludRowChangeEventHandler spRRHH_Ficha_Det_Familiar_SaludRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_Det_Familiar_SaludRowChangeEventHandler spRRHH_Ficha_Det_Familiar_SaludRowDeleted;

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
		public spRRHH_Ficha_Det_Familiar_SaludDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Det_Familiar_Salud";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Det_Familiar_SaludDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_Det_Familiar_SaludDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Ficha_Det_Familiar_SaludRow(spRRHH_Ficha_Det_Familiar_SaludRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_Familiar_SaludRow AddspRRHH_Ficha_Det_Familiar_SaludRow(string numdocid, string DescripTipoFam, string enfermedad, string tiempoenfermedad, string numautogensalud, string descripts)
		{
			spRRHH_Ficha_Det_Familiar_SaludRow spRRHH_Ficha_Det_Familiar_SaludRow = (spRRHH_Ficha_Det_Familiar_SaludRow)NewRow();
			object[] itemArray = new object[6] { numdocid, DescripTipoFam, enfermedad, tiempoenfermedad, numautogensalud, descripts };
			spRRHH_Ficha_Det_Familiar_SaludRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_Det_Familiar_SaludRow);
			return spRRHH_Ficha_Det_Familiar_SaludRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Ficha_Det_Familiar_SaludDataTable spRRHH_Ficha_Det_Familiar_SaludDataTable = (spRRHH_Ficha_Det_Familiar_SaludDataTable)base.Clone();
			spRRHH_Ficha_Det_Familiar_SaludDataTable.InitVars();
			return spRRHH_Ficha_Det_Familiar_SaludDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_Det_Familiar_SaludDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnnumdocid = base.Columns["numdocid"];
			columnDescripTipoFam = base.Columns["DescripTipoFam"];
			columnenfermedad = base.Columns["enfermedad"];
			columntiempoenfermedad = base.Columns["tiempoenfermedad"];
			columnnumautogensalud = base.Columns["numautogensalud"];
			columndescripts = base.Columns["descripts"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnnumdocid = new DataColumn("numdocid", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnumdocid);
			columnDescripTipoFam = new DataColumn("DescripTipoFam", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTipoFam);
			columnenfermedad = new DataColumn("enfermedad", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnenfermedad);
			columntiempoenfermedad = new DataColumn("tiempoenfermedad", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntiempoenfermedad);
			columnnumautogensalud = new DataColumn("numautogensalud", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnumautogensalud);
			columndescripts = new DataColumn("descripts", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndescripts);
			columnnumdocid.MaxLength = 12;
			columnDescripTipoFam.MaxLength = 10;
			columnenfermedad.MaxLength = 200;
			columntiempoenfermedad.MaxLength = 200;
			columnnumautogensalud.MaxLength = 15;
			columndescripts.MaxLength = 5;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_Familiar_SaludRow NewspRRHH_Ficha_Det_Familiar_SaludRow()
		{
			return (spRRHH_Ficha_Det_Familiar_SaludRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_Det_Familiar_SaludRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_Det_Familiar_SaludRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_Det_Familiar_SaludRowChanged != null)
			{
				spRRHH_Ficha_Det_Familiar_SaludRowChanged?.Invoke(this, new spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent((spRRHH_Ficha_Det_Familiar_SaludRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_Det_Familiar_SaludRowChanging != null)
			{
				spRRHH_Ficha_Det_Familiar_SaludRowChanging?.Invoke(this, new spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent((spRRHH_Ficha_Det_Familiar_SaludRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_Det_Familiar_SaludRowDeleted != null)
			{
				spRRHH_Ficha_Det_Familiar_SaludRowDeleted?.Invoke(this, new spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent((spRRHH_Ficha_Det_Familiar_SaludRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_Det_Familiar_SaludRowDeleting != null)
			{
				spRRHH_Ficha_Det_Familiar_SaludRowDeleting?.Invoke(this, new spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent((spRRHH_Ficha_Det_Familiar_SaludRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Ficha_Det_Familiar_SaludRow(spRRHH_Ficha_Det_Familiar_SaludRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_Det_Familiar_SaludDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Ficha_ViviendaDataTable : TypedTableBase<spRRHH_Ficha_ViviendaRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnDescripTenencia;

		private DataColumn columnDescripTipo;

		private DataColumn columnDescripMaterial;

		private DataColumn columnDescripConserva;

		private DataColumn columnNumDormitorio;

		private DataColumn columnNumServHig;

		private DataColumn columnDescripUbicacion;

		private DataColumn columnDescripAlumbrado;

		private DataColumn columnotroalumbrado;

		private DataColumn columndescripAgua;

		private DataColumn columnOtroAgua;

		private DataColumn columnDescripExcretas;

		private DataColumn columnOtroExcreta;

		private DataColumn columntelefono;

		private DataColumn columncable;

		private DataColumn columninternet;

		private DataColumn columnotros;

		private DataColumn columnNumCompart;

		private DataColumn columnNumPerDorm;

		private DataColumn columnobservacion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripTenenciaColumn => columnDescripTenencia;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripTipoColumn => columnDescripTipo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripMaterialColumn => columnDescripMaterial;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripConservaColumn => columnDescripConserva;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumDormitorioColumn => columnNumDormitorio;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NumServHigColumn => columnNumServHig;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DescripUbicacionColumn => columnDescripUbicacion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripAlumbradoColumn => columnDescripAlumbrado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn otroalumbradoColumn => columnotroalumbrado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn descripAguaColumn => columndescripAgua;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OtroAguaColumn => columnOtroAgua;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripExcretasColumn => columnDescripExcretas;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OtroExcretaColumn => columnOtroExcreta;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn telefonoColumn => columntelefono;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn cableColumn => columncable;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn internetColumn => columninternet;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn otrosColumn => columnotros;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumCompartColumn => columnNumCompart;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumPerDormColumn => columnNumPerDorm;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn observacionColumn => columnobservacion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_ViviendaRow this[int index] => (spRRHH_Ficha_ViviendaRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ViviendaRowChangeEventHandler spRRHH_Ficha_ViviendaRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ViviendaRowChangeEventHandler spRRHH_Ficha_ViviendaRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ViviendaRowChangeEventHandler spRRHH_Ficha_ViviendaRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Ficha_ViviendaRowChangeEventHandler spRRHH_Ficha_ViviendaRowDeleted;

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
		public spRRHH_Ficha_ViviendaDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Ficha_Vivienda";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_ViviendaDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_Ficha_ViviendaDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_Ficha_ViviendaRow(spRRHH_Ficha_ViviendaRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ViviendaRow AddspRRHH_Ficha_ViviendaRow(string DescripTenencia, string DescripTipo, string DescripMaterial, string DescripConserva, string NumDormitorio, string NumServHig, string DescripUbicacion, string DescripAlumbrado, string otroalumbrado, string descripAgua, string OtroAgua, string DescripExcretas, string OtroExcreta, bool telefono, bool cable, bool internet, bool otros, string NumCompart, string NumPerDorm, string observacion)
		{
			spRRHH_Ficha_ViviendaRow spRRHH_Ficha_ViviendaRow = (spRRHH_Ficha_ViviendaRow)NewRow();
			object[] itemArray = new object[20]
			{
				DescripTenencia, DescripTipo, DescripMaterial, DescripConserva, NumDormitorio, NumServHig, DescripUbicacion, DescripAlumbrado, otroalumbrado, descripAgua,
				OtroAgua, DescripExcretas, OtroExcreta, telefono, cable, internet, otros, NumCompart, NumPerDorm, observacion
			};
			spRRHH_Ficha_ViviendaRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Ficha_ViviendaRow);
			return spRRHH_Ficha_ViviendaRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Ficha_ViviendaDataTable spRRHH_Ficha_ViviendaDataTable = (spRRHH_Ficha_ViviendaDataTable)base.Clone();
			spRRHH_Ficha_ViviendaDataTable.InitVars();
			return spRRHH_Ficha_ViviendaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Ficha_ViviendaDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnDescripTenencia = base.Columns["DescripTenencia"];
			columnDescripTipo = base.Columns["DescripTipo"];
			columnDescripMaterial = base.Columns["DescripMaterial"];
			columnDescripConserva = base.Columns["DescripConserva"];
			columnNumDormitorio = base.Columns["NumDormitorio"];
			columnNumServHig = base.Columns["NumServHig"];
			columnDescripUbicacion = base.Columns["DescripUbicacion"];
			columnDescripAlumbrado = base.Columns["DescripAlumbrado"];
			columnotroalumbrado = base.Columns["otroalumbrado"];
			columndescripAgua = base.Columns["descripAgua"];
			columnOtroAgua = base.Columns["OtroAgua"];
			columnDescripExcretas = base.Columns["DescripExcretas"];
			columnOtroExcreta = base.Columns["OtroExcreta"];
			columntelefono = base.Columns["telefono"];
			columncable = base.Columns["cable"];
			columninternet = base.Columns["internet"];
			columnotros = base.Columns["otros"];
			columnNumCompart = base.Columns["NumCompart"];
			columnNumPerDorm = base.Columns["NumPerDorm"];
			columnobservacion = base.Columns["observacion"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnDescripTenencia = new DataColumn("DescripTenencia", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTenencia);
			columnDescripTipo = new DataColumn("DescripTipo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripTipo);
			columnDescripMaterial = new DataColumn("DescripMaterial", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripMaterial);
			columnDescripConserva = new DataColumn("DescripConserva", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripConserva);
			columnNumDormitorio = new DataColumn("NumDormitorio", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumDormitorio);
			columnNumServHig = new DataColumn("NumServHig", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumServHig);
			columnDescripUbicacion = new DataColumn("DescripUbicacion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripUbicacion);
			columnDescripAlumbrado = new DataColumn("DescripAlumbrado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripAlumbrado);
			columnotroalumbrado = new DataColumn("otroalumbrado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnotroalumbrado);
			columndescripAgua = new DataColumn("descripAgua", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndescripAgua);
			columnOtroAgua = new DataColumn("OtroAgua", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOtroAgua);
			columnDescripExcretas = new DataColumn("DescripExcretas", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripExcretas);
			columnOtroExcreta = new DataColumn("OtroExcreta", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOtroExcreta);
			columntelefono = new DataColumn("telefono", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columntelefono);
			columncable = new DataColumn("cable", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columncable);
			columninternet = new DataColumn("internet", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columninternet);
			columnotros = new DataColumn("otros", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnotros);
			columnNumCompart = new DataColumn("NumCompart", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumCompart);
			columnNumPerDorm = new DataColumn("NumPerDorm", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumPerDorm);
			columnobservacion = new DataColumn("observacion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnobservacion);
			columnDescripTenencia.MaxLength = 30;
			columnDescripTipo.MaxLength = 20;
			columnDescripMaterial.MaxLength = 12;
			columnDescripConserva.MaxLength = 17;
			columnNumDormitorio.MaxLength = 2;
			columnNumServHig.MaxLength = 2;
			columnDescripUbicacion.MaxLength = 22;
			columnDescripAlumbrado.MaxLength = 20;
			columnotroalumbrado.MaxLength = 50;
			columndescripAgua.MaxLength = 33;
			columnOtroAgua.MaxLength = 50;
			columnDescripExcretas.MaxLength = 33;
			columnOtroExcreta.MaxLength = 50;
			columnNumCompart.MaxLength = 2;
			columnNumPerDorm.MaxLength = 2;
			columnobservacion.MaxLength = 200;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_ViviendaRow NewspRRHH_Ficha_ViviendaRow()
		{
			return (spRRHH_Ficha_ViviendaRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Ficha_ViviendaRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Ficha_ViviendaRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Ficha_ViviendaRowChanged != null)
			{
				spRRHH_Ficha_ViviendaRowChanged?.Invoke(this, new spRRHH_Ficha_ViviendaRowChangeEvent((spRRHH_Ficha_ViviendaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Ficha_ViviendaRowChanging != null)
			{
				spRRHH_Ficha_ViviendaRowChanging?.Invoke(this, new spRRHH_Ficha_ViviendaRowChangeEvent((spRRHH_Ficha_ViviendaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Ficha_ViviendaRowDeleted != null)
			{
				spRRHH_Ficha_ViviendaRowDeleted?.Invoke(this, new spRRHH_Ficha_ViviendaRowChangeEvent((spRRHH_Ficha_ViviendaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Ficha_ViviendaRowDeleting != null)
			{
				spRRHH_Ficha_ViviendaRowDeleting?.Invoke(this, new spRRHH_Ficha_ViviendaRowChangeEvent((spRRHH_Ficha_ViviendaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_Ficha_ViviendaRow(spRRHH_Ficha_ViviendaRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Ficha_ViviendaDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_FaltasDataTable : TypedTableBase<spRRHH_FaltasRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnNombresC;

		private DataColumn columnNumDocID;

		private DataColumn columnIdpersona;

		private DataColumn columnIdempleado;

		private DataColumn columnyear;

		private DataColumn columnidAreaOrganiz;

		private DataColumn columnidTipoTrabajador;

		private DataColumn columnEstado;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columnDescripcion;

		private DataColumn columnFecha;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NombresCColumn => columnNombresC;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumDocIDColumn => columnNumDocID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IdpersonaColumn => columnIdpersona;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IdempleadoColumn => columnIdempleado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn yearColumn => columnyear;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idAreaOrganizColumn => columnidAreaOrganiz;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idTipoTrabajadorColumn => columnidTipoTrabajador;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EstadoColumn => columnEstado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripcionColumn => columnDescripcion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaColumn => columnFecha;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_FaltasRow this[int index] => (spRRHH_FaltasRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_FaltasRowChangeEventHandler spRRHH_FaltasRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_FaltasRowChangeEventHandler spRRHH_FaltasRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_FaltasRowChangeEventHandler spRRHH_FaltasRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_FaltasRowChangeEventHandler spRRHH_FaltasRowDeleted;

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
		public spRRHH_FaltasDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Faltas";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_FaltasDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_FaltasDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_FaltasRow(spRRHH_FaltasRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_FaltasRow AddspRRHH_FaltasRow(string NombresC, string NumDocID, int Idpersona, int Idempleado, int year, int idAreaOrganiz, int idTipoTrabajador, string Estado, string AreaOrganizacional, string Descripcion, DateTime Fecha)
		{
			spRRHH_FaltasRow spRRHH_FaltasRow = (spRRHH_FaltasRow)NewRow();
			object[] itemArray = new object[11]
			{
				NombresC, NumDocID, Idpersona, Idempleado, year, idAreaOrganiz, idTipoTrabajador, Estado, AreaOrganizacional, Descripcion,
				Fecha
			};
			spRRHH_FaltasRow.ItemArray = itemArray;
			Rows.Add(spRRHH_FaltasRow);
			return spRRHH_FaltasRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_FaltasDataTable spRRHH_FaltasDataTable = (spRRHH_FaltasDataTable)base.Clone();
			spRRHH_FaltasDataTable.InitVars();
			return spRRHH_FaltasDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_FaltasDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnNombresC = base.Columns["NombresC"];
			columnNumDocID = base.Columns["NumDocID"];
			columnIdpersona = base.Columns["Idpersona"];
			columnIdempleado = base.Columns["Idempleado"];
			columnyear = base.Columns["year"];
			columnidAreaOrganiz = base.Columns["idAreaOrganiz"];
			columnidTipoTrabajador = base.Columns["idTipoTrabajador"];
			columnEstado = base.Columns["Estado"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columnDescripcion = base.Columns["Descripcion"];
			columnFecha = base.Columns["Fecha"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnNombresC = new DataColumn("NombresC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombresC);
			columnNumDocID = new DataColumn("NumDocID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumDocID);
			columnIdpersona = new DataColumn("Idpersona", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIdpersona);
			columnIdempleado = new DataColumn("Idempleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIdempleado);
			columnyear = new DataColumn("year", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnyear);
			columnidAreaOrganiz = new DataColumn("idAreaOrganiz", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidAreaOrganiz);
			columnidTipoTrabajador = new DataColumn("idTipoTrabajador", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidTipoTrabajador);
			columnEstado = new DataColumn("Estado", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEstado);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnDescripcion = new DataColumn("Descripcion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripcion);
			columnFecha = new DataColumn("Fecha", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFecha);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[3] { columnIdpersona, columnIdempleado, columnFecha }, isPrimaryKey: false));
			columnNombresC.ReadOnly = true;
			columnNombresC.MaxLength = 162;
			columnNumDocID.MaxLength = 12;
			columnIdpersona.AllowDBNull = false;
			columnIdempleado.AllowDBNull = false;
			columnyear.AllowDBNull = false;
			columnidAreaOrganiz.AllowDBNull = false;
			columnEstado.MaxLength = 1;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
			columnDescripcion.MaxLength = 30;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_FaltasRow NewspRRHH_FaltasRow()
		{
			return (spRRHH_FaltasRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_FaltasRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_FaltasRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_FaltasRowChanged != null)
			{
				spRRHH_FaltasRowChanged?.Invoke(this, new spRRHH_FaltasRowChangeEvent((spRRHH_FaltasRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_FaltasRowChanging != null)
			{
				spRRHH_FaltasRowChanging?.Invoke(this, new spRRHH_FaltasRowChangeEvent((spRRHH_FaltasRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_FaltasRowDeleted != null)
			{
				spRRHH_FaltasRowDeleted?.Invoke(this, new spRRHH_FaltasRowChangeEvent((spRRHH_FaltasRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_FaltasRowDeleting != null)
			{
				spRRHH_FaltasRowDeleting?.Invoke(this, new spRRHH_FaltasRowChangeEvent((spRRHH_FaltasRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_FaltasRow(spRRHH_FaltasRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_FaltasDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_RepPermisosDataTable : TypedTableBase<spRRHH_RepPermisosRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnNombres;

		private DataColumn columnDescrip_Motivo;

		private DataColumn columnFechaInicio;

		private DataColumn columnFEchaFin;

		private DataColumn columnHora_Sal;

		private DataColumn columnHora_ret;

		private DataColumn columnLugar;

		private DataColumn columnObservaciones;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NombresColumn => columnNombres;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Descrip_MotivoColumn => columnDescrip_Motivo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaInicioColumn => columnFechaInicio;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FEchaFinColumn => columnFEchaFin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Hora_SalColumn => columnHora_Sal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Hora_retColumn => columnHora_ret;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LugarColumn => columnLugar;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ObservacionesColumn => columnObservaciones;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepPermisosRow this[int index] => (spRRHH_RepPermisosRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepPermisosRowChangeEventHandler spRRHH_RepPermisosRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepPermisosRowChangeEventHandler spRRHH_RepPermisosRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepPermisosRowChangeEventHandler spRRHH_RepPermisosRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepPermisosRowChangeEventHandler spRRHH_RepPermisosRowDeleted;

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
		public spRRHH_RepPermisosDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_RepPermisos";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_RepPermisosDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_RepPermisosDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_RepPermisosRow(spRRHH_RepPermisosRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_RepPermisosRow AddspRRHH_RepPermisosRow(string Nombres, string Descrip_Motivo, DateTime FechaInicio, DateTime FEchaFin, string Hora_Sal, string Hora_ret, string Lugar, string Observaciones)
		{
			spRRHH_RepPermisosRow spRRHH_RepPermisosRow = (spRRHH_RepPermisosRow)NewRow();
			object[] itemArray = new object[8] { Nombres, Descrip_Motivo, FechaInicio, FEchaFin, Hora_Sal, Hora_ret, Lugar, Observaciones };
			spRRHH_RepPermisosRow.ItemArray = itemArray;
			Rows.Add(spRRHH_RepPermisosRow);
			return spRRHH_RepPermisosRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_RepPermisosDataTable spRRHH_RepPermisosDataTable = (spRRHH_RepPermisosDataTable)base.Clone();
			spRRHH_RepPermisosDataTable.InitVars();
			return spRRHH_RepPermisosDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_RepPermisosDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnNombres = base.Columns["Nombres"];
			columnDescrip_Motivo = base.Columns["Descrip_Motivo"];
			columnFechaInicio = base.Columns["FechaInicio"];
			columnFEchaFin = base.Columns["FEchaFin"];
			columnHora_Sal = base.Columns["Hora_Sal"];
			columnHora_ret = base.Columns["Hora_ret"];
			columnLugar = base.Columns["Lugar"];
			columnObservaciones = base.Columns["Observaciones"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnNombres = new DataColumn("Nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombres);
			columnDescrip_Motivo = new DataColumn("Descrip_Motivo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescrip_Motivo);
			columnFechaInicio = new DataColumn("FechaInicio", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFechaInicio);
			columnFEchaFin = new DataColumn("FEchaFin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFEchaFin);
			columnHora_Sal = new DataColumn("Hora_Sal", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHora_Sal);
			columnHora_ret = new DataColumn("Hora_ret", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHora_ret);
			columnLugar = new DataColumn("Lugar", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLugar);
			columnObservaciones = new DataColumn("Observaciones", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnObservaciones);
			columnNombres.ReadOnly = true;
			columnNombres.MaxLength = 162;
			columnDescrip_Motivo.MaxLength = 50;
			columnHora_Sal.ReadOnly = true;
			columnHora_Sal.MaxLength = 8;
			columnHora_ret.ReadOnly = true;
			columnHora_ret.MaxLength = 8;
			columnLugar.ReadOnly = true;
			columnLugar.MaxLength = 20;
			columnObservaciones.ReadOnly = true;
			columnObservaciones.MaxLength = 200;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_RepPermisosRow NewspRRHH_RepPermisosRow()
		{
			return (spRRHH_RepPermisosRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_RepPermisosRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_RepPermisosRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_RepPermisosRowChanged != null)
			{
				spRRHH_RepPermisosRowChanged?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_RepPermisosRowChanging != null)
			{
				spRRHH_RepPermisosRowChanging?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_RepPermisosRowDeleted != null)
			{
				spRRHH_RepPermisosRowDeleted?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_RepPermisosRowDeleting != null)
			{
				spRRHH_RepPermisosRowDeleting?.Invoke(this, new spRRHH_RepPermisosRowChangeEvent((spRRHH_RepPermisosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemovespRRHH_RepPermisosRow(spRRHH_RepPermisosRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_RepPermisosDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_RepAsisdiarriaDataTable : TypedTableBase<spRRHH_RepAsisdiarriaRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnnombres;

		private DataColumn columnHoraE;

		private DataColumn columnHoraS;

		private DataColumn columnfecha1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn nombresColumn => columnnombres;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HoraEColumn => columnHoraE;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HoraSColumn => columnHoraS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn fecha1Column => columnfecha1;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepAsisdiarriaRow this[int index] => (spRRHH_RepAsisdiarriaRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepAsisdiarriaRowChangeEventHandler spRRHH_RepAsisdiarriaRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepAsisdiarriaRowChangeEventHandler spRRHH_RepAsisdiarriaRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepAsisdiarriaRowChangeEventHandler spRRHH_RepAsisdiarriaRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_RepAsisdiarriaRowChangeEventHandler spRRHH_RepAsisdiarriaRowDeleted;

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
		public spRRHH_RepAsisdiarriaDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_RepAsisdiarria";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_RepAsisdiarriaDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected spRRHH_RepAsisdiarriaDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_RepAsisdiarriaRow(spRRHH_RepAsisdiarriaRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepAsisdiarriaRow AddspRRHH_RepAsisdiarriaRow(string nombres, string HoraE, string HoraS, string fecha1)
		{
			spRRHH_RepAsisdiarriaRow spRRHH_RepAsisdiarriaRow = (spRRHH_RepAsisdiarriaRow)NewRow();
			object[] itemArray = new object[4] { nombres, HoraE, HoraS, fecha1 };
			spRRHH_RepAsisdiarriaRow.ItemArray = itemArray;
			Rows.Add(spRRHH_RepAsisdiarriaRow);
			return spRRHH_RepAsisdiarriaRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_RepAsisdiarriaDataTable spRRHH_RepAsisdiarriaDataTable = (spRRHH_RepAsisdiarriaDataTable)base.Clone();
			spRRHH_RepAsisdiarriaDataTable.InitVars();
			return spRRHH_RepAsisdiarriaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_RepAsisdiarriaDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnnombres = base.Columns["nombres"];
			columnHoraE = base.Columns["HoraE"];
			columnHoraS = base.Columns["HoraS"];
			columnfecha1 = base.Columns["fecha1"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnnombres = new DataColumn("nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnombres);
			columnHoraE = new DataColumn("HoraE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoraE);
			columnHoraS = new DataColumn("HoraS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoraS);
			columnfecha1 = new DataColumn("fecha1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnfecha1);
			columnnombres.ReadOnly = true;
			columnnombres.MaxLength = 162;
			columnHoraE.ReadOnly = true;
			columnHoraE.MaxLength = 20;
			columnHoraS.ReadOnly = true;
			columnHoraS.MaxLength = 20;
			columnfecha1.ReadOnly = true;
			columnfecha1.MaxLength = 10;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepAsisdiarriaRow NewspRRHH_RepAsisdiarriaRow()
		{
			return (spRRHH_RepAsisdiarriaRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_RepAsisdiarriaRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_RepAsisdiarriaRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_RepAsisdiarriaRowChanged != null)
			{
				spRRHH_RepAsisdiarriaRowChanged?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_RepAsisdiarriaRowChanging != null)
			{
				spRRHH_RepAsisdiarriaRowChanging?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_RepAsisdiarriaRowDeleted != null)
			{
				spRRHH_RepAsisdiarriaRowDeleted?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_RepAsisdiarriaRowDeleting != null)
			{
				spRRHH_RepAsisdiarriaRowDeleting?.Invoke(this, new spRRHH_RepAsisdiarriaRowChangeEvent((spRRHH_RepAsisdiarriaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_RepAsisdiarriaRow(spRRHH_RepAsisdiarriaRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_RepAsisdiarriaDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Report_FechaIngresoDataTable : TypedTableBase<spRRHH_Report_FechaIngresoRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnNombresCompletos;

		private DataColumn columnFechadeIngreso;

		private DataColumn columnaños;

		private DataColumn columnmeses;

		private DataColumn columndias;

		private DataColumn columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NombresCompletosColumn => columnNombresCompletos;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FechadeIngresoColumn => columnFechadeIngreso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn añosColumn => columnaños;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mesesColumn => columnmeses;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn diasColumn => columndias;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_FechaIngresoRow this[int index] => (spRRHH_Report_FechaIngresoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_FechaIngresoRowChangeEventHandler spRRHH_Report_FechaIngresoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_FechaIngresoRowChangeEventHandler spRRHH_Report_FechaIngresoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_FechaIngresoRowChangeEventHandler spRRHH_Report_FechaIngresoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Report_FechaIngresoRowChangeEventHandler spRRHH_Report_FechaIngresoRowDeleted;

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
		public spRRHH_Report_FechaIngresoDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Report_FechaIngreso";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_FechaIngresoDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Report_FechaIngresoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Report_FechaIngresoRow(spRRHH_Report_FechaIngresoRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_FechaIngresoRow AddspRRHH_Report_FechaIngresoRow(string NombresCompletos, string FechadeIngreso, int años, int meses, int dias, string AreaOrganizacional)
		{
			spRRHH_Report_FechaIngresoRow spRRHH_Report_FechaIngresoRow = (spRRHH_Report_FechaIngresoRow)NewRow();
			object[] itemArray = new object[6] { NombresCompletos, FechadeIngreso, años, meses, dias, AreaOrganizacional };
			spRRHH_Report_FechaIngresoRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Report_FechaIngresoRow);
			return spRRHH_Report_FechaIngresoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_Report_FechaIngresoDataTable spRRHH_Report_FechaIngresoDataTable = (spRRHH_Report_FechaIngresoDataTable)base.Clone();
			spRRHH_Report_FechaIngresoDataTable.InitVars();
			return spRRHH_Report_FechaIngresoDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Report_FechaIngresoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnNombresCompletos = base.Columns["NombresCompletos"];
			columnFechadeIngreso = base.Columns["FechadeIngreso"];
			columnaños = base.Columns["años"];
			columnmeses = base.Columns["meses"];
			columndias = base.Columns["dias"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnNombresCompletos = new DataColumn("NombresCompletos", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNombresCompletos);
			columnFechadeIngreso = new DataColumn("FechadeIngreso", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFechadeIngreso);
			columnaños = new DataColumn("años", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnaños);
			columnmeses = new DataColumn("meses", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnmeses);
			columndias = new DataColumn("dias", typeof(int), null, MappingType.Element);
			base.Columns.Add(columndias);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnNombresCompletos.ReadOnly = true;
			columnNombresCompletos.MaxLength = 162;
			columnFechadeIngreso.ReadOnly = true;
			columnFechadeIngreso.MaxLength = 10;
			columnaños.ReadOnly = true;
			columnmeses.ReadOnly = true;
			columndias.ReadOnly = true;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_FechaIngresoRow NewspRRHH_Report_FechaIngresoRow()
		{
			return (spRRHH_Report_FechaIngresoRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Report_FechaIngresoRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Report_FechaIngresoRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Report_FechaIngresoRowChanged != null)
			{
				spRRHH_Report_FechaIngresoRowChanged?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Report_FechaIngresoRowChanging != null)
			{
				spRRHH_Report_FechaIngresoRowChanging?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Report_FechaIngresoRowDeleted != null)
			{
				spRRHH_Report_FechaIngresoRowDeleted?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Report_FechaIngresoRowDeleting != null)
			{
				spRRHH_Report_FechaIngresoRowDeleting?.Invoke(this, new spRRHH_Report_FechaIngresoRowChangeEvent((spRRHH_Report_FechaIngresoRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Report_FechaIngresoRow(spRRHH_Report_FechaIngresoRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Report_FechaIngresoDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_Rep_profesionDataTable : TypedTableBase<spRRHH_Rep_profesionRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnApellido_Paterno;

		private DataColumn columnApellido_Materno;

		private DataColumn columnnombres;

		private DataColumn columnAreaOrganizacional;

		private DataColumn columnProfesion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Apellido_PaternoColumn => columnApellido_Paterno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Apellido_MaternoColumn => columnApellido_Materno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn nombresColumn => columnnombres;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AreaOrganizacionalColumn => columnAreaOrganizacional;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProfesionColumn => columnProfesion;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Rep_profesionRow this[int index] => (spRRHH_Rep_profesionRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_profesionRowChangeEventHandler spRRHH_Rep_profesionRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_profesionRowChangeEventHandler spRRHH_Rep_profesionRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_profesionRowChangeEventHandler spRRHH_Rep_profesionRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_Rep_profesionRowChangeEventHandler spRRHH_Rep_profesionRowDeleted;

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
		public spRRHH_Rep_profesionDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_Rep_profesion";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Rep_profesionDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_Rep_profesionDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddspRRHH_Rep_profesionRow(spRRHH_Rep_profesionRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_profesionRow AddspRRHH_Rep_profesionRow(string Apellido_Paterno, string Apellido_Materno, string nombres, string AreaOrganizacional, string Profesion)
		{
			spRRHH_Rep_profesionRow spRRHH_Rep_profesionRow = (spRRHH_Rep_profesionRow)NewRow();
			object[] itemArray = new object[5] { Apellido_Paterno, Apellido_Materno, nombres, AreaOrganizacional, Profesion };
			spRRHH_Rep_profesionRow.ItemArray = itemArray;
			Rows.Add(spRRHH_Rep_profesionRow);
			return spRRHH_Rep_profesionRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			spRRHH_Rep_profesionDataTable spRRHH_Rep_profesionDataTable = (spRRHH_Rep_profesionDataTable)base.Clone();
			spRRHH_Rep_profesionDataTable.InitVars();
			return spRRHH_Rep_profesionDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_Rep_profesionDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnApellido_Paterno = base.Columns["Apellido_Paterno"];
			columnApellido_Materno = base.Columns["Apellido_Materno"];
			columnnombres = base.Columns["nombres"];
			columnAreaOrganizacional = base.Columns["AreaOrganizacional"];
			columnProfesion = base.Columns["Profesion"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnApellido_Paterno = new DataColumn("Apellido_Paterno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Paterno);
			columnApellido_Materno = new DataColumn("Apellido_Materno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApellido_Materno);
			columnnombres = new DataColumn("nombres", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnnombres);
			columnAreaOrganizacional = new DataColumn("AreaOrganizacional", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAreaOrganizacional);
			columnProfesion = new DataColumn("Profesion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProfesion);
			columnApellido_Paterno.MaxLength = 30;
			columnApellido_Materno.MaxLength = 30;
			columnnombres.MaxLength = 100;
			columnAreaOrganizacional.AllowDBNull = false;
			columnAreaOrganizacional.MaxLength = 200;
			columnProfesion.MaxLength = 80;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_profesionRow NewspRRHH_Rep_profesionRow()
		{
			return (spRRHH_Rep_profesionRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_Rep_profesionRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_Rep_profesionRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_Rep_profesionRowChanged != null)
			{
				spRRHH_Rep_profesionRowChanged?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_Rep_profesionRowChanging != null)
			{
				spRRHH_Rep_profesionRowChanging?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_Rep_profesionRowDeleted != null)
			{
				spRRHH_Rep_profesionRowDeleted?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_Rep_profesionRowDeleting != null)
			{
				spRRHH_Rep_profesionRowDeleting?.Invoke(this, new spRRHH_Rep_profesionRowChangeEvent((spRRHH_Rep_profesionRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_Rep_profesionRow(spRRHH_Rep_profesionRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_Rep_profesionDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class spRRHH_busca_DisciplinaDataTable : TypedTableBase<spRRHH_busca_DisciplinaRow>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private DataColumn columnidComportamiento;

		private DataColumn columnFecha;

		private DataColumn columnidEmpleado;

		private DataColumn columnNumResol;

		private DataColumn columnTitulo;

		private DataColumn columnDescripcion;

		private DataColumn columnTipoCompDescrip;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idComportamientoColumn => columnidComportamiento;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FechaColumn => columnFecha;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idEmpleadoColumn => columnidEmpleado;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumResolColumn => columnNumResol;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TituloColumn => columnTitulo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescripcionColumn => columnDescripcion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TipoCompDescripColumn => columnTipoCompDescrip;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_busca_DisciplinaRow this[int index] => (spRRHH_busca_DisciplinaRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_busca_DisciplinaRowChangeEventHandler spRRHH_busca_DisciplinaRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_busca_DisciplinaRowChangeEventHandler spRRHH_busca_DisciplinaRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_busca_DisciplinaRowChangeEventHandler spRRHH_busca_DisciplinaRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[method: DebuggerNonUserCode]
		public event spRRHH_busca_DisciplinaRowChangeEventHandler spRRHH_busca_DisciplinaRowDeleted;

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
		public spRRHH_busca_DisciplinaDataTable()
		{
			__ENCAddToList(this);
			TableName = "spRRHH_busca_Disciplina";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_busca_DisciplinaDataTable(DataTable table)
		{
			__ENCAddToList(this);
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected spRRHH_busca_DisciplinaDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			__ENCAddToList(this);
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddspRRHH_busca_DisciplinaRow(spRRHH_busca_DisciplinaRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_busca_DisciplinaRow AddspRRHH_busca_DisciplinaRow(int idComportamiento, DateTime Fecha, int idEmpleado, string NumResol, string Titulo, string Descripcion, string TipoCompDescrip)
		{
			spRRHH_busca_DisciplinaRow spRRHH_busca_DisciplinaRow = (spRRHH_busca_DisciplinaRow)NewRow();
			object[] itemArray = new object[7] { idComportamiento, Fecha, idEmpleado, NumResol, Titulo, Descripcion, TipoCompDescrip };
			spRRHH_busca_DisciplinaRow.ItemArray = itemArray;
			Rows.Add(spRRHH_busca_DisciplinaRow);
			return spRRHH_busca_DisciplinaRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_busca_DisciplinaRow FindByidComportamiento(int idComportamiento)
		{
			return (spRRHH_busca_DisciplinaRow)Rows.Find(new object[1] { idComportamiento });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			spRRHH_busca_DisciplinaDataTable spRRHH_busca_DisciplinaDataTable = (spRRHH_busca_DisciplinaDataTable)base.Clone();
			spRRHH_busca_DisciplinaDataTable.InitVars();
			return spRRHH_busca_DisciplinaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new spRRHH_busca_DisciplinaDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnidComportamiento = base.Columns["idComportamiento"];
			columnFecha = base.Columns["Fecha"];
			columnidEmpleado = base.Columns["idEmpleado"];
			columnNumResol = base.Columns["NumResol"];
			columnTitulo = base.Columns["Titulo"];
			columnDescripcion = base.Columns["Descripcion"];
			columnTipoCompDescrip = base.Columns["TipoCompDescrip"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnidComportamiento = new DataColumn("idComportamiento", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidComportamiento);
			columnFecha = new DataColumn("Fecha", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFecha);
			columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnidEmpleado);
			columnNumResol = new DataColumn("NumResol", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNumResol);
			columnTitulo = new DataColumn("Titulo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTitulo);
			columnDescripcion = new DataColumn("Descripcion", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDescripcion);
			columnTipoCompDescrip = new DataColumn("TipoCompDescrip", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTipoCompDescrip);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnidComportamiento }, isPrimaryKey: true));
			columnidComportamiento.AllowDBNull = false;
			columnidComportamiento.Unique = true;
			columnNumResol.MaxLength = 200;
			columnTitulo.MaxLength = 1000;
			columnDescripcion.MaxLength = 2000;
			columnTipoCompDescrip.MaxLength = 8;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_busca_DisciplinaRow NewspRRHH_busca_DisciplinaRow()
		{
			return (spRRHH_busca_DisciplinaRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new spRRHH_busca_DisciplinaRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(spRRHH_busca_DisciplinaRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (spRRHH_busca_DisciplinaRowChanged != null)
			{
				spRRHH_busca_DisciplinaRowChanged?.Invoke(this, new spRRHH_busca_DisciplinaRowChangeEvent((spRRHH_busca_DisciplinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (spRRHH_busca_DisciplinaRowChanging != null)
			{
				spRRHH_busca_DisciplinaRowChanging?.Invoke(this, new spRRHH_busca_DisciplinaRowChangeEvent((spRRHH_busca_DisciplinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (spRRHH_busca_DisciplinaRowDeleted != null)
			{
				spRRHH_busca_DisciplinaRowDeleted?.Invoke(this, new spRRHH_busca_DisciplinaRowChangeEvent((spRRHH_busca_DisciplinaRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (spRRHH_busca_DisciplinaRowDeleting != null)
			{
				spRRHH_busca_DisciplinaRowDeleting?.Invoke(this, new spRRHH_busca_DisciplinaRowChangeEvent((spRRHH_busca_DisciplinaRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovespRRHH_busca_DisciplinaRow(spRRHH_busca_DisciplinaRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet1 dataSet = new DataSet1();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal num = 0m;
			xmlSchemaAny.MinOccurs = num;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			num = 1m;
			xmlSchemaAny2.MinOccurs = num;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "spRRHH_busca_DisciplinaDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class spRRHH_Ficha_ExpLabRow : DataRow
	{
		private spRRHH_Ficha_ExpLabDataTable tablespRRHH_Ficha_ExpLab;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NomInstitucion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab.NomInstitucionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NomInstitucion' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.NomInstitucionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CargoExp
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab.CargoExpColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'CargoExp' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.CargoExpColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaIngresoExp
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab.FechaIngresoExpColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaIngresoExp' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.FechaIngresoExpColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FEchaEgresoExp
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab.FEchaEgresoExpColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FEchaEgresoExp' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.FEchaEgresoExpColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UnidadOrgaExp
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab.UnidadOrgaExpColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'UnidadOrgaExp' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.UnidadOrgaExpColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescriptipoInstitucion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab.DescriptipoInstitucionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescriptipoInstitucion' de la tabla 'spRRHH_Ficha_ExpLab' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab.DescriptipoInstitucionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_ExpLabRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_ExpLab = (spRRHH_Ficha_ExpLabDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNomInstitucionNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.NomInstitucionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNomInstitucionNull()
		{
			this[tablespRRHH_Ficha_ExpLab.NomInstitucionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCargoExpNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.CargoExpColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCargoExpNull()
		{
			this[tablespRRHH_Ficha_ExpLab.CargoExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaIngresoExpNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.FechaIngresoExpColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaIngresoExpNull()
		{
			this[tablespRRHH_Ficha_ExpLab.FechaIngresoExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFEchaEgresoExpNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.FEchaEgresoExpColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFEchaEgresoExpNull()
		{
			this[tablespRRHH_Ficha_ExpLab.FEchaEgresoExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsUnidadOrgaExpNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.UnidadOrgaExpColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUnidadOrgaExpNull()
		{
			this[tablespRRHH_Ficha_ExpLab.UnidadOrgaExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescriptipoInstitucionNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab.DescriptipoInstitucionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescriptipoInstitucionNull()
		{
			this[tablespRRHH_Ficha_ExpLab.DescriptipoInstitucionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Ficha_ExpLab_DatosRow : DataRow
	{
		private spRRHH_Ficha_ExpLab_DatosDataTable tablespRRHH_Ficha_ExpLab_Datos;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.AreaOrganizacionalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AreaOrganizacional' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.AreaOrganizacionalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CondicionLab
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.CondicionLabColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'CondicionLab' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.CondicionLabColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime Fechaingreso
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaingresoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Fechaingreso' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaingresoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FechaIngreEstado
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaIngreEstadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaIngreEstado' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaIngreEstadoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumResoIngreEsta
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreEstaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResoIngreEsta' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreEstaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumResoIngreInstitu
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreInstituColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResoIngreInstitu' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreInstituColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumResolCese
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumResolCeseColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResolCese' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumResolCeseColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaResolCese
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolCeseColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaResolCese' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolCeseColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumResol20530
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumResol20530Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResol20530' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumResol20530Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaResol20530
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaResol20530Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaResol20530' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaResol20530Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumResolPenMen
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumResolPenMenColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResolPenMen' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumResolPenMenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FechaResolPenMen
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolPenMenColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaResolPenMen' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolPenMenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumAutogenSalud
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NumAutogenSaludColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumAutogenSalud' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NumAutogenSaludColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string LeyRegimen
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.LeyRegimenColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'LeyRegimen' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.LeyRegimenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string profesion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.profesionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'profesion' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.profesionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string cargo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.cargoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'cargo' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.cargoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripAFP
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.DescripAFPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripAFP' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.DescripAFPColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaAFP
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_ExpLab_Datos.FechaAFPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaAFP' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.FechaAFPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NroAFP
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_ExpLab_Datos.NroAFPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NroAFP' de la tabla 'spRRHH_Ficha_ExpLab_Datos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_ExpLab_Datos.NroAFPColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_ExpLab_DatosRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_ExpLab_Datos = (spRRHH_Ficha_ExpLab_DatosDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAreaOrganizacionalNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.AreaOrganizacionalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAreaOrganizacionalNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.AreaOrganizacionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCondicionLabNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.CondicionLabColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCondicionLabNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.CondicionLabColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaingresoNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaingresoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaingresoNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaingresoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaIngreEstadoNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaIngreEstadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFechaIngreEstadoNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaIngreEstadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumResoIngreEstaNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreEstaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumResoIngreEstaNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreEstaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumResoIngreInstituNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreInstituColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumResoIngreInstituNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumResoIngreInstituColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumResolCeseNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumResolCeseColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumResolCeseNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumResolCeseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFechaResolCeseNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaResolCeseColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaResolCeseNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolCeseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumResol20530Null()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumResol20530Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumResol20530Null()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumResol20530Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaResol20530Null()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaResol20530Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaResol20530Null()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaResol20530Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumResolPenMenNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumResolPenMenColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumResolPenMenNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumResolPenMenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaResolPenMenNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaResolPenMenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaResolPenMenNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaResolPenMenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumAutogenSaludNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NumAutogenSaludColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumAutogenSaludNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NumAutogenSaludColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLeyRegimenNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.LeyRegimenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLeyRegimenNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.LeyRegimenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsprofesionNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.profesionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetprofesionNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.profesionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscargoNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.cargoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcargoNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.cargoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripAFPNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.DescripAFPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripAFPNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.DescripAFPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaAFPNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.FechaAFPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaAFPNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.FechaAFPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNroAFPNull()
		{
			return IsNull(tablespRRHH_Ficha_ExpLab_Datos.NroAFPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNroAFPNull()
		{
			this[tablespRRHH_Ficha_ExpLab_Datos.NroAFPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Ficha_Det_FamiliarRow : DataRow
	{
		private spRRHH_Ficha_Det_FamiliarDataTable tablespRRHH_Ficha_Det_Familiar;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int edadFamiliar
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Ficha_Det_Familiar.edadFamiliarColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'edadFamiliar' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.edadFamiliarColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NombresFamilia
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar.NombresFamiliaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombresFamilia' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.NombresFamiliaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FamSexo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar.FamSexoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FamSexo' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.FamSexoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripTipoFam
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar.DescripTipoFamColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTipoFam' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.DescripTipoFamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FamGradoInstruc
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar.FamGradoInstrucColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FamGradoInstruc' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.FamGradoInstrucColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripEstCivil
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar.DescripEstCivilColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripEstCivil' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.DescripEstCivilColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool ViveCasa
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Det_Familiar.ViveCasaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'ViveCasa' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.ViveCasaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool LaboraInstitucion
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Det_Familiar.LaboraInstitucionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'LaboraInstitucion' de la tabla 'spRRHH_Ficha_Det_Familiar' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar.LaboraInstitucionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_Det_FamiliarRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Det_Familiar = (spRRHH_Ficha_Det_FamiliarDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsedadFamiliarNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.edadFamiliarColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetedadFamiliarNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.edadFamiliarColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNombresFamiliaNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.NombresFamiliaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNombresFamiliaNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.NombresFamiliaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFamSexoNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.FamSexoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFamSexoNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.FamSexoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripTipoFamNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.DescripTipoFamColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripTipoFamNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.DescripTipoFamColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFamGradoInstrucNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.FamGradoInstrucColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFamGradoInstrucNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.FamGradoInstrucColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripEstCivilNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.DescripEstCivilColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripEstCivilNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.DescripEstCivilColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsViveCasaNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.ViveCasaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetViveCasaNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.ViveCasaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLaboraInstitucionNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar.LaboraInstitucionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLaboraInstitucionNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar.LaboraInstitucionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Ficha_Estudio_RealizadoRow : DataRow
	{
		private spRRHH_Ficha_Estudio_RealizadoDataTable tablespRRHH_Ficha_Estudio_Realizado;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripTipoEst
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Realizado.DescripTipoEstColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTipoEst' de la tabla 'spRRHH_Ficha_Estudio_Realizado' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Realizado.DescripTipoEstColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CentroEstudios
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Realizado.CentroEstudiosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'CentroEstudios' de la tabla 'spRRHH_Ficha_Estudio_Realizado' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Realizado.CentroEstudiosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime AñoInicio
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_Estudio_Realizado.AñoInicioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AñoInicio' de la tabla 'spRRHH_Ficha_Estudio_Realizado' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Realizado.AñoInicioColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime Añotermino
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_Estudio_Realizado.AñoterminoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Añotermino' de la tabla 'spRRHH_Ficha_Estudio_Realizado' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Realizado.AñoterminoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripEstadoEstudio
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripEstadoEstudio' de la tabla 'spRRHH_Ficha_Estudio_Realizado' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudioColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Estudio_RealizadoRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Estudio_Realizado = (spRRHH_Ficha_Estudio_RealizadoDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripTipoEstNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Realizado.DescripTipoEstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripTipoEstNull()
		{
			this[tablespRRHH_Ficha_Estudio_Realizado.DescripTipoEstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCentroEstudiosNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Realizado.CentroEstudiosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCentroEstudiosNull()
		{
			this[tablespRRHH_Ficha_Estudio_Realizado.CentroEstudiosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAñoInicioNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Realizado.AñoInicioColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAñoInicioNull()
		{
			this[tablespRRHH_Ficha_Estudio_Realizado.AñoInicioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAñoterminoNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Realizado.AñoterminoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAñoterminoNull()
		{
			this[tablespRRHH_Ficha_Estudio_Realizado.AñoterminoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripEstadoEstudioNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudioColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripEstadoEstudioNull()
		{
			this[tablespRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Ficha_Estudio_TituloRow : DataRow
	{
		private spRRHH_Ficha_Estudio_TituloDataTable tablespRRHH_Ficha_Estudio_Titulo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumColegiatura
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Titulo.NumColegiaturaColumn]);
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Titulo.NumColegiaturaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DenominacionGrado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Titulo.DenominacionGradoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DenominacionGrado' de la tabla 'spRRHH_Ficha_Estudio_Titulo' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Titulo.DenominacionGradoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Institucion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Titulo.InstitucionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Institucion' de la tabla 'spRRHH_Ficha_Estudio_Titulo' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Titulo.InstitucionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime Fecha
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_Estudio_Titulo.FechaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Fecha' de la tabla 'spRRHH_Ficha_Estudio_Titulo' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Titulo.FechaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int IdEmpleado
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Ficha_Estudio_Titulo.IdEmpleadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'IdEmpleado' de la tabla 'spRRHH_Ficha_Estudio_Titulo' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Titulo.IdEmpleadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_Estudio_TituloRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Estudio_Titulo = (spRRHH_Ficha_Estudio_TituloDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDenominacionGradoNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Titulo.DenominacionGradoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDenominacionGradoNull()
		{
			this[tablespRRHH_Ficha_Estudio_Titulo.DenominacionGradoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsInstitucionNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Titulo.InstitucionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetInstitucionNull()
		{
			this[tablespRRHH_Ficha_Estudio_Titulo.InstitucionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFechaNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Titulo.FechaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaNull()
		{
			this[tablespRRHH_Ficha_Estudio_Titulo.FechaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIdEmpleadoNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Titulo.IdEmpleadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetIdEmpleadoNull()
		{
			this[tablespRRHH_Ficha_Estudio_Titulo.IdEmpleadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Ficha_Estudio_CapacitacionRow : DataRow
	{
		private spRRHH_Ficha_Estudio_CapacitacionDataTable tablespRRHH_Ficha_Estudio_Capacitacion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int IdCapacitacion
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Ficha_Estudio_Capacitacion.IdCapacitacionColumn]);
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.IdCapacitacionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NombreCurso
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Capacitacion.NombreCursoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombreCurso' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.NombreCursoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FechaInicio
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaInicioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaInicio' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaInicioColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaFin
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaFinColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaFin' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaFinColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumHoras
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Capacitacion.NumHorasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumHoras' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.NumHorasColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string InstitucionOrganizadora
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadoraColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'InstitucionOrganizadora' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadoraColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int IdEmpleado
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Ficha_Estudio_Capacitacion.IdEmpleadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'IdEmpleado' de la tabla 'spRRHH_Ficha_Estudio_Capacitacion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Estudio_Capacitacion.IdEmpleadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_Estudio_CapacitacionRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Estudio_Capacitacion = (spRRHH_Ficha_Estudio_CapacitacionDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNombreCursoNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.NombreCursoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNombreCursoNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.NombreCursoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaInicioNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.FechaInicioColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaInicioNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaInicioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaFinNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.FechaFinColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaFinNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.FechaFinColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumHorasNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.NumHorasColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumHorasNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.NumHorasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsInstitucionOrganizadoraNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadoraColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetInstitucionOrganizadoraNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadoraColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIdEmpleadoNull()
		{
			return IsNull(tablespRRHH_Ficha_Estudio_Capacitacion.IdEmpleadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetIdEmpleadoNull()
		{
			this[tablespRRHH_Ficha_Estudio_Capacitacion.IdEmpleadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Report_CuadroPerRow : DataRow
	{
		private spRRHH_Report_CuadroPerDataTable tablespRRHH_Report_CuadroPer;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idTipoTrabajador
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Report_CuadroPer.idTipoTrabajadorColumn]);
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.idTipoTrabajadorColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Descripcion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_CuadroPer.DescripcionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Descripcion' de la tabla 'spRRHH_Report_CuadroPer' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.DescripcionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Codigo
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Report_CuadroPer.CodigoColumn]);
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.CodigoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DNI
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_CuadroPer.DNIColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DNI' de la tabla 'spRRHH_Report_CuadroPer' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.DNIColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NombresCompletos
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_CuadroPer.NombresCompletosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombresCompletos' de la tabla 'spRRHH_Report_CuadroPer' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.NombresCompletosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Report_CuadroPer.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.AreaOrganizacionalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int cargo
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_CuadroPer.cargoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'cargo' de la tabla 'spRRHH_Report_CuadroPer' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.cargoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Estado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_CuadroPer.EstadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Estado' de la tabla 'spRRHH_Report_CuadroPer' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_CuadroPer.EstadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_CuadroPerRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Report_CuadroPer = (spRRHH_Report_CuadroPerDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripcionNull()
		{
			return IsNull(tablespRRHH_Report_CuadroPer.DescripcionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripcionNull()
		{
			this[tablespRRHH_Report_CuadroPer.DescripcionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDNINull()
		{
			return IsNull(tablespRRHH_Report_CuadroPer.DNIColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDNINull()
		{
			this[tablespRRHH_Report_CuadroPer.DNIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNombresCompletosNull()
		{
			return IsNull(tablespRRHH_Report_CuadroPer.NombresCompletosColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNombresCompletosNull()
		{
			this[tablespRRHH_Report_CuadroPer.NombresCompletosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscargoNull()
		{
			return IsNull(tablespRRHH_Report_CuadroPer.cargoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcargoNull()
		{
			this[tablespRRHH_Report_CuadroPer.cargoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsEstadoNull()
		{
			return IsNull(tablespRRHH_Report_CuadroPer.EstadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetEstadoNull()
		{
			this[tablespRRHH_Report_CuadroPer.EstadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Report_OficinaRow : DataRow
	{
		private spRRHH_Report_OficinaDataTable tablespRRHH_Report_Oficina;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idempleado
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Report_Oficina.idempleadoColumn]);
			}
			set
			{
				this[tablespRRHH_Report_Oficina.idempleadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idpersona
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_Oficina.idpersonaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'idpersona' de la tabla 'spRRHH_Report_Oficina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Oficina.idpersonaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string AreaOrganizacional
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Oficina.AreaOrganizacionalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AreaOrganizacional' de la tabla 'spRRHH_Report_Oficina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Oficina.AreaOrganizacionalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Apellido_paterno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Oficina.Apellido_paternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_paterno' de la tabla 'spRRHH_Report_Oficina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Oficina.Apellido_paternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string apellido_materno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Oficina.apellido_maternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'apellido_materno' de la tabla 'spRRHH_Report_Oficina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Oficina.apellido_maternoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Oficina.nombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'nombres' de la tabla 'spRRHH_Report_Oficina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Oficina.nombresColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Report_OficinaRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Report_Oficina = (spRRHH_Report_OficinaDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsidpersonaNull()
		{
			return IsNull(tablespRRHH_Report_Oficina.idpersonaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetidpersonaNull()
		{
			this[tablespRRHH_Report_Oficina.idpersonaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAreaOrganizacionalNull()
		{
			return IsNull(tablespRRHH_Report_Oficina.AreaOrganizacionalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAreaOrganizacionalNull()
		{
			this[tablespRRHH_Report_Oficina.AreaOrganizacionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsApellido_paternoNull()
		{
			return IsNull(tablespRRHH_Report_Oficina.Apellido_paternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_paternoNull()
		{
			this[tablespRRHH_Report_Oficina.Apellido_paternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isapellido_maternoNull()
		{
			return IsNull(tablespRRHH_Report_Oficina.apellido_maternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setapellido_maternoNull()
		{
			this[tablespRRHH_Report_Oficina.apellido_maternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsnombresNull()
		{
			return IsNull(tablespRRHH_Report_Oficina.nombresColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetnombresNull()
		{
			this[tablespRRHH_Report_Oficina.nombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Report_CumpleRow : DataRow
	{
		private spRRHH_Report_CumpleDataTable tablespRRHH_Report_Cumple;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int edadEmpleado
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_Cumple.edadEmpleadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'edadEmpleado' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.edadEmpleadoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NombresCompletos
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Cumple.NombresCompletosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombresCompletos' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.NombresCompletosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Report_Cumple.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Report_Cumple.AreaOrganizacionalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Estado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Cumple.EstadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Estado' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.EstadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Dia
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_Cumple.DiaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Dia' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.DiaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int mes
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_Cumple.mesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'mes' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.mesColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MESletras
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_Cumple.MESletrasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'MESletras' de la tabla 'spRRHH_Report_Cumple' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_Cumple.MESletrasColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_CumpleRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Report_Cumple = (spRRHH_Report_CumpleDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsedadEmpleadoNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.edadEmpleadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetedadEmpleadoNull()
		{
			this[tablespRRHH_Report_Cumple.edadEmpleadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNombresCompletosNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.NombresCompletosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNombresCompletosNull()
		{
			this[tablespRRHH_Report_Cumple.NombresCompletosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEstadoNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.EstadoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEstadoNull()
		{
			this[tablespRRHH_Report_Cumple.EstadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.DiaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaNull()
		{
			this[tablespRRHH_Report_Cumple.DiaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmesNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.mesColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetmesNull()
		{
			this[tablespRRHH_Report_Cumple.mesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMESletrasNull()
		{
			return IsNull(tablespRRHH_Report_Cumple.MESletrasColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMESletrasNull()
		{
			this[tablespRRHH_Report_Cumple.MESletrasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Rep_cargosRow : DataRow
	{
		private spRRHH_Rep_cargosDataTable tablespRRHH_Rep_cargos;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Apellido_Paterno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_cargos.Apellido_PaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Paterno' de la tabla 'spRRHH_Rep_cargos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_cargos.Apellido_PaternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Apellido_Materno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_cargos.Apellido_MaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Materno' de la tabla 'spRRHH_Rep_cargos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_cargos.Apellido_MaternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_cargos.nombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'nombres' de la tabla 'spRRHH_Rep_cargos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_cargos.nombresColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Rep_cargos.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Rep_cargos.AreaOrganizacionalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string cargo
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Rep_cargos.cargoColumn]);
			}
			set
			{
				this[tablespRRHH_Rep_cargos.cargoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Rep_cargosRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Rep_cargos = (spRRHH_Rep_cargosDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsApellido_PaternoNull()
		{
			return IsNull(tablespRRHH_Rep_cargos.Apellido_PaternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_PaternoNull()
		{
			this[tablespRRHH_Rep_cargos.Apellido_PaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApellido_MaternoNull()
		{
			return IsNull(tablespRRHH_Rep_cargos.Apellido_MaternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_MaternoNull()
		{
			this[tablespRRHH_Rep_cargos.Apellido_MaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnombresNull()
		{
			return IsNull(tablespRRHH_Rep_cargos.nombresColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetnombresNull()
		{
			this[tablespRRHH_Rep_cargos.nombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Ficha_Ingreso_EgresoRow : DataRow
	{
		private spRRHH_Ficha_Ingreso_EgresoDataTable tablespRRHH_Ficha_Ingreso_Egreso;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Remuneracion
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.RemuneracionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Remuneracion' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.RemuneracionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal honorarios
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.honorariosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'honorarios' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.honorariosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal AlqPredio
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.AlqPredioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AlqPredio' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.AlqPredioColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal AlqBienes
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.AlqBienesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AlqBienes' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.AlqBienesColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal CapitalesColocados
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.CapitalesColocadosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'CapitalesColocados' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.CapitalesColocadosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal Dietas
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.DietasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Dietas' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.DietasColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal Negocios
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.NegociosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Negocios' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.NegociosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal OtrosIngresos
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosIngresosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'OtrosIngresos' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosIngresosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal IngresoMiembros
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.IngresoMiembrosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'IngresoMiembros' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.IngresoMiembrosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumPersonaAportan
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Ingreso_Egreso.NumPersonaAportanColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumPersonaAportan' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.NumPersonaAportanColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal TotalIngreso
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.TotalIngresoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'TotalIngreso' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.TotalIngresoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Alimentacion
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.AlimentacionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Alimentacion' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.AlimentacionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal vivienda
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.viviendaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'vivienda' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.viviendaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal educacion
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.educacionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'educacion' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.educacionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal salud
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.saludColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'salud' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.saludColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal vestido
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.vestidoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'vestido' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.vestidoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal recreacion
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.recreacionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'recreacion' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.recreacionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal prestamos
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.prestamosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'prestamos' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.prestamosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal transporte
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.transporteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'transporte' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.transporteColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal energiaelec
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.energiaelecColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'energiaelec' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.energiaelecColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal agua
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.aguaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'agua' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.aguaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal bajapolicia
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.bajapoliciaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'bajapolicia' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.bajapoliciaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal telefono
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.telefonoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'telefono' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.telefonoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal seguropriv
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.seguroprivColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'seguropriv' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.seguroprivColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal tarjcredito
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.tarjcreditoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'tarjcredito' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.tarjcreditoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal OtrosEgresos
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosEgresosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'OtrosEgresos' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosEgresosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal TotalEgreso
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(this[tablespRRHH_Ficha_Ingreso_Egreso.TotalEgresoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'TotalEgreso' de la tabla 'spRRHH_Ficha_Ingreso_Egreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Ingreso_Egreso.TotalEgresoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_Ingreso_EgresoRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Ingreso_Egreso = (spRRHH_Ficha_Ingreso_EgresoDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRemuneracionNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.RemuneracionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetRemuneracionNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.RemuneracionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IshonorariosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.honorariosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SethonorariosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.honorariosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAlqPredioNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.AlqPredioColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAlqPredioNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.AlqPredioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAlqBienesNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.AlqBienesColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAlqBienesNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.AlqBienesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCapitalesColocadosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.CapitalesColocadosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCapitalesColocadosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.CapitalesColocadosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDietasNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.DietasColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDietasNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.DietasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNegociosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.NegociosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNegociosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.NegociosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOtrosIngresosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.OtrosIngresosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOtrosIngresosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosIngresosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsIngresoMiembrosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.IngresoMiembrosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIngresoMiembrosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.IngresoMiembrosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumPersonaAportanNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.NumPersonaAportanColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumPersonaAportanNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.NumPersonaAportanColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTotalIngresoNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.TotalIngresoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTotalIngresoNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.TotalIngresoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAlimentacionNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.AlimentacionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAlimentacionNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.AlimentacionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsviviendaNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.viviendaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetviviendaNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.viviendaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IseducacionNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.educacionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SeteducacionNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.educacionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IssaludNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.saludColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetsaludNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.saludColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsvestidoNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.vestidoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetvestidoNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.vestidoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsrecreacionNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.recreacionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetrecreacionNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.recreacionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsprestamosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.prestamosColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetprestamosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.prestamosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstransporteNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.transporteColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettransporteNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.transporteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsenergiaelecNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.energiaelecColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetenergiaelecNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.energiaelecColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsaguaNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.aguaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetaguaNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.aguaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsbajapoliciaNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.bajapoliciaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetbajapoliciaNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.bajapoliciaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstelefonoNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.telefonoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettelefonoNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.telefonoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsseguroprivNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.seguroprivColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetseguroprivNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.seguroprivColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstarjcreditoNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.tarjcreditoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettarjcreditoNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.tarjcreditoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsOtrosEgresosNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.OtrosEgresosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOtrosEgresosNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.OtrosEgresosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTotalEgresoNull()
		{
			return IsNull(tablespRRHH_Ficha_Ingreso_Egreso.TotalEgresoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTotalEgresoNull()
		{
			this[tablespRRHH_Ficha_Ingreso_Egreso.TotalEgresoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Ficha_DatosPersonalesRow : DataRow
	{
		private spRRHH_Ficha_DatosPersonalesDataTable tablespRRHH_Ficha_DatosPersonales;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int edadEmpleado
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Ficha_DatosPersonales.edadEmpleadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'edadEmpleado' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.edadEmpleadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Nombres' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NombresColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Apellido_Paterno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.Apellido_PaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Paterno' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.Apellido_PaternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Apellido_Materno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.Apellido_MaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Materno' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.Apellido_MaternoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string sexo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.sexoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'sexo' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.sexoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumDocId
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NumDocIdColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumDocId' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NumDocIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TipoDoc
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.TipoDocColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'TipoDoc' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.TipoDocColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Nacionalidad
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NacionalidadColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Nacionalidad' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NacionalidadColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaNacimiento
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_DatosPersonales.FechaNacimientoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaNacimiento' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.FechaNacimientoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Telefono
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.TelefonoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Telefono' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.TelefonoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Fax
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.FaxColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Fax' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.FaxColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumCelular
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NumCelularColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumCelular' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NumCelularColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FonoCentroLab
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.FonoCentroLabColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FonoCentroLab' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.FonoCentroLabColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string EstadoCivil
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.EstadoCivilColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'EstadoCivil' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.EstadoCivilColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Discapacidad
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.DiscapacidadColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Discapacidad' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.DiscapacidadColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string gradoInstruccion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.gradoInstruccionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'gradoInstruccion' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.gradoInstruccionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string desdepartamento
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.desdepartamentoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'desdepartamento' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.desdepartamentoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string desprovincia
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.desprovinciaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'desprovincia' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.desprovinciaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string desdistrito
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.desdistritoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'desdistrito' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.desdistritoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string depCasa
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.depCasaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'depCasa' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.depCasaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ProvCasa
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.ProvCasaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'ProvCasa' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.ProvCasaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DistCasa
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.DistCasaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DistCasa' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.DistCasaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string direccion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.direccionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'direccion' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.direccionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumRUC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NumRUCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumRUC' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NumRUCColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumLibretaMilitar
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NumLibretaMilitarColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumLibretaMilitar' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NumLibretaMilitarColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public byte[] foto
		{
			get
			{
				try
				{
					return (byte[])this[tablespRRHH_Ficha_DatosPersonales.fotoColumn];
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'foto' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.fotoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idempleado
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Ficha_DatosPersonales.idempleadoColumn]);
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.idempleadoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaRegistro
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Ficha_DatosPersonales.FechaRegistroColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaRegistro' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.FechaRegistroColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ExpSocial
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.ExpSocialColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'ExpSocial' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.ExpSocialColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string brevete
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.breveteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'brevete' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.breveteColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripTS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.DescripTSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTS' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.DescripTSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Descripvivecon
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.DescripviveconColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Descripvivecon' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.DescripviveconColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool JefeHogar
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_DatosPersonales.JefeHogarColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'JefeHogar' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.JefeHogarColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CargaFam
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.CargaFamColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'CargaFam' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.CargaFamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Numhijos
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.NumhijosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Numhijos' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.NumhijosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ObsFam
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.ObsFamColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'ObsFam' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.ObsFamColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TipoFamDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.TipoFamDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'TipoFamDescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.TipoFamDescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string relacParejaDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.relacParejaDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'relacParejaDescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.relacParejaDescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string RelacPHDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.RelacPHDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'RelacPHDescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.RelacPHDescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string RelacHermanoDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.RelacHermanoDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'RelacHermanoDescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.RelacHermanoDescripColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string com1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.com1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'com1' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.com1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string com2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.com2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'com2' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.com2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string afec1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.afec1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'afec1' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.afec1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string afec2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.afec2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'afec2' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.afec2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string decis1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.decis1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'decis1' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.decis1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string decis2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.decis2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'decis2' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.decis2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string soc1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.soc1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'soc1' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.soc1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string soc2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.soc2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'soc2' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.soc2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string soc3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.soc3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'soc3' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.soc3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string respues1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.respues1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'respues1' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.respues1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string respues2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.respues2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'respues2' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.respues2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string respues3
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.respues3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'respues3' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.respues3Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PrincipProblemas
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.PrincipProblemasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'PrincipProblemas' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.PrincipProblemasColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PropMejoraInstitu
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.PropMejoraInstituColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'PropMejoraInstitu' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.PropMejoraInstituColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string hobby
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.hobbyColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'hobby' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.hobbyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ActRecreaInstitu
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.ActRecreaInstituColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'ActRecreaInstitu' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.ActRecreaInstituColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string AcudeEnfermDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.AcudeEnfermDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'AcudeEnfermDescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.AcudeEnfermDescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool enfercronica
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_DatosPersonales.enfercronicaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'enfercronica' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.enfercronicaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string enfercronicadescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.enfercronicadescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'enfercronicadescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.enfercronicadescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool famdiscapacidad
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_DatosPersonales.famdiscapacidadColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'famdiscapacidad' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.famdiscapacidadColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string famdiscapdescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.famdiscapdescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'famdiscapdescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.famdiscapdescripColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool alergico
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_DatosPersonales.alergicoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'alergico' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.alergicoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string alergicodescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_DatosPersonales.alergicodescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'alergicodescrip' de la tabla 'spRRHH_Ficha_DatosPersonales' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_DatosPersonales.alergicodescripColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Ficha_DatosPersonalesRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_DatosPersonales = (spRRHH_Ficha_DatosPersonalesDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsedadEmpleadoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.edadEmpleadoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetedadEmpleadoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.edadEmpleadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNombresNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NombresColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNombresNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApellido_PaternoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.Apellido_PaternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_PaternoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.Apellido_PaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApellido_MaternoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.Apellido_MaternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_MaternoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.Apellido_MaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IssexoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.sexoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetsexoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.sexoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumDocIdNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NumDocIdColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumDocIdNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NumDocIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTipoDocNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.TipoDocColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTipoDocNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.TipoDocColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNacionalidadNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NacionalidadColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNacionalidadNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NacionalidadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaNacimientoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.FechaNacimientoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFechaNacimientoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.FechaNacimientoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTelefonoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.TelefonoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTelefonoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.TelefonoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFaxNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.FaxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFaxNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumCelularNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NumCelularColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumCelularNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NumCelularColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFonoCentroLabNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.FonoCentroLabColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFonoCentroLabNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.FonoCentroLabColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEstadoCivilNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.EstadoCivilColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEstadoCivilNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.EstadoCivilColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiscapacidadNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.DiscapacidadColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDiscapacidadNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.DiscapacidadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsgradoInstruccionNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.gradoInstruccionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetgradoInstruccionNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.gradoInstruccionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdesdepartamentoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.desdepartamentoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdesdepartamentoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.desdepartamentoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdesprovinciaNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.desprovinciaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdesprovinciaNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.desprovinciaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdesdistritoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.desdistritoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdesdistritoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.desdistritoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdepCasaNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.depCasaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdepCasaNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.depCasaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsProvCasaNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.ProvCasaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetProvCasaNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.ProvCasaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDistCasaNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.DistCasaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDistCasaNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.DistCasaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdireccionNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.direccionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdireccionNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.direccionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumRUCNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NumRUCColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumRUCNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NumRUCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumLibretaMilitarNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NumLibretaMilitarColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumLibretaMilitarNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NumLibretaMilitarColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsfotoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.fotoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetfotoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.fotoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFechaRegistroNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.FechaRegistroColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFechaRegistroNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.FechaRegistroColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsExpSocialNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.ExpSocialColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetExpSocialNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.ExpSocialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsbreveteNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.breveteColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetbreveteNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.breveteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripTSNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.DescripTSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripTSNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.DescripTSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripviveconNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.DescripviveconColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripviveconNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.DescripviveconColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsJefeHogarNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.JefeHogarColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetJefeHogarNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.JefeHogarColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCargaFamNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.CargaFamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCargaFamNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.CargaFamColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumhijosNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.NumhijosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumhijosNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.NumhijosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsObsFamNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.ObsFamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetObsFamNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.ObsFamColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTipoFamDescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.TipoFamDescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTipoFamDescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.TipoFamDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsrelacParejaDescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.relacParejaDescripColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetrelacParejaDescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.relacParejaDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsRelacPHDescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.RelacPHDescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetRelacPHDescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.RelacPHDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRelacHermanoDescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.RelacHermanoDescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetRelacHermanoDescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.RelacHermanoDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Iscom1Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.com1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setcom1Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.com1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Iscom2Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.com2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setcom2Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.com2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isafec1Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.afec1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setafec1Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.afec1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isafec2Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.afec2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setafec2Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.afec2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isdecis1Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.decis1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdecis1Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.decis1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isdecis2Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.decis2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdecis2Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.decis2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Issoc1Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.soc1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setsoc1Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.soc1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Issoc2Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.soc2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setsoc2Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.soc2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Issoc3Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.soc3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setsoc3Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.soc3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isrespues1Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.respues1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setrespues1Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.respues1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isrespues2Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.respues2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setrespues2Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.respues2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isrespues3Null()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.respues3Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setrespues3Null()
		{
			this[tablespRRHH_Ficha_DatosPersonales.respues3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPrincipProblemasNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.PrincipProblemasColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPrincipProblemasNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.PrincipProblemasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPropMejoraInstituNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.PropMejoraInstituColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPropMejoraInstituNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.PropMejoraInstituColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IshobbyNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.hobbyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SethobbyNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.hobbyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsActRecreaInstituNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.ActRecreaInstituColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetActRecreaInstituNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.ActRecreaInstituColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAcudeEnfermDescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.AcudeEnfermDescripColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAcudeEnfermDescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.AcudeEnfermDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsenfercronicaNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.enfercronicaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetenfercronicaNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.enfercronicaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsenfercronicadescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.enfercronicadescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetenfercronicadescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.enfercronicadescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsfamdiscapacidadNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.famdiscapacidadColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetfamdiscapacidadNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.famdiscapacidadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsfamdiscapdescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.famdiscapdescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetfamdiscapdescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.famdiscapdescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsalergicoNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.alergicoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetalergicoNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.alergicoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsalergicodescripNull()
		{
			return IsNull(tablespRRHH_Ficha_DatosPersonales.alergicodescripColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetalergicodescripNull()
		{
			this[tablespRRHH_Ficha_DatosPersonales.alergicodescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Ficha_Det_Familiar_SaludRow : DataRow
	{
		private spRRHH_Ficha_Det_Familiar_SaludDataTable tablespRRHH_Ficha_Det_Familiar_Salud;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numdocid
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.numdocidColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'numdocid' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.numdocidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripTipoFam
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.DescripTipoFamColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTipoFam' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.DescripTipoFamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string enfermedad
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.enfermedadColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'enfermedad' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.enfermedadColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string tiempoenfermedad
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedadColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'tiempoenfermedad' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedadColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numautogensalud
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.numautogensaludColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'numautogensalud' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.numautogensaludColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string descripts
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Det_Familiar_Salud.descriptsColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'descripts' de la tabla 'spRRHH_Ficha_Det_Familiar_Salud' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Det_Familiar_Salud.descriptsColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_Det_Familiar_SaludRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Det_Familiar_Salud = (spRRHH_Ficha_Det_Familiar_SaludDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnumdocidNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.numdocidColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetnumdocidNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.numdocidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripTipoFamNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.DescripTipoFamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripTipoFamNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.DescripTipoFamColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsenfermedadNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.enfermedadColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetenfermedadNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.enfermedadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstiempoenfermedadNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedadColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettiempoenfermedadNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsnumautogensaludNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.numautogensaludColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetnumautogensaludNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.numautogensaludColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdescriptsNull()
		{
			return IsNull(tablespRRHH_Ficha_Det_Familiar_Salud.descriptsColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdescriptsNull()
		{
			this[tablespRRHH_Ficha_Det_Familiar_Salud.descriptsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Ficha_ViviendaRow : DataRow
	{
		private spRRHH_Ficha_ViviendaDataTable tablespRRHH_Ficha_Vivienda;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DescripTenencia
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripTenenciaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTenencia' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripTenenciaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripTipo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripTipoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripTipo' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripTipoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripMaterial
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripMaterialColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripMaterial' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripMaterialColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripConserva
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripConservaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripConserva' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripConservaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumDormitorio
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.NumDormitorioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumDormitorio' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.NumDormitorioColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumServHig
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.NumServHigColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumServHig' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.NumServHigColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripUbicacion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripUbicacionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripUbicacion' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripUbicacionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripAlumbrado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripAlumbradoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripAlumbrado' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripAlumbradoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string otroalumbrado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.otroalumbradoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'otroalumbrado' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.otroalumbradoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string descripAgua
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.descripAguaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'descripAgua' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.descripAguaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string OtroAgua
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.OtroAguaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'OtroAgua' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.OtroAguaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DescripExcretas
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.DescripExcretasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'DescripExcretas' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.DescripExcretasColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string OtroExcreta
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.OtroExcretaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'OtroExcreta' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.OtroExcretaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool telefono
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Vivienda.telefonoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'telefono' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.telefonoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool cable
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Vivienda.cableColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'cable' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.cableColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool internet
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Vivienda.internetColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'internet' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.internetColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool otros
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tablespRRHH_Ficha_Vivienda.otrosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'otros' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.otrosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumCompart
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.NumCompartColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumCompart' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.NumCompartColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumPerDorm
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.NumPerDormColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumPerDorm' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.NumPerDormColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string observacion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Ficha_Vivienda.observacionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'observacion' de la tabla 'spRRHH_Ficha_Vivienda' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Ficha_Vivienda.observacionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_Ficha_ViviendaRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Ficha_Vivienda = (spRRHH_Ficha_ViviendaDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripTenenciaNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripTenenciaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripTenenciaNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripTenenciaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripTipoNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripTipoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripTipoNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripTipoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripMaterialNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripMaterialColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripMaterialNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripMaterialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripConservaNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripConservaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripConservaNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripConservaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumDormitorioNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.NumDormitorioColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumDormitorioNull()
		{
			this[tablespRRHH_Ficha_Vivienda.NumDormitorioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumServHigNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.NumServHigColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumServHigNull()
		{
			this[tablespRRHH_Ficha_Vivienda.NumServHigColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripUbicacionNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripUbicacionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripUbicacionNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripUbicacionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDescripAlumbradoNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripAlumbradoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripAlumbradoNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripAlumbradoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsotroalumbradoNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.otroalumbradoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetotroalumbradoNull()
		{
			this[tablespRRHH_Ficha_Vivienda.otroalumbradoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdescripAguaNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.descripAguaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdescripAguaNull()
		{
			this[tablespRRHH_Ficha_Vivienda.descripAguaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOtroAguaNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.OtroAguaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetOtroAguaNull()
		{
			this[tablespRRHH_Ficha_Vivienda.OtroAguaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripExcretasNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.DescripExcretasColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripExcretasNull()
		{
			this[tablespRRHH_Ficha_Vivienda.DescripExcretasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOtroExcretaNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.OtroExcretaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOtroExcretaNull()
		{
			this[tablespRRHH_Ficha_Vivienda.OtroExcretaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstelefonoNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.telefonoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettelefonoNull()
		{
			this[tablespRRHH_Ficha_Vivienda.telefonoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscableNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.cableColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcableNull()
		{
			this[tablespRRHH_Ficha_Vivienda.cableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsinternetNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.internetColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetinternetNull()
		{
			this[tablespRRHH_Ficha_Vivienda.internetColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsotrosNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.otrosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetotrosNull()
		{
			this[tablespRRHH_Ficha_Vivienda.otrosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumCompartNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.NumCompartColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumCompartNull()
		{
			this[tablespRRHH_Ficha_Vivienda.NumCompartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumPerDormNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.NumPerDormColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumPerDormNull()
		{
			this[tablespRRHH_Ficha_Vivienda.NumPerDormColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsobservacionNull()
		{
			return IsNull(tablespRRHH_Ficha_Vivienda.observacionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetobservacionNull()
		{
			this[tablespRRHH_Ficha_Vivienda.observacionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_FaltasRow : DataRow
	{
		private spRRHH_FaltasDataTable tablespRRHH_Faltas;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NombresC
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Faltas.NombresCColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombresC' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.NombresCColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumDocID
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Faltas.NumDocIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumDocID' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.NumDocIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Idpersona
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Faltas.IdpersonaColumn]);
			}
			set
			{
				this[tablespRRHH_Faltas.IdpersonaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Idempleado
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Faltas.IdempleadoColumn]);
			}
			set
			{
				this[tablespRRHH_Faltas.IdempleadoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int year
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Faltas.yearColumn]);
			}
			set
			{
				this[tablespRRHH_Faltas.yearColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idAreaOrganiz
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_Faltas.idAreaOrganizColumn]);
			}
			set
			{
				this[tablespRRHH_Faltas.idAreaOrganizColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idTipoTrabajador
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Faltas.idTipoTrabajadorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'idTipoTrabajador' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.idTipoTrabajadorColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Estado
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Faltas.EstadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Estado' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.EstadoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Faltas.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Faltas.AreaOrganizacionalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Descripcion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Faltas.DescripcionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Descripcion' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.DescripcionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime Fecha
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_Faltas.FechaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Fecha' de la tabla 'spRRHH_Faltas' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Faltas.FechaColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_FaltasRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Faltas = (spRRHH_FaltasDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNombresCNull()
		{
			return IsNull(tablespRRHH_Faltas.NombresCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNombresCNull()
		{
			this[tablespRRHH_Faltas.NombresCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumDocIDNull()
		{
			return IsNull(tablespRRHH_Faltas.NumDocIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumDocIDNull()
		{
			this[tablespRRHH_Faltas.NumDocIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsidTipoTrabajadorNull()
		{
			return IsNull(tablespRRHH_Faltas.idTipoTrabajadorColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetidTipoTrabajadorNull()
		{
			this[tablespRRHH_Faltas.idTipoTrabajadorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEstadoNull()
		{
			return IsNull(tablespRRHH_Faltas.EstadoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEstadoNull()
		{
			this[tablespRRHH_Faltas.EstadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripcionNull()
		{
			return IsNull(tablespRRHH_Faltas.DescripcionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescripcionNull()
		{
			this[tablespRRHH_Faltas.DescripcionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsFechaNull()
		{
			return IsNull(tablespRRHH_Faltas.FechaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFechaNull()
		{
			this[tablespRRHH_Faltas.FechaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_RepPermisosRow : DataRow
	{
		private spRRHH_RepPermisosDataTable tablespRRHH_RepPermisos;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.NombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Nombres' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.NombresColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Descrip_Motivo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.Descrip_MotivoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Descrip_Motivo' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.Descrip_MotivoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FechaInicio
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_RepPermisos.FechaInicioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechaInicio' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.FechaInicioColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FEchaFin
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_RepPermisos.FEchaFinColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FEchaFin' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.FEchaFinColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Hora_Sal
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.Hora_SalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Hora_Sal' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.Hora_SalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Hora_ret
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.Hora_retColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Hora_ret' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.Hora_retColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Lugar
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.LugarColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Lugar' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.LugarColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Observaciones
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepPermisos.ObservacionesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Observaciones' de la tabla 'spRRHH_RepPermisos' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepPermisos.ObservacionesColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_RepPermisosRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_RepPermisos = (spRRHH_RepPermisosDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNombresNull()
		{
			return IsNull(tablespRRHH_RepPermisos.NombresColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNombresNull()
		{
			this[tablespRRHH_RepPermisos.NombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescrip_MotivoNull()
		{
			return IsNull(tablespRRHH_RepPermisos.Descrip_MotivoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDescrip_MotivoNull()
		{
			this[tablespRRHH_RepPermisos.Descrip_MotivoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaInicioNull()
		{
			return IsNull(tablespRRHH_RepPermisos.FechaInicioColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaInicioNull()
		{
			this[tablespRRHH_RepPermisos.FechaInicioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFEchaFinNull()
		{
			return IsNull(tablespRRHH_RepPermisos.FEchaFinColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFEchaFinNull()
		{
			this[tablespRRHH_RepPermisos.FEchaFinColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHora_SalNull()
		{
			return IsNull(tablespRRHH_RepPermisos.Hora_SalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHora_SalNull()
		{
			this[tablespRRHH_RepPermisos.Hora_SalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHora_retNull()
		{
			return IsNull(tablespRRHH_RepPermisos.Hora_retColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHora_retNull()
		{
			this[tablespRRHH_RepPermisos.Hora_retColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLugarNull()
		{
			return IsNull(tablespRRHH_RepPermisos.LugarColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLugarNull()
		{
			this[tablespRRHH_RepPermisos.LugarColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsObservacionesNull()
		{
			return IsNull(tablespRRHH_RepPermisos.ObservacionesColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetObservacionesNull()
		{
			this[tablespRRHH_RepPermisos.ObservacionesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_RepAsisdiarriaRow : DataRow
	{
		private spRRHH_RepAsisdiarriaDataTable tablespRRHH_RepAsisdiarria;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepAsisdiarria.nombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'nombres' de la tabla 'spRRHH_RepAsisdiarria' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepAsisdiarria.nombresColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HoraE
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepAsisdiarria.HoraEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'HoraE' de la tabla 'spRRHH_RepAsisdiarria' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepAsisdiarria.HoraEColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HoraS
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepAsisdiarria.HoraSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'HoraS' de la tabla 'spRRHH_RepAsisdiarria' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepAsisdiarria.HoraSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string fecha1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_RepAsisdiarria.fecha1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'fecha1' de la tabla 'spRRHH_RepAsisdiarria' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_RepAsisdiarria.fecha1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_RepAsisdiarriaRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_RepAsisdiarria = (spRRHH_RepAsisdiarriaDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnombresNull()
		{
			return IsNull(tablespRRHH_RepAsisdiarria.nombresColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetnombresNull()
		{
			this[tablespRRHH_RepAsisdiarria.nombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHoraENull()
		{
			return IsNull(tablespRRHH_RepAsisdiarria.HoraEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHoraENull()
		{
			this[tablespRRHH_RepAsisdiarria.HoraEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHoraSNull()
		{
			return IsNull(tablespRRHH_RepAsisdiarria.HoraSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetHoraSNull()
		{
			this[tablespRRHH_RepAsisdiarria.HoraSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isfecha1Null()
		{
			return IsNull(tablespRRHH_RepAsisdiarria.fecha1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setfecha1Null()
		{
			this[tablespRRHH_RepAsisdiarria.fecha1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_Report_FechaIngresoRow : DataRow
	{
		private spRRHH_Report_FechaIngresoDataTable tablespRRHH_Report_FechaIngreso;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NombresCompletos
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_FechaIngreso.NombresCompletosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NombresCompletos' de la tabla 'spRRHH_Report_FechaIngreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.NombresCompletosColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FechadeIngreso
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Report_FechaIngreso.FechadeIngresoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'FechadeIngreso' de la tabla 'spRRHH_Report_FechaIngreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.FechadeIngresoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int años
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_FechaIngreso.añosColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'años' de la tabla 'spRRHH_Report_FechaIngreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.añosColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int meses
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_FechaIngreso.mesesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'meses' de la tabla 'spRRHH_Report_FechaIngreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.mesesColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int dias
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_Report_FechaIngreso.diasColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'dias' de la tabla 'spRRHH_Report_FechaIngreso' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.diasColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Report_FechaIngreso.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Report_FechaIngreso.AreaOrganizacionalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Report_FechaIngresoRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Report_FechaIngreso = (spRRHH_Report_FechaIngresoDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNombresCompletosNull()
		{
			return IsNull(tablespRRHH_Report_FechaIngreso.NombresCompletosColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNombresCompletosNull()
		{
			this[tablespRRHH_Report_FechaIngreso.NombresCompletosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechadeIngresoNull()
		{
			return IsNull(tablespRRHH_Report_FechaIngreso.FechadeIngresoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechadeIngresoNull()
		{
			this[tablespRRHH_Report_FechaIngreso.FechadeIngresoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsañosNull()
		{
			return IsNull(tablespRRHH_Report_FechaIngreso.añosColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetañosNull()
		{
			this[tablespRRHH_Report_FechaIngreso.añosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsmesesNull()
		{
			return IsNull(tablespRRHH_Report_FechaIngreso.mesesColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetmesesNull()
		{
			this[tablespRRHH_Report_FechaIngreso.mesesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiasNull()
		{
			return IsNull(tablespRRHH_Report_FechaIngreso.diasColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiasNull()
		{
			this[tablespRRHH_Report_FechaIngreso.diasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class spRRHH_Rep_profesionRow : DataRow
	{
		private spRRHH_Rep_profesionDataTable tablespRRHH_Rep_profesion;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Apellido_Paterno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_profesion.Apellido_PaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Paterno' de la tabla 'spRRHH_Rep_profesion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_profesion.Apellido_PaternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Apellido_Materno
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_profesion.Apellido_MaternoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Apellido_Materno' de la tabla 'spRRHH_Rep_profesion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_profesion.Apellido_MaternoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string nombres
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_profesion.nombresColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'nombres' de la tabla 'spRRHH_Rep_profesion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_profesion.nombresColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string AreaOrganizacional
		{
			get
			{
				return Conversions.ToString(this[tablespRRHH_Rep_profesion.AreaOrganizacionalColumn]);
			}
			set
			{
				this[tablespRRHH_Rep_profesion.AreaOrganizacionalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Profesion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_Rep_profesion.ProfesionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Profesion' de la tabla 'spRRHH_Rep_profesion' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_Rep_profesion.ProfesionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal spRRHH_Rep_profesionRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_Rep_profesion = (spRRHH_Rep_profesionDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApellido_PaternoNull()
		{
			return IsNull(tablespRRHH_Rep_profesion.Apellido_PaternoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetApellido_PaternoNull()
		{
			this[tablespRRHH_Rep_profesion.Apellido_PaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApellido_MaternoNull()
		{
			return IsNull(tablespRRHH_Rep_profesion.Apellido_MaternoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApellido_MaternoNull()
		{
			this[tablespRRHH_Rep_profesion.Apellido_MaternoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnombresNull()
		{
			return IsNull(tablespRRHH_Rep_profesion.nombresColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetnombresNull()
		{
			this[tablespRRHH_Rep_profesion.nombresColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsProfesionNull()
		{
			return IsNull(tablespRRHH_Rep_profesion.ProfesionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetProfesionNull()
		{
			this[tablespRRHH_Rep_profesion.ProfesionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class spRRHH_busca_DisciplinaRow : DataRow
	{
		private spRRHH_busca_DisciplinaDataTable tablespRRHH_busca_Disciplina;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idComportamiento
		{
			get
			{
				return Conversions.ToInteger(this[tablespRRHH_busca_Disciplina.idComportamientoColumn]);
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.idComportamientoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime Fecha
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tablespRRHH_busca_Disciplina.FechaColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Fecha' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.FechaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idEmpleado
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablespRRHH_busca_Disciplina.idEmpleadoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'idEmpleado' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.idEmpleadoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NumResol
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_busca_Disciplina.NumResolColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'NumResol' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.NumResolColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Titulo
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_busca_Disciplina.TituloColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Titulo' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.TituloColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Descripcion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_busca_Disciplina.DescripcionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'Descripcion' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.DescripcionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TipoCompDescrip
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablespRRHH_busca_Disciplina.TipoCompDescripColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("El valor de la columna 'TipoCompDescrip' de la tabla 'spRRHH_busca_Disciplina' es DBNull.", innerException);
				}
			}
			set
			{
				this[tablespRRHH_busca_Disciplina.TipoCompDescripColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal spRRHH_busca_DisciplinaRow(DataRowBuilder rb)
			: base(rb)
		{
			tablespRRHH_busca_Disciplina = (spRRHH_busca_DisciplinaDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFechaNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.FechaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFechaNull()
		{
			this[tablespRRHH_busca_Disciplina.FechaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsidEmpleadoNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.idEmpleadoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetidEmpleadoNull()
		{
			this[tablespRRHH_busca_Disciplina.idEmpleadoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNumResolNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.NumResolColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumResolNull()
		{
			this[tablespRRHH_busca_Disciplina.NumResolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTituloNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.TituloColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTituloNull()
		{
			this[tablespRRHH_busca_Disciplina.TituloColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescripcionNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.DescripcionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescripcionNull()
		{
			this[tablespRRHH_busca_Disciplina.DescripcionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTipoCompDescripNull()
		{
			return IsNull(tablespRRHH_busca_Disciplina.TipoCompDescripColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetTipoCompDescripNull()
		{
			this[tablespRRHH_busca_Disciplina.TipoCompDescripColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_ExpLabRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_ExpLabRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLabRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLabRowChangeEvent(spRRHH_Ficha_ExpLabRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_ExpLab_DatosRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_ExpLab_DatosRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLab_DatosRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ExpLab_DatosRowChangeEvent(spRRHH_Ficha_ExpLab_DatosRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Det_FamiliarRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Det_FamiliarRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Det_FamiliarRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Det_FamiliarRowChangeEvent(spRRHH_Ficha_Det_FamiliarRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Estudio_RealizadoRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Estudio_RealizadoRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_RealizadoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_Estudio_RealizadoRowChangeEvent(spRRHH_Ficha_Estudio_RealizadoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Estudio_TituloRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Estudio_TituloRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_TituloRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_TituloRowChangeEvent(spRRHH_Ficha_Estudio_TituloRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Estudio_CapacitacionRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Estudio_CapacitacionRowChangeEvent(spRRHH_Ficha_Estudio_CapacitacionRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Report_CuadroPerRowChangeEvent : EventArgs
	{
		private spRRHH_Report_CuadroPerRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_CuadroPerRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_CuadroPerRowChangeEvent(spRRHH_Report_CuadroPerRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Report_OficinaRowChangeEvent : EventArgs
	{
		private spRRHH_Report_OficinaRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_OficinaRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Report_OficinaRowChangeEvent(spRRHH_Report_OficinaRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Report_CumpleRowChangeEvent : EventArgs
	{
		private spRRHH_Report_CumpleRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_CumpleRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_CumpleRowChangeEvent(spRRHH_Report_CumpleRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Rep_cargosRowChangeEvent : EventArgs
	{
		private spRRHH_Rep_cargosRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_cargosRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_cargosRowChangeEvent(spRRHH_Rep_cargosRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Ingreso_EgresoRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Ingreso_EgresoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Ingreso_EgresoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Ingreso_EgresoRowChangeEvent(spRRHH_Ficha_Ingreso_EgresoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_DatosPersonalesRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_DatosPersonalesRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_DatosPersonalesRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_DatosPersonalesRowChangeEvent(spRRHH_Ficha_DatosPersonalesRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_Det_Familiar_SaludRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_Familiar_SaludRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_Det_Familiar_SaludRowChangeEvent(spRRHH_Ficha_Det_Familiar_SaludRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Ficha_ViviendaRowChangeEvent : EventArgs
	{
		private spRRHH_Ficha_ViviendaRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Ficha_ViviendaRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Ficha_ViviendaRowChangeEvent(spRRHH_Ficha_ViviendaRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_FaltasRowChangeEvent : EventArgs
	{
		private spRRHH_FaltasRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_FaltasRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_FaltasRowChangeEvent(spRRHH_FaltasRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_RepPermisosRowChangeEvent : EventArgs
	{
		private spRRHH_RepPermisosRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepPermisosRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepPermisosRowChangeEvent(spRRHH_RepPermisosRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_RepAsisdiarriaRowChangeEvent : EventArgs
	{
		private spRRHH_RepAsisdiarriaRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_RepAsisdiarriaRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_RepAsisdiarriaRowChangeEvent(spRRHH_RepAsisdiarriaRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Report_FechaIngresoRowChangeEvent : EventArgs
	{
		private spRRHH_Report_FechaIngresoRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_FechaIngresoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Report_FechaIngresoRowChangeEvent(spRRHH_Report_FechaIngresoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_Rep_profesionRowChangeEvent : EventArgs
	{
		private spRRHH_Rep_profesionRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public spRRHH_Rep_profesionRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_Rep_profesionRowChangeEvent(spRRHH_Rep_profesionRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class spRRHH_busca_DisciplinaRowChangeEvent : EventArgs
	{
		private spRRHH_busca_DisciplinaRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_busca_DisciplinaRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public spRRHH_busca_DisciplinaRowChangeEvent(spRRHH_busca_DisciplinaRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private spRRHH_Ficha_ExpLabDataTable tablespRRHH_Ficha_ExpLab;

	private spRRHH_Ficha_ExpLab_DatosDataTable tablespRRHH_Ficha_ExpLab_Datos;

	private spRRHH_Ficha_Det_FamiliarDataTable tablespRRHH_Ficha_Det_Familiar;

	private spRRHH_Ficha_Estudio_RealizadoDataTable tablespRRHH_Ficha_Estudio_Realizado;

	private spRRHH_Ficha_Estudio_TituloDataTable tablespRRHH_Ficha_Estudio_Titulo;

	private spRRHH_Ficha_Estudio_CapacitacionDataTable tablespRRHH_Ficha_Estudio_Capacitacion;

	private spRRHH_Report_CuadroPerDataTable tablespRRHH_Report_CuadroPer;

	private spRRHH_Report_OficinaDataTable tablespRRHH_Report_Oficina;

	private spRRHH_Report_CumpleDataTable tablespRRHH_Report_Cumple;

	private spRRHH_Rep_cargosDataTable tablespRRHH_Rep_cargos;

	private spRRHH_Ficha_Ingreso_EgresoDataTable tablespRRHH_Ficha_Ingreso_Egreso;

	private spRRHH_Ficha_DatosPersonalesDataTable tablespRRHH_Ficha_DatosPersonales;

	private spRRHH_Ficha_Det_Familiar_SaludDataTable tablespRRHH_Ficha_Det_Familiar_Salud;

	private spRRHH_Ficha_ViviendaDataTable tablespRRHH_Ficha_Vivienda;

	private spRRHH_FaltasDataTable tablespRRHH_Faltas;

	private spRRHH_RepPermisosDataTable tablespRRHH_RepPermisos;

	private spRRHH_RepAsisdiarriaDataTable tablespRRHH_RepAsisdiarria;

	private spRRHH_Report_FechaIngresoDataTable tablespRRHH_Report_FechaIngreso;

	private spRRHH_Rep_profesionDataTable tablespRRHH_Rep_profesion;

	private spRRHH_busca_DisciplinaDataTable tablespRRHH_busca_Disciplina;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_ExpLabDataTable spRRHH_Ficha_ExpLab => tablespRRHH_Ficha_ExpLab;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public spRRHH_Ficha_ExpLab_DatosDataTable spRRHH_Ficha_ExpLab_Datos => tablespRRHH_Ficha_ExpLab_Datos;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_Det_FamiliarDataTable spRRHH_Ficha_Det_Familiar => tablespRRHH_Ficha_Det_Familiar;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public spRRHH_Ficha_Estudio_RealizadoDataTable spRRHH_Ficha_Estudio_Realizado => tablespRRHH_Ficha_Estudio_Realizado;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_Estudio_TituloDataTable spRRHH_Ficha_Estudio_Titulo => tablespRRHH_Ficha_Estudio_Titulo;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_Estudio_CapacitacionDataTable spRRHH_Ficha_Estudio_Capacitacion => tablespRRHH_Ficha_Estudio_Capacitacion;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public spRRHH_Report_CuadroPerDataTable spRRHH_Report_CuadroPer => tablespRRHH_Report_CuadroPer;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Report_OficinaDataTable spRRHH_Report_Oficina => tablespRRHH_Report_Oficina;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public spRRHH_Report_CumpleDataTable spRRHH_Report_Cumple => tablespRRHH_Report_Cumple;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public spRRHH_Rep_cargosDataTable spRRHH_Rep_cargos => tablespRRHH_Rep_cargos;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_Ingreso_EgresoDataTable spRRHH_Ficha_Ingreso_Egreso => tablespRRHH_Ficha_Ingreso_Egreso;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public spRRHH_Ficha_DatosPersonalesDataTable spRRHH_Ficha_DatosPersonales => tablespRRHH_Ficha_DatosPersonales;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public spRRHH_Ficha_Det_Familiar_SaludDataTable spRRHH_Ficha_Det_Familiar_Salud => tablespRRHH_Ficha_Det_Familiar_Salud;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public spRRHH_Ficha_ViviendaDataTable spRRHH_Ficha_Vivienda => tablespRRHH_Ficha_Vivienda;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_FaltasDataTable spRRHH_Faltas => tablespRRHH_Faltas;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_RepPermisosDataTable spRRHH_RepPermisos => tablespRRHH_RepPermisos;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_RepAsisdiarriaDataTable spRRHH_RepAsisdiarria => tablespRRHH_RepAsisdiarria;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public spRRHH_Report_FechaIngresoDataTable spRRHH_Report_FechaIngreso => tablespRRHH_Report_FechaIngreso;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_Rep_profesionDataTable spRRHH_Rep_profesion => tablespRRHH_Rep_profesion;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public spRRHH_busca_DisciplinaDataTable spRRHH_busca_Disciplina => tablespRRHH_busca_Disciplina;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

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
	public DataSet1()
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected DataSet1(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		__ENCAddToList(this);
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["spRRHH_Ficha_ExpLab"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ExpLabDataTable(dataSet.Tables["spRRHH_Ficha_ExpLab"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_ExpLab_Datos"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ExpLab_DatosDataTable(dataSet.Tables["spRRHH_Ficha_ExpLab_Datos"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Det_Familiar"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Det_FamiliarDataTable(dataSet.Tables["spRRHH_Ficha_Det_Familiar"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Realizado"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_RealizadoDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Realizado"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Titulo"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_TituloDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Titulo"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Capacitacion"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_CapacitacionDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Capacitacion"]));
			}
			if (dataSet.Tables["spRRHH_Report_CuadroPer"] != null)
			{
				base.Tables.Add(new spRRHH_Report_CuadroPerDataTable(dataSet.Tables["spRRHH_Report_CuadroPer"]));
			}
			if (dataSet.Tables["spRRHH_Report_Oficina"] != null)
			{
				base.Tables.Add(new spRRHH_Report_OficinaDataTable(dataSet.Tables["spRRHH_Report_Oficina"]));
			}
			if (dataSet.Tables["spRRHH_Report_Cumple"] != null)
			{
				base.Tables.Add(new spRRHH_Report_CumpleDataTable(dataSet.Tables["spRRHH_Report_Cumple"]));
			}
			if (dataSet.Tables["spRRHH_Rep_cargos"] != null)
			{
				base.Tables.Add(new spRRHH_Rep_cargosDataTable(dataSet.Tables["spRRHH_Rep_cargos"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Ingreso_Egreso"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Ingreso_EgresoDataTable(dataSet.Tables["spRRHH_Ficha_Ingreso_Egreso"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_DatosPersonales"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_DatosPersonalesDataTable(dataSet.Tables["spRRHH_Ficha_DatosPersonales"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Det_Familiar_Salud"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Det_Familiar_SaludDataTable(dataSet.Tables["spRRHH_Ficha_Det_Familiar_Salud"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Vivienda"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ViviendaDataTable(dataSet.Tables["spRRHH_Ficha_Vivienda"]));
			}
			if (dataSet.Tables["spRRHH_Faltas"] != null)
			{
				base.Tables.Add(new spRRHH_FaltasDataTable(dataSet.Tables["spRRHH_Faltas"]));
			}
			if (dataSet.Tables["spRRHH_RepPermisos"] != null)
			{
				base.Tables.Add(new spRRHH_RepPermisosDataTable(dataSet.Tables["spRRHH_RepPermisos"]));
			}
			if (dataSet.Tables["spRRHH_RepAsisdiarria"] != null)
			{
				base.Tables.Add(new spRRHH_RepAsisdiarriaDataTable(dataSet.Tables["spRRHH_RepAsisdiarria"]));
			}
			if (dataSet.Tables["spRRHH_Report_FechaIngreso"] != null)
			{
				base.Tables.Add(new spRRHH_Report_FechaIngresoDataTable(dataSet.Tables["spRRHH_Report_FechaIngreso"]));
			}
			if (dataSet.Tables["spRRHH_Rep_profesion"] != null)
			{
				base.Tables.Add(new spRRHH_Rep_profesionDataTable(dataSet.Tables["spRRHH_Rep_profesion"]));
			}
			if (dataSet.Tables["spRRHH_busca_Disciplina"] != null)
			{
				base.Tables.Add(new spRRHH_busca_DisciplinaDataTable(dataSet.Tables["spRRHH_busca_Disciplina"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		DataSet1 dataSet = (DataSet1)base.Clone();
		dataSet.InitVars();
		dataSet.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["spRRHH_Ficha_ExpLab"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ExpLabDataTable(dataSet.Tables["spRRHH_Ficha_ExpLab"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_ExpLab_Datos"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ExpLab_DatosDataTable(dataSet.Tables["spRRHH_Ficha_ExpLab_Datos"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Det_Familiar"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Det_FamiliarDataTable(dataSet.Tables["spRRHH_Ficha_Det_Familiar"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Realizado"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_RealizadoDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Realizado"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Titulo"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_TituloDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Titulo"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Estudio_Capacitacion"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Estudio_CapacitacionDataTable(dataSet.Tables["spRRHH_Ficha_Estudio_Capacitacion"]));
			}
			if (dataSet.Tables["spRRHH_Report_CuadroPer"] != null)
			{
				base.Tables.Add(new spRRHH_Report_CuadroPerDataTable(dataSet.Tables["spRRHH_Report_CuadroPer"]));
			}
			if (dataSet.Tables["spRRHH_Report_Oficina"] != null)
			{
				base.Tables.Add(new spRRHH_Report_OficinaDataTable(dataSet.Tables["spRRHH_Report_Oficina"]));
			}
			if (dataSet.Tables["spRRHH_Report_Cumple"] != null)
			{
				base.Tables.Add(new spRRHH_Report_CumpleDataTable(dataSet.Tables["spRRHH_Report_Cumple"]));
			}
			if (dataSet.Tables["spRRHH_Rep_cargos"] != null)
			{
				base.Tables.Add(new spRRHH_Rep_cargosDataTable(dataSet.Tables["spRRHH_Rep_cargos"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Ingreso_Egreso"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Ingreso_EgresoDataTable(dataSet.Tables["spRRHH_Ficha_Ingreso_Egreso"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_DatosPersonales"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_DatosPersonalesDataTable(dataSet.Tables["spRRHH_Ficha_DatosPersonales"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Det_Familiar_Salud"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_Det_Familiar_SaludDataTable(dataSet.Tables["spRRHH_Ficha_Det_Familiar_Salud"]));
			}
			if (dataSet.Tables["spRRHH_Ficha_Vivienda"] != null)
			{
				base.Tables.Add(new spRRHH_Ficha_ViviendaDataTable(dataSet.Tables["spRRHH_Ficha_Vivienda"]));
			}
			if (dataSet.Tables["spRRHH_Faltas"] != null)
			{
				base.Tables.Add(new spRRHH_FaltasDataTable(dataSet.Tables["spRRHH_Faltas"]));
			}
			if (dataSet.Tables["spRRHH_RepPermisos"] != null)
			{
				base.Tables.Add(new spRRHH_RepPermisosDataTable(dataSet.Tables["spRRHH_RepPermisos"]));
			}
			if (dataSet.Tables["spRRHH_RepAsisdiarria"] != null)
			{
				base.Tables.Add(new spRRHH_RepAsisdiarriaDataTable(dataSet.Tables["spRRHH_RepAsisdiarria"]));
			}
			if (dataSet.Tables["spRRHH_Report_FechaIngreso"] != null)
			{
				base.Tables.Add(new spRRHH_Report_FechaIngresoDataTable(dataSet.Tables["spRRHH_Report_FechaIngreso"]));
			}
			if (dataSet.Tables["spRRHH_Rep_profesion"] != null)
			{
				base.Tables.Add(new spRRHH_Rep_profesionDataTable(dataSet.Tables["spRRHH_Rep_profesion"]));
			}
			if (dataSet.Tables["spRRHH_busca_Disciplina"] != null)
			{
				base.Tables.Add(new spRRHH_busca_DisciplinaDataTable(dataSet.Tables["spRRHH_busca_Disciplina"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tablespRRHH_Ficha_ExpLab = (spRRHH_Ficha_ExpLabDataTable)base.Tables["spRRHH_Ficha_ExpLab"];
		if (initTable && tablespRRHH_Ficha_ExpLab != null)
		{
			tablespRRHH_Ficha_ExpLab.InitVars();
		}
		tablespRRHH_Ficha_ExpLab_Datos = (spRRHH_Ficha_ExpLab_DatosDataTable)base.Tables["spRRHH_Ficha_ExpLab_Datos"];
		if (initTable && tablespRRHH_Ficha_ExpLab_Datos != null)
		{
			tablespRRHH_Ficha_ExpLab_Datos.InitVars();
		}
		tablespRRHH_Ficha_Det_Familiar = (spRRHH_Ficha_Det_FamiliarDataTable)base.Tables["spRRHH_Ficha_Det_Familiar"];
		if (initTable && tablespRRHH_Ficha_Det_Familiar != null)
		{
			tablespRRHH_Ficha_Det_Familiar.InitVars();
		}
		tablespRRHH_Ficha_Estudio_Realizado = (spRRHH_Ficha_Estudio_RealizadoDataTable)base.Tables["spRRHH_Ficha_Estudio_Realizado"];
		if (initTable && tablespRRHH_Ficha_Estudio_Realizado != null)
		{
			tablespRRHH_Ficha_Estudio_Realizado.InitVars();
		}
		tablespRRHH_Ficha_Estudio_Titulo = (spRRHH_Ficha_Estudio_TituloDataTable)base.Tables["spRRHH_Ficha_Estudio_Titulo"];
		if (initTable && tablespRRHH_Ficha_Estudio_Titulo != null)
		{
			tablespRRHH_Ficha_Estudio_Titulo.InitVars();
		}
		tablespRRHH_Ficha_Estudio_Capacitacion = (spRRHH_Ficha_Estudio_CapacitacionDataTable)base.Tables["spRRHH_Ficha_Estudio_Capacitacion"];
		if (initTable && tablespRRHH_Ficha_Estudio_Capacitacion != null)
		{
			tablespRRHH_Ficha_Estudio_Capacitacion.InitVars();
		}
		tablespRRHH_Report_CuadroPer = (spRRHH_Report_CuadroPerDataTable)base.Tables["spRRHH_Report_CuadroPer"];
		if (initTable && tablespRRHH_Report_CuadroPer != null)
		{
			tablespRRHH_Report_CuadroPer.InitVars();
		}
		tablespRRHH_Report_Oficina = (spRRHH_Report_OficinaDataTable)base.Tables["spRRHH_Report_Oficina"];
		if (initTable && tablespRRHH_Report_Oficina != null)
		{
			tablespRRHH_Report_Oficina.InitVars();
		}
		tablespRRHH_Report_Cumple = (spRRHH_Report_CumpleDataTable)base.Tables["spRRHH_Report_Cumple"];
		if (initTable && tablespRRHH_Report_Cumple != null)
		{
			tablespRRHH_Report_Cumple.InitVars();
		}
		tablespRRHH_Rep_cargos = (spRRHH_Rep_cargosDataTable)base.Tables["spRRHH_Rep_cargos"];
		if (initTable && tablespRRHH_Rep_cargos != null)
		{
			tablespRRHH_Rep_cargos.InitVars();
		}
		tablespRRHH_Ficha_Ingreso_Egreso = (spRRHH_Ficha_Ingreso_EgresoDataTable)base.Tables["spRRHH_Ficha_Ingreso_Egreso"];
		if (initTable && tablespRRHH_Ficha_Ingreso_Egreso != null)
		{
			tablespRRHH_Ficha_Ingreso_Egreso.InitVars();
		}
		tablespRRHH_Ficha_DatosPersonales = (spRRHH_Ficha_DatosPersonalesDataTable)base.Tables["spRRHH_Ficha_DatosPersonales"];
		if (initTable && tablespRRHH_Ficha_DatosPersonales != null)
		{
			tablespRRHH_Ficha_DatosPersonales.InitVars();
		}
		tablespRRHH_Ficha_Det_Familiar_Salud = (spRRHH_Ficha_Det_Familiar_SaludDataTable)base.Tables["spRRHH_Ficha_Det_Familiar_Salud"];
		if (initTable && tablespRRHH_Ficha_Det_Familiar_Salud != null)
		{
			tablespRRHH_Ficha_Det_Familiar_Salud.InitVars();
		}
		tablespRRHH_Ficha_Vivienda = (spRRHH_Ficha_ViviendaDataTable)base.Tables["spRRHH_Ficha_Vivienda"];
		if (initTable && tablespRRHH_Ficha_Vivienda != null)
		{
			tablespRRHH_Ficha_Vivienda.InitVars();
		}
		tablespRRHH_Faltas = (spRRHH_FaltasDataTable)base.Tables["spRRHH_Faltas"];
		if (initTable && tablespRRHH_Faltas != null)
		{
			tablespRRHH_Faltas.InitVars();
		}
		tablespRRHH_RepPermisos = (spRRHH_RepPermisosDataTable)base.Tables["spRRHH_RepPermisos"];
		if (initTable && tablespRRHH_RepPermisos != null)
		{
			tablespRRHH_RepPermisos.InitVars();
		}
		tablespRRHH_RepAsisdiarria = (spRRHH_RepAsisdiarriaDataTable)base.Tables["spRRHH_RepAsisdiarria"];
		if (initTable && tablespRRHH_RepAsisdiarria != null)
		{
			tablespRRHH_RepAsisdiarria.InitVars();
		}
		tablespRRHH_Report_FechaIngreso = (spRRHH_Report_FechaIngresoDataTable)base.Tables["spRRHH_Report_FechaIngreso"];
		if (initTable && tablespRRHH_Report_FechaIngreso != null)
		{
			tablespRRHH_Report_FechaIngreso.InitVars();
		}
		tablespRRHH_Rep_profesion = (spRRHH_Rep_profesionDataTable)base.Tables["spRRHH_Rep_profesion"];
		if (initTable && tablespRRHH_Rep_profesion != null)
		{
			tablespRRHH_Rep_profesion.InitVars();
		}
		tablespRRHH_busca_Disciplina = (spRRHH_busca_DisciplinaDataTable)base.Tables["spRRHH_busca_Disciplina"];
		if (initTable && tablespRRHH_busca_Disciplina != null)
		{
			tablespRRHH_busca_Disciplina.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "DataSet1";
		Prefix = "";
		Namespace = "http://tempuri.org/DataSet1.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tablespRRHH_Ficha_ExpLab = new spRRHH_Ficha_ExpLabDataTable();
		base.Tables.Add(tablespRRHH_Ficha_ExpLab);
		tablespRRHH_Ficha_ExpLab_Datos = new spRRHH_Ficha_ExpLab_DatosDataTable();
		base.Tables.Add(tablespRRHH_Ficha_ExpLab_Datos);
		tablespRRHH_Ficha_Det_Familiar = new spRRHH_Ficha_Det_FamiliarDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Det_Familiar);
		tablespRRHH_Ficha_Estudio_Realizado = new spRRHH_Ficha_Estudio_RealizadoDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Estudio_Realizado);
		tablespRRHH_Ficha_Estudio_Titulo = new spRRHH_Ficha_Estudio_TituloDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Estudio_Titulo);
		tablespRRHH_Ficha_Estudio_Capacitacion = new spRRHH_Ficha_Estudio_CapacitacionDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Estudio_Capacitacion);
		tablespRRHH_Report_CuadroPer = new spRRHH_Report_CuadroPerDataTable();
		base.Tables.Add(tablespRRHH_Report_CuadroPer);
		tablespRRHH_Report_Oficina = new spRRHH_Report_OficinaDataTable();
		base.Tables.Add(tablespRRHH_Report_Oficina);
		tablespRRHH_Report_Cumple = new spRRHH_Report_CumpleDataTable();
		base.Tables.Add(tablespRRHH_Report_Cumple);
		tablespRRHH_Rep_cargos = new spRRHH_Rep_cargosDataTable();
		base.Tables.Add(tablespRRHH_Rep_cargos);
		tablespRRHH_Ficha_Ingreso_Egreso = new spRRHH_Ficha_Ingreso_EgresoDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Ingreso_Egreso);
		tablespRRHH_Ficha_DatosPersonales = new spRRHH_Ficha_DatosPersonalesDataTable();
		base.Tables.Add(tablespRRHH_Ficha_DatosPersonales);
		tablespRRHH_Ficha_Det_Familiar_Salud = new spRRHH_Ficha_Det_Familiar_SaludDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Det_Familiar_Salud);
		tablespRRHH_Ficha_Vivienda = new spRRHH_Ficha_ViviendaDataTable();
		base.Tables.Add(tablespRRHH_Ficha_Vivienda);
		tablespRRHH_Faltas = new spRRHH_FaltasDataTable();
		base.Tables.Add(tablespRRHH_Faltas);
		tablespRRHH_RepPermisos = new spRRHH_RepPermisosDataTable();
		base.Tables.Add(tablespRRHH_RepPermisos);
		tablespRRHH_RepAsisdiarria = new spRRHH_RepAsisdiarriaDataTable();
		base.Tables.Add(tablespRRHH_RepAsisdiarria);
		tablespRRHH_Report_FechaIngreso = new spRRHH_Report_FechaIngresoDataTable();
		base.Tables.Add(tablespRRHH_Report_FechaIngreso);
		tablespRRHH_Rep_profesion = new spRRHH_Rep_profesionDataTable();
		base.Tables.Add(tablespRRHH_Rep_profesion);
		tablespRRHH_busca_Disciplina = new spRRHH_busca_DisciplinaDataTable();
		base.Tables.Add(tablespRRHH_busca_Disciplina);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_ExpLab()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_ExpLab_Datos()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Ficha_Det_Familiar()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_Estudio_Realizado()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_Estudio_Titulo()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Ficha_Estudio_Capacitacion()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Report_CuadroPer()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Report_Oficina()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Report_Cumple()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Rep_cargos()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_Ingreso_Egreso()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_Ficha_DatosPersonales()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Ficha_Det_Familiar_Salud()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Ficha_Vivienda()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Faltas()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_RepPermisos()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_RepAsisdiarria()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Report_FechaIngreso()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializespRRHH_Rep_profesion()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializespRRHH_busca_Disciplina()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		DataSet1 dataSet = new DataSet1();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = dataSet.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while ((memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte()) ? true : false)
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
