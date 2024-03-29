﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Financial;

namespace Core.IFinancial
{
    public interface IStudentFeeRepo:IRepo<StudentFee>
    {

        Task<IEnumerable<object>> GetStudFeesListByParent(int YearId, int ParentId);
        Task<IEnumerable<object>> GetStudFeesDtl(int yearId, int StudId);
        Task<IEnumerable<object>> GetChequesListByFeeId(int StudentFeeId);
     


    }
}
