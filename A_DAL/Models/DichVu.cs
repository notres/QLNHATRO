using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class DichVu
    {
        public Guid Id { get; set; }
        public Guid ChuTroId { get; set; }
        public string? Ten { get; set; }
        public double DonGia { get; set; }
        public virtual ChuTro? ChuTro { get; set; }
    }
}
