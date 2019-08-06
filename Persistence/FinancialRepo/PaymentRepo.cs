using System;
using System.Collections.Generic;
using System.Linq;
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


      
        public async Task<IEnumerable<object>> GetByParenetIdYearId(int parentId, int yearId)
        {

            //var _tourPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.TourPrice);
            //var _classPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.ClassPrice);
            //var _descount = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.DescountValue);
            //var _totalPrice = _tourPrice + _classPrice;
            //var _netTotal = _tourPrice + _classPrice - _descount;
            
            var payment = _db.Payments.Where(x => (x.RegParentId == parentId || parentId == 0) && (x.YearId == yearId || yearId == 0)).Select(p => new
            {
                p.Id,
                p.RegParent.FirstLName,
                FatherFullName = p.RegParent.FirstLName + " " + p.RegParent.SecondName + " " + p.RegParent.FamilyName,
                p.VoucherDate

            });//.FirstOrDefault() ;

            return payment;


        }

        
    }
}