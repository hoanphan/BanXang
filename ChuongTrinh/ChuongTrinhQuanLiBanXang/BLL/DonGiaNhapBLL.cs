using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
namespace BLL
{
    public class DonGiaNhapBLL
    {
       static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
       public static IList LoadDonGiaNhap()
       {
           return (from q in DB.DonGiaNhaps select (new { MaDonGia = q.MaDonGia, TenMatHang = q.MatHang.TenHang, Gia = q.Gia, NgayCapNhat = q.NgayCapNhat, LaGiaHienTai = q.GiaHienTai })).ToList();
       }

       public static DonGiaNhap TruyVanTheoMa( string MaDonGia)
       {
           return DB.DonGiaNhaps.Where(q => q.MaDonGia == MaDonGia).FirstOrDefault();
       }
        
       public static string TaoMaDonGiaSL(int soluong)
       {
           if (soluong < 10)
               return "DGN0" + soluong.ToString();
           else
               return "DGN" + soluong.ToString();
       }
       public static string TaoMaDonGia()
       {
           int MaDonGiaSL = DB.DonGiaNhaps.Count() + 1;
           string MaDonGia = TaoMaDonGiaSL(MaDonGiaSL);
           while (TruyVanTheoMa(MaDonGia) != null)
           {
               MaDonGiaSL++;
               MaDonGia = TaoMaDonGiaSL(MaDonGiaSL);
           }
           return MaDonGia;

       }
       public static void Them(DonGiaNhap Ds)
       {
           DB.DonGiaNhaps.InsertOnSubmit(Ds);
           DB.SubmitChanges();
       }
       public static void Sua(DonGiaNhap Ds)
       {
           DonGiaNhap DS = TruyVanTheoMa(Ds.MaDonGia);
           DS.MaMatHang = Ds.MaMatHang;
           DS.Gia = Ds.Gia;
           DS.GiaHienTai = Ds.GiaHienTai;
           DS.NgayCapNhat = Ds.NgayCapNhat;
           DB.SubmitChanges();
       }
       public static void Xoa(string MaDonGia)
       {
           DonGiaNhap Ds = TruyVanTheoMa(MaDonGia);
           DB.DonGiaNhaps.DeleteOnSubmit(Ds);
           DB.SubmitChanges();
       }

    }
}
