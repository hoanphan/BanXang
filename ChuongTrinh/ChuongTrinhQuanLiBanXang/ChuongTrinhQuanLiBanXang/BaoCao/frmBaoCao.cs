using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLiBanXang.BaoCao
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao(string LoaiBang,int Nam)
        {
            InitializeComponent();
            BaoCaoThue thue = new BaoCaoThue();
            this.documentViewer1.DocumentSource = thue;
            //if (LoaiBang == "Hàng Nhập")
            //{
            //    BaoCaoHangNhap hangNhap = new BaoCaoHangNhap(Nam);
            //    this.documentViewer1.DocumentSource = hangNhap;
            //}
            //else
            //{
            //    BaoCaoHangBan hangNhap = new BaoCaoHangBan(Nam);
            //    this.documentViewer1.DocumentSource = hangNhap;
            //}


        }
        public frmBaoCao()
        {
            InitializeComponent();
            BaoCaoThue thue = new BaoCaoThue();
            this.documentViewer1.DocumentSource = thue;
            //BaoCaoHangNhap hangNhap = new BaoCaoHangNhap(DateTime.Now.Year);
            //this.documentViewer1.DocumentSource = hangNhap;

        }
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
          
        }
    }
}
