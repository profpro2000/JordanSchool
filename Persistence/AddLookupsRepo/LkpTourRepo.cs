using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;

namespace Persistence.AddLookupsRepo
{
    public class LkpTourRepo:DbOperation<LkpTour>, ILkpTourRepo
    {
        private SchoolDbContext _db;

        public LkpTourRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
        {
            _db = schoolDbContext;
        }

    }
}