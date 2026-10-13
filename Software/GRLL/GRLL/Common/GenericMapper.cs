using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DataObject]
public class GenericMapper<TEntity, TDataContext> where TDataContext : DataContext
{
	private static GenericMapper<TEntity, TDataContext> mInstance;

	private static Mutex mMutex = new Mutex();

	private static TDataContext _DataContext;

	protected static DataContext DataContext
	{
		get
		{
			if (HttpContext.Current != null)
			{
				_DataContext = Conversions.ToGenericParameter<TDataContext>(RuntimeHelpers.GetObjectValue(HttpContext.Current.Items["_dataContext"]));
				if (_DataContext == null)
				{
					_DataContext = Activator.CreateInstance<TDataContext>();
				}
				return _DataContext;
			}
			if (_DataContext == null)
			{
				_DataContext = Activator.CreateInstance<TDataContext>();
			}
			return _DataContext;
		}
		set
		{
			_DataContext = (TDataContext)value;
		}
	}

	protected static Type EntityType => typeof(TEntity);

	protected static ITable EntityTable => _DataContext.GetTable(EntityType);

	protected static string EntityName => EntityType.Name;

	protected static string TableName
	{
		get
		{
			object att = RuntimeHelpers.GetObjectValue((from a in EntityType.GetCustomAttributes(inherit: false)
				where a.GetType() == typeof(TableAttribute)
				select (a)).FirstOrDefault());
			if (att != null)
			{
				return ((TableAttribute)att).Name;
			}
			return "";
		}
	}

	public static DataLoadOptions LoadOptions
	{
		get
		{
			return DataContext.LoadOptions;
		}
		set
		{
			DataContext.LoadOptions = value;
		}
	}

	[DebuggerNonUserCode]
	public GenericMapper()
	{
	}

	protected static GenericMapper<TEntity, TDataContext> InstanceBase()
	{
		mMutex.WaitOne();
		if (mInstance == null)
		{
			mInstance = new GenericMapper<TEntity, TDataContext>();
		}
		mMutex.ReleaseMutex();
		return mInstance;
	}

	public PropertyInfo[] GetColumns()
	{
		return (from p in EntityType.GetProperties()
			where (from att in p.GetCustomAttributes(inherit: true)
				where att.GetType() == typeof(ColumnAttribute)
				select (att)).Count() > 0
			select (p)).ToArray();
	}

	public PropertyInfo GetPrimaryKey()
	{
		PropertyInfo[] columns = GetColumns();
		foreach (PropertyInfo pi in columns)
		{
			object[] customAttributes = pi.GetCustomAttributes(inherit: true);
			for (int j = 0; j < customAttributes.Length; j = checked(j + 1))
			{
				ColumnAttribute o = (ColumnAttribute)customAttributes[j];
				if (o.GetType() == typeof(ColumnAttribute))
				{
					ColumnAttribute col = o;
					if (col.IsPrimaryKey)
					{
						return pi;
					}
				}
			}
		}
		return null;
	}

	protected int GetPrimaryKeyValue(TEntity Entity)
	{
		PropertyInfo pi = GetPrimaryKey();
		return int.Parse(Conversions.ToString(pi.GetValue(Entity, null)));
	}

	protected TEntity GetEntity(TEntity entity)
	{
		return GetEntity(GetPrimaryKeyValue(entity));
	}

