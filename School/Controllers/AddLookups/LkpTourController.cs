using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Helpers;
using Core;
using Microsoft.AspNetCore.Mvc;
using Model.AddLookups;
using School.ServiceLayer.Services.AddLookupServices;




namespace School.Controllers.AddLookups
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LkpTourController : ControllerBase
    {
        private LkpTourService _lkpTourService;

        public LkpTourController(LkpTourService lkpTourService)
        {
            _lkpTourService = lkpTourService;
        }


        // GET: api/LkpTour
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result= await _lkpTourService.GetAll();
            if (!result.Any())
            { return NotFound("No Data Found");}
            return Ok(result);
        }

        // GET: api/LkpTour/5
        [HttpGet("{id}")]
        public async  Task<IActionResult> Get(int id)
        {
            var result = await _lkpTourService.GetById(id);
            if (!result.Any())
            { return NotFound("No Data Found");}
            return Ok(result);
        }
        
        // POST: api/LkpTour
        [HttpPost]
        public async  Task<IActionResult> Post(LkpTourVw obj)
        {
            if (!ModelState.IsValid)
            {
             Response.StatusCode = 400;
             return Ok(new Res(false, "State not valid", obj));
            }
            _lkpTourService.Insert(obj);
            return Ok(new Res(true, "Complite", await _lkpTourService.GetAll()));
           
        }

        // PUT: api/LkpTour/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, LkpTourVw obj)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    Response.StatusCode = 400;
                    return Ok(new Res(false, "State not valid", obj));
                }
                _lkpTourService.Update(id, obj);
                return Ok(new Res(true,"Complite", await _lkpTourService.GetAll()));

            }
            catch (Exception e)
            {
               // Console.WriteLine(e);
                // return not
               // Response.StatusCode = 400;
              //  return Ok(new Res(false, "State not valid", obj));
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
            _lkpTourService.Delete(id);
            return Accepted();
        }
    }
}
