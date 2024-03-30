namespace lab8
{
	class MyProgram {
		static void Main()
		{
			//Transport lada = new Transport("А555ВА79", "Аурус", 2023);
			//LAvto llada = new LAvto("А111ВА79", "Largo",2023, 200,"Sedan", 20);
			//GAvto maz = new GAvto("А011ВА79", "MAz9000", 2023, 200,"Turbo", 20000);
			//Vertolet v1 = new Vertolet("А001ВА79", "Rothels", 2023,3500);


			List<Transport> transportList = new List<Transport>();
			List<Avto> avtoList = new List<Avto>();
			List<GAvto> gAvtoList = new List<GAvto>();
			List<LAvto> lAvtoList = new List<LAvto>();
			List<Vertolet> vertoletList = new List<Vertolet>();

			for (int i = 0; i < 100; i++)
			{
				string number = i.ToString();
				string name = $"Transport{i}";
				int yearSale = 2020;

				Transport transport = new Transport(number, name, yearSale);
				transportList.Add(transport);
				Console.WriteLine($"Transport: {transport.number}, {transport.name}, {transport.yearSale}");

				string avtoNumber = $"AvtoNumber{i}";
				string avtoName = $"Avto{i}";
				int avtoYearSale = 2019;
				int avtoSpeed = 200;
				string avtoModel = $"Model{i}";

				Avto avto = new Avto(avtoNumber, avtoName, avtoYearSale, avtoSpeed, avtoModel);
				avtoList.Add(avto);
				Console.WriteLine($"Avto: {avto.number}, {avto.name}, {avto.yearSale}, {avto.speed}, {avto.model}");

				string gAvtoNumber = $"GAvtoNumber{i}";
				string gAvtoName = $"GAvto{i}";
				int gAvtoYearSale = 2018;
				int gAvtoSpeed = 180;
				string gAvtoModel = $"Model{i}";
				int gAvtoNetto = i * 10;

				GAvto gAvto = new GAvto(gAvtoNumber, gAvtoName, gAvtoYearSale, gAvtoSpeed, gAvtoModel, gAvtoNetto);
				gAvtoList.Add(gAvto);
				Console.WriteLine($"GAvto: {gAvto.number}, {gAvto.name}, {gAvto.yearSale}, {gAvto.speed}, {gAvto.model}, {gAvto.netto}");

				string lAvtoNumber = $"LAvtoNumber{i}";
				string lAvtoName = $"LAvto{i}";
				int lAvtoYearSale = 2017;
				int lAvtoSpeed = 160;
				string lAvtoModel = $"Model{i}";
				int lAvtoCountPipul = i % 5;

				LAvto lAvto = new LAvto(lAvtoNumber, lAvtoName, lAvtoYearSale, lAvtoSpeed, lAvtoModel, lAvtoCountPipul);
				lAvtoList.Add(lAvto);
				Console.WriteLine($"LAvto: {lAvto.number}, {lAvto.name}, {lAvto.yearSale}, {lAvto.speed}, {lAvto.model}, {lAvto.countPipul}");

				string vertoletNumber = $"VertoletNumber{i}";
				string vertoletName = $"Vertolet{i}";
				int vertoletYearSale = 2016;
				int vertoletHeight = i * 100;

				Vertolet vertolet = new Vertolet(vertoletNumber, vertoletName, vertoletYearSale, vertoletHeight);
				vertoletList.Add(vertolet);
				Console.WriteLine($"Vertolet: {vertolet.number}, {vertolet.name}, {vertolet.yearSale}, {vertolet.height}");
			}
		}
	
	}

}
