using HotelProject.Entities.Concrete;

namespace HotelProject.Entities.Dto_s.WorkLocationDto
{
    public class WorkLocationListItemDto
    {
        public int Id { get; set; }
        public string? WorkLocationName { get; set; }
        public string? WorkLocationCity { get; set; }
        public List<User>? Users { get; set; }
    }
}
