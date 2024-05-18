namespace lab16
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvRaw = new DataGridView();
			dgvSummary = new DataGridView();
			btnLoad = new Button();
			openFileDlg = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)dgvRaw).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
			SuspendLayout();
			// 
			// dgvRaw
			// 
			dgvRaw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvRaw.Location = new Point(12, 12);
			dgvRaw.Name = "dgvRaw";
			dgvRaw.Size = new Size(548, 359);
			dgvRaw.TabIndex = 0;
			// 
			// dgvSummary
			// 
			dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSummary.Location = new Point(566, 12);
			dgvSummary.Name = "dgvSummary";
			dgvSummary.Size = new Size(222, 359);
			dgvSummary.TabIndex = 1;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(12, 409);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(149, 29);
			btnLoad.TabIndex = 2;
			btnLoad.Text = "Загрузить данные";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// openFileDlg
			// 
			openFileDlg.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLoad);
			Controls.Add(dgvSummary);
			Controls.Add(dgvRaw);
			Name = "Form1";
			Text = "Загрузка данных";
			((System.ComponentModel.ISupportInitialize)dgvRaw).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvRaw;
		private DataGridView dgvSummary;
		private Button btnLoad;
		private OpenFileDialog openFileDlg;
	}
}
