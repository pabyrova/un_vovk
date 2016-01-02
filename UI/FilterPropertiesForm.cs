using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace UI
{
	public partial class FilterPropertiesForm : Form
	{
		private readonly List<CheckBox> _checkBoxes = new List<CheckBox>();
		private readonly PropertiesSettings _settingsControl = new PropertiesSettings();

		public FilterPropertiesForm()
		{
			InitializeComponent();
		}

		public bool IsCustom {
			get { return _checkCustom.Checked; }
		}
		public Type Type { get; set; }

		public List<PropertyInfo> Properties
		{
			get
			{
				List<PropertyInfo> list = GetCheckedProperties();
				list.Sort((a, b) =>
				{
					if (_settingsControl.Result == 0)
					{
						return String.Compare(a.Name, b.Name, StringComparison.Ordinal);
					}
					return String.Compare(b.Name, a.Name, StringComparison.Ordinal);
				});
				return list;
			}
		}

		private void FilterPropertiesFormLoad(object sender, EventArgs e)
		{
			List<PropertyInfo> properties = Type.GetProperties().ToList();

			for (int i = 0; i < properties.Count; i++)
			{
				if (properties[i].Name == "Id" || properties[i].Name == "DataType")
				{
					continue;
				}
				CheckBox checkBox = new CheckBox();
				string name = properties[i].Name;
				int index = name.IndexOf("_", StringComparison.Ordinal);
				if (index != -1)
				{
					name = name.Substring(0, index);
				}
				checkBox.Text = name;
				checkBox.Tag = properties[i];
				_checkBoxes.Add(checkBox);
			}

			Height = (_checkBoxes.Count + 2) * 55;

			PopulateCheckBoxes();
		}

		private List<PropertyInfo> GetCheckedProperties()
		{
			List<PropertyInfo> filteredProp = new List<PropertyInfo>();

			for (int i = 0; i < _checkBoxes.Count; i++)
			{
				if (_checkBoxes[i].Checked)
				{
					filteredProp.Add((PropertyInfo) _checkBoxes[i].Tag);
				}
			}
			return filteredProp;
		}

		private void PopulateCheckBoxes()
		{
			_layoutTablePanel.RowStyles.Clear();
			for (int l = 0; l < _checkBoxes.Count; l++)
			{
				_layoutTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
				_checkBoxes[l].Dock = DockStyle.Fill;
				try
				{
					_layoutTablePanel.Controls.Add(_checkBoxes[l], 0, l + 1);
				}
				catch (Exception ex)
				{
				}
			}
			_layoutTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
			_settingsControl.Dock = DockStyle.Fill;
			_layoutTablePanel.Controls.Add(_settingsControl, 0, _layoutTablePanel.RowStyles.Count);
			_layoutTablePanel.RowStyles.RemoveAt(1);
		}

		private void CheckCustomCheckedChanged(object sender, EventArgs e)
		{
			DisableCheckBoxes(_checkCustom.Checked);
		}

		private void DisableCheckBoxes(bool disable)
		{
			for (int l = 0; l < _checkBoxes.Count; l++)
			{
				_checkBoxes[l].Enabled = !disable;
			}
			_settingsControl.Enabled = !disable;
		}
	}
}