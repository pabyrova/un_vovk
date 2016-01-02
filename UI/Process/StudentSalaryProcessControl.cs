using System;
using System.Windows.Forms;

namespace UI.Process
{
	public partial class StudentSalaryProcessControl : UserControl, IProcessControl
	{
		public StudentSalaryProcessControl()
		{
			InitializeComponent();
			this._salaryProcessControl.DataObject = null;
			this._salaryProcessControl.Location = new System.Drawing.Point(3, 3);
			this._salaryProcessControl.Name = "_salaryProcessControl";
			this._salaryProcessControl.Size = new System.Drawing.Size(200, 55);
			this._salaryProcessControl.TabIndex = 0;
		}

		public ProcessDataObject DataObject
		{
			get { return null; }
			set
			{
				_salaryProcessControl.ValueChanged = UpdateValue;
				_salaryProcessControl.DataObject = value;
				processStudentSalaryDataObjectBindingSource.DataSource = value;
			}
		}

		public double FinalSalary
		{
			get { return _salaryProcessControl.FinalSalary; }
			set { }
		}

		private void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			UpdateValue();
		}

		private void UpdateValue()
		{
			double value = (double) _numAdditionalSalary.Value;
			_salaryProcessControl.FinalSalary = _checkAdditional.Checked ? _salaryProcessControl.StartSalary + value : _salaryProcessControl.StartSalary;
		}

		private void NumAdditionalSalaryValueChanged(object sender, EventArgs e)
		{
			UpdateValue();
		}
	}
}