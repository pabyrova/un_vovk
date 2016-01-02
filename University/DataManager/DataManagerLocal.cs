using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using University.DataObjects;
using University.Other;

namespace University.DataManager
{
	public class DataManagerLocal
	{
		private static readonly DataManagerLocal Instance;
		private SqlCommand _command;
		private SqlConnection _connection;
		private List<Entry> _data;
		private Stack<Entry> _stack;
		private readonly string _connectionString;
		private readonly Dictionary<string, List<string>> _dependencies;

		private DataManagerLocal()
		{
			_connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=unSysVovk;Integrated Security=True";
			_data = new List<Entry>();
			_dependencies = new Dictionary<string, List<string>>();
			InitDependecies();
		}

		public Dictionary<string, List<string>> Dependencies {
			get { return _dependencies; }
		}

		static DataManagerLocal()
		{
			Instance = new DataManagerLocal();
		}

		public SqlConnection Connection
		{
			get { return _connection; }
			set { _connection = value; }
		}

		public SqlCommand Command
		{
			get { return _command; }
			set { _command = value; }
		}

		public string ConnectionString
		{
			get { return _connectionString; }
		}

		public static DataManagerLocal Inst
		{
			get
			{
				Instance._stack = new Stack<Entry>();
				Instance.Connection = new SqlConnection(Instance.ConnectionString);
				Instance.Command = new SqlCommand();
				Instance.Command.Connection = Instance.Connection;
				return Instance;
			}
		}

		public List<Entry> Data
		{
			get
			{
				if (_data == null || _data.Count == 0)
				{
					_data = Select("Entry", Guid.Empty);
				}
				return _data;
			}
		}

		private void InitDependecies()
		{
			_dependencies.Add("University", new List<string> {"Faculty"});
			_dependencies.Add("Faculty", new List<string> {"Department"});
			_dependencies.Add("Department", new List<string> { "Team", "Lecturer" });
			_dependencies.Add("Team", new List<string> {"Student"});
		}

		private int GetDataEntryIndex(Entry entry)
		{
			for (int l = 0; l < _data.Count; l++)
			{
				if (_data[l].Id == entry.Id)
				{
					return l;
				}
			}
			return -1;
		}

		private void PrepareDownStack(Entry entry)
		{
			Entry lEntry = entry;
			while (lEntry != null)
			{
				_stack.Push(lEntry);
				lEntry = GetBaseInst(lEntry);
			}
		}

		private void PrepareUpStack(Entry entry)
		{
			if (entry == null)
			{
				return;
			}
			_stack.Push(entry);
			List<Entry> lEntries = GetEntryChildren(entry);
			for (int l = 0; l < lEntries.Count; l++)
			{
				PrepareUpStack(lEntries[l]);
			}
		}

		private void PrepareTwoSideStack(Entry entry)
		{
			PrepareUpStack(entry);
			_stack = ReverseStack(_stack);
			_stack.Pop();
			PrepareDownStack(entry);
		}

		private List<Entry> GetEntryChildren(Entry entry)
		{
			Type lType = entry.GetType();
			List<Type> lTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsClass && type.Namespace == "University.DataObjects" && type.IsSubclassOf(lType)).ToList();
			if (lTypes.Count == 0)
			{
				return new List<Entry>();
			}

			List<Entry> lEntries = new List<Entry>();
			for (int l = 0; l < lTypes.Count; l++)
			{
				lEntries.Add(CreateTypeInst(lTypes[l], entry, true));
			}
			return lEntries;
		}

		private Entry GetBaseInst(Entry entry)
		{
			Type lBaseType = entry.GetType().BaseType;
			if (lBaseType != null && lBaseType != typeof (object))
			{
				return CreateTypeInst(lBaseType, entry, false);
			}
			return null;
		}

		private Entry CreateTypeInst(Type type, Entry data, bool up)
		{
			PropertyInfo[] lProperties = up ? data.GetType().GetProperties() : type.GetProperties();

			Entry lEntry = Activator.CreateInstance(type) as Entry;

			for (int l = 0; l < lProperties.Length; l++)
			{
				lProperties[l].SetValue(lEntry, GetPropValue(data, lProperties[l].Name));
			}
			return lEntry;
		}

		private object GetPropValue(object src, string propName)
		{
			return src.GetType().GetProperty(propName).GetValue(src, null);
		}

