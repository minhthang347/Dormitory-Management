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
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            if (PhanQuyen.Chucvu == 1)
                btnQLTK.Enabled = true;
            else
                btnQLTK.Enabled = false;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            FmStudent f = new FmStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            FmRoom f = new FmRoom();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLToa_Click(object sender, EventArgs e)
        {
            FmBuilding f = new FmBuilding();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            FmAccount f = new FmAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void s_Click(object sender, EventArgs e)
        {
            PhanQuyen.Chucvu = -1;
            this.Dispose();
        }
    }
}
