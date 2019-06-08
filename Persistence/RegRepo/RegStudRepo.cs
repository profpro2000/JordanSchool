using Core.IRegRepo;
using Domain;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.RegRepo
{
    public class RegStudRepo:DbOperation<RegStud>, IRegStudRepo
    {
        private SchoolDbContext _db;

        public RegStudRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}