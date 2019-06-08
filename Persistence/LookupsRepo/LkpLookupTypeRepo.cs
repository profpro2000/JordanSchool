using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.ILookupRepo;
using Domain;
using Domain.Model.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Persistence.LookupsRepo
{
   public class LkpLookupTypeRepo: DbOperation<Domain.Model.Lookups.LkpLookupType>, ILkpLookupTypeRepo
   {
       private SchoolDbContext _db;

       public LkpLookupTypeRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
       {
           _db = schoolDbContext;
       }

       public async Task<List<LkpLookupType>> GetAllWithChildren()
       {
           var result = await _db.LkpLookupTypes.Include(c => c.LkpLookups ).ToListAsync();
           return result;
       }
    }
}
