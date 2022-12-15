using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLChuTroService
    {
        string Add(ChuTroView obj);
        string Update(ChuTroView obj);
        string Delete(Guid obj);
        List<ChuTroView> GetAll();
    }
}
