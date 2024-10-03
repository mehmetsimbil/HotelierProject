using HotelProject.Entities.Dto_s.UserDto;

namespace HotelProject.Business.Responses.User
{
    public class GetUserListResponse
    {
        public ICollection<UserListItemDto> Items { get; set; }
    }
}
