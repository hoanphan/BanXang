namespace ChuongTrinhQuanLiBanXang
{
    partial class FormThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThue));
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
            this.gcThue = new DevExpress.XtraGrid.GridControl();
            this.gvThue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhanTramTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLaThueHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).BeginInit();
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
            // gcThue
            // 
            this.gcThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThue.Location = new System.Drawing.Point(0, 58);
            this.gcThue.MainView = this.gvThue;
            this.gcThue.MenuManager = this.barManager1;
            this.gcThue.Name = "gcThue";
            this.gcThue.Size = new System.Drawing.Size(632, 197);
            this.gcThue.TabIndex = 4;
            this.gcThue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThue});
            // 
            // gvThue
            // 
            this.gvThue.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvThue.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvThue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaThue,
            this.gcPhanTramTinh,
            this.gcNgayCapNhat,
            this.gcLaThueHienTai,
            this.gcLaMua});
            this.gvThue.GridControl = this.gcThue;
            this.gvThue.Name = "gvThue";
            // 
            // gcMaThue
            // 
            this.gcMaThue.AppearanceCell.Options.UseTextOptions = true;
            this.gcMaThue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaThue.AppearanceHeader.Options.UseTextOptions = true;
            this.gcMaThue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcMaThue.Caption = "Mã thuế";
            this.gcMaThue.FieldName = "MaThue";
            this.gcMaThue.Name = "gcMaThue";
            this.gcMaThue.OptionsColumn.AllowEdit = false;
            this.gcMaThue.Visible = true;
            this.gcMaThue.VisibleIndex = 0;
            // 
            // gcPhanTramTinh
            // 
            this.gcPhanTramTinh.AppearanceCell.Options.UseTextOptions = true;
            this.gcPhanTramTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPhanTramTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gcPhanTramTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPhanTramTinh.Caption = "Phần trăm";
            this.gcPhanTramTinh.FieldName = "PhanTramTinh";
            this.gcPhanTramTinh.Name = "gcPhanTramTinh";
            this.gcPhanTramTinh.OptionsColumn.AllowEdit = false;
            this.gcPhanTramTinh.Visible = true;
            this.gcPhanTramTinh.VisibleIndex = 1;
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
            this.gcNgayCapNhat.VisibleIndex = 2;
            // 
            // gcLaThueHienTai
            // 
            this.gcLaThueHienTai.AppearanceCell.Options.UseTextOptions = true;
            this.gcLaThueHienTai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaThueHienTai.AppearanceHeader.Options.UseTextOptions = true;
            this.gcLaThueHienTai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaThueHienTai.Caption = "Là Thuế hiện tại";
            this.gcLaThueHienTai.FieldName = "LaThueHienTai";
            this.gcLaThueHienTai.Name = "gcLaThueHienTai";
            this.gcLaThueHienTai.OptionsColumn.AllowEdit = false;
            this.gcLaThueHienTai.Visible = true;
            this.gcLaThueHienTai.VisibleIndex = 3;
            // 
            // gcLaMua
            // 
            this.gcLaMua.AppearanceCell.Options.UseTextOptions = true;
            this.gcLaMua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaMua.AppearanceHeader.Options.UseTextOptions = true;
            this.gcLaMua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcLaMua.Caption = "Là Thuế Nhập";
            this.gcLaMua.FieldName = "LaMua";
            this.gcLaMua.Name = "gcLaMua";
            this.gcLaMua.OptionsColumn.AllowEdit = false;
            this.gcLaMua.Visible = true;
            this.gcLaMua.VisibleIndex = 4;
            // 
            // FormThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.ControlBox = false;
            this.Controls.Add(this.gcThue);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThue";
            this.Text = "Bảng thuế";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThue)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcThue;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThue;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaThue;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhanTramTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn gcLaThueHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn gcLaMua;

    }
}

