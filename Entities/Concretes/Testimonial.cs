using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Testimonial : Entity<int>
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
      
    }
}
