using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Lookups
{
  public  class LkpLookupType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<LkpLookup> LkpLookups { get; set; }
    }
}
