using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.ServiceLayer.Services.AdmServices;
//test 0000123456
namespace School.Controllers.Adm
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmStudController : ControllerBase
    {


        private AdmStudService _service;

        public AdmStudController(AdmStudService service)
        {
            _service = service;
        }






        // GET: api/AdmStud
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





        // GET: api/AdmStud/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AdmStud
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/AdmStud/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
