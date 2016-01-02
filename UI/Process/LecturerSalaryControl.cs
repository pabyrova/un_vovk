using System;
using System.Windows.Forms;

namespace UI.Process
{
	public partial class LecturerSalaryControl : UserControl, IProcessControl
	{
		public LecturerSalaryControl()
		{
			InitializeComponent();
		}

		public ProcessDataObject DataObject
		{
			get { return null; }
			set
			{
				_salaryProcessControl.ValueChanged = RecalculateFinalSalary;
				_salaryProcessControl.DataObject = value;
				processLecturerSalaryDataObjectBindingSource.DataSource = value;
			}
		}

		public double FinalSalary
		{
			get { return _salaryProcessControl.FinalSalary; }
			set {  }
		}

		private void NumDegreeValueChanged(object sender, EventArgs e)
		{
			RecalculateFinalSalary();
		}

		private void NumPhDValueChanged(object sender, EventArgs e)
		{
			RecalculateFinalSalary();
		}

		private void NumMeritYearsValueChanged(object sender, EventArgs e)
		{
			RecalculateFinalSalary();
		}

		private void NumTaxValueChanged(object sender, EventArgs e)
		{
			RecalculateFinalSalary();
		}

		private void RecalculateFinalSalary()
		{
			double startSalary = _salaryProcessControl.StartSalary;

			double degree = (double) _numDegree.Value / 100 * startSalary;
			double phd = (double) _numPhD.Value / 100 * startSalary;
			double merityears = (double) _numMeritYears.Value / 100 * startSalary;
			double tax = (double) _numTax.Value / 100 * startSalary;

			_salaryProcessControl.FinalSalary = startSalary + degree + phd + merityears - tax;
		}
	}

	public interface IProcessControl
	{
		ProcessDataObject DataObject { get; set; }
		double FinalSalary { get; set; }
	}
}