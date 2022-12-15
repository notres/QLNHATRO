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
    public class QLDichVuService : IQLDichVuService
    {
        private IDichVuRespository _iDichVuRespository;

        public QLDichVuService()
        {
            _iDichVuRespository = new DichVuRespository();
        }

        public string Add(DichVuView obj)
        {
            if (obj == null) return "Thêm không thành công";
            DichVu x = new DichVu()
            {
                Id = obj.Id,
                ChuTroId = obj.ChuTroId,
                Ten = obj.Ten,
                DonGia = obj.DonGia
            };
            if (_iDichVuRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iDichVuRespository.GetAll().FirstOrDefault(p => p.Id == obj);
            if (_iDichVuRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<DichVuView> GetAll(Guid obj)
        {
            List<DichVuView> lstDichVuViews = new List<DichVuView>();
            lstDichVuViews =
                (from a in _iDichVuRespository.GetAll()
                 where a.ChuTroId == obj
                 select new DichVuView()
                 {
                     Id = a.Id,
                     ChuTroId = a.ChuTroId,
                     Ten = a.Ten,
                     DonGia = a.DonGia
                 }).ToList();
            return lstDichVuViews;
        }

        public string Update(DichVuView obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iDichVuRespository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.ChuTroId = obj.ChuTroId;
            x.Ten = obj.Ten;
            x.DonGia = obj.DonGia;
            if (_iDichVuRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
