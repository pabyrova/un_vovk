namespace UI
{
	partial class LabelCheckBox
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
			this._checkBox = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._label);
			this.flowLayoutPanel1.Controls.Add(this._checkBox);
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
			this._label.Size = new System.Drawing.Size(125, 23);
			this._label.TabIndex = 0;
			this._label.Text = "label1";
			this._label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _checkBox
			// 
			this._checkBox.Location = new System.Drawing.Point(134, 3);
			this._checkBox.Name = "_checkBox";
			this._checkBox.Size = new System.Drawing.Size(16, 17);
			this._checkBox.TabIndex = 2;
			this._checkBox.UseVisualStyleBackColor = true;
			this._checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
			// 
			// LabelCheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "LabelCheckBox";
			this.Size = new System.Drawing.Size(340, 30);
			this.Load += new System.EventHandler(this.LabelCheckBoxLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label _label;
		private System.Windows.Forms.CheckBox _checkBox;
	}
}
