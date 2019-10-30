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
    public partial class FmBuilding : Form
    {
        public FmBuilding()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _tentoa = textBox_searchToa.Text;
            if (_tentoa != "")
                _tentoa = " MaToa ='" + _tentoa + "'";
            else
                _tentoa = " MaToa <>''";

            string _gioitinh = "";
            if (radioButton_nam.Checked)
                _gioitinh = " and GioiTinh=N'Nam'";
            else if (radioButton_nu.Checked)
                _gioitinh = " and GioiTinh=N'Nữ'";
            
            string query = "select MaToa as [Toà nhà], GioiTinh as [Giới tính] from Toa where "
                + _tentoa + _gioitinh;
            dataGridView_Toa.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
