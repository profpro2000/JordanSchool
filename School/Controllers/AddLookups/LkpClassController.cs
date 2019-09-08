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
        public IActionResult Get(int id)
        {
            var result =  _service.GetById(id);
            if (result==null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("GetClassBySchool/{schoolId}")]
        public async Task<IEnumerable<object>> GetClassBySchool(int schoolId)
        {
            var result = await _service.GetClassBySchool(schoolId);
            //if (!result.Any())
           // { return NotFound("No Data Found"); }
            return result;
        }


        [HttpGet("GetClassBySection/{sectionId}")]
        public async Task<IEnumerable<object>> GetClassBySection(int sectionId)
        {
            var result = await _service.GetClassBySection(sectionId);
            //if (!result.Any())
            // { return NotFound("No Data Found"); }
            return result;
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
        public void Put(int id, LkpClassVw obj)
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
