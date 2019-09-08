using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;

namespace Persistence.AddLookupsRepo
{
    public class LkpBusRepo:DbOperation<LkpBus>,ILkpBusRepo
    {
        SchoolDbContext _db;

        public LkpBusRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}