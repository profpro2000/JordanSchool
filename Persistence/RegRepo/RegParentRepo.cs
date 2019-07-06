
using Core.IRegRepo;
using Domain;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Persistence.RegRepo
{
    public class RegParentRepo:DbOperation<RegParent>, IRegParentRepo
    {
        private SchoolDbContext _db;

        public RegParentRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<RegParent>> GetAll()
        {
            return await _db.RegParents
                .Include(t=>t.NationalityLookup)
                .Include(t=>t.ReligionLookup)
                .Include(t=>t.CityLookup)
                .Include(t=>t.FatherEducationLookup)
                .Include(t=>t.MatherEducationLookup)
                .Include(t=>t.ParentRelationLookup)
                .ToListAsync();

        }

        public async Task<IEnumerable<object>> ParentDetail(int id)
        {
            var parent = _db.RegParents.Where(p=>p.Id==id).Select(p => new
            {
                p.Id,
                p.IdNum,
                FatherName = p.FirstName + " " + p.SecondName + " " + p.FamilyName,
                FatherLName = p.FirstLName + " " + p.SecondLName + " " + p.FamilyLName,
                p.MotherName,
                p.ReligionId,
                ReligionName = p.ReligionLookup.AName,
                p.NationalityId,
                NationalityName=p.NationalityLookup.AName,
                p.CityId,
                CityName=p.CityLookup.AName,
                p.Locality1,
                p.Locality2,
                p.Address,
                p.Street,
                p.BuildingNo,
                p.FatherEducationId,
                FatherEducation=p.FatherEducationLookup.AName,
                p.FatherSpec,
                p.MatherEducationId,
                MatherEducation=p.MatherEducationLookup.AName,
                p.MatherSpec,
                p.ParentRelationId,
                ParentRelation=p.ParentRelationLookup.AName,
                p.ParentName,
                p.ParentWork,
                p.FamilySize,
                p.FamilyIncome,
                p.FamilyAssistance,
                p.RefugeeCardNo,
                p.Tel,
                p.FatherMobile,
                p.MotherMobile,
                p.SmsParent,
                p.SmsMobile,
                p.ParentEmail,
                p.ParentFace,
                p.Note
            }) ; 

            return parent;
        }
    }
}