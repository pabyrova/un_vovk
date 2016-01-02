using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DataObjects;

namespace Editors
{

	public enum EditEntryFormMode
	{
		Add = 1,
		Edit = 2,
		View = 4
	}

	public interface IEditorValue
	{
		Entry Data { get; set; }
		string PropertyName { get; set; }
		object PropertyValue { get; set; }
		EditEntryFormMode Mode { set; }
		Type Type { get; set; }
	}
	public delegate void CreateForm(params string[] parameters);

	public delegate bool ValueChanged(string name, object value);
}
