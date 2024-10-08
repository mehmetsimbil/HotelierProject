using AutoMapper;
using Business.Requests.User;
using Business.Responses.User;
using DataAccess.UnitOfWork;
using HotelProject.Business.Abstracts;
using HotelProject.Business.Requests.User;
using HotelProject.Business.Responses.User;
using HotelProject.Entities.Concrete;


namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public AddUserResponse Add(AddUserRequest request)
        {
            var userToAdd = _mapper.Map<User>(request);
            User addedUser = _unitOfWork.UserDal.Add(userToAdd);
            var response = _mapper.Map<AddUserResponse>(addedUser);
            _unitOfWork.Save();
            return response;
        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            User? userToDelete = _unitOfWork.UserDal.Get(predicate: u=> u.Id == request.Id);
            if (userToDelete == null)
            {
                throw new KeyNotFoundException($"No About found with ID {request.Id}");
            }


            userToDelete.IsDeleted = true;
            User deletedUser = _unitOfWork.UserDal.Delete(userToDelete!);
            var response = _mapper.Map<DeleteUserResponse>(deletedUser);
            _unitOfWork.Save();
            return response;
        }

        public GetUserByIdResponse GetById(GetUserByIdRequest request)
        {
            User? user = _unitOfWork.UserDal.Get(predicate: u=>u.Id == request.Id);
            var response = _mapper.Map<GetUserByIdResponse>(user);
            return response;
        }

        public GetUserListResponse GetList(GetUserListRequest request)
        {
            IList<User> users = _unitOfWork.UserDal.GetList();
            GetUserListResponse response = _mapper.Map<GetUserListResponse>(users);
            return response;
        }

        public UpdateUserResponse Update(UpdateUserRequest request)
        {
            User? userToUpdate = _unitOfWork.UserDal.Get(predicate: a => a.Id == request.Id);
            userToUpdate = _mapper.Map(request, userToUpdate);
            User updateduser = _unitOfWork.UserDal.Update(userToUpdate!);
            var response = _mapper.Map<UpdateUserResponse>(updateduser);
            _unitOfWork.Save();
            return response;
        }
    }
}
