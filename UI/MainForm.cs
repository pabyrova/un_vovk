using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Editors;
using University.DataManager;
using University.DataObjects;
using University.Other;

namespace UI
{
	public partial class MainForm : Form
	{
		private Assembly _dataManagerAssembly;
		private TypeNode _hierarchy;

		public MainForm()
		{
			InitializeComponent();

			//Entry lUniversity1 = new University.DataObjects.University(Guid.NewGuid(), "Ivan Franko", "University");
			//Entry lUniversity2 = new University.DataObjects.University(Guid.NewGuid(), "Polytechnic", "University");

			//Entry lFaculty1 = new Faculty(Guid.NewGuid(), "Linguistic", lUniversity1.Id, "Faculty");
			//Entry lFaculty2 = new Faculty(Guid.NewGuid(), "Math", lUniversity1.Id, "Faculty");
			//Entry lFaculty3 = new Faculty(Guid.NewGuid(), "Applied Mathematic", lUniversity1.Id, "Faculty");
			//Entry lFaculty4 = new Faculty(Guid.NewGuid(), "Physic", lUniversity2.Id, "Faculty");
			//Entry lFaculty5 = new Faculty(Guid.NewGuid(), "Linguistic", lUniversity2.Id, "Faculty");

			//Entry lDepartment1 = new Department(Guid.NewGuid(), "Info System", lFaculty3.Id, "Department");
			//Entry lDepartment2 = new Department(Guid.NewGuid(), "Discrete Analysis", lFaculty3.Id, "Department");
			//Entry lDepartment3 = new Department(Guid.NewGuid(), "Ukraine language", lFaculty5.Id, "Department");
			//Entry lDepartment4 = new Department(Guid.NewGuid(), "Math analysis", lFaculty2.Id, "Department");

			//Entry lTeam1 = new Team(Guid.NewGuid(), "PMI", 42, lDepartment1.Id, "Team");
			//Entry lTeam2 = new Team(Guid.NewGuid(), "PMI", 32, lDepartment1.Id, "Team");
			//Entry lTeam3 = new Team(Guid.NewGuid(), "PMI", 43, lDepartment2.Id, "Team");
			//Entry lTeam4 = new Team(Guid.NewGuid(), "PM", 12, lDepartment4.Id, "Team");


			//Entry lAdress1 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress2 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress3 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress4 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress5 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress6 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress7 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress8 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress9 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");
			//Entry lAdress10 = new Address(Guid.NewGuid(), "Ukraine", "Lviv", "University", 1, 1, "Address");

			//Entry lStudent1 = new Student(Guid.NewGuid(), 20, "Volodya", "Pabyr", "+380", lAdress1.Id, lTeam1.Id, "Student");
			//Entry lStudent2 = new Student(Guid.NewGuid(), 25, "Kolya", "Yershov", "+380", lAdress2.Id, lTeam2.Id, "Student");
			//Entry lStudent3 = new Student(Guid.NewGuid(), 19, "Solya", "Demkiv", "+380", lAdress3.Id, lTeam1.Id, "Student");
			//Entry lStudent4 = new Student(Guid.NewGuid(), 20, "Yura", "Olex", "+380", lAdress4.Id, lTeam1.Id, "Student");
			//Entry lStudent5 = new Student(Guid.NewGuid(), 20, "Ivan", "Paber", "+380", lAdress5.Id, lTeam3.Id, "Student");
			//Entry lStudent6 = new Student(Guid.NewGuid(), 20, "Andriy", "Dyachuk", "+380", lAdress6.Id, lTeam4.Id, "Student");

			//Entry lLecturer1 = new Lecturer(Guid.NewGuid(), 50, "Petro", "Vagin", "+380", lAdress7.Id, lDepartment1.Id, "Lecturer");
			//Entry lLecturer2 = new Lecturer(Guid.NewGuid(), 50, "Volodymyr", "Vovk", "+380", lAdress8.Id, lDepartment2.Id, "Lecturer");
			//Entry lLecturer3 = new Lecturer(Guid.NewGuid(), 50, "Gregoriy", "Shynkarenko", "+380", lAdress9.Id, lDepartment1.Id, "Lecturer");
			//Entry lLecturer4 = new Lecturer(Guid.NewGuid(), 50, "Svatoslav", "Tarasyuk", "+380", lAdress10.Id, lDepartment4.Id, "Lecturer");

			//List<Entry> lEntries = new List<Entry>
			//{
			//	lUniversity1, lUniversity2, lFaculty1, lFaculty2, lFaculty3, lFaculty4, lFaculty5, lDepartment1, lDepartment2, lDepartment3, lDepartment4, lTeam1, lTeam2, lTeam3, lTeam4, lAdress1, lAdress2,
			//	lAdress3, lAdress4, lAdress5, lAdress6, lAdress7, lAdress8, lAdress9, lAdress10, lStudent1, lStudent2, lStudent3, lStudent4, lStudent5, lStudent6, lLecturer1, lLecturer2, lLecturer3, lLecturer4,
			//};

			//for (int l = 0; l < lEntries.Count; l++)
			//{
			//	DataManagerLocal.Inst.Insert(lEntries[l]);
			//}
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void UpdateData()
		{
			_treeView.Nodes.Clear();
			List<Entry> entries = DataManagerLocal.Inst.Data;
			if (_checkBoxHierarchy.Checked)
			{
				TreeViewCreator.PopulateTreeViewWithDataHierarchy(_treeView, entries, string.Empty, null);
			}
			else
			{
				TreeViewCreator.CreateHierarchyTreeView(_treeView);
			}
		}

		private void BtnEditClick(object sender, EventArgs e)
		{
			TreeNode node = _treeView.SelectedNode;
			if (node == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(node.Name))
			{
				return;
			}
			List<Entry> entries = DataManagerLocal.Inst.Select(node.Parent.Text, new Guid(node.Name));
			if (entries.Count == 0)
			{
				return;
			}
			Entry entry = entries[0];


			List<PropertyInfo> properties;
			bool isCusom;
			using (FilterPropertiesForm form = new FilterPropertiesForm())
			{
				form.Type = entry.GetType();

				if (form.ShowDialog() == DialogResult.Cancel)
				{
					return;
				}

				properties = form.Properties;
				isCusom = form.IsCustom;
			}

			ActionCreateEditForm action = new ActionCreateEditForm(EditEntryFormMode.Edit, entry, entry.GetType(), properties, UpdateData, isCusom);
			action.InvokeForm();
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			using (SelectTypeForm form = new SelectTypeForm())
			{
				form.DataChanged = UpdateData;
				form.ShowDialog();
			}
			UpdateData();
		}

		private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		private void BtnDeleteClick(object sender, EventArgs e)
		{
			TreeNode node = _treeView.SelectedNode;
			if (string.IsNullOrEmpty(node.Name))
			{
				return;
			}
			List<Entry> entries = DataManagerLocal.Inst.Select(node.Parent.Text, new Guid(node.Name));
			if (entries.Count == 0)
			{
				return;
			}
			Entry entry = entries[0];

			DataManagerLocal.Inst.Delete(entry);
			UpdateData();
		}

		private void AddSalaryToolStripMenuItemClick(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			ActionCreateSalaryProcess lProcess = new ActionCreateSalaryProcess(entry);
			lProcess.Run();
		}

		private void TreeViewMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point p = new Point(e.X, e.Y);

				TreeNode node = _treeView.GetNodeAt(p);

				if (node == null || node.Parent == null)
				{
					return;
				}
				_treeView.SelectedNode = node;
				string text = node.Parent.Text;
				if (text != "Student" && text != "Lecturer")
				{
					return;
				}

				switch (text)
				{
					case "Lecturer":
						_contextLecturerMenu.Show(_treeView, p);
						break;
					case "Student":
						_contextStudentMenu.Show(_treeView, p);
						break;
				}
			}
		}

