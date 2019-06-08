using System;
using System.Collections.Generic;
using System.Text;
using Core.ILookupRepo;
using Domain;
using Domain.Model.Lookups;

namespace Persistence.LookupsRepo
{
  public  class LkpLookupRepo:DbOperation<LkpLookup>, ILkpLookupRepo
  {
      private SchoolDbContext _db;

      public LkpLookupRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
      {
          _db = schoolDbContext;
      }
  }
}
