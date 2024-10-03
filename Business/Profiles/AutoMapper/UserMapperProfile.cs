using AutoMapper;
using HotelProject.Business.Requests.User;
using HotelProject.Business.Responses.User;
using HotelProject.Entities.Concrete;
using HotelProject.Entities.Dto_s.UserDto;

namespace HotelProject.Business.Profiles.AutoMapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User,AddUserResponse>();

            CreateMap<User,UserListItemDto>();
            CreateMap<IList<User>,GetUserListResponse>();

            CreateMap<UpdateUserRequest, User>();
            CreateMap<User,UpdateUserResponse>();

            CreateMap<User, DeleteUserResponse>();
        }
    }
}
