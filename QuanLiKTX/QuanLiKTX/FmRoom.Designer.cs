namespace QuanLiKTX
{
    partial class FmRoom
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tcRoom = new System.Windows.Forms.TabControl();
            this.tabPageQLP = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_searchLoai = new System.Windows.Forms.TextBox();
            this.textBox_searchToa = new System.Windows.Forms.TextBox();
            this.textBox_searchTenPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_searchTrong = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPageDienNuoc = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_HD = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDSHD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddHD = new System.Windows.Forms.Button();
            this.textBox_CSNmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CSDmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_phong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageReportHD = new System.Windows.Forms.TabPage();
            this.btnReportHD = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportViewer_Bill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLiKTXDataSet_HDP = new QuanLiKTX.QuanLiKTXDataSet_HDP();
            this.HoaDonPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonPhongTableAdapter = new QuanLiKTX.QuanLiKTXDataSet_HDPTableAdapters.HoaDonPhongTableAdapter();
            this.tcRoom.SuspendLayout();
            this.tabPageQLP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageDienNuoc.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageReportHD.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiKTXDataSet_HDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRoom
            // 
            this.tcRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRoom.Controls.Add(this.tabPageQLP);
            this.tcRoom.Controls.Add(this.tabPageDienNuoc);
            this.tcRoom.Controls.Add(this.tabPageReportHD);
            this.tcRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcRoom.Location = new System.Drawing.Point(12, 12);
            this.tcRoom.Name = "tcRoom";
            this.tcRoom.SelectedIndex = 0;
            this.tcRoom.Size = new System.Drawing.Size(776, 426);
            this.tcRoom.TabIndex = 1;
            // 
            // tabPageQLP
            // 
            this.tabPageQLP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageQLP.Controls.Add(this.groupBox2);
            this.tabPageQLP.Controls.Add(this.groupBox1);
            this.tabPageQLP.Controls.Add(this.btnSearch);
            this.tabPageQLP.Location = new System.Drawing.Point(4, 29);
            this.tabPageQLP.Name = "tabPageQLP";
            this.tabPageQLP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLP.Size = new System.Drawing.Size(768, 393);
            this.tabPageQLP.TabIndex = 0;
            this.tabPageQLP.Text = "Tra cứu phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Phong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 273);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tra cứu";
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Phong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Location = new System.Drawing.Point(6, 25);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.Size = new System.Drawing.Size(744, 242);
            this.dataGridView_Phong.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_searchLoai);
            this.groupBox1.Controls.Add(this.textBox_searchToa);
            this.groupBox1.Controls.Add(this.textBox_searchTenPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_searchTrong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // textBox_searchLoai
            // 
            this.textBox_searchLoai.Location = new System.Drawing.Point(527, 23);
            this.textBox_searchLoai.Name = "textBox_searchLoai";
            this.textBox_searchLoai.Size = new System.Drawing.Size(101, 26);
            this.textBox_searchLoai.TabIndex = 55;
            // 
            // textBox_searchToa
            // 
            this.textBox_searchToa.Location = new System.Drawing.Point(301, 23);
            this.textBox_searchToa.Name = "textBox_searchToa";
            this.textBox_searchToa.Size = new System.Drawing.Size(101, 26);
            this.textBox_searchToa.TabIndex = 54;
            // 
            // textBox_searchTenPhong
            // 
            this.textBox_searchTenPhong.Location = new System.Drawing.Point(96, 23);
            this.textBox_searchTenPhong.Name = "textBox_searchTenPhong";
            this.textBox_searchTenPhong.Size = new System.Drawing.Size(101, 26);
            this.textBox_searchTenPhong.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tòa nhà:";
            // 
            // checkBox_searchTrong
            // 
            this.checkBox_searchTrong.AutoSize = true;
            this.checkBox_searchTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_searchTrong.Location = new System.Drawing.Point(663, 25);
            this.checkBox_searchTrong.Name = "checkBox_searchTrong";
            this.checkBox_searchTrong.Size = new System.Drawing.Size(69, 24);
            this.checkBox_searchTrong.TabIndex = 51;
            this.checkBox_searchTrong.Text = "Trống";
            this.checkBox_searchTrong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(429, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tên phòng :";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(321, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 33);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Xem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPageDienNuoc
            // 
            this.tabPageDienNuoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageDienNuoc.Controls.Add(this.groupBox4);
            this.tabPageDienNuoc.Controls.Add(this.groupBox3);
            this.tabPageDienNuoc.Location = new System.Drawing.Point(4, 29);
            this.tabPageDienNuoc.Name = "tabPageDienNuoc";
            this.tabPageDienNuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDienNuoc.Size = new System.Drawing.Size(768, 393);
            this.tabPageDienNuoc.TabIndex = 2;
            this.tabPageDienNuoc.Text = "Điện nước";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_HD);
            this.groupBox4.Controls.Add(this.dateTimePicker_end);
            this.groupBox4.Controls.Add(this.dateTimePicker_start);
            this.groupBox4.Controls.Add(this.btnLoadDSHD);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 305);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hoá đơn";
            // 
            // dataGridView_HD
            // 
            this.dataGridView_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HD.Location = new System.Drawing.Point(10, 67);
            this.dataGridView_HD.Name = "dataGridView_HD";
            this.dataGridView_HD.Size = new System.Drawing.Size(740, 232);
            this.dataGridView_HD.TabIndex = 59;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(308, 27);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker_end.TabIndex = 58;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_start.Location = new System.Drawing.Point(75, 26);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker_start.TabIndex = 57;
            // 
            // btnLoadDSHD
            // 
            this.btnLoadDSHD.Location = new System.Drawing.Point(595, 26);
            this.btnLoadDSHD.Name = "btnLoadDSHD";
            this.btnLoadDSHD.Size = new System.Drawing.Size(137, 31);
            this.btnLoadDSHD.TabIndex = 56;
            this.btnLoadDSHD.Text = "Load";
            this.btnLoadDSHD.UseVisualStyleBackColor = true;
            this.btnLoadDSHD.Click += new System.EventHandler(this.btnLoadDSHD_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(225, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Đến ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Từ ngày ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddHD);
            this.groupBox3.Controls.Add(this.textBox_CSNmoi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_CSDmoi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_phong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm hoá đơn";
            // 
            // btnAddHD
            // 
            this.btnAddHD.Location = new System.Drawing.Point(595, 26);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(137, 31);
            this.btnAddHD.TabIndex = 56;
            this.btnAddHD.Text = "Thêm hoá đơn";
            this.btnAddHD.UseVisualStyleBackColor = true;
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHD_Click);
            // 
            // textBox_CSNmoi
            // 
            this.textBox_CSNmoi.Location = new System.Drawing.Point(480, 28);
            this.textBox_CSNmoi.Name = "textBox_CSNmoi";
            this.textBox_CSNmoi.Size = new System.Drawing.Size(65, 26);
            this.textBox_CSNmoi.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(365, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "CS Nước mới :";
            // 
            // textBox_CSDmoi
            // 
            this.textBox_CSDmoi.Location = new System.Drawing.Point(294, 28);
            this.textBox_CSDmoi.Name = "textBox_CSDmoi";
            this.textBox_CSDmoi.Size = new System.Drawing.Size(65, 26);
            this.textBox_CSDmoi.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(197, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "CS Điện mới :";
            // 
            // textBox_phong
            // 
            this.textBox_phong.Location = new System.Drawing.Point(75, 28);
            this.textBox_phong.Name = "textBox_phong";
            this.textBox_phong.Size = new System.Drawing.Size(116, 26);
            this.textBox_phong.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Phòng :";
            // 
            // tabPageReportHD
            // 
            this.tabPageReportHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageReportHD.Controls.Add(this.btnReportHD);
            this.tabPageReportHD.Controls.Add(this.groupBox5);
            this.tabPageReportHD.Location = new System.Drawing.Point(4, 29);
            this.tabPageReportHD.Name = "tabPageReportHD";
            this.tabPageReportHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportHD.Size = new System.Drawing.Size(768, 393);
            this.tabPageReportHD.TabIndex = 4;
            this.tabPageReportHD.Text = "Báo cáo hoá đơn";
            // 
            // btnReportHD
            // 
            this.btnReportHD.Location = new System.Drawing.Point(12, 6);
            this.btnReportHD.Name = "btnReportHD";
            this.btnReportHD.Size = new System.Drawing.Size(126, 30);
            this.btnReportHD.TabIndex = 55;
            this.btnReportHD.Text = "Xuất báo cáo";
            this.btnReportHD.UseVisualStyleBackColor = true;
            this.btnReportHD.Click += new System.EventHandler(this.btnReportHD_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportViewer_Bill);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(6, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(756, 345);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Báo cáo hoá đơn điện nước";
            // 
            // reportViewer_Bill
            // 
            reportDataSource1.Name = "DataSet_hdp";
            reportDataSource1.Value = this.HoaDonPhongBindingSource;
            this.reportViewer_Bill.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Bill.LocalReport.ReportEmbeddedResource = "QuanLiKTX.HoaDonPhong.rdlc";
            this.reportViewer_Bill.Location = new System.Drawing.Point(6, 25);
            this.reportViewer_Bill.Name = "reportViewer_Bill";
            this.reportViewer_Bill.ServerReport.BearerToken = null;
            this.reportViewer_Bill.Size = new System.Drawing.Size(744, 314);
            this.reportViewer_Bill.TabIndex = 0;
            // 
            // QuanLiKTXDataSet_HDP
            // 
            this.QuanLiKTXDataSet_HDP.DataSetName = "QuanLiKTXDataSet_HDP";
            this.QuanLiKTXDataSet_HDP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonPhongBindingSource
            // 
            this.HoaDonPhongBindingSource.DataMember = "HoaDonPhong";
            this.HoaDonPhongBindingSource.DataSource = this.QuanLiKTXDataSet_HDP;
            // 
            // HoaDonPhongTableAdapter
            // 
            this.HoaDonPhongTableAdapter.ClearBeforeFill = true;
            // 
            // FmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcRoom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Phòng ở";
            this.Load += new System.EventHandler(this.FrRoom_Load);
            this.tcRoom.ResumeLayout(false);
            this.tabPageQLP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDienNuoc.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageReportHD.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiKTXDataSet_HDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonPhongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRoom;
        private System.Windows.Forms.TabPage tabPageQLP;
        private System.Windows.Forms.TabPage tabPageDienNuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_searchTrong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_searchLoai;
        private System.Windows.Forms.TextBox textBox_searchToa;
        private System.Windows.Forms.TextBox textBox_searchTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Phong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_phong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CSNmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CSDmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHD;
        private System.Windows.Forms.TabPage tabPageReportHD;
        private System.Windows.Forms.Button btnReportHD;
        private System.Windows.Forms.GroupBox groupBox5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Bill;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLoadDSHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DataGridView dataGridView_HD;
        private System.Windows.Forms.BindingSource HoaDonPhongBindingSource;
        private QuanLiKTXDataSet_HDP QuanLiKTXDataSet_HDP;
        private QuanLiKTXDataSet_HDPTableAdapters.HoaDonPhongTableAdapter HoaDonPhongTableAdapter;
    }
}