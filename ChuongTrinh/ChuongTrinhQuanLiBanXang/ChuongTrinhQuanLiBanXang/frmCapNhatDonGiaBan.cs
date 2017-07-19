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
    public partial class frmCapNhatDonGiaBan : Form
    {
        DonGiaBan donGiaBan;
        bool Kt;
        public frmCapNhatDonGiaBan()
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
        public frmCapNhatDonGiaBan(DonGiaBan donGiaBan, bool Kt)
        {
            this.donGiaBan = donGiaBan;
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
                this.Text = "Thêm mới đơn giá bán";
                txtMaDonGia.Text = DonGiaBanBLL.TaoMaDonGia();
                txtGiaTien.Focus();
                ckLaGiaHienTai.Checked = false;
               
            }
            else
            {
                txtNgayCapNhat.Visible = true;
                this.Text = "Cập nhật đơn giá bán";
                txtMaDonGia.Text = donGiaBan.MaDonGia;
                txtGiaTien.Text = donGiaBan.Gia.ToString();
                cbMatHang.SelectedValue = donGiaBan.MaDonGia;
                txtNgayCapNhat.Text = donGiaBan.NgayCapNhat.ToString();
                if ((bool)donGiaBan.LaGiaHienTai)
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
                    DonGiaBan Ds = new DonGiaBan
                    {
                        MaDonGia = txtMaDonGia.Text,
                        Gia = decimal.Parse(txtGiaTien.Text),
                        MaMatHang=cbMatHang.SelectedValue.ToString(),
                        NgayCapNhat = DateTime.Now
                    };
                    if (ckLaGiaHienTai.Checked)
                        Ds.LaGiaHienTai = true;
                    else
                        Ds.LaGiaHienTai = false;

                    DonGiaBanBLL.Them(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtGiaTien, "Trường này không thể để trống");
            }
            else
            {
                if (txtGiaTien.Text != null)
                {
                    DonGiaBan Ds = new DonGiaBan
                    {
                        MaDonGia = txtMaDonGia.Text,
                        Gia = decimal.Parse(txtGiaTien.Text),
                        MaMatHang = cbMatHang.SelectedValue.ToString(),
                        NgayCapNhat =DateTime.Parse(txtNgayCapNhat.Text)
                    };
                    if (ckLaGiaHienTai.Checked)
                        Ds.LaGiaHienTai = true;
                    else
                        Ds.LaGiaHienTai = false;

                    DonGiaBanBLL.Sua(Ds);
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