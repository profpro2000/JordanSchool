using Domain.Model.Lookups;
using ServicesAndMiddleware.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.ILookupRepo
{
    public interface ILkpLookupRepo: IRepo<LkpLookup>
    {

        Task<IEnumerable<LkpLookup>> GetListByType(LookupTypes id);

    }

   
}