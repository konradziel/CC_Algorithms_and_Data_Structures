namespace selectSort
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
			nUD = new NumericUpDown();
			btsStart = new Button();
			((System.ComponentModel.ISupportInitialize)nUD).BeginInit();
			SuspendLayout();
			// 
			// nUD
			// 
			nUD.Location = new Point(321, 203);
			nUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			nUD.Name = "nUD";
			nUD.Size = new Size(120, 23);
			nUD.TabIndex = 0;
			// 
			// btsStart
			// 
			btsStart.Location = new Point(341, 255);
			btsStart.Name = "btsStart";
			btsStart.Size = new Size(75, 23);
			btsStart.TabIndex = 1;
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
			Controls.Add(nUD);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)nUD).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private NumericUpDown nUD;
		private Button btsStart;
	}
}