using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace ChuongTrinhQuanLiBanXang
{
    public partial class formMatHang : DevExpress.XtraEditors.XtraForm
    {
        public formMatHang()
        {
            InitializeComponent();
            LoadGriview();
        }
         private void LoadGriview()
        {
            gcMatHang.DataSource = MatHangBLL.LoadMatHang();
            
        }
        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapMatHang frm = new frmCapMatHang(null, true);
            frm.ShowDialog();
            LoadGriview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              object rowCellValue = this.gvMatHang.GetRowCellValue(this.gvMatHang.FocusedRowHandle, this.gcMaMatHang);
              if (rowCellValue != null)
              {
                  frmCapMatHang form = new frmCapMatHang(MatHangBLL.TruyVanTheoMa(rowCellValue.ToString()), false);
                  form.ShowDialog();
                  LoadGriview();
              }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvMatHang.GetRowCellValue(this.gvMatHang.FocusedRowHandle, this.gcMaMatHang);
            if (rowCellValue != null)
            {
                DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(questions==DialogResult.Yes)
                {
                    MatHangBLL.Xoa(rowCellValue.ToString());
                    LoadGriview();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcMatHang);
        }
          

      
    }
}
