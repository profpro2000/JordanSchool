using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Model.Lookups;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Model.Lookups;

namespace Model.AddLookups
{
  public   class LkpSchoolVw
    {

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
        public int CityId { get; set; }
        //   [Label("NIdNo")]
        //[Display(Name = "City")]
        [Display(Name = "City")]
      [IgnoreDataMember]  public LkpLookupVw CitesLookup { get; set; }
        public string City { get { return CitesLookup != null ? CitesLookup.Aname : ""; } set { } }
             
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string WebPage { get; set; }
        public string FaceBook { get; set; }
        [IgnoreDataMember] public ICollection<LkpSectionVw> LkpSections { get; set; }

    }
}
