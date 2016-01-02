using System;
using System.Drawing;
using System.Windows.Forms;
using University.DataObjects;

namespace UI
{
	public partial class StudentControl : UserControl, IEntryControl
	{
		private Entry _entry;

		public StudentControl()
		{
			InitializeComponent();
			// 
			// personControl1
			// 
			personControl1.Entry = null;
			personControl1.Location = new Point(3, 16);
			personControl1.Name = "personControl1";
			personControl1.Size = new Size(321, 54);
			personControl1.TabIndex = 2;
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _entry = personControl1.Entry = value; }
		}

		private void StudentControlLoad(object sender, EventArgs e)
		{
		}
	}
}