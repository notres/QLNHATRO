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
    public class QLHopDongService : IQLHopDongService
    {
        private IHopDongRespository _iHopDongRespository;

        public QLHopDongService()
        {
            _iHopDongRespository = new HopDongRespository();
        }

        public string Add(HopDongView obj)
        {
            if (obj == null) return "Thêm không thành công";
            HopDong x = new HopDong()
            {
                ChuTroId = obj.ChuTroId,
                MaHopDong = obj.MaHopDong,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                TongTien = obj.TongTien,
                TrangThai = obj.TrangThai
            };
            if (_iHopDongRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iHopDongRespository.GetAll().FirstOrDefault(p => p.Id == obj);
            if (_iHopDongRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<HopDongView> GetAll(Guid obj)
        {
            List<HopDongView> lstHopDongViews = new List<HopDongView>();
            lstHopDongViews =
                (from a in _iHopDongRespository.GetAll()
                 where a.ChuTroId == obj
                 select new HopDongView()
                 {
                     Id = a.Id,
                     ChuTroId = a.ChuTroId,
                     MaHopDong = a.MaHopDong,
                     NgayTao = a.NgayTao,
                     NgayThanhToan = a.NgayThanhToan,
                     TongTien = a.TongTien,
                     TrangThai = a.TrangThai
                 }).ToList();
            return lstHopDongViews;
        }

        public string Update(HopDongView obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iHopDongRespository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.ChuTroId = obj.ChuTroId;
            x.MaHopDong = obj.MaHopDong;
            x.NgayTao = obj.NgayTao;
            x.NgayThanhToan = obj.NgayThanhToan;
            x.TongTien = obj.TongTien;
            x.TrangThai = obj.TrangThai;
            if (_iHopDongRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
