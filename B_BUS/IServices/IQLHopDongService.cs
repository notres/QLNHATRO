using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLHopDongService
    {
        string Add(HopDongView obj);
        string Update(HopDongView obj);
        string Delete(Guid obj);
        List<HopDongView> GetAll(Guid obj);
    }
}
