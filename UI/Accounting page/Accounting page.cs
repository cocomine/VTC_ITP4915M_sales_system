using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M.API;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace UI.Accounting_page {
    public partial class Accounting_page : Form {
        private MySqlConnection conn;
        private Account_Details acc;
        private MySqlDataAdapter order_adapter = new MySqlDataAdapter();
        private MySqlDataAdapter purchase_adapter = new MySqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private Lang lang;

        public Accounting_page(MySqlConnection conn, Account_Details acc, string report = null) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
            if (report != null) {
                dgv_report.DataMember = report;
                bt_output.Enabled = true;
            }

            lang = new Lang(typeof(Accounting_page));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) { Program.Logout(); }

        private void Accounting_page_Load(object sender, EventArgs e) {
            Program.addPage();
            try {
                //order report
                MySqlCommand cmd = new MySqlCommand("SELECT OrderID AS 'Order ID', IF(Payment_Method = 0, 'Cash', 'e-Payment') AS 'Payment Method', Charge, finalTotal AS 'Total', DateTime AS 'Date' FROM `order` WHERE Status = 2 AND Payment_Method != 2;", conn);
                order_adapter.SelectCommand = cmd;

                //Purchase report
                MySqlCommand cmd2 = new MySqlCommand("SELECT p.PurchaseID AS 'Purchase ID', p.DateTime AS 'Date', p.ItemID AS 'Item ID', i.Name AS 'Item', s.Name AS 'Supplier', p.Qty FROM purchase_order p, item i, supplier s WHERE p.ItemID = i.ItemID AND i.SupplierID = s.SupplierID;", conn);
                purchase_adapter.SelectCommand = cmd2;

                //fill dataset
                order_adapter.Fill(dataSet, "Order_report");
                purchase_adapter.Fill(dataSet, "Purchase_report");

                //binding data Source
                dgv_report.DataSource = dataSet;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void Accounting_page_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }

        //order report
        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //fill dataset
                dataSet.Tables["Order_report"].Clear();
                order_adapter.Fill(dataSet, "Order_report");

                //update ui
                dgv_report.DataMember = "Order_report";
                bt_output.Enabled = true;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //Purchase report
        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //fill dataset
                dataSet.Tables["Purchase_report"].Clear();
                purchase_adapter.Fill(dataSet, "Purchase_report");

                //update ui
                dgv_report.DataMember = "Purchase_report";
                bt_output.Enabled = true;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //output xlsx
        private void bt_output_Click(object sender, EventArgs e) {
            DataTable dt = dataSet.Tables[dgv_report.DataMember];
            
            //select filePath1
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //預設路徑為桌面
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyy-MM-dd HHmmss"); //預設檔案名稱

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return; //確認儲存

            string filePath = saveFileDialog1.FileName; //取得用戶指定儲存路徑
            if (!filePath.EndsWith(".xlsx")) filePath += ".xlsx"; //確保檔案副檔名是 .xlsx

            //fill data
            Excel.Application Ex_app = new Excel.Application();
            Excel.Workbook Ex_book = Ex_app.Workbooks.Add();
            Excel.Worksheet Ex_sheet = (Excel.Worksheet)Ex_book.Worksheets[1];

            //Order report
            if (dt.TableName.Equals("Order_report")) {
                Ex_sheet.Name = "Order report"; //sheet name

                //Header
                for (int col = 0; col < dt.Columns.Count; col++) {
                    Ex_sheet.Cells[1, col + 1] = dt.Columns[col].ColumnName;
                }
                Ex_sheet.Range["A1"].Resize[1, dt.Columns.Count].Interior.Color = Color.Orange; //back color
                Ex_sheet.Range["A1"].Resize[1, dt.Columns.Count].Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous; //Borde

                //body
                for (int row = 0; row < dt.Rows.Count; row++) {
                    for (int col = 0; col < dt.Columns.Count; col++) {
                        if (col == 0) Ex_sheet.Cells[row + 2, col + 1] = dt.Rows[row][col].ToString(); //id col
                        else Ex_sheet.Cells[row + 2, col + 1] = dt.Rows[row][col]; //any else
                    }
                }

                //col width
                Ex_sheet.Range["A:B"].ColumnWidth = 14;
                Ex_sheet.Range["C:D"].ColumnWidth = 11;
                Ex_sheet.Range["E1"].Columns.ColumnWidth = 20;

                //footer
                Ex_sheet.Cells[dt.Rows.Count + 3, 1] = "Total"; //col A
                Ex_sheet.Cells[dt.Rows.Count + 3, 3] = $"=SUM(C2:C{dt.Rows.Count + 2})"; //col C
                Ex_sheet.Cells[dt.Rows.Count + 3, 4] = $"=SUM(D2:D{dt.Rows.Count + 2})"; //col D
                Ex_sheet.Range["A"+(dt.Rows.Count + 3), "E"+ (dt.Rows.Count + 3)].Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous; //Borde

                //info
                Ex_sheet.Cells[dt.Rows.Count + 4, 1] = "Cash"; //col A
                Ex_sheet.Cells[dt.Rows.Count + 4, 2] = $"=COUNTIF(B2:B{dt.Rows.Count + 2}, \"Cash\")"; //col B
                Ex_sheet.Cells[dt.Rows.Count + 5, 1] = "e-Payment";
                Ex_sheet.Cells[dt.Rows.Count + 5, 2] = $"=COUNTIF(B2:B{dt.Rows.Count + 2}, \"e-Payment\")";
                Ex_sheet.Cells[dt.Rows.Count + 7, 1] = "Generate Date";
                Ex_sheet.Cells[dt.Rows.Count + 7, 2] = DateTime.Now.ToString("g");
            }

            //Purchase report
            if (dt.TableName.Equals("Purchase_report")) {
                Ex_sheet.Name = "Purchase report"; //sheet name

                //Header
                for (int col = 0; col < dt.Columns.Count; col++) {
                    Ex_sheet.Cells[1, col + 1] = dt.Columns[col].ColumnName;
                }
                Ex_sheet.Range["A1"].Resize[1, dt.Columns.Count].Interior.Color = Color.Orange; //back color
                Ex_sheet.Range["A1"].Resize[1, dt.Columns.Count].Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous; //Borde

                //body
                for (int row = 0; row < dt.Rows.Count; row++) {
                    for (int col = 0; col < dt.Columns.Count; col++) {
                        if (col == 0 || col == 2) Ex_sheet.Cells[row + 2, col + 1] = dt.Rows[row][col].ToString(); //id col
                        else Ex_sheet.Cells[row + 2, col + 1] = dt.Rows[row][col]; //any else
                        
                    }
                }

                //footer
                Ex_sheet.Range["A" + (dt.Rows.Count + 2), "F" + (dt.Rows.Count + 2)].Borders.Item[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous; //Borde

                //col width
                Ex_sheet.Range["A1"].Columns.ColumnWidth = 11;
                Ex_sheet.Range["B1"].Columns.ColumnWidth = 20;
                Ex_sheet.Range["C1"].Columns.ColumnWidth = 32.5;
                Ex_sheet.Range["D:E"].ColumnWidth = 15;
                Ex_sheet.Range["F1"].Columns.ColumnWidth = 7;

                //info
                Ex_sheet.Cells[dt.Rows.Count + 4, 1] = "Generate Date";
                Ex_sheet.Cells[dt.Rows.Count + 4, 2] = DateTime.Now.ToString("g");
            }

            Ex_book.SaveAs(filePath);
            Ex_book.Close();
            Ex_app.Quit();

            Process.Start(filePath); //打開檔案
        }
    }
}