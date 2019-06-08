using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;

namespace Persistence.AddLookupsRepo
{
    public class LkpClassRepo: DbOperation<LkpClass>, ILkpClassRepo
    {
        private SchoolDbContext _db;

        public LkpClassRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}