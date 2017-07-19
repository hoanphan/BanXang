namespace ChuongTrinhQuanLiBanXang
{
    partial class FormDonGiaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonGiaBan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.gcDonGiaBan = new DevExpress.XtraGrid.GridControl();
            this.gvDonGiaBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLaGiaHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonGiaBan)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem,
            this.btnSua,
            this.barHeaderItem1,
            this.btnXoa,
            this.btnXuat,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 3;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất ra Excel";
            this.btnXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.Glyph")));
            this.btnXuat.Id = 4;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 5;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(632, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 255);
            this.barDockControlBottom.Size = new System.Drawing.Size(632, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 197);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(632, 58);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 197);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHeaderItem1_ItemClick);
            // 
            // gcDonGiaBan
            // 
            this.gcDonGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDonGiaBan.Location = new System.Drawing.Point(0, 58);
            this.gcDonGiaBan.MainView = this.gvDonGiaBan;
            this.gcDonGiaBan.MenuManager = this.barManager1;
            this.gcDonGiaBan.Name = "gcDonGiaBan";
            this.gcDonGiaBan.Size = new System.Drawing.Size(632, 197);
            this.gcDonGiaBan.TabIndex = 4;
            this.gcDonGiaBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonGiaBan});
            // 
            // gvDonGiaBan
            // 
            this.gvDonGiaBan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDonGiaBan.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDonGiaBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaDonGia,
            this.gcTenMatHang,
            this.gcGia,
            this.gcNgayCapNhat,
            this.gcLaGiaHienTai});
            this.gvDonGiaBan.GridControl = this.gcDonGiaBan;
            this.gvDonGiaBan.Name = "gvDonGiaBan";
            // 
            // gcMaDonGia
            // 
            this.gcMaDonGia.AppearanceCell.Options.UseTextOptions = true;
            this.gcMaDonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaDonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaDonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaDonGia.Caption = "Mã đơn giá";
            this.gcMaDonGia.FieldName = "MaDonGia";
            this.gcMaDonGia.Name = "gcMaDonGia";
            this.gcMaDonGia.OptionsColumn.AllowEdit = false;
            this.gcMaDonGia.Visible = true;
            this.gcMaDonGia.VisibleIndex = 0;
            // 
            // gcTenMatHang
            // 
            this.gcTenMatHang.AppearanceCell.Options.UseTextOptions = true;
            this.gcTenMatHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenMatHang.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenMatHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenMatHang.Caption = "Tên mặt hàng";
            this.gcTenMatHang.FieldName = "TenMatHang";
            this.gcTenMatHang.Name = "gcTenMatHang";
            this.gcTenMatHang.OptionsColumn.AllowEdit = false;
            this.gcTenMatHang.Visible = true;
            this.gcTenMatHang.VisibleIndex = 1;
            // 
            // gcGia
            // 
            this.gcGia.AppearanceCell.Options.UseTextOptions = true;
            this.gcGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcGia.AppearanceHeader.Options.UseTextOptions = true;
            this.gcGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcGia.Caption = "Giá tiền";
            this.gcGia.FieldName = "Gia";
            this.gcGia.Name = "gcGia";
            this.gcGia.OptionsColumn.AllowEdit = false;
            this.gcGia.Visible = true;
            this.gcGia.VisibleIndex = 2;
            // 
            // gcNgayCapNhat
            // 
            this.gcNgayCapNhat.AppearanceCell.Options.UseTextOptions = true;
            this.gcNgayCapNhat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcNgayCapNhat.AppearanceHeader.Options.UseTextOptions = true;
            this.gcNgayCapNhat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcNgayCapNhat.Caption = "Ngày cập nhật";
            this.gcNgayCapNhat.FieldName = "NgayCapNhat";
            this.gcNgayCapNhat.Name = "gcNgayCapNhat";
            this.gcNgayCapNhat.OptionsColumn.AllowEdit = false;
            this.gcNgayCapNhat.Visible = true;
            this.gcNgayCapNhat.VisibleIndex = 3;
            // 
            // gcLaGiaHienTai
            // 
            this.gcLaGiaHienTai.AppearanceCell.Options.UseTextOptions = true;
            this.gcLaGiaHienTai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaGiaHienTai.AppearanceHeader.Options.UseTextOptions = true;
            this.gcLaGiaHienTai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaGiaHienTai.Caption = "Là giá hiện tại";
            this.gcLaGiaHienTai.FieldName = "LaGiaHienTai";
            this.gcLaGiaHienTai.Name = "gcLaGiaHienTai";
            this.gcLaGiaHienTai.OptionsColumn.AllowEdit = false;
            this.gcLaGiaHienTai.Visible = true;
            this.gcLaGiaHienTai.VisibleIndex = 4;
            // 
            // FormDonGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.ControlBox = false;
            this.Controls.Add(this.gcDonGiaBan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonGiaBan";
            this.Text = "Bảng đơn giá bán";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonGiaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnThem;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnXuat;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraGrid.GridControl gcDonGiaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcGia;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn gcLaGiaHienTai;

    }
}

