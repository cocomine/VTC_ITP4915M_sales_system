using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M.API {
    public class savePDF {
        public static void Save(string html) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //預設路徑為桌面
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyy-MM-dd HHmmss") + " Receipt"; //預設檔案名稱

            //確認儲存
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog1.FileName; //取得用戶指定儲存路徑
                if (!filePath.EndsWith(".pdf")) filePath += ".pdf"; //確保檔案副檔名是 .pdf

                PdfWriter writer = new PdfWriter(new FileStream(filePath, FileMode.Create), new WriterProperties().SetFullCompressionMode(true)); //設定壓縮等級
                PdfDocument pdfDocument = new PdfDocument(writer);
                pdfDocument.SetDefaultPageSize(PageSize.A4); //設定紙張大小

                HtmlConverter.ConvertToPdf(html, writer); //輸出儲存

                MessageBox.Show("Receipt saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(filePath); //打開檔案
            }
        }
    }
}
