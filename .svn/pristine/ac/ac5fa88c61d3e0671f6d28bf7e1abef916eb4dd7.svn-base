using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Domain.Model.Financial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Financial;
using School.ServiceLayer.Services.FinancialServices;

namespace School.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private PaymentService _service;

        public PaymentController(PaymentService service)
        {
            _service = service;
        }


        /*
               // GET: api/Payment
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




                 [HttpGet("GetByParenetIdYearId/{parentId}/{yearId}")]
                  public IActionResult GetByParenetIdYearId(int parentId, int yearId)
                  {
                      try
                      {
                          var result = _service.GetByParenetIdYearId(parentId, yearId);
                          if (result == null)
                              return NotFound("No Data Found");
                          return Ok(result);
                      }
                      catch (Exception ex)
                      {
                          throw ex;
                      }
                  }


                  [HttpGet("GetParentSummaryFeesByYear/{parentId}/{yearId}")]
                  public IActionResult GetParentSummaryFeesByYear(int parentId, int yearId)
                  {
                      try
                      {
                          var result = _service.GetParentSummaryFeesByYear(parentId, yearId);
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
                  public void add(Payment obj)
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
                  public async Task<IActionResult> Put(int id, PaymentVw obj)
                  {

                      if (!ModelState.IsValid)
                      {
                          Response.StatusCode = 400;
                          return Ok(new Res(false, "State not valid", obj));
                      }
                      _service.Update(id, obj);
                      return Ok(new Res(true, "Complite", await _service.GetAll()));
                  }*/

    }
}
