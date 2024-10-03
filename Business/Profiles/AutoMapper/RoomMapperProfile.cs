using AutoMapper;
using HotelProject.Business.Requests.Room;
using HotelProject.Business.Responses.Room;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.RoomDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class RoomMapperProfile : Profile
    {
        public RoomMapperProfile()
        {
            CreateMap<AddRoomRequest, Room>();
            CreateMap<Room,AddRoomResponse>();
            CreateMap<Room, RoomLıstItemDto>();
            CreateMap<IList<Room>,GetRoomListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src)); 
            CreateMap<UpdateRoomRequest, Room>();
            CreateMap< Room,UpdateRoomResponse > ();
            CreateMap<Room,DeleteRoomResponse> ();

        }
    }
}
