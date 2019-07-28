﻿using Core.IRegRepo;
using Domain;
using Domain.Model.Reg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistence.RegRepo
{
 public   class YearlyStudRegRepo : DbOperation<YearlyStudReg>, IYearlyStudRegRepo
    {
        private SchoolDbContext _db;
        private double descount = 0;
       

        public YearlyStudRegRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
           
        }

        // public List<String> Strings { get; set; }
        public async Task<IEnumerable<object>> GetParentChildrens(int id)
        {

            var yearObj = _db.LkpYears.FirstOrDefault(x => x.Active == 1);
            var yearId = yearObj?.Id;

            var Students = _db.AdmStuds.Where(p => p.ParentId == id)!=null?_db.AdmStuds.Where(p => p.ParentId == id).Select(x => new { x.Id, x.FirstName }).ToList():null;
            IList<xYearlyStudReg> studentList = new List<xYearlyStudReg>();

            Students.ForEach(
                dd => {
                    //int xStudents = dd.Id;
                    var xStudents = 0;
                    try
                    {
                         xStudents = _db.YearlyStudRegs.Where(p => p.AdmId == dd.Id) != null ? _db.YearlyStudRegs.Where(p => p.AdmId == dd.Id).Max(c => c.Id) : 0;
                        System.Diagnostics.Debug.WriteLine("b-----------------------------------------xx=" + xStudents);
                    }
                    catch(Exception e){
                        xStudents = 0;
                    }
                    // var StudExist = _db.YearlyStudRegs.Where(p => p.Id == xStudents).Count();

                    // if (StudExist > 0) return;
                    if (xStudents > 0)
                    {
                        var data = _db.YearlyStudRegs.Where(p => p.Id == xStudents).Select(x => new xYearlyStudReg()
                        {
                            Id = x.Id,
                            AdmId = x.AdmId,
                            ParentId = x.ParentId,
                            FirstName = _db.AdmStuds.Where(c => c.Id == x.AdmId).Select(g => g.FirstName).FirstOrDefault(),
                            BirthDate = x.BirthDate,
                            YearId = x.YearId,
                            ClassName = x.Class != null ? x.Class.Aname : string.Empty,
                            ClassPrice = x.Class != null ? x.Class.Amt : 0,
                            ClassYear = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Id : 0 : 0,
                            ClassActive = x.Class != null ? x.Class.YearsLookup != null ? x.Class.YearsLookup.Active : 0 : 0,
                            ClassSeqName = x.ClassSeq != null ? x.ClassSeq.AName : string.Empty,
                            TourName = x.Tour != null ? x.Tour.TourName : string.Empty,
                            TourTypeName = x.TourType != null ? x.TourType.AName : string.Empty,
                            TourPrice = x.TourType != null ? int.Parse(x.TourType.Value) == 3 ?
                            x.Tour.TourFullPrice : x.Tour.TourHalfPrice : 0,
                            StudentBrotherSeq = x.StudentBrotherSeq,
                            DescountValue = x.DescountValue,
                            SchoolId = x.SchoolId,
                            ClassSeq = x.Class.ClassSeq,
                            ClassId = x.ClassId,
                            NewClass = x.ApprovedId == 1 && x.YearId == yearId ? x.ClassId :
                                      x.YearId == yearId ? x.ClassId :
                            (_db.LkpClasses.Where(c => c.ClassSeq == x.Class.ClassSeq + 1 && c.SchoolId == x.SchoolId).FirstOrDefault() != null ?
                                    _db.LkpClasses.Where(c => c.ClassSeq == x.Class.ClassSeq + 1 && c.SchoolId == x.SchoolId).Select(get => get.Id).FirstOrDefault() : 0),
                            ApprovedId = x.ApprovedId == 1 && x.YearId == yearId ? x.ApprovedId :
                                      x.YearId == yearId ? x.ApprovedId : null,

                            // newClass = _db.LkpClasses.Where(c=>c.Id)


                        }).FirstOrDefault();//.Where(p=>p.ClassActive == 1) ;
                        studentList.Add(data);
                    }//if
                }) ;

            studentList.ToList().ForEach(xx=>{

                System.Diagnostics.Debug.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  Id="+xx.Id+"      AdmId="+xx.AdmId);

            });
            var result = studentList.Select(x => new
            {
                x.Id,
                AdmId = x.AdmId,
                x.FirstName,
                x.BirthDate,
                x.YearId,
                x.ClassName,
                ClassPrice =  _db.LkpClasses.Where(px => px.Id == x.NewClass)!=null? _db.LkpClasses.Where(px => px.Id == x.NewClass).Select(pz => pz.Amt).FirstOrDefault():0,
                x.ClassYear,
                x.ClassActive,
                x.ClassSeqName,
                x.TourName,
                x.TourTypeName,
                x.TourPrice,
                x.StudentBrotherSeq,
                x.DescountValue,
                TotalPrice = x.ClassPrice + x.TourPrice - x.DescountValue,
                x.SchoolId,
                x.ClassSeq,
                x.ClassId,
                NewClassId = x.NewClass,
                NewClassName = x.NewClass != 0 ? _db.LkpClasses.Where(p => p.Id == x.NewClass).Select(p => p.Aname).FirstOrDefault() : "",
                StudExist = _db.YearlyStudRegs.Where(p => p.AdmId == x.AdmId && p.YearId == x.YearId).Count(),
                x.ApprovedId,

            }).OrderBy(p => p.AdmId);
            return result;
        }

       

        public  int ConfirmStudReg(int id, int PYearId,int oldClassId, int newClassId)
        {

            System.Diagnostics.Debug.WriteLine("-----****************-----==-------   id=" + id+ "   PYearId="+ PYearId+ "   oldClassId="+ oldClassId+ "   newClassId="+ newClassId);
            
            var StudExist = _db.YearlyStudRegs.Where(p => p.AdmId == _db.YearlyStudRegs.FirstOrDefault(x=>x.Id==id).AdmId && p.YearId== PYearId).Count();
            var ClassNotConfirm=_db.YearlyStudRegs.Where(p => p.AdmId == _db.YearlyStudRegs.FirstOrDefault(x => x.Id == id).AdmId && p.ClassId == oldClassId && p.YearId==PYearId).Count();

            if (ClassNotConfirm > 0) { ConfirmExistClass(id); return 1; }

            if (StudExist>1) return 0;
            if (newClassId == 0) return 0;
            
            
                
            var data = _db.YearlyStudRegs.Where(p => p.Id == id).Select(x =>
          new //YearlyStudReg()
          {
              Id = x.Id,
              AdmId = x.AdmId,
              SchoolId = x.SchoolId,
              SectionId = x.SectionId,
              ClassId = newClassId,
              ClassPrice =
              _db.LkpClasses.Where(k1 => k1.Id == newClassId)
                         .Select(k11 => k11.Amt).FirstOrDefault(),
              ParentId = x.ParentId,
              StudStatusId = _db.LkpLookups.Where(k => k.TypeId == 42).Select(k => k.Id).FirstOrDefault(), // Student Status = Register = 1
              BirthDate = x.BirthDate,
              YearId = PYearId,
              JoinTermId = x.JoinTermId,
              ClassSeqId = x.ClassSeqId,
              TourId = x.TourId,
              TourTypeId = x.TourTypeId,
              BusId = x.BusId,
              TourPrice = x.TourPrice,
              ApprovedId = 1, //1=Approved  0 or null not approved
              ApprovedDate = DateTime.Now,
              StudentBrotherSeq = x.StudentBrotherSeq != null ? x.StudentBrotherSeq : 0,
              BrotherDescountType = x.BrotherDescountType,
              DescountValue = x.DescountValue

          }) ;//.FirstOrDefault();

            int xStudentBrotherSeq = (int)data.Select(x=>x.StudentBrotherSeq).FirstOrDefault();
            int xClassPrice = (int)data.Select(x => x.ClassPrice).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine("---------------xStudentBrotherSeq="+ xStudentBrotherSeq+ "  xClassPrice="+ xClassPrice);
            CalcStudDescount(id, xStudentBrotherSeq, xClassPrice);
            
            var data2 = data.Select(x =>
             new YearlyStudReg()
             {
                AdmId = x.AdmId,
                SchoolId = x.SchoolId,
                SectionId = x.SectionId,
                ClassId = x.ClassId,
                ClassPrice =x.ClassPrice,
                ParentId = x.ParentId,
                StudStatusId = x.StudStatusId,
                BirthDate = x.BirthDate,
                YearId = x.YearId,
                JoinTermId = x.JoinTermId,
                ClassSeqId = x.ClassSeqId,
                TourId = x.TourId,
                TourTypeId = x.TourTypeId,
                BusId = x.BusId,
                TourPrice = x.TourPrice,
                ApprovedId = x.ApprovedId,
                ApprovedDate = x.ApprovedDate,
                StudentBrotherSeq = x.StudentBrotherSeq ,
                BrotherDescountType = x.BrotherDescountType,
                DescountValue = descount

             }).FirstOrDefault();

            DbSet.Add(data2);

            // Calc student descounts
            var ParentId = _db.YearlyStudRegs.Where(p => p.Id == id).Select(p => p.ParentId).FirstOrDefault();
            UpdateStudSeq(ParentId);

            return 1;

 
        }

        public void ConfirmExistClass(int id)
        {
            var data = _db.YearlyStudRegs.Where(p => p.Id == id).ToList();
            System.Diagnostics.Debug.WriteLine("----------==-------   id=" + id);           
                data.ForEach(x =>
                {
                    x.ApprovedId = 1;
                    x.ApprovedDate = DateTime.Now;
                    DbSet.Update(x);
                });
        }

        public void CalcStudDescount(int studId, int? i, int price)
        {
            descount = 0;
            if (i == 1) descount = price * 0.50;
            if (i == 2) descount = price * 0.25;
            if (i >= 3) descount = price * 0.10;
            //return descount;
        }

        public void UpdateStudSeq(int id)
        {
            var data = _db.YearlyStudRegs.Where(p => p.ParentId == id)
                .OrderByDescending(x => x.BirthDate)
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
                    var price = x.ClassPrice + (x.TourPrice ?? 0);
                    double descount = 0;
                    if (i == 1) descount = price * 0.50;
                    if (i == 2) descount = price * 0.25;
                    if (i >= 3) descount = price * 0.10;

                    x.StudentBrotherSeq = i;
                    x.DescountValue = descount;
                    DbSet.Update(x);
                    System.Diagnostics.Debug.WriteLine("counter=" + i + "  studId=" + studId + "  price=" + price + "  descount=" + descount);
                });
            // _db.SaveChanges();

        }

        
    }
    public class xYearlyStudReg
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public RegParent Parent { get; set; }
        public int? AdmId { get; set; }
        public string FirstName { get; set; }
         public DateTime? BirthDate { get; set; }
        public int? YearId { get; set; }
        public string ClassName { get; set; }
        public int ClassPrice { get; set; }
        public int ClassYear { get; set; }
    public int? ClassActive { get; set; }
      public string ClassSeqName { get; set; }
       public string TourName { get; set; }
       public string TourTypeName { get; set; }
       public int TourPrice { get; set; }
        public int? StudentBrotherSeq { get; set; }
       public double DescountValue { get; set; }
       public int SchoolId { get; set; }
       public int? ClassSeq { get; set; }
       public int? ClassId { get; set; }
       public int? NewClass { get; set; }
        public int? ApprovedId { get; set; }
    }
    }
