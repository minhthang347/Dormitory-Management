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
    public partial class FmRoom : Form
    {
        public FmRoom()
        {
            InitializeComponent();
        }

        private void FrRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLiKTXDataSet_HDP.HoaDonPhong' table. You can move, or remove it, as needed.
            this.HoaDonPhongTableAdapter.Fill(this.QuanLiKTXDataSet_HDP.HoaDonPhong);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _tenphong = textBox_searchTenPhong.Text;
            if (_tenphong != "")
                _tenphong = "MaPhong ='" + _tenphong + "'";
            else
                _tenphong = "MaPhong <>''";
                   
            string _tentoa = textBox_searchToa.Text;
            if (_tentoa != "")
                _tentoa = " and MaToa ='" + _tentoa + "'";
            else
                _tentoa = " and MaToa <>''";
            string _loaiphong = textBox_searchLoai.Text;
            if (_loaiphong != "")
                _loaiphong = " and LoaiPhong =" + _loaiphong;
            else
                _loaiphong = " and LoaiPhong <>''";

            string _trong;
            if (checkBox_searchTrong.Checked) _trong = " and LoaiPhong>SoLuong";
            else _trong = " and LoaiPhong>=SoLuong";

            string query = "select MaPhong as [Tên Phòng], MaToa as [Toà nhà], LoaiPhong as [Loại phòng]" +
                ", SoLuong [Số người hiện tại], Gia as [Giá phòng] from Phong where " + _tenphong + _tentoa + _loaiphong + _trong;
            dataGridView_Phong.DataSource = DataProvider.Instance.ExecuteQuery(query);
            
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            int _CSDmoi = Int32.Parse(textBox_CSDmoi.Text);
            int _CSNmoi = Int32.Parse(textBox_CSNmoi.Text);

            DateTime NgayHD = DateTime.Today;
            string _NgayHD = NgayHD.ToShortDateString().Substring(0, 10);
            string[] tempsplit = _NgayHD.Split('/');
            _NgayHD = tempsplit[2] + "/" + tempsplit[1] + "/" + tempsplit[0];
            

            string _phong = textBox_phong.Text;
            string query = "select CSDien, CSNuoc from Phong where MaPhong='" + _phong + "'";
            DataTable ChiSo = DataProvider.Instance.ExecuteQuery(query);
            if (ChiSo.Rows.Count > 0)
            {
                int _CSDcu = (int)ChiSo.Rows[0][0];
                int _CSNcu = (int)ChiSo.Rows[0][1];
                query = "EXEC AddHD @MaPhong , @NgayHD , @CSDienCu , @CSDienMoi , @CSNuocCu , @CSNuocMoi";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { _phong, _NgayHD, _CSDcu, _CSDmoi, _CSNcu, _CSNmoi });

                query = "update Phong set CSDien=" + _CSDmoi.ToString() + ",CSNuoc=" + _CSNmoi.ToString() 
                    + " where MaPhong='" + _phong + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng trên! Vui lòng nhập lại");
            }
        }

        private void btnLoadDSHD_Click(object sender, EventArgs e)
        {
            string _Start = dateTimePicker_start.Value.ToString().Substring(0,10);
            string[] tempsplit = _Start.Split('/');
            _Start = tempsplit[2] + "/" + tempsplit[1] + "/" + tempsplit[0];

            string _End = dateTimePicker_end.Value.ToString().Substring(0, 10);
            tempsplit = _End.Split('/');
            _End = tempsplit[2] + "/" + tempsplit[1] + "/" + tempsplit[0];

            string query = "select MaHD as [Mã hoá đơn], MaPhong as [Tên phòng], NgayHD as [Ngày hoá đơn]," +
                "CSDienCu as [Chỉ số điện cũ], CSDienMoi as [Chỉ số điện mới] , CSNuocCu as [Chỉ số nước cũ]," +
                "CSNuocMoi as [Chỉ số nước mới] from HoaDonPhong where NgayHD>='"+_Start+"' and NgayHD<='"
                + _End + "'";
            dataGridView_HD.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnReportHD_Click(object sender, EventArgs e)
        {
            this.reportViewer_Bill.RefreshReport();

        }
    }
}
