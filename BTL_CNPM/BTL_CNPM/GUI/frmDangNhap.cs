using BTL_CNPM.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        #region mouseForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // click chuột lên và di chuyển đến vị trí khác
        public void MouseDown()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region event
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            (new ToolTip()).SetToolTip(this.btnThoat, "Close");
            (new ToolTip()).SetToolTip(this.btnDangNhap, "Đăng nhập");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Red;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown();
        }

        private void lblTop_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        #endregion

    }
}
