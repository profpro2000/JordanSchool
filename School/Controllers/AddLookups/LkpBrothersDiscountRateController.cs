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
    public class LkpBrothersDiscountRateController : ControllerBase
    {

        private LkpBrothersDiscountRateService _service;

        public LkpBrothersDiscountRateController(LkpBrothersDiscountRateService service)
        {
            _service = service;
        }

        // GET: api/LkpBrothersDiscountRate
        [HttpGet]
        public async Task<List<LkpBrothersDiscountRateVw>> Get()
        {
            return await _service.GetAll();
        }

        // GET: api/LkpBrothersDiscountRate/5
        [HttpGet("{id}")]
        public LkpBrothersDiscountRateVw GetById(int Id)
        {
            return _service.GetById(Id);
        }

        // POST: api/LkpBrothersDiscountRate
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LkpBrothersDiscountRate/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
