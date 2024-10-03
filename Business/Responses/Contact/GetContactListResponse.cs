using HotelProject.Entities.Dto_s.ContactDto;

namespace HotelProject.Business.Responses.Contact
{
    public class GetContactListResponse
    {
        public ICollection<ContactListItemDto> Items { get; set; }
    }
}
