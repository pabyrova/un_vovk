namespace UI
{
	partial class TeamControl
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
			this._txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._numNumber = new System.Windows.Forms.NumericUpDown();
			this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._txtName);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this._numNumber);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 35);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtName
			// 
			this._txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtName.Location = new System.Drawing.Point(47, 3);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(100, 20);
			this._txtName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(153, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Number:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numNumber
			// 
			this._numNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSource, "Number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._numNumber.Location = new System.Drawing.Point(206, 3);
			this._numNumber.Name = "_numNumber";
			this._numNumber.Size = new System.Drawing.Size(105, 20);
			this._numNumber.TabIndex = 3;
			// 
			// _bindingSource
			// 
			this._bindingSource.DataSource = typeof(University.DataObjects.Team);
			// 
			// TeamControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "TeamControl";
			this.Size = new System.Drawing.Size(318, 35);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _numNumber;
		private System.Windows.Forms.BindingSource _bindingSource;
	}
}
