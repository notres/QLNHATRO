using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class PhongTroView
    {
        public Guid Id { get; set; }
        public Guid ChuTroId { get; set; }
        public string? MaPhong { get; set; }
        public int SoNguoi { get; set; }
        public double DienTich { get; set; }
        public string? DiaChi { get; set; }
        public double DonGiaPhong { get; set; }
        public int TrangThai { get; set; }
    }
}
