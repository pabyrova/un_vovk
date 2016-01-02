using System;
using System.Windows.Forms;
using Editors;
using University.DataObjects;

namespace UI
{
	public partial class LinkLabelTextBox : UserControl, IEditorValue
	{
		private Entry _entry;
		private EditEntryFormMode _mode;
		private string _propertyName;

		public LinkLabelTextBox()
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
			get { return !string.IsNullOrEmpty(_propertyName)?_propertyName:_label.Text; }
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
					_textBox.Text = value.ToString();
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
				//else if (_mode == EditEntryFormMode.Add)
				//_label.LinkClicked -= LabelLinkClicked;
			}
		}

		private void TextBoxTextChanged(object sender, EventArgs e)
		{
			if(_entry == null)
				return;
			_entry.GetType().GetProperty(PropertyName).SetValue(_entry, new Guid((string)PropertyValue));
		}

		private void LinkLabelTextBoxLoad(object sender, EventArgs e)
		{
			int index = PropertyName.IndexOf("_", StringComparison.Ordinal);
			if (_entry == null)
			{
				PropertyName = PropertyName.Substring(0, index);
				return;
			}
			PropertyValue = _entry.GetType().GetProperty(PropertyName).GetValue(_entry);
			_propertyName = PropertyName;
			PropertyName = PropertyName.Substring(0, index);
		}

		private void LabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		     ActionCreate
		}
	}
}