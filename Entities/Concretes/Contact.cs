using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Contact : Entity<int>
    {
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public int MessageCategoryID { get; set; }
        public MessageCategory? MessageCategory { get; set; }
    }
}
