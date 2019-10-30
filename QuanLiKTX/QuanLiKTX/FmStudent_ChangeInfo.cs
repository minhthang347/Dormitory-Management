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
    public partial class FmStudent_ChangeInfo : Form
    {
        
        public FmStudent_ChangeInfo(DataRow SV)
        {
            InitializeComponent();
            textBox_cmnd.Text = SV[0].ToString();
            textBox_hoten.Text = SV[1].ToString();
            textBox_gioitinh.Text = SV[2].ToString();
            textBox_mssv.Text = SV[3].ToString();
            textBox_truong.Text = SV[4].ToString();
            textBox_quequan.Text = SV[5].ToString();
            textBox_ngaysinh.Text = SV[6].ToString().Substring(0, 10);
            textBox_phong.Text = SV[7].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] tempsplit = textBox_ngaysinh.Text.Split('/');
            string ngaysinh = tempsplit[2] + "/" + tempsplit[1] + "/" + tempsplit[0];

            string query = "EXEC UpdateSinhVien @CMND , @HoTen , @MSSV , @Truong , @Que , @NgaySinh";
            int x = DataProvider.Instance.ExecuteNonQuery(query, new object[] { textBox_cmnd.Text,
                textBox_hoten.Text, textBox_mssv.Text, textBox_truong.Text, textBox_quequan.Text, ngaysinh});
            if (x > 0)
            {
                MessageBox.Show("Thay đổi thành công!");
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại. Vui lòng thử lại! ");
            }
        }
    }
}
