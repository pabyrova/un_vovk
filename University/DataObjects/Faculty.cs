using System;

namespace University.DataObjects
{
	public class Faculty : Entry
	{
		public Faculty()
		{
		}

		public Faculty(Guid id, string name, Guid? universityId, string dataType) : base(id, dataType)
		{
			Name = name;
			University_Id = universityId;
		}

		public Faculty(string name, Guid? universityId)
		{
			Name = name;
			University_Id = universityId;
		}

		public Faculty(Faculty faculty) : this(faculty.Id, faculty.Name, faculty.University_Id, faculty.GetType().Name)
		{
		}

		public string Name { get; set; }
		public Guid? University_Id { get; set; }

		public override string ToString()
		{
			return Name;
		}

		public override Entry Clone()
		{
			Faculty clone = new Faculty(this);
			return clone;
		}
	}
}