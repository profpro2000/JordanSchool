using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.Reg;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.ServiceLayer.Services.RegServices;

namespace School.Controllers.Reg
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearlyStudRegController : ControllerBase
    {

        private YearlyStudRegService _service;

        public YearlyStudRegController(YearlyStudRegService service)
        {
            _service = service;
        }


        // GET: api/YearlyStudReg
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var result = await _service.GetAll();
            if (!result.Any())
            {
                return NotFound("No Data Found");
            }

            return Ok(result);
        }

        // GET: api/YearlyStudReg/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetById(id);
            if (result == null)
            {
                return NotFound("No Data Found");
            }

            return Ok(result);
        }
        [HttpGet("GetParentChildrens/{id}")]
        public async Task<IActionResult> GetParentChildrens(int id)
        {
            var result = await _service.GetParentChildrens(id);
            if (result == null)
            {
                return NotFound("No Data Found");
            }

            return Ok(result);
        }
        // POST: api/YearlyStudReg
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/YearlyStudReg/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("ConfirmStudReg/{id}/{PYearId}/{oldClass}/{newClass}")]
        public int ConfirmStudReg(int id, int PYearId, int oldClass, int newClass)
        {
          return _service.ConfirmStudReg(id, PYearId, oldClass, newClass);
           
        }
    }
}
