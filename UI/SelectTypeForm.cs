using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Editors;
using University.DataObjects;
using University.Other;

namespace UI
{
	public partial class SelectTypeForm : Form
	{
		private Assembly _dataManagerAssembly;
		private TypeNode _hierarchy;
		private Type _type;

		public SelectTypeForm()
		{
			InitializeComponent();
		}

		public DataChanged DataChanged { get; set; }

		private void MainFormLoad(object sender, EventArgs e)
		{
			_dataManagerAssembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(assembly => assembly.GetName().Name == "University");
			if (_dataManagerAssembly != null)
			{
				List<Type> types = _dataManagerAssembly.GetTypes().Where(type => type.Name == "Entry").ToList();
				if (types.Count == 0)
				{
					return;
				}
				_hierarchy = new TypeNode(types[0]);
			}
			TreeCreator.Create(_hierarchy);
			_treeView.Nodes.Add(_hierarchy.Data.Name, _hierarchy.Data.Name);
			TreeViewCreator.PopulateTreeViewWithHierarchy(_treeView, _hierarchy);
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			if (_type == typeof (Entry))
			{
				DialogResult = DialogResult.None;
				return;
			}
			ActionCreateEditForm action = new ActionCreateEditForm(EditEntryFormMode.Add, null, _type, new List<PropertyInfo>(), DataChanged, false);
			action.InvokeForm();
		}

		private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
			_type = _dataManagerAssembly.GetTypes().Where(t => t.Name == e.Node.Text).ToList()[0];
		}
	}
}