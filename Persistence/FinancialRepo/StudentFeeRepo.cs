using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;

namespace Persistence.FinancialRepo
{
   public class StudentFeeRepo:DbOperation<StudentFee>,IStudentFeeRepo
    {
        private SchoolDbContext _db;

        public StudentFeeRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}
