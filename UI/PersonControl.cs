using System;
using System.Windows.Forms;
using University.DataObjects;

namespace UI
{
	public partial class PersonControl : UserControl, IEntryControl
	{
		private Entry _entry;

		public PersonControl()
		{
			InitializeComponent();
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _bindingSource.DataSource = _entry = value; }
		}

		private void PersonControlLoad(object sender, EventArgs e)
		{
		}
	}

	public interface IEntryControl
	{
		Entry Entry { get; set; }
	}
}