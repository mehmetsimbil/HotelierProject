using HotelProject.Entities.Dto_s.AboutDto;

namespace HotelProject.Business.Responses.About
{
    public class GetAboutListResponse
    {
        public ICollection<AboutListItemDto> Items { get; set; }
        public GetAboutListResponse()
        {
            Items = Array.Empty<AboutListItemDto>();
        }

        public GetAboutListResponse(ICollection<AboutListItemDto> items)
        {
            Items = items;
        }
    }
}
