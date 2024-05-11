using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab13
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double Zoo = 0;
			double X = Convert.ToDouble(textBoxX.Text);
			double Y = Convert.ToDouble(textBoxY.Text);
			int N = Convert.ToInt32(textBoxN.Text);
			double W = Convert.ToDouble(comboBoxW.SelectedItem.ToString());
			double T = Convert.ToDouble(listBoxT.SelectedItem.ToString());
			if (eq1.Checked)
			{
				Zoo = 0; double item = 0;
				for (int i = 0; i < N; i++)
				{
					item = (i % 2 == 0) ? Y : X;
					Zoo += Math.Pow(-1, i % 2) * Math.Pow(item, i);
				}
			}
			else
			{
				Zoo = W * X - T * Y + 7;

				textBoxZoo.Text = Zoo.ToString();
			}
		}
	}
}
