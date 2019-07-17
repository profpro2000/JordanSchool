using Core.IRegRepo;
using Domain;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace Persistence.RegRepo
{
    public class RegStudRepo:DbOperation<RegStud>, IRegStudRepo
    {
        private SchoolDbContext _db;

        public RegStudRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }

        public async Task<List<RegStud>> StudList()
        {
            return await _db.RegStuds.Include(r => r.RegParent).ToListAsync();
        }
    }
}