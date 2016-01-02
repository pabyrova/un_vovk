using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Editors;
using University.DataManager;
using University.DataObjects;

namespace UI
{
	public class ActionCreateEditForm
	{
		private Entry _entry;
		private readonly DataChanged _dataChanged;
		private readonly bool _isCustom;
		private readonly EditEntryFormMode _mode;
		private readonly List<PropertyInfo> _properties;
		private readonly Type _type;

		public ActionCreateEditForm(EditEntryFormMode mode, Entry entry, Type type, List<PropertyInfo> properties, DataChanged dataChanged, bool isCusom)
		{
			_mode = mode;
			_entry = entry;
			_type = type;
			_properties = properties;
			_dataChanged = dataChanged;
			_isCustom = isCusom;
			if (_entry == null)
			{
				_entry = Activator.CreateInstance(type) as Entry;
				_entry.Id = Guid.NewGuid();
			}
		}

		public Entry InvokeForm()
		{
			if (_isCustom)
			{
				using (CusomEditForm form = new CusomEditForm())
				{
					form.Entry = _entry;
					if (form.ShowDialog() == DialogResult.Cancel)
					{
						return null;
					}
					_entry = form.Entry;
				}
			}
			else
			{
				using (EditEntryForm form = new EditEntryForm())
				{
					form.Mode = _mode;
					form.Entry = _entry == null ? null : _entry.Clone();
					form.Type = _type;
					form.Properties = _properties;
					form.DataChanged = _dataChanged;
					if (form.ShowDialog() == DialogResult.Cancel)
					{
						return null;
					}
					_entry = form.Entry;
				}
			}
			if (_mode == EditEntryFormMode.Edit)
			{
				DataManagerLocal.Inst.Update(_entry);
			}
			if (_mode == EditEntryFormMode.Add)
			{
				DataManagerLocal.Inst.Insert(_entry);
			}
			if (_dataChanged != null)
			{
				_dataChanged();
			}
			return _entry;
		}
	}
}