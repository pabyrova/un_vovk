using System;

namespace University.DataObjects
{
	public class Person : Entry
	{
		public Person()
		{
		}

		public Person(Guid id, int age, string name, string surname, string phoneNumber, Guid? addressId, string dataType) : base(id, dataType)
		{
			Age = age;
			Name = name;
			Surname = surname;
			PhoneNumber = phoneNumber;
			Address_Id = addressId;
		}

		public Person(int age, string name, string surname, string phoneNumber, Guid? addressId)
		{
			Age = age;
			Name = name;
			Surname = surname;
			PhoneNumber = phoneNumber;
			Address_Id = addressId;
		}

		public Person(Person person) : this(person.Id, person.Age, person.Name, person.Surname, person.PhoneNumber, person.Address_Id, person.GetType().Name)
		{
		}

		public string Name { get; set; }
		public int Age { get; set; }
		public string Surname { get; set; }
		public string PhoneNumber { get; set; }
		public Guid? Address_Id { get; set; }

		public override string ToString()
		{
			return string.Format("{0} {1}", Surname, Name);
		}

		public override Entry Clone()
		{
			Person clone = new Person(this);
			return clone;
		}
	}
}