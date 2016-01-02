namespace UI
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this._treeView = new System.Windows.Forms.TreeView();
			this._btnEdit = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnDelete = new System.Windows.Forms.Button();
			this._contextLecturerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewSalariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this._contextStudentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addScholarshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewScholarshipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._checkBoxHierarchy = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this._contextLecturerMenu.SuspendLayout();
			this._contextStudentMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _treeView
			// 
			this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._treeView.Location = new System.Drawing.Point(3, 3);
			this._treeView.Name = "_treeView";
			this._treeView.Size = new System.Drawing.Size(467, 314);
			this._treeView.TabIndex = 2;
			this._treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAfterSelect);
			this._treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeViewMouseUp);
			// 
			// _btnEdit
			// 
			this._btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnEdit.Location = new System.Drawing.Point(131, 3);
			this._btnEdit.Name = "_btnEdit";
			this._btnEdit.Size = new System.Drawing.Size(123, 26);
			this._btnEdit.TabIndex = 3;
			this._btnEdit.Text = "Edit";
			this._btnEdit.UseVisualStyleBackColor = true;
			this._btnEdit.Click += new System.EventHandler(this.BtnEditClick);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 358);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.Controls.Add(this._btnEdit, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._btnAdd, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this._btnDelete, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this._checkBoxHierarchy, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 323);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 32);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// _btnAdd
			// 
			this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnAdd.Location = new System.Drawing.Point(3, 3);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(122, 26);
			this._btnAdd.TabIndex = 4;
			this._btnAdd.Text = "Add";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// _btnDelete
			// 
			this._btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnDelete.Location = new System.Drawing.Point(260, 3);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(123, 26);
			this._btnDelete.TabIndex = 5;
			this._btnDelete.Text = "Delete";
			this._btnDelete.UseVisualStyleBackColor = true;
			this._btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// _contextLecturerMenu
			// 
			this._contextLecturerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalaryToolStripMenuItem,
            this.viewSalariesToolStripMenuItem,
            this.clearToolStripMenuItem1});
			this._contextLecturerMenu.Name = "_contextTreeViewMenu";
			this._contextLecturerMenu.Size = new System.Drawing.Size(142, 70);
			// 
			// addSalaryToolStripMenuItem
			// 
			this.addSalaryToolStripMenuItem.Name = "addSalaryToolStripMenuItem";
			this.addSalaryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.addSalaryToolStripMenuItem.Text = "Add Salary";
			this.addSalaryToolStripMenuItem.Click += new System.EventHandler(this.AddSalaryToolStripMenuItemClick);
			// 
			// viewSalariesToolStripMenuItem
			// 
			this.viewSalariesToolStripMenuItem.Name = "viewSalariesToolStripMenuItem";
			this.viewSalariesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.viewSalariesToolStripMenuItem.Text = "View Salaries";
			this.viewSalariesToolStripMenuItem.Click += new System.EventHandler(this.ViewSalariesToolStripMenuItemClick);
			// 
			// clearToolStripMenuItem1
			// 
			this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
			this.clearToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.clearToolStripMenuItem1.Text = "Clear";
			this.clearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem1Click);
			// 
			// _contextStudentMenu
			// 
			this._contextStudentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScholarshipToolStripMenuItem,
            this.viewScholarshipsToolStripMenuItem,
            this.clearToolStripMenuItem});
			this._contextStudentMenu.Name = "_contextStudentMenu";
			this._contextStudentMenu.Size = new System.Drawing.Size(169, 70);
			// 
			// addScholarshipToolStripMenuItem
			// 
			this.addScholarshipToolStripMenuItem.Name = "addScholarshipToolStripMenuItem";
			this.addScholarshipToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.addScholarshipToolStripMenuItem.Text = "Add Scholarship";
			this.addScholarshipToolStripMenuItem.Click += new System.EventHandler(this.AddScholarshipToolStripMenuItemClick);
			// 
			// viewScholarshipsToolStripMenuItem
			// 
			this.viewScholarshipsToolStripMenuItem.Name = "viewScholarshipsToolStripMenuItem";
			this.viewScholarshipsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.viewScholarshipsToolStripMenuItem.Text = "View Scholarships";
			this.viewScholarshipsToolStripMenuItem.Click += new System.EventHandler(this.ViewScholarshipsToolStripMenuItemClick);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItemClick);
			// 
			// _checkBoxHierarchy
			// 
			this._checkBoxHierarchy.AutoSize = true;
			this._checkBoxHierarchy.Location = new System.Drawing.Point(389, 3);
			this._checkBoxHierarchy.Name = "_checkBoxHierarchy";
			this._checkBoxHierarchy.Size = new System.Drawing.Size(71, 17);
			this._checkBoxHierarchy.TabIndex = 6;
			this._checkBoxHierarchy.Text = "Hierarchy";
			this._checkBoxHierarchy.UseVisualStyleBackColor = true;
			this._checkBoxHierarchy.CheckedChanged += new System.EventHandler(this.CheckBoxHierarchyCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(473, 358);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this._contextLecturerMenu.ResumeLayout(false);
			this._contextStudentMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TreeView _treeView;
		private System.Windows.Forms.Button _btnEdit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.ContextMenuStrip _contextLecturerMenu;
		private System.Windows.Forms.ToolStripMenuItem addSalaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewSalariesToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip _contextStudentMenu;
		private System.Windows.Forms.ToolStripMenuItem addScholarshipToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewScholarshipsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
		private System.Windows.Forms.CheckBox _checkBoxHierarchy;
    }
}

