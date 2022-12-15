using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class DichVuView
    {
        public Guid Id { get; set; }
        public Guid ChuTroId { get; set; }
        public string? Ten { get; set; }
        public double DonGia { get; set; }
    }
}
