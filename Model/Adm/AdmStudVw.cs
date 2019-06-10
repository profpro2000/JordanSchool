using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Adm
{
    public class AdmStudVw
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int StudNo { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime BirthDate { set; get; }

        public int SchoolId { get; set; }
     ///   public LkpSchool LkpSchool { get; set; }


        public int SectionId { get; set; }
      //  public LkpSection LkpSection { get; set; }



        public int ReligionId { get; set; }
      //  public LkpLookup ReligionLookup { get; set; }


        public int NationalityId { set; get; }
        //public LkpLookup NationalityLookup { set; get; }


        public int GenderId { set; get; }
      //  public LkpLookup GenderLookup { set; get; }


        public int YearId { set; get; }// is it from lookup?

       // public LkpLookup YearLookup { set; get; }

        public int ClassId { set; get; }
        //public LkpClass ClassLookup { set; get; }


        public int SequenceId { set; get; }

     //   public LkpLookup SequenceLookup { set; get; }


        public int BusId { set; get; }
      //  public LkpBus BusLookup { set; get; }



        public int TourId { set; get; }
      //  public LkpTour TourLookup { set; get; }


        public int IsApproved { set; get; }

        public DateTime? ApproveDate { set; get; }

        public int StudentBrotherSeq { set; get; }

        public int DiscountTypeId { set; get; }

      //  public LkpLookup DiscountLookup { set; get; }

        public string BusNotes { set; get; }
        public string Notes { set; get; }



    }
}
