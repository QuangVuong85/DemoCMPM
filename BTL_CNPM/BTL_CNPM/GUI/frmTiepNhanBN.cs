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
    public partial class frmTiepNhanBN : Form
    {
        private string idbn;
        private string idtn;

        public frmTiepNhanBN()
        {
            InitializeComponent();
        }

        #region event
        private void frmTiepNhanBN_Load(object sender, EventArgs e)
        {
            loadData2DataGridView();
            //bindingsData2Control();
        }

        private void dgvDSBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData2Control(e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BenhNhan_ThanNhan_BLL data = new BenhNhan_ThanNhan_BLL();
            BenhNhan_ThanNhan bn_tn = new BenhNhan_ThanNhan();
            bn_tn.MaThanNhan = this.idtn;
            bn_tn.TenThanNhan = txtTenTN.Text;
            bn_tn.CMNDTN = txtCMNDTN.Text;
            bn_tn.SDT = txtSDTTN.Text;
            bn_tn.MaBenhNhan = this.idbn;
            bn_tn.TenBenhNhan = txtTenBN.Text;
            bn_tn.NgaySinh = dateTimePickerNgaySinh.Value;
            bn_tn.DiaChi = txtDiaChiBN.Text;
            bn_tn.CMNDBN = txtCMNDBN.Text;
            if (radioBtnNam.Checked == true)
            {
                bn_tn.GioiTinh = "Nam";
            }
            else
            {
                bn_tn.GioiTinh = "Nữ";
            }
            data.Update(bn_tn);
            MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            loadData2DataGridView();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            BenhNhan_ThanNhan_BLL data = new BenhNhan_ThanNhan_BLL();
            BenhNhan_ThanNhan bn_tn = new BenhNhan_ThanNhan();
            bn_tn.MaThanNhan = data.MaxMaThanNhan();
            bn_tn.TenThanNhan = txtTenTN.Text;
            bn_tn.CMNDTN = txtCMNDTN.Text;
            bn_tn.SDT = txtSDTTN.Text;
            bn_tn.MaBenhNhan = data.MaxMaBenhNhan();
            bn_tn.TenBenhNhan = txtTenBN.Text;
            bn_tn.NgaySinh = dateTimePickerNgaySinh.Value;
            bn_tn.DiaChi = txtDiaChiBN.Text;
            bn_tn.CMNDBN = txtCMNDBN.Text;
            if (radioBtnNam.Checked == true)
            {
                bn_tn.GioiTinh = "Nam";
            }
            else
            {
                bn_tn.GioiTinh = "Nữ";
            }

            data.Add(bn_tn);
            MessageBox.Show("Tiếp nhận thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            loadData2DataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearDataInControl();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BenhNhan_ThanNhan_BLL data = new BenhNhan_ThanNhan_BLL();
            dgvDSBenhNhan.DataSource = data.FindListBNTN(txtTiemKiem.Text);
        }

        #endregion

        #region function
        public void loadData2DataGridView()
        {
            BenhNhan_ThanNhan_BLL data = new BenhNhan_ThanNhan_BLL();
            dgvDSBenhNhan.DataSource = data.GetListBNTN();

            dgvDSBenhNhan.Columns[0].HeaderCell.Value = "Mã thân nhân";
            dgvDSBenhNhan.Columns[1].HeaderCell.Value = "Tên thân nhân";
            dgvDSBenhNhan.Columns[2].HeaderCell.Value = "CMND thân nhân";
            dgvDSBenhNhan.Columns[3].HeaderCell.Value = "Số điện thoại";
            dgvDSBenhNhan.Columns[4].HeaderCell.Value = "Mã bệnh nhân";
            dgvDSBenhNhan.Columns[5].HeaderCell.Value = "Tên bệnh nhân";
            dgvDSBenhNhan.Columns[6].HeaderCell.Value = "Ngày sinh";
            dgvDSBenhNhan.Columns[7].HeaderCell.Value = "Địa chỉ";
            dgvDSBenhNhan.Columns[8].HeaderCell.Value = "Giới tính";
            dgvDSBenhNhan.Columns[9].HeaderCell.Value = "CMND bệnh nhân";

            dgvDSBenhNhan.Columns[0].Width = 150;
            dgvDSBenhNhan.Columns[1].Width = 250;
            dgvDSBenhNhan.Columns[2].Width = 150;
            dgvDSBenhNhan.Columns[3].Width = 150;
            dgvDSBenhNhan.Columns[4].Width = 150;
            dgvDSBenhNhan.Columns[5].Width = 250;
            dgvDSBenhNhan.Columns[6].Width = 100;
            dgvDSBenhNhan.Columns[7].Width = 300;
            dgvDSBenhNhan.Columns[8].Width = 100;
            dgvDSBenhNhan.Columns[9].Width = 150;
        }

        public void bindingsData2Control()
        {
            txtTenBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "TenBenhNhan"));
            dateTimePickerNgaySinh.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "NgaySinh"));
            txtDiaChiBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "DiaChi"));
            txtCMNDBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "CMNDBN"));
            txtCMNDTN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "CMNDTN"));
            txtTenTN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "TenThanNhan"));
            txtSDTTN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "SDT"));
        }

        public void loadData2Control(DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;

            try
            {
                if (dgvDSBenhNhan.Rows[id].Cells[8].Value.ToString() == "Nam")
                {
                    radioBtnNam.Checked = true;
                }
                else
                {
                    radioBtnNu.Checked = true;
                }

                txtTenTN.Text = dgvDSBenhNhan.Rows[id].Cells[1].Value.ToString();
                txtCMNDTN.Text = dgvDSBenhNhan.Rows[id].Cells[2].Value.ToString();
                txtSDTTN.Text = dgvDSBenhNhan.Rows[id].Cells[3].Value.ToString();
                txtTenBN.Text = dgvDSBenhNhan.Rows[id].Cells[5].Value.ToString();
                dateTimePickerNgaySinh.Text = dgvDSBenhNhan.Rows[id].Cells[6].Value.ToString();
                txtDiaChiBN.Text = dgvDSBenhNhan.Rows[id].Cells[7].Value.ToString();
                txtCMNDBN.Text = dgvDSBenhNhan.Rows[id].Cells[9].Value.ToString();
                this.idbn = dgvDSBenhNhan.Rows[id].Cells[4].Value.ToString();
                this.idtn = dgvDSBenhNhan.Rows[id].Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        public void clearDataInControl()
        {
            txtTenBN.Text = string.Empty;
            dateTimePickerNgaySinh.Text = DateTime.Now.ToLongDateString();
            txtDiaChiBN.Text = string.Empty;
            txtCMNDBN.Text = string.Empty;
            txtCMNDTN.Text = string.Empty;
            txtTenTN.Text = string.Empty;
            txtSDTTN.Text = string.Empty;
            radioBtnNam.Checked = true;
        }


        #endregion
    }
}
