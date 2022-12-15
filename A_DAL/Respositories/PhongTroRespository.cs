using A_DAL.IRespositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class PhongTroRespository : IPhongTroRespository
    {
        private QLNhaTroDbContext _dbContext;
        public PhongTroRespository()
        {
            _dbContext = new QLNhaTroDbContext();
        }

        public bool Add(PhongTro obj)
        {
            if (obj == null) return false;
            _dbContext.PhongTros.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhongTro obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.PhongTros.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<PhongTro> GetAll()
        {
            return _dbContext.PhongTros.ToList();
        }

        public bool Update(PhongTro obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.PhongTros.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.MaPhong = obj.MaPhong;
            tempobj.SoNguoi = obj.SoNguoi;
            tempobj.DienTich = obj.DienTich;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.DonGiaPhong = obj.DonGiaPhong;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
