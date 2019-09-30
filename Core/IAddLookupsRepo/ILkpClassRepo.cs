using Domain.Model.AddLookups;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.IAddLookupsRepo
{
    public interface ILkpClassRepo: IRepo<LkpClass>
    {
        Task<IEnumerable<object>> GetClassBySchool(int schoolId);
        Task<IEnumerable<object>> GetClassBySection(int sectionId);
    }
}