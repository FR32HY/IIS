namespace lab14
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Calculate_Click(object sender, EventArgs e)
		{
			int a = int.Parse(comboBoxA.Text);
			int b = int.Parse(comboBoxB.Text); ;

			int x = int.Parse(InputX.Text);
			int y = int.Parse(InputY.Text);
			int z = int.Parse(InputZ.Text);

			double rez = a*a*x + (b-a)*y + Math.Sin(z);

			OutRezult.Text = rez.ToString();

		}
	}
}
