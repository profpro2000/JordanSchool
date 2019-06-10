using AutoMapper;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Reg;
using Model.AddLookups;
using Model.Lookups;
using Model.Reg;

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
            CreateMap<LkpDocument, LkpDocumentVw>().ReverseMap();


            //============Stud Mapping================
            CreateMap<RegParent, RegParentVw>().ReverseMap();
            CreateMap<RegStud, RegStudVw>().ReverseMap();



        }
    }
}
