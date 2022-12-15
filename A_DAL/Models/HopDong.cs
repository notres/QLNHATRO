using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A_DAL.Models
{
    public class HopDong
    {
        public Guid Id { get; set; }
        public Guid ChuTroId { get; set; }
        public string? MaHopDong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double TongTien { get; set; }
        public int TrangThai { get; set; }
        public virtual ChuTro? ChuTro { get; set; }
    }
}
