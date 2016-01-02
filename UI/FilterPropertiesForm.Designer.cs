namespace UI
{
    partial class FilterPropertiesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnProcceed = new System.Windows.Forms.Button();
			this._layoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this._checkCustom = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._layoutTablePanel, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 347);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this._btnCancel, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this._btnProcceed, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._checkCustom, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 312);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(255, 32);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnCancel.Location = new System.Drawing.Point(173, 3);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(79, 26);
			this._btnCancel.TabIndex = 1;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			// 
			// _btnProcceed
			// 
			this._btnProcceed.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnProcceed.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnProcceed.Location = new System.Drawing.Point(88, 3);
			this._btnProcceed.Name = "_btnProcceed";
			this._btnProcceed.Size = new System.Drawing.Size(79, 26);
			this._btnProcceed.TabIndex = 0;
			this._btnProcceed.Text = "Procceed";
			this._btnProcceed.UseVisualStyleBackColor = true;
			// 
			// _layoutTablePanel
			// 
			this._layoutTablePanel.ColumnCount = 1;
			this._layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._layoutTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._layoutTablePanel.Location = new System.Drawing.Point(3, 3);
			this._layoutTablePanel.Name = "_layoutTablePanel";
			this._layoutTablePanel.RowCount = 2;
			this._layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._layoutTablePanel.Size = new System.Drawing.Size(255, 303);
			this._layoutTablePanel.TabIndex = 1;
			// 
			// _checkCustom
			// 
			this._checkCustom.AutoSize = true;
			this._checkCustom.Dock = System.Windows.Forms.DockStyle.Fill;
			this._checkCustom.Location = new System.Drawing.Point(3, 3);
			this._checkCustom.Name = "_checkCustom";
			this._checkCustom.Size = new System.Drawing.Size(79, 26);
			this._checkCustom.TabIndex = 2;
			this._checkCustom.Text = "Custom";
			this._checkCustom.UseVisualStyleBackColor = true;
			this._checkCustom.CheckedChanged += new System.EventHandler(this.CheckCustomCheckedChanged);
			// 
			// FilterPropertiesForm
			// 
			this.AcceptButton = this._btnProcceed;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(261, 347);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FilterPropertiesForm";
			this.Text = "Filter";
			this.Load += new System.EventHandler(this.FilterPropertiesFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _btnProcceed;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TableLayoutPanel _layoutTablePanel;
		private System.Windows.Forms.CheckBox _checkCustom;
    }
}