using AutoMapper;
using LeaveManagementSystem.web.Data;
using LeaveManagementSystem.web.Models.LeaveTypes;

namespace LeaveManagementSystem.web.MappingProfiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() {
            CreateMap<LeaveType, LeaveTypeReadOnlyViewModel>();
            //.ForMember(dest => dest.Days, val => val.MapFrom(src => src.NumberOfDays));
            CreateMap<LeaveTypeCreateViewModel, LeaveType>();

            CreateMap<LeaveTypeEditViewModel, LeaveType>().ReverseMap();
        }
    }
}
