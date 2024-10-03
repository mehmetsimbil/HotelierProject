using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Staff : Entity<int>
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Github { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }
    }
}
