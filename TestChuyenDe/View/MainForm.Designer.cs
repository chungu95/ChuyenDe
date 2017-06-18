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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
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
            this.btnAddLogin});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(783, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
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
            // 
            // btnTongtien
            // 
            this.btnTongtien.Caption = "Tổng số tiền từng tháng,năm";
            this.btnTongtien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTongtien.Glyph")));
            this.btnTongtien.Id = 10;
            this.btnTongtien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTongtien.LargeGlyph")));
            this.btnTongtien.Name = "btnTongtien";
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.Caption = "Tạo tài khoản";
            this.btnAddLogin.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAddLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.Glyph")));
            this.btnAddLogin.Id = 14;
            this.btnAddLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.LargeGlyph")));
            this.btnAddLogin.Name = "btnAddLogin";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CẬP NHẬT";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnAddLogin);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Tạo tài khoản";
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
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "LIỆT KÊ THỐNG KÊ";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDanhsachDV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnPhieuguitientrongkhoangthoigian);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnPhieuguitienquahanrut);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnTongtien);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 417);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(783, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(69, 417);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(160, 31);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "label1";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRole.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(235, 417);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(178, 29);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "label1";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 448);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private DevExpress.XtraBars.BarButtonItem btnDanhsachDV;
        private DevExpress.XtraBars.BarButtonItem btnPhieuguitientrongkhoangthoigian;
        private DevExpress.XtraBars.BarButtonItem btnPhieuguitienquahanrut;
        private DevExpress.XtraBars.BarButtonItem btnTongtien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnAddLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRole;
    }
}