using System;

namespace University.DataObjects
{
	public class Team : Entry
	{
		public Team(Guid id, string name, int number, Guid? departmentId, string dataType) : base(id, dataType)
		{
			Name = name;
			Number = number;
			Department_Id = departmentId;
		}

		public Team(string name, int number, Guid? departmentId)
		{
			Name = name;
			Number = number;
			Department_Id = departmentId;
		}

		public Team(Team team) : this(team.Id, team.Name, team.Number, team.Department_Id, team.GetType().Name)
		{
		}

		public Team()
		{
		}

		public string Name { get; set; }
		public int Number { get; set; }
		public Guid? Department_Id { get; set; }

		public override Entry Clone()
		{
			Team clone = new Team(this);
			return clone;
		}

		public override string ToString()
		{
			return Name + Number;
		}
	}
}