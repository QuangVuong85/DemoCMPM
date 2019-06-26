using BTL_CNPM.DAL.Entities;
using BTL_CNPM.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CNPM.BLL
{
    class BenhNhan_ThanNhan_BLL
    {
        ModelQLKhamBenh db = new ModelQLKhamBenh();

        public List<BenhNhan_ThanNhan> GetListBNTN()
        {
            List<BenhNhan_ThanNhan> lst = null;
            lst = (from bn in db.BenhNhans
                   join tn in db.ThanNhans
                   on bn.MaThanNhan equals tn.MaThanNhan
                   select new BenhNhan_ThanNhan
                   {
                       MaThanNhan = tn.MaThanNhan,
                       TenThanNhan = tn.TenThanNhan,
                       CMNDTN = tn.CMND,
                       SDT = tn.SDT,
                       MaBenhNhan = bn.MaBenhNhan,
                       TenBenhNhan = bn.TenBenhNhan,
                       NgaySinh = bn.NgaySinh,
                       DiaChi = bn.DiaChi,
                       GioiTinh = bn.GioiTinh,
                       CMNDBN = bn.CMND,
                   }).ToList();
            return lst;
        }

        public void Update(BenhNhan_ThanNhan bn_tn)
        {
            string idbn = bn_tn.MaBenhNhan;
            string idtn = bn_tn.MaThanNhan;

            ThanNhan tn = db.ThanNhans.Find(idtn);
            tn.MaThanNhan = bn_tn.MaThanNhan;
            tn.TenThanNhan = bn_tn.TenThanNhan;
            tn.CMND = bn_tn.CMNDTN;
            tn.SDT = bn_tn.SDT;
            db.SaveChanges();

            BenhNhan bn = db.BenhNhans.Find(idbn);
            bn.MaBenhNhan = bn_tn.MaBenhNhan;
            bn.TenBenhNhan = bn_tn.TenBenhNhan;
            bn.NgaySinh = bn_tn.NgaySinh;
            bn.DiaChi = bn_tn.DiaChi;
            bn.GioiTinh = bn_tn.GioiTinh;
            bn.CMND = bn_tn.CMNDBN;
            bn.MaThanNhan = bn_tn.MaThanNhan;
            db.SaveChanges();
        }

        public void Add(BenhNhan_ThanNhan bn_tn)
        {
            ThanNhan tn = new ThanNhan();
            tn.MaThanNhan = bn_tn.MaThanNhan;
            tn.TenThanNhan = bn_tn.TenThanNhan;
            tn.CMND = bn_tn.CMNDTN;
            tn.SDT = bn_tn.SDT;
            db.ThanNhans.Add(tn);
            db.SaveChanges();

            BenhNhan bn = new BenhNhan();
            bn.MaBenhNhan = bn_tn.MaBenhNhan;
            bn.TenBenhNhan = bn_tn.TenBenhNhan;
            bn.NgaySinh = bn_tn.NgaySinh;
            bn.DiaChi = bn_tn.DiaChi;
            bn.GioiTinh = bn_tn.GioiTinh;
            bn.CMND = bn_tn.CMNDBN;
            bn.MaThanNhan = bn_tn.MaThanNhan;
            db.BenhNhans.Add(bn);
            db.SaveChanges();
        }

        public List<BenhNhan_ThanNhan> FindListBNTN(string tenbn)
        {
            List<BenhNhan_ThanNhan> lst = null;
            lst = (from bn in db.BenhNhans
                   join tn in db.ThanNhans
                   on bn.MaThanNhan equals tn.MaThanNhan
                   where bn.TenBenhNhan.Contains(tenbn)
                   select new BenhNhan_ThanNhan
                   {
                       MaThanNhan = tn.MaThanNhan,
                       TenThanNhan = tn.TenThanNhan,
                       CMNDTN = tn.CMND,
                       SDT = tn.SDT,
                       MaBenhNhan = bn.MaBenhNhan,
                       TenBenhNhan = bn.TenBenhNhan,
                       NgaySinh = bn.NgaySinh,
                       DiaChi = bn.DiaChi,
                       GioiTinh = bn.GioiTinh,
                       CMNDBN = bn.CMND,
                   }).ToList();
            return lst;
        }

        public string MaxMaBenhNhan()
        {
            var max = db.BenhNhans.OrderByDescending(i => i.MaBenhNhan).First();
            return (Convert.ToInt32(max.MaBenhNhan)+1).ToString();
        }

        public string MaxMaThanNhan()
        {
            var max = db.ThanNhans.OrderByDescending(i => i.MaThanNhan).First();
            return (Convert.ToInt32(max.MaThanNhan) + 1).ToString();
        }
    }
}
