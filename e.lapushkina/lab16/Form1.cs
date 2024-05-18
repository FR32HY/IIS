using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab16
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			openFileDlg.InitialDirectory = Application.StartupPath;
			if (openFileDlg.ShowDialog() == DialogResult.OK)
						{
							ShowData(openFileDlg.FileName);
						}
		}
		private void ShowData(string datapath)
		{
			DataStorage data;
			try
			{
				data = DataStorage.DataCreator(datapath);
				dgvRaw.DataSource = data.GetRawData();
				dgvRaw.ReadOnly = true;
				dgvSummary.DataSource = data.GetSummaryData();
				dgvSummary.ReadOnly = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("npn загрузке данных что-то сломалось");
			}
		}
	}
}