	protected void UpdateOriginalFromChanged(ref TEntity destination, TEntity source)
	{
		PropertyInfo[] propsToUpdate = GetColumns();
		PropertyInfo[] array = propsToUpdate;
		DateTime d = default(DateTime);
		DateTime c = default(DateTime);
		char r = default(char);
		foreach (PropertyInfo pi in array)
		{
			if (!pi.CanWrite || pi.GetValue(source, null) == null)
			{
				continue;
			}
			if (pi.GetValue(source, null).GetType() == typeof(string))
			{
				if (Operators.CompareString(pi.GetValue(source, null).ToString().Trim(), "<NULL>", TextCompare: false) == 0)
				{
					pi.SetValue(destination, null, null);
				}
				else
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
			}
			else if ((pi.GetValue(source, null).GetType() == typeof(int)) | (pi.GetValue(source, null).GetType() == typeof(decimal)) | (pi.GetValue(source, null).GetType() == typeof(double)))
			{
				if (Operators.ConditionalCompareObjectEqual(pi.GetValue(source, null), -1, TextCompare: false))
				{
					pi.SetValue(destination, null, null);
				}
				else
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
			}
			else if ((pi.GetValue(source, null).GetType() == typeof(DateTime)) | (pi.GetValue(source, null).GetType() == typeof(DateTime)))
			{
				if (Operators.ConditionalCompareObjectEqual(pi.GetValue(source, null), d, TextCompare: false))
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(destination, null)), null);
				}
				else
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
				if (Operators.ConditionalCompareObjectEqual(pi.GetValue(source, null), c, TextCompare: false))
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(destination, null)), null);
				}
				else
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
			}
			else if (pi.GetValue(source, null).GetType() == typeof(char))
			{
				if (Operators.ConditionalCompareObjectNotEqual(pi.GetValue(source, null), r, TextCompare: false))
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
				else
				{
					pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
				}
			}
			else
			{
				pi.SetValue(destination, RuntimeHelpers.GetObjectValue(pi.GetValue(source, null)), null);
			}
		}
	}

	[DataObjectMethod(DataObjectMethodType.Select)]
	protected IQueryable<TEntity> SelectAllAsQuery()
	{
		return EntityTable.Cast<TEntity>();
	}

	[DataObjectMethod(DataObjectMethodType.Select)]
	public List<TEntity> SelectAll()
	{
		return SelectAllAsQuery().ToList();
	}

	[DataObjectMethod(DataObjectMethodType.Select)]
	public TEntity GetEntity(int id)
	{
		string query = string.Format("Select * From (0) where (1)=(2)", new object[3]
		{
			TableName,
			GetPrimaryKey().Name,
			id
		});
		return DataContext.ExecuteQuery<TEntity>(query, new object[0]).FirstOrDefault();
	}

	[DataObjectMethod(DataObjectMethodType.Insert)]
	public void Insert(TEntity entity)
	{
		Insert(entity, submitchanges: true);
	}

	public void Insert(TEntity entity, bool submitchanges)
	{
		EntityTable.InsertOnSubmit(entity);
		if (submitchanges)
		{
			DataContext.SubmitChanges();
		}
	}

	public void InsertAll(List<TEntity> entity)
	{
		EntityTable.InsertAllOnSubmit(entity);
		DataContext.SubmitChanges();
	}

	[DataObjectMethod(DataObjectMethodType.Update)]
	public void Update(TEntity entity)
	{
		Update(entity, submitchanges: true);
	}

	public void Update(TEntity entity, bool submitchanges)
	{
		TEntity original = DameEntidad(entity);
		if (original == null)
		{
			throw new Exception("No se encontró registro alguno según los criterios ingresados");
		}
		UpdateOriginalFromChanged(ref original, entity);
		if (submitchanges)
		{
			DataContext.SubmitChanges();
		}
	}

	public void UpdateBy(TEntity entity, Func<TEntity, bool> myWhere)
	{
		IQueryable<TEntity> a = (IQueryable<TEntity>)DataContext.GetTable(EntityType);
		List<TEntity> lista = a.Where(myWhere).ToList();
		try
		{
			foreach (TEntity item in lista)
			{
				TEntity Item = item;
				UpdateOriginalFromChanged(ref Item, entity);
			}
			DataContext.SubmitChanges();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (ex2.Message.ToUpper().Contains("A member defining the identity of the object cannot be changed".ToUpper()))
			{
				throw new Exception("Infracción de la restricción PRIMARY KEY. No se puede insertar una clave duplicada");
			}
			throw new Exception(ex2.Message);
		}
	}

	[DataObjectMethod(DataObjectMethodType.Delete)]
	public void Delete(TEntity entity)
	{
		Delete(entity, submitChanges: true);
	}

	public void Delete(TEntity entity, bool submitChanges)
	{
		TEntity delete = DameEntidad(entity);
		if (delete == null)
		{
			throw new Exception("No se encontró registro alguno según los criterios ingresados");
		}
		EntityTable.DeleteOnSubmit(delete);
		if (submitChanges)
		{
			DataContext.SubmitChanges();
		}
	}

	public void DeleteBy(Func<TEntity, bool> myWhere)
	{
		IQueryable<TEntity> a = (IQueryable<TEntity>)DataContext.GetTable(EntityType);
		IEnumerable<TEntity> lista = a.Where(myWhere);
		if (lista == null)
		{
			throw new Exception("No se encontró registro alguno según los criterios ingresados");
		}
		EntityTable.DeleteAllOnSubmit(lista);
		try
		{
			DataContext.SubmitChanges();
		}
		catch (SqlException ex)
		{
			ProjectData.SetProjectError(ex);
			SqlException ex2 = ex;
			throw new Exception(ex2.Message);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			throw new Exception(ex4.Message);
		}
	}

	public TEntity SelectOneBy(TEntity t)
	{
		return t;
	}

	public TEntity SelectOneBy(Func<TEntity, bool> myWhere)
	{
		IQueryable<TEntity> a = (IQueryable<TEntity>)DataContext.GetTable(EntityType);
		return a.Where(myWhere).FirstOrDefault();
	}

	public List<TEntity> SelectBy(Func<TEntity, bool> myWhere)
	{
		IQueryable<TEntity> a = (IQueryable<TEntity>)DataContext.GetTable(EntityType);
		return a.Where(myWhere).ToList();
	}

	private string GetColumnNames(TEntity t)
	{
		string sql = "";
		PropertyInfo[] columns = GetColumns();
		foreach (PropertyInfo memberInfo in columns)
		{
			if (Operators.CompareString(sql, "", TextCompare: false) != 0)
			{
				sql += ", ";
			}
			sql += memberInfo.Name;
		}
		return sql;
	}

	private TEntity DameEntidad(TEntity t)
	{
		string EntidadName;
		if (t.GetType().IsDefined(typeof(TableAttribute), inherit: true))
		{
			EntidadName = GetTableName(t.GetType());
		}
		EntidadName = EntityName;
		string sql = "SELECT " + GetColumnNames(t) + " FROM [" + EntidadName + "]";
		int counter = 0;
		sql += " WHERE ";
		PropertyInfo[] columns = GetColumns();
		checked
		{
			foreach (PropertyInfo pi in columns)
			{
				object[] customAttributes = pi.GetCustomAttributes(inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					ColumnAttribute o = (ColumnAttribute)customAttributes[j];
					if (o.GetType() != typeof(ColumnAttribute))
					{
						continue;
					}
					ColumnAttribute col = o;
					if (col.IsPrimaryKey)
					{
						if (counter > 0)
						{
							sql += " AND ";
						}
						if (pi.GetValue(t, null) == null)
						{
							throw new Exception("No se ha especificado valor para el Campo PrimaryKey '" + pi.Name + "'");
						}
						sql = Conversions.ToString(Operators.ConcatenateObject(sql, Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("(" + pi.Name, " = '"), pi.GetValue(t, null)), "')")));
						counter++;
					}
				}
			}
			string query = sql;
			return DataContext.ExecuteQuery<TEntity>(query, new object[0]).FirstOrDefault();
		}
	}

	public void SubmitChanges()
	{
		DataContext.SubmitChanges();
	}

	internal static string GetTableName(Type t)
	{
		string name = t.Name;
		if (t.IsDefined(typeof(TableAttribute), inherit: false))
		{
			name = ((TableAttribute[])t.GetCustomAttributes(typeof(TableAttribute), inherit: true))[0].Name;
		}
		return name;
	}
}
