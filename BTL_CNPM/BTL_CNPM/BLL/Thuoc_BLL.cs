using BTL_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.BLL
{
    class Thuoc_BLL
    {
        private ModelQLKhamBenh db = new ModelQLKhamBenh();
        
        public List<Thuoc> GetListThuoc()
        {
            List<Thuoc> lst = null;
            lst = (from u in db.Thuocs select u).ToList();
            return lst;
        }

        public int CountListThuoc()
        {
            List<Thuoc> lst = null;
            lst = (from u in db.Thuocs select u).ToList();
            return lst.Count;
        }

        public void Add(Thuoc th)
        {
            db.Thuocs.Add(th);
            db.SaveChanges();
        }

        public void Remove(string mathuoc)
        {
            var thuoc = db.Thuocs.Find(mathuoc);
            db.Thuocs.Remove(thuoc);
            db.SaveChanges();
        }

        public void Update(Thuoc th)
        {
            var thuoc = db.Thuocs.Find(th.MaThuoc);
            thuoc.MaThuoc = th.MaThuoc;
            thuoc.TenThuoc = th.TenThuoc;
            thuoc.DuongDung = th.DuongDung;
            thuoc.DVT = th.DVT;
            thuoc.DonGia = th.DonGia;
            db.SaveChanges();
        }

        public List<Thuoc> FindByMaThuoc(string id)
        {
            List<Thuoc> lst = null;
            lst = (from u in db.Thuocs
                   where u.MaThuoc.Equals(id)
                   select u
                   ).ToList();
            return lst;
        }

        public List<Thuoc> FindByTenThuoc(string name)
        {
            List<Thuoc> lst = null;
            lst = (from u in db.Thuocs
                   where u.TenThuoc.Contains(name) //like in sql
                   select u
                   ).ToList();
            return lst;
        }

        public bool CheckMaThuoc(Thuoc th)
        {
            Thuoc _thuoc = db.Thuocs.Find(th.MaThuoc);
            if (_thuoc != null)
            {
                return false;
            }
            return true;
        }
    }
}
