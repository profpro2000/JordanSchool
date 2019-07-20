using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.Lookups;
using Microsoft.AspNetCore.Mvc;
using MiddlewareAndServices.Filters;
using MiddlewareAndServices.Helper;
using Model.Lookups;
using School.ServiceLayer.Services.LookupsServices;


namespace School.Controllers.Lookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpLookupController : ControllerBase
    {
        private LkpLookupService _lookupService;

        public LkpLookupController(LkpLookupService lkpLookupService)
        {
            _lookupService = lkpLookupService;
        }

        public Task<List<LkpLookupVw>> GetAll()
        {
            var result = _lookupService.GetAll();
           
            return result;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _lookupService.GetById(id);
                if (result == null)
                    return NotFound("No Data Found");
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetByParentId/{id}")]
        public async Task<List<LkpLookupVw>> GetByParentId(int id)
        {
            var result = await _lookupService.GetByParentId(id);
            
            return result;
        }

        [HttpPost("GetListByType")]
        public async Task<IEnumerable<LkpLookupVw>> GetByListType(LookupTypes id)
        {
              var result = await _lookupService.GetByListType(id);

           

            return await _lookupService.GetByListType(id);
        }
        

        [HttpPost("GetLookups")]
        public async Task<IEnumerable<LkpLookupVw>> GetLookups([FromBody] FilterLookupsType filter)
        {
            var result = await _lookupService.GetByListType2(filter);



            return result;
        }

        [HttpPost]
        public void Add(LkpLookup obj)
        {
            _lookupService.Add(obj);
        }

        [HttpPut("{id}")]
        public void Update(int id, LkpLookup obj)
        {
            _lookupService.Update(id,obj);
        }

        [HttpDelete("{id}")]
       /* public void Delete(int id)
        {
            _lookupService.Delete(id);
        }
        */
        public async Task<IActionResult> Delete(int id)
       {

           try
           {
               _lookupService.Delete(id);
            }
           catch (Exception e)
           {
               
               Console.WriteLine(e);
               throw;
           }
          
            return NoContent();
        }
    }
}