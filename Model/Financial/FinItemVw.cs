using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
  public  class FinItemVw
    {
        public int Id { set; get; }
        public string ArDesc { set; get; }
        public string LaDesc { set; get; }
        public string CDType { set; get; }// debit or redit اضافة او خصم
        public string VPType { set; get; }//  percentage or value
    }
}
