using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model;

namespace Model.Lookups
{
 public   class LkpLookupVw
    {

        public int Id { get; set; }
        public string Aname { get; set; }
        public  string Lname { get; set; }
        public string Value { get; set; }
        public int ParentId { get; set; }
        public int TypeId { get; set; }
     

    }
}
