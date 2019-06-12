using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLPK.Forms
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_TenDangNhap.Text;
            string mk = txt_MatKhau.Text;

            if (txt_TenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
            }
            else if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");

            }
            else if (/*DAO.DangNhapDAO.Instance.DangNhap(tendangnhap, mk)*/true)
            {
                Menu m = new Menu();
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên hoặc mật khẩu sai. Mời nhập lại.");
            }
        }
    }
}
