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
    public partial class FmAccount : Form
    {
        public FmAccount()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "select TenDN as [Tên đăng nhập], MatKhau as [Mật khẩu], ChucVu as [Chức vụ]" +
                "from TaiKhoan";
            dataGridView_TaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string _TenDN = textBox_tendn.Text;
            string _MatKhau = textBox_matkhau.Text;
            string _ChucVu = "";
            if (radioButton_Admin.Checked) _ChucVu = "1";
            else if (radioButton_NV.Checked) _ChucVu = "0";

            string query = "EXEC AddTK @TenDN , @MatKhau , @ChucVu";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { _TenDN, _MatKhau, _ChucVu });
            MessageBox.Show("Thêm thành công!");
        }
    }
}
