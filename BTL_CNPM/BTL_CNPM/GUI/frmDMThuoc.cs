using BTL_CNPM.BLL;
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
    public partial class frmDMThuoc : Form
    {
        public frmDMThuoc()
        {
            InitializeComponent();
        }

        #region event
        private void radioButtonTKMaThuoc_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Status(radioButtonTKMaThuoc, "Mã thuốc:");
        }

        private void radioButtonTKTenThuoc_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Status(radioButtonTKTenThuoc, "Tên thuốc:");
        }

        private void frmDMThuoc_Load(object sender, EventArgs e)
        {
            loadData2DataGridView();
            bindingsData2Control();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadData2DataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region function
        // thay đổi text của lblTimKiem
        private void radioButton_Status(RadioButton rb, string lbl)
        {
            if (rb.Checked == true)
            {
                lblTimKiem.Text = lbl;
                txtTimKiem.Text = string.Empty;
            }
        }

        // load dữ liệu lên datagridview
        private void loadData2DataGridView()
        {
            Thuoc_BLL _thuoc = new Thuoc_BLL();
            dgvDSThuoc.DataSource = _thuoc.GetListThuoc();

            dgvDSThuoc.Columns[0].HeaderCell.Value = "Mã thuốc";
            dgvDSThuoc.Columns[1].HeaderCell.Value = "Tên thuốc";
            dgvDSThuoc.Columns[2].HeaderCell.Value = "Cách dùng";
            dgvDSThuoc.Columns[3].HeaderCell.Value = "Đơn vị tính";
            dgvDSThuoc.Columns[4].HeaderCell.Value = "Đơn giá";

            dgvDSThuoc.Columns[0].Width = 100;
            dgvDSThuoc.Columns[1].Width = 200;
            dgvDSThuoc.Columns[2].Width = 120;
            dgvDSThuoc.Columns[3].Width = 120;
            dgvDSThuoc.Columns[4].Width = 200;

            dgvDSThuoc.Columns[5].Visible = false;
        }

        // đưa dữ liệu từ datagridview lên các control
        public void bindingsData2Control()
        {
            txtMaThuoc.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "MaThuoc"));
            txtTenThuoc.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "TenThuoc"));
            cbxCachDung.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "DuongDung"));
            cbxDonViTinh.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "DVT"));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "DonGia"));
        }
        #endregion
    }
}
