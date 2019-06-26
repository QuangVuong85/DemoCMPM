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
    public partial class frmDonThuoc : Form
    {
        public frmDonThuoc()
        {
            InitializeComponent();
        }

        private void frmDonThuoc_Load(object sender, EventArgs e)
        {
            (new ToolTip()).SetToolTip(this.btnThemThuoc, "Thêm mới");
            (new ToolTip()).SetToolTip(this.btnSuaThuoc, "Sửa");
            (new ToolTip()).SetToolTip(this.btnXoaThuoc, "Xóa");
            (new ToolTip()).SetToolTip(this.btnRefresh, "Tải lại");
        }
    }
}
