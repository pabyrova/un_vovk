namespace UI
{
	partial class LabelNumericUpDown
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this._label = new System.Windows.Forms.Label();
			this._numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._label);
			this.flowLayoutPanel1.Controls.Add(this._numericUpDown);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 30);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// _label
			// 
			this._label.Location = new System.Drawing.Point(3, 0);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(125, 29);
			this._label.TabIndex = 0;
			this._label.Text = "label1";
			this._label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _numericUpDown
			// 
			this._numericUpDown.Location = new System.Drawing.Point(134, 3);
			this._numericUpDown.Name = "_numericUpDown";
			this._numericUpDown.Size = new System.Drawing.Size(199, 20);
			this._numericUpDown.TabIndex = 2;
			this._numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
			// 
			// LabelNumericUpDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "LabelNumericUpDown";
			this.Size = new System.Drawing.Size(340, 30);
			this.Load += new System.EventHandler(this.LabelNumericUpDownLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label _label;
		private System.Windows.Forms.NumericUpDown _numericUpDown;
	}
}
