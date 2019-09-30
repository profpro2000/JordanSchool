using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Model.Financial;
using FinStudCard = Model.Financial.FinStudCard;

namespace Persistence.FinancialRepo
{
    public class StudentFeeRepo : DbOperation<StudentFee>, IStudentFeeRepo
    {
        private SchoolDbContext _db;

        public StudentFeeRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetStudFeesListByParent(int YearId, int ParentId)
        {
            // IList<ToDoItem> items = new List<ToDoItem>();
            IList<StudFeeDtlVw> xList = new List<StudFeeDtlVw>();
            try
            {
                xList = _db.AdmStuds.Where(p => p.ParentId == ParentId).Select(x => new StudFeeDtlVw()
                {
                    StudentId = x.Id,
                    StudentName = _db.AdmStuds.Where(c => c.Id == x.Id).Select(cc => cc.FirstName).FirstOrDefault(),
                    YearId = x.YearId,
                    Debit = _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Debit),
                    Credit = _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Credit),
                    Total = _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Debit) -
                   _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Credit),

                }).ToList();
            }
            catch (Exception e) { }
            return xList;
        }
        public async Task<IEnumerable<object>> GetStudFeesDtl(int yearId, int StudId)
        { 
            IList<StudFeeDtlVw> xList = new List<StudFeeDtlVw>();
            try
            {
                xList = _db.StudentFees.Where(p => p.YearId == yearId && p.StudentId == StudId).Select(x => new StudFeeDtlVw()
                {
                    StudentId = x.StudentId,
                    FinItemId = x.FinItemId,
                    FinItemName = _db.FinItems.Where(c => c.Id == x.FinItemId).Select(cc => cc.ArDesc).FirstOrDefault(),
                    YearId = x.YearId,
                    Debit = x.Debit,
                    Credit = x.Credit
                }).ToList();
            }
            catch (Exception e) { }
            return xList;
        }
        public async Task<IEnumerable<object>> GetStudentFeesByParam(StudentFeeFilter studentFeeFilter)
        {
            IList<StudentFeeVw> xList = new List<StudentFeeVw>();

            try
            {
                
                xList = await _db.StudentFees.Where(p => 
                (p.FinItemId == studentFeeFilter.finItemId | studentFeeFilter.finItemId == null) && 
                (p.ParentId == studentFeeFilter.parentId | studentFeeFilter.parentId ==null) &&
                (studentFeeFilter.voucherDateTo == null | p.VoucherDate <= studentFeeFilter.voucherDateTo) &&
                (studentFeeFilter.voucherDateFrom == null | p.VoucherDate >= studentFeeFilter.voucherDateFrom)&&
                (studentFeeFilter.FinItemVoucherSequenceTo == null | p.FinItemVoucherSequence <= studentFeeFilter.FinItemVoucherSequenceTo) &&
                (studentFeeFilter.FinItemVoucherSequenceFrom == null | p.FinItemVoucherSequence>= studentFeeFilter.FinItemVoucherSequenceFrom)
               ).Select(x => new StudentFeeVw()
                    {
                        FinItemId = x.FinItemId,
                        FinItemDesc=_db.FinItems.Where(c=>c.Id==x.FinItemId).Select(b=>b.ArDesc).FirstOrDefault(),
                        StudentId = x.StudentId,
                        StudentName = _db.AdmStuds.Where(c => c.Id == x.StudentId).Select(cc => cc.FirstName).FirstOrDefault(),
                        VoucherDate = x.VoucherDate,
                        Credit=x.Credit,
                        FinItemVoucherSequence = x.FinItemVoucherSequence,
                        PaymentMethodId=x.PaymentMethodId,
                        PaymentMethodDesc = _db.LkpLookups.Where(c=>c.Id==x.PaymentMethodId).Select(dd=>dd.AName).FirstOrDefault(),
                        ParentName =_db.RegParents.Where(c=>c.Id==x.ParentId).Select(ee=>ee.FirstName + " " + ee.SecondName + " " + ee.FamilyName).FirstOrDefault()
                    }).ToListAsync();
            }
            catch(Exception e)
            {

            }
            return   xList;
        }
        public async Task<IEnumerable<object>> GetPaymentList(int yearId, int StudId)
        {
            IList<StudFeeDtlVw> xList = new List<StudFeeDtlVw>();
            try
            {
                xList = _db.StudentFees.Where(p => p.PaymentMethodId > 0 && p.Credit > 0 && p.FinItemId != 9 &&
                p.YearId == yearId && p.StudentId == StudId).Select(x => new StudFeeDtlVw()
                {
                    StudentId = x.StudentId,
                    FinItemId = x.FinItemId,
                    FinItemName = _db.FinItems.Where(c => c.Id == x.FinItemId).Select(cc => cc.ArDesc).FirstOrDefault(),
                    YearId = x.YearId,
                    Debit = x.Debit,
                    Credit = x.Credit,
                    FinItemVoucherSequence = x.FinItemVoucherSequence,
                    VoucherDate = x.VoucherDate,
                    PaymentId=x.Id,
                    Note=x.Note
                    

                }).ToList();
            }
            catch (Exception e) { }
            return xList;
        }


        //public async task<ienumerable<object>> getchequeslistbyfeeid(int paymentid)
        //{
        //    return await _db.paymentcheques.where(p => p.paymentid == paymentid).tolistasync();


        //}

        public async Task<IEnumerable<object>> FinStudCard(int YearId, int ParentId)
        {
            var Vw = await  _db.FinStudCard.Where(p => p.YearId == YearId && p.ParentId == ParentId).ToListAsync();
            return Vw;
        }

        public async Task<IEnumerable<object>> FinStudCardByStud(int YearId, int StudId)
        {
            var Vw = await _db.FinStudCard.Where(p => p.YearId == YearId && p.StudentId == StudId).ToListAsync();
            return Vw;
        }

        public object getByPayemtId(int id)
        {
            var result = _db.StudentFees.Where(p => p.Id == id).Include(v=>v.Paymentcheques).FirstOrDefault();
            return result;

        }

    }
    }
