using System;

namespace University.DataObjects
{
	public class Lecturer : Person
	{
		public Lecturer()
		{
		}

		public Lecturer(Guid? departmentId)
		{
			Department_Id = departmentId;
		}

		public Lecturer(Guid id, int age, string name, string surname, string phoneNumber, Guid? addressId, Guid? departmentId, string dataType)
			: base(id, age, name, surname, phoneNumber, addressId, dataType)
		{
			Department_Id = departmentId;
		}

		public Lecturer(int age, string name, string surname, string phoneNumber, Guid? addressId, Guid? departmentId) : base(age, name, surname, phoneNumber, addressId)
		{
			Department_Id = departmentId;
		}

		public Lecturer(Lecturer lecturer) : this(lecturer.Id, lecturer.Age, lecturer.Name, lecturer.Surname, lecturer.PhoneNumber, lecturer.Address_Id, lecturer.Department_Id, lecturer.GetType().Name)
		{
		}

		public Guid? Department_Id { get; set; }

		public override Entry Clone()
		{
			Lecturer clone = new Lecturer(this);
			return clone;
		}
	}
}