using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;

namespace BLL
{
    public class KhoBLL
    {
        private int Nam;
        private  QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        public KhoBLL(int Nam)
        {
            this.Nam = Nam;
        }
        private List<KhoXang>  SoLuongtonTuNamTruocHangTon()
        {
            int nam;
            List<KhoXang> listKhoXang = new List<KhoXang>();
            KhoXang gt = new KhoXang();
            List<int> DanhsachNam = LoadComboboxNam.DanhSachNam();
            if (Nam == DanhsachNam[0])
            {
                foreach(MatHang matHang in MatHangBLL.LoadMatHang())
                {
                    KhoXang ds = new KhoXang
                    {
                        MaHang = matHang.MaMatHang,
                        TonXang = 0,
                        XangBan = 0,
                        XangNhap = 0

                    };
                    listKhoXang.Add(ds);
                }
            }
            else
                for (int i = DanhsachNam.Count-1; i >= 0; i--)
                    if (DanhsachNam[i]==Nam)
                    {
                        nam = DanhsachNam[i - 1];
                        int ThangCuoiCung = DB.KhoXangs.Where(q => q.Nam == nam).Max(q => q.Thang);
                        listKhoXang = DB.KhoXangs.Where(q => q.Nam == nam && q.Thang == ThangCuoiCung).ToList();
                        break;
                    }
           
            return listKhoXang;
        }
        private List<int> ListThangTrongNam()
        {
            var value=(from ds in DB.HangNhaps where ds.NgayNhap.Value.Year == Nam select new { Thang = ds.NgayNhap.Value.Month }).OrderBy(q=>q.Thang).GroupBy(q=>q.Thang).ToList();
            List<int> gt =new List<int>();
            foreach(var ob in value)
            {
                gt.Add(ob.Select(q => q.Thang).FirstOrDefault());
            }
            return gt;
        }
        private List<HangNhap> DSHangNhap()
        {
            return DB.HangNhaps.Where(q => q.NgayNhap.Value.Year == Nam).ToList();
        }
        private List<HangBan> DsHangBan()
        {
            return DB.HangBans.Where(q => q.NgayBan.Value.Year == Nam).ToList();
        }
        private List<KhoXang> listKhoXang;
        private void TinhToan()
        {
            List<int> listThang = ListThangTrongNam();
            List<MatHang> listMatHang = MatHangBLL.LoadMatHang();
            listKhoXang = new List<KhoXang>();
            #region[tinh hang ban va hang nhap]
            for (int i=0;i< listThang.Count;i++)
             {
                for(int j=0;j<listMatHang.Count;j++)
                {
                    double hangNhap = 0;
                    double hangBan = 0;
                    if (DSHangNhap().Where(q => q.MaMatHang == listMatHang[j].MaMatHang && q.NgayNhap.Value.Year == Nam && q.NgayNhap.Value.Month == listThang[i]).FirstOrDefault()!=null)
                         hangNhap = (double)DSHangNhap().Where(q => q.MaMatHang == listMatHang[j].MaMatHang && q.NgayNhap.Value.Year == Nam && q.NgayNhap.Value.Month == listThang[i]).Sum(q=>q.SoLuong);
                    if(DsHangBan().Where(q => q.MaMatHang == listMatHang[j].MaMatHang && q.NgayBan.Value.Year == Nam && q.NgayBan.Value.Month == listThang[i]).FirstOrDefault()!=null)
                         hangBan = (double)DsHangBan().Where(q => q.MaMatHang == listMatHang[j].MaMatHang && q.NgayBan.Value.Year == Nam && q.NgayBan.Value.Month == listThang[i]).Sum(q => q.SoLuong);
                    KhoXang ob = new KhoXang
                    {
                        MaHang = listMatHang[j].MaMatHang,
                        XangBan = hangBan,
                        XangNhap = hangNhap,
                        Thang = listThang[i],
                        Nam = Nam
                    };
                    listKhoXang.Add(ob);
                }
             }
            #endregion
            int ThangNhonhat = ListThangTrongNam()[0];
         
           foreach(KhoXang ds in SoLuongtonTuNamTruocHangTon())
            {
                KhoXang Ds = listKhoXang.Where(q => q.Thang == ThangNhonhat).Where(q => q.MaHang == ds.MaHang).FirstOrDefault();
                Ds.TonCu = ds.TonXang;
            }
           foreach(KhoXang ds in listKhoXang)
            {
                ds.TonXang = ds.TonCu + ds.XangNhap - ds.XangBan;
                if (KhoHangBLL.TruyVanTheMa(ds.Nam, ds.Thang, ds.MaHang) == null)
                    KhoHangBLL.Them(ds);
                else
                    KhoHangBLL.Sua(ds);
            }
        }
        public IList LoadAll()
        {
            TinhToan();
            return (from ds in DB.KhoXangs where ds.Nam==Nam select new { ThangNam = ds.Thang + "-" + ds.Nam, TonKhoCu = ds.TonCu, TenHang = ds.MatHang.TenHang, TongNhap = ds.XangNhap, TongBan = ds.XangBan,Ton=ds.TonXang }).ToList();
        }
    }
}
