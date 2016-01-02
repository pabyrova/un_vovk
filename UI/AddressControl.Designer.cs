namespace UI
{
	partial class AddressControl
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
			this._txtCountry = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._txtCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._txtStreet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._numHouseNumber = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this._numFlatNumber = new System.Windows.Forms.NumericUpDown();
			this._bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numHouseNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numFlatNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this._txtCountry);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this._txtCity);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this._txtStreet);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this._numHouseNumber);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this._numFlatNumber);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 79);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Country:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtCountry
			// 
			this._txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Country", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtCountry.Location = new System.Drawing.Point(55, 3);
			this._txtCountry.Name = "_txtCountry";
			this._txtCountry.Size = new System.Drawing.Size(100, 20);
			this._txtCountry.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(161, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "City:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _txtCity
			// 
			this._txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtCity.Location = new System.Drawing.Point(194, 3);
			this._txtCity.Name = "_txtCity";
			this._txtCity.Size = new System.Drawing.Size(100, 20);
			this._txtCity.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Street:";
			// 
			// _txtStreet
			// 
			this._txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindingSource, "Street", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._txtStreet.Location = new System.Drawing.Point(47, 29);
			this._txtStreet.Name = "_txtStreet";
			this._txtStreet.Size = new System.Drawing.Size(108, 20);
			this._txtStreet.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(161, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "HouseN:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numHouseNumber
			// 
			this._numHouseNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSource, "HouseNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._numHouseNumber.Location = new System.Drawing.Point(216, 29);
			this._numHouseNumber.Name = "_numHouseNumber";
			this._numHouseNumber.Size = new System.Drawing.Size(72, 20);
			this._numHouseNumber.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "FlatN";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// _numFlatNumber
			// 
			this._numFlatNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bindingSource, "FlatNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this._numFlatNumber.Location = new System.Drawing.Point(41, 55);
			this._numFlatNumber.Name = "_numFlatNumber";
			this._numFlatNumber.Size = new System.Drawing.Size(114, 20);
			this._numFlatNumber.TabIndex = 9;
			// 
			// _bindingSource
			// 
			this._bindingSource.DataSource = typeof(University.DataObjects.Address);
			// 
			// AddressControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "AddressControl";
			this.Size = new System.Drawing.Size(301, 79);
			this.Load += new System.EventHandler(this.AddressControlLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numHouseNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numFlatNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txtCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _txtStreet;
		private System.Windows.Forms.BindingSource _bindingSource;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown _numHouseNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown _numFlatNumber;
	}
}
