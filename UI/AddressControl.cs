using System;
using System.Windows.Forms;
using University.DataObjects;

namespace UI
{
	public partial class AddressControl : UserControl, IEntryControl
	{
		private Entry _entry;

		public AddressControl()
		{
			InitializeComponent();
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _bindingSource.DataSource = _entry = value; }
		}

		private void AddressControlLoad(object sender, EventArgs e)
		{
		}
	}
}