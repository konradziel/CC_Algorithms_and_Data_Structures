﻿namespace _04._10
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
			nudNumberN = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)nudNumberN).BeginInit();
			SuspendLayout();
			// 
			// btsStart
			// 
			btsStart.Location = new Point(362, 402);
			btsStart.Name = "btsStart";
			btsStart.Size = new Size(75, 23);
			btsStart.TabIndex = 0;
			btsStart.TabStop = false;
			btsStart.Text = "Start";
			btsStart.UseVisualStyleBackColor = true;
			btsStart.Click += btsStart_Click;
			// 
			// nudNumberN
			// 
			nudNumberN.Location = new Point(350, 233);
			nudNumberN.MaximumSize = new Size(100, 0);
			nudNumberN.Name = "nudNumberN";
			nudNumberN.Size = new Size(100, 23);
			nudNumberN.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(nudNumberN);
			Controls.Add(btsStart);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)nudNumberN).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btsStart;
		private NumericUpDown nudNumberN;
	}
}