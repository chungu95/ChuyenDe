﻿namespace TestChuyenDe.View
{
    partial class FrmDichVu
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbMADV = new System.Windows.Forms.TextBox();
            this.tbKYHAN = new System.Windows.Forms.TextBox();
            this.tbTENDV = new System.Windows.Forms.TextBox();
            this.lbMaDV = new System.Windows.Forms.Label();
            this.lbKYHAN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSửa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(581, 203);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // tbMADV
            // 
            this.tbMADV.Location = new System.Drawing.Point(256, 271);
            this.tbMADV.Name = "tbMADV";
            this.tbMADV.Size = new System.Drawing.Size(144, 21);
            this.tbMADV.TabIndex = 1;
            // 
            // tbKYHAN
            // 
            this.tbKYHAN.Location = new System.Drawing.Point(256, 311);
            this.tbKYHAN.Name = "tbKYHAN";
            this.tbKYHAN.Size = new System.Drawing.Size(144, 21);
            this.tbKYHAN.TabIndex = 2;
            // 
            // tbTENDV
            // 
            this.tbTENDV.Location = new System.Drawing.Point(256, 350);
            this.tbTENDV.Name = "tbTENDV";
            this.tbTENDV.Size = new System.Drawing.Size(144, 21);
            this.tbTENDV.TabIndex = 3;
            // 
            // lbMaDV
            // 
            this.lbMaDV.AutoSize = true;
            this.lbMaDV.Location = new System.Drawing.Point(125, 271);
            this.lbMaDV.Name = "lbMaDV";
            this.lbMaDV.Size = new System.Drawing.Size(35, 13);
            this.lbMaDV.TabIndex = 4;
            this.lbMaDV.Text = "MADV";
            // 
            // lbKYHAN
            // 
            this.lbKYHAN.AutoSize = true;
            this.lbKYHAN.Location = new System.Drawing.Point(125, 319);
            this.lbKYHAN.Name = "lbKYHAN";
            this.lbKYHAN.Size = new System.Drawing.Size(40, 13);
            this.lbKYHAN.TabIndex = 5;
            this.lbKYHAN.Text = "KYHAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TENDV";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemDV,
            this.btnXoaDV,
            this.btnSửa,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(584, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 414);
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemDV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaDV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSửa)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnThemDV
            // 
            this.btnThemDV.Caption = "Thêm";
            this.btnThemDV.Id = 0;
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDV_ItemClick);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Caption = "Xóa";
            this.btnXoaDV.Id = 1;
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaDV_ItemClick);
            // 
            // btnSửa
            // 
            this.btnSửa.Caption = "Sửa";
            this.btnSửa.Id = 2;
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSửa_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(274, 385);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 23);
            this.btnGhi.TabIndex = 11;
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 437);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbKYHAN);
            this.Controls.Add(this.lbMaDV);
            this.Controls.Add(this.tbTENDV);
            this.Controls.Add(this.tbKYHAN);
            this.Controls.Add(this.tbMADV);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox tbMADV;
        private System.Windows.Forms.TextBox tbKYHAN;
        private System.Windows.Forms.TextBox tbTENDV;
        private System.Windows.Forms.Label lbMaDV;
        private System.Windows.Forms.Label lbKYHAN;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemDV;
        private DevExpress.XtraBars.BarButtonItem btnXoaDV;
        private DevExpress.XtraBars.BarButtonItem btnSửa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Button btnGhi;
    }
}