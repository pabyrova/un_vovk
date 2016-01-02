namespace UI
{
	partial class CusomEditForm
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._btnCacnel = new System.Windows.Forms.Button();
			this._btnUpdate = new System.Windows.Forms.Button();
			this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._layoutEditorControls = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2.SuspendLayout();
			this._tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.Controls.Add(this._btnCacnel, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this._btnUpdate, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 122);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 29);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// _btnCacnel
			// 
			this._btnCacnel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCacnel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnCacnel.Location = new System.Drawing.Point(261, 3);
			this._btnCacnel.Name = "_btnCacnel";
			this._btnCacnel.Size = new System.Drawing.Size(64, 23);
			this._btnCacnel.TabIndex = 1;
			this._btnCacnel.Text = "Cancel";
			this._btnCacnel.UseVisualStyleBackColor = true;
			// 
			// _btnUpdate
			// 
			this._btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnUpdate.Location = new System.Drawing.Point(191, 3);
			this._btnUpdate.Name = "_btnUpdate";
			this._btnUpdate.Size = new System.Drawing.Size(64, 23);
			this._btnUpdate.TabIndex = 0;
			this._btnUpdate.Text = "Save";
			this._btnUpdate.UseVisualStyleBackColor = true;
			// 
			// _tableLayoutPanel
			// 
			this._tableLayoutPanel.ColumnCount = 1;
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this._tableLayoutPanel.Controls.Add(this._layoutEditorControls, 0, 0);
			this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._tableLayoutPanel.Name = "_tableLayoutPanel";
			this._tableLayoutPanel.RowCount = 2;
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this._tableLayoutPanel.Size = new System.Drawing.Size(334, 154);
			this._tableLayoutPanel.TabIndex = 4;
			// 
			// _layoutEditorControls
			// 
			this._layoutEditorControls.ColumnCount = 1;
			this._layoutEditorControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._layoutEditorControls.Dock = System.Windows.Forms.DockStyle.Fill;
			this._layoutEditorControls.Location = new System.Drawing.Point(3, 3);
			this._layoutEditorControls.Name = "_layoutEditorControls";
			this._layoutEditorControls.RowCount = 2;
			this._layoutEditorControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this._layoutEditorControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
			this._layoutEditorControls.Size = new System.Drawing.Size(328, 113);
			this._layoutEditorControls.TabIndex = 1;
			// 
			// EditEntyForm
			// 
			this.AcceptButton = this._btnUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCacnel;
			this.ClientSize = new System.Drawing.Size(334, 154);
			this.Controls.Add(this._tableLayoutPanel);
			this.MaximumSize = new System.Drawing.Size(350, 1024);
			this.MinimumSize = new System.Drawing.Size(345, 39);
			this.Name = "EditEntyForm";
			this.Text = "Edit";
			this.Load += new System.EventHandler(this.EditEntryFormLoad);
			this.tableLayoutPanel2.ResumeLayout(false);
			this._tableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button _btnCacnel;
		private System.Windows.Forms.Button _btnUpdate;
		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel _layoutEditorControls;

	}
}