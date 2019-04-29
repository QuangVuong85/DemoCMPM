using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_QLPK.User_Control;

namespace CNPM_QLPK
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labelcontrol.Text = "Home";
            UserControlHome home = new UserControlHome();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TiepNhan_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Tiếp nhận bệnh nhân";
            UserControlTiepNhanBenhNhan tiepnhan = new UserControlTiepNhanBenhNhan();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(tiepnhan);
            tiepnhan.Dock = DockStyle.Fill;
        }

        private void btn_Khambenh_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Khám bệnh";
            UserControlKhamBenh khambenh = new UserControlKhamBenh();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(khambenh);
            khambenh.Dock = DockStyle.Fill;
        }

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Thuốc và kê đơn";
            UserControlThuocvaKeDon kedon = new UserControlThuocvaKeDon();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(kedon);
            kedon.Dock = DockStyle.Fill;
        }

        private void btn_DichvuLCS_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Dịch vụ LCS";
            UserControlDichVuLCS dv = new UserControlDichVuLCS();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(dv);
            dv.Dock = DockStyle.Fill;
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Home";
            UserControlHome home = new UserControlHome();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void dANHMỤCTHUỐCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Thuốc";
            UserControlThuocvaKeDon kedon = new UserControlThuocvaKeDon();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(kedon);
            kedon.Dock = DockStyle.Fill;
        }

        private void tIẾPNHẬNBỆNHNHÂNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Tiếp nhận bệnh nhân";
            UserControlTiepNhanBenhNhan tiepnhan = new UserControlTiepNhanBenhNhan();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(tiepnhan);
            tiepnhan.Dock = DockStyle.Fill;
        }

        private void kHÁMBỆNHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Khám bệnh";
            UserControlKhamBenh khambenh = new UserControlKhamBenh();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(khambenh);
            khambenh.Dock = DockStyle.Fill;
        }

        private void cHỈĐỊNHCLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelcontrol.Text = "Dịch vụ LCS";
            UserControlDichVuLCS dv = new UserControlDichVuLCS();
            panelcontrol.Controls.Clear();
            panelcontrol.Controls.Add(dv);
            dv.Dock = DockStyle.Fill;
        }
    }
}
