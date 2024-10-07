using AutoMapper;
using Business.Responses.Staff;
using HotelProject.Business.Requests.Staff;
using HotelProject.Business.Responses.Staff;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.StaffDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class StaffMapperProfile : Profile
    {
        public StaffMapperProfile()
        {
            CreateMap<AddStaffRequest, Staff>();
            CreateMap<Staff,AddStaffResponse>();
            CreateMap<Staff,StaffListItemDto>();
            CreateMap<IList<Staff>,GetStaffListResponse>();
            CreateMap<UpdateStaffRequest, Staff>();
            CreateMap<Staff, UpdateStaffResponse>();
            CreateMap<Staff, DeleteStaffResponse>();
            CreateMap<Staff,GetStaffByIdResponse>();
        }
    }
}
