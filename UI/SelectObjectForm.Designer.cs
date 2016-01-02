namespace UI
{
	partial class SelectObjectForm
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
			this._treeView = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnAdd = new System.Windows.Forms.Button();
			this._checkBoxHierarchy = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _treeView
			// 
			this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._treeView.Location = new System.Drawing.Point(3, 3);
			this._treeView.Name = "_treeView";
			this._treeView.Size = new System.Drawing.Size(234, 264);
			this._treeView.TabIndex = 2;
			this._treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAfterSelect);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
			this.tableLayoutPanel1.Controls.Add(this._treeView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.50276F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.49724F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 302);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this._btnCancel, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this._btnAdd, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._checkBoxHierarchy, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 273);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 26);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnCancel.Location = new System.Drawing.Point(159, 3);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(72, 23);
			this._btnCancel.TabIndex = 5;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			// 
			// _btnAdd
			// 
			this._btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnAdd.Location = new System.Drawing.Point(81, 3);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(72, 23);
			this._btnAdd.TabIndex = 4;
			this._btnAdd.Text = "Select";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// _checkBoxHierarchy
			// 
			this._checkBoxHierarchy.AutoSize = true;
			this._checkBoxHierarchy.Location = new System.Drawing.Point(3, 3);
			this._checkBoxHierarchy.Name = "_checkBoxHierarchy";
			this._checkBoxHierarchy.Size = new System.Drawing.Size(71, 17);
			this._checkBoxHierarchy.TabIndex = 6;
			this._checkBoxHierarchy.Text = "Hierarchy";
			this._checkBoxHierarchy.UseVisualStyleBackColor = true;
			this._checkBoxHierarchy.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// SelectObjectForm
			// 
			this.AcceptButton = this._btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(240, 302);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SelectObjectForm";
			this.Text = "Select Object";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TreeView _treeView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.CheckBox _checkBoxHierarchy;
    }
}

