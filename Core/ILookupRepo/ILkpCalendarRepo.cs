
using System.Collections.Generic;
using Domain.Model.Lookups;


namespace Core.ILookupRepo
{
    public interface ILkpCalendarRepo:IRepo<LkpCalendar>
    {
        List<LkpCalendar> GetAllLkpCalendar();
    }
}