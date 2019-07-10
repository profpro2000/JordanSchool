using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;

namespace Persistence.FinancialRepo
{
   public class FinItemRepo:DbOperation<FinItem>,IFinItemRepo
    {
        private SchoolDbContext _db;

        public FinItemRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}
