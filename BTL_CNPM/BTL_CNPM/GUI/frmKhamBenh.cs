using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class frmKhamBenh : Form
    {
        public frmKhamBenh()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            frmDonThuoc donThuoc = new frmDonThuoc();
            donThuoc.ShowDialog();
        }
    }
}
