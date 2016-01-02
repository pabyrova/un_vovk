using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace University.Other
{
	public class TypeNode
	{
		private readonly List<TypeNode> _children = new List<TypeNode>();

		public TypeNode(Type data)
		{
			Data = data;
		}

		public Type Data { get; set; }

		public List<TypeNode> Children
		{
			get { return _children; }
		}

		public void AddChild(TypeNode node)
		{
			_children.Add(node);
		}
	}

	public static class TreeCreator
	{
		private static readonly List<Type> DataOjecTypes;

		static TreeCreator()
		{
			DataOjecTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.Namespace == "University.DataObjects").ToList();
		}

		public static void Create(TypeNode node)
		{
			for (int l = 0; l < DataOjecTypes.Count; l++)
			{
				Type lType = DataOjecTypes[l];
				if (lType.IsSubclassOf(node.Data) && lType.BaseType == node.Data)
				{
					TypeNode lNode = new TypeNode(lType);
					node.AddChild(lNode);
					Create(lNode);
				}
			}
		}
	}
}