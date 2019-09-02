using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Model.AddLookups;

namespace Persistence.AddLookupsRepo
{
   public class LkpSectionRepo: DbOperation<LkpSection>,  ILkpSectionRepo
   {
       private SchoolDbContext _db;

       public LkpSectionRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
       {
           _db = schoolDbContext;
       }

       
   }
}
