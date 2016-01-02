using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace UI.Process
{
	public partial class ProcessView : Form
	{
		private readonly List<ProcessDataObject> _dataObjects = new List<ProcessDataObject>();
		private readonly DataTable _table = new DataTable();

		public ProcessView()
		{
			InitializeComponent();
		}

		public bool IsStudent { get; set; }
		public List<string> Data { get; set; }

		private void EditEntryFormLoad(object sender, EventArgs e)
		{
			JavaScriptSerializer serializer = new JavaScriptSerializer();

			for (int l = 0; l < Data.Count; l++)
			{
				ProcessDataObject dataObject1;
				if (IsStudent)
				{
					dataObject1 = serializer.Deserialize<ProcessStudentSalaryDataObject>(Data[l]);
				}
				else
				{
					dataObject1 = serializer.Deserialize<ProcessLecturerSalaryDataObject>(Data[l]);
				}
				_dataObjects.Add(dataObject1);
			}

			if (_dataObjects.Count == 0)
			{
				return;
			}

			ProcessDataObject dataObject = _dataObjects[0];

			List<PropertyInfo> propertyInfos = dataObject.GetType().GetProperties().ToList();

			for (int l = 0; l < propertyInfos.Count; l++)
			{
				_table.Columns.Add(propertyInfos[l].Name);
			}

			PopulateGrid();
			DisableEditing();
		}

		private void PopulateGrid()
		{
			for (int l = 0; l < _dataObjects.Count; l++)
			{
				DataRow dataRow = _table.NewRow();
				ProcessDataObject dataObject = _dataObjects[l];
				List<PropertyInfo> propertyInfos = dataObject.GetType().GetProperties().ToList();

				for (int i = 0; i < propertyInfos.Count; i++)
				{
					dataRow[propertyInfos[i].Name] = propertyInfos[i].GetValue(_dataObjects[l]).ToString();
				}
				_table.Rows.Add(dataRow);
			}
			_grid.DataSource = _table;
		}

		private void DisableEditing()
		{
			for (int l = 0; l < _grid.Rows.Count; l++)
			{
				for (int i = 0; i < _grid.Rows[l].Cells.Count; i++)
				{
					_grid.Rows[l].Cells[i].ReadOnly = true;
				}
			}
		}
	}
}