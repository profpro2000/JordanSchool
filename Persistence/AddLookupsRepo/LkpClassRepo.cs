using Core.IAddLookupsRepo;
using Domain;
using Domain.Model.AddLookups;
using Microsoft.EntityFrameworkCore;
using Model.AddLookups;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.AddLookupsRepo
{
    public class LkpClassRepo : DbOperation<LkpClass>, ILkpClassRepo
    {
        private SchoolDbContext _db;

        public LkpClassRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetClassBySchool(int schoolId)
        {
            // return await _db.LkpClasses.Where(p=>p.SchoolId==schoolId).Include(p => p.LkpSection).ToListAsync();
            var currentYEar = _db.LkpYears.Where(p => p.Active == 1).Select(p=>p.Id).FirstOrDefault();
            var result = _db.LkpClasses.Where(p => p.SchoolId == schoolId).Include(p => p.LkpSection).Select(x => new
            {
                Id = x.Id,
                SectionId = x.SectionId,
                SectionName = x.LkpSection.SectionName,// _db.LkpSections.Where(xx => xx.Id == x.SectionId).Select(xxx => xxx.Id).FirstOrDefault(),
                SchoolId = x.SchoolId,
                Aname = x.Aname,
                Lname = x.Lname,
                Capacity = x.Capacity,
                Age = x.Age,
                ClassFees = x.LkpClassFees.Where(xx => xx.ClassId == x.Id && xx.YearId == currentYEar).LastOrDefault(),
                ClassGender= x.ClassGender != null ? x.ClassGender : 0

            }).ToList();

            var values = result.Select(x => new
            {
                Id = x.Id,
                SectionId = x.SectionId,
                SectionName = x.SectionName,// _db.LkpSections.Where(xx => xx.Id == x.SectionId).Select(xxx => xxx.Id).FirstOrDefault(),
                SchoolId = x.SchoolId,
                Aname = x.Aname,
                Lname = x.Lname,
                Capacity = x.Capacity,
                Age = x.Age,
                ClassFees=x.ClassFees!=null? x.ClassFees.ClassFees+"":null,
                x.ClassGender
            }).ToList();

            return values;
        }




        public async Task<IEnumerable<object>> GetClassBySection(int sectionId)
        {
            //  var currentYear = _db.LkpYears.Where(p => p.Active == 1).Select(p => p.Id).FirstOrDefault();
            var result = _db.LkpClasses.Where(p => p.SectionId == sectionId).Select(x => new
            {
                Id=x.Id,
               Aname= x.Aname
            }).ToList();

            return result;
        }
    }
}