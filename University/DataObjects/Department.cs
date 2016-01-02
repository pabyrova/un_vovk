using System;

namespace University.DataObjects
{
	public class Department : Entry
	{
		public Department()
		{
		}

		public Department(Guid id, string name, Guid? facultyId, string dataType) : base(id, dataType)
		{
			Name = name;
			Faculty_Id = facultyId;
		}

		public Department(string name, Guid? facultyId)
		{
			Name = name;
			Faculty_Id = facultyId;
		}

		public Department(Department dept) : this(dept.Id, dept.Name, dept.Faculty_Id, dept.GetType().Name)
		{
		}

		public string Name { get; set; }
		public Guid? Faculty_Id { get; set; }

		public override Entry Clone()
		{
			Department clone = new Department(this);
			return clone;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}