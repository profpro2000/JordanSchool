using Core.IAdmStudRepo;
using Domain;
using Domain.Model.Adm;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            var _tourPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.TourPrice);
            var _classPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.ClassPrice);
            var _totalPrice = _tourPrice + _classPrice;

            var parent = _db.RegParents.Where(x => x.Id == id).Select(p => new {
                p.Id,
                FatherFullName = p.FirstName + " " + p.SecondName + " " + p.FamilyName,
                FatherFirstName = p.FirstName,
                FatherSecondName = p.SecondName,
                FatherFamilyName = p.FamilyName,
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
                p.ParentEmail,
                ParentTotalPrice= _totalPrice

            });//.FirstOrDefault() ;

            return parent;
        }

        public async Task<IEnumerable<object>> GetRegChildrens(int id)
        {
            var data = _db.AdmStuds.Where(p => p.ParentId == id).Select(x => new
            {
                x.Id,
                x.FirstName,
                x.BirthDate,
                x.GenderId,
                x.YearId,
                GenderName = x.Gender != null ? x.Gender.AName : "",
                ClassName = x.Class != null ? x.Class.Aname : "",
                ClassPrice = x.Class != null ? x.Class.Amt : 0,
                ClassYear = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Id :0 :0,
                ClassActive = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Active:0 :0,
                ClassSeqName = x.ClassSeq != null ? x.ClassSeq.AName:"",
                TourName = x.Tour != null ? x.Tour.TourName : "",
                TourTypeName= x.TourType != null ?  x.TourType.AName : "",          
                TourPrice =x.TourType != null ? int.Parse(x.TourType.Value)==3 ?
                x.Tour.TourFullPrice:x.Tour.TourHalfPrice : 0,
            });//.Where(p=>p.ClassActive == 1) ;
           
            var result = data.Select(x => new
            {
                x.Id,
                x.FirstName,
                x.BirthDate,
                x.GenderId,
                x.GenderName,
                x.YearId,
                x.ClassName,
                x.ClassPrice,
                x.ClassYear,
                x.ClassActive,
                x.ClassSeqName,
                x.TourName,
                x.TourTypeName,
                x.TourPrice,
                TotalPrice = x.ClassPrice + x.TourPrice

            }) ;
            /*int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1
            */
            return result;

        }
    }
}
