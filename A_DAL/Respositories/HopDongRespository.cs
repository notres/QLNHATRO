using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class HopDongRespository : IHopDongRespository
    {
        private QLNhaTroDbContext _dbContext;
        public HopDongRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }

        public bool Add(HopDong obj)
        {
            if (obj == null) return false;
            _dbContext.HopDongs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HopDong obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HopDongs.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HopDong> GetAll()
        {
            return _dbContext.HopDongs.ToList();
        }

        public bool Update(HopDong obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HopDongs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.ChuTroId = obj.ChuTroId;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.TongTien = obj.TongTien;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
