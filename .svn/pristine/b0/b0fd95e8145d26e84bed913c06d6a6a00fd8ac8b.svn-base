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
    public class LkpYearController : ControllerBase
    {


        private LkpYearService _lkpYearService;

        public LkpYearController(LkpYearService lkpYearService)
        {
            _lkpYearService = lkpYearService;
        }

        // GET: api/LkpYear
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _lkpYearService.GetAll();
            if (!result.Any())
            { return NotFound("No Data Found"); }
            return Ok(result);
        }


        // GET: api/LkpYear/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _lkpYearService.GetById(id);
            if (result==null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("CurrentYear")]
        public async Task<IActionResult> GetCurrentYear()
        {
            var result = await _lkpYearService.GetCurrentYear();
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // POST: api/LkpYear
        [HttpPost]
        public async Task<IActionResult> Post(LkpYearVw obj)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", obj));
            }
            _lkpYearService.Insert(obj);
            return Ok(new Res(true, "Complite", await _lkpYearService.GetAll()));

        }

        // PUT: api/LkpYear/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, LkpYearVw obj)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    Response.StatusCode = 400;
                    return Ok(new Res(false, "State not valid", obj));
                }
                _lkpYearService.Update(id, obj);
                return Ok(new Res(true, "Complite", await _lkpYearService.GetAll()));

            }
            catch (Exception e)
            {
                    throw e;
            }

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
            _lkpYearService.Delete(id);
            return Accepted();
        }
    }
}
