using BTL_CNPM.DAL.Entities;
using BTL_CNPM.DAL.ViewModels;
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
    }
}
