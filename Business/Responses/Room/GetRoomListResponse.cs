using HotelProject.Entities.Dto_s.RoomDto;

namespace HotelProject.Business.Responses.Room
{
    public class GetRoomListResponse
    {
        public ICollection<RoomLıstItemDto> Items { get; set; }
    }
}
