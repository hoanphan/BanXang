using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace BLL
{
    public class HangNhapBLL
    {
        static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static int LayRaThangLonNhat(int Nam)
        {
            return DB.HangNhaps.Where(q => q.NgayNhap.Value.Year == Nam).Max(q => q.NgayNhap.Value.Month);
        }
        public static int LayRaThangNhoNhat(int Nam)
        {
            return DB.HangNhaps.Where(q => q.NgayNhap.Value.Year == Nam).Min(q => q.NgayNhap.Value.Month);
        }
        public static List<HangNhap> LoadALL(int Thang, int nam)
        {
            return DB.HangNhaps.Where(q => q.NgayNhap.Value.Month == Thang && q.NgayNhap.Value.Year == nam).ToList();
        }
        public static DataTable LoadGrid()
        {
            DataTable table = new DataTable();
            DataColumn SoHieu = new DataColumn("SoHieu");
            DataColumn TenMatHang = new DataColumn("TenMatHang");
            DataColumn DienGiai = new DataColumn("DienGiai");
            DataColumn DonGia = new DataColumn("DonGia");
            DataColumn PhanTramThue = new DataColumn("PhanTramThue");
            DataColumn Thue = new DataColumn("Thue", typeof(double));
            DataColumn SoLuong = new DataColumn("SoLuong", typeof(double));
            DataColumn ThanhTien = new DataColumn("ThanhTien", typeof(double));
            DataColumn NgayNhap = new DataColumn("NgayNhap", typeof(DateTime));
            DataColumn Tong = new DataColumn("Tong", typeof(double));
            table.Columns.Add(SoHieu);
            table.Columns.Add(NgayNhap);
            table.Columns.Add(DienGiai);
            table.Columns.Add(TenMatHang);
            table.Columns.Add(SoLuong);
            table.Columns.Add(DonGia);
            table.Columns.Add(ThanhTien);
            table.Columns.Add(PhanTramThue);
            table.Columns.Add(Thue);
            table.Columns.Add(Tong);
            var Ds = DB.HangNhaps.ToList();
            foreach (HangNhap HangNhap in Ds)
            {
                DataRow row = table.NewRow();
                row["SoHieu"] = HangNhap.SoHieu;
                if (HangNhap.NgayNhap != null)
                    row["NgayNhap"] = HangNhap.NgayNhap;

                if (HangNhap.MaMatHang != null)
                    row["TenMatHang"] = HangNhap.MatHang.TenHang;
                if (HangNhap != null)
                    row["SoLuong"] = HangNhap.SoLuong;
                if (HangNhap.Gia != null)
                    row["DonGia"] = HangNhap.Gia;
                if (HangNhap.ThanhTien != null)
                    row["ThanhTien"] = HangNhap.ThanhTien;
                if (HangNhap.MaThue!= null)
                    row["PhanTramThue"] = HangNhap.BangThue.PhanTramTinh;
                if (HangNhap.Thue != null)
                    row["Thue"] = HangNhap.Thue;
                if (HangNhap.TongCong != null)
                    row["Tong"] = HangNhap.TongCong;
                table.Rows.Add(row);
            }
            return table;
        }

        public static HangNhap TruyVanTheoMa(string soHieu)
        {
            return DB.HangNhaps.Where(q => q.SoHieu == soHieu).FirstOrDefault();
        }

       
        public static void Them(HangNhap Ds)
        {
            DB.HangNhaps.InsertOnSubmit(Ds);
            DB.SubmitChanges();
        }
        public static void Sua(HangNhap Ds)
        {
            BangThue thue = ThueBLL.TruyVanTheoMa(Ds.MaThue);
            HangNhap DS = TruyVanTheoMa(Ds.SoHieu);
            DS.ThanhTien = (decimal)Ds.SoLuong * Ds.Gia;
            DS.Thue = decimal.Parse((DS.ThanhTien*(decimal)thue.PhanTramTinh/100).ToString());
            DS.TongCong = DS.ThanhTien + DS.Thue;
            DS.SoLuong = Ds.SoLuong;
            DS.MaThue = Ds.MaThue;
            DS.MaMatHang ="MH01";
            DS.NgayNhap = Ds.NgayNhap;
            DB.SubmitChanges();
        }
        public static void Xoa(string SoHieu)
        {
            HangNhap Ds = TruyVanTheoMa(SoHieu);
            DB.HangNhaps.DeleteOnSubmit(Ds);
            DB.SubmitChanges();
        }
    }
}
