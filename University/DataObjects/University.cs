using System;

namespace University.DataObjects
{
	public class University : Entry
	{
		public University()
		{
		}

		public University(string name)
		{
			Name = name;
		}

		public University(Guid id, string name, string dataType) : base(id, dataType)
		{
			Name = name;
		}

		public University(University university) : this(university.Id, university.Name, university.GetType().Name)
		{
		}

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}

		public override Entry Clone()
		{
			University clone = new University(this);
			return clone;
		}
	}
}