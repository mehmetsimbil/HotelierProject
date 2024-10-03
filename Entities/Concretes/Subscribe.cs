using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class Subscribe : Entity<int>
    {
        public string? Mail { get; set; }
    }
}
