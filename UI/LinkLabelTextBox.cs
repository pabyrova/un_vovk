using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Editors;
using University.DataManager;
using University.DataObjects;

namespace UI
{
	public partial class LinkLabelTextBox : UserControl, IEditorValue
	{
		private Entry _entry;
		private EditEntryFormMode _mode;
		private string _propertyName;
		private string _tableName;
		private Type _type;

		public LinkLabelTextBox()
		{
			InitializeComponent();
		}

		public DataChanged DataChanged { get; set; }

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
			get { return !string.IsNullOrEmpty(_propertyName) ? _propertyName : _label.Text; }
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
				if (value != null)
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
				_textBox.Hide();
				_fakeTextBox.Enabled = false;
				if (_mode == EditEntryFormMode.Edit)
				{
					_btnEdit.Text = "Edit";
				}
				if (_mode == EditEntryFormMode.View)
				{
					_btnEdit.Text = "Edit";
					_btnEdit.Enabled = false;
				}
				//else if (_mode == EditEntryFormMode.Add)
				//_label.LinkClicked -= LabelLinkClicked;
			}
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		private void TextBoxTextChanged(object sender, EventArgs e)
		{
			if (_entry == null)
			{
				return;
			}
			_entry.GetType().GetProperty(PropertyName).SetValue(_entry, new Guid((string) PropertyValue));
			if (!string.IsNullOrEmpty(_tableName))
			{
				Entry entry = DataManagerLocal.Inst.Select(_tableName, new Guid((string) PropertyValue))[0];
				_fakeTextBox.Text = entry.ToString();
			}
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
			_tableName = PropertyName = PropertyName.Substring(0, index);
			TextBoxTextChanged(_textBox, new EventArgs());
		}

		private void LabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (string.IsNullOrEmpty((string) PropertyValue))
			{
				return;
			}
			List<Entry> entries = DataManagerLocal.Inst.Select(_tableName, new Guid((string) PropertyValue));
			if (entries.Count == 0)
			{
				return;
			}
			Entry entry = DataManagerLocal.Inst.Select(_tableName, new Guid((string) PropertyValue))[0];
			ActionCreateEditForm action = new ActionCreateEditForm(EditEntryFormMode.Edit, entry, entry.GetType(), new List<PropertyInfo>(), DataChanged, false);
			action.InvokeForm();
			TextBoxTextChanged(this, new EventArgs());
		}

		private void BtnEditClick(object sender, EventArgs e)
		{
			using (SelectObjectForm form = new SelectObjectForm())
			{
				form.ExactType = _label.Text;
				if (!string.IsNullOrEmpty((string)PropertyValue))
				{
					form.ExactGuid = new Guid(PropertyValue.ToString());
				}

				if (form.ShowDialog() == DialogResult.Cancel)
				{
					return;
				}
				PropertyValue = form.SelectedItem;
			}
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			Assembly lAssembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(assembly => assembly.GetName().Name == "University");
			if (lAssembly != null)
			{
				Type type = lAssembly.GetType("University.DataObjects." + _tableName);
				ActionCreateEditForm action = new ActionCreateEditForm(EditEntryFormMode.Add, null, type, new List<PropertyInfo>(), DataChanged, false);
				Entry entry = action.InvokeForm();
				if(entry == null)
					return;
				PropertyValue = entry.Id;
			}
			TextBoxTextChanged(this, new EventArgs());
		}
	}
}