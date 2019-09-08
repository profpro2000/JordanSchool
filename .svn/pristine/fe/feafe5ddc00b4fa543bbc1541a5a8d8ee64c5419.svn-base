using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.AddLookups;
using School.ServiceLayer.Services.AddLookupServices;

namespace School.Controllers.AddLookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpClassFeesController : ControllerBase
    {

        private LkpClassFeesService _service;

        public LkpClassFeesController(LkpClassFeesService service)
        {
            _service = service;
        }

        // GET: api/LkpClassFees
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAll();
            if (!result.Any())
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // GET: api/LkpClassFees/5 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _service.GetById(id);
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("GetByPriceByClassId/{id}/{YearId}")]
        public IActionResult GetByPriceByClassId(int id, int YearId)
        {
            var result = _service.GetByPriceByClassId(id,YearId);
           // if (result == null)
           // { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // POST: api/LkpClassFees
        [HttpPost]
        public async Task<IActionResult> Post(LkpClassFeesVw obj)
        {

            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", obj));
            }
            _service.Insert(obj);
            return Ok(new Res(true, "Complite", await _service.GetAll()));
        }

        // PUT: api/LkpClassFees/5
        [HttpPut("{id}")]
        public void Put(int id, LkpClassFeesVw obj)
        {

            _service.Update(id, obj);
            //  return Ok(new Res(true, "Complite", _service.GetAll()));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", null));
            }
            _service.Delete(id);
            return Accepted();
        }
    }
}
