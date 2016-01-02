using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using University.DataManager;
using University.DataObjects;
using University.Other;

namespace UI
{
	internal static class TreeViewCreator
	{
		private static readonly Assembly _dataManagerAssembly;

		static TreeViewCreator()
		{
			_dataManagerAssembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(assembly => assembly.GetName().Name == "University");
		}

		public static void PopulateTreeViewWithHierarchy(TreeView tree, TypeNode type)
		{
			for (int l = 0; l < type.Children.Count; l++)
			{
				GetNode(type.Data.Name, tree).Nodes.Add(type.Children[l].Data.Name);
				PopulateTreeViewWithHierarchy(tree, type.Children[l]);
			}
		}

		private static TreeNode GetNode(string key, TreeView tree)
		{
			List<TreeNode> lNodes = new List<TreeNode>();
			foreach (TreeNode lItem in tree.Nodes)
			{
				lNodes.Add(lItem);
			}
			return GetNode(lNodes, key);
		}

		private static TreeNode GetNode(List<TreeNode> nodes, string key)
		{
			List<TreeNode> lNodes = new List<TreeNode>();
			for (int l = 0; l < nodes.Count; l++)
			{
				if (nodes[l].Text == key)
				{
					return nodes[l];
				}
				for (int lN = 0; lN < nodes[l].Nodes.Count; lN++)
				{
					lNodes.Add(nodes[l].Nodes[lN]);
				}
			}
			return lNodes.Count == 0 ? null : GetNode(lNodes, key);
		}

		public static void PopulateTreeViewWithDataHierarchy(TreeView tree, List<Entry> data, string exactType, Guid? exactGuid)
		{
			for (int l = 0; l < data.Count; l++)
			{
				if (!string.IsNullOrEmpty(exactType))
				{
					if (data[l].DataType == exactType && data[l].Id != exactGuid)
					{
						CreateBranch(tree, data[l]);
					}
					continue;
				}
				CreateBranch(tree, data[l]);
			}
		}

		private static void CreateBranch(TreeView tree, Entry entry)
		{
			Stack<Entry> stack = CreateDownStack(entry);
			if (stack.Count == 0)
			{
				return;
			}
			TreeNode previousNode = GetNode(stack.Peek().GetType().Name, tree);
			if (previousNode == null)
			{
				previousNode = tree.Nodes.Add(stack.Peek().GetType().Name);
			}
			if (stack.Count > 1)
			{
				stack.Pop();
			}

			while (stack.Peek() != null)
			{
				TreeNode node = GetNode(stack.Peek().GetType().Name, tree);
				if (node == null)
				{
					node = previousNode.Nodes.Add(stack.Peek().GetType().Name);
				}
				previousNode = node;
				if (stack.Count == 1)
				{
					break;
				}
				stack.Pop();
			}
			Entry peek = stack.Peek();
			List<Entry> entries = DataManagerLocal.Inst.Select(peek.DataType, peek.Id);
			if (entries.Count == 0)
			{
				return;
			}
			Entry finalEntry = entries[0];
			previousNode.Nodes.Add(finalEntry.Id.ToString(), finalEntry.ToString());
		}

		private static Stack<Entry> CreateDownStack(Entry entry)
		{
			Type type1 = _dataManagerAssembly.GetTypes().Where(type => type.Name == entry.DataType).ToList()[0];
			Entry entry1 = Activator.CreateInstance(type1) as Entry;
			entry1.Id = entry.Id;
			entry1.DataType = entry.DataType;
			Stack<Entry> stack = new Stack<Entry>();
			Entry lEntry = entry1;
			while (lEntry.GetType() != typeof (Entry))
			{
				stack.Push(lEntry);
				lEntry = GetBaseInst(lEntry);
			}
			return stack;
		}

		private static Entry GetBaseInst(Entry entry)
		{
			Type lBaseType = entry.GetType().BaseType;
			if (lBaseType != null)
			{
				return CreateTypeInst(lBaseType, entry, false);
			}
			return null;
		}

		private static Entry CreateTypeInst(Type type, Entry data, bool up)
		{
			PropertyInfo[] lProperties = up ? data.GetType().GetProperties() : type.GetProperties();

			Entry lEntry = Activator.CreateInstance(type) as Entry;

			for (int l = 0; l < lProperties.Length; l++)
			{
				lProperties[l].SetValue(lEntry, GetPropValue(data, lProperties[l].Name));
			}
			return lEntry;
		}

		private static object GetPropValue(object src, string propName)
		{
			return src.GetType().GetProperty(propName).GetValue(src, null);
		}

		#region HierarchyTreeView

		public static void CreateHierarchyTreeView(TreeView tree)
		{
			tree.Nodes.Add(DataManagerLocal.Inst.Dependencies.First().Key);

			BuildCombineTreeView(tree.Nodes[0]);
		}

		private static void BuildCombineTreeView(TreeNode treeNode)
		{
			Entry entry = treeNode.Tag as Entry;
			if (entry != null)
			{
				if (!DataManagerLocal.Inst.Dependencies.ContainsKey(entry.DataType))
				{
					return;
				}
				List<string> list = DataManagerLocal.Inst.Dependencies[entry.DataType];
				for (int l = 0; l < list.Count; l++)
				{
					TreeNode node = treeNode.Nodes.Add(entry.Id.ToString(), list[l]);
					BuildCombineTreeView(node);
				}
			}
			else
			{
				string name = treeNode.Text;
				List<Entry> entries = DataManagerLocal.Inst.Data;

				for (int l = 0; l < entries.Count; l++)
				{
					if (entries[l].DataType == name)
					{
						Entry entry1 = DataManagerLocal.Inst.Select(entries[l].DataType, entries[l].Id)[0];
						if (!string.IsNullOrEmpty(treeNode.Name))
						{
							if (!HasEntryRefId(entry1, new Guid(treeNode.Name)))
							{
								continue;
							}
						}
						TreeNode node = treeNode.Nodes.Add(entry1.Id.ToString(), entry1.ToString());
						node.Tag = entry1;
						BuildCombineTreeView(node);
					}
				}
			}
		}

		private static bool HasEntryRefId(Entry entry1, Guid id)
		{
			List<PropertyInfo> list = entry1.GetType().GetProperties().ToList();
			for (int l = 0; l < list.Count; l++)
			{
				bool contains = list[l].Name.Contains("_Id");
				if (!contains)
				{
					continue;
				}
				if ((Guid) list[l].GetValue(entry1) == id)
				{
					return true;
				}
			}
			return false;
		}

		#endregion
	}
}