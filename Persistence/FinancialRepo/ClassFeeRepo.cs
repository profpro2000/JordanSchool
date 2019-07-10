using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;

namespace Persistence.FinancialRepo
{
   public class ClassFeeRepo: DbOperation<ClassFee>,IClassFeeRepo
    {
        private SchoolDbContext _db;

        public ClassFeeRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}
