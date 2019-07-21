using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;

namespace Persistence.FinancialRepo
{
    public class PaymentRepo : DbOperation<Payment>, IPaymentRepo
    {
        private SchoolDbContext _db;

        public PaymentRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}