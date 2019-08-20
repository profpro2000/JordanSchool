using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.ServiceLayer.Services.FinancialServices;

namespace School.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentChequeController : ControllerBase
    {

       private  PaymentChequeService _servcie;

        public PaymentChequeController(PaymentChequeService servcie)
        {
            _servcie = servcie;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _servcie.GetAll();
            if (result == null)
                return NotFound("No Data Found");
            return Ok(result);
        }

        [HttpGet("GetByPayementId/{paymentId}")]
        public   IActionResult GetByPayementId(int paymentId)
        {

            try
            {
                var result = _servcie.GetByPaymentId(paymentId);
                if (result == null)
                    return NotFound("No Data Found");
                return Ok(result);
            }

            catch(Exception e)
            {
                throw e;
            }
        }
    }
}