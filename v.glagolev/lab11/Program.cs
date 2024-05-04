using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace lr11
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader f_in = new StreamReader("data_example_small.csv");

#if !DEBUG
			TextWriter save_out = Console.Out;
			var new_out = new StreamWriter(@"lr11_output.txt");
			Console.SetOut(new_out);
#endif
			List<Person> all = new List<Person>();

			//string line = f_in.ReadLine();
			//while ((line = f_in.ReadLine()) != null)
			//{
			//	Console.WriteLine(line);
			//}

			try
			{
				string line = f_in.ReadLine();
				while ((line = f_in.ReadLine()) != null)
				{
					all.Add(Person.Create(line));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine("Всего пользователей: {0}", all.Count);
			foreach (var p in all)
				Console.WriteLine(p);
			//1.Найдем количество пользователей мужского и женского пола
			Console.WriteLine("****** Задача 1 **********");
			int mCount = all.FindAll(p => p.Gender == GenderType.Male).ToList().Count;
			Console.WriteLine("Koличество мужчин: {0}", mCount);
			Console.WriteLine("Количество женщин: {0}", all.Count - mCount);

			//2.Требуется найти самую высокую зарплату среди женщин и среди мужчин (вывести этих пользователей)
			Console.WriteLine("****** Задача 2 **********");
			float male_max = (from p in all
							  where p.Gender == GenderType.Male
							  select p.Salary).Max();
			Person rich_man = (from p in all
							   where (p.Gender == GenderType.Male) &&
							   (p.Salary == male_max)
							   select p).First();
			Console.WriteLine(rich_man);
			float female_max = (from p in all
								where p.Gender == GenderType.Female
								select p.Salary).Max();
			Person rich_woman = (from p in all
								 where (p.Gender == GenderType.Female) &&
								 (p.Salary == female_max)
								 select p).First();
			Console.WriteLine(rich_woman);
			//3.Требуется посчитать количество пользователей с детьми и без
			Console.WriteLine("\n****** Задача 3 *******");
			int Count_Yes = 0;
			int Count_No = 0;
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].HasChildren) Count_Yes++;
				else Count_No++;
			}
			Console.WriteLine("C детьми: {0}, без детей {1}", Count_Yes, Count_No);
			//4.посчитать суммарный фонд заработной платы для четырех категорий, образованных признаками Gender и HasChildren
			Console.WriteLine("\n****** Задача 4 **********");
			float salary_total = (from p in all
								  select p.Salary).Sum();
			float m_haschildren = (from p in all
								   where (p.Gender == GenderType.Male) && p.HasChildren
								   select p.Salary).Sum();
			float f_haschildren = (from p in all
								   where (p.Gender == GenderType.Female) && p.HasChildren
								   select p.Salary).Sum();
			float m_nochildren = (from p in all
								  where (p.Gender == GenderType.Male) && !p.HasChildren
								  select p.Salary).Sum();
			float f_nochildren = (from p in all
								  where (p.Gender == GenderType.Female) && !p.HasChildren
								  select p.Salary).Sum();
			var f = System.Globalization.CultureInfo.GetCultureInfo("en-us");
			Console.WriteLine("Фонд з/п: {0}\n" +
			"Муж.+дети: {1}.,\t Жен.+дети: {2}\n" +
			"Муж.-дети: {3}.\t Жен.-дети: {4}",
			salary_total.ToString("C3", f),
			m_haschildren.ToString("C", f), f_haschildren.ToString("C", f),
			m_nochildren.ToString("C", f), f_nochildren.ToString("C", f));

#if !DEBUG
			Console.SetOut(save_out);
			new_out.Close();
#else
			Console.ReadKey();
#endif
		}
	}

}