using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public  class XuatExcel
    {

        public static void XuatRaExcel(GridControl dgvGrid)
        {
            try
            {
                string fileName = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Reset();
                saveFileDialog.Title = "Xuất dữ liệu";
                saveFileDialog.Filter = "Excel file(*.xls)|*.xls|Excel file(*.xlsx)|*.xls|Pdf files (*.pdf)|*.pdf|Html files (*.html)|*.html|Text files (*.txt)|*.txt";
                saveFileDialog.ShowDialog();
                fileName = saveFileDialog.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    string str3 = fileName.Substring(fileName.IndexOf(".") + 1);
                    if (str3 != null)
                    {
                        if (!(str3 == "xls"))
                        {
                            if (str3 == "xlsx")
                            {
                                goto Label_00E7;
                            }
                            if (str3 == "pdf")
                            {
                                goto Label_0115;
                            }
                            if (str3 == "html")
                            {
                                goto Label_0140;
                            }
                            if (str3 == "txt")
                            {
                                goto Label_016B;
                            }
                        }
                        else if (!saveFileDialog.CheckFileExists)
                        {
                            dgvGrid.ExportToXls(fileName);
                        }
                        else if (saveFileDialog.OverwritePrompt)
                        {
                            dgvGrid.ExportToXls(fileName);
                        }
                    }
                }
                return;
            Label_00E7:
                if (!saveFileDialog.CheckFileExists)
                {
                    dgvGrid.ExportToXlsx(fileName);
                }
                else if (saveFileDialog.OverwritePrompt)
                {
                    dgvGrid.ExportToXlsx(fileName);
                }
                return;
            Label_0115:
                if (!saveFileDialog.CheckFileExists)
                {
                    dgvGrid.ExportToPdf(fileName);
                }
                else if (saveFileDialog.OverwritePrompt)
                {
                    dgvGrid.ExportToPdf(fileName);
                }
                return;
            Label_0140:
                if (!saveFileDialog.CheckFileExists)
                {
                    dgvGrid.ExportToHtml(fileName);
                }
                else if (saveFileDialog.OverwritePrompt)
                {
                    dgvGrid.ExportToHtml(fileName);
                }
                return;
            Label_016B:
                if (!saveFileDialog.CheckFileExists)
                {
                    dgvGrid.ExportToText(fileName);
                }
                else if (saveFileDialog.OverwritePrompt)
                {
                    dgvGrid.ExportToText(fileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi trong qu\x00e1 tr\x00ecnh xuất dữ liệu" + exception.ToString());
                throw;
            }

        }
    }
}
