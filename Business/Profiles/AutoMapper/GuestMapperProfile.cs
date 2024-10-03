using AutoMapper;
using HotelProject.Business.Requests.Guest;
using HotelProject.Business.Responses.Guest;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.GuestDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class GuestMapperProfile : Profile
    {
        public GuestMapperProfile()
        {
            CreateMap<AddGuestRequest, Guest>();
            CreateMap<Guest,AddGuestResponse>();
            CreateMap<Guest,GuestListItemDto>();
            CreateMap<IList<Guest>,GetGuestListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<UpdateGuestRequest, Guest>();
            CreateMap<Guest,UpdateGuestResponse>();
            CreateMap<Guest,DeleteGuestResponse>();
        }
    }
}
