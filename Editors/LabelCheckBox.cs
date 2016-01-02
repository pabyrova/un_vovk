using System;
using System.Windows.Forms;
using Editors;
using University.DataObjects;

namespace UI
{
	public partial class LabelCheckBox : UserControl, IEditorValue
	{
		private Entry _entry;
		private EditEntryFormMode _mode;

		public LabelCheckBox()
		{
			InitializeComponent();
		}

		public Entry Data
		{
			get { return _entry; }
			set
			{
				if (value == null)
				{
					return;
				}
				_entry = value;
			}
		}

		public string PropertyName
		{
			get { return _label.Text; }
			set
			{
				if (value != null)
				{
					_label.Text = value;
				}
			}
		}

		public object PropertyValue
		{
			get { return _checkBox.Checked; }
			set
			{
				if (value != null && _mode != EditEntryFormMode.Add)
				{
					_checkBox.Checked = (bool) value;
				}
			}
		}

		public EditEntryFormMode Mode
		{
			set
			{
				_mode = value;
				if (_mode == EditEntryFormMode.View)
				{
					_checkBox.Enabled = false;
				}
			}
		}

		private void CheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (_entry == null)
				return;
			_entry.GetType().GetProperty(PropertyName).SetValue(_entry, PropertyValue);
		}

		private void LabelCheckBoxLoad(object sender, EventArgs e)
		{
			if (_entry == null)
				return;
			PropertyValue = _entry.GetType().GetProperty(PropertyName).GetValue(_entry);
		}
	}
}