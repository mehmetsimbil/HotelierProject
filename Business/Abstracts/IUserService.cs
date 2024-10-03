using HotelProject.Business.Requests.User;
using HotelProject.Business.Responses.User;

namespace HotelProject.Business.Abstracts
{
    public interface IUserService
    {
        public AddUserResponse Add(AddUserRequest request);
        public GetUserListResponse GetList(GetUserListRequest request);
        public DeleteUserResponse Delete(DeleteUserRequest request);
        public UpdateUserResponse Update(UpdateUserRequest request);
    }
}
