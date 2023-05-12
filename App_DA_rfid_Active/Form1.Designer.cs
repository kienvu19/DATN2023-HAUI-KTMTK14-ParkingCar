
namespace App_DA_rfid_Active
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Monitor = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.rtbThongTin = new System.Windows.Forms.RichTextBox();
            this.rtbTinhTien = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbClock = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_vt5 = new System.Windows.Forms.Button();
            this.btn_vt4 = new System.Windows.Forms.Button();
            this.btn_vt3 = new System.Windows.Forms.Button();
            this.btn_vt2 = new System.Windows.Forms.Button();
            this.btn_vt1 = new System.Windows.Forms.Button();
            this.lbSoXeTrongBai = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbSoLuotXeRa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSoLuotXeVao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewMonitor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.TabPage();
            this.dataGridViewSetting = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ngayAdd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRfidCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNotification = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDonGia = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this._STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RFID_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._day_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToltalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetting)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Monitor);
            this.tabControl1.Controls.Add(this.History);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 571);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Monitor
            // 
            this.Monitor.Controls.Add(this.label19);
            this.Monitor.Controls.Add(this.tbDonGia);
            this.Monitor.Controls.Add(this.lbDonGia);
            this.Monitor.Controls.Add(this.label17);
            this.Monitor.Controls.Add(this.rtbThongTin);
            this.Monitor.Controls.Add(this.rtbTinhTien);
            this.Monitor.Controls.Add(this.pictureBox1);
            this.Monitor.Controls.Add(this.groupBox3);
            this.Monitor.Controls.Add(this.btnClear);
            this.Monitor.Controls.Add(this.label9);
            this.Monitor.Controls.Add(this.label8);
            this.Monitor.Controls.Add(this.dataGridViewMonitor);
            this.Monitor.Controls.Add(this.groupBox1);
            this.Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor.Location = new System.Drawing.Point(4, 29);
            this.Monitor.Name = "Monitor";
            this.Monitor.Padding = new System.Windows.Forms.Padding(3);
            this.Monitor.Size = new System.Drawing.Size(1308, 538);
            this.Monitor.TabIndex = 0;
            this.Monitor.Text = "Monitor";
            this.Monitor.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(592, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Thông tin thanh toán";
            // 
            // rtbThongTin
            // 
            this.rtbThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbThongTin.Location = new System.Drawing.Point(10, 93);
            this.rtbThongTin.Name = "rtbThongTin";
            this.rtbThongTin.ReadOnly = true;
            this.rtbThongTin.Size = new System.Drawing.Size(580, 165);
            this.rtbThongTin.TabIndex = 8;
            this.rtbThongTin.Text = "";
            // 
            // rtbTinhTien
            // 
            this.rtbTinhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTinhTien.Location = new System.Drawing.Point(596, 93);
            this.rtbTinhTien.Name = "rtbTinhTien";
            this.rtbTinhTien.ReadOnly = true;
            this.rtbTinhTien.Size = new System.Drawing.Size(529, 165);
            this.rtbTinhTien.TabIndex = 7;
            this.rtbTinhTien.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_DA_rfid_Active.Properties.Resources.hauiLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1168, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbClock);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lbSoXeTrongBai);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbSoLuotXeRa);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lbSoLuotXeVao);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1131, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 443);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Moccasin;
            this.lbClock.Location = new System.Drawing.Point(24, 40);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(116, 26);
            this.lbClock.TabIndex = 7;
            this.lbClock.Text = "label17";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_vt5);
            this.groupBox4.Controls.Add(this.btn_vt4);
            this.groupBox4.Controls.Add(this.btn_vt3);
            this.groupBox4.Controls.Add(this.btn_vt2);
            this.groupBox4.Controls.Add(this.btn_vt1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 144);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vị trí xe còn trống";
            // 
            // btn_vt5
            // 
            this.btn_vt5.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_vt5.Location = new System.Drawing.Point(15, 99);
            this.btn_vt5.Name = "btn_vt5";
            this.btn_vt5.Size = new System.Drawing.Size(62, 31);
            this.btn_vt5.TabIndex = 10;
            this.btn_vt5.Text = "5";
            this.btn_vt5.UseVisualStyleBackColor = false;
            // 
            // btn_vt4
            // 
            this.btn_vt4.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_vt4.Location = new System.Drawing.Point(86, 62);
            this.btn_vt4.Name = "btn_vt4";
            this.btn_vt4.Size = new System.Drawing.Size(62, 31);
            this.btn_vt4.TabIndex = 9;
            this.btn_vt4.Text = "4";
            this.btn_vt4.UseVisualStyleBackColor = false;
            // 
            // btn_vt3
            // 
            this.btn_vt3.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_vt3.Location = new System.Drawing.Point(15, 62);
            this.btn_vt3.Name = "btn_vt3";
            this.btn_vt3.Size = new System.Drawing.Size(62, 31);
            this.btn_vt3.TabIndex = 8;
            this.btn_vt3.Text = "3";
            this.btn_vt3.UseVisualStyleBackColor = false;
            // 
            // btn_vt2
            // 
            this.btn_vt2.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_vt2.Location = new System.Drawing.Point(86, 25);
            this.btn_vt2.Name = "btn_vt2";
            this.btn_vt2.Size = new System.Drawing.Size(62, 31);
            this.btn_vt2.TabIndex = 7;
            this.btn_vt2.Text = "2";
            this.btn_vt2.UseVisualStyleBackColor = false;
            // 
            // btn_vt1
            // 
            this.btn_vt1.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_vt1.Location = new System.Drawing.Point(15, 25);
            this.btn_vt1.Name = "btn_vt1";
            this.btn_vt1.Size = new System.Drawing.Size(62, 31);
            this.btn_vt1.TabIndex = 6;
            this.btn_vt1.Text = "1";
            this.btn_vt1.UseVisualStyleBackColor = false;
            // 
            // lbSoXeTrongBai
            // 
            this.lbSoXeTrongBai.BackColor = System.Drawing.Color.MediumPurple;
            this.lbSoXeTrongBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoXeTrongBai.Location = new System.Drawing.Point(21, 201);
            this.lbSoXeTrongBai.Name = "lbSoXeTrongBai";
            this.lbSoXeTrongBai.Size = new System.Drawing.Size(117, 24);
            this.lbSoXeTrongBai.TabIndex = 5;
            this.lbSoXeTrongBai.Text = "0";
            this.lbSoXeTrongBai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Số xe trong bãi";
            // 
            // lbSoLuotXeRa
            // 
            this.lbSoLuotXeRa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbSoLuotXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuotXeRa.Location = new System.Drawing.Point(21, 153);
            this.lbSoLuotXeRa.Name = "lbSoLuotXeRa";
            this.lbSoLuotXeRa.Size = new System.Drawing.Size(117, 24);
            this.lbSoLuotXeRa.TabIndex = 3;
            this.lbSoLuotXeRa.Text = "0";
            this.lbSoLuotXeRa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Số lượt xe ra";
            // 
            // lbSoLuotXeVao
            // 
            this.lbSoLuotXeVao.BackColor = System.Drawing.Color.Yellow;
            this.lbSoLuotXeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuotXeVao.Location = new System.Drawing.Point(21, 105);
            this.lbSoLuotXeVao.Name = "lbSoLuotXeVao";
            this.lbSoLuotXeVao.Size = new System.Drawing.Size(117, 24);
            this.lbSoLuotXeVao.TabIndex = 1;
            this.lbSoLuotXeVao.Text = "0";
            this.lbSoLuotXeVao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượt xe vào";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1021, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thông tin phương tiện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Danh sách các xe vào ra";
            // 
            // dataGridViewMonitor
            // 
            this.dataGridViewMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonitor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMonitor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._STT,
            this.InOut,
            this._RFID_code,
            this._Name,
            this._Quantity,
            this._day_add,
            this.TimeIn,
            this.TimeOut,
            this.ToltalTime,
            this.ThanhTien});
            this.dataGridViewMonitor.Location = new System.Drawing.Point(0, 294);
            this.dataGridViewMonitor.Name = "dataGridViewMonitor";
            this.dataGridViewMonitor.ReadOnly = true;
            this.dataGridViewMonitor.Size = new System.Drawing.Size(1131, 242);
            this.dataGridViewMonitor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.tbTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnRefresh.Location = new System.Drawing.Point(335, 19);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(122, 32);
            this.BtnRefresh.TabIndex = 18;
            this.BtnRefresh.Text = "Refresh port";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConnect.Location = new System.Drawing.Point(228, 19);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 32);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(9, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Select com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "RFID Code";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(769, 21);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 32);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Find";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.Location = new System.Drawing.Point(560, 24);
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(203, 26);
            this.tbTimkiem.TabIndex = 5;
            // 
            // History
            // 
            this.History.Controls.Add(this.dataGridViewSetting);
            this.History.Controls.Add(this.groupBox2);
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(4, 29);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1308, 538);
            this.History.TabIndex = 1;
            this.History.Text = "Setting";
            this.History.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSetting
            // 
            this.dataGridViewSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSetting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSetting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSetting.Location = new System.Drawing.Point(8, 165);
            this.dataGridViewSetting.Name = "dataGridViewSetting";
            this.dataGridViewSetting.ReadOnly = true;
            this.dataGridViewSetting.Size = new System.Drawing.Size(1292, 370);
            this.dataGridViewSetting.TabIndex = 1;
            this.dataGridViewSetting.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSetting_CellMouseDoubleClick);
            this.dataGridViewSetting.SelectionChanged += new System.EventHandler(this.dataGridViewSetting_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.tbNote);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ngayAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbRfidCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1292, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(618, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(530, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(445, 21);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(572, 87);
            this.tbNote.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Note";
            // 
            // ngayAdd
            // 
            this.ngayAdd.CustomFormat = "dd/mm/yyyy";
            this.ngayAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayAdd.Location = new System.Drawing.Point(103, 117);
            this.ngayAdd.Name = "ngayAdd";
            this.ngayAdd.Size = new System.Drawing.Size(275, 26);
            this.ngayAdd.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Day add";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(103, 85);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(275, 26);
            this.tbQuantity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biển số";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 26);
            this.tbName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // tbRfidCode
            // 
            this.tbRfidCode.Location = new System.Drawing.Point(103, 21);
            this.tbRfidCode.Name = "tbRfidCode";
            this.tbRfidCode.Size = new System.Drawing.Size(275, 26);
            this.tbRfidCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rfid code";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(796, 598);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(2, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Notification:";
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(100, 572);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(60, 20);
            this.lbNotification.TabIndex = 3;
            this.lbNotification.Text = "label11";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1025, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerialPort1
            // 
            this.SerialPort1.BaudRate = 115200;
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(877, 29);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(68, 20);
            this.lbDonGia.TabIndex = 10;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // tbDonGia
            // 
            this.tbDonGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDonGia.ForeColor = System.Drawing.Color.Red;
            this.tbDonGia.Location = new System.Drawing.Point(951, 26);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(70, 26);
            this.tbDonGia.TabIndex = 11;
            this.tbDonGia.Text = "30000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1027, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 12;
            this.label19.Text = "Đồng/giờ";
            // 
            // _STT
            // 
            this._STT.FillWeight = 45.68528F;
            this._STT.HeaderText = "STT";
            this._STT.Name = "_STT";
            this._STT.ReadOnly = true;
            // 
            // InOut
            // 
            this.InOut.HeaderText = "Vào/Ra";
            this.InOut.Name = "InOut";
            this.InOut.ReadOnly = true;
            // 
            // _RFID_code
            // 
            this._RFID_code.FillWeight = 110.8629F;
            this._RFID_code.HeaderText = "RFID code";
            this._RFID_code.Name = "_RFID_code";
            this._RFID_code.ReadOnly = true;
            // 
            // _Name
            // 
            this._Name.FillWeight = 110.8629F;
            this._Name.HeaderText = "Name";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // _Quantity
            // 
            this._Quantity.FillWeight = 110.8629F;
            this._Quantity.HeaderText = "Biển số";
            this._Quantity.Name = "_Quantity";
            this._Quantity.ReadOnly = true;
            // 
            // _day_add
            // 
            this._day_add.FillWeight = 110.8629F;
            this._day_add.HeaderText = "Day add";
            this._day_add.Name = "_day_add";
            this._day_add.ReadOnly = true;
            // 
            // TimeIn
            // 
            this.TimeIn.HeaderText = "Time in";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            // 
            // TimeOut
            // 
            this.TimeOut.FillWeight = 110.8629F;
            this.TimeOut.HeaderText = "Time out";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            // 
            // ToltalTime
            // 
            this.ToltalTime.HeaderText = "ToltalTime";
            this.ToltalTime.Name = "ToltalTime";
            this.ToltalTime.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(875, 569);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(144, 26);
            this.btnExportExcel.TabIndex = 7;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 598);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quản lý bãi đỗ xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Monitor.ResumeLayout(false);
            this.Monitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetting)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Monitor;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRfidCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ngayAdd;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSetting;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label14;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoLuotXeVao;
        private System.Windows.Forms.Label lbSoLuotXeRa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSoXeTrongBai;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtbTinhTien;
        private System.Windows.Forms.RichTextBox rtbThongTin;
        private System.Windows.Forms.Button btn_vt1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_vt5;
        private System.Windows.Forms.Button btn_vt4;
        private System.Windows.Forms.Button btn_vt3;
        private System.Windows.Forms.Button btn_vt2;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn _STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RFID_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _day_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToltalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnExportExcel;
    }
}