		private Dictionary<string, object> GetEntryValues(Entry entry)
		{
			Type lType = entry.GetType();
			PropertyInfo[] lProperties = lType.GetProperties();
			PropertyInfo[] lBaseProperties = lType.BaseType.GetProperties();

			List<string> lProNames = new List<string>();
			List<string> lBaseProNames = new List<string>();

			for (int l = 0; l < lProperties.Length; l++)
			{
				lProNames.Add(lProperties[l].Name);
			}

			for (int l = 0; l < lBaseProperties.Length; l++)
			{
				lBaseProNames.Add(lBaseProperties[l].Name);
			}

			List<string> lExcept = lProNames.Except(lBaseProNames).ToList();
			if (!lExcept.Contains("Id"))
			{
				lExcept.Add("Id");
			}

			Dictionary<string, object> lDictionary = new Dictionary<string, object>();
			for (int l = 0; l < lExcept.Count; l++)
			{
				lDictionary.Add(lExcept[l], GetPropValue(entry, lExcept[l]));
			}
			return lDictionary;
		}

		private Entry CreateEntry(Type type, Dictionary<string, object> data)
		{
			Entry lEntry = (Entry) Activator.CreateInstance(type);
			foreach (var lO in data)
			{
				type.GetProperty(lO.Key).SetValue(lEntry, lO.Value);
			}
			return lEntry;
		}

		private Stack<Entry> ReverseStack(Stack<Entry> stack)
		{
			Stack<Entry> lReverse = new Stack<Entry>();
			while (_stack.Count != 0)
			{
				lReverse.Push(_stack.Peek());
				_stack.Pop();
			}
			return lReverse;
		}

		private void MergeEntries(List<Dictionary<string, object>> mergeEntries, List<Dictionary<string, object>> baseEntries)
		{
			for (int l = 0; l < mergeEntries.Count; l++)
			{
				Dictionary<string, object> lMergeEntry = mergeEntries[l];
				Guid lMergeEntryId = (Guid) lMergeEntry["Id"];
				for (int lB = 0; lB < baseEntries.Count; lB++)
				{
					Dictionary<string, object> lBaseEntry = baseEntries[lB];
					Guid lBaseEnreyId = (Guid) lBaseEntry["Id"];
					if (lMergeEntryId != lBaseEnreyId)
					{
						continue;
					}
					foreach (var lItem in lMergeEntry)
					{
						if (lItem.Key != "Id")
						{
							lBaseEntry.Add(lItem.Key, lItem.Value);
						}
					}
				}
			}
		}

		#region Select      

		public List<Entry> Select(string tableName, Guid id)
		{
			try
			{
				Type lType = Type.GetType("University.DataObjects." + tableName);
				if (lType != null)
				{
					PrepareDownStack((Entry) Activator.CreateInstance(lType));
				}

				List<Dictionary<string, object>> lEntries = new List<Dictionary<string, object>>();
				using (Connection)
				{
					Connection.Open();
					using (Command)
					{
						_stack = ReverseStack(_stack);
						lEntries.AddRange(SelectEntry(_stack.Peek(), id));
						_stack.Pop();
						while (_stack.Count != 0)
						{
							List<Dictionary<string, object>> lMergeEntries = SelectEntry(_stack.Peek(), id);
							MergeEntries(lMergeEntries, lEntries);
							_stack.Pop();
						}

						List<Entry> lList = new List<Entry>();

						for (int l = 0; l < lEntries.Count; l++)
						{
							lList.Add(CreateEntry(lType, lEntries[l]));
						}

						return lList;
					}
				}
			}
			catch (Exception ex)
			{
				Type type = Type.GetType("University.DataObjects." + tableName);
				if (type != null)
				{
					Trace.WriteLine(string.Format("Select issue appears in '{0}':{1}", type.Name, ex.Message));
				}
			}

			return new List<Entry>();
		}

