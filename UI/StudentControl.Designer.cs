﻿namespace UI
{
	partial class StudentControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.personControl1 = new UI.PersonControl();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.personControl1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 76);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Custom Student Control";
			// 
			// StudentControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "StudentControl";
			this.Size = new System.Drawing.Size(316, 76);
			this.Load += new System.EventHandler(this.StudentControlLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private PersonControl personControl1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
	}
}
