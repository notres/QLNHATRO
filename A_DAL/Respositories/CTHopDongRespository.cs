using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class CTHopDongRespository : ICTHopDongRespository
    {
        private QLNhaTroDbContext _dbContext;
        public CTHopDongRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }
        public bool Add(CTHopDong obj)
        {
            if (obj == null) return false;
            _dbContext.CTHopDongs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CTHopDong obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CTHopDongs.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<CTHopDong> GetAll()
        {
            return _dbContext.CTHopDongs.ToList();
        }

        public bool Update(CTHopDong obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CTHopDongs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Id = obj.Id;
            tempobj.HopDongId = obj.HopDongId;
            tempobj.PhongTroId = obj.PhongTroId;
            tempobj.DichVuId = obj.DichVuId;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
