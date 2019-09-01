using Domain.Model.Financial;
using Model.Financial;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.IFinancial
{
    public interface IPaymentChequeRepo:IRepo<PaymentCheque>
    {

        Task<List<PaymentCheque>> GetAll();
     //   Task<List<PaymentCheque>> GetByStudentFeetId(int StudentFeeId);

       
    }
}
