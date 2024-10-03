using AutoMapper;
using HotelProject.Business.Requests.WorkLocation;
using HotelProject.Business.Responses.WorkLocation;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.WorkLocationDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class WorkLocationMapperProfile : Profile
    {
        public WorkLocationMapperProfile()
        {
            CreateMap<AddWorkLocationRequest, WorkLocation>();
            CreateMap<WorkLocation, AddWorkLocationResponse>();

            CreateMap<WorkLocation, WorkLocationListItemDto>();
            CreateMap<IList<WorkLocation>, GetWorkLocationListResponse>();

            CreateMap<UpdateWorkLocationRequest, WorkLocation>();
            CreateMap<WorkLocation, UpdateWorkLocationResponse>();

            CreateMap<WorkLocation, DeleteWorkLocationResponse>();
        }
    }
}
