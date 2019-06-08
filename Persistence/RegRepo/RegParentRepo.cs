
using Core.IRegRepo;
using Domain;
using Domain.Model.Reg;

namespace Persistence.RegRepo
{
    public class RegParentRepo:DbOperation<RegParent>, IRegParentRepo
    {
        private SchoolDbContext _db;

        public RegParentRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}