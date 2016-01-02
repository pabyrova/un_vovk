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
	public partial class CusomEditForm : Form
	{
		public Entry Entry { get; set; }

		public CusomEditForm()
		{
			InitializeComponent();
		}

		private void EditEntryFormLoad(object sender, EventArgs e)
		{
			Assembly lAssembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(assembly => assembly.GetName().Name == "UI");
			if (lAssembly != null)
			{
				Type type = lAssembly.GetType("UI." + Entry.GetType().Name + "Control");
				IEntryControl entryControl = Activator.CreateInstance(type) as IEntryControl;

				if (entryControl == null)
				{
					return;
				}

				entryControl.Entry = Entry;

				UserControl userControl = (UserControl)entryControl;
				userControl.Dock = DockStyle.Fill;
				_layoutEditorControls.Controls.Add(userControl, 0, 0);
				userControl.Show();
			}
		}
	}
}