using HotelProject.Entities.Concrete;

namespace HotelProject.Entities.Dto_s.UserDto
{
    public class UserListItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public string? WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public WorkLocation? WorkLocation { get; set; }
    }
}
