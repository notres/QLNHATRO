using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class KhachHangRespository : IKhachHangRespository
    {
        private QLNhaTroDbContext _dbContext;
        public KhachHangRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }

        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.HopDongId = obj.HopDongId;
            tempobj.Ten = obj.Ten;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.Sdt = obj.Sdt;
            tempobj.Email = obj.Email;
            tempobj.Quequan = obj.Quequan;
            tempobj.CMND = obj.CMND;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
