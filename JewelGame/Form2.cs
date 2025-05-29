using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelGame
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();

            lbNgChoi1.Hide();
            txtNgChoi1.Hide();
            lbNgChoi2.Hide();
            txtNgChoi2.Hide();

            dgv1.Hide();
        }

        private void rd1nguoi_CheckedChanged(object sender, EventArgs e)
        {
       

            lbNgChoi1.Hide();
            txtNgChoi1.Hide();
            lbNgChoi2.Hide();
            txtNgChoi2.Hide();

            lbTenNgChoi.Show();
            txtTenNgChoi.Show();
        }

        private void rd2nguoi_CheckedChanged(object sender, EventArgs e)
        {
            lbNgChoi1.Show();
            txtNgChoi1.Show();
            lbNgChoi2.Show();
            txtNgChoi2.Show();

            lbTenNgChoi.Hide();
            txtTenNgChoi.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dgv1.Show();
        }
    }
}
