using System;

namespace University.DataObjects
{
	public class Entry
	{
		public Entry(Guid id, string dataType)
		{
			Id = id;
			DataType = dataType;
		}

		public Entry()
		{
		}

		public Entry(Entry entry) : this(entry.Id, entry.DataType)
		{
		}

		public Guid Id { get; set; }
		public string DataType { get; set; }

		public virtual Entry Clone()
		{
			Entry entry = new Entry(this);
			return entry;
		}
	}
}