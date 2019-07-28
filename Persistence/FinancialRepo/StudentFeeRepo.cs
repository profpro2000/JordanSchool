using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<object>> GetStudFeesListByParent(int ParentId)
        {
           // IList<ToDoItem> items = new List<ToDoItem>();
            IList<ToDoItem> xList= new List<ToDoItem>();
            try
            {
                 xList =  _db.AdmStuds.Where(p => p.ParentId == ParentId).Select(x => new ToDoItem()
                 {
                    StudentId = x.Id,
                    StudentName = _db.AdmStuds.Where(c => c.Id == x.Id).Select(cc => cc.FirstName).FirstOrDefault(),
                    YearId = x.YearId,
                    Db = _db.StudentFees.Where(p => p.StudentId == x.Id).Sum(xx => xx.Db),
                    Cr = _db.StudentFees.Where(p => p.StudentId == x.Id).Sum(xx => xx.Cr),
                    Total = _db.StudentFees.Where(p => p.StudentId == x.Id).Sum(xx => xx.Db) -
                     _db.StudentFees.Where(p => p.StudentId == x.Id).Sum(xx => xx.Cr),

                 }).ToList() ;
            }
            catch(Exception e) { }
            return xList;
        }


        class ToDoItem
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int? YearId { get; set; }
            public int? Db { get; set; }
            public int? Cr { get; set; }
            public int? Total { get; set; }
        }
    }
}
