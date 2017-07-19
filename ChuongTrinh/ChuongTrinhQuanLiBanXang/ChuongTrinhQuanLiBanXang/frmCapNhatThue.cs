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
    public partial class 
        frmCapNhatThue : Form
    {
        BangThue BangThue;
        bool Kt;
        public frmCapNhatThue()
        {
            InitializeComponent();
            LoadForm();
        }
        public frmCapNhatThue(BangThue BangThue, bool Kt)
        {
            this.BangThue = BangThue;
            this.Kt = Kt;
            InitializeComponent();
            txtMaThue.Enabled = false;
            txtNgayCapNhat.Visible = false;
            LoadForm();
        }
        private void LoadForm()
        {
            if (Kt)
            {
                this.Text = "Thêm mới thuế";
                txtMaThue.Text = ThueBLL.TaoMaThue();
                txtPhanTram.Focus();
                ckLaHienTai.Checked = false;
                ckLaMua.Checked = false;
            }
            else
            {
                txtNgayCapNhat.Visible = true;
                this.Text = "Cập nhật thuế";
                txtMaThue.Text = BangThue.MaThue;
                txtPhanTram.Text = BangThue.PhanTramTinh.ToString();
                txtNgayCapNhat.Text = BangThue.NgayCapNhat.ToString();
                if ((bool)BangThue.LaThueHienTai)
                    ckLaHienTai.Checked = true;
                else
                    ckLaHienTai.Checked = false;
                if ((bool)BangThue.LaMua)
                    ckLaMua.Checked = true;
                else
                    ckLaMua.Checked = false;
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
                if (txtPhanTram.Text != null)
                {
                    BangThue Ds = new BangThue
                    {
                        MaThue = txtMaThue.Text,
                        NgayCapNhat = DateTime.Now,
                        PhanTramTinh = float.Parse(txtPhanTram.Text),
                    };
                    if (ckLaHienTai.Checked)
                        Ds.LaThueHienTai = true;
                    else
                        Ds.LaThueHienTai = false;
                    if (ckLaMua.Checked)
                        Ds.LaMua = true;
                    else
                        Ds.LaMua = false;
                    ThueBLL.Them(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtPhanTram, "Trường này không thể để trống");
            }
            else
            {
                if (txtPhanTram.Text != null)
                {
                    BangThue Ds = new BangThue
                    {
                        MaThue = txtMaThue.Text,
                        NgayCapNhat = DateTime.Parse(txtNgayCapNhat.Text),
                        PhanTramTinh = float.Parse(txtPhanTram.Text),
                    };
                    if (ckLaHienTai.Checked)
                        Ds.LaThueHienTai = true;
                    else
                        Ds.LaThueHienTai = false;
                    if (ckLaMua.Checked)
                        Ds.LaMua = true;
                    else
                        Ds.LaMua = false;
                    ThueBLL.Sua(Ds);
                    base.Close();
                }
                else
                    dxErrorProvider1.SetError(txtPhanTram, "Trường này không thể để trống");
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}