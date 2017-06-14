namespace TestChuyenDe.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLaiSuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoDichVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuiTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDichVu,
            this.btnLaiSuat,
            this.btnKhachHang,
            this.btnGiaoDichVien,
            this.btnGuiTien,
            this.btnRutTien});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(782, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Caption = "Dịch vụ";
            this.btnDichVu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Glyph")));
            this.btnDichVu.Id = 1;
            this.btnDichVu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDichVu.LargeGlyph")));
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDichVu_ItemClick);
            // 
            // btnLaiSuat
            // 
            this.btnLaiSuat.Caption = "Thay đổi lãi suất";
            this.btnLaiSuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLaiSuat.Glyph")));
            this.btnLaiSuat.Id = 2;
            this.btnLaiSuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLaiSuat.LargeGlyph")));
            this.btnLaiSuat.Name = "btnLaiSuat";
            this.btnLaiSuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLaiSuat_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 3;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnGiaoDichVien
            // 
            this.btnGiaoDichVien.Caption = "Giao dịch viên";
            this.btnGiaoDichVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGiaoDichVien.Glyph")));
            this.btnGiaoDichVien.Id = 4;
            this.btnGiaoDichVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGiaoDichVien.LargeGlyph")));
            this.btnGiaoDichVien.Name = "btnGiaoDichVien";
            this.btnGiaoDichVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoDichVien_ItemClick);
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Caption = "Lập phiếu gửi tiền";
            this.btnGuiTien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuiTien.Glyph")));
            this.btnGuiTien.Id = 5;
            this.btnGuiTien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuiTien.LargeGlyph")));
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuiTien_ItemClick);
            // 
            // btnRutTien
            // 
            this.btnRutTien.Caption = "Lập phiếu rút tiền";
            this.btnRutTien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRutTien.Glyph")));
            this.btnRutTien.Id = 6;
            this.btnRutTien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRutTien.LargeGlyph")));
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRutTien_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CẬP NHẬT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDichVu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dịch vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLaiSuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thay đổi lãi suất";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Khách hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGiaoDichVien, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Giao dịch viên";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGuiTien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRutTien);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(782, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnLaiSuat;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnGiaoDichVien;
        private DevExpress.XtraBars.BarButtonItem btnGuiTien;
        private DevExpress.XtraBars.BarButtonItem btnRutTien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}