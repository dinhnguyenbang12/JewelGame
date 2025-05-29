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
    public partial class FormMenu : Form
    {
        public class Data_tranDau
        {
            public int maTranDau;
            public string tenNguoiChoi1;
            public string tenNguoiChoi2;

            public int KichCo;
            public double thoiGian;
        }

        public List<Data_tranDau> listData;

        public FormMenu()
        {
            InitializeComponent();

            listData = new List<Data_tranDau>();
            listData.Add(new Data_tranDau
            {
                maTranDau = 0, tenNguoiChoi1 = "Bang1", tenNguoiChoi2 = "Bang2", KichCo = 12, thoiGian = 234,
            });
            listData.Add(new Data_tranDau
            {
                maTranDau = 1,
                tenNguoiChoi1 = "Hung1",
                tenNguoiChoi2 = "Hung2",
                KichCo = 32,
                thoiGian = 534,
            });
            listData.Add(new Data_tranDau
            {
                maTranDau = 3,
                tenNguoiChoi1 = "dung1",
                tenNguoiChoi2 = "dung2",
                KichCo = 82,
                thoiGian = 984,
            });
            listData.Add(new Data_tranDau
            {
                maTranDau = 4,
                tenNguoiChoi1 = "duong1",
                tenNguoiChoi2 = "duong2",
                KichCo = 54,
                thoiGian = 098,
            });
        }



        private void FormMenu_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Hide();
            txtPlayer1.Hide();
            txtPlayer2.Hide();

            rd1player.Checked = true;

            dgvDS.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rd2player_CheckedChanged(object sender, EventArgs e)
        {
            bool hienThi = rd2player.Checked;

            label4.Show();
            txtPlayer1.Show();

            label5.Show();
            txtPlayer2.Show();

            label1.Hide();
            txtPlayer.Hide();
        }

        private void rd1player_CheckedChanged(object sender, EventArgs e)
        {
            bool hienThi = rd1player.Checked;

            label4.Hide();
            txtPlayer1.Hide();

            label5.Hide();
            txtPlayer2.Hide(); 

            label1.Show();
            txtPlayer.Show();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            dgvDS.Show();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
