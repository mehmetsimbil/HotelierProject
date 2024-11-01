using HotelProject.Entities.Abstract;

namespace HotelProject.Entities.Concrete
{
    public class About : Entity<int>
    {
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
        public bool IsActive { get; set; }
    }
}
