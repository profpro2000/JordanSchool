using Domain.Model.Reg;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.IRegRepo
{
    public interface IRegStudRepo:IRepo<RegStud>
    {
         Task<List<RegStud>> StudList();
    }
}

  