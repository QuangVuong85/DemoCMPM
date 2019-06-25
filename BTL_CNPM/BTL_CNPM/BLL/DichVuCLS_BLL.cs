using BTL_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.BLL
{
    class DichVuCLS_BLL
    {
        private ModelQLKhamBenh db = new ModelQLKhamBenh();
        public List<DichVuCL> listDichVuCLS()
        {
            List<DichVuCL> lst = null;
            lst = (from u in db.DichVuCLS select u).ToList();
            return lst;
        }

        public int countDichVuCLS()
        {
            List<DichVuCL> lst = null;
            lst = (from u in db.DichVuCLS select u).ToList();
            return lst.Count;
        }
    }
}
