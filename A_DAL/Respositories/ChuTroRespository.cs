using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class ChuTroRespository : IChuTroRespository
    {
        private QLNhaTroDbContext _dbContext;
        public ChuTroRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }
        public bool Add(ChuTro obj)
        {
            if (obj == null) return false;
            _dbContext.ChuTros.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChuTro obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChuTros.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChuTro> GetAll()
        {
            return _dbContext.ChuTros.ToList();
        }

        public bool Update(ChuTro obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChuTros.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Id = obj.Id;
            tempobj.Username = obj.Username;
            tempobj.Password = obj.Password;
            tempobj.Ten = obj.Ten;
            tempobj.Sdt = obj.Sdt;
            tempobj.Diachi = obj.Diachi;
            tempobj.Email = obj.Email;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
