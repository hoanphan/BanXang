using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using BLL;
using DAL;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
namespace ChuongTrinhQuanLiBanXang
{
    public partial class formHangBan : DevExpress.XtraEditors.XtraForm
    {
        private string LoaiBang;
        public formHangBan()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013";
           
            
        }
        private void LoadcbTenHang()
        {
            cbTenHang.Items.Clear();
            foreach (MatHang Ds in DB.MatHangs.ToList())
            {
                cbTenHang.Items.Add(Ds.TenHang);
            }
           
        }
        private decimal TachGia(string Gia)
        {
            decimal gt = 0;
            int vtNgoacDauTien = Gia.IndexOf("(");
            string ChuoiGia;
            if (vtNgoacDauTien > 0)
                ChuoiGia = Gia.Substring(0, vtNgoacDauTien);
            else
                ChuoiGia = Gia;
            gt = decimal.Parse(ChuoiGia);
            return gt;
        }
        QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        #region[Hang Nhap]
        private void LoadGridViewHangNhap()
        {
            gcHangNhapHoacHangBan.DataSource = HangNhapBLL.LoadGrid();
        }
        private void LoadAllHangNhap()
        {
            LoadGridViewHangNhap();
            LoadcbTenHang();
            LoadThueNhap();
            LoadcbGiaHangNhap();
        }
        private void LoadcbGiaHangNhap()
         {
             cbGia.Items.Clear();
             foreach (DonGiaNhap Ds in DB.DonGiaNhaps.ToList())
             {
                 cbGia.Items.Add(Ds.Gia + "(" + Ds.MatHang.TenHang + ")");
             }
         }
        private void LoadThueNhap()
        {
            cbThue.Items.Clear();
            foreach(BangThue Thue in DB.BangThues.Where(q=>q.LaMua==true).ToList())
            {
                cbThue.Items.Add(Thue.PhanTramTinh);
            }
        }
        private void ThemHangMua()
        {
            int sl = DB.HangNhaps.Count();
            for (int i = sl; i < gvHangNhapHoacBan.RowCount; i++)
            {
                DataRow row = gvHangNhapHoacBan.GetDataRow(i);
                string soHieu = row[0].ToString();
                DateTime ngayNhap = DateTime.Parse(row[1].ToString());
                string tenMatHang = row[3].ToString();
                string soLuong = row["SoLuong"].ToString();
                string gia = row["DonGia"].ToString();
                string PhanTramThue = row["PhanTramThue"].ToString();
                decimal Gia = TachGia(gia);
                decimal ThanhTien = TachGia(gia) * int.Parse(soLuong);
                decimal thanhTien = (decimal)ThanhTien;
                decimal thue = thanhTien * decimal.Parse(PhanTramThue) / 100;
                decimal tongCong = thue + thanhTien;
                MessageBox.Show(ThueBLL.LayMaThueHangMua(PhanTramThue));
                HangNhap Ds = new HangNhap
                {
                    SoHieu = soHieu,
                    MaMatHang = MatHangBLL.LayMaMatHang(tenMatHang),
                    MaThue = ThueBLL.LayMaThueHangMua(PhanTramThue),
                    SoLuong = int.Parse(soLuong),
                    Gia = TachGia(gia),
                    ThanhTien = thanhTien,
                    Thue = thue,
                    NgayNhap = ngayNhap,
                    TongCong = tongCong
                };
                HangNhapBLL.Them(Ds);


            }
            LoadGridViewHangNhap();
        }
        private void SuaHangMua()
        {
            int sl = DB.HangNhaps.Count();
            for (int i = 0; i < sl; i++)
            {
                DataRow row = gvHangNhapHoacBan.GetDataRow(i);
             
                string soHieu = row[0].ToString();

                DateTime ngayNhap = DateTime.Parse(row[1].ToString());
                string tenMatHang = row[3].ToString();
                string soLuong = row["SoLuong"].ToString();
                string gia = row["DonGia"].ToString();
                string PhanTramThue = row["PhanTramThue"].ToString();
                decimal Gia = TachGia(gia);
                decimal ThanhTien = TachGia(gia) * int.Parse(soLuong);
                decimal thanhTien = (decimal)ThanhTien;
                decimal thue = thanhTien * decimal.Parse(PhanTramThue) / 100;
                decimal tongCong = thue + thanhTien;
                MessageBox.Show(tenMatHang);
                HangNhap Ds = new HangNhap
                {
                    SoHieu = soHieu,
                    MaMatHang = MatHangBLL.LayMaMatHang(tenMatHang),
                    MaThue = ThueBLL.LayMaThueHangMua(PhanTramThue),
                    SoLuong = int.Parse(soLuong),
                    Gia = TachGia(gia)
                };
                HangNhapBLL.Sua(Ds);
               
            }
            LoadGridViewHangNhap();
        }
        private void XoaHangNhap()
        {
            DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (questions == DialogResult.Yes)
            {
                DataRow row = gvHangNhapHoacBan.GetDataRow(gvHangNhapHoacBan.FocusedRowHandle);
                string SoHieu = row[0].ToString();
                HangNhapBLL.Xoa(SoHieu);
                LoadGridViewHangNhap();
            }
        }

