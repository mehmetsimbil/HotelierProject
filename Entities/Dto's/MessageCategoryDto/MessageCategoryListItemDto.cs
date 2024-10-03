using HotelProject.Entities.Concrete;

namespace HotelProject.Entities.Dto_s.MessageCategoryDto
{
    public class MessageCategoryListItemDto
    {
        public int Id { get; set; }
        public string? MessageCategoryName { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
