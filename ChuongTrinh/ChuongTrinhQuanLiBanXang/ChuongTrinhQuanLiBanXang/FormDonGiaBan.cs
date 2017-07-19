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
    public partial class FormDonGiaBan : DevExpress.XtraEditors.XtraForm
    {
        public FormDonGiaBan()
        {
            InitializeComponent();
            LoadGriview();
        }
         private void LoadGriview()
        {
            gcDonGiaBan.DataSource = DonGiaBanBLL.LoadDonGiaBan();
           
        }
        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatDonGiaBan frm = new frmCapNhatDonGiaBan(null, true);
            frm.ShowDialog();
            LoadGriview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              object rowCellValue = this.gvDonGiaBan.GetRowCellValue(this.gvDonGiaBan.FocusedRowHandle, this.gcMaDonGia);
              if (rowCellValue != null)
              {
                  frmCapNhatDonGiaBan form = new frmCapNhatDonGiaBan(DonGiaBanBLL.TruyVanTheoMa(rowCellValue.ToString()), false);
                  form.ShowDialog();
                  LoadGriview();
              }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvDonGiaBan.GetRowCellValue(this.gvDonGiaBan.FocusedRowHandle, this.gcMaDonGia);
            if (rowCellValue != null)
            {
                DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(questions==DialogResult.Yes)
                {
                    DonGiaBanBLL.Xoa(rowCellValue.ToString());
                    LoadGriview();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcDonGiaBan);
        }
          

      
    }
}
