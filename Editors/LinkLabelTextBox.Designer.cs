namespace UI
{
	partial class LinkLabelTextBox 
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
			this._label = new System.Windows.Forms.LinkLabel();
			this._textBox = new System.Windows.Forms.TextBox();
			this._btnAdd = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._label);
			this.flowLayoutPanel1.Controls.Add(this._textBox);
			this.flowLayoutPanel1.Controls.Add(this._btnAdd);
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
			this._label.Size = new System.Drawing.Size(126, 23);
			this._label.TabIndex = 5;
			this._label.TabStop = true;
			this._label.Text = "linkLabel1";
			this._label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelLinkClicked);
			// 
			// _textBox
			// 
			this._textBox.Location = new System.Drawing.Point(135, 3);
			this._textBox.Name = "_textBox";
			this._textBox.Size = new System.Drawing.Size(129, 20);
			this._textBox.TabIndex = 1;
			this._textBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
			// 
			// _btnAdd
			// 
			this._btnAdd.Location = new System.Drawing.Point(270, 3);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(62, 23);
			this._btnAdd.TabIndex = 3;
			this._btnAdd.Text = "Add";
			this._btnAdd.UseVisualStyleBackColor = true;
			// 
			// LinkLabelTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "LinkLabelTextBox";
			this.Size = new System.Drawing.Size(340, 30);
			this.Load += new System.EventHandler(this.LinkLabelTextBoxLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox _textBox;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.LinkLabel _label;
	}
}