		private List<Dictionary<string, object>> SelectEntry(Entry entry, Guid id)
		{
			List<string> lList = GetEntryValues(entry).Keys.ToList();

			SqlCreator lCreator = new SqlCreator();
			lCreator.Table = entry.GetType().Name;
			Command.CommandText = id != Guid.Empty ? lCreator.GetSelectSql(id) : lCreator.GetSelectSql();
			SqlDataReader lReader = Command.ExecuteReader();

			List<Dictionary<string, object>> lListDict = new List<Dictionary<string, object>>();
			using (lReader)
			{
				while (lReader.Read())
				{
					Dictionary<string, object> lDictionary = new Dictionary<string, object>();
					for (int l = 0; l < lList.Count; l++)
					{
						lDictionary.Add(lList[l], lReader[lList[l]]);
					}
					lListDict.Add(lDictionary);
				}
			}
			return lListDict;
		}

		public Dictionary<string, Entry> GetForeignData(Entry data)
		{
			List<PropertyInfo> lInfos = data.GetType().GetProperties().Where(property => property.Name.Contains("_Id")).ToList();

			Dictionary<string, Entry> lDictionary = new Dictionary<string, Entry>();

			for (int l = 0; l < lInfos.Count; l++)
			{
				int lI = lInfos[l].Name.IndexOf("_", StringComparison.Ordinal);
				if (lI != -1)
				{
					string lS = lInfos[l].Name.Substring(0, lI);
					List<Entry> lList = Select(lS, (Guid) lInfos[l].GetValue(data));
					if (lList.Count == 0)
					{
						continue;
					}
					lDictionary.Add(lS, lList[0]);
				}
			}

			return lDictionary;
		}

		#endregion

		#region Insert

		public void Insert(Entry entry)
		{
			try
			{
				PrepareDownStack(entry);

				using (Connection)
				{
					Connection.Open();
					using (Command)
					{
						while (_stack.Count != 0)
						{
							InsertEntry(_stack.Peek());
							_stack.Pop();
						}
					}
				}
				_data.Add(entry);
			}
			catch (Exception ex)
			{
				Trace.WriteLine(string.Format("Insert issue appears in '{0}':{1}", entry.GetType().Name, ex.Message));
			}
		}

		private void InsertEntry(Entry entry)
		{
			Dictionary<string, object> lEntryValues = GetEntryValues(entry);

			SqlCreator lCreator = new SqlCreator();
			lCreator.Dictionary = lEntryValues;
			lCreator.Table = entry.GetType().Name;
			Command.CommandText = lCreator.GetInsertSql();
			Command.ExecuteNonQuery();
		}

		#endregion

		#region Update

		public void Update(Entry entry)
		{
			try
			{
				PrepareDownStack(entry);

				using (Connection)
				{
					Connection.Open();
					using (Command)
					{
						while (_stack.Count != 0)
						{
							UpdateEntry(_stack.Peek());
							_stack.Pop();
						}
					}
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine(string.Format("Update issue appears in '{0}':{1}", entry.GetType().Name, ex.Message));
			}
		}


		private void UpdateEntry(Entry entry)
		{
			Dictionary<string, object> lEntryValues = GetEntryValues(entry);

			SqlCreator lCreator = new SqlCreator();
			lCreator.Dictionary = lEntryValues;
			lCreator.Table = entry.GetType().Name;
			Command.CommandText = lCreator.GetUpdateSql((Guid) lCreator["Id"]);
			Command.ExecuteNonQuery();
		}

		#endregion

		#region Delete

		public void Delete(Entry entry)
		{
			try
			{
				PrepareTwoSideStack(entry);
				using (Connection)
				{
					Connection.Open();
					using (Command)
					{
						_stack = ReverseStack(_stack);
						while (_stack.Count != 0)
						{
							DeleteEntry(_stack.Peek());
							_stack.Pop();
						}
					}
				}
				int index = GetDataEntryIndex(entry);
				if (index == -1)
				{
					return;
				}
				_data.RemoveAt(index);
			}
			catch (Exception ex)
			{
				Trace.WriteLine(string.Format("Update issue appears in '{0}':{1}", entry.GetType().Name, ex.Message));
			}
		}

		private void DeleteEntry(Entry entry)
		{
			Dictionary<string, object> lEntryValues = GetEntryValues(entry);

			SqlCreator lCreator = new SqlCreator();
			lCreator.Dictionary = lEntryValues;
			lCreator.Table = entry.GetType().Name;
			Command.CommandText = lCreator.GetDeleteSql((Guid) lCreator["Id"]);
			Command.ExecuteNonQuery();
		}

		#endregion
	}
}