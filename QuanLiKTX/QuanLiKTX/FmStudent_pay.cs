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
    public partial class FmStudent_pay : Form
    {
        string _CMND;
        public FmStudent_pay(string cmnd, string bhyt, string noitru)
        {
            InitializeComponent();
            _CMND = cmnd;
            if (bhyt.Equals("Đã đóng"))
            {
                checkBox_BHYT.Checked = true;
                checkBox_BHYT.Enabled = false;
            }
            if (noitru.Equals("Đã đóng"))
            {
                checkBox_tienphong.Checked = true;
                checkBox_tienphong.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _BHYT = "Chưa đóng";
            string _NoiTru = "Chưa đóng";
            if (checkBox_BHYT.Checked == true) _BHYT = "Đã đóng";
            if (checkBox_tienphong.Checked == true) _NoiTru = "Đã đóng";
            string query = "EXEC PaySinhVien @CMND , @BHYT , @NoiTru";
            int x = DataProvider.Instance.ExecuteNonQuery(query, new object[] {_CMND,_BHYT,_NoiTru});
            if (x > 0)
            {
                MessageBox.Show("Thanh toán thành công!");
                if (checkBox_BHYT.Checked == true)
                    checkBox_BHYT.Enabled = false;
                if (checkBox_tienphong.Checked == true)
                    checkBox_tienphong.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại. Vui lòng thử lại! ");
            }
        }
    }
}
