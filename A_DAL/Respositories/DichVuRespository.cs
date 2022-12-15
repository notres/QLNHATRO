using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class DichVuRespository : IDichVuRespository
    {
        private QLNhaTroDbContext _dbContext;
        public DichVuRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }

        public bool Add(DichVu obj)
        {
            if (obj == null) return false;
            _dbContext.DichVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DichVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DichVus.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DichVu> GetAll()
        {
            return _dbContext.DichVus.ToList();
        }

        public bool Update(DichVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DichVus.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.ChuTroId = obj.ChuTroId;
            tempobj.Ten = obj.Ten;
            tempobj.DonGia = obj.DonGia;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
