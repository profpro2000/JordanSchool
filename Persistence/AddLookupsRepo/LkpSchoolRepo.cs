using System.Collections.Generic;
using System.Threading.Tasks;
using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Model.AddLookups;

namespace Persistence.AddLookupsRepo
{
  public  class LkpSchoolRepo:DbOperation<LkpSchool>, ILkpSchoolRepo
  {
      private SchoolDbContext _db;

      public LkpSchoolRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
      {
          _db = schoolDbContext;
      }

      public async Task<List<LkpSchool>> GetAll()
      {
        return   await _db.LkpSchools.Include(p => p.LkpSections).ToListAsync();
      }

     
  }
}
