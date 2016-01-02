using System;
using System.Windows.Forms;
using Editors;
using University.DataObjects;

namespace UI
{
	public partial class LabelNumericUpDown : UserControl, IEditorValue
	{
		private Entry _entry;
		private EditEntryFormMode _mode;
		private Type _type;

		public LabelNumericUpDown()
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
			get { return _numericUpDown.Value; }
			set
			{
				if (value != null && _mode != EditEntryFormMode.Add)
				{
					Type type = value.GetType();
					_numericUpDown.Value = (int)value;
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
					_numericUpDown.Enabled = false;
				}
			}
		}

		private void NumericUpDownValueChanged(object sender, EventArgs e)
		{
			if (_entry == null)
				return;
			var value = Decimal.ToInt32((decimal)PropertyValue);
			_entry.GetType().GetProperty(PropertyName).SetValue(_entry, value);
		}

		private void LabelNumericUpDownLoad(object sender, EventArgs e)
		{
			if (_entry == null)
				return;
			PropertyValue = _entry.GetType().GetProperty(PropertyName).GetValue(_entry);
		}
	}
}