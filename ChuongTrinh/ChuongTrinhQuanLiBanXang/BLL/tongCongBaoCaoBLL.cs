using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class tongCongBaoCaoBLL
    {
       static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static List<BaoCaoTong> LoadHangBan(int Thang,int Nam)
       {
           List<BaoCaoTong> list = new List<BaoCaoTong>();
            foreach(MatHang matHang in MatHangBLL.LoadMatHang())
            {
                BaoCaoTong Ds = new BaoCaoTong();
                Ds.Thang = Thang;
                Ds.Nam = Nam;
                Ds.Ten ="Total "+ matHang.TenHang;
                foreach(HangBan hangBan in HangBanDLL.LoadALL(Thang,Nam))
                {
                    if(hangBan.MaMatHang==matHang.MaMatHang)
                    {
                        Ds.SoLuong += (decimal)hangBan.SoLuong;
                        Ds.ThanhTien += (decimal)hangBan.ThanhTien;
                        Ds.TongThue += (decimal)hangBan.Thue;
                        Ds.TongCong += (decimal)hangBan.TongCong;
                    }
                }
                list.Add(Ds);
            }
            BaoCaoTong DS = new BaoCaoTong();
            DS.Thang = Thang;
            DS.Nam = Nam;
            DS.Ten = "Full Total";
            foreach (HangBan hangBan in HangBanDLL.LoadALL(Thang, Nam))
            {


                DS.ThanhTien += (decimal)hangBan.ThanhTien;
                DS.TongThue += (decimal)hangBan.Thue;
                DS.TongCong += (decimal)hangBan.TongCong;
                
            }
            list.Add(DS);
            return list;
            
       }
        public static List<BaoCaoTong> LoadHangMua(int Thang, int Nam)
        {
            List<BaoCaoTong> list = new List<BaoCaoTong>();
            foreach (MatHang matHang in MatHangBLL.LoadMatHang())
            {
                BaoCaoTong Ds = new BaoCaoTong();
                Ds.Thang = Thang;
                Ds.Nam = Nam;
                Ds.Ten = "Total " + matHang.TenHang;
                foreach (HangNhap hangBan in HangNhapBLL.LoadALL(Thang, Nam))
                {
                    if (hangBan.MaMatHang == matHang.MaMatHang)
                    {
                        Ds.SoLuong += (decimal)hangBan.SoLuong;
                        Ds.ThanhTien += (decimal)hangBan.ThanhTien;
                        Ds.TongThue += (decimal)hangBan.Thue;
                        Ds.TongCong += (decimal)hangBan.TongCong;
                    }
                }
                list.Add(Ds);
            }
            BaoCaoTong DS = new BaoCaoTong();
            DS.Thang = Thang;
            DS.Nam = Nam;
            DS.Ten = "Full Total";
            foreach (HangNhap hangBan in HangNhapBLL.LoadALL(Thang, Nam))
            {


                DS.ThanhTien += (decimal)hangBan.ThanhTien;
                DS.TongThue += (decimal)hangBan.Thue;
                DS.TongCong += (decimal)hangBan.TongCong;

            }
            list.Add(DS);
            return list;

        }
    }
}
