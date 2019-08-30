using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Model.AddLookups;
using School.ServiceLayer.Services.AddLookupServices;

namespace School.Controllers.AddLookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpSectionController : ControllerBase
    {
        private LkpSectionService _lkpSectionService;

        public LkpSectionController(LkpSectionService lkpSectionService)
        {
            _lkpSectionService = lkpSectionService;
        }
        // GET: api/LkpSection
        [HttpGet]
        public  IEnumerable<LkpSectionVw> Get()
        {
            return  _lkpSectionService.GetAll();
        }

        // GET: api/LkpSection/5  
        [HttpGet("{id}")]
        public LkpSectionVw Get(int id)
        {
            return _lkpSectionService.GetById(id);
        }

        [HttpGet("GetSectionBySchool/{schoolId}")]
        public List<LkpSectionVw> GetSectionBySchool(int schoolId)
        {
            return _lkpSectionService.GetSectionBySchool(schoolId);
        }

        // POST: api/LkpSection
        [HttpPost]
        public async Task<IActionResult> Post(LkpSectionVw obj)
        {
           /* try
            {
                if (!ModelState.IsValid)
                {
                    Response.StatusCode = 400;
                    var xx = Json(new Res(isDone: false, message: "sssss", obj));
                    return Json(new Res(false, "State not valid", obj));
                }*/
                 _lkpSectionService.Insert(obj);
                 return Ok(_lkpSectionService.GetAll());

                 /* }
                  catch (Exception e)
                  {
                      Console.WriteLine(e);
                      throw;
                  }*/

        }

        // PUT: api/LkpSection/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, LkpSectionVw obj)
        {
            _lkpSectionService.Update(id,obj);
            return Ok(_lkpSectionService.GetById(id));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _lkpSectionService.Delete(id);
            return Accepted();
        }
    }
}
