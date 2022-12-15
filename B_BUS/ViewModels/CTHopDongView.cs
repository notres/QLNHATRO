using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class CTHopDongView
    {
        public CTHopDong? CTHopDong { get; set; }
        public HopDong? HopDong { get; set; }
        public PhongTro? PhongTro { get; set; }
        public DichVu? DichVu { get; set; }
    }
}
