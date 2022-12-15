using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLPhongTroService
    {
        string Add(PhongTroView obj);
        string Update(PhongTroView obj);
        string Delete(Guid obj);
        List<PhongTroView> GetAll(Guid obj);
    }
}
