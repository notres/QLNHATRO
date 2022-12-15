using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IChuTroRespository
    {
        bool Add(ChuTro obj);
        bool Update(ChuTro obj);
        bool Delete(ChuTro obj);
        List<ChuTro> GetAll();
    }
}
