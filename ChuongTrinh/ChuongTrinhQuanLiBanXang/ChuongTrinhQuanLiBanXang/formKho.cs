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
namespace ChuongTrinhQuanLiBanXang.Imager
{
    public partial class formKho : Form
    {
        public formKho()
        {
            InitializeComponent();
            LoadCb();
            int maxYear = LoadComboboxNam.NamLonNhat();
            KhoBLL kho = new KhoBLL(maxYear);
            gcKho.DataSource= kho.LoadAll();
            
        }
        private void LoadCb()
        {
            List<int> DanhSach = LoadComboboxNam.DanhSachNam();
            for(int i=0;i<DanhSach.Count;i++)
            rpNam.Items.Add(DanhSach[i]);
            rpNam.NullText = "2016";
        }

        private void barNam_EditValueChanged(object sender, EventArgs e)
        {
            int value = (int)barNam.EditValue;
            KhoBLL kho = new KhoBLL(value);
            gcKho.DataSource = kho.LoadAll();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcKho);
        }
    }
}
