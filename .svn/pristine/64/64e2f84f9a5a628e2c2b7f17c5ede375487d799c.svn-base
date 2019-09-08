using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model.Lookups;
using Microsoft.AspNetCore.Mvc;
using Model.Lookups;
using School.ServiceLayer.Services.LookupsServices;

namespace School.Controllers.Lookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpLookupTypeController : ControllerBase
    {
        private LkpLookupTypeService _lkpLookupTypeService;

        public LkpLookupTypeController(LkpLookupTypeService lkpLookupTypeService)
        {
            _lkpLookupTypeService = lkpLookupTypeService;
        }

        [HttpGet]
        public  async Task<IEnumerable<LkpLookupTypeVw>> GetAllWithChildren()
        {
            try
            {
                var result = await _lkpLookupTypeService.GetAllWithChildren();
                return result;
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
        [HttpGet("List")]
        public async Task<IEnumerable<LkpLookupTypeVw>> GetList()
        {
            try
            {
                var result = await _lkpLookupTypeService.GetList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _lkpLookupTypeService.GetById(id);
                if (result == null)
                    return NotFound("No Data Found");
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public void add(LkpLookupType obj)
        {
            try
            {
                _lkpLookupTypeService.Add(obj);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
             
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _lkpLookupTypeService.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}