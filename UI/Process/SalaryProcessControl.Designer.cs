﻿namespace UI.Process
{
	partial class SalaryProcessControl
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
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this._numStartSalary = new System.Windows.Forms.NumericUpDown();
			this.processSalaryDataObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this._numFinalSalary = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numStartSalary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processSalaryDataObjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numFinalSalary)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._numStartSalary);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this._numFinalSalary);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 55);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Salary:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numStartSalary
			// 
			this._numStartSalary.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processSalaryDataObjectBindingSource, "Salary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N3"));
			this._numStartSalary.Location = new System.Drawing.Point(48, 3);
			this._numStartSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._numStartSalary.Name = "_numStartSalary";
			this._numStartSalary.Size = new System.Drawing.Size(145, 20);
			this._numStartSalary.TabIndex = 1;
			this._numStartSalary.ValueChanged += new System.EventHandler(this.NumStartSalaryValueChanged);
			// 
			// processSalaryDataObjectBindingSource
			// 
			this.processSalaryDataObjectBindingSource.DataSource = typeof(UI.Process.ProcessSalaryDataObject);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Final Salary:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numFinalSalary
			// 
			this._numFinalSalary.Enabled = false;
			this._numFinalSalary.Location = new System.Drawing.Point(73, 29);
			this._numFinalSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._numFinalSalary.Name = "_numFinalSalary";
			this._numFinalSalary.Size = new System.Drawing.Size(120, 20);
			this._numFinalSalary.TabIndex = 2;
			// 
			// SalaryProcessControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "SalaryProcessControl";
			this.Size = new System.Drawing.Size(200, 55);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numStartSalary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processSalaryDataObjectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numFinalSalary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _numStartSalary;
		private System.Windows.Forms.BindingSource processSalaryDataObjectBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _numFinalSalary;
	}
}