		private void AddScholarshipToolStripMenuItemClick(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			ActionCreateSalaryProcess lProcess = new ActionCreateSalaryProcess(entry);
			lProcess.Run();
		}

		private Entry GetEntryFromSelectedNode()
		{
			TreeNode node = _treeView.SelectedNode;
			if (node == null || node.Parent == null)
			{
				return null;
			}
			return DataManagerLocal.Inst.Select(node.Parent.Text, new Guid(node.Name))[0];
		}

		private void ViewScholarshipsToolStripMenuItemClick(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			ActionViewProcess process = new ActionViewProcess(entry, true);
			process.Run();
		}

		private void ViewSalariesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			ActionViewProcess process = new ActionViewProcess(entry, false);
			process.Run();
		}

		private void ClearToolStripMenuItemClick(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			TruncateProcess(entry);
		}

		private void TruncateProcess(Entry entry)
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
					cm.CommandText = "DELETE FROM Process WHERE DataType='" + entry.DataType + "' AND EntryId = '" + entry.Id + "'";
					cm.ExecuteNonQuery();
				}
			}
		}

		private void ClearToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Entry entry = GetEntryFromSelectedNode();
			if (entry == null)
			{
				return;
			}
			TruncateProcess(entry);
		}

		private void CheckBoxHierarchyCheckedChanged(object sender, EventArgs e)
		{
			UpdateData();
		}
	}

	public delegate void DataChanged();
}