       #endregion
        #region[Hang Ban]
        private void LoadGridViewHangBan()
        {
            gcHangNhapHoacHangBan.DataSource = HangBanDLL.LoadGrid();
        }
        private void LoadGiaBan()
        {
            cbGia.Items.Clear();
            foreach (DonGiaBan Ds in DB.DonGiaBans.ToList())
            {
                cbGia.Items.Add(Ds.Gia + "(" + Ds.MatHang.TenHang + ")");
            }
        }
        private void LoadThueBan()
        {
            cbThue.Items.Clear();
            foreach (BangThue Thue in DB.BangThues.Where(q => q.LaMua == false).ToList())
            {
                cbThue.Items.Add(Thue.PhanTramTinh);
            }
        }
        private void LoadAllGiaBan()
        {
            LoadGridViewHangBan();
            LoadGiaBan();
            LoadThueBan();
            LoadcbTenHang();
        }
        private void ThemHangBan()
        {
            int sl = DB.HangBans.Count();
            for (int i = sl; i < gvHangNhapHoacBan.RowCount; i++)
            {
                DataRow row = gvHangNhapHoacBan.GetDataRow(i);
                string soHieu = row["SoHieu"].ToString();
                DateTime ngayNhap = DateTime.Parse(row[1].ToString());
                string tenMatHang = row[3].ToString();
                string soLuong = row["SoLuong"].ToString();
                string gia = row["DonGia"].ToString();
                string PhanTramThue = row["PhanTramThue"].ToString();
                decimal Gia = TachGia(gia);
                decimal ThanhTien = TachGia(gia) * int.Parse(soLuong);
                decimal thanhTien = (decimal)ThanhTien;
                decimal thue = thanhTien * decimal.Parse(PhanTramThue) / 100;
                decimal tongCong = thue + thanhTien;
                MessageBox.Show(ThueBLL.LayMaThueHangBan(PhanTramThue));
                HangBan Ds = new HangBan
                {
                    SoHieu = soHieu,
                    MaMatHang = MatHangBLL.LayMaMatHang(tenMatHang),
                    MaThue = ThueBLL.LayMaThueHangBan(PhanTramThue),
                    SoLuong = int.Parse(soLuong),
                    Gia = TachGia(gia),
                    ThanhTien = thanhTien,
                    Thue = thue,
                    NgayBan = ngayNhap,
                    TongCong = tongCong
                };
                HangBanDLL.Them(Ds);
              
            }
            LoadGridViewHangBan();
        }
        private void XoaHangBan()
        {
            DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (questions == DialogResult.Yes)
            {
                DataRow row = gvHangNhapHoacBan.GetDataRow(gvHangNhapHoacBan.FocusedRowHandle);
                string SoHieu = row[0].ToString();
                HangBanDLL.Xoa(SoHieu);
                LoadGridViewHangBan();
                
            }
        }
        #endregion
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHangNhapHoacBan.ShowLoadingPanel();
            if (LoaiBang == "Hàng bán")
                ThemHangBan();
            else
                ThemHangMua();
            gvHangNhapHoacBan.HideLoadingPanel();
          
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHangNhapHoacBan.ShowLoadingPanel();
            SuaHangMua();
            gvHangNhapHoacBan.HideLoadingPanel();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHangNhapHoacBan.ShowLoadingPanel();
            if (LoaiBang == "Hàng bán")
                XoaHangBan();
            else
                XoaHangNhap();
            gvHangNhapHoacBan.HideLoadingPanel();
        }

        private void cbLoaiBang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RepositoryItem checkEdit = cbLoaiBang.Edit;
          
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcMatHang_Click(object sender, EventArgs e)
        {

        }

        private void gcMatHang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gvMatHang_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //e.RepositoryItem = repositoryItemComboBox6;
        }

        private void cbLoaiBang_EditValueChanged(object sender, EventArgs e)
        {
           object obj= cbLoaiBang.EditValue;
           LoaiBang = obj.ToString().Trim();
           if(LoaiBang=="Hàng bán")
           {
               LoadAllGiaBan();
               LoaiBang = "Hàng bán";
           }
           else
           {
               LoadAllHangNhap();
               LoaiBang = "Hàng mua";
           }

        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcHangNhapHoacHangBan);
        }

        private void gcHangNhapHoacHangBan_Click(object sender, EventArgs e)
        {

        }
        

      
    }
}
