using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
namespace BLL
{
    public class DonGiaBanBLL
    {
       static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
       public static IList LoadDonGiaBan()
       {
           return (from q in DB.DonGiaBans select (new { MaDonGia = q.MaDonGia, TenMatHang = q.MatHang.TenHang, Gia = q.Gia, NgayCapNhat = q.NgayCapNhat, LaGiaHienTai = q.LaGiaHienTai })).ToList();
       }

       public static DonGiaBan TruyVanTheoMa( string MaDonGia)
       {
           return DB.DonGiaBans.Where(q => q.MaDonGia == MaDonGia).FirstOrDefault();
       }
       public static string TaoMaDonGiaSL(int soluong)
       {
           if (soluong < 10)
               return "DGB0" + soluong.ToString();
           else
               return "DGB" + soluong.ToString();
       }
       public static string TaoMaDonGia()
       {
           int MaDonGiaSL = DB.DonGiaBans.Count() + 1;
           string MaDonGia = TaoMaDonGiaSL(MaDonGiaSL);
           while (TruyVanTheoMa(MaDonGia) != null)
           {
               MaDonGiaSL++;
               MaDonGia = TaoMaDonGiaSL(MaDonGiaSL);
           }
           return MaDonGia;

       }
       public static void Them(DonGiaBan Ds)
       {
           DB.DonGiaBans.InsertOnSubmit(Ds);
           DB.SubmitChanges();
       }
       public static void Sua(DonGiaBan Ds)
       {
           DonGiaBan DS = DB.DonGiaBans.Where(q => q.MaDonGia == Ds.MaDonGia).FirstOrDefault();
           //DS.MaMatHang ="MH03";
           DS.NgayCapNhat = Ds.NgayCapNhat;
           DS.LaGiaHienTai = Ds.LaGiaHienTai;
           DS.Gia = Ds.Gia;
           DB.SubmitChanges();
       }
       public static void Xoa(string MaDonGia)
       {
           DonGiaBan Ds = TruyVanTheoMa(MaDonGia);
           DB.DonGiaBans.DeleteOnSubmit(Ds);
           DB.SubmitChanges();
       }

    }
}
