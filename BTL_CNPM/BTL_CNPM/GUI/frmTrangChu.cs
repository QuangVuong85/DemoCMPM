using BTL_CNPM.BLL;
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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            loadDV();
        }

        public void loadDV()
        {
            DichVuCLS_BLL dv = new DichVuCLS_BLL();
            int stt = 0;
            for (int i = 0; i < dv.countDichVuCLS(); i++)
            {
                stt = i + 1;
                ListViewItem listitem = new ListViewItem((stt).ToString());
                listitem.SubItems.Add(dv.GetListDichVuCLS()[i].MaDichVu.ToString());
                listitem.SubItems.Add(dv.GetListDichVuCLS()[i].TenDichVu.ToString());
                listitem.SubItems.Add(String.Format(new CultureInfo("vi-VN"), "{0:c00}", dv.GetListDichVuCLS()[i].DonGia));
                listViewDV.Items.Add(listitem);
            }

            listViewDV.Columns[3].TextAlign = HorizontalAlignment.Right;
        }
    }
}
