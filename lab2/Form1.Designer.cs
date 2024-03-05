namespace _18._10
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
			btsStart = new Button();
			tbInput = new TextBox();
			lblWynik = new Label();
			btsStartSS = new Button();
			SuspendLayout();
			// 
			// btsStart
			// 
			btsStart.Location = new Point(253, 231);
			btsStart.Name = "btsStart";
			btsStart.Size = new Size(102, 23);
			btsStart.TabIndex = 1;
			btsStart.Text = "Bubble Sort";
			btsStart.UseVisualStyleBackColor = true;
			btsStart.Click += btsStart_Click;
			// 
			// tbInput
			// 
			tbInput.Location = new Point(321, 161);
			tbInput.Name = "tbInput";
			tbInput.Size = new Size(100, 23);
			tbInput.TabIndex = 2;
			tbInput.TextChanged += textBox1_TextChanged;
			// 
			// lblWynik
			// 
			lblWynik.AutoSize = true;
			lblWynik.Location = new Point(350, 196);
			lblWynik.Name = "lblWynik";
			lblWynik.Size = new Size(40, 15);
			lblWynik.TabIndex = 3;
			lblWynik.Text = "Wynik";
			lblWynik.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btsStartSS
			// 
			btsStartSS.Location = new Point(391, 231);
			btsStartSS.Name = "btsStartSS";
			btsStartSS.Size = new Size(102, 23);
			btsStartSS.TabIndex = 4;
			btsStartSS.Text = "Selection Sort";
			btsStartSS.UseVisualStyleBackColor = true;
			btsStartSS.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btsStartSS);
			Controls.Add(lblWynik);
			Controls.Add(tbInput);
			Controls.Add(btsStart);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btsStart;
		private TextBox tbInput;
		private Label lblWynik;
		private Button btsStartSS;
	}
}