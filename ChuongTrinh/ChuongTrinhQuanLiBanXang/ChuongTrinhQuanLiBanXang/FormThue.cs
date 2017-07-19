using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

using BLL;

namespace ChuongTrinhQuanLiBanXang
{
    public partial class FormThue : DevExpress.XtraEditors.XtraForm
    {
        public FormThue()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013";
            LoadGriview();
        }
         private void LoadGriview()
        {
             
            gcThue.DataSource = ThueBLL.LoadThue();
        }
        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatThue frm = new frmCapNhatThue(null, true);
            frm.ShowDialog();
            LoadGriview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              object rowCellValue = this.gvThue.GetRowCellValue(this.gvThue.FocusedRowHandle, this.gcMaThue);
              if (rowCellValue != null)
              {
                  frmCapNhatThue form = new frmCapNhatThue(ThueBLL.TruyVanTheoMa(rowCellValue.ToString()), false);
                  form.ShowDialog();
                  LoadGriview();
              }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object rowCellValue = this.gvThue.GetRowCellValue(this.gvThue.FocusedRowHandle, this.gcMaThue);
            if (rowCellValue != null)
            {
                DialogResult questions = MessageBox.Show("Bạn có muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(questions==DialogResult.Yes)
                {
                    ThueBLL.Xoa(rowCellValue.ToString());
                    LoadGriview();
                }
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuatExcel.XuatRaExcel(gcThue);
        }
          

      
    }
}
