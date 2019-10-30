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
    public partial class FmStudent_ChangeRoom : Form
    {
        private string _CMND;
        public FmStudent_ChangeRoom(string CMND, DataRow DataRoom)
        {
            InitializeComponent();
            _CMND = CMND;

            label_phonghientai.Text = DataRoom[0].ToString();
            label_toa.Text = DataRoom[1].ToString();
            label_loaiphong.Text = DataRoom[2].ToString();
            label_songuoi.Text = DataRoom[3].ToString();
            label_giaphong.Text = DataRoom[4].ToString();

            int available = (int)DataRoom[2] - (int)DataRoom[3];

            string query = "select GioiTinh from SinhVien where CMND=N'" + _CMND + "'";
            DataTable _DataSV = DataProvider.Instance.ExecuteQuery(query);

            string _gioitinh = _DataSV.Rows[0][0].ToString();

            query = "select MaToa as [Toà nhà], GioiTinh as [Giới tính] from Toa where GioiTinh = N'" + _gioitinh + "'";
            dataGridView_TOA.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void dataGridView_TOA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = dataGridView_TOA.CurrentCell.RowIndex;
            string _toa = dataGridView_TOA[0, rowindex].Value.ToString();

            string query = "EXEC ChooseRoom @MaToa";
            dataGridView_PHONG.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { _toa });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rowindex_toa = dataGridView_TOA.CurrentCell.RowIndex;
            int rowindex_phong = dataGridView_PHONG.CurrentCell.RowIndex;

            string _phong = dataGridView_PHONG[0, rowindex_phong].Value.ToString();
            string _toa = dataGridView_TOA[0, rowindex_toa].Value.ToString();

            if (rowindex_toa != -1 && rowindex_phong != -1)
            {
                if (_phong.Equals(label_phonghientai.Text))
                {
                    MessageBox.Show("Chuyển phòng thất bại. Bạn đang chọn phòng hiện tại !");
                }
                else
                {
                    int _soluong = Int32.Parse(dataGridView_PHONG[2, rowindex_phong].Value.ToString()) + 1;
                    dataGridView_PHONG[2, rowindex_phong].Value = _soluong;

                    string query = "EXEC ChangeSoLuong @MaPhong , @SoLuong";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { _phong, _soluong });

                    _soluong = Int32.Parse(label_songuoi.Text) - 1;
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { label_phonghientai.Text, _soluong });

                    query = "UPDATE SinhVien SET MaPhong=N'" + _phong + "' WHERE CMND=N'" + _CMND + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);

                    label_phonghientai.Text = _phong;
                    label_toa.Text = _toa;
                    label_loaiphong.Text = dataGridView_PHONG[1, rowindex_phong].Value.ToString();
                    label_songuoi.Text = dataGridView_PHONG[2, rowindex_phong].Value.ToString();
                    label_giaphong.Text = dataGridView_PHONG[3, rowindex_phong].Value.ToString();

                    MessageBox.Show("Chuyển phòng thành công!");
                }
            }
            else
                MessageBox.Show("Chưa chọn đủ thông tin!");
        } 
    }
}
