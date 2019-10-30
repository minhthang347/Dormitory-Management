namespace QuanLiKTX
{
    partial class FmBuilding
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
            this.tcBuilding = new System.Windows.Forms.TabControl();
            this.tabPageQLToa = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Toa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_both = new System.Windows.Forms.RadioButton();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_searchToa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tcBuilding.SuspendLayout();
            this.tabPageQLToa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Toa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBuilding
            // 
            this.tcBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcBuilding.Controls.Add(this.tabPageQLToa);
            this.tcBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcBuilding.Location = new System.Drawing.Point(12, 12);
            this.tcBuilding.Name = "tcBuilding";
            this.tcBuilding.SelectedIndex = 0;
            this.tcBuilding.Size = new System.Drawing.Size(445, 426);
            this.tcBuilding.TabIndex = 2;
            // 
            // tabPageQLToa
            // 
            this.tabPageQLToa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageQLToa.Controls.Add(this.groupBox2);
            this.tabPageQLToa.Controls.Add(this.groupBox1);
            this.tabPageQLToa.Controls.Add(this.btnSearch);
            this.tabPageQLToa.Location = new System.Drawing.Point(4, 29);
            this.tabPageQLToa.Name = "tabPageQLToa";
            this.tabPageQLToa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLToa.Size = new System.Drawing.Size(437, 393);
            this.tabPageQLToa.TabIndex = 0;
            this.tabPageQLToa.Text = "Tra cứu toà nhà";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Toa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 226);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tra cứu";
            // 
            // dataGridView_Toa
            // 
            this.dataGridView_Toa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Toa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Toa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Toa.Location = new System.Drawing.Point(6, 25);
            this.dataGridView_Toa.Name = "dataGridView_Toa";
            this.dataGridView_Toa.Size = new System.Drawing.Size(417, 195);
            this.dataGridView_Toa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_both);
            this.groupBox1.Controls.Add(this.radioButton_nu);
            this.groupBox1.Controls.Add(this.radioButton_nam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_searchToa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin toà ";
            // 
            // radioButton_both
            // 
            this.radioButton_both.AutoSize = true;
            this.radioButton_both.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_both.Location = new System.Drawing.Point(270, 62);
            this.radioButton_both.Name = "radioButton_both";
            this.radioButton_both.Size = new System.Drawing.Size(68, 22);
            this.radioButton_both.TabIndex = 58;
            this.radioButton_both.Text = "Cả hai";
            this.radioButton_both.UseVisualStyleBackColor = true;
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nu.Location = new System.Drawing.Point(200, 62);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(45, 22);
            this.radioButton_nu.TabIndex = 57;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Checked = true;
            this.radioButton_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nam.Location = new System.Drawing.Point(123, 62);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(58, 22);
            this.radioButton_nam.TabIndex = 56;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Giới tính :";
            // 
            // textBox_searchToa
            // 
            this.textBox_searchToa.Location = new System.Drawing.Point(135, 26);
            this.textBox_searchToa.Name = "textBox_searchToa";
            this.textBox_searchToa.Size = new System.Drawing.Size(100, 26);
            this.textBox_searchToa.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên tòa nhà:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(177, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 33);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Xem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.tcBuilding);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Toà nhà";
            this.tcBuilding.ResumeLayout(false);
            this.tabPageQLToa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Toa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBuilding;
        private System.Windows.Forms.TabPage tabPageQLToa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Toa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_searchToa;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.RadioButton radioButton_both;
    }
}