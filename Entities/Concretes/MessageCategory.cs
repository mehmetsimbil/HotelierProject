using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class MessageCategory : Entity<int>
    {
        public string? MessageCategoryName { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
