using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	

	public class ControlsDictionary
	{
		private readonly Dictionary<Type, Type> _dictionary;
		private static readonly ControlsDictionary Instance;

		private ControlsDictionary()
		{
			_dictionary = new Dictionary<Type, Type>();
			_dictionary.Add(typeof(string),typeof(LabelTextBox));
			_dictionary.Add(typeof(int),typeof(LabelNumericUpDown));
			_dictionary.Add(typeof(Guid), typeof(LabelTextBox));
			_dictionary.Add(typeof(Guid?), typeof(LinkLabelTextBox));
			_dictionary.Add(typeof(bool), typeof(LabelCheckBox));
		}

		static ControlsDictionary()
		{
			Instance = new ControlsDictionary();
		}

		public static ControlsDictionary Inst
		{
			get { return Instance; }
		}

		public Type this[Type type]
		{
			get
			{
				if (!_dictionary.ContainsKey(type))
					return null;
				return _dictionary[type];
			}
		}
	}
}
