using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Lookups;
using School.ServiceLayer.Services.LookupsServices;

namespace School.Controllers.Lookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpCalendarController : ControllerBase
    {
        private LkpCalendarService _lkpCalendarService;

        public LkpCalendarController(LkpCalendarService lkpCalendarService)
        {
            _lkpCalendarService = lkpCalendarService;
        }


        public Task<List<LkpCalendarVw>> GetAll()
        {
            var data = _lkpCalendarService.GetAll();
            return data;
        }
    }
}