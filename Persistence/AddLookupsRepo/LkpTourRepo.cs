using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.AddLookupsRepo
{
    public class LkpTourRepo:DbOperation<LkpTour>, ILkpTourRepo
    {
        private SchoolDbContext _db;

        public LkpTourRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
        {
            _db = schoolDbContext;
        }

        public async Task<List<LkpTour>> GetAll()
        {
            return await _db.LkpTours.Include(p => p.Tour).ToListAsync();
        }

    }
}