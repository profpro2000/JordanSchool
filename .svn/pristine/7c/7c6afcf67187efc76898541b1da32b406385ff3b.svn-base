
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.ILookupRepo;
using Domain;
using Domain.Model.Lookups;
using Microsoft.EntityFrameworkCore;
using Model.Lookups;


namespace Persistence.LookupsRepo
{
  public  class LkpItemCalendarRepo:DbOperation<LkpItemCalendar>, ILkpItemCalendarRepo
  {
      private SchoolDbContext _db;

      public LkpItemCalendarRepo(SchoolDbContext schoolDbContext) : base(schoolDbContext)
      {
          _db = schoolDbContext;
      }

      public List<LkpItemCalendar> GetItemCalendars()
      {
          var result = _db.LkpItemCalendars.ToList();
          return result;
      }

      public async Task<List<LkpItemCalendar>> GetAllLkpCalendar()
      {
          var result = await _db.LkpItemCalendars.Include(p => p.LkpCalendar).ToListAsync();
          return result;
      }

  }
}
