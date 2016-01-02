using System;

namespace University.DataObjects
{
	public class Address : Entry
	{
		public Address(Guid id, string country, string city, string street, int houseNumber, int flatNumber, string dataType) : base(id, dataType)
		{
			Country = country;
			City = city;
			Street = street;
			HouseNumber = houseNumber;
			FlatNumber = flatNumber;
		}

		public Address(string country, string city, string street, int houseNumber, int flatNumber)
		{
			Country = country;
			City = city;
			Street = street;
			HouseNumber = houseNumber;
			FlatNumber = flatNumber;
		}

		public Address(Address address) : this(address.Id, address.Country, address.City, address.Street, address.HouseNumber, address.FlatNumber, address.GetType().Name)
		{
		}

		public Address()
		{
		}

		public string Country { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int HouseNumber { get; set; }
		public int FlatNumber { get; set; }

		public override Entry Clone()
		{
			Address clone = new Address(this);
			return clone;
		}

		public override string ToString()
		{
			return string.Format("{0},{1},{2}", City, Street, HouseNumber);
		}
	}
}