using BTL_CNPM.DAL.Entities;
using BTL_CNPM.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.BLL
{
    class TaiKhoan_NhanVien_BLL
    {
        private ModelQLKhamBenh db = new ModelQLKhamBenh();

        public List<TaiKhoan_NhanVien> GetListNhanVien()
        {
            List<TaiKhoan_NhanVien> lst = null;
            lst = (from nv in db.NhanViens
                   join tk in db.TaiKhoans
                   on nv.MaNhanVien equals tk.MaNhanVien
                   select new TaiKhoan_NhanVien
                   {
                       MaTaiKhoan = tk.MaTaiKhoan,
                       TenDangNhap = tk.TenDangNhap,
                       MatKhau = tk.MatKhau,
                       VaiTro = tk.VaiTro,
                       MaNhanVien = nv.MaNhanVien,
                       TenNhanVien = nv.TenNhanVien,
                       NgaySinh = nv.NgaySinh,
                       DiaChi = nv.DiaChi,
                       HocHam = nv.HocHam,
                       HocVi = nv.HocVi,
                       GioiTinh = nv.GioiTinh,
                       SDT = nv.SDT
                   }).ToList();
            return lst;
        }

        public void Add(TaiKhoan_NhanVien tk_nv)
        {
            NhanVien nv = new NhanVien()
            {
                MaNhanVien = tk_nv.MaNhanVien,
                TenNhanVien = tk_nv.TenNhanVien,
                NgaySinh = tk_nv.NgaySinh,
                DiaChi = tk_nv.DiaChi,
                HocHam = tk_nv.HocHam,
                HocVi = tk_nv.HocVi,
                GioiTinh = tk_nv.GioiTinh,
                SDT = tk_nv.SDT
            };
            db.NhanViens.Add(nv);
            db.SaveChanges();

            TaiKhoan tk = new TaiKhoan()
            {
                MaTaiKhoan = tk_nv.MaTaiKhoan,
                TenDangNhap = tk_nv.TenDangNhap,
                MatKhau = tk_nv.MatKhau,
                VaiTro = tk_nv.VaiTro,
                MaNhanVien = tk_nv.MaNhanVien
            };
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }

        public void Update(TaiKhoan_NhanVien tk_nv)
        {
            var nv = db.NhanViens.Find(tk_nv.MaNhanVien);
            nv.MaNhanVien = tk_nv.MaNhanVien;
            nv.TenNhanVien = tk_nv.TenNhanVien;
            nv.NgaySinh = tk_nv.NgaySinh;
            nv.DiaChi = tk_nv.DiaChi;
            nv.HocHam = tk_nv.HocHam;
            nv.HocVi = tk_nv.HocVi;
            nv.GioiTinh = tk_nv.GioiTinh;
            nv.SDT = tk_nv.SDT;
            db.SaveChanges();

            var tk = db.TaiKhoans.Find(tk_nv.MaTaiKhoan);
            tk.MaTaiKhoan = tk_nv.MaTaiKhoan;
            tk.TenDangNhap = tk_nv.TenDangNhap;
            tk.MatKhau = tk_nv.MatKhau;
            tk.VaiTro = tk_nv.VaiTro;
            tk.MaNhanVien = tk_nv.MaNhanVien;
            db.SaveChanges();
        }

        public void Delete(int idtk, string idnv)
        {
            var tk = db.TaiKhoans.Find(idtk);
            db.TaiKhoans.Remove(tk);
            db.SaveChanges();

            var nv = db.NhanViens.Find(idnv);
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }

        public int GetMaxMaTK()
        {
            var tk = db.TaiKhoans.OrderByDescending(i => i.MaTaiKhoan).First();
            return (tk.MaTaiKhoan + 1);
        }

        public string GetMaxMaNV()
        {
            var nv = db.NhanViens.OrderByDescending(i => i.MaNhanVien).First();
            return (Convert.ToInt32(nv.MaNhanVien) + 1).ToString();
        }

        public bool CheckTenTK(string tentk)
        {
            var tk = (from t in db.TaiKhoans
                      where t.TenDangNhap == tentk
                      select t).ToList();
            if (tk.Count != 0) return false;
            return true;
        }
    }
}
