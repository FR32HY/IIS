using System.Reflection;
using System.Xml.Linq;

namespace lr11
{
	public enum GenderType
	{
		Male,
		Female
	}
	public class Person
	{
		public string ID { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public string Email { get; set; }
		public GenderType Gender { get; set; }
		public float Salary { get; set; }
		public bool HasChildren { get; set; }
		public static Person Create(string str)
		{
			Person p = new Person();
			string[] e = str.Split(',');
			p.ID = e[0].Trim();
			p.Fname = e[1].Trim();
			p.Lname = e[2].Trim();
			p.Email = e[3].Trim();
			string tmp = e[4].Trim();
			if (tmp == "Male")
				p.Gender = GenderType.Male;
			else p.Gender = GenderType.Female;
			p.Salary = Convert.ToSingle(e[5].TrimStart('$').Replace('.', ','));
			p.HasChildren = Convert.ToBoolean(e[6].TrimStart());
			return p;

		}
		public override string ToString()
		{
			String s = string.Format(
			"ID: {0}, Имя: {1}, Фамилия: {2}, ({3})\n" +
			"E-mail: {4}, 3/n: {5}, Дети: {6}",
					ID, Fname, Lname, GenderToStr(Gender),
						Email, Salary, HasChildrenToStr(HasChildren));
			return s;
		}
		private static String GenderToStr(GenderType g)
		{
			if (g == GenderType.Male) return "M";
			else return "Ж";
		}
		private static String HasChildrenToStr(Boolean g)
		{
			if (g == true) return "Есть";
			else return "Нет";
		}

	}
}
