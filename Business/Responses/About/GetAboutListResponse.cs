using HotelProject.Entities.Dto_s.AboutDto;

namespace HotelProject.Business.Responses.About
{
    public class GetAboutListResponse
    {
        public ICollection<AboutListItemDto> Items { get; set; }
    }
}
