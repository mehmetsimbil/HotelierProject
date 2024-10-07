using AutoMapper;
using Business.Responses.Service;
using HotelProject.Business.Requests.Service;
using HotelProject.Business.Responses.Service;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.ServiceDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            CreateMap<AddServiceRequest, Service>();
            CreateMap<Service, AddServiceResponse>();
            CreateMap<Service, ServiceListItemDto>();
            CreateMap<IList<Service>,GetServiceListResponse>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<UpdateServiceRequest, Service>();
            CreateMap<Service,UpdateServiceResponse>();
            CreateMap<Service, DeleteServiceResponse>();
            CreateMap<Service,GetServiceByIdResponse>();
        }
    }
}
