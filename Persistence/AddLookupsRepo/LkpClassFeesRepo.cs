using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.AddLookupsRepo
{
  public  class LkpClassFeesRepo:DbOperation<LkpClassFees>, ILkpClassFeesRepo
    {

        private SchoolDbContext _db;

        public LkpClassFeesRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}
