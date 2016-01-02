using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Editors;
using University.DataObjects;

namespace UI
{
	public partial class EditEntryForm : Form
	{
		private Entry _entry;
		private EditEntryFormMode _mode;
		private Type _type;

		public EditEntryForm()
		{
			InitializeComponent();
		}

		public List<PropertyInfo> Properties { get; set; }
		public DataChanged DataChanged { get; set; }

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public EditEntryFormMode Mode
		{
			get { return _mode; }
			set { _mode = value; }
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _entry = value; }
		}

		private void EditEntryFormLoad(object sender, EventArgs e)
		{
			List<IEditorValue> wrappers = CreateEntryWrappers();

			//Adjust form size
			Height = (wrappers.Count + 1) * 55;
			Width = MinimumSize.Width;
			MinimumSize = new Size(Width, Height / 100 * 95);

			PopulateControls(wrappers);
		}

		private void PopulateControls(List<IEditorValue> wrappers)
		{
			_layoutEditorControls.RowStyles.Clear();
			for (int l = 0; l < wrappers.Count; l++)
			{
				UserControl control = wrappers[l] as UserControl;
				if (control == null)
				{
					return;
				}
				_layoutEditorControls.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
				control.Dock = DockStyle.Fill;
				try
				{
					_layoutEditorControls.Controls.Add(control, 0, l);
				}
				catch (Exception ex)
				{
				}
			}
		}

		private List<IEditorValue> CreateEntryWrappers()
		{
			List<PropertyInfo> propertyInfos = Properties.Count == 0 ? GetEntryPropertyInfos() : Properties;
			List<IEditorValue> editorValues = new List<IEditorValue>();

			for (int l = 0; l < propertyInfos.Count; l++)
			{
				editorValues.Add(CreateWrapper(ControlsDictionary.Inst[propertyInfos[l].PropertyType], _mode, propertyInfos[l].Name));
			}
			return editorValues;
		}

		private List<PropertyInfo> GetEntryPropertyInfos()
		{
			PropertyInfo[] propertyInfos = _type.GetProperties();
			List<PropertyInfo> filteredProperties = new List<PropertyInfo>();

			for (int i = 0; i < propertyInfos.Count(); i++)
			{
				if (propertyInfos[i].Name == "Id" || propertyInfos[i].Name == "DataType")
				{
					continue;
				}
				filteredProperties.Add(propertyInfos[i]);
			}
			return filteredProperties;
		}

		private IEditorValue CreateWrapper(Type controlType, EditEntryFormMode mode, string propertyName)
		{
			IEditorValue control = Activator.CreateInstance(controlType) as IEditorValue;
			if (control == null)
			{
				return null;
			}
			LinkLabelTextBox linkLabelTextBox = control as LinkLabelTextBox;
			if (linkLabelTextBox != null)
				linkLabelTextBox.DataChanged = DataChanged;
			control.Mode = mode;
			control.Data = _entry;
			control.PropertyName = propertyName;
			control.Type = _type;
			return control;
		}

		private void BtnSaveClick(object sender, EventArgs e)
		{
			if (DataChanged != null)
			{
				DataChanged();
			}
		}
	}
}