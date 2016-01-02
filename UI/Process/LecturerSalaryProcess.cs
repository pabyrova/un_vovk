namespace UI.Process
{
	internal class LecturerSalaryProcess : SalaryProcess
	{
		private readonly LecturerSalaryControl _salaryControl = new LecturerSalaryControl();

		public LecturerSalaryProcess()
		{
		}

		public override IProcessControl GetView()
		{
			return _salaryControl;
		}

		public LecturerSalaryProcess(ProcessDataObject data) : base(data)
		{
		}
	}
}