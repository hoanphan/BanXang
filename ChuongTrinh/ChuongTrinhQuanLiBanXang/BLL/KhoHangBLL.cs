using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class KhoHangBLL
    {
        static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static KhoXang TruyVanTheMa(int Nam,int Thang,string MaHang)
        {
            return DB.KhoXangs.Where(q => q.Nam == Nam && q.Thang == Thang&&q.MaHang==MaHang).FirstOrDefault();
        }
        public static void Them(KhoXang ds)
        {
            DB.KhoXangs.InsertOnSubmit(ds);
            DB.SubmitChanges();
        }
        public static void Sua(KhoXang ds)
        {
            KhoXang DS = TruyVanTheMa(ds.Nam, ds.Thang,ds.MaHang);
            DS.TonXang = ds.TonXang;
            DS.XangBan = ds.XangBan;
            DS.XangNhap = ds.XangNhap;
            DB.SubmitChanges();
        }
    }
}
