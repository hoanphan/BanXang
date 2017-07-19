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
    public partial class frmCapMatHang : Form
    {
        MatHang matHang;
        bool Kt;
        public frmCapMatHang()
        {
            InitializeComponent();
            LoadForm();
        }
        public frmCapMatHang(MatHang matHang, bool Kt)
        {
            this.matHang = matHang;
            this.Kt = Kt;
            InitializeComponent();
            txtMaMatHang.Enabled = false;
           
            LoadForm();
        }
        private void LoadForm()
        {
            if (Kt)
            {
                this.Text = "Thêm mới mặt hàng";
                txtMaMatHang.Text = MatHangBLL.TaoMaMatHang();
                txtTenMatHang.Focus();
               
            }
            else
            {
                
                this.Text = "Cập nhật mặt hàng";
                txtMaMatHang.Text = matHang.MaMatHang;
                txtTenMatHang.Text = matHang.TenHang;
                txtDonViTinh.Text = matHang.DonViTinh;
              
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
                if (txtTenMatHang.Text != null)
                {
                    MatHang Ds = new MatHang
                    {
                        MaMatHang = txtMaMatHang.Text,
                        TenHang = txtTenMatHang.Text,
                        DonViTinh = txtDonViTinh.Text,
                    };
                    MatHangBLL.Them(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtTenMatHang, "Trường này không thể để trống");
            }
            else
            {
                if (txtTenMatHang.Text != null)
                {
                    MatHang Ds = new MatHang
                    {
                        MaMatHang = txtMaMatHang.Text,
                        TenHang = txtTenMatHang.Text,
                        DonViTinh = txtDonViTinh.Text,
                    };
                    MatHangBLL.Sua(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtTenMatHang, "Trường này không thể để trống");
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}