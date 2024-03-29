﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.IFinancial;
using Domain;
using Domain.Model.Financial;
using Microsoft.EntityFrameworkCore;
using Model.Financial;

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
                    Db = _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Debit),
                    Cr = _db.StudentFees.Where(p => p.StudentId == x.Id && p.YearId == YearId).Sum(xx => xx.Credit),
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
                    Db = x.Debit,
                    Cr = x.Credit
                }).ToList();
            }
            catch (Exception e) { }
            return xList;
        }


        public async Task<IEnumerable<object>> GetChequesListByFeeId(int StudentFeeId)
        {
            return await _db.PaymentCheques.Where(p => p.StudentFeeId == StudentFeeId).ToListAsync();


        }
    }
    }
