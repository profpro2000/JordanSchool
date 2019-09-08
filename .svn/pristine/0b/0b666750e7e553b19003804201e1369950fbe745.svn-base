using Core.IFinancial;
using Domain;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Model.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.FinancialRepo
{
    public class PaymentChequeRepo : DbOperation<PaymentCheque>, IPaymentChequeRepo
    {
        private SchoolDbContext _db;

        public PaymentChequeRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        
        public async Task<List<PaymentCheque>> GetAll()
        {
            var v =await  _db.PaymentCheques.ToListAsync();
            return v;
        }

      /*  public async Task<List<PaymentCheque>> GetByStudentFeetId(int StudenFeeId)
        {
            var pamentChequevar = await _db.PaymentCheques.Where(x => x.StudentFeeId == StudenFeeId).ToListAsync();
            return pamentChequevar;
        }*/
    }
}
