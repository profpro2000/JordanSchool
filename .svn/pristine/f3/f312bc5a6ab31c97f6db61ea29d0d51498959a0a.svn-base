using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.AddLookups;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.AddLookups;
using School.ServiceLayer.Services.AddLookupServices;

namespace School.Controllers.AddLookups
{
    [Route("api/[controller]")]
    [ApiController]
    public class LkpSchoolController : ControllerBase
    {
        private LkpSchoolService _lkpSchoolService;

        public LkpSchoolController(LkpSchoolService lkpSchoolService)
        {
            _lkpSchoolService = lkpSchoolService;
        }

        public async Task<IEnumerable<LkpSchoolVw>> Get()
        {
             var result = await _lkpSchoolService.GetAll();
           // var result = await  _lkpSchoolService.getTest();
            return result;
        }

        [HttpGet("Test")]
        public LkpSchoolVw GetTest()
        {
            var result = _lkpSchoolService.getTest2();
            return result;
        }

        [HttpGet("Test3")]
        public async Task<IEnumerable<object>> GetTest3()
        {
            var result = await _lkpSchoolService.getTest3();
            return result;
        }

        [HttpGet("{id}")]
        public LkpSchoolVw GetById(int id)
        {
            var result = _lkpSchoolService.GetById(id);
            return  result;
        }

        [HttpPost]
        public  void Add(LkpSchoolVw obj)
        {
            _lkpSchoolService.Insert(obj);
        }

        [HttpPut("{id}")]
        public void Update(int id, LkpSchoolVw obj)
        {
            _lkpSchoolService.Update(id,obj);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _lkpSchoolService.Delete(id);
        }
    }
}