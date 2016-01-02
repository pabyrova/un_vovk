namespace UI.Process
{
	partial class LecturerSalaryControl
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
			this._salaryProcessControl = new UI.Process.SalaryProcessControl();
			this.label1 = new System.Windows.Forms.Label();
			this._numDegree = new System.Windows.Forms.NumericUpDown();
			this.processLecturerSalaryDataObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this._numPhD = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this._numMeritYears = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this._numTax = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numDegree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processLecturerSalaryDataObjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numPhD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numMeritYears)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numTax)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._salaryProcessControl);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._numDegree);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this._numPhD);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this._numMeritYears);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this._numTax);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(205, 172);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// _salaryProcessControl
			// 
			this._salaryProcessControl.Location = new System.Drawing.Point(3, 3);
			this._salaryProcessControl.Name = "_salaryProcessControl";
			this._salaryProcessControl.Size = new System.Drawing.Size(200, 55);
			this._salaryProcessControl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Degree (%):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numDegree
			// 
			this._numDegree.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processLecturerSalaryDataObjectBindingSource, "Degree", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this._numDegree.Location = new System.Drawing.Point(71, 64);
			this._numDegree.Name = "_numDegree";
			this._numDegree.Size = new System.Drawing.Size(127, 20);
			this._numDegree.TabIndex = 2;
			this._numDegree.ValueChanged += new System.EventHandler(this.NumDegreeValueChanged);
			// 
			// processLecturerSalaryDataObjectBindingSource
			// 
			this.processLecturerSalaryDataObjectBindingSource.DataSource = typeof(UI.Process.ProcessLecturerSalaryDataObject);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phd (%):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numPhD
			// 
			this._numPhD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processLecturerSalaryDataObjectBindingSource, "PhD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this._numPhD.Location = new System.Drawing.Point(55, 90);
			this._numPhD.Name = "_numPhD";
			this._numPhD.Size = new System.Drawing.Size(143, 20);
			this._numPhD.TabIndex = 4;
			this._numPhD.ValueChanged += new System.EventHandler(this.NumPhDValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Merit Years (%):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numMeritYears
			// 
			this._numMeritYears.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processLecturerSalaryDataObjectBindingSource, "MeritYears", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
			this._numMeritYears.Location = new System.Drawing.Point(89, 116);
			this._numMeritYears.Name = "_numMeritYears";
			this._numMeritYears.Size = new System.Drawing.Size(109, 20);
			this._numMeritYears.TabIndex = 6;
			this._numMeritYears.ValueChanged += new System.EventHandler(this.NumMeritYearsValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tax (%):";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numTax
			// 
			this._numTax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processLecturerSalaryDataObjectBindingSource, "Tax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._numTax.Location = new System.Drawing.Point(54, 142);
			this._numTax.Name = "_numTax";
			this._numTax.Size = new System.Drawing.Size(144, 20);
			this._numTax.TabIndex = 8;
			this._numTax.ValueChanged += new System.EventHandler(this.NumTaxValueChanged);
			// 
			// LecturerSalaryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "LecturerSalaryControl";
			this.Size = new System.Drawing.Size(205, 172);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numDegree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processLecturerSalaryDataObjectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numPhD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numMeritYears)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numTax)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private SalaryProcessControl _salaryProcessControl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _numDegree;
		private System.Windows.Forms.BindingSource processLecturerSalaryDataObjectBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _numPhD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown _numMeritYears;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown _numTax;
	}
}
