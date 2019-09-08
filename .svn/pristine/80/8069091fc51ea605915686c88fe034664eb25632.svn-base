using Core.IAdmStudRepo;
using Domain;
using Domain.Model.Adm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.AdmRepo
{
    public class AdmStudRepo : DbOperation<AdmStud>, IAdmStudRepo
    {

        private readonly SchoolDbContext _db;


        public AdmStudRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<AdmStud>> GetAllStud()
        {
            return await _db.AdmStuds.Include(r => r.Parent).ToListAsync();
        }

        public object GetParentName(int id)
        {
            //return  _db.AdmStuds.Where(x => x.ParentId == id).Include(r => r.Parent).FirstOrDefault();
            var _tourPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.TourPrice);
            var _classPrice = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.ClassPrice);
            var _descount = _db.AdmStuds.Where(x => x.ParentId == id).Sum(x => x.DescountValue);
            var _totalPrice = _tourPrice + _classPrice;
            var _netTotal = _tourPrice + _classPrice - _descount;

            var parent = _db.RegParents.Where(x => x.Id == id).Select(p => new
            {
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
                ParentTotalDescount = _descount,
                ParentTotalPrice = _totalPrice,
                ParentNetTotalAmt = _netTotal

            });//.FirstOrDefault() ;

            return parent;
        }

        public async Task<IEnumerable<object>> GetRegChildrens(int id)
        {
            var CurrentYear = _db.LkpYears.Where(p => p.Active == 1).Select(x => x.Id).FirstOrDefault();
            var data = _db.AdmStuds.Where(p => p.ParentId == id && p.YearId==CurrentYear ).Select(x => new
            {
                x.Id,
                x.FirstName,
                x.BirthDate,
                x.GenderId,
                x.YearId,
                GenderName = x.Gender != null ? x.Gender.AName : string.Empty,
                ClassName = x.Class != null ? x.Class.Aname : string.Empty,
                ClassPrice = x.Class != null ? x.Class.Amt : 0,
                ClassYear = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Id : 0 : 0,
                ClassActive = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Active : 0 : 0,
                ClassSeqName = x.ClassSeq != null ? x.ClassSeq.AName : string.Empty,
                TourName = x.Tour != null ? x.Tour.Tour.AName : string.Empty,
                TourTypeName = x.TourType != null ? x.TourType.AName : string.Empty,
                TourPrice = x.TourType != null ? int.Parse(x.TourType.Value) == 3 ?
                x.Tour.TourFullPrice : x.Tour.TourHalfPrice : 0,
                x.StudentBrotherSeq,
                x.DescountValue
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
                x.StudentBrotherSeq,
                x.DescountValue,
                TotalPrice = x.ClassPrice + x.TourPrice - x.DescountValue

            }).OrderBy(p => p.StudentBrotherSeq);


            return result;

        }
        public async Task<IEnumerable<object>> GetRegChildrensBySchool(int id, int SchoolId)
        {
            var CurrentYear = _db.LkpYears.Where(p => p.Active == 1).Select(x => x.Id).FirstOrDefault();
            var data = _db.AdmStuds.Where(p => p.ParentId == id && p.YearId == CurrentYear && p.SchoolId==SchoolId).Select(x => new
            {
                x.Id,
                x.FirstName,
                x.BirthDate,
                x.GenderId,
                x.YearId,
                GenderName = x.Gender != null ? x.Gender.AName : string.Empty,
                ClassName = x.Class != null ? x.Class.Aname : string.Empty,
                ClassPrice = x.ClassPrice,
                ClassYear = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Id : 0 : 0,
                ClassActive = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Active : 0 : 0,
                ClassSeqName = x.ClassSeq != null ? x.ClassSeq.AName : string.Empty,
                TourName = x.Tour != null ? x.Tour.Tour.AName : string.Empty,
                TourTypeName = x.TourType != null ? x.TourType.AName : string.Empty,
                TourPrice = x.TourType != null ? int.Parse(x.TourType.Value) == 3 ?
                x.Tour.TourFullPrice : x.Tour.TourHalfPrice : 0,
                x.StudentBrotherSeq,
                x.DescountValue
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
                x.StudentBrotherSeq,
                x.DescountValue,
                TotalPrice = x.ClassPrice + x.TourPrice - x.DescountValue

            }).OrderBy(p => p.StudentBrotherSeq);


            return result;

        }
        public async Task<List<AdmStud>> GetStudByParent(int id)
        {
           
            return await _db.AdmStuds.Where(x => x.ParentId == id ).Include(r => r.Parent).ToListAsync();
        }

        public async Task<List<AdmStud>> GetStudByParentAndSchool(int id, int schoolId)
        {

            return await _db.AdmStuds.Where(x => x.ParentId == id && x.SchoolId==schoolId).Include(r => r.Parent).ToListAsync();
        }
        

        public void UpdateStudSeq(int id)
        {
            var data = _db.AdmStuds.Where(p => p.ParentId == id)
                .OrderBy(x => x.BirthDate)
                .ToList();
            var CountData = data.Count();
            System.Diagnostics.Debug.WriteLine("CountData=" + CountData);

            //----------------------------------------------------------------------------
            //youngest brother get 50%  (classPrice=1500=>Discount=750)
            //younger brother get 25% (classPrice=4000 => Discount=1000)
            //old brother get 10%    (classPrice=5000 => Discount=500)
            //-----------------------------------------------------------------------
            System.Diagnostics.Debug.WriteLine("begin");
            var i = 0;
            if (CountData > 1)
                data.ForEach(x =>
                {
                    i = i + 1;
                    var studId = x.Id;
                    var price = x.ClassPrice;// + (x.TourPrice ?? 0);
                    double descount = 0;
                    if (i == 1) descount = price * 0.10;
                    if (i == 2) descount = price * 0.15;
                    if (i == 3) descount = price * 0.20;
                    if (i == 4) descount = price * 0.25;
                    if (i == 5) descount = price * 0.30;
                    if (i >= 6) descount = price * 0.30;

                    x.StudentBrotherSeq = i;
                    x.DescountValue = descount;
                    DbSet.Update(x);
                    System.Diagnostics.Debug.WriteLine("counter=" + i + "  studId=" + studId + "  price=" + price + "  descount=" + descount);
                });
            // _db.SaveChanges();

        }
    }
}
