namespace UI
{
    partial class PropertiesSettings
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
            this._label = new System.Windows.Forms.Label();
            this._radioAsc = new System.Windows.Forms.RadioButton();
            this._radioDesc = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label.Location = new System.Drawing.Point(3, 0);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(62, 33);
            this._label.TabIndex = 2;
            this._label.Text = "Sort Order:";
            this._label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _radioAsc
            // 
            this._radioAsc.AutoSize = true;
            this._radioAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioAsc.Location = new System.Drawing.Point(71, 3);
            this._radioAsc.Name = "_radioAsc";
            this._radioAsc.Size = new System.Drawing.Size(76, 27);
            this._radioAsc.TabIndex = 0;
            this._radioAsc.TabStop = true;
            this._radioAsc.Text = "Acsending";
            this._radioAsc.UseVisualStyleBackColor = true;
            this._radioAsc.CheckedChanged += new System.EventHandler(this._radioAsc_CheckedChanged);
            // 
            // _radioDesc
            // 
            this._radioDesc.AutoSize = true;
            this._radioDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._radioDesc.Location = new System.Drawing.Point(153, 3);
            this._radioDesc.Name = "_radioDesc";
            this._radioDesc.Size = new System.Drawing.Size(82, 27);
            this._radioDesc.TabIndex = 1;
            this._radioDesc.TabStop = true;
            this._radioDesc.Text = "Descending";
            this._radioDesc.UseVisualStyleBackColor = true;
            this._radioDesc.CheckedChanged += new System.EventHandler(this._radioDesc_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.78161F));
            this.tableLayoutPanel1.Controls.Add(this._radioDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._radioAsc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 33);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // PropertiesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PropertiesSettings";
            this.Size = new System.Drawing.Size(238, 33);
            this.Load += new System.EventHandler(this.PropertiesSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.RadioButton _radioAsc;
        private System.Windows.Forms.RadioButton _radioDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}
