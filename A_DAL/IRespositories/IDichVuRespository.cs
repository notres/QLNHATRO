using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IDichVuRespository
    {
        bool Add(DichVu obj);
        bool Update(DichVu obj);
        bool Delete(DichVu obj);
        List<DichVu> GetAll();
    }
}
