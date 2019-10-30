namespace QuanLiKTX
{
    partial class FmStudent_pay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_tienphong = new System.Windows.Forms.CheckBox();
            this.checkBox_BHYT = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_tienphong);
            this.groupBox1.Controls.Add(this.checkBox_BHYT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chi phí";
            // 
            // checkBox_tienphong
            // 
            this.checkBox_tienphong.AutoSize = true;
            this.checkBox_tienphong.Location = new System.Drawing.Point(61, 86);
            this.checkBox_tienphong.Name = "checkBox_tienphong";
            this.checkBox_tienphong.Size = new System.Drawing.Size(127, 28);
            this.checkBox_tienphong.TabIndex = 1;
            this.checkBox_tienphong.Text = "Tiền phòng";
            this.checkBox_tienphong.UseVisualStyleBackColor = true;
            // 
            // checkBox_BHYT
            // 
            this.checkBox_BHYT.AutoSize = true;
            this.checkBox_BHYT.Location = new System.Drawing.Point(61, 38);
            this.checkBox_BHYT.Name = "checkBox_BHYT";
            this.checkBox_BHYT.Size = new System.Drawing.Size(79, 28);
            this.checkBox_BHYT.TabIndex = 0;
            this.checkBox_BHYT.Text = "BHYT";
            this.checkBox_BHYT.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(88, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Thanh toán và lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FmStudent_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmStudent_pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán chi phí cá nhân";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_tienphong;
        private System.Windows.Forms.CheckBox checkBox_BHYT;
        private System.Windows.Forms.Button btnSave;
    }
}