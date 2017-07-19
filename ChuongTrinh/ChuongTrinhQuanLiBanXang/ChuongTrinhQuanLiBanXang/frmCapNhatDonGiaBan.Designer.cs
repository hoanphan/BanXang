namespace ChuongTrinhQuanLiBanXang
{
    partial class frmCapNhatDonGiaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatDonGiaBan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.ckLaGiaHienTai = new DevExpress.XtraEditors.CheckEdit();
            this.txtGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgayCapNhat = new DevExpress.XtraEditors.TextEdit();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTin)).BeginInit();
            this.gpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckLaGiaHienTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCapNhat.Properties)).BeginInit();
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
            this.btnLuu,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu và thoát";
            this.btnLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.Glyph")));
            this.btnLuu.Id = 0;
            this.btnLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.LargeGlyph")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Glyph")));
            this.btnLamMoi.Id = 1;
            this.btnLamMoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.LargeGlyph")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 2;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(425, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 244);
            this.barDockControlBottom.Size = new System.Drawing.Size(425, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 186);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(425, 58);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
            // 
            // gpThongTin
            // 
            this.gpThongTin.Controls.Add(this.cbMatHang);
            this.gpThongTin.Controls.Add(this.ckLaGiaHienTai);
            this.gpThongTin.Controls.Add(this.txtNgayCapNhat);
            this.gpThongTin.Controls.Add(this.labelControl4);
            this.gpThongTin.Controls.Add(this.txtGiaTien);
            this.gpThongTin.Controls.Add(this.labelControl3);
            this.gpThongTin.Controls.Add(this.labelControl2);
            this.gpThongTin.Controls.Add(this.txtMaDonGia);
            this.gpThongTin.Controls.Add(this.labelControl1);
            this.gpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpThongTin.Location = new System.Drawing.Point(0, 58);
            this.gpThongTin.Name = "gpThongTin";
            this.gpThongTin.Size = new System.Drawing.Size(425, 186);
            this.gpThongTin.TabIndex = 4;
            this.gpThongTin.Text = "Thông tin về thuế";
            // 
            // ckLaGiaHienTai
            // 
            this.ckLaGiaHienTai.Location = new System.Drawing.Point(145, 142);
            this.ckLaGiaHienTai.MenuManager = this.barManager1;
            this.ckLaGiaHienTai.Name = "ckLaGiaHienTai";
            this.ckLaGiaHienTai.Properties.Caption = "Là giá hiện tại";
            this.ckLaGiaHienTai.Size = new System.Drawing.Size(110, 19);
            this.ckLaGiaHienTai.TabIndex = 2;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(145, 84);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(178, 20);
            this.txtGiaTien.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Giá tiền:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên mặt hàng :";
            // 
            // txtMaDonGia
            // 
            this.txtMaDonGia.Location = new System.Drawing.Point(145, 26);
            this.txtMaDonGia.MenuManager = this.barManager1;
            this.txtMaDonGia.Name = "txtMaDonGia";
            this.txtMaDonGia.Size = new System.Drawing.Size(178, 20);
            this.txtMaDonGia.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã đơn giá bán:";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(49, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày cập nhật";
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(145, 113);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.Size = new System.Drawing.Size(178, 20);
            this.txtNgayCapNhat.TabIndex = 1;
            // 
            // cbMatHang
            // 
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(145, 52);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(178, 21);
            this.cbMatHang.TabIndex = 3;
            // 
            // frmCapNhatDonGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 267);
            this.Controls.Add(this.gpThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapNhatDonGiaBan";
            this.Text = "frmThue";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongTin)).EndInit();
            this.gpThongTin.ResumeLayout(false);
            this.gpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckLaGiaHienTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCapNhat.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnLuu;
        private DevExpress.XtraBars.BarLargeButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl gpThongTin;
        private DevExpress.XtraEditors.CheckEdit ckLaGiaHienTai;
        private DevExpress.XtraEditors.TextEdit txtGiaTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.TextEdit txtNgayCapNhat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbMatHang;
    }
}