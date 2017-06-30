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
            this.btnDanhsachDV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuguitientrongkhoangthoigian = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuguitienquahanrut = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongtien = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackupRestore = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTaoTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGiaoDichVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTongTien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBackupRestore = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.rpgDoiPass = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnRutTien,
            this.btnDanhsachDV,
            this.btnPhieuguitientrongkhoangthoigian,
            this.btnPhieuguitienquahanrut,
            this.btnTongtien,
            this.btnAddLogin,
            this.btnBackupRestore,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(889, 143);
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
            // btnDanhsachDV
            // 
            this.btnDanhsachDV.Caption = "Danh sách dịch vụ";
            this.btnDanhsachDV.Id = 7;
            this.btnDanhsachDV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDanhsachDV.LargeGlyph")));
            this.btnDanhsachDV.Name = "btnDanhsachDV";
            this.btnDanhsachDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhsachDV_ItemClick);
            // 
            // btnPhieuguitientrongkhoangthoigian
            // 
            this.btnPhieuguitientrongkhoangthoigian.Caption = "Phiếu gửi trong khoảng thời gian ";
            this.btnPhieuguitientrongkhoangthoigian.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuguitientrongkhoangthoigian.Glyph")));
            this.btnPhieuguitientrongkhoangthoigian.Id = 8;
            this.btnPhieuguitientrongkhoangthoigian.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuguitientrongkhoangthoigian.LargeGlyph")));
            this.btnPhieuguitientrongkhoangthoigian.Name = "btnPhieuguitientrongkhoangthoigian";
            this.btnPhieuguitientrongkhoangthoigian.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuguitientrongkhoangthoigian_ItemClick);
            // 
            // btnPhieuguitienquahanrut
            // 
            this.btnPhieuguitienquahanrut.Caption = "Phiếu gửi tiền đã quá hạn rút";
            this.btnPhieuguitienquahanrut.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuguitienquahanrut.Glyph")));
            this.btnPhieuguitienquahanrut.Id = 9;
            this.btnPhieuguitienquahanrut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuguitienquahanrut.LargeGlyph")));
            this.btnPhieuguitienquahanrut.Name = "btnPhieuguitienquahanrut";
            this.btnPhieuguitienquahanrut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuguitienquahanrut_ItemClick);
            // 
            // btnTongtien
            // 
            this.btnTongtien.Caption = "Tổng số tiền từng tháng,năm";
            this.btnTongtien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTongtien.Glyph")));
            this.btnTongtien.Id = 10;
            this.btnTongtien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTongtien.LargeGlyph")));
            this.btnTongtien.Name = "btnTongtien";
            this.btnTongtien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongtien_ItemClick);
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.Caption = "Tạo tài khoản";
            this.btnAddLogin.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAddLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.Glyph")));
            this.btnAddLogin.Id = 14;
            this.btnAddLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.LargeGlyph")));
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddLogin_ItemClick);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Caption = "Backup - Restore";
            this.btnBackupRestore.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBackupRestore.Glyph")));
            this.btnBackupRestore.Id = 20;
            this.btnBackupRestore.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBackupRestore.LargeGlyph")));
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackupRestore_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTaoTaiKhoan,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.rpgGiaoDichVien,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CẬP NHẬT";
            // 
            // rpgTaoTaiKhoan
            // 
            this.rpgTaoTaiKhoan.ItemLinks.Add(this.btnAddLogin);
            this.rpgTaoTaiKhoan.Name = "rpgTaoTaiKhoan";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDichVu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLaiSuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rpgGiaoDichVien
            // 
            this.rpgGiaoDichVien.ItemLinks.Add(this.btnGiaoDichVien, true);
            this.rpgGiaoDichVien.Name = "rpgGiaoDichVien";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGuiTien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRutTien);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.rpgTongTien});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "LIỆT KÊ THỐNG KÊ";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDanhsachDV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnPhieuguitientrongkhoangthoigian);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnPhieuguitienquahanrut);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // rpgTongTien
            // 
            this.rpgTongTien.ItemLinks.Add(this.btnTongtien);
            this.rpgTongTien.Name = "rpgTongTien";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBackupRestore,
            this.rpgDoiPass,
            this.ribbonPageGroup14});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "TÀI KHOẢN VÀ HỆ THỐNG";
            // 
            // rpgBackupRestore
            // 
            this.rpgBackupRestore.ItemLinks.Add(this.btnBackupRestore);
            this.rpgBackupRestore.Name = "rpgBackupRestore";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 647);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(889, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // rpgDoiPass
            // 
            this.rpgDoiPass.ItemLinks.Add(this.barButtonItem1);
            this.rpgDoiPass.Name = "rpgDoiPass";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đổi mật khẩu";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 21;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 22;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 678);
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
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnLaiSuat;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnGiaoDichVien;
        private DevExpress.XtraBars.BarButtonItem btnGuiTien;
        private DevExpress.XtraBars.BarButtonItem btnRutTien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDichVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDanhsachDV;
        private DevExpress.XtraBars.BarButtonItem btnPhieuguitientrongkhoangthoigian;
        private DevExpress.XtraBars.BarButtonItem btnPhieuguitienquahanrut;
        private DevExpress.XtraBars.BarButtonItem btnTongtien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTongTien;
        private DevExpress.XtraBars.BarButtonItem btnAddLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTaoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBackupRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBackupRestore;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDoiPass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
    }
}