namespace QuanLiKTX
{
    partial class FmAccount
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
            this.tcAccount = new System.Windows.Forms.TabControl();
            this.tabPageQLaccount = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.radioButton_NV = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tendn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tcAccount.SuspendLayout();
            this.tabPageQLaccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAccount
            // 
            this.tcAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAccount.Controls.Add(this.tabPageQLaccount);
            this.tcAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcAccount.Location = new System.Drawing.Point(12, 12);
            this.tcAccount.Name = "tcAccount";
            this.tcAccount.SelectedIndex = 0;
            this.tcAccount.Size = new System.Drawing.Size(776, 426);
            this.tcAccount.TabIndex = 3;
            // 
            // tabPageQLaccount
            // 
            this.tabPageQLaccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageQLaccount.Controls.Add(this.groupBox2);
            this.tabPageQLaccount.Controls.Add(this.groupBox1);
            this.tabPageQLaccount.Location = new System.Drawing.Point(4, 29);
            this.tabPageQLaccount.Name = "tabPageQLaccount";
            this.tabPageQLaccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLaccount.Size = new System.Drawing.Size(768, 393);
            this.tabPageQLaccount.TabIndex = 0;
            this.tabPageQLaccount.Text = "Quản lí tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Controls.Add(this.radioButton_Admin);
            this.groupBox2.Controls.Add(this.radioButton_NV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_matkhau);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_tendn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 174);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm tài khoản";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(36, 39);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 33);
            this.buttonThem.TabIndex = 52;
            this.buttonThem.Text = "Tạo";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_Admin.Location = new System.Drawing.Point(418, 113);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(67, 22);
            this.radioButton_Admin.TabIndex = 60;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "Admin";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // radioButton_NV
            // 
            this.radioButton_NV.AutoSize = true;
            this.radioButton_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_NV.Location = new System.Drawing.Point(284, 113);
            this.radioButton_NV.Name = "radioButton_NV";
            this.radioButton_NV.Size = new System.Drawing.Size(91, 22);
            this.radioButton_NV.TabIndex = 59;
            this.radioButton_NV.TabStop = true;
            this.radioButton_NV.Text = "Nhân viên";
            this.radioButton_NV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(154, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Phân quyền :";
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(284, 73);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(222, 26);
            this.textBox_matkhau.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(154, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mật khẩu :";
            // 
            // textBox_tendn
            // 
            this.textBox_tendn.Location = new System.Drawing.Point(284, 36);
            this.textBox_tendn.Name = "textBox_tendn";
            this.textBox_tendn.Size = new System.Drawing.Size(222, 26);
            this.textBox_tendn.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(154, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tên đăng nhập :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_TaiKhoan);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(158, 25);
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(563, 143);
            this.dataGridView_TaiKhoan.TabIndex = 51;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(36, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 33);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAccount";
            this.tcAccount.ResumeLayout(false);
            this.tabPageQLaccount.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAccount;
        private System.Windows.Forms.TabPage tabPageQLaccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView_TaiKhoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_tendn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private System.Windows.Forms.RadioButton radioButton_NV;
        private System.Windows.Forms.Button buttonThem;
    }
}