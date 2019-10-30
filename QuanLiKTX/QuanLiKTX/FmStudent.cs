using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKTX
{
    public partial class FmStudent : Form
    {
        private string _CMND = "";
        private DataTable _DataSV = new DataTable();
        private DataTable _DataRoom = new DataTable();

        public FmStudent()
        {
            InitializeComponent();
        }

        // Form QUẢN LÍ
        // Set rỗng
        private void setEmpty()
        {
            label_cmnd.Text = "<Số chứng minh nhân dân>";
            label_tenSV.Text = "<Họ tên sinh viên>";
            label_gioitinh.Text = "<Giới tính>";
            label_mssv.Text = "<Mã số sinh viên>";
            label_truong.Text = "<Trường>";
            label_quequan.Text = "<Quê quán>";
            label_ngaysinh.Text = "<Ngày tháng năm sinh>";
            label_phong.Text = "<Phòng ở hiện tại>";
            label_BHYT.Text = "<BHYT>";
            label_tienphong.Text = "<Tiền phòng>";

            label_phonghientai.Text = "<Tên phòng>";
            label_toa.Text = "<Tên toà>";
            label_loaiphong.Text = "<Loại phòng>";
            label_songuoi.Text = "<Số lượng>";
            label_giaphong.Text = "<Giá>";

            btnChangeInfo.Enabled = false;
            btnChangeRoom.Enabled = false;
            btnPay.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Button sửa thông tin
        private void btnChangeSV_Click(object sender, EventArgs e)
        {
            FmStudent_ChangeInfo f = new FmStudent_ChangeInfo(_DataSV.Rows[0]);
            f.ShowDialog();
        }

        // Button Đóng phí
        private void button1_Click(object sender, EventArgs e)
        {
            if (label_BHYT.Text.Equals("Đã đóng") && label_tienphong.Text.Equals("Đã đóng"))
            {
                MessageBox.Show("Đã thanh toán đầy đủ.");
            }
            else
            {
                FmStudent_pay f = new FmStudent_pay(_CMND,_DataSV.Rows[0][8].ToString(),_DataSV.Rows[0][9].ToString());
                f.ShowDialog();
            }
        }

        // Button Chuyển phòng
        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            FmStudent_ChangeRoom f = new FmStudent_ChangeRoom(_CMND, _DataRoom.Rows[0]);
            f.ShowDialog();
        }

        // Button Huỷ 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn huỷ sinh viên?", "Thông báo huỷ", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string query = "EXEC ChangeSoLuong @MaPhong , @SoLuong";
                string _MaPhong = label_phong.Text;
                int _SoLuong = Int32.Parse(label_songuoi.Text) - 1;
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { _MaPhong, _SoLuong });
                query = "delete from SinhVien where CMND = N'" + _CMND + "'";
                int x = DataProvider.Instance.ExecuteNonQuery(query);
                if (x > 0)
                {
                    MessageBox.Show("Huỷ sinh viên thành công!");
                    setEmpty();
                }
                else
                    MessageBox.Show("Huỷ sinh viên thất bại!");

            }
        }

        // Button Tìm sinh viên 
        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            _CMND = textBox_search.Text;
            textBox_search.Text = "";

            string query = "select * from SinhVien where CMND = N'" + _CMND + "'";
            _DataSV = DataProvider.Instance.ExecuteQuery(query);

            if (_DataSV.Rows.Count > 0)
            {
                label_cmnd.Text = _DataSV.Rows[0][0].ToString();
                label_tenSV.Text = _DataSV.Rows[0][1].ToString();
                label_gioitinh.Text = _DataSV.Rows[0][2].ToString();
                label_mssv.Text = _DataSV.Rows[0][3].ToString();
                label_truong.Text = _DataSV.Rows[0][4].ToString();
                label_quequan.Text = _DataSV.Rows[0][5].ToString();
                label_ngaysinh.Text = _DataSV.Rows[0][6].ToString().Substring(0, 10);
                label_phong.Text = _DataSV.Rows[0][7].ToString();
                label_BHYT.Text = _DataSV.Rows[0][8].ToString();
                label_tienphong.Text = _DataSV.Rows[0][9].ToString();

                query = "select * from Phong where MaPhong = N'" + label_phong.Text + "'";
                _DataRoom = DataProvider.Instance.ExecuteQuery(query);
                label_cmnd.Text = _DataSV.Rows[0][0].ToString();
                label_tenSV.Text = _DataSV.Rows[0][1].ToString();
                label_gioitinh.Text = _DataSV.Rows[0][2].ToString();
                label_mssv.Text = _DataSV.Rows[0][3].ToString();
                label_truong.Text = _DataSV.Rows[0][4].ToString();
                label_quequan.Text = _DataSV.Rows[0][5].ToString();
                label_ngaysinh.Text = _DataSV.Rows[0][6].ToString().Substring(0, 10);
                label_phong.Text = _DataSV.Rows[0][7].ToString();
                label_BHYT.Text = _DataSV.Rows[0][8].ToString();
                label_tienphong.Text = _DataSV.Rows[0][9].ToString();

                label_phonghientai.Text = _DataRoom.Rows[0][0].ToString();
                label_toa.Text = _DataRoom.Rows[0][1].ToString();
                label_loaiphong.Text = _DataRoom.Rows[0][2].ToString();
                label_songuoi.Text = _DataRoom.Rows[0][3].ToString();
                label_giaphong.Text = _DataRoom.Rows[0][4].ToString();

                btnChangeInfo.Enabled = true;
                btnChangeRoom.Enabled = true;
                btnPay.Enabled = true;
                btnDelete.Enabled = true;

            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh viên!");
                setEmpty();
            }
        }
        //==========================================================================================
        // FORM ĐĂNG KÝ MỚI
        private void radioButton_nam_CheckedChanged(object sender, EventArgs e)
        {
            string _gioitinh;
            if (radioButton_nam.Checked == true)
                _gioitinh = "Nam";
            else
                _gioitinh = "Nữ";

            string query = "select MaToa as [Toà nhà], GioiTinh as [Giới tính] from Toa where GioiTinh = N'" + _gioitinh + "'";
            dataGridView_TOA.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void dataGridView_TOA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView_TOA.CurrentCell.RowIndex;
            string _toa = dataGridView_TOA[0, rowindex].Value.ToString();

            string query = "EXEC ChooseRoom @MaToa";
            dataGridView_PHONG.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { _toa });

        }

        // Button đăng ký
        private void btnDKSV_Click(object sender, EventArgs e)
        {
            string _CMND = textBox_CMND.Text;
            string _HoTen = textBox_tenSV.Text;

            string _GioiTinh;
            if (radioButton_nam.Checked == true) _GioiTinh = "Nam"; else _GioiTinh = "Nữ";

            string _MSSV = textBox_mssv.Text;
            string _Truong = textBox_truong.Text;
            string _Que = textBox_quequan.Text;
            
            string _NgaySinh = dateTimePicker_ngaysinh.Value.ToShortDateString();
            string[] tempsplit = _NgaySinh.Split('/');
            _NgaySinh = tempsplit[2] + "/" + tempsplit[1] + "/" + tempsplit[0];

            int rowindex = dataGridView_PHONG.CurrentCell.RowIndex;
            string _MaPhong = dataGridView_PHONG[0, rowindex].Value.ToString();

            string _BHYT, _NoiTru;
            if (checkBox_DKBHYT.Checked) _BHYT = "Đã đóng"; else _BHYT = "Chưa đóng";
            if (checkBox_DKtienphong.Checked) _NoiTru = "Đã đóng"; else _NoiTru = "Chưa đóng";

            string query = "EXEC AddSV @CMND , @HoTen , @GioiTinh , @MSSV , @Truong , @Que , @NgaySinh , @MaPhong , @BHYT , @NoiTru";
            int x = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _CMND, _HoTen, _GioiTinh, _MSSV,
            _Truong,_Que,_NgaySinh,_MaPhong,_BHYT, _NoiTru});

            if (x > 0)
            {
                MessageBox.Show("Đăng ký thành công!");
           
                textBox_CMND.Text = "";
                textBox_tenSV.Text = "";
                radioButton_nam.Checked = false; radioButton_nu.Checked = false;
                textBox_mssv.Text = "";
                textBox_truong.Text = "";
                textBox_quequan.Text = "";
                dateTimePicker_ngaysinh.Text = "";
                checkBox_DKBHYT.Checked = false;checkBox_DKtienphong.Checked = false;
                DataTable y = new DataTable();
                dataGridView_TOA.DataSource = y;
                dataGridView_PHONG.DataSource = y;
            }
            else
                MessageBox.Show("Đăng ký thất bại!");
        }

        private void btnReportDSSV_Click(object sender, EventArgs e)
        {
            this.reportViewer_DSSV.RefreshReport();
        }

        private void FmStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLiKTXDataSet_DSSV.SinhVien' table. You can move, or remove it, as needed.
            this.SinhVienTableAdapter.Fill(this.QuanLiKTXDataSet_DSSV.SinhVien);

        }
    }
}
