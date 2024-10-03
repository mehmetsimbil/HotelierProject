using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class WorkLocation : Entity<int>
    {
        public string? WorkLocationName { get; set; }
        public string? WorkLocationCity { get; set; }
        public List<User>? Users { get; set; }
    }
}
