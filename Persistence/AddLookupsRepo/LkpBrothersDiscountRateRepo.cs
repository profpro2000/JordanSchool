using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.AddLookupsRepo
{
  public  class LkpBrothersDiscountRateRepo:DbOperation<LkpBrothersDiscountRate>, ILkpBrothersDiscountRateRepo
    {
        SchoolDbContext _db;

        public LkpBrothersDiscountRateRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
