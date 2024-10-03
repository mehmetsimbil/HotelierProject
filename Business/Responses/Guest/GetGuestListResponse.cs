using HotelProject.Entities.Dto_s.GuestDto;

namespace HotelProject.Business.Responses.Guest
{
    public class GetGuestListResponse
    {
        public ICollection<GuestListItemDto> Items { get; set; }
    }
}
