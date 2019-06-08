using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.AddLookups;
using School.ServiceLayer.Services.AddLookupServices;

namespace School.Controllers.AddLookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpSchoolController : ControllerBase
    {
        private LkpSchoolService _lkpSchoolService;

        public LkpSchoolController(LkpSchoolService lkpSchoolService)
        {
            _lkpSchoolService = lkpSchoolService;
        }

        public Task<List<LkpSchoolVw>> Get()
        {
            var result = _lkpSchoolService.GetAll();
            return result;
        }
    }
}