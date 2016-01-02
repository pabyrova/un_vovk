using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.DataObjects;

namespace UI
{
	public partial class LecturerControl : UserControl,IEntryControl
	{
		private Entry _entry;
		public LecturerControl()
		{
			InitializeComponent();
			personControl1.Entry = null;
			personControl1.Location = new Point(3, 16);
			personControl1.Name = "personControl1";
			personControl1.Size = new Size(321, 54);
			personControl1.TabIndex = 0;
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _entry = personControl1.Entry = value; }
		}
	}
}
