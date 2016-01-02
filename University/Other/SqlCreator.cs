using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University.Other
{
	internal class SqlCreator
	{
		private Dictionary<string, object> _dictionary;
		private string _table;

		public SqlCreator()
		{
			_dictionary = new Dictionary<string, object>();
		}

		public string Table
		{
			get { return _table; }
			set { _table = value; }
		}

		public Dictionary<string, object> Dictionary
		{
			get { return _dictionary; }
			set
			{
				_dictionary.Clear();
				if (value == null)
				{
					return;
				}
				_dictionary = value;
			}
		}

		public object this[string key]
		{
			get { return _dictionary[key]; }
			set
			{
				if (!_dictionary.ContainsKey(key))
				{
					_dictionary.Add(key, value);
				}
				_dictionary[key] = value;
			}
		}

		public string GetInsertSql()
		{
			StringBuilder lBuilder = new StringBuilder();
			lBuilder.Append("INSERT INTO ");
			lBuilder.Append(_table + " (");
			lBuilder.Append(_dictionary.Keys.ToList().Combine());
			lBuilder.Append(") ");
			lBuilder.Append("VALUES (");
			lBuilder.Append(_dictionary.Values.ToList().Combine(wrapper: "'"));
			lBuilder.Append(") ");
			return lBuilder.ToString();
		}

		public string GetSelectSql()
		{
			StringBuilder lBuilder = new StringBuilder();
			if (_dictionary.Count == 0)
			{
				return lBuilder.Append("SELECT * FROM " + _table).ToString();
			}
			lBuilder.Append("SELECT ");
			lBuilder.Append(_dictionary.Values.ToList().Combine());
			lBuilder.Append(" FROM " + _table);
			return lBuilder.ToString();
		}

		public string GetSelectSql(Guid id)
		{
			StringBuilder lBuilder = new StringBuilder();
			if (_dictionary.Count == 0)
			{
				return lBuilder.Append("SELECT * FROM " + _table + " WHERE Id = '" + id + "'").ToString();
			}
			lBuilder.Append("SELECT ");
			lBuilder.Append(_dictionary.Keys.ToList().Combine());
			lBuilder.Append(" FROM " + _table);
			lBuilder.Append(" WHERE Id = '" + id + "'");
			return lBuilder.ToString();
		}

		public string GetDeleteSql(Guid id)
		{
			return "DELETE FROM " + _table + " WHERE Id = '" + id + "'";
		}

		public string GetUpdateSql(Guid id)
		{
			StringBuilder lBuilder = new StringBuilder();
			lBuilder.Append("UPDATE " + _table + " SET ");
			List<string> lList = new List<string>();
			foreach (var lItem in _dictionary)
			{
				lList.Add(lItem.Key + "='" + lItem.Value + "'");
			}
			lBuilder.Append(lList.Combine());
			lBuilder.Append(" WHERE Id = '" + id + "'");
			return lBuilder.ToString();
		}
	}
}