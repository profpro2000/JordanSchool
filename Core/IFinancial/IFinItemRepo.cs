using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Financial;

namespace Core.IFinancial
{
    public interface IFinItemRepo:IRepo<FinItem>
    {

        Task<List<FinItem>> GetAll();
    }
}
