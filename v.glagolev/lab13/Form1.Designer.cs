namespace lab13
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxX = new System.Windows.Forms.TextBox();
			this.textBoxY = new System.Windows.Forms.TextBox();
			this.textBoxN = new System.Windows.Forms.TextBox();
			this.comboBoxW = new System.Windows.Forms.ComboBox();
			this.listBoxT = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.eq1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxZoo = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(104, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(104, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "N";
			// 
			// textBoxX
			// 
			this.textBoxX.Location = new System.Drawing.Point(158, 25);
			this.textBoxX.Name = "textBoxX";
			this.textBoxX.Size = new System.Drawing.Size(100, 20);
			this.textBoxX.TabIndex = 3;
			this.textBoxX.Text = "0";
			// 
			// textBoxY
			// 
			this.textBoxY.Location = new System.Drawing.Point(158, 64);
			this.textBoxY.Name = "textBoxY";
			this.textBoxY.Size = new System.Drawing.Size(100, 20);
			this.textBoxY.TabIndex = 4;
			this.textBoxY.Text = "0";
			// 
			// textBoxN
			// 
			this.textBoxN.Location = new System.Drawing.Point(158, 107);
			this.textBoxN.Name = "textBoxN";
			this.textBoxN.Size = new System.Drawing.Size(100, 20);
			this.textBoxN.TabIndex = 5;
			this.textBoxN.Text = "0";
			// 
			// comboBoxW
			// 
			this.comboBoxW.FormattingEnabled = true;
			this.comboBoxW.Items.AddRange(new object[] {
            "0,05",
            "0,01",
            "0,1"});
			this.comboBoxW.Location = new System.Drawing.Point(345, 23);
			this.comboBoxW.Name = "comboBoxW";
			this.comboBoxW.Size = new System.Drawing.Size(121, 21);
			this.comboBoxW.TabIndex = 6;
			this.comboBoxW.Text = "0";
			// 
			// listBoxT
			// 
			this.listBoxT.FormattingEnabled = true;
			this.listBoxT.Items.AddRange(new object[] {
            "0,001",
            "0,01",
            "0,1",
            "1",
            "10",
            "100",
            "1000"});
			this.listBoxT.Location = new System.Drawing.Point(345, 62);
			this.listBoxT.Name = "listBoxT";
			this.listBoxT.Size = new System.Drawing.Size(120, 108);
			this.listBoxT.TabIndex = 7;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.eq1);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Location = new System.Drawing.Point(545, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 96);
			this.panel1.TabIndex = 8;
			// 
			// eq1
			// 
			this.eq1.AutoSize = true;
			this.eq1.Checked = true;
			this.eq1.Location = new System.Drawing.Point(23, 15);
			this.eq1.Name = "eq1";
			this.eq1.Size = new System.Drawing.Size(90, 17);
			this.eq1.TabIndex = 9;
			this.eq1.TabStop = true;
			this.eq1.Text = "Уравнение 1";
			this.eq1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(23, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(90, 17);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "Уравнение 2";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(107, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 43);
			this.button1.TabIndex = 11;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(309, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Zoo";
			// 
			// textBoxZoo
			// 
			this.textBoxZoo.Enabled = false;
			this.textBoxZoo.Location = new System.Drawing.Point(345, 235);
			this.textBoxZoo.Name = "textBoxZoo";
			this.textBoxZoo.Size = new System.Drawing.Size(120, 20);
			this.textBoxZoo.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 299);
			this.Controls.Add(this.textBoxZoo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listBoxT);
			this.Controls.Add(this.comboBoxW);
			this.Controls.Add(this.textBoxN);
			this.Controls.Add(this.textBoxY);
			this.Controls.Add(this.textBoxX);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxX;
		private System.Windows.Forms.TextBox textBoxY;
		private System.Windows.Forms.TextBox textBoxN;
		private System.Windows.Forms.ComboBox comboBoxW;
		private System.Windows.Forms.ListBox listBoxT;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton eq1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxZoo;
	}
}

