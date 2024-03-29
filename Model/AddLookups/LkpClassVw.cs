﻿using System.Runtime.Serialization;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;

namespace Model.AddLookups
{
    public class LkpClassVw
    {
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
      //  public int Amt { get; set; }
        public int Capacity { get; set; }
        public float Age { get; set; }
        public int SchoolId { get; set; }
      
        public int SectionId { get; set; }
        public string SectionName { get { return LkpSection != null ? LkpSection.SectionName : "";  } }
      [IgnoreDataMember]  public LkpSection LkpSection { get; set; }
       
        public int? YearId { get; set; }
       public int Amt { get; set; }
        public int? ClassGender { get; set; } //0=All, 1=Male, 2=Female
    }
}