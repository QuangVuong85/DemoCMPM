using BTL_CNPM.BLL;
using BTL_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            //bindingsData2Control();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearDataInControl();
            loadData2DataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Thuoc_BLL _thuoc = new Thuoc_BLL();

            if (radioButtonTKMaThuoc.Checked == true)
            {
                dgvDSThuoc.DataSource = _thuoc.FindByMaThuoc(txtTimKiem.Text);
            }

            if (radioButtonTKTenThuoc.Checked == true)
            {
                dgvDSThuoc.DataSource = _thuoc.FindByTenThuoc(txtTimKiem.Text);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Thuoc_BLL _thuoc = new Thuoc_BLL();
            Thuoc th = new Thuoc();

            th.MaThuoc = txtMaThuoc.Text.ToString();
            th.TenThuoc = txtTenThuoc.Text.ToString();
            th.DonGia = Convert.ToInt32(txtDonGia.Text);
            th.DuongDung = cbxCachDung.SelectedItem.ToString();
            th.DVT = cbxDonViTinh.SelectedItem.ToString();

            if (_thuoc.CheckMaThuoc(th) == false)
            {
                MessageBox.Show("Mã thuốc đã tồn tại.", "Thông báo", MessageBoxButtons.OK);
                txtMaThuoc.Focus();
            }
            else
            {
                _thuoc.Add(th);
                MessageBox.Show("Thêm mới thuốc thành công.", "Thông báo", MessageBoxButtons.OK);
                loadData2DataGridView();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc_BLL _thuoc = new Thuoc_BLL();
                Thuoc th = new Thuoc();

                th.MaThuoc = txtMaThuoc.Text.ToString().Trim();
                th.TenThuoc = txtTenThuoc.Text.ToString().Trim();
                th.DonGia = Convert.ToInt32(txtDonGia.Text.Trim());
                th.DuongDung = cbxCachDung.SelectedItem.ToString();
                th.DVT = cbxDonViTinh.SelectedItem.ToString();

                _thuoc.Update(th);
                MessageBox.Show("Cập nhật thông tin thuốc thành công.", "Thông báo", MessageBoxButtons.OK);
                loadData2DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc_BLL _thuoc = new Thuoc_BLL();

                _thuoc.Remove(txtMaThuoc.Text.ToString());
                MessageBox.Show("Xóa thuốc thành công.", "Thông báo", MessageBoxButtons.OK);
                loadData2DataGridView();
                //bindingsData2Control();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData2Control(e);
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
            dgvDSThuoc.Columns[4].HeaderCell.Value = "Đơn giá (VNĐ)";

            dgvDSThuoc.Columns[0].Width = 100;
            dgvDSThuoc.Columns[1].Width = 200;
            dgvDSThuoc.Columns[2].Width = 120;
            dgvDSThuoc.Columns[3].Width = 120;
            dgvDSThuoc.Columns[4].Width = 200;

            dgvDSThuoc.Columns[4].DefaultCellStyle.Format = "#,###";
            dgvDSThuoc.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDSThuoc.Columns[5].Visible = false;
        }

        // cách 1:đưa dữ liệu từ datagridview lên các control
        public void bindingsData2Control()
        {
            txtMaThuoc.DataBindings.Add(new Binding("Text".Trim(), dgvDSThuoc.DataSource, "MaThuoc"));
            txtTenThuoc.DataBindings.Add(new Binding("Text".Trim(), dgvDSThuoc.DataSource, "TenThuoc"));
            cbxCachDung.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "DuongDung"));
            cbxDonViTinh.DataBindings.Add(new Binding("Text", dgvDSThuoc.DataSource, "DVT"));
            txtDonGia.DataBindings.Add(new Binding("Text".Trim(), dgvDSThuoc.DataSource, "DonGia"));
        }
        // cách 2:đưa dữ liệu từ datagridview lên các control
        public void loadData2Control(DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            txtMaThuoc.Text = dgvDSThuoc.Rows[id].Cells[0].Value.ToString().Trim();
            txtTenThuoc.Text = dgvDSThuoc.Rows[id].Cells[1].Value.ToString().Trim();
            cbxCachDung.Text = dgvDSThuoc.Rows[id].Cells[2].Value.ToString().Trim();
            cbxDonViTinh.Text = dgvDSThuoc.Rows[id].Cells[3].Value.ToString().Trim();
            txtDonGia.Text = dgvDSThuoc.Rows[id].Cells[4].Value.ToString().Trim();
        }
        // xóa text trong các control
        public void clearDataInControl()
        {
            txtMaThuoc.Text = string.Empty;
            txtTenThuoc.Text = string.Empty;
            cbxCachDung.Text = "Chọn cách dùng";
            cbxDonViTinh.Text = "Chọn ĐVT";
            txtDonGia.Text = string.Empty;
        }
        #endregion

        
    }
}
