using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLDichVuService
    {
        string Add(DichVuView obj);
        string Update(DichVuView obj);
        string Delete(Guid obj);
        List<DichVuView> GetAll(Guid obj);
    }
}
