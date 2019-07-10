using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;

namespace Persistence.FinancialRepo
{
    class SchoolFeeRepo:DbOperation<SchoolFee>,ISchoolFeeRepo
    {
        private SchoolDbContext _db;

        public SchoolFeeRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}
