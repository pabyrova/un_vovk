namespace UI.Process
{
	public class ProcessDataObject
	{
	}

	public class ProcessSalaryDataObject : ProcessDataObject
	{
		public double Salary { get; set; }
		public double FinalSalary { get; set; }
	}

	public class ProcessStudentSalaryDataObject : ProcessSalaryDataObject
	{
		public bool IsHighScholar { get; set; }
		public double AdditionaSalary { get; set; }
	}

	public class ProcessLecturerSalaryDataObject : ProcessSalaryDataObject
	{
		public double Degree { get; set; }
		public double PhD { get; set; }
		public double MeritYears { get; set; }
		public double Tax { get; set; }
	}
}