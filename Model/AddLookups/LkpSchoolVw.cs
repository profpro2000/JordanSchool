using System.Collections.Generic;

namespace Model.AddLookups
{
  public   class LkpSchoolVw
    {

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string WebPage { get; set; }
        public string FaceBook { get; set; }
        public ICollection<LkpSectionVw> LkpSections { get; set; }

    }
}
