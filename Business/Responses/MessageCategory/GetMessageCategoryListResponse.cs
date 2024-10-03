using HotelProject.Entities.Dto_s.MessageCategoryDto;

namespace HotelProject.Business.Responses.MessageCategory
{
    public class GetMessageCategoryListResponse
    {
        public ICollection<MessageCategoryListItemDto> Items { get; set; }
    }
}
