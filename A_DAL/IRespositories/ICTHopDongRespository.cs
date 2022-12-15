using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface ICTHopDongRespository
    {
        bool Add(CTHopDong obj);
        bool Update(CTHopDong obj);
        bool Delete(CTHopDong obj);
        List<CTHopDong> GetAll();
    }
}
