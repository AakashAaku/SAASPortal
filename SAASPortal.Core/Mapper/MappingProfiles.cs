using AutoMapper;
using SAASPortal.Core.DTOs;
using SAASPortal.Core.Models;

namespace SAASPortal.Core.Mapper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Assignment, AssignmentDto>().ReverseMap();
            CreateMap<Assessment, AssessmentDto>().ReverseMap();

            //CreateMap<Assignment, AssignmentDto>()
            //.ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Title));
        }
    }
}
