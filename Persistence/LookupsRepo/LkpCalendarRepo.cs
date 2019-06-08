using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Core.ILookupRepo;
using Domain;
using Domain.Model.Lookups;

namespace Persistence.LookupsRepo
{
  public  class LkpCalendarRepo: DbOperation<LkpCalendar>, ILkpCalendarRepo
  {
      private SchoolDbContext _db;

      public LkpCalendarRepo(SchoolDbContext schoolDbContext): base(schoolDbContext)
      {
          _db = schoolDbContext;
      }

      public List<LkpCalendar> GetAllLkpCalendar()
      {
          var result = _db.LkpCalendars.ToList();
          return result;
      }

  }
}
