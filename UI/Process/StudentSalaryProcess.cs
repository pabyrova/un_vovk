namespace UI.Process
{
	internal class StudentSalaryProcess : SalaryProcess
	{
		private readonly StudentSalaryProcessControl _salaryControl = new StudentSalaryProcessControl();

		public StudentSalaryProcess()
		{
		}

		public override IProcessControl GetView()
		{
			return _salaryControl;
		}

		public StudentSalaryProcess(ProcessDataObject data) : base(data)
		{
		}
	}
}