using AutoMapper;
using Full.Server.DTO;
using Full.Shared;

namespace Full.Server.AutomapperProfile
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
