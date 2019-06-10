using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Model.AddLookups;
using Core.IAddLookupsRepo;
using Domain.Model.Lookups;

namespace Persistence.AddLookupsRepo
{
   public  class LkpDocumentRepo : DbOperation<LkpDocument>, ILkpDocumentRepo
    {
        SchoolDbContext _db;
        public LkpDocumentRepo(SchoolDbContext context) : base(context)
        {
            _db = context;
        }
    }
}
