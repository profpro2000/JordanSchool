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
    public class SchoolFeeRepo : DbOperation<SchoolFee>, ISchoolFeeRepo
    {
        private SchoolDbContext _db;

        public SchoolFeeRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<SchoolFee>> GetAll()
        {
            return await _db.SchoolFees
                .Include(t => t.school)
                .Include(t => t.Year)
                .Include(t => t.FinItem)
                .ToListAsync();
        }
    }
}
