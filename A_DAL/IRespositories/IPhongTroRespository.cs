using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IPhongTroRespository
    {
        bool Add(PhongTro obj);
        bool Update(PhongTro obj);
        bool Delete(PhongTro obj);
        List<PhongTro> GetAll();
    }
}
