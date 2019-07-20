﻿using AutoMapper;
using Domain.Model.AddLookups;
using Domain.Model.Adm;
using Domain.Model.Financial;
using Domain.Model.Lookups;
using Domain.Model.Reg;
using Domain.Model.Users;
using Model.AddLookups;
using Model.Adm;
using Model.Financial;
using Model.Lookups;
using Model.Reg;
using Model.Users;

namespace School.ServiceLayer.MappingConfigs
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            //=========== Users ===============
            CreateMap<Users, UsersVw>().ReverseMap();
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
            CreateMap<LkpYear, LkpYearVw>().ReverseMap();
            //============Stud Mapping================
            CreateMap<RegParent, RegParentVw>().ReverseMap();
            CreateMap<RegStud, RegStudVw>().ReverseMap();
            //=========== Stud Admission
            CreateMap<AdmStud, AdmStudVw>().ReverseMap();


            //==============Financial==================
            CreateMap<FinItem, FinItemVw>().ReverseMap();
            CreateMap<SchoolFee, SchoolFeeVw>().ReverseMap();
            CreateMap<ClassFee, ClassFeeVw>().ReverseMap();
            CreateMap<StudentFee, StudentFeeVw>().ReverseMap();



        }
    }
}
