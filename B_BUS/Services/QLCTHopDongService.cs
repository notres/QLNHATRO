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
    public class QLCTHopDongService : IQLCTHopDongService
    {
        private ICTHopDongRespository _iCTHopDongRespository;
        private IHopDongRespository _iHopDongRespository;
        private IPhongTroRespository _iPhongTroRespository;
        private IDichVuRespository _iDichVuRespository;

        public QLCTHopDongService()
        {
            _iCTHopDongRespository = new CTHopDongRespository();
            _iHopDongRespository = new HopDongRespository();
            _iPhongTroRespository = new PhongTroRespository();
            _iDichVuRespository = new DichVuRespository();
        }

        public string Add(CreateCTHopDongView obj)
        {
            if (obj == null) return "Thêm không thành công";
            CTHopDong x = new CTHopDong()
            {
                HopDongId = obj.HopDongId,
                PhongTroId = obj.PhongTroId,
                DichVuId = obj.DichVuId
            };
            if (_iCTHopDongRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iCTHopDongRespository.GetAll().FirstOrDefault(s => s.Id == obj);
            if (_iCTHopDongRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<CTHopDongView> GetAll(Guid obj)
        {
            List<CTHopDongView> lstCTHopDongViews = new List<CTHopDongView>();
            lstCTHopDongViews =
                (from a in _iCTHopDongRespository.GetAll()
                 join b in _iHopDongRespository.GetAll() on a.HopDongId equals b.Id
                 join c in _iPhongTroRespository.GetAll() on a.PhongTroId equals c.Id
                 join d in _iDichVuRespository.GetAll() on a.DichVuId equals d.Id
                 where b.Id == obj
                 select new CTHopDongView()
                 {
                     CTHopDong = a,
                     HopDong = b,
                     PhongTro = c,
                     DichVu = d
                 }).ToList();
            return lstCTHopDongViews;
        }

        public List<CTHopDong> GetFromDB()
        {
            return _iCTHopDongRespository.GetAll();
        }

        public string Update(CTHopDong obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iCTHopDongRespository.GetAll().FirstOrDefault(s => s.Id == obj.Id);
            x.Id = obj.Id;
            x.HopDongId = obj.HopDongId;
            x.PhongTroId = obj.PhongTroId;
            x.DichVuId = obj.DichVuId;
            if (_iCTHopDongRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
