using System;
using System.Windows.Forms;
using Editors;
using University.DataObjects;

namespace UI
{
	public partial class LabelTextBox : UserControl, IEditorValue
	{
		private Entry _entry;
		private EditEntryFormMode _mode;
		private Type _type;

		public LabelTextBox()
		{
			InitializeComponent();
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
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
			get { return _textBox.Text; }
			set
			{
				if (value != null && _mode != EditEntryFormMode.Add)
				{
					_textBox.Text = (string) value;
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
					_textBox.Enabled = false;
				}
			}
		}

		private void TextBoxTextChanged(object sender, EventArgs e)
		{
			if(_entry == null)
				return;
			_entry.GetType().GetProperty(PropertyName).SetValue(_entry, PropertyValue);
		}

		private void LabelTextBoxLoad(object sender, EventArgs e)
		{
			if (_entry == null)
				return;
			PropertyValue = _entry.GetType().GetProperty(PropertyName).GetValue(_entry);
		}
	}
}