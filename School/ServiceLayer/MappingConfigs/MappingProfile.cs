using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Stud;
using Model.AddLookups;
using Model.Lookups;
using Model.Stud;

namespace School.ServiceLayer.MappingConfigs
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
           
            //=============Lookups ===============
            CreateMap<LkpItemCalendar, LkpItemCalendarVw>().ReverseMap();
            CreateMap<LkpCalendar, LkpCalendarVw>().ReverseMap();
            CreateMap<LkpLookupType, LkpLookupTypeVw>().ReverseMap();
            CreateMap<LkpLookup, LkpLookupVw>().ReverseMap();
            CreateMap<LkpSchool, LkpSchoolVw>().ReverseMap();
            CreateMap<LkpSection, LkpSectionVw>().ReverseMap();
            CreateMap<LkpTour, LkpTourVw>().ReverseMap();
            CreateMap<LkpBus, LkpBusVw>().ReverseMap();
            CreateMap<LkpClass, LkpClassVw>().ReverseMap();
            //============Stud Mapping================
            CreateMap<StudParent, StudParentVw>().ReverseMap();
            CreateMap<StudMaster, StudMasterVw>().ReverseMap();

        }
    }
}
