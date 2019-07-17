using Core.IAdmStudRepo;
using Domain;
using Domain.Model.Adm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Persistence.AdmRepo
{
 public   class AdmStudRepo: DbOperation<AdmStud>, IAdmStudRepo
    {

        private readonly SchoolDbContext _db;

        public AdmStudRepo(SchoolDbContext db):base(db)
        {
            _db = db;
        }

        public async Task<List<AdmStud>> GetAllStud()
        {
            return await _db.AdmStuds.Include(r => r.Parent).ToListAsync();
        }
        public async Task<List<AdmStud>> GetStudByParent(int id)
        {
            return await _db.AdmStuds.Where(x=>x.ParentId==id).Include(r => r.Parent).ToListAsync();
        }

        public object GetParentName(int id)
        {
            //return  _db.AdmStuds.Where(x => x.ParentId == id).Include(r => r.Parent).FirstOrDefault();
            var parent= _db.RegParents.Where(x => x.Id == id).Select(p => new {
                p.Id,
                FatherFullName = p.FirstName + " " + p.SecondName + " " + p.FamilyName,
                FatherFirstName=p.FirstName,
                FatherSecondName=p.SecondName,
                FatherFamilyName=p.FamilyName,
                ReligionName = p.ReligionLookup.AName,
                NationalityName = p.NationalityLookup.AName,
                CityName = p.CityLookup.AName,
                p.Locality1,
                p.Locality2,
                p.Address,
                p.Street,
                p.BuildingNo,
                p.Tel,
                p.FatherMobile,
                p.MotherMobile,
                p.SmsParent,
                p.SmsMobile,
                p.ParentEmail
            }) ;

            return parent;
        }

    }
}
