using BTL_CNPM.BLL;
using BTL_CNPM.DAL.ViewModels;
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
    public partial class frmDMNhanVien : Form
    {
        private int idtk;
        private string idnv;

        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        #region event
        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            loadData2DataGridView();
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData2Control(e);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            TaiKhoan_NhanVien_BLL tk_nv = new TaiKhoan_NhanVien_BLL();
            TaiKhoan_NhanVien tt = new TaiKhoan_NhanVien();

            try
            {
                if (tk_nv.CheckTenTK(txtTK.Text.Trim()) == true)
                {
                    tt.MaTaiKhoan = tk_nv.GetMaxMaTK();
                    tt.TenDangNhap = txtTK.Text.Trim();
                    tt.MatKhau = txtMK.Text.Trim();
                    tt.VaiTro = (cbxVaiTro.SelectedItem == "Là quản trị viên") ? true : false;

                    tt.MaNhanVien = txtMaNV.Text.Trim();
                    tt.TenNhanVien = txtTenNV.Text.Trim();
                    tt.NgaySinh = dateTimePickerNgaySinh.Value;
                    if (radioBtnNam.Checked == true) tt.GioiTinh = "Nam";
                    if (radioBtnNu.Checked == true) tt.GioiTinh = "Nữ";
                    tt.DiaChi = txtDiaChi.Text.Trim();
                    tt.SDT = txtSDT.Text.Trim();
                    tt.HocHam = cbxHocHam.SelectedItem.ToString();
                    tt.HocVi = cbxHocVi.SelectedItem.ToString();

                    tk_nv.Add(tt);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                    loadData2DataGridView();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan_NhanVien_BLL tk_nv = new TaiKhoan_NhanVien_BLL();
            TaiKhoan_NhanVien tt = new TaiKhoan_NhanVien();

            if (tk_nv.CheckTenTK(txtTK.Text.Trim()) == true)
            {
                tt.MaTaiKhoan = idtk;
                tt.TenDangNhap = txtTK.Text.Trim();
                tt.MatKhau = txtMK.Text.Trim();
                tt.VaiTro = (cbxVaiTro.SelectedItem.ToString() == "Là quản trị viên") ? true : false;
                tt.MaNhanVien = idnv;
                tt.TenNhanVien = txtTenNV.Text.Trim();
                tt.NgaySinh = dateTimePickerNgaySinh.Value;
                if (radioBtnNam.Checked == true) tt.GioiTinh = "Nam";
                if (radioBtnNu.Checked == true) tt.GioiTinh = "Nữ";
                tt.DiaChi = txtDiaChi.Text.Trim();
                tt.SDT = txtSDT.Text.Trim();
                tt.HocHam = cbxHocHam.SelectedItem.ToString();
                tt.HocVi = cbxHocVi.SelectedItem.ToString();

                tk_nv.Update(tt);
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
                loadData2DataGridView();
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoan_NhanVien_BLL tk_nv = new TaiKhoan_NhanVien_BLL();

            try
            {
                tk_nv.Delete(idtk, idnv);
                MessageBox.Show("Xóa thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
                loadData2DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadData2DataGridView();
            clearTextInControl();
        }

        #endregion

        #region function
        public void loadData2DataGridView()
        {
            TaiKhoan_NhanVien_BLL tk_nv = new TaiKhoan_NhanVien_BLL();
            dgvDSNV.DataSource = tk_nv.GetListNhanVien();

            dgvDSNV.Columns[0].Visible = false;
            dgvDSNV.Columns[2].Visible = false;
            dgvDSNV.Columns[3].Visible = false;

            dgvDSNV.Columns[1].HeaderCell.Value = "Tên đăng nhập";
            dgvDSNV.Columns[4].HeaderCell.Value = "Mã nhân viên";
            dgvDSNV.Columns[5].HeaderCell.Value = "Tên nhân viên";
            dgvDSNV.Columns[6].HeaderCell.Value = "Ngày sinh";
            dgvDSNV.Columns[7].HeaderCell.Value = "Giới tính";
            dgvDSNV.Columns[8].HeaderCell.Value = "Địa chỉ";
            dgvDSNV.Columns[9].HeaderCell.Value = "Số điện thoại";
            dgvDSNV.Columns[10].HeaderCell.Value = "Học hàm";
            dgvDSNV.Columns[11].HeaderCell.Value = "Học vị";

            dgvDSNV.Columns[1].Width = 150;
            dgvDSNV.Columns[4].Width = 120;
            dgvDSNV.Columns[5].Width = 150;
            dgvDSNV.Columns[6].Width = 100;
            dgvDSNV.Columns[7].Width = 100;
            dgvDSNV.Columns[8].Width = 200;
            dgvDSNV.Columns[9].Width = 120;
            dgvDSNV.Columns[10].Width = 120;
            dgvDSNV.Columns[11].Width = 120;
        }

        public void loadData2Control(DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            try
            {
                txtTK.Text = dgvDSNV.Rows[id].Cells[1].Value.ToString().Trim();
                txtMK.Text = dgvDSNV.Rows[id].Cells[2].Value.ToString().Trim();
                txtMaNV.Text = dgvDSNV.Rows[id].Cells[4].Value.ToString().Trim();
                txtTenNV.Text = dgvDSNV.Rows[id].Cells[5].Value.ToString().Trim();
                dateTimePickerNgaySinh.Text = dgvDSNV.Rows[id].Cells[6].Value.ToString();
                txtDiaChi.Text = dgvDSNV.Rows[id].Cells[8].Value.ToString().Trim();
                txtSDT.Text = dgvDSNV.Rows[id].Cells[9].Value.ToString().Trim();
                cbxHocHam.Text = dgvDSNV.Rows[id].Cells[10].Value.ToString();
                cbxHocVi.Text = dgvDSNV.Rows[id].Cells[11].Value.ToString();

                this.idnv = dgvDSNV.Rows[id].Cells[4].Value.ToString().Trim();
                this.idtk = Convert.ToInt32(dgvDSNV.Rows[id].Cells[0].Value);

                if (dgvDSNV.Rows[id].Cells[3].Value.ToString() == "True")
                {
                    cbxVaiTro.Text = "Là quản trị viên";
                }
                else
                {
                    cbxVaiTro.Text = "Là bác sĩ";
                }

                if (dgvDSNV.Rows[id].Cells[7].Value.ToString() == "Nam")
                {
                    radioBtnNam.Checked = true;
                }
                else
                {
                    radioBtnNu.Checked = true;
                }
            }
            catch
            {
                return;
            }
        }

        public void clearTextInControl()
        {
            txtTK.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtMaNV.Text = (new TaiKhoan_NhanVien_BLL()).GetMaxMaNV();
            txtTenNV.Text = string.Empty;
            dateTimePickerNgaySinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cbxHocHam.Text = string.Empty;
            cbxHocVi.Text = string.Empty;
        }
        #endregion


    }
}
