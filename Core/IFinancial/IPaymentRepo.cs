using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Financial;

namespace Core.IFinancial
{
  public   interface IPaymentRepo:IRepo<Payment>
    {

        Task<List<Payment>> GetAll();
        Task<IEnumerable<object>> GetByParenetIdYearId(int parentId,int yearId);


    }
}
