using A_DAL.IRespositories;
using A_DAL.Models;
using A_DAL.Respositories;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class QLChuTroService : IQLChuTroService
    {
        private IChuTroRespository _iChuTroRespository;

        public QLChuTroService()
        {
            _iChuTroRespository = new ChuTroRespository();
        }

        public string Add(ChuTroView obj)
        {
            if (obj == null) return "Thêm không thành công";
            ChuTro x = new ChuTro()
            {
                Id = obj.Id,
                Username = obj.Username,
                Password = obj.Password,
                Ten = obj.Ten,
                Sdt = obj.Sdt,
                Diachi = obj.Diachi,
                Email = obj.Email
            };
            if (_iChuTroRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iChuTroRespository.GetAll().FirstOrDefault(p => p.Id == obj);
            if (_iChuTroRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<ChuTroView> GetAll()
        {
            List<ChuTroView> lstChuTroViews = new List<ChuTroView>();
            lstChuTroViews =
                (from a in _iChuTroRespository.GetAll()
                 select new ChuTroView()
                 {
                     Id = a.Id,
                     Username = a.Username,
                     Password = a.Password,
                     Ten = a.Ten,
                     Sdt = a.Sdt,
                     Diachi = a.Diachi,
                     Email = a.Email
                 }).ToList();
            return lstChuTroViews;
        }

        public string Update(ChuTroView obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iChuTroRespository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Username = obj.Username;
            x.Password = obj.Password;
            x.Ten = obj.Ten;
            x.Sdt = obj.Sdt;
            x.Diachi = obj.Diachi;
            x.Email = obj.Email;
            if (_iChuTroRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
