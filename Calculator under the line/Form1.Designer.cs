namespace Kalkulator_pod_kreską
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
			numericUpDown1 = new NumericUpDown();
			liczba1 = new Label();
			numericUpDown2 = new NumericUpDown();
			liczba2 = new Label();
			sumaBox = new CheckBox();
			roznicaBox = new CheckBox();
			iloczynBox = new CheckBox();
			ilorazBox = new CheckBox();
			btsStart = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			SuspendLayout();
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(206, 194);
			numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown1.MaximumSize = new Size(10000, 0);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 23);
			numericUpDown1.TabIndex = 0;
			// 
			// liczba1
			// 
			liczba1.AutoSize = true;
			liczba1.Location = new Point(220, 176);
			liczba1.Name = "liczba1";
			liczba1.Size = new Size(85, 15);
			liczba1.TabIndex = 2;
			liczba1.Text = "pierwsza liczba";
			// 
			// numericUpDown2
			// 
			numericUpDown2.Location = new Point(416, 194);
			numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(120, 23);
			numericUpDown2.TabIndex = 3;
			// 
			// liczba2
			// 
			liczba2.AutoSize = true;
			liczba2.Location = new Point(439, 176);
			liczba2.Name = "liczba2";
			liczba2.Size = new Size(71, 15);
			liczba2.TabIndex = 4;
			liczba2.Text = "druga liczba";
			// 
			// sumaBox
			// 
			sumaBox.AutoSize = true;
			sumaBox.Location = new Point(336, 223);
			sumaBox.Name = "sumaBox";
			sumaBox.Size = new Size(55, 19);
			sumaBox.TabIndex = 8;
			sumaBox.Text = "suma";
			sumaBox.UseVisualStyleBackColor = true;
			// 
			// roznicaBox
			// 
			roznicaBox.AutoSize = true;
			roznicaBox.Location = new Point(336, 248);
			roznicaBox.Name = "roznicaBox";
			roznicaBox.Size = new Size(64, 19);
			roznicaBox.TabIndex = 9;
			roznicaBox.Text = "różnica";
			roznicaBox.UseVisualStyleBackColor = true;
			// 
			// iloczynBox
			// 
			iloczynBox.AutoSize = true;
			iloczynBox.Location = new Point(336, 273);
			iloczynBox.Name = "iloczynBox";
			iloczynBox.Size = new Size(63, 19);
			iloczynBox.TabIndex = 10;
			iloczynBox.Text = "iloczyn";
			iloczynBox.UseVisualStyleBackColor = true;
			// 
			// ilorazBox
			// 
			ilorazBox.AutoSize = true;
			ilorazBox.Location = new Point(336, 298);
			ilorazBox.Name = "ilorazBox";
			ilorazBox.Size = new Size(54, 19);
			ilorazBox.TabIndex = 11;
			ilorazBox.Text = "iloraz";
			ilorazBox.UseVisualStyleBackColor = true;
			// 
			// btsStart
			// 
			btsStart.Location = new Point(336, 346);
			btsStart.Name = "btsStart";
			btsStart.Size = new Size(75, 23);
			btsStart.TabIndex = 12;
			btsStart.Text = "Start";
			btsStart.UseVisualStyleBackColor = true;
			btsStart.Click += btsStart_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btsStart);
			Controls.Add(ilorazBox);
			Controls.Add(iloczynBox);
			Controls.Add(roznicaBox);
			Controls.Add(sumaBox);
			Controls.Add(liczba2);
			Controls.Add(numericUpDown2);
			Controls.Add(liczba1);
			Controls.Add(numericUpDown1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numericUpDown1;
		private Label liczba1;
		private NumericUpDown numericUpDown2;
		private Label liczba2;
		private CheckBox sumaBox;
		private CheckBox roznicaBox;
		private CheckBox iloczynBox;
		private CheckBox ilorazBox;
		private Button btsStart;
	}
}