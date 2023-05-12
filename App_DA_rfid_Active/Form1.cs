using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO.Ports;
using System.Threading;

namespace App_DA_rfid_Active
{
    public partial class Form1 : Form
    {
        string str = string.Format(@"Data Source={0}\BaiDoXeHaui.db;Version=3;", Application.StartupPath);
        int count = 0;
        String esp_data_rec = "";
        bool enable_read_data_rec = false; //data_rec_done = false;
        bool data_done_frame = false;
        String uart_rec_temp = "";
        int soLuotXeVao = 0;
        int soLuotXeRa = 0;
        int soXeTrongBai = 0;
        String[,] ArrQuanLyXe = new String[5,4]; //Rfid_code - In/Out - TimeIn - TimeOut

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            lbNotification.Text = "Run application";
            loadDataBase("DB_BaiDoXe");
            ngayAdd.Value.ToString("dd/mm/yyyy");
        }

        private void loadDataBase(String DbName)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                con.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from "+ DbName, con);
                da.Fill(dt);
                dataGridViewSetting.DataSource = dt;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataBase("DB_BaiDoXe");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO DB_BaiDoXe VALUES (null,'{0}','{1}','{2}','{3}','{4}')", tbRfidCode.Text, tbName.Text, tbQuantity.Text, ngayAdd.Value.ToString("dd/mm/yyyy"),tbNote.Text);
            Execute(query);
        }

        private void Execute(string query)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    //MessageBox.Show("Successful");
                    loadDataBase("DB_BaiDoXe");
                    tbRfidCode.Clear();
                    tbName.Clear();
                    tbQuantity.Clear();
                    tbNote.Clear();
                }
            }
        }

        private void dataGridViewSetting_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSetting.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                tbRfidCode.Text = row.Cells[1].Value.ToString();
                tbName.Text = row.Cells[2].Value.ToString();
                tbQuantity.Text= row.Cells[3].Value.ToString();
                ngayAdd.Value = Convert.ToDateTime(row.Cells[3].Value);
                tbNote.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewSetting_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSetting.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
            }
        }

        public string id { get; set; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE DB_BaiDoXe SET rfid_code='{0}',name='{1}',bien_so='{2}',day_add='{3}',note='{4}' WHERE id='{5}'", tbRfidCode.Text, tbName.Text, tbQuantity.Text,ngayAdd.Value.ToString("dd/mm/yyyy"),tbNote.Text, id);
            Execute(query);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = string.Format("DELETE FROM DB_BaiDoXe WHERE id={0}", id);
            Execute(query);
        }

        //----------------------------xu ly uart interrupt----------------------------------
        /*
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lbNotification.Text = $"server disconected.{Environment.NewLine}";
            });
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lbNotification.Text = $"{Encoding.UTF8.GetString(e.Data)} {Environment.NewLine}";
                esp_data_rec = $"{Encoding.UTF8.GetString(e.Data)}";
                tbTimkiem.Text = esp_data_rec;
                tbRfidCode.Text = esp_data_rec;

                SQLiteConnection con;
                SQLiteCommand cmd;
                string sqlconnect = "Data Source=BaiDoXeHaui.db;Version=3; ";
                con = new SQLiteConnection(sqlconnect);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM DB_BaiDoXe WHERE rfid_code='" + esp_data_rec + "';";
                SQLiteDataReader sqr = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(sqr);
                if (data.Rows.Count == 0)
                {
                    rtbThongTin.Text = "Không có thông tin về thẻ này";
                    con.Close();
                }
                else
                {
                    string rfid_code = data.Rows[0].ItemArray[1].ToString();
                    //string thoi_gian = data.Rows[0].ItemArray[2].ToString();
                    //string vao_ra = data.Rows[0].ItemArray[3].ToString();
                    string name = data.Rows[0].ItemArray[2].ToString();
                    string bien_so = data.Rows[0].ItemArray[3].ToString();
                    string day_add = data.Rows[0].ItemArray[4].ToString();
                    string note = data.Rows[0].ItemArray[5].ToString();
                    rtbThongTin.Text = "RFID code: " + rfid_code + "\r\n"
                                    + "Thoi gian: " + DateTime.Now.ToString("h:mm:ss tt") + "\r\n"
                                    + "Vao/ra: " + "VAO" + "\r\n"
                                    + "Name: " + name + "\r\n"
                                    + "Bien so: " + bien_so + "\r\n"
                                    + "Day Add: " + day_add + "\r\n"
                                    + "Note: " + note + "\r\n";
                    count++;
                    this.dataGridViewMonitor.Rows.Add(count.ToString(), DateTime.Now.ToString("h:mm:ss tt"),"xe vao",rfid_code, name, bien_so, day_add, note);

                }//
            });

        }
        */

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lbNotification.Text = $"server conected.{Environment.NewLine}";
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbThongTin.Clear();
            rtbTinhTien.Clear();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SQLiteConnection con;
            SQLiteCommand cmd;
            string sqlconnect = "Data Source=BaiDoXeHaui.db;Version=3; ";
            con = new SQLiteConnection(sqlconnect);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DB_BaiDoXe WHERE rfid_code='" + tbTimkiem.Text + "';";
            SQLiteDataReader sqr = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(sqr);
            if (data.Rows.Count == 0)
            {
                rtbThongTin.Text= "Không có thông tin về thẻ này";
                con.Close();
            }
            else
            {
                string rfid_code = data.Rows[0].ItemArray[1].ToString();
                string name = data.Rows[0].ItemArray[2].ToString();
                string bien_so = data.Rows[0].ItemArray[3].ToString();
                string day_add = data.Rows[0].ItemArray[4].ToString();
                string note = data.Rows[0].ItemArray[5].ToString();
                rtbThongTin.Text = "RFID code: " + rfid_code + "\r\n"
                                + "Name: " + name + "\r\n"
                                + "Bien so: " + bien_so + "\r\n"
                                + "Day Add: " + day_add + "\r\n"
                                + "Note: " + note + "\r\n";
                count++;
                this.dataGridViewMonitor.Rows.Add(count.ToString(),rfid_code, name, bien_so, day_add, note);

            }//
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMonitor.Rows.Clear();
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort1.IsOpen)
                {
                    //MessageBox.Show("Đã kết nối!");
                    SerialPort1.Close();
                    btnConnect.Text = "Connect";
                    btnConnect.BackColor = Color.FromArgb(225, 225, 225);
                    label4.Text = "";
                }
                else
                {
                    SerialPort1.PortName = comboBox1.Text;
                    SerialPort1.Open();
                    btnConnect.Text = "Connected!";
                    btnConnect.BackColor = Color.FromArgb(128, 255, 128);
                    lbNotification.Text = "Connected "+SerialPort1.PortName.ToString() + "-Baud:" + SerialPort1.BaudRate.ToString() +
                        "-Parity:" + SerialPort1.Parity.ToString() + "-Data:" + SerialPort1.DataBits.ToString() + "bit";
                }
            }
            catch
            {
                MessageBox.Show("Connection False !");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text= DateTime.Now.ToString("HH:mm:ss tt");
        }

        Action<String> uartDataReceiver;
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            uartDataReceiver = uart_interrupt_handle;
            this.BeginInvoke(uartDataReceiver, SerialPort1.ReadExisting());
        }


        /*
         *  Frame format
         *  $ <IN/OUT> RFID><CODE>< VT<VALUE>E @ //VT là vị trí xe còn trống
         *  Ex: $ IN RFID>123456< VT9E @
         *  
         */
        private void uart_interrupt_handle(String dat)
        {
            this.Invoke(new Action(() => {

            for (int i = 0; i < dat.Length; i++)
            {
                string temp = dat[i].ToString();
            }


            if (dat.Contains("E"))
            {
                data_done_frame = true;
            }
            //check header start
            if (dat.Contains("$"))
            {
                enable_read_data_rec = true;
                uart_rec_temp = "";
            }
            //get data
            if (enable_read_data_rec == true) uart_rec_temp += dat;

            if (data_done_frame == true)
            {
                if(uart_rec_temp.IndexOf("RFID")>=0)
                {
                        //đọc mã thẻ
                        int startCode = uart_rec_temp.IndexOf("RFID");
                        int stopCode = uart_rec_temp.IndexOf(" VT");
                        String Rfid_code = "";
                        Rfid_code = uart_rec_temp.Substring(startCode + 4, stopCode - startCode - 4);
                        //đọc trạng thái vào/ra
                        String sttInOut = "";
                        if (uart_rec_temp.IndexOf("IN") >= 0)
                        {
                            sttInOut = "IN";
                        }
                        else if (uart_rec_temp.IndexOf("OUT") >= 0)
                        {
                            sttInOut = "OUT";
                        }


                        //rtbTinhTien.AppendText(uart_rec_temp);
                        tbTimkiem.Text = Rfid_code;
                        tbRfidCode.Text = Rfid_code;

                        SQLiteConnection con;
                        SQLiteCommand cmd;
                        string sqlconnect = "Data Source=BaiDoXeHaui.db;Version=3; ";
                        con = new SQLiteConnection(sqlconnect);
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT * FROM DB_BaiDoXe WHERE rfid_code='" + Rfid_code + "';";
                        SQLiteDataReader sqr = cmd.ExecuteReader();
                        DataTable data = new DataTable();
                        data.Load(sqr);
                        if (data.Rows.Count == 0)
                        {
                            rtbThongTin.Text = "Không có thông tin về thẻ này";
                            SerialPort1.Write("F");
                            con.Close();
                        }
                        else
                        {

                            if (uart_rec_temp.IndexOf("IN") >= 0)
                            {
                                if (soXeTrongBai < 5) soXeTrongBai++;
                                soLuotXeVao++;
                            }
                            else if (uart_rec_temp.IndexOf("OUT") >= 0)
                            {
                                if (soXeTrongBai < 5) soXeTrongBai--;
                                soLuotXeRa++;
                            }
                            lbSoLuotXeRa.Text = soLuotXeRa.ToString();
                            lbSoLuotXeVao.Text = soLuotXeVao.ToString();
                            lbSoXeTrongBai.Text = soXeTrongBai.ToString();


                            string rfid_code = data.Rows[0].ItemArray[1].ToString();
                            string name = data.Rows[0].ItemArray[2].ToString();
                            string bien_so = data.Rows[0].ItemArray[3].ToString();
                            string day_add = data.Rows[0].ItemArray[4].ToString();
                            string note = data.Rows[0].ItemArray[5].ToString();
                            //hiển thị lên bảng thông tin
                            rtbThongTin.Text = "RFID code: " + rfid_code + "\r\n"
                                            + "Thời gian: " + DateTime.Now.ToString("h:mm:ss tt") + "\r\n"
                                            + "Vào/ra: " + sttInOut + "\r\n"
                                            + "Tên: " + name + "\r\n"
                                            + "Biển số: " + bien_so + "\r\n"
                                            + "Ngày thêm: " + day_add + "\r\n"
                                            + "Note: " + note + "\r\n";

                            if (sttInOut == "IN")
                            {
                                int checkTrungRfid = 0;
                                for (int i = 0; i < 5; i++)
                                {
                                    if (ArrQuanLyXe[i, 0] == rfid_code)
                                    {
                                        checkTrungRfid = 1;
                                        rtbThongTin.Text = "Thẻ đã đi vào";
                                    }
                                }

                                if (checkTrungRfid == 0)
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (ArrQuanLyXe[i, 0] == null)
                                        {
                                            ArrQuanLyXe[i, 0] = rfid_code;
                                            ArrQuanLyXe[i, 1] = "IN";
                                            ArrQuanLyXe[i, 2] = DateTime.Now.ToString("h:mm:ss tt");
                                            ArrQuanLyXe[i, 3] = null;

                                            count++;
                                            this.dataGridViewMonitor.Rows.Add(count.ToString(), sttInOut, rfid_code, name, bien_so, day_add, ArrQuanLyXe[i, 2]);
                                            break;
                                        }
                                    }
                            }
                            else if (sttInOut == "OUT")
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    if (ArrQuanLyXe[i, 0] == rfid_code)
                                    {
                                        ArrQuanLyXe[i, 0] = null;
                                        ArrQuanLyXe[i, 1] = null; ;
                                        //ArrQuanLyXe[i, 2] = DateTime.Now.ToString("h:mm:ss tt");
                                        ArrQuanLyXe[i, 3] = DateTime.Now.ToString("h:mm:ss tt");
                                        DateTime TimeIn = DateTime.ParseExact(ArrQuanLyXe[i, 2], "h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                                        DateTime TimeOut = DateTime.ParseExact(ArrQuanLyXe[i, 3], "h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                                        TimeSpan totalTimeTime = TimeOut - TimeIn;
                                        String totalTime = totalTimeTime.ToString();
                                        DateTime TimeConver = DateTime.ParseExact(totalTime, "h:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                                        int donGia = int.Parse(tbDonGia.Text);
                                        String ThanhTien = ((float)TimeConver.Hour * donGia + (float)TimeConver.Minute / 60 * donGia + (float)TimeConver.Minute / 3600 * donGia).ToString() + "đ";

                                        count++;
                                        this.dataGridViewMonitor.Rows.Add(count.ToString(), sttInOut, rfid_code, name, bien_so, day_add, ArrQuanLyXe[i, 2], ArrQuanLyXe[i, 3], totalTime, ThanhTien);

                                        //hiển thị lên bảng thông tin
                                        rtbTinhTien.Text = "Thời gian vào: " + ArrQuanLyXe[i, 2] + "\r\n"
                                                        + "Thời gian ra: " + ArrQuanLyXe[i, 3] + "\r\n"
                                                        + "Thời gian trong bãi: " + totalTime + "\r\n"
                                                        + "Thành tiền: " + ThanhTien + "\r\n";
                                    }
                                }
                            }

                            //count++;
                            //this.dataGridViewMonitor.Rows.Add(count.ToString(), DateTime.Now.ToString("h:mm:ss tt"), "xe vao", rfid_code, name, bien_so, day_add, note);
                            //this.dataGridViewMonitor.Rows.Add(count.ToString(), sttInOut, rfid_code, name, bien_so, day_add);
                            SerialPort1.Write("T");
                        }//
                    }//if(uart_rec_temp.IndexOf("RFID")>=0)

                    //đọc vị trí xe còn trống
                    //hiển thị trạng thái vị trí đỗ xe
                    if (uart_rec_temp.IndexOf("VT1ON") > 0) btn_vt1.BackColor = Color.Red; else if (uart_rec_temp.IndexOf("VT1OFF") > 0) btn_vt1.BackColor = Color.LawnGreen;
                    if (uart_rec_temp.IndexOf("VT2ON") > 0) btn_vt2.BackColor = Color.Red; else if (uart_rec_temp.IndexOf("VT2OFF") > 0) btn_vt2.BackColor = Color.LawnGreen;
                    if (uart_rec_temp.IndexOf("VT3ON") > 0) btn_vt3.BackColor = Color.Red; else if (uart_rec_temp.IndexOf("VT3OFF") > 0) btn_vt3.BackColor = Color.LawnGreen;
                    if (uart_rec_temp.IndexOf("VT4ON") > 0) btn_vt4.BackColor = Color.Red; else if (uart_rec_temp.IndexOf("VT4OFF") > 0) btn_vt4.BackColor = Color.LawnGreen;
                    if (uart_rec_temp.IndexOf("VT5ON") > 0) btn_vt5.BackColor = Color.Red; else if (uart_rec_temp.IndexOf("VT5OFF") > 0) btn_vt5.BackColor = Color.LawnGreen;

                    //reset status
                    uart_rec_temp = "";
                    data_done_frame = false;
                    enable_read_data_rec = false;
                }//if (uart_rec_temp.IndexOf("@") >0 && enable_read_data_rec == true)
            }));
        }


        private void copyAlltoClipboard()
        {
            dataGridViewMonitor.SelectAll();
            DataObject dataObj = dataGridViewMonitor.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            /*
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridViewMonitor.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewMonitor.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridViewMonitor.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewMonitor.Columns.Count; j++)
                {
                    try
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewMonitor.Rows[i].Cells[j].Value.ToString();
                    }
                    catch
                    {

                    }
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            */
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


        }
    }//
}
