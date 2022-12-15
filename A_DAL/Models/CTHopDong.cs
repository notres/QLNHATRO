using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A_DAL.Models
{
    public class CTHopDong
    {
        public Guid Id { get; set; }
        public Guid HopDongId { get; set; }
        public Guid PhongTroId { get; set; }
        public Guid DichVuId { get; set; }
        public virtual HopDong? HopDong { get; set; }
        public virtual PhongTro? PhongTro { get; set; }
        public virtual DichVu? DichVu { get; set; }
    }
}
