using Domain.Model.Reg;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRegRepo
{
 public   interface IYearlyStudRegRepo:IRepo<YearlyStudReg>
    {

        Task<IEnumerable<object>> GetParentChildrens(int id);
       // Task<IEnumerable<YearlyStudReg>> ConfirmStudReg2(int id, int PYearId);
        int ConfirmStudReg(int id, int PYearId, int oldClassId, int newClassId);

    }

   
}
