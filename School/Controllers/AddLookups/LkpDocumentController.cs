using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Lookups;
using School.ServiceLayer.Services.AddLookupServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers.AddLookups
{
    [Route("api/[controller]")]
    public class LkpDocumentController : Controller
    {

        LkpDocumentService _Service;

        public LkpDocumentController(LkpDocumentService Service)
        {
            _Service = Service;
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<List<LkpDocumentVw>> Get()
        {
            var v1 = await _Service.GetAll();
            return  v1;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
