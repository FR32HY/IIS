using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
	public class Transport
	{
		public string number;
		public string name;
		public int yearSale;

        public Transport(string num, string nam, int yea)
        {
			number = num;
			name = nam;
			yearSale = yea;
        }
    }
	public class Avto:Transport
	{
		public int speed;
		public string model;
		public Avto(string num, string nam, int yea, int sp, string mod) : base(num, nam, yea)
        {
			this.speed = sp;
			this.model = mod;
        }
    }
	public class GAvto:Avto
	{
		public int netto;
        public GAvto(string num, string nam, int yea, int sp, string mod, int netto):base(num, nam, yea, sp, mod)
        {
            this.netto = netto;
        }
    }
	internal class LAvto:Avto
	{
		public int countPipul;
		public LAvto(string num, string nam, int yea, int sp, string mod, int countPipul) : base(num, nam, yea, sp, mod)
		{
			this.countPipul = countPipul;
		}
	}

	internal class Vertolet:Transport
	{
		public int height;
		public Vertolet(string num, string nam, int yea, int h) : base(num, nam, yea)
		{
			height = h;
		}
	}


}
