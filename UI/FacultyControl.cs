﻿using System;
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
	public partial class FacultyControl : UserControl,IEntryControl
	{
		private Entry _entry;
		public FacultyControl()
		{
			InitializeComponent();
		}

		public Entry Entry
		{
			get { return _entry; }
			set { _bindingSource.DataSource = _entry = value; }
		}
	}
}
