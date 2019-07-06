using Domain.Model.Reg;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.IRegRepo
{
    public interface IRegParentRepo:IRepo<RegParent>
    {

        Task<List<RegParent>> GetAll();

        Task<IEnumerable<object>> ParentDetail(int id);




    }
}