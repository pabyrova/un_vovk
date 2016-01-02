using System;

namespace University.DataObjects
{
	public class Student : Person
	{
		public Student()
		{
		}

		public Student(Guid? teamId)
		{
			Team_Id = teamId;
		}

		public Student(Guid id, int age, string name, string surname, string phoneNumber, Guid? addressId, Guid? teamId, string dataType) : base(id, age, name, surname, phoneNumber, addressId, dataType)
		{
			Team_Id = teamId;
		}

		public Student(int age, string name, string surname, string phoneNumber, Guid? addressId, Guid? teamId) : base(age, name, surname, phoneNumber, addressId)
		{
			Team_Id = teamId;
		}

		public Student(Student student) : this(student.Id, student.Age, student.Name, student.Surname, student.PhoneNumber, student.Address_Id, student.Team_Id, student.GetType().Name)
		{
		}

		public Guid? Team_Id { get; set; }

		public override Entry Clone()
		{
			Student clone = new Student(this);
			return clone;
		}
	}
}