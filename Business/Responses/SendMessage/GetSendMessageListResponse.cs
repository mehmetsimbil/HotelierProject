using HotelProject.Entities.Dto_s.SendMessageDto;

namespace HotelProject.Business.Responses.SendMessage
{
    public class GetSendMessageListResponse
    {
        public ICollection<SendMessageListItemDto> Items { get; set; }
    }
}
