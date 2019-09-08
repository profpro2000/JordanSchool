using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.Lookups;
using Microsoft.AspNetCore.Mvc;
using Model.Lookups;
using School.ServiceLayer.Services.LookupsServices;

namespace School.Controllers.Lookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpItemCalendarController : ControllerBase
    {
        private LkpItemCalendarService _lkpItemCalendarService;

        public LkpItemCalendarController(LkpItemCalendarService lkpItemCalendarService)
        {
            _lkpItemCalendarService = lkpItemCalendarService;
        }

        [HttpGet("List")]
        public Task<List<LkpItemCalendarVw>> GetList()
        {
            var result = _lkpItemCalendarService.Get();
            return result;
        }
        [HttpGet]
        public async Task<List<LkpItemCalendarVw>> GetAllLkpCalendar()
        {
            var result = await _lkpItemCalendarService.GetAllLkpCalendar();
            return result;
        }

        [HttpPost]
        public void Add(LkpItemCalendar obj)
        {
            _lkpItemCalendarService.Add(obj);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _lkpItemCalendarService.Delete(id);
        }
    }
}