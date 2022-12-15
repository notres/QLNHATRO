using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class ChuTro
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Ten { get; set; }
        public string? Sdt { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }
    }
}
