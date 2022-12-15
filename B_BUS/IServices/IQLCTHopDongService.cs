using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLCTHopDongService
    {
        string Add(CreateCTHopDongView obj);
        string Update(CTHopDong obj);
        string Delete(Guid obj);
        List<CTHopDongView> GetAll(Guid obj);
        List<CTHopDong> GetFromDB();
    }
}
