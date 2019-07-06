using System.Collections.Generic;
using System.Threading.Tasks;
using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
        return  await _db.LkpSchools.Include(p => p.CitesLookup)
               // .Include(p=>p.CitesLookup.LName)
                .ToListAsync();
      }
        public   List<LkpSchool> GetTest()
        {
            var data1= _db.LkpSchools.Where(p => p.Lname.Contains("R"))
                .Include(p => p.CitesLookup)/*.ThenInclude(x => x.AName)*/.ToList();
            
            return data1;

        }
        public async  Task<IEnumerable<object>> GetTest3()
        {

            
            var data2 = _db.LkpSchools.Select(x => new {
                x.Id,
                x.Aname,
                CityName = x.CitesLookup.AName ,
               // parent= x.RegParents.FirstName
                // .FirstOrDefault().ToString():""



            }).ToList();
            return  data2;

        }


        public LkpSchool GetTest2()
        {
            return _db.LkpSchools.Where(p => p.Lname.Contains("R"))
                .Include(p => p.CitesLookup).FirstOrDefault();//.ThenInclude(x => x.AName).FirstOrDefault();
        }



    }
}
