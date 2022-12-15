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
    public class QLPhongTroService : IQLPhongTroService
    {
        private IPhongTroRespository _iPhongTroRespository;

        public QLPhongTroService()
        {
            _iPhongTroRespository = new PhongTroRespository();
        }

        public string Add(PhongTroView obj)
        {
            if (obj == null) return "Thêm không thành công";
            PhongTro x = new PhongTro()
            {
                Id = obj.Id,
                ChuTroId = obj.ChuTroId,
                MaPhong = obj.MaPhong,
                SoNguoi = obj.SoNguoi,
                DienTich = obj.DienTich,
                DiaChi = obj.DiaChi,
                DonGiaPhong = obj.DonGiaPhong,
                TrangThai = obj.TrangThai
            };
            if (_iPhongTroRespository.Add(x))
                return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == Guid.Empty) return "Xóa không thành công";
            var x = _iPhongTroRespository.GetAll().FirstOrDefault(p => p.Id == obj);
            if (_iPhongTroRespository.Delete(x))
                return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<PhongTroView> GetAll(Guid obj)
        {
            List<PhongTroView> lstPhongTroViews = new List<PhongTroView>();
            lstPhongTroViews =
                (from a in _iPhongTroRespository.GetAll()
                 where a.ChuTroId == obj
                 select new PhongTroView()
                 {
                     Id = a.Id,
                     ChuTroId = a.ChuTroId,
                     MaPhong = a.MaPhong,
                     SoNguoi = a.SoNguoi,
                     DienTich = a.DienTich,
                     DiaChi = a.DiaChi,
                     DonGiaPhong = a.DonGiaPhong,
                     TrangThai = a.TrangThai
                 }).ToList();
            return lstPhongTroViews;
        }

        public string Update(PhongTroView obj)
        {
            if (obj == null) return "Sửa không thành công";
            var x = _iPhongTroRespository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.ChuTroId = obj.ChuTroId;
            x.MaPhong = obj.MaPhong;
            x.SoNguoi = obj.SoNguoi;
            x.DienTich = obj.DienTich;
            x.DiaChi = obj.DiaChi;
            x.DonGiaPhong = obj.DonGiaPhong;
            x.TrangThai = obj.TrangThai;
            if (_iPhongTroRespository.Update(x))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
