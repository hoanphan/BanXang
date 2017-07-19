using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class MatHangBLL
    {
        static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static List<MatHang> LoadMatHang()
        {
            return DB.MatHangs.ToList();
        }
        public static string LayMaMatHang(string TenMatHang)
        {
            return DB.MatHangs.Where(q => q.TenHang == TenMatHang).Select(q => q.MaMatHang).FirstOrDefault();
        }
        public static MatHang TruyVanTheoMa(string maMatHang)
        {
            return DB.MatHangs.Where(q => q.MaMatHang == maMatHang).FirstOrDefault();
        }
        public static string TaoMaMatHangTheoSoLuong(int soluong)
        {
            if (soluong < 10)
                return "MH0" + soluong.ToString();
            else
                return "MH" + soluong.ToString();
        }
        public static string TaoMaMatHang()
        {
            int MaMatHangSL = DB.MatHangs.Count() + 1;
            string MaMatHang = TaoMaMatHangTheoSoLuong(MaMatHangSL);
            while (TruyVanTheoMa(MaMatHang) != null)
            {
                MaMatHangSL++;
                MaMatHang = TaoMaMatHangTheoSoLuong(MaMatHangSL);
            }
            return MaMatHang;

        }
        public static void Them(MatHang Ds)
        {
            DB.MatHangs.InsertOnSubmit(Ds);
            DB.SubmitChanges();
        }
        public static void Sua(MatHang Ds)
        {
            MatHang DS = TruyVanTheoMa(Ds.MaMatHang);
            DS.TenHang = Ds.TenHang;
            DS.DonViTinh = Ds.DonViTinh;
            DB.SubmitChanges();
        }
        public static void Xoa(string MaMatHang)
        {
            MatHang Ds = TruyVanTheoMa(MaMatHang);
            DB.MatHangs.DeleteOnSubmit(Ds);
            DB.SubmitChanges();
        }
    }
}
