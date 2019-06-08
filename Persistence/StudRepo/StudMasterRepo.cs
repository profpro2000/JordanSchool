using Core.IStudRepo;
using Domain;
using Domain.Model.Stud;
using Microsoft.EntityFrameworkCore;
using  Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.StudRepo
{
    public class StudMasterRepo:DbOperation<StudMaster>, IStudMasterRepo
    {
        private SchoolDbContext _db;

        public StudMasterRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }
    }
}