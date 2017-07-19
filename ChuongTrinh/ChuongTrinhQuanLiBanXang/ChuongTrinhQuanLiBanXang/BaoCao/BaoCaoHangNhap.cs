using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DAL;
using BLL;
namespace ChuongTrinhQuanLiBanXang.BaoCao
{
    public partial class BaoCaoHangNhap : DevExpress.XtraReports.UI.XtraReport
    {
        private int Nam;
        public BaoCaoHangNhap(int _Nam)
        {
            Nam = _Nam;
            InitializeComponent();
            TaoFormHangNhap();
        }
        private void TaoFormHangNhap()
        {
            QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
            float i = 0;
            float vtThang = 0;
            int nam = Nam;
            for (int thang = HangNhapBLL.LayRaThangNhoNhat(nam); thang <= HangNhapBLL.LayRaThangLonNhat(nam); thang++)
            {
                XRLabel lableDienGiai = new XRLabel();
                lableDienGiai.BorderWidth = 1f;
                lableDienGiai.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                lableDienGiai.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                | DevExpress.XtraPrinting.BorderSide.Left)));
                lableDienGiai.LocationF = new DevExpress.Utils.PointFloat(123.12f, vtThang);
                lableDienGiai.WidthF = 60.21f;
                //lableDienGiai.HeightF = HangNhapBLL.LoadALL(thang, nam).Count * 50f;
                lableDienGiai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                lableDienGiai.Text = "Tháng " + thang;
                //vtThang = vtThang + HangNhapBLL.LoadALL(thang, nam).Count * 50f;
                foreach (BaoCaoTong Ds in tongCongBaoCaoBLL.LoadHangMua(thang, nam))
                {
                    XRLabel lableTenTongKet = new XRLabel();
                    lableTenTongKet.BorderWidth = 1f;
                    lableTenTongKet.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTenTongKet.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Left)));
                    lableTenTongKet.LocationF = new DevExpress.Utils.PointFloat(0, vtThang);
                    lableTenTongKet.WidthF = 183.33f;
                    lableTenTongKet.HeightF = 50f;
                    lableTenTongKet.BackColor = Color.LightBlue;
                    lableTenTongKet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    lableTenTongKet.Text = Ds.Ten;

                    XRLabel lableTenTongThanhTien = new XRLabel();
                    lableTenTongThanhTien.BorderWidth = 1f;
                    lableTenTongThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTenTongThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTenTongThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTenTongThanhTien.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableTenTongThanhTien.LocationF = new DevExpress.Utils.PointFloat(404.9f, vtThang);
                    lableTenTongThanhTien.WidthF = 97.02f;
                    lableTenTongThanhTien.HeightF = 50f;
                    lableTenTongThanhTien.BackColor = Color.LightBlue;
                    lableTenTongThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableGia = new XRLabel();
                    lableGia.BorderWidth = 1f;
                    lableGia.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableGia.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableGia.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableGia.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableGia.LocationF = new DevExpress.Utils.PointFloat(338.76f, vtThang);
                    lableGia.WidthF = 66.14f;
                    lableGia.HeightF = 50f;
                    lableGia.BackColor = Color.LightBlue;
                    lableGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    lableGia.Text = "";

                    XRLabel lableThue = new XRLabel();
                    lableThue.BorderWidth = 1f;
                    lableThue.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThue.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThue.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThue.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableThue.LocationF = new DevExpress.Utils.PointFloat(501.92f, vtThang);
                    lableThue.WidthF = 73.99f;
                    lableThue.HeightF = 50f;
                    lableThue.BackColor = Color.LightBlue;
                    lableThue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableTong = new XRLabel();
                    lableTong.BorderWidth = 1f;
                    lableTong.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTong.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTong.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTong.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableTong.LocationF = new DevExpress.Utils.PointFloat(575.91f, vtThang);
                    lableTong.WidthF = 73.99f;
                    lableTong.HeightF = 50f;
                    lableTong.BackColor = Color.LightBlue;
                    lableTong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableKhac = new XRLabel();
                    lableKhac.BorderWidth = 1f;
                    lableKhac.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableKhac.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableKhac.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableKhac.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableKhac.LocationF = new DevExpress.Utils.PointFloat(302.3f, vtThang);
                    lableKhac.WidthF = 36.46f;
                    lableKhac.HeightF = 50f;
                    lableKhac.BackColor = Color.LightBlue;
                    lableKhac.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.Ten != "Total Dầu" && Ds.Ten != "Total Xăng" && Ds.Ten != "Full Total")
                    {
                        lableKhac.Text = Ds.SoLuong.ToString();
                        lableThue.Text = Ds.TongThue.ToString();
                        lableTong.Text = Ds.TongCong.ToString();
                    }
                    else
                        lableKhac.Text = "";


                    XRLabel Dau = new XRLabel();
                    Dau.BorderWidth = 1f;
                    Dau.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    Dau.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    Dau.LocationF = new DevExpress.Utils.PointFloat(241.06f, vtThang);
                    Dau.BackColor = Color.LightBlue;
                    Dau.WidthF = 61.24f;
                    Dau.HeightF = 50f;
                    Dau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.Ten == "Total Dầu")
                    {
                        Dau.Text = Ds.SoLuong.ToString();
                        lableTenTongThanhTien.Text = Ds.ThanhTien.ToString();
                        lableThue.Text = Ds.TongThue.ToString();
                        lableTong.Text = Ds.TongCong.ToString();
                    }
                    else
                        Dau.Text = "";

                    XRLabel lableXang = new XRLabel();
                    lableXang.BorderWidth = 1f;
                    lableXang.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableXang.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableXang.LocationF = new DevExpress.Utils.PointFloat(183.33f, vtThang);
                    lableXang.WidthF = 57.73f;
                    lableXang.HeightF = 50f;
                    lableXang.BackColor = Color.LightBlue;
                    lableXang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.Ten == "Total Xăng")
                    {
                        lableXang.Text = Ds.SoLuong.ToString();
                        lableTenTongThanhTien.Text = Ds.ThanhTien.ToString();
                        lableThue.Text = Ds.TongThue.ToString();
                        lableTong.Text = Ds.TongCong.ToString();
                    }
                    else
                        lableXang.Text = "";
                    if (Ds.Ten == "Full Total")
                    {

                        lableTenTongThanhTien.Text = Ds.ThanhTien.ToString();
                        lableThue.Text = Ds.TongThue.ToString();
                        lableTong.Text = Ds.TongCong.ToString();
                    }
                    vtThang = vtThang + 50f;

                    Detail.Controls.Add(lableTenTongKet);
                    Detail.Controls.Add(lableXang);
                    Detail.Controls.Add(Dau);
                    Detail.Controls.Add(lableTenTongThanhTien);
                    Detail.Controls.Add(lableGia);
                    Detail.Controls.Add(lableKhac);
                    Detail.Controls.Add(lableThue);
                    Detail.Controls.Add(lableTong);
                }
                foreach (HangNhap Ds in HangNhapBLL.LoadALL(thang, nam))
                {
                    XRLabel lable = new XRLabel();
                    lable.BorderWidth = 1f;
                    lable.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lable.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Left)));
                    lable.LocationF = new DevExpress.Utils.PointFloat(0, i);
                    lable.WidthF = 52.19f;
                    lable.HeightF = 50f;
                    lable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    lable.Text = Ds.NgayNhap.Value.Day + "-" + Ds.NgayNhap.Value.Month;
                    XRLabel lableSoHieu = new XRLabel();
                    lableSoHieu.BorderWidth = 1f;
                    lableSoHieu.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableSoHieu.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableSoHieu.LocationF = new DevExpress.Utils.PointFloat(52.19f, i);
                    lableSoHieu.WidthF = 70.93f;
                    lableSoHieu.HeightF = 50f;
                    lableSoHieu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    lableSoHieu.Text = Ds.SoHieu;
                    XRLabel lableGia = new XRLabel();
                    lableGia.BorderWidth = 1f;
                    lableGia.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableGia.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableGia.LocationF = new DevExpress.Utils.PointFloat(338.76f, i);
                    lableGia.WidthF = 66.14f;
                    lableGia.HeightF = 50f;
                    lableGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableThanhTien = new XRLabel();
                    lableThanhTien.BorderWidth = 1f;
                    lableThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThanhTien.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThanhTien.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableThanhTien.LocationF = new DevExpress.Utils.PointFloat(404.9f, i);
                    lableThanhTien.WidthF = 97.02f;
                    lableThanhTien.HeightF = 50f;
                    lableThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableThue = new XRLabel();
                    lableThue.BorderWidth = 1f;
                    lableThue.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableThue.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableThue.LocationF = new DevExpress.Utils.PointFloat(501.92f, i);
                    lableThue.WidthF = 73.99f;
                    lableThue.HeightF = 50f;
                    lableThue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    XRLabel lableTongCong = new XRLabel();
                    lableTongCong.BorderWidth = 1f;
                    lableTongCong.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableTongCong.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableTongCong.LocationF = new DevExpress.Utils.PointFloat(575.91f, i);
                    lableTongCong.WidthF = 73.99f;
                    lableTongCong.HeightF = 50f;
                    lableTongCong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;


                    XRLabel lableXang = new XRLabel();
                    lableXang.BorderWidth = 1f;
                    lableXang.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableXang.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableXang.LocationF = new DevExpress.Utils.PointFloat(183.33f, i);
                    lableXang.WidthF = 57.73f;
                    lableXang.HeightF = 50f;
                    lableXang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.MatHang.TenHang == "Xăng")
                    {
                        lableGia.Text = Ds.Gia.ToString();
                        lableXang.Text = Ds.SoLuong.ToString();
                        lableThue.Text = Ds.Thue.ToString();
                        lableThanhTien.Text = Ds.ThanhTien.ToString();
                        lableTongCong.Text = Ds.TongCong.ToString();

                    }
                    else
                        lableXang.Text = "";


                    XRLabel lableDau = new XRLabel();
                    lableDau.BorderWidth = 1f;
                    lableDau.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableDau.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableDau.LocationF = new DevExpress.Utils.PointFloat(241.06f, i);
                    lableDau.WidthF = 61.24f;
                    lableDau.HeightF = 50f;
                    lableDau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.MatHang.TenHang == "Dầu")
                    {
                        lableGia.Text = Ds.Gia.ToString();
                        lableDau.Text = Ds.SoLuong.ToString();
                        lableThue.Text = Ds.Thue.ToString();
                        lableThanhTien.Text = Ds.ThanhTien.ToString();
                        lableTongCong.Text = Ds.TongCong.ToString();
                    }
                    else
                        lableDau.Text = "";
                    XRLabel lableKhac = new XRLabel();
                    lableKhac.BorderWidth = 1f;
                    lableKhac.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
                    lableKhac.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.None)));
                    lableKhac.LocationF = new DevExpress.Utils.PointFloat(302.3f, i);
                    lableKhac.WidthF = 36.46f;
                    lableKhac.HeightF = 50f;
                    lableKhac.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    if (Ds.MatHang.TenHang != "Dầu" && Ds.MatHang.TenHang != "Xăng")
                    {
                        lableGia.Text = Ds.Gia.ToString();
                        lableKhac.Text = Ds.SoLuong.ToString();
                        lableThue.Text = Ds.Thue.ToString();
                        lableThanhTien.Text = Ds.ThanhTien.ToString();
                        lableTongCong.Text = Ds.TongCong.ToString();
                    }
                    else
                        lableKhac.Text = "";
                    i = i + 50f;

                    Detail.Controls.Add(lable);
                    Detail.Controls.Add(lableSoHieu);
                    Detail.Controls.Add(lableXang);
                    Detail.Controls.Add(lableDau);
                    Detail.Controls.Add(lableKhac);
                    Detail.Controls.Add(lableGia);
                    Detail.Controls.Add(lableThue);
                    Detail.Controls.Add(lableThanhTien);
                    Detail.Controls.Add(lableTongCong);
                }
                i += (float)MatHangBLL.LoadMatHang().Count * 20 + 50f;

                Detail.Controls.Add(lableDienGiai);

            }
        }

    }
}
