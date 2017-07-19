using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LoadComboboxNam
    {
        static QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public static List<int> DanhSachNam()
        {
            List<int> DanhSach = new List<int>();
            var value = (from db in DB.HangBans select new { year = db.NgayBan.Value.Year }).GroupBy(q => q.year).ToList();
           
            for(int i=0;i<value.Count;i++)
            {
                DanhSach.Add(value[i].Select(q=>q.year).FirstOrDefault());
            }
            return DanhSach;
        }
        public static int NamLonNhat()
        {
            return DB.HangNhaps.Max(q => q.NgayNhap.Value.Year);
        }
    }
}
