namespace UI
{
	partial class PersonControl
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
			this._lblName = new System.Windows.Forms.Label();
			this._txtName = new System.Windows.Forms.TextBox();
			this._lblSurname = new System.Windows.Forms.Label();
			this._txtSurname = new System.Windows.Forms.TextBox();
			this._lblAge = new System.Windows.Forms.Label();
			this._numAge = new System.Windows.Forms.NumericUpDown();
			this._lblPhoneNumber = new System.Windows.Forms.Label();
			this._txtPhoneNumber = new System.Windows.Forms.TextBox();
			this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._lblName);
			this.flowLayoutPanel1.Controls.Add(this._txtName);
			this.flowLayoutPanel1.Controls.Add(this._lblSurname);
			this.flowLayoutPanel1.Controls.Add(this._txtSurname);
			this.flowLayoutPanel1.Controls.Add(this._lblAge);
			this.flowLayoutPanel1.Controls.Add(this._numAge);
			this.flowLayoutPanel1.Controls.Add(this._lblPhoneNumber);
			this.flowLayoutPanel1.Controls.Add(this._txtPhoneNumber);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 54);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// _lblName
			// 
			this._lblName.AutoSize = true;
			this._lblName.Location = new System.Drawing.Point(3, 0);
			this._lblName.Name = "_lblName";
			this._lblName.Size = new System.Drawing.Size(38, 13);
			this._lblName.TabIndex = 1;
			this._lblName.Text = "Name:";
			this._lblName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtName
			// 
			this._txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtName.Location = new System.Drawing.Point(47, 3);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(91, 20);
			this._txtName.TabIndex = 0;
			// 
			// _lblSurname
			// 
			this._lblSurname.AutoSize = true;
			this._lblSurname.Location = new System.Drawing.Point(144, 0);
			this._lblSurname.Name = "_lblSurname";
			this._lblSurname.Size = new System.Drawing.Size(52, 13);
			this._lblSurname.TabIndex = 2;
			this._lblSurname.Text = "Surname:";
			this._lblSurname.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtSurname
			// 
			this._txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Surname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtSurname.Location = new System.Drawing.Point(202, 3);
			this._txtSurname.Name = "_txtSurname";
			this._txtSurname.Size = new System.Drawing.Size(100, 20);
			this._txtSurname.TabIndex = 3;
			// 
			// _lblAge
			// 
			this._lblAge.AutoSize = true;
			this._lblAge.Location = new System.Drawing.Point(3, 26);
			this._lblAge.Name = "_lblAge";
			this._lblAge.Size = new System.Drawing.Size(29, 13);
			this._lblAge.TabIndex = 4;
			this._lblAge.Text = "Age:";
			this._lblAge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numAge
			// 
			this._numAge.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSource, "Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
			this._numAge.Location = new System.Drawing.Point(38, 29);
			this._numAge.Name = "_numAge";
			this._numAge.Size = new System.Drawing.Size(100, 20);
			this._numAge.TabIndex = 6;
			// 
			// _lblPhoneNumber
			// 
			this._lblPhoneNumber.AutoSize = true;
			this._lblPhoneNumber.Location = new System.Drawing.Point(144, 26);
			this._lblPhoneNumber.Name = "_lblPhoneNumber";
			this._lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
			this._lblPhoneNumber.TabIndex = 7;
			this._lblPhoneNumber.Text = "Phone Number:";
			this._lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtPhoneNumber
			// 
			this._txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this._bindingSource, "PhoneNumber", true));
			this._txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtPhoneNumber.Location = new System.Drawing.Point(231, 29);
			this._txtPhoneNumber.Name = "_txtPhoneNumber";
			this._txtPhoneNumber.Size = new System.Drawing.Size(71, 20);
			this._txtPhoneNumber.TabIndex = 8;
			// 
			// _bindingSource
			// 
			this._bindingSource.DataSource = typeof(University.DataObjects.Person);
			// 
			// PersonControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "PersonControl";
			this.Size = new System.Drawing.Size(321, 54);
			this.Load += new System.EventHandler(this.PersonControlLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label _lblName;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.Label _lblSurname;
		private System.Windows.Forms.TextBox _txtSurname;
		private System.Windows.Forms.Label _lblAge;
		private System.Windows.Forms.NumericUpDown _numAge;
		private System.Windows.Forms.Label _lblPhoneNumber;
		private System.Windows.Forms.TextBox _txtPhoneNumber;
		private System.Windows.Forms.BindingSource _bindingSource;
	}
}
