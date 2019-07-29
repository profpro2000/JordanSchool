using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;

namespace Persistence.FinancialRepo
{
    public class PaymentRepo : DbOperation<Payment>, IPaymentRepo
    {
        private SchoolDbContext _db;

        public PaymentRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Payment>> GetAll()
        {
            return await _db.Payments
                .Include(t => t.RegParent)
                .Include(t => t.VoucherType)
                .Include(t => t.VoucherStatus)
                .Include(t => t.Year)
                .ToListAsync();
        }

    }
}