using AutoMapper;
using HotelProject.Business.Requests.Subscribe;
using HotelProject.Business.Responses.Subscribe;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.SubscribeDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class SubscribeMapperProfile : Profile
    {
        public SubscribeMapperProfile()
        {
            CreateMap<AddSubscribeRequest, Subscribe>();
            CreateMap<Subscribe, AddSubscribeResponse>();

            CreateMap<Subscribe,SubscribeListItemDto>();
            CreateMap<IList<Subscribe>,GetSubscribeListResponse>();

            CreateMap<UpdateSubscribeRequest, Subscribe>();
            CreateMap<Subscribe, UpdateSubscribeResponse>();

            CreateMap<Subscribe,DeleteSubscribeResponse>();
        }
    }
}
