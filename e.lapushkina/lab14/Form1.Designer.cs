namespace lab14
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
			menuStrip1 = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem4 = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripMenuItem();
			toolStrip1 = new ToolStrip();
			InputX = new TextBox();
			comboBoxA = new ComboBox();
			labelA = new Label();
			labelB = new Label();
			comboBoxB = new ComboBox();
			labelX = new Label();
			label1 = new Label();
			InputY = new TextBox();
			label2 = new Label();
			InputZ = new TextBox();
			Calculate = new Button();
			OutRezult = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem2 });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(125, 20);
			toolStripMenuItem1.Text = "toolStripMenuItem1";
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new Size(125, 20);
			toolStripMenuItem3.Text = "toolStripMenuItem3";
			// 
			// toolStripMenuItem4
			// 
			toolStripMenuItem4.Name = "toolStripMenuItem4";
			toolStripMenuItem4.Size = new Size(125, 20);
			toolStripMenuItem4.Text = "toolStripMenuItem4";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(125, 20);
			toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// toolStrip1
			// 
			toolStrip1.Location = new Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 25);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// InputX
			// 
			InputX.Location = new Point(30, 185);
			InputX.Name = "InputX";
			InputX.Size = new Size(100, 23);
			InputX.TabIndex = 2;
			InputX.Text = "0";
			// 
			// comboBoxA
			// 
			comboBoxA.FormattingEnabled = true;
			comboBoxA.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
			comboBoxA.Location = new Point(30, 83);
			comboBoxA.Name = "comboBoxA";
			comboBoxA.Size = new Size(121, 23);
			comboBoxA.TabIndex = 3;
			comboBoxA.Text = "0";
			// 
			// labelA
			// 
			labelA.AutoSize = true;
			labelA.Location = new Point(30, 55);
			labelA.Name = "labelA";
			labelA.Size = new Size(85, 15);
			labelA.TabIndex = 4;
			labelA.Text = "Переменная а";
			// 
			// labelB
			// 
			labelB.AutoSize = true;
			labelB.Location = new Point(251, 60);
			labelB.Name = "labelB";
			labelB.Size = new Size(86, 15);
			labelB.TabIndex = 6;
			labelB.Text = "Переменная b";
			// 
			// comboBoxB
			// 
			comboBoxB.FormattingEnabled = true;
			comboBoxB.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
			comboBoxB.Location = new Point(251, 88);
			comboBoxB.Name = "comboBoxB";
			comboBoxB.Size = new Size(121, 23);
			comboBoxB.TabIndex = 5;
			comboBoxB.Text = "0";
			// 
			// labelX
			// 
			labelX.AutoSize = true;
			labelX.Location = new Point(30, 156);
			labelX.Name = "labelX";
			labelX.Size = new Size(70, 15);
			labelX.TabIndex = 7;
			labelX.Text = "Значение X";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(187, 156);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 9;
			label1.Text = "Значение Y";
			// 
			// InputY
			// 
			InputY.Location = new Point(187, 185);
			InputY.Name = "InputY";
			InputY.Size = new Size(100, 23);
			InputY.TabIndex = 8;
			InputY.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(351, 156);
			label2.Name = "label2";
			label2.Size = new Size(70, 15);
			label2.TabIndex = 11;
			label2.Text = "Значение Z";
			// 
			// InputZ
			// 
			InputZ.Location = new Point(341, 185);
			InputZ.Name = "InputZ";
			InputZ.Size = new Size(100, 23);
			InputZ.TabIndex = 10;
			InputZ.Text = "0";
			// 
			// Calculate
			// 
			Calculate.Location = new Point(30, 247);
			Calculate.Name = "Calculate";
			Calculate.Size = new Size(75, 23);
			Calculate.TabIndex = 12;
			Calculate.Text = "Результат";
			Calculate.UseVisualStyleBackColor = true;
			Calculate.Click += Calculate_Click;
			// 
			// OutRezult
			// 
			OutRezult.AutoSize = true;
			OutRezult.Location = new Point(187, 251);
			OutRezult.Name = "OutRezult";
			OutRezult.Size = new Size(13, 15);
			OutRezult.TabIndex = 13;
			OutRezult.Text = "0";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(OutRezult);
			Controls.Add(Calculate);
			Controls.Add(label2);
			Controls.Add(InputZ);
			Controls.Add(label1);
			Controls.Add(InputY);
			Controls.Add(labelX);
			Controls.Add(labelB);
			Controls.Add(comboBoxB);
			Controls.Add(labelA);
			Controls.Add(comboBoxA);
			Controls.Add(InputX);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private TextBox InputX;
		private ComboBox comboBoxA;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem4;
		private ToolStripMenuItem toolStripMenuItem2;
		private Label labelA;
		private Label labelB;
		private ComboBox comboBoxB;
		private Label labelX;
		private Label label1;
		private TextBox InputY;
		private Label label2;
		private TextBox InputZ;
		private Button Calculate;
		private Label OutRezult;
	}
}
