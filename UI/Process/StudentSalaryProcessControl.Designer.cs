namespace UI.Process
{
	partial class StudentSalaryProcessControl
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
			this._checkAdditional = new System.Windows.Forms.CheckBox();
			this.processStudentSalaryDataObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this._numAdditionalSalary = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.processStudentSalaryDataObjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numAdditionalSalary)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._salaryProcessControl);
			this.flowLayoutPanel1.Controls.Add(this._checkAdditional);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._numAdditionalSalary);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 96);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// _salaryProcessControl
			// 
			this._salaryProcessControl.DataObject = null;
			this._salaryProcessControl.Location = new System.Drawing.Point(3, 3);
			this._salaryProcessControl.Name = "_salaryProcessControl";
			this._salaryProcessControl.Size = new System.Drawing.Size(200, 55);
			this._salaryProcessControl.TabIndex = 0;
			// 
			// _checkAdditional
			// 
			this._checkAdditional.AutoSize = true;
			this._checkAdditional.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.processStudentSalaryDataObjectBindingSource, "IsHighScholar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._checkAdditional.Location = new System.Drawing.Point(3, 64);
			this._checkAdditional.Name = "_checkAdditional";
			this._checkAdditional.Size = new System.Drawing.Size(48, 17);
			this._checkAdditional.TabIndex = 1;
			this._checkAdditional.Text = "High";
			this._checkAdditional.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._checkAdditional.UseVisualStyleBackColor = true;
			this._checkAdditional.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// processStudentSalaryDataObjectBindingSource
			// 
			this.processStudentSalaryDataObjectBindingSource.DataSource = typeof(UI.Process.ProcessStudentSalaryDataObject);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Prem Scholar:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numAdditionalSalary
			// 
			this._numAdditionalSalary.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.processStudentSalaryDataObjectBindingSource, "AdditionaSalary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N3"));
			this._numAdditionalSalary.Location = new System.Drawing.Point(136, 64);
			this._numAdditionalSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._numAdditionalSalary.Name = "_numAdditionalSalary";
			this._numAdditionalSalary.Size = new System.Drawing.Size(57, 20);
			this._numAdditionalSalary.TabIndex = 3;
			this._numAdditionalSalary.ValueChanged += new System.EventHandler(this.NumAdditionalSalaryValueChanged);
			// 
			// StudentSalaryProcessControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "StudentSalaryProcessControl";
			this.Size = new System.Drawing.Size(204, 96);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.processStudentSalaryDataObjectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numAdditionalSalary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private SalaryProcessControl _salaryProcessControl;
		private System.Windows.Forms.CheckBox _checkAdditional;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _numAdditionalSalary;
		private System.Windows.Forms.BindingSource processStudentSalaryDataObjectBindingSource;

	}
}
