using Core.IStud;
using Domain;
using Domain.Model.Stud;

namespace Persistence.StudRepo
{
    public class StudParentRepo:DbOperation<StudParent>, IStudParentRepo
    {
        private SchoolDbContext _db;

        public StudParentRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}