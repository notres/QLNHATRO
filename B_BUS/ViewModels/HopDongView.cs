using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class HopDongView
    {
        public Guid Id { get; set; }
        public Guid ChuTroId { get; set; }
        public string? MaHopDong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double TongTien { get; set; }
        public int TrangThai { get; set; }
    }
}
