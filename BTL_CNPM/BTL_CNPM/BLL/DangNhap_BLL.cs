using BTL_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.BLL
{
    class DangNhap_BLL
    {
        private ModelQLKhamBenh db = new ModelQLKhamBenh();

        public bool CheckDangNhap(string acc, string pwd)
        {
            var check = (from tk in db.TaiKhoans
                         where tk.TenDangNhap == acc && tk.MatKhau == pwd
                         select tk).ToList();
            if (check.Count != 0) return true;
            return false;
        }
    }
}
