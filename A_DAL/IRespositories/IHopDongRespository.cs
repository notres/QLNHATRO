using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IHopDongRespository
    {
        bool Add(HopDong obj);
        bool Update(HopDong obj);
        bool Delete(HopDong obj);
        List<HopDong> GetAll();
    }
}
