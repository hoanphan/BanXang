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
    public partial class FormDonGiaNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDonGiaNhap()
        {
            InitializeComponent();
            LoadGriview();
        }
         private void LoadGriview()
        {
            gcDonGiaNhap.DataSource = DonGiaNhapBLL.LoadDonGiaNhap();
           
        }
        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatDonGiaNhap frm = new frmCapNhatDonGiaNhap(null, true);
            frm.ShowDialog();
            LoadGriview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              object rowCellValue = this.gvDonGiaNhap.GetRowCellValue(this.gvDonGiaNhap.FocusedRowHandle, this.gcMaDonGia);
              if (rowCellValue != null)
              {
                  frmCapNhatDonGiaNhap form = new frmCapNhatDonGiaNhap(DonGiaNhapBLL.TruyVanTheoMa(rowCellValue.ToString()), false);
                  form.ShowDialog();
                  LoadGriview();
              }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDonGiaNhap.GetRowCellValue(this.gvDonGiaNhap.FocusedRowHandle, this.gcMaDonGia);
            if (rowCellValue != null)
            {
                DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(questions==DialogResult.Yes)
                {
                    DonGiaNhapBLL.Xoa(rowCellValue.ToString());
                    LoadGriview();
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcDonGiaNhap);
        }
          

      
    }
}
