using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace ChuongTrinhQuanLiBanXang
{
    public partial class frmCapNhatDonGiaNhap : Form
    {
        DonGiaNhap donGiaNhap;
        bool Kt;
        public frmCapNhatDonGiaNhap()
        {
            InitializeComponent();
            LoadDuLieuVaoComboBox();
           
        }
        private void LoadDuLieuVaoComboBox()
        {
            cbMatHang.DataSource = MatHangBLL.LoadMatHang();
            cbMatHang.DisplayMember = "TenHang";
            cbMatHang.ValueMember = "MaMatHang";
        }
        public frmCapNhatDonGiaNhap(DonGiaNhap donGiaNhap, bool Kt)
        {
            this.donGiaNhap = donGiaNhap;
            this.Kt = Kt;
            InitializeComponent();
            txtMaDonGia.Enabled = false;
            txtNgayCapNhat.Visible = false;
            LoadForm();
            LoadDuLieuVaoComboBox();
        }
        private void LoadForm()
        {
            if (Kt)
            {
                this.Text = "Thêm mới đơn giá nhập";
                txtMaDonGia.Text = DonGiaNhapBLL.TaoMaDonGia();
                txtGiaTien.Focus();
                ckLaGiaHienTai.Checked = false;
               
            }
            else
            {
                txtNgayCapNhat.Visible = true;
                this.Text = "Cập nhật đơn giá nhập";
                txtMaDonGia.Text = donGiaNhap.MaDonGia;
                txtGiaTien.Text = donGiaNhap.Gia.ToString();
                cbMatHang.SelectedValue = donGiaNhap.MaDonGia;
                txtNgayCapNhat.Text = donGiaNhap.NgayCapNhat.ToString();
                if ((bool)donGiaNhap.GiaHienTai)
                    ckLaGiaHienTai.Checked = true;
                else
                    ckLaGiaHienTai.Checked = false;
                
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Kt)
            {
                if (txtGiaTien.Text != null)
                {
                    DonGiaNhap Ds = new DonGiaNhap
                    {
                        MaDonGia = txtMaDonGia.Text,
                        Gia = decimal.Parse(txtGiaTien.Text),
                        MaMatHang=cbMatHang.SelectedValue.ToString(),
                        NgayCapNhat = DateTime.Now
                    };
                    if (ckLaGiaHienTai.Checked)
                        Ds.GiaHienTai = true;
                    else
                        Ds.GiaHienTai = false;

                    DonGiaNhapBLL.Them(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtGiaTien, "Trường này không thể để trống");
            }
            else
            {
                if (txtGiaTien.Text != null)
                {
                    DonGiaNhap Ds = new DonGiaNhap
                    {
                        MaDonGia = txtMaDonGia.Text,
                        Gia = decimal.Parse(txtGiaTien.Text),
                        MaMatHang = cbMatHang.SelectedValue.ToString(),
                        NgayCapNhat = DateTime.Parse(txtNgayCapNhat.Text)
                    };
                    if (ckLaGiaHienTai.Checked)
                        Ds.GiaHienTai = true;
                    else
                        Ds.GiaHienTai = false;

                    DonGiaNhapBLL.Sua(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtGiaTien, "Trường này không thể để trống");

            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}