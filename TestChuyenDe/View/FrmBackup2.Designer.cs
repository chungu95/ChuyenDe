namespace TestChuyenDe.View
{
    partial class FrmBackup2
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaygio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnbackup = new System.Windows.Forms.Button();
            this.cbreset = new System.Windows.Forms.CheckBox();
            this.btnrestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Enabled = false;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(156, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.ngaygio});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // check
            // 
            this.check.Caption = "Chọn bản Backup";
            this.check.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.check.FieldName = "position";
            this.check.Name = "check";
            this.check.Visible = true;
            this.check.VisibleIndex = 0;
            // 
            // ngaygio
            // 
            this.ngaygio.Caption = "Ngày giờ Backup";
            this.ngaygio.DisplayFormat.FormatString = "G";
            this.ngaygio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngaygio.FieldName = "date";
            this.ngaygio.Name = "ngaygio";
            this.ngaygio.OptionsColumn.AllowEdit = false;
            this.ngaygio.OptionsColumn.ReadOnly = true;
            this.ngaygio.Visible = true;
            this.ngaygio.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(29, 56);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(75, 23);
            this.btnbackup.TabIndex = 1;
            this.btnbackup.Text = "BACKUP";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // cbreset
            // 
            this.cbreset.AutoSize = true;
            this.cbreset.Location = new System.Drawing.Point(274, 266);
            this.cbreset.Name = "cbreset";
            this.cbreset.Size = new System.Drawing.Size(109, 17);
            this.cbreset.TabIndex = 2;
            this.cbreset.Text = "Reset file sao lưu";
            this.cbreset.UseVisualStyleBackColor = true;
            this.cbreset.CheckedChanged += new System.EventHandler(this.cbreset_CheckedChanged);
            // 
            // btnrestore
            // 
            this.btnrestore.Location = new System.Drawing.Point(29, 109);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(75, 23);
            this.btnrestore.TabIndex = 3;
            this.btnrestore.Text = "RESTORE";
            this.btnrestore.UseVisualStyleBackColor = true;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click_1);
            // 
            // FrmBackup2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.cbreset);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBackup2";
            this.Text = "FrmBackup2";
            this.Load += new System.EventHandler(this.FrmBackup2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnbackup;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraGrid.Columns.GridColumn ngaygio;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.CheckBox cbreset;
        private System.Windows.Forms.Button btnrestore;
    }
}