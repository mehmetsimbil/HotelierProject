using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Guest : Entity<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
    }
}
