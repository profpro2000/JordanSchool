using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.ILookupRepo;
using Domain;
using Domain.Model.Lookups;
using System.Linq;
using MiddlewareAndServices.Helper;

namespace Persistence.LookupsRepo
{
  public  class LkpLookupRepo:DbOperation<LkpLookup>, ILkpLookupRepo
  {
      private SchoolDbContext _db;

      public LkpLookupRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
      {
          _db = schoolDbContext;
      }


        public async Task<IEnumerable<LkpLookup>> GetListByType(LookupTypes id)
        {
            return  _db.LkpLookups.Where(x => x.TypeId == (int)id).Select(v => new LkpLookup
            {
                Id = v.Id,
                AName = v.AName,
                LName = v.LName,
                ParentId = v.ParentId,
                DefaultValue = v.DefaultValue,
                TypeId = v.TypeId,
                Value = v.Value

            }).ToList();
        }
    }
}
