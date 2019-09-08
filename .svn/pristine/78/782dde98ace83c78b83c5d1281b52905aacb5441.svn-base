using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.Financial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Financial;
using School.ServiceLayer.Services.FinancialServices;

namespace School.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinItemController : ControllerBase
    {
        private FinItemService _service;

        public FinItemController(FinItemService service)
        {
            _service = service;
        }


        // GET: api/FinItem
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



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _service.GetById(id);
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
        public void add(FinItem obj)
        {
            try
            {
                _service.Add(obj);

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
                _service.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        [HttpPut("{id}")]
        public void Update(int id, FinItemVw obj)
        {
            _service.Update(id, obj);
        }

    }
}
