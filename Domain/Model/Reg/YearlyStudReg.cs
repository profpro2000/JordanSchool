using Domain.Model.AddLookups;
using Domain.Model.Adm;
using Domain.Model.Lookups;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Reg
{
    public class YearlyStudReg
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public RegParent Parent { get; set; }
        public int? AdmId { get; set; }
        [NotMapped] public AdmStud AdmStuds { get; set; }
        public int? StudStatusId { get; set; }
        public LkpLookup StudStatus { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }
        public int SectionId { get; set; }
        public LkpSection LkpSection { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? YearId { get; set; }
        public LkpLookup Years { get; set; }
        public int? JoinTermId { get; set; }// Lookup --2
        public LkpLookup JoinTermLookup { get; set; }
        public int? ClassId { get; set; }
        public LkpClass Class { get; set; }
        public int ClassPrice { get; set; }
        public int? ClassSeqId { get; set; }
        public LkpLookup ClassSeq { get; set; }
        public int? TourId { get; set; }
        public LkpTour Tour { get; set; }
        public int? TourTypeId { get; set; }
        public LkpLookup TourType { get; set; }
        public int? BusId { get; set; }
        public LkpBus Bus { get; set; }
        public int? TourPrice { get; set; }
        public int? ApprovedId { get; set; }
        public LkpLookup Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? StudentBrotherSeq { get; set; }
        public int? BrotherDescountType { get; set; }
        public decimal DescountValue { get; set; } //New 25/07/2019
        public string BusNote { get; set; }
        public string Note { get; set; }
    }
}
