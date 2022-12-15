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
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangRespository _iKhachHangRespository;
        private IHopDongRespository _iHopDongRespository;

        public QLKhachHangService()
        {
            _iKhachHangRespository = new KhachHangRespository();
            _iHopDongRespository = new HopDongRespository();
        }

        public string Add(CreateKhachHangView obj)
        {
            if (obj == null) return "Thêm không thành công";
            KhachHang x = new KhachHang()
            {
                HopDongId = obj.HopDongId,
                Ten = obj.Ten,
                GioiTinh = obj.GioiTinh,
                Sdt = obj.Sdt,
                Email = obj.Email,
                Quequan = obj.Quequan,
                CMND = obj.CMND
            };
            if (_iKhachHangRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iKhachHangRespository.GetAll().FirstOrDefault(p => p.Id == obj);
            if (_iKhachHangRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<KhachHangView> GetAll(Guid obj)
        {
            List<KhachHangView> lstKhachHangViews = new List<KhachHangView>();
            lstKhachHangViews =
                (from a in _iKhachHangRespository.GetAll()
                 join b in _iHopDongRespository.GetAll() on a.HopDongId equals b.Id
                 where b.ChuTroId == obj
                 select new KhachHangView()
                 {
                     KhachHang = a,
                     HopDong = b
                 }).ToList();
            return lstKhachHangViews;
        }

        public string Update(UpdateKhachHangView obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iKhachHangRespository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.HopDongId = obj.HopDongId;
            x.Ten = obj.Ten;
            x.GioiTinh = obj.GioiTinh;
            x.Sdt = obj.Sdt;
            x.Email = obj.Email;
            x.Quequan = obj.Quequan;
            x.CMND = obj.CMND;
            if (_iKhachHangRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
