using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using University.DataManager;
using University.DataObjects;
using University.Other;

namespace UI
{
	public partial class SelectObjectForm : Form
	{
		private Assembly _dataManagerAssembly;
		private TypeNode _hierarchy;
		private Type _type;
		private Guid? exactGuid;
		private string exactType;

		public SelectObjectForm()
		{
			InitializeComponent();
		}

		public string ExactType
		{
			get { return exactType; }
			set { exactType = value; }
		}

		public Guid? ExactGuid
		{
			get { return exactGuid; }
			set { exactGuid = value; }
		}

		public Guid? SelectedItem
		{
			get { return new Guid(_treeView.SelectedNode.Name); }
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			TreeNode node = _treeView.SelectedNode;
			if (node == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(node.Name) || (node.Tag == null && DataManagerLocal.Inst.Dependencies.ContainsKey(exactType) && !_checkBoxHierarchy.Checked) || exactType != node.Parent.Text)
			{
				DialogResult = DialogResult.None;
			}
		}

		private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		private void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			UpdateData();
		}

		private void UpdateData()
		{
			_treeView.Nodes.Clear();
			List<Entry> entries = DataManagerLocal.Inst.Data;
			if (_checkBoxHierarchy.Checked)
			{
				TreeViewCreator.PopulateTreeViewWithDataHierarchy(_treeView, entries, exactType, exactGuid);
			}
			else
			{
				TreeViewCreator.CreateHierarchyTreeView(_treeView);
			}
		}
	}
}