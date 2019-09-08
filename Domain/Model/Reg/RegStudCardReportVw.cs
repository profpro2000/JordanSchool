using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Reg
{
   public class RegStudCardReportVw
    {
        public int StudId { get; set; }
        public int ParentId { get; set; }       
        public string StudName { get; set; }
        public string StudLName { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? NationalityId { get; set; }
        public string NationalityName { get; set; }
        public int? ReligionId { get; set; }
        public string ReligionName { get; set; }
        public int? GenderId { get; set; }
        public string GenderName { get; set; }
        public int? YearId { get; set; }   
        public string YearName { get; set; }
        public int? ClassId { get; set; }//
        public string ClassName { get; set; }
        public int ClassPrice { get; set; }
        public int? ClassSeqId { get; set; }
        public string ClassSeqName { get; set; }
        public int? TourId { get; set; }
        public int? TourTypeId { get; set; }
        public int? BusId { get; set; }
        public string BusNo { get; set; }
        public int? TourPrice { get; set; }
        public decimal? DescountValue { get; set; } 
        public DateTime? approvedDate { get; set; }
        public int? IdNum { get; set; }
        public string StudStatusName { get; set; }
        public string Tel { get; set; }
        public string FatherMobile { get; set; }
        public string MotherMobile { get; set; }
        public string SmsParentName { get; set; }
        public string TourTypeIdName { get; set; }
        public string BusNote { get; set; }
        public int? StudentBrotherValue { get; set; }
        public string StudentBrotherDescountType { get; set; }
        public decimal? TotalValue { get; set; }
        public int? RegFees { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string StudMobile { get; set; }
        public string BirthPlace { get; set; }
        public string ParentWork { get; set; }
        public int? JoinYearId { get; set; }


    }
}
