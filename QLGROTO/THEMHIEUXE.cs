﻿using QLGROTO.DAO;

namespace QLGROTO
{
    public partial class THEMHIEUXE : Form
    {
        public THEMHIEUXE()
        {
            InitializeComponent();
        }

        private void ThemHieuXe_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public bool ThemHieuXe(string s)
        {
            return HIEUXEDAO.Instance.ThemHieuXe(s);
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(themtxtbox.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                string s = themtxtbox.Text;
                if (ThemHieuXe(s))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm hiệu xe thất bại!");
                    this.Close();
                }
            }
        }
    }
}
