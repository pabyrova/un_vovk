using System;
using System.Windows.Forms;
using UI.Process;
using University.DataObjects;

namespace UI
{
	public partial class ProcessForm : Form
	{
		public ProcessForm()
		{
			InitializeComponent();
		}

		public Entry Entry { get; set; }
		public ProcessDataObject Data { get; set; }
		public IProcessControl Control { get; set; }

		public double KostylFinalMoney
		{
			get
			{
				return Control.FinalSalary;
			}
		}

		private void EditEntryFormLoad(object sender, EventArgs e)
		{
			Control.DataObject = Data;

			UserControl userControl = (UserControl) Control;
			userControl.Dock = DockStyle.Fill;
			_layoutEditorControls.Controls.Add(userControl, 0, 0);
			userControl.Show();
		}
	}
}