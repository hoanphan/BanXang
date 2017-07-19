using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DAL;
using BLL;
using ChuongTrinhQuanLiBanXang.BaoCao;
using ChuongTrinhQuanLiBanXang.Imager;

namespace ChuongTrinhQuanLiBanXang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013";
            Load();
            LoadCbbNam();
            

            
        }
        QuanLiBanXangDataContext DB = new QuanLiBanXangDataContext();
        void Load()
        {
            panelMail.Controls.Clear();
            FormThue frm = new FormThue();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }
        protected void LoadCbbNam()
        {
            int NamNhoNhat = DB.HangNhaps.Min(q => q.NgayNhap.Value.Year) > DB.HangBans.Min(q => q.NgayBan.Value.Year) ? DB.HangNhaps.Min(q => q.NgayNhap.Value.Year) : DB.HangBans.Min(q => q.NgayBan.Value.Year);
            int NamLonNhat = DB.HangNhaps.Max(q => q.NgayNhap.Value.Year) > DB.HangBans.Max(q => q.NgayBan.Value.Year) ? DB.HangNhaps.Max(q => q.NgayNhap.Value.Year) : DB.HangBans.Max(q => q.NgayBan.Value.Year);
            for (int i = NamNhoNhat; i <= NamLonNhat; i++)
            {
                cbbNam.Items.Add(i);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMail.Controls.Clear();
            formMatHang frm = new formMatHang();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDonGiaNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMail.Controls.Clear();
            FormDonGiaNhap frm = new FormDonGiaNhap();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDonGiaBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMail.Controls.Clear();
            FormDonGiaBan frm = new FormDonGiaBan();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMail.Controls.Clear();
            formHangBan frm = new formHangBan();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                object valueLoaiBang = cbLoaiBang.EditValue;
                object valueNam = cbYear.EditValue;
                if (valueLoaiBang.ToString() != null && valueNam != null)
                {
                    frmBaoCao _frmBaoCao = new frmBaoCao(valueLoaiBang.ToString(), (int)valueNam);
                    panelMail.Controls.Clear();

                    _frmBaoCao.TopLevel = false;
                    _frmBaoCao.AutoScroll = true;
                    panelMail.Controls.Add(_frmBaoCao);
                    _frmBaoCao.Dock = DockStyle.Fill;
                    _frmBaoCao.Show();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu chưa đầy đủ. Xem lại lại thông tin cần lấy");
            }
         
                
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMail.Controls.Clear();
            formKho frm = new formKho();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            panelMail.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
