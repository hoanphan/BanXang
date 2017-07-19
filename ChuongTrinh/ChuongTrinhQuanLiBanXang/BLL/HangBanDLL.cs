using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class HangBanDLL
    {
        static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static DataTable LoadGrid()
        {
            DataTable table = new DataTable();
            DataColumn SoHieu = new DataColumn("SoHieu");
            DataColumn TenMatHang = new DataColumn("TenMatHang");
            DataColumn DienGiai = new DataColumn("DienGiai");
            DataColumn DonGia = new DataColumn("DonGia");
            DataColumn PhanTramThue = new DataColumn("PhanTramThue");
            DataColumn Thue = new DataColumn("Thue",typeof(double));
            DataColumn SoLuong = new DataColumn("SoLuong",typeof(double));
            DataColumn ThanhTien = new DataColumn("ThanhTien",typeof(double));
            DataColumn NgayNhap = new DataColumn("NgayNhap",typeof(DateTime));
            DataColumn Tong = new DataColumn("Tong",typeof(double));
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
            var Ds = DB.HangBans.ToList();
            foreach (HangBan hangMua in Ds)
            {
                DataRow row = table.NewRow();
                row["SoHieu"] = hangMua.SoHieu;
                if (hangMua.NgayBan != null)
                    row["NgayNhap"] = hangMua.NgayBan;

                if (hangMua.MaMatHang != null)
                    row["TenMatHang"] = hangMua.MatHang.TenHang;
                if (hangMua != null)
                    row["SoLuong"] = hangMua.SoLuong;
                if (hangMua.Gia != null)
                    row["DonGia"] = hangMua.Gia;
                if (hangMua.ThanhTien != null)
                    row["ThanhTien"] = hangMua.ThanhTien;
                if (hangMua.MaThue != null)
                    row["PhanTramThue"] = hangMua.BangThue.PhanTramTinh;
                if (hangMua.Thue != null)
                    row["Thue"] = hangMua.Thue;
                if (hangMua.TongCong != null)
                    row["Tong"] = hangMua.TongCong;
                table.Rows.Add(row);
            }
            return table;
        }
       public static List<HangBan>LoadALL(int Thang,int nam)
        {
            return DB.HangBans.Where(q=>q.NgayBan.Value.Month==Thang&&q.NgayBan.Value.Year==nam).ToList();
        }
      public static int LayRaThangLonNhat(int Nam)
       {
           return DB.HangBans.Where(q => q.NgayBan.Value.Year == Nam).Max(q => q.NgayBan.Value.Month);
       }
      public static int LayRaThangNhoNhat(int Nam)
      {
          return DB.HangBans.Where(q => q.NgayBan.Value.Year == Nam).Min(q => q.NgayBan.Value.Month);
      }
        public static HangBan TruyVanTheoMa(string soHieu)
        {
            return DB.HangBans.Where(q => q.SoHieu == soHieu).FirstOrDefault();
        }
       public static void Them(HangBan Ds)
        {
            DB.HangBans.InsertOnSubmit(Ds);
            DB.SubmitChanges();
        }
       public static void Xoa(string SoHieu)
       {
           HangBan Ds = TruyVanTheoMa(SoHieu);
           DB.HangBans.DeleteOnSubmit(Ds);
           DB.SubmitChanges();
       }

    }
}
