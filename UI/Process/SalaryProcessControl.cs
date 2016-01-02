using System;
using System.Windows.Forms;

namespace UI.Process
{
	public partial class SalaryProcessControl : UserControl,IProcessControl
	{
		public Action ValueChanged;

		public SalaryProcessControl()
		{
			InitializeComponent();
		}

		public double StartSalary
		{
			get { return (double) _numStartSalary.Value; }
		}

		public double FinalSalary
		{
			set { _numFinalSalary.Value = (decimal) value; }
			get { return (double)_numFinalSalary.Value; }
		}

		public ProcessDataObject DataObject
		{
			get { return null; }
			set { processSalaryDataObjectBindingSource.DataSource = value; }
		}

		private void NumStartSalaryValueChanged(object sender, System.EventArgs e)
		{
			ValueChanged();
		}
	}
}