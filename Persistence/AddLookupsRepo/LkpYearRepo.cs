using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.AddLookupsRepo
{
 public class LkpYearRepo: DbOperation<LkpYear>, ILkpYearRepo
    {
        SchoolDbContext _db;

        public LkpYearRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<LkpYear> GetCurrentYear()
        {
            return _db.LkpYears.Where(x => x.Active == 1).FirstOrDefault();

           /* var data = _db.LkpYears.Where(x => x.Active == 1).Select(x => new {
                x.Id,
                x.AName,
                x.LName,
                x.Active
            }).FirstOrDefault();
                return data;*/
        }
    }
}
