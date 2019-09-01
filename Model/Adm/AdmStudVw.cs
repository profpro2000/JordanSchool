using Domain.Model;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Reg;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Model.Adm
{
    public class AdmStudVw : AuditModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int ParentId { get; set; }
        [IgnoreDataMember] public RegParent Parent { get; set; }
        public string FatherFirstName { get { return Parent != null  ? Parent.FirstName: ""; } }
        public string FatherSecondName { get { return Parent != null ? Parent.SecondName : ""; } }
        public string FatherFamilyName { get { return Parent != null ? Parent.FamilyName : ""; } }
        public string FatherFullName { get {return Parent !=null ? /*FirstName+" "+*/Parent.FirstName + " " + Parent.SecondName + " " + Parent.FamilyName :""; } }
        public string StudFullName { get { return FirstName + " " + FatherFullName; } }
        public int? StudNo { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }
        public int SectionId { get; set; }
        public LkpSection LkpSection { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? NationalityId { get; set; }
        public LkpLookup Nationality { get; set; }
        public int? ReligionId { get; set; }
        public LkpLookup Religion { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderId { get; set; }
        public LkpLookup Gender { get; set; }
        public int? YearId { get; set; }
        public LkpLookup Years { get; set; }
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
        public string BusNote { get; set; }
        public string Note { get; set; }
        public double DescountValue { get; set; } //New 25/07/2019


        //// We merge AdmStud with RegStud

        public int? IdNum { get; set; }
        public string FirstLName { get; set; }
        public string StudMobile { get; set; }
        public string PreviousSchool { get; set; }
        public int? JoinYearId { get; set; } // Lookup  --1
        public LkpLookup JoinYearLookup { get; set; }
        public int? JoinTermId { get; set; }// Lookup --2
        public LkpLookup JoinTermLookup { get; set; }
        public string Image { get; set; }// must change to blob
        public string Email { get; set; }
        public string StudFace { get; set; }
        public int? StudBrotherSeq { get; set; }
        public int? StudHealthId { get; set; }//Lookup --3
        public LkpLookup StudHealthLookup { get; set; }
        public string DiseaseName { get; set; }
        public string MedicamentName { get; set; }

    }
}
