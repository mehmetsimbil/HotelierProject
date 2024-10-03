using HotelProject.Entities.Concrete;

namespace HotelProject.Entities.Dto_s.ContactDto
{
    public class ContactListItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int MessageCategoryID { get; set; }
        public MessageCategory? MessageCategory { get; set; }
    }
}
