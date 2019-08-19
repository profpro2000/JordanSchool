using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Model.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class PaymentChequeService
    {

        private IMapper _mapper;
        private IPaymentChequeRepo _interface;

        public PaymentChequeService(IMapper mapper, IPaymentChequeRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<PaymentChequeVw>> GetByPaymentId(int PaymentId)
        {
            var v = _interface.GetByPaymentId(PaymentId);
            var result = _mapper.Map<List<PaymentChequeVw>>(v);
            return result;
        }


        public async Task<List<PaymentChequeVw>> GetAll()
        {
            var vw = await _interface.GetAll();
            var result = _mapper.Map<List<PaymentChequeVw>>(vw);
            return result;
        }

    }
}
