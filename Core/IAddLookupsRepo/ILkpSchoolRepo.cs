using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.AddLookups;
using Model.AddLookups;

namespace Core.IAddLookupsRepo
{
    public interface ILkpSchoolRepo:IRepo<LkpSchool>
    {
        Task<List<LkpSchool>> GetAll();
    }
}