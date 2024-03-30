using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Generic_classes_and_methods
{
	//internal class Person
	//{
	//	public int Id { get; set; }
	//	public string Name { get; set; }

	//	public Person(int id, string name)
	//	{
	//		Id = id;
	//		Name = name;
	//	}
	//}
	internal class Person
	{
		public object Id { get; set; }
		public string Name { get; set; }
		public Person(object id, string name)
		{
			Id = id;
			Name = name;
		}
	}
	class MyPerson
	{
		void Main()
		{
			Person tom = new Person(546, "Tom");
			Person bob = new Person("abc123", "Bob");
			int tomId = (int)tom.Id;
			string bobId = (string)bob.Id;
            Console.WriteLine(tomId);
			Console.WriteLine(bobId);
		}
	}
}
