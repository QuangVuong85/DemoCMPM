using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.DAL.ViewModels
{
    class TaiKhoan_NhanVien
    {
        public int MaTaiKhoan { get; set; }

        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public bool? VaiTro { get; set; }

        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public string SDT { get; set; }

        public string HocHam { get; set; }

        public string HocVi { get; set; }
    }
}
