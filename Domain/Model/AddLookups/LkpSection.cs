﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.Stud;

namespace Domain.Model.AddLookups
{
 public   class LkpSection:AuditModel
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int ManagerId { get; set; }
        public string Email { get; set; }
        public  string NationalId { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }

        public ICollection<LkpClass> LkpClasses { get; set; }
        [IgnoreDataMember] public ICollection<StudMaster> SectionStudMasters { get; set; }
    }
}