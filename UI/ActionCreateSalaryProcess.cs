using System.Data.SqlClient;
using UI.Process;
using University.DataObjects;

namespace UI
{
	internal class ActionCreateSalaryProcess
	{
		private readonly Entry _entry;

		public ActionCreateSalaryProcess(Entry entry)
		{
			_entry = entry;
		}

		public void Run()
		{
			SalaryProcess salaryProcess = ProcessUtils.CreateSalaryProcess(_entry);
			if (salaryProcess.Run())
			{
				SaveProcess(salaryProcess);
			}
		}

		private void SaveProcess(SalaryProcess process)
		{
			const string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=unSysVovk;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cm = new SqlCommand();
			cm.Connection = conn;

			using (conn)
			{
				conn.Open();
				using (cm)
				{
					cm.CommandText = "INSERT INTO Process (Data,EntryId,DataType) VALUES ('" + process.Data + "','" + process.Id + "','" + process.DataType + "')";
					cm.ExecuteNonQuery();
				}
			}
		}
	}
}