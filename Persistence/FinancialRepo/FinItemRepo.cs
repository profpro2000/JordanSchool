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
   public class FinItemRepo:DbOperation<FinItem>,IFinItemRepo
    {
        private SchoolDbContext _db;

        public FinItemRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }


        public async Task<List<FinItem>> GetAll()
        {
            return await _db.FinItems
                 .Include(t => t.cdTypeLookup)
                 .Include(t => t.vpTypeLookup)
                 .ToListAsync();
        }
    }
}
