﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			//Для вывода информации в заголовке окна
			Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
			//Для вывода суммы координат в TextBox1
			textBox1.Text = (e.X + e.Y).ToString();

			int a = 1;
			int b = 3;
			int w = 2;
			double z = Math.Sqrt(Math.Abs(a * e.X / Math.Pow(w, a))) +
				Math.Sqrt(Math.Abs(b)) - Math.Abs(e.X - Math.Cos(e.Y)) ;
			textBox2.Text = z.ToString();

		}
	}
}
