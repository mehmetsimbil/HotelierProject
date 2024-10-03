using HotelProject.Entities.Dto_s.SubscribeDto;

namespace HotelProject.Business.Responses.Subscribe
{
    public class GetSubscribeListResponse
    {
        public ICollection<SubscribeListItemDto> Items { get; set; }
    }
}
