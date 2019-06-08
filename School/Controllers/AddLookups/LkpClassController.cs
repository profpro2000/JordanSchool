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
    public class LkpClassController : ControllerBase
    {
        private LkpClassService _service;

        public LkpClassController(LkpClassService service)
        {
            _service = service;
        }

        // GET: api/LkpClass
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAll();
            if (!result.Any())
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // GET: api/LkpClass/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetById(id);
            if (!result.Any())
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // POST: api/LkpClass
        [HttpPost]
        public async Task<IActionResult> Post(LkpClassVw obj)
        {

            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", obj));
            }
            _service.Insert(obj);
            return Ok(new Res(true, "Complite", await _service.GetAll()));
        }

        // PUT: api/LkpClass/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, LkpClassVw obj)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", obj));
            }
            _service.Update(id, obj);
            return Ok(new Res(true, "Complite", _service.GetAll()));
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
