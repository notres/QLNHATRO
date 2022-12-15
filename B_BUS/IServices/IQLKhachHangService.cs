using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IQLKhachHangService
    {
        string Add(CreateKhachHangView obj);
        string Update(UpdateKhachHangView obj);
        string Delete(Guid obj);
        List<KhachHangView> GetAll(Guid obj);
    }
}
