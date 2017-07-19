namespace ChuongTrinhQuanLiBanXang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonGiaNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonGiaBan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbYear = new DevExpress.XtraBars.BarEditItem();
            this.cbbNam = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnLayDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.cbLoaiBang = new DevExpress.XtraBars.BarEditItem();
            this.cbbLoaiBang = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelMail = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMail)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnMatHang,
            this.btnDonGiaNhap,
            this.btnDonGiaBan,
            this.ribbonGalleryBarItem1,
            this.barButtonGroup1,
            this.barButtonItem2,
            this.barEditItem1,
            this.cbYear,
            this.btnLayDuLieu,
            this.cbLoaiBang,
            this.barButtonItem3,
            this.btnKho});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.cbbNam,
            this.cbbLoaiBang});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(739, 143);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thuế";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnMatHang
            // 
            this.btnMatHang.Caption = "Mặt hàng";
            this.btnMatHang.Id = 2;
            this.btnMatHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMatHang.LargeGlyph")));
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnDonGiaNhap
            // 
            this.btnDonGiaNhap.Caption = "Đơn giá nhập";
            this.btnDonGiaNhap.Id = 3;
            this.btnDonGiaNhap.LargeGlyph = global::ChuongTrinhQuanLiBanXang.Properties.Resources.shopping_cart_full_512;
            this.btnDonGiaNhap.Name = "btnDonGiaNhap";
            this.btnDonGiaNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonGiaNhap_ItemClick);
            // 
            // btnDonGiaBan
            // 
            this.btnDonGiaBan.Caption = "Đơn giá bán";
            this.btnDonGiaBan.Id = 4;
            this.btnDonGiaBan.LargeGlyph = global::ChuongTrinhQuanLiBanXang.Properties.Resources._6853352_orig__1_;
            this.btnDonGiaBan.Name = "btnDonGiaBan";
            this.btnDonGiaBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonGiaBan_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 6;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 7;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhập dữ liệu";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Bảng";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 9;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 100;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // cbYear
            // 
            this.cbYear.Caption = "Năm";
            this.cbYear.Edit = this.cbbNam;
            this.cbYear.Id = 10;
            this.cbYear.Name = "cbYear";
            this.cbYear.Width = 100;
            // 
            // cbbNam
            // 
            this.cbbNam.AutoHeight = false;
            this.cbbNam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNam.Name = "cbbNam";
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Caption = "Lấy dữ liệu";
            this.btnLayDuLieu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLayDuLieu.Glyph")));
            this.btnLayDuLieu.Id = 11;
            this.btnLayDuLieu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLayDuLieu.LargeGlyph")));
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLayDuLieu_ItemClick);
            // 
            // cbLoaiBang
            // 
            this.cbLoaiBang.Caption = "Bảng";
            this.cbLoaiBang.Edit = this.cbbLoaiBang;
            this.cbLoaiBang.Id = 12;
            this.cbLoaiBang.Name = "cbLoaiBang";
            this.cbLoaiBang.Width = 100;
            // 
            // cbbLoaiBang
            // 
            this.cbbLoaiBang.AutoHeight = false;
            this.cbbLoaiBang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiBang.Items.AddRange(new object[] {
            "Hàng Nhập",
            "Hàng Bán",
            "Kho"});
            this.cbbLoaiBang.Name = "cbbLoaiBang";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnKho
            // 
            this.btnKho.ActAsDropDown = true;
            this.btnKho.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 15;
            this.btnKho.LargeGlyph = global::ChuongTrinhQuanLiBanXang.Properties.Resources.Pink_Barn_Barn_Second;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Thuế";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMatHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonGiaNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonGiaBan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Hàng hóa";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Nhập dữ liệu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLayDuLieu);
            this.ribbonPageGroup4.ItemLinks.Add(this.cbYear);
            this.ribbonPageGroup4.ItemLinks.Add(this.cbLoaiBang);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo cáo";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Kho hàng";
            // 
            // panelMail
            // 
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMail.Location = new System.Drawing.Point(0, 143);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(739, 239);
            this.panelMail.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 382);
            this.Controls.Add(this.panelMail);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình quản lí bán xăng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelMail;
        private DevExpress.XtraBars.BarButtonItem btnMatHang;
        private DevExpress.XtraBars.BarButtonItem btnDonGiaNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDonGiaBan;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem cbYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbbNam;
        private DevExpress.XtraBars.BarButtonItem btnLayDuLieu;
        private DevExpress.XtraBars.BarEditItem cbLoaiBang;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbbLoaiBang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}