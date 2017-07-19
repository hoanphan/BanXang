namespace ChuongTrinhQuanLiBanXang.Imager
{
    partial class formKho
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barNam = new DevExpress.XtraBars.BarEditItem();
            this.rpNam = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnXuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcThangNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
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
            this.barButtonItem2,
            this.barLargeButtonItem1,
            this.btnXuat,
            this.barNam});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpNam});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(333, 139);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barNam, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barNam
            // 
            this.barNam.Caption = "Năm: ";
            this.barNam.Edit = this.rpNam;
            this.barNam.Id = 4;
            this.barNam.Name = "barNam";
            this.barNam.Width = 145;
            this.barNam.EditValueChanged += new System.EventHandler(this.barNam_EditValueChanged);
            // 
            // rpNam
            // 
            this.rpNam.AutoHeight = false;
            this.rpNam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpNam.Name = "rpNam";
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "Xuất excel";
            this.btnXuat.Id = 3;
            this.btnXuat.LargeGlyph = global::ChuongTrinhQuanLiBanXang.Properties.Resources.ễcl;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(769, 76);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 338);
            this.barDockControlBottom.Size = new System.Drawing.Size(769, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 76);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 262);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 76);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 262);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 2;
            this.barLargeButtonItem1.LargeGlyph = global::ChuongTrinhQuanLiBanXang.Properties.Resources.excel_2013_3e7309ea2dbd8944be164009d840feae;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // gcKho
            // 
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKho.Location = new System.Drawing.Point(0, 76);
            this.gcKho.MainView = this.gvKho;
            this.gcKho.MenuManager = this.barManager1;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(769, 262);
            this.gcKho.TabIndex = 4;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcThangNam,
            this.gcTenMatHang,
            this.gcTonKho,
            this.gcTongNhap,
            this.gridColumn1,
            this.gridColumn2});
            this.gvKho.GridControl = this.gcKho;
            this.gvKho.Name = "gvKho";
            this.gvKho.OptionsView.AllowCellMerge = true;
            // 
            // gcThangNam
            // 
            this.gcThangNam.AppearanceCell.Options.UseTextOptions = true;
            this.gcThangNam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcThangNam.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcThangNam.AppearanceHeader.Options.UseFont = true;
            this.gcThangNam.AppearanceHeader.Options.UseTextOptions = true;
            this.gcThangNam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcThangNam.Caption = "Tháng - năm";
            this.gcThangNam.FieldName = "ThangNam";
            this.gcThangNam.Name = "gcThangNam";
            this.gcThangNam.OptionsColumn.AllowEdit = false;
            this.gcThangNam.Visible = true;
            this.gcThangNam.VisibleIndex = 0;
            // 
            // gcTenMatHang
            // 
            this.gcTenMatHang.AppearanceCell.Options.UseTextOptions = true;
            this.gcTenMatHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenMatHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTenMatHang.AppearanceHeader.Options.UseFont = true;
            this.gcTenMatHang.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTenMatHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTenMatHang.Caption = "Tên Hàng";
            this.gcTenMatHang.FieldName = "TenHang";
            this.gcTenMatHang.Name = "gcTenMatHang";
            this.gcTenMatHang.OptionsColumn.AllowEdit = false;
            this.gcTenMatHang.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcTenMatHang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcTenMatHang.Visible = true;
            this.gcTenMatHang.VisibleIndex = 1;
            // 
            // gcTonKho
            // 
            this.gcTonKho.AppearanceCell.Options.UseTextOptions = true;
            this.gcTonKho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTonKho.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTonKho.AppearanceHeader.Options.UseFont = true;
            this.gcTonKho.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTonKho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTonKho.Caption = "Tồn kho từ tháng trước";
            this.gcTonKho.FieldName = "TonKhoCu";
            this.gcTonKho.Name = "gcTonKho";
            this.gcTonKho.OptionsColumn.AllowEdit = false;
            this.gcTonKho.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcTonKho.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcTonKho.Visible = true;
            this.gcTonKho.VisibleIndex = 2;
            // 
            // gcTongNhap
            // 
            this.gcTongNhap.AppearanceCell.Options.UseTextOptions = true;
            this.gcTongNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTongNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTongNhap.AppearanceHeader.Options.UseFont = true;
            this.gcTongNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTongNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTongNhap.Caption = "Tổng nhập";
            this.gcTongNhap.FieldName = "TongNhap";
            this.gcTongNhap.Name = "gcTongNhap";
            this.gcTongNhap.OptionsColumn.AllowEdit = false;
            this.gcTongNhap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcTongNhap.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcTongNhap.Visible = true;
            this.gcTongNhap.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Tổng bán";
            this.gridColumn1.FieldName = "TongBan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tồn kho";
            this.gridColumn2.FieldName = "Ton";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // formKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 361);
            this.ControlBox = false;
            this.Controls.Add(this.gcKho);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formKho";
            this.Text = "formKho";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnXuat;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarEditItem barNam;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpNam;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn gcThangNam;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn gcTongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}