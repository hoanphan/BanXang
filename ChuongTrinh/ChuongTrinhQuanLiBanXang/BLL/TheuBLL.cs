using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ThueBLL
    {
       static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
       public static List<BangThue> LoadThue()
       {
           return DB.BangThues.ToList();
       }
        public static string LayMaThueHangMua(string PhanTram)
       {
            string maThue="";
            List<BangThue> DS=DB.BangThues.Where(q=>q.LaMua==true).Where(q=>q.PhanTramTinh==float.Parse(PhanTram)).ToList();
            foreach (BangThue thue in DS)
            {
                if (thue.LaThueHienTai == true)
                {
                    maThue = thue.MaThue;
                    break;
                }
            }
            if (maThue == "")
                maThue = DS.Select(q => q.MaThue).FirstOrDefault();
            return maThue;
       }
        public static string LayMaThueHangBan(string PhanTram)
        {
            string maThue = "";
            List<BangThue> DS = DB.BangThues.Where(q => q.LaMua == false).Where(q => q.PhanTramTinh == float.Parse(PhanTram)).ToList();
            foreach (BangThue thue in DS)
            {
                if (thue.LaThueHienTai == true)
                {
                    maThue = thue.MaThue;
                    break;
                }
            }
            if (maThue == "")
                maThue = DS.Select(q => q.MaThue).FirstOrDefault();
            return maThue;
        }
       public static BangThue TruyVanTheoMa( string MaThue)
       {
           return DB.BangThues.Where(q => q.MaThue == MaThue).FirstOrDefault();
       }
       public static string TaoMaThueTheoSoLuong(int soluong)
       {
           if (soluong < 10)
               return "MH0" + soluong.ToString();
           else
               return "MH" + soluong.ToString();
       }
       public static string TaoMaThue()
       {
           int MaMatHangSL = DB.BangThues.Count() + 1;
           string MaMatHang = TaoMaThueTheoSoLuong(MaMatHangSL);
           while (TruyVanTheoMa(MaMatHang) != null)
           {
               MaMatHangSL++;
               MaMatHang = TaoMaThueTheoSoLuong(MaMatHangSL);
           }
           return MaMatHang;

       }
       public static void Them(BangThue Ds)
       {
           DB.BangThues.InsertOnSubmit(Ds);
           DB.SubmitChanges();
       }
       public static void Sua(BangThue Ds)
       {
           BangThue DS = TruyVanTheoMa(Ds.MaThue);
           DS.PhanTramTinh = Ds.PhanTramTinh;
           DS.LaMua = Ds.LaMua;
           DS.LaThueHienTai = Ds.LaThueHienTai;
           DS.NgayCapNhat = Ds.NgayCapNhat;
           DB.SubmitChanges();
       }
       public static void Xoa(string MaThue)
       {
           BangThue Ds = TruyVanTheoMa(MaThue);
           DB.BangThues.DeleteOnSubmit(Ds);
           DB.SubmitChanges();
       }

    }
}
