namespace UI.Process
{
	partial class ProcessView
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
			this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._grid = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel2.SuspendLayout();
			this._tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel2.Controls.Add(this._btnCacnel, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 210);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(524, 29);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// _btnCacnel
			// 
			this._btnCacnel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCacnel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnCacnel.Location = new System.Drawing.Point(457, 3);
			this._btnCacnel.Name = "_btnCacnel";
			this._btnCacnel.Size = new System.Drawing.Size(64, 23);
			this._btnCacnel.TabIndex = 1;
			this._btnCacnel.Text = "Close";
			this._btnCacnel.UseVisualStyleBackColor = true;
			// 
			// _tableLayoutPanel
			// 
			this._tableLayoutPanel.ColumnCount = 1;
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this._tableLayoutPanel.Controls.Add(this._grid, 0, 0);
			this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._tableLayoutPanel.Name = "_tableLayoutPanel";
			this._tableLayoutPanel.RowCount = 2;
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this._tableLayoutPanel.Size = new System.Drawing.Size(530, 242);
			this._tableLayoutPanel.TabIndex = 4;
			// 
			// _grid
			// 
			this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._grid.Location = new System.Drawing.Point(3, 3);
			this._grid.Name = "_grid";
			this._grid.Size = new System.Drawing.Size(524, 201);
			this._grid.TabIndex = 1;
			// 
			// ProcessView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCacnel;
			this.ClientSize = new System.Drawing.Size(530, 242);
			this.Controls.Add(this._tableLayoutPanel);
			this.MaximumSize = new System.Drawing.Size(1920, 1024);
			this.MinimumSize = new System.Drawing.Size(230, 39);
			this.Name = "ProcessView";
			this.Text = "Edit";
			this.Load += new System.EventHandler(this.EditEntryFormLoad);
			this.tableLayoutPanel2.ResumeLayout(false);
			this._tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button _btnCacnel;
		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
		private System.Windows.Forms.DataGridView _grid;

	}
}