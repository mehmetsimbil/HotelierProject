using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Service : Entity<int>
    {
        public string? Title { get; set; }
        public string? Icon { get; set; }
        public string? Description { get; set; }

    }
}
