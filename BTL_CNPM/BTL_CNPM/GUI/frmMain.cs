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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region event
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1570, 868);
            loadForm(new frmTrangChu());
        }

        // start TRO GIUP
        private void thongTinPMStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroGiup help = new frmTroGiup();
            help.ShowDialog();
        }
        // end TRO GIUP

        // start TOOLSTRIP
        private void homeToolStripButton_Click(object sender, EventArgs e)
        {
            frmTrangChu home = new frmTrangChu();
            closeFormInPanel(this.panelMain);
            loadForm(home);
        }

        private void closePanelToolStripButton_Click(object sender, EventArgs e)
        {
            closeFormInPanel(this.panelMain);
        }
        // end TOOLSTRIP

        // start NGHIEP VU
        private void tiepNhanBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiepNhanBN tiepNhanBN = new frmTiepNhanBN();
            closeFormInPanel(this.panelMain);
            loadForm(tiepNhanBN);
        }

        private void khamBenhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhamBenh khamBenh = new frmKhamBenh();
            closeFormInPanel(this.panelMain);
            loadForm(khamBenh);
        }

        private void chiDinhCLSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dsTaiKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // end NGHIEP VU

        // start DANH MUC
        private void danhMucThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMThuoc dmthuoc = new frmDMThuoc();
            closeFormInPanel(this.panelMain);
            loadForm(dmthuoc);
        }

        private void danhMucDonThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucNVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucBenhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // end DANH MUC

        // start HE THONG
        private void saoLuuDuLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // end HE THONG

        // start BAOCAO
        private void thongKeBNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thongKeSLThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // end BAO CAO

        #endregion

        #region function
        // xóa form trong panel
        public void closeFormInPanel(Panel pnlName)
        {
            if (pnlName.Controls.Count > 0)
            {
                pnlName.Controls.RemoveAt(0);
            }
        }

        // load form lên panel
        public void loadForm(Form frmName)
        {
            frmName.TopLevel = false;
            this.panelMain.Controls.Add(frmName);
            frmName.FormBorderStyle = FormBorderStyle.None;
            frmName.Dock = DockStyle.Fill;
            frmName.Show();
        }

        #endregion
    }
}
