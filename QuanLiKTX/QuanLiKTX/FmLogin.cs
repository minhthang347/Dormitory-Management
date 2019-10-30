using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKTX
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
            this.ActiveControl = textBox_taikhoan;
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked == true)
                textBox_password.PasswordChar = '\0';
            else textBox_password.PasswordChar = '*';

        }

        private void FmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _TenDN = textBox_taikhoan.Text;
            string _MatKhau = textBox_password.Text;

            string query = "EXEC Login @TenDN , @MatKhau";
            DataTable tk = DataProvider.Instance.ExecuteQuery(query, new object[] { _TenDN, _MatKhau });

            if (tk.Rows.Count > 0)
            {
                PhanQuyen.Chucvu = (int)tk.Rows[0][2];
                FmMain f = new FmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
                textBox_taikhoan.Text = "";
                textBox_password.Text = "";
                checkBox_showpass.Checked = false;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! /n Vui lòng nhập chính xác tên đăng nhập và mật khẩu");
            }
        }
    }
}
