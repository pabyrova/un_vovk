using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Process;
using University.DataObjects;

namespace UI
{
	public class ActionViewProcess
	{
		private readonly Entry _entry;
		private readonly bool _isStudent;

		public ActionViewProcess(Entry entry,bool isStudent)
		{
			_entry = entry;
			_isStudent = isStudent;
		}

		public void Run()
		{
			using (ProcessView view = new ProcessView())
			{
				view.Data = GetProcess();
				view.IsStudent = _isStudent;
				view.ShowDialog();
			}
		}

		private List<string> GetProcess()
		{
			List<string> process = new List<string>();
			const string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=unSysVovk;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cm = new SqlCommand();
			cm.Connection = conn;

			using (conn)
			{
				conn.Open();
				using (cm)
				{
					cm.CommandText = "Select * from Process where EntryId='" + _entry.Id + "'";
					SqlDataReader reader = cm.ExecuteReader();
					while (reader.Read())
					{
						process.Add((string)reader[1]);
					}
				}
			}
			return process;
		}
	}
}
