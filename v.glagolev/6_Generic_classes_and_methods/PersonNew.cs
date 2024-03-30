using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Generic_classes_and_methods
{
	internal class PersonNew<T>
	{
		public static T? code;
		public T Id { get; set; }
		public string Name { get; set; }

        public PersonNew(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
	class Company<P>
	{
		public P CEO { get; set; }
        public Company(P ceo)
        {
			CEO = ceo;
        }
    }
	class MyPersonNew
	{
		void Main()
		{
			PersonNew<int> tom = new PersonNew<int>(546, "Tom");
			PersonNew<int>.code = 123;

			PersonNew<string> bob = new PersonNew<string>("abc123", "Bob");
			PersonNew<string>.code = "meta";

			int tomId = tom.Id;
			string bobId = bob.Id;
			Console.WriteLine(tomId);
			Console.WriteLine(bobId);

			//------------------------
			Company<PersonNew<int>> microsoft = new Company<PersonNew<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);
			Console.WriteLine(microsoft.CEO.Name);
		}
	}

}
